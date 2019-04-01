Imports LFERP.Library.WareHouse.WareBorrowChange
Imports LFERP.DataSetting
Imports LFERP.SystemManager

Public Class frmWareBorrowChangeMain

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then AddToolStripMenuItem.Enabled = True
        End If

        '2014-02-18 mao
        checkToolStripMenuItem.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then checkToolStripMenuItem.Enabled = True
        End If

        Dim WC As New WareBorrowChangeControl
        Grid1.DataSource = WC.WareBorrowChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


    End Sub

    Private Sub frmWareBorrowChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click

        tempValue = "Add"
        tempValue2 = Nothing

        frmWareBorrowChange.ShowDialog()
        frmWareBorrowChange.Dispose()
    End Sub

    Private Sub viewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewToolStripMenuItem.Click

        If Me.GridView2.RowCount <= 0 Then
            Exit Sub
        End If



        tempValue = "View"
        tempValue2 = Me.GridView2.GetFocusedRowCellValue("ChangeNo").ToString

        frmWareBorrowChange.ShowDialog()
        frmWareBorrowChange.Dispose()
    End Sub
    '2014-02-12 姚駿
    Private Sub checkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkToolStripMenuItem.Click
        If Me.GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        Dim WC As New WareBorrowChangeControl
        Dim wcList As New List(Of WareBorrowChangeInfo)
        wcList = WC.WareBorrowChange_CheckGetList(Nothing, Nothing, Nothing, Nothing, Nothing, Me.GridView2.GetFocusedRowCellValue("ChangeNo").ToString, "1")

        If wcList.Count > 0 Then
            MsgBox("此單已審核,不允許再次操作！", MsgBoxStyle.OkOnly, "提示")
            Exit Sub
        End If


        tempValue = "Check"
        tempValue2 = Me.GridView2.GetFocusedRowCellValue("ChangeNo").ToString

        frmWareBorrowChange.ShowDialog()
        frmWareBorrowChange.Dispose()
    End Sub

    Private Sub GridView2_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView2.CustomColumnDisplayText
        If e.Column.FieldName = "CheckDate" Then
            If e.Value = Nothing Then
                e.DisplayText = ""
            End If
        End If
    End Sub
End Class