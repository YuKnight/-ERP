Imports LFERP.Library.SingleFactory
Imports LFERP.SystemManager.SystemUser

Public Class frmSingleFactorySelect

    Dim us As New SystemUserController

    Private Sub frmSingleFactorySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridLookUpEdit1.Properties.DisplayMember = "U_Name"
        GridLookUpEdit1.Properties.ValueMember = "U_ID"
        GridLookUpEdit1.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, Nothing)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckEdit1.Checked = True Then
            If TextEdit1.Text.Trim = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = TextEdit1.Text
            End If

        Else
            tempValue2 = Nothing
        End If
        If CheckEdit2.Checked = True Then
            tempValue3 = Format(DateEdit1.EditValue, "yyyy/MM/dd")
            tempValue4 = ComboBoxEdit2.EditValue
        Else
            tempValue3 = Nothing
            tempValue4 = Nothing
        End If
        If CheckEdit3.Checked = True Then
            If TextEdit3.Text.Trim = "" Then
                tempValue5 = Nothing
            Else
                tempValue5 = TextEdit3.Text
            End If
        Else
            tempValue5 = Nothing
        End If

        If CheckEdit4.Checked = True Then
            tempValue6 = GridLookUpEdit1.EditValue
        Else
            tempValue6 = Nothing
        End If
        If CheckEdit5.Checked = True Then
            If ComboBoxEdit1.EditValue = "¤w¼f®Ö" Then
                tempValue7 = True
            Else
                tempValue7 = False
            End If

        Else
            tempValue7 = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class