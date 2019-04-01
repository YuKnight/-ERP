Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareBorrowReturn
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareSelect

Public Class frmWareReturnMain

    Private Sub frmWareReturnMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New WareHouseController
        Dim mc As New WareOut.WareOutController


        CaptionLabel.Text = "還刀作業"
        'mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "50100201"))

        ''暫時固定---------------------------------------
        'TreeView1.Nodes.Add("半成品倉").Tag = "W16"
        'TreeView1.Nodes(0).Nodes.Add("待檢").Tag = "W1609"
        'TreeView1.ExpandAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0).Nodes(0)
        ''-----------------------------------------------

        Dim a As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim b As New List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)
        b = a.PermissionModuleWarrantSub_GetList(InUserID, "50100201")

        mt.WareHouse_LoadToTreeViewIn(TreeView1, WareInSelect(InUserID, "50100201"), b.Item(0).PMWS_Value)
        '--------------------------------------------------------


        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripReturnAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripReturnAddR.Enabled = True
        End If

    End Sub

    Sub LoadReturn()
        Grid1.DataSource = Nothing
        Grid1.ContextMenuStrip = WareReturnContext
        GridView2.Columns.Clear()

        Dim StrA As String, StrB As String

        StrA = "自動編號, 還刀流水號, 還刀單號, 刀具編碼,名稱, 規格,歸還數量,單位,還刀人,代還人,倉庫名稱, 還刀日期,操作人"
        StrB = "AutoID, WB_NUM, WB_NO, M_Code, M_Name, M_Gauge, Qty,WB_Action,RR_PerName,WB_Date, WH_Name,WB_Date,WB_ActionName"

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

    Private Sub ToolStripReturnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnAdd.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode.Level = 1 Then
            Dim fr As frmWareReturn
            tempValue = "還刀單"
            tempValue3 = TreeView1.SelectedNode.Tag
            tempValue4 = TreeView1.SelectedNode.Text
            fr = New frmWareReturn
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        '-----------------------------------------------------------
        ''On Error Resume Next
        ''Edit = False
        ''Dim fr As frmWareReturn
        ''tempValue = "還刀單"
        ''tempValue3 = "W1609"
        ''tempValue4 = "待檢倉"
        ''fr = New frmWareReturn
        ''fr.MdiParent = MDIMain
        ''fr.WindowState = FormWindowState.Maximized
        ''fr.Show()
   


    End Sub

    Private Sub ToolStripReturnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnRefresh.Click
        Dim bc As New WareBorrowReturnControl
        Me.Grid1.DataSource = bc.WareBorrowReturn_GetList(Nothing, Nothing, "還刀", Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub ToolStripReturnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnView.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim fr As frmWareReturn

        tempValue = "查看"
        tempValue5 = GridView2.GetFocusedRowCellValue("WB_NO").ToString
        fr = New frmWareReturn
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Level = 1 Then
            ToolStripReturnRefresh_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub ToolStripReturnAddR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnAddR.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode.Level = 1 Then
            Dim fr As frmWareReturn
            tempValue = "代還刀"
            tempValue3 = TreeView1.SelectedNode.Tag
            tempValue4 = TreeView1.SelectedNode.Text
            fr = New frmWareReturn
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        ''On Error Resume Next
        ''Edit = False
        ''Dim fr As frmWareReturn
        ''tempValue = "代還刀"
        ''tempValue3 = "W1609"
        ''tempValue4 = "待檢倉"
        ''fr = New frmWareReturn
        ''fr.MdiParent = MDIMain
        ''fr.WindowState = FormWindowState.Maximized
        ''fr.Show()
 
    End Sub

    Private Sub ToolStripReturnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnFind.Click

        If TreeView1.SelectedNode.Level = 1 Then
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        Dim mc As New WareBorrowReturnControl
        Dim fr As New frmWareSelect
        tempValue = "還刀作業"
        tempValue4 = TreeView1.SelectedNode.Tag
        fr.ShowDialog()

        Select Case tempValue
            Case "1"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(Nothing, tempValue2, "還刀", Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(Nothing, Nothing, "還刀", tempValue2, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                Grid1.DataSource = mc.WareBorrowReturn_GetList(tempValue2, Nothing, "還刀", Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "6"
                Dim ws As New WareSelectControl
                Grid1.DataSource = ws.WareBorrowReturn_Getlist("還刀作業", tempValue2)
        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub ToolStripReturnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturnPrint.Click
       
        If GridView2.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim strA As String

        Dim ltc As New CollectionToDataSet
        strA = GridView2.GetFocusedRowCellValue("WB_NO").ToString

        Dim bc As New WareBorrowReturnControl
        ltc.CollToDataSet(ds, "WareBorrowReturn", bc.WareBorrowReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        PreviewRPT(ds, "rptWareReturn", "還刀單", True, True)
        ltc = Nothing
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
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

    Private Sub CopyALLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyALLToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "WB_NUM,WB_NO,M_Code,M_Name,M_Gauge,Qty,WB_Action,RR_PerName,WH_Name,DPT_Name,WB_Date,WB_ActionName"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "WB_NUM,WB_NO,M_Code,M_Name,M_Gauge,Qty,WB_Action,RR_PerName,WH_Name,DPT_Name,WB_Date,WB_ActionName"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "")
    End Sub
End Class