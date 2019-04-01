<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPSupplierQuotationMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPSupplierQuotationMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmFind = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmPaint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_MRPOrderFous = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_MRPOrderTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EconomicQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MaxQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MinQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ResponsibleUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MrpSQID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.MI_NeedDateITEM = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MI_NeedDateRIDE = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MI_NeedDateITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 32)
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(9, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(153, 21)
        Me.Lbl_Title.TabIndex = 197
        Me.Lbl_Title.Text = "MRP供應商報價"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.cmsMenuStrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 34)
        Me.Grid1.MainView = Me.GridView
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemButtonEdit3, Me.RepositoryItemTimeEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit2, Me.MI_NeedDateITEM, Me.MI_NeedDateRIDE})
        Me.Grid1.Size = New System.Drawing.Size(857, 474)
        Me.Grid1.TabIndex = 206
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmDelete, Me.tsmEdit, Me.tsmView, Me.ToolStripSeparator1, Me.tsmFind, Me.tsmCheck, Me.tsmRefresh, Me.ToolStripSeparator2, Me.tsmPaint})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(169, 192)
        '
        'tsmNew
        '
        Me.tsmNew.Image = CType(resources.GetObject("tsmNew.Image"), System.Drawing.Image)
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(168, 22)
        Me.tsmNew.Text = "新增(&A)"
        '
        'tsmDelete
        '
        Me.tsmDelete.Image = CType(resources.GetObject("tsmDelete.Image"), System.Drawing.Image)
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(168, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        '
        'tsmEdit
        '
        Me.tsmEdit.Image = CType(resources.GetObject("tsmEdit.Image"), System.Drawing.Image)
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmEdit.Size = New System.Drawing.Size(168, 22)
        Me.tsmEdit.Text = "修改(&E)"
        '
        'tsmView
        '
        Me.tsmView.Image = CType(resources.GetObject("tsmView.Image"), System.Drawing.Image)
        Me.tsmView.Name = "tsmView"
        Me.tsmView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.tsmView.Size = New System.Drawing.Size(168, 22)
        Me.tsmView.Text = "查看(&W)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'tsmFind
        '
        Me.tsmFind.Image = CType(resources.GetObject("tsmFind.Image"), System.Drawing.Image)
        Me.tsmFind.Name = "tsmFind"
        Me.tsmFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsmFind.Size = New System.Drawing.Size(168, 22)
        Me.tsmFind.Text = "查詢(&F)"
        '
        'tsmCheck
        '
        Me.tsmCheck.Image = CType(resources.GetObject("tsmCheck.Image"), System.Drawing.Image)
        Me.tsmCheck.Name = "tsmCheck"
        Me.tsmCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmCheck.Size = New System.Drawing.Size(168, 22)
        Me.tsmCheck.Text = "審核(&S)"
        '
        'tsmRefresh
        '
        Me.tsmRefresh.Image = CType(resources.GetObject("tsmRefresh.Image"), System.Drawing.Image)
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmRefresh.Size = New System.Drawing.Size(168, 22)
        Me.tsmRefresh.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'tsmPaint
        '
        Me.tsmPaint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_MRPOrderFous, Me.tsm_MRPOrderTotal})
        Me.tsmPaint.Image = CType(resources.GetObject("tsmPaint.Image"), System.Drawing.Image)
        Me.tsmPaint.Name = "tsmPaint"
        Me.tsmPaint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPaint.Size = New System.Drawing.Size(168, 22)
        Me.tsmPaint.Text = "打印(&P)"
        '
        'tsm_MRPOrderFous
        '
        Me.tsm_MRPOrderFous.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsm_MRPOrderFous.Name = "tsm_MRPOrderFous"
        Me.tsm_MRPOrderFous.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsm_MRPOrderFous.Size = New System.Drawing.Size(220, 22)
        Me.tsm_MRPOrderFous.Text = "焦點訂單信息(&O）"
        '
        'tsm_MRPOrderTotal
        '
        Me.tsm_MRPOrderTotal.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsm_MRPOrderTotal.Name = "tsm_MRPOrderTotal"
        Me.tsm_MRPOrderTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.tsm_MRPOrderTotal.Size = New System.Drawing.Size(220, 22)
        Me.tsm_MRPOrderTotal.Text = "訂單信息匯總(&T)"
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MCode, Me.S_Supplier, Me.EconomicQty, Me.OrderQty, Me.DeliveryDate, Me.MaxQty, Me.MinQty, Me.ResponsibleUserID, Me.UnitPrice, Me.Remark, Me.CreateUserID, Me.CreateDate, Me.ModifyUserID, Me.ModifyDate, Me.CheckUserID, Me.CheckBit, Me.CheckRemark, Me.AutoID, Me.S_SupplierName, Me.M_Unit, Me.M_Name, Me.M_Gauge, Me.M_Source, Me.CreateUserName, Me.ModifyUserName, Me.CheckUserName, Me.MrpSQID})
        Me.GridView.GridControl = Me.Grid1
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsCustomization.AllowSort = False
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
        Me.MCode.Visible = True
        Me.MCode.VisibleIndex = 0
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 1
        '
        'EconomicQty
        '
        Me.EconomicQty.Caption = "經濟批量"
        Me.EconomicQty.FieldName = "EconomicQty"
        Me.EconomicQty.Name = "EconomicQty"
        Me.EconomicQty.Visible = True
        Me.EconomicQty.VisibleIndex = 2
        '
        'OrderQty
        '
        Me.OrderQty.Caption = "訂購批量"
        Me.OrderQty.FieldName = "OrderQty"
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Visible = True
        Me.OrderQty.VisibleIndex = 3
        '
        'DeliveryDate
        '
        Me.DeliveryDate.Caption = "採購週期"
        Me.DeliveryDate.FieldName = "DeliveryDate"
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.Visible = True
        Me.DeliveryDate.VisibleIndex = 4
        '
        'MaxQty
        '
        Me.MaxQty.Caption = "最大採購數量"
        Me.MaxQty.FieldName = "MaxQty"
        Me.MaxQty.Name = "MaxQty"
        Me.MaxQty.Visible = True
        Me.MaxQty.VisibleIndex = 5
        '
        'MinQty
        '
        Me.MinQty.Caption = "最小採購數量"
        Me.MinQty.FieldName = "MinQty"
        Me.MinQty.Name = "MinQty"
        Me.MinQty.Visible = True
        Me.MinQty.VisibleIndex = 6
        '
        'ResponsibleUserID
        '
        Me.ResponsibleUserID.Caption = "負責人"
        Me.ResponsibleUserID.FieldName = "ResponsibleUserID"
        Me.ResponsibleUserID.Name = "ResponsibleUserID"
        Me.ResponsibleUserID.Visible = True
        Me.ResponsibleUserID.VisibleIndex = 7
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 8
        '
        'Remark
        '
        Me.Remark.Caption = "備註"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "創建人ID"
        Me.CreateUserID.FieldName = "CreateUserID"
        Me.CreateUserID.Name = "CreateUserID"
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建時間"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        '
        'ModifyUserID
        '
        Me.ModifyUserID.Caption = "修改人員ID"
        Me.ModifyUserID.FieldName = "ModifyUserID"
        Me.ModifyUserID.Name = "ModifyUserID"
        '
        'ModifyDate
        '
        Me.ModifyDate.Caption = "修改時間"
        Me.ModifyDate.FieldName = "ModifyDate"
        Me.ModifyDate.Name = "ModifyDate"
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人ID"
        Me.CheckUserID.FieldName = "CheckUserID"
        Me.CheckUserID.Name = "CheckUserID"
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 11
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.Visible = True
        Me.CheckRemark.VisibleIndex = 13
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 15
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 16
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 9
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 10
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.Visible = True
        Me.M_Source.VisibleIndex = 12
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
        'CheckUserName
        '
        Me.CheckUserName.Caption = "審核人姓名"
        Me.CheckUserName.FieldName = "CheckUserName"
        Me.CheckUserName.Name = "CheckUserName"
        '
        'MrpSQID
        '
        Me.MrpSQID.Caption = "供應商報價編號"
        Me.MrpSQID.FieldName = "MrpSQID"
        Me.MrpSQID.Name = "MrpSQID"
        Me.MrpSQID.Visible = True
        Me.MrpSQID.VisibleIndex = 14
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
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
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
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView5
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
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
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
        'frmMRPSupplierQuotationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 510)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMRPSupplierQuotationMain"
        Me.Text = "frmMRPSupplierQuotationMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MI_NeedDateITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MI_NeedDateITEM As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents MI_NeedDateRIDE As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
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
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmPaint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_MRPOrderFous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_MRPOrderTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MrpSQID As DevExpress.XtraGrid.Columns.GridColumn
End Class
