Imports LFERP.Library.WareHouse.WareMove
Imports LFERP.Library.WareHouse
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareSelect
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Public Class frmWareMoveMain
    Dim isBarCode As Boolean '記錄是否是條碼掃描

    Private Sub frmWareMoveMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New WareHouseController
        mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "500306"))

        isBarCode = False

        LoadUserPower()

        tv1.CollapseAll()
    End Sub

    

    Private Sub popWareMoveOutAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveOutAdd.Click

        On Error Resume Next
        Edit = False
        MTypeName = "WareMoveAddEdit"
        If TreeView1.SelectedNode.Level = 1 Then
            Dim fr As frmWareMoveOut
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareMoveOut Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            tempValue2 = TreeView1.SelectedNode.Tag

            fr = New frmWareMoveOut
            fr.isBarCode = isBarCode
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveOutAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveEdit.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveDel.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500304")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveIn.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500305")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500307")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then isBarCode = True
        End If


    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        tempValue2 = ""
        Dim wmc As New WareMoveController
        Dim wmi As New WareMoveInfo
        If e.Node.Level = 1 Then

            Grid1.DataSource = wmc.WareMove_GetList1(Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
            tempValue2 = TreeView1.SelectedNode.Tag

            tv1.ExpandAll() 'TV1展開所有目錄

            Dim a As New WareMoveController
            Dim b As New List(Of WareMoveInfo)
            Dim c As New List(Of WareMoveInfo)
            b = a.WareMove_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, False, "2")
            c = a.WareMove_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, False, "2")
            If b.Count > 0 Then
                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核 (" & b.Count & ")"
            Else
                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核"
            End If

            If c.Count > 0 Then
                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核 (" & c.Count & ")"
            Else
                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核"
            End If

        End If
    End Sub

    Private Sub popWareMoveEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveEdit.Click
        On Error Resume Next
        Dim osc As New WareMoveController
        Dim osilist As New List(Of WareMoveInfo)


        osilist = osc.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1")
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此調撥單已確認！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", Nothing, True, "1")
        If osilist.Count <> 0 Then

            MsgBox("無法修改,此驗收單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "發料" Then
            MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If


        ''2013-5-2 修改不能修改其它用戶調撥記錄
        Dim osc1 As New WareMoveController
        Dim osilist1 As New List(Of WareMoveInfo)
        osilist1 = osc1.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "發料", Nothing, False, "1")
        If osilist1.Count > 0 Then
            If osilist1(0).MV_OutAction = InUserID Then
            Else
                MsgBox("您不能對其它用戶的調撥,信息修改!", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        End If




        tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
        MTypeName = "WareMoveAddEdit"
        Edit = True

        Dim fr As frmWareMoveOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareMoveOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmWareMoveOut
        fr.MdiParent = MDIMain
        fr.isBarCode = isBarCode
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveIn.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString

        Dim a As New WareMoveController
        Dim b As New List(Of WareMoveInfo)

        b = a.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, "1")
        If b.Count > 0 Then
            MsgBox("此單已審核,無法再收貨！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "收料" Then
            MsgBox("您隻能對'收料'性質的記錄收貨確認操作！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        MTypeName = "WareMoveIn"

        Dim fr As frmWareMoveOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareMoveOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmWareMoveOut
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveDel.Click
        On Error Resume Next
        Dim osc As New WareMoveController
        Dim osilist As New List(Of WareMoveInfo)


        osilist = osc.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1")
        If osilist.Count <> 0 Then

            MsgBox("無法刪除,此調撥單已確認！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        osilist = osc.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", Nothing, True, "1")
        If osilist.Count <> 0 Then

            MsgBox("無法刪除,此調撥單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If


        If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "發料" Then
            MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If


        Dim StrA As String
        StrA = GridView1.GetFocusedRowCellValue("MV_NO").ToString
        If MsgBox("你確定刪除調撥單號為  '" & StrA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim mc As New WareMoveInfo
            Dim mt As New WareMoveController
            mc.MV_NO = StrA
            If mt.WareMove_DelNO(mc) = True Then

                Grid1.DataSource = mt.WareMove_GetList(Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, "2")
            Else
                MsgBox("刪除失敗")
            End If

        End If
    End Sub

    Private Sub popWareMoveView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveView.Click
        On Error Resume Next
        tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
        MTypeName = "WareMoveView"


        Dim fr As frmWareMoveOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareMoveOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmWareMoveOut
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveCheck.Click
        '審核
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
        Dim a As New WareMoveController
        Dim b As New List(Of WareMoveInfo)
        '      b = a.WareMove_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, False, Nothing, "2")
        b = a.WareMove_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1")
        Dim c As New List(Of WareMoveInfo)
        c = a.WareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, "1")
        If c.Count > 0 Then
            MsgBox("此單已審核,不允許再次操作！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If b.Count = 0 Then
            MsgBox("審核之前需要先收貨!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "收料" Then
            MsgBox("您隻能對'收料'性質的記錄進行審核操作！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If


        MTypeName = "WareMoveCheck"
        '     Edit = True

        Dim fr As frmWareMoveOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareMoveOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmWareMoveOut
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

   
    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        Dim wmc As New WareMoveController
        Dim wmi As New WareMoveInfo
        If e.Node.Level = 1 Then

            Select Case Mid(tv1.SelectedNode.Text, 1, 3)

                Case "未審核"
                    If tv1.SelectedNode.Parent.Text = "收入項目" Then
                        Grid1.DataSource = wmc.WareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, False, "2", Nothing, Nothing)

                    End If
                    If tv1.SelectedNode.Parent.Text = "發出項目" Then
                        Grid1.DataSource = wmc.WareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, False, "2", Nothing, Nothing)
                    End If

                Case "已審核"
                    If tv1.SelectedNode.Parent.Text = "收入項目" Then
                        Grid1.DataSource = wmc.WareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, True, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                    End If
                    If tv1.SelectedNode.Parent.Text = "發出項目" Then
                        Grid1.DataSource = wmc.WareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, True, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                    End If
            End Select
            '    Label1.Text = Mid(tv1.SelectedNode.Text, 1, 3) & tv1.SelectedNode.Parent.Text
            ' Grid1.DataSource = wmc.WareMove_GetList("2")
      
        End If
    End Sub

    Private Sub popWareMoveSeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareMoveSeek.Click
        Dim mc As New WareMoveController

        tempValue4 = TreeView1.SelectedNode.Tag
        Dim fr As New frmWareSelect
        'tempValue = Label1.Text
        tempValue = "調拔作業"

        fr.ShowDialog()
    
        Select Case tempValue
            Case "1"
                Grid1.DataSource = mc.WareMove_GetList(tempValue2, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, "2")
            Case "2"
                Grid1.DataSource = mc.WareMove_GetList(Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, "2")
            Case "3"
                Grid1.DataSource = mc.WareMove_GetList(Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, "2")
            Case "4"
                Grid1.DataSource = mc.WareMove_GetList(Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, Nothing, Nothing, "2")
              
            Case "6"
                Dim ws As New WareSelectControl
                Grid1.DataSource = ws.WareMove_Getlist("調拔作業", tempValue2)

        End Select
        tempValue = ""
        tempValue2 = ""
        tempValue4 = ""
    End Sub
    '導出對應倉庫調撥信息---主要針對為調撥收入!
    Private Sub popWareMovePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMovePrint.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        If MsgBox("你確定要當前所有的資料嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        'Dim exapp As New Excel.Application
        'Dim exbook As Excel.Workbook
        'Dim exsheet As Excel.Worksheet

        'Dim i As Integer = 0, ii As Integer = 0

        'exapp = CreateObject("Excel.Application")
        'exbook = exapp.Workbooks.Add
        'exsheet = exapp.Worksheets(1)

        'exsheet.Cells(1, 1) = "調撥單號"
        'exsheet.Cells(1, 2) = "物料編碼"
        'exsheet.Cells(1, 3) = "物料名稱"
        'exsheet.Cells(1, 4) = "規格"
        'exsheet.Cells(1, 5) = "調撥數量"
        'exsheet.Cells(1, 6) = "單位"
        'exsheet.Cells(1, 7) = "倉庫代號"
        'exsheet.Cells(1, 8) = "變更倉庫代號"
        'exsheet.Cells(1, 9) = "操作員"
        'exsheet.Cells(1, 10) = "收發性質"
        'exsheet.Cells(1, 11) = "調撥日期"
        'exsheet.Cells(1, 12) = "備註"
        'exsheet.Cells(1, 13) = "確認"
        'exsheet.Cells(1, 14) = "收料人"
        'exsheet.Cells(1, 15) = "審核"
        'exsheet.Cells(1, 16) = "審核備註"


        'For i = 0 To GridView1.RowCount - 1
        '    ii = i + 2

        '    exsheet.Cells(ii, 1) = GridView1.GetRowCellValue(i, "MV_NO")
        '    exsheet.Cells(ii, 2) = "$" & GridView1.GetRowCellValue(i, "M_Code") & "$"
        '    exsheet.Cells(ii, 3) = GridView1.GetRowCellValue(i, "M_Name")
        '    exsheet.Cells(ii, 4) = GridView1.GetRowCellValue(i, "M_Gauge")
        '    exsheet.Cells(ii, 5) = GridView1.GetRowCellValue(i, "MV_Qty")
        '    exsheet.Cells(ii, 6) = GridView1.GetRowCellValue(i, "M_Unit")
        '    exsheet.Cells(ii, 7) = GridView1.GetRowCellValue(i, "DepotNO")
        '    exsheet.Cells(ii, 8) = GridView1.GetRowCellValue(i, "MV_ChangeDepotNO")
        '    exsheet.Cells(ii, 9) = GridView1.GetRowCellValue(i, "MV_OutActionName")
        '    exsheet.Cells(ii, 10) = GridView1.GetRowCellValue(i, "MV_InOrOut")
        '    exsheet.Cells(ii, 11) = CDate(GridView1.GetRowCellValue(i, "MV_Date"))
        '    exsheet.Cells(ii, 12) = GridView1.GetRowCellValue(i, "MV_Remark")
        '    exsheet.Cells(ii, 13) = GridView1.GetRowCellValue(i, "MV_Ack")
        '    exsheet.Cells(ii, 14) = GridView1.GetRowCellValue(i, "MV_CheckActionName")
        '    exsheet.Cells(ii, 15) = GridView1.GetRowCellValue(i, "MV_Check")
        '    exsheet.Cells(ii, 16) = GridView1.GetRowCellValue(i, "MV_CheckRemark")


        'Next
        'exapp.Visible = True

        If GridView1.RowCount = 0 Then Exit Sub
        'ExportGridToXls()

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridView1.BestFitColumns()

            Grid1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
       
    End Sub

    Private Sub popWareMoveLook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveLook.Click
        frmWareMoveLook.MdiParent = MDIMain
        frmWareMoveLook.Show()
    End Sub

    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "MV_NO,M_Code,M_Name,M_Gauge,MV_Qty,M_Unit,MV_Date,DepotNO,MV_ChangeDepotNO,MV_InOrOut,MV_Ack,MV_Check,MV_OutAction,MV_InAction"

        GridViewCopyMulitRow(GridView1, FiledNameStr, "")
    End Sub


    Private Sub ToolStripMenuItemALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemALL.Click
        Dim FiledNameStr As String
        FiledNameStr = "MV_NO,M_Code,M_Name,M_Gauge,MV_Qty,M_Unit,MV_Date,DepotNO,MV_ChangeDepotNO,MV_InOrOut,MV_Ack,MV_Check,MV_OutAction,MV_InAction"

        GridViewCopyMulitRow(GridView1, FiledNameStr, "ALL")
    End Sub

    Private Sub popWareMoveflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveflesh.Click

    End Sub
End Class