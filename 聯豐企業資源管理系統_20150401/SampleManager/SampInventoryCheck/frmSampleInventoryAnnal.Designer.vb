<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleInventoryAnnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleInventoryAnnal))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dateStratDate = New DevExpress.XtraEditors.DateEdit
        Me.dateEndDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdExcel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colcPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcM_Code_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.gluD_ID = New DevExpress.XtraEditors.PopupContainerEdit
        Me.ppcD_ID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkD_ID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.chkD_IDAll = New DevExpress.XtraEditors.CheckEdit
        Me.lblD_ID = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsExcel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdExcelSub = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colaPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaProphaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaInQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaInReworkQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaOutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaOutReworkQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaDamageQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaBorrowQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaAlsoQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaReturnQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCompletionQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaInDivertQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaOutDivertQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaBackQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCurrentQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colbD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbBorrowQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbAlsoQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbNoAlsoQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppcD_ID.SuspendLayout()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsExcel.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "每日记录表"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.dateStratDate)
        Me.Panel1.Controls.Add(Me.dateEndDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdExcel)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.gluPM_M_Code)
        Me.Panel1.Controls.Add(Me.lblPM_M_Code)
        Me.Panel1.Controls.Add(Me.gluD_ID)
        Me.Panel1.Controls.Add(Me.lblD_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 74)
        Me.Panel1.TabIndex = 87
        '
        'dateStratDate
        '
        Me.dateStratDate.EditValue = Nothing
        Me.dateStratDate.Location = New System.Drawing.Point(446, 8)
        Me.dateStratDate.Name = "dateStratDate"
        Me.dateStratDate.Properties.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateStratDate.Properties.Appearance.Options.UseFont = True
        Me.dateStratDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateStratDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateStratDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateStratDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateStratDate.Size = New System.Drawing.Size(118, 24)
        Me.dateStratDate.TabIndex = 8
        '
        'dateEndDate
        '
        Me.dateEndDate.EditValue = Nothing
        Me.dateEndDate.Location = New System.Drawing.Point(446, 41)
        Me.dateEndDate.Name = "dateEndDate"
        Me.dateEndDate.Properties.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateEndDate.Properties.Appearance.Options.UseFont = True
        Me.dateEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEndDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateEndDate.Size = New System.Drawing.Size(118, 24)
        Me.dateEndDate.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "截止日期(&S):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "起始日期(&S):"
        '
        'cmdExcel
        '
        Me.cmdExcel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExcel.Appearance.Options.UseFont = True
        Me.cmdExcel.Image = CType(resources.GetObject("cmdExcel.Image"), System.Drawing.Image)
        Me.cmdExcel.Location = New System.Drawing.Point(570, 8)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(78, 24)
        Me.cmdExcel.TabIndex = 7
        Me.cmdExcel.Text = "Excel(&E)"
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSearch.Location = New System.Drawing.Point(570, 41)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(78, 24)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "查询(&Q)"
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(100, 41)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 480
        Me.gluPM_M_Code.Properties.ValueMember = "SO_ID"
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(247, 24)
        Me.gluPM_M_Code.TabIndex = 3
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcPM_M_Code, Me.colcSO_SampleID, Me.colcM_Code_Type, Me.colcSO_ID})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colcPM_M_Code
        '
        Me.colcPM_M_Code.Caption = "产品编号"
        Me.colcPM_M_Code.FieldName = "PM_M_Code"
        Me.colcPM_M_Code.Name = "colcPM_M_Code"
        Me.colcPM_M_Code.Visible = True
        Me.colcPM_M_Code.VisibleIndex = 0
        '
        'colcSO_SampleID
        '
        Me.colcSO_SampleID.Caption = "样办单号"
        Me.colcSO_SampleID.FieldName = "SO_SampleID"
        Me.colcSO_SampleID.Name = "colcSO_SampleID"
        Me.colcSO_SampleID.Visible = True
        Me.colcSO_SampleID.VisibleIndex = 1
        '
        'colcSO_ID
        '
        Me.colcSO_ID.Caption = "订单编号"
        Me.colcSO_ID.FieldName = "SO_ID"
        Me.colcSO_ID.Name = "colcSO_ID"
        Me.colcSO_ID.Visible = True
        Me.colcSO_ID.VisibleIndex = 3
        '
        'colcM_Code_Type
        '
        Me.colcM_Code_Type.Caption = "产品类别"
        Me.colcM_Code_Type.FieldName = "M_Code_Type"
        Me.colcM_Code_Type.Name = "colcM_Code_Type"
        Me.colcM_Code_Type.Visible = True
        Me.colcM_Code_Type.VisibleIndex = 2
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.Location = New System.Drawing.Point(7, 45)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(96, 16)
        Me.lblPM_M_Code.TabIndex = 2
        Me.lblPM_M_Code.Text = "产品编号(&C):"
        '
        'gluD_ID
        '
        Me.gluD_ID.Location = New System.Drawing.Point(100, 8)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluD_ID.Properties.PopupControl = Me.ppcD_ID
        Me.gluD_ID.Size = New System.Drawing.Size(247, 24)
        Me.gluD_ID.TabIndex = 1
        '
        'ppcD_ID
        '
        Me.ppcD_ID.Controls.Add(Me.chkD_ID)
        Me.ppcD_ID.Controls.Add(Me.chkD_IDAll)
        Me.ppcD_ID.Location = New System.Drawing.Point(296, 171)
        Me.ppcD_ID.Name = "ppcD_ID"
        Me.ppcD_ID.Size = New System.Drawing.Size(200, 218)
        Me.ppcD_ID.TabIndex = 246
        Me.ppcD_ID.Text = "PopupContainerControl4"
        '
        'chkD_ID
        '
        Me.chkD_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkD_ID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkD_ID.CheckOnClick = True
        Me.chkD_ID.DisplayMember = "DepName"
        Me.chkD_ID.HotTrackItems = True
        Me.chkD_ID.Location = New System.Drawing.Point(0, 25)
        Me.chkD_ID.Name = "chkD_ID"
        Me.chkD_ID.Size = New System.Drawing.Size(200, 191)
        Me.chkD_ID.TabIndex = 0
        Me.chkD_ID.ValueMember = "DepID"
        '
        'chkD_IDAll
        '
        Me.chkD_IDAll.Location = New System.Drawing.Point(2, 2)
        Me.chkD_IDAll.Name = "chkD_IDAll"
        Me.chkD_IDAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.chkD_IDAll.Properties.Appearance.Options.UseFont = True
        Me.chkD_IDAll.Properties.Caption = "全选<部门>"
        Me.chkD_IDAll.Size = New System.Drawing.Size(106, 23)
        Me.chkD_IDAll.TabIndex = 29
        '
        'lblD_ID
        '
        Me.lblD_ID.AutoSize = True
        Me.lblD_ID.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblD_ID.Location = New System.Drawing.Point(6, 12)
        Me.lblD_ID.Name = "lblD_ID"
        Me.lblD_ID.Size = New System.Drawing.Size(97, 16)
        Me.lblD_ID.TabIndex = 0
        Me.lblD_ID.Text = "部        门(&D):"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 106)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(856, 577)
        Me.XtraTabControl1.TabIndex = 95
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage1})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ppcD_ID)
        Me.XtraTabPage3.Controls.Add(Me.Grid1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(847, 545)
        Me.XtraTabPage3.Text = "每日记录表"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsExcel
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemButtonEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(847, 545)
        Me.Grid1.TabIndex = 226
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsExcel
        '
        Me.cmsExcel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExcelSub, Me.cmdPrint})
        Me.cmsExcel.Name = "cmsRepaySub"
        Me.cmsExcel.Size = New System.Drawing.Size(192, 48)
        '
        'cmdExcelSub
        '
        Me.cmdExcelSub.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExcelSub.Name = "cmdExcelSub"
        Me.cmdExcelSub.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdExcelSub.Size = New System.Drawing.Size(191, 22)
        Me.cmdExcelSub.Text = "汇出Excel(&G)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(191, 22)
        Me.cmdPrint.Text = "列印Print(&P)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colaPM_M_Code, Me.colaD_Dep, Me.colaPS_Name, Me.colaProphaseQty, Me.colaInQty, Me.colaInReworkQty, Me.colaOutQty, Me.colaOutReworkQty, Me.colaDamageQty, Me.colaBorrowQty, Me.colaAlsoQty, Me.colaReturnQty, Me.colaCompletionQty, Me.colaInDivertQty, Me.colaOutDivertQty, Me.colaBackQty, Me.colaCurrentQty, Me.colaRemark})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colaPM_M_Code
        '
        Me.colaPM_M_Code.Caption = "产品编号"
        Me.colaPM_M_Code.FieldName = "PM_M_Code"
        Me.colaPM_M_Code.Name = "colaPM_M_Code"
        Me.colaPM_M_Code.Visible = True
        Me.colaPM_M_Code.VisibleIndex = 0
        '
        'colaD_Dep
        '
        Me.colaD_Dep.Caption = "部门"
        Me.colaD_Dep.FieldName = "D_Dep"
        Me.colaD_Dep.Name = "colaD_Dep"
        Me.colaD_Dep.OptionsColumn.ReadOnly = True
        Me.colaD_Dep.Visible = True
        Me.colaD_Dep.VisibleIndex = 1
        Me.colaD_Dep.Width = 90
        '
        'colaPS_Name
        '
        Me.colaPS_Name.Caption = "工序"
        Me.colaPS_Name.FieldName = "PS_Name"
        Me.colaPS_Name.Name = "colaPS_Name"
        Me.colaPS_Name.OptionsColumn.ReadOnly = True
        Me.colaPS_Name.SummaryItem.DisplayFormat = "合计:"
        Me.colaPS_Name.SummaryItem.FieldName = "PutInTotalQty"
        Me.colaPS_Name.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colaPS_Name.Visible = True
        Me.colaPS_Name.VisibleIndex = 2
        Me.colaPS_Name.Width = 86
        '
        'colaProphaseQty
        '
        Me.colaProphaseQty.Caption = "前日余留"
        Me.colaProphaseQty.FieldName = "ProphaseQty"
        Me.colaProphaseQty.Name = "colaProphaseQty"
        Me.colaProphaseQty.OptionsColumn.ReadOnly = True
        Me.colaProphaseQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaProphaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaProphaseQty.Visible = True
        Me.colaProphaseQty.VisibleIndex = 3
        Me.colaProphaseQty.Width = 70
        '
        'colaInQty
        '
        Me.colaInQty.Caption = "收入数量"
        Me.colaInQty.FieldName = "InQty"
        Me.colaInQty.Name = "colaInQty"
        Me.colaInQty.OptionsColumn.ReadOnly = True
        Me.colaInQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaInQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaInQty.Visible = True
        Me.colaInQty.VisibleIndex = 4
        Me.colaInQty.Width = 70
        '
        'colaInReworkQty
        '
        Me.colaInReworkQty.Caption = "收入返修"
        Me.colaInReworkQty.FieldName = "InReworkQty"
        Me.colaInReworkQty.Name = "colaInReworkQty"
        Me.colaInReworkQty.OptionsColumn.ReadOnly = True
        Me.colaInReworkQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaInReworkQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaInReworkQty.Visible = True
        Me.colaInReworkQty.VisibleIndex = 5
        Me.colaInReworkQty.Width = 70
        '
        'colaOutQty
        '
        Me.colaOutQty.Caption = "发出良品"
        Me.colaOutQty.FieldName = "OutQty"
        Me.colaOutQty.Name = "colaOutQty"
        Me.colaOutQty.OptionsColumn.ReadOnly = True
        Me.colaOutQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaOutQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaOutQty.Visible = True
        Me.colaOutQty.VisibleIndex = 6
        Me.colaOutQty.Width = 70
        '
        'colaOutReworkQty
        '
        Me.colaOutReworkQty.Caption = "发出返修"
        Me.colaOutReworkQty.FieldName = "OutReworkQty"
        Me.colaOutReworkQty.Name = "colaOutReworkQty"
        Me.colaOutReworkQty.OptionsColumn.ReadOnly = True
        Me.colaOutReworkQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaOutReworkQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaOutReworkQty.Visible = True
        Me.colaOutReworkQty.VisibleIndex = 7
        Me.colaOutReworkQty.Width = 70
        '
        'colaDamageQty
        '
        Me.colaDamageQty.Caption = "损坏"
        Me.colaDamageQty.FieldName = "DamageQty"
        Me.colaDamageQty.Name = "colaDamageQty"
        Me.colaDamageQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaDamageQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaDamageQty.Visible = True
        Me.colaDamageQty.VisibleIndex = 8
        Me.colaDamageQty.Width = 63
        '
        'colaBorrowQty
        '
        Me.colaBorrowQty.Caption = "借出数量"
        Me.colaBorrowQty.FieldName = "BorrowQty"
        Me.colaBorrowQty.Name = "colaBorrowQty"
        Me.colaBorrowQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaBorrowQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaBorrowQty.Visible = True
        Me.colaBorrowQty.VisibleIndex = 9
        Me.colaBorrowQty.Width = 70
        '
        'colaAlsoQty
        '
        Me.colaAlsoQty.Caption = "还入数量"
        Me.colaAlsoQty.FieldName = "AlsoQty"
        Me.colaAlsoQty.Name = "colaAlsoQty"
        Me.colaAlsoQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaAlsoQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaAlsoQty.Visible = True
        Me.colaAlsoQty.VisibleIndex = 10
        Me.colaAlsoQty.Width = 70
        '
        'colaReturnQty
        '
        Me.colaReturnQty.Caption = "退料数量"
        Me.colaReturnQty.FieldName = "ReturnQty"
        Me.colaReturnQty.Name = "colaReturnQty"
        Me.colaReturnQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaReturnQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaReturnQty.Visible = True
        Me.colaReturnQty.VisibleIndex = 11
        Me.colaReturnQty.Width = 70
        '
        'colaCompletionQty
        '
        Me.colaCompletionQty.Caption = "完工数量"
        Me.colaCompletionQty.FieldName = "CompletionQty"
        Me.colaCompletionQty.Name = "colaCompletionQty"
        Me.colaCompletionQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaCompletionQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaCompletionQty.Visible = True
        Me.colaCompletionQty.VisibleIndex = 12
        Me.colaCompletionQty.Width = 70
        '
        'colaInDivertQty
        '
        Me.colaInDivertQty.Caption = "转入数量"
        Me.colaInDivertQty.FieldName = "InDivertQty"
        Me.colaInDivertQty.Name = "colaInDivertQty"
        Me.colaInDivertQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaInDivertQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaInDivertQty.Visible = True
        Me.colaInDivertQty.VisibleIndex = 13
        Me.colaInDivertQty.Width = 70
        '
        'colaOutDivertQty
        '
        Me.colaOutDivertQty.Caption = "转出数量"
        Me.colaOutDivertQty.FieldName = "OutDivertQty"
        Me.colaOutDivertQty.Name = "colaOutDivertQty"
        Me.colaOutDivertQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaOutDivertQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaOutDivertQty.Visible = True
        Me.colaOutDivertQty.VisibleIndex = 14
        Me.colaOutDivertQty.Width = 70
        '
        'colaBackQty
        '
        Me.colaBackQty.Caption = "退回数量"
        Me.colaBackQty.FieldName = "BackQty"
        Me.colaBackQty.Name = "colaBackQty"
        Me.colaBackQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaBackQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaBackQty.Visible = True
        Me.colaBackQty.VisibleIndex = 15
        Me.colaBackQty.Width = 70
        '
        'colaCurrentQty
        '
        Me.colaCurrentQty.Caption = "结余数量"
        Me.colaCurrentQty.FieldName = "CurrentQty"
        Me.colaCurrentQty.Name = "colaCurrentQty"
        Me.colaCurrentQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaCurrentQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaCurrentQty.Visible = True
        Me.colaCurrentQty.VisibleIndex = 16
        Me.colaCurrentQty.Width = 70
        '
        'colaRemark
        '
        Me.colaRemark.Caption = "备注"
        Me.colaRemark.FieldName = "Remark"
        Me.colaRemark.Name = "colaRemark"
        Me.colaRemark.Visible = True
        Me.colaRemark.VisibleIndex = 17
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
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
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(847, 545)
        Me.XtraTabPage1.Text = "部门借还信息"
        '
        'Grid2
        '
        Me.Grid2.ContextMenuStrip = Me.cmsExcel
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView3
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit2})
        Me.Grid2.Size = New System.Drawing.Size(847, 545)
        Me.Grid2.TabIndex = 227
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbD_ID, Me.colbD_Dep, Me.colbPM_M_Code, Me.colbPS_NO, Me.colbPS_Name, Me.colbBorrowQty, Me.colbAlsoQty, Me.colbNoAlsoQty, Me.colbRemarks})
        Me.GridView3.GridControl = Me.Grid2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colbD_ID
        '
        Me.colbD_ID.Caption = "部门编号"
        Me.colbD_ID.FieldName = "D_ID"
        Me.colbD_ID.Name = "colbD_ID"
        Me.colbD_ID.Width = 86
        '
        'colbD_Dep
        '
        Me.colbD_Dep.Caption = "部门"
        Me.colbD_Dep.FieldName = "D_Dep"
        Me.colbD_Dep.Name = "colbD_Dep"
        Me.colbD_Dep.Visible = True
        Me.colbD_Dep.VisibleIndex = 0
        Me.colbD_Dep.Width = 73
        '
        'colbPM_M_Code
        '
        Me.colbPM_M_Code.Caption = "产品编号"
        Me.colbPM_M_Code.FieldName = "PM_M_Code"
        Me.colbPM_M_Code.Name = "colbPM_M_Code"
        Me.colbPM_M_Code.Visible = True
        Me.colbPM_M_Code.VisibleIndex = 1
        Me.colbPM_M_Code.Width = 90
        '
        'colbPS_NO
        '
        Me.colbPS_NO.Caption = "工序编号"
        Me.colbPS_NO.FieldName = "PS_NO"
        Me.colbPS_NO.Name = "colbPS_NO"
        '
        'colbPS_Name
        '
        Me.colbPS_Name.Caption = "工序"
        Me.colbPS_Name.FieldName = "PS_Name"
        Me.colbPS_Name.Name = "colbPS_Name"
        Me.colbPS_Name.SummaryItem.DisplayFormat = "合计："
        Me.colbPS_Name.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colbPS_Name.Visible = True
        Me.colbPS_Name.VisibleIndex = 2
        Me.colbPS_Name.Width = 134
        '
        'colbBorrowQty
        '
        Me.colbBorrowQty.Caption = "借出数量"
        Me.colbBorrowQty.FieldName = "BorrowQty"
        Me.colbBorrowQty.Name = "colbBorrowQty"
        Me.colbBorrowQty.SummaryItem.DisplayFormat = "{0}"
        Me.colbBorrowQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colbBorrowQty.Visible = True
        Me.colbBorrowQty.VisibleIndex = 3
        Me.colbBorrowQty.Width = 88
        '
        'colbAlsoQty
        '
        Me.colbAlsoQty.Caption = "还入数量"
        Me.colbAlsoQty.FieldName = "AlsoQty"
        Me.colbAlsoQty.Name = "colbAlsoQty"
        Me.colbAlsoQty.SummaryItem.DisplayFormat = "{0}"
        Me.colbAlsoQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colbAlsoQty.Visible = True
        Me.colbAlsoQty.VisibleIndex = 4
        Me.colbAlsoQty.Width = 88
        '
        'colbNoAlsoQty
        '
        Me.colbNoAlsoQty.Caption = "未还数量"
        Me.colbNoAlsoQty.FieldName = "NoAlsoQty"
        Me.colbNoAlsoQty.Name = "colbNoAlsoQty"
        Me.colbNoAlsoQty.SummaryItem.DisplayFormat = "{0}"
        Me.colbNoAlsoQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colbNoAlsoQty.Visible = True
        Me.colbNoAlsoQty.VisibleIndex = 5
        Me.colbNoAlsoQty.Width = 85
        '
        'colbRemarks
        '
        Me.colbRemarks.Caption = "备注"
        Me.colbRemarks.FieldName = "Remarks"
        Me.colbRemarks.Name = "colbRemarks"
        Me.colbRemarks.Visible = True
        Me.colbRemarks.VisibleIndex = 6
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
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'frmSampleInventoryAnnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 683)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSampleInventoryAnnal"
        Me.Text = "每日记录表"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppcD_ID.ResumeLayout(False)
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsExcel.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents lblD_ID As System.Windows.Forms.Label
    Friend WithEvents cmdExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colaD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaProphaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaInQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaInReworkQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaOutReworkQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsExcel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdExcelSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colcM_Code_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ppcD_ID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkD_ID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkD_IDAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colaDamageQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCurrentQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colbD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbBorrowQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbAlsoQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbNoAlsoQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateStratDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dateEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colaBorrowQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaAlsoQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaReturnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCompletionQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaInDivertQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaOutDivertQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaBackQty As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colaOutQty As DevExpress.XtraGrid.Columns.GridColumn
End Class
