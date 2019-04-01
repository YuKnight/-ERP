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
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsLook = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsReflash = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_BatchQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_BatFixEconomy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderInterVal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderMan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMin = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        Me.SuspendLayout()
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(4, 6)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(120, 21)
        Me.lblinfo.TabIndex = 88
        Me.lblinfo.Text = "物料編碼表"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit27, Me.RepositoryItemButtonEdit14, Me.RepositoryItemCalcEdit15, Me.RepositoryItemTextEdit14, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit13, Me.RepositoryItemDateEdit40, Me.RepositoryItemDateEdit38, Me.RepositoryItemDateEdit39, Me.RepositoryItemMRUEdit13, Me.RepositoryItemMemoEdit28, Me.RepositoryItemMemoExEdit15, Me.RepositoryItemDateEdit41, Me.RepositoryItemTimeEdit1, Me.RepositoryItemCheckEdit2})
        Me.Grid.Size = New System.Drawing.Size(1205, 496)
        Me.Grid.TabIndex = 89
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsEdit, Me.cmsDel, Me.cmsFind, Me.cmsLook, Me.cmsCheck, Me.cmsReflash, Me.cmsPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 180)
        Me.ContextMenuStrip1.Text = "新增(&A)"
        '
        'cmsAdd
        '
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(168, 22)
        Me.cmsAdd.Text = "新增(&A)"
        '
        'cmsEdit
        '
        Me.cmsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsEdit.Size = New System.Drawing.Size(168, 22)
        Me.cmsEdit.Text = "修改(&E)"
        '
        'cmsDel
        '
        Me.cmsDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDel.Name = "cmsDel"
        Me.cmsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDel.Size = New System.Drawing.Size(168, 22)
        Me.cmsDel.Text = "刪除(&D)"
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
        'cmsCheck
        '
        Me.cmsCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsCheck.Name = "cmsCheck"
        Me.cmsCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsCheck.Size = New System.Drawing.Size(168, 22)
        Me.cmsCheck.Text = "審核(&G)"
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
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(168, 22)
        Me.cmsPrint.Text = "打印(&P)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.MC_BatchQty, Me.MC_BatFixEconomy, Me.MC_OrderInterVal, Me.MC_OrderMan, Me.MC_QtyMax, Me.MC_QtyMin, Me.MC_LowLimit, Me.MC_SecInv, Me.MC_WH_Name, Me.Source, Me.MC_MRPCon, Me.MC_WH_ID, Me.CheckUserID, Me.CheckBit, Me.CheckRemark, Me.CreateUserID, Me.CreateDate, Me.ModifyUserID, Me.ModifyDate, Me.MC_Remark, Me.MC_OrderRemark, Me.MC_WareHouseRemark, Me.AutoID})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'MC_BatchQty
        '
        Me.MC_BatchQty.Caption = "訂貨批量"
        Me.MC_BatchQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_BatchQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_BatchQty.FieldName = "MC_BatchQty"
        Me.MC_BatchQty.Name = "MC_BatchQty"
        Me.MC_BatchQty.OptionsColumn.AllowEdit = False
        Me.MC_BatchQty.Width = 66
        '
        'MC_BatFixEconomy
        '
        Me.MC_BatFixEconomy.Caption = "經濟批量"
        Me.MC_BatFixEconomy.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_BatFixEconomy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_BatFixEconomy.FieldName = "MC_BatFixEconomy"
        Me.MC_BatFixEconomy.Name = "MC_BatFixEconomy"
        Me.MC_BatFixEconomy.OptionsColumn.AllowEdit = False
        Me.MC_BatFixEconomy.Visible = True
        Me.MC_BatFixEconomy.VisibleIndex = 4
        Me.MC_BatFixEconomy.Width = 63
        '
        'MC_OrderInterVal
        '
        Me.MC_OrderInterVal.Caption = "交貨天數"
        Me.MC_OrderInterVal.DisplayFormat.FormatString = "#,###0.#"
        Me.MC_OrderInterVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_OrderInterVal.FieldName = "MC_OrderInterVal"
        Me.MC_OrderInterVal.Name = "MC_OrderInterVal"
        Me.MC_OrderInterVal.OptionsColumn.AllowEdit = False
        Me.MC_OrderInterVal.Visible = True
        Me.MC_OrderInterVal.VisibleIndex = 5
        Me.MC_OrderInterVal.Width = 72
        '
        'MC_OrderMan
        '
        Me.MC_OrderMan.Caption = "採購負責人"
        Me.MC_OrderMan.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.MC_OrderMan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.MC_OrderMan.FieldName = "MC_OrderMan"
        Me.MC_OrderMan.Name = "MC_OrderMan"
        Me.MC_OrderMan.OptionsColumn.AllowEdit = False
        Me.MC_OrderMan.Width = 71
        '
        'MC_QtyMax
        '
        Me.MC_QtyMax.Caption = "最大訂購量"
        Me.MC_QtyMax.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_QtyMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_QtyMax.FieldName = "MC_QtyMax"
        Me.MC_QtyMax.Name = "MC_QtyMax"
        Me.MC_QtyMax.OptionsColumn.AllowEdit = False
        Me.MC_QtyMax.Visible = True
        Me.MC_QtyMax.VisibleIndex = 6
        Me.MC_QtyMax.Width = 72
        '
        'MC_QtyMin
        '
        Me.MC_QtyMin.Caption = "最小訂購量"
        Me.MC_QtyMin.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_QtyMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_QtyMin.FieldName = "MC_QtyMin"
        Me.MC_QtyMin.Name = "MC_QtyMin"
        Me.MC_QtyMin.Visible = True
        Me.MC_QtyMin.VisibleIndex = 7
        Me.MC_QtyMin.Width = 70
        '
        'MC_LowLimit
        '
        Me.MC_LowLimit.Caption = "最低存量"
        Me.MC_LowLimit.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_LowLimit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_LowLimit.FieldName = "MC_LowLimit"
        Me.MC_LowLimit.Name = "MC_LowLimit"
        Me.MC_LowLimit.Width = 68
        '
        'MC_SecInv
        '
        Me.MC_SecInv.Caption = "安全庫存"
        Me.MC_SecInv.DisplayFormat.FormatString = "#,###0.######"
        Me.MC_SecInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MC_SecInv.FieldName = "MC_SecInv"
        Me.MC_SecInv.Name = "MC_SecInv"
        Me.MC_SecInv.Visible = True
        Me.MC_SecInv.VisibleIndex = 8
        Me.MC_SecInv.Width = 74
        '
        'MC_WH_Name
        '
        Me.MC_WH_Name.Caption = "入庫倉庫"
        Me.MC_WH_Name.FieldName = "MC_WH_Name"
        Me.MC_WH_Name.Name = "MC_WH_Name"
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "MC_Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 9
        Me.Source.Width = 63
        '
        'MC_MRPCon
        '
        Me.MC_MRPCon.Caption = "合併需求"
        Me.MC_MRPCon.FieldName = "MC_MRPCon"
        Me.MC_MRPCon.Name = "MC_MRPCon"
        Me.MC_MRPCon.Visible = True
        Me.MC_MRPCon.VisibleIndex = 10
        Me.MC_MRPCon.Width = 59
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
        Me.CheckUserID.VisibleIndex = 12
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
        Me.CheckBit.VisibleIndex = 11
        Me.CheckBit.Width = 35
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
        Me.ModifyUserID.FieldName = "ModifyUserID"
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
        Me.MC_Remark.VisibleIndex = 13
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
        'frmMrpMaterialCodeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 528)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpMaterialCodeMain"
        Me.Text = "物料編碼表"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_BatchQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_BatFixEconomy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderInterVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderMan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_QtyMax As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents MC_QtyMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_LowLimit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_SecInv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_MRPCon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsReflash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MC_WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WareHouseRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
End Class
