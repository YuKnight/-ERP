Imports LFERP.Library.ProductionWareMove
Imports LFERP.Library.ProductionWareHouse
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareHouseController

Public Class frmProductionHouseMoveMain

    '載入擁有權限的倉庫
    Private Sub frmProductionHouseMoveMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New Library.WareHouse.WareHouseController

        mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "880606"))
        LoadUserPower()

        tv1.CollapseAll()
    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880601")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveOutAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880602")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880603")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveDel.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880604")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveIn.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880605")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareMoveCheck.Enabled = True
        End If

    End Sub

    '獲取當前倉庫的調撥信息
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        tempValue2 = ""
        Dim wmc As New ProductionWareMoveControl
        Dim wmi As New ProductionWareMoveInfo
        'If e.Node.Level = 1 Then
        If TreeView1.SelectedNode.Level = 1 Then
            'Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, "2")
            Grid1.DataSource = Nothing
            tempValue2 = TreeView1.SelectedNode.Tag

            tv1.ExpandAll() 'TV1展開所有目錄

            Dim a As New ProductionWareMoveControl
            Dim b As New List(Of ProductionWareMoveInfo)
            Dim c As New List(Of ProductionWareMoveInfo)

            b = a.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, True, Nothing, False)
            c = a.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, True, Nothing, False)
            If b.Count > 0 Then
                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核 (" & b.Count & ")"
            Else
                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核(0)"
            End If

            If c.Count > 0 Then
                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核 (" & c.Count & ")"
            Else
                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核(0)"
            End If
            tv1.Select()
        End If
    End Sub

    '獲取當前模式下詳細物料信息
    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        Dim wmc As New ProductionWareMoveControl
        Dim wmi As New ProductionWareMoveInfo
        If tv1.SelectedNode.Level = 0 Then
            If tv1.SelectedNode.Text = "收入項目" Then

                Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing)

                popWareMoveEdit.Visible = False
                popWareMoveDel.Visible = False
                popWareMoveIn.Visible = True
                popWareMoveCheck.Visible = True
                ToolStripSeparator1.Visible = True

            ElseIf tv1.SelectedNode.Text = "發出項目" Then

                Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing)

                popWareMoveEdit.Visible = True
                popWareMoveDel.Visible = True
                popWareMoveIn.Visible = False
                popWareMoveCheck.Visible = False
                ToolStripSeparator1.Visible = False
            End If

        ElseIf tv1.SelectedNode.Level = 1 Then
            If tv1.SelectedNode.Parent.Text = "收入項目" Then

                If Mid(tv1.SelectedNode.Text, 1, 3) = "未審核" Then
                    Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, False)
                ElseIf Mid(tv1.SelectedNode.Text, 1, 3) = "已審核" Then
                    Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, True)
                End If

                popWareMoveEdit.Visible = False
                popWareMoveDel.Visible = False
                popWareMoveIn.Visible = True
                popWareMoveCheck.Visible = True
                ToolStripSeparator1.Visible = True

            ElseIf tv1.SelectedNode.Parent.Text = "發出項目" Then

                If Mid(tv1.SelectedNode.Text, 1, 3) = "未審核" Then
                    Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, False)
                ElseIf Mid(tv1.SelectedNode.Text, 1, 3) = "已審核" Then
                    Grid1.DataSource = wmc.ProductionWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, True)
                End If

                popWareMoveEdit.Visible = True
                popWareMoveDel.Visible = True
                popWareMoveIn.Visible = False
                popWareMoveCheck.Visible = False
                ToolStripSeparator1.Visible = False

            End If
        End If
    End Sub

    Private Sub popWareMoveOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveOutAdd.Click
        On Error Resume Next
        Edit = False
        If TreeView1.SelectedNode.Level = 1 Then
            Dim fr As frmProductionWareMove
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionWareMove Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New frmProductionWareMove
            MTypeName = "ProductionWareMove"
            tempValue2 = TreeView1.SelectedNode.Tag
            tempValue3 = TreeView1.SelectedNode.Text
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
     
    End Sub

    Private Sub popWareMoveEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveEdit.Click
        On Error Resume Next
        Dim osc As New ProductionWareMoveControl
        Dim osilist As New List(Of ProductionWareMoveInfo)

        If GridView1.RowCount = 0 Then Exit Sub

        osilist = osc.ProductionWareMove_GetList(GridView1.GetFocusedRowCellValue("PWM_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, Nothing)
        If osilist.Count > 0 Then

            MsgBox("無法修改,此調撥單已確認！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        'osilist = osc.ProductionWareMove_GetList(GridView1.GetFocusedRowCellValue("PWM_NO").ToString, Nothing, Nothing, Nothing, "收料", Nothing, Nothing, Nothing, True, "1")
        'If osilist.Count > 0 Then

        '    MsgBox("無法修改,此驗收單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If GridView1.GetFocusedRowCellValue("PWM_Type").ToString <> "發料" Then
        '    MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If

        Edit = True
    
        Dim fr As frmProductionWareMove
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionWareMove Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionWareMove
        tempValue = GridView1.GetFocusedRowCellValue("PWM_NO").ToString
        MTypeName = "ProductionWareMove"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim osc As New ProductionWareMoveControl
        Dim osilist As New List(Of ProductionWareMoveInfo)


        osilist = osc.ProductionWareMove_GetList(GridView1.GetFocusedRowCellValue("PWM_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("此調撥單已確認，不能刪除！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        'osilist = osc.ProductionWareMove_GetList(GridView1.GetFocusedRowCellValue("PWM_NO").ToString, Nothing, Nothing, Nothing, "收料", Nothing, Nothing, Nothing, True, "1")
        'If osilist.Count <> 0 Then

        '    MsgBox("無法修改,此調撥單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    Exit Sub
        'End If


        'If GridView1.GetFocusedRowCellValue("PWM_Type").ToString <> "發料" Then
        '    MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If


        Dim StrA As String
        StrA = GridView1.GetFocusedRowCellValue("PWM_NO").ToString
        If MsgBox("你確定刪除調撥單號為  '" & StrA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim mt As New ProductionWareMoveControl

            If mt.ProductionWareMove_Delete(StrA, Nothing) = True Then
                MsgBox("刪除成功！", 64, "提示")
                TreeView1_AfterSelect(Nothing, Nothing)
                tv1_AfterSelect(Nothing, Nothing)
            Else
                MsgBox("刪除失敗！", 64, "提示")
            End If

        End If
    End Sub

    Private Sub popWareMoveView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmProductionWareMove
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionWareMove Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionWareMove

        tempValue = GridView1.GetFocusedRowCellValue("PWM_NO").ToString
        MTypeName = "PreView"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveIn.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("PWM_NO").ToString
        Dim a As New ProductionWareMoveControl
        Dim b As New List(Of ProductionWareMoveInfo)
        b = a.ProductionWareMove_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)
        If b.Count > 0 Then
            MsgBox("此單已審核,無法再收貨！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim fr As frmProductionWareMove
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionWareMove Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionWareMove
        MTypeName = "InCheck"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("PWM_NO").ToString
        Dim a As New ProductionWareMoveControl
        Dim b As New List(Of ProductionWareMoveInfo)

        b = a.ProductionWareMove_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False, Nothing)

        If b.Count > 0 Then
            MsgBox("審核之前需要先確認收貨!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        'If GridView1.GetFocusedRowCellValue("PWM_Type").ToString <> "收料" Then
        '    MsgBox("您隻能對'收料'性質的記錄進行審核操作！", MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If

        Dim fr As frmProductionWareMove
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionWareMove Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionWareMove
        MTypeName = "Check"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareMoveflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareMoveflesh.Click
        TreeView1_AfterSelect(Nothing, Nothing)
        tv1_AfterSelect(Nothing, Nothing)
    End Sub
End Class