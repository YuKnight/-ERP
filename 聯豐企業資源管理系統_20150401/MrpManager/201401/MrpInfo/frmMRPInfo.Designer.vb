<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPInfo))
        Me.sonsNum = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pnlDeclare = New DevExpress.XtraEditors.PanelControl
        Me.lblDeclare = New System.Windows.Forms.Label
        Me.pceForecastID = New DevExpress.XtraEditors.PopupContainerEdit
        Me.pccForecastID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chklbForecastID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.btnGetPurchase = New DevExpress.XtraEditors.SimpleButton
        Me.btnInsertWareHouse = New DevExpress.XtraEditors.SimpleButton
        Me.prb = New DevExpress.XtraEditors.ProgressBarControl
        Me.chkForecastID = New DevExpress.XtraEditors.CheckEdit
        Me.chkDate = New DevExpress.XtraEditors.CheckEdit
        Me.dteNeedEndDate = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblWareID = New System.Windows.Forms.Label
        Me.lblDescrip = New System.Windows.Forms.Label
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.dteNeedBeginDate = New DevExpress.XtraEditors.DateEdit
        Me.txtlogtxt = New DevExpress.XtraEditors.MemoEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMRPType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnMrp = New DevExpress.XtraEditors.SimpleButton
        Me.txtMRP_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCreateUserName = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.dteCreateDate = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.xtpDestBills = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridMaterial1 = New DevExpress.XtraGrid.GridControl
        Me.GridViewMaterial1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsBill = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsBillAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdBillDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MB_AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.MB_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_MRPQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.MB_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MB_MP_InventoryQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpExamine = New DevExpress.XtraTab.XtraTabPage
        Me.xtpIndReq = New DevExpress.XtraTab.XtraTabPage
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
        Me.xtpOrderDestBills = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl2 = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridMaterial2 = New DevExpress.XtraGrid.GridControl
        Me.GridViewMaterial2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grid2 = New DevExpress.XtraGrid.GridControl
        Me.cmsOrderBill = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsOrderBillAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOrderBillDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MOB_AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deNeedDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.customerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.MOB_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MOB_MRPQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.MOB_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpPurchase = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl3 = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridMaterial3 = New DevExpress.XtraGrid.GridControl
        Me.GridViewMaterial3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grid3 = New DevExpress.XtraGrid.GridControl
        Me.cmsPurchase = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPurchaseAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurchaseDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPurchasePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemPopupContainerEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn17 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn16 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn18 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn19 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_AutoID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.xtpCheck = New DevExpress.XtraTab.XtraTabPage
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.lblCheckUser = New System.Windows.Forms.Label
        Me.chkCheck = New DevExpress.XtraEditors.CheckEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.MP_MRP_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Gauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_Source = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_M_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_NeedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_MRPQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_InventoryQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_InTransitQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_Inspection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_NoCollar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_RetreatQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_SecInv = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_LowLimit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_BatFixEconomy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_BatchQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RelatedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.pbIndreq = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pnlDeclare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDeclare.SuspendLayout()
        CType(Me.pceForecastID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccForecastID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccForecastID.SuspendLayout()
        CType(Me.chklbForecastID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkForecastID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNeedEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNeedBeginDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlogtxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRPType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMRP_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpDestBills.SuspendLayout()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.GridMaterial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMaterial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsBill.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpIndReq.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpOrderDestBills.SuspendLayout()
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl2.SuspendLayout()
        CType(Me.GridMaterial2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMaterial2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOrderBill.SuspendLayout()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNeedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPurchase.SuspendLayout()
        CType(Me.PopupContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl3.SuspendLayout()
        CType(Me.GridMaterial3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMaterial3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPurchase.SuspendLayout()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCheck.SuspendLayout()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIndreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sonsNum
        '
        Me.sonsNum.Caption = "sonsNum"
        Me.sonsNum.FieldName = "sonsNum"
        Me.sonsNum.Name = "sonsNum"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(1, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(175, 21)
        Me.lblTitle.TabIndex = 171
        Me.lblTitle.Text = "MRP物料需求運算"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1050, 32)
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnlDeclare)
        Me.GroupBox1.Controls.Add(Me.pceForecastID)
        Me.GroupBox1.Controls.Add(Me.btnGetPurchase)
        Me.GroupBox1.Controls.Add(Me.btnInsertWareHouse)
        Me.GroupBox1.Controls.Add(Me.prb)
        Me.GroupBox1.Controls.Add(Me.chkForecastID)
        Me.GroupBox1.Controls.Add(Me.chkDate)
        Me.GroupBox1.Controls.Add(Me.dteNeedEndDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dteNeedBeginDate)
        Me.GroupBox1.Controls.Add(Me.txtlogtxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboMRPType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnMrp)
        Me.GroupBox1.Controls.Add(Me.txtMRP_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1040, 162)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        '
        'pnlDeclare
        '
        Me.pnlDeclare.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlDeclare.Controls.Add(Me.lblDeclare)
        Me.pnlDeclare.Location = New System.Drawing.Point(357, 103)
        Me.pnlDeclare.Name = "pnlDeclare"
        Me.pnlDeclare.Size = New System.Drawing.Size(225, 19)
        Me.pnlDeclare.TabIndex = 183
        Me.pnlDeclare.Visible = False
        '
        'lblDeclare
        '
        Me.lblDeclare.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDeclare.AutoSize = True
        Me.lblDeclare.ForeColor = System.Drawing.Color.Red
        Me.lblDeclare.Location = New System.Drawing.Point(8, 5)
        Me.lblDeclare.Name = "lblDeclare"
        Me.lblDeclare.Size = New System.Drawing.Size(209, 12)
        Me.lblDeclare.TabIndex = 181
        Me.lblDeclare.Text = "轉庫存記錄后點擊生成請購建議以繼續"
        '
        'pceForecastID
        '
        Me.pceForecastID.Location = New System.Drawing.Point(131, 71)
        Me.pceForecastID.Name = "pceForecastID"
        Me.pceForecastID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.pceForecastID.Properties.Appearance.Options.UseFont = True
        Me.pceForecastID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceForecastID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.pceForecastID.Properties.PopupControl = Me.pccForecastID
        Me.pceForecastID.Size = New System.Drawing.Size(658, 24)
        Me.pceForecastID.TabIndex = 180
        '
        'pccForecastID
        '
        Me.pccForecastID.Controls.Add(Me.chklbForecastID)
        Me.pccForecastID.Location = New System.Drawing.Point(27, 16)
        Me.pccForecastID.Name = "pccForecastID"
        Me.pccForecastID.Size = New System.Drawing.Size(200, 218)
        Me.pccForecastID.TabIndex = 181
        Me.pccForecastID.Text = "PopupContainerControl4"
        '
        'chklbForecastID
        '
        Me.chklbForecastID.CheckOnClick = True
        Me.chklbForecastID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chklbForecastID.Location = New System.Drawing.Point(0, 0)
        Me.chklbForecastID.Name = "chklbForecastID"
        Me.chklbForecastID.Size = New System.Drawing.Size(200, 218)
        Me.chklbForecastID.TabIndex = 0
        '
        'btnGetPurchase
        '
        Me.btnGetPurchase.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnGetPurchase.Appearance.Options.UseFont = True
        Me.btnGetPurchase.Location = New System.Drawing.Point(795, 131)
        Me.btnGetPurchase.Name = "btnGetPurchase"
        Me.btnGetPurchase.Size = New System.Drawing.Size(100, 24)
        Me.btnGetPurchase.TabIndex = 177
        Me.btnGetPurchase.Text = "生成請購建議"
        '
        'btnInsertWareHouse
        '
        Me.btnInsertWareHouse.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnInsertWareHouse.Appearance.Options.UseFont = True
        Me.btnInsertWareHouse.Location = New System.Drawing.Point(795, 101)
        Me.btnInsertWareHouse.Name = "btnInsertWareHouse"
        Me.btnInsertWareHouse.Size = New System.Drawing.Size(100, 24)
        Me.btnInsertWareHouse.TabIndex = 176
        Me.btnInsertWareHouse.Text = "轉庫存記錄"
        '
        'prb
        '
        Me.prb.Location = New System.Drawing.Point(131, 101)
        Me.prb.Name = "prb"
        Me.prb.Properties.ShowTitle = True
        Me.prb.Properties.Step = 20
        Me.prb.Size = New System.Drawing.Size(658, 24)
        Me.prb.TabIndex = 175
        Me.prb.Visible = False
        '
        'chkForecastID
        '
        Me.chkForecastID.Location = New System.Drawing.Point(6, 75)
        Me.chkForecastID.Name = "chkForecastID"
        Me.chkForecastID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.chkForecastID.Properties.Appearance.Options.UseFont = True
        Me.chkForecastID.Properties.Caption = "預測訂單單號："
        Me.chkForecastID.Size = New System.Drawing.Size(123, 20)
        Me.chkForecastID.TabIndex = 174
        '
        'chkDate
        '
        Me.chkDate.EditValue = True
        Me.chkDate.Location = New System.Drawing.Point(6, 43)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.chkDate.Properties.Appearance.Options.UseFont = True
        Me.chkDate.Properties.Caption = "訂單開始日期："
        Me.chkDate.Size = New System.Drawing.Size(124, 20)
        Me.chkDate.TabIndex = 173
        '
        'dteNeedEndDate
        '
        Me.dteNeedEndDate.EditValue = Nothing
        Me.dteNeedEndDate.Location = New System.Drawing.Point(407, 41)
        Me.dteNeedEndDate.Name = "dteNeedEndDate"
        Me.dteNeedEndDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dteNeedEndDate.Properties.Appearance.Options.UseFont = True
        Me.dteNeedEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNeedEndDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dteNeedEndDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNeedEndDate.Size = New System.Drawing.Size(150, 24)
        Me.dteNeedEndDate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "訂單結束日期："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblWareID)
        Me.GroupBox2.Controls.Add(Me.lblDescrip)
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(562, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 58)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "運算說明"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "庫存記錄單號:"
        '
        'lblWareID
        '
        Me.lblWareID.AutoSize = True
        Me.lblWareID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWareID.ForeColor = System.Drawing.Color.Red
        Me.lblWareID.Location = New System.Drawing.Point(104, 36)
        Me.lblWareID.Name = "lblWareID"
        Me.lblWareID.Size = New System.Drawing.Size(15, 15)
        Me.lblWareID.TabIndex = 101
        Me.lblWareID.Text = "  "
        '
        'lblDescrip
        '
        Me.lblDescrip.AutoSize = True
        Me.lblDescrip.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblDescrip.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDescrip.Location = New System.Drawing.Point(6, 18)
        Me.lblDescrip.Name = "lblDescrip"
        Me.lblDescrip.Size = New System.Drawing.Size(112, 15)
        Me.lblDescrip.TabIndex = 100
        Me.lblDescrip.Text = "按訂單交期運算"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(131, 131)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(658, 24)
        Me.txtRemarks.TabIndex = 97
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "運算備注："
        '
        'dteNeedBeginDate
        '
        Me.dteNeedBeginDate.EditValue = Nothing
        Me.dteNeedBeginDate.Location = New System.Drawing.Point(131, 41)
        Me.dteNeedBeginDate.Name = "dteNeedBeginDate"
        Me.dteNeedBeginDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dteNeedBeginDate.Properties.Appearance.Options.UseFont = True
        Me.dteNeedBeginDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNeedBeginDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dteNeedBeginDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNeedBeginDate.Size = New System.Drawing.Size(150, 24)
        Me.dteNeedBeginDate.TabIndex = 3
        '
        'txtlogtxt
        '
        Me.txtlogtxt.Enabled = False
        Me.txtlogtxt.Location = New System.Drawing.Point(131, 101)
        Me.txtlogtxt.Name = "txtlogtxt"
        Me.txtlogtxt.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtlogtxt.Properties.Appearance.Options.UseFont = True
        Me.txtlogtxt.Properties.ReadOnly = True
        Me.txtlogtxt.Size = New System.Drawing.Size(658, 24)
        Me.txtlogtxt.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "運算日志："
        '
        'cboMRPType
        '
        Me.cboMRPType.EditValue = "正式"
        Me.cboMRPType.Location = New System.Drawing.Point(407, 13)
        Me.cboMRPType.Name = "cboMRPType"
        Me.cboMRPType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cboMRPType.Properties.Appearance.Options.UseFont = True
        Me.cboMRPType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMRPType.Properties.Items.AddRange(New Object() {"模擬", "正式"})
        Me.cboMRPType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMRPType.Size = New System.Drawing.Size(150, 24)
        Me.cboMRPType.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "計劃運算類型："
        '
        'btnMrp
        '
        Me.btnMrp.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnMrp.Appearance.Options.UseFont = True
        Me.btnMrp.Location = New System.Drawing.Point(795, 71)
        Me.btnMrp.Name = "btnMrp"
        Me.btnMrp.Size = New System.Drawing.Size(100, 24)
        Me.btnMrp.TabIndex = 6
        Me.btnMrp.Text = "獲取訂單物料"
        '
        'txtMRP_ID
        '
        Me.txtMRP_ID.Enabled = False
        Me.txtMRP_ID.Location = New System.Drawing.Point(131, 11)
        Me.txtMRP_ID.Name = "txtMRP_ID"
        Me.txtMRP_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMRP_ID.Properties.Appearance.Options.UseFont = True
        Me.txtMRP_ID.Properties.ReadOnly = True
        Me.txtMRP_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtMRP_ID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "計劃運算編碼："
        '
        'txtCreateUserName
        '
        Me.txtCreateUserName.Enabled = False
        Me.txtCreateUserName.Location = New System.Drawing.Point(643, 4)
        Me.txtCreateUserName.Name = "txtCreateUserName"
        Me.txtCreateUserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCreateUserName.Properties.Appearance.Options.UseFont = True
        Me.txtCreateUserName.Properties.ReadOnly = True
        Me.txtCreateUserName.Size = New System.Drawing.Size(150, 24)
        Me.txtCreateUserName.TabIndex = 95
        Me.txtCreateUserName.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(566, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "創建人員："
        Me.Label9.Visible = False
        '
        'dteCreateDate
        '
        Me.dteCreateDate.EditValue = Nothing
        Me.dteCreateDate.Enabled = False
        Me.dteCreateDate.Location = New System.Drawing.Point(410, 4)
        Me.dteCreateDate.Name = "dteCreateDate"
        Me.dteCreateDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dteCreateDate.Properties.Appearance.Options.UseFont = True
        Me.dteCreateDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteCreateDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dteCreateDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteCreateDate.Size = New System.Drawing.Size(150, 24)
        Me.dteCreateDate.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(333, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "創建日期："
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(950, 536)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "退出"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnSave.Location = New System.Drawing.Point(848, 536)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "保存"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 204)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpDestBills
        Me.XtraTabControl1.Size = New System.Drawing.Size(1041, 328)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpExamine, Me.xtpIndReq, Me.xtpDestBills, Me.xtpOrderDestBills, Me.xtpPurchase, Me.xtpCheck})
        '
        'xtpDestBills
        '
        Me.xtpDestBills.Controls.Add(Me.pccForecastID)
        Me.xtpDestBills.Controls.Add(Me.PopupContainerControl1)
        Me.xtpDestBills.Controls.Add(Me.grid1)
        Me.xtpDestBills.Name = "xtpDestBills"
        Me.xtpDestBills.Size = New System.Drawing.Size(1032, 296)
        Me.xtpDestBills.Text = "產品明細"
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.GridMaterial1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(233, 46)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(397, 185)
        Me.PopupContainerControl1.TabIndex = 1
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'GridMaterial1
        '
        Me.GridMaterial1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterial1.EmbeddedNavigator.Name = ""
        Me.GridMaterial1.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterial1.MainView = Me.GridViewMaterial1
        Me.GridMaterial1.Name = "GridMaterial1"
        Me.GridMaterial1.Size = New System.Drawing.Size(397, 185)
        Me.GridMaterial1.TabIndex = 0
        Me.GridMaterial1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMaterial1})
        '
        'GridViewMaterial1
        '
        Me.GridViewMaterial1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridViewMaterial1.GridControl = Me.GridMaterial1
        Me.GridViewMaterial1.Name = "GridViewMaterial1"
        Me.GridViewMaterial1.OptionsBehavior.Editable = False
        Me.GridViewMaterial1.OptionsView.ColumnAutoWidth = False
        Me.GridViewMaterial1.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMaterial1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "物料編碼"
        Me.GridColumn1.FieldName = "M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 119
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料名稱"
        Me.GridColumn2.FieldName = "M_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 106
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料規格"
        Me.GridColumn3.FieldName = "M_Gauge"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 147
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "單位"
        Me.GridColumn4.FieldName = "M_Unit"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'grid1
        '
        Me.grid1.ContextMenuStrip = Me.cmsBill
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EmbeddedNavigator.Name = ""
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.MainView = Me.GridView2
        Me.grid1.Name = "grid1"
        Me.grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemPopupContainerEdit1})
        Me.grid1.Size = New System.Drawing.Size(1032, 296)
        Me.grid1.TabIndex = 0
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'cmsBill
        '
        Me.cmsBill.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsBillAdd, Me.cmdBillDel})
        Me.cmsBill.Name = "cmsBill"
        Me.cmsBill.Size = New System.Drawing.Size(163, 48)
        '
        'cmsBillAdd
        '
        Me.cmsBillAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsBillAdd.Name = "cmsBillAdd"
        Me.cmsBillAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsBillAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsBillAdd.Text = "新增(&A)"
        '
        'cmdBillDel
        '
        Me.cmdBillDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdBillDel.Name = "cmdBillDel"
        Me.cmdBillDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdBillDel.Size = New System.Drawing.Size(162, 22)
        Me.cmdBillDel.Text = "刪除(&D)"
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MB_AutoID, Me.MB_MRP_ID, Me.MB_M_Code, Me.MB_M_Name, Me.MB_M_Gauge, Me.MB_Source, Me.MB_MRPQty, Me.MB_M_Unit, Me.MB_MP_InventoryQty})
        Me.GridView2.GridControl = Me.grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'MB_AutoID
        '
        Me.MB_AutoID.Caption = "AutoID"
        Me.MB_AutoID.FieldName = "AutoID"
        Me.MB_AutoID.Name = "MB_AutoID"
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
        Me.MB_M_Code.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.MB_M_Code.FieldName = "M_Code"
        Me.MB_M_Code.Name = "MB_M_Code"
        Me.MB_M_Code.SummaryItem.DisplayFormat = "記錄條數：{0}"
        Me.MB_M_Code.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.MB_M_Code.Visible = True
        Me.MB_M_Code.VisibleIndex = 0
        Me.MB_M_Code.Width = 144
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl1
        '
        'MB_M_Name
        '
        Me.MB_M_Name.Caption = "產品名稱"
        Me.MB_M_Name.FieldName = "M_Name"
        Me.MB_M_Name.Name = "MB_M_Name"
        Me.MB_M_Name.OptionsColumn.AllowEdit = False
        Me.MB_M_Name.Visible = True
        Me.MB_M_Name.VisibleIndex = 1
        Me.MB_M_Name.Width = 161
        '
        'MB_M_Gauge
        '
        Me.MB_M_Gauge.Caption = "產品規格"
        Me.MB_M_Gauge.FieldName = "M_Gauge"
        Me.MB_M_Gauge.Name = "MB_M_Gauge"
        Me.MB_M_Gauge.OptionsColumn.AllowEdit = False
        Me.MB_M_Gauge.Visible = True
        Me.MB_M_Gauge.VisibleIndex = 2
        Me.MB_M_Gauge.Width = 171
        '
        'MB_Source
        '
        Me.MB_Source.Caption = "來源碼"
        Me.MB_Source.FieldName = "Source"
        Me.MB_Source.Name = "MB_Source"
        Me.MB_Source.Visible = True
        Me.MB_Source.VisibleIndex = 3
        Me.MB_Source.Width = 70
        '
        'MB_MRPQty
        '
        Me.MB_MRPQty.Caption = "MRP凈需求"
        Me.MB_MRPQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MB_MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MB_MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MB_MRPQty.FieldName = "MRPQty"
        Me.MB_MRPQty.Name = "MB_MRPQty"
        Me.MB_MRPQty.Visible = True
        Me.MB_MRPQty.VisibleIndex = 4
        Me.MB_MRPQty.Width = 95
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'MB_M_Unit
        '
        Me.MB_M_Unit.Caption = "單位"
        Me.MB_M_Unit.FieldName = "M_Unit"
        Me.MB_M_Unit.Name = "MB_M_Unit"
        Me.MB_M_Unit.OptionsColumn.AllowEdit = False
        Me.MB_M_Unit.Visible = True
        Me.MB_M_Unit.VisibleIndex = 5
        Me.MB_M_Unit.Width = 49
        '
        'MB_MP_InventoryQty
        '
        Me.MB_MP_InventoryQty.Caption = "現有庫存"
        Me.MB_MP_InventoryQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MB_MP_InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MB_MP_InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MB_MP_InventoryQty.FieldName = "MP_InventoryQty"
        Me.MB_MP_InventoryQty.Name = "MB_MP_InventoryQty"
        Me.MB_MP_InventoryQty.Width = 70
        '
        'xtpExamine
        '
        Me.xtpExamine.Name = "xtpExamine"
        Me.xtpExamine.PageVisible = False
        Me.xtpExamine.Size = New System.Drawing.Size(1032, 296)
        Me.xtpExamine.Text = "運算稽核"
        '
        'xtpIndReq
        '
        Me.xtpIndReq.Controls.Add(Me.TreeList1)
        Me.xtpIndReq.Name = "xtpIndReq"
        Me.xtpIndReq.Size = New System.Drawing.Size(1032, 296)
        Me.xtpIndReq.Text = "獨立需求"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.Source, Me.NeedQty, Me.M_Unit, Me.sonsNum, Me.NeedDate, Me.InvalidDate})
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
        Me.TreeList1.Size = New System.Drawing.Size(1032, 296)
        Me.TreeList1.TabIndex = 1
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "預測單號"
        Me.TreeListColumn1.FieldName = "ForecastID"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 115
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "客戶名稱"
        Me.TreeListColumn2.FieldName = "CustomerName"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 175
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 133
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 162
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "Source"
        Me.Source.Name = "Source"
        Me.Source.VisibleIndex = 5
        Me.Source.Width = 69
        '
        'NeedQty
        '
        Me.NeedQty.Caption = "需求數量"
        Me.NeedQty.FieldName = "NeedQty"
        Me.NeedQty.Format.FormatString = "#,###0.######"
        Me.NeedQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NeedQty.Name = "NeedQty"
        Me.NeedQty.VisibleIndex = 6
        Me.NeedQty.Width = 82
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
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
        'xtpOrderDestBills
        '
        Me.xtpOrderDestBills.Controls.Add(Me.PopupContainerControl2)
        Me.xtpOrderDestBills.Controls.Add(Me.grid2)
        Me.xtpOrderDestBills.Name = "xtpOrderDestBills"
        Me.xtpOrderDestBills.Size = New System.Drawing.Size(1032, 296)
        Me.xtpOrderDestBills.Text = "訂單物料明細"
        '
        'PopupContainerControl2
        '
        Me.PopupContainerControl2.Controls.Add(Me.GridMaterial2)
        Me.PopupContainerControl2.Location = New System.Drawing.Point(274, 85)
        Me.PopupContainerControl2.Name = "PopupContainerControl2"
        Me.PopupContainerControl2.Size = New System.Drawing.Size(397, 185)
        Me.PopupContainerControl2.TabIndex = 2
        Me.PopupContainerControl2.Text = "PopupContainerControl2"
        '
        'GridMaterial2
        '
        Me.GridMaterial2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterial2.EmbeddedNavigator.Name = ""
        Me.GridMaterial2.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterial2.MainView = Me.GridViewMaterial2
        Me.GridMaterial2.Name = "GridMaterial2"
        Me.GridMaterial2.Size = New System.Drawing.Size(397, 185)
        Me.GridMaterial2.TabIndex = 0
        Me.GridMaterial2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMaterial2})
        '
        'GridViewMaterial2
        '
        Me.GridViewMaterial2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridViewMaterial2.GridControl = Me.GridMaterial2
        Me.GridViewMaterial2.Name = "GridViewMaterial2"
        Me.GridViewMaterial2.OptionsBehavior.Editable = False
        Me.GridViewMaterial2.OptionsView.ColumnAutoWidth = False
        Me.GridViewMaterial2.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMaterial2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "物料編碼"
        Me.GridColumn5.FieldName = "M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 136
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "物料名稱"
        Me.GridColumn6.FieldName = "M_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 110
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "物料規格"
        Me.GridColumn7.FieldName = "M_Gauge"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 123
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "單位"
        Me.GridColumn8.FieldName = "M_Unit"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'grid2
        '
        Me.grid2.ContextMenuStrip = Me.cmsOrderBill
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid2.EmbeddedNavigator.Name = ""
        Me.grid2.Location = New System.Drawing.Point(0, 0)
        Me.grid2.MainView = Me.GridView3
        Me.grid2.Name = "grid2"
        Me.grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit3, Me.deNeedDate, Me.RepositoryItemPopupContainerEdit2})
        Me.grid2.Size = New System.Drawing.Size(1032, 296)
        Me.grid2.TabIndex = 1
        Me.grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'cmsOrderBill
        '
        Me.cmsOrderBill.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsOrderBillAdd, Me.cmsOrderBillDel})
        Me.cmsOrderBill.Name = "cmsBill"
        Me.cmsOrderBill.Size = New System.Drawing.Size(163, 48)
        '
        'cmsOrderBillAdd
        '
        Me.cmsOrderBillAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsOrderBillAdd.Name = "cmsOrderBillAdd"
        Me.cmsOrderBillAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsOrderBillAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsOrderBillAdd.Text = "新增(&A)"
        '
        'cmsOrderBillDel
        '
        Me.cmsOrderBillDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsOrderBillDel.Name = "cmsOrderBillDel"
        Me.cmsOrderBillDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsOrderBillDel.Size = New System.Drawing.Size(162, 22)
        Me.cmsOrderBillDel.Text = "刪除(&D)"
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MOB_AutoID, Me.MOB_MRP_ID, Me.MOB_ForecastID, Me.OD_ID, Me.MOB_NeedDate, Me.customerName, Me.MOB_M_Code, Me.MOB_M_Name, Me.MOB_M_Gauge, Me.MOB_Source, Me.MOB_MRPQty, Me.MOB_M_Unit})
        Me.GridView3.GridControl = Me.grid2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'MOB_AutoID
        '
        Me.MOB_AutoID.Caption = "AutoID"
        Me.MOB_AutoID.FieldName = "AutoID"
        Me.MOB_AutoID.Name = "MOB_AutoID"
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
        Me.MOB_ForecastID.SummaryItem.DisplayFormat = "記錄條數：{0}"
        Me.MOB_ForecastID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.MOB_ForecastID.Visible = True
        Me.MOB_ForecastID.VisibleIndex = 0
        Me.MOB_ForecastID.Width = 111
        '
        'OD_ID
        '
        Me.OD_ID.Caption = "訂單編號"
        Me.OD_ID.FieldName = "OD_ID"
        Me.OD_ID.Name = "OD_ID"
        Me.OD_ID.Width = 125
        '
        'MOB_NeedDate
        '
        Me.MOB_NeedDate.Caption = "交貨日期"
        Me.MOB_NeedDate.ColumnEdit = Me.deNeedDate
        Me.MOB_NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MOB_NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MOB_NeedDate.FieldName = "MOB_NeedDate"
        Me.MOB_NeedDate.Name = "MOB_NeedDate"
        Me.MOB_NeedDate.Visible = True
        Me.MOB_NeedDate.VisibleIndex = 2
        Me.MOB_NeedDate.Width = 90
        '
        'deNeedDate
        '
        Me.deNeedDate.AutoHeight = False
        Me.deNeedDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNeedDate.Name = "deNeedDate"
        '
        'customerName
        '
        Me.customerName.Caption = "客戶名稱"
        Me.customerName.FieldName = "customerName"
        Me.customerName.Name = "customerName"
        Me.customerName.Visible = True
        Me.customerName.VisibleIndex = 1
        Me.customerName.Width = 139
        '
        'MOB_M_Code
        '
        Me.MOB_M_Code.Caption = "物料編碼"
        Me.MOB_M_Code.ColumnEdit = Me.RepositoryItemPopupContainerEdit2
        Me.MOB_M_Code.FieldName = "M_Code"
        Me.MOB_M_Code.Name = "MOB_M_Code"
        Me.MOB_M_Code.Visible = True
        Me.MOB_M_Code.VisibleIndex = 3
        Me.MOB_M_Code.Width = 149
        '
        'RepositoryItemPopupContainerEdit2
        '
        Me.RepositoryItemPopupContainerEdit2.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit2.Name = "RepositoryItemPopupContainerEdit2"
        Me.RepositoryItemPopupContainerEdit2.PopupControl = Me.PopupContainerControl2
        '
        'MOB_M_Name
        '
        Me.MOB_M_Name.Caption = "物料名稱"
        Me.MOB_M_Name.FieldName = "M_Name"
        Me.MOB_M_Name.Name = "MOB_M_Name"
        Me.MOB_M_Name.OptionsColumn.AllowEdit = False
        Me.MOB_M_Name.Visible = True
        Me.MOB_M_Name.VisibleIndex = 4
        Me.MOB_M_Name.Width = 141
        '
        'MOB_M_Gauge
        '
        Me.MOB_M_Gauge.Caption = "物料規格"
        Me.MOB_M_Gauge.FieldName = "M_Gauge"
        Me.MOB_M_Gauge.Name = "MOB_M_Gauge"
        Me.MOB_M_Gauge.OptionsColumn.AllowEdit = False
        Me.MOB_M_Gauge.Visible = True
        Me.MOB_M_Gauge.VisibleIndex = 5
        Me.MOB_M_Gauge.Width = 144
        '
        'MOB_Source
        '
        Me.MOB_Source.Caption = "來源碼"
        Me.MOB_Source.FieldName = "Source"
        Me.MOB_Source.Name = "MOB_Source"
        Me.MOB_Source.Visible = True
        Me.MOB_Source.VisibleIndex = 6
        '
        'MOB_MRPQty
        '
        Me.MOB_MRPQty.Caption = "MRP凈需求"
        Me.MOB_MRPQty.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.MOB_MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MOB_MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOB_MRPQty.FieldName = "MRPQty"
        Me.MOB_MRPQty.Name = "MOB_MRPQty"
        Me.MOB_MRPQty.Visible = True
        Me.MOB_MRPQty.VisibleIndex = 7
        Me.MOB_MRPQty.Width = 80
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'MOB_M_Unit
        '
        Me.MOB_M_Unit.Caption = "單位"
        Me.MOB_M_Unit.FieldName = "M_Unit"
        Me.MOB_M_Unit.Name = "MOB_M_Unit"
        Me.MOB_M_Unit.OptionsColumn.AllowEdit = False
        Me.MOB_M_Unit.Visible = True
        Me.MOB_M_Unit.VisibleIndex = 8
        Me.MOB_M_Unit.Width = 47
        '
        'xtpPurchase
        '
        Me.xtpPurchase.Controls.Add(Me.PopupContainerControl3)
        Me.xtpPurchase.Controls.Add(Me.grid3)
        Me.xtpPurchase.Name = "xtpPurchase"
        Me.xtpPurchase.Size = New System.Drawing.Size(1032, 296)
        Me.xtpPurchase.Text = "請購建議"
        '
        'PopupContainerControl3
        '
        Me.PopupContainerControl3.Controls.Add(Me.GridMaterial3)
        Me.PopupContainerControl3.Location = New System.Drawing.Point(323, 78)
        Me.PopupContainerControl3.Name = "PopupContainerControl3"
        Me.PopupContainerControl3.Size = New System.Drawing.Size(397, 185)
        Me.PopupContainerControl3.TabIndex = 2
        Me.PopupContainerControl3.Text = "PopupContainerControl3"
        '
        'GridMaterial3
        '
        Me.GridMaterial3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterial3.EmbeddedNavigator.Name = ""
        Me.GridMaterial3.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterial3.MainView = Me.GridViewMaterial3
        Me.GridMaterial3.Name = "GridMaterial3"
        Me.GridMaterial3.Size = New System.Drawing.Size(397, 185)
        Me.GridMaterial3.TabIndex = 0
        Me.GridMaterial3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMaterial3})
        '
        'GridViewMaterial3
        '
        Me.GridViewMaterial3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridViewMaterial3.GridControl = Me.GridMaterial3
        Me.GridViewMaterial3.Name = "GridViewMaterial3"
        Me.GridViewMaterial3.OptionsBehavior.Editable = False
        Me.GridViewMaterial3.OptionsView.ColumnAutoWidth = False
        Me.GridViewMaterial3.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMaterial3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "物料編碼"
        Me.GridColumn9.FieldName = "M_Code"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 135
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "物料名稱"
        Me.GridColumn10.FieldName = "M_Name"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 97
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "物料規格"
        Me.GridColumn11.FieldName = "M_Gauge"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 140
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "單位"
        Me.GridColumn12.FieldName = "M_Unit"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'grid3
        '
        Me.grid3.ContextMenuStrip = Me.cmsPurchase
        Me.grid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid3.EmbeddedNavigator.Name = ""
        Me.grid3.Location = New System.Drawing.Point(0, 0)
        Me.grid3.MainView = Me.BandedGridView1
        Me.grid3.Name = "grid3"
        Me.grid3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit2, Me.RepositoryItemPopupContainerEdit3})
        Me.grid3.Size = New System.Drawing.Size(1032, 296)
        Me.grid3.TabIndex = 1
        Me.grid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'cmsPurchase
        '
        Me.cmsPurchase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPurchaseAdd, Me.cmsPurchaseDel, Me.ToolStripMenuItem1, Me.cmsPurchasePrint})
        Me.cmsPurchase.Name = "cmsBill"
        Me.cmsPurchase.Size = New System.Drawing.Size(163, 76)
        '
        'cmsPurchaseAdd
        '
        Me.cmsPurchaseAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsPurchaseAdd.Name = "cmsPurchaseAdd"
        Me.cmsPurchaseAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsPurchaseAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsPurchaseAdd.Text = "新增(&A)"
        '
        'cmsPurchaseDel
        '
        Me.cmsPurchaseDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsPurchaseDel.Name = "cmsPurchaseDel"
        Me.cmsPurchaseDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsPurchaseDel.Size = New System.Drawing.Size(162, 22)
        Me.cmsPurchaseDel.Text = "刪除(&D)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'cmsPurchasePrint
        '
        Me.cmsPurchasePrint.Name = "cmsPurchasePrint"
        Me.cmsPurchasePrint.Size = New System.Drawing.Size(162, 22)
        Me.cmsPurchasePrint.Text = "列印(&P)"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.MP_AutoID, Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.BandedGridColumn7, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn10, Me.BandedGridColumn11, Me.BandedGridColumn12, Me.BandedGridColumn13, Me.BandedGridColumn14, Me.BandedGridColumn15, Me.BandedGridColumn16, Me.BandedGridColumn17, Me.BandedGridColumn18, Me.BandedGridColumn19, Me.BandedGridColumn20})
        Me.BandedGridView1.GridControl = Me.grid3
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsNavigation.UseTabKey = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "物料"
        Me.GridBand1.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn5)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn6)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.RowCount = 2
        Me.GridBand1.Width = 528
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "MRP_ID"
        Me.BandedGridColumn1.FieldName = "MRP_ID"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.Width = 97
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "物料編碼"
        Me.BandedGridColumn2.ColumnEdit = Me.RepositoryItemPopupContainerEdit3
        Me.BandedGridColumn2.FieldName = "M_Code"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.SummaryItem.DisplayFormat = "記錄條數：{0}"
        Me.BandedGridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 148
        '
        'RepositoryItemPopupContainerEdit3
        '
        Me.RepositoryItemPopupContainerEdit3.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit3.Name = "RepositoryItemPopupContainerEdit3"
        Me.RepositoryItemPopupContainerEdit3.PopupControl = Me.PopupContainerControl3
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "物料名稱"
        Me.BandedGridColumn3.FieldName = "M_Name"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 131
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.Caption = "物料規格"
        Me.BandedGridColumn5.FieldName = "M_Gauge"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.Width = 134
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "來源碼"
        Me.BandedGridColumn6.FieldName = "Source"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.Width = 67
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "單位"
        Me.BandedGridColumn4.FieldName = "M_Unit"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 48
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "MRP數量"
        Me.GridBand2.Columns.Add(Me.BandedGridColumn7)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 95
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.Caption = "總需求量"
        Me.BandedGridColumn7.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn7.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn7.FieldName = "MP_NeedQty"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.Width = 72
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        Me.RepositoryItemCalcEdit2.NullText = "0"
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.Caption = "實際需求數量"
        Me.BandedGridColumn8.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn8.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn8.FieldName = "MP_MRPQty"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.Visible = True
        Me.BandedGridColumn8.Width = 95
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "物料相關數量"
        Me.GridBand3.Columns.Add(Me.BandedGridColumn9)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn10)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn11)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn12)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn13)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn14)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn20)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn15)
        Me.GridBand3.Columns.Add(Me.BandedGridColumn17)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 487
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.Caption = "庫存數量"
        Me.BandedGridColumn9.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn9.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn9.FieldName = "MP_InventoryQty"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.Visible = True
        Me.BandedGridColumn9.Width = 69
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.Caption = "在途數量"
        Me.BandedGridColumn10.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn10.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn10.FieldName = "MP_InTransitQty"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.Visible = True
        Me.BandedGridColumn10.Width = 70
        '
        'BandedGridColumn11
        '
        Me.BandedGridColumn11.Caption = "待驗量"
        Me.BandedGridColumn11.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn11.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn11.FieldName = "MP_Inspection"
        Me.BandedGridColumn11.Name = "BandedGridColumn11"
        Me.BandedGridColumn11.Visible = True
        Me.BandedGridColumn11.Width = 57
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.Caption = "生產未領"
        Me.BandedGridColumn12.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn12.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn12.FieldName = "MP_NoCollar"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        Me.BandedGridColumn12.Visible = True
        Me.BandedGridColumn12.Width = 73
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.Caption = "退貨數量"
        Me.BandedGridColumn13.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn13.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn13.FieldName = "MP_RetreatQty"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        Me.BandedGridColumn13.Visible = True
        Me.BandedGridColumn13.Width = 70
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.Caption = "安全庫存"
        Me.BandedGridColumn14.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn14.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn14.FieldName = "MP_SecInv"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        Me.BandedGridColumn14.Visible = True
        Me.BandedGridColumn14.Width = 73
        '
        'BandedGridColumn20
        '
        Me.BandedGridColumn20.Caption = "相關數量"
        Me.BandedGridColumn20.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn20.FieldName = "MP_RelatedQty"
        Me.BandedGridColumn20.Name = "BandedGridColumn20"
        Me.BandedGridColumn20.Visible = True
        '
        'BandedGridColumn15
        '
        Me.BandedGridColumn15.Caption = "最低庫存"
        Me.BandedGridColumn15.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn15.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn15.FieldName = "MP_LowLimit"
        Me.BandedGridColumn15.Name = "BandedGridColumn15"
        Me.BandedGridColumn15.Width = 69
        '
        'BandedGridColumn17
        '
        Me.BandedGridColumn17.Caption = "經濟批量"
        Me.BandedGridColumn17.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn17.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn17.FieldName = "MP_BatFixEconomy"
        Me.BandedGridColumn17.Name = "BandedGridColumn17"
        Me.BandedGridColumn17.Width = 93
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "采購相關數量"
        Me.GridBand4.Columns.Add(Me.BandedGridColumn16)
        Me.GridBand4.Columns.Add(Me.BandedGridColumn18)
        Me.GridBand4.Columns.Add(Me.BandedGridColumn19)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 245
        '
        'BandedGridColumn16
        '
        Me.BandedGridColumn16.Caption = "訂貨批量"
        Me.BandedGridColumn16.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn16.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn16.FieldName = "MP_BatchQty"
        Me.BandedGridColumn16.Name = "BandedGridColumn16"
        Me.BandedGridColumn16.Visible = True
        Me.BandedGridColumn16.Width = 71
        '
        'BandedGridColumn18
        '
        Me.BandedGridColumn18.Caption = "最大定購量"
        Me.BandedGridColumn18.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn18.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn18.FieldName = "MP_OrderMax"
        Me.BandedGridColumn18.Name = "BandedGridColumn18"
        Me.BandedGridColumn18.Visible = True
        Me.BandedGridColumn18.Width = 83
        '
        'BandedGridColumn19
        '
        Me.BandedGridColumn19.Caption = "最小定購量"
        Me.BandedGridColumn19.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.BandedGridColumn19.DisplayFormat.FormatString = "#,###0.######"
        Me.BandedGridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn19.FieldName = "MP_OrderMin"
        Me.BandedGridColumn19.Name = "BandedGridColumn19"
        Me.BandedGridColumn19.Visible = True
        Me.BandedGridColumn19.Width = 91
        '
        'MP_AutoID
        '
        Me.MP_AutoID.Caption = "AutoID"
        Me.MP_AutoID.FieldName = "AutoID"
        Me.MP_AutoID.Name = "MP_AutoID"
        '
        'xtpCheck
        '
        Me.xtpCheck.Controls.Add(Me.lblCheckDate)
        Me.xtpCheck.Controls.Add(Me.lblCheckUser)
        Me.xtpCheck.Controls.Add(Me.chkCheck)
        Me.xtpCheck.Controls.Add(Me.Label7)
        Me.xtpCheck.Controls.Add(Me.Label10)
        Me.xtpCheck.Controls.Add(Me.txtCheckRemark)
        Me.xtpCheck.Name = "xtpCheck"
        Me.xtpCheck.Size = New System.Drawing.Size(1032, 296)
        Me.xtpCheck.Text = "審核"
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(640, 39)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(71, 15)
        Me.lblCheckDate.TabIndex = 96
        Me.lblCheckDate.Text = "審核日期:"
        '
        'lblCheckUser
        '
        Me.lblCheckUser.AutoSize = True
        Me.lblCheckUser.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUser.Location = New System.Drawing.Point(496, 39)
        Me.lblCheckUser.Name = "lblCheckUser"
        Me.lblCheckUser.Size = New System.Drawing.Size(82, 15)
        Me.lblCheckUser.TabIndex = 95
        Me.lblCheckUser.Text = "審核人員："
        '
        'chkCheck
        '
        Me.chkCheck.Location = New System.Drawing.Point(91, 37)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Properties.Caption = "確認審核"
        Me.chkCheck.Size = New System.Drawing.Size(92, 19)
        Me.chkCheck.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "備註(&R):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(24, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "審核(&K):"
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(91, 79)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Size = New System.Drawing.Size(763, 161)
        Me.txtCheckRemark.TabIndex = 91
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
        Me.MP_M_Code.ColumnEdit = Me.RepositoryItemPopupContainerEdit3
        Me.MP_M_Code.FieldName = "M_Code"
        Me.MP_M_Code.Name = "MP_M_Code"
        Me.MP_M_Code.Visible = True
        Me.MP_M_Code.Width = 148
        '
        'MP_M_Name
        '
        Me.MP_M_Name.Caption = "物料名稱"
        Me.MP_M_Name.FieldName = "M_Name"
        Me.MP_M_Name.Name = "MP_M_Name"
        Me.MP_M_Name.OptionsColumn.AllowEdit = False
        Me.MP_M_Name.Visible = True
        Me.MP_M_Name.Width = 131
        '
        'MP_M_Gauge
        '
        Me.MP_M_Gauge.Caption = "物料規格"
        Me.MP_M_Gauge.FieldName = "M_Gauge"
        Me.MP_M_Gauge.Name = "MP_M_Gauge"
        Me.MP_M_Gauge.OptionsColumn.AllowEdit = False
        Me.MP_M_Gauge.Visible = True
        Me.MP_M_Gauge.Width = 134
        '
        'MP_Source
        '
        Me.MP_Source.Caption = "來源碼"
        Me.MP_Source.FieldName = "Source"
        Me.MP_Source.Name = "MP_Source"
        Me.MP_Source.Visible = True
        '
        'MP_M_Unit
        '
        Me.MP_M_Unit.Caption = "單位"
        Me.MP_M_Unit.FieldName = "M_Unit"
        Me.MP_M_Unit.Name = "MP_M_Unit"
        Me.MP_M_Unit.OptionsColumn.AllowEdit = False
        Me.MP_M_Unit.Visible = True
        Me.MP_M_Unit.Width = 48
        '
        'MP_NeedQty
        '
        Me.MP_NeedQty.Caption = "毛需求量"
        Me.MP_NeedQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_NeedQty.FieldName = "MP_NeedQty"
        Me.MP_NeedQty.Name = "MP_NeedQty"
        Me.MP_NeedQty.Visible = True
        Me.MP_NeedQty.Width = 72
        '
        'MP_MRPQty
        '
        Me.MP_MRPQty.Caption = "MRP凈需求量"
        Me.MP_MRPQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_MRPQty.FieldName = "MP_MRPQty"
        Me.MP_MRPQty.Name = "MP_MRPQty"
        Me.MP_MRPQty.Visible = True
        Me.MP_MRPQty.Width = 95
        '
        'MP_InventoryQty
        '
        Me.MP_InventoryQty.Caption = "庫存數量"
        Me.MP_InventoryQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_InventoryQty.FieldName = "MP_InventoryQty"
        Me.MP_InventoryQty.Name = "MP_InventoryQty"
        Me.MP_InventoryQty.Visible = True
        Me.MP_InventoryQty.Width = 69
        '
        'MP_InTransitQty
        '
        Me.MP_InTransitQty.Caption = "在途數量"
        Me.MP_InTransitQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_InTransitQty.FieldName = "MP_InTransitQty"
        Me.MP_InTransitQty.Name = "MP_InTransitQty"
        Me.MP_InTransitQty.Visible = True
        Me.MP_InTransitQty.Width = 70
        '
        'MP_Inspection
        '
        Me.MP_Inspection.Caption = "待驗量"
        Me.MP_Inspection.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_Inspection.FieldName = "MP_Inspection"
        Me.MP_Inspection.Name = "MP_Inspection"
        Me.MP_Inspection.Visible = True
        Me.MP_Inspection.Width = 57
        '
        'MP_NoCollar
        '
        Me.MP_NoCollar.Caption = "生產未領"
        Me.MP_NoCollar.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_NoCollar.FieldName = "MP_NoCollar"
        Me.MP_NoCollar.Name = "MP_NoCollar"
        Me.MP_NoCollar.Visible = True
        Me.MP_NoCollar.Width = 73
        '
        'MP_RetreatQty
        '
        Me.MP_RetreatQty.Caption = "退貨數量"
        Me.MP_RetreatQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_RetreatQty.FieldName = "MP_RetreatQty"
        Me.MP_RetreatQty.Name = "MP_RetreatQty"
        Me.MP_RetreatQty.Visible = True
        Me.MP_RetreatQty.Width = 70
        '
        'MP_SecInv
        '
        Me.MP_SecInv.Caption = "安全庫存"
        Me.MP_SecInv.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_SecInv.FieldName = "MP_SecInv"
        Me.MP_SecInv.Name = "MP_SecInv"
        Me.MP_SecInv.Visible = True
        Me.MP_SecInv.Width = 73
        '
        'MP_LowLimit
        '
        Me.MP_LowLimit.Caption = "最低庫存"
        Me.MP_LowLimit.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_LowLimit.FieldName = "MP_LowLimit"
        Me.MP_LowLimit.Name = "MP_LowLimit"
        Me.MP_LowLimit.Width = 69
        '
        'MP_BatFixEconomy
        '
        Me.MP_BatFixEconomy.Caption = "經濟批量"
        Me.MP_BatFixEconomy.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_BatFixEconomy.FieldName = "MP_BatFixEconomy"
        Me.MP_BatFixEconomy.Name = "MP_BatFixEconomy"
        Me.MP_BatFixEconomy.Width = 93
        '
        'MP_BatchQty
        '
        Me.MP_BatchQty.Caption = "訂貨批量"
        Me.MP_BatchQty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_BatchQty.FieldName = "MP_BatchQty"
        Me.MP_BatchQty.Name = "MP_BatchQty"
        Me.MP_BatchQty.Visible = True
        Me.MP_BatchQty.Width = 71
        '
        'MP_OrderMax
        '
        Me.MP_OrderMax.Caption = "最大定購量"
        Me.MP_OrderMax.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_OrderMax.FieldName = "MP_OrderMax"
        Me.MP_OrderMax.Name = "MP_OrderMax"
        Me.MP_OrderMax.Visible = True
        Me.MP_OrderMax.Width = 83
        '
        'MP_OrderMin
        '
        Me.MP_OrderMin.Caption = "最小定購量"
        Me.MP_OrderMin.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.MP_OrderMin.FieldName = "MP_OrderMin"
        Me.MP_OrderMin.Name = "MP_OrderMin"
        Me.MP_OrderMin.Visible = True
        Me.MP_OrderMin.Width = 91
        '
        'RelatedQty
        '
        Me.RelatedQty.Caption = "相關數量"
        Me.RelatedQty.FieldName = "RelatedQty"
        Me.RelatedQty.Name = "RelatedQty"
        Me.RelatedQty.Visible = True
        '
        'pbIndreq
        '
        Me.pbIndreq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbIndreq.BackColor = System.Drawing.Color.White
        Me.pbIndreq.Image = CType(resources.GetObject("pbIndreq.Image"), System.Drawing.Image)
        Me.pbIndreq.Location = New System.Drawing.Point(496, 332)
        Me.pbIndreq.Name = "pbIndreq"
        Me.pbIndreq.Size = New System.Drawing.Size(103, 106)
        Me.pbIndreq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbIndreq.TabIndex = 173
        Me.pbIndreq.TabStop = False
        Me.pbIndreq.Visible = False
        '
        'frmMRPInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 571)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCreateUserName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dteCreateDate)
        Me.Controls.Add(Me.pbIndreq)
        Me.Name = "frmMRPInfo"
        Me.Text = "MRP物料需求運算"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pnlDeclare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDeclare.ResumeLayout(False)
        Me.pnlDeclare.PerformLayout()
        CType(Me.pceForecastID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccForecastID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccForecastID.ResumeLayout(False)
        CType(Me.chklbForecastID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkForecastID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNeedEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNeedBeginDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlogtxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRPType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMRP_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpDestBills.ResumeLayout(False)
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.GridMaterial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMaterial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsBill.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpIndReq.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpOrderDestBills.ResumeLayout(False)
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl2.ResumeLayout(False)
        CType(Me.GridMaterial2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMaterial2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOrderBill.ResumeLayout(False)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNeedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPurchase.ResumeLayout(False)
        CType(Me.PopupContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl3.ResumeLayout(False)
        CType(Me.GridMaterial3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMaterial3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPurchase.ResumeLayout(False)
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIndreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMRP_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteNeedEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dteNeedBeginDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMRPType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnMrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpDestBills As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MB_MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_MRPQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MB_MP_InventoryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpOrderDestBills As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpPurchase As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents xtpCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_MRP_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_M_Gauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_NeedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_InventoryQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_InTransitQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_Inspection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_NoCollar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_RetreatQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_SecInv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_LowLimit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_MRPQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtlogtxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dteCreateDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmsBill As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsBillAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_M_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_BatchQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_BatFixEconomy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_OrderMax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_OrderMin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmdBillDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOB_MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsOrderBill As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOrderBillAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOrderBillDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurchase As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsPurchaseAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurchaseDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_AutoID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MOB_MRPQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPurchasePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCheckUser As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCreateUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MOB_ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkForecastID As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDescrip As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deNeedDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents MB_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOB_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MP_Source As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents prb As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridMaterial1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMaterial1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemPopupContainerEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents PopupContainerControl2 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridMaterial2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMaterial2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupContainerControl3 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridMaterial3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMaterial3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpIndReq As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnInsertWareHouse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGetPurchase As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents M_Code As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Gauge As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Source As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents NeedQty As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Unit As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents sonsNum As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NeedDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lblWareID As System.Windows.Forms.Label
    Friend WithEvents pceForecastID As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents pccForecastID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chklbForecastID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents InvalidDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RelatedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents pbIndreq As System.Windows.Forms.PictureBox
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn17 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn16 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn18 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn19 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lblDeclare As System.Windows.Forms.Label
    Friend WithEvents pnlDeclare As DevExpress.XtraEditors.PanelControl
    Friend WithEvents xtpExamine As DevExpress.XtraTab.XtraTabPage
End Class
