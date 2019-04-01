Public Class frmA_AcceptanceSelect2

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = txtLFID.Text
            Me.Close()
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = TextEdit2.Text
            Me.Close()
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = TextEdit1.Text
            Me.Close()
        End If


        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = TextEdit3.Text
            Me.Close()
        End If


        If RadioButton5.Checked = True Then
            tempValue = "5"
            tempValue2 = gluSupplier.EditValue
            Me.Close()
        End If

        If RadioButton6.Checked = True Then
            tempValue = "6"
            tempValue2 = TextEdit4.Text
            Me.Close()
        End If
    End Sub

    Private Sub frmA_AcceptanceSelect2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        txtLFID.Select()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtLFID.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextEdit2.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextEdit3.Focus()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextEdit4.Focus()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            gluSupplier.Focus()
        End If
    End Sub
End Class