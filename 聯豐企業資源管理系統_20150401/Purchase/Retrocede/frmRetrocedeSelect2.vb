Public Class frmRetrocedeSelect2

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = txtLFID.Text
            Me.Close()
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = TextEdit2.Text
            Me.Close()
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = TextEdit1.Text
            Me.Close()
        End If


        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = TextEdit3.Text
            Me.Close()
        End If


        If RadioButton5.Checked = True Then
            tempValue = "5"
            tempValue2 = TextEdit5.Text
            Me.Close()
        End If

        If RadioButton6.Checked = True Then
            tempValue = "6"
            tempValue2 = TextEdit4.Text
            Me.Close()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        Dim i%
        If sender.checked = True Then
            i = sender.tag
            Me.Controls.Item(i).Focus()
        End If
    End Sub

    Private Sub frmRetrocedeSelect2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub
End Class