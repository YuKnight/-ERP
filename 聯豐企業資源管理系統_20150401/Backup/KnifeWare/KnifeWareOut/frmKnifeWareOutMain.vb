Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.Shared
Imports LFERP.Library.WareHouse.WareSelect
Imports DevExpress.XtraGrid.Columns
Imports LFERP.Library.KnifeWare

Public Class frmKnifeWareOutMain
    Private LableText As String

    Private m_BolReport As Boolean = False    '報表判別標識

    Private Sub frmKnifeWareOutMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New WareHouseController

        'mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "510205"))
        KnifeWareTreeView = TreeView1
        KnifeWareBarManager = BarManager2

        KnifeWareLoad(ImageList1, "510205")

        LoadUserPower()

        popWareOutEdit.Visible = False
        popWareOutDel.Visible = False
        ' popWareOutCheck.Visible = False
        Dim kwo As New KnifeWareOutController
        'Me.Grid1.DataSource = kwo.KnifeWareOut_GetList5(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAddNew.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510206")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutReCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510207")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAdd_Process.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510208")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then WareoutcollToolStripMenuItem.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510209")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAddBarCode.Enabled = True
        End If
        ModifyRemarkTool.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510210")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ModifyRemarkTool.Visible = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510212")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAddOld.Enabled = True
        End If
    End Sub
    Private Sub popWareOutAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAddNew.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode Is Nothing Then
            MsgBox("請選擇正確的倉庫!", 64, "提示")
            Exit Sub
        Else
            Dim fr As frmKnifeWareOutSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmKnifeWareOutSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmKnifeWareOutSub
            fr.EditValue = "popWareOutAddNew"
            fr.EditItem = "popWareOutAdd"
            fr.NodeTag = TreeView1.SelectedNode.Tag
            fr.NodeText = TreeView1.SelectedNode.Text
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub popWareOutAddOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAddOld.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode Is Nothing Then
            MsgBox("請選擇正確的倉庫!", 64, "提示")
            Exit Sub
        Else
            Dim fr As frmKnifeWareOutSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmKnifeWareOutSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmKnifeWareOutSub
            fr.EditValue = "popWareOutAddOld"
            fr.EditItem = "popWareOutAdd"
            fr.NodeTag = TreeView1.SelectedNode.Tag
            fr.NodeText = TreeView1.SelectedNode.Text
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim kwo As New KnifeWareOutController
        If e.Node.Level = 0 Then
            ''***判斷用戶是擁有此倉別的權限
            'Dim pmws As New PermissionModuleWarrantSubController
            'Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

            'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500205")
            'If pmwiL.Count > 0 Then
            '    If InStr(pmwiL.Item(0).PMWS_Value, Mid(TreeView1.SelectedNode.Tag, 1, 3)) = 0 Then
            '        MsgBox("你沒有此類型的新增或修改權限")
            '        Exit Sub
            '    End If

            'End If
            ''************
            If (m_BolReport) Then
                m_BolReport = False
                Exit Sub
            End If
            Grid1.DataSource = kwo.KnifeWareOut_GetList5(Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing, Nothing, Nothing)
        End If
    End Sub

    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        Dim kwo As New KnifeWareOutController
        Dim kinfo As New KnifeWareOutInfo
        kinfo = kwo.KnifeWareOut_GetNUM(GridView2.GetFocusedRowCellValue("WO_NUM").ToString)
        If kinfo.WO_Check = False Then
            Dim strDate, strDate1 As Date
            strDate = Format(Now, "yyyy/MM")
            strDate1 = Format(kinfo.WO_AddDate, "yyyy/MM")

            If strDate = strDate1 Then
                If MsgBox("確定刪除單號為" & GridView2.GetFocusedRowCellValue("WO_ID").ToString & "的全部記錄？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    If kwo.KnifeWareOut_Delete(Nothing, GridView2.GetFocusedRowCellValue("WO_ID").ToString) = True Then
                        MsgBox("刪除成功", 64, "提示")
                        Grid1.DataSource = kwo.KnifeWareOut_GetList5(Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag.ToString, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing, Nothing, Nothing)
                    End If
                End If
            Else
                MsgBox("不是當月出庫單,當前不允許刪除!", 64, "提示")
                Exit Sub
            End If

        Else
            MsgBox("該單已審核，不允許刪除", 64, "提示")
        End If
    End Sub

    Private Sub popWareOutEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutEdit.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim kwo As New KnifeWareOutController
        Dim kinfo As New KnifeWareOutInfo
        kinfo = kwo.KnifeWareOut_GetNUM(GridView2.GetFocusedRowCellValue("WO_NUM").ToString)

        If IsDBNull(kinfo.WO_Check) = True Or kinfo.WO_Check = False Then
            Edit = True
            Dim fr As frmKnifeWareOutSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmKnifeWareOutSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmKnifeWareOutSub
            fr.EditItem = "出庫單"
            fr.MdiParent = MDIMain
            fr.EditID = GridView2.GetFocusedRowCellValue("WO_ID").ToString
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此單已被審核，不允許修改", 64, "提示")
            Exit Sub
        End If
    End Sub

    Private Sub popWareOutCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutCheck.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub
        Dim kwo As New KnifeWareOutController
        Dim kinfo As New KnifeWareOutInfo
        kinfo = kwo.KnifeWareOut_GetNUM(GridView2.GetFocusedRowCellValue("WO_NUM").ToString)

        Dim fr As frmKnifeWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmKnifeWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmKnifeWareOutSub
        fr.EditItem = "popWareOutCheck"
        fr.MdiParent = MDIMain
        fr.EditID = GridView2.GetFocusedRowCellValue("WO_ID").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareOutReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutReCheck.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim kwo As New KnifeWareOutController
        Dim kinfo As New KnifeWareOutInfo
        kinfo = kwo.KnifeWareOut_GetNUM(GridView2.GetFocusedRowCellValue("WO_NUM").ToString)

        If kinfo.WO_Check = True Then
            Dim fr As frmKnifeWareOutSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmKnifeWareOutSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New frmKnifeWareOutSub
            fr.EditItem = "popWareOutReCheck"
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.EditID = GridView2.GetFocusedRowCellValue("WO_ID").ToString
            fr.Show()
        Else
            MsgBox("此單未被審核，請先審核當前出庫單!", 64, "提示")
            Exit Sub
        End If
    End Sub

    Private Sub popWareOutAddBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAddBarCode.Click
        Edit = False
        If TreeView1.SelectedNode Is Nothing Then
            MsgBox("請選擇正確的倉庫!", 64, "提示")
            Exit Sub
        Else
            Dim fr As New frmKnifeWareOutSub

            fr.NodeTag = TreeView1.SelectedNode.Tag
            fr.NodeText = TreeView1.SelectedNode.Text
            fr.EditItem = "出庫單"
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.isBarCode = True
            fr.Show()
        End If
    End Sub


    Private Sub ModifyRemarkTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyRemarkTool.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        Dim kwo As New KnifeWareOutController
        Dim kinfo As New KnifeWareOutInfo

        kinfo = kwo.KnifeWareOut_GetNUM(GridView2.GetFocusedRowCellValue("WO_NUM").ToString)
        Dim fr As frmKnifeWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmKnifeWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmKnifeWareOutSub
        fr.EditItem = "ModifyRemarkTool" '修改備注
        fr.MdiParent = MDIMain
        fr.EditID = GridView2.GetFocusedRowCellValue("WO_ID").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub popwareOutView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popwareOutView.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim fr As frmKnifeWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmKnifeWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmKnifeWareOutSub
        fr.EditItem = "popwareOutView"
        fr.MdiParent = MDIMain
        fr.EditID = GridView2.GetFocusedRowCellValue("WO_ID").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popwareOutflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popwareOutflesh.Click
        Dim kwo As New KnifeWareOutController
        Grid1.DataSource = kwo.KnifeWareOut_GetList5(Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag.ToString, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing, Nothing, Nothing)
    End Sub

    Private Sub popWareOutPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutPrint.Click
        Dim DsA As New DataSet
        If GridView2.RowCount = 0 Then Exit Sub
        Dim ltc, ltc1, ltc2, ltc3, ltc4, ltc5 As New CollectionToDataSet

        Dim pmc As New KnifeWareOutController
        Dim uc As New UnitController
        Dim suc As New SystemUser.SystemUserController
        Dim wh As New WareHouseController

        Dim pmc2 As New WhiteUserListController
        Dim uc2 As New DepartmentControler

        DsA.Tables.Clear()
        Dim strA, strB As String
        'strA = txtWIPID.Text
        'strB = TextEdit1.Text

        strA = GridView2.GetFocusedRowCellValue("WO_ID").ToString
        strB = GridView2.GetFocusedRowCellValue("WO_PerID").ToString

        ltc.CollToDataSet(DsA, "KnifeWareOut", pmc.KnifeWareOut_GetList5(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(DsA, "Unit", uc.GetUnitList(Nothing))
        ltc2.CollToDataSet(DsA, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(DsA, "WareHouse", wh.WareHouse_GetList(Nothing))
        ltc4.CollToDataSet(DsA, "WhiteUserList", pmc2.WhiteUserList_GetList(strB, Nothing))
        ltc5.CollToDataSet(DsA, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))

        PreviewRPT(DsA, "rptKnifeWareOut0", "出庫單", True, True)

        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing
    End Sub

    Private Sub frmKnifeWareOutMain_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        KnifeWareTreeView = TreeView1
        KnifeWareBarManager = BarManager2
        KnifeWareLoad(ImageList1, "510205")
    End Sub

    Private Sub popWareOutSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutSeek.Click
        Dim kwo As New LFERP.Library.KnifeWare.KnifeWareOutController
        Dim fr As New frmKnifeSelect
        fr.ComboBoxEdit1.Properties.Items.Add("出庫單號")
        tempValue = "刀具出庫"
        Try
            tempValue4 = TreeView1.SelectedNode.Tag
        Catch ex As Exception
        End Try
        fr.ShowDialog()
        If RefreshT = True Then
            Dim ws As New LFERP.Library.KnifeWare.KnifeWareSelectController
            Select Case tempValue
                Case 1
                    Grid1.DataSource = kwo.KnifeWareOut_Getlist(tempValue2, Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 2
                    Grid1.DataSource = kwo.KnifeWareOut_Getlist(Nothing, Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 3
                    Grid1.DataSource = kwo.KnifeWareOut_Getlist(Nothing, Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 4
                    Grid1.DataSource = kwo.KnifeWareOut_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 5
                    Grid1.DataSource = kwo.KnifeWareOut_Getlist(Nothing, Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2)
                Case 6
                    Grid1.DataSource = ws.WareOut_Getlist("刀具出庫", tempValue2)
                    RefreshT = False
            End Select
            tempValue = ""
            tempValue2 = ""
            tempValue4 = ""
        End If
    End Sub

    Private Sub popWareOutPrintColl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutPrintColl.Click
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim mc As New KnifeWareOutController

        If GridView2.RowCount <= 0 Then Exit Sub
        'Dim strSO_No As String
        'strSO_No = GridView2.GetFocusedRowCellValue("WO_ID").ToString

        '**************************************************************
        '*******************2013-11-11 姚駿新增************************
        Dim strMonthly As String
        Dim strDtAll As Date
        Dim lstExport As List(Of KnifeWareOutInfo)
        Dim frmKnWareOutput As frmKnifeWareOutPutExport = New frmKnifeWareOutPutExport
        frmKnWareOutput.ShowDialog()

        If frmKnifeWareOutPutExport.DTReport = "" And Not frmKnifeWareOutPutExport.BolReport Then Exit Sub
        strMonthly = frmKnifeWareOutPutExport.DTReport
        strDtAll = Convert.ToDateTime(frmKnifeWareOutPutExport.DTReportAll)

        If Not frmKnifeWareOutPutExport.BolReport Then
            lstExport = mc.KnifeWareOutExportReport_GetList(TreeView1.SelectedNode.Tag, strMonthly, DateAdd(DateInterval.Day, -9, CDate(Format(strDtAll, "yyyy/MM/dd"))))
            If (lstExport Is Nothing) Or (lstExport.Count = 0) Then
                MessageBox.Show("導出數據為空")
                Exit Sub
            End If
            ltc.CollToDataSet(ds, "KnifeWareOut", lstExport)

            If (ds.Tables.Count < 0 Or ds.Tables.Count = 0) Then
                MessageBox.Show("導出數據為空")
                Exit Sub
            End If
            Grid1.DataSource = lstExport
            m_BolReport = True
        Else
            lstExport = mc.KnifeWareOutExportReport_GetList(TreeView1.SelectedNode.Tag, strMonthly, DateAdd(DateInterval.Day, -9, CDate(Format(strDtAll, "yyyy/MM/dd"))))

            If lstExport.Count = 0 Then
                MessageBox.Show("導出數據為空")
                Exit Sub
            End If

            Grid1.DataSource = lstExport
            m_BolReport = True
        End If

        If (frmKnifeWareOutPutExport.BolReport) Then
            Dim saveFileDialog As New SaveFileDialog()

            saveFileDialog.Title = "導出Excel"

            saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
            '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

            Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

            If dialogResult__1 = Windows.Forms.DialogResult.OK Then
                GridView2.BestFitColumns()
                Grid1.ExportToExcelOld(saveFileDialog.FileName)
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Exit Sub

        End If

        'ltc.CollToDataSet(ds, "KnifeWareOut", mc.KnifeWareOut_Getlist(TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        PreviewRPT(ds, "rptKnifeWareOut", "刀具出庫單", True, True)
        ltc = Nothing

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ExportlStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportlStripMenuItem.Click

    End Sub
End Class