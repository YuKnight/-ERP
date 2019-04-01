

Public Class frmWareInventorySafe

    Private Sub frmWareInventorySafe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = tempValue2
        tempValue2 = ""
        LabelControl1.Text = tempValue4
        tempValue4 = ""
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue3 = TextEdit2.Text
        If RadioButton1.Checked = True Then
            tempValue4 = LabelControl1.Text
        End If
        If RadioButton2.Checked = True Then
            tempValue4 = TextEdit3.Text
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            LabelControl1.Visible = True
        Else
            LabelControl1.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextEdit3.Enabled = True
            TextEdit3.Focus()
        Else
            TextEdit3.Enabled = False
        End If
    End Sub
End Class