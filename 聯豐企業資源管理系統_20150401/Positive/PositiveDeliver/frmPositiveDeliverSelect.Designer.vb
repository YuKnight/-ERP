<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPositiveDeliverSelect
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgPositiveOrders = New DevExpress.XtraGrid.GridControl
        Me.dgvPositiveOrders = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Input = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PartNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.P_OM_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rGrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.r_PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Type3Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCalcEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.cmdInput = New DevExpress.XtraEditors.SimpleButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.gluP_OM_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CP_OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.dgPositiveOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPositiveOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPositiveOrders
        '
        Me.dgPositiveOrders.EmbeddedNavigator.Name = ""
        Me.dgPositiveOrders.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dgPositiveOrders.Location = New System.Drawing.Point(3, 40)
        Me.dgPositiveOrders.MainView = Me.dgvPositiveOrders
        Me.dgPositiveOrders.Name = "dgPositiveOrders"
        Me.dgPositiveOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.rGrid, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemCalcEdit4, Me.RepositoryItemCalcEdit5, Me.RepositoryItemCalcEdit6})
        Me.dgPositiveOrders.Size = New System.Drawing.Size(583, 266)
        Me.dgPositiveOrders.TabIndex = 48
        Me.dgPositiveOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvPositiveOrders})
        '
        'dgvPositiveOrders
        '
        Me.dgvPositiveOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Input, Me.P_OM_CusterPO, Me.P_M_Code, Me.PartNumber, Me.P_OM_ID, Me.Qty, Me.NoSendQty, Me.P_OM_Num})
        Me.dgvPositiveOrders.GridControl = Me.dgPositiveOrders
        Me.dgvPositiveOrders.Name = "dgvPositiveOrders"
        Me.dgvPositiveOrders.OptionsCustomization.AllowColumnMoving = False
        Me.dgvPositiveOrders.OptionsCustomization.AllowFilter = False
        Me.dgvPositiveOrders.OptionsCustomization.AllowSort = False
        Me.dgvPositiveOrders.OptionsFilter.AllowColumnMRUFilterList = False
        Me.dgvPositiveOrders.OptionsFilter.AllowFilterEditor = False
        Me.dgvPositiveOrders.OptionsFilter.AllowMRUFilterList = False
        Me.dgvPositiveOrders.OptionsNavigation.AutoFocusNewRow = True
        Me.dgvPositiveOrders.OptionsNavigation.UseTabKey = False
        Me.dgvPositiveOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgvPositiveOrders.OptionsSelection.UseIndicatorForSelection = False
        Me.dgvPositiveOrders.OptionsView.ColumnAutoWidth = False
        Me.dgvPositiveOrders.OptionsView.RowAutoHeight = True
        Me.dgvPositiveOrders.OptionsView.ShowGroupPanel = False
        '
        'Input
        '
        Me.Input.Caption = "加入"
        Me.Input.FieldName = "Input"
        Me.Input.Name = "Input"
        Me.Input.Visible = True
        Me.Input.VisibleIndex = 0
        Me.Input.Width = 50
        '
        'P_OM_CusterPO
        '
        Me.P_OM_CusterPO.Caption = "客戶PO"
        Me.P_OM_CusterPO.FieldName = "P_OM_CusterPO"
        Me.P_OM_CusterPO.Name = "P_OM_CusterPO"
        Me.P_OM_CusterPO.OptionsColumn.AllowEdit = False
        Me.P_OM_CusterPO.Visible = True
        Me.P_OM_CusterPO.VisibleIndex = 1
        Me.P_OM_CusterPO.Width = 100
        '
        'P_M_Code
        '
        Me.P_M_Code.Caption = "產品編號"
        Me.P_M_Code.FieldName = "P_M_Code"
        Me.P_M_Code.Name = "P_M_Code"
        Me.P_M_Code.OptionsColumn.AllowEdit = False
        Me.P_M_Code.Visible = True
        Me.P_M_Code.VisibleIndex = 2
        Me.P_M_Code.Width = 114
        '
        'PartNumber
        '
        Me.PartNumber.Caption = "料號"
        Me.PartNumber.FieldName = "PartNumber"
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.OptionsColumn.AllowEdit = False
        Me.PartNumber.Visible = True
        Me.PartNumber.VisibleIndex = 3
        Me.PartNumber.Width = 121
        '
        'P_OM_ID
        '
        Me.P_OM_ID.Caption = "訂單編號"
        Me.P_OM_ID.FieldName = "P_OM_ID"
        Me.P_OM_ID.Name = "P_OM_ID"
        Me.P_OM_ID.OptionsColumn.AllowEdit = False
        '
        'Qty
        '
        Me.Qty.Caption = "訂單數量"
        Me.Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 4
        Me.Qty.Width = 79
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'NoSendQty
        '
        Me.NoSendQty.Caption = "未交數"
        Me.NoSendQty.ColumnEdit = Me.RepositoryItemCalcEdit4
        Me.NoSendQty.FieldName = "NoSendQty"
        Me.NoSendQty.Name = "NoSendQty"
        Me.NoSendQty.OptionsColumn.AllowEdit = False
        Me.NoSendQty.Visible = True
        Me.NoSendQty.VisibleIndex = 5
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'P_OM_Num
        '
        Me.P_OM_Num.Caption = "訂單流水號"
        Me.P_OM_Num.FieldName = "P_OM_Num"
        Me.P_OM_Num.Name = "P_OM_Num"
        Me.P_OM_Num.OptionsColumn.AllowEdit = False
        Me.P_OM_Num.Width = 100
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.DisplayFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit2.EditFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit2.Mask.EditMask = "f"
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'rGrid
        '
        Me.rGrid.AutoHeight = False
        Me.rGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rGrid.Name = "rGrid"
        Me.rGrid.NullText = ""
        Me.rGrid.PopupFormWidth = 500
        Me.rGrid.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.r_PM_M_Code, Me.GridColumn2, Me.PM_CusterNO, Me.M_Gauge, Me.Type3Name})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'r_PM_M_Code
        '
        Me.r_PM_M_Code.Caption = "產品編號"
        Me.r_PM_M_Code.FieldName = "PM_M_Code"
        Me.r_PM_M_Code.Name = "r_PM_M_Code"
        Me.r_PM_M_Code.Visible = True
        Me.r_PM_M_Code.VisibleIndex = 0
        Me.r_PM_M_Code.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品類別"
        Me.GridColumn2.FieldName = "PM_JiYu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'PM_CusterNO
        '
        Me.PM_CusterNO.Caption = "客戶編號"
        Me.PM_CusterNO.FieldName = "PM_CusterNO"
        Me.PM_CusterNO.Name = "PM_CusterNO"
        Me.PM_CusterNO.Visible = True
        Me.PM_CusterNO.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'Type3Name
        '
        Me.Type3Name.Caption = "名稱"
        Me.Type3Name.FieldName = "Type3Name"
        Me.Type3Name.Name = "Type3Name"
        Me.Type3Name.Visible = True
        Me.Type3Name.VisibleIndex = 4
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'RepositoryItemCalcEdit5
        '
        Me.RepositoryItemCalcEdit5.AutoHeight = False
        Me.RepositoryItemCalcEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit5.Name = "RepositoryItemCalcEdit5"
        '
        'RepositoryItemCalcEdit6
        '
        Me.RepositoryItemCalcEdit6.AutoHeight = False
        Me.RepositoryItemCalcEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit6.Name = "RepositoryItemCalcEdit6"
        '
        'cmdInput
        '
        Me.cmdInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInput.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdInput.Appearance.Options.UseFont = True
        Me.cmdInput.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdInput.Location = New System.Drawing.Point(275, 2)
        Me.cmdInput.Name = "cmdInput"
        Me.cmdInput.Size = New System.Drawing.Size(80, 28)
        Me.cmdInput.TabIndex = 51
        Me.cmdInput.Text = "導入(&I)"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "訂單編號(&I):"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(498, 312)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 53
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(397, 312)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 52
        Me.cmdSave.Text = "確定(&O)"
        '
        'gluP_OM_ID
        '
        Me.gluP_OM_ID.EditValue = ""
        Me.gluP_OM_ID.EnterMoveNextControl = True
        Me.gluP_OM_ID.Location = New System.Drawing.Point(107, 6)
        Me.gluP_OM_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.gluP_OM_ID.Name = "gluP_OM_ID"
        Me.gluP_OM_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluP_OM_ID.Properties.Appearance.Options.UseFont = True
        Me.gluP_OM_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluP_OM_ID.Properties.NullText = ""
        Me.gluP_OM_ID.Properties.View = Me.GridLookUpEdit1View
        Me.gluP_OM_ID.Size = New System.Drawing.Size(150, 24)
        Me.gluP_OM_ID.TabIndex = 54
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CP_OM_ID})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'CP_OM_ID
        '
        Me.CP_OM_ID.Caption = "訂單編號"
        Me.CP_OM_ID.FieldName = "P_OM_ID"
        Me.CP_OM_ID.Name = "CP_OM_ID"
        Me.CP_OM_ID.Visible = True
        Me.CP_OM_ID.VisibleIndex = 0
        '
        'frmPositiveDeliverSelect
        '
        Me.AcceptButton = Me.cmdExit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.gluP_OM_ID)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgPositiveOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPositiveDeliverSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "導入訂貨單"
        CType(Me.dgPositiveOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPositiveOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPositiveOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvPositiveOrders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents P_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rGrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents r_PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type3Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents P_OM_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents cmdInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gluP_OM_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CP_OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
End Class
