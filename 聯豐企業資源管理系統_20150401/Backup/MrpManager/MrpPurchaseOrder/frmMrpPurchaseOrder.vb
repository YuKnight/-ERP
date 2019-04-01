Imports LFERP.Library.MrpManager.MrpPurchaseOrder
Imports LFERP.Library.MrpManager.MrpPurchaseRecord
Imports LFERP.DataSetting
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.Library.WareHouse

Public Class frmMrpPurchaseOrder

#Region "字段屬性"
    Dim ds As New DataSet
    Dim mpoc As New MrpPurchaseOrderController
    Dim mpoec As New MrpPurchaseOrderEntryController
    Dim msuc As New SystemUserController
    Dim mprc As New MrpPurchaseRecordController
    Dim sc As New SuppliersControler
    Dim whc As New WareHouseController
    Dim mmcc As New MrpMaterialCodeController
    Dim DelAutoID As String = ""            '記錄明細表被刪除的AutoID
    Dim boCheck As Boolean = False         '用來判斷審核狀態是否有改變
    Private _EditItem As String
    Private _PO As String

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property

    Property PO() As String '屬性
        Get
            Return _PO
        End Get
        Set(ByVal value As String)
            _PO = value
        End Set
    End Property
#End Region

#Region "創建、填充臨時表"
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("PurchaseOrder")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("Source", GetType(String))
            .Columns.Add("PurchaseQty", GetType(Decimal))
            .Columns.Add("UnitPrice", GetType(Decimal))
            .Columns.Add("NeedDate", GetType(Date))
            .Columns.Add("DeliveryDate", GetType(Date))
            .Columns.Add("Remarks", GetType(String))
            .Columns.Add("TotalPrice", GetType(String))
            '.Columns.Add("TotalPrice", GetType(String), "PurchaseQty*UnitPrice")
        End With
        GridPurchaseOrder.DataSource = ds.Tables("PurchaseOrder")
    End Sub

    Sub FillTable(ByVal infoList As Object)
        Try
            Dim row As DataRow
            Dim i As Integer
            Dim mpoi As New List(Of MrpPurchaseOrderEntryInfo)
            mpoi = infoList
            For i = 0 To mpoi.Count - 1
                row = ds.Tables("PurchaseOrder").NewRow
                row("AutoID") = mpoi(i).AutoID
                row("PO") = mpoi(i).PO
                row("M_Code") = mpoi(i).M_Code
                row("M_Name") = mpoi(i).M_Name
                row("M_Gauge") = mpoi(i).M_Gauge
                row("M_Unit") = mpoi(i).M_Unit
                row("Source") = mpoi(i).Source
                row("PurchaseQty") = mpoi(i).PurchaseQty
                row("UnitPrice") = mpoi(i).UnitPrice
                row("NeedDate") = mpoi(i).NeedDate
                row("DeliveryDate") = mpoi(i).DeliveryDate
                row("Remarks") = mpoi(i).Remarks
                row("TotalPrice") = row("PurchaseQty") * row("UnitPrice")
                ds.Tables("PurchaseOrder").Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FillTable方法出錯")
        End Try
    End Sub
#End Region

