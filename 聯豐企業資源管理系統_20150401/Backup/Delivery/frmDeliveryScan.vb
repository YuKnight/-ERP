
Public Class frmDeliveryScan

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue3 = TextEdit1.Text
        If tempValue3 = "" Then
            MsgBox("請確認存在有裝箱編號！")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class