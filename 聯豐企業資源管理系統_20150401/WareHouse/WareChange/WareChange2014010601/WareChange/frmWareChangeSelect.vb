Imports LFERP.Library.WareHouse.WareHouseInfo


Public Class frmWareChangeSelect


    Private Sub frmWareChangeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckEdit1.Checked = True Then
            If Trim(ButtonEdit1.Text) = "" Then
                tempValue = Nothing
            Else
                tempValue = ButtonEdit1.Text
            End If
        Else
            tempValue = Nothing
        End If
        If CheckEdit2.Checked = True Then
            If Trim(txtNo.Text) = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = txtNo.Text
            End If
        Else
            tempValue2 = Nothing
        End If
        If CheckEdit3.Checked = True Then
            If Trim(txtCode.Text) = "" Then
                tempValue4 = Nothing
            Else
                tempValue4 = txtCode.Text.Trim
            End If
        Else
            tempValue4 = Nothing
        End If
        If CheckEdit4.Checked = True Then
            If Trim(txtName.Text) = "" Then
                tempValue5 = Nothing
            Else
                tempValue5 = txtName.Text
            End If
        Else
            tempValue5 = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        tempValue2 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        Me.Close()
    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        tempValue3 = "500306"
        frmWareHouseSelect.ShowDialog()
        ButtonEdit1.Text = frmWareHouseSelect.SelectWareID
    End Sub

End Class