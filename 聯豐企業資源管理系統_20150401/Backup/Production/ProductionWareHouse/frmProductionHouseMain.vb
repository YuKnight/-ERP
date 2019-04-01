Imports LFERP.Library.ProductionWareInventory
Imports LFERP.Library.ProductionWareHouse
Imports LFERP.Library.Product
Imports LFERP.Library.WareHouse.WareInventory

Public Class frmProductionHouseMain

    Private Sub frmProductionHouseMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New Library.WareHouse.WareHouseController
        PM_JiYu.Caption = strJIYU

        If mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "880501")) = False Then
            Exit Sub
        End If

        TreeView1.ExpandAll()

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim pwc As New WareInventoryMTController
        Dim pic As New ProductInventoryController

        If TreeView1.SelectedNode.Level = 1 Then
            'If TreeView1.SelectedNode.Tag = "W0801" Or TreeView1.SelectedNode.Tag = "W0802" Or TreeView1.SelectedNode.Tag = "W0803" _
            '    Or TreeView1.SelectedNode.Tag = "W0901" Or TreeView1.SelectedNode.Tag = "W1001" Or TreeView1.SelectedNode.Tag = "W1101" Then
            If Mid(TreeView1.SelectedNode.Tag, 1, 3) = "W08" Or Mid(TreeView1.SelectedNode.Tag, 1, 3) = "W09" Or Mid(TreeView1.SelectedNode.Tag, 1, 3) = "W10" _
                Or Mid(TreeView1.SelectedNode.Tag, 1, 3) = "W11" Then
                PM_M_Code.Visible = True
                PM_M_Code.VisibleIndex = 0
                Qty.FieldName = "PI_Qty"
                Grid.DataSource = pic.ProductInventory_GetList(Nothing, Nothing, TreeView1.SelectedNode.Tag, 0)
            Else
                PM_M_Code.Visible = False
                Qty.FieldName = "WI_Qty"
                Grid.DataSource = pwc.WareInventory_GetList3(Nothing, TreeView1.SelectedNode.Tag, "True")
            End If
        End If
    End Sub

    '預覽當前物料的收發記錄
    Private Sub MenuStripPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripPrint.Click

    End Sub
    '取倉記錄---對應相應的部門 發料的一個過程  (收發兩條記錄)
    Private Sub MenuStripOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripOut.Click
        On Error Resume Next

        Edit = False

        Dim fr As frmProductionFieldCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldCode
        tempValue = "CodeOut"
        tempValue2 = "PT05"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub MenuStripReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripReturn.Click
        On Error Resume Next

        Edit = False

        Dim fr As frmProductionFieldCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldCode
        tempValue = "CodeOut"
        tempValue2 = "PT02"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub
End Class