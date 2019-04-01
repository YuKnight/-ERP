<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareInventoryMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.popWareInventoryBarCodeMD = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSetBarCodeMD = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintNetAllBarCodeMD = New System.Windows.Forms.ToolStripMenuItem
        Me.Popexport = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemALL = New System.Windows.Forms.ToolStripMenuItem
        Me.WareInventMothItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshWarringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.twType = New System.Windows.Forms.TreeView
        Me.twWare = New System.Windows.Forms.TreeView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMothPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMonthDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInventory.SuspendLayout()
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
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "倉庫存倉管理"
        '
        'popWareInventory
        '
        Me.popWareInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInventorySeek, Me.popWareInventorySafe, Me.popChangePrice, Me.popWareInventoryPrint, Me.popBatchCodeSelect, Me.popWareInventoryBarCode, Me.popWareInventoryBarCodeMD, Me.Popexport, Me.COPYToolStripMenuItem, Me.ToolStripMenuItemALL, Me.WareInventMothItemToolStripMenuItem, Me.ToolStripMenuItem1, Me.RefreshWarringToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripDetail, Me.ToolStripMenuItem3, Me.ToolStripMothPrice, Me.ToolStripMonthDetail})
        Me.popWareInventory.Name = "popWareInput"
        Me.popWareInventory.Size = New System.Drawing.Size(212, 374)
        '
        'popWareInventorySeek
        '
        Me.popWareInventorySeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareInventorySeek.Name = "popWareInventorySeek"
        Me.popWareInventorySeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInventorySeek.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventorySeek.Text = "查詢(&F)..."
        '
        'popWareInventorySafe
        '
        Me.popWareInventorySafe.Enabled = False
        Me.popWareInventorySafe.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.popWareInventorySafe.Name = "popWareInventorySafe"
        Me.popWareInventorySafe.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventorySafe.Text = "調整安全庫存(&S)..."
        '
        'popChangePrice
        '
        Me.popChangePrice.Enabled = False
        Me.popChangePrice.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.popChangePrice.Name = "popChangePrice"
        Me.popChangePrice.Size = New System.Drawing.Size(211, 22)
        Me.popChangePrice.Text = "變更指定日期物料單價(&J)..."
        '
        'popWareInventoryPrint
        '
        Me.popWareInventoryPrint.Image = Global.LFERP.My.Resources.Resources.AdvancedFileProperties
        Me.popWareInventoryPrint.Name = "popWareInventoryPrint"
        Me.popWareInventoryPrint.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventoryPrint.Text = "庫存表(&B)..."
        '
        'popBatchCodeSelect
        '
        Me.popBatchCodeSelect.Image = Global.LFERP.My.Resources.Resources.BlogPublishMenu
        Me.popBatchCodeSelect.Name = "popBatchCodeSelect"
        Me.popBatchCodeSelect.Size = New System.Drawing.Size(211, 22)
        Me.popBatchCodeSelect.Text = "物料出入庫明細(&E)..."
        '
        'popWareInventoryBarCode
        '
        Me.popWareInventoryBarCode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllBarCode, Me.PrintSetBarCode, Me.PrintNetAllBarCode})
        Me.popWareInventoryBarCode.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.popWareInventoryBarCode.Name = "popWareInventoryBarCode"
        Me.popWareInventoryBarCode.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventoryBarCode.Text = "列印條碼(&P)..."
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
        Me.PrintNetAllBarCode.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.PrintNetAllBarCode.Name = "PrintNetAllBarCode"
        Me.PrintNetAllBarCode.Size = New System.Drawing.Size(189, 22)
        Me.PrintNetAllBarCode.Text = "打印當前倉庫條碼(&P)..."
        '
        'popWareInventoryBarCodeMD
        '
        Me.popWareInventoryBarCodeMD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSetBarCodeMD, Me.PrintNetAllBarCodeMD})
        Me.popWareInventoryBarCodeMD.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.popWareInventoryBarCodeMD.Name = "popWareInventoryBarCodeMD"
        Me.popWareInventoryBarCodeMD.Size = New System.Drawing.Size(211, 22)
        Me.popWareInventoryBarCodeMD.Text = "列印條碼磨刀部(&M)"
        '
        'PrintSetBarCodeMD
        '
        Me.PrintSetBarCodeMD.Name = "PrintSetBarCodeMD"
        Me.PrintSetBarCodeMD.Size = New System.Drawing.Size(189, 22)
        Me.PrintSetBarCodeMD.Text = "指定條碼(&B)..."
        '
        'PrintNetAllBarCodeMD
        '
        Me.PrintNetAllBarCodeMD.Name = "PrintNetAllBarCodeMD"
        Me.PrintNetAllBarCodeMD.Size = New System.Drawing.Size(189, 22)
        Me.PrintNetAllBarCodeMD.Text = "打印當前倉庫條碼(&P)..."
        '
        'Popexport
        '
        Me.Popexport.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.Popexport.Name = "Popexport"
        Me.Popexport.Size = New System.Drawing.Size(211, 22)
        Me.Popexport.Text = "導出(&U)..."
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.COPYToolStripMenuItem.Text = "復制(&C)"
        '
        'ToolStripMenuItemALL
        '
        Me.ToolStripMenuItemALL.Name = "ToolStripMenuItemALL"
        Me.ToolStripMenuItemALL.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItemALL.Text = "全部復制"
        '
        'WareInventMothItemToolStripMenuItem
        '
        Me.WareInventMothItemToolStripMenuItem.Name = "WareInventMothItemToolStripMenuItem"
        Me.WareInventMothItemToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.WareInventMothItemToolStripMenuItem.Text = "庫存月報表(&T)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        '
        'RefreshWarringToolStripMenuItem
        '
        Me.RefreshWarringToolStripMenuItem.Name = "RefreshWarringToolStripMenuItem"
        Me.RefreshWarringToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RefreshWarringToolStripMenuItem.Text = "顯示低於安全庫存物料"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripDetail
        '
        Me.ToolStripDetail.Name = "ToolStripDetail"
        Me.ToolStripDetail.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripDetail.Text = "出入庫明細(顯示)"
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
        Me.twType.Size = New System.Drawing.Size(152, 235)
        Me.twType.TabIndex = 34
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
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(696, 414)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 37
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
        Me.SplitContainer2.Size = New System.Drawing.Size(152, 414)
        Me.SplitContainer2.SplitterDistance = 175
        Me.SplitContainer2.TabIndex = 0
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
        Me.SplitContainer3.Size = New System.Drawing.Size(540, 414)
        Me.SplitContainer3.SplitterDistance = 291
        Me.SplitContainer3.TabIndex = 167
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
        Me.Grid1.Size = New System.Drawing.Size(540, 291)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.WI_Qty, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
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
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "物料編碼"
        Me.GridColumn1.FieldName = "M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 125
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料名稱"
        Me.GridColumn2.FieldName = "M_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "規格"
        Me.GridColumn3.FieldName = "M_Gauge"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存數量"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "單位"
        Me.GridColumn4.FieldName = "M_Unit"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "安全庫存"
        Me.GridColumn5.FieldName = "WI_SafeQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "倉庫編號"
        Me.GridColumn6.FieldName = "WH_ID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(540, 119)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WH_AllName, Me.WH_ID, Me.WI_Qty1, Me.WI_SafeQty})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'WH_AllName
        '
        Me.WH_AllName.Caption = "倉庫名稱"
        Me.WH_AllName.FieldName = "WH_AllName"
        Me.WH_AllName.Name = "WH_AllName"
        Me.WH_AllName.OptionsColumn.ReadOnly = True
        Me.WH_AllName.Visible = True
        Me.WH_AllName.VisibleIndex = 0
        Me.WH_AllName.Width = 98
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.OptionsColumn.ReadOnly = True
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
        'WI_SafeQty
        '
        Me.WI_SafeQty.Caption = "安全庫存"
        Me.WI_SafeQty.FieldName = "WI_SafeQty"
        Me.WI_SafeQty.Name = "WI_SafeQty"
        Me.WI_SafeQty.OptionsColumn.ReadOnly = True
        Me.WI_SafeQty.Visible = True
        Me.WI_SafeQty.VisibleIndex = 2
        Me.WI_SafeQty.Width = 105
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(698, 36)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripMothPrice
        '
        Me.ToolStripMothPrice.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ToolStripMothPrice.Name = "ToolStripMothPrice"
        Me.ToolStripMothPrice.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMothPrice.Text = "倉庫存貨價值明細"
        '
        'ToolStripMonthDetail
        '
        Me.ToolStripMonthDetail.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ToolStripMonthDetail.Name = "ToolStripMonthDetail"
        Me.ToolStripMonthDetail.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMonthDetail.Text = "倉庫出入庫明細"
        '
        'frmWareInventoryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareInventoryMain"
        Me.Text = "倉庫存倉管理"
        Me.popWareInventory.ResumeLayout(False)
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
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents twType As System.Windows.Forms.TreeView
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents popWareInventory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInventorySeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventoryPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventorySafe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popBatchCodeSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInventoryBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Popexport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintNetAllBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popChangePrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareInventMothItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshWarringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInventoryBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintNetAllBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMothPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMonthDetail As System.Windows.Forms.ToolStripMenuItem
End Class
