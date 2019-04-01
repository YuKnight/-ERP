Imports LFERP.Library.MrpManager.MrpSetting
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.MrpManager.MrpPurchaseOrder
Imports LFERP.Library.MrpManager.MrpSupplierQuotation
Imports LFERP.SystemManager

Public Class frmMrpSetting

#Region "屬性"
    Dim msuc As New SystemUserController
    Dim mpoec As New MrpPurchaseOrderEntryController
    Dim msc As New MrpSettingController
    Dim msqc As New MrpSupplierQuotationController
#End Region
    Private Sub SetComboBoxEdit(ByVal cbo As DevExpress.XtraEditors.ComboBoxEdit, ByVal value As String)
        If value.Contains("0") And value.Contains("1") Then
            cbo.SelectedIndex = 0
        ElseIf value.Contains("1") Then
            cbo.SelectedIndex = 1
        ElseIf value.Contains("0") Then
            cbo.SelectedIndex = 2
        ElseIf value.Contains("2") Then
            cbo.SelectedIndex = 3
        End If
    End Sub

    Private Sub SetComboBoxUserID(ByVal cbo As DevExpress.XtraEditors.ComboBoxEdit, ByVal value As String)
        If value.Contains("All") Then
            cbo.EditValue = value
        Else
            cbo.EditValue = value
        End If
    End Sub

    Private Sub MRPSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '1.權限設置
        Dim pccon As New PermissionController
        Dim pcinfo As New PermissionInfo
        pcinfo = pccon.PermissionModuleUser_Get("4805", InUserID)
        If pcinfo.PMU_Value = False Then
            XtraTabPage7.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4803", InUserID)
        If pcinfo.PMU_Value = False Then
            XtraTabPage1.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4802", InUserID)
        If pcinfo.PMU_Value = False Then
            XtraTabPage2.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4801", InUserID)
        If pcinfo.PMU_Value = False Then
            XtraTabPage5.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4806", InUserID)
        If pcinfo.PMU_Value = False Then
            XtraTabPage6.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4807", InUserID)
        If pcinfo.PMU_Value = False Then
            xtpPurchaseRequest.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4808", InUserID)
        If pcinfo.PMU_Value = False Then
            xtpPurchaseOrder.PageVisible = False
        End If
        pcinfo = pccon.PermissionModuleUser_Get("4804", InUserID)
        If pcinfo.PMU_Value = False Then
            xtp_MrpMps.PageVisible = False
        End If
        tipWarehouse.SetToolTip(cboMaterialWarehouse, "可手動輸入，多個倉庫用逗號隔開")
        Dim msuli As New List(Of SystemUserInfo)
        Dim msui As New SystemUserInfo
        msui.U_ID = "All"
        msui.U_Name = "全部"
        msuli = msuc.SystemUser_GetList(Nothing, Nothing, Nothing)
        msuli.Insert(0, msui)

        Dim dt As DataTable = mpoec.GetDeptInfo()
        Dim row As DataRow = dt.NewRow()
        row("DeptID") = "All"
        row("DeptName") = "全部"
        dt.Rows.InsertAt(row, 0)

        Dim msqlist As New List(Of MrpSupplierQuotationInfo)
        Dim msqi As New MrpSupplierQuotationInfo
        msqi.S_Supplier = "All"
        msqi.S_SupplierName = "全部"
        msqlist = msqc.MRPSupplierQuotation_GetList(Nothing, Nothing, Nothing)
        msqlist.Insert(0, msqi)

        gluForecastUserID.Properties.DataSource = msuli
        gluBomUserID.Properties.DataSource = msuli
        gluMaterialUserID.Properties.DataSource = msuli
        gluWarehouseUserID.Properties.DataSource = msuli
        gluMrpInfoUserID.Properties.DataSource = msuli
        gluPurchaseUserID.Properties.DataSource = msuli
        gluPurOrderUserID.Properties.DataSource = msuli
        gluPurOrderRequestDept.Properties.DataSource = dt
        gluPurOrderSupplier.Properties.DataSource = msqlist

        glu_UserID_MM.Properties.DataSource = msuli
        Dim msli As New List(Of MrpSettingInfo)
        msli = msc.MrpSetting_GetList(InUserID)
        If msli.Count > 0 Then
            dteForecastBeginDate.EditValue = Format(msli(0).forecastBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboForestcastCheckType, msli(0).forecastCheckType)
            SetComboBoxEdit(cboForecastCancellation, msli(0).mrpInfoForecastCancellation)
            gluForecastUserID.EditValue = msli(0).forecastCreateUserID
            clcForecastDisplayNum.EditValue = msli(0).forecastDisplayNum
            dteForecastBrowserBeginDate.EditValue = Format(msli(0).forecastBrowserBeginDate, "yyyy/MM/dd")
            dteForecastBrowserEndDate.EditValue = Format(msli(0).forecastBrowserEndDate, "yyyy/MM/dd")
            clcForecastBrowserDisplayNum.EditValue = msli(0).forecastBrowserDisplayNum

            dteBomBeginDate.EditValue = Format(msli(0).bomBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboBomProductType, msli(0).bomProductType)
            SetComboBoxEdit(cboBomCheckType, msli(0).bomCheckType)
            SetComboBoxEdit(cboBomDisplayType, msli(0).bomDisplayType)
            gluBomUserID.EditValue = msli(0).bomCreateUserID
            clcBomDisplayNum.EditValue = msli(0).bomDisplayNum

            dteMaterialBeginDate.EditValue = Format(msli(0).materialBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboMaterialCheckType, msli(0).materialCheckType)
            SetComboBoxUserID(cboMaterialWarehouse, msli(0).materialWarehouse)
            gluMaterialUserID.EditValue = msli(0).materialCreateUserID
            clcMaterialDisplayNum.EditValue = msli(0).materialDisplayNum

            dteWarehouseBeginDate.EditValue = Format(msli(0).warehouseBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboWarehouseCheckType, msli(0).warehouseCheckType)
            gluWarehouseUserID.EditValue = msli(0).warehouseCreateUserID
            clcWarehouseDisplayNum.EditValue = msli(0).warehouseDisplayNum

            dteMrpInfoBeginDate.EditValue = Format(msli(0).mrpInfoBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboMrpInfoCheckType, msli(0).mrpInfoCheckType)
            SetComboBoxEdit(cboMrpInfoMrpType, msli(0).mrpInfoMrpType)
            gluMrpInfoUserID.EditValue = msli(0).mrpInfoCreateUserID
            clcMrpInfoDisplayNum.EditValue = msli(0).mrpInfoDisplayNum

            SetComboBoxEdit(cboMrpInfoForecastCancellation, msli(0).mrpInfoForecastCancellation)
            SetComboBoxEdit(cboMrpInfoForecastCheckType, msli(0).mrpInfoForecastCheckType)

            chkNeedQtyEnable.Checked = msli(0).needQtyEnable
            chkInventoryQtyEnable.Checked = msli(0).inventoryQtyEnable
            chkRetreatQtyEnable.Checked = msli(0).retreatQtyEnable
            chkInTransitQtyEnable.Checked = msli(0).inTransitQtyEnable
            chkInspectionEnable.Checked = msli(0).inspectionEnable
            chkNoCollarEnable.Checked = msli(0).noCollarEnable
            chkRelatedQtyEnable.Checked = msli(0).relatedQtyEnable
            chkSecInvEnable.Checked = msli(0).secInvEnable
            chkLowLimitEnable.Checked = msli(0).lowLimitEnable

            dtePurchaseBeginDate.EditValue = Format(msli(0).purchaseBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboPurchaseCheckType, msli(0).purchaseCheckType)
            gluPurchaseUserID.EditValue = msli(0).purchaseCreateUserID
            clcPurchaseDisplayNum.EditValue = msli(0).purchaseDisplayNum

            dtePurOrderBeginDate.EditValue = Format(msli(0).purOrderBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cboPurOrderCheckType, msli(0).purOrderCheckType)
            SetComboBoxEdit(cboPurOrderReCheckType, msli(0).purOrderReCheckType)
            gluPurOrderRequestDept.EditValue = msli(0).purOrderRequestDept
            gluPurOrderSupplier.EditValue = msli(0).purOrderSupplierID
            gluPurOrderUserID.EditValue = msli(0).purOrderCreateUserID
            clcPurOrderDisplayNum.EditValue = msli(0).purOrderDisplayNum

            de_BeginDate_MM.EditValue = Format(msli(0).MrpMpsBeginDate, "yyyy/MM/dd")
            SetComboBoxEdit(cbe_IsCheck_MM, msli(0).MrpMpsCheckType)
            glu_UserID_MM.EditValue = msli(0).MrpMpsCreateUserID
            clcMrpMpsDisplayNum.EditValue = msli(0).MrpMpsDisplayNum

            de_BeginDate_MME.EditValue = Format(msli(0).mrpMpsBrowserBeginDate, "yyyy/MM/dd")
            de_EndDate_MME.EditValue = Format(msli(0).mrpMpsBrowserEndDate, "yyyy/MM/dd")
            clcMrpMpsBrowserDisplayNum.EditValue = msli(0).mrpMpsBrowserDisplayNum

        Else
            btnReset_Click(sender, e)
        End If
    End Sub

    Private Function GetComboBoxEditValue(ByVal cbo As DevExpress.XtraEditors.ComboBoxEdit) As String
        If cbo.SelectedIndex = 0 Then
            Return "0,1"
        ElseIf cbo.SelectedIndex = 1 Then
            Return "1"
        ElseIf cbo.SelectedIndex = 2 Then
            Return "0"
        ElseIf cbo.SelectedIndex = 3 Then
            Return "2"
        Else
            Return "false"
        End If
    End Function

    Private Function GetComboBoxUserID(ByVal cbo As DevExpress.XtraEditors.ComboBoxEdit) As String
        If cbo.SelectedIndex = 0 Then
            Return "All"
        Else
            Return (cbo.EditValue.ToString)
        End If
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CheckSave() = False Then
            Exit Sub
        End If
        Dim msi As New MrpSettingInfo
        msi.U_ID = InUserID
        msi.forecastBeginDate = dteForecastBeginDate.EditValue
        msi.forecastCheckType = GetComboBoxEditValue(cboMaterialCheckType)
        msi.forecasstCancellation = GetComboBoxEditValue(cboForecastCancellation)
        msi.forecastCreateUserID = gluForecastUserID.EditValue
        msi.forecastDisplayNum = clcForecastDisplayNum.EditValue
        msi.forecastBrowserBeginDate = dteForecastBrowserBeginDate.EditValue
        msi.forecastBrowserEndDate = dteForecastBrowserEndDate.EditValue
        msi.forecastBrowserDisplayNum = clcForecastBrowserDisplayNum.EditValue

        msi.bomBeginDate = dteBomBeginDate.EditValue
        msi.bomProductType = GetComboBoxEditValue(cboBomProductType)
        msi.bomCheckType = GetComboBoxEditValue(cboBomCheckType)
        msi.bomDisplayType = GetComboBoxEditValue(cboBomDisplayType)
        msi.bomCreateUserID = gluBomUserID.EditValue
        msi.bomDisplayNum = clcBomDisplayNum.EditValue

        msi.materialBeginDate = dteMaterialBeginDate.EditValue
        msi.materialCheckType = GetComboBoxEditValue(cboMaterialCheckType)
        msi.materialWarehouse = GetComboBoxUserID(cboMaterialWarehouse)
        msi.materialCreateUserID = gluMaterialUserID.EditValue
        msi.materialDisplayNum = clcMaterialDisplayNum.EditValue

        msi.warehouseBeginDate = dteWarehouseBeginDate.EditValue
        msi.warehouseCheckType = GetComboBoxEditValue(cboWarehouseCheckType)
        msi.warehouseCreateUserID = gluWarehouseUserID.EditValue
        msi.warehouseDisplayNum = clcWarehouseDisplayNum.EditValue

        msi.mrpInfoBeginDate = dteMrpInfoBeginDate.EditValue
        msi.mrpInfoCheckType = GetComboBoxEditValue(cboMrpInfoCheckType)
        msi.mrpInfoMrpType = GetComboBoxEditValue(cboMrpInfoMrpType)
        msi.mrpInfoCreateUserID = gluMrpInfoUserID.EditValue
        msi.mrpInfoForecastCancellation = GetComboBoxEditValue(cboMrpInfoForecastCancellation)
        msi.mrpInfoForecastCheckType = GetComboBoxEditValue(cboMrpInfoForecastCheckType)
        msi.mrpInfoDisplayNum = clcMrpInfoDisplayNum.EditValue

        msi.needQtyEnable = chkNeedQtyEnable.Checked
        msi.inventoryQtyEnable = chkInventoryQtyEnable.Checked
        msi.retreatQtyEnable = chkRetreatQtyEnable.Checked
        msi.inTransitQtyEnable = chkInTransitQtyEnable.Checked
        msi.inspectionEnable = chkInspectionEnable.Checked
        msi.noCollarEnable = chkNoCollarEnable.Checked
        msi.relatedQtyEnable = chkRelatedQtyEnable.Checked
        msi.secInvEnable = chkSecInvEnable.Checked
        msi.lowLimitEnable = chkLowLimitEnable.Checked

        msi.purchaseBeginDate = dtePurchaseBeginDate.EditValue
        msi.purchaseCheckType = GetComboBoxEditValue(cboPurchaseCheckType)
        msi.purchaseCreateUserID = gluPurchaseUserID.EditValue
        msi.purchaseDisplayNum = clcPurchaseDisplayNum.EditValue

        msi.purOrderBeginDate = dtePurOrderBeginDate.EditValue
        msi.purOrderCheckType = GetComboBoxEditValue(cboPurOrderCheckType)
        msi.purOrderReCheckType = GetComboBoxEditValue(cboPurOrderReCheckType)
        msi.purOrderRequestDept = gluPurOrderRequestDept.EditValue
        msi.purOrderSupplierID = gluPurOrderSupplier.EditValue
        msi.purOrderCreateUserID = gluPurOrderUserID.EditValue
        msi.purOrderDisplayNum = clcPurOrderDisplayNum.EditValue

        msi.MrpMpsBeginDate = de_BeginDate_MM.EditValue
        msi.MrpMpsCheckType = GetComboBoxEditValue(cbe_IsCheck_MM)
        msi.MrpMpsCreateUserID = glu_UserID_MM.EditValue
        msi.MrpMpsDisplayNum = clcMrpMpsDisplayNum.EditValue

        msi.mrpMpsBrowserBeginDate = de_BeginDate_MME.EditValue
        msi.mrpMpsBrowserEndDate = de_EndDate_MME.EditValue
        msi.mrpMpsBrowserDisplayNum = clcMrpMpsBrowserDisplayNum.EditValue

        Dim msli As New List(Of MrpSettingInfo)
        msli = msc.MrpSetting_GetList(InUserID)
        If msli.Count > 0 Then
            If msc.MrpSetting_Update(msi) = True Then
                MsgBox("MRP相關參數設置修改成功", MsgBoxStyle.Information, "提示")
                Me.Close()
            Else
                MsgBox("MRP相關參數設置修改失敗", MsgBoxStyle.Information, "提示")
            End If
        Else
            If msc.MrpSetting_Add(msi) = True Then
                MsgBox("MRP相關參數設置增加成功", MsgBoxStyle.Information, "提示")
                Me.Close()
            Else
                MsgBox("MRP相關參數設置新增失敗", MsgBoxStyle.Information, "提示")
            End If
        End If
    End Sub

    Private Function CheckSave() As Boolean
        CheckSave = False
        Dim value As String

        value = cboMaterialWarehouse.EditValue.ToString.Trim
        If value.StartsWith(",") Or value.EndsWith(",") Then
            MsgBox("物料信息參數中入庫倉庫不能以逗號開頭或結尾", MsgBoxStyle.Information, "提示")
            Exit Function
        ElseIf Date.Compare(CDate(dteForecastBrowserBeginDate.EditValue), dteForecastBrowserEndDate.EditValue) > 0 Then
            MsgBox("注意:預測訂單參數中瀏覽開始日期晚于截止日期", MsgBoxStyle.Information, "提示")
            Exit Function
        End If
        If Date.Compare(CDate(dteForecastBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:預測訂單參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        ElseIf Date.Compare(CDate(dteBomBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:Bom表參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        ElseIf Date.Compare(CDate(dteMaterialBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:物料信息參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        ElseIf Date.Compare(CDate(dteWarehouseBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:庫存記錄參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        ElseIf Date.Compare(CDate(dteMrpInfoBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:MRP需求計劃參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        ElseIf Date.Compare(CDate(dtePurchaseBeginDate.EditValue), Now) > 0 Then
            MsgBox("注意:MRP需求計劃參數中開始日期晚于目前日期", MsgBoxStyle.Information, "提示")
        End If
        CheckSave = True
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim beginDate As Date = CDate(Now.Year.ToString + "/1/1")

        gluForecastUserID.EditValue = "All"
        gluBomUserID.EditValue = "All"
        gluMaterialUserID.EditValue = "All"
        gluWarehouseUserID.EditValue = "All"
        gluMrpInfoUserID.EditValue = "All"
        gluPurchaseUserID.EditValue = "All"
        gluPurOrderUserID.EditValue = "All"
        gluPurOrderRequestDept.EditValue = "All"
        gluPurOrderSupplier.EditValue = "All"

        dteForecastBeginDate.EditValue = beginDate
        cboForestcastCheckType.SelectedIndex = 0
        cboForecastCancellation.SelectedIndex = 0
        dteForecastBrowserBeginDate.EditValue = beginDate
        dteForecastBrowserEndDate.EditValue = CDate(Now.Year.ToString + "/12/31")

        dteBomBeginDate.EditValue = beginDate
        cboBomProductType.SelectedIndex = 0
        cboBomCheckType.SelectedIndex = 0
        cboBomDisplayType.SelectedIndex = 0

        dteMaterialBeginDate.EditValue = beginDate
        cboMaterialCheckType.SelectedIndex = 0
        cboMaterialWarehouse.SelectedIndex = 0

        dteWarehouseBeginDate.EditValue = beginDate
        cboWarehouseCheckType.SelectedIndex = 0

        dteMrpInfoBeginDate.EditValue = beginDate
        cboMrpInfoCheckType.SelectedIndex = 0
        cboMrpInfoMrpType.SelectedIndex = 0
        cboMrpInfoForecastCancellation.SelectedIndex = 2
        cboMrpInfoForecastCheckType.SelectedIndex = 0
        chkNeedQtyEnable.Checked = True
        chkInventoryQtyEnable.Checked = True
        chkRetreatQtyEnable.Checked = False
        chkInTransitQtyEnable.Checked = False
        chkInspectionEnable.Checked = False
        chkNoCollarEnable.Checked = True
        chkRelatedQtyEnable.Checked = True
        chkSecInvEnable.Checked = False
        chkLowLimitEnable.Checked = False
        chkBatFixEconomyEnable.Checked = False

        dtePurchaseBeginDate.EditValue = beginDate
        cboPurchaseCheckType.SelectedIndex = 0

        dtePurOrderBeginDate.EditValue = beginDate
        cboPurOrderCheckType.SelectedIndex = 0
        cboPurOrderReCheckType.SelectedIndex = 0

        de_BeginDate_MM.EditValue = beginDate
        cbe_IsCheck_MM.SelectedIndex = 0
        glu_UserID_MM.EditValue = "All"

        de_BeginDate_MME.EditValue = beginDate
        de_EndDate_MME.EditValue = CDate(Now.Year.ToString + "/12/31")


    End Sub

    Private Sub clcMrpInfoDisplayNum_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles clcMrpInfoDisplayNum.EditValueChanging, clcWarehouseDisplayNum.EditValueChanging, clcPurOrderDisplayNum.EditValueChanging, clcPurchaseDisplayNum.EditValueChanging, clcMrpMpsDisplayNum.EditValueChanging, clcMrpMpsBrowserDisplayNum.EditValueChanging, clcMaterialDisplayNum.EditValueChanging, clcForecastDisplayNum.EditValueChanging, clcForecastBrowserDisplayNum.EditValueChanging, clcBomDisplayNum.EditValueChanging
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
        Else
            e.NewValue = CInt(e.NewValue)
        End If
    End Sub
End Class