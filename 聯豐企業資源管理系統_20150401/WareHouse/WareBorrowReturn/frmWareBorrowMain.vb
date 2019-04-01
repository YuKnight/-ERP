Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareBorrowReturn
Imports LFERP.DataSetting
Imports LFERP.SystemManager

Imports LFERP.Library.WareHouse.WareSelect

Public Class frmWareBorrowMain

    Private Sub frmWareBorrowReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mt As New WareHouseController
        CaptionLabel.Text = "借刀作業"
        mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "50100101"))


        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripBorrowAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripBorrowDelay.Enabled = True
        End If

        XtraTabControl1.SelectedTabPage = Me.XtraTabPage1

    End Sub



    Sub LoadBorrow()
        Grid1.DataSource = Nothing
        Grid1.ContextMenuStrip = WareBorrowContext
        GridView2.Columns.Clear()

        Dim StrA As String, StrB As String
        StrA = "自動編號, 借刀流水號, 借刀單號, 刀具編碼,名稱, 規格,借出數量,未還數量,單位,借刀人,部門,倉庫名稱, 借出日期, 操作人"
        StrB = "AutoID, WB_NUM, WB_NO, M_Code, M_Name, M_Gauge, Qty, NO_ReQty, M_Unit,WB_PerName,DPT_Name,WH_Name, WB_Date, WB_ActionName"

        Dim StrAarray As Array = Split(StrA, ",")
        Dim StrBarray As Array = Split(StrB, ",")

        For i As Integer = 0 To UBound(StrAarray)
            Dim Coll As New DevExpress.XtraGrid.Columns.GridColumn
            Coll.Caption = Trim(StrAarray(i))
            Coll.FieldName = Trim(StrBarray(i))
            Coll.OptionsColumn.AllowEdit = False
            Coll.Visible = True
            Coll.VisibleIndex = GridView2.Columns.Count
            GridView2.Columns.Add(Coll)
        Next

    End Sub

    Private Sub ToolStripBorrowAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowAdd.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode.Level = 1 Then
            Dim fr As frmWareBorrow
            tempValue = "借刀單"
            tempValue3 = TreeView1.SelectedNode.Tag
            tempValue4 = TreeView1.SelectedNode.Text
            fr = New frmWareBorrow
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripBorrowRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowRefresh.Click
        Dim bc As New WareBorrowReturnControl
        Me.Grid1.DataSource = bc.WareBorrowReturn_GetList(Nothing, Nothing, "借刀", Nothing, 100, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub ToolStripBorrowView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowView.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        Dim fr As frmWareBorrow

        tempValue = "查看"
        tempValue5 = GridView2.GetFocusedRowCellValue("WB_NO").ToString
        fr = New frmWareBorrow
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub


    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Level = 1 Then
            ToolStripBorrowRefresh_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ToolStripBorrowFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowFind.Click


        If TreeView1.SelectedNode.Level = 1 Then
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        Dim mc As New WareBorrowReturnControl
        Dim fr As New frmWareSelect
        tempValue = "借刀作業"
        tempValue4 = TreeView1.SelectedNode.Tag
        fr.ShowDialog()

        Select Case tempValue
            Case "1"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(Nothing, tempValue2, "借刀", Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(Nothing, Nothing, "借刀", tempValue2, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(tempValue2, Nothing, "借刀", Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "6"
                Dim ws As New WareSelectControl
                Grid1.DataSource = ws.WareBorrowReturn_Getlist("借刀作業", tempValue2)
        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub ToolStripBorrowPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowPrint.Click

        If GridView2.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim strA As String

        Dim ltc As New CollectionToDataSet
        strA = GridView2.GetFocusedRowCellValue("WB_NO").ToString

        Dim bc As New WareBorrowReturnControl
        ltc.CollToDataSet(ds, "WareBorrowReturn", bc.WareBorrowReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        PreviewRPT(ds, "rptWareBorrow", "借刀單", True, True)
        ltc = Nothing
    End Sub

    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged

        Grid2.DataSource = Nothing

        If GridView2.RowCount <= 0 Then Exit Sub

        ''str1
        Dim WCH As New WareBorrowChange.WareBorrowChangeControl
        Me.GridC.DataSource = WCH.WareBorrowChange_GetList(Nothing, Nothing, GridView2.GetFocusedRowCellValue("WB_NUM").ToString, Nothing, Nothing, Nothing)



        Dim bc As New WareBorrowReturnControl
        Dim bl As New List(Of WareBorrowReturnInfo)

        Dim StrWBR_NO, str1 As String
        str1 = GridView2.GetFocusedRowCellValue("WB_NUM")
        bl = bc.WareBorrowReturnSub_GetList(str1, Nothing, Nothing)

        If bl.Count <= 0 Then
            Exit Sub
        End If

        Dim i1 As Integer
        StrWBR_NO = ""

        For i1 = 0 To bl.Count - 1
            If i1 = 0 Then
                StrWBR_NO = "'" + bl(i1).WR_NUM + "'"
            Else
                StrWBR_NO = StrWBR_NO + ", '" + bl(i1).WR_NUM + "'"
            End If
        Next

        StrWBR_NO = "( " + StrWBR_NO + " )"
        Grid2.DataSource = bc.WareBorrowReturn_GetList(Nothing, Nothing, "還刀", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrWBR_NO)
        ''----------------------------------------------------------------------------------
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim j, j1 As Integer
        For j = 0 To GridView1.RowCount - 1

            Dim bc2 As New WareBorrowReturnControl
            Dim bl2 As New List(Of WareBorrowReturnInfo)
            bl2 = bc2.WareBorrowReturnSub_GetList(str1, GridView1.GetRowCellValue(j, "WB_NUM").ToString, Nothing)

            Dim CellQty As Double
            CellQty = bl2(0).Qty
            Me.GridView1.SetRowCellValue(j, "QtyReal", CellQty)
            ''------------------------------------------------------------
            If GridView1.RowCount >= 2 Then
                Dim bc1 As New WareBorrowReturnControl
                Dim bl1 As New List(Of WareBorrowReturnInfo)
                bl1 = bc1.WareBorrowReturnSub_GetList(str1, GridView1.GetRowCellValue(j, "WB_NUM").ToString, "1")

                If bl1.Count <= 0 Then
                Else
                    Dim ls As String = ""
                    For j1 = 0 To bl1.Count - 1
                        ls = ls + "還" & bl1(j1).WB_NUM & "借刀單, " & bl1(j1).Qty.ToString & "把" & vbCrLf
                    Next

                    Me.GridView1.SetRowCellValue(j, "RemarkReal", ls)
                End If


            End If

        Next


     


    End Sub

    Private Sub ToolStripBorrowDelay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowDelay.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        Dim fr As frmWareBorrow

        tempValue = "借刀延期"
        tempValue5 = GridView2.GetFocusedRowCellValue("WB_NO").ToString
        fr = New frmWareBorrow
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

        '借刀延期
    End Sub

    Private Sub ToolStripBorrowNOReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowNOReturn.Click
        frmWareNOReturn.ShowDialog()
    End Sub


    Private Sub ToolStripBorrowExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowExport.Click

        If GridView2.RowCount = 0 Then Exit Sub
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

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "WB_NUM,WB_NO,M_Code,M_Name,M_Gauge,Qty,NO_ReQty,WB_PerName,DPT_Name,WH_Name,WB_Date,WB_ActionName,DelayDate"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "")
    End Sub

    Private Sub CopyALLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyALLToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "WB_NUM,WB_NO,M_Code,M_Name,M_Gauge,Qty,NO_ReQty,WB_PerName,DPT_Name,WH_Name,WB_Date,WB_ActionName,DelayDate"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        GridView2_FocusedRowChanged(Nothing, Nothing)
    End Sub
End Class