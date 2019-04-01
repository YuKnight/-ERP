Public Class frmScanFind
    Public isClickbtnFind As Boolean        '判斷是否單擊了查詢按鈕

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmScanFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isClickbtnFind = False
        txtSF_Remark.Select()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtSF_No.Text.Trim = "" And txtSF_Remark.Text.Trim = "" And dteSF_DateBegin.Text = "" And dteSF_DateEnd.Text = "" Then
            MsgBox("請輸入查詢條件!", 64, "提示")
            txtSF_No.Focus()
        Else

            If txtSF_No.Text.Trim = "" Then
                tempValue = Nothing
            Else
                tempValue = txtSF_No.Text.Trim
            End If

            If txtSF_Remark.Text.Trim = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = txtSF_Remark.Text.Trim
            End If

            If dteSF_DateBegin.Text.Trim = "" Then
                tempValue3 = Nothing
            Else
                tempValue3 = dteSF_DateBegin.Text & " 00:00:00"
            End If

            If dteSF_DateEnd.Text.Trim = "" Then
                tempValue4 = Nothing
            Else
                tempValue4 = dteSF_DateEnd.Text & " 23:59:59"
            End If

            isClickbtnFind = True
            Me.Close()
        End If
    End Sub
End Class