Imports System.Windows.Forms

Public Class frmNmetalCustomerFeedbackRemark
    Public VERRemark As String
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click


        VERRemark = txt_remark.Text
        Me.Close()
    End Sub

    Private Sub cancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton1.Click
        VERRemark = ""
        Me.Close()
    End Sub

    Private Sub frmCustomerFeedbackRemark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
