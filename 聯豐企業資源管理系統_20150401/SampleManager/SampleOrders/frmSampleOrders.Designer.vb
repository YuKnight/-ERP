<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleOrders
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具进行修改。
    '请不要使用程式碼編輯器进行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCODE = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdOrderClose = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSendBack = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdBack = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSO_SampleID = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEditType = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEditQty = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdQueryInventory = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLook = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrintTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExcelA = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MaterialTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SampTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CusterNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_PoDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SO_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSO_OrdersType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSO_Closed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_Rank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_State = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdSendBackLook = New System.Windows.Forms.ToolStripMenuItem
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SO_IDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SS_EditionSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SWI_QtySub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SS_RemarkSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_NoSendQtySub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripWareChange = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SWI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarCodeCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LoseCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DamageCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FinishedCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReturnCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SendCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCODEA = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCODEDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkCC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdSendBackQuery = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1045, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.Grid1.Size = New System.Drawing.Size(1045, 355)
        Me.Grid1.TabIndex = 80
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator2, Me.cmdCODE, Me.ToolStripSeparator3, Me.cmdOrderClose, Me.cmdCheck, Me.ToolStripSeparator4, Me.cmdSendBack, Me.cmdBack, Me.cmdSO_SampleID, Me.cmdEditType, Me.cmdEditQty, Me.ToolStripSeparator1, Me.cmdQueryInventory, Me.cmdQuery, Me.cmdLook, Me.cmdRef, Me.cmdPrint, Me.cmdPrintTotal, Me.cmdExcelA})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 430)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(210, 22)
        Me.cmdAdd.Text = "增加(&A)"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(210, 22)
        Me.cmdEdit.Text = "修改(&E)"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(210, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'cmdCODE
        '
        Me.cmdCODE.AutoSize = False
        Me.cmdCODE.Enabled = False
        Me.cmdCODE.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCODE.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.cmdCODE.Name = "cmdCODE"
        Me.cmdCODE.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmdCODE.Size = New System.Drawing.Size(202, 28)
        Me.cmdCODE.Text = "条码采集(&C)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(207, 6)
        '
        'cmdOrderClose
        '
        Me.cmdOrderClose.Enabled = False
        Me.cmdOrderClose.Image = Global.LFERP.My.Resources.Resources.SmartArtChangeColorsGallery
        Me.cmdOrderClose.Name = "cmdOrderClose"
        Me.cmdOrderClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.cmdOrderClose.Size = New System.Drawing.Size(210, 22)
        Me.cmdOrderClose.Text = "订单结案(&J)"
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(210, 22)
        Me.cmdCheck.Text = "审核(&G)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(207, 6)
        '
        'cmdSendBack
        '
        Me.cmdSendBack.Enabled = False
        Me.cmdSendBack.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.cmdSendBack.Name = "cmdSendBack"
        Me.cmdSendBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.cmdSendBack.Size = New System.Drawing.Size(210, 22)
        Me.cmdSendBack.Text = "订单退回(Z)"
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.cmdBack.Size = New System.Drawing.Size(210, 22)
        Me.cmdBack.Text = "完工退回(&M)"
        '
        'cmdSO_SampleID
        '
        Me.cmdSO_SampleID.Enabled = False
        Me.cmdSO_SampleID.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdSO_SampleID.Name = "cmdSO_SampleID"
        Me.cmdSO_SampleID.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.cmdSO_SampleID.Size = New System.Drawing.Size(210, 22)
        Me.cmdSO_SampleID.Text = "更改样办单号(&B)"
        '
        'cmdEditType
        '
        Me.cmdEditType.Enabled = False
        Me.cmdEditType.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEditType.Name = "cmdEditType"
        Me.cmdEditType.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.cmdEditType.Size = New System.Drawing.Size(210, 22)
        Me.cmdEditType.Text = "更改产品类别(&U)"
        '
        'cmdEditQty
        '
        Me.cmdEditQty.Enabled = False
        Me.cmdEditQty.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEditQty.Name = "cmdEditQty"
        Me.cmdEditQty.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.cmdEditQty.Size = New System.Drawing.Size(210, 22)
        Me.cmdEditQty.Text = "更改數量(&Q)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'cmdQueryInventory
        '
        Me.cmdQueryInventory.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQueryInventory.Name = "cmdQueryInventory"
        Me.cmdQueryInventory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmdQueryInventory.Size = New System.Drawing.Size(210, 22)
        Me.cmdQueryInventory.Text = "产品库存查询(&S)"
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(210, 22)
        Me.cmdQuery.Text = "查询(&F)"
        '
        'cmdLook
        '
        Me.cmdLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdLook.Name = "cmdLook"
        Me.cmdLook.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdLook.Size = New System.Drawing.Size(210, 22)
        Me.cmdLook.Text = "查看(&W)"
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(210, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(210, 22)
        Me.cmdPrint.Text = "列印(&T)"
        '
        'cmdPrintTotal
        '
        Me.cmdPrintTotal.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintTotal.Name = "cmdPrintTotal"
        Me.cmdPrintTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrintTotal.Size = New System.Drawing.Size(210, 22)
        Me.cmdPrintTotal.Text = "列印汇总(&P)"
        '
        'cmdExcelA
        '
        Me.cmdExcelA.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExcelA.Name = "cmdExcelA"
        Me.cmdExcelA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmdExcelA.Size = New System.Drawing.Size(210, 22)
        Me.cmdExcelA.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SO_ID, Me.SO_SampleID, Me.M_Code_Type, Me.PM_M_Code, Me.GridColumn28, Me.MaterialTypeName, Me.SampTypeName, Me.M_Code, Me.M_Name, Me.SO_CusterNo, Me.SO_OrderQty, Me.SO_CreateDate, Me.SO_PoDate, Me.SO_SendDate, Me.SO_NoSendQty, Me.colaSO_OrdersType, Me.SO_Check, Me.colSO_Closed, Me.GridColumn18, Me.SO_CheckRemark, Me.SO_Rank, Me.SO_State, Me.SO_Remark, Me.SO_No, Me.SO_CusterID, Me.SO_CusterPO})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SO_ID
        '
        Me.SO_ID.Caption = "订单编号"
        Me.SO_ID.FieldName = "SO_ID"
        Me.SO_ID.Name = "SO_ID"
        Me.SO_ID.OptionsColumn.ReadOnly = True
        Me.SO_ID.Visible = True
        Me.SO_ID.VisibleIndex = 19
        Me.SO_ID.Width = 85
        '
        'SO_SampleID
        '
        Me.SO_SampleID.Caption = "样办单号"
        Me.SO_SampleID.FieldName = "SO_SampleID"
        Me.SO_SampleID.Name = "SO_SampleID"
        Me.SO_SampleID.Visible = True
        Me.SO_SampleID.VisibleIndex = 0
        Me.SO_SampleID.Width = 95
        '
        'M_Code_Type
        '
        Me.M_Code_Type.Caption = "产品类别"
        Me.M_Code_Type.FieldName = "M_Code_Type"
        Me.M_Code_Type.Name = "M_Code_Type"
        Me.M_Code_Type.Visible = True
        Me.M_Code_Type.VisibleIndex = 13
        Me.M_Code_Type.Width = 97
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        Me.PM_M_Code.Width = 100
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "材料类型"
        Me.GridColumn28.FieldName = "TMaterialType"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 12
        Me.GridColumn28.Width = 69
        '
        'MaterialTypeName
        '
        Me.MaterialTypeName.Caption = "材料"
        Me.MaterialTypeName.FieldName = "MaterialTypeName"
        Me.MaterialTypeName.Name = "MaterialTypeName"
        Me.MaterialTypeName.OptionsColumn.ReadOnly = True
        Me.MaterialTypeName.Visible = True
        Me.MaterialTypeName.VisibleIndex = 2
        Me.MaterialTypeName.Width = 87
        '
        'SampTypeName
        '
        Me.SampTypeName.Caption = "样办阶段"
        Me.SampTypeName.FieldName = "SampTypeName"
        Me.SampTypeName.Name = "SampTypeName"
        Me.SampTypeName.OptionsColumn.ReadOnly = True
        Me.SampTypeName.SummaryItem.DisplayFormat = "合计:"
        Me.SampTypeName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.SampTypeName.Visible = True
        Me.SampTypeName.VisibleIndex = 3
        '
        'M_Code
        '
        Me.M_Code.Caption = "产品类別"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Width = 68
        '
        'M_Name
        '
        Me.M_Name.Caption = "配件名称"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        '
        'SO_CusterNo
        '
        Me.SO_CusterNo.Caption = "客戶编号"
        Me.SO_CusterNo.FieldName = "SO_CusterNo"
        Me.SO_CusterNo.Name = "SO_CusterNo"
        Me.SO_CusterNo.OptionsColumn.ReadOnly = True
        '
        'SO_OrderQty
        '
        Me.SO_OrderQty.Caption = "订单数量"
        Me.SO_OrderQty.FieldName = "SO_OrderQty"
        Me.SO_OrderQty.Name = "SO_OrderQty"
        Me.SO_OrderQty.OptionsColumn.ReadOnly = True
        Me.SO_OrderQty.SummaryItem.DisplayFormat = "{0}"
        Me.SO_OrderQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SO_OrderQty.Visible = True
        Me.SO_OrderQty.VisibleIndex = 4
        Me.SO_OrderQty.Width = 70
        '
        'SO_CreateDate
        '
        Me.SO_CreateDate.Caption = "建立日期"
        Me.SO_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.SO_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_CreateDate.FieldName = "SO_CreateDate"
        Me.SO_CreateDate.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.SO_CreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_CreateDate.Name = "SO_CreateDate"
        Me.SO_CreateDate.OptionsColumn.ReadOnly = True
        Me.SO_CreateDate.Visible = True
        Me.SO_CreateDate.VisibleIndex = 6
        '
        'SO_PoDate
        '
        Me.SO_PoDate.Caption = "PO日期"
        Me.SO_PoDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.SO_PoDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.SO_PoDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_PoDate.FieldName = "SO_PoDate"
        Me.SO_PoDate.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.SO_PoDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_PoDate.Name = "SO_PoDate"
        Me.SO_PoDate.OptionsColumn.ReadOnly = True
        Me.SO_PoDate.Visible = True
        Me.SO_PoDate.VisibleIndex = 7
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'SO_SendDate
        '
        Me.SO_SendDate.Caption = "交货日期"
        Me.SO_SendDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.SO_SendDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_SendDate.FieldName = "SO_SendDate"
        Me.SO_SendDate.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.SO_SendDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_SendDate.Name = "SO_SendDate"
        Me.SO_SendDate.OptionsColumn.ReadOnly = True
        Me.SO_SendDate.Visible = True
        Me.SO_SendDate.VisibleIndex = 8
        '
        'SO_NoSendQty
        '
        Me.SO_NoSendQty.Caption = "未交数量"
        Me.SO_NoSendQty.FieldName = "SO_NoSendQty"
        Me.SO_NoSendQty.Name = "SO_NoSendQty"
        Me.SO_NoSendQty.OptionsColumn.ReadOnly = True
        Me.SO_NoSendQty.SummaryItem.DisplayFormat = "{0}"
        Me.SO_NoSendQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SO_NoSendQty.Visible = True
        Me.SO_NoSendQty.VisibleIndex = 5
        Me.SO_NoSendQty.Width = 77
        '
        'colaSO_OrdersType
        '
        Me.colaSO_OrdersType.Caption = "订单类型"
        Me.colaSO_OrdersType.FieldName = "SO_OrdersType"
        Me.colaSO_OrdersType.Name = "colaSO_OrdersType"
        Me.colaSO_OrdersType.Visible = True
        Me.colaSO_OrdersType.VisibleIndex = 16
        '
        'SO_Check
        '
        Me.SO_Check.Caption = "审核"
        Me.SO_Check.FieldName = "SO_Check"
        Me.SO_Check.Name = "SO_Check"
        Me.SO_Check.OptionsColumn.ReadOnly = True
        Me.SO_Check.Visible = True
        Me.SO_Check.VisibleIndex = 9
        Me.SO_Check.Width = 48
        '
        'colSO_Closed
        '
        Me.colSO_Closed.Caption = "结案"
        Me.colSO_Closed.FieldName = "SO_Closed"
        Me.colSO_Closed.Name = "colSO_Closed"
        Me.colSO_Closed.Visible = True
        Me.colSO_Closed.VisibleIndex = 10
        Me.colSO_Closed.Width = 48
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "審核人員"
        Me.GridColumn18.FieldName = "SO_CheckUserName"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 11
        '
        'SO_CheckRemark
        '
        Me.SO_CheckRemark.Caption = "审核说明"
        Me.SO_CheckRemark.FieldName = "SO_CheckRemark"
        Me.SO_CheckRemark.Name = "SO_CheckRemark"
        Me.SO_CheckRemark.OptionsColumn.ReadOnly = True
        Me.SO_CheckRemark.Width = 153
        '
        'SO_Rank
        '
        Me.SO_Rank.Caption = "订单等级"
        Me.SO_Rank.FieldName = "SO_Rank"
        Me.SO_Rank.Name = "SO_Rank"
        Me.SO_Rank.OptionsColumn.ReadOnly = True
        Me.SO_Rank.Visible = True
        Me.SO_Rank.VisibleIndex = 14
        Me.SO_Rank.Width = 68
        '
        'SO_State
        '
        Me.SO_State.Caption = "状态"
        Me.SO_State.FieldName = "SO_State"
        Me.SO_State.Name = "SO_State"
        Me.SO_State.OptionsColumn.ReadOnly = True
        Me.SO_State.Visible = True
        Me.SO_State.VisibleIndex = 15
        Me.SO_State.Width = 54
        '
        'SO_Remark
        '
        Me.SO_Remark.Caption = "备注"
        Me.SO_Remark.FieldName = "SO_Remark"
        Me.SO_Remark.Name = "SO_Remark"
        Me.SO_Remark.OptionsColumn.ReadOnly = True
        Me.SO_Remark.Visible = True
        Me.SO_Remark.VisibleIndex = 17
        Me.SO_Remark.Width = 139
        '
        'SO_No
        '
        Me.SO_No.Caption = "流水号"
        Me.SO_No.FieldName = "SO_No"
        Me.SO_No.Name = "SO_No"
        Me.SO_No.OptionsColumn.ReadOnly = True
        Me.SO_No.Width = 79
        '
        'SO_CusterID
        '
        Me.SO_CusterID.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.SO_CusterID.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.SO_CusterID.AppearanceCell.Options.UseBackColor = True
        Me.SO_CusterID.AppearanceCell.Options.UseForeColor = True
        Me.SO_CusterID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SO_CusterID.AppearanceHeader.Options.UseForeColor = True
        Me.SO_CusterID.Caption = "客戶代号"
        Me.SO_CusterID.FieldName = "SO_CusterID"
        Me.SO_CusterID.Name = "SO_CusterID"
        Me.SO_CusterID.OptionsColumn.ReadOnly = True
        Me.SO_CusterID.Width = 84
        '
        'SO_CusterPO
        '
        Me.SO_CusterPO.Caption = "客戶PO"
        Me.SO_CusterPO.FieldName = "SO_CusterPO"
        Me.SO_CusterPO.Name = "SO_CusterPO"
        Me.SO_CusterPO.OptionsColumn.ReadOnly = True
        Me.SO_CusterPO.Visible = True
        Me.SO_CusterPO.VisibleIndex = 18
        Me.SO_CusterPO.Width = 72
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "样办订单管理"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1045, 608)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.TabIndex = 83
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.XtraTabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1045, 249)
        Me.SplitContainer2.SplitterDistance = 389
        Me.SplitContainer2.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.ContextMenuStrip = Me.ContextMenuStrip4
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(389, 249)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage1, Me.XtraTabPage5})
        Me.XtraTabControl1.Text = "工作进度"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSendBackLook, Me.cmdSendBackQuery})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(153, 70)
        '
        'cmdSendBackLook
        '
        Me.cmdSendBackLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdSendBackLook.Name = "cmdSendBackLook"
        Me.cmdSendBackLook.Size = New System.Drawing.Size(152, 22)
        Me.cmdSendBackLook.Text = "样办退回查看"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(380, 217)
        Me.XtraTabPage3.Text = "工艺流程"
        '
        'GridControl4
        '
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCalcEdit2})
        Me.GridControl4.Size = New System.Drawing.Size(380, 217)
        Me.GridControl4.TabIndex = 11
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.PS_Type, Me.GridColumn6, Me.GridColumn7, Me.GridColumn15})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsNavigation.UseTabKey = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "工序编号"
        Me.GridColumn2.FieldName = "PS_NO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "序号"
        Me.GridColumn3.FieldName = "PS_Num"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.SummaryItem.DisplayFormat = "合计:"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "工艺部門"
        Me.GridColumn4.FieldName = "D_Dep"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 78
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "工序名称"
        Me.GridColumn5.FieldName = "PS_Name"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 162
        '
        'PS_Type
        '
        Me.PS_Type.Caption = "类型"
        Me.PS_Type.ColumnEdit = Me.RepositoryItemComboBox1
        Me.PS_Type.FieldName = "PS_Type"
        Me.PS_Type.Name = "PS_Type"
        Me.PS_Type.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"大货", "返修"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "注意事项"
        Me.GridColumn6.FieldName = "PS_Remark"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 194
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "审核"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn7.FieldName = "PS_Check"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Width = 79
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "排序"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn15.FieldName = "PS_PaiXu"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Width = 53
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.HideSelection = False
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("D_ID", "编号", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("D_Dep", "部門", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ReadOnly = True
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.PageVisible = False
        Me.XtraTabPage1.Size = New System.Drawing.Size(380, 217)
        Me.XtraTabPage1.Text = "版本信息"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(380, 217)
        Me.GridControl1.TabIndex = 80
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SO_IDSub, Me.SS_EditionSub, Me.SWI_QtySub, Me.GridColumn17, Me.GridColumn19, Me.SS_RemarkSub, Me.SO_NoSendQtySub})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SO_IDSub
        '
        Me.SO_IDSub.Caption = "订单编号"
        Me.SO_IDSub.FieldName = "SO_ID"
        Me.SO_IDSub.Name = "SO_IDSub"
        Me.SO_IDSub.Visible = True
        Me.SO_IDSub.VisibleIndex = 0
        Me.SO_IDSub.Width = 85
        '
        'SS_EditionSub
        '
        Me.SS_EditionSub.Caption = "版本号"
        Me.SS_EditionSub.FieldName = "SS_Edition"
        Me.SS_EditionSub.Name = "SS_EditionSub"
        Me.SS_EditionSub.Visible = True
        Me.SS_EditionSub.VisibleIndex = 1
        Me.SS_EditionSub.Width = 57
        '
        'SWI_QtySub
        '
        Me.SWI_QtySub.Caption = "入庫数量"
        Me.SWI_QtySub.FieldName = "SWI_Qty"
        Me.SWI_QtySub.Name = "SWI_QtySub"
        Me.SWI_QtySub.Visible = True
        Me.SWI_QtySub.VisibleIndex = 2
        Me.SWI_QtySub.Width = 80
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "单价"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "货币"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'SS_RemarkSub
        '
        Me.SS_RemarkSub.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.SS_RemarkSub.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.SS_RemarkSub.AppearanceCell.Options.UseBackColor = True
        Me.SS_RemarkSub.AppearanceCell.Options.UseForeColor = True
        Me.SS_RemarkSub.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SS_RemarkSub.AppearanceHeader.Options.UseForeColor = True
        Me.SS_RemarkSub.Caption = "备注"
        Me.SS_RemarkSub.FieldName = "SS_Remark"
        Me.SS_RemarkSub.Name = "SS_RemarkSub"
        Me.SS_RemarkSub.Visible = True
        Me.SS_RemarkSub.VisibleIndex = 4
        Me.SS_RemarkSub.Width = 120
        '
        'SO_NoSendQtySub
        '
        Me.SO_NoSendQtySub.Caption = "未交數量"
        Me.SO_NoSendQtySub.FieldName = "SO_NoSendQty"
        Me.SO_NoSendQtySub.Name = "SO_NoSendQtySub"
        Me.SO_NoSendQtySub.Visible = True
        Me.SO_NoSendQtySub.VisibleIndex = 3
        Me.SO_NoSendQtySub.Width = 69
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridControl5)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(380, 217)
        Me.XtraTabPage5.Text = "样办退回"
        '
        'GridControl5
        '
        Me.GridControl5.ContextMenuStrip = Me.ContextMenuStrip4
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.EmbeddedNavigator.Name = ""
        Me.GridControl5.Location = New System.Drawing.Point(0, 0)
        Me.GridControl5.MainView = Me.GridView7
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(380, 217)
        Me.GridControl5.TabIndex = 81
        Me.GridControl5.TabStop = False
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn27, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26})
        Me.GridView7.GridControl = Me.GridControl5
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ColumnAutoWidth = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "退回单号"
        Me.GridColumn21.FieldName = "SB_ID"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        Me.GridColumn21.Width = 78
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "退回类型"
        Me.GridColumn27.FieldName = "SE_TypeName"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "条码"
        Me.GridColumn22.FieldName = "Code_ID"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 2
        Me.GridColumn22.Width = 61
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "数量"
        Me.GridColumn23.FieldName = "SB_Qty"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 3
        Me.GridColumn23.Width = 48
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "部门"
        Me.GridColumn24.FieldName = "D_Dep"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 4
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "工序"
        Me.GridColumn25.FieldName = "PS_Name"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 5
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn26.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GridColumn26.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn26.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn26.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn26.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn26.Caption = "备注"
        Me.GridColumn26.FieldName = "SB_Remark"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 6
        Me.GridColumn26.Width = 120
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(652, 249)
        Me.XtraTabControl2.TabIndex = 1
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage4})
        Me.XtraTabControl2.Text = "工作进度"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(643, 217)
        Me.XtraTabPage2.Text = "工序数量"
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenuStrip = Me.ContextMenuStrip3
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(643, 217)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripWareChange})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(149, 26)
        '
        'ToolStripWareChange
        '
        Me.ToolStripWareChange.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ToolStripWareChange.Name = "ToolStripWareChange"
        Me.ToolStripWareChange.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripWareChange.Text = "工序庫存調整"
        Me.ToolStripWareChange.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepName, Me.PS_Name, Me.SWI_Qty, Me.InQty, Me.OutQty, Me.BarCodeCount, Me.LoseCount, Me.DamageCount, Me.FinishedCount, Me.ReturnCount, Me.SendCount, Me.D_ID, Me.PS_NO})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'DepName
        '
        Me.DepName.Caption = "部门"
        Me.DepName.FieldName = "D_Dep"
        Me.DepName.Name = "DepName"
        Me.DepName.OptionsColumn.ReadOnly = True
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 0
        Me.DepName.Width = 64
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名称"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.SummaryItem.DisplayFormat = "合計:"
        Me.PS_Name.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 1
        Me.PS_Name.Width = 94
        '
        'SWI_Qty
        '
        Me.SWI_Qty.Caption = "库存数量"
        Me.SWI_Qty.FieldName = "SWI_Qty"
        Me.SWI_Qty.Name = "SWI_Qty"
        Me.SWI_Qty.OptionsColumn.ReadOnly = True
        Me.SWI_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.SWI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SWI_Qty.Visible = True
        Me.SWI_Qty.VisibleIndex = 2
        '
        'InQty
        '
        Me.InQty.Caption = "总收入"
        Me.InQty.FieldName = "InQty"
        Me.InQty.Name = "InQty"
        Me.InQty.OptionsColumn.ReadOnly = True
        Me.InQty.SummaryItem.DisplayFormat = "{0}"
        Me.InQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.InQty.Width = 63
        '
        'OutQty
        '
        Me.OutQty.Caption = "总发出"
        Me.OutQty.FieldName = "OutQty"
        Me.OutQty.Name = "OutQty"
        Me.OutQty.OptionsColumn.ReadOnly = True
        Me.OutQty.SummaryItem.DisplayFormat = "{0}"
        Me.OutQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.OutQty.Width = 64
        '
        'BarCodeCount
        '
        Me.BarCodeCount.Caption = "已借出未还"
        Me.BarCodeCount.FieldName = "BarCodeCount"
        Me.BarCodeCount.Name = "BarCodeCount"
        Me.BarCodeCount.OptionsColumn.ReadOnly = True
        Me.BarCodeCount.SummaryItem.DisplayFormat = "{0}"
        Me.BarCodeCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.BarCodeCount.Visible = True
        Me.BarCodeCount.VisibleIndex = 3
        Me.BarCodeCount.Width = 86
        '
        'LoseCount
        '
        Me.LoseCount.Caption = "丟失數量"
        Me.LoseCount.FieldName = "LoseCount"
        Me.LoseCount.Name = "LoseCount"
        Me.LoseCount.OptionsColumn.ReadOnly = True
        Me.LoseCount.SummaryItem.DisplayFormat = "{0}"
        Me.LoseCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.LoseCount.Visible = True
        Me.LoseCount.VisibleIndex = 4
        '
        'DamageCount
        '
        Me.DamageCount.Caption = "損壞數量"
        Me.DamageCount.FieldName = "DamageCount"
        Me.DamageCount.Name = "DamageCount"
        Me.DamageCount.OptionsColumn.ReadOnly = True
        Me.DamageCount.SummaryItem.DisplayFormat = "{0}"
        Me.DamageCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'FinishedCount
        '
        Me.FinishedCount.Caption = "完工數量 "
        Me.FinishedCount.FieldName = "FinishedCount"
        Me.FinishedCount.Name = "FinishedCount"
        Me.FinishedCount.OptionsColumn.ReadOnly = True
        Me.FinishedCount.SummaryItem.DisplayFormat = "{0}"
        Me.FinishedCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FinishedCount.Visible = True
        Me.FinishedCount.VisibleIndex = 5
        '
        'ReturnCount
        '
        Me.ReturnCount.Caption = "退料數量"
        Me.ReturnCount.FieldName = "ReturnCount"
        Me.ReturnCount.Name = "ReturnCount"
        Me.ReturnCount.OptionsColumn.ReadOnly = True
        Me.ReturnCount.SummaryItem.DisplayFormat = "{0}"
        Me.ReturnCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ReturnCount.Visible = True
        Me.ReturnCount.VisibleIndex = 6
        '
        'SendCount
        '
        Me.SendCount.Caption = "寄送数量"
        Me.SendCount.FieldName = "SendCount"
        Me.SendCount.Name = "SendCount"
        Me.SendCount.SummaryItem.DisplayFormat = "{0}"
        Me.SendCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SendCount.Visible = True
        Me.SendCount.VisibleIndex = 7
        '
        'D_ID
        '
        Me.D_ID.Caption = "D_ID"
        Me.D_ID.FieldName = "D_ID"
        Me.D_ID.Name = "D_ID"
        Me.D_ID.OptionsColumn.ReadOnly = True
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "PS_NO"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.OptionsColumn.ReadOnly = True
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(643, 217)
        Me.XtraTabPage4.Text = "条码采集"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView5
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(643, 217)
        Me.GridControl2.TabIndex = 81
        Me.GridControl2.TabStop = False
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCODEA, Me.ToolStripSeparator5, Me.cmdCODEDel, Me.ToolStripSeparator6})
        Me.ContextMenuStrip2.Name = "cmsMenuStrip"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(216, 72)
        '
        'cmdCODEA
        '
        Me.cmdCODEA.AutoSize = False
        Me.cmdCODEA.Enabled = False
        Me.cmdCODEA.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCODEA.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.cmdCODEA.Name = "cmdCODEA"
        Me.cmdCODEA.Size = New System.Drawing.Size(202, 28)
        Me.cmdCODEA.Text = "条码采集(&C)        Ctrl+C"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(212, 6)
        '
        'cmdCODEDel
        '
        Me.cmdCODEDel.AutoSize = False
        Me.cmdCODEDel.Enabled = False
        Me.cmdCODEDel.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCODEDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdCODEDel.Name = "cmdCODEDel"
        Me.cmdCODEDel.Size = New System.Drawing.Size(202, 28)
        Me.cmdCODEDel.Text = "删除条码(&D)        Ctrl+D"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(212, 6)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.ClientBarcode, Me.GridColumn1, Me.StatusTypeName, Me.GridColumn16, Me.RemarkCC, Me.GridColumn14, Me.GridColumn20})
        Me.GridView5.GridControl = Me.GridControl2
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "订单编号"
        Me.GridColumn8.FieldName = "SO_ID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 85
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "版本号"
        Me.GridColumn9.FieldName = "SS_Edition"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 57
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "产品编号"
        Me.GridColumn10.FieldName = "PM_M_Code"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "条码编号"
        Me.GridColumn11.FieldName = "Code_ID"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.SummaryItem.DisplayFormat = "數量:{0}"
        Me.GridColumn11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 155
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "数量"
        Me.GridColumn12.FieldName = "Code_Qty"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.SummaryItem.DisplayFormat = "合计:{0}"
        Me.GridColumn12.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn12.Width = 52
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "寄送单号"
        Me.GridColumn13.FieldName = "SP_ID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 107
        '
        'ClientBarcode
        '
        Me.ClientBarcode.Caption = "客戶條碼"
        Me.ClientBarcode.FieldName = "ClientBarcode"
        Me.ClientBarcode.Name = "ClientBarcode"
        Me.ClientBarcode.Visible = True
        Me.ClientBarcode.VisibleIndex = 2
        Me.ClientBarcode.Width = 167
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "部门"
        Me.GridColumn1.FieldName = "D_Dep"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'StatusTypeName
        '
        Me.StatusTypeName.Caption = "状态"
        Me.StatusTypeName.FieldName = "StatusTypeName"
        Me.StatusTypeName.Name = "StatusTypeName"
        Me.StatusTypeName.Visible = True
        Me.StatusTypeName.VisibleIndex = 4
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "条码类型"
        Me.GridColumn16.FieldName = "BarcodeType"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 5
        '
        'RemarkCC
        '
        Me.RemarkCC.Caption = "备注"
        Me.RemarkCC.FieldName = "Remark"
        Me.RemarkCC.Name = "RemarkCC"
        Me.RemarkCC.Visible = True
        Me.RemarkCC.VisibleIndex = 6
        Me.RemarkCC.Width = 114
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "AutoID"
        Me.GridColumn14.FieldName = "AutoID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "状态编号"
        Me.GridColumn20.FieldName = "StatusType"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'cmdSendBackQuery
        '
        Me.cmdSendBackQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSendBackQuery.Name = "cmdSendBackQuery"
        Me.cmdSendBackQuery.Size = New System.Drawing.Size(152, 22)
        Me.cmdSendBackQuery.Text = "样办退回查询"
        '
        'frmSampleOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 640)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSampleOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "样办订单管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SO_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_PoDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CusterNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SO_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_Rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SO_IDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SS_EditionSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SWI_QtySub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SS_RemarkSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NoSendQtySub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdCODE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCODEA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCODEDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaterialTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SWI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PS_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents InQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OutQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEditQty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarCodeCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoseCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DamageCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishedCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReturnCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSO_SampleID As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQueryInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripWareChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExcelA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSendBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdSendBackLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Code_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEditType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaSO_OrdersType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdOrderClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colSO_Closed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSendBackQuery As System.Windows.Forms.ToolStripMenuItem
End Class
