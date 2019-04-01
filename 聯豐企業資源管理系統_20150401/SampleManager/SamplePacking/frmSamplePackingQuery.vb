Public Class frmSamplePackingQuery

#Region "載入窗體"
    Private Sub frmOutPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtVersions.Text = "A.包裝箱"
        txtID.Text = tempValue
        tempValue = ""
    End Sub
#End Region

#Region "按鍵事件"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '條件選擇
        If Me.txtVersions.Text = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtVersions.Text
        End If
        '包裝
        If Me.txtID.Text = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = txtID.Text
        End If
        '條碼
        If Me.txtCode.Text = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = txtCode.Text
        End If

        Me.Close()
    End Sub
#End Region

#Region "選擇條件"
    Private Sub txtVersions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVersions.SelectedIndexChanged
        Select Case Mid(txtVersions.Text, 1, 1)
            Case "A"
                Me.lblID.Text = "包裝單號(&L)："
                Me.lblCode.Text = "包裝條碼(&Y)："
                Me.lblID.Enabled = True
                Me.lblCode.Enabled = True
                Me.txtID.Enabled = True
                Me.txtCode.Enabled = True
            Case "B"
                Me.lblID.Text = "內箱單號(&L)："
                Me.lblCode.Text = "內箱條碼(&Y)："
                Me.lblID.Enabled = True
                Me.lblCode.Enabled = True
                Me.txtID.Enabled = True
                Me.txtCode.Enabled = True
            Case "C"
                Me.lblCode.Text = "產品條碼(&Y)："
                Me.lblID.Text = "內箱單號(&L)："
                Me.lblID.Enabled = False
                Me.lblCode.Enabled = True
                Me.txtID.Enabled = False
                Me.txtCode.Enabled = True
        End Select
    End Sub
#End Region

End Class