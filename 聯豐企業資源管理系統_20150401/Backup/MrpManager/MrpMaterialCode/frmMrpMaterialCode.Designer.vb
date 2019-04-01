<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpMaterialCode
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpMaterialCode))
        Me.lblinfo = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.xtcTable = New DevExpress.XtraTab.XtraTabControl
        Me.xtpCheck = New DevExpress.XtraTab.XtraTabPage
        Me.txtrecheckaction = New System.Windows.Forms.Label
        Me.txtrecheckdate = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkCheckBit = New DevExpress.XtraEditors.CheckEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.lblCheckUserID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtpGridView = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Check = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DefaultBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkDefaultBit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.CurrencyName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EconomicQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MaxQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MinQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkMC_MRPCon = New DevExpress.XtraEditors.CheckEdit
        Me.gueSource = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SourceID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtM_Unit = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMC_OrderMan = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.caeMC_BatchQty = New DevExpress.XtraEditors.CalcEdit
        Me.lblMC_OrderInterVal = New System.Windows.Forms.Label
        Me.lblMC_BatFixEconomy = New System.Windows.Forms.Label
        Me.caeMC_QtyMin = New DevExpress.XtraEditors.CalcEdit
        Me.lblMC_BatchQty = New System.Windows.Forms.Label
        Me.caeMC_OrderInterVal = New DevExpress.XtraEditors.CalcEdit
        Me.lblMC_OrderMan = New System.Windows.Forms.Label
        Me.caeMC_BatFixEconomy = New DevExpress.XtraEditors.CalcEdit
        Me.caeMC_QtyMax = New DevExpress.XtraEditors.CalcEdit
        Me.lblMC_QtyMax = New System.Windows.Forms.Label
        Me.lblMC_QtyMin = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.caeMC_LowLimit = New DevExpress.XtraEditors.CalcEdit
        Me.caeMC_SecInv = New DevExpress.XtraEditors.CalcEdit
        Me.lblMC_LowLimit = New System.Windows.Forms.Label
        Me.lblMC_WH_ID = New System.Windows.Forms.Label
        Me.gueMC_WH_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MC_WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblMC_SecInv = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.meeMC_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.lblCheckRemark = New System.Windows.Forms.Label
        Me.txtM_Gauge = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.gueM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblM_Code = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MC_Source = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.gluS_Supplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTable.SuspendLayout()
        Me.xtpCheck.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpGridView.SuspendLayout()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDefaultBit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chkMC_MRPCon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gueSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMC_OrderMan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_BatchQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_QtyMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_OrderInterVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_BatFixEconomy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_QtyMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.caeMC_LowLimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeMC_SecInv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gueMC_WH_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meeMC_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gueM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gluS_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblinfo.Size = New System.Drawing.Size(153, 21)
        Me.lblinfo.TabIndex = 87
        Me.lblinfo.Text = "MRP物料編碼表"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cmdExit)
        Me.Panel3.Controls.Add(Me.cmdSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(0, 749)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(842, 42)
        Me.Panel3.TabIndex = 143
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(741, 8)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(81, 27)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(631, 8)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "確認(&O)"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(842, 749)
        Me.XtraTabControl2.TabIndex = 235
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl2.TabStop = False
        Me.XtraTabControl2.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Controls.Add(Me.Panel1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(833, 717)
        Me.XtraTabPage1.Text = "基本信息"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.xtcTable)
        Me.Panel2.Location = New System.Drawing.Point(0, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 469)
        Me.Panel2.TabIndex = 257
        '
        'xtcTable
        '
        Me.xtcTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcTable.Location = New System.Drawing.Point(0, 0)
        Me.xtcTable.Name = "xtcTable"
        Me.xtcTable.SelectedTabPage = Me.xtpCheck
        Me.xtcTable.Size = New System.Drawing.Size(833, 469)
        Me.xtcTable.TabIndex = 223
        Me.xtcTable.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGridView, Me.xtpCheck})
        '
        'xtpCheck
        '
        Me.xtpCheck.Controls.Add(Me.txtrecheckaction)
        Me.xtpCheck.Controls.Add(Me.txtrecheckdate)
        Me.xtpCheck.Controls.Add(Me.Label17)
        Me.xtpCheck.Controls.Add(Me.Label18)
        Me.xtpCheck.Controls.Add(Me.Label19)
        Me.xtpCheck.Controls.Add(Me.Label21)
        Me.xtpCheck.Controls.Add(Me.Panel4)
        Me.xtpCheck.Name = "xtpCheck"
        Me.xtpCheck.PageVisible = False
        Me.xtpCheck.Size = New System.Drawing.Size(824, 437)
        Me.xtpCheck.Text = "審核信息"
        '
        'txtrecheckaction
        '
        Me.txtrecheckaction.AutoSize = True
        Me.txtrecheckaction.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckaction.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckaction.Location = New System.Drawing.Point(274, 15)
        Me.txtrecheckaction.Name = "txtrecheckaction"
        Me.txtrecheckaction.Size = New System.Drawing.Size(0, 15)
        Me.txtrecheckaction.TabIndex = 0
        '
        'txtrecheckdate
        '
        Me.txtrecheckdate.AutoSize = True
        Me.txtrecheckdate.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckdate.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckdate.Location = New System.Drawing.Point(468, 15)
        Me.txtrecheckdate.Name = "txtrecheckdate"
        Me.txtrecheckdate.Size = New System.Drawing.Size(0, 15)
        Me.txtrecheckdate.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(394, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 15)
        Me.Label17.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(217, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 15)
        Me.Label18.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 15)
        Me.Label19.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(15, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 15)
        Me.Label21.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtCheckRemark)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.chkCheckBit)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lblCheckDate)
        Me.Panel4.Controls.Add(Me.lblCheckUserID)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(824, 437)
        Me.Panel4.TabIndex = 5
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(84, 50)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Properties.MaxLength = 200
        Me.txtCheckRemark.ShowToolTips = False
        Me.txtCheckRemark.Size = New System.Drawing.Size(704, 200)
        Me.txtCheckRemark.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "備注(&N)："
        '
        'chkCheckBit
        '
        Me.chkCheckBit.Location = New System.Drawing.Point(84, 13)
        Me.chkCheckBit.Name = "chkCheckBit"
        Me.chkCheckBit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckBit.Properties.Appearance.Options.UseFont = True
        Me.chkCheckBit.Properties.Caption = "確認"
        Me.chkCheckBit.Size = New System.Drawing.Size(92, 20)
        Me.chkCheckBit.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "審核(&G)："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(347, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "審核人："
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(599, 15)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(23, 15)
        Me.lblCheckDate.TabIndex = 6
        Me.lblCheckDate.Text = "    "
        '
        'lblCheckUserID
        '
        Me.lblCheckUserID.AutoSize = True
        Me.lblCheckUserID.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUserID.Location = New System.Drawing.Point(411, 15)
        Me.lblCheckUserID.Name = "lblCheckUserID"
        Me.lblCheckUserID.Size = New System.Drawing.Size(23, 15)
        Me.lblCheckUserID.TabIndex = 5
        Me.lblCheckUserID.Text = "    "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "審核日期："
        '
        'xtpGridView
        '
        Me.xtpGridView.Controls.Add(Me.PopupContainerControl1)
        Me.xtpGridView.Controls.Add(Me.Grid1)
        Me.xtpGridView.Name = "xtpGridView"
        Me.xtpGridView.Size = New System.Drawing.Size(824, 437)
        Me.xtpGridView.Text = "物料明細"
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.GridControl1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(41, 84)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(342, 191)
        Me.PopupContainerControl1.TabIndex = 224
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView4
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemButtonEdit1, Me.RepositoryItemTimeEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemPopupContainerEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemCalcEdit4, Me.RepositoryItemImageComboBox2, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemMemoEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit5, Me.RepositoryItemDateEdit6})
        Me.GridControl1.Size = New System.Drawing.Size(342, 191)
        Me.GridControl1.TabIndex = 210
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn19})
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "供應商編號"
        Me.GridColumn2.FieldName = "S_Supplier"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 106
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "供應商名稱"
        Me.GridColumn19.FieldName = "S_SupplierName"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        Me.GridColumn19.Width = 200
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
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'RepositoryItemPopupContainerEdit2
        '
        Me.RepositoryItemPopupContainerEdit2.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit2.Name = "RepositoryItemPopupContainerEdit2"
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'RepositoryItemImageComboBox2
        '
        Me.RepositoryItemImageComboBox2.AutoHeight = False
        Me.RepositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox2.Name = "RepositoryItemImageComboBox2"
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        '
        'RepositoryItemDateEdit6
        '
        Me.RepositoryItemDateEdit6.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit6.AutoHeight = False
        Me.RepositoryItemDateEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit6.Name = "RepositoryItemDateEdit6"
        Me.RepositoryItemDateEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsMenuStrip
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Enabled = False
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemPopupContainerEdit3, Me.RepositoryItemMemoExEdit4, Me.chkDefaultBit})
        Me.Grid1.Size = New System.Drawing.Size(824, 437)
        Me.Grid1.TabIndex = 209
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmDelete, Me.tsm_Check})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(163, 92)
        '
        'tsmNew
        '
        Me.tsmNew.Image = CType(resources.GetObject("tsmNew.Image"), System.Drawing.Image)
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(162, 22)
        Me.tsmNew.Text = "新增(&A)"
        '
        'tsmDelete
        '
        Me.tsmDelete.Image = CType(resources.GetObject("tsmDelete.Image"), System.Drawing.Image)
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(162, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        '
        'tsm_Check
        '
        Me.tsm_Check.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.tsm_Check.Name = "tsm_Check"
        Me.tsm_Check.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsm_Check.Size = New System.Drawing.Size(162, 22)
        Me.tsm_Check.Text = "審核(&C)"
        Me.tsm_Check.Visible = False
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DefaultBit, Me.S_Supplier, Me.S_SupplierName, Me.UnitPrice, Me.CurrencyName, Me.EconomicQty, Me.OrderQty, Me.DeliveryDate, Me.MaxQty, Me.MinQty, Me.Remark, Me.GridColumn1})
        Me.GridView.GridControl = Me.Grid1
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'DefaultBit
        '
        Me.DefaultBit.Caption = "默認"
        Me.DefaultBit.ColumnEdit = Me.chkDefaultBit
        Me.DefaultBit.FieldName = "DefaultBit"
        Me.DefaultBit.Name = "DefaultBit"
        Me.DefaultBit.Visible = True
        Me.DefaultBit.VisibleIndex = 0
        Me.DefaultBit.Width = 47
        '
        'chkDefaultBit
        '
        Me.chkDefaultBit.AutoHeight = False
        Me.chkDefaultBit.Name = "chkDefaultBit"
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.ColumnEdit = Me.RepositoryItemPopupContainerEdit3
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 1
        Me.S_Supplier.Width = 85
        '
        'RepositoryItemPopupContainerEdit3
        '
        Me.RepositoryItemPopupContainerEdit3.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit3.Name = "RepositoryItemPopupContainerEdit3"
        Me.RepositoryItemPopupContainerEdit3.PopupControl = Me.PopupContainerControl1
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.OptionsColumn.AllowEdit = False
        Me.S_SupplierName.OptionsColumn.ReadOnly = True
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 2
        Me.S_SupplierName.Width = 160
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 3
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'CurrencyName
        '
        Me.CurrencyName.Caption = "幣別"
        Me.CurrencyName.FieldName = "CurrencyName"
        Me.CurrencyName.Name = "CurrencyName"
        Me.CurrencyName.OptionsColumn.AllowEdit = False
        Me.CurrencyName.OptionsColumn.ReadOnly = True
        Me.CurrencyName.Visible = True
        Me.CurrencyName.VisibleIndex = 4
        '
        'EconomicQty
        '
        Me.EconomicQty.Caption = "經濟批量"
        Me.EconomicQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.EconomicQty.FieldName = "EconomicQty"
        Me.EconomicQty.Name = "EconomicQty"
        Me.EconomicQty.Visible = True
        Me.EconomicQty.VisibleIndex = 5
        Me.EconomicQty.Width = 85
        '
        'OrderQty
        '
        Me.OrderQty.Caption = "訂購批量"
        Me.OrderQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.OrderQty.FieldName = "OrderQty"
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Visible = True
        Me.OrderQty.VisibleIndex = 6
        Me.OrderQty.Width = 85
        '
        'DeliveryDate
        '
        Me.DeliveryDate.Caption = "採購週期"
        Me.DeliveryDate.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.DeliveryDate.FieldName = "DeliveryDate"
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.Visible = True
        Me.DeliveryDate.VisibleIndex = 7
        Me.DeliveryDate.Width = 87
        '
        'MaxQty
        '
        Me.MaxQty.Caption = "最大採購數量"
        Me.MaxQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MaxQty.FieldName = "MaxQty"
        Me.MaxQty.Name = "MaxQty"
        Me.MaxQty.Visible = True
        Me.MaxQty.VisibleIndex = 8
        Me.MaxQty.Width = 117
        '
        'MinQty
        '
        Me.MinQty.Caption = "最小採購數量"
        Me.MinQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MinQty.FieldName = "MinQty"
        Me.MinQty.Name = "MinQty"
        Me.MinQty.Visible = True
        Me.MinQty.VisibleIndex = 9
        Me.MinQty.Width = 93
        '
        'Remark
        '
        Me.Remark.Caption = "備註"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit4
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 10
        Me.Remark.Width = 120
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "AutoIDA"
        Me.GridColumn1.FieldName = "AutoID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.chkMC_MRPCon)
        Me.Panel1.Controls.Add(Me.gueSource)
        Me.Panel1.Controls.Add(Me.txtM_Unit)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.meeMC_Remark)
        Me.Panel1.Controls.Add(Me.lblCheckRemark)
        Me.Panel1.Controls.Add(Me.txtM_Gauge)
        Me.Panel1.Controls.Add(Me.txtM_Name)
        Me.Panel1.Controls.Add(Me.gueM_Code)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblM_Code)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MC_Source)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 235)
        Me.Panel1.TabIndex = 256
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(505, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "MRP 選擇:"
        '
        'chkMC_MRPCon
        '
        Me.chkMC_MRPCon.EditValue = True
        Me.chkMC_MRPCon.Location = New System.Drawing.Point(581, 65)
        Me.chkMC_MRPCon.Name = "chkMC_MRPCon"
        Me.chkMC_MRPCon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chkMC_MRPCon.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkMC_MRPCon.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.chkMC_MRPCon.Properties.Appearance.Options.UseBackColor = True
        Me.chkMC_MRPCon.Properties.Appearance.Options.UseFont = True
        Me.chkMC_MRPCon.Properties.Appearance.Options.UseForeColor = True
        Me.chkMC_MRPCon.Properties.Caption = "Mrp合并需求"
        Me.chkMC_MRPCon.Size = New System.Drawing.Size(111, 20)
        Me.chkMC_MRPCon.TabIndex = 13
        '
        'gueSource
        '
        Me.gueSource.Location = New System.Drawing.Point(389, 9)
        Me.gueSource.Name = "gueSource"
        Me.gueSource.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gueSource.Properties.Appearance.Options.UseFont = True
        Me.gueSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueSource.Properties.DisplayMember = "MC_Source"
        Me.gueSource.Properties.NullText = ""
        Me.gueSource.Properties.PopupFormWidth = 75
        Me.gueSource.Properties.ValueMember = "MC_SourceID"
        Me.gueSource.Properties.View = Me.GridView2
        Me.gueSource.Size = New System.Drawing.Size(109, 24)
        Me.gueSource.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SourceID, Me.Source})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SourceID
        '
        Me.SourceID.Caption = "來源編碼"
        Me.SourceID.FieldName = "MC_SourceID"
        Me.SourceID.Name = "SourceID"
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "MC_Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 0
        '
        'txtM_Unit
        '
        Me.txtM_Unit.Enabled = False
        Me.txtM_Unit.Location = New System.Drawing.Point(577, 9)
        Me.txtM_Unit.Margin = New System.Windows.Forms.Padding(6)
        Me.txtM_Unit.Name = "txtM_Unit"
        Me.txtM_Unit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Unit.Properties.Appearance.Options.UseFont = True
        Me.txtM_Unit.Size = New System.Drawing.Size(153, 24)
        Me.txtM_Unit.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMC_OrderMan)
        Me.GroupBox1.Controls.Add(Me.caeMC_BatchQty)
        Me.GroupBox1.Controls.Add(Me.lblMC_OrderInterVal)
        Me.GroupBox1.Controls.Add(Me.lblMC_BatFixEconomy)
        Me.GroupBox1.Controls.Add(Me.caeMC_QtyMin)
        Me.GroupBox1.Controls.Add(Me.lblMC_BatchQty)
        Me.GroupBox1.Controls.Add(Me.caeMC_OrderInterVal)
        Me.GroupBox1.Controls.Add(Me.lblMC_OrderMan)
        Me.GroupBox1.Controls.Add(Me.caeMC_BatFixEconomy)
        Me.GroupBox1.Controls.Add(Me.caeMC_QtyMax)
        Me.GroupBox1.Controls.Add(Me.lblMC_QtyMax)
        Me.GroupBox1.Controls.Add(Me.lblMC_QtyMin)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(273, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 102)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "訂購資料"
        '
        'txtMC_OrderMan
        '
        Me.txtMC_OrderMan.EditValue = ""
        Me.txtMC_OrderMan.EnterMoveNextControl = True
        Me.txtMC_OrderMan.Location = New System.Drawing.Point(335, 66)
        Me.txtMC_OrderMan.Name = "txtMC_OrderMan"
        Me.txtMC_OrderMan.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMC_OrderMan.Properties.Appearance.Options.UseFont = True
        Me.txtMC_OrderMan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMC_OrderMan.Properties.DisplayMember = "U_Name"
        Me.txtMC_OrderMan.Properties.NullText = ""
        Me.txtMC_OrderMan.Properties.PopupFormWidth = 180
        Me.txtMC_OrderMan.Properties.ValueMember = "U_ID"
        Me.txtMC_OrderMan.Properties.View = Me.GridLookUpEdit1View
        Me.txtMC_OrderMan.Size = New System.Drawing.Size(120, 24)
        Me.txtMC_OrderMan.TabIndex = 11
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Appearance.Row.Options.UseTextOptions = True
        Me.GridLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn25})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "帳號"
        Me.GridColumn5.FieldName = "U_ID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 70
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.Caption = "姓名"
        Me.GridColumn25.FieldName = "U_Name"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 1
        Me.GridColumn25.Width = 90
        '
        'caeMC_BatchQty
        '
        Me.caeMC_BatchQty.Location = New System.Drawing.Point(111, 39)
        Me.caeMC_BatchQty.Name = "caeMC_BatchQty"
        Me.caeMC_BatchQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_BatchQty.Properties.Appearance.Options.UseFont = True
        Me.caeMC_BatchQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_BatchQty.Size = New System.Drawing.Size(115, 24)
        Me.caeMC_BatchQty.TabIndex = 5
        '
        'lblMC_OrderInterVal
        '
        Me.lblMC_OrderInterVal.AutoSize = True
        Me.lblMC_OrderInterVal.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_OrderInterVal.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_OrderInterVal.ForeColor = System.Drawing.Color.Black
        Me.lblMC_OrderInterVal.Location = New System.Drawing.Point(15, 68)
        Me.lblMC_OrderInterVal.Name = "lblMC_OrderInterVal"
        Me.lblMC_OrderInterVal.Size = New System.Drawing.Size(90, 15)
        Me.lblMC_OrderInterVal.TabIndex = 8
        Me.lblMC_OrderInterVal.Text = "採購週期(&R):"
        '
        'lblMC_BatFixEconomy
        '
        Me.lblMC_BatFixEconomy.AutoSize = True
        Me.lblMC_BatFixEconomy.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_BatFixEconomy.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_BatFixEconomy.ForeColor = System.Drawing.Color.Black
        Me.lblMC_BatFixEconomy.Location = New System.Drawing.Point(15, 18)
        Me.lblMC_BatFixEconomy.Name = "lblMC_BatFixEconomy"
        Me.lblMC_BatFixEconomy.Size = New System.Drawing.Size(90, 15)
        Me.lblMC_BatFixEconomy.TabIndex = 0
        Me.lblMC_BatFixEconomy.Text = "經濟批量(&E):"
        '
        'caeMC_QtyMin
        '
        Me.caeMC_QtyMin.Location = New System.Drawing.Point(335, 39)
        Me.caeMC_QtyMin.Name = "caeMC_QtyMin"
        Me.caeMC_QtyMin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_QtyMin.Properties.Appearance.Options.UseFont = True
        Me.caeMC_QtyMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_QtyMin.Size = New System.Drawing.Size(120, 24)
        Me.caeMC_QtyMin.TabIndex = 7
        '
        'lblMC_BatchQty
        '
        Me.lblMC_BatchQty.AutoSize = True
        Me.lblMC_BatchQty.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_BatchQty.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_BatchQty.ForeColor = System.Drawing.Color.Black
        Me.lblMC_BatchQty.Location = New System.Drawing.Point(11, 42)
        Me.lblMC_BatchQty.Name = "lblMC_BatchQty"
        Me.lblMC_BatchQty.Size = New System.Drawing.Size(94, 15)
        Me.lblMC_BatchQty.TabIndex = 4
        Me.lblMC_BatchQty.Text = "訂購批量(&W):"
        '
        'caeMC_OrderInterVal
        '
        Me.caeMC_OrderInterVal.Location = New System.Drawing.Point(111, 65)
        Me.caeMC_OrderInterVal.Name = "caeMC_OrderInterVal"
        Me.caeMC_OrderInterVal.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_OrderInterVal.Properties.Appearance.Options.UseFont = True
        Me.caeMC_OrderInterVal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_OrderInterVal.Size = New System.Drawing.Size(115, 24)
        Me.caeMC_OrderInterVal.TabIndex = 9
        '
        'lblMC_OrderMan
        '
        Me.lblMC_OrderMan.AutoSize = True
        Me.lblMC_OrderMan.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_OrderMan.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_OrderMan.ForeColor = System.Drawing.Color.Black
        Me.lblMC_OrderMan.Location = New System.Drawing.Point(226, 69)
        Me.lblMC_OrderMan.Name = "lblMC_OrderMan"
        Me.lblMC_OrderMan.Size = New System.Drawing.Size(106, 15)
        Me.lblMC_OrderMan.TabIndex = 10
        Me.lblMC_OrderMan.Text = "採購負責人(&A):"
        '
        'caeMC_BatFixEconomy
        '
        Me.caeMC_BatFixEconomy.Location = New System.Drawing.Point(111, 13)
        Me.caeMC_BatFixEconomy.Name = "caeMC_BatFixEconomy"
        Me.caeMC_BatFixEconomy.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_BatFixEconomy.Properties.Appearance.Options.UseFont = True
        Me.caeMC_BatFixEconomy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_BatFixEconomy.Size = New System.Drawing.Size(115, 24)
        Me.caeMC_BatFixEconomy.TabIndex = 1
        '
        'caeMC_QtyMax
        '
        Me.caeMC_QtyMax.Location = New System.Drawing.Point(335, 13)
        Me.caeMC_QtyMax.Name = "caeMC_QtyMax"
        Me.caeMC_QtyMax.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_QtyMax.Properties.Appearance.Options.UseFont = True
        Me.caeMC_QtyMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_QtyMax.Size = New System.Drawing.Size(120, 24)
        Me.caeMC_QtyMax.TabIndex = 3
        '
        'lblMC_QtyMax
        '
        Me.lblMC_QtyMax.AutoSize = True
        Me.lblMC_QtyMax.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_QtyMax.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_QtyMax.ForeColor = System.Drawing.Color.Black
        Me.lblMC_QtyMax.Location = New System.Drawing.Point(228, 18)
        Me.lblMC_QtyMax.Name = "lblMC_QtyMax"
        Me.lblMC_QtyMax.Size = New System.Drawing.Size(104, 15)
        Me.lblMC_QtyMax.TabIndex = 2
        Me.lblMC_QtyMax.Text = "最大訂購量(&S):"
        '
        'lblMC_QtyMin
        '
        Me.lblMC_QtyMin.AutoSize = True
        Me.lblMC_QtyMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_QtyMin.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_QtyMin.ForeColor = System.Drawing.Color.Black
        Me.lblMC_QtyMin.Location = New System.Drawing.Point(226, 42)
        Me.lblMC_QtyMin.Name = "lblMC_QtyMin"
        Me.lblMC_QtyMin.Size = New System.Drawing.Size(106, 15)
        Me.lblMC_QtyMin.TabIndex = 6
        Me.lblMC_QtyMin.Text = "最小訂購量(&D):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.caeMC_LowLimit)
        Me.GroupBox2.Controls.Add(Me.caeMC_SecInv)
        Me.GroupBox2.Controls.Add(Me.lblMC_LowLimit)
        Me.GroupBox2.Controls.Add(Me.lblMC_WH_ID)
        Me.GroupBox2.Controls.Add(Me.gueMC_WH_ID)
        Me.GroupBox2.Controls.Add(Me.lblMC_SecInv)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 104)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "庫存資料"
        '
        'caeMC_LowLimit
        '
        Me.caeMC_LowLimit.Location = New System.Drawing.Point(97, 40)
        Me.caeMC_LowLimit.Name = "caeMC_LowLimit"
        Me.caeMC_LowLimit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_LowLimit.Properties.Appearance.Options.UseFont = True
        Me.caeMC_LowLimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_LowLimit.Size = New System.Drawing.Size(161, 24)
        Me.caeMC_LowLimit.TabIndex = 3
        '
        'caeMC_SecInv
        '
        Me.caeMC_SecInv.Location = New System.Drawing.Point(97, 66)
        Me.caeMC_SecInv.Name = "caeMC_SecInv"
        Me.caeMC_SecInv.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeMC_SecInv.Properties.Appearance.Options.UseFont = True
        Me.caeMC_SecInv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeMC_SecInv.Size = New System.Drawing.Size(161, 24)
        Me.caeMC_SecInv.TabIndex = 5
        '
        'lblMC_LowLimit
        '
        Me.lblMC_LowLimit.AutoSize = True
        Me.lblMC_LowLimit.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_LowLimit.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_LowLimit.ForeColor = System.Drawing.Color.Black
        Me.lblMC_LowLimit.Location = New System.Drawing.Point(9, 43)
        Me.lblMC_LowLimit.Name = "lblMC_LowLimit"
        Me.lblMC_LowLimit.Size = New System.Drawing.Size(89, 15)
        Me.lblMC_LowLimit.TabIndex = 2
        Me.lblMC_LowLimit.Text = "最低庫存(&F):"
        '
        'lblMC_WH_ID
        '
        Me.lblMC_WH_ID.AutoSize = True
        Me.lblMC_WH_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_WH_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_WH_ID.ForeColor = System.Drawing.Color.Black
        Me.lblMC_WH_ID.Location = New System.Drawing.Point(6, 18)
        Me.lblMC_WH_ID.Name = "lblMC_WH_ID"
        Me.lblMC_WH_ID.Size = New System.Drawing.Size(91, 15)
        Me.lblMC_WH_ID.TabIndex = 0
        Me.lblMC_WH_ID.Text = "入庫倉庫(&V):"
        '
        'gueMC_WH_ID
        '
        Me.gueMC_WH_ID.EditValue = ""
        Me.gueMC_WH_ID.Location = New System.Drawing.Point(97, 13)
        Me.gueMC_WH_ID.Name = "gueMC_WH_ID"
        Me.gueMC_WH_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gueMC_WH_ID.Properties.Appearance.Options.UseFont = True
        Me.gueMC_WH_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueMC_WH_ID.Properties.DisplayMember = "MC_WH_Name"
        Me.gueMC_WH_ID.Properties.NullText = ""
        Me.gueMC_WH_ID.Properties.PopupFormWidth = 200
        Me.gueMC_WH_ID.Properties.ValueMember = "MC_WH_ID"
        Me.gueMC_WH_ID.Properties.View = Me.GridView1
        Me.gueMC_WH_ID.Size = New System.Drawing.Size(161, 24)
        Me.gueMC_WH_ID.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MC_WH_ID, Me.MC_WH_Name})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MC_WH_ID
        '
        Me.MC_WH_ID.Caption = "倉庫ID"
        Me.MC_WH_ID.FieldName = "MC_WH_ID"
        Me.MC_WH_ID.Name = "MC_WH_ID"
        Me.MC_WH_ID.ToolTip = "倉庫ID"
        Me.MC_WH_ID.Visible = True
        Me.MC_WH_ID.VisibleIndex = 0
        Me.MC_WH_ID.Width = 456
        '
        'MC_WH_Name
        '
        Me.MC_WH_Name.Caption = "倉庫名稱"
        Me.MC_WH_Name.FieldName = "MC_WH_Name"
        Me.MC_WH_Name.Name = "MC_WH_Name"
        Me.MC_WH_Name.Visible = True
        Me.MC_WH_Name.VisibleIndex = 1
        Me.MC_WH_Name.Width = 750
        '
        'lblMC_SecInv
        '
        Me.lblMC_SecInv.AutoSize = True
        Me.lblMC_SecInv.BackColor = System.Drawing.Color.Transparent
        Me.lblMC_SecInv.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMC_SecInv.ForeColor = System.Drawing.Color.Black
        Me.lblMC_SecInv.Location = New System.Drawing.Point(7, 69)
        Me.lblMC_SecInv.Name = "lblMC_SecInv"
        Me.lblMC_SecInv.Size = New System.Drawing.Size(90, 15)
        Me.lblMC_SecInv.TabIndex = 4
        Me.lblMC_SecInv.Text = "安全庫存(&Z):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(505, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "單位(&H):"
        '
        'meeMC_Remark
        '
        Me.meeMC_Remark.Location = New System.Drawing.Point(98, 61)
        Me.meeMC_Remark.Name = "meeMC_Remark"
        Me.meeMC_Remark.Size = New System.Drawing.Size(401, 53)
        Me.meeMC_Remark.TabIndex = 11
        '
        'lblCheckRemark
        '
        Me.lblCheckRemark.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCheckRemark.AutoSize = True
        Me.lblCheckRemark.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckRemark.Location = New System.Drawing.Point(3, 66)
        Me.lblCheckRemark.Name = "lblCheckRemark"
        Me.lblCheckRemark.Size = New System.Drawing.Size(89, 15)
        Me.lblCheckRemark.TabIndex = 10
        Me.lblCheckRemark.Text = "備       註(&G):"
        '
        'txtM_Gauge
        '
        Me.txtM_Gauge.Enabled = False
        Me.txtM_Gauge.Location = New System.Drawing.Point(389, 35)
        Me.txtM_Gauge.Margin = New System.Windows.Forms.Padding(6)
        Me.txtM_Gauge.Name = "txtM_Gauge"
        Me.txtM_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txtM_Gauge.Size = New System.Drawing.Size(341, 24)
        Me.txtM_Gauge.TabIndex = 9
        '
        'txtM_Name
        '
        Me.txtM_Name.Enabled = False
        Me.txtM_Name.Location = New System.Drawing.Point(98, 35)
        Me.txtM_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Size = New System.Drawing.Size(191, 24)
        Me.txtM_Name.TabIndex = 7
        '
        'gueM_Code
        '
        Me.gueM_Code.EditValue = ""
        Me.gueM_Code.Enabled = False
        Me.gueM_Code.Location = New System.Drawing.Point(98, 9)
        Me.gueM_Code.Name = "gueM_Code"
        Me.gueM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gueM_Code.Properties.Appearance.Options.UseFont = True
        Me.gueM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueM_Code.Properties.DisplayMember = "M_Code"
        Me.gueM_Code.Properties.NullText = ""
        Me.gueM_Code.Properties.PopupFormWidth = 300
        Me.gueM_Code.Properties.ValueMember = "M_Code"
        Me.gueM_Code.Properties.View = Me.GridView3
        Me.gueM_Code.Size = New System.Drawing.Size(192, 24)
        Me.gueM_Code.TabIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Unit})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.ToolTip = "產品編號"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 150
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 100
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 2
        Me.M_Unit.Width = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(295, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "產品規格(&P):"
        '
        'lblM_Code
        '
        Me.lblM_Code.AutoSize = True
        Me.lblM_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblM_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblM_Code.ForeColor = System.Drawing.Color.Black
        Me.lblM_Code.Location = New System.Drawing.Point(4, 14)
        Me.lblM_Code.Name = "lblM_Code"
        Me.lblM_Code.Size = New System.Drawing.Size(91, 15)
        Me.lblM_Code.TabIndex = 0
        Me.lblM_Code.Text = "產品编號(&Q):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "產品名稱(&N):"
        '
        'MC_Source
        '
        Me.MC_Source.AutoSize = True
        Me.MC_Source.BackColor = System.Drawing.Color.Transparent
        Me.MC_Source.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MC_Source.ForeColor = System.Drawing.Color.Black
        Me.MC_Source.Location = New System.Drawing.Point(296, 14)
        Me.MC_Source.Name = "MC_Source"
        Me.MC_Source.Size = New System.Drawing.Size(92, 15)
        Me.MC_Source.TabIndex = 2
        Me.MC_Source.Text = "來  源  碼(&X):"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.gluS_Supplier)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(501, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 40)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'gluS_Supplier
        '
        Me.gluS_Supplier.EditValue = ""
        Me.gluS_Supplier.Location = New System.Drawing.Point(77, 11)
        Me.gluS_Supplier.Name = "gluS_Supplier"
        Me.gluS_Supplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluS_Supplier.Properties.Appearance.Options.UseFont = True
        Me.gluS_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluS_Supplier.Properties.DisplayMember = "S_SupplierName"
        Me.gluS_Supplier.Properties.NullText = ""
        Me.gluS_Supplier.Properties.PopupFormWidth = 270
        Me.gluS_Supplier.Properties.ValueMember = "S_Supplier"
        Me.gluS_Supplier.Properties.View = Me.GridView9
        Me.gluS_Supplier.Size = New System.Drawing.Size(151, 24)
        Me.gluS_Supplier.TabIndex = 15
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowAutoFilterRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "編號"
        Me.GridColumn3.FieldName = "S_Supplier"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.ToolTip = "倉庫ID"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "名稱"
        Me.GridColumn4.FieldName = "S_SupplierName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 306
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "供應商(&H):"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(842, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 236
        Me.PictureBox1.TabStop = False
        '
        'frmMrpMaterialCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 791)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmMrpMaterialCode"
        Me.Text = "MRP物料編碼表"
        Me.Panel3.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTable.ResumeLayout(False)
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpGridView.ResumeLayout(False)
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDefaultBit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chkMC_MRPCon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gueSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMC_OrderMan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_BatchQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_QtyMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_OrderInterVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_BatFixEconomy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_QtyMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.caeMC_LowLimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeMC_SecInv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gueMC_WH_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meeMC_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gueM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gluS_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkMC_MRPCon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents caeMC_LowLimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents caeMC_SecInv As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblMC_LowLimit As System.Windows.Forms.Label
    Friend WithEvents lblMC_WH_ID As System.Windows.Forms.Label
    Friend WithEvents gueMC_WH_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MC_WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblMC_SecInv As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents caeMC_BatchQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblMC_OrderInterVal As System.Windows.Forms.Label
    Friend WithEvents lblMC_BatFixEconomy As System.Windows.Forms.Label
    Friend WithEvents caeMC_QtyMin As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblMC_BatchQty As System.Windows.Forms.Label
    Friend WithEvents caeMC_OrderInterVal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblMC_OrderMan As System.Windows.Forms.Label
    Friend WithEvents caeMC_BatFixEconomy As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents caeMC_QtyMax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblMC_QtyMax As System.Windows.Forms.Label
    Friend WithEvents lblMC_QtyMin As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gueSource As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SourceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtM_Unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents meeMC_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblCheckRemark As System.Windows.Forms.Label
    Friend WithEvents txtM_Gauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gueM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblM_Code As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MC_Source As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents xtcTable As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkCheckBit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCheckUserID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtrecheckaction As System.Windows.Forms.Label
    Friend WithEvents txtrecheckdate As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpGridView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents CurrencyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EconomicQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaxQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MinQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Check As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gluS_Supplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DefaultBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkDefaultBit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtMC_OrderMan As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
