Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Shared
Imports LFERP.FileManager
Imports LFERP.DataSetting
Imports LFERP.SystemManager
Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.ProductionWareOutMain
Imports LFERP.Library.Purchase.Apply
Imports LFERP.Library.ProductionMaterial
Imports System.Threading
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductionField
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Production.ProductionAffair
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports LFERP.Library.Product




Public Class frmWareOut
    Dim ds As New DataSet
    Dim oldcheck As Boolean
    Dim strWHID As String
    Dim strDPTID As String
    Public isProcess As Boolean '判斷是否是轉發工序
    Public isBarCode As Boolean '判斷是否是條碼掃描
    Dim strPM_M_Code As String
    Dim isShowLCD As Boolean = False  '是否在LCD小屏幕上顯示出庫信息

    Public strPdMachine As Boolean = False


    Dim MsgBZ As String = ""
    Dim LoadM_Code As String = ""

    Dim AllPlus As Boolean = False
    Dim AllowChageQty As Boolean = False  ''可變更開料數

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmWareOut_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If My.Settings.strCOM = "" Or isShowLCD = False Then Exit Sub
        '@ 2013/3/13 添加
        ApiDisplay.display_wellcome()   'LCD顯示屏恢復為初始界面
        ApiDisplay.com_exit() '斷開COM連接
        isOpenCOM = False   'COM打開標記為False
    End Sub

    '@ 2012/8/28 添加 權限控制
    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        '在LCD小顯示屏上顯示信息
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500211")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then isShowLCD = True
        End If

        '顯示“導入申領單”右鍵菜單
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500212")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                popApplyAdd.Visible = True
            Else
                popApplyAdd.Visible = False
            End If
        Else
            popApplyAdd.Visible = True
        End If

        ''---------批量新增2013-5-11---------------------------------------------------------------
        ToolStripBatchLoad.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500214")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripBatchLoad.Visible = True
        End If
        ''------------------------------------------------------------------------
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500217") '加
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then AllPlus = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500218") '加
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then AllowChageQty = True
        End If


    End Sub

    Private Sub frmWareOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New Purchase.SharePurchase.SharePurchaseController

        '@ 2012/7/27 添加　加載收料部門
        Dim pc As New PersonnelControl
        gluDepID.Properties.DataSource = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        gluDepID.Properties.ValueMember = "DepID"
        gluDepID.Properties.DisplayMember = "DepName"

        LoadUserPower()

        LabelMsg.Text = ""
        LoadM_Code = tempValue5


        'If Mid(strInDPT_ID, 1, 4) = "1001" Then
        '    popApplyAdd.Visible = False
        'End If

        If isBarCode = True Then
            Label24.Visible = True
            txtM_Code.Visible = True
            LabelControl1.Visible = True
            popWareOutBarAdd.Visible = False
            txtM_Code.Select()

            If strPdMachine = True Then
                LabelControl1.Text = "(盤點機模式)"
            End If

        End If

        Label3.Text = tempValue
        txtWIPID.EditValue = tempValue2
        tempValue = ""
        tempValue2 = ""

        CreateTables()

        ''重置新刷卡機
        'Dim reset As New ResetPassWords.SetPassWords
        'reset.SetPassWords()
        'txtWIPID.Enabled = False

        If isProcess = True Then
            PS_Name.Visible = True
            gluDepID.Visible = True
            Label23.Visible = True
        End If

        '------------------------------------
        Select Case Label3.Text
            Case "出庫單"
                If Edit = True Then
                    Me.Text = "出庫單修改"
                    loadedit(txtWIPID.EditValue)
                    'txtWH.Enabled = False
                    'ButtonEdit2.Enabled = False
                    'TextEdit1.Enabled = False
                    'DateEdit1.Enabled = False
                    txtWIPID.Enabled = False
                    'getenable(False, False)
                    DateEdit1.Enabled = False
                ElseIf Edit = False Then

                    WO_EndQty_Show.Caption = "當前庫存"

                    Me.Text = "出庫單新增"
                    txtWIPID.EditValue = ""
                    DateEdit1.DateTime = Now
                    'getenable(True, False)
                    cbType.EditValue = "正常"
                    DateEdit1.Enabled = False

                    CheckEdit1.Checked = True  '默認為審核狀態

                    ''---------------------------------------------------------------------------刷卡判斷
                    strWHID = tempValue3
                    txtWH.EditValue = tempValue4
                    tempValue3 = ""
                    tempValue4 = ""

                    Dim wc As New WareHouseController
                    Dim wiL As New List(Of WareHouseInfo)
                    wiL = wc.WareHouse_Get(strWHID)
                    If wiL.Item(0).NeedCheck = False Then
                        TextEdit1.Enabled = True
                        ButtonEdit2.Enabled = True
                        sk.Visible = False
                    Else
                        TextEdit1.Enabled = False
                        ButtonEdit2.Enabled = False
                    End If
                    ''--------------------------------------
                    If LoadM_Code <> "" Then
                        AddRow(LoadM_Code, 0)
                    End If

                End If

                XtraTabControl1.SelectedTabPage = XtraTabPage1

                If strInCompany = "1001" Then
                    Label13.Visible = True
                    txtAPNO.Visible = True
                Else
                    Label13.Visible = False
                    txtAPNO.Visible = False

                End If
            Case "審核"
                loadedit(txtWIPID.EditValue)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                getenable(False, True)
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False


            Case "查看"
                loadedit(txtWIPID.EditValue)
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                getenable(False, False)
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                cmdSave.Enabled = False
            Case "復核"
                loadedit(txtWIPID.EditValue)
                XtraTabControl1.SelectedTabPage = XtraTabPage3
                getenable(False, False)
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

            Case "修改備注" '2013-3-5 修改備注
                Me.Text = "出庫單-修改備注"
                loadedit(txtWIPID.EditValue)
                XtraTabPage1.PageVisible = True
                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = False
                XtraTabPage4.PageVisible = False
                getenable(False, False)
                AP_NO.OptionsColumn.AllowEdit = False
                ButtonEdit2.Enabled = False
                cbType.Enabled = False
                txtOPNO.Enabled = False
                WO_Qty.OptionsColumn.AllowEdit = False

        End Select
        '加載附件供顯示
        GridFile.AutoGenerateColumns = False
        GridFile.RowHeadersWidth = 15
        Dim dt As New FileController
        GridFile.DataSource = dt.FileBond_GetList("5002", txtWIPID.EditValue, Nothing)
        GridFile.Refresh()

        XtraTabPage2.PageVisible = False

        '@ 2013/3/9 添加   倉庫為成品倉時不顯示申購單等信息
        If strWHID = "W1101" Then
            popApplyAdd.Visible = False
            WI_SafeQty_Show.Visible = False
            AP_NO.Visible = False
            M_SendQty.Visible = False
        End If


        If sk.Visible = False Then  ''刷卡按鈕 不可用 就不重置新 2013-4-9
        Else
            '重置新刷卡機
            Dim reset As New ResetPassWords.SetPassWords
            reset.SetPassWords()
            txtWIPID.Enabled = False
        End If

       

    End Sub

    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("WareOut")

            .Columns.Add("WO_NUM", GetType(String))
            .Columns.Add("WO_ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("WO_Qty", GetType(Double))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("WO_Remark", GetType(String))
            .Columns.Add("AP_NO", GetType(String))    '申領單號---載入表  2012/8/28
            .Columns.Add("M_ID", GetType(String))
            .Columns.Add("Temp_Code", GetType(String))
            .Columns.Add("M_SendQty", GetType(Double))         '@ 2012/8/29 添加
            .Columns.Add("C_Qty", GetType(Double))         '@ 2012/10/9 添加
            .Columns.Add("PM_M_Code", GetType(String))    '@ 2013/4/8 添加

            '2012-7-16
            .Columns.Add("WO_EndQty_Show", GetType(Double))
            .Columns.Add("WI_SafeQty_Show", GetType(Double))

            '@ 2012/7/27 
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With

        With ds.Tables.Add("DelDate")
            .Columns.Add("WO_NUM", GetType(String))
            .Columns.Add("WO_ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
        End With

        Grid.DataSource = ds.Tables("WareOut")
    End Sub

    Sub AddRow(ByVal strCode As String, ByVal strQty As Double)

        Dim row As DataRow

        row = ds.Tables("WareOut").NewRow

        If strCode = "" Then

        Else

            Dim j As Integer

            For j = 0 To ds.Tables("WareOut").Rows.Count - 1
                If strCode = ds.Tables("WareOut").Rows(j)("M_Code") Then

                    If isBarCode = True Then
                        ds.Tables("WareOut").Rows(j)("WO_Qty") = ds.Tables("WareOut").Rows(j)("WO_Qty") + strQty

                        '@ 2013/3/13 添加 數量改變時物料信息在LCD顯示屏上重新顯示
                        If isShowLCD = True Then
                            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(j)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(j)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(j)("WO_Qty") & ds.Tables("WareOut").Rows(j)("M_Unit"), "")
                        End If

                        GridView1.FocusedRowHandle = j
                        Exit Sub
                    Else
                        If MsgBZ = "" Then
                            MsgBZ = "Y"
                            MsgBox("物料已存在，同一張出庫單中不允許存在相同的出庫物料！")
                        End If

                        Exit Sub
                    End If

                End If
            Next

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            If objInfo Is Nothing Then
                MsgBox("當前物料不存在，請確認此物料信息！", 64, "提示")
                Exit Sub
            End If
            If objInfo.M_IsEnabled = False Then
                MsgBox("當前物料不可用，請確認此物料信息！", 64, "提示")
                Exit Sub
            End If

            row("WO_NUM") = Nothing
            row("WO_ID") = Nothing

            row("M_Code") = objInfo.M_Code

            row("M_Name") = objInfo.M_Name
            row("PM_M_Code") = strPM_M_Code

            Dim unit As New LFERP.DataSetting.UnitController
            Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

            unitinfo = unit.GetUnitList(objInfo.M_Unit)
            If unitinfo.Count > 0 Then
                row("M_Unit") = unitinfo(0).U_Name
            Else
                row("M_Unit") = ""
            End If

            '2013-11-01
            If GetWH_Remark(strWHID) = "NG" Then
                row("M_Unit") = "KG"
            End If

            'row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge

            row("WO_Qty") = strQty
            row("AP_NO") = ""  '申領單號---普通添加不再在主頁面顯示
            row("M_ID") = ""  '項次  ---針對存在申領單號
            row("Temp_Code") = "" '臨時物料編碼  --針對存在申領單號
            row("PS_NO") = ""


            '2012-7-16 加入顯示安全庫存與節余數-----------------------------
            If strWHID = "W1101" Then    '@ 203/3/9 修改 當選擇的倉庫是成品倉時，顯示的是成品庫存表
                Dim pic As New ProductInventoryController
                Dim piiGet As List(Of ProductInventoryInfo)
                piiGet = pic.ProductInventory_GetList(strPM_M_Code, strCode, strWHID, Nothing)

                If piiGet.Count <= 0 Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = piiGet(0).PI_Qty
                End If
            Else
                Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetSub(strCode, strWHID)

                If wi1 Is Nothing Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = wi1.WI_SafeQty
                    row("WO_EndQty_Show") = wi1.WI_Qty
                End If

                ''針對磨刀部門時W1609待檢倉全部出庫---------------------
                If strWHID = "W1609" Or strWHID = "w1609" Then
                    row("WO_Qty") = wi1.WI_Qty
                End If


            End If






                ''------------------------------------------------------

                ds.Tables("WareOut").Rows.Add(row)

                '@ 2013/3/13 添加 新增的物料信息在LCD顯示屏上顯示
                If isShowLCD = True Then   '有顯示權限時才可顯示
                    LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("WO_Qty") & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Unit"), "")
                End If

        End If
        GridView1.MoveLast()
    End Sub

    Function GetWH_Remark(ByVal strWH_ID As String) As String
        GetWH_Remark = ""
        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_Get(strWH_ID)

        If mtl.Count > 0 Then
            GetWH_Remark = mtl(0).WH_Remark
        End If
    End Function

    Function AddRowPD(ByVal strCode As String, ByVal strQty As Double) As String


        AddRowPD = ""

        Dim row As DataRow

        row = ds.Tables("WareOut").NewRow

        If strCode = "" Then

        Else

            Dim j As Integer

            For j = 0 To ds.Tables("WareOut").Rows.Count - 1
                If strCode = ds.Tables("WareOut").Rows(j)("M_Code") Then

                    If isBarCode = True Then
                        ds.Tables("WareOut").Rows(j)("WO_Qty") = ds.Tables("WareOut").Rows(j)("WO_Qty") + strQty

                        '@ 2013/3/13 添加 數量改變時物料信息在LCD顯示屏上重新顯示
                        If isShowLCD = True Then
                            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(j)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(j)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(j)("WO_Qty") & ds.Tables("WareOut").Rows(j)("M_Unit"), "")
                        End If

                        GridView1.FocusedRowHandle = j
                        Exit Function
                    Else
                        If MsgBZ = "" Then
                            MsgBZ = "Y"
                            'MsgBox("物料已存在，同一張出庫單中不允許存在相同的出庫物料！")
                            AddRowPD = AddRowPD & strCode & "物料已存在，同一張出庫單中不允許存在相同的出庫物料！" + vbCrLf
                        End If

                        Exit Function
                    End If

                End If
            Next

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            If objInfo Is Nothing Then
                'MsgBox("當前物料不存在，請確認此物料信息！", 64, "提示")
                AddRowPD = AddRowPD & strCode & "當前物料不存在，請確認此物料信息！" + vbCrLf
                Exit Function
            End If
            If objInfo.M_IsEnabled = False Then
                AddRowPD = AddRowPD & strCode & "當前物料不可用，請確認此物料信息！" + vbCrLf
                ' MsgBox("當前物料不可用，請確認此物料信息！", 64, "提示")
                Exit Function
            End If

            row("WO_NUM") = Nothing
            row("WO_ID") = Nothing

            row("M_Code") = objInfo.M_Code

            row("M_Name") = objInfo.M_Name
            row("PM_M_Code") = strPM_M_Code

            Dim unit As New LFERP.DataSetting.UnitController
            Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

            unitinfo = unit.GetUnitList(objInfo.M_Unit)
            If unitinfo.Count > 0 Then
                row("M_Unit") = unitinfo(0).U_Name
            Else
                row("M_Unit") = ""
            End If

            'row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge

            row("WO_Qty") = strQty
            row("AP_NO") = ""  '申領單號---普通添加不再在主頁面顯示
            row("M_ID") = ""  '項次  ---針對存在申領單號
            row("Temp_Code") = "" '臨時物料編碼  --針對存在申領單號
            row("PS_NO") = ""


            '2012-7-16 加入顯示安全庫存與節余數-----------------------------
            If strWHID = "W1101" Then    '@ 203/3/9 修改 當選擇的倉庫是成品倉時，顯示的是成品庫存表
                Dim pic As New ProductInventoryController
                Dim piiGet As List(Of ProductInventoryInfo)
                piiGet = pic.ProductInventory_GetList(strPM_M_Code, strCode, strWHID, Nothing)

                If piiGet.Count <= 0 Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = piiGet(0).PI_Qty
                End If
            Else
                Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetSub(strCode, strWHID)

                If wi1 Is Nothing Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = wi1.WI_SafeQty
                    row("WO_EndQty_Show") = wi1.WI_Qty
                End If
            End If
            ''------------------------------------------------------

            ds.Tables("WareOut").Rows.Add(row)

            '@ 2013/3/13 添加 新增的物料信息在LCD顯示屏上顯示
            If isShowLCD = True Then   '有顯示權限時才可顯示
                LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("WO_Qty") & ds.Tables("WareOut").Rows(GridView1.RowCount - 1)("M_Unit"), "")
            End If

        End If
        GridView1.MoveLast()




    End Function


    Sub getenable(ByVal a As Boolean, ByVal b As Boolean)

        txtWH.Enabled = a
        TextEdit1.Enabled = a
        DateEdit1.Enabled = a
        CheckEdit1.Enabled = b
        CheckRemark.Enabled = b
    End Sub

    Sub loadedit(ByVal WO_ID As String)
        ds.Tables("WareOut").Clear()

        Dim objInfo As List(Of WareOutInfo)
        Dim pc As New WareOutController
        Dim i As Integer
        Dim row As DataRow
        Try
            objInfo = pc.WareOut_Getlist5(WO_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                '沒有數據
                Exit Sub
            End If
            'txtAPNO.Text = objInfo(0).AP_NO
            cbType.EditValue = objInfo(0).WO_Type
            strWHID = objInfo(0).WH_ID

            Dim wc As New WareHouseController
            Dim wiL As New List(Of WareHouseInfo)
            wiL = wc.WareHouse_Get(strWHID)
            If wiL.Item(0).NeedCheck = False Then
                TextEdit1.Enabled = True
                ButtonEdit2.Enabled = True
                sk.Visible = False
            Else
                TextEdit1.Enabled = False
                ButtonEdit2.Enabled = False
            End If

            Label15.Text = objInfo(0).WO_Action
            txtWH.EditValue = objInfo(0).WH_Name
            DateEdit1.EditValue = Format(objInfo(0).WO_AddDate, "yyyy/MM/dd")

            strDPTID = objInfo(0).DPT_ID
            ButtonEdit2.EditValue = objInfo(0).DPT_Name

            TextEdit1.EditValue = objInfo(0).WO_PerID
            Label4.Text = objInfo(0).WO_PerName
            CheckEdit1.Checked = objInfo(0).WO_Check
            CheckDate.Text = objInfo(0).WO_CheckDate
            CheckAction.Text = objInfo(0).WO_CheckActionName
            CheckRemark.Text = objInfo(0).WO_CheckRemark

            CheckEdit2.Checked = objInfo(0).WO_ReCheck
            txtrecheckdate.Text = objInfo(0).WO_ReCheckDate
            txtrecheckaction.Text = objInfo(0).WO_ReCheckAction
            txtrecheckremark.Text = objInfo(0).WO_ReCheckRemark

            oldcheck = objInfo(0).WO_Check

            For i = 0 To objInfo.Count - 1
                row = ds.Tables("WareOut").NewRow
                row("WO_NUM") = objInfo(i).WO_NUM
                row("WO_ID") = objInfo(i).WO_ID
                row("M_Code") = objInfo(i).M_Code
                row("M_Name") = objInfo(i).M_Name
                row("M_Gauge") = objInfo(i).M_Gauge
                row("M_Unit") = objInfo(i).M_Unit
                row("WO_Qty") = objInfo(i).WO_Qty
                row("OS_BatchID") = objInfo(i).OS_BatchID
                row("WO_Remark") = objInfo(i).WO_Remark
                row("AP_NO") = objInfo(i).AP_NO   '申領單號
                row("M_ID") = objInfo(i).M_ID
                row("Temp_Code") = objInfo(i).Temp_Code

                Dim api As List(Of ApplyInfo)
                Dim apc As New ApplyControl
                api = apc.Apply_GetList(objInfo(i).AP_NO, objInfo(i).M_ID, Nothing, Nothing)
                If api.Count > 0 Then
                    row("M_SendQty") = api(0).M_SendQty
                Else
                    row("M_SendQty") = objInfo(i).WO_Qty
                End If

                '@ 2012/10/9 添加 顯示開料數量
                If objInfo(0).WO_Type = "生產開料" Then
                    txtOPNO.Text = objInfo(0).OP_NO

                    Dim pli As List(Of ProductionKaiLiaoInfo)
                    Dim plc As New ProductionKaiLiaoControl

                    pli = plc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)
                    If pli.Count > 0 Then
                        C_Qty.VisibleIndex = 6
                        C_Qty.Visible = True
                        row("C_Qty") = pli(0).C_Weight
                    End If
                End If

                '2012-7-16讀取節余數  在審核 保存的，-----------------------------
                row("WO_EndQty_Show") = objInfo(i).WO_EndQty
                ''讀取安全庫存
                Dim wi2 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc2 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi2 = wc2.WareInventory_GetSub(objInfo(i).M_Code, strWHID)


                If wi2 Is Nothing Then
                    row("WI_SafeQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = wi2.WI_SafeQty
                End If
                '’--------------------------------------------------------------------


                ds.Tables("WareOut").Rows.Add(row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function GetWO_ID() As String
        '生成新pm
        Dim pm As New WareOutController
        Dim pi As New WareOutInfo
        Dim ndate As String
        ndate = "WO" + Format(Now(), "yyMM")
        pi = pm.WareOut_GetID(ndate)
        If pi Is Nothing Then
            GetWO_ID = ndate + "00001"
        Else
            GetWO_ID = ndate + Mid((CInt(Mid(pi.WO_ID, 7)) + 100001), 2)
        End If



    End Function

    Function GetWO_NUM() As String
        '生成新pS
        Dim pm As New WareOutController
        Dim pi As New WareOutInfo
        pi = pm.WareOut_GetNUM(Nothing)
        If pi Is Nothing Then
            GetWO_NUM = "O000000001"
        Else
            GetWO_NUM = "O" & Mid((CInt(Mid(pi.WO_NUM, 2)) + 1000000001), 2)
        End If

    End Function

    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        tempCode = ""
        tempValue5 = strWHID
        tempValue6 = "倉庫管理"
        tempValue7 = "出庫作業"
        frmBOMSelect.ShowDialog()

        'AP_NO.OptionsColumn.AllowEdit = True
        'AP_NO.OptionsColumn.ReadOnly = True

        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            '增加記錄
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode, 0)
            End If
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i), 0)
            Next
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then
            Dim i, n As Integer
            Dim arr(n) As String
            strPM_M_Code = tempValue3
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n

                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i), 0)
            Next
        End If
        tempValue7 = ""
        tempValue8 = ""
        tempValue3 = ""
    End Sub

    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If ds.Tables("WareOut").Rows.Count = 0 Then Exit Sub


        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")

        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelDate").NewRow
            'row("M_CodeSub") = CodeSubData.Tables("CodeSub").Rows(GridView1.FocusedRowHandle)("M_CodeSub")
            row("WO_NUM") = ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_NUM")
            row("WO_ID") = ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_ID")
            row("M_Code") = DelTemp
            ds.Tables("DelDate").Rows.Add(row)
        End If
        ds.Tables("WareOut").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label3.Text
            Case "出庫單"
                If Edit = False Then
                    If CheckSave() = True Then
                        SaveDataNew()
                        cmdSave.Enabled = False
                        cmdPrint.Visible = True
                    End If
                ElseIf Edit = True Then
                    SaveDataEdit()
                    cmdSave.Enabled = False
                    cmdPrint.Visible = True
                End If
            Case "審核"
                UpdateCheck()
            Case "復核"
                UpdateReCheck()

            Case "修改備注"

                Update_Remark()
        End Select
    End Sub

    Function GetNO() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetNO = "PF" & strA & "000001"
        Else
            GetNO = "PF" + strA + Mid((CInt(Mid(pi.FP_NO, 7)) + 1000001), 2)
        End If

    End Function

    Function GetNum() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetNum = strA & "000001"
        Else
            GetNum = strA + Mid((CInt(Mid(pi.FP_Num, 5)) + 1000001), 2)
        End If

    End Function

    Sub SaveDataNew()
     

        Dim mc As New WareOutController
        Dim mi As New WareOutInfo

        Dim i, l As Integer

        txtWIPID.EditValue = GetWO_ID()

        If Len(txtWIPID.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存！")
            Exit Sub
        End If

        '@ 2012/7/27 添加
        '-------------------------------------------------------------------------物料收發添加
        If isProcess = True Then
            Dim pfi As New ProductionFieldInfo
            Dim pfc As New ProductionFieldControl

            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)

            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc As New ProductionDPTWareInventoryControl

            Dim pai As New ProductionAffairInfo
            Dim pac As New ProductionAffairControl

            Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
            Dim pdsc As New ProductionFieldDaySummaryControl

            For l = 0 To ds.Tables("WareOut").Rows.Count - 1
                pci = pic.ProcessSub_GetList(Nothing, ds.Tables("WareOut").Rows(l)("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing)

                If pci.Count = 0 Then Exit Sub

                Dim AllWeight, strWeight, strG As Double

                strWeight = pci(0).PS_Weight  '克/個  單重
                strG = strWeight * ds.Tables("WareOut").Rows(l)("WO_Qty").ToString
                AllWeight = strG / 1000  '當前數量的重量(KG)

                pdi = pdc.ProductionDPTWareInventory_GetList(gluDepID.EditValue, ds.Tables("WareOut").Rows(l)("PS_NO").ToString, Nothing)

                pfi.FP_NO = GetNO()
                pfi.FP_Num = GetNum()
                pfi.Pro_Type = pci(0).Pro_Type
                pfi.PM_M_Code = pci(0).PM_M_Code
                pfi.PM_Type = pci(0).Type3ID

                pfi.Pro_NO = ds.Tables("WareOut").Rows(l)("PS_NO").ToString
                pfi.FP_OutDep = gluDepID.EditValue
                pfi.FP_InDep = strWHID
                pfi.FP_Qty = ds.Tables("WareOut").Rows(l)("WO_Qty").ToString
                pfi.FP_Weight = Format(AllWeight, "0.00") '(轉化為兩位小數)

                pfi.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
                pfi.FP_Detail = "PT03"
                pfi.FP_OutAction = InUserID
                pfi.FP_Remark = txtWIPID.EditValue
                pfi.IW_NO = ""
                pfi.CardID = TextEdit1.Text


                pfi.FP_Check = True
                pfi.FP_CheckAction = InUserID
                pfi.FP_CheckRemark = "倉庫物料轉發工序"

                If pfc.ProductionField_InAdd(pfi) = True Then
                    pfc.ProductionField_UpdateCheck(pfi)

                    pai.FP_NO = pfi.FP_NO
                    pai.Pro_Type = pci(0).Pro_Type
                    pai.PM_M_Code = pci(0).PM_M_Code
                    pai.PM_Type = pci(0).Type3ID
                    pai.Pro_NO = ds.Tables("WareOut").Rows(l)("PS_NO").ToString

                    pai.FP_OutDep = gluDepID.EditValue
                    'pai.FP_InDep = gluDepID.EditValue
                    pai.FP_Detail = "PT03"
                    pai.FP_Type = "收料"
                    pai.FP_InAction = InUserID

                    pai.FP_InCheck = True
                    pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    pai.CardID = TextEdit1.Text

                    pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("WareOut").Rows(l)("PS_NO").ToString, gluDepID.EditValue, Nothing, DateEdit1.Text, DateEdit1.Text)

                    If pdsi.Count <= 0 Then
                        pai.ShouLiao = ds.Tables("WareOut").Rows(l)("WO_Qty").ToString
                    Else
                        pai.ShouLiao = pdsi(0).ShouLiao + ds.Tables("WareOut").Rows(l)("WO_Qty").ToString
                        pai.JiaCun = pdsi(0).JiaCun
                        pai.QuCun = pdsi(0).QuCun
                        pai.FaLiao = pdsi(0).FaLiao
                        pai.CunHuo = pdsi(0).CunHuo

                        pai.FanXiuIn = pdsi(0).FanXiuIn
                        pai.FanXiuOut = pdsi(0).FanXiuOut
                        pai.LiuBan = pdsi(0).LiuBan
                        pai.SunHuai = pdsi(0).SunHuai
                        pai.DiuShi = pdsi(0).DiuShi

                        pai.BuNiang = pdsi(0).BuNiang
                        pai.CunCang = pdsi(0).CunCang
                        pai.QuCang = pdsi(0).QuCang
                        pai.ChuHuo = pdsi(0).ChuHuo
                        pai.WaiFaIn = pdsi(0).WaiFaIn

                        pai.WaiFaOut = pdsi(0).WaiFaOut
                        pai.AccIn = pdsi(0).AccIn
                        pai.AccOut = pdsi(0).AccOut
                        pai.RePairOut = pdsi(0).RePairOut
                        pai.ZuheOut = pdsi(0).ZuheOut
                    End If

                    pai.PM_Date = Format(Now, "yyyy/MM/dd")

                    pai.WI_Qty = pdi(0).WI_Qty + ds.Tables("WareOut").Rows(l)("WO_Qty").ToString
                    pai.WI_ReQty = pdi(0).WI_ReQty

                    pac.UpdateProductionCheck_Qty(pai)
                End If
            Next
        End If



        mi.WO_ID = txtWIPID.EditValue
        mi.WO_Type = cbType.EditValue
        'mi.AP_NO = txtAPNO.Text
        mi.OP_NO = txtOPNO.Text
        mi.WH_ID = strWHID
        mi.WO_AddDate = Format(Now, "yyyy/MM/dd")
        mi.WO_Action = InUserID

        mi.DPT_ID = strDPTID

        'mi.DPT_ID = ButtonEdit2.EditValue

        If Len(TextEdit1.EditValue) = 0 Then
            mi.WO_PerID = Nothing

        Else
            mi.WO_PerID = TextEdit1.EditValue
        End If
        If Len(Label4.Text) = 0 Then
            mi.WO_PerName = Nothing

        Else
            mi.WO_PerName = Label4.Text
        End If

        '----------------------------------------------------
        mi.WO_Check = CheckEdit1.Checked
        mi.WO_CheckAction = InUserID
        mi.WO_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        mi.WO_CheckRemark = CheckRemark.Text
        '----------------------------------------------------

        For i = 0 To ds.Tables("WareOut").Rows.Count - 1
            mi.WO_NUM = GetWO_NUM()
            If IsDBNull(ds.Tables("WareOut").Rows(i)("M_Code")) Then
                mi.M_Code = Nothing
            Else
                mi.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")
            End If

            If IsDBNull(ds.Tables("WareOut").Rows(i)("OS_BatchID")) Then
                mi.OS_BatchID = Nothing
            Else
                mi.OS_BatchID = ds.Tables("WareOut").Rows(i)("OS_BatchID")
            End If


            mi.WO_Qty = CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))

            If IsDBNull(ds.Tables("WareOut").Rows(i)("WO_Remark")) Then
                mi.WO_Remark = Nothing
            Else
                mi.WO_Remark = ds.Tables("WareOut").Rows(i)("WO_Remark")
            End If

            '---------申領單號載入，無 為空，存在則載入值或者手工輸入

            If IsDBNull(ds.Tables("WareOut").Rows(i)("AP_NO")) Then

                mi.AP_NO = Nothing
            Else
                mi.AP_NO = ds.Tables("WareOut").Rows(i)("AP_NO")

            End If


            If IsDBNull(ds.Tables("WareOut").Rows(i)("M_ID")) Then

                mi.M_ID = Nothing
            Else
                mi.M_ID = ds.Tables("WareOut").Rows(i)("M_ID")

            End If

            If IsDBNull(ds.Tables("WareOut").Rows(i)("Temp_Code")) Then

                mi.Temp_Code = Nothing
            Else
                mi.Temp_Code = ds.Tables("WareOut").Rows(i)("Temp_Code")

            End If

            mc.WareOut_Add(mi)

        Next


        '-------------------------------------------------------------------------
        If CheckEdit1.Checked = True Then

            'Dim j As Integer
            Dim Qty As Double
            Dim dblWIP_EndQty As Double

            For i = 0 To ds.Tables("WareOut").Rows.Count - 1
                If strWHID = "W1101" Then            '@ 2013/3/9 修改 當選擇的倉庫是成品倉時，顯示成品庫存表
                    Dim pic As New ProductInventoryController
                    Dim piiSet As New ProductInventoryInfo
                    piiSet.WH_ID = strWHID
                    piiSet.PM_M_Code = ds.Tables("WareOut").Rows(i)("PM_M_Code")
                    piiSet.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

                    Dim piiGet As List(Of ProductInventoryInfo)
                    piiGet = pic.ProductInventory_GetList(ds.Tables("WareOut").Rows(i)("PM_M_Code"), ds.Tables("WareOut").Rows(i)("M_Code"), strWHID, Nothing)

                    If piiGet.Count <= 0 Then
                        Qty = 0
                    Else
                        Qty = piiGet(0).PI_Qty
                    End If

                    piiSet.PI_Qty = Qty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))

                    dblWIP_EndQty = piiSet.PI_Qty

                    pic.ProductInventory_Update(piiSet)
                Else
                    Dim mt As New SharePurchaseController
                    Dim mm As New SharePurchaseInfo

                    mm.WH_ID = strWHID
                    mm.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")


                    Dim wi As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                    Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                    wi = wc.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)

                    If wi Is Nothing Then
                        Qty = 0
                    Else
                        Qty = wi.WI_Qty
                    End If

                    mm.WI_Qty = Qty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))

                    dblWIP_EndQty = mm.WI_Qty

                    mt.UpdateWareInventory_WIQty2(mm)   '扣數當前倉庫庫存
                End If



                'Dim tii As New DataSetting.TransferInventoryInfo
                'Dim tic As New DataSetting.TransferInventoryControl

                'tii.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")
                'tii.M_Qty = mm.WI_Qty
                'tii.M_Bit = False

                'tic.TransferInventory_Add(tii)

                '-------------------變更當前結餘數-------------------------------
                Dim info As New WareOutInfo
                info.WO_ID = txtWIPID.Text
                info.WH_ID = strWHID
                info.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

                info.WO_EndQty = dblWIP_EndQty

                mc.WareOut_UpdateEndQty(info)
                '--------------------------------------------------
            Next
            '--------------------------------------------------------------------生產開料記錄信息---主要是跟蹤生產原材料使用狀況

            Dim pi As New ProductionMaterialInfo '原材料領料數記錄
            Dim pc As New ProductionMaterialControl
            Dim pi1 As List(Of ProductionMaterialInfo)

            Dim pki As List(Of ProductionKaiLiaoInfo) '開料信息
            Dim pkc As New ProductionKaiLiaoControl

            If cbType.EditValue = "生產開料" Then

                Dim m As Integer
                For m = 0 To ds.Tables("WareOut").Rows.Count - 1

                    pki = pkc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)

                    If pki.Count > 0 Then
                        Dim k As Integer
                        For k = 0 To pki.Count - 1

                            '判斷當前是否存在有此生產開料信息記錄
                            pi1 = pc.ProductionMaterial_GetList(pki(k).Pro_Type, pki(k).PM_M_Code, pki(k).PM_Type, pki(k).M_Code)
                            Dim MaterialQty As Single '定義初始化數量/重量信息

                            If pi1.Count = 0 Then
                                MaterialQty = 0
                            Else
                                MaterialQty = pi1(0).M_Qty  '初始信息
                            End If

                            pi.Pro_Type = pki(k).Pro_Type
                            pi.PM_M_Code = pki(k).PM_M_Code
                            pi.PM_Type = pki(k).PM_Type
                            pi.M_Code = pki(k).M_Code
                            pi.M_Qty = MaterialQty + CDbl(ds.Tables("WareOut").Rows(m)("WO_Qty"))

                            pc.UpdateProductionMaterialQty(pi)  '記錄當前此產品生產開料庫存信息狀況

                        Next

                    End If

                Next

            End If



            '  --------------------------------------------------------------------申領單號記錄信息
            Dim ti As New TransferModuleInfo
            Dim tc As New TransferModuleControl


            Dim ai As List(Of ApplyInfo)
            Dim ac As New ApplyControl
            Dim ai1 As New ApplyInfo

            Dim j As Integer
            For j = 0 To ds.Tables("WareOut").Rows.Count - 1

                If ds.Tables("WareOut").Rows(j)("M_ID") = "" Then
                Else


                    ai = ac.Apply_GetList(ds.Tables("WareOut").Rows(j)("AP_NO"), ds.Tables("WareOut").Rows(j)("M_ID"), Nothing, Nothing)

                    If ai.Count > 0 Then

                        Dim SngA As Single

                        Dim m As Integer
                        For m = 0 To ai.Count - 1
                            SngA = ai(0).M_SendQty
                        Next

                        '-----------------------------變更當前申領單中發出數量記錄--------------------------------------------------
                        ai1.AM_ID = ds.Tables("WareOut").Rows(j)("AP_NO")
                        ai1.M_ID = ds.Tables("WareOut").Rows(j)("M_ID")
                        ai1.M_Code = ds.Tables("WareOut").Rows(j)("M_Code")
                        'ai1.M_SendQty = SngA + CSng(ds.Tables("WareOut").Rows(j)("WO_Qty"))

                        ''2012-9-4 加如果有轉物料編碼的情況，次將申領單中的領單數量 ，發貨數量進行更改

                        If ai(0).M_Code = ds.Tables("WareOut").Rows(j)("M_Code") Then
                            ai1.M_Qty = ai(0).M_Qty
                            ai1.M_SendQty = SngA + CDbl(ds.Tables("WareOut").Rows(j)("WO_Qty"))
                        Else
                            ai1.M_Qty = CDbl(ds.Tables("WareOut").Rows(j)("WO_Qty"))
                            ai1.M_SendQty = CDbl(ds.Tables("WareOut").Rows(j)("WO_Qty"))
                        End If



                        ac.Apply_UpdateQty(ai1)


                        '修改日期　 2012-06-19  當前使用新的記錄當前物料實時庫存信息 此模塊不再使用 
                        '-------------------------------------------------------------------------------
                        '-------------------------------------------------------------------------------
                        Dim SngB As Double

                        SngB = ai1.M_SendQty

                        ti.ModuleID = "出庫作業"
                        ti.ModuleDetail = ds.Tables("WareOut").Rows(j)("AP_NO") & "," & ds.Tables("WareOut").Rows(j)("M_ID") & "," & ds.Tables("WareOut").Rows(j)("M_Code") & "," & SngB & "," & ds.Tables("WareOut").Rows(j)("Temp_Code") & "," & ds.Tables("WareOut").Rows(j)("WO_Remark")
                        ti.ModuleRemark = txtWIPID.Text & ds.Tables("WareOut").Rows(j)("AP_NO")
                        tc.TransferModule_Add(ti)

                    End If


                End If

            Next
            '----------------------------------------------------------------------

        End If


            '-------------------------------------------------------------------------
    End Sub

    Sub SaveDataEdit()
        On Error Resume Next

        If Len(txtWH.EditValue) = 0 Then
            MsgBox("請選擇倉庫")
            Exit Sub
        End If
        If Len(ButtonEdit2.EditValue) = 0 Then
            MsgBox("請選擇部門")
            Exit Sub
        End If

        If ds.Tables("WareOut").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            Exit Sub
        End If

        If Len(txtWIPID.EditValue) = 0 Then
            MsgBox("單號為空，無法保存！")
            Exit Sub
        End If

        Dim i As Integer
        '查詢是否相應的倉庫中夠數
        Dim mw As New WareInventory.WareInventoryMTController
        Dim mwi As New WareInventory.WareInventoryInfo
        For i = 0 To ds.Tables("WareOut").Rows.Count - 1

            mwi = mw.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)
            If mwi Is Nothing Then
                MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不存在，不能保存！")
                Exit Sub
            End If

            If mwi.WI_Qty < CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) Then
                MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不夠數，不能保存！")
                Exit Sub
            End If
        Next


        '更新刪除的記錄
        If ds.Tables("DelDate").Rows.Count > 0 Then
            Dim ii As Integer
            For ii = 0 To ds.Tables("DelDate").Rows.Count - 1

                Dim mc2 As New WareOutController
                If Not IsDBNull(ds.Tables("DelDate").Rows(ii)("WO_NUM")) Then
                    mc2.WareOut_Delete(ds.Tables("DelDate").Rows(ii)("WO_NUM"), Nothing)
                End If
            Next ii
        End If




        Dim mc As New WareOutController
        Dim mi As New WareOutInfo



        mi.WO_ID = txtWIPID.EditValue
        mi.WO_Type = cbType.EditValue
        'mi.AP_NO = txtAPNO.Text
        mi.OP_NO = txtOPNO.Text
        mi.WH_ID = strWHID
        mi.WO_AddDate = DateEdit1.EditValue
        mi.WO_Action = Label15.Text

        mi.DPT_ID = strDPTID

        'mi.DPT_ID = ButtonEdit2.EditValue
        mi.WO_PerID = TextEdit1.EditValue
        mi.WO_PerName = Label4.Text


        '----------------------------------------------------  修改審核信息
        mi.WO_Check = CheckEdit1.Checked
        mi.WO_CheckAction = InUserID
        mi.WO_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        mi.WO_CheckRemark = CheckRemark.Text
        '----------------------------------------------------

        For i = 0 To ds.Tables("WareOut").Rows.Count - 1
            If IsDBNull(ds.Tables("WareOut").Rows(i)("WO_NUM")) Then   '新增
                mi.WO_NUM = GetWO_NUM()
                mi.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

                mi.OS_BatchID = ds.Tables("WareOut").Rows(i)("OS_BatchID")
                mi.WO_Qty = CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))
                mi.WO_Remark = ds.Tables("WareOut").Rows(i)("WO_Remark")

                '---------申領單號載入，無 為空，存在則載入值或者手工輸入

                If IsDBNull(ds.Tables("WareOut").Rows(i)("AP_NO")) Then

                    mi.AP_NO = Nothing
                Else
                    mi.AP_NO = ds.Tables("WareOut").Rows(i)("AP_NO")

                End If

                If IsDBNull(ds.Tables("WareOut").Rows(i)("M_ID")) Then

                    mi.M_ID = Nothing
                Else
                    mi.M_ID = ds.Tables("WareOut").Rows(i)("M_ID")

                End If

                If IsDBNull(ds.Tables("WareOut").Rows(i)("Temp_Code")) Then

                    mi.Temp_Code = Nothing
                Else
                    mi.Temp_Code = ds.Tables("WareOut").Rows(i)("Temp_Code")

                End If

                mc.WareOut_Add(mi)
            ElseIf Not IsDBNull(ds.Tables("WareOut").Rows(i)("WO_NUM")) Then ' 修改
                mi.WO_NUM = ds.Tables("WareOut").Rows(i)("WO_NUM")
                mi.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

                mi.OS_BatchID = ds.Tables("WareOut").Rows(i)("OS_BatchID")
                mi.WO_Qty = CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))
                mi.WO_Remark = ds.Tables("WareOut").Rows(i)("WO_Remark")
                mi.WO_EditDate = Format(Now, "yyyy/MM/dd")


                '---------申領單號載入，無 為空，存在則載入值或者手工輸入

                If IsDBNull(ds.Tables("WareOut").Rows(i)("AP_NO")) Then

                    mi.AP_NO = Nothing
                Else
                    mi.AP_NO = ds.Tables("WareOut").Rows(i)("AP_NO")

                End If

                If IsDBNull(ds.Tables("WareOut").Rows(i)("M_ID")) Then

                    mi.M_ID = Nothing
                Else
                    mi.M_ID = ds.Tables("WareOut").Rows(i)("M_ID")

                End If

                If IsDBNull(ds.Tables("WareOut").Rows(i)("Temp_Code")) Then

                    mi.Temp_Code = Nothing
                Else
                    mi.Temp_Code = ds.Tables("WareOut").Rows(i)("Temp_Code")

                End If
                mc.WareOut_Update(mi)
            End If
        Next

        If oldcheck = True Then
            MsgBox("此單已審核!")
            Exit Sub
        Else
            '-------------------------------------------------------------------------
            If CheckEdit1.Checked = True Then

                Dim mt As New SharePurchaseController
                Dim mm As New SharePurchaseInfo

                mm.WH_ID = strWHID

                For i = 0 To ds.Tables("WareOut").Rows.Count - 1
                    mm.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

                    Dim Qty As Double

                    Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                    Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                    wi = wc.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)

                    If wi Is Nothing Then
                        Qty = 0
                    Else
                        Qty = wi.WI_Qty
                    End If

                    mm.WI_Qty = Qty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))
                    mt.UpdateWareInventory_WIQty2(mm)

                Next

                '--------------------------------------------------------------------生產開料記錄信息---主要是跟蹤生產原材料使用狀況

                Dim pi As New ProductionMaterialInfo '原材料領料數記錄
                Dim pc As New ProductionMaterialControl
                Dim pi1 As List(Of ProductionMaterialInfo)

                Dim pki As List(Of ProductionKaiLiaoInfo) '開料信息
                Dim pkc As New ProductionKaiLiaoControl

                If cbType.EditValue = "生產開料" Then

                    Dim m As Integer
                    For m = 0 To ds.Tables("WareOut").Rows.Count - 1

                        pki = pkc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)

                        If pki.Count > 0 Then
                            Dim k As Integer
                            For k = 0 To pki.Count - 1

                                '判斷當前是否存在有此生產開料信息記錄
                                pi1 = pc.ProductionMaterial_GetList(pki(k).Pro_Type, pki(k).PM_M_Code, pki(k).PM_Type, pki(k).M_Code)
                                Dim MaterialQty As Double '定義初始化數量/重量信息

                                If pi1.Count = 0 Then
                                    MaterialQty = 0
                                Else
                                    MaterialQty = pi1(0).M_Qty  '初始信息
                                End If

                                pi.Pro_Type = pki(k).Pro_Type
                                pi.PM_M_Code = pki(k).PM_M_Code
                                pi.PM_Type = pki(k).PM_Type
                                pi.M_Code = pki(k).M_Code
                                pi.M_Qty = MaterialQty + CDbl(ds.Tables("WareOut").Rows(m)("WO_Qty"))

                                pc.UpdateProductionMaterialQty(pi)  '記錄當前此產品生產開料庫存信息狀況

                            Next

                        End If

                    Next

                End If

                '-----------------------------------------------------------------------------申領單號記錄信息
                Dim ti As New TransferModuleInfo
                Dim tc As New TransferModuleControl

                Dim ai As List(Of ApplyInfo)
                Dim ac As New ApplyControl
                Dim ai1 As New ApplyInfo

                Dim j As Integer
                For j = 0 To ds.Tables("WareOut").Rows.Count - 1

                    If ds.Tables("WareOut").Rows(j)("M_ID") = "" Then
                    Else


                        ai = ac.Apply_GetList(ds.Tables("WareOut").Rows(j)("AP_NO"), ds.Tables("WareOut").Rows(j)("M_ID"), Nothing, Nothing)

                        If ai.Count > 0 Then

                            Dim SngA As Double

                            'Dim m As Integer
                            'For m = 0 To ai.Count - 1
                            SngA = ai(0).M_SendQty  '若存在--則只有一條記錄
                            'Next
                            '-----------------------------變更當前申領單中發出數量記錄--------------------------------------------------
                            ai1.AM_ID = ds.Tables("WareOut").Rows(j)("AP_NO")
                            ai1.M_ID = ds.Tables("WareOut").Rows(j)("M_ID")
                            ai1.M_Code = ds.Tables("WareOut").Rows(j)("M_Code")
                            ai1.M_SendQty = SngA + CDbl(ds.Tables("WareOut").Rows(j)("WO_Qty"))

                            ac.Apply_UpdateQty(ai1)
                            '-------------------------------------------------------------------------------
                            '修改日期　 2012-06-19  當前使用新的記錄當前物料實時庫存信息,
                            '此模塊當前只對申領單，發貨數量進行記錄, 已確定當前申領單是否已完成
                            '-------------------------------------------------------------------------------
                            Dim SngB As Double

                            SngB = ai1.M_SendQty

                            ti.ModuleID = "出庫作業"
                            ti.ModuleDetail = ds.Tables("WareOut").Rows(j)("AP_NO") & "," & ds.Tables("WareOut").Rows(j)("M_ID") & "," & ds.Tables("WareOut").Rows(j)("M_Code") & "," & SngB & "," & ds.Tables("WareOut").Rows(j)("Temp_Code") & "," & ds.Tables("WareOut").Rows(j)("WO_Remark")
                            ti.ModuleRemark = txtWIPID.Text & ds.Tables("WareOut").Rows(j)("AP_NO")

                            tc.TransferModule_Add(ti)

                        End If

                    End If

                Next
                '-----------------------------------------------------------------------------

            End If
        End If

    End Sub

    Sub UpdateCheck()

        Dim i As Integer

        If oldcheck = CheckEdit1.Checked Then
            MsgBox("審核狀態未改變，請更改狀態後再保存……")
            Exit Sub
        End If

        'If CheckEdit1.Checked = True Then
        '    Dim mw As New WareInventory.WareInventoryMTController
        '    Dim mwi As New WareInventory.WareInventoryInfo

        '    For i = 0 To ds.Tables("WareOut").Rows.Count - 1
        '        '查詢是否相應的倉庫中夠數
        '        mwi = mw.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)

        '        If mwi Is Nothing Then
        '            MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不存在，不能保存！")
        '            Exit Sub
        '        End If

        '        If mwi.WI_Qty < CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) Then
        '            MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不夠數，不能保存！")
        '            Exit Sub
        '        End If
        '    Next
        'End If


        Dim mc As New WareOutController
        Dim mi As New WareOutInfo
        mi.WO_ID = txtWIPID.EditValue
        mi.WO_Check = CheckEdit1.Checked
        mi.WO_CheckAction = InUserID
        mi.WO_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        mi.WO_CheckRemark = CheckRemark.Text
        If mc.WareOut_UpdateCheck(mi) = False Then
            MsgBox("取消審核失敗,請檢查原因!")
            Exit Sub
        End If

        Dim mt As New SharePurchaseController
        Dim mm As New SharePurchaseInfo

        mm.WH_ID = strWHID

        For i = 0 To ds.Tables("WareOut").Rows.Count - 1
            mm.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")

            Dim Qty As Double
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)

            If wi Is Nothing Then
                Qty = 0
            Else
                Qty = wi.WI_Qty
            End If

            If CheckEdit1.Checked = False Then
                mm.WI_Qty = Qty + CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))
                'ElseIf CheckEdit1.Checked = True Then
                '    mm.WI_Qty = Qty - CSng(ds.Tables("WareOut").Rows(i)("WO_Qty"))
            End If
            mt.UpdateWareInventory_WIQty2(mm)

            '--------------------------------------------------------------------生產開料記錄信息---主要是跟蹤生產原材料使用狀況

            Dim pi As New ProductionMaterialInfo '原材料領料數記錄
            Dim pc As New ProductionMaterialControl
            Dim pi1 As List(Of ProductionMaterialInfo)

            Dim pki As List(Of ProductionKaiLiaoInfo) '開料信息
            Dim pkc As New ProductionKaiLiaoControl

            If cbType.EditValue = "生產開料" Then


                pki = pkc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)

                If pki.Count > 0 Then
                    Dim k As Integer
                    For k = 0 To pki.Count - 1

                        '判斷當前是否存在有此生產開料信息記錄
                        pi1 = pc.ProductionMaterial_GetList(pki(k).Pro_Type, pki(k).PM_M_Code, pki(k).PM_Type, pki(k).M_Code)
                        Dim MaterialQty As Double '定義初始化數量/重量信息

                        If pi1.Count = 0 Then
                            MaterialQty = 0
                        Else
                            MaterialQty = pi1(0).M_Qty  '初始信息
                        End If

                        pi.Pro_Type = pki(k).Pro_Type
                        pi.PM_M_Code = pki(k).PM_M_Code
                        pi.PM_Type = pki(k).PM_Type
                        pi.M_Code = pki(k).M_Code
                        pi.M_Qty = MaterialQty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))

                        pc.UpdateProductionMaterialQty(pi)  '變更當前此產品生產開料庫存信息狀況

                    Next

                End If

            End If

            '-----------------------------------變更存在有申領單記錄狀況----------------------
            Dim ai As New ApplyInfo
            Dim aii As List(Of ApplyInfo)
            Dim ac As New ApplyControl

            If ds.Tables("WareOut").Rows(i)("M_ID") = "" Then
            Else
                aii = ac.Apply_GetList(ds.Tables("WareOut").Rows(i)("AP_NO"), ds.Tables("WareOut").Rows(i)("M_ID"), Nothing, Nothing)

                If aii.Count = 0 Then

                Else
                    ai.AM_ID = ds.Tables("WareOut").Rows(i)("AP_NO")
                    ai.M_ID = ds.Tables("WareOut").Rows(i)("M_ID")
                    ai.M_Code = ds.Tables("WareOut").Rows(i)("M_Code")
                    ai.M_SendQty = aii(0).M_SendQty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty"))

                    ac.Apply_UpdateQty(ai)

                End If

            End If

            '-----------------------------------------------------------------------------------

        Next


        Dim fi As New TransferModuleInfo
        Dim fc As New TransferModuleControl

        fi.ModuleID = "出庫作業"
        fi.ModuleRemark = txtWIPID.Text

        fc.TransferModule_Delete(fi.ModuleID, fi.ModuleRemark) '刪除當前取消過的申領單號記錄信息

        Me.Close()

    End Sub

    Sub UpdateReCheck()

        Dim mc As New WareOutController
        Dim mi As New WareOutInfo
        mi.WO_ID = txtWIPID.EditValue
        mi.WO_ReCheck = CheckEdit2.Checked
        mi.WO_ReCheckAction = InUserID
        mi.WO_ReCheckDate = Format(Now, "yyyy/MM/dd")
        mi.WO_ReCheckRemark = txtrecheckremark.Text
        If mc.WareOut_UpdateReCheck(mi) = False Then
            MsgBox("復核失敗,請檢查原因!")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub popWareOutBarAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutBarAdd.Click
        tempValue4 = Me.strWHID
        FrmBarCodeInput.ds.Tables.Clear()
        FrmBarCodeInput.ShowDialog()
        If FrmBarCodeInput.ds.Tables("BarCode").Rows.Count <> 0 Then
            Dim i As Integer
            For i = 0 To FrmBarCodeInput.ds.Tables("BarCode").Rows.Count - 1
                If IsDBNull(FrmBarCodeInput.ds.Tables("BarCode").Rows(i)("M_Code")) Then
                Else
                    AddRow(FrmBarCodeInput.ds.Tables("BarCode").Rows(i)("M_Code"), FrmBarCodeInput.ds.Tables("BarCode").Rows(i)("WIP_Qty"))
                End If
            Next
        End If

    End Sub

    'Private Sub TextEdit1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.LostFocus
    'On Error Resume Next

    'Dim mt As New LFERP.DataSetting.EmployeControler
    'Dim mc As New LFERP.DataSetting.EmployeInfo
    'Dim uc As New LFERP.SystemManager.SystemUser.SystemUserController
    'If Trim(TextEdit1.EditValue) = "" Then      '@ 2012/2/14添加判斷TextEdit1.EditValue是否為空
    '    Exit Sub
    'End If

    'mc = mt.Employe_Get(TextEdit1.EditValue)
    'If mc Is Nothing Then
    '    Exit Sub
    'Else
    '    Label4.Text = mc.Employe_Name
    '    Dim wulc As New WhiteUserListController
    '    Dim wuliL As New List(Of WhiteuserListInfo)
    '    wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Mid(strWHID, 1, 3))
    '    'If wuliL.Count = 0 Then
    '    '    cmdSave.Text = "非法卡號"
    '    '    cmdSave.Enabled = False
    '    '    Exit Sub
    '    'End If
    '    Label4.Text = wuliL.Item(0).W_UserName
    '    If wuliL.Item(0).DPT_ID = "" Then
    '        'strDPTID = ""
    '        'ButtonEdit2.Text = ""
    '        'ButtonEdit2.Enabled = True
    '        TextEdit1.Enabled = False
    '    Else
    '        strDPTID = wuliL.Item(0).DPT_ID
    '        ButtonEdit2.Text = wuliL.Item(0).DPT_Name
    '        ButtonEdit2.Enabled = False
    '        TextEdit1.Enabled = False
    '    End If
    'End If

    'End Sub

    Private Sub cmdBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarCode.Click
        'Dim i, m As Integer
        'For i = 0 To ds.Tables("WareOut").Rows.Count - 1
        '    Dim str1, str2, str3, str4, str5, str6, str7 As String

        '    str1 = ds.Tables("WareOut").Rows(i)("M_Code")
        '    str2 = ds.Tables("WareOut").Rows(i)("M_Name")
        '    str3 = Nothing
        '    str4 = ds.Tables("WareOut").Rows(i)("M_Unit")
        '    str5 = ds.Tables("WareOut").Rows(i)("MO_Qty")
        '    str6 = Format(DateEdit1.DateTime, "Short Date")
        '    str7 = ds.Tables("WareOut").Rows(i)("OS_BatchID")


        '    Dim whc As New WareHouseController
        '    Dim whiL As New List(Of WareHouseInfo)
        '    whiL = whc.WareHouse_GetList(Nothing)
        '    For m = 0 To whiL.Count - 1
        '        If whiL.Item(m).WH_ID = txtWH.Text Then
        '            If whiL.Item(m).PrintBulk = "大" Then
        '                PrintBar(str1, str2, str3, str4, str5, str6, str7)
        '            End If

        '            If whiL.Item(m).PrintBulk = "小" Then
        '                PrintBar2(str1, str2)
        '            End If
        '            Exit For
        '        End If
        '    Next

        'Next
        tempValue3 = "出庫作業"
        tempValue4 = txtWIPID.EditValue
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
    End Sub

    Private Sub ButtonEdit2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit2.ButtonClick
        '' ''frmDepartmentSelect.DptID = ""
        '' ''frmDepartmentSelect.DptName = ""

        '' ''frmDepartmentSelect.ShowDialog()

        '' ''If frmDepartmentSelect.DptID = "" Then

        '' ''Else

        '' ''    ButtonEdit2.Text = frmDepartmentSelect.DptName
        '' ''    strDPTID = frmDepartmentSelect.DptID
        '' ''    'ButtonEdit2.Tag = frmDepartmentSelect.DptID

        '' ''End If

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value <> "" Then
                frmDepartmentSelect1.DptID = ""
                frmDepartmentSelect1.DptName = ""
                tempValue = pmwiL.Item(0).PMWS_Value

                frmDepartmentSelect1.ShowDialog()
                If frmDepartmentSelect1.DptID = "" Then
                Else
                    ButtonEdit2.Text = frmDepartmentSelect1.DptName
                    strDPTID = frmDepartmentSelect1.DptID
                End If

                Exit Sub

            End If
        End If

        frmDepartmentSelect.DptID = ""
        frmDepartmentSelect.DptName = ""
        frmDepartmentSelect.ShowDialog()

        If frmDepartmentSelect.DptID = "" Then
        Else
            ButtonEdit2.Text = frmDepartmentSelect.DptName
            strDPTID = frmDepartmentSelect.DptID
            'ButtonEdit2.Tag = frmDepartmentSelect.DptID
        End If
    End Sub

    Private Sub sk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sk.Click

        TextEdit1.Text = ReadCard1() '讀取卡號

        Dim wulc As New WhiteUserListController
        Dim wuliL As New List(Of WhiteuserListInfo)
        wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Mid(strWHID, 1, 3))
        If wuliL.Count = 0 Then
            'cmdSave.Text = "非法卡號"
            MsgBox("未刷卡或非法卡號")
            'cmdSave.Enabled = False
            Exit Sub
        Else
            cmdSave.Text = "確定"
            cmdSave.Enabled = True
        End If
        Label4.Text = wuliL.Item(0).W_UserName
        strDPTID = wuliL.Item(0).DPT_ID
        ButtonEdit2.Text = wuliL.Item(0).DPT_Name

        '-------------------------------------------------------------------------
        'Dim strtemp2 As String = Application.StartupPath & "\vb6\ReadIC.exe "
        ''刷卡並載入刷卡人信息

        'Shell(strtemp2, AppWinStyle.NormalFocus, True)

        'Dim tc As New TempController
        'Dim ti As New List(Of TempInfo)
        'ti = tc.Temp_GetList(Nothing, Nothing, Nothing)
        'TextEdit1.Text = ti.Item(0).Str1

        'Dim wulc As New WhiteUserListController
        'Dim wuliL As New List(Of WhiteuserListInfo)
        'wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Mid(strWHID, 1, 3))
        'If wuliL.Count = 0 Then
        '    cmdSave.Text = "非法卡號"
        '    cmdSave.Enabled = False
        '    Exit Sub
        'End If
        'Label4.Text = wuliL.Item(0).W_UserName
        'strDPTID = wuliL.Item(0).DPT_ID
        'ButtonEdit2.Text = wuliL.Item(0).DPT_Name

        '-------------------------------------------------------------------------
        'TextEdit1.Text = "0403034"
        'Label4.Text = "柯厚行"            '
        'strDPTID = "10010104"             '*測試用*‘
        'ButtonEdit2.EditValue = "電腦部"  '

        ButtonEdit2.Enabled = False
        TextEdit1.Enabled = False

    End Sub

    Private Function ReadCard1() As String

        'MsgBox(ReadComm)
        ReadComm = Val(GetIni("CommSet", "ER900"))
        If ReadComm = 0 Then
            ReadComm = 1
        End If

        Dim portptr As IntPtr = ReadWriteCard.readwriteDll.OpenCommPort(ReadComm, 9600)
        Dim port As Integer = Int32.Parse(portptr.ToString())
        Dim isclock As Boolean

        If port <> -1 AndAlso port <> 0 Then
            isclock = ReadWriteCard.readwriteDll.CallClock(portptr, Int32.Parse(0))
            If isclock Then


                Dim temp As New ReadWriteCard.info
                temp.CardNo = New Byte(16) {}
                temp.CardName = New Byte(16) {}
                temp.Money = 0
                temp.Times = 0
                temp.Ver = 0
                Try
                    Dim suc As Boolean = ReadWriteCard.readwriteDll.ReadICCard(portptr, temp.CardNo, temp.CardName, temp.Money, temp.Times, temp.Ver)

                    If suc Then

                        If Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 9, 1) = "2" Then
                            ReadCard1 = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8)
                        Else
                            ReadCard1 = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7)
                        End If
                    Else
                        MessageBox.Show("無法偵測工卡或刷卡機未連接！")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                ReadWriteCard.readwriteDll.CloseCommPort(ReadComm)
            Else
                MessageBox.Show("聯機失敗!")
                ReadCard1 = ""
            End If
        ElseIf port = 0 Then
            MessageBox.Show("無法打開端口!")
        ElseIf port = -1 Then

            MessageBox.Show("端口無效或正在使用!")

        End If

    End Function
    '導入某批次中單個配件進行出庫操作
    Private Sub popLoadBatchAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popLoadBatchAdd.Click

        tempValue4 = strWHID
        frmLoadingBatchID.ShowDialog()

        If tempValue = "" Or tempValue2 = "" Then
            Exit Sub
        Else
            AddRow1(tempValue, tempValue2, tempValue3)

            tempValue = ""
            tempValue2 = ""
            tempValue3 = Nothing

        End If

    End Sub

    Sub AddRow1(ByVal strBatchID As String, ByVal strCode As String, ByVal strQty As Single)

        Dim row As DataRow
        row = ds.Tables("WareOut").NewRow

        If strCode = "" Then

        Else

            Dim j As Integer

            For j = 0 To ds.Tables("WareOut").Rows.Count - 1
                If strBatchID = ds.Tables("WareOut").Rows(j)("OS_BatchID") And strCode = ds.Tables("WareOut").Rows(j)("M_Code") Then
                    MsgBox("一張單相同批次編號相同物料不允許存在多條記錄····")
                    Exit Sub
                End If
            Next


            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            row("WO_NUM") = Nothing
            row("WO_ID") = Nothing
            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name

            Dim unit As New LFERP.DataSetting.UnitController
            Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

            unitinfo = unit.GetUnitList(objInfo.M_Unit)
            If unitinfo.Count > 0 Then
                row("M_Unit") = unitinfo(0).U_Name
            Else
                row("M_Unit") = ""
            End If

            row("M_Gauge") = objInfo.M_Gauge
            row("OS_BatchID") = strBatchID
            row("WO_Qty") = strQty
            row("M_ID") = ""
            row("Temp_Code") = ""

            '2012-7-16 加入顯示安全庫存與節余數-----------------------------
            Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi1 = wc1.WareInventory_GetSub(strCode, strWHID)

            If wi1 Is Nothing Then
                row("WI_SafeQty_Show") = 0
                row("WO_EndQty_Show") = 0
            Else
                row("WI_SafeQty_Show") = wi1.WI_SafeQty
                row("WO_EndQty_Show") = wi1.WI_Qty
            End If

            ''------------------------------------------------------

            ds.Tables("WareOut").Rows.Add(row)
        End If
        GridView1.MoveLast()
    End Sub

    '打開附檔文件信息
    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click
        Dim dt As New FileController
        If GridFile.Rows.Count = 0 Then Exit Sub
        dt.File_Open(Nothing, Nothing, GridFile.CurrentRow.Cells("F_No").Value.ToString)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet


        Dim pmc As New WareOutController
        Dim uc As New UnitController
        Dim suc As New SystemUser.SystemUserController
        Dim wh As New WareHouseController

        Dim pmc2 As New WhiteUserListController
        Dim uc2 As New DepartmentControler

        '    Dim omc As New OrdersMainController
        ds.Tables.Clear()
        Dim strA, strB As String
        strA = txtWIPID.Text
        strB = TextEdit1.Text

        Dim wc As New WareHouseController
        Dim wiL As New List(Of WareHouseInfo)
        wiL = wc.WareHouse_Get(strWHID)

        If wiL(0).NeedCheck = False Then

            ltc.CollToDataSet(ds, "WareOut", pmc.WareOut_Getlist5(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc2.CollToDataSet(ds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc5.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))

            Dim pmi As List(Of WareOutInfo)
            pmi = pmc.WareOut_Getlist5(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If pmi.Count = 0 Then Exit Sub
            If pmi(0).WO_Check = False Then

                PreviewRPT(ds, "rptWareOutNoCard", "出庫單", False, False)
            Else

                PreviewRPT(ds, "rptWareOutNoCard", "出庫單", True, False)
            End If


            ltc = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
            ltc5 = Nothing

        Else
            ltc.CollToDataSet(ds, "WareOut", pmc.WareOut_Getlist5(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
            ltc2.CollToDataSet(ds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))

            ltc4.CollToDataSet(ds, "WhiteUserList", pmc2.WhiteUserList_GetList(strB, Nothing))
            ltc5.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))

            Dim poi As List(Of WareOutInfo)

            poi = pmc.WareOut_Getlist5(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            'If poi(0).WH_ID = "W0401" Then
            If GetKnifeWareHouseReport(poi(0).WH_ID) = True Then
                If poi(0).WO_Check = False Then
                    PreviewRPT(ds, "rptWareOut1", "出庫單", False, False)
                Else
                    PreviewRPT(ds, "rptWareOut1", "出庫單", True, False)
                End If

            Else
                If poi(0).WO_Check = False Then
                    PreviewRPT(ds, "rptWareOut", "出庫單", False, False)
                Else
                    PreviewRPT(ds, "rptWareOut", "出庫單", True, False)
                End If

            End If

            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
        End If
        Me.Close()

    End Sub

    Private Function GetKnifeWareHouseReport(ByVal StrWHID As String) As Boolean
        Dim strWHRemark As String
        GetKnifeWareHouseReport = False

        Dim wc As New WareHouseController
        Dim wl As New List(Of WareHouseInfo)
        wl = wc.WareHouse_Get(StrWHID)
        strWHRemark = wl(0).WH_Remark  '如果是夜班倉

        If strWHRemark = "KnifeReports" Or strWHRemark = "刀具倉報表" Then
            GetKnifeWareHouseReport = True
        End If
    End Function

    '針對配件部某批次整體出庫時操作
    Private Sub popLoadBatchAllAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popLoadBatchAllAdd.Click

        frmWareOutBatchID.ShowDialog()

        If tempValue2 = Nothing Then Exit Sub

        'If Label6.Text.Equals(tempValue2) = True Then
        '    MsgBox("此出庫單中已存在此批次的出庫記錄！")
        '    Exit Sub
        'End If

        'Label6.Text = tempValue2
        Dim j As Integer

        For j = 0 To ds.Tables("WareOut").Rows.Count - 1
            If tempValue2 = ds.Tables("WareOut").Rows(j)("OS_BatchID") Then
                MsgBox("一張單不允許有重復批次編號....")
                Exit Sub
            End If
        Next

        Dim wic As New WareInput.WareInputContraller
        Dim woc As New WareOutController



        Dim wi1 As List(Of WareInput.WareInputInfo)
        wi1 = wic.WareInput_GetQty(tempValue2, Nothing, strWHID, True)

        If wi1.Count = 0 Then
            MsgBox("此批次沒有入庫記錄！")
            Exit Sub
        Else

            Dim i As Integer
            For i = 0 To wi1.Count - 1

                Dim InputQty As Double
                Dim OutputQty As Double

                Dim row As DataRow
                row = ds.Tables("WareOut").NewRow

                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(wi1(i).M_Code)

                row("WO_NUM") = Nothing
                row("WO_ID") = Nothing
                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name

                Dim unit As New LFERP.DataSetting.UnitController
                Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

                unitinfo = unit.GetUnitList(objInfo.M_Unit)

                row("M_Unit") = unitinfo(0).U_Name
                row("M_Gauge") = objInfo.M_Gauge
                row("OS_BatchID") = tempValue2

                Dim wi As List(Of WareInput.WareInputInfo)
                wi = wic.WareInput_GetQty(tempValue2, wi1(i).M_Code, strWHID, True)

                If wi.Count = 0 Then
                    InputQty = 0
                Else
                    InputQty = wi(0).GetQty
                End If
                Dim wo1 As List(Of WareOut.WareOutInfo)

                wo1 = woc.WareOut_GetQty(tempValue2, wi1(i).M_Code, strWHID, True)
                If wo1.Count = 0 Then
                    OutputQty = 0
                Else
                    OutputQty = wo1(0).OutGetQty
                End If
                Dim wii As List(Of WareInventory.WareInventoryInfo)
                Dim wiic As New WareInventory.WareInventoryMTController
                wii = wiic.WareInventory_GetList(wi1(i).M_Code, strWHID)
                If wii.Count = 0 Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                    MsgBox("當前倉庫無此物料或此物料庫存為0！")
                    Exit Sub
                Else
                    If InputQty - OutputQty > wii(0).WI_Qty Then
                        MsgBox("此批次結餘數量大於庫存,僅載入當前庫存數！")
                        row("WO_Qty") = wii(0).WI_Qty
                    Else
                        row("WO_Qty") = InputQty - OutputQty
                    End If

                    row("WI_SafeQty_Show") = wii(0).WI_SafeQty
                    row("WO_EndQty_Show") = wii(0).WI_Qty


                End If
                row("M_ID") = ""
                row("Temp_Code") = ""

                ds.Tables("WareOut").Rows.Add(row)
            Next
        End If

        tempValue2 = ""

    End Sub

    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        If cbType.EditValue = "生產開料" Then
            Label16.Text = "開料單號:"
            popWareInput.Enabled = False
        ElseIf cbType.EditValue = "生產出貨" Then
            Label16.Text = "出貨單號"
            popWareInput.Enabled = False
        Else
            Label6.Text = "單號"
            popWareInput.Enabled = True
        End If
    End Sub

    Private Sub txtOPNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOPNO.KeyPress
        Dim woc As New WareOutController
        Dim woi As List(Of WareOutInfo)

        If e.KeyChar = Chr(13) Then

            If cbType.EditValue = "生產開料" Then
                Dim pli As List(Of ProductionKaiLiaoInfo)
                Dim plc As New ProductionKaiLiaoControl

                pli = plc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)
                If pli.Count = 0 Then
                    MsgBox("不存在此開料單號或此開料單未審核!")
                    txtOPNO.EditValue = ""
                    txtOPNO.Enabled = True
                    Exit Sub
                End If

                If pli(0).WH_ID <> strWHID Then
                    MsgBox("此開料單號,不是在本倉領料!")
                    txtOPNO.EditValue = ""
                    txtOPNO.Enabled = True
                    Exit Sub
                End If

                If AllowChageQty = True Then ''可改數量
                    WO_Qty.OptionsColumn.AllowEdit = True
                Else
                    WO_Qty.OptionsColumn.AllowEdit = False
                End If

                '--------------------@ 2012/10/9 添加　判斷開料單是否已完全發料------
                woi = woc.WareOut_GetQty3(Nothing, Nothing, txtOPNO.Text.Trim)

                If woi.Count > 0 Then
                    If woi(0).AllQty >= pli(0).C_Weight Then
                        MsgBox("此開料單已完全發料，不能再發料！", 64, "提示")
                        txtOPNO.Focus()
                        Exit Sub
                    End If
                End If
                '---------------------------------------------------------------------------------------------------

                AP_NO.OptionsColumn.ReadOnly = True

                Dim j As Integer
                Dim row As DataRow

                ds.Tables("WareOut").Clear()

                For j = 0 To pli.Count - 1

                    row = ds.Tables("WareOut").NewRow

                    row("AP_NO") = txtOPNO.Text.Trim
                    row("WO_NUM") = Nothing
                    row("WO_ID") = Nothing
                    row("M_Code") = pli(j).M_Code
                    row("M_Name") = pli(j).M_Name

                    Dim mc As New LFERP.Library.Material.MaterialController
                    Dim objInfo As New LFERP.Library.Material.MaterialInfo
                    objInfo = mc.MaterialCode_Get(pli(j).M_Code)

                    Dim unit As New LFERP.DataSetting.UnitController
                    Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

                    unitinfo = unit.GetUnitList(objInfo.M_Unit)

                    row("M_Unit") = unitinfo(0).U_Name
                    row("M_Gauge") = pli(j).M_Gauge
                    row("OS_BatchID") = ""

                    '@ 2012/10/15 修改
                    row("WO_Qty") = pli(j).C_Weight

                    'If objInfo.M_Unit = "KG" Or objInfo.M_Unit = "公斤" Or objInfo.M_Unit = "千克" Or objInfo.M_Unit = "Catty" Or objInfo.M_Unit = "t" Or objInfo.M_Unit = "吨" Then
                    '    row("WO_Qty") = pli(j).C_Weight
                    'Else
                    '    row("WO_Qty") = pli(j).C_Qty
                    'End If

                    row("M_SendQty") = woi(0).AllQty
                    row("C_Qty") = pli(j).C_Weight

                    row("M_ID") = ""
                    row("Temp_Code") = ""


                    '2012-7-16 加入顯示安全庫存與節余數-----------------------------
                    Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                    Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                    wi1 = wc1.WareInventory_GetSub(pli(j).M_Code, strWHID)


                    If wi1 Is Nothing Then
                        row("WI_SafeQty_Show") = 0
                        row("WO_EndQty_Show") = 0
                    Else
                        row("WI_SafeQty_Show") = wi1.WI_SafeQty
                        row("WO_EndQty_Show") = wi1.WI_Qty
                    End If

                    ds.Tables("WareOut").Rows.Add(row)
                    txtOPNO.Enabled = False
                    cbType.Enabled = False
                    C_Qty.VisibleIndex = 6
                    C_Qty.Visible = True
                    'WO_Qty.OptionsColumn.AllowEdit = False
                Next

                GridView1.MoveLast()


            ElseIf cbType.EditValue = "生產出貨" Then

                Dim poi As List(Of Production.ProuctionWareOut.ProductionWareOutInfo)
                Dim poc As New Production.ProuctionWareOut.ProductionWareOutControl

                poi = poc.ProductionWareOut_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                If poi.Count = 0 Then
                    MsgBox("不存在此出貨單號,請確認!")
                    txtOPNO.EditValue = ""
                    txtOPNO.Enabled = True
                    Exit Sub
                End If

                Dim j As Integer
                Dim row As DataRow

                For j = 0 To poi.Count - 1

                    row = ds.Tables("WareOut").NewRow

                    row("WO_NUM") = Nothing
                    row("WO_ID") = Nothing
                    row("M_Code") = poi(j).M_Code
                    row("M_Name") = poi(j).M_Name

                    Dim unit As New LFERP.DataSetting.UnitController
                    Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

                    unitinfo = unit.GetUnitList(poi(j).M_Unit)

                    row("M_Unit") = unitinfo(0).U_ID
                    row("M_Gauge") = poi(j).M_Gauge
                    row("OS_BatchID") = ""
                    row("WO_Qty") = poi(j).PWO_Qty
                    row("M_ID") = ""
                    row("Temp_Code") = ""

                    '2012-7-16 加入顯示安全庫存與節余數-----------------------------
                    Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                    Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                    wi1 = wc1.WareInventory_GetSub(poi(j).M_Code, strWHID)


                    If wi1 Is Nothing Then
                        row("WI_SafeQty_Show") = 0
                        row("WO_EndQty_Show") = 0
                    Else
                        row("WI_SafeQty_Show") = wi1.WI_SafeQty
                        row("WO_EndQty_Show") = wi1.WI_Qty
                    End If

                    ds.Tables("WareOut").Rows.Add(row)
                    txtOPNO.Enabled = False
                Next

                GridView1.MoveLast()

            End If
        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        '        Dim api As List(Of ApplyInfo)
        '        Dim apc As New ApplyControl
        '        '-----------------------------------變更申領記錄以前判斷當前申領單號是否存在有加簽記錄--------
        '        Dim ei As List(Of EndorsementInfo)
        '        Dim ec As New EndorsementControl

        '        ei = ec.Endorsement_GetList(txtAPNO.Text, Nothing, Nothing)
        '        If ei.Count = 0 Then
        '            GoTo Sucess
        '        Else
        '            If ei(0).AM_Type = "審核通過" And ei(0).AM_Check = True Then
        '                GoTo Sucess
        '            ElseIf ei(0).AM_Type = "審核退回" And ei(0).AM_Check = True Then
        '                MsgBox("此申領單加簽記錄被退回,不允許發貨!")
        '                Exit Sub
        '            Else
        '                MsgBox("此申領單存在加簽記錄且未審核,不允許發貨!")
        '                Exit Sub
        '            End If

        '        End If

        '        '-----------------------------------------------------------------------------------------------

        'Sucess: api = apc.Apply_GetList(txtAPNO.Text, Nothing, Nothing, Nothing)
        '        If api.Count = 0 Then
        '            MsgBox("當前中央系統不存在當前申領單號,請確認!")
        '            popWareInput.Enabled = True

        '            Exit Sub
        '        Else
        '            popWareInput.Enabled = False
        '            tempValue = txtAPNO.Text
        '            Dim frm As New frmWareOutLoadingApply

        '            frm.ShowDialog()

        '            Dim i, n As Integer
        '            Dim arr(n) As String
        '            arr = Split(tempValue, ",")
        '            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)
        '            For i = 0 To n
        '                If arr(i) = "" Then
        '                    Exit Sub
        '                End If
        '                AddRowApply(txtAPNO.Text, arr(i))
        '            Next
        '            tempValue = ""
        '        End If

        If GridView1.RowCount = 0 Then
            'txtAPNO.Text = Nothing
        End If

        tempValue3 = strWHID   '傳入倉庫編號信息
        Dim frm As New frmWareOutLoadingApply
        frm.ShowDialog()

        '2012-7-16
        If tempValue = "" Or tempValue = Nothing Then
            Exit Sub
        End If

        'popWareInput.Enabled = False
        popWareOutAdd.Enabled = False
        popWareOutBarAdd.Enabled = False
        popLoadBatchAdd.Enabled = False
        popLoadBatchAllAdd.Enabled = False

        popWareOutDel.Enabled = True

        'If Len(txtAPNO.Text.Trim) = 0 Then
        '    txtAPNO.Text = tempValue2
        'Else
        '    If txtAPNO.Text.Equals(tempValue2) = False Then
        '        MsgBox("在同一出庫單號中不允許出現不同申領單號,請重新開出庫單!")
        '        Exit Sub
        '    End If
        'End If
        'txtAPNO.Enabled = False

        '-----------------------------------變更申領記錄以前判斷當前申領單號是否存在有加簽記錄--------
        Dim ei As List(Of EndorsementInfo)
        Dim ec As New EndorsementControl

        ei = ec.Endorsement_GetList(tempValue2, Nothing, Nothing)
        If ei.Count = 0 Then
            GoTo Sucess
        Else
            If ei(0).AM_Type = "審核通過" And ei(0).AM_Check = True Then
                GoTo Sucess
            ElseIf ei(0).AM_Type = "審核退回" And ei(0).AM_Check = True Then
                MsgBox("此申領單加簽記錄被退回,不允許發貨!")
                Exit Sub
            Else
                MsgBox("此申領單存在加簽記錄且未審核,不允許發貨!")
                Exit Sub
            End If

        End If

        '-----------------------------------------------------------------------------------------------

Sucess: Dim i, n As Integer
        Dim arr(n) As String
        arr = Split(tempValue, ",")
        n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)
        For i = 0 To n
            If arr(i) = "" Then
                Exit Sub
            End If
            AddRowApply(tempValue2, arr(i))
        Next
        tempValue = ""
        tempValue2 = ""

    End Sub

  

    Sub AddRowApply(ByVal AM_ID As String, ByVal M_ID As String)
        Dim row As DataRow
        row = ds.Tables("WareOut").NewRow

        If M_ID = "" Then
        Else
            Dim api As List(Of ApplyInfo)
            Dim apc As New ApplyControl
            api = apc.Apply_GetList(AM_ID, M_ID, Nothing, Nothing)
            If api.Count = 0 Then
                Exit Sub
            Else

                Dim j As Integer

                For j = 0 To ds.Tables("WareOut").Rows.Count - 1
                    If api(0).M_Code = ds.Tables("WareOut").Rows(j)("M_Code") Then
                        MsgBox("物料" & ds.Tables("WareOut").Rows(j)("M_Code") & " / " & ds.Tables("WareOut").Rows(j)("M_Name") & "出庫單中已存在。" & vbCrLf & "同一張出庫單中不允許存在相同的出庫物料！", 64, "提示")
                        Exit Sub
                    End If
                Next

                row = ds.Tables("WareOut").NewRow


                row("WO_NUM") = Nothing
                row("WO_ID") = Nothing
                row("M_Code") = api(0).M_Code
                row("M_Name") = api(0).M_Name
                row("M_Gauge") = api(0).M_Gauge
                row("M_Unit") = api(0).M_Unit
                row("WO_Qty") = api(0).M_Qty
                row("OS_BatchID") = ""
                row("WO_Remark") = ""
                row("AP_NO") = AM_ID
                row("M_ID") = api(0).M_ID
                row("Temp_Code") = api(0).Temp_Code
                row("M_SendQty") = api(0).M_SendQty
                row("PS_NO") = ""

                '2012-7-16 加入顯示安全庫存與節余數-----------------------------
                Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetSub(api(0).M_Code, strWHID)


                If wi1 Is Nothing Then
                    row("WI_SafeQty_Show") = 0
                    row("WO_EndQty_Show") = 0
                Else
                    row("WI_SafeQty_Show") = wi1.WI_SafeQty
                    row("WO_EndQty_Show") = wi1.WI_Qty
                End If

                ds.Tables("WareOut").Rows.Add(row)

                GridView1.MoveLast()
            End If
        End If
    End Sub
    '變更當前選擇行物料編碼信息
    Private Sub RepositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Dim strTemp, strCode As String
        strTemp = GridView1.GetFocusedRowCellValue("M_Code").ToString
        tempValue5 = strWHID
        tempValue6 = "倉庫管理"
        tempValue7 = "出庫作業"

        Dim frm As New frmBOMSelect
        frm.ShowDialog()

        If tempCode = "" Then
        Else
            'AddRow(tempCode, 0)

            Dim j As Integer

            For j = 0 To ds.Tables("WareOut").Rows.Count - 1
                If j <> GridView1.FocusedRowHandle Then
                    If tempCode = ds.Tables("WareOut").Rows(j)("M_Code") Then
                        MsgBox("物料已存在，同一張出庫單中不允許存在相同的出庫物料！")
                        Exit Sub
                    End If
                End If
            Next

            strCode = tempCode  '新的物料編碼

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            Dim unit As New LFERP.DataSetting.UnitController
            Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)

            unitinfo = unit.GetUnitList(objInfo.M_Unit)

            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "M_Code", strCode) '新的真實發出的物料編碼
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "M_Name", objInfo.M_Name) '新的名稱
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "M_Gauge", objInfo.M_Gauge) '新的規格
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "M_Unit", unitinfo(0).U_Name) '新的單位
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "M_SendQty", 0) '已發數量
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Temp_Code", strTemp) '申領單中誤以為的真實編碼(變更為臨時編碼字段中保存)
            '-------------------------------------------------------
            '得到當前物料在指定倉庫的安全庫存設置信息以及當前實時庫存信息

            Dim wi As List(Of WareInventory.WareInventoryInfo)
            Dim wic As New WareInventory.WareInventoryMTController

            wi = wic.WareInventory_GetList3(strCode, strWHID, "True")
            If wi.Count = 0 Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "WI_SafeQty_Show", 0) '新的真實發出的物料編碼
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "WO_EndQty_Show", 0) '新的名稱
            Else
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "WI_SafeQty_Show", wi(0).WI_SafeQty) '新的真實出庫物料安全庫存
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "WO_EndQty_Show", wi(0).WI_Qty) '新的物料倉庫庫存
            End If


            '-------------------------------------------------------

        End If
        tempCode = ""

    End Sub

    Function CheckSave() As Boolean

        CheckSave = True

        ''--------------------2012-12-17--防止有代替刷卡--------------------------------------
        If sk.Visible = False Then '電腦倉不用
        Else

            Dim wulc As New WhiteUserListController
            Dim wuliL As New List(Of WhiteuserListInfo)
            wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Mid(strWHID, 1, 3))
            If wuliL.Count <= 0 Or TextEdit1.Text = "" Then
                CheckSave = False
                MsgBox("未刷卡或非法卡號")
                Exit Function
            End If

        End If
        ''------------------------------------------------------------

        If Len(ButtonEdit2.EditValue) = 0 Then

            MsgBox("部門不能為空")
            CheckSave = False
            Exit Function
        End If
        If Len(TextEdit1.EditValue) = 0 Then
            MsgBox("領料人不能為空")
            CheckSave = False
            Exit Function
        End If
        If ds.Tables("WareOut").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            CheckSave = False
            Exit Function
        End If

        If isProcess = True Then
            If gluDepID.Text.Trim = "" Then
                MsgBox("收料部門不能為空")
                CheckSave = False
                Exit Function
            End If

            Dim n%
            For n = 0 To ds.Tables("WareOut").Rows.Count - 1
                If ds.Tables("WareOut").Rows(n)("PS_NO") = "" Then
                    MsgBox("請輸入工序名稱！", 64, "提示")
                    CheckSave = False
                    Exit Function
                End If
            Next
        End If
        Dim i As Integer

        '查詢是否相應的倉庫中夠數
        Dim mw As New WareInventory.WareInventoryMTController
        Dim mwi As New WareInventory.WareInventoryInfo

        Dim pic As New ProductInventoryController
        Dim piiGet As List(Of ProductInventoryInfo)

        Dim dblInventoryQty As Double '庫存數
        Dim intRecords As Integer '記錄數

        For i = 0 To ds.Tables("WareOut").Rows.Count - 1

            If AllPlus = True Then
                If ds.Tables("WareOut").Rows(i)("WO_Qty") = 0 Then
                    MsgBox("出庫數量不能為0!")
                    CheckSave = False
                    Exit Function
                End If
            Else
                If ds.Tables("WareOut").Rows(i)("WO_Qty") <= 0 Then
                    MsgBox("出庫數量不能小于等于0!")
                    CheckSave = False
                    Exit Function
                End If

            End If




            If strWHID = "W1101" Then        '@ 2013/3/11 修改
                piiGet = pic.ProductInventory_GetList(ds.Tables("WareOut").Rows(i)("PM_M_Code"), ds.Tables("WareOut").Rows(i)("M_Code"), strWHID, Nothing)
                If piiGet.Count <= 0 Then
                    intRecords = 0
                    dblInventoryQty = 0
                Else
                    intRecords = piiGet.Count
                    dblInventoryQty = piiGet(0).PI_Qty
                End If
            Else
                mwi = mw.WareInventory_GetSub(ds.Tables("WareOut").Rows(i)("M_Code"), strWHID)
                If mwi Is Nothing Then
                    intRecords = 0
                    dblInventoryQty = 0
                Else
                    intRecords = 1
                    dblInventoryQty = mwi.WI_Qty
                End If
            End If

            If intRecords = 0 Then
                MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不存在，不能保存！")
                CheckSave = False
                Exit Function
            End If

            '@ 2012/10/9 添加
            If cbType.EditValue = "生產開料" Then
                'If (CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) + CDbl(ds.Tables("WareOut").Rows(i)("M_SendQty"))) > CDbl(ds.Tables("WareOut").Rows(i)("C_Qty")) Then
                '    MsgBox("出庫數量與已發數量之和不能大於開料數量！", 64, "提示")
                '    Exit Function
                'End If


                Dim pli As New List(Of ProductionKaiLiaoInfo)
                Dim plc As New ProductionKaiLiaoControl

                pli = plc.ProductionKaiLiao_GetList(txtOPNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)
                If pli.Count = 0 Then
                    MsgBox("不存在此開料單號或此開料單未審核!")
                    CheckSave = False
                    Exit Function
                End If

                '--------------------@ 2012/10/9 添加　判斷開料單是否已完全發料------
                Dim woc As New WareOutController
                Dim woi As New List(Of WareOutInfo)
                woi = woc.WareOut_GetQty3(Nothing, Nothing, txtOPNO.Text.Trim)

                If woi.Count > 0 Then
                    If pli(0).C_Weight - woi(0).AllQty < CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) Then
                        MsgBox("此開料單已完全發料，不能再發料！", 64, "提示")
                        CheckSave = False
                        Exit Function
                    End If
                End If
                '---------------------------------------------------------------------------------------------------
            End If

            If dblInventoryQty = 0 Then

                If CSng(ds.Tables("WareOut").Rows(i)("WO_Qty")) < 0 Then
                    CheckSave = True
                ElseIf dblInventoryQty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) >= 0 Then
                    CheckSave = True
                Else
                    MsgBox("當前物料庫存為0,不允許出庫為正數,只能進行會計部負數沖帳處理")
                    CheckSave = False
                    Exit Function
                End If
            ElseIf dblInventoryQty > 0 And dblInventoryQty < ds.Tables("WareOut").Rows(i)("WO_Qty") Then
                MsgBox("物料" & ds.Tables("WareOut").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不夠數，不能保存！")
                CheckSave = False
                Exit Function
            ElseIf dblInventoryQty < 0 Then

                If dblInventoryQty - CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) >= 0 Then
                    CheckSave = True
                Else
                    MsgBox("當前物料" & ds.Tables("WareOut").Rows(i)("M_Code") & "庫存為負數,請檢查原因!")
                    CheckSave = False
                    Exit Function
                End If

                If isProcess = True Then
                    If ds.Tables("WareOut").Rows(i)("PS_NO") = "" Then
                        MsgBox("請輸入工序名稱！", 64, "提示")
                        CheckSave = False
                        Exit Function
                    End If
                End If

            Else
                CheckSave = True
            End If

            ''2012-9-4 判斷以申領單，出庫的情況--------------------------------

            If ds.Tables("WareOut").Rows(i)("M_ID") = "" Then
            Else
                Dim ai2 As New List(Of ApplyInfo)
                Dim ac2 As New ApplyControl
                ai2 = ac2.Apply_GetList(ds.Tables("WareOut").Rows(i)("AP_NO"), ds.Tables("WareOut").Rows(i)("M_ID"), Nothing, Nothing)

                If ai2.Count > 0 Then
                    If ai2(0).M_Code = ds.Tables("WareOut").Rows(i)("M_Code") Then
                        If CDbl(ds.Tables("WareOut").Rows(i)("WO_Qty")) > ai2(0).M_Qty - ai2(0).M_SendQty Then
                            MsgBox("出庫數量不能大于申領中未發出數量！", 64, "提示")
                            CheckSave = False
                            Exit Function
                        End If
                    End If
                End If
            End If

            '’----------------------------------------


        Next
    End Function

    '@ 2012/7/27 添加
    Private Sub RepositoryItemButtonEdit3_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit3.ButtonClick
        tempCode = ""
        tempValue2 = "物料出庫轉工序"
        Dim fr As New frmProductionSelect
        fr.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim i%
            For i = 0 To ds.Tables("WareOut").Rows.Count - 1
                If ds.Tables("WareOut").Rows(i)("PS_NO") = tempCode Then
                    MsgBox("工序已存在，同一張單中不能存在相同的工序！", 64, "提示")
                    Exit Sub
                End If
            Next
            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("PS_NO") = tempCode
            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("PS_Name") = tempValue9
            sender.text = tempValue9
        End If
        tempCode = ""
        tempValue9 = ""
    End Sub

    '當前允許在同一張申領單中添加不同的申領單信息

    Private Sub popApplyAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popApplyAdd.Click


        'If GridView1.RowCount = 0 Then
        '    txtAPNO.Text = Nothing
        'End If
        arl1.Clear()
        arl2.Clear()

        tempValue3 = strWHID   '傳入倉庫編號信息
        Dim frm As New frmWareOutLoadingApply
        frm.ShowDialog()

        'AP_NO.OptionsColumn.AllowEdit = False
        'AP_NO.OptionsColumn.ReadOnly = False

        'If tempValue = "" Or tempValue = Nothing Then
        '    Exit Sub
        'End If

        'popWareInput.Enabled = False
        'popWareOutAdd.Enabled = False
        'popWareOutBarAdd.Enabled = False
        'popLoadBatchAdd.Enabled = False
        'popLoadBatchAllAdd.Enabled = False

        'popWareOutDel.Enabled = True


        Dim i, j As Integer
        If arl1.Count > 0 Then
            For i = 0 To arl1.Count - 1
                AddRowApply(arl1(i), arl2(i))
            Next
        End If

 
        arl1.Clear()
        arl2.Clear()
    End Sub

    Private Sub rtxtAP_NO_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtAP_NO.Enter
        If cbType.Text <> "生產開料" Then
            If ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_ID").ToString <> "" Then
                'AP_NO.OptionsColumn.ReadOnly = True
                sender.Properties.ReadOnly = True
            Else
                'AP_NO.OptionsColumn.ReadOnly = False
                sender.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub txtAPNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAPNO.KeyPress

        If e.KeyChar = Chr(13) Then

            If GridView1.RowCount = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To ds.Tables("WareOut").Rows.Count - 1

                GridView1.SetRowCellValue(i, "AP_NO", txtAPNO.Text)

            Next

        End If

    End Sub

    '@ 2012/10/12 添加 申領單輸入文本框失去焦點時，判斷申領單是否存在，存在則提取相應信息
    Private Sub rtxtAP_NO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtAP_NO.Leave
        If sender.text <> "" And ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Code") <> "" Then
            Dim api As List(Of ApplyInfo)
            Dim apc As New ApplyControl
            api = apc.Apply_GetList(sender.text, Nothing, GridView1.GetFocusedRowCellValue(M_Code), Nothing)
            If api.Count > 0 Then
                ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_ID") = api(0).M_ID
                ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("Temp_Code") = api(0).Temp_Code
                ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_SendQty") = api(0).M_SendQty
            End If
        End If
    End Sub

   
    'Private Sub RepositoryItemButtonEdit1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit1.Leave
    '    If sender.text <> "" And ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("AP_NO") <> "" Then
    '        Dim api As List(Of ApplyInfo)
    '        Dim apc As New ApplyControl
    '        api = apc.Apply_GetList(GridView1.GetFocusedRowCellValue(AP_NO), Nothing, sender.text, Nothing)
    '        If api.Count > 0 Then
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_ID") = api(0).M_ID
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("Temp_Code") = api(0).Temp_Code
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_SendQty") = api(0).M_SendQty
    '        Else
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_ID") = ""
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("Temp_Code") = ""
    '            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_SendQty") = 0
    '        End If
    '    End If
    'End Sub


    '@ 2013/1/25 添加 按下回車鍵調用添加數據行事件,條碼掃描器掃描出的條碼自帶回車後綴
    Private Sub txtM_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtM_Code.KeyDown
        ''If e.KeyCode = Keys.Enter Then

        ''    If strPdMachine = True Then


        ''        Dim strCode As String
        ''        Dim strQty As String
        ''        Dim intIn As Integer
        ''        Dim StrText As String

        ''        StrText = txtM_Code.Text

        ''        intIn = InStr(StrText, ",", CompareMethod.Text)
        ''        If intIn <= 0 Then
        ''            strCode = StrText
        ''            strQty = "1"
        ''        Else
        ''            strCode = Mid(StrText, 1, intIn - 1)
        ''            strQty = Mid(StrText, intIn + 1, Len(StrText) - intIn)
        ''        End If


        ''        LabelMsg.Text = LabelMsg.Text + AddRowPD(strCode, strQty)

        ''        txtM_Code.Text = ""
        ''    Else
        ''        AddRow(txtM_Code.Text.Trim, 1)
        ''        txtM_Code.Text = ""
        ''    End If

        ''End If


        If e.KeyCode = Keys.Enter Then

            Dim strCode As String
            Dim strQty As String
            Dim intIn As Integer
            Dim StrText As String

            StrText = txtM_Code.Text

            intIn = InStr(StrText, ",", CompareMethod.Text)
            If intIn <= 0 Then
                strCode = StrText
                strQty = "1"
            Else
                strCode = Mid(StrText, 1, intIn - 1)
                strQty = Mid(StrText, intIn + 1, Len(StrText) - intIn)
            End If


            LabelMsg.Text = LabelMsg.Text + AddRowPD(strCode, strQty)

            txtM_Code.Text = ""

        End If
    End Sub

    '@ 2013/1/25 添加
    Private Sub txtM_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtM_Code.KeyUp
        If GridView1.RowCount <= 0 Then Exit Sub

       ' If strPdMachine = True Then Exit Sub ''盤點機模式


        If e.KeyCode = Keys.Home Then   '按下Home鍵，焦點行數量單元格獲得焦點
            GridView1.Focus()
            GridView1.FocusedColumn = GridView1.Columns("WO_Qty")

        End If

        If e.KeyCode = Keys.PageUp Then    '按下PageUp鍵，焦點行數量加一
            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") = ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") + 1
            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Unit"), "")
        End If

        If e.KeyCode = Keys.PageDown Then    '按下PageDown鍵，焦點行數量減一
            ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") = ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") - 1
            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Unit"), "")
        End If

        If e.KeyCode = Keys.Up Then    '按下向上方向鍵，焦點行上移一行，並且焦點落在數量單元格中
            GridView1.FocusedRowHandle = GridView1.FocusedRowHandle - 1
            GridView1.Focus()
            GridView1.FocusedColumn = GridView1.Columns("WO_Qty")
        End If

        If e.KeyCode = Keys.Down Then   '按下向下方向鍵，焦點行下移一行，並且焦點落在數量單元格中
            GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
            GridView1.Focus()
            GridView1.FocusedColumn = GridView1.Columns("WO_Qty")
        End If
    End Sub

    '@ 2013/1/25 添加
    'Private Sub GridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        txtM_Code.Focus()
    '    End If
    'End Sub

    ''2013-3-5 只修改備注
    Sub Update_Remark()
        Dim mcc As New WareOutController
        Dim mii As New WareOutInfo

        mii.WO_ID = txtWIPID.EditValue
       
        Dim i As Integer

        For i = 0 To ds.Tables("WareOut").Rows.Count - 1
            mii.WO_NUM = ds.Tables("WareOut").Rows(i)("WO_NUM")
            mii.WO_Remark = ds.Tables("WareOut").Rows(i)("WO_Remark")

            If mcc.WareOut_UpdateRemark(mii) = False Then
                Exit Sub
            End If
        Next

        MsgBox("保存成功!")
        Me.Close()
    End Sub

    '@ 2013/3/14 數量修改時，LCD屏幕重新顯示物料信息
    Private Sub QtyItemCalcEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyItemCalcEdit.EditValueChanged
        If isShowLCD = True Then   '有顯示權限時才可顯示
            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & CDbl(sender.text) & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Unit"), "")
        End If
    End Sub

    '@ 2013/1/25 添加
    Private Sub QtyItemCalcEdit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyItemCalcEdit.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtM_Code.Focus()
        End If
    End Sub

    Private Sub txtM_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtM_Code.EditValueChanged

    End Sub
    Private Sub txtM_Code_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtM_Code.Leave
        If LabelMsg.Text <> "" Then
            MsgBox(LabelMsg.Text)
        End If
    End Sub

    Private Sub ToolStripBatchLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBatchLoad.Click
        tempCode = ""
        tempValue12 = "B"
        '--------------------------------
        tempValue5 = strWHID
        tempValue6 = "倉庫管理"
        tempValue7 = "出庫作業"

        frmBOMSelect.ShowDialog()


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

    '@ 2013/6/8 添加 焦點行改變時，LCD屏幕顯示焦點行物料信息
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If isShowLCD = True Then   '有顯示權限時才可顯示
            LoadPingMU("名稱：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("WO_Qty") & ds.Tables("WareOut").Rows(GridView1.FocusedRowHandle)("M_Unit"), "")
        End If
    End Sub

 
End Class