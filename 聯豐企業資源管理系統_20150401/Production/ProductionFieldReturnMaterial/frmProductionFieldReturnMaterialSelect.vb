Public Class frmProductionFieldReturnMaterialSelect

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = "OK"

        If txtR_NO.Text = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtR_NO.Text
        End If

        If txtCode.Text = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = txtCode.Text
        End If

        If Mid(ComboCheck.EditValue, 1, 1) = "0" Then
            tempValue5 = "False"
        ElseIf Mid(ComboCheck.EditValue, 1, 1) = "1" Then
            tempValue5 = "True"
        ElseIf Mid(ComboCheck.EditValue, 1, 1) = "2" Then
            tempValue5 = Nothing
        End If

        If DateEdit1.Text = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd") & " 00:00:00"
        End If

        If DateEdit2.Text = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = Format(CDate(DateEdit2.EditValue), "yyyy/MM/dd") & " 23:59:59"
        End If

        Me.Close()
    End Sub
End Class