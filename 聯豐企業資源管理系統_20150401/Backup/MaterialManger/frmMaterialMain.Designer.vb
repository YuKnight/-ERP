<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.popMaterialMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popMaterialMainAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainAudit = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popToolStripPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popMaterialMainFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popMaterialMainPhoto = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainView = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popMaterialMainSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popMaterialMainCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainExport = New System.Windows.Forms.ToolStripMenuItem
        Me.popMaterialMainNouse = New System.Windows.Forms.ToolStripMenuItem
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.popMaterialType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popMaterialTypeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tcList = New DevExpress.XtraTab.XtraTabControl
        Me.tcP1 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP2 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP3 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP4 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP5 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP7 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP6 = New DevExpress.XtraTab.XtraTabPage
        Me.tcP8 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_IsEnabled = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_FinalDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GridSub = New System.Windows.Forms.DataGridView
        Me.cmsQuality = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsQualityPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.popReport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popReportOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Currency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.popMaterialMain.SuspendLayout()
        Me.popMaterialType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcList.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsQuality.SuspendLayout()
        Me.popReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'popMaterialMain
        '
        Me.popMaterialMain.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popMaterialMainAdd, Me.popMaterialMainEdit, Me.popMaterialMainAudit, Me.popMaterialMainDel, Me.ToolStripSeparator3, Me.popToolStripPrice, Me.ToolStripSeparator1, Me.popMaterialMainFile, Me.ToolStripSeparator4, Me.popMaterialMainPhoto, Me.popMaterialMainView, Me.popMaterialMainRef, Me.ToolStripSeparator5, Me.popMaterialMainSeek, Me.ToolStripSeparator2, Me.popMaterialMainCheck, Me.popMaterialMainPrint, Me.popMaterialMainExport, Me.popMaterialMainNouse})
        Me.popMaterialMain.Name = "popMaterialMain"
        Me.popMaterialMain.Size = New System.Drawing.Size(221, 364)
        '
        'popMaterialMainAdd
        '
        Me.popMaterialMainAdd.Enabled = False
        Me.popMaterialMainAdd.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popMaterialMainAdd.Name = "popMaterialMainAdd"
        Me.popMaterialMainAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popMaterialMainAdd.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainAdd.Text = "新增(&A)..."
        '
        'popMaterialMainEdit
        '
        Me.popMaterialMainEdit.Enabled = False
        Me.popMaterialMainEdit.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popMaterialMainEdit.Name = "popMaterialMainEdit"
        Me.popMaterialMainEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popMaterialMainEdit.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainEdit.Text = "修改(&E)..."
        '
        'popMaterialMainAudit
        '
        Me.popMaterialMainAudit.Enabled = False
        Me.popMaterialMainAudit.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainAudit.Image = Global.LFERP.My.Resources.Resources.SignatureLineInsertMenu
        Me.popMaterialMainAudit.Name = "popMaterialMainAudit"
        Me.popMaterialMainAudit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.popMaterialMainAudit.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainAudit.Text = "審計部修改(&M)..."
        '
        'popMaterialMainDel
        '
        Me.popMaterialMainDel.Enabled = False
        Me.popMaterialMainDel.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popMaterialMainDel.Name = "popMaterialMainDel"
        Me.popMaterialMainDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popMaterialMainDel.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(217, 6)
        '
        'popToolStripPrice
        '
        Me.popToolStripPrice.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popToolStripPrice.Name = "popToolStripPrice"
        Me.popToolStripPrice.Size = New System.Drawing.Size(220, 22)
        Me.popToolStripPrice.Text = "單價錄入&H"
        Me.popToolStripPrice.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'popMaterialMainFile
        '
        Me.popMaterialMainFile.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popMaterialMainFile.Name = "popMaterialMainFile"
        Me.popMaterialMainFile.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainFile.Text = "附加文件(&B)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(217, 6)
        '
        'popMaterialMainPhoto
        '
        Me.popMaterialMainPhoto.Enabled = False
        Me.popMaterialMainPhoto.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainPhoto.Image = Global.LFERP.My.Resources.Resources.ContactSendMenu
        Me.popMaterialMainPhoto.Name = "popMaterialMainPhoto"
        Me.popMaterialMainPhoto.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainPhoto.Text = "變更類別,圖片及子物料(&K)..."
        '
        'popMaterialMainView
        '
        Me.popMaterialMainView.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popMaterialMainView.Name = "popMaterialMainView"
        Me.popMaterialMainView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popMaterialMainView.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainView.Text = "查看(&W)..."
        '
        'popMaterialMainRef
        '
        Me.popMaterialMainRef.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popMaterialMainRef.Name = "popMaterialMainRef"
        Me.popMaterialMainRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popMaterialMainRef.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(217, 6)
        '
        'popMaterialMainSeek
        '
        Me.popMaterialMainSeek.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popMaterialMainSeek.Name = "popMaterialMainSeek"
        Me.popMaterialMainSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popMaterialMainSeek.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(217, 6)
        '
        'popMaterialMainCheck
        '
        Me.popMaterialMainCheck.Enabled = False
        Me.popMaterialMainCheck.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popMaterialMainCheck.Name = "popMaterialMainCheck"
        Me.popMaterialMainCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popMaterialMainCheck.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainCheck.Text = "審核(&G)..."
        '
        'popMaterialMainPrint
        '
        Me.popMaterialMainPrint.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popMaterialMainPrint.Name = "popMaterialMainPrint"
        Me.popMaterialMainPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popMaterialMainPrint.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainPrint.Text = "列印(&P)..."
        '
        'popMaterialMainExport
        '
        Me.popMaterialMainExport.Enabled = False
        Me.popMaterialMainExport.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.popMaterialMainExport.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.popMaterialMainExport.Name = "popMaterialMainExport"
        Me.popMaterialMainExport.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainExport.Text = "導出(&U)..."
        '
        'popMaterialMainNouse
        '
        Me.popMaterialMainNouse.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.popMaterialMainNouse.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.popMaterialMainNouse.Name = "popMaterialMainNouse"
        Me.popMaterialMainNouse.Size = New System.Drawing.Size(220, 22)
        Me.popMaterialMainNouse.Text = "呆滯物料匯總(&L)..."
        '
        'tv1
        '
        Me.tv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.ContextMenuStrip = Me.popMaterialType
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(2, 43)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(187, 457)
        Me.tv1.TabIndex = 24
        '
        'popMaterialType
        '
        Me.popMaterialType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popMaterialTypeRef})
        Me.popMaterialType.Name = "popMaterialType"
        Me.popMaterialType.Size = New System.Drawing.Size(148, 26)
        '
        'popMaterialTypeRef
        '
        Me.popMaterialTypeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popMaterialTypeRef.Name = "popMaterialTypeRef"
        Me.popMaterialTypeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popMaterialTypeRef.Size = New System.Drawing.Size(147, 22)
        Me.popMaterialTypeRef.Text = "刷新(&R)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "物料編碼"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(831, 37)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'tcList
        '
        Me.tcList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcList.Location = New System.Drawing.Point(190, 311)
        Me.tcList.Name = "tcList"
        Me.tcList.SelectedTabPage = Me.tcP1
        Me.tcList.Size = New System.Drawing.Size(633, 22)
        Me.tcList.TabIndex = 30
        Me.tcList.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tcP1, Me.tcP2, Me.tcP3, Me.tcP4, Me.tcP5, Me.tcP7, Me.tcP6, Me.tcP8})
        Me.tcList.Text = "XtraTabControl1"
        '
        'tcP1
        '
        Me.tcP1.Name = "tcP1"
        Me.tcP1.Size = New System.Drawing.Size(624, 0)
        Me.tcP1.Text = "產品資料共用"
        '
        'tcP2
        '
        Me.tcP2.Name = "tcP2"
        Me.tcP2.Size = New System.Drawing.Size(624, 0)
        Me.tcP2.Text = "批次共用"
        '
        'tcP3
        '
        Me.tcP3.Name = "tcP3"
        Me.tcP3.Size = New System.Drawing.Size(624, 0)
        Me.tcP3.Text = "報價單"
        '
        'tcP4
        '
        Me.tcP4.Name = "tcP4"
        Me.tcP4.Size = New System.Drawing.Size(624, 0)
        Me.tcP4.Text = "庫存"
        '
        'tcP5
        '
        Me.tcP5.Name = "tcP5"
        Me.tcP5.Size = New System.Drawing.Size(624, 0)
        Me.tcP5.Text = "採購單"
        '
        'tcP7
        '
        Me.tcP7.Name = "tcP7"
        Me.tcP7.Size = New System.Drawing.Size(624, 0)
        Me.tcP7.Text = "採購單(未交完)"
        '
        'tcP6
        '
        Me.tcP6.Name = "tcP6"
        Me.tcP6.Size = New System.Drawing.Size(624, 0)
        Me.tcP6.Text = "送貨單"
        '
        'tcP8
        '
        Me.tcP8.Name = "tcP8"
        Me.tcP8.Size = New System.Drawing.Size(624, 0)
        Me.tcP8.Text = "物料品質反饋"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popMaterialMain
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(192, 43)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(641, 262)
        Me.Grid1.TabIndex = 167
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Price, Me.M_Currency, Me.M_Unit, Me.M_IsEnabled, Me.M_AccountCheck, Me.M_AddDate, Me.M_EditDate, Me.InUser, Me.U_Name, Me.M_FinalDate})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 130
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 5
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 2
        '
        'M_IsEnabled
        '
        Me.M_IsEnabled.Caption = "啟用"
        Me.M_IsEnabled.FieldName = "M_IsEnabled"
        Me.M_IsEnabled.Name = "M_IsEnabled"
        Me.M_IsEnabled.Visible = True
        Me.M_IsEnabled.VisibleIndex = 6
        '
        'M_AccountCheck
        '
        Me.M_AccountCheck.Caption = "會計部審核"
        Me.M_AccountCheck.FieldName = "M_AccountCheck"
        Me.M_AccountCheck.Name = "M_AccountCheck"
        Me.M_AccountCheck.Visible = True
        Me.M_AccountCheck.VisibleIndex = 7
        '
        'M_AddDate
        '
        Me.M_AddDate.Caption = "建立日期"
        Me.M_AddDate.FieldName = "M_AddDate"
        Me.M_AddDate.Name = "M_AddDate"
        Me.M_AddDate.Visible = True
        Me.M_AddDate.VisibleIndex = 8
        Me.M_AddDate.Width = 125
        '
        'M_EditDate
        '
        Me.M_EditDate.Caption = "修改日期"
        Me.M_EditDate.FieldName = "M_EditDate"
        Me.M_EditDate.Name = "M_EditDate"
        Me.M_EditDate.Visible = True
        Me.M_EditDate.VisibleIndex = 9
        Me.M_EditDate.Width = 125
        '
        'InUser
        '
        Me.InUser.Caption = "操作員ID"
        Me.InUser.FieldName = "InUser"
        Me.InUser.Name = "InUser"
        '
        'U_Name
        '
        Me.U_Name.Caption = "操作員"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 11
        '
        'M_FinalDate
        '
        Me.M_FinalDate.Caption = "最後採購日期"
        Me.M_FinalDate.FieldName = "M_FinalDate"
        Me.M_FinalDate.Name = "M_FinalDate"
        Me.M_FinalDate.Visible = True
        Me.M_FinalDate.VisibleIndex = 10
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "InUser"
        Me.DataGridViewTextBoxColumn7.HeaderText = "操作員"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "M_EditDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "修改日期"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "M_AddDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "建立日期"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "M_AccountCheck"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "會計部審核"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "M_IsEnabled"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "啟用"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "M_Gauge"
        Me.DataGridViewTextBoxColumn4.HeaderText = "規格"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "M_Unit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "單位"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "M_Name"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "名稱"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "M_Code"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "物料編碼"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'GridSub
        '
        Me.GridSub.AllowUserToAddRows = False
        Me.GridSub.AllowUserToResizeRows = False
        Me.GridSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSub.BackgroundColor = System.Drawing.Color.White
        Me.GridSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.GridSub.ContextMenuStrip = Me.cmsQuality
        Me.GridSub.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridSub.EnableHeadersVisualStyles = False
        Me.GridSub.GridColor = System.Drawing.Color.Silver
        Me.GridSub.Location = New System.Drawing.Point(192, 333)
        Me.GridSub.MultiSelect = False
        Me.GridSub.Name = "GridSub"
        Me.GridSub.RowTemplate.Height = 24
        Me.GridSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSub.Size = New System.Drawing.Size(641, 167)
        Me.GridSub.TabIndex = 29
        '
        'cmsQuality
        '
        Me.cmsQuality.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsQualityPreview})
        Me.cmsQuality.Name = "cmsQuality"
        Me.cmsQuality.Size = New System.Drawing.Size(143, 26)
        '
        'cmsQualityPreview
        '
        Me.cmsQualityPreview.Name = "cmsQualityPreview"
        Me.cmsQualityPreview.Size = New System.Drawing.Size(142, 22)
        Me.cmsQualityPreview.Text = "查看詳細信息"
        Me.cmsQualityPreview.Visible = False
        '
        'popReport
        '
        Me.popReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popReportOpen})
        Me.popReport.Name = "popReport"
        Me.popReport.Size = New System.Drawing.Size(118, 26)
        '
        'popReportOpen
        '
        Me.popReportOpen.Image = Global.LFERP.My.Resources.Resources.AdvancedFileProperties
        Me.popReportOpen.Name = "popReportOpen"
        Me.popReportOpen.Size = New System.Drawing.Size(117, 22)
        Me.popReportOpen.Text = "報表(&P)..."
        Me.popReportOpen.Visible = False
        '
        'M_Price
        '
        Me.M_Price.Caption = "單價"
        Me.M_Price.FieldName = "M_Price"
        Me.M_Price.Name = "M_Price"
        Me.M_Price.OptionsColumn.ReadOnly = True
        Me.M_Price.Visible = True
        Me.M_Price.VisibleIndex = 3
        '
        'M_Currency
        '
        Me.M_Currency.Caption = "幣別"
        Me.M_Currency.FieldName = "M_Currency"
        Me.M_Currency.Name = "M_Currency"
        Me.M_Currency.OptionsColumn.ReadOnly = True
        Me.M_Currency.Visible = True
        Me.M_Currency.VisibleIndex = 4
        '
        'frmMaterialMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 503)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tv1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tcList)
        Me.Controls.Add(Me.GridSub)
        Me.Name = "frmMaterialMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "物料編碼"
        Me.popMaterialMain.ResumeLayout(False)
        Me.popMaterialType.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcList.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsQuality.ResumeLayout(False)
        Me.popReport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popMaterialMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popMaterialMainAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popMaterialMainRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popMaterialType As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popMaterialTypeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcList As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tcP1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents popMaterialMainFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popMaterialMainCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_IsEnabled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridSub As System.Windows.Forms.DataGridView
    Friend WithEvents popReport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popReportOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainPhoto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_FinalDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popMaterialMainNouse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMaterialMainAudit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcP7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcP8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmsQuality As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsQualityPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popToolStripPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Currency As DevExpress.XtraGrid.Columns.GridColumn

End Class
