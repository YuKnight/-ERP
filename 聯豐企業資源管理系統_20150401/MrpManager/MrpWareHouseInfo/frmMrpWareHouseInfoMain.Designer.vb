<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpWareHouseInfoMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsLook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsReflash = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_PrintMRPWareHouseInfo = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_PrintMRPWareHouseAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Ware_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MD_ISMrp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MD_RecordCreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.列印明細ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsSub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsSubExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_CodeSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_InventoryQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_InTransitQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_Inspection = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_NoCollar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_RetreatQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSub.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(931, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "MRP庫存記錄表"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(931, 496)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.TabIndex = 83
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
        Me.Grid.Size = New System.Drawing.Size(931, 258)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsEdit, Me.cmsDel, Me.cmsFind, Me.cmsLook, Me.ToolStripSeparator1, Me.cmsCheck, Me.ToolStripSeparator2, Me.cmsReflash, Me.cmsPrint, Me.cmsExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 214)
        Me.ContextMenuStrip1.Text = "新增(&A)"
        '
        'cmsAdd
        '
        Me.cmsAdd.Enabled = False
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(168, 22)
        Me.cmsAdd.Text = "新增(&A)"
        Me.cmsAdd.Visible = False
        '
        'cmsEdit
        '
        Me.cmsEdit.Enabled = False
        Me.cmsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsEdit.Size = New System.Drawing.Size(168, 22)
        Me.cmsEdit.Text = "修改(&E)"
        Me.cmsEdit.Visible = False
        '
        'cmsDel
        '
        Me.cmsDel.Enabled = False
        Me.cmsDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDel.Name = "cmsDel"
        Me.cmsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDel.Size = New System.Drawing.Size(168, 22)
        Me.cmsDel.Text = "刪除(&D)"
        Me.cmsDel.Visible = False
        '
        'cmsFind
        '
        Me.cmsFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsFind.Size = New System.Drawing.Size(168, 22)
        Me.cmsFind.Text = "查詢(F)"
        '
        'cmsLook
        '
        Me.cmsLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsLook.Name = "cmsLook"
        Me.cmsLook.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsLook.Size = New System.Drawing.Size(168, 22)
        Me.cmsLook.Text = "查看(&W)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'cmsCheck
        '
        Me.cmsCheck.Enabled = False
        Me.cmsCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsCheck.Name = "cmsCheck"
        Me.cmsCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsCheck.Size = New System.Drawing.Size(168, 22)
        Me.cmsCheck.Text = "審核(&G)"
        Me.cmsCheck.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'cmsReflash
        '
        Me.cmsReflash.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsReflash.Name = "cmsReflash"
        Me.cmsReflash.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsReflash.Size = New System.Drawing.Size(168, 22)
        Me.cmsReflash.Text = "刷新(R)"
        '
        'cmsPrint
        '
        Me.cmsPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_PrintMRPWareHouseInfo, Me.tsm_PrintMRPWareHouseAll})
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(168, 22)
        Me.cmsPrint.Text = "打印(&P)"
        '
        'tsm_PrintMRPWareHouseInfo
        '
        Me.tsm_PrintMRPWareHouseInfo.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsm_PrintMRPWareHouseInfo.Name = "tsm_PrintMRPWareHouseInfo"
        Me.tsm_PrintMRPWareHouseInfo.Size = New System.Drawing.Size(172, 22)
        Me.tsm_PrintMRPWareHouseInfo.Text = "列印詳細庫存信息"
        '
        'tsm_PrintMRPWareHouseAll
        '
        Me.tsm_PrintMRPWareHouseAll.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsm_PrintMRPWareHouseAll.Name = "tsm_PrintMRPWareHouseAll"
        Me.tsm_PrintMRPWareHouseAll.Size = New System.Drawing.Size(172, 22)
        Me.tsm_PrintMRPWareHouseAll.Text = "列印庫存匯總信息"
        '
        'cmsExcel
        '
        Me.cmsExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsExcel.Name = "cmsExcel"
        Me.cmsExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsExcel.Size = New System.Drawing.Size(168, 22)
        Me.cmsExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ware_ID, Me.M_Code, Me.MRP_ID, Me.MD_ISMrp, Me.MD_RecordCreateDate, Me.CheckUserID, Me.CheckBit, Me.CheckRemark, Me.CreateUserID, Me.CreateDate, Me.ModifyUserID, Me.ModifyDate, Me.AutoID})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Ware_ID
        '
        Me.Ware_ID.Caption = "庫存單號"
        Me.Ware_ID.FieldName = "Ware_ID"
        Me.Ware_ID.Name = "Ware_ID"
        Me.Ware_ID.OptionsColumn.AllowEdit = False
        Me.Ware_ID.Visible = True
        Me.Ware_ID.VisibleIndex = 0
        Me.Ware_ID.Width = 101
        '
        'M_Code
        '
        Me.M_Code.Caption = "產品編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "運算單號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.OptionsColumn.AllowEdit = False
        Me.MRP_ID.Visible = True
        Me.MRP_ID.VisibleIndex = 1
        Me.MRP_ID.Width = 102
        '
        'MD_ISMrp
        '
        Me.MD_ISMrp.Caption = "轉MRP"
        Me.MD_ISMrp.FieldName = "MD_ISMrp"
        Me.MD_ISMrp.Name = "MD_ISMrp"
        Me.MD_ISMrp.OptionsColumn.AllowEdit = False
        Me.MD_ISMrp.Visible = True
        Me.MD_ISMrp.VisibleIndex = 2
        Me.MD_ISMrp.Width = 57
        '
        'MD_RecordCreateDate
        '
        Me.MD_RecordCreateDate.Caption = "創建日期"
        Me.MD_RecordCreateDate.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.MD_RecordCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.MD_RecordCreateDate.FieldName = "MD_RecordCreateDate"
        Me.MD_RecordCreateDate.Name = "MD_RecordCreateDate"
        Me.MD_RecordCreateDate.OptionsColumn.AllowEdit = False
        Me.MD_RecordCreateDate.Visible = True
        Me.MD_RecordCreateDate.VisibleIndex = 3
        Me.MD_RecordCreateDate.Width = 91
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人"
        Me.CheckUserID.FieldName = "CheckUserName"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.OptionsColumn.AllowEdit = False
        Me.CheckUserID.Visible = True
        Me.CheckUserID.VisibleIndex = 5
        Me.CheckUserID.Width = 79
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.Tag = False
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 4
        Me.CheckBit.Width = 52
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.AllowEdit = False
        Me.CheckRemark.Visible = True
        Me.CheckRemark.VisibleIndex = 6
        Me.CheckRemark.Width = 380
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "創建人"
        Me.CreateUserID.FieldName = "CreateUserName"
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
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(931, 234)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.列印明細ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(168, 26)
        '
        '列印明細ToolStripMenuItem
        '
        Me.列印明細ToolStripMenuItem.Name = "列印明細ToolStripMenuItem"
        Me.列印明細ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.列印明細ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.列印明細ToolStripMenuItem.Text = "列印明細"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(922, 202)
        Me.XtraTabPage1.Text = "明細"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsSub
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemMRUEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit4, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoExEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(922, 202)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_CodeSub, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.Source, Me.MP_InventoryQty, Me.MP_InTransitQty, Me.MP_Inspection, Me.MP_NoCollar, Me.MP_RetreatQty, Me.AutoIDSub, Me.MP_Remark})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'M_CodeSub
        '
        Me.M_CodeSub.Caption = "產品編號"
        Me.M_CodeSub.FieldName = "M_Code"
        Me.M_CodeSub.Name = "M_CodeSub"
        Me.M_CodeSub.OptionsColumn.AllowEdit = False
        Me.M_CodeSub.Visible = True
        Me.M_CodeSub.VisibleIndex = 0
        Me.M_CodeSub.Width = 134
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 97
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "產品規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 167
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 48
        '
        'Source
        '
        Me.Source.Caption = "來源別"
        Me.Source.FieldName = "Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 4
        Me.Source.Width = 58
        '
        'MP_InventoryQty
        '
        Me.MP_InventoryQty.Caption = "庫存數量"
        Me.MP_InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_InventoryQty.FieldName = "MP_InventoryQty"
        Me.MP_InventoryQty.Name = "MP_InventoryQty"
        Me.MP_InventoryQty.OptionsColumn.AllowEdit = False
        Me.MP_InventoryQty.OptionsColumn.ReadOnly = True
        Me.MP_InventoryQty.Visible = True
        Me.MP_InventoryQty.VisibleIndex = 5
        Me.MP_InventoryQty.Width = 74
        '
        'MP_InTransitQty
        '
        Me.MP_InTransitQty.Caption = "在途量"
        Me.MP_InTransitQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_InTransitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_InTransitQty.FieldName = "MP_InTransitQty"
        Me.MP_InTransitQty.Name = "MP_InTransitQty"
        Me.MP_InTransitQty.OptionsColumn.AllowEdit = False
        Me.MP_InTransitQty.OptionsColumn.ReadOnly = True
        Me.MP_InTransitQty.Visible = True
        Me.MP_InTransitQty.VisibleIndex = 6
        Me.MP_InTransitQty.Width = 60
        '
        'MP_Inspection
        '
        Me.MP_Inspection.Caption = "待驗量"
        Me.MP_Inspection.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_Inspection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_Inspection.FieldName = "MP_Inspection"
        Me.MP_Inspection.Name = "MP_Inspection"
        Me.MP_Inspection.OptionsColumn.AllowEdit = False
        Me.MP_Inspection.OptionsColumn.ReadOnly = True
        Me.MP_Inspection.Visible = True
        Me.MP_Inspection.VisibleIndex = 7
        Me.MP_Inspection.Width = 57
        '
        'MP_NoCollar
        '
        Me.MP_NoCollar.Caption = "生產未領"
        Me.MP_NoCollar.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_NoCollar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_NoCollar.FieldName = "MP_NoCollar"
        Me.MP_NoCollar.Name = "MP_NoCollar"
        Me.MP_NoCollar.OptionsColumn.AllowEdit = False
        Me.MP_NoCollar.OptionsColumn.ReadOnly = True
        Me.MP_NoCollar.Visible = True
        Me.MP_NoCollar.VisibleIndex = 9
        Me.MP_NoCollar.Width = 72
        '
        'MP_RetreatQty
        '
        Me.MP_RetreatQty.Caption = "退貨數量"
        Me.MP_RetreatQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_RetreatQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_RetreatQty.FieldName = "MP_RetreatQty"
        Me.MP_RetreatQty.Name = "MP_RetreatQty"
        Me.MP_RetreatQty.OptionsColumn.AllowEdit = False
        Me.MP_RetreatQty.Visible = True
        Me.MP_RetreatQty.VisibleIndex = 8
        Me.MP_RetreatQty.Width = 71
        '
        'AutoIDSub
        '
        Me.AutoIDSub.Caption = "AutoID"
        Me.AutoIDSub.FieldName = "AutoID"
        Me.AutoIDSub.Name = "AutoIDSub"
        Me.AutoIDSub.OptionsColumn.AllowEdit = False
        '
        'MP_Remark
        '
        Me.MP_Remark.Caption = "備註"
        Me.MP_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.MP_Remark.FieldName = "MP_Remark"
        Me.MP_Remark.Name = "MP_Remark"
        Me.MP_Remark.Visible = True
        Me.MP_Remark.VisibleIndex = 10
        Me.MP_Remark.Width = 150
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = ""
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemMRUEdit1
        '
        Me.RepositoryItemMRUEdit1.AutoHeight = False
        Me.RepositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit1.Name = "RepositoryItemMRUEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'frmMrpWareHouseInfoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 528)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpWareHouseInfoMain"
        Me.Text = "MRP庫存記錄表"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
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
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSub.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MD_RecordCreateDate As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_CodeSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_InventoryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_InTransitQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_Inspection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_NoCollar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_RetreatQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoIDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Ware_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsReflash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_ISMrp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 列印明細ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_PrintMRPWareHouseInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_PrintMRPWareHouseAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsSubExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
