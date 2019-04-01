<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdersSubNeedMain
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
        Me.components = New System.ComponentModel.Container
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsSalesDptCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOperationDptCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsExport = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ON_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Weight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_CodeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_PrepareQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedPurchaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_ReallyPurchaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_PurchaseReturnQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_TakeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_PurchaseState = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_SalesDptCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ON_OperationDptCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Appearance.Options.UseForeColor = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(115, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "批次需求單"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(769, 37)
        Me.PanelControl1.TabIndex = 3
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(769, 510)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsDelete, Me.cmsSalesDptCheck, Me.cmsOperationDptCheck, Me.cmsRef, Me.cmsView, Me.cmsFind, Me.cmsExport, Me.cmsPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(226, 202)
        '
        'cmsDelete
        '
        Me.cmsDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDelete.Size = New System.Drawing.Size(225, 22)
        Me.cmsDelete.Text = "刪除(&D)"
        '
        'cmsSalesDptCheck
        '
        Me.cmsSalesDptCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsSalesDptCheck.Name = "cmsSalesDptCheck"
        Me.cmsSalesDptCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsSalesDptCheck.Size = New System.Drawing.Size(225, 22)
        Me.cmsSalesDptCheck.Text = "營業部審核(&G)..."
        '
        'cmsOperationDptCheck
        '
        Me.cmsOperationDptCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsOperationDptCheck.Name = "cmsOperationDptCheck"
        Me.cmsOperationDptCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmsOperationDptCheck.Size = New System.Drawing.Size(225, 22)
        Me.cmsOperationDptCheck.Text = "營運部審核(&T)..."
        '
        'cmsRef
        '
        Me.cmsRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsRef.Name = "cmsRef"
        Me.cmsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsRef.Size = New System.Drawing.Size(225, 22)
        Me.cmsRef.Text = "刷新(&R)"
        '
        'cmsView
        '
        Me.cmsView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsView.Name = "cmsView"
        Me.cmsView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsView.Size = New System.Drawing.Size(225, 22)
        Me.cmsView.Text = "查看(&W)..."
        '
        'cmsFind
        '
        Me.cmsFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsFind.Size = New System.Drawing.Size(225, 22)
        Me.cmsFind.Text = "查詢(&F)..."
        '
        'cmsExport
        '
        Me.cmsExport.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.cmsExport.Name = "cmsExport"
        Me.cmsExport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.cmsExport.Size = New System.Drawing.Size(225, 22)
        Me.cmsExport.Text = "導出(&L)"
        '
        'cmsPrint
        '
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(225, 22)
        Me.cmsPrint.Text = "列印(&P)"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ON_ID, Me.OS_BatchID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.OS_Qty, Me.M_Weight, Me.ON_NeedQty, Me.M_CodeType, Me.WI_Qty, Me.ON_PrepareQty, Me.ON_NeedPurchaseQty, Me.ON_ReallyPurchaseQty, Me.ON_PurchaseReturnQty, Me.ON_TakeQty, Me.ON_PurchaseState, Me.ON_Remark, Me.ON_AddDate, Me.ON_SalesDptCheck, Me.ON_OperationDptCheck})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "拖動列表頭到此處可進行分組"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OS_BatchID", Me.OS_BatchID, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ON_NeedQty", Me.ON_NeedQty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ON_NeedPurchaseQty", Me.ON_NeedPurchaseQty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ON_ReallyPurchaseQty", Me.ON_ReallyPurchaseQty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ON_PurchaseReturnQty", Me.ON_PurchaseReturnQty, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'ON_ID
        '
        Me.ON_ID.Caption = "需求單號"
        Me.ON_ID.FieldName = "ON_ID"
        Me.ON_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.ON_ID.Name = "ON_ID"
        Me.ON_ID.OptionsColumn.ReadOnly = True
        Me.ON_ID.Visible = True
        Me.ON_ID.VisibleIndex = 0
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.OptionsColumn.ReadOnly = True
        Me.OS_BatchID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 5
        Me.M_Unit.Width = 55
        '
        'OS_Qty
        '
        Me.OS_Qty.AppearanceCell.Options.UseTextOptions = True
        Me.OS_Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OS_Qty.Caption = "批次數量"
        Me.OS_Qty.FieldName = "OS_Qty"
        Me.OS_Qty.Name = "OS_Qty"
        Me.OS_Qty.OptionsColumn.ReadOnly = True
        Me.OS_Qty.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.OS_Qty.Visible = True
        Me.OS_Qty.VisibleIndex = 6
        '
        'M_Weight
        '
        Me.M_Weight.AppearanceCell.Options.UseTextOptions = True
        Me.M_Weight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.M_Weight.Caption = "用量"
        Me.M_Weight.FieldName = "M_Weight"
        Me.M_Weight.Name = "M_Weight"
        Me.M_Weight.OptionsColumn.ReadOnly = True
        Me.M_Weight.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.M_Weight.Visible = True
        Me.M_Weight.VisibleIndex = 7
        Me.M_Weight.Width = 55
        '
        'ON_NeedQty
        '
        Me.ON_NeedQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_NeedQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_NeedQty.Caption = "理論需求數"
        Me.ON_NeedQty.FieldName = "ON_NeedQty"
        Me.ON_NeedQty.Name = "ON_NeedQty"
        Me.ON_NeedQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_NeedQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_NeedQty.Visible = True
        Me.ON_NeedQty.VisibleIndex = 8
        Me.ON_NeedQty.Width = 85
        '
        'M_CodeType
        '
        Me.M_CodeType.Caption = "配件類型"
        Me.M_CodeType.FieldName = "M_CodeType"
        Me.M_CodeType.Name = "M_CodeType"
        Me.M_CodeType.OptionsColumn.ReadOnly = True
        Me.M_CodeType.Visible = True
        Me.M_CodeType.VisibleIndex = 9
        '
        'WI_Qty
        '
        Me.WI_Qty.AppearanceCell.Options.UseTextOptions = True
        Me.WI_Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.WI_Qty.Caption = "當前庫存數"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.WI_Qty.Width = 85
        '
        'ON_PrepareQty
        '
        Me.ON_PrepareQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_PrepareQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_PrepareQty.Caption = "可備料數"
        Me.ON_PrepareQty.FieldName = "ON_PrepareQty"
        Me.ON_PrepareQty.Name = "ON_PrepareQty"
        Me.ON_PrepareQty.OptionsColumn.ReadOnly = True
        Me.ON_PrepareQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_PrepareQty.Visible = True
        Me.ON_PrepareQty.VisibleIndex = 10
        '
        'ON_NeedPurchaseQty
        '
        Me.ON_NeedPurchaseQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_NeedPurchaseQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_NeedPurchaseQty.Caption = "需採購數"
        Me.ON_NeedPurchaseQty.FieldName = "ON_NeedPurchaseQty"
        Me.ON_NeedPurchaseQty.Name = "ON_NeedPurchaseQty"
        Me.ON_NeedPurchaseQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedPurchaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_NeedPurchaseQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_NeedPurchaseQty.Visible = True
        Me.ON_NeedPurchaseQty.VisibleIndex = 11
        '
        'ON_ReallyPurchaseQty
        '
        Me.ON_ReallyPurchaseQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_ReallyPurchaseQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_ReallyPurchaseQty.Caption = "實際採購數"
        Me.ON_ReallyPurchaseQty.FieldName = "ON_ReallyPurchaseQty"
        Me.ON_ReallyPurchaseQty.Name = "ON_ReallyPurchaseQty"
        Me.ON_ReallyPurchaseQty.OptionsColumn.ReadOnly = True
        Me.ON_ReallyPurchaseQty.SummaryItem.FieldName = "ON_PurchaseQty"
        Me.ON_ReallyPurchaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_ReallyPurchaseQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_ReallyPurchaseQty.Width = 85
        '
        'ON_PurchaseReturnQty
        '
        Me.ON_PurchaseReturnQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_PurchaseReturnQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_PurchaseReturnQty.Caption = "採購已回數"
        Me.ON_PurchaseReturnQty.FieldName = "ON_PurchaseReturnQty"
        Me.ON_PurchaseReturnQty.Name = "ON_PurchaseReturnQty"
        Me.ON_PurchaseReturnQty.OptionsColumn.ReadOnly = True
        Me.ON_PurchaseReturnQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_PurchaseReturnQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_PurchaseReturnQty.Visible = True
        Me.ON_PurchaseReturnQty.VisibleIndex = 12
        Me.ON_PurchaseReturnQty.Width = 85
        '
        'ON_TakeQty
        '
        Me.ON_TakeQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_TakeQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_TakeQty.Caption = "已領取數"
        Me.ON_TakeQty.FieldName = "ON_TakeQty"
        Me.ON_TakeQty.Name = "ON_TakeQty"
        Me.ON_TakeQty.OptionsColumn.ReadOnly = True
        Me.ON_TakeQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_TakeQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_TakeQty.Visible = True
        Me.ON_TakeQty.VisibleIndex = 13
        '
        'ON_PurchaseState
        '
        Me.ON_PurchaseState.Caption = "採購狀態"
        Me.ON_PurchaseState.FieldName = "ON_PurchaseState"
        Me.ON_PurchaseState.Name = "ON_PurchaseState"
        Me.ON_PurchaseState.OptionsColumn.ReadOnly = True
        Me.ON_PurchaseState.Visible = True
        Me.ON_PurchaseState.VisibleIndex = 14
        '
        'ON_Remark
        '
        Me.ON_Remark.Caption = "備注"
        Me.ON_Remark.FieldName = "ON_Remark"
        Me.ON_Remark.Name = "ON_Remark"
        Me.ON_Remark.OptionsColumn.ReadOnly = True
        Me.ON_Remark.Width = 100
        '
        'ON_AddDate
        '
        Me.ON_AddDate.Caption = "建立日期"
        Me.ON_AddDate.FieldName = "ON_AddDate"
        Me.ON_AddDate.Name = "ON_AddDate"
        Me.ON_AddDate.OptionsColumn.ReadOnly = True
        Me.ON_AddDate.Visible = True
        Me.ON_AddDate.VisibleIndex = 15
        '
        'ON_SalesDptCheck
        '
        Me.ON_SalesDptCheck.Caption = "營業部審核"
        Me.ON_SalesDptCheck.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ON_SalesDptCheck.FieldName = "ON_SalesDptCheck"
        Me.ON_SalesDptCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ON_SalesDptCheck.Name = "ON_SalesDptCheck"
        Me.ON_SalesDptCheck.OptionsColumn.ReadOnly = True
        Me.ON_SalesDptCheck.Visible = True
        Me.ON_SalesDptCheck.VisibleIndex = 16
        Me.ON_SalesDptCheck.Width = 85
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ON_OperationDptCheck
        '
        Me.ON_OperationDptCheck.Caption = "營運部審核"
        Me.ON_OperationDptCheck.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.ON_OperationDptCheck.FieldName = "ON_OperationDptCheck"
        Me.ON_OperationDptCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ON_OperationDptCheck.Name = "ON_OperationDptCheck"
        Me.ON_OperationDptCheck.OptionsColumn.ReadOnly = True
        Me.ON_OperationDptCheck.Visible = True
        Me.ON_OperationDptCheck.VisibleIndex = 17
        Me.ON_OperationDptCheck.Width = 85
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmOrdersSubNeedMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 547)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmOrdersSubNeedMain"
        Me.Text = "批次需求單"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_CodeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_PrepareQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedPurchaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_ReallyPurchaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_PurchaseReturnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_TakeQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_SalesDptCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_OperationDptCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSalesDptCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOperationDptCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ON_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ON_PurchaseState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_AddDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
