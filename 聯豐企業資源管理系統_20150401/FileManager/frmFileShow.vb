Imports LFERP.FileManager
Imports LFERP.SystemManager

Public Class frmFileShow

    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click
        Dim dt As New FileController
        If Grid.Rows.Count = 0 Then Exit Sub
        'MsgBox(lvwFile.SelectedItems.Item(0).Text)
        dt.File_Open(Label2.Text, Label3.Text, Grid.CurrentRow.Cells("F_No").Value.ToString)

    End Sub

    Private Sub popFileShowUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowUpdate.Click
        frmFileUpdate.Label6.Text = Label2.Text
        frmFileUpdate.Label7.Text = Label3.Text
        frmFileUpdate.ShowDialog()
        'FileShow(Label2.Text, Label3.Text, True, True, True, True, True, True)
        Dim dt As New FileController
        Grid.DataSource = dt.FileBond_GetList(Label2.Text, Label3.Text, Nothing)
        'GetFileList(lvwFile, Label2.Text, Label3.Text)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Private Sub frmFileShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15

    End Sub



    Private Sub popFileShowDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowDown.Click
        Dim dt As New FileController
        Dim objInfo As New List(Of FilesInfo)
        If Grid.Rows.Count = 0 Then Exit Sub
        objInfo = dt.FileBond_GetList(Label2.Text, Label3.Text, Grid.CurrentRow.Cells("F_No").Value.ToString)

        SaveFileDialog1.Filter = "*" & objInfo(0).F_FileType & "|" & "*" & objInfo(0).F_FileType
        SaveFileDialog1.DefaultExt = objInfo(0).F_FileType
        SaveFileDialog1.FileName = objInfo(0).F_OldName
        SaveFileDialog1.InitialDirectory = Application.StartupPath & "\TempFile\"
        SaveFileDialog1.ShowDialog()
        MsgBox(SaveFileDialog1.FileName)

        If SaveFileDialog1.FileName <> "" And SaveFileDialog1.FileName <> objInfo(0).F_OldName Then
            'txtSourcePath.Text = OpenFileDialog1.FileName
            dt.File_DownLoad(Label2.Text, Label3.Text, Grid.CurrentRow.Cells("F_No").Value.ToString, SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveFileDialog1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveFileDialog1.Disposed

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub popFileShowDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowDel.Click
        If Grid.Rows.Count = 0 Then Exit Sub
        If MsgBox("你確定要刪除 " & Grid.CurrentRow.Cells("F_No").Value.ToString & " 這個文件嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        Dim dt As New FileController
        If dt.File_Delete(Label2.Text, Label3.Text, Grid.CurrentRow.Cells("F_No").Value.ToString) = True Then
            Grid.DataSource = dt.FileBond_GetList(Label2.Text, Label3.Text, Nothing)
        Else
            MsgBox("刪除失敗", , "提示")

        End If

    End Sub

    Private Sub popFileShowEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowEdit.Click

    End Sub

End Class