<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpMaterialCodeMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Supplier = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Stock = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdReflash = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_LowLimit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_SecInv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_MRPCon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WareHouseRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_BatchQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_BatFixEconomy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderInterVal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderMan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit27 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit40 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit38 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit39 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMRUEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemMemoEdit28 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoExEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit41 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsSub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsSubExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.CurrencyName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EconomicQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.MaxQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MinQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ResponsibleUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Contacts = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PaymentType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Email = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MrpSQID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.MI_NeedDateITEM = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MI_NeedDateRIDE = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSub.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MI_NeedDateITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(4, 6)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(153, 21)
        Me.lblinfo.TabIndex = 88
        Me.lblinfo.Text = "MRP物料編碼表"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit27, Me.RepositoryItemButtonEdit14, Me.RepositoryItemCalcEdit15, Me.RepositoryItemTextEdit14, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit13, Me.RepositoryItemDateEdit40, Me.RepositoryItemDateEdit38, Me.RepositoryItemDateEdit39, Me.RepositoryItemMRUEdit13, Me.RepositoryItemMemoEdit28, Me.RepositoryItemMemoExEdit15, Me.RepositoryItemDateEdit41, Me.RepositoryItemTimeEdit1, Me.RepositoryItemCheckEdit2})
        Me.Grid.Size = New System.Drawing.Size(1205, 248)
        Me.Grid.TabIndex = 89
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.cmdFind, Me.cmdLook, Me.ToolStripSeparator1, Me.cmdCheck, Me.tsm_Supplier, Me.tsm_Stock, Me.ToolStripSeparator2, Me.cmdReflash, Me.cmdPrint, Me.cmsExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(201, 280)
        Me.ContextMenuStrip1.Text = "新增(&A)"
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(200, 22)
        Me.cmdAdd.Text = "新增(&A)"
        Me.cmdAdd.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(200, 22)
        Me.cmdEdit.Text = "修改(&E)"
        Me.cmdEdit.Visible = False
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(200, 22)
        Me.cmdDel.Text = "刪除(&D)"
        Me.cmdDel.Visible = False
        '
        'cmdFind
        '
        Me.cmdFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdFind.Size = New System.Drawing.Size(200, 22)
        Me.cmdFind.Text = "查詢(F)"
        '
        'cmdLook
        '
        Me.cmdLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdLook.Name = "cmdLook"
        Me.cmdLook.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdLook.Size = New System.Drawing.Size(200, 22)
        Me.cmdLook.Text = "查看(&W)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(200, 22)
        Me.cmdCheck.Text = "審核(&G)"
        Me.cmdCheck.Visible = False
        '
        'tsm_Supplier
        '
        Me.tsm_Supplier.Enabled = False
        Me.tsm_Supplier.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.tsm_Supplier.Name = "tsm_Supplier"
        Me.tsm_Supplier.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsm_Supplier.Size = New System.Drawing.Size(200, 22)
        Me.tsm_Supplier.Text = "供應商設置(&O)"
        Me.tsm_Supplier.Visible = False
        '
        'tsm_Stock
        '
        Me.tsm_Stock.Enabled = False
        Me.tsm_Stock.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.tsm_Stock.Name = "tsm_Stock"
        Me.tsm_Stock.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsm_Stock.Size = New System.Drawing.Size(200, 22)
        Me.tsm_Stock.Text = "倉儲設置(&S)"
        Me.tsm_Stock.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'cmdReflash
        '
        Me.cmdReflash.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdReflash.Name = "cmdReflash"
        Me.cmdReflash.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdReflash.Size = New System.Drawing.Size(200, 22)
        Me.cmdReflash.Text = "刷新(R)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(200, 22)
        Me.cmdPrint.Text = "打印(&P)"
        '
        'cmsExcel
        '
        Me.cmsExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsExcel.Name = "cmsExcel"
        Me.cmsExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsExcel.Size = New System.Drawing.Size(200, 22)
        Me.cmsExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.MC_LowLimit, Me.MC_SecInv, Me.MC_WH_Name, Me.Source, Me.MC_MRPCon, Me.MC_WH_ID, Me.CheckUserID, Me.CheckBit, Me.CheckRemark, Me.CreateUserID, Me.CreateDate, Me.ModifyUserID, Me.ModifyDate, Me.MC_Remark, Me.MC_OrderRemark, Me.MC_WareHouseRemark, Me.M_SupplierName, Me.AutoID, Me.MC_BatchQty, Me.MC_BatFixEconomy, Me.MC_OrderInterVal, Me.MC_OrderMan, Me.MC_QtyMax, Me.MC_QtyMin})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.AutoID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'M_Code
        '
        Me.M_Code.Caption = "產品編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 129
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 121
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "產品規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 127
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 43
        '
        'MC_LowLimit
        '
        Me.MC_LowLimit.Caption = "最低存量"
        Me.MC_LowLimit.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_LowLimit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_LowLimit.FieldName = "MC_LowLimit"
        Me.MC_LowLimit.Name = "MC_LowLimit"
        Me.MC_LowLimit.Visible = True
        Me.MC_LowLimit.VisibleIndex = 7
        Me.MC_LowLimit.Width = 64
        '
        'MC_SecInv
        '
        Me.MC_SecInv.Caption = "安全庫存"
        Me.MC_SecInv.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_SecInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_SecInv.FieldName = "MC_SecInv"
        Me.MC_SecInv.Name = "MC_SecInv"
        Me.MC_SecInv.Visible = True
        Me.MC_SecInv.VisibleIndex = 6
        Me.MC_SecInv.Width = 64
        '
        'MC_WH_Name
        '
        Me.MC_WH_Name.Caption = "入庫倉庫"
        Me.MC_WH_Name.FieldName = "MC_WH_Name"
        Me.MC_WH_Name.Name = "MC_WH_Name"
        Me.MC_WH_Name.Visible = True
        Me.MC_WH_Name.VisibleIndex = 5
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "MC_Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 4
        Me.Source.Width = 63
        '
        'MC_MRPCon
        '
        Me.MC_MRPCon.Caption = "合併需求"
        Me.MC_MRPCon.FieldName = "MC_MRPCon"
        Me.MC_MRPCon.Name = "MC_MRPCon"
        Me.MC_MRPCon.Visible = True
        Me.MC_MRPCon.VisibleIndex = 15
        Me.MC_MRPCon.Width = 58
        '
        'MC_WH_ID
        '
        Me.MC_WH_ID.Caption = "入庫倉庫"
        Me.MC_WH_ID.FieldName = "MC_WH_ID"
        Me.MC_WH_ID.Name = "MC_WH_ID"
        Me.MC_WH_ID.Width = 116
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人"
        Me.CheckUserID.FieldName = "CheckUserID"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.Visible = True
        Me.CheckUserID.VisibleIndex = 17
        Me.CheckUserID.Width = 84
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.Tag = False
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 16
        Me.CheckBit.Width = 37
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.AllowEdit = False
        Me.CheckRemark.Width = 141
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "創建人"
        Me.CreateUserID.FieldName = "CreateUserID"
        Me.CreateUserID.Name = "CreateUserID"
        Me.CreateUserID.OptionsColumn.AllowEdit = False
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建日期"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.OptionsColumn.AllowEdit = False
        '
        'ModifyUserID
        '
        Me.ModifyUserID.Caption = "修改人"
        Me.ModifyUserID.FieldName = "ModifyUserName"
        Me.ModifyUserID.Name = "ModifyUserID"
        Me.ModifyUserID.OptionsColumn.AllowEdit = False
        '
        'ModifyDate
        '
        Me.ModifyDate.Caption = "修改日期"
        Me.ModifyDate.FieldName = "ModifyDate"
        Me.ModifyDate.Name = "ModifyDate"
        Me.ModifyDate.OptionsColumn.AllowEdit = False
        '
        'MC_Remark
        '
        Me.MC_Remark.Caption = "備註"
        Me.MC_Remark.FieldName = "MC_Remark"
        Me.MC_Remark.Name = "MC_Remark"
        Me.MC_Remark.Visible = True
        Me.MC_Remark.VisibleIndex = 18
        Me.MC_Remark.Width = 149
        '
        'MC_OrderRemark
        '
        Me.MC_OrderRemark.Caption = "訂購備註"
        Me.MC_OrderRemark.FieldName = "MC_OrderRemark"
        Me.MC_OrderRemark.Name = "MC_OrderRemark"
        '
        'MC_WareHouseRemark
        '
        Me.MC_WareHouseRemark.Caption = "庫存備註"
        Me.MC_WareHouseRemark.FieldName = "MC_WareHouseRemark"
        Me.MC_WareHouseRemark.Name = "MC_WareHouseRemark"
        '
        'M_SupplierName
        '
        Me.M_SupplierName.Caption = "供應商"
        Me.M_SupplierName.FieldName = "M_SupplierName"
        Me.M_SupplierName.Name = "M_SupplierName"
        Me.M_SupplierName.Visible = True
        Me.M_SupplierName.VisibleIndex = 8
        Me.M_SupplierName.Width = 142
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        '
        'MC_BatchQty
        '
        Me.MC_BatchQty.Caption = "订货批量"
        Me.MC_BatchQty.FieldName = "MC_BatchQty"
        Me.MC_BatchQty.Name = "MC_BatchQty"
        Me.MC_BatchQty.Visible = True
        Me.MC_BatchQty.VisibleIndex = 9
        Me.MC_BatchQty.Width = 62
        '
        'MC_BatFixEconomy
        '
        Me.MC_BatFixEconomy.Caption = "经济批量"
        Me.MC_BatFixEconomy.FieldName = "MC_BatFixEconomy"
        Me.MC_BatFixEconomy.Name = "MC_BatFixEconomy"
        Me.MC_BatFixEconomy.Visible = True
        Me.MC_BatFixEconomy.VisibleIndex = 10
        Me.MC_BatFixEconomy.Width = 62
        '
        'MC_OrderInterVal
        '
        Me.MC_OrderInterVal.Caption = "订货间隔期(天)"
        Me.MC_OrderInterVal.FieldName = "MC_OrderInterVal"
        Me.MC_OrderInterVal.Name = "MC_OrderInterVal"
        Me.MC_OrderInterVal.Visible = True
        Me.MC_OrderInterVal.VisibleIndex = 11
        Me.MC_OrderInterVal.Width = 95
        '
        'MC_OrderMan
        '
        Me.MC_OrderMan.Caption = "采購負責人"
        Me.MC_OrderMan.FieldName = "MC_OrderMan"
        Me.MC_OrderMan.Name = "MC_OrderMan"
        Me.MC_OrderMan.Visible = True
        Me.MC_OrderMan.VisibleIndex = 14
        Me.MC_OrderMan.Width = 71
        '
        'MC_QtyMax
        '
        Me.MC_QtyMax.Caption = "最大訂購量"
        Me.MC_QtyMax.FieldName = "MC_QtyMax"
        Me.MC_QtyMax.Name = "MC_QtyMax"
        Me.MC_QtyMax.Visible = True
        Me.MC_QtyMax.VisibleIndex = 12
        Me.MC_QtyMax.Width = 70
        '
        'MC_QtyMin
        '
        Me.MC_QtyMin.Caption = "最小訂購量"
        Me.MC_QtyMin.FieldName = "MC_QtyMin"
        Me.MC_QtyMin.Name = "MC_QtyMin"
        Me.MC_QtyMin.Visible = True
        Me.MC_QtyMin.VisibleIndex = 13
        Me.MC_QtyMin.Width = 71
        '
        'RepositoryItemMemoEdit27
        '
        Me.RepositoryItemMemoEdit27.Name = "RepositoryItemMemoEdit27"
        '
        'RepositoryItemButtonEdit14
        '
        Me.RepositoryItemButtonEdit14.AutoHeight = False
        Me.RepositoryItemButtonEdit14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit14.Name = "RepositoryItemButtonEdit14"
        '
        'RepositoryItemCalcEdit15
        '
        Me.RepositoryItemCalcEdit15.AutoHeight = False
        Me.RepositoryItemCalcEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit15.Name = "RepositoryItemCalcEdit15"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit13
        '
        Me.RepositoryItemCheckEdit13.AutoHeight = False
        Me.RepositoryItemCheckEdit13.Name = "RepositoryItemCheckEdit13"
        Me.RepositoryItemCheckEdit13.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemDateEdit40
        '
        Me.RepositoryItemDateEdit40.AutoHeight = False
        Me.RepositoryItemDateEdit40.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit40.Mask.EditMask = ""
        Me.RepositoryItemDateEdit40.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit40.Name = "RepositoryItemDateEdit40"
        '
        'RepositoryItemDateEdit38
        '
        Me.RepositoryItemDateEdit38.AutoHeight = False
        Me.RepositoryItemDateEdit38.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit38.Name = "RepositoryItemDateEdit38"
        '
        'RepositoryItemDateEdit39
        '
        Me.RepositoryItemDateEdit39.AutoHeight = False
        Me.RepositoryItemDateEdit39.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit39.Name = "RepositoryItemDateEdit39"
        '
        'RepositoryItemMRUEdit13
        '
        Me.RepositoryItemMRUEdit13.AutoHeight = False
        Me.RepositoryItemMRUEdit13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit13.Name = "RepositoryItemMRUEdit13"
        '
        'RepositoryItemMemoEdit28
        '
        Me.RepositoryItemMemoEdit28.Name = "RepositoryItemMemoEdit28"
        '
        'RepositoryItemMemoExEdit15
        '
        Me.RepositoryItemMemoExEdit15.AutoHeight = False
        Me.RepositoryItemMemoExEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit15.Name = "RepositoryItemMemoExEdit15"
        Me.RepositoryItemMemoExEdit15.ShowIcon = False
        '
        'RepositoryItemDateEdit41
        '
        Me.RepositoryItemDateEdit41.AutoHeight = False
        Me.RepositoryItemDateEdit41.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit41.Name = "RepositoryItemDateEdit41"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1205, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsSub
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemButtonEdit3, Me.RepositoryItemTimeEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit1, Me.MI_NeedDateITEM, Me.MI_NeedDateRIDE})
        Me.Grid1.Size = New System.Drawing.Size(1205, 244)
        Me.Grid1.TabIndex = 207
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
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
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MCode, Me.GridColumn6, Me.S_Supplier, Me.S_SupplierName, Me.GridColumn9, Me.UnitPrice, Me.CurrencyName, Me.EconomicQty, Me.OrderQty, Me.DeliveryDate, Me.MaxQty, Me.MinQty, Me.ResponsibleUserID, Me.Contacts, Me.PaymentType, Me.Tel, Me.Fax, Me.Email, Me.Remark, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.M_Source, Me.CreateUserName, Me.ModifyUserName, Me.MrpSQID, Me.CheckUserName})
        Me.GridView.GridControl = Me.Grid1
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsPrint.AutoWidth = False
        Me.GridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'MCode
        '
        Me.MCode.Caption = "物料編號"
        Me.MCode.FieldName = "MCode"
        Me.MCode.Name = "MCode"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "默認"
        Me.GridColumn6.FieldName = "DefaultBit"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 1
        Me.S_Supplier.Width = 99
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 2
        Me.S_SupplierName.Width = 122
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "單位"
        Me.GridColumn9.FieldName = "M_Unit"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 4
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'CurrencyName
        '
        Me.CurrencyName.Caption = "幣別"
        Me.CurrencyName.FieldName = "CurrencyName"
        Me.CurrencyName.Name = "CurrencyName"
        Me.CurrencyName.Visible = True
        Me.CurrencyName.VisibleIndex = 5
        '
        'EconomicQty
        '
        Me.EconomicQty.Caption = "經濟批量"
        Me.EconomicQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.EconomicQty.FieldName = "EconomicQty"
        Me.EconomicQty.Name = "EconomicQty"
        Me.EconomicQty.Visible = True
        Me.EconomicQty.VisibleIndex = 6
        '
        'OrderQty
        '
        Me.OrderQty.Caption = "訂購批量"
        Me.OrderQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.OrderQty.FieldName = "OrderQty"
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Visible = True
        Me.OrderQty.VisibleIndex = 7
        '
        'DeliveryDate
        '
        Me.DeliveryDate.Caption = "採購週期"
        Me.DeliveryDate.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.DeliveryDate.FieldName = "DeliveryDate"
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.Visible = True
        Me.DeliveryDate.VisibleIndex = 8
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'MaxQty
        '
        Me.MaxQty.Caption = "最大採購數量"
        Me.MaxQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MaxQty.FieldName = "MaxQty"
        Me.MaxQty.Name = "MaxQty"
        Me.MaxQty.Visible = True
        Me.MaxQty.VisibleIndex = 9
        Me.MaxQty.Width = 95
        '
        'MinQty
        '
        Me.MinQty.Caption = "最小採購數量"
        Me.MinQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MinQty.FieldName = "MinQty"
        Me.MinQty.Name = "MinQty"
        Me.MinQty.Visible = True
        Me.MinQty.VisibleIndex = 10
        Me.MinQty.Width = 104
        '
        'ResponsibleUserID
        '
        Me.ResponsibleUserID.Caption = "負責人"
        Me.ResponsibleUserID.FieldName = "ResponsibleUserID"
        Me.ResponsibleUserID.Name = "ResponsibleUserID"
        Me.ResponsibleUserID.Visible = True
        Me.ResponsibleUserID.VisibleIndex = 11
        '
        'Contacts
        '
        Me.Contacts.Caption = "聯繫人"
        Me.Contacts.FieldName = "Contacts"
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Visible = True
        Me.Contacts.VisibleIndex = 12
        '
        'PaymentType
        '
        Me.PaymentType.Caption = "付款方式"
        Me.PaymentType.FieldName = "PaymentType"
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Visible = True
        Me.PaymentType.VisibleIndex = 13
        '
        'Tel
        '
        Me.Tel.Caption = "聯繫電話"
        Me.Tel.FieldName = "Tel"
        Me.Tel.Name = "Tel"
        Me.Tel.Visible = True
        Me.Tel.VisibleIndex = 14
        '
        'Fax
        '
        Me.Fax.Caption = "傳真"
        Me.Fax.FieldName = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 15
        '
        'Email
        '
        Me.Email.Caption = "電子郵箱"
        Me.Email.FieldName = "Email"
        Me.Email.Name = "Email"
        Me.Email.Visible = True
        Me.Email.VisibleIndex = 16
        '
        'Remark
        '
        Me.Remark.Caption = "備註"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "創建人ID"
        Me.GridColumn1.FieldName = "CreateUserID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "創建時間"
        Me.GridColumn2.FieldName = "CreateDate"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "修改人員ID"
        Me.GridColumn3.FieldName = "ModifyUserID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "修改時間"
        Me.GridColumn4.FieldName = "ModifyDate"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "審核人ID"
        Me.GridColumn5.FieldName = "CheckUserID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "自動編號"
        Me.GridColumn8.FieldName = "AutoID"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "產品名稱"
        Me.GridColumn10.FieldName = "M_Name"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "規格"
        Me.GridColumn11.FieldName = "M_Gauge"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建人姓名"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        '
        'ModifyUserName
        '
        Me.ModifyUserName.Caption = "修改人姓名"
        Me.ModifyUserName.FieldName = "ModifyUserName"
        Me.ModifyUserName.Name = "ModifyUserName"
        '
        'MrpSQID
        '
        Me.MrpSQID.Caption = "供應商報價編號"
        Me.MrpSQID.FieldName = "MrpSQID"
        Me.MrpSQID.Name = "MrpSQID"
        '
        'CheckUserName
        '
        Me.CheckUserName.Caption = "審核人姓名"
        Me.CheckUserName.FieldName = "CheckUserName"
        Me.CheckUserName.Name = "CheckUserName"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'MI_NeedDateITEM
        '
        Me.MI_NeedDateITEM.AutoHeight = False
        Me.MI_NeedDateITEM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MI_NeedDateITEM.Name = "MI_NeedDateITEM"
        '
        'MI_NeedDateRIDE
        '
        Me.MI_NeedDateRIDE.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.MI_NeedDateRIDE.AutoHeight = False
        Me.MI_NeedDateRIDE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MI_NeedDateRIDE.Name = "MI_NeedDateRIDE"
        Me.MI_NeedDateRIDE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1205, 496)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 208
        '
        'frmMrpMaterialCodeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 528)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpMaterialCodeMain"
        Me.Text = "MRP物料編碼表"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSub.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MI_NeedDateITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit27 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit40 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit38 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit39 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMRUEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents RepositoryItemMemoEdit28 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit41 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MC_LowLimit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_SecInv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_MRPCon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReflash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MC_WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WareHouseRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EconomicQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaxQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MinQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResponsibleUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MrpSQID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MI_NeedDateITEM As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents MI_NeedDateRIDE As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CurrencyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Contacts As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PaymentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_BatchQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_BatFixEconomy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderInterVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderMan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_QtyMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_QtyMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsSubExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Supplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Stock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
