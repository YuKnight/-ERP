Imports LFERP.SystemManager

Public Class frmUserSelect
    Dim su As New SystemUser.SystemUserController

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        tempValue = GridLookUpEdit1.EditValue
        Me.Close()
    End Sub

    Private Sub frmUserSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridLookUpEdit1.Properties.DataSource = su.SystemUser_GetList(Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "U_Name"
        GridLookUpEdit1.Properties.ValueMember = "U_ID"
    End Sub
End Class