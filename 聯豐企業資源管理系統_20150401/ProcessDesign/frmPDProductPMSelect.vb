Imports System
Imports LFERP.Library.Product
Public Class frmPDProductPMSelect
    Public PMName As String
    Dim pc As New ProductController
    Private Sub frmPDProductPMSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridLookUpEdit1.Properties.DataSource = pc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "PM_M_Code"
        GridLookUpEdit1.Properties.ValueMember = "PM_M_Code"

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        PMName = GridLookUpEdit1.Text
        Me.Close()
    End Sub
End Class