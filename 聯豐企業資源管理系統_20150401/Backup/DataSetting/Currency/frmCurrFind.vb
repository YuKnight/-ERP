Imports LFERP.DataSetting
Public Class frmCurrFind

    Dim cc As New CurrencyControler

    Private Sub frmCurrFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Date_YYMM.EditValue = Format(Now, "yyyy¦~MM¤ë")

        Date_YYMM.Focus()

        PM_M_Code.Properties.DataSource = cc.GetCurrencyList(Nothing)
        PM_M_Code.Properties.DisplayMember = "C_Name"
        PM_M_Code.Properties.ValueMember = "C_ID"
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        tempValue2 = Nothing
        tempValue3 = Nothing
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        tempValue2 = Format(CDate(Me.Date_YYMM.EditValue), "yyyyMM")

        If PM_M_Code.EditValue Is Nothing Or PM_M_Code.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = PM_M_Code.EditValue
        End If
        Me.Close()

    End Sub
End Class