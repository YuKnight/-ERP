Imports LFERP.Library.Purchase.ApplyPurchase

Public Class frmApplyPurchaseSelect
    Dim strDPTID As String

    Private Sub frmApplyPurchaseSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Text = ""
        txtCode.Text = ""
        txtName.Text = ""
        txtGauge.Text = ""
        txtapDpt.Text = ""
        detDateStart.Text = ""
        detDateEnd.Text = ""
        strDPTID = ""
        txtID.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If detDateStart.DateTime > detDateEnd.DateTime Then
            MsgBox("輸入申購日期順序有誤，請重新輸入!", 64, "提示")
            detDateStart.Focus()
        Else
            tempAPID = txtID.Text
            tempAPCode = txtCode.Text
            tempAPName = txtName.Text
            tempAPGauge = txtGauge.Text
            tempAPDPTID = strDPTID
            tempAPDateStart = detDateStart.Text
            tempAPDateEnd = detDateEnd.Text
            Me.Close()
        End If
    End Sub

    Private Sub cmdExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub txtapDpt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtapDpt.Click
        frmDepartmentSelect.DptID = ""
        frmDepartmentSelect.DptName = ""
        frmDepartmentSelect.UpDptName = ""
        txtapDpt.Text = ""
        frmDepartmentSelect.StartPosition = FormStartPosition.Manual
        frmDepartmentSelect.Left = Me.Left + txtapDpt.Left + 2
        frmDepartmentSelect.Top = Me.Top + 246
        frmDepartmentSelect.Size = New Size(213, 245)
        frmDepartmentSelect.ShowDialog()
        strDPTID = ""
        If frmDepartmentSelect.DptID = "" Then

        Else
            strDPTID = frmDepartmentSelect.DptID
            txtapDpt.Text = frmDepartmentSelect.UpDptName & "-" & frmDepartmentSelect.DptName
        End If
    End Sub

End Class