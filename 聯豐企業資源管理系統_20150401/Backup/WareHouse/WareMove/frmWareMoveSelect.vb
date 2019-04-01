Imports LFERP.SystemManager
Public Class frmWareMoveSelect



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ButtonEdit1.Text = "" Or (txtLFID.Text = "" And TextEdit2.Text = "" And TextEdit1.Text = "" And CBSendType.Text = "") Then
            MsgBox("請先選擇倉別和填寫查詢條件!", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            tempValue3 = ButtonEdit1.Text
            If RadioButton1.Checked = True Then
                tempValue = "1"
                tempValue2 = Trim(txtLFID.Text)
            End If

            If RadioButton2.Checked = True Then
                tempValue = "2"
                tempValue2 = Trim(TextEdit2.Text)
            End If


            If RadioButton3.Checked = True Then
                tempValue = "3"
                tempValue2 = Trim(TextEdit1.Text)
            End If


            If RadioButton5.Checked = True Then
                tempValue = "4"
                tempValue2 = Trim(CBSendType.Text)
            End If

        End If

        Me.Close()
    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        tempValue3 = "500306"
        frmWareHouseSelect.ShowDialog()
        ButtonEdit1.Text = frmWareHouseSelect.SelectWareID
    End Sub


  
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton5.CheckedChanged
        Dim i%
        If sender.checked = True Then
            i = sender.tag
            Me.Controls.Item(i).Focus()
        End If
    End Sub
End Class