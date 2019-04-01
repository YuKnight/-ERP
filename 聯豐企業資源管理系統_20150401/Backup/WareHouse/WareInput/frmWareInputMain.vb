Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareInput
Imports LFERP.SystemManager
Imports LFERP.FileManager
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports LFERP.Library.WareHouse.WareSelect

Public Class frmWareInputMain

    Private Sub frmWareInputMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Grid1.AutoGenerateColumns = False
        'Grid1.RowHeadersWidth = 15
        Dim mt As New WareHouseController
        Dim mc As New WareInput.WareInputContraller
        mt.WareHouse_LoadToTreeView(twWare, WareSelect(InUserID, "500105"))
        LoadUserPower()
        'Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing)
        popWareInputEdit.Visible = False
        popWareInputDel.Visible = False
        popWareInputCheck.Visible = False

    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputAdd.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputDel.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500106")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputReCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500108")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInputAddBarCode.Enabled = True
        End If

        '修改備注
        ModifyRemarkTool.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500110")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ModifyRemarkTool.Visible = True
        End If

    End Sub

    Private Sub popWareInputAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputAdd.Click
        On Error Resume Next
        Edit = False
        If twWare.SelectedNode.Level = 1 Then
            Dim fr As frmWareInput
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareInput Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "入庫單"
            tempValue3 = twWare.SelectedNode.Tag
            tempValue4 = twWare.SelectedNode.Text
            fr = New frmWareInput
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
      


    End Sub


    Private Sub popWareInputEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputEdit.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub


        Dim mc As New WareInput.WareInputContraller
        Dim mi As New WareInput.WareInputInfo
        mi = mc.WareInput_GetNUM(GridView2.GetFocusedRowCellValue("WIP_NUM").ToString)

        If IsDBNull(mi.WIP_Check) = True Or mi.WIP_Check = False Then
            Edit = True
            Dim fr As frmWareInput
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareInput Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            tempValue = "入庫單"
            tempValue2 = GridView2.GetFocusedRowCellValue("WIP_ID").ToString
            fr = New frmWareInput
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此單已被審核，不允許修改")
            Exit Sub

        End If


    End Sub

    Private Sub popWareInputCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputCheck.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub
        Dim mc As New WareInput.WareInputContraller
        Dim mi As New WareInput.WareInputInfo
        mi = mc.WareInput_GetNUM(GridView2.GetFocusedRowCellValue("WIP_NUM").ToString)
        If mi.WIP_ReCheck = True Then
            MsgBox("該入庫單已復核,不允許取消審核!")
            Exit Sub
        Else
            If mi.WIP_Check = True Then

                Dim fr As frmWareInput
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmWareInput Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next

                tempValue = "取消審核"
                tempValue2 = GridView2.GetFocusedRowCellValue("WIP_ID").ToString
                fr = New frmWareInput
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("該單目前沒有審核,不允許取消審核!")
                Exit Sub
            End If
        End If
       
    End Sub

    Private Sub popWareInputDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputDel.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        Dim mc As New WareInput.WareInputContraller
        Dim mi As New WareInput.WareInputInfo
        mi = mc.WareInput_GetNUM(GridView2.GetFocusedRowCellValue("WIP_NUM").ToString)
        If mi.WIP_Check = False Then

            Dim strDate, strDate1 As Date
            strDate = Format(Now, "yyyy/MM")
            strDate1 = Format(mi.WIP_AddDate, "yyyy/MM")

            If strDate = strDate1 Then

                If MsgBox("確定刪除單號為" & GridView2.GetFocusedRowCellValue("WIP_ID").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If mc.WareInput_Delete(Nothing, GridView2.GetFocusedRowCellValue("WIP_ID").ToString) = True Then
                        MsgBox("刪除成功")
                        'Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing, False)
                        Grid1.DataSource = mc.WareInput_Getlist1(Nothing, Nothing, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing)
                    End If
                End If

            Else
                MsgBox("不是當月入庫單,當前不允許刪除!")
                Exit Sub
            End If
          
        Else
            MsgBox("該單已審核，不允許刪除")
        End If

    End Sub

    Private Sub popWareInputSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputSeek.Click
        Dim mc As New WareInput.WareInputContraller
        'Dim frm As New FrmWareInputFind
        Dim fr As New frmWareSelect
        tempValue = Label1.Text
        tempValue4 = twWare.SelectedNode.Tag
        fr.ShowDialog()

        Select Case tempValue
            Case "1"
                Grid1.DataSource = mc.WareInput_Getlist(tempValue2, Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "3"
                Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "5"
                Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, tempValue2)
            Case "6"
                Dim ws As New WareSelectControl

                Grid1.DataSource = ws.WareInput_Getlist("入庫作業", tempValue2)

        End Select
        tempValue = ""
        tempValue2 = ""
        tempValue4 = ""
    End Sub

    Private Sub popwareinputflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popwareinputflesh.Click
        Dim mc As New WareInput.WareInputContraller

        'Grid1.DataSource = mc.WareInput_Getlist(Nothing, Nothing, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing, False)

        Grid1.DataSource = mc.WareInput_Getlist1(Nothing, Nothing, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing)
    End Sub

    Private Sub twWare_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twWare.AfterSelect
        Dim mc As New WareInput.WareInputContraller
        If e.Node.Level = 1 Then
            Grid1.DataSource = mc.WareInput_Getlist1(Nothing, Nothing, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), ">", Nothing)
        End If
    End Sub

    Private Sub popWareInputView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputView.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim fr As frmWareInput
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareInput Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "查看"
        tempValue2 = GridView2.GetFocusedRowCellValue("WIP_ID").ToString
        fr = New frmWareInput
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ExportStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportStripMenuItem.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        If MsgBox("你確定要當前所有的資料嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        'Dim exapp As New Excel.Application
        'Dim exbook As Excel.Workbook
        'Dim exsheet As Excel.Worksheet

        'Dim i As Integer = 0, ii As Integer = 0

        'exapp = CreateObject("Excel.Application")
        'exbook = exapp.Workbooks.Add
        'exsheet = exapp.Worksheets(1)

        'exsheet.Cells(1, 1) = "入庫單號"
        'exsheet.Cells(1, 2) = "物料編碼"
        'exsheet.Cells(1, 3) = "物料名稱"
        'exsheet.Cells(1, 4) = "規格"
        'exsheet.Cells(1, 5) = "入庫數量"
        'exsheet.Cells(1, 6) = "單位"
        'exsheet.Cells(1, 7) = "批次"
        'exsheet.Cells(1, 8) = "備註"
        'exsheet.Cells(1, 9) = "操作員"
        'exsheet.Cells(1, 10) = "審核"
        'exsheet.Cells(1, 11) = "入庫日期"
        'exsheet.Cells(1, 12) = "審核備註"

        'For i = 0 To GridView2.RowCount - 1
        '    ii = i + 2

        '    exsheet.Cells(ii, 1) = GridView2.GetRowCellValue(i, "WIP_ID")
        '    exsheet.Cells(ii, 2) = "$" & GridView2.GetRowCellValue(i, "M_Code") & "$"
        '    exsheet.Cells(ii, 3) = GridView2.GetRowCellValue(i, "M_Name")
        '    exsheet.Cells(ii, 4) = GridView2.GetRowCellValue(i, "M_Gauge")
        '    exsheet.Cells(ii, 5) = GridView2.GetRowCellValue(i, "WIP_Qty")
        '    exsheet.Cells(ii, 6) = GridView2.GetRowCellValue(i, "M_Unit")
        '    exsheet.Cells(ii, 7) = GridView2.GetRowCellValue(i, "OS_BatchID")
        '    exsheet.Cells(ii, 8) = GridView2.GetRowCellValue(i, "WIP_Remark")
        '    exsheet.Cells(ii, 9) = GridView2.GetRowCellValue(i, "WIP_ActionName")
        '    exsheet.Cells(ii, 10) = GridView2.GetRowCellValue(i, "WIP_Check")
        '    exsheet.Cells(ii, 11) = CDate(GridView2.GetRowCellValue(i, "WIP_AddDate"))
        '    exsheet.Cells(ii, 12) = GridView2.GetRowCellValue(i, "WIP_CheckRemark")

        'Next
        'exapp.Visible = True

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

    End Sub
    '附加當前入庫資料文件
    Private Sub popwareInputLoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popwareInputLoadFile.Click

        Dim open, update, down, edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView2.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505005")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505006")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If

        FileShow("5001", GridView2.GetFocusedRowCellValue("WIP_ID").ToString, open, update, down, edit, del, detail)
    End Sub
    '列印當前入庫單
    Private Sub popWareInputPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputPrint.Click
        Dim ds As New DataSet

        If GridView2.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet

        Dim pmc As New WareInputContraller
        Dim suc As New SystemUser.SystemUserController
        Dim wh As New WareHouseController
        Dim uc2 As New DataSetting.DepartmentControler

        ds.Tables.Clear()
        Dim strA As String
        strA = GridView2.GetFocusedRowCellValue("WIP_ID").ToString

        ltc.CollToDataSet(ds, "WareInput", pmc.WareInput_Getlist(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
        ltc2.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))

        Dim mc As New WareInput.WareInputContraller
        Dim mi As New WareInput.WareInputInfo
        mi = mc.WareInput_GetNUM(GridView2.GetFocusedRowCellValue("WIP_NUM").ToString)

        If mi.WIP_Check = False Then
            PreviewRPT(ds, "rptWareInput", "入庫單", False, False)
        Else
            PreviewRPT(ds, "rptWareInput", "入庫單", True, False)
        End If
      
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing

    End Sub

    Private Sub popWareInputReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputReCheck.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim mc As New WareInput.WareInputContraller
        Dim mi As New WareInput.WareInputInfo
        mi = mc.WareInput_GetNUM(GridView2.GetFocusedRowCellValue("WIP_NUM").ToString)

        If mi.WIP_Check = True Then
            Dim fr As frmWareInput
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareInput Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            tempValue = "復核"
            tempValue2 = GridView2.GetFocusedRowCellValue("WIP_ID").ToString
            fr = New frmWareInput
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("該入庫單還未被審核!請先確認審核!")
            Exit Sub
        End If
      
    End Sub

    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "WIP_ID,M_Code,M_Name,M_Gauge,WIP_Qty,M_Unit,WIP_Remark,WIP_ActionName,WIP_Check,WIP_AddDate,WIP_CheckRemark"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "")
    End Sub

    Private Sub COPYall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYall.Click
        Dim FiledNameStr As String
        FiledNameStr = "WIP_ID,M_Code,M_Name,M_Gauge,WIP_Qty,M_Unit,WIP_Remark,WIP_ActionName,WIP_Check,WIP_AddDate,WIP_CheckRemark"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub

    Private Sub popWareInputAddBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInputAddBarCode.Click
        Edit = False
        If twWare.SelectedNode.Level = 1 Then
            Dim fr As New frmWareInput

            tempValue = "入庫單"
            tempValue3 = twWare.SelectedNode.Tag
            tempValue4 = twWare.SelectedNode.Text

            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.isBarCode = True
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
    End Sub

    Private Sub ModifyRemarkTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyRemarkTool.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub


        Dim fr As frmWareInput
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareInput Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "修改備注"
        tempValue2 = GridView2.GetFocusedRowCellValue("WIP_ID").ToString
        fr = New frmWareInput
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub


End Class