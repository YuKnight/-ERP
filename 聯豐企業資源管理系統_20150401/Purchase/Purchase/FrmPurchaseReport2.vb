
Imports LFERP.SystemManager
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class FrmPurchaseReport2
    Dim mtc As New Material.MaterialTypeController


    Private Sub FrmPurchaseReport2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        mtc.LoadNodes(tv1, ErpUser.MaterialType)
        DateEdit1.EditValue = Now
        DateEdit2.EditValue = Now

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click


        Dim ds As New DataSet
        'If GridView2.RowCount = 0 Then Exit Sub

        'Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        'Dim ltc3 As New CollectionToDataSet
        'Dim ltc4 As New CollectionToDataSet
        ' Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
        ' Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
        'Dim mctarriff As New LFERP.DataSetting.TarriffController
        '***判斷用戶是擁有特殊類的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim pim As List(Of Purchase.Purchase.PurchaseMainInfo)
        Dim tesuvalue, temp1, temp2, temp3, temp4 As String
        Dim temp5, temp6 As Boolean
        tesuvalue = "否"
        temp1 = Nothing
        temp2 = Nothing
        temp3 = Nothing
        temp4 = Nothing
        temp5 = Nothing
        temp6 = Nothing

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        If pmwiL.Item(0).PMWS_Value = "是" Then
            tesuvalue = "是"
        End If

        If Len(PopupContainerEdit1.EditValue) <> 0 Then temp1 = PopupContainerEdit1.EditValue
        If Len(gluSupplier.EditValue) <> 0 Then temp2 = gluSupplier.EditValue
        If CheckBox1.Checked = True Then
            temp3 = Format(DateEdit1.EditValue, "yyyy/MM/dd")
            temp4 = Format(DateEdit2.EditValue, "yyyy/MM/dd")
        End If


        If ComboBoxEdit1.EditValue = "已審核" Then
            temp5 = True
        ElseIf ComboBoxEdit1.EditValue = "未審核" Then
            temp5 = False
        End If
        If ComboBoxEdit2.EditValue = "已審核" Then
            temp6 = True
        ElseIf ComboBoxEdit2.EditValue = "未審核" Then
            temp6 = False
        End If
        pim = mcPurchase.PurchaseMain_GetReportList(Nothing, temp1, Nothing, Nothing, temp3, temp4, temp2, temp5, temp6, Nothing, tesuvalue)
        If pim.Count = 0 Then
            MsgBox("沒有符合條件的數據")
            Exit Sub
        End If
        ds.Tables.Clear()
        'ltc.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        ltc2.CollToDataSet(ds, "PurchaseMain", mcPurchase.PurchaseMain_GetReportList(Nothing, temp1, Nothing, Nothing, temp3, temp4, temp2, temp5, temp6, Nothing, tesuvalue))
        'ltc3.CollToDataSet(ds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
        'ltc4.CollToDataSet(ds, "Unit", mctarriff.TarriffGetList(Nothing))

        PreviewRPT(ds, "rptPurchaseReport", " 採購單--", True, True)
        'ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        'ltc3 = Nothing
        ' ltc4 = Nothing

    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub



    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            DateEdit1.Focus()
        Else
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
        End If

    End Sub

End Class