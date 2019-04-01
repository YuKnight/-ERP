Public Class frmWareQCRecoverSelect

    Private Sub frmWareQCRecoverSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        txtRNO.Select()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then                 '歸還單號
            tempValue = "1"
            tempValue2 = txtRNO.Text
        End If

        If RadioButton2.Checked = True Then                 '發出單號
            tempValue = "2"
            tempValue2 = txtNO.Text
        End If

        If RadioButton3.Checked = True Then                 '物料編碼
            tempValue = "3"
            tempValue2 = txtCode.Text
        End If

        If RadioButton4.Checked = True Then                 '操作員工號
            tempValue = "4"
            tempValue2 = txtUser.Text
        End If

        If RadioButton5.Checked = True Then                 '歸還日期
            tempValue = "5"
            tempValue2 = DateEdit1.EditValue
            tempValue3 = DateEdit2.EditValue
        End If

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        Dim i%
        If sender.checked = True Then
            i = sender.tag()
            Me.Controls.Item(i).Focus()
        End If
    End Sub
End Class