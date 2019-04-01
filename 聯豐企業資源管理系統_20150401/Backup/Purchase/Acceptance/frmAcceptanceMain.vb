Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Purchase
Imports LFERP.Library.Purchase.Retrocede
Imports LFERP.DataSetting
Imports LFERP.SystemManager
Imports LFERP.Library.Purchase.purselect
Public Class frmAcceptanceMain

    Private Sub popAcceptanceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAcceptanceAdd.Click

        On Error Resume Next
        Edit = False
        MTypeName = "AcceptanceAddEdit"
        'Dim fr As frmAcceptance
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmAcceptance Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        'fr = New frmAcceptance
        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized
        'fr.Show()
        CheckForm(frmAcceptance, frmAcceptance.Name)
        'Dim myfrm As New frmAcceptance
        'myfrm.ShowDialog()
    End Sub

    Private Sub frmAcceptanceMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New AcceptanceController
       
        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, "已結單", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        LoadUserPower()
    End Sub
    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceEdit.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceDel.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400305")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceCheck.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400306")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceAccCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400314")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptancePayCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400315")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceDetail.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400316")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popBatchCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400317")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAcceptanceGether.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400318")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popBatchPayCheck.Enabled = True
        End If

        '--------------------------------------------物料調撥權限(假若有發料權限與其相同)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMove.Enabled = True
        End If
    End Sub
    Private Sub popAcceptanceRef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceRef.Click
        Dim mc As New AcceptanceController
       
        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, "已結單", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub popAcceptanceDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceDel.Click
        Dim osc As New AcceptanceController
        Dim osilist As New List(Of AcceptanceInfo)
        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法刪除,此驗收單已驗收！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim rc As New RetrocedeController
        Dim riList As New List(Of RetrocedeInfo)
        riList = rc.Retrocede_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If riList.Count <> 0 Then
            MsgBox("無法刪除,此驗收單已有退貨！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法刪除,此驗收單已付款！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim StrA As String
        StrA = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        If MsgBox("你確定刪除驗收單號為  '" & StrA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim mc As New AcceptanceInfo
            Dim mt As New AcceptanceController
            mc.A_AcceptanceNO = StrA
            If mt.Acceptance_NO_Delete(mc) = True Then

                Grid1.DataSource = mt.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Else
                MsgBox("刪除失敗")
            End If

        End If
    End Sub

    Private Sub popAcceptanceEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceEdit.Click
        On Error Resume Next
        Dim osc As New AcceptanceController
        Dim osilist As New List(Of AcceptanceInfo)
        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim rc As New RetrocedeController
        Dim riList As New List(Of RetrocedeInfo)
        riList = rc.Retrocede_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        If riList.Count <> 0 Then
            MsgBox("無法刪除,此驗收單已有退貨！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If


        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單已驗收！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單會計部已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單已付款！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceAddEdit"
        Edit = True

        Dim fr As frmAcceptance
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmAcceptance Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
        'CheckForm(frmAcceptance, frmAcceptance.Name)
    End Sub

    Private Sub popAcceptanceCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceCheck.Click
        On Error Resume Next
        Dim osc As New AcceptanceController
        Dim osilist As New List(Of AcceptanceInfo)


        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單會計部已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單已付款！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If




        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceCheck"


        Dim fr As frmAcceptance
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmAcceptance Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
        'Dim myfrm As New frmAcceptance
        'myfrm.ShowDialog()
        'CheckForm(frmAcceptance, frmAcceptance.Name)
    End Sub

    Private Sub popAcceptanceAccCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceAccCheck.Click
        On Error Resume Next
        Dim osc As New AcceptanceController
        Dim osilist As New List(Of AcceptanceInfo)



        Dim ac As New AcceptanceController
        Dim ai As New AcceptanceInfo

        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        ai = ac.Acceptance_Get(tempValue2)
        If ai.A_Check = False Then
            MsgBox("必須先驗收,會計部才能審核!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.Acceptance_GetList(Nothing, GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單已付款！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        MTypeName = "AcceptanceAccountCheck"

        Dim fr As frmAcceptance
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmAcceptance Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popAcceptanceSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAcceptanceSeek.Click

        tempValue = "驗收管理"
        Dim fr As New FrmpurSelect
        FrmpurSelect.ShowDialog()
        Dim mc As New AcceptanceController
        Dim pc As New PurSelectControl
        Select Case tempValue
            Case "1" '採購單號
                Grid1.DataSource = mc.Acceptance_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "2" '驗收單號
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "3" '物料名稱
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "4" '物料編碼,
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)

                'Case "5"  '物料類別
            Case "5" '供應商
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)

            Case "6"

                Grid1.DataSource = pc.Acceptance_GetList("驗收管理", tempValue2)
        End Select
        tempValue = ""
        tempValue2 = ""

        'Dim mc As New AcceptanceController
        'Dim myfrm As New frmA_AcceptanceSelect2
        'myfrm.ShowDialog()
        'Select Case tempValue
        '    Case "1"
        '        Grid1.DataSource = mc.Acceptance_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        '    Case "2"
        '        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing)
        '    Case "3"
        '        Grid1.DataSource = mc.Acceptance_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    Case "4"
        '        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    Case "5"
        '        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing)
        '    Case "6"
        '        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)

        'End Select

        'tempValue = ""
        'tempValue2 = ""

        'tempValue = "驗收管理"

        'Dim fr As New FrmpurSelect
        'FrmpurSelect.ShowDialog()
        ''Dim fr As New FrmpurSelect
        'Dim pc As New PurSelectControl

        'Grid1.DataSource = pc.Acceptance_GetList("驗收管理", tempValue2)
        'tempValue2 = ""

    End Sub

    Private Sub popAcceptanceFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceFile.Click
        '調用此訂單流水號的文件
        '  If Grid.Rows.Count = 0 Then Exit Sub

        Dim open, update, down, edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        '  If Grid.Rows.Count = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400308")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400309")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400310")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400311")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400312")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400313")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If

        FileShow("4001", GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString, open, update, down, edit, del, detail)
    End Sub

    Private Sub popAcceptancePayCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptancePayCheck.Click
        On Error Resume Next
        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        Dim ac As New AcceptanceController
        Dim ai As New AcceptanceInfo
        ai = ac.Acceptance_Get(tempValue2)
        If ai.A_AccountCheck = False Then
            MsgBox("單據必須會計部審核後才能做付款確認!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        MTypeName = "AcceptancePayCheck"
        '     Edit = True

        Dim fr As frmAcceptance
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmAcceptance Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popAcceptanceView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAcceptanceView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmAcceptance
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmAcceptance Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next


        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceView"



        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popAcceptancePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAcceptancePrint.Click
        '   On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet

        Dim pmc As New PurchaseMainController
        Dim ac As New AcceptanceController
        Dim uc As New UnitController
        Dim suc As New SystemUser.SystemUserController
        Dim cc As New CompanyControler
        '    Dim omc As New OrdersMainController
        ds.Tables.Clear()
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("PM_NO").ToString

        ltc.CollToDataSet(ds, "PurchaseMain", pmc.PurchaseMain_Getlist(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Acceptance", ac.Acceptance_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))

        ltc3.CollToDataSet(ds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))

        ltc4.CollToDataSet(ds, "Company", cc.Company_Getlist(Nothing, Nothing, Nothing, Nothing))
        ' ltc5.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Grid.CurrentRow.Cells("OM_ID").Value.ToString))



        PreviewRPT(ds, "rptAcceptance", "送貨詳細表", True, False)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        '     ltc5 = Nothing
    End Sub

    Private Sub popDetail1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popDetail1.Click

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        Dim ac2 As New AcceptanceController
        Dim aciList As New List(Of AcceptanceInfo)
        Dim aci2 As New AcceptanceInfo
        aciList = ac2.Acceptance_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '  Label1.Text = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        If aciList.Item(0).A_PayCheck = False Then
            MsgBox("必須是'付款確認'的單據才能調整為'已結單'", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If MsgBox("確定要將狀態調整為 '已結單' 嗎?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo
            ai.A_AcceptanceNO = strA
            ai.A_Detail = "已結單"
            ac.Acceptance_UpdateDetail(ai)
            MsgBox("狀態已更改", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub popDetail2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popDetail2.Click
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        If MsgBox("確定要將狀態調整為 '退貨未處理' 嗎?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo
            ai.A_AcceptanceNO = strA
            ai.A_Detail = "退貨未處理"
            ac.Acceptance_UpdateDetail(ai)
            MsgBox("狀態已更改", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString()
        strB = GridView1.GetFocusedRowCellValue("M_Code").ToString()
        Dim rc As New RetrocedeController
        GridControl2.DataSource = rc.Retrocede_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, True, Nothing, strB, Nothing, Nothing, Nothing)
    End Sub

    '直接從驗收單中添加調撥單
    Private Sub popWareMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMove.Click

        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ac As New AcceptanceController
        Dim ai As New AcceptanceInfo
        ai = ac.Acceptance_Get(GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString)
        If ai.A_Check = False Then
            MsgBox("驗收單必須驗貨QC審核後才能發調撥單!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim fr As frmWareMoveOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareMoveOut Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceMoveOut"

        fr = New frmWareMoveOut
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    '@ 2012/6/14 添加 批量審核功能
    Private Sub popBatchCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchCheck.Click
        Dim fr As New frmAcceptanceBatchCheck
        Dim ac As New AcceptanceController
        fr.lblTittle.Text = "驗收單批量審核"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    '@ 2012/6/14 添加 驗收記錄匯總功能
    Private Sub popAcceptanceGether_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAcceptanceGether.Click
        Dim fr As New frmAcceptanceGather
        fr.ShowDialog()
    End Sub
    '@ 2012/6/18 添加 批量付款確認
    Private Sub popBatchPayCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchPayCheck.Click
        Dim fr As New frmAcceptanceBatchCheck
        Dim ac As New AcceptanceController
        fr.lblTittle.Text = "驗收單批量付款確認"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
End Class