#Region "窗體加載"
    Private Sub frmMrpPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToLookUpEdit()
        CreateTables()
        Select Case EditItem
            Case EditEnumType.ADD
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.ADD)
                Me.Text = lblTitle.Text
                txtPO.EditValue = "自動編號"
                dteRequestDate.EditValue = Now
                SetControlEnable(True, True)
                gluPR.Enabled = True
            Case EditEnumType.EDIT
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.EDIT)
                Me.Text = lblTitle.Text
                SetControlEnable(True, True)
                LoadData(PO)
            Case EditEnumType.VIEW
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.VIEW)
                Me.Text = lblTitle.Text
                SetControlEnable(False, False)
                LoadData(PO)
            Case EditEnumType.CHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.CHECK)
                Me.Text = lblTitle.Text
                SetControlEnable(False, True)
                XtraTabControl1.SelectedTabPage = xtpCheck
                LoadData(PO)
            Case EditEnumType.RECHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.RECHECK)
                Me.Text = lblTitle.Text            
                SetControlEnable(False, True)
                XtraTabControl1.SelectedTabPage = xtpCheck
                LoadData(PO)
        End Select
    End Sub

    Private Sub LoadDataToLookUpEdit()   
        gluPR.Properties.DataSource = mprc.MrpPurchaseRecord_GetPRList()
        gluSupplier.Properties.DataSource = sc.Suppliers_GetDataTable(Nothing)
        gluDept.Properties.DataSource = mpoec.GetDeptInfo()
        gluUserID.Properties.DataSource = msuc.SystemUser_GetList(Nothing, Nothing, Nothing)
        gluWareHouse.Properties.DataSource = whc.WareHouse_GetDataTable(Nothing)

        If EditItem = EditEnumType.ADD Then
            GridMaterial.DataSource = mmcc.MrpMaterialCode_GetList(Nothing, Nothing, "True", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Else
            GridMaterial.DataSource = mmcc.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
    End Sub

#End Region

#Region "設置控件是否可用"
    Private Sub SetControlEnable(ByVal a As Boolean, ByVal b As Boolean)
        gluSupplier.Enabled = a
        gluDept.Enabled = a
        gluUserID.Enabled = a
        gluWareHouse.Enabled = a
        dteRequestDate.Enabled = a
        chkIsUrgency.Enabled = a
        txtRemarks.Enabled = a
        viewPurchaseOrder.OptionsBehavior.Editable = a
        xtpCheck.PageVisible = Not a
        chkCheck.Enabled = b
        txtCheckRemark.Enabled = b
        btnSave.Enabled = b

        If a = False Then
            GridPurchaseOrder.ContextMenuStrip = Nothing
        End If
    End Sub
#End Region

#Region "加載數據"
    Private Sub LoadData(ByVal PO As String)
        Dim objInfo As New MrpPurchaseOrderInfo
        Dim mpolist As New List(Of MrpPurchaseOrderEntryInfo)
        objInfo = mpoc.MrpPurchaseOrder_GetList(PO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)(0)
        txtPO.EditValue = objInfo.PO
        gluPR.EditValue = objInfo.PR
        gluDept.EditValue = objInfo.DeptID
        gluSupplier.EditValue = objInfo.SupplierID
        gluUserID.EditValue = objInfo.RequestUserID
        dteRequestDate.EditValue = objInfo.RequestDate
        txtRemarks.EditValue = objInfo.Remarks
        chkIsUrgency.Checked = objInfo.IsUrgency
        gluWareHouse.EditValue = objInfo.WareHouseID

        chkCheck.Checked = objInfo.CheckBit
        boCheck = chkCheck.Checked
        txtCheckRemark.EditValue = objInfo.CheckRemark
        If chkCheck.Checked = True Then
            lblCheckUserName.Text += objInfo.CheckUserName
            lblCheckDate.Text += Format(objInfo.CheckDate, "yyyy/MM/dd")
        Else
            lblCheckUserName.Text += InUser
            lblCheckDate.Text += Format(Now, "yyyy/MM/dd")
        End If
        If EditItem = EditEnumType.VIEW And objInfo.ReCheckBit = True Or EditItem = EditEnumType.RECHECK Then
            lblCheck.Text = "復審："
            xtpCheck.Text = "復審信息"
            chkCheck.Checked = objInfo.ReCheckBit
            boCheck = chkCheck.Checked
            txtCheckRemark.EditValue = objInfo.ReCheckRemark
            If chkCheck.Checked = True Then
                lblCheckUserName.Text = "復核人員：" + objInfo.ReCheckUserName
                lblCheckDate.Text = "復核日期：" + Format(objInfo.ReCheckDate, "yyyy/MM/dd")
            Else
                lblCheckUserName.Text = "復核人員：" + InUser
                lblCheckDate.Text = "復核日期：" + Format(Now, "yyyy/MM/dd")
            End If
        End If
        mpolist = mpoec.MrpPurchaseOrderEntry_GetList(PO)
        If mpolist.Count > 0 Then
            FillTable(mpolist)
        End If
    End Sub
#End Region

#Region "右擊菜單事件"
    Private Sub cms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPurOrderAdd.Click, cmsPurOrderDel.Click
        Select Case sender.Name
            Case "cmsPurOrderAdd"
                Dim row As DataRow
                row = ds.Tables("PurchaseOrder").NewRow
                row("AutoID") = 0
                row("PurchaseQty") = 0
                row("UnitPrice") = 0
                ds.Tables("PurchaseOrder").Rows.Add(row)
                viewPurchaseOrder.FocusedRowHandle = viewPurchaseOrder.RowCount - 1
            Case "cmsPurOrderDel"
                If (viewPurchaseOrder.GetFocusedRowCellValue("AutoID").ToString <> "0") Then
                    DelAutoID += viewPurchaseOrder.GetFocusedRowCellValue("AutoID").ToString + ","
                End If
                ds.Tables("PurchaseOrder").Rows.RemoveAt(viewPurchaseOrder.FocusedRowHandle)
                SetRightMenuEnable()
        End Select
    End Sub

    Private Sub GridPurchaseOrder_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridPurchaseOrder.MouseDown
        If e.Button() = Windows.Forms.MouseButtons.Right Then
            SetRightMenuEnable()
        End If
    End Sub

    Private Sub SetRightMenuEnable()
        If viewPurchaseOrder.RowCount < 1 Then
            cmsPurOrder.Items("cmsPurOrderDel").Enabled = False
        Else
            cmsPurOrder.Items("cmsPurOrderDel").Enabled = True
        End If
    End Sub
#End Region

#Region "物料選擇事件"
    Private Sub PopupControlSelect(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMaterial.DoubleClick
        Dim i As Int32 = viewPurchaseOrder.FocusedRowHandle
        With ds.Tables("PurchaseOrder")
            .Rows(i)("M_Code") = ViewMaterial.GetFocusedRowCellValue("M_Code").ToString
            .Rows(i)("M_Name") = ViewMaterial.GetFocusedRowCellValue("M_Name").ToString
            .Rows(i)("M_Gauge") = ViewMaterial.GetFocusedRowCellValue("M_Gauge").ToString
            .Rows(i)("M_Unit") = ViewMaterial.GetFocusedRowCellValue("M_Unit").ToString
            .Rows(i)("Source") = ViewMaterial.GetFocusedRowCellValue("MC_Source").ToString
        End With
        pccMaterial.OwnerEdit.ClosePopup()
        btnSave.Focus()
    End Sub
#End Region

#Region "保存、退出事件"

#Region "保存前檢查輸入數據是否正確"
    Private Function CheckSave() As Boolean
        Dim bo As Boolean = False
        CheckSave = True
        If gluPR.EditValue = Nothing Then
            MsgBox("請選擇采購單號", MsgBoxStyle.Information, "提示")
            gluPR.Focus()
            bo = True
        ElseIf gluSupplier.EditValue = Nothing Then
            MsgBox("請選擇供應商", MsgBoxStyle.Information, "提示")
            gluSupplier.Focus()
            bo = True
        ElseIf gluDept.EditValue = Nothing Then
            MsgBox("請選擇部門", MsgBoxStyle.Information, "提示")
            gluDept.Focus()
            bo = True
        ElseIf gluUserID.EditValue = Nothing Then
            MsgBox("請選擇請購人員", MsgBoxStyle.Information, "提示")
            gluUserID.Focus()
            bo = True
        ElseIf dteRequestDate.EditValue = Nothing Then
            MsgBox("請選擇請購日期", MsgBoxStyle.Information, "提示")
            dteRequestDate.Focus()
            bo = True
        ElseIf gluWareHouse.EditValue = Nothing Then
            MsgBox("請選擇進貨倉庫", MsgBoxStyle.Information, "提示")
            gluWareHouse.Focus()
            bo = True
        ElseIf ds.Tables("PurchaseOrder").Rows.Count < 1 Then
            MsgBox("物料明細為空，無法保存", MsgBoxStyle.Information, "提示")
            GridPurchaseOrder.Focus()
            bo = True
        ElseIf EditItem = EditEnumType.CHECK And boCheck = chkCheck.Checked Then
            MsgBox("審核狀態沒有變化，無法保存", MsgBoxStyle.Information, "提示")
            chkCheck.Focus()
            bo = True
        End If
        If bo = True Then
            CheckSave = False
            Exit Function
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("PurchaseOrder").Rows.Count - 1
            If IsDBNull(ds.Tables("PurchaseOrder").Rows(i)("M_Code")) Then
                MsgBox("無法保存，物料明細中存在產品編碼為空的資料行", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf ds.Tables("PurchaseOrder").Rows(i)("PurchaseQty") = 0 Then
                MsgBox("無法保存，物料明細中存在請購數量為0的資料行", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf ds.Tables("PurchaseOrder").Rows(i)("UnitPrice") = 0 Then
                MsgBox("無法保存，物料明細中存在單價為0的資料行", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf IsDBNull(ds.Tables("PurchaseOrder").Rows(i)("NeedDate")) Then
                MsgBox("無法保存，物料明細中存在需求日期為空的資料行", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf IsDBNull(ds.Tables("PurchaseOrder").Rows(i)("DeliveryDate")) Then
                MsgBox("無法保存，物料明細中存在預定交期為空的資料行", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf ds.Tables("PurchaseOrder").Rows(i)("NeedDate") > ds.Tables("PurchaseOrder").Rows(i)("DeliveryDate") Then
                MsgBox("無法保存，物料明細中需求日期大於預定交期", MsgBoxStyle.Information, "提示")
                bo = True
            End If

            If bo = True Then
                viewPurchaseOrder.FocusedRowHandle = i
                CheckSave = False
                Exit Function
            End If

        Next
    End Function
#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (CheckSave() = False) Then
            Exit Sub
        End If

        Select Case EditItem
            Case EditEnumType.ADD
                SaveData(EditEnumType.ADD)
            Case EditEnumType.EDIT
                SaveData(EditEnumType.EDIT)
            Case EditEnumType.CHECK
                Dim mpoi As New MrpPurchaseOrderInfo
                mpoi.PO = txtPO.EditValue
                mpoi.CheckBit = chkCheck.Checked
                mpoi.CheckUserID = InUserID
                mpoi.CheckRemark = txtCheckRemark.Text
                If mpoc.MrpPurchaseOrder_UpdateCheck(mpoi) = True Then
                    MsgBox("審核狀態修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("審核狀態修改失敗", MsgBoxStyle.Information, "提示")
                End If
            Case EditEnumType.RECHECK
                Dim mpoi As New MrpPurchaseOrderInfo
                mpoi.PO = txtPO.EditValue
                mpoi.ReCheckBit = chkCheck.Checked
                mpoi.ReCheckUserID = InUserID
                mpoi.ReCheckRemark = txtCheckRemark.Text
                If mpoc.MrpPurchaseOrder_UpdateCheck(mpoi) = True Then
                    MsgBox("復核狀態修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("復核狀態修改失敗", MsgBoxStyle.Information, "提示")
                End If
        End Select
        Me.Close()
    End Sub

    Private Sub SaveData(ByVal editItem As String)
        Try
            Dim result As Boolean = True
            Dim mpoi As New MrpPurchaseOrderInfo
            mpoi.PR = gluPR.EditValue.ToString
            mpoi.DeptID = gluDept.EditValue.ToString
            mpoi.SupplierID = gluSupplier.EditValue.ToString
            mpoi.RequestUserID = gluUserID.EditValue
            mpoi.RequestDate = dteRequestDate.EditValue
            mpoi.Remarks = txtRemarks.EditValue
            mpoi.WareHouseID = gluWareHouse.EditValue
            mpoi.IsUrgency = chkIsUrgency.Checked
            If editItem = EditEnumType.ADD Then
                txtPO.EditValue = mpoc.MrpPurchaseOrder_GetID()
                mpoi.PO = txtPO.EditValue.ToString
                mpoi.CreateUserID = InUserID
                result = mpoc.MrpPurchaseOrder_Add(mpoi) And result
            ElseIf editItem = EditEnumType.EDIT Then
                mpoi.PO = txtPO.EditValue.ToString
                mpoi.ModifyUserID = InUserID
                result = mpoc.MrpPurchaseOrder_Update(mpoi) And result
            End If

            If editItem = EditEnumType.EDIT Then
                If String.IsNullOrEmpty(DelAutoID) = False Then
                    Dim array1 As String()
                    array1 = DelAutoID.Split(",")
                    For x As Int16 = 0 To array1.Length - 2
                        mpoec.MrpPurchaseOrderEntry_Delete(array1(x), Nothing)
                    Next
                End If
            End If
            If ds.Tables("PurchaseOrder").Rows.Count > 0 Then
                Dim mpoei As New MrpPurchaseOrderEntryInfo
                Dim i As Integer
                For i = 0 To ds.Tables("PurchaseOrder").Rows.Count - 1
                    mpoei.AutoID = ds.Tables("PurchaseOrder").Rows(i)("AutoID").ToString
                    mpoei.PO = txtPO.EditValue.ToString
                    mpoei.M_Code = ds.Tables("PurchaseOrder").Rows(i)("M_Code").ToString
                    mpoei.PurchaseQty = ds.Tables("PurchaseOrder").Rows(i)("PurchaseQty").ToString
                    mpoei.UnitPrice = ds.Tables("PurchaseOrder").Rows(i)("UnitPrice").ToString
                    mpoei.NeedDate = CDate(ds.Tables("PurchaseOrder").Rows(i)("NeedDate"))
                    mpoei.DeliveryDate = CDate(ds.Tables("PurchaseOrder").Rows(i)("DeliveryDate"))
                    mpoei.Remarks = ds.Tables("PurchaseOrder").Rows(i)("Remarks").ToString
                    If editItem = EditEnumType.ADD Then                 '增加
                        mpoei.CreateUserID = InUserID
                        result = mpoec.MrpPurchaseOrderEntry_Add(mpoei) And result
                    ElseIf editItem = EditEnumType.EDIT Then                        '修改
                        mpoei.ModifyUserID = InUserID
                        If mpoei.AutoID = 0 Then
                            result = mpoec.MrpPurchaseOrderEntry_Add(mpoei) And result
                        Else
                            result = mpoec.MrpPurchaseOrderEntry_Update(mpoei) And result
                        End If
                    End If
                Next
            End If
            If editItem = EditEnumType.ADD And result = True Then
                MsgBox("保存成功", MsgBoxStyle.Information, "提示")
            ElseIf editItem = EditEnumType.EDIT And result = True Then
                MsgBox("修改成功", MsgBoxStyle.Information, "提示")
            ElseIf result = False Then
                MsgBox("數據保存失敗", MsgBoxStyle.Information, "提示")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpPurchaseOrder方法出錯")
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

#Region "數據值驗證"
    Private Sub RepositoryItemCalcEdit1_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemCalcEdit1.EditValueChanging
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
            Exit Sub
        End If
        Dim purchaseQty As Decimal = viewPurchaseOrder.GetFocusedRowCellValue("PurchaseQty")
        Dim unitPrice As Decimal = viewPurchaseOrder.GetFocusedRowCellValue("UnitPrice")
        If viewPurchaseOrder.FocusedColumn.FieldName = "PurchaseQty" Then
            purchaseQty = e.NewValue
        ElseIf viewPurchaseOrder.FocusedColumn.FieldName = "UnitPrice" Then
            unitPrice = e.NewValue
        End If
        viewPurchaseOrder.SetFocusedRowCellValue(TotalPrice, purchaseQty * unitPrice)
    End Sub
#End Region

#Region "選擇供應商帶出供應商的其它基本信息"
    Private Sub gluSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluSupplier.EditValueChanged
        txtPaymentType.EditValue = viewSupplier.GetFocusedRowCellValue("S_ToFrom")
        txtTel.EditValue = viewSupplier.GetFocusedRowCellValue("S_Tel")
        txtContacts.EditValue = viewSupplier.GetFocusedRowCellValue("S_Associate")
        txtCurrencyName.EditValue = viewSupplier.GetFocusedRowCellValue("CurrencyName")
        txtEmail.EditValue = viewSupplier.GetFocusedRowCellValue("S_Email")
        txtFax.EditValue = viewSupplier.GetFocusedRowCellValue("S_Fax")
    End Sub
#End Region

End Class