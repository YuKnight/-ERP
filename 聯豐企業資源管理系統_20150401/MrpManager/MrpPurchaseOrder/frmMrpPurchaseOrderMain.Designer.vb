<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpPurchaseOrderMain
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
        Me.lblinfo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsPurOrder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPurOrderAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPurOrderCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPurOrderRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_PrintMrpPurchaseOrder = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RequestDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeptID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RequestUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IsUrgency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReCheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsSub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsSubExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.viewPurchaseOrder = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemPceMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItempceCurrency = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPurOrder.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSub.SuspendLayout()
        CType(Me.viewPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItempceCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(4, 6)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(109, 21)
        Me.lblinfo.TabIndex = 240
        Me.lblinfo.Text = "MRP采購單"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1240, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 239
        Me.PictureBox1.TabStop = False
        '
        'grid1
        '
        Me.grid1.ContextMenuStrip = Me.cmsPurOrder
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EmbeddedNavigator.Name = ""
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.MainView = Me.GridView1
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(1236, 258)
        Me.grid1.TabIndex = 241
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsPurOrder
        '
        Me.cmsPurOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPurOrderAdd, Me.cmsPurOrderEdit, Me.cmsPurOrderDel, Me.cmsPurOrderView, Me.cmsPurOrderSelect, Me.ToolStripMenuItem1, Me.cmsPurOrderCheck, Me.cmsPurOrderReCheck, Me.ToolStripMenuItem2, Me.cmsPurOrderRefresh, Me.cmsPurOrderPrint, Me.cmsExcel})
        Me.cmsPurOrder.Name = "cmsMRP"
        Me.cmsPurOrder.Size = New System.Drawing.Size(166, 258)
        '
        'cmsPurOrderAdd
        '
        Me.cmsPurOrderAdd.Enabled = False
        Me.cmsPurOrderAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsPurOrderAdd.Name = "cmsPurOrderAdd"
        Me.cmsPurOrderAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsPurOrderAdd.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderAdd.Text = "新增(&A)"
        Me.cmsPurOrderAdd.Visible = False
        '
        'cmsPurOrderEdit
        '
        Me.cmsPurOrderEdit.Enabled = False
        Me.cmsPurOrderEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsPurOrderEdit.Name = "cmsPurOrderEdit"
        Me.cmsPurOrderEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsPurOrderEdit.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderEdit.Text = "修改(&E)"
        Me.cmsPurOrderEdit.Visible = False
        '
        'cmsPurOrderDel
        '
        Me.cmsPurOrderDel.Enabled = False
        Me.cmsPurOrderDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsPurOrderDel.Name = "cmsPurOrderDel"
        Me.cmsPurOrderDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsPurOrderDel.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderDel.Text = "刪除(&D)"
        Me.cmsPurOrderDel.Visible = False
        '
        'cmsPurOrderView
        '
        Me.cmsPurOrderView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsPurOrderView.Name = "cmsPurOrderView"
        Me.cmsPurOrderView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.cmsPurOrderView.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderView.Text = "查看(&V)"
        '
        'cmsPurOrderSelect
        '
        Me.cmsPurOrderSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsPurOrderSelect.Name = "cmsPurOrderSelect"
        Me.cmsPurOrderSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmsPurOrderSelect.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderSelect.Text = "查詢(&S)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 6)
        '
        'cmsPurOrderCheck
        '
        Me.cmsPurOrderCheck.Enabled = False
        Me.cmsPurOrderCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsPurOrderCheck.Name = "cmsPurOrderCheck"
        Me.cmsPurOrderCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsPurOrderCheck.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderCheck.Text = "審核(&F)"
        Me.cmsPurOrderCheck.Visible = False
        '
        'cmsPurOrderReCheck
        '
        Me.cmsPurOrderReCheck.Enabled = False
        Me.cmsPurOrderReCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsPurOrderReCheck.Name = "cmsPurOrderReCheck"
        Me.cmsPurOrderReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsPurOrderReCheck.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderReCheck.Text = "復審(&G)"
        Me.cmsPurOrderReCheck.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(162, 6)
        '
        'cmsPurOrderRefresh
        '
        Me.cmsPurOrderRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsPurOrderRefresh.Name = "cmsPurOrderRefresh"
        Me.cmsPurOrderRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsPurOrderRefresh.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderRefresh.Text = "刷新(&R)"
        '
        'cmsPurOrderPrint
        '
        Me.cmsPurOrderPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_PrintMrpPurchaseOrder})
        Me.cmsPurOrderPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPurOrderPrint.Name = "cmsPurOrderPrint"
        Me.cmsPurOrderPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPurOrderPrint.Size = New System.Drawing.Size(165, 22)
        Me.cmsPurOrderPrint.Text = "列印(&P)"
        '
        'tsm_PrintMrpPurchaseOrder
        '
        Me.tsm_PrintMrpPurchaseOrder.Name = "tsm_PrintMrpPurchaseOrder"
        Me.tsm_PrintMrpPurchaseOrder.Size = New System.Drawing.Size(172, 22)
        Me.tsm_PrintMrpPurchaseOrder.Text = "列印採購匯總信息"
        '
        'cmsExcel
        '
        Me.cmsExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsExcel.Name = "cmsExcel"
        Me.cmsExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsExcel.Size = New System.Drawing.Size(165, 22)
        Me.cmsExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.PO, Me.PR, Me.DeptName, Me.SupplierID, Me.SupplierName, Me.GridColumn3, Me.GridColumn4, Me.RequestDate, Me.DeptID, Me.RequestUserName, Me.IsUrgency, Me.CheckBit, Me.GridColumn5, Me.GridColumn6, Me.ReCheckBit, Me.GridColumn7, Me.GridColumn8, Me.CreateDate, Me.CreateUserName, Me.Remarks})
        Me.GridView1.GridControl = Me.grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.PO, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'PO
        '
        Me.PO.Caption = "采購單號"
        Me.PO.FieldName = "PO"
        Me.PO.Name = "PO"
        Me.PO.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.PO.Visible = True
        Me.PO.VisibleIndex = 0
        Me.PO.Width = 88
        '
        'PR
        '
        Me.PR.Caption = "請購單號"
        Me.PR.FieldName = "PR"
        Me.PR.Name = "PR"
        Me.PR.Visible = True
        Me.PR.VisibleIndex = 1
        Me.PR.Width = 84
        '
        'DeptName
        '
        Me.DeptName.Caption = "請購部門"
        Me.DeptName.FieldName = "DeptName"
        Me.DeptName.Name = "DeptName"
        Me.DeptName.Visible = True
        Me.DeptName.VisibleIndex = 2
        '
        'SupplierID
        '
        Me.SupplierID.Caption = "供應商編碼"
        Me.SupplierID.FieldName = "SupplierID"
        Me.SupplierID.Name = "SupplierID"
        '
        'SupplierName
        '
        Me.SupplierName.Caption = "供應商名稱"
        Me.SupplierName.FieldName = "SupplierName"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Visible = True
        Me.SupplierName.VisibleIndex = 3
        Me.SupplierName.Width = 138
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "幣別"
        Me.GridColumn3.FieldName = "CurrencyName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "付款方式"
        Me.GridColumn4.FieldName = "PaymentType"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'RequestDate
        '
        Me.RequestDate.Caption = "請購日期"
        Me.RequestDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RequestDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RequestDate.FieldName = "RequestDate"
        Me.RequestDate.Name = "RequestDate"
        Me.RequestDate.Width = 83
        '
        'DeptID
        '
        Me.DeptID.Caption = "DeptID"
        Me.DeptID.FieldName = "DeptID"
        Me.DeptID.Name = "DeptID"
        '
        'RequestUserName
        '
        Me.RequestUserName.Caption = "請購人員"
        Me.RequestUserName.FieldName = "RequestUserName"
        Me.RequestUserName.Name = "RequestUserName"
        '
        'IsUrgency
        '
        Me.IsUrgency.Caption = "是否緊急"
        Me.IsUrgency.FieldName = "IsUrgency"
        Me.IsUrgency.Name = "IsUrgency"
        Me.IsUrgency.Visible = True
        Me.IsUrgency.VisibleIndex = 6
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 7
        Me.CheckBit.Width = 44
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "審核人員"
        Me.GridColumn5.FieldName = "CheckUserName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "審核備注"
        Me.GridColumn6.FieldName = "CheckRemark"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 9
        Me.GridColumn6.Width = 119
        '
        'ReCheckBit
        '
        Me.ReCheckBit.Caption = "復審"
        Me.ReCheckBit.FieldName = "ReCheckBit"
        Me.ReCheckBit.Name = "ReCheckBit"
        Me.ReCheckBit.Visible = True
        Me.ReCheckBit.VisibleIndex = 10
        Me.ReCheckBit.Width = 48
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "復審人員"
        Me.GridColumn7.FieldName = "ReCheckUserName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 11
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "復審備注"
        Me.GridColumn8.FieldName = "ReCheckRemark"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 12
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建日期"
        Me.CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建人員"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        '
        'Remarks
        '
        Me.Remarks.Caption = "備注"
        Me.Remarks.FieldName = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Visible = True
        Me.Remarks.VisibleIndex = 13
        Me.Remarks.Width = 139
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grid1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1240, 452)
        Me.SplitContainerControl1.SplitterPosition = 262
        Me.SplitContainerControl1.TabIndex = 242
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsSub
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.viewPurchaseOrder
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemPceMaterial, Me.ItempceCurrency, Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1236, 180)
        Me.GridControl1.TabIndex = 244
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewPurchaseOrder})
        '
        'cmsSub
        '
        Me.cmsSub.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsSubExcel})
        Me.cmsSub.Name = "cmsBom_D"
        Me.cmsSub.Size = New System.Drawing.Size(162, 26)
        '
        'cmsSubExcel
        '
        Me.cmsSubExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsSubExcel.Name = "cmsSubExcel"
        Me.cmsSubExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.cmsSubExcel.Size = New System.Drawing.Size(161, 22)
        Me.cmsSubExcel.Text = "Excel(&L)"
        '
        'viewPurchaseOrder
        '
        Me.viewPurchaseOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.GridColumn2, Me.PurchaseQty, Me.UnitPrice, Me.GridColumn9, Me.NeedDate, Me.GridColumn10, Me.GridColumn17})
        Me.viewPurchaseOrder.GridControl = Me.GridControl1
        Me.viewPurchaseOrder.Name = "viewPurchaseOrder"
        Me.viewPurchaseOrder.OptionsBehavior.Editable = False
        Me.viewPurchaseOrder.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewPurchaseOrder.OptionsView.ColumnAutoWidth = False
        Me.viewPurchaseOrder.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "AutoID"
        Me.GridColumn1.FieldName = "AutoID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.ColumnEdit = Me.ItemPceMaterial
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 143
        '
        'ItemPceMaterial
        '
        Me.ItemPceMaterial.AutoHeight = False
        Me.ItemPceMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemPceMaterial.Name = "ItemPceMaterial"
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 130
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 140
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "物料單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "來源碼"
        Me.GridColumn2.FieldName = "Source"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'PurchaseQty
        '
        Me.PurchaseQty.Caption = "采購數量"
        Me.PurchaseQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PurchaseQty.FieldName = "PurchaseQty"
        Me.PurchaseQty.Name = "PurchaseQty"
        Me.PurchaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PurchaseQty.Visible = True
        Me.PurchaseQty.VisibleIndex = 5
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "金額"
        Me.GridColumn9.FieldName = "TotalPrice"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'NeedDate
        '
        Me.NeedDate.Caption = "需求日期"
        Me.NeedDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NeedDate.FieldName = "NeedDate"
        Me.NeedDate.Name = "NeedDate"
        Me.NeedDate.Visible = True
        Me.NeedDate.VisibleIndex = 8
        Me.NeedDate.Width = 84
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "預定交期"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn10.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn10.FieldName = "DeliveryDate"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "備注"
        Me.GridColumn17.FieldName = "Remarks"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 10
        Me.GridColumn17.Width = 203
        '
        'ItempceCurrency
        '
        Me.ItempceCurrency.AutoHeight = False
        Me.ItempceCurrency.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItempceCurrency.Name = "ItempceCurrency"
        '
        'frmMrpPurchaseOrderMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 484)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpPurchaseOrderMain"
        Me.Text = "MRP采購單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPurOrder.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSub.ResumeLayout(False)
        CType(Me.viewPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItempceCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequestUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReCheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsPurOrder As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsPurOrderAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurOrderEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurOrderDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPurOrderView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurOrderRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPurOrderCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurOrderPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewPurchaseOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemPceMaterial As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ItempceCurrency As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeptID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsPurOrderReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsPurOrderSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IsUrgency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_PrintMrpPurchaseOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsSubExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsExcel As System.Windows.Forms.ToolStripMenuItem
End Class
