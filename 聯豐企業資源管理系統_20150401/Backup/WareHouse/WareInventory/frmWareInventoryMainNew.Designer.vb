<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareInventoryMainNew
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
        Dim WIP_AddDateIN As DevExpress.XtraGrid.Columns.GridColumn
        Dim WO_AddDateOut As DevExpress.XtraGrid.Columns.GridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWareInventoryMainNew))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
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
        Me.ToolStripWareInventoryNG = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripInput = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripOutput = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
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
        Me.ToolStripShowSa = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMothPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMonthDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_ReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NGType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NGName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NGMaterial = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabInvent = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridInput = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WIP_IDIn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_QtyIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_RemarkIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ActionNameIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ReCheckIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GridOut = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WO_IDout = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_QtyOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_AllNameOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_PerNameOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_NameOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ActionNameOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_RemarkOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_CheckOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridMVOUT = New DevExpress.XtraGrid.GridControl
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MV_NOMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_QtyMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_DateMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InOrOutMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_AckMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_CheckMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_OutActionMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InActionMV_OUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.GridMVIN = New DevExpress.XtraGrid.GridControl
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MV_NOMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_QtyMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_DateMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InOrOutMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_AckMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_CheckMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_OutActionMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InActionMVIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.GridBroow = New DevExpress.XtraGrid.GridControl
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WB_NOB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_ReQtyB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_PerNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_NameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_DateB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_ActionNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WBR_NOB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DelayDateB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.GridReturn = New DevExpress.XtraGrid.GridControl
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WB_NOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_PerNameR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RR_PerNameR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_NameR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_DateR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_ActionNameR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PWS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InWareName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InAddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid10 = New DevExpress.XtraGrid.GridControl
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_InDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_InCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        WIP_AddDateIN = New DevExpress.XtraGrid.Columns.GridColumn
        WO_AddDateOut = New DevExpress.XtraGrid.Columns.GridColumn
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
        CType(Me.XtraTabInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabInvent.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridMVOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridMVIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GridBroow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.GridReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.Grid10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WIP_AddDateIN
        '
        WIP_AddDateIN.Caption = "入庫日期"
        WIP_AddDateIN.FieldName = "WIP_AddDate"
        WIP_AddDateIN.Name = "WIP_AddDateIN"
        WIP_AddDateIN.Visible = True
        WIP_AddDateIN.VisibleIndex = 2
        WIP_AddDateIN.Width = 80
        '
        'WO_AddDateOut
        '
        WO_AddDateOut.Caption = "出庫日期"
        WO_AddDateOut.FieldName = "WO_AddDate"
        WO_AddDateOut.Name = "WO_AddDateOut"
        WO_AddDateOut.OptionsColumn.ReadOnly = True
        WO_AddDateOut.Visible = True
        WO_AddDateOut.VisibleIndex = 3
        WO_AddDateOut.Width = 80
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 0
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barDockControlTop.Appearance.Options.UseFont = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 476)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 39
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
        Me.SplitContainer2.Size = New System.Drawing.Size(152, 476)
        Me.SplitContainer2.SplitterDistance = 137
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
        Me.twWare.Size = New System.Drawing.Size(152, 137)
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
        Me.twType.Size = New System.Drawing.Size(152, 335)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabInvent)
        Me.SplitContainer3.Size = New System.Drawing.Size(628, 476)
        Me.SplitContainer3.SplitterDistance = 178
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
        Me.Grid1.Size = New System.Drawing.Size(628, 178)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popWareInventory
        '
        Me.popWareInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripWareInventoryNG, Me.ToolStripInput, Me.ToolStripOutput, Me.ToolStripMenuItem4, Me.popWareInventorySeek, Me.popWareInventorySafe, Me.popChangePrice, Me.popWareInventoryPrint, Me.popBatchCodeSelect, Me.popWareInventoryBarCode, Me.popWareInventoryBarCodeMD, Me.Popexport, Me.COPYToolStripMenuItem, Me.ToolStripMenuItemALL, Me.WareInventMothItemToolStripMenuItem, Me.ToolStripMenuItem1, Me.RefreshWarringToolStripMenuItem, Me.ToolStripShowSa, Me.ToolStripMenuItem2, Me.ToolStripDetail, Me.ToolStripMenuItem3, Me.ToolStripMothPrice, Me.ToolStripMonthDetail})
        Me.popWareInventory.Name = "popWareInput"
        Me.popWareInventory.Size = New System.Drawing.Size(212, 446)
        '
        'ToolStripWareInventoryNG
        '
        Me.ToolStripWareInventoryNG.Name = "ToolStripWareInventoryNG"
        Me.ToolStripWareInventoryNG.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ToolStripWareInventoryNG.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripWareInventoryNG.Text = "次品倉關聯(&L)"
        '
        'ToolStripInput
        '
        Me.ToolStripInput.Name = "ToolStripInput"
        Me.ToolStripInput.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripInput.Text = "入庫(&I)"
        Me.ToolStripInput.Visible = False
        '
        'ToolStripOutput
        '
        Me.ToolStripOutput.Name = "ToolStripOutput"
        Me.ToolStripOutput.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripOutput.Text = "出庫(&O)"
        Me.ToolStripOutput.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(208, 6)
        Me.ToolStripMenuItem4.Visible = False
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
        'ToolStripShowSa
        '
        Me.ToolStripShowSa.Name = "ToolStripShowSa"
        Me.ToolStripShowSa.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripShowSa.Text = "顯示樣辦庫存"
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.GridColumn2, Me.GridColumn3, Me.PM_JiYu, Me.WI_Qty, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.NO_ReQty, Me.NGType, Me.NGName, Me.NGMaterial})
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
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.SummaryItem.DisplayFormat = "共:{0}條"
        Me.M_Code.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 125
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
        Me.GridColumn3.Width = 180
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "品名"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.ReadOnly = True
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 3
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存數量"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "單位"
        Me.GridColumn4.FieldName = "M_Unit"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "安全庫存"
        Me.GridColumn5.FieldName = "WI_SafeQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "倉庫編號"
        Me.GridColumn6.FieldName = "WH_ID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'NO_ReQty
        '
        Me.NO_ReQty.Caption = "未還數"
        Me.NO_ReQty.FieldName = "NO_ReQty"
        Me.NO_ReQty.Name = "NO_ReQty"
        Me.NO_ReQty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.NO_ReQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.NO_ReQty.Visible = True
        Me.NO_ReQty.VisibleIndex = 6
        '
        'NGType
        '
        Me.NGType.Caption = "類別"
        Me.NGType.FieldName = "NGType"
        Me.NGType.Name = "NGType"
        Me.NGType.OptionsColumn.ReadOnly = True
        '
        'NGName
        '
        Me.NGName.Caption = "產品名稱"
        Me.NGName.FieldName = "NGName"
        Me.NGName.Name = "NGName"
        Me.NGName.OptionsColumn.ReadOnly = True
        Me.NGName.Width = 90
        '
        'NGMaterial
        '
        Me.NGMaterial.Caption = "材質"
        Me.NGMaterial.FieldName = "NGMaterial"
        Me.NGMaterial.Name = "NGMaterial"
        Me.NGMaterial.OptionsColumn.ReadOnly = True
        '
        'XtraTabInvent
        '
        Me.XtraTabInvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabInvent.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabInvent.Name = "XtraTabInvent"
        Me.XtraTabInvent.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabInvent.Size = New System.Drawing.Size(628, 294)
        Me.XtraTabInvent.TabIndex = 0
        Me.XtraTabInvent.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage1.Text = "其它倉"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(619, 262)
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
        Me.GridView1.OptionsView.ColumnAutoWidth = False
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridInput)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage2.Text = "入庫記錄"
        '
        'GridInput
        '
        Me.GridInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInput.EmbeddedNavigator.Name = ""
        Me.GridInput.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridInput.Location = New System.Drawing.Point(0, 0)
        Me.GridInput.MainView = Me.GridView3
        Me.GridInput.Name = "GridInput"
        Me.GridInput.Size = New System.Drawing.Size(619, 262)
        Me.GridInput.TabIndex = 167
        Me.GridInput.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WIP_IDIn, Me.WIP_QtyIN, Me.WIP_RemarkIN, Me.WIP_ActionNameIN, WIP_AddDateIN, Me.WIP_ReCheckIN})
        Me.GridView3.GridControl = Me.GridInput
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'WIP_IDIn
        '
        Me.WIP_IDIn.Caption = "入庫單號"
        Me.WIP_IDIn.FieldName = "WIP_ID"
        Me.WIP_IDIn.Name = "WIP_IDIn"
        Me.WIP_IDIn.Visible = True
        Me.WIP_IDIn.VisibleIndex = 0
        Me.WIP_IDIn.Width = 90
        '
        'WIP_QtyIN
        '
        Me.WIP_QtyIN.Caption = "入庫數量"
        Me.WIP_QtyIN.FieldName = "WIP_Qty"
        Me.WIP_QtyIN.Name = "WIP_QtyIN"
        Me.WIP_QtyIN.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WIP_QtyIN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WIP_QtyIN.Visible = True
        Me.WIP_QtyIN.VisibleIndex = 1
        '
        'WIP_RemarkIN
        '
        Me.WIP_RemarkIN.Caption = "備註"
        Me.WIP_RemarkIN.FieldName = "WIP_Remark"
        Me.WIP_RemarkIN.Name = "WIP_RemarkIN"
        Me.WIP_RemarkIN.Visible = True
        Me.WIP_RemarkIN.VisibleIndex = 3
        '
        'WIP_ActionNameIN
        '
        Me.WIP_ActionNameIN.Caption = "操作員"
        Me.WIP_ActionNameIN.FieldName = "WIP_ActionName"
        Me.WIP_ActionNameIN.Name = "WIP_ActionNameIN"
        Me.WIP_ActionNameIN.Visible = True
        Me.WIP_ActionNameIN.VisibleIndex = 4
        '
        'WIP_ReCheckIN
        '
        Me.WIP_ReCheckIN.Caption = "復核"
        Me.WIP_ReCheckIN.FieldName = "WIP_ReCheck"
        Me.WIP_ReCheckIN.Name = "WIP_ReCheckIN"
        Me.WIP_ReCheckIN.Visible = True
        Me.WIP_ReCheckIN.VisibleIndex = 5
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridOut)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage3.Text = "出庫記錄"
        '
        'GridOut
        '
        Me.GridOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOut.EmbeddedNavigator.Name = ""
        Me.GridOut.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridOut.Location = New System.Drawing.Point(0, 0)
        Me.GridOut.MainView = Me.GridView4
        Me.GridOut.Name = "GridOut"
        Me.GridOut.Size = New System.Drawing.Size(619, 262)
        Me.GridOut.TabIndex = 168
        Me.GridOut.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WO_IDout, Me.WO_QtyOut, Me.WH_AllNameOut, Me.WO_PerNameOut, Me.DPT_NameOut, Me.WO_ActionNameOut, Me.WO_RemarkOut, Me.WO_CheckOut, WO_AddDateOut})
        Me.GridView4.GridControl = Me.GridOut
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView4.OptionsFilter.AllowFilterEditor = False
        Me.GridView4.OptionsFilter.AllowMRUFilterList = False
        Me.GridView4.OptionsMenu.EnableColumnMenu = False
        Me.GridView4.OptionsMenu.EnableFooterMenu = False
        Me.GridView4.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView4.OptionsSelection.MultiSelect = True
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'WO_IDout
        '
        Me.WO_IDout.Caption = "出庫單號"
        Me.WO_IDout.FieldName = "WO_ID"
        Me.WO_IDout.Name = "WO_IDout"
        Me.WO_IDout.OptionsColumn.ReadOnly = True
        Me.WO_IDout.Visible = True
        Me.WO_IDout.VisibleIndex = 0
        Me.WO_IDout.Width = 90
        '
        'WO_QtyOut
        '
        Me.WO_QtyOut.Caption = "出庫數量"
        Me.WO_QtyOut.FieldName = "WO_Qty"
        Me.WO_QtyOut.Name = "WO_QtyOut"
        Me.WO_QtyOut.OptionsColumn.ReadOnly = True
        Me.WO_QtyOut.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WO_QtyOut.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WO_QtyOut.Visible = True
        Me.WO_QtyOut.VisibleIndex = 1
        '
        'WH_AllNameOut
        '
        Me.WH_AllNameOut.Caption = "倉庫名稱"
        Me.WH_AllNameOut.FieldName = "WH_AllName"
        Me.WH_AllNameOut.Name = "WH_AllNameOut"
        Me.WH_AllNameOut.OptionsColumn.ReadOnly = True
        Me.WH_AllNameOut.Visible = True
        Me.WH_AllNameOut.VisibleIndex = 2
        '
        'WO_PerNameOut
        '
        Me.WO_PerNameOut.Caption = "領料人"
        Me.WO_PerNameOut.FieldName = "WO_PerName"
        Me.WO_PerNameOut.Name = "WO_PerNameOut"
        Me.WO_PerNameOut.OptionsColumn.ReadOnly = True
        Me.WO_PerNameOut.Visible = True
        Me.WO_PerNameOut.VisibleIndex = 4
        '
        'DPT_NameOut
        '
        Me.DPT_NameOut.Caption = "領料部門"
        Me.DPT_NameOut.FieldName = "DPT_Name"
        Me.DPT_NameOut.Name = "DPT_NameOut"
        Me.DPT_NameOut.OptionsColumn.ReadOnly = True
        Me.DPT_NameOut.Visible = True
        Me.DPT_NameOut.VisibleIndex = 5
        '
        'WO_ActionNameOut
        '
        Me.WO_ActionNameOut.Caption = "操作員"
        Me.WO_ActionNameOut.FieldName = "WO_ActionName"
        Me.WO_ActionNameOut.Name = "WO_ActionNameOut"
        Me.WO_ActionNameOut.OptionsColumn.ReadOnly = True
        Me.WO_ActionNameOut.Visible = True
        Me.WO_ActionNameOut.VisibleIndex = 6
        '
        'WO_RemarkOut
        '
        Me.WO_RemarkOut.Caption = "備註"
        Me.WO_RemarkOut.FieldName = "WO_Remark"
        Me.WO_RemarkOut.Name = "WO_RemarkOut"
        Me.WO_RemarkOut.OptionsColumn.ReadOnly = True
        Me.WO_RemarkOut.Visible = True
        Me.WO_RemarkOut.VisibleIndex = 7
        '
        'WO_CheckOut
        '
        Me.WO_CheckOut.Caption = "審核"
        Me.WO_CheckOut.FieldName = "WO_Check"
        Me.WO_CheckOut.Name = "WO_CheckOut"
        Me.WO_CheckOut.OptionsColumn.ReadOnly = True
        Me.WO_CheckOut.Width = 50
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridMVOUT)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage4.Text = "調撥發出"
        '
        'GridMVOUT
        '
        Me.GridMVOUT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMVOUT.EmbeddedNavigator.Name = ""
        Me.GridMVOUT.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridMVOUT.Location = New System.Drawing.Point(0, 0)
        Me.GridMVOUT.MainView = Me.GridView5
        Me.GridMVOUT.Name = "GridMVOUT"
        Me.GridMVOUT.Size = New System.Drawing.Size(619, 262)
        Me.GridMVOUT.TabIndex = 170
        Me.GridMVOUT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MV_NOMV_OUT, Me.MV_QtyMV_OUT, Me.MV_DateMV_OUT, Me.MV_InOrOutMV_OUT, Me.MV_AckMV_OUT, Me.MV_CheckMV_OUT, Me.MV_OutActionMV_OUT, Me.MV_InActionMV_OUT})
        Me.GridView5.GridControl = Me.GridMVOUT
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowColumnMoving = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView5.OptionsFilter.AllowFilterEditor = False
        Me.GridView5.OptionsFilter.AllowMRUFilterList = False
        Me.GridView5.OptionsMenu.EnableColumnMenu = False
        Me.GridView5.OptionsMenu.EnableFooterMenu = False
        Me.GridView5.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.RowAutoHeight = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'MV_NOMV_OUT
        '
        Me.MV_NOMV_OUT.Caption = "調撥單號"
        Me.MV_NOMV_OUT.FieldName = "MV_NO"
        Me.MV_NOMV_OUT.Name = "MV_NOMV_OUT"
        Me.MV_NOMV_OUT.Visible = True
        Me.MV_NOMV_OUT.VisibleIndex = 0
        Me.MV_NOMV_OUT.Width = 91
        '
        'MV_QtyMV_OUT
        '
        Me.MV_QtyMV_OUT.Caption = "調撥數量"
        Me.MV_QtyMV_OUT.FieldName = "MV_Qty"
        Me.MV_QtyMV_OUT.Name = "MV_QtyMV_OUT"
        Me.MV_QtyMV_OUT.SummaryItem.DisplayFormat = "合計:{0}"
        Me.MV_QtyMV_OUT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.MV_QtyMV_OUT.Visible = True
        Me.MV_QtyMV_OUT.VisibleIndex = 1
        '
        'MV_DateMV_OUT
        '
        Me.MV_DateMV_OUT.Caption = "日期"
        Me.MV_DateMV_OUT.FieldName = "MV_Date"
        Me.MV_DateMV_OUT.Name = "MV_DateMV_OUT"
        Me.MV_DateMV_OUT.Visible = True
        Me.MV_DateMV_OUT.VisibleIndex = 2
        '
        'MV_InOrOutMV_OUT
        '
        Me.MV_InOrOutMV_OUT.Caption = "收發性質"
        Me.MV_InOrOutMV_OUT.FieldName = "MV_InOrOut"
        Me.MV_InOrOutMV_OUT.Name = "MV_InOrOutMV_OUT"
        Me.MV_InOrOutMV_OUT.Visible = True
        Me.MV_InOrOutMV_OUT.VisibleIndex = 3
        '
        'MV_AckMV_OUT
        '
        Me.MV_AckMV_OUT.Caption = "確認"
        Me.MV_AckMV_OUT.FieldName = "MV_Ack"
        Me.MV_AckMV_OUT.Name = "MV_AckMV_OUT"
        Me.MV_AckMV_OUT.Visible = True
        Me.MV_AckMV_OUT.VisibleIndex = 4
        '
        'MV_CheckMV_OUT
        '
        Me.MV_CheckMV_OUT.Caption = "審核"
        Me.MV_CheckMV_OUT.FieldName = "MV_Check"
        Me.MV_CheckMV_OUT.Name = "MV_CheckMV_OUT"
        Me.MV_CheckMV_OUT.Visible = True
        Me.MV_CheckMV_OUT.VisibleIndex = 5
        '
        'MV_OutActionMV_OUT
        '
        Me.MV_OutActionMV_OUT.Caption = "發出操作人"
        Me.MV_OutActionMV_OUT.FieldName = "MV_OutAction"
        Me.MV_OutActionMV_OUT.Name = "MV_OutActionMV_OUT"
        Me.MV_OutActionMV_OUT.Visible = True
        Me.MV_OutActionMV_OUT.VisibleIndex = 6
        '
        'MV_InActionMV_OUT
        '
        Me.MV_InActionMV_OUT.Caption = "收入操作人"
        Me.MV_InActionMV_OUT.FieldName = "MV_InAction"
        Me.MV_InActionMV_OUT.Name = "MV_InActionMV_OUT"
        Me.MV_InActionMV_OUT.Visible = True
        Me.MV_InActionMV_OUT.VisibleIndex = 7
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridMVIN)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage5.Text = "調撥收入"
        '
        'GridMVIN
        '
        Me.GridMVIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMVIN.EmbeddedNavigator.Name = ""
        Me.GridMVIN.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridMVIN.Location = New System.Drawing.Point(0, 0)
        Me.GridMVIN.MainView = Me.GridView6
        Me.GridMVIN.Name = "GridMVIN"
        Me.GridMVIN.Size = New System.Drawing.Size(619, 262)
        Me.GridMVIN.TabIndex = 169
        Me.GridMVIN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MV_NOMVIN, Me.MV_QtyMVIN, Me.MV_DateMVIN, Me.MV_InOrOutMVIN, Me.MV_AckMVIN, Me.MV_CheckMVIN, Me.MV_OutActionMVIN, Me.MV_InActionMVIN})
        Me.GridView6.GridControl = Me.GridMVIN
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsCustomization.AllowColumnMoving = False
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView6.OptionsFilter.AllowFilterEditor = False
        Me.GridView6.OptionsFilter.AllowMRUFilterList = False
        Me.GridView6.OptionsMenu.EnableColumnMenu = False
        Me.GridView6.OptionsMenu.EnableFooterMenu = False
        Me.GridView6.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsSelection.MultiSelect = True
        Me.GridView6.OptionsView.ColumnAutoWidth = False
        Me.GridView6.OptionsView.RowAutoHeight = True
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'MV_NOMVIN
        '
        Me.MV_NOMVIN.Caption = "調撥單號"
        Me.MV_NOMVIN.FieldName = "MV_NO"
        Me.MV_NOMVIN.Name = "MV_NOMVIN"
        Me.MV_NOMVIN.Visible = True
        Me.MV_NOMVIN.VisibleIndex = 0
        Me.MV_NOMVIN.Width = 91
        '
        'MV_QtyMVIN
        '
        Me.MV_QtyMVIN.Caption = "調撥數量"
        Me.MV_QtyMVIN.FieldName = "MV_Qty"
        Me.MV_QtyMVIN.Name = "MV_QtyMVIN"
        Me.MV_QtyMVIN.SummaryItem.DisplayFormat = "合計:{0}"
        Me.MV_QtyMVIN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.MV_QtyMVIN.Visible = True
        Me.MV_QtyMVIN.VisibleIndex = 1
        '
        'MV_DateMVIN
        '
        Me.MV_DateMVIN.Caption = "日期"
        Me.MV_DateMVIN.FieldName = "MV_Date"
        Me.MV_DateMVIN.Name = "MV_DateMVIN"
        Me.MV_DateMVIN.Visible = True
        Me.MV_DateMVIN.VisibleIndex = 2
        '
        'MV_InOrOutMVIN
        '
        Me.MV_InOrOutMVIN.Caption = "收發性質"
        Me.MV_InOrOutMVIN.FieldName = "MV_InOrOut"
        Me.MV_InOrOutMVIN.Name = "MV_InOrOutMVIN"
        Me.MV_InOrOutMVIN.Visible = True
        Me.MV_InOrOutMVIN.VisibleIndex = 3
        '
        'MV_AckMVIN
        '
        Me.MV_AckMVIN.Caption = "確認"
        Me.MV_AckMVIN.FieldName = "MV_Ack"
        Me.MV_AckMVIN.Name = "MV_AckMVIN"
        Me.MV_AckMVIN.Visible = True
        Me.MV_AckMVIN.VisibleIndex = 4
        '
        'MV_CheckMVIN
        '
        Me.MV_CheckMVIN.Caption = "審核"
        Me.MV_CheckMVIN.FieldName = "MV_Check"
        Me.MV_CheckMVIN.Name = "MV_CheckMVIN"
        Me.MV_CheckMVIN.Visible = True
        Me.MV_CheckMVIN.VisibleIndex = 5
        '
        'MV_OutActionMVIN
        '
        Me.MV_OutActionMVIN.Caption = "發出操作人"
        Me.MV_OutActionMVIN.FieldName = "MV_OutAction"
        Me.MV_OutActionMVIN.Name = "MV_OutActionMVIN"
        Me.MV_OutActionMVIN.Visible = True
        Me.MV_OutActionMVIN.VisibleIndex = 6
        '
        'MV_InActionMVIN
        '
        Me.MV_InActionMVIN.Caption = "收入操作人"
        Me.MV_InActionMVIN.FieldName = "MV_InAction"
        Me.MV_InActionMVIN.Name = "MV_InActionMVIN"
        Me.MV_InActionMVIN.Visible = True
        Me.MV_InActionMVIN.VisibleIndex = 7
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GridBroow)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage6.Text = "借刀記錄"
        '
        'GridBroow
        '
        Me.GridBroow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBroow.EmbeddedNavigator.Name = ""
        Me.GridBroow.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridBroow.Location = New System.Drawing.Point(0, 0)
        Me.GridBroow.MainView = Me.GridView7
        Me.GridBroow.Name = "GridBroow"
        Me.GridBroow.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit1})
        Me.GridBroow.Size = New System.Drawing.Size(619, 262)
        Me.GridBroow.TabIndex = 172
        Me.GridBroow.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WB_NOB, Me.QtyB, Me.NO_ReQtyB, Me.WB_PerNameB, Me.DPT_NameB, Me.WB_DateB, Me.WB_ActionNameB, Me.WBR_NOB, Me.DelayDateB})
        Me.GridView7.GridControl = Me.GridBroow
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView7.OptionsCustomization.AllowColumnMoving = False
        Me.GridView7.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView7.OptionsFilter.AllowFilterEditor = False
        Me.GridView7.OptionsFilter.AllowMRUFilterList = False
        Me.GridView7.OptionsMenu.EnableColumnMenu = False
        Me.GridView7.OptionsMenu.EnableFooterMenu = False
        Me.GridView7.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView7.OptionsSelection.MultiSelect = True
        Me.GridView7.OptionsView.ColumnAutoWidth = False
        Me.GridView7.OptionsView.RowAutoHeight = True
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'WB_NOB
        '
        Me.WB_NOB.Caption = "借刀單號"
        Me.WB_NOB.FieldName = "WB_NO"
        Me.WB_NOB.Name = "WB_NOB"
        Me.WB_NOB.OptionsColumn.ReadOnly = True
        Me.WB_NOB.Visible = True
        Me.WB_NOB.VisibleIndex = 0
        Me.WB_NOB.Width = 92
        '
        'QtyB
        '
        Me.QtyB.Caption = "借出數量"
        Me.QtyB.FieldName = "Qty"
        Me.QtyB.Name = "QtyB"
        Me.QtyB.OptionsColumn.ReadOnly = True
        Me.QtyB.SummaryItem.DisplayFormat = "合計:{0}"
        Me.QtyB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QtyB.Visible = True
        Me.QtyB.VisibleIndex = 1
        '
        'NO_ReQtyB
        '
        Me.NO_ReQtyB.Caption = "未還數量"
        Me.NO_ReQtyB.FieldName = "NO_ReQty"
        Me.NO_ReQtyB.Name = "NO_ReQtyB"
        Me.NO_ReQtyB.OptionsColumn.ReadOnly = True
        Me.NO_ReQtyB.SummaryItem.DisplayFormat = "合計:{0}"
        Me.NO_ReQtyB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.NO_ReQtyB.Visible = True
        Me.NO_ReQtyB.VisibleIndex = 2
        '
        'WB_PerNameB
        '
        Me.WB_PerNameB.Caption = "借刀人"
        Me.WB_PerNameB.FieldName = "WB_PerName"
        Me.WB_PerNameB.Name = "WB_PerNameB"
        Me.WB_PerNameB.OptionsColumn.ReadOnly = True
        Me.WB_PerNameB.Visible = True
        Me.WB_PerNameB.VisibleIndex = 3
        '
        'DPT_NameB
        '
        Me.DPT_NameB.Caption = "部門"
        Me.DPT_NameB.FieldName = "DPT_Name"
        Me.DPT_NameB.Name = "DPT_NameB"
        Me.DPT_NameB.OptionsColumn.ReadOnly = True
        Me.DPT_NameB.Visible = True
        Me.DPT_NameB.VisibleIndex = 4
        '
        'WB_DateB
        '
        Me.WB_DateB.Caption = "借出日期"
        Me.WB_DateB.FieldName = "WB_Date"
        Me.WB_DateB.Name = "WB_DateB"
        Me.WB_DateB.OptionsColumn.ReadOnly = True
        Me.WB_DateB.Visible = True
        Me.WB_DateB.VisibleIndex = 5
        '
        'WB_ActionNameB
        '
        Me.WB_ActionNameB.Caption = "操作人"
        Me.WB_ActionNameB.FieldName = "WB_ActionName"
        Me.WB_ActionNameB.Name = "WB_ActionNameB"
        Me.WB_ActionNameB.OptionsColumn.ReadOnly = True
        Me.WB_ActionNameB.Visible = True
        Me.WB_ActionNameB.VisibleIndex = 6
        '
        'WBR_NOB
        '
        Me.WBR_NOB.Caption = "歸還單號"
        Me.WBR_NOB.FieldName = "WBR_NO"
        Me.WBR_NOB.Name = "WBR_NOB"
        Me.WBR_NOB.OptionsColumn.ReadOnly = True
        '
        'DelayDateB
        '
        Me.DelayDateB.Caption = "延期至"
        Me.DelayDateB.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.DelayDateB.FieldName = "DelayDate"
        Me.DelayDateB.Name = "DelayDateB"
        Me.DelayDateB.OptionsColumn.ReadOnly = True
        Me.DelayDateB.Visible = True
        Me.DelayDateB.VisibleIndex = 7
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GridReturn)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage7.Text = "還刀記錄"
        '
        'GridReturn
        '
        Me.GridReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReturn.EmbeddedNavigator.Name = ""
        Me.GridReturn.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridReturn.Location = New System.Drawing.Point(0, 0)
        Me.GridReturn.MainView = Me.GridView8
        Me.GridReturn.Name = "GridReturn"
        Me.GridReturn.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemMemoExEdit2})
        Me.GridReturn.Size = New System.Drawing.Size(619, 262)
        Me.GridReturn.TabIndex = 176
        Me.GridReturn.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WB_NOR, Me.QtyR, Me.WB_PerNameR, Me.RR_PerNameR, Me.DPT_NameR, Me.WB_DateR, Me.WB_ActionNameR})
        Me.GridView8.GridControl = Me.GridReturn
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView8.OptionsCustomization.AllowColumnMoving = False
        Me.GridView8.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView8.OptionsFilter.AllowFilterEditor = False
        Me.GridView8.OptionsFilter.AllowMRUFilterList = False
        Me.GridView8.OptionsMenu.EnableColumnMenu = False
        Me.GridView8.OptionsMenu.EnableFooterMenu = False
        Me.GridView8.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsSelection.MultiSelect = True
        Me.GridView8.OptionsView.ColumnAutoWidth = False
        Me.GridView8.OptionsView.RowAutoHeight = True
        Me.GridView8.OptionsView.ShowFooter = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'WB_NOR
        '
        Me.WB_NOR.Caption = "還刀單號"
        Me.WB_NOR.FieldName = "WB_NO"
        Me.WB_NOR.Name = "WB_NOR"
        Me.WB_NOR.OptionsColumn.ReadOnly = True
        Me.WB_NOR.Visible = True
        Me.WB_NOR.VisibleIndex = 0
        Me.WB_NOR.Width = 120
        '
        'QtyR
        '
        Me.QtyR.Caption = "歸還數量"
        Me.QtyR.FieldName = "Qty"
        Me.QtyR.Name = "QtyR"
        Me.QtyR.OptionsColumn.ReadOnly = True
        Me.QtyR.SummaryItem.DisplayFormat = "合計:{0}"
        Me.QtyR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QtyR.Visible = True
        Me.QtyR.VisibleIndex = 1
        '
        'WB_PerNameR
        '
        Me.WB_PerNameR.Caption = "還刀人"
        Me.WB_PerNameR.FieldName = "WB_PerName"
        Me.WB_PerNameR.Name = "WB_PerNameR"
        Me.WB_PerNameR.OptionsColumn.ReadOnly = True
        Me.WB_PerNameR.Visible = True
        Me.WB_PerNameR.VisibleIndex = 2
        '
        'RR_PerNameR
        '
        Me.RR_PerNameR.Caption = "代還人"
        Me.RR_PerNameR.FieldName = "RR_PerName"
        Me.RR_PerNameR.Name = "RR_PerNameR"
        Me.RR_PerNameR.OptionsColumn.ReadOnly = True
        Me.RR_PerNameR.Visible = True
        Me.RR_PerNameR.VisibleIndex = 3
        '
        'DPT_NameR
        '
        Me.DPT_NameR.Caption = "部門"
        Me.DPT_NameR.FieldName = "DPT_Name"
        Me.DPT_NameR.Name = "DPT_NameR"
        Me.DPT_NameR.Visible = True
        Me.DPT_NameR.VisibleIndex = 4
        '
        'WB_DateR
        '
        Me.WB_DateR.Caption = "還刀日期"
        Me.WB_DateR.FieldName = "WB_Date"
        Me.WB_DateR.Name = "WB_DateR"
        Me.WB_DateR.OptionsColumn.ReadOnly = True
        Me.WB_DateR.Visible = True
        Me.WB_DateR.VisibleIndex = 5
        '
        'WB_ActionNameR
        '
        Me.WB_ActionNameR.Caption = "操作人"
        Me.WB_ActionNameR.FieldName = "WB_ActionName"
        Me.WB_ActionNameR.Name = "WB_ActionNameR"
        Me.WB_ActionNameR.OptionsColumn.ReadOnly = True
        Me.WB_ActionNameR.Visible = True
        Me.WB_ActionNameR.VisibleIndex = 6
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.Grid)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage8.Text = "裝配出貨"
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView9
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(619, 262)
        Me.Grid.TabIndex = 4
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PWS_NO, Me.PS_Num, Me.PWS_M_Code, Me.M_Name, Me.M_Gauge, Me.PWS_Qty, Me.PWS_AddDate, Me.PWS_Action, Me.PWS_InWareName, Me.PWS_InAddDate, Me.PWS_InActionName, Me.PWS_Check, Me.PWS_InCheck, Me.PWS_CheckDate, Me.PWS_CheckAction, Me.PM_M_Code, Me.GridColumn1, Me.PM_Type})
        Me.GridView9.GridControl = Me.Grid
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsCustomization.AllowColumnMoving = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ColumnAutoWidth = False
        Me.GridView9.OptionsView.RowAutoHeight = True
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'PWS_NO
        '
        Me.PWS_NO.Caption = "出貨單號"
        Me.PWS_NO.FieldName = "PWS_NO"
        Me.PWS_NO.Name = "PWS_NO"
        Me.PWS_NO.Visible = True
        Me.PWS_NO.VisibleIndex = 0
        Me.PWS_NO.Width = 95
        '
        'PS_Num
        '
        Me.PS_Num.Caption = "項目流水號"
        Me.PS_Num.FieldName = "PS_Num"
        Me.PS_Num.Name = "PS_Num"
        Me.PS_Num.Width = 90
        '
        'PWS_M_Code
        '
        Me.PWS_M_Code.Caption = "物料編碼"
        Me.PWS_M_Code.FieldName = "PWS_M_Code"
        Me.PWS_M_Code.Name = "PWS_M_Code"
        Me.PWS_M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Width = 65
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Width = 80
        '
        'PWS_Qty
        '
        Me.PWS_Qty.Caption = "出貨數量"
        Me.PWS_Qty.FieldName = "PWS_Qty"
        Me.PWS_Qty.Name = "PWS_Qty"
        Me.PWS_Qty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.PWS_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PWS_Qty.Visible = True
        Me.PWS_Qty.VisibleIndex = 2
        '
        'PWS_AddDate
        '
        Me.PWS_AddDate.Caption = "出貨日期"
        Me.PWS_AddDate.FieldName = "PWS_AddDate"
        Me.PWS_AddDate.Name = "PWS_AddDate"
        Me.PWS_AddDate.Visible = True
        Me.PWS_AddDate.VisibleIndex = 3
        '
        'PWS_Action
        '
        Me.PWS_Action.Caption = "操作員"
        Me.PWS_Action.FieldName = "PWS_ActionName"
        Me.PWS_Action.Name = "PWS_Action"
        Me.PWS_Action.Visible = True
        Me.PWS_Action.VisibleIndex = 6
        Me.PWS_Action.Width = 65
        '
        'PWS_InWareName
        '
        Me.PWS_InWareName.Caption = "收貨倉庫"
        Me.PWS_InWareName.FieldName = "PWS_InName"
        Me.PWS_InWareName.Name = "PWS_InWareName"
        '
        'PWS_InAddDate
        '
        Me.PWS_InAddDate.Caption = "收貨日期"
        Me.PWS_InAddDate.FieldName = "PWS_InAddDate"
        Me.PWS_InAddDate.Name = "PWS_InAddDate"
        Me.PWS_InAddDate.Visible = True
        Me.PWS_InAddDate.VisibleIndex = 4
        '
        'PWS_InActionName
        '
        Me.PWS_InActionName.Caption = "收貨人員"
        Me.PWS_InActionName.FieldName = "PWS_InActionName"
        Me.PWS_InActionName.Name = "PWS_InActionName"
        Me.PWS_InActionName.Visible = True
        Me.PWS_InActionName.VisibleIndex = 5
        '
        'PWS_Check
        '
        Me.PWS_Check.Caption = "審核"
        Me.PWS_Check.FieldName = "PWS_Check"
        Me.PWS_Check.Name = "PWS_Check"
        Me.PWS_Check.Width = 55
        '
        'PWS_InCheck
        '
        Me.PWS_InCheck.Caption = "收貨確認"
        Me.PWS_InCheck.FieldName = "PWS_InCheck"
        Me.PWS_InCheck.Name = "PWS_InCheck"
        '
        'PWS_CheckDate
        '
        Me.PWS_CheckDate.Caption = "審核日期"
        Me.PWS_CheckDate.FieldName = "PWS_CheckDate"
        Me.PWS_CheckDate.Name = "PWS_CheckDate"
        '
        'PWS_CheckAction
        '
        Me.PWS_CheckAction.Caption = "審核員"
        Me.PWS_CheckAction.FieldName = "PWS_CheckActionName"
        Me.PWS_CheckAction.Name = "PWS_CheckAction"
        Me.PWS_CheckAction.Visible = True
        Me.PWS_CheckAction.VisibleIndex = 7
        Me.PWS_CheckAction.Width = 65
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "別名"
        Me.GridColumn1.FieldName = "PM_JiYu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 65
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.AllowEdit = False
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(587, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 14)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "LabelControl1"
        Me.LabelControl1.Visible = False
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.Grid10)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(619, 262)
        Me.XtraTabPage9.Text = "生產完工"
        '
        'Grid10
        '
        Me.Grid10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid10.EmbeddedNavigator.Name = ""
        Me.Grid10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid10.Location = New System.Drawing.Point(0, 0)
        Me.Grid10.MainView = Me.GridView10
        Me.Grid10.Name = "Grid10"
        Me.Grid10.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2})
        Me.Grid10.Size = New System.Drawing.Size(619, 262)
        Me.Grid10.TabIndex = 3
        Me.Grid10.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FP_NO, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.Pro_NO, Me.Pro_NO1, Me.FP_OutDep, Me.FP_InDep, Me.FP_Qty, Me.FP_Date, Me.FP_InCheckDate, Me.FP_Remark, Me.FP_Type, Me.FP_OutOK, Me.FP_Detail, Me.FP_OutType, Me.FP_Num, Me.FP_Check, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.AutoID})
        Me.GridView10.GridControl = Me.Grid10
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsCustomization.AllowColumnMoving = False
        Me.GridView10.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView10.OptionsFilter.AllowFilterEditor = False
        Me.GridView10.OptionsFilter.AllowMRUFilterList = False
        Me.GridView10.OptionsMenu.EnableColumnMenu = False
        Me.GridView10.OptionsMenu.EnableFooterMenu = False
        Me.GridView10.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView10.OptionsNavigation.UseTabKey = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ColumnAutoWidth = False
        Me.GridView10.OptionsView.RowAutoHeight = True
        Me.GridView10.OptionsView.ShowFooter = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'FP_NO
        '
        Me.FP_NO.Caption = "收發單號"
        Me.FP_NO.FieldName = "FP_NO"
        Me.FP_NO.Name = "FP_NO"
        Me.FP_NO.Visible = True
        Me.FP_NO.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "產品編號"
        Me.GridColumn7.FieldName = "PM_M_Code"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "別名"
        Me.GridColumn8.FieldName = "PM_JiYu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "類型"
        Me.GridColumn9.FieldName = "PM_Type"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'Pro_NO
        '
        Me.Pro_NO.Caption = "發料工序"
        Me.Pro_NO.FieldName = "PS_Name"
        Me.Pro_NO.Name = "Pro_NO"
        Me.Pro_NO.Visible = True
        Me.Pro_NO.VisibleIndex = 4
        Me.Pro_NO.Width = 88
        '
        'Pro_NO1
        '
        Me.Pro_NO1.Caption = "收料工序"
        Me.Pro_NO1.FieldName = "PS_Name1"
        Me.Pro_NO1.Name = "Pro_NO1"
        Me.Pro_NO1.Visible = True
        Me.Pro_NO1.VisibleIndex = 5
        Me.Pro_NO1.Width = 82
        '
        'FP_OutDep
        '
        Me.FP_OutDep.Caption = "部門"
        Me.FP_OutDep.FieldName = "DepOutName"
        Me.FP_OutDep.Name = "FP_OutDep"
        Me.FP_OutDep.Visible = True
        Me.FP_OutDep.VisibleIndex = 6
        '
        'FP_InDep
        '
        Me.FP_InDep.Caption = "變更部門"
        Me.FP_InDep.FieldName = "DepInName"
        Me.FP_InDep.Name = "FP_InDep"
        Me.FP_InDep.Visible = True
        Me.FP_InDep.VisibleIndex = 7
        '
        'FP_Qty
        '
        Me.FP_Qty.Caption = "數量"
        Me.FP_Qty.FieldName = "FP_Qty"
        Me.FP_Qty.Name = "FP_Qty"
        Me.FP_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FP_Qty.Visible = True
        Me.FP_Qty.VisibleIndex = 8
        '
        'FP_Date
        '
        Me.FP_Date.Caption = "發料時間"
        Me.FP_Date.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.FP_Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FP_Date.FieldName = "FP_Date"
        Me.FP_Date.Name = "FP_Date"
        Me.FP_Date.Visible = True
        Me.FP_Date.VisibleIndex = 9
        Me.FP_Date.Width = 90
        '
        'FP_InCheckDate
        '
        Me.FP_InCheckDate.Caption = "確認收料時間"
        Me.FP_InCheckDate.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.FP_InCheckDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FP_InCheckDate.FieldName = "FP_InCheckDates"
        Me.FP_InCheckDate.Name = "FP_InCheckDate"
        Me.FP_InCheckDate.Visible = True
        Me.FP_InCheckDate.VisibleIndex = 10
        Me.FP_InCheckDate.Width = 95
        '
        'FP_Remark
        '
        Me.FP_Remark.Caption = "備註"
        Me.FP_Remark.FieldName = "FP_Remark"
        Me.FP_Remark.Name = "FP_Remark"
        Me.FP_Remark.Visible = True
        Me.FP_Remark.VisibleIndex = 13
        '
        'FP_Type
        '
        Me.FP_Type.Caption = "收發類型"
        Me.FP_Type.FieldName = "FP_Type"
        Me.FP_Type.Name = "FP_Type"
        Me.FP_Type.Visible = True
        Me.FP_Type.VisibleIndex = 11
        '
        'FP_OutOK
        '
        Me.FP_OutOK.Caption = "確認發出"
        Me.FP_OutOK.FieldName = "FP_OutOK"
        Me.FP_OutOK.Name = "FP_OutOK"
        Me.FP_OutOK.Visible = True
        Me.FP_OutOK.VisibleIndex = 12
        '
        'FP_Detail
        '
        Me.FP_Detail.Caption = "屬性"
        Me.FP_Detail.FieldName = "PT_Type"
        Me.FP_Detail.Name = "FP_Detail"
        Me.FP_Detail.Visible = True
        Me.FP_Detail.VisibleIndex = 14
        '
        'FP_OutType
        '
        Me.FP_OutType.Caption = "外發類型"
        Me.FP_OutType.FieldName = "FP_OutType"
        Me.FP_OutType.Name = "FP_OutType"
        Me.FP_OutType.Visible = True
        Me.FP_OutType.VisibleIndex = 15
        '
        'FP_Num
        '
        Me.FP_Num.Caption = "流水號"
        Me.FP_Num.FieldName = "FP_Num"
        Me.FP_Num.Name = "FP_Num"
        '
        'FP_Check
        '
        Me.FP_Check.Caption = "審核"
        Me.FP_Check.FieldName = "FP_Check"
        Me.FP_Check.Name = "FP_Check"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "工藝類型"
        Me.GridColumn10.FieldName = "Pro_Type"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "發料員"
        Me.GridColumn11.FieldName = "FP_OutActionName"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "收料確認員"
        Me.GridColumn12.FieldName = "FP_InActionName"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'frmWareInventoryMainNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 500)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmWareInventoryMainNew"
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
        CType(Me.XtraTabInvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabInvent.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridMVOUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridMVIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GridBroow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GridReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.Grid10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
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
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQty As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents popWareInventoryBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintNetAllBarCodeMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Popexport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareInventMothItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshWarringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMothPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMonthDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripOutput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents XtraTabInvent As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridInput As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WIP_IDIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_QtyIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_RemarkIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ActionNameIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ReCheckIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridOut As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WO_IDout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_QtyOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_AllNameOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_PerNameOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_NameOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ActionNameOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_RemarkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_CheckOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridMVOUT As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MV_NOMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_QtyMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_DateMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InOrOutMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_AckMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_CheckMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_OutActionMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InActionMV_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridMVIN As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MV_NOMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_QtyMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_DateMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InOrOutMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_AckMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_CheckMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_OutActionMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InActionMVIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBroow As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WB_NOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_ReQtyB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_PerNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_NameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_DateB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_ActionNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WBR_NOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DelayDateB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridReturn As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WB_NOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_PerNameR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RR_PerNameR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_NameR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_DateR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_ActionNameR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NO_ReQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripShowSa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NGType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripWareInventoryNG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PWS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InWareName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InAddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid10 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_OutDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_InDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_InCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_OutOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_OutType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
