Imports LFERP.Library.KnifeWare
Imports LFERP.SystemManager
Public Class frmKnifeChangeMain

    Private Sub frmKnifeChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUserPower()
        ButtonPer_Click(Nothing, Nothing)
    End Sub


    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510701")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripOld.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510702")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripNew.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510703")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripBorrow.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510704")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripReturn.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510705")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripAddBorrow.Enabled = True
        End If
        
       
    End Sub

    Private Sub ButtonPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPer.Click
        Dim cc As New KnifeChangeControl
        Grid4.DataSource = cc.KnifeChange_GetList(Nothing, Nothing, Nothing, Nothing, "WT", Nothing, Nothing)
        Grid4.ContextMenuStrip = ContextMenuKuncun
    End Sub

    Private Sub ButtonGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGroup.Click
        Dim cc As New KnifeChangeControl
        Grid4.DataSource = cc.KnifeChange_GetList(Nothing, Nothing, Nothing, Nothing, "KT", Nothing, Nothing)
        Grid4.ContextMenuStrip = ContextMenuBReturn
    End Sub

    Private Sub ToolStripOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripOld.Click
        tempValue = "WT1" '倉庫待處理
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNew.Click
        tempValue = "WT2" '倉庫新刀
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripView.Click
        If Me.GridView4.RowCount <= 0 Then
            Exit Sub
        End If

        tempValue2 = Me.GridView4.GetFocusedRowCellValue("CH_Num").ToString
        tempValue = "View"
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrow.Click
        tempValue = "KT3" '倉庫待處理
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripReturn.Click
        tempValue = "KT4" '員工還刀數
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripViewB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripViewB.Click
        If Me.GridView4.RowCount <= 0 Then
            Exit Sub
        End If

        tempValue2 = Me.GridView4.GetFocusedRowCellValue("CH_Num").ToString
        tempValue = "View"
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub

    Private Sub ToolStripAddBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAddBorrow.Click
        tempValue = "KT5" '更改單增加
        frmKnifeChange.ShowDialog()
        frmKnifeChange.Dispose()
    End Sub
End Class