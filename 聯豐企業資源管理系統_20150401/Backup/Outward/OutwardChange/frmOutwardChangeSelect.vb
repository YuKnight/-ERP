Imports LFERP.SystemManager.SystemUser

Public Class frmOutwardChangeSelect

    Private Sub frmOutwardChangeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim us As New SystemUserController
        gluAction.Properties.DisplayMember = "U_Name"
        gluAction.Properties.ValueMember = "U_ID"
        gluAction.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, "10010502")

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(txtCONo.Text.Trim) = 0 Then
            tempValue = Nothing
        Else
            tempValue = txtCONo.Text.Trim
        End If
        If Len(txtONo.Text.Trim) = 0 Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtONo.Text.Trim
        End If
        If Len(txtBatch.Text.Trim) = 0 Then
            tempValue3 = Nothing
        Else
            tempValue3 = txtBatch.Text.Trim
        End If
        If Len(txtName.Text.Trim) = 0 Then
            tempValue4 = Nothing
        Else
            tempValue4 = txtName.Text.Trim
        End If
        If Len(gluAction.EditValue) = 0 Then
            tempValue5 = Nothing
        Else
            tempValue5 = gluAction.EditValue
        End If
        If Len(ComboBoxEdit1.EditValue) = 0 Then
            tempValue6 = Nothing
        Else
            If ComboBoxEdit1.EditValue = "¥¼¼f®Ö" Then
                tempValue6 = "False"
            Else
                tempValue6 = "True"
            End If
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class