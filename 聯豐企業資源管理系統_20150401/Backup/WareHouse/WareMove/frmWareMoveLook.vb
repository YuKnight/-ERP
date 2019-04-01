
Public Class frmWareMoveLook
    Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController

    Private Sub frmWareMoveLook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DG.DataSource = mcPurchase.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Trim(txtPM_NO.Text) = "" Then
            MsgBox("請輸入採購單號!")
            txtPM_NO.Focus()
            'ElseIf mcPurchase.PurchaseMain_Getlist(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count = 0 Then
            'MsgBox("輸入採購單號不存在，請重新輸入!")
            'txtPM_NO.Focus()
            'txtPM_NO.SelectAll()
        Else
            DG.DataSource = mcPurchase.PurchaseMain_Getlist(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
    End Sub

    Private Sub txtPM_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPM_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdOK_Click(Nothing, Nothing)
        End If
    End Sub

End Class