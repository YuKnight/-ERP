
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class frmQuotationseek
    Dim mtc As New Material.MaterialTypeController
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = TextEdit1.EditValue
            Me.Close()
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = PopupContainerEdit1.EditValue
            Me.Close()
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = gluSupplier.EditValue
            Me.Close()
        End If
        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = ComboBoxEdit1.EditValue
            Me.Close()
        End If
        If RadioButton5.Checked = True Then
            tempValue = "5"
            tempValue2 = ComboBoxEdit2.EditValue
            Me.Close()
        End If
        If RadioButton6.Checked = True Then
            tempValue = "6"
            tempValue2 = TextEdit2.EditValue
            Me.Close()
        End If
        If RadioButton7.Checked = True Then
            tempValue = "7"
            tempValue2 = TextEdit3.EditValue
            Me.Close()
        End If

    End Sub

    Private Sub frmQuotationseek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        mtc.LoadNodes(tv1, ErpUser.MaterialType)
        RadioButton1.Checked = True

    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged
        Dim i%
        If sender.checked = True Then
            i = sender.tag
            Me.Controls.Item(i).Focus()
        End If
    End Sub
End Class