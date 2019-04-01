Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProuctionWareOutA
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.ProductionSchedule



Public Class ProductionWareOutSubA
    Dim ds As New DataSet
    Dim dc As New DepartmentControler
    Dim strFac, strDep As String
    Dim strWHOutID, strWHInID As String
    Dim oldCheck, oldInCheck As Boolean

    Dim upi As New List(Of UserPowerInfo)
    Dim upc As New UserPowerControl
    Dim pic As New ProductInventoryController

    Private Sub ProductionWareOutSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label5.Text = tempValue2
        Label3.Text = tempValue3
        tempValue2 = ""
        tempValue3 = ""

        CreateTable()

        txtWIPID.Enabled = False
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")

        'Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
        'GluDep.Properties.DataSource = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        'GluDep.Properties.DisplayMember = "DepName"
        'GluDep.Properties.ValueMember = "DepID"

        Select Case Label5.Text
            Case "出貨單"
                If Edit = False Then
                    Me.Text = "出貨單--新增"

                    upi = upc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)
                    'GluDep.EditValue = upi(0).DepID
                    'GluDep.Enabled = False
                    strDep = upi(0).DepID

               

                    'If Mid(upi(0).DepID, 1, 1) = "A" Then
                    '    strWHInID = "W0901"  '第一裝配倉
                    '    txtWHIn.Text = "第一裝配倉"
                    'ElseIf Mid(upi(0).DepID, 1, 1) = "B" Then
                    '    strWHInID = "W0902"  '第二裝配倉
                    '    txtWHIn.Text = "第二裝配倉"
                    'ElseIf Mid(upi(0).DepID, 1, 1) = "C" Then
                    '    strWHInID = "W0921" '裝配倉(成品)
                    '    txtWHIn.Text = "裝配倉(成品)"
                    'End If

                    cbType.EditValue = upi(0).UserType
                    cbType.Enabled = False

                Else
                    txtWIPID.Text = Label3.Text
                    LoadData(Label3.Text)
                    CheckEdit1.Enabled = False
                    CheckRemark.Enabled = False
                    Me.Text = "出貨單--修改" & Label3.Text
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                XtraTabPage2.PageVisible = False
            Case "PreView"
                Me.Text = "出貨單--查看" & Label3.Text
                LoadData(Label3.Text)
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                Me.Text = "出貨單--審核" & Label3.Text

                txtWH.Enabled = False
                txtWHIn.Enabled = False
                'GluDep.Enabled = False
                cbType.Enabled = False
                DateEdit1.Enabled = False
                txtRemark.Enabled = False
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

                LoadData(Label3.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
            Case "InCheck"
                Me.Text = "出貨單--收貨確認" & Label3.Text
                txtWHIn.Enabled = False
                txtWH.Enabled = False
                'GluDep.Enabled = False
                cbType.Enabled = False
                DateEdit1.Enabled = False
                txtRemark.Enabled = False
                XtraTabPage2.PageVisible = False
                CheckEdit3.Enabled = True

                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

                LoadData(Label3.Text)
                'XtraTabControl1.SelectedTabPage = XtraTabPage2
        End Select

        cmdGuideAdd.Visible = False

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("ProductionWareOutSub")

            .Columns.Add("PWO_SubNO", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("PWO_Qty", GetType(Integer))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PWO_SubType", GetType(String))
            .Columns.Add("PWO_SubRemark", GetType(String))

            .Columns.Add("PM_Type", GetType(String)) '2012-7-20
            .Columns.Add("PM_JiYu", GetType(String)) '機玉
            .Columns.Add("PI_Qty", GetType(Integer))    '@ 2012/10/4

        End With
        Grid.DataSource = ds.Tables("ProductionWareOutSub")

        With ds.Tables.Add("DelProductionWareOutSub")

            .Columns.Add("PWO_NO", GetType(String))
            .Columns.Add("PWO_SubNO", GetType(String))

        End With

    End Sub

    Public Function LoadData(ByVal PWO_NO As String) As Boolean
        LoadData = True

        ds.Tables("ProductionWareOutSub").Clear()

        Dim piL As List(Of ProductionWareOutAInfo)
        Dim pc As New ProductionWareOutAControl
        Dim pii As List(Of ProductInventoryInfo)

        piL = pc.ProductionWareOutA_GetList(PWO_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Try
            If piL.Count = 0 Then
                MsgBox("沒有數據")
                LoadData = False
                Exit Function
            Else
                strWHOutID = piL(0).PWO_WareID
                txtWIPID.Text = piL(0).PWO_NO
                txtWH.EditValue = piL(0).PWO_OutName

                txtWHIn.EditValue = piL(0).PWO_InName
                strWHInID = piL(0).PWO_InWareID

                'GluDep.EditValue = piL(0).PWO_DepID
                cbType.EditValue = piL(0).PWO_Type
                DateEdit1.EditValue = piL(0).PWO_AddDate
                txtRemark.Text = piL(0).PWO_Remark

                CheckEdit1.Checked = piL(0).PWO_Check
                If CheckEdit1.Checked = True Then
                    oldCheck = True
                Else
                    oldCheck = False
                End If

                CheckEdit3.Checked = piL(0).PWO_InCheck
                If CheckEdit3.Checked = True Then
                    oldInCheck = True
                Else
                    oldInCheck = False
                End If

                CheckDate.Text = piL(0).PWO_CheckDate
                CheckAction.Text = piL(0).PWO_CheckActionName
                CheckRemark.Text = piL(0).PWO_CheckRemark

                Dim i As Integer
                Dim row As DataRow
                For i = 0 To piL.Count - 1

                    row = ds.Tables("ProductionWareOutSub").NewRow

                    row("PWO_SubNO") = piL(i).PWO_SubNO
                    row("PM_M_Code") = piL(i).PM_M_Code
                    row("M_Code") = piL(i).M_Code
                    row("M_Name") = piL(i).M_Name
                    row("M_Gauge") = piL(i).M_Gauge
                    row("M_Unit") = piL(i).M_Unit
                    row("PWO_Qty") = piL(i).PWO_Qty
                    row("PWO_SubType") = piL(i).PWO_SubType
                    row("PWO_SubRemark") = piL(i).PWO_SubRemark

                    '2012-7-20 保証以前的數據
                    If piL(i).PM_Type <> "" Then
                        row("PM_Type") = piL(i).PM_Type
                    Else
                        row("PM_Type") = LoadProductionType(cbType.EditValue, piL(i).PM_M_Code, piL(i).M_Code)
                    End If

                    row("PM_JiYu") = piL(i).PM_JiYu

                    '@ 2012/10/4 添加 顯示庫存
                    pii = pic.ProductInventory_GetList(piL(i).PM_M_Code, piL(i).M_Code, strWHOutID, Nothing)
                    If pii.Count > 0 Then
                        row("PI_Qty") = pii(0).PI_Qty
                    Else
                        row("PI_Qty") = 0
                    End If

                    ds.Tables("ProductionWareOutSub").Rows.Add(row)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function GetNO() As String
        Dim pi As New ProductionWareOutAInfo
        Dim pc As New ProductionWareOutAControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionWareOutA_GetNo(strA)

        If pi Is Nothing Then
            GetNO = "PWO" & strA & "0001"
        Else
            GetNO = "PWO" + strA + Mid((CInt(Mid(pi.PWO_NO, 8)) + 10001), 2)
        End If
    End Function

    Private Function GetSubNO() As String
        Dim pi As New ProductionWareOutAInfo
        Dim pc As New ProductionWareOutAControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionWareOutA_GetSubNO(strA)
        If pi Is Nothing Then
            GetSubNO = "PSub" & strA & "0001"
        Else
            GetSubNO = "PSub" + strA + Mid((CInt(Mid(pi.PWO_SubNO, 9)) + 10001), 2)
        End If

    End Function
    Sub DataNew()
        Dim pi As New ProductionWareOutAInfo
        Dim pc As New ProductionWareOutAControl

        txtWIPID.Text = GetNO()

        pi.PWO_NO = txtWIPID.Text
        pi.PWO_WareID = strWHOutID
        pi.PWO_InWareID = strWHInID
        'pi.PWO_DepID = GluDep.EditValue
        pi.PWO_DepID = strDep
        pi.PWO_Type = cbType.EditValue
        pi.PWO_AddDate = DateEdit1.Text
        pi.PWO_Remark = txtRemark.Text
        pi.PWO_Action = InUserID


        Dim i As Integer

        For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
            pi.PWO_SubNO = GetSubNO()

            pi.PM_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code")

            pi.PWO_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")) Then
                pi.PWO_Qty = 0
            Else
                pi.PWO_Qty = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")
            End If
            If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")) Then
                pi.PWO_SubType = Nothing
            Else
                pi.PWO_SubType = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")
            End If

            If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")) Then
                pi.PWO_SubRemark = Nothing
            Else
                pi.PWO_SubRemark = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")
            End If
            '2012-7-20
            If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")) Then
                pi.PM_Type = Nothing
            Else
                pi.PM_Type = ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")
            End If
            pc.ProductionWareOutA_Add(pi)
        Next

        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()

    End Sub

    Sub DataEdit()

        Dim i As Integer

        '更新刪除的記錄
        If ds.Tables("DelProductionWareOutSub").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelProductionWareOutSub").Rows.Count - 1

                Dim pc As New ProductionWareOutAControl

                If Not IsDBNull(ds.Tables("DelProductionWareOutSub").Rows(j)("PWO_SubNO")) Then
                    pc.ProductionWareOutA_Delete(ds.Tables("DelProductionWareOutSub").Rows(j)("PWO_NO"), ds.Tables("DelProductionWareOutSub").Rows(j)("PWO_SubNO"))
                End If
            Next j
        End If

        For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1



            If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubNO")) Then

                Dim pi As New ProductionWareOutAInfo
                Dim pc As New ProductionWareOutAControl

                pi.PWO_NO = txtWIPID.Text
                pi.PWO_WareID = strWHOutID
                pi.PWO_InWareID = strWHInID

                'pi.PWO_DepID = GluDep.EditValue
                pi.PWO_DepID = strDep

                pi.PWO_Type = cbType.EditValue
                pi.PWO_AddDate = DateEdit1.Text
                pi.PWO_Remark = txtRemark.Text
                pi.PWO_Action = InUserID

                pi.PWO_SubNO = GetSubNO()
                pi.PM_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code")

                pi.PWO_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")) Then
                    pi.PWO_Qty = 0
                Else
                    pi.PWO_Qty = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")
                End If

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")) Then
                    pi.PWO_SubType = Nothing
                Else
                    pi.PWO_SubType = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")
                End If

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")) Then
                    pi.PWO_SubRemark = Nothing
                Else
                    pi.PWO_SubRemark = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")
                End If

                '2012-7-20
                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")) Then
                    pi.PM_Type = Nothing
                Else
                    pi.PM_Type = ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")
                End If

                pc.ProductionWareOutA_Add(pi)

            ElseIf Not IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubNO")) Then


                Dim pi As New ProductionWareOutAInfo
                Dim pc As New ProductionWareOutAControl

                pi.PWO_NO = txtWIPID.Text
                pi.PWO_WareID = strWHOutID
                pi.PWO_InWareID = strWHInID
                'pi.PWO_DepID = GluDep.EditValue
                pi.PWO_Type = cbType.EditValue
                pi.PWO_AddDate = DateEdit1.Text
                pi.PWO_Remark = txtRemark.Text
                pi.PWO_Action = InUserID

                pi.PWO_SubNO = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubNO")
                pi.PM_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code")
                pi.PWO_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")) Then
                    pi.PWO_Qty = 0
                Else
                    pi.PWO_Qty = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")
                End If

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")) Then
                    pi.PWO_SubType = Nothing
                Else
                    pi.PWO_SubType = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubType")
                End If

                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")) Then
                    pi.PWO_SubRemark = Nothing
                Else
                    pi.PWO_SubRemark = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_SubRemark")
                End If

                '2012-7-20
                If IsDBNull(ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")) Then
                    pi.PM_Type = Nothing
                Else
                    pi.PM_Type = ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type")
                End If

                pc.ProductionWareOutA_Update(pi)

            End If
        Next

        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()
    End Sub

    Sub UpdateCheck()

        Dim pi As New ProductionWareOutAInfo
        Dim pc As New ProductionWareOutAControl

        If oldCheck = CheckEdit1.Checked Then
            MsgBox("審核狀態未改變，請更改狀態後再保存……")
            Exit Sub
        End If

        pi.PWO_NO = txtWIPID.Text
        pi.PWO_Check = CheckEdit1.Checked
        pi.PWO_CheckAction = InUserID
        pi.PWO_CheckDate = Format(Now, "yyyy/MM/dd")
        pi.PWO_CheckRemark = CheckRemark.Text

        If pc.ProductionWareOutA_UpdateCheck(pi) = True Then
            MsgBox("審核狀態已改變!")
        Else
            MsgBox("審核失敗,請檢查原因!")
            Exit Sub
        End If

        '--------------------------------------------------------------------------出貨記錄扣數信息
        '--------------------------------------------------------------------------
        '''''''''''''李超新增
        Dim fcon As New FacControler
        Dim flist As New List(Of FacInfo)
        flist = fcon.GetFacListA(Nothing, Nothing, strWHOutID)
        If flist.Count > 0 Then
            strFac = flist(0).FacID
        End If

        'Dim strFac As String
        '' strFac = Mid(GluDep.EditValue, 1, 1)
        'If strWHOutID = "W0801" Then
        '    strFac = "A"
        'ElseIf strWHOutID = "W0802" Then
        '    strFac = "B"
        'ElseIf strWHOutID = "W0803" Then
        '    strFac = "C"
        'End If




        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim psi1 As List(Of ProductionScheduleInfo)

        Dim j As Integer

        For j = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1

            psi1 = psc.ProductionSchedule_GetList1(Nothing, cbType.EditValue, ds.Tables("ProductionWareOutSub").Rows(j)("PM_M_Code"), ds.Tables("ProductionWareOutSub").Rows(j)("M_Code"), strFac, Nothing, DateEdit1.Text, DateEdit1.Text, ds.Tables("ProductionWareOutSub").Rows(j)("PM_Type"))

            If psi1.Count = 0 Then

            Else

                Dim m As Single

                m = psi1(0).PS_ActualNumber

                psi.PS_NO = psi1(0).PS_NO '得到當前單號
                psi.Pro_Type = cbType.EditValue
                psi.PM_M_Code = psi1(0).PM_M_Code

                psi.PM_Type = psi1(0).PM_Type
                psi.PS_Dep = strFac
                psi.PS_Date = CDate(DateEdit1.Text)

                If CheckEdit1.Checked = True Then
                    psi.PS_ActualNumber = m + CSng(ds.Tables("ProductionWareOutSub").Rows(j)("PWO_Qty"))
                Else
                    psi.PS_ActualNumber = m - CSng(ds.Tables("ProductionWareOutSub").Rows(j)("PWO_Qty"))
                End If

                psc.ProductionSchedule_UpdateActualNumber(psi)

            End If
        Next
        Me.Close()
    End Sub


    Sub UpdateInCheck()

        Dim pi As New ProductionWareOutAInfo
        Dim pc As New ProductionWareOutAControl

        If oldInCheck = CheckEdit3.Checked Then
            MsgBox("收貨確認未改變，請更改狀態後再保存……")
            Exit Sub
        End If


        pi.PWO_NO = txtWIPID.Text
        pi.PWO_InCheck = CheckEdit3.Checked
        pi.PWO_InAction = InUserID
        pi.PWO_InAddDate = Format(Now, "yyyy/MM/dd")

        If pc.ProductionWareOutA_UpdateInCheck(pi) = True Then
            MsgBox("收貨確認已改變!")
        Else
            MsgBox("收貨確認,請檢查原因!")
            Exit Sub
        End If

        '----------------出貨扣賬處理----------------------------------------
        Dim i%
        Dim pii As New ProductInventoryInfo
        pii.WH_ID = strWHOutID

        For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
            Dim piiGet As List(Of ProductInventoryInfo)

            piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString, strWHOutID, Nothing)
            If CheckEdit3.Checked = True Then
                pii.PI_Qty = piiGet(0).PI_Qty - CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
            ElseIf CheckEdit3.Checked = False Then
                pii.PI_Qty = piiGet(0).PI_Qty + CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
            End If

            pii.PM_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString
            pii.M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString

            If pic.ProductInventory_Update(pii) = False Then
                MsgBox("出貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If
        Next

        '----------------收貨扣賬處理----------------------------------------
        Dim piinfo As New ProductInventoryInfo
        piinfo.WH_ID = strWHInID

        For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
            Dim piiGet As List(Of ProductInventoryInfo)

            piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString, strWHInID, Nothing)

            If CheckEdit3.Checked = True Then
                If piiGet.Count = 0 Then
                    piinfo.PI_Qty = CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
                Else
                    piinfo.PI_Qty = piiGet(0).PI_Qty + CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
                End If
            ElseIf CheckEdit3.Checked = False Then
                If piiGet.Count = 0 Then
                    piinfo.PI_Qty = 0 - CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
                Else
                    piinfo.PI_Qty = piiGet(0).PI_Qty - CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty"))
                End If
            End If

            piinfo.PM_M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString
            piinfo.M_Code = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString
            If pic.ProductInventory_Update(piinfo) = False Then
                MsgBox("收貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If
        Next
        '--------------------------------------------------------------------------
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label5.Text
            Case "出貨單"
                If Edit = False Then
                    If CheckData() = True Then
                        DataNew()
                    End If
                Else
                    DataEdit()
                End If
            Case "Check"
                If CheckData() = True Then
                    UpdateCheck()
                End If
            Case "InCheck"
                If CheckData() = True Then
                    UpdateInCheck()
                End If
        End Select
    End Sub
    Private Sub cmsCodeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeAdd.Click
        tempCode = ""
        tempValue6 = "出貨管理"

        frmBOMSelect.XtraTabPage1.PageVisible = False
        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = True

        frmBOMSelect.ShowDialog()
        '增加記錄
        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode)
            End If
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then  '批次

            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
                    If arr(i) = ds.Tables("ProductionWareOutSub").Rows(j)("M_Code") Then
                        MsgBox("一張單不允許有重復物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))

                Dim row As DataRow
                row = ds.Tables("ProductionWareOutSub").NewRow
                row("PM_M_Code") = ""
                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Unit") = objInfo.M_Unit
                row("M_Gauge") = objInfo.M_Gauge
                row("PWO_Qty") = 0
                row("PWO_SubType") = "正批"
                ds.Tables("ProductionWareOutSub").Rows.Add(row)
                GridView1.MoveLast()
            Next

        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then   '聯豐編號
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n
                ''Dim j As Integer

                ''For j = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
                ''    If arr(i) = ds.Tables("ProductionWareOutSub").Rows(j)("M_Code") Then
                ''        MsgBox("一張單不允許有重復物料編碼....")
                ''        Exit Sub
                ''    End If
                ''Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))
                Dim row As DataRow
                row = ds.Tables("ProductionWareOutSub").NewRow

                row("PM_M_Code") = tempValue3
                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Gauge") = objInfo.M_Gauge
                row("M_Unit") = objInfo.M_Unit
                row("PWO_Qty") = 0
                row("PWO_SubType") = "正批"

                ''--------------2012-7-20------------------------------------------------------------------------------------
                row("PM_Type") = LoadProductionType(cbType.EditValue, tempValue3, objInfo.M_Code)
                ''--------------------------------------------------------------------------------------------------
                ''PM_JiYu 2012-8-22 加機玉

                Dim ppc1 As New ProcessMainControl
                Dim ppi1 As New List(Of ProcessMainInfo)
                ppi1 = ppc1.ProcessMain_GetList1(Nothing, tempValue3, cbType.EditValue, objInfo.M_Code)
                If ppi1.Count > 0 Then
                    row("PM_JiYu") = ppi1(0).PM_JiYu
                End If
                ''------------

                '@ 2012/10/4 添加 顯示庫存
                Dim pii As List(Of ProductInventoryInfo)
                pii = pic.ProductInventory_GetList(tempValue3, objInfo.M_Code, strWHOutID, Nothing)

                If pii.Count > 0 Then
                    row("PI_Qty") = pii(0).PI_Qty
                Else
                    row("PI_Qty") = 0
                End If

                ds.Tables("ProductionWareOutSub").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If
        tempValue2 = ""
        tempValue7 = ""
        tempValue8 = ""
        tempValue3 = ""
    End Sub

    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else

            Dim i As Integer

            For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
                If strCode = ds.Tables("ProductionWareOutSub").Rows(i)("M_Code") Then
                    MsgBox("一張單不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = ds.Tables("ProductionWareOutSub").NewRow

            If Mid(objInfo.M_Code, 1, 2) = "MG" Then
                row("PM_M_Code") = objInfo.M_Code
            Else
                row("PM_M_Code") = ""
            End If

            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge
            row("PWO_Qty") = 0
            row("PWO_SubType") = "正批"

            ds.Tables("ProductionWareOutSub").Rows.Add(row)

            GridView1.MoveLast()
        End If
    End Sub

    Private Sub cmsCodeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "PWO_SubNO")

        If DelTemp = "PWO_SubNO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelProductionWareOutSub").NewRow
            row("PWO_NO") = txtWIPID.Text
            row("PWO_SubNO") = DelTemp
            ds.Tables("DelProductionWareOutSub").Rows.Add(row)
        End If
        ds.Tables("ProductionWareOutSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub txtWH_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "880705"
        tempValue3 = "880705"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWH.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWH.Top + txtWH.Height + 140
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHOutID = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub
    Private Sub txtWHIn_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWHIn.ButtonClick

        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "880708"
        tempValue3 = "880708"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWHIn.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWHIn.Top + txtWHIn.Height + 140
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHInID = frmWareHouseSelect.SelectWareID
            txtWHIn.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub cmdGuideAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuideAdd.Click
        tempValue5 = "生產倉出貨"
        Dim fr As New frmProductionSelect
        fr.ShowDialog()
    End Sub


    Public Function GetCode(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String) As String

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ppi = ppc.ProcessMain_GetList(Nothing, PM_M_Code, Pro_Type, PM_Type, Nothing, Nothing)
        If ppi.Count = 0 Then
            GetCode = Nothing
            Exit Function
        Else
            GetCode = ppi(0).M_Code
        End If

    End Function

    '獲取最新項目號
    Public Function GetPSNO() As String
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim strName As String
        strName = Format(Now, "yyMM")
        psi = psc.ProductionSchedule_GetNO(strName)
        If psi Is Nothing Then
            GetPSNO = "PS" + strName + "0001"
        Else
            GetPSNO = "PS" + strName + Mid((CInt(Mid(psi.PS_NO, 7)) + 10001), 2)
        End If

    End Function

    '獲取最新日期項目流水號
    Public Function GetNum() As String
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim strName As String
        strName = "P" + Format(Now, "yyMM")
        psi = psc.ProductionSchedule_GetNum(strName)
        If psi Is Nothing Then
            GetNum = strName + "00001"
        Else
            GetNum = strName + Mid((CInt(Mid(psi.PS_Num, 6)) + 100001), 2)
        End If
    End Function

    Function CheckData() As Boolean  '判斷當前發出倉庫物料是否夠數
        CheckData = True

        If txtWH.Text = "" Then
            MsgBox("出貨倉庫不能為空")
            CheckData = False
            Exit Function
        End If
        If txtWHIn.Text = "" Then
            MsgBox("收貨倉庫不能為空")
            CheckData = False
            Exit Function
        End If
        'If GluDep.EditValue = "" Then
        '    MsgBox("出貨部門不能為空")
        '    CheckData = False
        '    Exit Function
        'End If

        If DateEdit1.Text = "" Then
            MsgBox("出貨日期不能為空")
            CheckData = False
            Exit Function
        End If

        If ds.Tables("ProductionWareOutSub").Rows.Count <= 0 Then
            MsgBox("沒有添加任何物料")
            CheckData = False
            Exit Function
        End If


        Dim i, j, sum As Integer
        For i = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1

            ''2012-7-21
            If ds.Tables("ProductionWareOutSub").Rows(i)("PM_Type") = "" Then
                MsgBox("出貨產品類型不能為空！")
                CheckData = False
                Exit Function

            End If

            If ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty") = 0 Then
                MsgBox("出貨數量不能為0！")
                CheckData = False
                Exit Function

            End If


            'Dim Qty As Double
            'Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            'Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            'wi = wc.WareInventory_GetSub(ds.Tables("ProductionWareOutSub").Rows(i)("M_Code"), strWHOutID)

            'If wi Is Nothing Then
            '    Qty = 0
            'Else
            '    Qty = wi.WI_Qty
            'End If




            sum = ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")
            If i <> j Then
                If ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString = ds.Tables("ProductionWareOutSub").Rows(j)("PM_M_Code").ToString _
                And ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString = ds.Tables("ProductionWareOutSub").Rows(j)("M_Code").ToString Then
                    sum = sum + ds.Tables("ProductionWareOutSub").Rows(j)("PWO_Qty")
                End If
            End If
            If sum > ds.Tables("ProductionWareOutSub").Rows(i)("PI_Qty") Then
                MsgBox("相同產品發出總數量大於當前選定倉庫庫存數量,請確認！")
                CheckData = False
                Exit Function
            End If


            '２０１３０８０８李超增加
            If Label5.Text = "InCheck" Then
                '----------------收貨確認檢查----------------------------------------
                Dim piiGet As List(Of ProductInventoryInfo)
                piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString, strWHOutID, Nothing)
                If piiGet.Count = 1 And CheckEdit3.Checked Then
                    If piiGet(0).PI_Qty < CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")) Then
                        MsgBox("出貨倉庫存不足,無法收貨確認！", MsgBoxStyle.Information, "提示")
                        CheckData = False
                        Exit Function
                    End If
                End If
                '----------------取消收貨確認檢查----------------------------------------
                Dim piiList As List(Of ProductInventoryInfo)
                piiList = pic.ProductInventory_GetList(ds.Tables("ProductionWareOutSub").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareOutSub").Rows(i)("M_Code").ToString, strWHInID, Nothing)
                If piiList.Count = 1 And CheckEdit3.Checked = False Then
                    If piiList(0).PI_Qty < CInt(ds.Tables("ProductionWareOutSub").Rows(i)("PWO_Qty")) Then
                        MsgBox("收貨倉庫存不足,無法取消收貨確認！", MsgBoxStyle.Information, "提示")
                        CheckData = False
                        Exit Function
                    End If
                End If
            End If
        Next
        ''--------------------2012-7-20--------------------------------------------------------------
        'Dim strFac As String
        ''strFac = Mid(GluDep.EditValue, 1, 1)
        'If strWHOutID = "W0801" Then
        '    strFac = "A"
        'ElseIf strWHOutID = "W0802" Then
        '    strFac = "B"
        'ElseIf strWHOutID = "W0803" Then
        '    strFac = "C"
        'End If

        '''''''''''''李超新增
        Dim fcon As New FacControler
        Dim flist As New List(Of FacInfo)
        flist = fcon.GetFacListA(Nothing, Nothing, strWHOutID)
        If flist.Count > 0 Then
            strFac = flist(0).FacID
        End If


        Dim pscA As New ProductionScheduleControl
        Dim psiA As List(Of ProductionScheduleInfo)

        Dim K As Integer
        Dim StrPM_M_Code As String
        Dim StrM_Code As String
        Dim StrPM_Type As String

        For K = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
            StrPM_M_Code = ds.Tables("ProductionWareOutSub").Rows(K)("PM_M_Code")
            StrM_Code = ds.Tables("ProductionWareOutSub").Rows(K)("M_Code")
            StrPM_Type = ds.Tables("ProductionWareOutSub").Rows(K)("PM_Type")

            psiA = pscA.ProductionSchedule_GetList1(Nothing, cbType.EditValue, StrPM_M_Code, StrM_Code, strFac, Nothing, DateEdit1.Text, DateEdit1.Text, StrPM_Type)
            If psiA.Count = 0 Then
                MsgBox("產品:" & StrPM_M_Code & "  配件:" & StrPM_Type & "在" & DateEdit1.EditValue & "無生產計，請添加生產計划!")
                CheckData = False
                Exit Function
            End If
        Next

        Dim m As Integer
        Dim n As Integer
        If ds.Tables("ProductionWareOutSub").Rows.Count > 1 Then

            For n = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
                For m = 0 To ds.Tables("ProductionWareOutSub").Rows.Count - 1
                    If m <> n Then
                        If ds.Tables("ProductionWareOutSub").Rows(m)("PM_M_Code") = ds.Tables("ProductionWareOutSub").Rows(n)("PM_M_Code") And _
                        ds.Tables("ProductionWareOutSub").Rows(m)("M_Code") = ds.Tables("ProductionWareOutSub").Rows(n)("M_Code") And _
                        ds.Tables("ProductionWareOutSub").Rows(m)("PM_Type") = ds.Tables("ProductionWareOutSub").Rows(n)("PM_Type") Then
                            MsgBox("一張單中不能存在相同產品,同類型,同物料編碼的記錄!")
                            CheckData = False
                            Exit Function
                        End If
                    End If
                Next
            Next

        End If
        ''--------------------------------------------------------------------------------------------
    End Function


    ''2012-7-20

    Private Sub RepositoryItemComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemComboBox1.Click
        Dim Get_LoadP_YN As Boolean

        If GridView1.RowCount > 0 Then
        Else
            Exit Sub
        End If

        Dim strA, strB, strC As String

        strA = ds.Tables("ProductionWareOutSub").Rows((GridView1.FocusedRowHandle)).Item("PM_M_Code")
        strB = cbType.EditValue
        strC = ds.Tables("ProductionWareOutSub").Rows((GridView1.FocusedRowHandle)).Item("M_Code")

        If LabelID.Text <> strA Or LabelName.Text <> strB Or LabM_Code.Text <> strC Then
            LabelID.Text = strA
            LabelName.Text = strB
            LabM_Code.Text = strC
            Get_LoadP_YN = True
        Else
            Get_LoadP_YN = False
        End If

        If Get_LoadP_YN = True Then
            LoadProductionType(strB, strA, strC)
        End If
    End Sub

    Function LoadProductionType(ByVal _Pro_Type As String, ByVal _PM_M_Code As String, ByVal _M_Code As String) As String
        LoadProductionType = ""
        Dim ppc As New ProcessMainControl
        Dim ppi As New List(Of ProcessMainInfo)

        RepositoryItemComboBox1.Items.Clear()

        ppi = ppc.ProcessMain_GetList1(Nothing, _PM_M_Code, _Pro_Type, _M_Code)
        If ppi.Count > 0 Then
            Dim k As Integer
            For k = 0 To ppi.Count - 1
                RepositoryItemComboBox1.Items.Add(ppi(k).Type3ID)
            Next

            LoadProductionType = ppi(0).Type3ID

        End If
    End Function

    Private Sub txtWH_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWH.EditValueChanged

    End Sub
End Class