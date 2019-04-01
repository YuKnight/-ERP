Imports LFERP.Library.WareHouse.WareMove
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.KnifeWare
Imports LFERP.SystemManager

Public Class frmKnifeWareMoveOut
#Region "字段屬性"
    Dim ds As New DataSet
    Public isBarCode As Boolean = True
    Dim oldCheck As Boolean
    Dim TorF As Boolean
    Private _EditItem As String '屬性欄
    Private _EditID As String
    Private _KnifeType As String

    Property KnifeType() As String '屬性
        Get
            Return _KnifeType
        End Get
        Set(ByVal value As String)
            _KnifeType = value
        End Set
    End Property

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
    Property EditID() As String '屬性
        Get
            Return _EditID
        End Get
        Set(ByVal value As String)
            _EditID = value
        End Set
    End Property
#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Select Case sender.Name
            Case "cmdAdd"
                tempCode = ""
                tempValue5 = OutWH.Tag
                tempValue6 = "倉庫管理"
                frmKnifeBOMSelect.ShowDialog()
                '增加記錄
                If tempCode = "" Then
                    Exit Sub
                Else
                    AddRow(tempCode, 0)
                End If
            Case "cmdAccAdd"
            Case "cmdCenterAcc"
            Case "cmdBarAdd"
            Case "cmdDel"
        End Select
    End Sub

    Sub AddRow(ByVal strCode As String, ByVal Qty As Double)
        If strCode = "" Then
        Else
            Dim i As Integer
            For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
                If strCode = ds.Tables("KnifeWareMove").Rows(i)("M_Code") Then
                    If isBarCode = True Then
                        ds.Tables("KnifeWareMove").Rows(i)("MV_Qty") = ds.Tables("KnifeWareMove").Rows(i)("MV_Qty") + 1
                        GridView2.FocusedRowHandle = i
                        Exit Sub
                    Else
                        MsgBox("一張單不允許有重復物料編碼....", 64, "提示")
                        Exit Sub
                    End If
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            If objInfo Is Nothing Then
                MsgBox("不存在此物料編碼信息!", 64, "提示")
                Exit Sub
            End If
            Dim row As DataRow
            row = ds.Tables("KnifeWareMove").NewRow
            'CodeSubData.Tables("CodeSub").NewRow()
            row("M_Code") = objInfo.M_Code
            row("MV_Qty") = Qty
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge
            '     row("OS_BatchID") = objInfo.m
            row("MV_Property") = "物料轉移"

            '@2013/1/28 添加 顯示庫存
            Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi1 = wc1.WareInventory_GetSub(strCode, OutWH.Tag)

            If wi1 Is Nothing Then
                row("WI_SafeQty") = 0
                row("WI_Qty") = 0
            Else
                row("WI_SafeQty") = wi1.WI_SafeQty
                row("WI_Qty") = wi1.WI_Qty
            End If

            ''''''''''''''''''''2013-11-6姚駿新增


            ''''''''''''''''''''''''''''''''''''''''''''
            'row("WI_SQty") = frmKnifeBOMSelect.BOWI_SQty
            'row("WI_SReQty") = frmKnifeBOMSelect.BOWI_SReQty

            '--------------------------------------------

            '----------------------------------------
            Dim strKnifeName As String
            Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi5 = wc5.KnifeWareInventorySub_GetList(strCode, OutWH.Tag)
            If wi5 Is Nothing Then
                row("Enable_Qty_Show") = 0
                row("WI_SQty") = 0
                row("WI_SReQty") = 0
            Else

                Select Case EditItem
                    Case "KnifeWareMoveAddNew" ''''新刀
                        row("Enable_Qty_Show") = wi5.WI_SQty
                        strKnifeName = "新刀"
                    Case "KnifeWareMoveAddOld" '待處理
                        row("Enable_Qty_Show") = wi5.WI_SReQty
                        strKnifeName = "待處理"
                    Case "KnifeWareMoveEdit"
                        If cbKnifeType.Text = "新刀" Then
                            row("Enable_Qty_Show") = wi5.WI_SQty
                            strKnifeName = "新刀"
                        ElseIf cbKnifeType.Text = "待處理" Then
                            row("Enable_Qty_Show") = wi5.WI_SReQty
                            strKnifeName = "待處理"
                        End If


                End Select

                row("WI_SQty") = wi5.WI_SQty
                row("WI_SReQty") = wi5.WI_SReQty
            End If

            'If EditItem = "KnifeWareMoveAddNew" Then
            '    strKnifeName = "新刀"
            'Else
            '    strKnifeName = "待處理"
            'End If
            Dim nRealQty As Integer = LoadRealInventory(row("M_Code"), strKnifeName, row("Enable_Qty_Show"), String.Empty)

            If nRealQty = -1 Then
                row("WI_RealQty") = row("Enable_Qty_Show")
            Else
                row("WI_RealQty") = nRealQty
            End If

            ds.Tables("KnifeWareMove").Rows.Add(row)
            GridView2.MoveLast()
        End If
    End Sub
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("KnifeWareMove")
            .Columns.Add("MV_NO", GetType(String))
            .Columns.Add("MV_Number", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("MV_Qty", GetType(Int32))
            .Columns.Add("MV_Date", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("DepotNO", GetType(String))
            .Columns.Add("MV_ChangeDepotNO", GetType(String))
            .Columns.Add("MV_InOrOut", GetType(String))
            .Columns.Add("MV_Remark", GetType(String))
            .Columns.Add("MV_Ack", GetType(String))
            .Columns.Add("MV_OutAction", GetType(String))
            .Columns.Add("MV_InAction", GetType(String))
            .Columns.Add("MV_Property", GetType(String))
            .Columns.Add("MV_Check", GetType(String))
            .Columns.Add("MV_CheckAction", GetType(String))
            .Columns.Add("MV_CheckType", GetType(String))
            .Columns.Add("MV_ChcekRemark", GetType(String))
            .Columns.Add("MV_InActionName", GetType(Boolean))
            .Columns.Add("MV_OutActionName", GetType(String))
            .Columns.Add("MV_CheckActionName", GetType(String))
            .Columns.Add("WI_Qty", GetType(Double))
            .Columns.Add("WI_SafeQty", GetType(Double))
            .Columns.Add("KnifeType", GetType(String))
            .Columns.Add("Enable_Qty_Show", GetType(Double))
            .Columns.Add("WI_SQty", GetType(String))         '新刀數量
            .Columns.Add("WI_SReQty", GetType(String))       '待處理刀數量
            .Columns.Add("WI_RealQty", GetType(String))      '實際可用庫存數量
            .Columns.Add("MV_PreRemark", GetType(String))    '原先備註 
        End With
        '創建刪除數據表
        With ds.Tables.Add("DelDataKnifeWareMove")
            .Columns.Add("MV_Number", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("KnifeWareMove")
    End Sub

    Private Sub frmKnifeWareMoveOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTables()
        If isBarCode = True Then
            Label24.Visible = False
            txtM_Code.Visible = False
            LabelControl1.Visible = False
            cmdBarAdd.Visible = False
            'txtM_Code.Focus()
        End If

        Select Case EditItem
            Case "KnifeWareMoveAddNew"
                '新增修改時
                OutWH.Tag = tempValue2
                OutWH.Text = tempValue3

                If tempValue2 = "" Then
                    MsgBox("請先選擇相應的倉別", 64, "提示")
                    Exit Sub
                End If
                txtWH.Enabled = True
                DateEdit1.Enabled = False
                DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                Label1.Text = "刀具調撥單--新增"
                cbKnifeType.Text = "新刀"
            Case "KnifeWareMoveAddOld"
                '新增修改時
                OutWH.Tag = tempValue2
                OutWH.Text = tempValue3

                If tempValue2 = "" Then
                    MsgBox("請先選擇相應的倉別", 64, "提示")
                    Exit Sub
                End If
                txtWH.Enabled = True
                DateEdit1.Enabled = False
                DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                Label1.Text = "刀具調撥單--新增"
                cbKnifeType.Text = "待處理"
            Case "KnifeWareMoveEdit"
                If LoadData(EditID) = False Then Exit Sub
                Label1.Text = "刀具調撥單--修改"
            Case "KnifeAcceptanceMoveOut"
                ' OutWH.Text = "W0102"
                txtWH.Enabled = True
                DateEdit1.Enabled = False
                DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                tempValue2 = Nothing
            Case "KnifeWareMoveIn"
                '收料確認時
                Label1.Text = "刀具調撥單--收料確認"
                If LoadData(EditID) = False Then Exit Sub
                GridView2.Columns.Item("MV_Qty").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Property").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Remark").OptionsColumn.ReadOnly = True
                cmdAdd.Enabled = False
                cmdDel.Enabled = False
                CheckEdit3.Enabled = True
            Case "KnifeWareMoveView"
                '查看時
                If LoadData(EditID) = False Then Exit Sub
                GridView2.Columns.Item("MV_Qty").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Property").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Remark").OptionsColumn.ReadOnly = True
                cmdAdd.Enabled = False
                cmdDel.Enabled = False
                cmdSave.Enabled = False
                Label1.Text = "刀具調撥單--查看"
            Case "KnifeWareMoveCheck"
                '審核時
                If LoadData(EditID) = False Then Exit Sub
                CheckEdit2.Enabled = True
                MemoEdit1.Enabled = True
                If CheckEdit2.Checked = True Then
                    TorF = True
                Else
                    TorF = False
                End If
                Panel1.Enabled = True
                GridView2.Columns.Item("MV_Qty").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Property").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Remark").OptionsColumn.ReadOnly = True
                cmdAdd.Enabled = False
                cmdDel.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                Label1.Text = "刀具調撥單--審核"
            Case "KnifeWareMoveRemarkEdit"
                If LoadData(EditID) = False Then Exit Sub
                Label1.Text = "刀具調撥單--修改審核"

                GridView2.Columns.Item("MV_Qty").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Property").OptionsColumn.ReadOnly = True

                cmdAdd.Enabled = False
                cmdDel.Enabled = False

        End Select
        ' tempValue = ""
    End Sub

#Region "保存修改備註"
    ''' <summary>
    ''' 保存修改備註
    ''' </summary>
    ''' <remarks>2014-02-28</remarks>
    Private Sub SaveUpdateRemarkEdit()

        Dim osc As New LFERP.Library.KnifeWare.KnifeWareMoveController
        Dim osilist As New List(Of LFERP.Library.KnifeWare.KnifeWareMoveInfo)
        osilist = osc.KnifeWareMove_GetList(txtQuoID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing)
        If osilist.Count <= 0 Then
            MsgBox("此單已經被刪除！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
            If Not IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Number")) Then
                Dim ac As New KnifeWareMoveController
                Dim ai As New KnifeWareMoveInfo

                ai.MV_Number = ds.Tables("KnifeWareMove").Rows(i)("MV_Number")

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")) Then
                    ai.MV_Remark = Nothing
                Else
                    ai.MV_Remark = ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")
                End If

                ac.KnifeWareMove_UpdateEditRemark(ai)

            End If
        Next
    End Sub
#End Region

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case EditItem
            Case "KnifeWareMoveAddNew"
                '新增修改時
                If CheckSave() = True Then
                    SaveNew()
                End If
            Case "KnifeWareMoveAddOld"
                '新增修改時
                If CheckSave() = True Then
                    SaveNew()
                End If
            Case "KnifeWareMoveEdit"
                If CheckSave() = True Then
                    SaveUpdate()
                End If
            Case "KnifeAcceptanceMoveOut"
                SaveNew()
            Case "KnifeWareMoveIn"
                If CheckSave() = True Then
                    SaveIn()
                End If
            Case "KnifeWareMoveCheck"
                '審核狀態不變的情況下
                If TorF = True And CheckEdit2.Checked = True Then
                    Exit Sub
                    Me.Close()
                End If

                If TorF = False And CheckEdit2.Checked = False Then
                    Exit Sub
                    Me.Close()
                End If
                If CheckSave() = True Then
                    SaveCheck()
                End If
            Case "KnifeWareMoveView"
                '查看時
                If LoadData(EditID) = False Then Exit Sub
                GridView2.Columns.Item("MV_Qty").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Property").OptionsColumn.ReadOnly = True
                GridView2.Columns.Item("MV_Remark").OptionsColumn.ReadOnly = True
                cmdAdd.Enabled = False
                cmdDel.Enabled = False
                cmdSave.Enabled = False
                Label1.Text = "刀具調撥單--查看"
            Case "KnifeWareMoveRemarkEdit"
                SaveUpdateRemarkEdit()
                SaveUpdateRemarkEditLog()

        End Select
    End Sub

    '2014-02-28  姚駿
    ''' <summary>
    ''' 保存更改備註日誌
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveUpdateRemarkEditLog()
        Dim i As Integer
        For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
            If Not IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Number")) Then
                Dim ac As New KnifeWareMoveController
                Dim ai As New KnifeWareMoveInfo

                ai.MV_Number = ds.Tables("KnifeWareMove").Rows(i)("MV_Number")


                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_PreRemark")) Then
                    ai.MV_PreRemark = Nothing
                Else
                    ai.MV_PreRemark = ds.Tables("KnifeWareMove").Rows(i)("MV_PreRemark")
                End If


                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")) Then
                    ai.MV_LastRemark = Nothing
                Else
                    ai.MV_LastRemark = ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")
                End If

                ai.MV_Action = InUserID
                ai.MV_ActionDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

                If Not ac.KnifeWareMoveLog_Update(ai) Then
                    MsgBox("保存調撥記錄失敗!", 64, "提示")
                    Exit Sub
                End If

            End If
        Next
        MsgBox("修改審核成功!", 64, "提示")
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub SaveNew()
        With ds.Tables("KnifeWareMove")
            Dim MV_NO As String = GetMV_NO()
            Dim i As Integer
            For i = 0 To .Rows.Count - 1
                Dim ac As New KnifeWareMoveController
                Dim ai As New KnifeWareMoveInfo
                If IsDBNull(.Rows(i)("MV_Qty")) Then
                    MsgBox("數量不能為空,請輸入數量!", 64, "提示")
                    Exit Sub
                Else
                    ai.MV_Qty = CDbl(.Rows(i)("MV_Qty"))
                End If
                ai.MV_NO = MV_NO
                ai.MV_Number = GetMV_Number()
                ai.MV_Date = DateEdit1.Text
                ai.DepotNO = OutWH.Tag
                ai.MV_ChangeDepotNO = txtWH.Tag
                ai.MV_OutAction = InUserID
                ai.KnifeType = cbKnifeType.Text

                ai.M_Code = .Rows(i)("M_Code")
                ai.M_Name = .Rows(i)("M_Name")
                ai.M_Gauge = .Rows(i)("M_Gauge")
                ai.M_Unit = .Rows(i)("M_Unit")
                ai.MV_Property = .Rows(i)("MV_Property")
                ai.OS_BatchID = IIf(IsDBNull(.Rows(i)("OS_BatchID")), Nothing, .Rows(i)("OS_BatchID"))
                ai.PM_M_Code = IIf(IsDBNull(.Rows(i)("PM_M_Code")), Nothing, .Rows(i)("PM_M_Code"))
                ai.MV_Remark = IIf(IsDBNull(.Rows(i)("MV_Remark")), Nothing, .Rows(i)("MV_Remark"))
                ac.KnifeWareMove_Add(ai)
            Next
            MsgBox("已保存,單號: " & MV_NO & " ", 64, "提示")
            Me.Close()
        End With
    End Sub

    Function GetMV_NO() As String
        ' ''生成新的調撥單號
        ''Dim str1, str2 As String
        ''Dim ac As New KnifeWareMoveController
        ''Dim ai As List(Of KnifeWareMoveInfo)
        ''str1 = Mid(Year(Now), 3)
        ''If CInt(Month(Now)) < 10 Then
        ''    str2 = "0" & Month(Now)
        ''Else
        ''    str2 = Month(Now)
        ''End If

        ''Dim Stra As String
        ''Stra = "MV" & str1 & str2
        ''ai = ac.KnifeWareMove_GetList(Stra, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "2", Nothing)
        ''If ai.Count = 0 Then
        ''    GetMV_NO = "MV" & str1 & str2 & "00001"
        ''Else
        ''    GetMV_NO = "MV" & str1 & str2 & Mid((CInt(Mid(ai.Item(0).MV_NO, 7)) + 100001), 2)
        ''End If

        Dim str1 As String
        Dim ac As New KnifeWareMoveController
        Dim ai As New List(Of KnifeWareMoveInfo)
        str1 = "MV" & Format(Now, "yyMM")

        ai = ac.KnifeWareMove_GetNO(str1)
        If ai.Count = 0 Then
            GetMV_NO = str1 & "00001"
        Else
            GetMV_NO = str1 & Mid((CInt(Mid(ai.Item(0).MV_NO, 7)) + 100001), 2)
        End If


    End Function

    Function GetMV_Number() As String
        '生成新的調撥編號
        ' ''Dim str1, str2 As String
        ' ''Dim ac As New LFERP.Library.KnifeWare.KnifeWareMoveController
        ' ''Dim ai As List(Of LFERP.Library.KnifeWare.KnifeWareMoveInfo)
        ' ''str1 = Mid(Year(Now), 3)
        ' ''If CInt(Month(Now)) < 10 Then
        ' ''    str2 = "0" & Month(Now)
        ' ''Else
        ' ''    str2 = Month(Now)
        ' ''End If

        ' ''Dim Stra As String
        ' ''Stra = str1 & str2
        ' ''ai = ac.KnifeWareMove_GetList(Stra, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "2", Nothing)
        ' ''If ai.Count = 0 Then
        ' ''    GetMV_Number = str1 & str2 & "00001"
        ' ''Else
        ' ''    GetMV_Number = str1 & str2 & Mid((CInt(Mid(ai.Item(0).MV_Number, 5)) + 100001), 2)
        ' ''End If

        Dim str1 As String
        Dim ac As New KnifeWareMoveController
        Dim ai As New List(Of KnifeWareMoveInfo)
        str1 = Format(Now, "yyMM")

        ai = ac.KnifeWareMove_GetNumber(str1)
        If ai.Count = 0 Then
            GetMV_Number = str1 & "00001"
        Else
            GetMV_Number = str1 & Mid((CInt(Mid(ai.Item(0).MV_Number, 5)) + 100001), 2)
        End If

    End Function
    ''' <summary>
    ''' 載入調撥單數據
    ''' </summary>
    ''' <param name="MV_NO"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal MV_NO As String) As Boolean
        LoadData = True
        Dim objList As New List(Of LFERP.Library.KnifeWare.KnifeWareMoveInfo)
        Dim oc As New LFERP.Library.KnifeWare.KnifeWareMoveController
        Try
            objList = oc.KnifeWareMove_GetList(MV_NO, Nothing, Nothing, Nothing, Nothing, "收料", Nothing, Nothing, "2", Nothing)
            If objList.Count = 0 Then
                MsgBox("沒有數據", 64, "提示")
                LoadData = False
                Exit Function
            End If
            txtQuoID.Text = objList(0).MV_NO
            txtWH.Tag = objList(0).DepotNO
            txtWH.Text = objList(0).DepotAllName

            OutWH.Tag = objList(0).MV_ChangeDepotNO
            OutWH.Text = objList(0).MV_ChangeDepotAllName

            DateEdit1.Text = objList(0).MV_Date
            cbKnifeType.Text = objList(0).KnifeType
            ds.Tables("KnifeWareMove").Rows.Clear()
            '           objList = oc.Acceptance_GetList(Nothing, A_AcceptanceNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim i As Integer
            Dim row As DataRow
            For i = 0 To objList.Count - 1
                row = ds.Tables("KnifeWareMove").NewRow
                row("MV_NO") = objList(i).MV_NO
                row("MV_Number") = objList(i).MV_Number
                row("M_Code") = objList(i).M_Code
                row("M_Unit") = objList(i).M_Unit
                row("M_Gauge") = objList(i).M_Gauge
                row("M_Name") = objList(i).M_Name


                row("OS_BatchID") = objList(i).OS_BatchID
                row("PM_M_Code") = objList(i).PM_M_Code
                row("MV_Qty") = objList(i).MV_Qty
                row("MV_Property") = objList(i).MV_Property
                row("MV_Remark") = objList(i).MV_Remark
                row("KnifeType") = objList(i).KnifeType

                '2014-02-28 姚駿
                row("MV_PreRemark") = objList(i).MV_Remark

                '@2013/1/28 添加 顯示庫存
                Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetSub(objList(i).M_Code, OutWH.Tag)
                If wi1 Is Nothing Then
                    row("WI_SafeQty") = 0
                    row("WI_Qty") = 0
                Else
                    row("WI_SafeQty") = wi1.WI_SafeQty
                    row("WI_Qty") = wi1.WI_Qty
                End If


                '2013-02-10姚駿新增
                '-------------------------------------------------------------------------------------------------
                Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
                Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
                wi5 = wc5.KnifeWareInventorySub_GetList(objList(i).M_Code, OutWH.Tag)
                If wi5 Is Nothing Then
                    row("Enable_Qty_Show") = 0
                    row("WI_SQty") = 0
                    row("WI_SReQty") = 0
                Else
                    Select Case objList(i).KnifeType
                        Case "新刀" ''''新刀
                            row("Enable_Qty_Show") = wi5.WI_SQty

                        Case "待處理" '待處理
                            row("Enable_Qty_Show") = wi5.WI_SReQty

                    End Select

                    row("WI_SQty") = wi5.WI_SQty
                    row("WI_SReQty") = wi5.WI_SReQty
                End If


                Dim nRealQty As Integer = LoadRealInventory(row("M_Code"), objList(i).KnifeType, row("Enable_Qty_Show"), String.Empty)

                If nRealQty = -1 Then
                    row("WI_RealQty") = row("Enable_Qty_Show")
                Else
                    row("WI_RealQty") = nRealQty + objList(i).MV_Qty
                End If

                '--------------------------------------------------------------------------------------------------


                ds.Tables("KnifeWareMove").Rows.Add(row)
                If objList(i).MV_Ack = False Then
                    CheckEdit3.Checked = False
                    'oldCheck = False
                Else
                    CheckEdit3.Checked = True
                    'oldCheck = True
                End If
                If objList(i).MV_Check = False Then
                    CheckEdit2.Checked = False
                Else
                    CheckEdit2.Checked = True
                End If
                Label3.Text = objList(i).MV_CheckAction
                MemoEdit1.Text = objList(i).MV_CheckRemark
            Next
        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try
    End Function

    Function CheckSave() As Boolean
        CheckSave = True


        '2013-3-3 ------------------------------------
        If EditItem = "KnifeWareMoveAddNew" Or EditItem = "KnifeWareMoveAddOld" Or EditItem = "KnifeWareMoveEdit" Then
            If CheckWHIDA(OutWH.Tag) = False Then
                MsgBox("當前用戶無:" & OutWH.Text & "發出權限!", 64, "提示")
                CheckSave = False
                Exit Function
            End If
        End If


        If ds.Tables("KnifeWareMove").Rows.Count = 0 Then
            MsgBox("沒有數據,無法保存!", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        If txtWH.Text = "" Then
            MsgBox("接收倉庫不能為空!", MsgBoxStyle.OkOnly, "提示")
            CheckSave = False
            Exit Function
        End If

        If OutWH.Tag = "" Then
            MsgBox("發料倉庫不能為空!", MsgBoxStyle.OkOnly, "提示")
            CheckSave = False
            Exit Function
        End If

        If cbKnifeType.Text = "新刀" Or cbKnifeType.Text = "待處理" Then
        Else
            MsgBox("刀具屬性必須為 新刀 或 待處理", MsgBoxStyle.OkOnly, "提示")
            CheckSave = False
            Exit Function
        End If

        If txtWH.Tag = OutWH.Tag Then
            MsgBox("接收和發出不能是同一個倉別!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
            CheckSave = False
            Exit Function
        End If

        If DateEdit1.Text = "" Then
            MsgBox("日期不能為空!", MsgBoxStyle.OkOnly, "提示")
            CheckSave = False
            Exit Function
        End If
        Dim i As Integer
        For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
            If ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString.Trim = "" Then
                MsgBox("物料編碼不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeWareMove").Rows(i)("M_Name").ToString.Trim = "" Then
                MsgBox("物料名稱不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeWareMove").Rows(i)("M_Gauge").ToString.Trim = "" Then
                MsgBox("物料規格不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeWareMove").Rows(i)("M_Unit").ToString.Trim = "" Then
                MsgBox("物料單位不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) = 0 Then
                MsgBox("調撥數量不能為0！", MsgBoxStyle.OkOnly, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            End If

            If ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString < 0 Then
                MsgBox("調撥數量不能為負數！", MsgBoxStyle.OkOnly, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            End If

            '--------------------------------------------------------判斷是否有主檔庫存
            Dim wic As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            Dim wii As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            wii = wic.WareInventory_GetSub(ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString, OutWH.Tag)
            Dim Qty As Double
            If wii Is Nothing Then
                MsgBox("當前發出倉庫不存在此物料信息", 64, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            Else
                Qty = wii.WI_Qty
            End If

            If Qty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                MsgBox("發出倉沒有此庫存或庫存不足!", 64, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            End If
            '--------------------------------------------------------判斷是否有子檔庫存
            Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi5 = wc5.KnifeWareInventorySub_GetList(ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString, OutWH.Tag)
            If wi5 Is Nothing Then
                MsgBox("當前發出倉庫刀具屬性倉庫不存在此物料信息", 64, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            Else
                'Select Case EditItem
                '    Case "KnifeWareMoveAddNew" ''''新刀
                '        If wi5.WI_SQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                '            MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                '            GridControl1.Focus()
                '            GridView2.FocusedRowHandle = i
                '            CheckSave = False
                '            Exit Function
                '        End If
                '    Case "KnifeWareMoveAddOld" '待處理
                '        If wi5.WI_SReQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                '            MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                '            GridControl1.Focus()
                '            GridView2.FocusedRowHandle = i
                '            CheckSave = False
                '            Exit Function
                '        End If
                'End Select

                '2014-02-08 姚駿
                Select Case EditItem
                    Case "KnifeWareMoveAddNew" ''''新刀
                        Dim nWI_SQty As Integer = LoadRealInventory(ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString, "新刀", wi5.WI_SQty, String.Empty)

                        If nWI_SQty = -1 Then
                            nWI_SQty = wi5.WI_SQty
                        End If

                        If nWI_SQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then

                            MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                            GridControl1.Focus()
                            GridView2.FocusedRowHandle = i
                            CheckSave = False
                            Exit Function
                        End If
                    Case "KnifeWareMoveAddOld" '待處理

                        Dim nWI_SReQty As Integer = LoadRealInventory(ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString, "待處理", wi5.WI_SReQty, String.Empty)

                        If nWI_SReQty = -1 Then
                            nWI_SReQty = wi5.WI_SReQty
                        End If

                        If nWI_SReQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                            MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                            GridControl1.Focus()
                            GridView2.FocusedRowHandle = i
                            CheckSave = False
                            Exit Function
                        End If
                        '2014-02-10 姚駿
                    Case "KnifeWareMoveEdit"

                        Dim knifeCount As Double

                        If cbKnifeType.Text = "新刀" Then
                            knifeCount = wi5.WI_SQty
                        ElseIf cbKnifeType.Text = "待處理" Then
                            knifeCount = wi5.WI_SReQty
                        End If

                        Dim nWI_SQty As Integer = LoadRealInventory(ds.Tables("KnifeWareMove").Rows(i)("M_Code").ToString, cbKnifeType.Text, knifeCount, txtQuoID.Text)

                        If nWI_SQty = -1 Then
                            nWI_SQty = wi5.WI_SQty
                        End If

                        If nWI_SQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then

                            MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                            GridControl1.Focus()
                            GridView2.FocusedRowHandle = i
                            CheckSave = False
                            Exit Function
                        End If


                    Case "KnifeWareMoveCheck"

                        Select Case ds.Tables("KnifeWareMove").Rows(i)("KnifeType")
                            Case "新刀"
                                If wi5.WI_SQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                                    MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                                    GridControl1.Focus()
                                    GridView2.FocusedRowHandle = i
                                    CheckSave = False
                                    Exit Function
                                End If
                            Case "待處理"
                                If wi5.WI_SReQty < CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty").ToString) Then
                                    MsgBox("發出倉屬性刀具沒有此庫存或庫存不足!", 64, "提示")
                                    GridControl1.Focus()
                                    GridView2.FocusedRowHandle = i
                                    CheckSave = False
                                    Exit Function
                                End If
                                '-----------------------------------------------------------------
                        End Select
                End Select
            End If
            '------------------------------------------------------------
            If ds.Tables("KnifeWareMove").Rows(i)("MV_Property").ToString = "" Then
                MsgBox("請填寫調撥類型！", MsgBoxStyle.OkOnly, "提示")
                GridControl1.Focus()
                GridView2.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            End If
        Next
    End Function

    '2014-02-08 姚駿
    Private Function LoadRealInventory(ByVal strMocde As String, ByVal strKnifeType As String, ByVal nEnableQty As Integer, ByVal strMVCode As String) As Integer


        Dim knifeMoveInfo As New List(Of LFERP.Library.KnifeWare.KnifeWareMoveInfo)
        Dim knifeMoveCtrl As New LFERP.Library.KnifeWare.KnifeWareMoveController

        knifeMoveInfo = knifeMoveCtrl.KnifeWareMove_GetListTwo(Nothing, strMocde, Nothing, OutWH.Tag, Nothing, "發料", Nothing, "0", "2", Nothing, strKnifeType)


        If (knifeMoveInfo.Count <= 0) Then
            LoadRealInventory = -1
            Exit Function
        End If

        Dim knifeMoveCount As Integer = 0
        Dim index As Integer = 0
        For index = 0 To knifeMoveInfo.Count - 1
            If strMVCode <> String.Empty Then
                If (strMVCode <> knifeMoveInfo(index).MV_NO) Then
                    knifeMoveCount = knifeMoveCount + knifeMoveInfo(index).MV_Qty
                End If
            Else
                knifeMoveCount = knifeMoveCount + knifeMoveInfo(index).MV_Qty
            End If

        Next

        LoadRealInventory = nEnableQty - knifeMoveCount

    End Function

    Sub SaveIn()
        Dim wmc As New KnifeWareMoveController
        Dim wmi As New KnifeWareMoveInfo
        wmi.MV_NO = txtQuoID.Text
        wmi.MV_InAction = InUserID
        If CheckEdit3.Checked = oldCheck Then
            MsgBox("請先變更確認狀態!", 64, "提示")
            Exit Sub
        End If
        If CheckEdit3.Checked = True Then
            wmi.MV_Ack = True
        Else
            wmi.MV_Ack = False
        End If
        wmc.KnifeWareMove_UpdateAck(wmi)
        MsgBox("收料確認狀態已改變", MsgBoxStyle.OkOnly, "提示")
        Me.Close()
    End Sub

#Region "不使用程序"
    Sub SaveUpdate()
        Dim i As Integer
        For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
            If Not IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Number")) Then
                '如果隻是修改
                Dim ac As New KnifeWareMoveController
                Dim ai As New KnifeWareMoveInfo

                ai.MV_Number = ds.Tables("KnifeWareMove").Rows(i)("MV_Number")

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty")) Then
                    MsgBox("數量不能為空,請輸入數量!", 64, "提示")
                    Exit Sub
                Else
                    ai.MV_Qty = CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty"))
                End If

                ai.MV_ChangeDepotNO = txtWH.Tag

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")) Then
                    ai.MV_Remark = Nothing
                Else
                    ai.MV_Remark = ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")
                End If

                ai.MV_Property = ds.Tables("KnifeWareMove").Rows(i)("MV_Property")
                ai.KnifeType = cbKnifeType.Text
                ai.MV_OutAction = InUserID

                ac.KnifeWareMove_Update(ai)

            End If

            If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Number")) Then
                '如果隻是新增
                Dim MV_Number As String
                MV_Number = GetMV_Number()
                Dim ac As New KnifeWareMoveController
                Dim ai As New KnifeWareMoveInfo

                ai.MV_NO = txtQuoID.Text
                ai.MV_Number = MV_Number
                ai.M_Code = ds.Tables("KnifeWareMove").Rows(i)("M_Code")
                ai.M_Name = ds.Tables("KnifeWareMove").Rows(i)("M_Name")
                ai.M_Gauge = ds.Tables("KnifeWareMove").Rows(i)("M_Gauge")
                ai.M_Unit = ds.Tables("KnifeWareMove").Rows(i)("M_Unit")

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty")) Then
                    MsgBox("數量不能為空,請輸入數量!", 64, "提示")
                    Exit Sub
                Else
                    ai.MV_Qty = CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty"))
                End If

                ai.MV_Date = DateEdit1.Text


                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("OS_BatchID")) Then
                    ai.OS_BatchID = Nothing
                Else
                    ai.OS_BatchID = ds.Tables("KnifeWareMove").Rows(i)("OS_BatchID")
                End If

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("PM_M_Code")) Then
                    ai.PM_M_Code = Nothing
                Else
                    ai.PM_M_Code = ds.Tables("KnifeWareMove").Rows(i)("PM_M_Code")
                End If

                ai.DepotNO = OutWH.Tag
                ai.MV_ChangeDepotNO = txtWH.Tag
                ai.KnifeType = cbKnifeType.Text

                If IsDBNull(ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")) Then
                    ai.MV_Remark = Nothing
                Else
                    ai.MV_Remark = ds.Tables("KnifeWareMove").Rows(i)("MV_Remark")
                End If

                ai.MV_Property = ds.Tables("KnifeWareMove").Rows(i)("MV_Property")
                ai.MV_OutAction = InUserID
                ac.KnifeWareMove_Add(ai)
            End If
        Next
        '更新刪除的記錄
        If ds.Tables("DelDataKnifeWareMove").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelDataKnifeWareMove").Rows.Count - 1
                Dim odc As New KnifeWareMoveController
                Dim odi As New KnifeWareMoveInfo
                odi.MV_Number = ds.Tables("DelDataKnifeWareMove").Rows(i)("MV_Number")
                odc.KnifeWareMove_DelNumber(odi)
            Next i
        End If
        MsgBox("已修改,單號: " & txtQuoID.Text & " ", 64, "提示")
        Me.Close()
    End Sub
#End Region

    Sub SaveCheck()

        ''''''''''''''''是否有庫存'''''''''''''''
        Dim wiic As New WareInventory.WareInventoryMTController
        Dim a As New LFERP.Library.KnifeWare.KnifeWareMoveController
        Dim b As New LFERP.Library.KnifeWare.KnifeWareMoveInfo
        b.MV_NO = txtQuoID.Text
        If CheckEdit2.Checked = True Then
            b.MV_Check = True
        Else
            b.MV_Check = False
        End If
        b.MV_AckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        b.MV_CheckRemark = MemoEdit1.Text
        b.MV_CheckAction = InUserID
        a.KnifeWareMove_UpdateCheck(b)

        Dim i As Integer
        For i = 0 To ds.Tables("KnifeWareMove").Rows.Count - 1
            '------------------------------------子庫存-----------------------------------------------------------
            Dim DouQty As Double = CDbl(ds.Tables("KnifeWareMove").Rows(i)("MV_Qty"))
            Dim strKnifeType As String = ds.Tables("KnifeWareMove").Rows(i)("KnifeType")
            Dim strM_Code As String = ds.Tables("KnifeWareMove").Rows(i)("M_Code")
            '-------調入倉庫-------------------------------------------------------------
            Dim KnifeIn As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wiIn As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wcIn As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wiIn = wcIn.WareInventory_GetSub(strM_Code, txtWH.Tag)
            If wiIn Is Nothing Then
                KnifeIn.WI_All = 0 + DouQty
            Else
                KnifeIn.WI_All = wiIn.WI_Qty + DouQty
            End If

            Dim KwInfoIn As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim KwConIn As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            KwInfoIn = KwConIn.KnifeWareInventorySub_GetList(strM_Code, txtWH.Tag)
            If KwInfoIn Is Nothing Then
                Select Case strKnifeType
                    Case "新刀" ''''新刀
                        KnifeIn.WI_SQty = (0 + DouQty)
                        KnifeIn.WI_SReQty = 0
                    Case "待處理" '待處理
                        KnifeIn.WI_SReQty = (0 + DouQty)
                        KnifeIn.WI_SQty = 0
                End Select
            Else
                Select Case strKnifeType
                    Case "新刀" ''''新刀
                        KnifeIn.WI_SQty = KwInfoIn.WI_SQty + DouQty
                        KnifeIn.WI_SReQty = KwInfoIn.WI_SReQty
                    Case "待處理" '待處理
                        KnifeIn.WI_SReQty = KwInfoIn.WI_SReQty + DouQty
                        KnifeIn.WI_SQty = KwInfoIn.WI_SQty
                End Select
            End If
            KnifeIn.M_Code = strM_Code
            KnifeIn.WH_ID = txtWH.Tag
            KwConIn.KnifeWareInventorySub_Update(KnifeIn)
            '-------調出倉庫--------------------------------------------------------------
            Dim KnifeOut As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wiOut As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wcOut As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wiOut = wcOut.WareInventory_GetSub(strM_Code, OutWH.Tag)
            If wiOut Is Nothing Then
                KnifeOut.WI_All = 0 - DouQty
            Else
                KnifeOut.WI_All = wiOut.WI_Qty - DouQty
            End If

            Dim KwInfoOut As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim KwConOut As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            KwInfoOut = KwConOut.KnifeWareInventorySub_GetList(strM_Code, OutWH.Tag)
            If KwInfoOut Is Nothing Then
                Select Case strKnifeType
                    Case "新刀" ''''新刀
                        KnifeOut.WI_SQty = (0 - DouQty)
                        KnifeOut.WI_SReQty = 0
                    Case "待處理" '待處理
                        KnifeOut.WI_SReQty = (0 - DouQty)
                        KnifeOut.WI_SQty = 0
                End Select
            Else
                Select Case strKnifeType
                    Case "新刀" ''''新刀
                        KnifeOut.WI_SQty = (KwInfoOut.WI_SQty - DouQty)
                        KnifeOut.WI_SReQty = KwInfoOut.WI_SReQty
                    Case "待處理" '待處理
                        KnifeOut.WI_SReQty = (KwInfoOut.WI_SReQty - DouQty)
                        KnifeOut.WI_SQty = KwInfoOut.WI_SQty
                End Select
            End If
            KnifeOut.M_Code = strM_Code
            KnifeOut.WH_ID = OutWH.Tag
            KwConOut.KnifeWareInventorySub_Update(KnifeOut)
            '-----------------------------------------------------------------------------------------------
            '-----------------------------------------------------------------------------------------------
            Dim wi1 As List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
            Dim wi2 As List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
            Dim Qty1, Qty2 As Double
            '--------------------------------------------------------------
            wi1 = wiic.WareInventory_GetList3(ds.Tables("KnifeWareMove").Rows(i)("M_Code"), OutWH.Tag, "True")  '發出倉庫
            Qty1 = IIf(wi1.Count = 0, 0, wi1(0).WI_Qty)
            Dim wmi1 As New LFERP.Library.KnifeWare.KnifeWareMoveInfo
            wmi1.MV_NO = txtQuoID.Text
            wmi1.DepotNO = OutWH.Tag
            wmi1.MV_ChangeDepotNO = txtWH.Tag
            wmi1.M_Code = ds.Tables("KnifeWareMove").Rows(i)("M_Code")
            wmi1.MV_EndQty = Qty1
            a.KnifeWareMove_UpdateOutEndQty(wmi1)
            '----------------------------------------------------------------------------------------------
            wi2 = wiic.WareInventory_GetList3(ds.Tables("KnifeWareMove").Rows(i)("M_Code"), txtWH.Tag, "True") '收入倉庫
            Qty2 = IIf(wi2.Count = 0, 0, wi2(0).WI_Qty)
            Dim wmi2 As New LFERP.Library.KnifeWare.KnifeWareMoveInfo
            wmi2.MV_NO = txtQuoID.Text
            wmi2.DepotNO = txtWH.Tag
            wmi2.MV_ChangeDepotNO = OutWH.Tag
            wmi2.M_Code = ds.Tables("KnifeWareMove").Rows(i)("M_Code")
            wmi2.MV_EndQty = Qty2
            a.KnifeWareMove_UpdateInEndQty(wmi2)
            '----------------------------------------------------------------------------------------------
        Next
        MsgBox("審核狀態已改變!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
        Me.Close()
    End Sub
    Private Sub txtWH_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "510308"
        tempValue2 = "510308"
        tempCode = "物料倉庫"
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            txtWH.Tag = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareUpName & "-" & frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If ds.Tables("KnifeWareMove").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "MV_Number")

        If DelTemp = "MV_Number" Then
        Else
            Dim row As DataRow = ds.Tables("DelDataKnifeWareMove").NewRow
            row("MV_Number") = ds.Tables("KnifeWareMove").Rows(GridView2.FocusedRowHandle)("MV_Number")
            ds.Tables("DelDataKnifeWareMove").Rows.Add(row)
        End If
        ds.Tables("KnifeWareMove").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        MsgBox("驗証NO:" & GetMV_NO() & " Number: " & GetMV_Number())
    End Sub

    Private Sub cmdPatchAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatchAdd.Click
        tempCode = ""
        tempValue12 = "B"
        '--------------------------------

        tempValue5 = OutWH.Tag
        tempValue6 = "倉庫管理"
        frmKnifeBOMSelect.ShowDialog()




        If tempValue = Nothing Or tempValue = "" Then
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
            AddRow(arr(i), 0)
        Next

        tempValue = Nothing
        tempValue12 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
    End Sub



    Function CheckWHIDA(ByVal strSelectWHID As String) As Boolean
        CheckWHIDA = False

        Dim strID As String
        ''-------------------------
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510312")
        If pmwiL.Count > 0 Then
            strID = pmwiL.Item(0).PMWS_Value
        Else
            Exit Function
        End If
        ''-------------------------
        Dim arrWHID() As String
        arrWHID = strID.Split(",")
        Dim i As Integer
        For i = 0 To arrWHID.Length - 1
            If strSelectWHID = arrWHID(i) Then
                CheckWHIDA = True
                Exit Function
            Else

            End If
        Next
    End Function



End Class