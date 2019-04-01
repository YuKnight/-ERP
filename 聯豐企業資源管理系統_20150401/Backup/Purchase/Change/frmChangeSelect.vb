Public Class frmChangeSelect

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked Then
            tempValue = "1"
            tempValue2 = TextEdit1.Text
        End If
        If RadioButton2.Checked Then
            tempValue = "2"
            tempValue2 = TextEdit2.Text
        End If
        If RadioButton3.Checked Then
            tempValue = "3"
            tempValue2 = TextEdit3.Text
        End If
        If RadioButton4.Checked Then
            tempValue = "4"
            tempValue2 = ComboBoxEdit1.EditValue
        End If
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextEdit3.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextEdit2.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBoxEdit1.Focus()
        End If
    End Sub

    Private Sub frmChangeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Select()
    End Sub
End Class