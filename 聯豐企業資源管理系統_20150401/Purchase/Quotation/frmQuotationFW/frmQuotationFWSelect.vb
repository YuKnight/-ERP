Imports LFERP.SystemManager.SystemUser
Public Class frmQuotationFWSelect
    Inherits System.Windows.Forms.Form

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = TextEdit1.EditValue
            Me.Close()
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = TextEdit2.EditValue
            Me.Close()
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = TextEdit3.EditValue
            Me.Close()
        End If

        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = TextEdit4.EditValue
            Me.Close()
        End If

        If RadioButton5.Checked = True Then
            tempValue = "5"
            tempValue2 = TextEdit5.EditValue
            Me.Close()
        End If

        If RadioButton6.Checked = True Then
            tempValue = "6"
            tempValue2 = TextEdit6.EditValue
            Me.Close()
        End If

        If RadioButton7.Checked = True Then
            tempValue = "7"
            tempValue2 = ComboBoxEdit1.EditValue
            Me.Close()
        End If

        If RadioButton8.Checked = True Then
            tempValue = "8"
            tempValue2 = gluAction.EditValue
            Me.Close()
        End If
    End Sub

    Private Sub frmQuotationFWSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim us As New SystemUserController

        gluAction.Properties.DisplayMember = "U_Name"
        gluAction.Properties.ValueMember = "U_ID"
        gluAction.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, "10010103")
        RadioButton1.Checked = True
        TextEdit1.Select()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged
        Dim i%
        If sender.Checked = True Then
            i = sender.Tag
            P1.Controls.Item(i).Focus()
        End If
    End Sub

End Class