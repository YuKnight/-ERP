Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager.SystemUser


Public Class frmPurchaseSelect
    Dim mtc As New Material.MaterialTypeController



    Private Sub frmPurchaseSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        Dim us As New SystemUserController

        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        gluAction.Properties.DisplayMember = "U_Name"
        gluAction.Properties.ValueMember = "U_ID"
        gluAction.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, "10010103")
        mtc.LoadNodes(tv1, ErpUser.MaterialType)
        RadioButton1.Checked = True
    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If RadioButton1.Checked = True Then                 '採購單號
            tempValue = "1"
            tempValue2 = txtLFID.EditValue
        End If

        If RadioButton2.Checked = True Then                 '物料
            tempValue = "2"
            tempValue2 = PopupContainerEdit1.EditValue
        End If

        If RadioButton3.Checked = True Then                 '供應商
            tempValue = "3"
            tempValue2 = gluSupplier.EditValue
        End If

        If RadioButton4.Checked = True Then                 '部門審核
            tempValue = "4"
            tempValue2 = ComboBoxEdit1.EditValue
        End If

        If RadioButton5.Checked = True Then                 '會計
            tempValue = "5"
            tempValue2 = ComboBoxEdit2.EditValue
        End If

        If RadioButton6.Checked = True Then                 '會計
            tempValue = "6"
            tempValue2 = TextEdit1.EditValue
        End If
        If RadioButton7.Checked = True Then
            tempValue = "7"
            tempValue2 = TextEdit2.EditValue
        End If
        If RadioButton8.Checked Then                  '操作員
            tempValue = 8
            tempValue2 = gluAction.EditValue
        End If
        If RadioButton9.Checked Then
            tempValue = "9"
            tempValue2 = txtGauge.Text
        End If

        'If txtLFID.Text = "" Then
        '    tempValue2 = Nothing
        'Else
        '    tempValue2 = txtLFID.Text
        'End If
        'If PopupContainerEdit1.EditValue = "" Then
        '    tempValue3 = Nothing
        'Else
        '    tempValue3 = PopupContainerEdit1.EditValue
        'End If
        'If gluSupplier.EditValue = "" Then
        '    tempValue4 = Nothing
        'Else
        '    tempValue4 = gluSupplier.EditValue
        'End If
        'If ComboBoxEdit1.EditValue = "" Then
        '    tempValue5 = Nothing
        'ElseIf ComboBoxEdit1.EditValue = "已審核" Then
        '    tempValue5 = True
        'ElseIf ComboBoxEdit1.EditValue = "未審核" Then
        '    tempValue5 = False
        'End If
        'If TextEdit1.EditValue = "" Then
        '    tempValue6 = Nothing
        'Else
        '    tempValue6 = TextEdit1.EditValue
        'End If
        'If TextEdit2.EditValue = "" Then
        '    tempValue7 = Nothing
        'Else
        '    tempValue7 = TextEdit2.EditValue
        'End If
        'If gluAction.EditValue = "" Then
        '    tempValue8 = Nothing
        'Else
        '    tempValue8 = gluAction.EditValue
        'End If
        'If ComboBoxEdit2.EditValue = "" Then
        '    tempValue9 = Nothing
        'ElseIf ComboBoxEdit2.EditValue = "已審核" Then
        '    tempValue9 = True
        'ElseIf ComboBoxEdit2.EditValue = "未審核" Then
        '    tempValue9 = False
        'End If

        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged
        Dim i%
        If sender.checked = True Then
            i = sender.tag
            Me.Controls.Item(i).Focus()
        End If
    End Sub
End Class