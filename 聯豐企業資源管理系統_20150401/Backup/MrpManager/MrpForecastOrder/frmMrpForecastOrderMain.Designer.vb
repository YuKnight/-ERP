<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpForecastOrderMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpForecastOrderMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmFind = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsm_ChildCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmPaint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_MRPOrderFous = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_MRPOrderTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_ForecastDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_PlanType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_Cancellation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderInterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsSub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsSubExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchasedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PlanQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeliveryQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.MI_WeekNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DateCross = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_Note = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.IsMrpOperation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.E_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISpurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISPpurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISWorkOrder = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_IsCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSub.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(835, 484)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 200
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsMenuStrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemTimeEdit2, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemCalcEdit4})
        Me.GridControl1.Size = New System.Drawing.Size(835, 237)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmEdit, Me.tsmDelete, Me.tsmFind, Me.tsmView, Me.ToolStripSeparator2, Me.tsm_ChildCheck, Me.tsmCheck, Me.ToolStripSeparator1, Me.tsmRefresh, Me.tsmPaint, Me.cmsExcel})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(185, 236)
        '
        'tsmNew
        '
        Me.tsmNew.Enabled = False
        Me.tsmNew.Image = CType(resources.GetObject("tsmNew.Image"), System.Drawing.Image)
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(184, 22)
        Me.tsmNew.Text = "新增(&A)"
        Me.tsmNew.Visible = False
        '
        'tsmEdit
        '
        Me.tsmEdit.Enabled = False
        Me.tsmEdit.Image = CType(resources.GetObject("tsmEdit.Image"), System.Drawing.Image)
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmEdit.Size = New System.Drawing.Size(184, 22)
        Me.tsmEdit.Text = "修改(&E)"
        Me.tsmEdit.Visible = False
        '
        'tsmDelete
        '
        Me.tsmDelete.Enabled = False
        Me.tsmDelete.Image = CType(resources.GetObject("tsmDelete.Image"), System.Drawing.Image)
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(184, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        Me.tsmDelete.Visible = False
        '
        'tsmFind
        '
        Me.tsmFind.Image = CType(resources.GetObject("tsmFind.Image"), System.Drawing.Image)
        Me.tsmFind.Name = "tsmFind"
        Me.tsmFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsmFind.Size = New System.Drawing.Size(184, 22)
        Me.tsmFind.Text = "查詢(&F)"
        '
        'tsmView
        '
        Me.tsmView.Image = CType(resources.GetObject("tsmView.Image"), System.Drawing.Image)
        Me.tsmView.Name = "tsmView"
        Me.tsmView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.tsmView.Size = New System.Drawing.Size(184, 22)
        Me.tsmView.Text = "查看(&W)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'tsm_ChildCheck
        '
        Me.tsm_ChildCheck.Enabled = False
        Me.tsm_ChildCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.tsm_ChildCheck.Name = "tsm_ChildCheck"
        Me.tsm_ChildCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsm_ChildCheck.Size = New System.Drawing.Size(184, 22)
        Me.tsm_ChildCheck.Text = "明細審核(&C)"
        Me.tsm_ChildCheck.Visible = False
        '
        'tsmCheck
        '
        Me.tsmCheck.Enabled = False
        Me.tsmCheck.Image = CType(resources.GetObject("tsmCheck.Image"), System.Drawing.Image)
        Me.tsmCheck.Name = "tsmCheck"
        Me.tsmCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmCheck.Size = New System.Drawing.Size(184, 22)
        Me.tsmCheck.Text = "審核(&S)"
        Me.tsmCheck.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'tsmRefresh
        '
        Me.tsmRefresh.Image = CType(resources.GetObject("tsmRefresh.Image"), System.Drawing.Image)
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmRefresh.Size = New System.Drawing.Size(184, 22)
        Me.tsmRefresh.Text = "刷新(&R)"
        '
        'tsmPaint
        '
        Me.tsmPaint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_MRPOrderFous, Me.tsm_MRPOrderTotal})
        Me.tsmPaint.Image = CType(resources.GetObject("tsmPaint.Image"), System.Drawing.Image)
        Me.tsmPaint.Name = "tsmPaint"
        Me.tsmPaint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPaint.Size = New System.Drawing.Size(184, 22)
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
        'cmsExcel
        '
        Me.cmsExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsExcel.Name = "cmsExcel"
        Me.cmsExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsExcel.Size = New System.Drawing.Size(184, 22)
        Me.cmsExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ForecastID, Me.MO_ForecastDate, Me.MO_PlanType, Me.MO_Status, Me.MO_Cancellation, Me.OrderInterID, Me.MO_CusterName, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Source, Me.M_Unit, Me.NeedQty, Me.CheckBit, Me.CheckRemark, Me.CheckUserName, Me.CreateUserName, Me.CreateDate, Me.ModifyUserName, Me.ModifyDate, Me.MO_CusterID, Me.ModifyUserID, Me.AutoID, Me.CreateUserID, Me.CheckUserID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ForecastID, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'ForecastID
        '
        Me.ForecastID.Caption = "预测单号"
        Me.ForecastID.FieldName = "ForecastID"
        Me.ForecastID.Name = "ForecastID"
        Me.ForecastID.OptionsColumn.AllowEdit = False
        Me.ForecastID.OptionsColumn.ReadOnly = True
        Me.ForecastID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.ForecastID.Visible = True
        Me.ForecastID.VisibleIndex = 0
        Me.ForecastID.Width = 100
        '
        'MO_ForecastDate
        '
        Me.MO_ForecastDate.Caption = "預測日期"
        Me.MO_ForecastDate.FieldName = "MO_ForecastDate"
        Me.MO_ForecastDate.Name = "MO_ForecastDate"
        Me.MO_ForecastDate.OptionsColumn.AllowEdit = False
        Me.MO_ForecastDate.OptionsColumn.ReadOnly = True
        '
        'MO_PlanType
        '
        Me.MO_PlanType.Caption = "訂單類型"
        Me.MO_PlanType.FieldName = "MO_PlanType"
        Me.MO_PlanType.Name = "MO_PlanType"
        Me.MO_PlanType.OptionsColumn.AllowEdit = False
        Me.MO_PlanType.OptionsColumn.ReadOnly = True
        Me.MO_PlanType.Visible = True
        Me.MO_PlanType.VisibleIndex = 1
        Me.MO_PlanType.Width = 80
        '
        'MO_Status
        '
        Me.MO_Status.Caption = "状态"
        Me.MO_Status.FieldName = "MO_Status"
        Me.MO_Status.Name = "MO_Status"
        Me.MO_Status.OptionsColumn.AllowEdit = False
        Me.MO_Status.OptionsColumn.ReadOnly = True
        '
        'MO_Cancellation
        '
        Me.MO_Cancellation.Caption = "作废"
        Me.MO_Cancellation.FieldName = "MO_Cancellation"
        Me.MO_Cancellation.Name = "MO_Cancellation"
        Me.MO_Cancellation.OptionsColumn.AllowEdit = False
        Me.MO_Cancellation.OptionsColumn.ReadOnly = True
        Me.MO_Cancellation.Visible = True
        Me.MO_Cancellation.VisibleIndex = 15
        Me.MO_Cancellation.Width = 50
        '
        'OrderInterID
        '
        Me.OrderInterID.Caption = "客戶訂單"
        Me.OrderInterID.FieldName = "OrderInterID"
        Me.OrderInterID.Name = "OrderInterID"
        Me.OrderInterID.OptionsColumn.AllowEdit = False
        Me.OrderInterID.OptionsColumn.ReadOnly = True
        Me.OrderInterID.Visible = True
        Me.OrderInterID.VisibleIndex = 2
        Me.OrderInterID.Width = 91
        '
        'MO_CusterName
        '
        Me.MO_CusterName.Caption = "客戶名稱"
        Me.MO_CusterName.FieldName = "MO_CusterName"
        Me.MO_CusterName.Name = "MO_CusterName"
        Me.MO_CusterName.OptionsColumn.AllowEdit = False
        Me.MO_CusterName.OptionsColumn.ReadOnly = True
        Me.MO_CusterName.Visible = True
        Me.MO_CusterName.VisibleIndex = 3
        Me.MO_CusterName.Width = 71
        '
        'M_Code
        '
        Me.M_Code.Caption = "產品編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 4
        Me.M_Code.Width = 126
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 5
        Me.M_Name.Width = 84
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 6
        Me.M_Gauge.Width = 137
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.OptionsColumn.AllowEdit = False
        Me.M_Source.OptionsColumn.ReadOnly = True
        Me.M_Source.Visible = True
        Me.M_Source.VisibleIndex = 7
        Me.M_Source.Width = 58
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 8
        Me.M_Unit.Width = 50
        '
        'NeedQty
        '
        Me.NeedQty.Caption = "需求數量"
        Me.NeedQty.FieldName = "NeedQty"
        Me.NeedQty.Name = "NeedQty"
        Me.NeedQty.Visible = True
        Me.NeedQty.VisibleIndex = 9
        Me.NeedQty.Width = 100
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.OptionsColumn.ReadOnly = True
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 10
        Me.CheckBit.Width = 50
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
        '
        'CheckUserName
        '
        Me.CheckUserName.Caption = "審核人員"
        Me.CheckUserName.FieldName = "CheckUserName"
        Me.CheckUserName.Name = "CheckUserName"
        Me.CheckUserName.OptionsColumn.AllowEdit = False
        Me.CheckUserName.OptionsColumn.ReadOnly = True
        Me.CheckUserName.Visible = True
        Me.CheckUserName.VisibleIndex = 12
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建人員"
        Me.CreateUserName.FieldName = "MP_CreateUserName"
        Me.CreateUserName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.OptionsColumn.AllowEdit = False
        Me.CreateUserName.OptionsColumn.ReadOnly = True
        Me.CreateUserName.Visible = True
        Me.CreateUserName.VisibleIndex = 13
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建時間"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.OptionsColumn.AllowEdit = False
        Me.CreateDate.OptionsColumn.ReadOnly = True
        Me.CreateDate.Visible = True
        Me.CreateDate.VisibleIndex = 14
        '
        'ModifyUserName
        '
        Me.ModifyUserName.Caption = "修改人員"
        Me.ModifyUserName.FieldName = "ModifyUserName"
        Me.ModifyUserName.Name = "ModifyUserName"
        Me.ModifyUserName.OptionsColumn.AllowEdit = False
        Me.ModifyUserName.OptionsColumn.ReadOnly = True
        '
        'ModifyDate
        '
        Me.ModifyDate.Caption = "修改時間"
        Me.ModifyDate.FieldName = "ModifyDate"
        Me.ModifyDate.Name = "ModifyDate"
        Me.ModifyDate.OptionsColumn.AllowEdit = False
        Me.ModifyDate.OptionsColumn.ReadOnly = True
        '
        'MO_CusterID
        '
        Me.MO_CusterID.Caption = "客戶編號"
        Me.MO_CusterID.FieldName = "MO_CusterID"
        Me.MO_CusterID.Name = "MO_CusterID"
        '
        'ModifyUserID
        '
        Me.ModifyUserID.Caption = "ModifyUserID"
        Me.ModifyUserID.FieldName = "ModifyUserID"
        Me.ModifyUserID.Name = "ModifyUserID"
        Me.ModifyUserID.OptionsColumn.AllowEdit = False
        Me.ModifyUserID.OptionsColumn.ReadOnly = True
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "CreateUserID"
        Me.CreateUserID.FieldName = "CreateUserID"
        Me.CreateUserID.Name = "CreateUserID"
        Me.CreateUserID.OptionsColumn.AllowEdit = False
        Me.CreateUserID.OptionsColumn.ReadOnly = True
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "CheckUserID"
        Me.CheckUserID.FieldName = "CheckUserID"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.OptionsColumn.AllowEdit = False
        Me.CheckUserID.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
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
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        Me.RepositoryItemCalcEdit4.Precision = 0
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsSub
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemButtonEdit3, Me.RepositoryItemTimeEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCalcEdit3})
        Me.Grid1.Size = New System.Drawing.Size(835, 243)
        Me.Grid1.TabIndex = 204
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
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MI_Qty, Me.PurchasedQty, Me.PlanQty, Me.DeliveryQty, Me.MI_NeedDate, Me.MI_WeekNumber, Me.DateCross, Me.MI_Note, Me.IsMrpOperation, Me.E_CreateUserName, Me.E_CreateDate, Me.E_ModifyUserName, Me.E_ModifyDate, Me.E_ForecastID, Me.MI_ISpurchase, Me.MI_ISPpurchase, Me.MI_ISWorkOrder, Me.E_CreateUserID, Me.E_ModifyUserID, Me.E_AutoID, Me.MI_IsCheck})
        Me.GridView.GridControl = Me.Grid1
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.MI_NeedDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'MI_Qty
        '
        Me.MI_Qty.Caption = "訂單數量"
        Me.MI_Qty.FieldName = "MI_Qty"
        Me.MI_Qty.Name = "MI_Qty"
        Me.MI_Qty.OptionsColumn.AllowEdit = False
        Me.MI_Qty.OptionsColumn.ReadOnly = True
        Me.MI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.MI_Qty.Visible = True
        Me.MI_Qty.VisibleIndex = 0
        Me.MI_Qty.Width = 100
        '
        'PurchasedQty
        '
        Me.PurchasedQty.Caption = "已採數量"
        Me.PurchasedQty.FieldName = "PurchasedQty"
        Me.PurchasedQty.Name = "PurchasedQty"
        Me.PurchasedQty.OptionsColumn.AllowEdit = False
        Me.PurchasedQty.OptionsColumn.ReadOnly = True
        Me.PurchasedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PurchasedQty.Visible = True
        Me.PurchasedQty.VisibleIndex = 1
        Me.PurchasedQty.Width = 100
        '
        'PlanQty
        '
        Me.PlanQty.Caption = "計劃生產數量"
        Me.PlanQty.FieldName = "PlanQty"
        Me.PlanQty.Name = "PlanQty"
        Me.PlanQty.OptionsColumn.AllowEdit = False
        Me.PlanQty.OptionsColumn.ReadOnly = True
        Me.PlanQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PlanQty.Width = 100
        '
        'DeliveryQty
        '
        Me.DeliveryQty.Caption = "已交數量"
        Me.DeliveryQty.FieldName = "DeliveryQty"
        Me.DeliveryQty.Name = "DeliveryQty"
        Me.DeliveryQty.OptionsColumn.AllowEdit = False
        Me.DeliveryQty.OptionsColumn.ReadOnly = True
        Me.DeliveryQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.DeliveryQty.Visible = True
        Me.DeliveryQty.VisibleIndex = 2
        '
        'MI_NeedDate
        '
        Me.MI_NeedDate.Caption = "需求日期"
        Me.MI_NeedDate.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MI_NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_NeedDate.FieldName = "MI_NeedDate"
        Me.MI_NeedDate.Name = "MI_NeedDate"
        Me.MI_NeedDate.OptionsColumn.AllowEdit = False
        Me.MI_NeedDate.OptionsColumn.ReadOnly = True
        Me.MI_NeedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.MI_NeedDate.Visible = True
        Me.MI_NeedDate.VisibleIndex = 3
        Me.MI_NeedDate.Width = 89
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'MI_WeekNumber
        '
        Me.MI_WeekNumber.Caption = "周數"
        Me.MI_WeekNumber.FieldName = "MI_WeekNumber"
        Me.MI_WeekNumber.Name = "MI_WeekNumber"
        Me.MI_WeekNumber.OptionsColumn.AllowEdit = False
        Me.MI_WeekNumber.OptionsColumn.ReadOnly = True
        Me.MI_WeekNumber.Visible = True
        Me.MI_WeekNumber.VisibleIndex = 4
        Me.MI_WeekNumber.Width = 44
        '
        'DateCross
        '
        Me.DateCross.Caption = "時間段"
        Me.DateCross.FieldName = "DateCross"
        Me.DateCross.Name = "DateCross"
        Me.DateCross.OptionsColumn.AllowEdit = False
        Me.DateCross.OptionsColumn.ReadOnly = True
        Me.DateCross.Visible = True
        Me.DateCross.VisibleIndex = 5
        Me.DateCross.Width = 166
        '
        'MI_Note
        '
        Me.MI_Note.Caption = "备注"
        Me.MI_Note.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.MI_Note.FieldName = "MI_Note"
        Me.MI_Note.Name = "MI_Note"
        Me.MI_Note.Visible = True
        Me.MI_Note.VisibleIndex = 6
        Me.MI_Note.Width = 189
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'IsMrpOperation
        '
        Me.IsMrpOperation.Caption = "是否運算"
        Me.IsMrpOperation.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsMrpOperation.FieldName = "IsMrpOperation"
        Me.IsMrpOperation.Name = "IsMrpOperation"
        Me.IsMrpOperation.OptionsColumn.AllowEdit = False
        Me.IsMrpOperation.OptionsColumn.ReadOnly = True
        Me.IsMrpOperation.Visible = True
        Me.IsMrpOperation.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'E_CreateUserName
        '
        Me.E_CreateUserName.Caption = "創建人員"
        Me.E_CreateUserName.FieldName = "CreateUserName"
        Me.E_CreateUserName.Name = "E_CreateUserName"
        '
        'E_CreateDate
        '
        Me.E_CreateDate.Caption = "創建時間"
        Me.E_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.E_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.E_CreateDate.FieldName = "CreateDate"
        Me.E_CreateDate.Name = "E_CreateDate"
        '
        'E_ModifyUserName
        '
        Me.E_ModifyUserName.Caption = "修改人員"
        Me.E_ModifyUserName.FieldName = "ModifyUserName"
        Me.E_ModifyUserName.Name = "E_ModifyUserName"
        '
        'E_ModifyDate
        '
        Me.E_ModifyDate.Caption = "修改時間"
        Me.E_ModifyDate.FieldName = "ModifyDate"
        Me.E_ModifyDate.Name = "E_ModifyDate"
        '
        'E_ForecastID
        '
        Me.E_ForecastID.Caption = "预测单号"
        Me.E_ForecastID.FieldName = "ForecastID"
        Me.E_ForecastID.Name = "E_ForecastID"
        '
        'MI_ISpurchase
        '
        Me.MI_ISpurchase.Caption = "是否訂購"
        Me.MI_ISpurchase.FieldName = "MI_ISpurchase"
        Me.MI_ISpurchase.Name = "MI_ISpurchase"
        '
        'MI_ISPpurchase
        '
        Me.MI_ISPpurchase.Caption = "是否轉請購"
        Me.MI_ISPpurchase.FieldName = "MI_ISPpurchase"
        Me.MI_ISPpurchase.Name = "MI_ISPpurchase"
        '
        'MI_ISWorkOrder
        '
        Me.MI_ISWorkOrder.Caption = "是否購工單"
        Me.MI_ISWorkOrder.FieldName = "MI_ISWorkOrder"
        Me.MI_ISWorkOrder.Name = "MI_ISWorkOrder"
        '
        'E_CreateUserID
        '
        Me.E_CreateUserID.Caption = "CreateUserID"
        Me.E_CreateUserID.FieldName = "CreateUserID"
        Me.E_CreateUserID.Name = "E_CreateUserID"
        '
        'E_ModifyUserID
        '
        Me.E_ModifyUserID.Caption = "ModifyUserID"
        Me.E_ModifyUserID.FieldName = "ModifyUserID"
        Me.E_ModifyUserID.Name = "E_ModifyUserID"
        '
        'E_AutoID
        '
        Me.E_AutoID.Caption = "AutoID"
        Me.E_AutoID.FieldName = "AutoID"
        Me.E_AutoID.Name = "E_AutoID"
        '
        'MI_IsCheck
        '
        Me.MI_IsCheck.Caption = "審核"
        Me.MI_IsCheck.FieldName = "IsCheck"
        Me.MI_IsCheck.Name = "MI_IsCheck"
        Me.MI_IsCheck.Visible = True
        Me.MI_IsCheck.VisibleIndex = 8
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
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 33)
        Me.PictureBox1.TabIndex = 201
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(5, 7)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(131, 21)
        Me.Lbl_Title.TabIndex = 201
        Me.Lbl_Title.Text = "MRP預測訂單"
        '
        'frmMrpForecastOrderMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpForecastOrderMain"
        Me.Text = "MRP預測訂單"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSub.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmPaint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_ForecastDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_Cancellation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderInterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_PlanType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents MO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_CusterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents MI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MI_NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_WeekNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MI_Note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents E_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISpurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISPpurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISWorkOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents DateCross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchasedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PlanQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsMrpOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents tsm_MRPOrderFous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_MRPOrderTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents cmsExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsSubExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MI_IsCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_ChildCheck As System.Windows.Forms.ToolStripMenuItem
End Class
