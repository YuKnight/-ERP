Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.Library.ProductionKaiLiaoReturn
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.WareHouse
Imports LFERP.DataSetting

Public Class frmProductionKaiLiaoReturn
#Region "定義"
    Dim ds As New DataSet

    Dim LoadRQty As Double ''本單載入的還刀數

    Private _EditItem As String
    Private _EditValue As String
    Private _EditID As String
    Public Property EditItem() As String
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
    Public Property EditValue() As String
        Get
            Return _EditValue
        End Get
        Set(ByVal value As String)
            _EditValue = value
        End Set
    End Property
    Public Property EditID() As String
        Get
            Return _EditID
        End Get
        Set(ByVal value As String)
            _EditID = value
        End Set
    End Property

#End Region

    Private Sub frmProductionKaiLiaoReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        ''暫時默認

        txtWH.Tag = "W0301"
        txtWH.Text = "五金倉"


        Select Case EditItem
            Case "Add"
                DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                XtraTabPage2.PageVisible = False

                ''載入默認部門
                Dim ui As New List(Of UserPowerInfo)
                Dim uc As New UserPowerControl
                ui = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

                If ui.Count = 0 Then
                    Exit Sub
                Else
                    GluDep.EditValue = ui(0).DepID
                End If

            Case "Update"
                LoadData(EditValue)
                XtraTabPage2.PageVisible = False
            Case "View"
                cmdSave.Visible = False
                LoadData(EditValue)
                XtraTabPage2.PageVisible = False
            Case "Check"
                LoadData(EditValue)
                Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
                XtraTabPage2.PageVisible = True
        End Select

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case EditItem
            Case "Add"
                SaveData()

            Case "Update"
                SaveUpdate()

            Case "Check"
                SaveCheck()
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("KaiLiaoReturn")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

            .Columns.Add("C_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))  '重量
            .Columns.Add("M_Unit", GetType(String))

            .Columns.Add("RQty", GetType(Double))
            .Columns.Add("KailiaoAutoID", GetType(String)) ''開料單流水號

            .Columns.Add("CQty", GetType(Double)) '開料數
            .Columns.Add("RQtyAll", GetType(Double)) '已退料數
            .Columns.Add("KaiLiaoAll", GetType(Double)) '已開料數(生產)
            .Columns.Add("RCAllow", GetType(Double)) '可退料數


        End With
        Grid.DataSource = ds.Tables("KaiLiaoReturn")

        With ds.Tables.Add("DelKaiLiaoReturn")
            .Columns.Add("AutoID", GetType(String))
        End With

        Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
        GluDep.Properties.DataSource = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        GluDep.Properties.DisplayMember = "DepName"
        GluDep.Properties.ValueMember = "DepID"
    End Sub


    Function GetR_NO() As String
        '生成新pm
        Dim pm As New ProductionKaiLiaoReturnControl
        Dim pi As New ProductionKaiLiaoReturnInfo
        Dim ndate As String
        ndate = "RC" + Format(Now(), "yyMM")
        pi = pm.ProductionKaiLiaoReturn_GetNO(ndate)
        If pi Is Nothing Then
            GetR_NO = ndate + "00001"
        Else
            GetR_NO = ndate + Mid((CInt(Mid(pi.R_NO, 7)) + 100001), 2)
        End If
    End Function

    Sub SaveData()
        If CheckDate() = True Then
        Else
            Exit Sub
        End If

        txtRCNO.Text = GetR_NO()

        If txtRCNO.Text = "" Then
            MsgBox("獲取單號失敗!")
            Exit Sub
        End If
        '----------------------------------------------------------------------
        Dim prc As New ProductionKaiLiaoReturnControl
        Dim pri As New ProductionKaiLiaoReturnInfo

        pri.R_NO = txtRCNO.Text
        pri.WH_ID = txtWH.Tag
        pri.RC_Dep = GluDep.EditValue
        pri.RC_Action = txtAction.Text
        pri.RDate = Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd")
        pri.RRemark = txtRemark.Text

        pri.RAction = InUserID

        Dim m As Integer

        For m = 0 To ds.Tables("KaiLiaoReturn").Rows.Count - 1
            pri.C_NO = ds.Tables("KaiLiaoReturn").Rows(m)("C_NO").ToString
            pri.M_Code = ds.Tables("KaiLiaoReturn").Rows(m)("M_Code").ToString
            pri.RQty = ds.Tables("KaiLiaoReturn").Rows(m)("RQty")

            pri.PM_Type = ds.Tables("KaiLiaoReturn").Rows(m)("PM_Type").ToString
            pri.PM_M_Code = ds.Tables("KaiLiaoReturn").Rows(m)("PM_M_Code").ToString
            pri.Pro_Type = ds.Tables("KaiLiaoReturn").Rows(m)("Pro_Type").ToString

            pri.KailiaoAutoID = ds.Tables("KaiLiaoReturn").Rows(m)("KailiaoAutoID").ToString

            If prc.ProductionKaiLiaoReturn_Add(pri) = False Then
                MsgBox("數據保存失敗,請檢查!")
                Exit Sub
            End If
        Next

        MsgBox("保存成功!")
        Me.Close()

    End Sub


    Sub SaveUpdate()
        If CheckDate() = True Then
        Else
            Exit Sub
        End If

        ''刪除已增加的記錄---------------------------
        Dim poc As New ProductionKaiLiaoReturnControl
        Dim j As Integer
        If ds.Tables("DelKaiLiaoReturn").Rows.Count > 0 Then
            For j = 0 To ds.Tables("DelKaiLiaoReturn").Rows.Count - 1
                poc.ProductionKaiLiaoReturn_Delete(ds.Tables("DelKaiLiaoReturn").Rows(j)("AutoID"), Nothing)
            Next
        End If
        '------------------------------------------------------------------

        Dim prc As New ProductionKaiLiaoReturnControl
        Dim pri As New ProductionKaiLiaoReturnInfo

        pri.R_NO = txtRCNO.Text
        pri.WH_ID = txtWH.Tag
        pri.RC_Dep = GluDep.EditValue
        pri.RC_Action = txtAction.Text
        pri.RDate = Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd")
        pri.RRemark = txtRemark.Text

        pri.RAction = InUserID

        Dim m As Integer

        For m = 0 To ds.Tables("KaiLiaoReturn").Rows.Count - 1
            pri.C_NO = ds.Tables("KaiLiaoReturn").Rows(m)("C_NO").ToString
            pri.M_Code = ds.Tables("KaiLiaoReturn").Rows(m)("M_Code").ToString
            pri.RQty = ds.Tables("KaiLiaoReturn").Rows(m)("RQty")

            pri.PM_Type = ds.Tables("KaiLiaoReturn").Rows(m)("PM_Type").ToString
            pri.PM_M_Code = ds.Tables("KaiLiaoReturn").Rows(m)("PM_M_Code").ToString
            pri.Pro_Type = ds.Tables("KaiLiaoReturn").Rows(m)("Pro_Type").ToString

            pri.KailiaoAutoID = ds.Tables("KaiLiaoReturn").Rows(m)("KailiaoAutoID").ToString

            If IsDBNull(ds.Tables("KaiLiaoReturn").Rows(m)("AutoID")) = True Then
                If prc.ProductionKaiLiaoReturn_Add(pri) = False Then
                    MsgBox("數據保存失敗,請檢查!")
                End If
            Else
                pri.AutoID = ds.Tables("KaiLiaoReturn").Rows(m)("AutoID").ToString
                If prc.ProductionKaiLiaoReturn_Update(pri) = False Then
                    MsgBox("數據保存失敗,請檢查!")
                End If
            End If
        Next

        MsgBox("保存成功!")
        Me.Close()
    End Sub

    Sub SaveCheck()
        Dim prc As New ProductionKaiLiaoReturnControl
        Dim pri As New ProductionKaiLiaoReturnInfo

        pri.R_NO = txtRCNO.Text
        pri.RCheck = CheckEdit1.Checked
        pri.RCheckAction = InUserID
        pri.RCheckDate = Format(Now, "yyyy/MM/dd")
        pri.RCheckRemark = txtCheckRemark.Text

        If prc.ProductionKaiLiaoReturn_Check(pri) = True Then
            If CheckEdit1.Checked = True Then
                MsgBox("審核成功!")
            Else
                MsgBox("取消審核成功!")
            End If
        End If

        Me.Close()
    End Sub

    Function CheckDate() As Boolean
        CheckDate = True
        If txtWH.Text = "" Then
            MsgBox("退料倉不能為空!")
            txtWH.Select()
            CheckDate = False
            Exit Function
        End If

        If GluDep.EditValue = "" Then
            MsgBox("退料倉不能為空!")
            GluDep.Select()
            CheckDate = False
            Exit Function
        End If

        If ds.Tables("KaiLiaoReturn").Rows.Count <= 0 Then
            MsgBox("當前無數據保存!")
            CheckDate = True
            Exit Function
        End If

        '----------------------------
        Dim k As Integer
        For k = 0 To ds.Tables("KaiLiaoReturn").Rows.Count - 1
            If IsDBNull(ds.Tables("KaiLiaoReturn").Rows(k)("M_Code")) = True Then
                CheckDate = False
                MsgBox("物料編號不能為空!")
                Exit Function
            End If

            If IsDBNull(ds.Tables("KaiLiaoReturn").Rows(k)("RQty")) = True Then
                CheckDate = False
                MsgBox("數量不能為空!")
                Exit Function
            End If

            If ds.Tables("KaiLiaoReturn").Rows(k)("RQty") <= 0 Then
                CheckDate = False
                MsgBox("退料數量不能小於0!")
                Exit Function
            End If

            '先只加這一層判斷
            If ds.Tables("KaiLiaoReturn").Rows(k)("RQty") > ds.Tables("KaiLiaoReturn").Rows(k)("CQty") Then
                CheckDate = False
                MsgBox("退料數量不能大於開料數量!")
                Exit Function
            End If


            Dim DoubleT1 As Double
            Dim DoubleT2 As Double
            DoubleT1 = GetKL_ActualWeight(ds.Tables("KaiLiaoReturn").Rows(k)("C_NO"), ds.Tables("KaiLiaoReturn").Rows(k)("M_Code"))
            DoubleT2 = GetRCAllow(ds.Tables("KaiLiaoReturn").Rows(k)("KailiaoAutoID"))

            If EditItem = "Add" Then  ''Update  ''Check 
                If ds.Tables("KaiLiaoReturn").Rows(k)("RQty") > ds.Tables("KaiLiaoReturn").Rows(k)("CQty") - DoubleT1 - DoubleT2 Then '可退料數
                    CheckDate = False
                    MsgBox(ds.Tables("KaiLiaoReturn").Rows(k)("M_Code") & "可退料數不足!")
                    Exit Function
                End If
            ElseIf EditItem = "Update" Or (EditItem = "Check" And CheckEdit1.Checked = True) Then  ''Update  ''Check 去本條記錄
                If ds.Tables("KaiLiaoReturn").Rows(k)("RQty") > ds.Tables("KaiLiaoReturn").Rows(k)("CQty") - DoubleT1 - DoubleT2 + LoadRQty Then '可退料數
                    CheckDate = False
                    MsgBox(ds.Tables("KaiLiaoReturn").Rows(k)("M_Code") & "可退料數不足!")
                    Exit Function
                End If
            End If

        Next


    End Function

    Sub LoadData(ByVal R_NO As String)
        Dim PL As New List(Of ProductionKaiLiaoReturnInfo)
        Dim PC As New ProductionKaiLiaoReturnControl
        PL = PC.ProductionKaiLiaoReturn_GetList(Nothing, R_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If PL.Count <= 0 Then
            MsgBox("無數據存在！")
            Exit Sub
        End If

        txtRCNO.Text = PL(0).R_NO
        txtWH.Tag = PL(0).WH_ID
        txtWH.Text = PL(0).WH_Name

        GluDep.EditValue = PL(0).RC_Dep
        txtAction.Text = PL(0).RC_Action
        DateEdit1.EditValue = Format(CDate(PL(0).RDate), "yyyy/MM/dd")

        txtRemark.Text = PL(0).RRemark

        Labaction.Text = PL(0).RActionName

        Dim j As Integer
        For j = 0 To PL.Count - 1
            Dim row As DataRow
            row = ds.Tables("KaiLiaoReturn").NewRow
            row("AutoID") = PL(j).AutoID

            row("KailiaoAutoID") = PL(j).KailiaoAutoID
            row("PM_M_Code") = PL(j).PM_M_Code
            row("PM_Type") = PL(j).PM_Type
            row("M_Gauge") = PL(j).M_Gauge
            row("M_Code") = PL(j).M_Code
            row("M_Unit") = PL(j).M_Unit
            row("RQty") = PL(j).RQty

            LoadRQty = PL(j).RQty

            row("M_Name") = PL(j).M_Name
            row("Pro_Type") = PL(j).Pro_Type
            row("C_NO") = PL(j).C_NO


            Dim DoubleT1 As Double
            Dim DoubleT2 As Double
            Dim DoubleT3 As Double
            DoubleT1 = GetKL_ActualWeight(PL(j).C_NO, PL(j).M_Code)
            DoubleT2 = GetRCAllow(PL(j).KailiaoAutoID)

            Dim PCC As New ProductionKaiLiaoControl
            Dim PLL As New List(Of ProductionKaiLiaoInfo)
            PLL = PCC.ProductionKaiLiao_GetListIndexNo(PL(j).KailiaoAutoID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If PLL.Count <= 0 Then
                DoubleT3 = 0
            Else
                DoubleT3 = PLL(0).C_Weight
            End If

            row("CQty") = DoubleT3

            row("RQtyAll") = DoubleT2 '已退料數
            row("KaiLiaoAll") = DoubleT1 '已開料數(生產)
            row("RCAllow") = DoubleT3 - DoubleT1 - DoubleT2 + PL(j).RQty '可退料數

            ds.Tables("KaiLiaoReturn").Rows.Add(row)
        Next

        CheckEdit1.EditValue = PL(0).RCheck
        txtCheckAction.Text = PL(0).RCheckActionName
        txtCheckRemark.Text = PL(0).RCheckRemark


    End Sub

    Private Sub cmsCodeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeAdd.Click
        frmProductionKaiLiaoReturnLoad.ShowDialog()

        If tempValue <> "" Then
        Else
            Exit Sub
        End If

        Dim i, n As Integer
        Dim arr(n) As String
        arr = Split(tempValue, ",")
        n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)
        For i = 0 To n
            If arr(i) = "" Then
                Exit Sub
            End If
            AddRow(arr(i))
        Next

        frmProductionKaiLiaoReturnLoad.Dispose()

    End Sub

    Sub AddRow(ByVal strAutoID As String)
        If strAutoID = "" Then
            Exit Sub
        End If

        Dim pil As New List(Of ProductionKaiLiaoInfo)
        Dim pic As New ProductionKaiLiaoControl
        pil = pic.ProductionKaiLiao_GetListIndexNo(strAutoID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pil.Count > 0 Then

            Dim i As Integer
            For i = 0 To ds.Tables("KaiLiaoReturn").Rows.Count - 1
                If strAutoID = ds.Tables("KaiLiaoReturn").Rows(i)("KailiaoAutoID") Then
                    MsgBox("一張單不允許有重復開料單號....")
                    Exit Sub
                End If

                If pil(0).M_Code = ds.Tables("KaiLiaoReturn").Rows(i)("M_Code") Then
                    MsgBox("一張單不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next


            Dim row As DataRow
            row = ds.Tables("KaiLiaoReturn").NewRow
            row("Pro_Type") = pil(0).Pro_Type
            row("PM_M_Code") = pil(0).PM_M_Code
            row("PM_Type") = pil(0).PM_Type
            row("M_Gauge") = pil(0).M_Gauge
            row("M_Code") = pil(0).M_Code
            row("M_Name") = pil(0).M_Name
            row("M_Unit") = pil(0).M_Unit
            row("KailiaoAutoID") = strAutoID
            row("C_NO") = pil(0).C_NO
            row("RQty") = 0
            row("CQty") = pil(0).C_Weight

            Dim DoubleT1 As Double
            Dim DoubleT2 As Double
            DoubleT1 = GetKL_ActualWeight(pil(0).C_NO, pil(0).M_Code)
            DoubleT2 = GetRCAllow(strAutoID)
            row("RQtyAll") = DoubleT2 '已退料數
            row("KaiLiaoAll") = DoubleT1 '已開料數(生產)
            row("RCAllow") = pil(0).C_Weight - DoubleT1 - DoubleT2 '可退料數


            ds.Tables("KaiLiaoReturn").Rows.Add(row)
            GridView1.MoveLast()
        End If

    End Sub

    Private Sub cmsCodeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeDel.Click
        If ds.Tables("KaiLiaoReturn").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelKaiLiaoReturn").NewRow
            row("AutoID") = DelTemp
            ds.Tables("DelKaiLiaoReturn").Rows.Add(row)
        End If
        ds.Tables("KaiLiaoReturn").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub


    Private Sub txtWH_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick

        tempValue3 = "880206" '與開料的倉相同
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID <> "" Then
            Dim strWHID As String
            strWHID = frmWareHouseSelect.SelectWareID

            Dim wi As New List(Of WareHouseInfo)
            Dim wc As New WareHouseController

            Dim strWHID1 As String
            strWHID1 = Mid(strWHID, 1, 3)
            wi = wc.WareHouse_Get(strWHID1)

            txtWH.Text = wi(0).WH_Name & "-" & frmWareHouseSelect.SelectWareName
            txtWH.Tag = strWHID
        Else
            Exit Sub
        End If
    End Sub

    ''取得已開料數(生產)

    Function GetKL_ActualWeight(ByVal C_NO As String, ByVal M_Code As String) As Double
        Dim klc As New ProductionKaiLiaoControl
        Dim kll As New List(Of ProductionKaiLiaoInfo)

        kll = klc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, C_NO, M_Code, Nothing, Nothing, Nothing, Nothing)

        If kll.Count <= 0 Then
            GetKL_ActualWeight = 0
        Else
            GetKL_ActualWeight = kll(0).KL_ActualWeight
        End If
    End Function


    ''取得已退料數
    Function GetRCAllow(ByVal AutoID As String) As Double
        Dim klc As New ProductionKaiLiaoReturnControl
        Dim kll As New List(Of ProductionKaiLiaoReturnInfo)

        kll = klc.ProductionKaiLiaoReturn_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, AutoID, Nothing, Nothing, Nothing, Nothing)

        If kll.Count <= 0 Then
            GetRCAllow = 0
        Else
            GetRCAllow = kll(0).RQty
        End If
    End Function





End Class