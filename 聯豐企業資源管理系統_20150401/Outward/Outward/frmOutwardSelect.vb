Imports LFERP.SystemManager.SystemUser

Public Class frmOutwardSelect

    Private Sub frmOutwardSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim us As New SystemUserController
        gluAction.Properties.DisplayMember = "U_Name"
        gluAction.Properties.ValueMember = "U_ID"
        gluAction.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, "10010502")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If RadioButton1.Checked Then
            tempValue = "1"
            tempValue2 = txtNO.Text

        End If
        If RadioButton2.Checked Then
            tempValue = "2"
            tempValue2 = cbType.EditValue
        End If
        If RadioButton3.Checked Then
            tempValue = "3"
            tempValue2 = Date1.EditValue
            tempValue3 = Date2.EditValue
        End If
        If RadioButton4.Checked Then
            tempValue = "4"
            tempValue2 = gluAction.EditValue
        End If
        If RadioButton5.Checked Then
            tempValue = "5"
            tempValue2 = btnWh.Text
        End If
        If RadioButton6.Checked Then
            tempValue = 6
            tempValue2 = TextEdit1.Text
        End If
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub btnWh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWh.Click
        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then


        Else

            btnWh.Text = frmWareHouseSelect.SelectWareID

        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtNO.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            cbType.Focus()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            gluAction.Focus()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            btnWh.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Date1.Focus()
        End If
    End Sub
End Class