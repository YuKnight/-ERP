Imports LFERP.SystemManager
Imports LFERP.DataSetting

Public Class frmMsgUserSelect

    Public MsgUserrray(1, 1) As String
    Dim uls As New SystemUser.SystemUserController
    Dim dpm As New LFERP.DataSetting.DepartmentControler

    Private Sub frmUserSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
        ListView1.Items.Clear()
        '  dpm.Department_LoadToTree(Tv1)
        dpm.GetDepartmentModule(Tv1)
        Tv1.ExpandAll()
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()
    End Sub


    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        Dim LI As New ListViewItem
        LI = ListView1.Items.Add(GridView2.GetFocusedRowCellValue("U_Name").ToString)
        LI.SubItems.Add(GridView2.GetFocusedRowCellValue("U_ID").ToString)

    End Sub

    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

    End Sub



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim l As Integer
        ReDim MsgUserrray(ListView1.Items.Count - 1, 1)
        For l = 0 To ListView1.Items.Count - 1


            MsgUserrray(l, 0) = ListView1.Items(l).Text
            MsgUserrray(l, 1) = ListView1.Items(l).SubItems(1).Text
        Next
        Me.Close()

    End Sub

    Private Sub ListView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyUp

        If e.KeyCode = Keys.Delete Then

            If ListView1.SelectedItems.Count = 0 Then
                Exit Sub
            Else
                Dim litem As ListViewItem
                For Each litem In ListView1.SelectedItems

                    ListView1.Items.Remove(litem)
                Next


            End If
        End If
    End Sub



    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Tv1.AfterSelect
        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Tv1.SelectedNode.Tag)
    End Sub
End Class