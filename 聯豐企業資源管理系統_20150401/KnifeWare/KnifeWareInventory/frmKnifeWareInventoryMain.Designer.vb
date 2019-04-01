<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareInventoryMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeWareInventoryMain))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.twWare = New System.Windows.Forms.TreeView
        Me.twType = New System.Windows.Forms.TreeView
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareInventory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareInventorySeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInventorySafe = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangePrice = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInventoryPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popBatchCodeSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInventoryBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintAllBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSetBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintNetAllBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.Popexport = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemALL = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDull = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripWareInvent = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_IDSum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQtySum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SQtySum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SReQtySum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.popKnifeMatriCodeRec = New System.Windows.Forms.ToolStripMenuItem
        Me.popKnifeMatriCodeBackUp = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareInventory.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 0
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 54)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 511)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 38
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.twWare)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.twType)
        Me.SplitContainer2.Size = New System.Drawing.Size(152, 511)
        Me.SplitContainer2.SplitterDistance = 175
        Me.SplitContainer2.TabIndex = 0
        '
        'twWare
        '
        Me.twWare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twWare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twWare.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twWare.FullRowSelect = True
        Me.twWare.HideSelection = False
        Me.twWare.Location = New System.Drawing.Point(0, 0)
        Me.twWare.Name = "twWare"
        Me.twWare.Size = New System.Drawing.Size(152, 175)
        Me.twWare.TabIndex = 35
        '
        'twType
        '
        Me.twType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twType.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twType.FullRowSelect = True
        Me.twType.HideSelection = False
        Me.twType.Location = New System.Drawing.Point(0, 0)
        Me.twType.Name = "twType"
        Me.twType.Size = New System.Drawing.Size(152, 332)
        Me.twType.TabIndex = 34
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Grid1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(648, 511)
        Me.SplitContainer3.SplitterDistance = 393
        Me.SplitContainer3.TabIndex = 168
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popWareInventory
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(648, 393)
        Me.Grid1.TabIndex = 168
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popWareInventory
        '
        Me.popWareInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInventorySeek, Me.popWareInventorySafe, Me.popChangePrice, Me.popWareInventoryPrint, Me.popBatchCodeSelect, Me.popWareInventoryBarCode, Me.Popexport, Me.COPYToolStripMenuItem, Me.ToolStripMenuItemALL, Me.ToolStripMenuItem1, Me.ToolStripDull, Me.ToolStripWareInvent, Me.ToolStripMenuItem2, Me.popKnifeMatriCodeRec, Me.popKnifeMatriCodeBackUp})
        Me.popWareInventory.Name = "popWareInput"
        Me.popWareInventory.Size = New System.Drawing.Size(212, 324)
        '
        'popWareInventorySeek
        '
        Me.popWareInventorySeek.Name = "popWareInventorySeek"
        Me.popWareInventorySeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInventorySeek.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventorySeek.Text = "查詢(&F)..."
        '
        'popWareInventorySafe
        '
        Me.popWareInventorySafe.Enabled = False
        Me.popWareInventorySafe.Name = "popWareInventorySafe"
        Me.popWareInventorySafe.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventorySafe.Text = "調整安全庫存(&S)..."
        Me.popWareInventorySafe.Visible = False
        '
        'popChangePrice
        '
        Me.popChangePrice.Enabled = False
        Me.popChangePrice.Name = "popChangePrice"
        Me.popChangePrice.Size = New System.Drawing.Size(211, 22)
        Me.popChangePrice.Text = "變更指定日期物料單價(&J)..."
        Me.popChangePrice.Visible = False
        '
        'popWareInventoryPrint
        '
        Me.popWareInventoryPrint.Name = "popWareInventoryPrint"
        Me.popWareInventoryPrint.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventoryPrint.Text = "庫存表(&B)..."
        '
        'popBatchCodeSelect
        '
        Me.popBatchCodeSelect.Name = "popBatchCodeSelect"
        Me.popBatchCodeSelect.Size = New System.Drawing.Size(211, 22)
        Me.popBatchCodeSelect.Text = "物料出入庫明細(&E)..."
        Me.popBatchCodeSelect.Visible = False
        '
        'popWareInventoryBarCode
        '
        Me.popWareInventoryBarCode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllBarCode, Me.PrintSetBarCode, Me.PrintNetAllBarCode})
        Me.popWareInventoryBarCode.Name = "popWareInventoryBarCode"
        Me.popWareInventoryBarCode.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventoryBarCode.Text = "列印條碼(&P)..."
        Me.popWareInventoryBarCode.Visible = False
        '
        'PrintAllBarCode
        '
        Me.PrintAllBarCode.Name = "PrintAllBarCode"
        Me.PrintAllBarCode.Size = New System.Drawing.Size(189, 22)
        Me.PrintAllBarCode.Text = "當前倉庫條碼(&D)..."
        '
        'PrintSetBarCode
        '
        Me.PrintSetBarCode.Name = "PrintSetBarCode"
        Me.PrintSetBarCode.Size = New System.Drawing.Size(189, 22)
        Me.PrintSetBarCode.Text = "指定條碼(&Z)..."
        '
        'PrintNetAllBarCode
        '
        Me.PrintNetAllBarCode.Name = "PrintNetAllBarCode"
        Me.PrintNetAllBarCode.Size = New System.Drawing.Size(189, 22)
        Me.PrintNetAllBarCode.Text = "打印當前倉庫條碼(&P)..."
        '
        'Popexport
        '
        Me.Popexport.Name = "Popexport"
        Me.Popexport.Size = New System.Drawing.Size(211, 22)
        Me.Popexport.Text = "導出(&U)..."
        Me.Popexport.Visible = False
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.COPYToolStripMenuItem.Text = "復制(&C)"
        Me.COPYToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItemALL
        '
        Me.ToolStripMenuItemALL.Name = "ToolStripMenuItemALL"
        Me.ToolStripMenuItemALL.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItemALL.Text = "全部復制"
        Me.ToolStripMenuItemALL.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'ToolStripDull
        '
        Me.ToolStripDull.Name = "ToolStripDull"
        Me.ToolStripDull.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripDull.Text = "列印呆滯刀具"
        '
        'ToolStripWareInvent
        '
        Me.ToolStripWareInvent.Name = "ToolStripWareInvent"
        Me.ToolStripWareInvent.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripWareInvent.Text = "刀具庫存一覽表"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.PM_M_Name, Me.M_Gauge, Me.WI_Qty, Me.WI_SQty, Me.WI_SReQty, Me.M_Unit, Me.WI_SafeQty, Me.WH_ID})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 125
        '
        'PM_M_Name
        '
        Me.PM_M_Name.Caption = "刀具名稱"
        Me.PM_M_Name.FieldName = "PM_M_Name"
        Me.PM_M_Name.Name = "PM_M_Name"
        Me.PM_M_Name.OptionsColumn.ReadOnly = True
        Me.PM_M_Name.Visible = True
        Me.PM_M_Name.VisibleIndex = 1
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 100
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存數量"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.SummaryItem.DisplayFormat = "庫存合計:{0}"
        Me.WI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 3
        Me.WI_Qty.Width = 130
        '
        'WI_SQty
        '
        Me.WI_SQty.Caption = "新刀數"
        Me.WI_SQty.FieldName = "WI_SQty"
        Me.WI_SQty.Name = "WI_SQty"
        Me.WI_SQty.OptionsColumn.ReadOnly = True
        Me.WI_SQty.SummaryItem.DisplayFormat = "新刀合計:{0}"
        Me.WI_SQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SQty.Visible = True
        Me.WI_SQty.VisibleIndex = 4
        Me.WI_SQty.Width = 130
        '
        'WI_SReQty
        '
        Me.WI_SReQty.Caption = "待處理數"
        Me.WI_SReQty.FieldName = "WI_SReQty"
        Me.WI_SReQty.Name = "WI_SReQty"
        Me.WI_SReQty.OptionsColumn.ReadOnly = True
        Me.WI_SReQty.SummaryItem.DisplayFormat = "待處理合計:{0}"
        Me.WI_SReQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SReQty.Visible = True
        Me.WI_SReQty.VisibleIndex = 5
        Me.WI_SReQty.Width = 130
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 6
        '
        'WI_SafeQty
        '
        Me.WI_SafeQty.Caption = "安全庫存"
        Me.WI_SafeQty.FieldName = "WI_SafeQty"
        Me.WI_SafeQty.Name = "WI_SafeQty"
        Me.WI_SafeQty.OptionsColumn.ReadOnly = True
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.OptionsColumn.ReadOnly = True
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(648, 114)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WH_AllName, Me.WH_IDSum, Me.WI_Qty1, Me.WI_SafeQtySum, Me.WI_SQtySum, Me.WI_SReQtySum})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'WH_AllName
        '
        Me.WH_AllName.Caption = "倉庫名稱"
        Me.WH_AllName.FieldName = "WH_Name"
        Me.WH_AllName.Name = "WH_AllName"
        Me.WH_AllName.OptionsColumn.ReadOnly = True
        Me.WH_AllName.Visible = True
        Me.WH_AllName.VisibleIndex = 0
        Me.WH_AllName.Width = 98
        '
        'WH_IDSum
        '
        Me.WH_IDSum.Caption = "倉庫編號"
        Me.WH_IDSum.FieldName = "WH_ID"
        Me.WH_IDSum.Name = "WH_IDSum"
        Me.WH_IDSum.OptionsColumn.ReadOnly = True
        '
        'WI_Qty1
        '
        Me.WI_Qty1.Caption = "庫存數量"
        Me.WI_Qty1.FieldName = "WI_Qty"
        Me.WI_Qty1.Name = "WI_Qty1"
        Me.WI_Qty1.OptionsColumn.ReadOnly = True
        Me.WI_Qty1.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_Qty1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_Qty1.Visible = True
        Me.WI_Qty1.VisibleIndex = 1
        Me.WI_Qty1.Width = 98
        '
        'WI_SafeQtySum
        '
        Me.WI_SafeQtySum.Caption = "安全庫存"
        Me.WI_SafeQtySum.FieldName = "WI_SafeQty"
        Me.WI_SafeQtySum.Name = "WI_SafeQtySum"
        Me.WI_SafeQtySum.OptionsColumn.ReadOnly = True
        Me.WI_SafeQtySum.Width = 105
        '
        'WI_SQtySum
        '
        Me.WI_SQtySum.Caption = "新刀數"
        Me.WI_SQtySum.FieldName = "WI_SQty"
        Me.WI_SQtySum.Name = "WI_SQtySum"
        Me.WI_SQtySum.SummaryItem.DisplayFormat = "新刀數-合計:{0}"
        Me.WI_SQtySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SQtySum.Visible = True
        Me.WI_SQtySum.VisibleIndex = 2
        '
        'WI_SReQtySum
        '
        Me.WI_SReQtySum.Caption = "待處理數"
        Me.WI_SReQtySum.FieldName = "WI_SReQty"
        Me.WI_SReQtySum.Name = "WI_SReQtySum"
        Me.WI_SReQtySum.SummaryItem.DisplayFormat = "侍處理數-合計:{0}"
        Me.WI_SReQtySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SReQtySum.Visible = True
        Me.WI_SReQtySum.VisibleIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "warehouse.ico")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 6)
        '
        'popKnifeMatriCodeRec
        '
        Me.popKnifeMatriCodeRec.Name = "popKnifeMatriCodeRec"
        Me.popKnifeMatriCodeRec.Size = New System.Drawing.Size(211, 22)
        Me.popKnifeMatriCodeRec.Text = "刀具收發明細"
        '
        'popKnifeMatriCodeBackUp
        '
        Me.popKnifeMatriCodeBackUp.Name = "popKnifeMatriCodeBackUp"
        Me.popKnifeMatriCodeBackUp.Size = New System.Drawing.Size(211, 22)
        Me.popKnifeMatriCodeBackUp.Text = "庫存備份"
        '
        'frmKnifeWareInventoryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmKnifeWareInventoryMain"
        Me.Text = "庫存管理"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareInventory.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents twType As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SReQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_IDSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQtySum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SQtySum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SReQtySum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInventory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInventorySeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventorySafe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangePrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventoryPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popBatchCodeSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventoryBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintNetAllBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Popexport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripDull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripWareInvent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popKnifeMatriCodeRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popKnifeMatriCodeBackUp As System.Windows.Forms.ToolStripMenuItem
End Class
