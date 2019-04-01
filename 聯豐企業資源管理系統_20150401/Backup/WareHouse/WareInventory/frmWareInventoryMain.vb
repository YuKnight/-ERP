Imports LFERP.Library.WareHouse
Imports LFERP.Library.Shared
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.BarCode
Imports LFERP.FileManager
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports LFERP.Library.Product


Public Class frmWareInventoryMain
    Dim VisibleGrid1 As Boolean
    Dim LoadBZ As String = ""

    Private Sub frmWareInventoryMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.GridShelves.AutoGenerateColumns = False
        'GridShelves.RowHeadersWidth = 15

        Dim mt As New WareHouseController
        Dim wic As New WareInventory.WareInventoryMTController
        Dim wil As New List(Of WareInventory.WareInventoryInfo)
        '  mt.WareHouse_LoadToTreeView(twWare, ErpUser.WareHouseList)

        mt.WareHouse_LoadToTreeView(twWare, WareSelect(InUserID, "500401"))

        VisibleGrid1 = False

        PowerUser()

        ''警告 查詢顯示
        'If tempValue <> "" Then

        '    Grid1.DataSource = wic.WareInventory_GetList2(Nothing, tempValue)
        '    tempValue = ""
        'End If
        SplitContainer3.Panel2MinSize = 0
        SplitContainer3.SplitterDistance = SplitContainer3.Height + 100

        If VisibleGrid1 = True Then

            GridControl1.Visible = True
            Grid1.DataSource = wic.WareInventory_GetSum(Nothing, "False")     '@2012/12/21  添加
            SplitContainer3.SplitterDistance = SplitContainer3.Height - 120
        End If



    End Sub
    Sub PowerUser() '設置權限與出庫新增相同（如果用戶擁有出庫的權限允許更改安全庫存數量）
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500402")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventorySafe.Enabled = True '
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500403")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangePrice.Enabled = True '
        End If

        '@2013/1/11 添加
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500404")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then VisibleGrid1 = True
        End If

        ''2013-2-22 磨刀部條碼打印
        popWareInventoryBarCode.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500405")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventoryBarCode.Enabled = True
        End If

        popWareInventoryBarCodeMD.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500406")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventoryBarCodeMD.Enabled = True
        End If

        ToolStripDetail.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500407")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripDetail.Visible = True
        End If

        ''---------------------------------------

        ToolStripMothPrice.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500408")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripMothPrice.Visible = True
        End If

        ToolStripMonthDetail.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500409")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripMonthDetail.Visible = True
        End If



    End Sub
    Private Sub twWare_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twWare.AfterSelect
        Dim mt As New WareInventory.WareInventoryMTController
        Dim pt As New ProductInventoryController

        If twWare.SelectedNode.Level = 1 Then
            mt.LoadNodes(twType, twWare.SelectedNode.Tag())
            WI_Qty.FieldName = "WI_Qty"
            GridColumn5.Visible = True

          

            If twWare.SelectedNode.Tag = "W1101" Then      '@ 2013/4/2  添加
                WI_Qty.FieldName = "PI_Qty"
                GridColumn5.Visible = False
                Grid1.DataSource = pt.ProductInventory_GetList(Nothing, Nothing, "W1101", 0)
            End If

            twType.ExpandAll()


        End If

        If VisibleGrid1 = True Then
            If twWare.SelectedNode.Level = 1 Or twWare.SelectedNode.Level = 0 Then
                Dim wic As New WareInventory.WareInventoryMTController
                Grid1.DataSource = wic.WareInventory_GetSum(Nothing, "False")     '@2012/12/21  添加
            End If
        End If

        Grid1.DataSource = Nothing
        GridControl1.DataSource = Nothing

    End Sub

    Private Sub twType_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twType.AfterSelect
        Dim mt As New WareInventory.WareInventoryMTController

        If twType.SelectedNode.Level = 3 Then
            'Grid.DataSource = mt.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            Grid1.DataSource = mt.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Sub popWareInventorySeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareInventorySeek.Click
        tempCode = ""
        tempValue6 = "倉庫庫存查詢"
        If Len(twWare.SelectedNode.Tag) = 5 Then
            tempValue5 = twWare.SelectedNode.Tag
        Else
            MsgBox("請選擇具體倉庫名稱!", 64, "提示")
            Exit Sub
        End If

        frmBOMSelect.ShowDialog()

        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = False

        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim mt As New WareInventory.WareInventoryMTController
            Dim pic As New ProductInventoryController

            'Dim strA As String = "'" & tempCode & "'"
            Dim strB As String
            Dim strA As String
            If twWare.SelectedNode.Tag = "W1101" Then          '@ 2013/4/24 修改 查成品倉庫存
                Grid1.DataSource = pic.ProductInventory_GetList(tempCode, Nothing, twWare.SelectedNode.Tag, Nothing)
            Else
                If Len(tempCode) > 17 Then
                    strB = Mid(tempCode, 2, Len(tempCode))
                    strA = strB
                    Grid1.DataSource = mt.WareInventory_GetMaterial(Nothing, twWare.SelectedNode.Tag, strA)
                Else
                    strB = tempCode
                    strA = "'" & strB & "'"
                    Grid1.DataSource = mt.WareInventory_GetMaterial(Nothing, twWare.SelectedNode.Tag, strA)
                End If
            End If
        End If
    End Sub

    Private Sub popWareInventoryPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareInventoryPrint.Click
        Dim myfrm As New frmWareInventorySeek
        myfrm.ShowDialog()

        If isClickButton = False Then Exit Sub

        Dim ds As New DataSet
        If tempValue = "" Then
            MsgBox("請選擇正確的倉庫！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim TC As New TempController
        Dim Ti As New TempInfo
        Dim strReportName As String = ""

        Ti.Str1 = tempValue5
        TC.Temp2_Add(Ti)

        If tempValue8 = "基本表" Then
            strReportName = "rptWareInventory"
        ElseIf tempValue8 = "盤點用表" Then
            strReportName = "rptWareInventory1"
        End If

        If tempValue5 = "現時" Then
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet

            Dim pmc As New WareInventory.WareInventoryMTController
            Dim uc As New UnitController
            Dim wh As New WareHouseController


            ds.Tables.Clear()
            Dim strA As String
            strA = tempValue
            tempValue = ""
            If pmc.WareInventory_GetMaterial(Nothing, strA, Nothing).Count = 0 Then
                Exit Sub
            End If

            If pmc.WareInventory_GetMaterial(Nothing, strA, Nothing).Count = 0 Then
                MsgBox("當前倉庫無物料庫存記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventory_GetMaterial(Nothing, strA, Nothing))
            ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))

            PreviewRPT1(ds, strReportName, "庫存表", UserName, "l", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc4 = Nothing
            ltc3 = Nothing
        Else
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet

            Dim pmc As New WareInventory.WareInventoryMTController
            Dim uc As New UnitController
            Dim wh As New WareHouseController


            ds.Tables.Clear()
            Dim strA As String
            strA = tempValue
            tempValue = ""

            If pmc.WareInventoryBackup_GetMaterial(Nothing, strA, Nothing, tempValue6, tempValue7).Count = 0 Then
                MsgBox("當前倉庫月份庫存記錄不存在,請檢查原因!")
                Exit Sub
            End If


            ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventoryBackup_GetMaterial(Nothing, strA, Nothing, tempValue6, tempValue7))
            ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))

            PreviewRPT1(ds, strReportName, "庫存表", UserName, "l", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc4 = Nothing
            ltc3 = Nothing
        End If
    
        tempValue5 = ""
        tempValue = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    Private Sub popWareInventorySafe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInventorySafe.Click
        If GridView2.RowCount = 0 Then Exit Sub

        tempValue2 = GridView2.GetFocusedRowCellValue("WI_SafeQty").ToString
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString

        Dim frm As New frmWareInventorySafe
        frm.ShowDialog()

        If tempValue3 = Nothing Then Exit Sub

        Dim pmc As New WareInventory.WareInventoryMTController
        Dim pi As New WareInventory.WareInventoryInfo

        pi.WH_ID = GridView2.GetFocusedRowCellValue("WH_ID").ToString
        pi.M_Code = tempValue4
        pi.WI_SafeQty = tempValue3
        pi.WI_UserID = InUserID
        pi.WI_EditDate = Format(Now, "yyyy/MM/dd")

        If pmc.WareInventory_Update(pi) = True Then
            MsgBox("更改安全庫存成功！")
            Grid1.DataSource = pmc.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
        Else
            MsgBox("更改安全庫存失敗，請檢查原因！")
            Exit Sub
        End If
        tempValue3 = ""
        tempValue4 = ""
    End Sub

    '物料出入庫明細查詢
    Private Sub popBatchCodeSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchCodeSelect.Click
        If twWare.SelectedNode.Level = 1 Then
            tempValue = twWare.SelectedNode.Tag
            'If GridView2.RowCount = 0 Then Exit Sub
            If GridView2.RowCount > 0 Then
                tempValue2 = GridView2.GetFocusedRowCellValue("M_Code").ToString
            End If
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        'frmBatchCodeSelect.ShowDialog()
        frmWareInventoryAll.ShowDialog()  '測試
    End Sub

    Private Sub PrintSetBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetBarCode.Click

        If GridView2.RowCount = 0 Then Exit Sub
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString
        Dim frm As New frmWareInventoryBarCode
        frm.ShowDialog()

    End Sub

    Private Sub PrintAllBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllBarCode.Click

        Dim pmc As New WareInventory.WareInventoryMTController
        Dim pmi As List(Of WareInventoryInfo)

        pmi = pmc.WareInventory_GetList3(Nothing, twWare.SelectedNode.Tag, "True")

        If pmi.Count = 0 Then
            Exit Sub
        Else
            Dim i As Integer
            For i = 0 To pmi.Count - 1
                Dim bc As New BarCodeControl

                bc.PrintSBar(pmi(i).M_Code, pmi(i).M_Name, "LPT3")   '測試端口!

                Threading.Thread.Sleep(1000)  '延時秒觸發

            Next
        End If

    End Sub

 
    Private Sub Popexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Popexport.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        If MsgBox("你確定要導出當前所查詢物料的信息嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub
      
        'Dim exapp As New Excel.Application
        'Dim exbook As Excel.Workbook
        'Dim exsheet As Excel.Worksheet

        'Dim i As Integer = 0, ii As Integer = 0

        'exapp = CreateObject("Excel.Application")
        'exbook = exapp.Workbooks.Add
        'exsheet = exapp.Worksheets(1)

        'exsheet.Cells(1, 1) = "物料編碼"
        'exsheet.Cells(1, 2) = "物料名稱"
        'exsheet.Cells(1, 3) = "規格"
        'exsheet.Cells(1, 4) = "庫存數量"
        'exsheet.Cells(1, 5) = "安全庫存數"
        'exsheet.Cells(1, 6) = "單位"

        'For i = 0 To GridView2.RowCount - 1
        '    ii = i + 2
        '    exsheet.Cells(ii, 1) = "$" & GridView2.GetRowCellValue(i, "M_Code") & "$"
        '    exsheet.Cells(ii, 2) = GridView2.GetRowCellValue(i, "M_Name")
        '    exsheet.Cells(ii, 3) = GridView2.GetRowCellValue(i, "M_Gauge")
        '    exsheet.Cells(ii, 4) = GridView2.GetRowCellValue(i, "WI_Qty")
        '    exsheet.Cells(ii, 5) = GridView2.GetRowCellValue(i, "WI_SafeQty")
        '    exsheet.Cells(ii, 6) = GridView2.GetRowCellValue(i, "M_Unit")

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

    Private Sub PrintNetAllBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNetAllBarCode.Click
        tempValue3 = "指定倉庫打印"
        tempValue4 = twWare.SelectedNode.Tag
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
    End Sub

    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView2.RowCount = 0 Then Exit Sub

        'Dim woc As New WareOut.WareOutController
        'Dim strWHID, strCode As String

        'strWHID = GridView2.GetFocusedRowCellValue("WH_ID").ToString
        'strCode = GridView2.GetFocusedRowCellValue("M_Code").ToString

        'Grid2.DataSource = woc.WareOut_HalfYearGetList(strWHID, strCode, DateAdd(DateInterval.Month, -6, CDate(Format(Now, "yyyy/MM"))), ">=")

    End Sub
    '變更物料單價信息
    Private Sub popChangePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePrice.Click

        'Dim frm As New frmWareInventoryChangePrice
        'frm.ShowDialog()
        Dim frm As New frmPrice
        frm.ShowDialog()


    End Sub

    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "M_Code,M_Name,M_Gauge,WI_Qty,M_Unit,WI_SafeQty"

        GridViewCopyMulitRow(GridView2, FiledNameStr, "")
    End Sub

    Private Sub ToolStripMenuItemALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemALL.Click
        Dim FiledNameStr As String
        FiledNameStr = "M_Code,M_Name,M_Gauge,WI_Qty,M_Unit,WI_SafeQty"

        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub

    Private Sub WareInventMothItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareInventMothItemToolStripMenuItem.Click

        If twWare.SelectedNode.Level = 1 Then
            tempValue4 = twWare.SelectedNode.Tag
            tempValue5 = twWare.SelectedNode.Text
            WareInventoryMothCollSelect.ShowDialog()
            WareInventoryMothCollSelect.Dispose()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        'WareInventoryMothCollSelect.ShowDialog()
        'WareInventoryMothCollSelect.Dispose()
    End Sub

    Private Sub RefreshWarringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWarringToolStripMenuItem.Click
        Dim tempWHID As String

        If Len(twWare.SelectedNode.Tag) = 5 Then
            tempWHID = twWare.SelectedNode.Tag
        Else
            MsgBox("請選擇具體倉庫名稱!", 64, "提示")
            Exit Sub
        End If

        Dim wic As New WareInventory.WareInventoryMTController
        Dim wil As New List(Of WareInventory.WareInventoryInfo)
        Grid1.DataSource = wic.WareInventory_GetList2(Nothing, tempWHID)

    End Sub

    '2013/2/22
    Private Sub PrintSetBarCodeMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetBarCodeMD.Click
        If GridView2.RowCount = 0 Then Exit Sub
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString
        tempValue3 = "磨刀部指定打印"

        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
        myfrm.Dispose()
    End Sub

    Private Sub PrintNetAllBarCodeMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNetAllBarCodeMD.Click
        If twWare.SelectedNode.Tag Is Nothing Then Exit Sub

        tempValue3 = "磨刀部指定倉庫"
        tempValue4 = twWare.SelectedNode.Tag
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
        myfrm.Dispose()
    End Sub

    '@2013/3/18  添加
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount <= 0 Then Exit Sub

        If GridControl1.Visible = True Then
            Dim wic As New WareInventory.WareInventoryMTController
            Dim wil As New List(Of WareInventory.WareInventoryInfo)

            GridControl1.DataSource = wic.WareInventory_GetList3(GridView2.GetFocusedRowCellValue("M_Code").ToString, Nothing, "False")
        End If
    End Sub

    Private Sub ToolStripDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDetail.Click
        On Error Resume Next

        Dim fr As frmWareOutINDetails
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareOutINDetails Then
                fr.Activate()
                Exit Sub
            End If
        Next


        fr = New frmWareOutINDetails
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ToolStripMothPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMothPrice.Click

        tempValue = "500408"

        Dim fr As New Form
        fr = frmWareHouseDetailMothPrice
        fr.ShowDialog()
        fr.Dispose()

        tempValue = Nothing

    End Sub

    Private Sub ToolStripMonthDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMonthDetail.Click

        tempValue = "500409"

        Dim fr As New Form
        fr = frmWareHouseDetailMothPrice
        fr.ShowDialog()
        fr.Dispose()

        tempValue = Nothing

    End Sub
End Class