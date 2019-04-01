
Imports LFERP.SystemManager
Imports LFERP.Library.ScanManager

Public Class frmScanFileSelect
    Public SelectSF_ID As String

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        SelectSF_ID = ""
        Me.Close()

    End Sub

    Private Sub frmScanFileSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15

        Dim mt As New ScanFileController
        Grid.DataSource = mt.ScanFile_GetList(Nothing, Nothing, InUserID, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Grid.RowCount > 0 Then
            SelectSF_ID = Grid.CurrentRow.Cells("SF_No").Value.ToString
            Me.Close()

        Else
            MsgBox("沒有文件!", , "提示")

        End If
    End Sub


End Class