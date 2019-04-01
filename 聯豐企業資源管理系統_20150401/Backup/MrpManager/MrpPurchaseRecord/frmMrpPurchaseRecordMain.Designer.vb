<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpPurchaseRecordMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpPurchaseRecordMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_SelectSQ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_LessTime = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_LessPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_UserChoice = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_ToPurchaseOrder = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmPaint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_PrintMrpchaseRecordAll = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Excel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MrpPurchaseID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WareHouseName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseDepartName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.IsPurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IsUrgent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.MPP_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseDepartment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MP_MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ForecastDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.MPI_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPI_ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemTimeEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 32)
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(8, 5)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(131, 21)
        Me.Lbl_Title.TabIndex = 203
        Me.Lbl_Title.Text = "MRP請購申請"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1246, 481)
        Me.SplitContainer1.SplitterDistance = 239
        Me.SplitContainer1.TabIndex = 204
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsMenuStrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemTimeEdit2, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1246, 239)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmDelete, Me.tsmEdit, Me.tsmView, Me.tsmFind, Me.ToolStripSeparator1, Me.tsmCheck, Me.tsm_SelectSQ, Me.tsm_ToPurchaseOrder, Me.ToolStripSeparator2, Me.tsmRefresh, Me.tsmPaint, Me.tsm_Excel})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(183, 258)
        '
        'tsmNew
        '
        Me.tsmNew.Enabled = False
        Me.tsmNew.Image = CType(resources.GetObject("tsmNew.Image"), System.Drawing.Image)
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(182, 22)
        Me.tsmNew.Text = "新增(&A)"
        Me.tsmNew.Visible = False
        '
        'tsmDelete
        '
        Me.tsmDelete.Enabled = False
        Me.tsmDelete.Image = CType(resources.GetObject("tsmDelete.Image"), System.Drawing.Image)
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(182, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        Me.tsmDelete.Visible = False
        '
        'tsmEdit
        '
        Me.tsmEdit.Enabled = False
        Me.tsmEdit.Image = CType(resources.GetObject("tsmEdit.Image"), System.Drawing.Image)
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmEdit.Size = New System.Drawing.Size(182, 22)
        Me.tsmEdit.Text = "修改(&E)"
        Me.tsmEdit.Visible = False
        '
        'tsmView
        '
        Me.tsmView.Image = CType(resources.GetObject("tsmView.Image"), System.Drawing.Image)
        Me.tsmView.Name = "tsmView"
        Me.tsmView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.tsmView.Size = New System.Drawing.Size(182, 22)
        Me.tsmView.Text = "查看(&W)"
        '
        'tsmFind
        '
        Me.tsmFind.Image = CType(resources.GetObject("tsmFind.Image"), System.Drawing.Image)
        Me.tsmFind.Name = "tsmFind"
        Me.tsmFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsmFind.Size = New System.Drawing.Size(182, 22)
        Me.tsmFind.Text = "查詢(&F)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'tsmCheck
        '
        Me.tsmCheck.Enabled = False
        Me.tsmCheck.Image = CType(resources.GetObject("tsmCheck.Image"), System.Drawing.Image)
        Me.tsmCheck.Name = "tsmCheck"
        Me.tsmCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmCheck.Size = New System.Drawing.Size(182, 22)
        Me.tsmCheck.Text = "審核(&S)"
        Me.tsmCheck.Visible = False
        '
        'tsm_SelectSQ
        '
        Me.tsm_SelectSQ.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_LessTime, Me.tsm_LessPrice, Me.tsm_UserChoice})
        Me.tsm_SelectSQ.Enabled = False
        Me.tsm_SelectSQ.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.tsm_SelectSQ.Name = "tsm_SelectSQ"
        Me.tsm_SelectSQ.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.tsm_SelectSQ.Size = New System.Drawing.Size(182, 22)
        Me.tsm_SelectSQ.Text = "供應商報價"
        Me.tsm_SelectSQ.Visible = False
        '
        'tsm_LessTime
        '
        Me.tsm_LessTime.Name = "tsm_LessTime"
        Me.tsm_LessTime.Size = New System.Drawing.Size(124, 22)
        Me.tsm_LessTime.Text = "最短時間"
        Me.tsm_LessTime.Visible = False
        '
        'tsm_LessPrice
        '
        Me.tsm_LessPrice.Name = "tsm_LessPrice"
        Me.tsm_LessPrice.Size = New System.Drawing.Size(124, 22)
        Me.tsm_LessPrice.Text = "最少單價"
        Me.tsm_LessPrice.Visible = False
        '
        'tsm_UserChoice
        '
        Me.tsm_UserChoice.Name = "tsm_UserChoice"
        Me.tsm_UserChoice.Size = New System.Drawing.Size(124, 22)
        Me.tsm_UserChoice.Text = "手動選擇"
        Me.tsm_UserChoice.Visible = False
        '
        'tsm_ToPurchaseOrder
        '
        Me.tsm_ToPurchaseOrder.Enabled = False
        Me.tsm_ToPurchaseOrder.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.tsm_ToPurchaseOrder.Name = "tsm_ToPurchaseOrder"
        Me.tsm_ToPurchaseOrder.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.tsm_ToPurchaseOrder.Size = New System.Drawing.Size(182, 22)
        Me.tsm_ToPurchaseOrder.Text = "轉采購(&T)"
        Me.tsm_ToPurchaseOrder.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'tsmRefresh
        '
        Me.tsmRefresh.Image = CType(resources.GetObject("tsmRefresh.Image"), System.Drawing.Image)
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmRefresh.Size = New System.Drawing.Size(182, 22)
        Me.tsmRefresh.Text = "刷新(&R)"
        '
        'tsmPaint
        '
        Me.tsmPaint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_PrintMrpchaseRecordAll})
        Me.tsmPaint.Image = CType(resources.GetObject("tsmPaint.Image"), System.Drawing.Image)
        Me.tsmPaint.Name = "tsmPaint"
        Me.tsmPaint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPaint.Size = New System.Drawing.Size(182, 22)
        Me.tsmPaint.Text = "打印(&P)"
        '
        'tsm_PrintMrpchaseRecordAll
        '
        Me.tsm_PrintMrpchaseRecordAll.Name = "tsm_PrintMrpchaseRecordAll"
        Me.tsm_PrintMrpchaseRecordAll.Size = New System.Drawing.Size(148, 22)
        Me.tsm_PrintMrpchaseRecordAll.Text = "列印匯總信息"
        '
        'tsm_Excel
        '
        Me.tsm_Excel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.tsm_Excel.Name = "tsm_Excel"
        Me.tsm_Excel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.tsm_Excel.Size = New System.Drawing.Size(182, 22)
        Me.tsm_Excel.Text = "轉Excel(&Z)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MrpPurchaseID, Me.MRP_ID, Me.WareHouseName, Me.PurchaseDepartName, Me.PurchaseUserName, Me.PurchaseDate, Me.IsPurchase, Me.IsUrgent, Me.CheckBit, Me.MPP_CheckUserName, Me.CheckRemark, Me.MPP_CreateUserName, Me.MPP_CreateDate, Me.MPP_Remark, Me.AutoID, Me.MPP_ModifyUserID, Me.MPP_ModifyUserName, Me.MPP_CreateUserID, Me.MPP_ModifyDate, Me.MPP_CheckDate, Me.MPP_CheckUserID, Me.PurchaseDepartment, Me.PurchaseUserID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.MrpPurchaseID, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'MrpPurchaseID
        '
        Me.MrpPurchaseID.Caption = "請購單號"
        Me.MrpPurchaseID.FieldName = "MrpPurchaseID"
        Me.MrpPurchaseID.Name = "MrpPurchaseID"
        Me.MrpPurchaseID.OptionsColumn.AllowEdit = False
        Me.MrpPurchaseID.OptionsColumn.ReadOnly = True
        Me.MrpPurchaseID.Visible = True
        Me.MrpPurchaseID.VisibleIndex = 0
        Me.MrpPurchaseID.Width = 106
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "運算單號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.OptionsColumn.AllowEdit = False
        Me.MRP_ID.OptionsColumn.ReadOnly = True
        Me.MRP_ID.Visible = True
        Me.MRP_ID.VisibleIndex = 1
        Me.MRP_ID.Width = 112
        '
        'WareHouseName
        '
        Me.WareHouseName.Caption = "進貨倉庫"
        Me.WareHouseName.FieldName = "WareHouseName"
        Me.WareHouseName.Name = "WareHouseName"
        Me.WareHouseName.Visible = True
        Me.WareHouseName.VisibleIndex = 2
        '
        'PurchaseDepartName
        '
        Me.PurchaseDepartName.Caption = "請購部門"
        Me.PurchaseDepartName.FieldName = "PurchaseDepartName"
        Me.PurchaseDepartName.Name = "PurchaseDepartName"
        Me.PurchaseDepartName.OptionsColumn.AllowEdit = False
        Me.PurchaseDepartName.OptionsColumn.ReadOnly = True
        Me.PurchaseDepartName.Visible = True
        Me.PurchaseDepartName.VisibleIndex = 3
        '
        'PurchaseUserName
        '
        Me.PurchaseUserName.Caption = "請購人員"
        Me.PurchaseUserName.FieldName = "PurchaseUserName"
        Me.PurchaseUserName.Name = "PurchaseUserName"
        Me.PurchaseUserName.OptionsColumn.AllowEdit = False
        Me.PurchaseUserName.OptionsColumn.ReadOnly = True
        Me.PurchaseUserName.Visible = True
        Me.PurchaseUserName.VisibleIndex = 4
        '
        'PurchaseDate
        '
        Me.PurchaseDate.Caption = "請購日期"
        Me.PurchaseDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.PurchaseDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.PurchaseDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PurchaseDate.FieldName = "PurchaseDate"
        Me.PurchaseDate.Name = "PurchaseDate"
        Me.PurchaseDate.OptionsColumn.AllowEdit = False
        Me.PurchaseDate.OptionsColumn.ReadOnly = True
        Me.PurchaseDate.Visible = True
        Me.PurchaseDate.VisibleIndex = 5
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'IsPurchase
        '
        Me.IsPurchase.Caption = "是否請購"
        Me.IsPurchase.FieldName = "IsPurchase"
        Me.IsPurchase.Name = "IsPurchase"
        Me.IsPurchase.OptionsColumn.AllowEdit = False
        Me.IsPurchase.OptionsColumn.ReadOnly = True
        Me.IsPurchase.Visible = True
        Me.IsPurchase.VisibleIndex = 6
        Me.IsPurchase.Width = 74
        '
        'IsUrgent
        '
        Me.IsUrgent.Caption = "緊急"
        Me.IsUrgent.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsUrgent.FieldName = "IsUrgent"
        Me.IsUrgent.Name = "IsUrgent"
        Me.IsUrgent.OptionsColumn.AllowEdit = False
        Me.IsUrgent.OptionsColumn.ReadOnly = True
        Me.IsUrgent.Visible = True
        Me.IsUrgent.VisibleIndex = 7
        Me.IsUrgent.Width = 50
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.OptionsColumn.ReadOnly = True
        Me.CheckBit.Tag = False
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 9
        Me.CheckBit.Width = 45
        '
        'MPP_CheckUserName
        '
        Me.MPP_CheckUserName.Caption = "審核人員"
        Me.MPP_CheckUserName.FieldName = "MPP_CheckUserName"
        Me.MPP_CheckUserName.Name = "MPP_CheckUserName"
        Me.MPP_CheckUserName.OptionsColumn.AllowEdit = False
        Me.MPP_CheckUserName.OptionsColumn.ReadOnly = True
        Me.MPP_CheckUserName.Visible = True
        Me.MPP_CheckUserName.VisibleIndex = 10
        Me.MPP_CheckUserName.Width = 71
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.ReadOnly = True
        Me.CheckRemark.Visible = True
        Me.CheckRemark.VisibleIndex = 11
        Me.CheckRemark.Width = 174
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F8)
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'MPP_CreateUserName
        '
        Me.MPP_CreateUserName.Caption = "創建人員"
        Me.MPP_CreateUserName.FieldName = "MPP_CreateUserName"
        Me.MPP_CreateUserName.Name = "MPP_CreateUserName"
        Me.MPP_CreateUserName.OptionsColumn.AllowEdit = False
        Me.MPP_CreateUserName.OptionsColumn.ReadOnly = True
        Me.MPP_CreateUserName.Visible = True
        Me.MPP_CreateUserName.VisibleIndex = 8
        Me.MPP_CreateUserName.Width = 76
        '
        'MPP_CreateDate
        '
        Me.MPP_CreateDate.Caption = "創建時間"
        Me.MPP_CreateDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.MPP_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPP_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPP_CreateDate.FieldName = "MPP_CreateDate"
        Me.MPP_CreateDate.Name = "MPP_CreateDate"
        Me.MPP_CreateDate.OptionsColumn.AllowEdit = False
        Me.MPP_CreateDate.OptionsColumn.ReadOnly = True
        Me.MPP_CreateDate.Visible = True
        Me.MPP_CreateDate.VisibleIndex = 12
        Me.MPP_CreateDate.Width = 111
        '
        'MPP_Remark
        '
        Me.MPP_Remark.Caption = "備註"
        Me.MPP_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.MPP_Remark.FieldName = "MPP_Remark"
        Me.MPP_Remark.Name = "MPP_Remark"
        Me.MPP_Remark.OptionsColumn.ReadOnly = True
        Me.MPP_Remark.Visible = True
        Me.MPP_Remark.VisibleIndex = 13
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'MPP_ModifyUserID
        '
        Me.MPP_ModifyUserID.Caption = "MPP_ModifyUserID"
        Me.MPP_ModifyUserID.FieldName = "MPP_ModifyUserID"
        Me.MPP_ModifyUserID.Name = "MPP_ModifyUserID"
        Me.MPP_ModifyUserID.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyUserID.OptionsColumn.ReadOnly = True
        '
        'MPP_ModifyUserName
        '
        Me.MPP_ModifyUserName.Caption = "MPP_ModifyUserName"
        Me.MPP_ModifyUserName.FieldName = "MPP_ModifyUserName"
        Me.MPP_ModifyUserName.Name = "MPP_ModifyUserName"
        Me.MPP_ModifyUserName.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyUserName.OptionsColumn.ReadOnly = True
        '
        'MPP_CreateUserID
        '
        Me.MPP_CreateUserID.Caption = "MPP_CreateUserID"
        Me.MPP_CreateUserID.FieldName = "MPP_CreateUserID"
        Me.MPP_CreateUserID.Name = "MPP_CreateUserID"
        Me.MPP_CreateUserID.OptionsColumn.AllowEdit = False
        Me.MPP_CreateUserID.OptionsColumn.ReadOnly = True
        Me.MPP_CreateUserID.Width = 104
        '
        'MPP_ModifyDate
        '
        Me.MPP_ModifyDate.Caption = "MPP_ModifyDate"
        Me.MPP_ModifyDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.MPP_ModifyDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPP_ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPP_ModifyDate.FieldName = "MPP_ModifyDate"
        Me.MPP_ModifyDate.Name = "MPP_ModifyDate"
        Me.MPP_ModifyDate.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyDate.OptionsColumn.ReadOnly = True
        '
        'MPP_CheckDate
        '
        Me.MPP_CheckDate.Caption = "MPP_CheckDate"
        Me.MPP_CheckDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.MPP_CheckDate.FieldName = "MPP_CheckDate"
        Me.MPP_CheckDate.Name = "MPP_CheckDate"
        Me.MPP_CheckDate.OptionsColumn.AllowEdit = False
        Me.MPP_CheckDate.OptionsColumn.ReadOnly = True
        '
        'MPP_CheckUserID
        '
        Me.MPP_CheckUserID.Caption = "MPP_CheckUserID"
        Me.MPP_CheckUserID.FieldName = "MPP_CheckUserID"
        Me.MPP_CheckUserID.Name = "MPP_CheckUserID"
        Me.MPP_CheckUserID.OptionsColumn.AllowEdit = False
        Me.MPP_CheckUserID.OptionsColumn.ReadOnly = True
        '
        'PurchaseDepartment
        '
        Me.PurchaseDepartment.Caption = "PurchaseDepartment"
        Me.PurchaseDepartment.FieldName = "PurchaseDepartment"
        Me.PurchaseDepartment.Name = "PurchaseDepartment"
        Me.PurchaseDepartment.OptionsColumn.AllowEdit = False
        Me.PurchaseDepartment.OptionsColumn.ReadOnly = True
        '
        'PurchaseUserID
        '
        Me.PurchaseUserID.Caption = "PurchaseUserID"
        Me.PurchaseUserID.FieldName = "PurchaseUserID"
        Me.PurchaseUserID.Name = "PurchaseUserID"
        Me.PurchaseUserID.OptionsColumn.AllowEdit = False
        Me.PurchaseUserID.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemButtonEdit3, Me.RepositoryItemTimeEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTimeEdit3})
        Me.GridControl2.Size = New System.Drawing.Size(1246, 238)
        Me.GridControl2.TabIndex = 204
        Me.GridControl2.TabStop = False
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsExcel})
        Me.ContextMenuStrip1.Name = "cmsMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 26)
        Me.ContextMenuStrip1.UseWaitCursor = True
        '
        'cmsExcel
        '
        Me.cmsExcel.Image = CType(resources.GetObject("cmsExcel.Image"), System.Drawing.Image)
        Me.cmsExcel.Name = "cmsExcel"
        Me.cmsExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.cmsExcel.Size = New System.Drawing.Size(201, 22)
        Me.cmsExcel.Text = "導出Excle（&L）"
        Me.cmsExcel.Visible = False
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MP_MRP_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Source, Me.M_Unit, Me.MPI_NeedQty, Me.MPI_NeedDate, Me.S_Supplier, Me.S_SupplierName, Me.UnitPrice, Me.ForecastDate, Me.MPI_Remark, Me.MPI_CreateUserName, Me.MPI_CreateDate, Me.MPI_ModifyUserName, Me.MPI_ModifyDate, Me.GridColumn2, Me.MPI_CreateUserID, Me.MPI_ModifyUserID})
        Me.GridView.GridControl = Me.GridControl2
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsPrint.AutoWidth = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'MP_MRP_ID
        '
        Me.MP_MRP_ID.Caption = "MRP運算單號"
        Me.MP_MRP_ID.FieldName = "MRP_ID"
        Me.MP_MRP_ID.Name = "MP_MRP_ID"
        Me.MP_MRP_ID.OptionsColumn.AllowEdit = False
        Me.MP_MRP_ID.OptionsColumn.ReadOnly = True
        Me.MP_MRP_ID.Width = 103
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 147
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 86
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 213
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.OptionsColumn.AllowEdit = False
        Me.M_Source.OptionsColumn.ReadOnly = True
        Me.M_Source.Visible = True
        Me.M_Source.VisibleIndex = 3
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 4
        '
        'MPI_NeedQty
        '
        Me.MPI_NeedQty.Caption = "需求數量"
        Me.MPI_NeedQty.FieldName = "MPI_NeedQty"
        Me.MPI_NeedQty.Name = "MPI_NeedQty"
        Me.MPI_NeedQty.OptionsColumn.AllowEdit = False
        Me.MPI_NeedQty.OptionsColumn.ReadOnly = True
        Me.MPI_NeedQty.Visible = True
        Me.MPI_NeedQty.VisibleIndex = 5
        Me.MPI_NeedQty.Width = 80
        '
        'MPI_NeedDate
        '
        Me.MPI_NeedDate.Caption = "需求日期"
        Me.MPI_NeedDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.MPI_NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPI_NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPI_NeedDate.FieldName = "MPI_NeedDate"
        Me.MPI_NeedDate.Name = "MPI_NeedDate"
        Me.MPI_NeedDate.OptionsColumn.AllowEdit = False
        Me.MPI_NeedDate.OptionsColumn.ReadOnly = True
        Me.MPI_NeedDate.Visible = True
        Me.MPI_NeedDate.VisibleIndex = 7
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit3.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "S_Supplier"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.OptionsColumn.AllowEdit = False
        Me.S_Supplier.OptionsColumn.ReadOnly = True
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.OptionsColumn.AllowEdit = False
        Me.S_SupplierName.OptionsColumn.ReadOnly = True
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 8
        Me.S_SupplierName.Width = 93
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 6
        '
        'ForecastDate
        '
        Me.ForecastDate.Caption = "預測交期"
        Me.ForecastDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.ForecastDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.ForecastDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ForecastDate.FieldName = "ForecastDate"
        Me.ForecastDate.Name = "ForecastDate"
        Me.ForecastDate.OptionsColumn.AllowEdit = False
        Me.ForecastDate.OptionsColumn.ReadOnly = True
        Me.ForecastDate.Visible = True
        Me.ForecastDate.VisibleIndex = 9
        '
        'MPI_Remark
        '
        Me.MPI_Remark.Caption = "備註"
        Me.MPI_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.MPI_Remark.FieldName = "MPI_Remark"
        Me.MPI_Remark.Name = "MPI_Remark"
        Me.MPI_Remark.OptionsColumn.ReadOnly = True
        Me.MPI_Remark.Visible = True
        Me.MPI_Remark.VisibleIndex = 10
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'MPI_CreateUserName
        '
        Me.MPI_CreateUserName.Caption = "創建人員"
        Me.MPI_CreateUserName.FieldName = "MPI_CreateUserName"
        Me.MPI_CreateUserName.Name = "MPI_CreateUserName"
        Me.MPI_CreateUserName.OptionsColumn.AllowEdit = False
        Me.MPI_CreateUserName.OptionsColumn.ReadOnly = True
        '
        'MPI_CreateDate
        '
        Me.MPI_CreateDate.Caption = "創建時間"
        Me.MPI_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPI_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPI_CreateDate.FieldName = "MPI_CreateDate"
        Me.MPI_CreateDate.Name = "MPI_CreateDate"
        Me.MPI_CreateDate.OptionsColumn.AllowEdit = False
        Me.MPI_CreateDate.OptionsColumn.ReadOnly = True
        Me.MPI_CreateDate.Width = 91
        '
        'MPI_ModifyUserName
        '
        Me.MPI_ModifyUserName.Caption = "修改人員"
        Me.MPI_ModifyUserName.FieldName = "MPI_ModifyUserName"
        Me.MPI_ModifyUserName.Name = "MPI_ModifyUserName"
        Me.MPI_ModifyUserName.OptionsColumn.AllowEdit = False
        Me.MPI_ModifyUserName.OptionsColumn.ReadOnly = True
        '
        'MPI_ModifyDate
        '
        Me.MPI_ModifyDate.Caption = "修改時間"
        Me.MPI_ModifyDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPI_ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPI_ModifyDate.FieldName = "MPI_ModifyDate"
        Me.MPI_ModifyDate.Name = "MPI_ModifyDate"
        Me.MPI_ModifyDate.OptionsColumn.AllowEdit = False
        Me.MPI_ModifyDate.OptionsColumn.ReadOnly = True
        Me.MPI_ModifyDate.Width = 127
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "自動編號"
        Me.GridColumn2.FieldName = "AutoID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'MPI_CreateUserID
        '
        Me.MPI_CreateUserID.Caption = "創建人員"
        Me.MPI_CreateUserID.FieldName = "MPI_CreateUserID"
        Me.MPI_CreateUserID.Name = "MPI_CreateUserID"
        Me.MPI_CreateUserID.OptionsColumn.AllowEdit = False
        Me.MPI_CreateUserID.OptionsColumn.ReadOnly = True
        Me.MPI_CreateUserID.Width = 109
        '
        'MPI_ModifyUserID
        '
        Me.MPI_ModifyUserID.Caption = "修改人員"
        Me.MPI_ModifyUserID.FieldName = "MPI_ModifyUserID"
        Me.MPI_ModifyUserID.Name = "MPI_ModifyUserID"
        Me.MPI_ModifyUserID.OptionsColumn.AllowEdit = False
        Me.MPI_ModifyUserID.OptionsColumn.ReadOnly = True
        Me.MPI_ModifyUserID.Width = 97
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
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
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
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
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
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        'RepositoryItemTimeEdit3
        '
        Me.RepositoryItemTimeEdit3.AutoHeight = False
        Me.RepositoryItemTimeEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit3.Name = "RepositoryItemTimeEdit3"
        '
        'frmMrpPurchaseRecordMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 512)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpPurchaseRecordMain"
        Me.Text = "MRP請購申請"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents MrpPurchaseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents tsm_Excel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MP_MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents IsPurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MPI_NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents tsm_SelectSQ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPI_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsUrgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseDepartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ForecastDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_LessTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_LessPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_UserChoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_ToPurchaseOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_PrintMrpchaseRecordAll As System.Windows.Forms.ToolStripMenuItem
End Class
