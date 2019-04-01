<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPInfoMain
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
        Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPInfoMain))
        Me.sonsNum = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMRP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsMRPAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMRPEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMRPDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsMRPWatch = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMRPRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsMRPCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Print = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CalcType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_NeedBeginDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_NeedEndDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_MRPType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_MRPDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_WareID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.xtpDestBills = New DevExpress.XtraTab.XtraTabPage
        Me.grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MB_MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_MRPQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_MP_InventoryQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboMRPBillMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.gueMRPBillMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.xtbIndReq = New DevExpress.XtraTab.XtraTabPage
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Code = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Gauge = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Source = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.NeedQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Unit = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.NeedDate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.InvalidDate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.xtpOrderBills = New DevExpress.XtraTab.XtraTabPage
        Me.grid3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MOB_MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_MRPQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpPurchase = New DevExpress.XtraTab.XtraTabPage
        Me.grid4 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.MP_MRP_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Gauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_Source = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.MP_NeedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_MRPQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.MP_InventoryQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_InTransitQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_Inspection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_NoCollar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_RetreatQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_SecInv = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_LowLimit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_RelatedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_BatFixEconomy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.MP_BatchQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.xtpPurchaseCalcRecord = New DevExpress.XtraTab.XtraTabPage
        Me.Grid5 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Ware_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MRPQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.InventoryQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.InTransitQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Inspection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NoCollar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RetreatQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RelatedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.CreateUserName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MRPType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NeedBeginDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NeedEndDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ForecastID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.pbIndreq = New System.Windows.Forms.PictureBox
        Me.CalcType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMRP.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpDestBills.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRPBillMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gueMRPBillMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtbIndReq.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpOrderBills.SuspendLayout()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPurchase.SuspendLayout()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPurchaseCalcRecord.SuspendLayout()
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIndreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sonsNum
        '
        Me.sonsNum.Caption = "sonsNum"
        Me.sonsNum.FieldName = "sonsNum"
        Me.sonsNum.Name = "sonsNum"
        Me.sonsNum.OptionsColumn.AllowEdit = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 32)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "MRP物料需求運算"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbIndreq)
        Me.SplitContainer1.Size = New System.Drawing.Size(1005, 675)
        Me.SplitContainer1.SplitterDistance = 354
        Me.SplitContainer1.TabIndex = 170
        '
        'grid1
        '
        Me.grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid1.ContextMenuStrip = Me.cmsMRP
        Me.grid1.EmbeddedNavigator.Name = ""
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.MainView = Me.GridView1
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(1005, 354)
        Me.grid1.TabIndex = 0
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsMRP
        '
        Me.cmsMRP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsMRPAdd, Me.cmsMRPEdit, Me.cmsMRPDel, Me.ToolStripMenuItem1, Me.cmsMRPWatch, Me.cmsMRPRefresh, Me.ToolStripMenuItem2, Me.cmsMRPCheck, Me.tsm_Print})
        Me.cmsMRP.Name = "cmsMRP"
        Me.cmsMRP.Size = New System.Drawing.Size(216, 170)
        '
        'cmsMRPAdd
        '
        Me.cmsMRPAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsMRPAdd.Name = "cmsMRPAdd"
        Me.cmsMRPAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsMRPAdd.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPAdd.Text = "新增(&A)"
        '
        'cmsMRPEdit
        '
        Me.cmsMRPEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsMRPEdit.Name = "cmsMRPEdit"
        Me.cmsMRPEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsMRPEdit.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPEdit.Text = "修改(&E)"
        '
        'cmsMRPDel
        '
        Me.cmsMRPDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsMRPDel.Name = "cmsMRPDel"
        Me.cmsMRPDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsMRPDel.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPDel.Text = "刪除(&D)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(212, 6)
        '
        'cmsMRPWatch
        '
        Me.cmsMRPWatch.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsMRPWatch.Name = "cmsMRPWatch"
        Me.cmsMRPWatch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsMRPWatch.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPWatch.Text = "查看(&W)"
        '
        'cmsMRPRefresh
        '
        Me.cmsMRPRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsMRPRefresh.Name = "cmsMRPRefresh"
        Me.cmsMRPRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsMRPRefresh.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPRefresh.Text = "刷新(&R)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(212, 6)
        '
        'cmsMRPCheck
        '
        Me.cmsMRPCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsMRPCheck.Name = "cmsMRPCheck"
        Me.cmsMRPCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsMRPCheck.Size = New System.Drawing.Size(215, 22)
        Me.cmsMRPCheck.Text = "審核/取消審核(&G)"
        '
        'tsm_Print
        '
        Me.tsm_Print.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsm_Print.Name = "tsm_Print"
        Me.tsm_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsm_Print.Size = New System.Drawing.Size(215, 22)
        Me.tsm_Print.Text = "列印(&P)"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.MRP_ID, Me.MI_CalcType, Me.MI_NeedBeginDate, Me.MI_NeedEndDate, Me.MI_ForecastID, Me.MI_MRPType, Me.MI_MRPDate, Me.MI_WareID, Me.MI_CreateUserName, Me.MI_CreateDate, Me.MI_CheckBit, Me.MI_CheckDate, Me.MI_CheckRemark})
        Me.GridView1.GridControl = Me.grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.MRP_ID, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "運算單號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.MRP_ID.Visible = True
        Me.MRP_ID.VisibleIndex = 0
        Me.MRP_ID.Width = 110
        '
        'MI_CalcType
        '
        Me.MI_CalcType.Caption = "運算條件"
        Me.MI_CalcType.FieldName = "MI_CalcType"
        Me.MI_CalcType.Name = "MI_CalcType"
        Me.MI_CalcType.Visible = True
        Me.MI_CalcType.VisibleIndex = 1
        '
        'MI_NeedBeginDate
        '
        Me.MI_NeedBeginDate.Caption = "訂單開始日期"
        Me.MI_NeedBeginDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_NeedBeginDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_NeedBeginDate.FieldName = "MI_NeedBeginDate"
        Me.MI_NeedBeginDate.Name = "MI_NeedBeginDate"
        Me.MI_NeedBeginDate.Visible = True
        Me.MI_NeedBeginDate.VisibleIndex = 2
        Me.MI_NeedBeginDate.Width = 100
        '
        'MI_NeedEndDate
        '
        Me.MI_NeedEndDate.Caption = "訂單結束日期"
        Me.MI_NeedEndDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_NeedEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_NeedEndDate.FieldName = "MI_NeedEndDate"
        Me.MI_NeedEndDate.Name = "MI_NeedEndDate"
        Me.MI_NeedEndDate.Visible = True
        Me.MI_NeedEndDate.VisibleIndex = 3
        Me.MI_NeedEndDate.Width = 105
        '
        'MI_ForecastID
        '
        Me.MI_ForecastID.Caption = "預測單號"
        Me.MI_ForecastID.FieldName = "MI_ForecastID"
        Me.MI_ForecastID.Name = "MI_ForecastID"
        Me.MI_ForecastID.Visible = True
        Me.MI_ForecastID.VisibleIndex = 4
        Me.MI_ForecastID.Width = 103
        '
        'MI_MRPType
        '
        Me.MI_MRPType.Caption = "運算類型"
        Me.MI_MRPType.FieldName = "MI_MRPType"
        Me.MI_MRPType.Name = "MI_MRPType"
        Me.MI_MRPType.Visible = True
        Me.MI_MRPType.VisibleIndex = 5
        Me.MI_MRPType.Width = 69
        '
        'MI_MRPDate
        '
        Me.MI_MRPDate.Caption = "運算日期"
        Me.MI_MRPDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_MRPDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_MRPDate.FieldName = "MI_MRPDate"
        Me.MI_MRPDate.Name = "MI_MRPDate"
        Me.MI_MRPDate.Visible = True
        Me.MI_MRPDate.VisibleIndex = 6
        Me.MI_MRPDate.Width = 90
        '
        'MI_WareID
        '
        Me.MI_WareID.Caption = "庫存單號"
        Me.MI_WareID.FieldName = "MI_WareID"
        Me.MI_WareID.Name = "MI_WareID"
        Me.MI_WareID.Visible = True
        Me.MI_WareID.VisibleIndex = 7
        Me.MI_WareID.Width = 88
        '
        'MI_CreateUserName
        '
        Me.MI_CreateUserName.Caption = "創建人員"
        Me.MI_CreateUserName.FieldName = "MI_CreateUserName"
        Me.MI_CreateUserName.Name = "MI_CreateUserName"
        Me.MI_CreateUserName.Visible = True
        Me.MI_CreateUserName.VisibleIndex = 8
        Me.MI_CreateUserName.Width = 91
        '
        'MI_CreateDate
        '
        Me.MI_CreateDate.Caption = "創建日期"
        Me.MI_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_CreateDate.FieldName = "MI_CreateDate"
        Me.MI_CreateDate.Name = "MI_CreateDate"
        Me.MI_CreateDate.Visible = True
        Me.MI_CreateDate.VisibleIndex = 9
        Me.MI_CreateDate.Width = 85
        '
        'MI_CheckBit
        '
        Me.MI_CheckBit.Caption = "審核"
        Me.MI_CheckBit.FieldName = "MI_CheckBit"
        Me.MI_CheckBit.Name = "MI_CheckBit"
        Me.MI_CheckBit.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.MI_CheckBit.Visible = True
        Me.MI_CheckBit.VisibleIndex = 10
        Me.MI_CheckBit.Width = 48
        '
        'MI_CheckDate
        '
        Me.MI_CheckDate.Caption = "審核時間"
        Me.MI_CheckDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_CheckDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.MI_CheckDate.FieldName = "MI_CheckDate"
        Me.MI_CheckDate.Name = "MI_CheckDate"
        Me.MI_CheckDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.MI_CheckDate.Width = 81
        '
        'MI_CheckRemark
        '
        Me.MI_CheckRemark.Caption = "審核備注"
        Me.MI_CheckRemark.FieldName = "MI_CheckRemark"
        Me.MI_CheckRemark.Name = "MI_CheckRemark"
        Me.MI_CheckRemark.Visible = True
        Me.MI_CheckRemark.VisibleIndex = 11
        Me.MI_CheckRemark.Width = 349
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpDestBills
        Me.XtraTabControl1.Size = New System.Drawing.Size(1005, 317)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtbIndReq, Me.xtpDestBills, Me.xtpOrderBills, Me.xtpPurchase, Me.xtpPurchaseCalcRecord})
        '
        'xtpDestBills
        '
        Me.xtpDestBills.Controls.Add(Me.grid2)
        Me.xtpDestBills.Name = "xtpDestBills"
        Me.xtpDestBills.Size = New System.Drawing.Size(996, 285)
        Me.xtpDestBills.Text = "產品明細"
        '
        'grid2
        '
        Me.grid2.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid2.EmbeddedNavigator.Name = ""
        Me.grid2.Location = New System.Drawing.Point(0, 0)
        Me.grid2.MainView = Me.GridView2
        Me.grid2.Name = "grid2"
        Me.grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboMRPBillMaterial, Me.RepositoryItemComboBox1, Me.gueMRPBillMaterial})
        Me.grid2.Size = New System.Drawing.Size(996, 285)
        Me.grid2.TabIndex = 0
        Me.grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MB_MRP_ID, Me.MB_M_Code, Me.MB_M_Name, Me.MB_M_Gauge, Me.MB_Source, Me.MB_MRPQty, Me.MB_M_Unit, Me.MB_MP_InventoryQty})
        Me.GridView2.GridControl = Me.grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'MB_MRP_ID
        '
        Me.MB_MRP_ID.Caption = "運算編碼"
        Me.MB_MRP_ID.FieldName = "MRP_ID"
        Me.MB_MRP_ID.Name = "MB_MRP_ID"
        '
        'MB_M_Code
        '
        Me.MB_M_Code.Caption = "產品編碼"
        Me.MB_M_Code.FieldName = "M_Code"
        Me.MB_M_Code.Name = "MB_M_Code"
        Me.MB_M_Code.Visible = True
        Me.MB_M_Code.VisibleIndex = 0
        Me.MB_M_Code.Width = 140
        '
        'MB_M_Name
        '
        Me.MB_M_Name.Caption = "產品名稱"
        Me.MB_M_Name.FieldName = "M_Name"
        Me.MB_M_Name.Name = "MB_M_Name"
        Me.MB_M_Name.Visible = True
        Me.MB_M_Name.VisibleIndex = 1
        Me.MB_M_Name.Width = 178
        '
        'MB_M_Gauge
        '
        Me.MB_M_Gauge.Caption = "產品規格"
        Me.MB_M_Gauge.FieldName = "M_Gauge"
        Me.MB_M_Gauge.Name = "MB_M_Gauge"
        Me.MB_M_Gauge.Visible = True
        Me.MB_M_Gauge.VisibleIndex = 2
        Me.MB_M_Gauge.Width = 178
        '
        'MB_Source
        '
        Me.MB_Source.Caption = "來源碼"
        Me.MB_Source.FieldName = "Source"
        Me.MB_Source.Name = "MB_Source"
        Me.MB_Source.Visible = True
        Me.MB_Source.VisibleIndex = 3
        Me.MB_Source.Width = 71
        '
        'MB_MRPQty
        '
        Me.MB_MRPQty.Caption = "MRP凈需求"
        Me.MB_MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MB_MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MB_MRPQty.FieldName = "MB_MRPQty"
        Me.MB_MRPQty.Name = "MB_MRPQty"
        Me.MB_MRPQty.Visible = True
        Me.MB_MRPQty.VisibleIndex = 4
        Me.MB_MRPQty.Width = 87
        '
        'MB_M_Unit
        '
        Me.MB_M_Unit.Caption = "單位"
        Me.MB_M_Unit.FieldName = "M_Unit"
        Me.MB_M_Unit.Name = "MB_M_Unit"
        Me.MB_M_Unit.Visible = True
        Me.MB_M_Unit.VisibleIndex = 5
        Me.MB_M_Unit.Width = 50
        '
        'MB_MP_InventoryQty
        '
        Me.MB_MP_InventoryQty.Caption = "現有庫存"
        Me.MB_MP_InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MB_MP_InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MB_MP_InventoryQty.FieldName = "MP_InventoryQty"
        Me.MB_MP_InventoryQty.Name = "MB_MP_InventoryQty"
        Me.MB_MP_InventoryQty.Width = 70
        '
        'cboMRPBillMaterial
        '
        Me.cboMRPBillMaterial.AutoHeight = False
        Me.cboMRPBillMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMRPBillMaterial.Name = "cboMRPBillMaterial"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'gueMRPBillMaterial
        '
        Me.gueMRPBillMaterial.AutoHeight = False
        Me.gueMRPBillMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueMRPBillMaterial.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("M_Code", "物料編碼", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("M_Name", "物料名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("M_Gauge", "物料規格", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.gueMRPBillMaterial.Name = "gueMRPBillMaterial"
        Me.gueMRPBillMaterial.NullText = ""
        '
        'xtbIndReq
        '
        Me.xtbIndReq.Controls.Add(Me.TreeList1)
        Me.xtbIndReq.Name = "xtbIndReq"
        Me.xtbIndReq.Size = New System.Drawing.Size(996, 285)
        Me.xtbIndReq.Text = "獨立需求"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.Source, Me.NeedQty, Me.M_Unit, Me.sonsNum, Me.NeedDate, Me.InvalidDate})
        Me.TreeList1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.sonsNum
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = 0
        Me.TreeList1.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1})
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.ParentFieldName = "PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.TreeList1.Size = New System.Drawing.Size(996, 285)
        Me.TreeList1.TabIndex = 2
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "預測單號"
        Me.TreeListColumn1.FieldName = "ForecastID"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 115
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "客戶名稱"
        Me.TreeListColumn2.FieldName = "CustomerName"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        Me.TreeListColumn2.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 138
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 133
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 162
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "Source"
        Me.Source.Name = "Source"
        Me.Source.OptionsColumn.AllowEdit = False
        Me.Source.VisibleIndex = 5
        Me.Source.Width = 64
        '
        'NeedQty
        '
        Me.NeedQty.Caption = "需求數量"
        Me.NeedQty.FieldName = "NeedQty"
        Me.NeedQty.Format.FormatString = "#,###0.######"
        Me.NeedQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NeedQty.Name = "NeedQty"
        Me.NeedQty.OptionsColumn.AllowEdit = False
        Me.NeedQty.VisibleIndex = 6
        Me.NeedQty.Width = 65
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.VisibleIndex = 7
        Me.M_Unit.Width = 44
        '
        'NeedDate
        '
        Me.NeedDate.Caption = "需求日期"
        Me.NeedDate.FieldName = "NeedDate"
        Me.NeedDate.Format.FormatString = "yyyy/MM/dd"
        Me.NeedDate.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NeedDate.Name = "NeedDate"
        Me.NeedDate.OptionsColumn.AllowEdit = False
        Me.NeedDate.VisibleIndex = 8
        '
        'InvalidDate
        '
        Me.InvalidDate.Caption = "失效日期"
        Me.InvalidDate.FieldName = "InvalidDate"
        Me.InvalidDate.Format.FormatString = "yyyy/MM/dd"
        Me.InvalidDate.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.InvalidDate.Name = "InvalidDate"
        Me.InvalidDate.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'xtpOrderBills
        '
        Me.xtpOrderBills.Controls.Add(Me.grid3)
        Me.xtpOrderBills.Name = "xtpOrderBills"
        Me.xtpOrderBills.Size = New System.Drawing.Size(996, 285)
        Me.xtpOrderBills.Text = "訂單物料明細"
        '
        'grid3
        '
        Me.grid3.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid3.EmbeddedNavigator.Name = ""
        Me.grid3.Location = New System.Drawing.Point(0, 0)
        Me.grid3.MainView = Me.GridView3
        Me.grid3.Name = "grid3"
        Me.grid3.Size = New System.Drawing.Size(996, 285)
        Me.grid3.TabIndex = 1
        Me.grid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MOB_MRP_ID, Me.MOB_ForecastID, Me.OD_ID, Me.customerName, Me.MOB_NeedDate, Me.MOB_M_Code, Me.MOB_M_Name, Me.MOB_M_Gauge, Me.MOB_Source, Me.MOB_MRPQty, Me.MOB_M_Unit})
        Me.GridView3.GridControl = Me.grid3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'MOB_MRP_ID
        '
        Me.MOB_MRP_ID.Caption = "MRP_ID"
        Me.MOB_MRP_ID.FieldName = "MRP_ID"
        Me.MOB_MRP_ID.Name = "MOB_MRP_ID"
        '
        'MOB_ForecastID
        '
        Me.MOB_ForecastID.Caption = "預測訂單號"
        Me.MOB_ForecastID.FieldName = "MOB_ForecastID"
        Me.MOB_ForecastID.Name = "MOB_ForecastID"
        Me.MOB_ForecastID.Visible = True
        Me.MOB_ForecastID.VisibleIndex = 1
        Me.MOB_ForecastID.Width = 120
        '
        'OD_ID
        '
        Me.OD_ID.Caption = "訂單編號"
        Me.OD_ID.FieldName = "OD_ID"
        Me.OD_ID.Name = "OD_ID"
        Me.OD_ID.Width = 166
        '
        'customerName
        '
        Me.customerName.Caption = "客戶名稱"
        Me.customerName.FieldName = "customerName"
        Me.customerName.Name = "customerName"
        Me.customerName.Visible = True
        Me.customerName.VisibleIndex = 0
        Me.customerName.Width = 149
        '
        'MOB_NeedDate
        '
        Me.MOB_NeedDate.Caption = "交貨日期"
        Me.MOB_NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MOB_NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MOB_NeedDate.FieldName = "MOB_NeedDate"
        Me.MOB_NeedDate.Name = "MOB_NeedDate"
        Me.MOB_NeedDate.Visible = True
        Me.MOB_NeedDate.VisibleIndex = 2
        Me.MOB_NeedDate.Width = 86
        '
        'MOB_M_Code
        '
        Me.MOB_M_Code.Caption = "物料編碼"
        Me.MOB_M_Code.FieldName = "M_Code"
        Me.MOB_M_Code.Name = "MOB_M_Code"
        Me.MOB_M_Code.Visible = True
        Me.MOB_M_Code.VisibleIndex = 3
        Me.MOB_M_Code.Width = 137
        '
        'MOB_M_Name
        '
        Me.MOB_M_Name.Caption = "物料名稱"
        Me.MOB_M_Name.FieldName = "M_Name"
        Me.MOB_M_Name.Name = "MOB_M_Name"
        Me.MOB_M_Name.Visible = True
        Me.MOB_M_Name.VisibleIndex = 4
        Me.MOB_M_Name.Width = 141
        '
        'MOB_M_Gauge
        '
        Me.MOB_M_Gauge.Caption = "物料規格"
        Me.MOB_M_Gauge.FieldName = "M_Gauge"
        Me.MOB_M_Gauge.Name = "MOB_M_Gauge"
        Me.MOB_M_Gauge.Visible = True
        Me.MOB_M_Gauge.VisibleIndex = 5
        Me.MOB_M_Gauge.Width = 169
        '
        'MOB_Source
        '
        Me.MOB_Source.Caption = "來源碼"
        Me.MOB_Source.FieldName = "Source"
        Me.MOB_Source.Name = "MOB_Source"
        Me.MOB_Source.Visible = True
        Me.MOB_Source.VisibleIndex = 6
        Me.MOB_Source.Width = 64
        '
        'MOB_MRPQty
        '
        Me.MOB_MRPQty.Caption = "MRP凈需求"
        Me.MOB_MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MOB_MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOB_MRPQty.FieldName = "MOB_MRPQty"
        Me.MOB_MRPQty.Name = "MOB_MRPQty"
        Me.MOB_MRPQty.Visible = True
        Me.MOB_MRPQty.VisibleIndex = 7
        Me.MOB_MRPQty.Width = 85
        '
        'MOB_M_Unit
        '
        Me.MOB_M_Unit.Caption = "單位"
        Me.MOB_M_Unit.FieldName = "M_Unit"
        Me.MOB_M_Unit.Name = "MOB_M_Unit"
        Me.MOB_M_Unit.Visible = True
        Me.MOB_M_Unit.VisibleIndex = 8
        Me.MOB_M_Unit.Width = 52
        '
        'xtpPurchase
        '
        Me.xtpPurchase.Controls.Add(Me.grid4)
        Me.xtpPurchase.Name = "xtpPurchase"
        Me.xtpPurchase.Size = New System.Drawing.Size(996, 285)
        Me.xtpPurchase.Text = "請購建議"
        '
        'grid4
        '
        Me.grid4.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid4.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.grid4.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grid4.Location = New System.Drawing.Point(0, 0)
        Me.grid4.MainView = Me.BandedGridView1
        Me.grid4.Name = "grid4"
        Me.grid4.Size = New System.Drawing.Size(996, 285)
        Me.grid4.TabIndex = 1
        Me.grid4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.MP_MRP_ID, Me.MP_M_Code, Me.MP_M_Name, Me.MP_M_Gauge, Me.MP_Source, Me.MP_M_Unit, Me.MP_NeedQty, Me.MP_MRPQty, Me.MP_InventoryQty, Me.MP_InTransitQty, Me.MP_Inspection, Me.MP_NoCollar, Me.MP_RetreatQty, Me.MP_SecInv, Me.MP_LowLimit, Me.MP_BatchQty, Me.MP_BatFixEconomy, Me.MP_OrderMax, Me.MP_OrderMin, Me.MP_RelatedQty})
        Me.BandedGridView1.GridControl = Me.grid4
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsNavigation.UseTabKey = False
        Me.BandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "物料"
        Me.GridBand1.Columns.Add(Me.MP_MRP_ID)
        Me.GridBand1.Columns.Add(Me.MP_M_Code)
        Me.GridBand1.Columns.Add(Me.MP_M_Name)
        Me.GridBand1.Columns.Add(Me.MP_M_Gauge)
        Me.GridBand1.Columns.Add(Me.MP_Source)
        Me.GridBand1.Columns.Add(Me.MP_M_Unit)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.RowCount = 2
        Me.GridBand1.Width = 428
        '
        'MP_MRP_ID
        '
        Me.MP_MRP_ID.Caption = "MRP_ID"
        Me.MP_MRP_ID.FieldName = "MRP_ID"
        Me.MP_MRP_ID.Name = "MP_MRP_ID"
        Me.MP_MRP_ID.Width = 97
        '
        'MP_M_Code
        '
        Me.MP_M_Code.Caption = "物料編碼"
        Me.MP_M_Code.FieldName = "M_Code"
        Me.MP_M_Code.Name = "MP_M_Code"
        Me.MP_M_Code.Visible = True
        Me.MP_M_Code.Width = 126
        '
        'MP_M_Name
        '
        Me.MP_M_Name.Caption = "物料名稱"
        Me.MP_M_Name.FieldName = "M_Name"
        Me.MP_M_Name.Name = "MP_M_Name"
        Me.MP_M_Name.Visible = True
        Me.MP_M_Name.Width = 85
        '
        'MP_M_Gauge
        '
        Me.MP_M_Gauge.Caption = "物料規格"
        Me.MP_M_Gauge.FieldName = "M_Gauge"
        Me.MP_M_Gauge.Name = "MP_M_Gauge"
        Me.MP_M_Gauge.Visible = True
        Me.MP_M_Gauge.Width = 100
        '
        'MP_Source
        '
        Me.MP_Source.Caption = "來源碼"
        Me.MP_Source.FieldName = "Source"
        Me.MP_Source.Name = "MP_Source"
        Me.MP_Source.Visible = True
        Me.MP_Source.Width = 65
        '
        'MP_M_Unit
        '
        Me.MP_M_Unit.Caption = "單位"
        Me.MP_M_Unit.FieldName = "M_Unit"
        Me.MP_M_Unit.Name = "MP_M_Unit"
        Me.MP_M_Unit.Visible = True
        Me.MP_M_Unit.Width = 52
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "MRP數量"
        Me.GridBand2.Columns.Add(Me.MP_NeedQty)
        Me.GridBand2.Columns.Add(Me.MP_MRPQty)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 92
        '
        'MP_NeedQty
        '
        Me.MP_NeedQty.Caption = "總需求量"
        Me.MP_NeedQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_NeedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_NeedQty.FieldName = "MP_NeedQty"
        Me.MP_NeedQty.Name = "MP_NeedQty"
        Me.MP_NeedQty.Width = 76
        '
        'MP_MRPQty
        '
        Me.MP_MRPQty.Caption = "實際需求數量"
        Me.MP_MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_MRPQty.FieldName = "MP_MRPQty"
        Me.MP_MRPQty.Name = "MP_MRPQty"
        Me.MP_MRPQty.Visible = True
        Me.MP_MRPQty.Width = 92
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "庫存相關數量"
        Me.GridBand3.Columns.Add(Me.MP_InventoryQty)
        Me.GridBand3.Columns.Add(Me.MP_InTransitQty)
        Me.GridBand3.Columns.Add(Me.MP_Inspection)
        Me.GridBand3.Columns.Add(Me.MP_NoCollar)
        Me.GridBand3.Columns.Add(Me.MP_RetreatQty)
        Me.GridBand3.Columns.Add(Me.MP_SecInv)
        Me.GridBand3.Columns.Add(Me.MP_LowLimit)
        Me.GridBand3.Columns.Add(Me.MP_RelatedQty)
        Me.GridBand3.Columns.Add(Me.MP_BatFixEconomy)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 479
        '
        'MP_InventoryQty
        '
        Me.MP_InventoryQty.Caption = "庫存數量"
        Me.MP_InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_InventoryQty.FieldName = "MP_InventoryQty"
        Me.MP_InventoryQty.Name = "MP_InventoryQty"
        Me.MP_InventoryQty.Visible = True
        Me.MP_InventoryQty.Width = 70
        '
        'MP_InTransitQty
        '
        Me.MP_InTransitQty.Caption = "在途數量"
        Me.MP_InTransitQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_InTransitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_InTransitQty.FieldName = "MP_InTransitQty"
        Me.MP_InTransitQty.Name = "MP_InTransitQty"
        Me.MP_InTransitQty.Visible = True
        Me.MP_InTransitQty.Width = 68
        '
        'MP_Inspection
        '
        Me.MP_Inspection.Caption = "待驗量"
        Me.MP_Inspection.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_Inspection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_Inspection.FieldName = "MP_Inspection"
        Me.MP_Inspection.Name = "MP_Inspection"
        Me.MP_Inspection.Visible = True
        Me.MP_Inspection.Width = 57
        '
        'MP_NoCollar
        '
        Me.MP_NoCollar.Caption = "生產未領"
        Me.MP_NoCollar.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_NoCollar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_NoCollar.FieldName = "MP_NoCollar"
        Me.MP_NoCollar.Name = "MP_NoCollar"
        Me.MP_NoCollar.Visible = True
        Me.MP_NoCollar.Width = 70
        '
        'MP_RetreatQty
        '
        Me.MP_RetreatQty.Caption = "退貨數量"
        Me.MP_RetreatQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_RetreatQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_RetreatQty.FieldName = "MP_RetreatQty"
        Me.MP_RetreatQty.Name = "MP_RetreatQty"
        Me.MP_RetreatQty.Visible = True
        Me.MP_RetreatQty.Width = 69
        '
        'MP_SecInv
        '
        Me.MP_SecInv.Caption = "安全庫存"
        Me.MP_SecInv.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_SecInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_SecInv.FieldName = "MP_SecInv"
        Me.MP_SecInv.Name = "MP_SecInv"
        Me.MP_SecInv.Visible = True
        Me.MP_SecInv.Width = 70
        '
        'MP_LowLimit
        '
        Me.MP_LowLimit.Caption = "最低庫存"
        Me.MP_LowLimit.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_LowLimit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_LowLimit.FieldName = "MP_LowLimit"
        Me.MP_LowLimit.Name = "MP_LowLimit"
        Me.MP_LowLimit.Width = 70
        '
        'MP_RelatedQty
        '
        Me.MP_RelatedQty.Caption = "相關數量"
        Me.MP_RelatedQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_RelatedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_RelatedQty.FieldName = "MP_RelatedQty"
        Me.MP_RelatedQty.Name = "MP_RelatedQty"
        Me.MP_RelatedQty.Visible = True
        '
        'MP_BatFixEconomy
        '
        Me.MP_BatFixEconomy.Caption = "經濟批量"
        Me.MP_BatFixEconomy.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_BatFixEconomy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_BatFixEconomy.FieldName = "MP_BatFixEconomy"
        Me.MP_BatFixEconomy.Name = "MP_BatFixEconomy"
        Me.MP_BatFixEconomy.Width = 80
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "采購相關數量"
        Me.GridBand4.Columns.Add(Me.MP_BatchQty)
        Me.GridBand4.Columns.Add(Me.MP_OrderMax)
        Me.GridBand4.Columns.Add(Me.MP_OrderMin)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 233
        '
        'MP_BatchQty
        '
        Me.MP_BatchQty.Caption = "訂貨批量"
        Me.MP_BatchQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_BatchQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_BatchQty.FieldName = "MP_BatchQty"
        Me.MP_BatchQty.Name = "MP_BatchQty"
        Me.MP_BatchQty.Visible = True
        Me.MP_BatchQty.Width = 68
        '
        'MP_OrderMax
        '
        Me.MP_OrderMax.Caption = "最大定購量"
        Me.MP_OrderMax.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_OrderMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_OrderMax.FieldName = "MP_OrderMax"
        Me.MP_OrderMax.Name = "MP_OrderMax"
        Me.MP_OrderMax.Visible = True
        Me.MP_OrderMax.Width = 82
        '
        'MP_OrderMin
        '
        Me.MP_OrderMin.Caption = "最小定購量"
        Me.MP_OrderMin.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_OrderMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_OrderMin.FieldName = "MP_OrderMin"
        Me.MP_OrderMin.Name = "MP_OrderMin"
        Me.MP_OrderMin.Visible = True
        Me.MP_OrderMin.Width = 83
        '
        'xtpPurchaseCalcRecord
        '
        Me.xtpPurchaseCalcRecord.Controls.Add(Me.Grid5)
        Me.xtpPurchaseCalcRecord.Name = "xtpPurchaseCalcRecord"
        Me.xtpPurchaseCalcRecord.Size = New System.Drawing.Size(996, 285)
        Me.xtpPurchaseCalcRecord.Text = "請購建議記錄"
        '
        'Grid5
        '
        Me.Grid5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid5.EmbeddedNavigator.Name = ""
        GridLevelNode2.RelationName = "Level1"
        Me.Grid5.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Grid5.Location = New System.Drawing.Point(0, 0)
        Me.Grid5.MainView = Me.BandedGridView2
        Me.Grid5.Name = "Grid5"
        Me.Grid5.Size = New System.Drawing.Size(996, 285)
        Me.Grid5.TabIndex = 3
        Me.Grid5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView2})
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5, Me.GridBand6, Me.GridBand7, Me.GridBand8, Me.GridBand9})
        Me.BandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn9, Me.SN, Me.BandedGridColumn1, Me.Ware_ID, Me.MRPType, Me.BandedGridColumn2, Me.NeedBeginDate, Me.NeedEndDate, Me.ForecastID, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.BandedGridColumn7, Me.BandedGridColumn8, Me.MRPQty, Me.InventoryQty, Me.InTransitQty, Me.Inspection, Me.NoCollar, Me.RetreatQty, Me.RelatedQty, Me.CreateUserName, Me.CreateDate})
        Me.BandedGridView2.GridControl = Me.Grid5
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsBehavior.Editable = False
        Me.BandedGridView2.OptionsNavigation.UseTabKey = False
        Me.BandedGridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BandedGridView2.OptionsView.AutoCalcPreviewLineCount = True
        Me.BandedGridView2.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'GridBand5
        '
        Me.GridBand5.Columns.Add(Me.Ware_ID)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 89
        '
        'Ware_ID
        '
        Me.Ware_ID.Caption = "庫存單號"
        Me.Ware_ID.FieldName = "Ware_ID"
        Me.Ware_ID.Name = "Ware_ID"
        Me.Ware_ID.Visible = True
        Me.Ware_ID.Width = 89
        '
        'GridBand6
        '
        Me.GridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand6.Caption = "物料"
        Me.GridBand6.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn5)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn6)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn7)
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.RowCount = 2
        Me.GridBand6.Width = 501
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "物料編碼"
        Me.BandedGridColumn3.FieldName = "M_Code"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 133
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "物料名稱"
        Me.BandedGridColumn4.FieldName = "M_Name"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 117
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.Caption = "物料規格"
        Me.BandedGridColumn5.FieldName = "M_Gauge"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.Width = 134
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "來源碼"
        Me.BandedGridColumn6.FieldName = "Source"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.Width = 65
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.Caption = "單位"
        Me.BandedGridColumn7.FieldName = "M_Unit"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.Width = 52
        '
        'GridBand7
        '
        Me.GridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand7.Caption = "MRP數量"
        Me.GridBand7.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand7.Columns.Add(Me.MRPQty)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 92
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.Caption = "總需求量"
        Me.BandedGridColumn8.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn8.FieldName = "NeedQty"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.Width = 76
        '
        'MRPQty
        '
        Me.MRPQty.Caption = "實際需求數量"
        Me.MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MRPQty.FieldName = "MRPQty"
        Me.MRPQty.Name = "MRPQty"
        Me.MRPQty.Visible = True
        Me.MRPQty.Width = 92
        '
        'GridBand8
        '
        Me.GridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand8.Caption = "庫存相關數量"
        Me.GridBand8.Columns.Add(Me.InventoryQty)
        Me.GridBand8.Columns.Add(Me.InTransitQty)
        Me.GridBand8.Columns.Add(Me.Inspection)
        Me.GridBand8.Columns.Add(Me.NoCollar)
        Me.GridBand8.Columns.Add(Me.RetreatQty)
        Me.GridBand8.Columns.Add(Me.RelatedQty)
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 409
        '
        'InventoryQty
        '
        Me.InventoryQty.Caption = "庫存數量"
        Me.InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.InventoryQty.FieldName = "InventoryQty"
        Me.InventoryQty.Name = "InventoryQty"
        Me.InventoryQty.Visible = True
        Me.InventoryQty.Width = 70
        '
        'InTransitQty
        '
        Me.InTransitQty.Caption = "在途數量"
        Me.InTransitQty.DisplayFormat.FormatString = "#,###0.######"
        Me.InTransitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.InTransitQty.FieldName = "InTransitQty"
        Me.InTransitQty.Name = "InTransitQty"
        Me.InTransitQty.Visible = True
        Me.InTransitQty.Width = 68
        '
        'Inspection
        '
        Me.Inspection.Caption = "待驗量"
        Me.Inspection.DisplayFormat.FormatString = "#,###0.######"
        Me.Inspection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Inspection.FieldName = "Inspection"
        Me.Inspection.Name = "Inspection"
        Me.Inspection.Visible = True
        Me.Inspection.Width = 57
        '
        'NoCollar
        '
        Me.NoCollar.Caption = "生產未領"
        Me.NoCollar.DisplayFormat.FormatString = "#,###0.######"
        Me.NoCollar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NoCollar.FieldName = "NoCollar"
        Me.NoCollar.Name = "NoCollar"
        Me.NoCollar.Visible = True
        Me.NoCollar.Width = 70
        '
        'RetreatQty
        '
        Me.RetreatQty.Caption = "退貨數量"
        Me.RetreatQty.DisplayFormat.FormatString = "#,###0.######"
        Me.RetreatQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RetreatQty.FieldName = "RetreatQty"
        Me.RetreatQty.Name = "RetreatQty"
        Me.RetreatQty.Visible = True
        Me.RetreatQty.Width = 69
        '
        'RelatedQty
        '
        Me.RelatedQty.Caption = "相關數量"
        Me.RelatedQty.DisplayFormat.FormatString = "#,###0.######"
        Me.RelatedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RelatedQty.FieldName = "RelatedQty"
        Me.RelatedQty.Name = "RelatedQty"
        Me.RelatedQty.Visible = True
        '
        'GridBand9
        '
        Me.GridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand9.Caption = "創建信息"
        Me.GridBand9.Columns.Add(Me.CreateUserName)
        Me.GridBand9.Columns.Add(Me.CreateDate)
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 150
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建人員"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.Visible = True
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建時間"
        Me.CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.Visible = True
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.Caption = "AutoID"
        Me.BandedGridColumn9.FieldName = "AutoID"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        '
        'SN
        '
        Me.SN.Caption = "流水號"
        Me.SN.FieldName = "SN"
        Me.SN.Name = "SN"
        Me.SN.Width = 85
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "運算單號"
        Me.BandedGridColumn1.FieldName = "MRP_ID"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 87
        '
        'MRPType
        '
        Me.MRPType.Caption = "運算類型"
        Me.MRPType.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MRPType.FieldName = "MRPType"
        Me.MRPType.Name = "MRPType"
        Me.MRPType.Visible = True
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "運算條件"
        Me.BandedGridColumn2.FieldName = "CalcType"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.Visible = True
        '
        'NeedBeginDate
        '
        Me.NeedBeginDate.Caption = "訂單開始日期"
        Me.NeedBeginDate.FieldName = "NeedBeginDate"
        Me.NeedBeginDate.Name = "NeedBeginDate"
        Me.NeedBeginDate.Visible = True
        Me.NeedBeginDate.Width = 95
        '
        'NeedEndDate
        '
        Me.NeedEndDate.Caption = "訂單結束日期"
        Me.NeedEndDate.FieldName = "NeedEndDate"
        Me.NeedEndDate.Name = "NeedEndDate"
        Me.NeedEndDate.Visible = True
        Me.NeedEndDate.Width = 93
        '
        'ForecastID
        '
        Me.ForecastID.Caption = "預測單號"
        Me.ForecastID.FieldName = "ForecastID"
        Me.ForecastID.Name = "ForecastID"
        Me.ForecastID.Visible = True
        '
        'pbIndreq
        '
        Me.pbIndreq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbIndreq.BackColor = System.Drawing.Color.White
        Me.pbIndreq.Image = CType(resources.GetObject("pbIndreq.Image"), System.Drawing.Image)
        Me.pbIndreq.Location = New System.Drawing.Point(446, 111)
        Me.pbIndreq.Name = "pbIndreq"
        Me.pbIndreq.Size = New System.Drawing.Size(103, 106)
        Me.pbIndreq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbIndreq.TabIndex = 3
        Me.pbIndreq.TabStop = False
        Me.pbIndreq.Visible = False
        '
        'CalcType
        '
        Me.CalcType.Caption = "運算條件"
        Me.CalcType.FieldName = "CalcType"
        Me.CalcType.Name = "CalcType"
        Me.CalcType.Visible = True
        '
        'frmMRPInfoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 710)
        Me.ContextMenuStrip = Me.cmsMRP
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMRPInfoMain"
        Me.Text = "MRP物料需求運算"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMRP.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpDestBills.ResumeLayout(False)
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRPBillMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gueMRPBillMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtbIndReq.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpOrderBills.ResumeLayout(False)
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPurchase.ResumeLayout(False)
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPurchaseCalcRecord.ResumeLayout(False)
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIndreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_NeedBeginDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_NeedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_MRPDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_MRPType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMRP As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsMRPAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMRPEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMRPDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMRPWatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMRPCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMRPRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MI_CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpDestBills As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MB_MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_MRPQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_MP_InventoryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMRPBillMaterial As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gueMRPBillMaterial As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents xtpOrderBills As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MOB_MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpPurchase As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_MRP_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Gauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_NeedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_MRPQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_InventoryQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_InTransitQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_Inspection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_NoCollar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_RetreatQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_SecInv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_LowLimit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_BatchQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_OrderMax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_OrderMin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_BatFixEconomy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MOB_MRPQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_Source As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MI_CalcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm_Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xtbIndReq As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Code As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Gauge As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Source As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents NeedQty As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Unit As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents sonsNum As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents NeedDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents pbIndreq As System.Windows.Forms.PictureBox
    Friend WithEvents InvalidDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents MI_WareID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_RelatedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents xtpPurchaseCalcRecord As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CalcType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Grid5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Ware_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NeedBeginDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NeedEndDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ForecastID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MRPType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MRPQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents InventoryQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents InTransitQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Inspection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NoCollar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RetreatQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RelatedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
