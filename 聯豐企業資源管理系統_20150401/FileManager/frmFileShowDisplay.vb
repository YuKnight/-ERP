Imports LFERP.FileManager
Imports LFERP.SystemManager

Public Class frmFileShowDisplay

    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click
        Dim dt As New FileController
        If Grid.Rows.Count = 0 Then Exit Sub
        'MsgBox(lvwFile.SelectedItems.Item(0).Text)
        dt.File_Open(Label2.Text, Label3.Text, Grid.CurrentRow.Cells("F_No").Value.ToString)


    End Sub

    

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub frmFileShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15

    End Sub



    


End Class