Public Class ForPDProductComplaintSelect

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked Then
            tempValue = "1"
            tempValue2 = txtLFID.Text
        End If
        If RadioButton2.Checked Then
            tempValue = "2"
            tempValue2 = TextEdit1.Text
        End If
        If RadioButton3.Checked Then
            tempValue = "3"
            tempValue2 = TextEdit2.Text
        End If
        'If RadioButton4.Checked Then
        '    tempValue = "4"
        '    tempValue2 = txtLFID.Text
        'End If
        Me.Close()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        txtLFID.Focus()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        TextEdit1.Focus()
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        TextEdit2.Focus()
    End Sub
End Class