<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPForecastBrowse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPForecastBrowse))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.det_EndDate = New DevExpress.XtraEditors.DateEdit
        Me.MC_Source = New System.Windows.Forms.Label
        Me.gueSource = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SourceID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txt_Type = New DevExpress.XtraEditors.MemoEdit
        Me.stb_Sort = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cms_ToExcelChild = New System.Windows.Forms.ToolStripMenuItem
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.cms_ToExcel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GLU_MCode = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DM_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSelect = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMO_CusterID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.det_StartDate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1.SuspendLayout()
        CType(Me.det_EndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gueSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_ToExcel.SuspendLayout()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_CusterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.det_StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.det_EndDate)
        Me.Panel1.Controls.Add(Me.MC_Source)
        Me.Panel1.Controls.Add(Me.gueSource)
        Me.Panel1.Controls.Add(Me.txt_Type)
        Me.Panel1.Controls.Add(Me.stb_Sort)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.GLU_MCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSelect)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMO_CusterID)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.det_StartDate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdFind)
        Me.Panel1.Controls.Add(Me.Lbl_Title)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 481)
        Me.Panel1.TabIndex = 0
        '
        'det_EndDate
        '
        Me.det_EndDate.EditValue = Nothing
        Me.det_EndDate.Location = New System.Drawing.Point(98, 71)
        Me.det_EndDate.Name = "det_EndDate"
        Me.det_EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.det_EndDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.det_EndDate.Properties.Appearance.Options.UseFont = True
        Me.det_EndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.det_EndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.det_EndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.det_EndDate.Size = New System.Drawing.Size(113, 24)
        Me.det_EndDate.TabIndex = 3
        '
        'MC_Source
        '
        Me.MC_Source.AutoSize = True
        Me.MC_Source.BackColor = System.Drawing.Color.Transparent
        Me.MC_Source.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MC_Source.ForeColor = System.Drawing.Color.Black
        Me.MC_Source.Location = New System.Drawing.Point(445, 76)
        Me.MC_Source.Name = "MC_Source"
        Me.MC_Source.Size = New System.Drawing.Size(92, 15)
        Me.MC_Source.TabIndex = 257
        Me.MC_Source.Text = "來  源  碼(&X):"
        '
        'gueSource
        '
        Me.gueSource.Location = New System.Drawing.Point(541, 71)
        Me.gueSource.Name = "gueSource"
        Me.gueSource.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.gueSource.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gueSource.Properties.Appearance.Options.UseBackColor = True
        Me.gueSource.Properties.Appearance.Options.UseFont = True
        Me.gueSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueSource.Properties.DisplayMember = "SO_CusterID"
        Me.gueSource.Properties.NullText = ""
        Me.gueSource.Properties.View = Me.GridView1
        Me.gueSource.Size = New System.Drawing.Size(142, 24)
        Me.gueSource.TabIndex = 10
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SourceID, Me.Source})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SourceID
        '
        Me.SourceID.Caption = "來源編碼"
        Me.SourceID.FieldName = "MC_SourceID"
        Me.SourceID.Name = "SourceID"
        Me.SourceID.Visible = True
        Me.SourceID.VisibleIndex = 0
        '
        'Source
        '
        Me.Source.Caption = "來源名稱"
        Me.Source.FieldName = "MC_Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 1
        '
        'txt_Type
        '
        Me.txt_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Type.Enabled = False
        Me.txt_Type.Location = New System.Drawing.Point(894, 42)
        Me.txt_Type.Name = "txt_Type"
        Me.txt_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_Type.Properties.Appearance.Options.UseFont = True
        Me.txt_Type.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Type.Size = New System.Drawing.Size(125, 56)
        Me.txt_Type.TabIndex = 214
        Me.txt_Type.Visible = False
        '
        'stb_Sort
        '
        Me.stb_Sort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stb_Sort.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.stb_Sort.Appearance.Options.UseFont = True
        Me.stb_Sort.Image = CType(resources.GetObject("stb_Sort.Image"), System.Drawing.Image)
        Me.stb_Sort.Location = New System.Drawing.Point(860, 42)
        Me.stb_Sort.Name = "stb_Sort"
        Me.stb_Sort.Size = New System.Drawing.Size(28, 24)
        Me.stb_Sort.TabIndex = 212
        Me.stb_Sort.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 104)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1043, 377)
        Me.SplitContainer1.SplitterDistance = 188
        Me.SplitContainer1.TabIndex = 211
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsMenuStrip
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1043, 188)
        Me.GridControl1.TabIndex = 211
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cms_ToExcelChild})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(204, 26)
        Me.cmsMenuStrip.UseWaitCursor = True
        '
        'cms_ToExcelChild
        '
        Me.cms_ToExcelChild.Image = CType(resources.GetObject("cms_ToExcelChild.Image"), System.Drawing.Image)
        Me.cms_ToExcelChild.Name = "cms_ToExcelChild"
        Me.cms_ToExcelChild.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cms_ToExcelChild.Size = New System.Drawing.Size(203, 22)
        Me.cms_ToExcelChild.Text = "導出Excle（&E）"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
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
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.ContextMenuStrip = Me.cms_ToExcel
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.BandedGridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4})
        Me.GridControl2.Size = New System.Drawing.Size(1043, 185)
        Me.GridControl2.TabIndex = 210
        Me.GridControl2.TabStop = False
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView2})
        '
        'cms_ToExcel
        '
        Me.cms_ToExcel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cms_ToExcel.Name = "cmsMenuStrip"
        Me.cms_ToExcel.Size = New System.Drawing.Size(204, 26)
        Me.cms_ToExcel.UseWaitCursor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem1.Text = "導出Excle（&E）"
        '
        'BandedGridView2
        '
        Me.BandedGridView2.GridControl = Me.GridControl2
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'GLU_MCode
        '
        Me.GLU_MCode.EditValue = "*全部*"
        Me.GLU_MCode.Location = New System.Drawing.Point(541, 41)
        Me.GLU_MCode.Name = "GLU_MCode"
        Me.GLU_MCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GLU_MCode.Properties.Appearance.Options.UseFont = True
        Me.GLU_MCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_MCode.Properties.DisplayMember = "SO_CusterID"
        Me.GLU_MCode.Properties.NullText = ""
        Me.GLU_MCode.Properties.PopupFormWidth = 500
        Me.GLU_MCode.Properties.View = Me.GridView4
        Me.GLU_MCode.Size = New System.Drawing.Size(142, 24)
        Me.GLU_MCode.TabIndex = 9
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DM_Code, Me.DM_Name, Me.DM_Gauge, Me.DM_Unit, Me.DM_Source})
        Me.GridView4.DetailHeight = 540
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'DM_Code
        '
        Me.DM_Code.Caption = "產品編號"
        Me.DM_Code.FieldName = "ParentGroup"
        Me.DM_Code.Name = "DM_Code"
        Me.DM_Code.OptionsColumn.AllowEdit = False
        Me.DM_Code.OptionsColumn.ReadOnly = True
        Me.DM_Code.Visible = True
        Me.DM_Code.VisibleIndex = 0
        Me.DM_Code.Width = 116
        '
        'DM_Name
        '
        Me.DM_Name.Caption = "產品名稱"
        Me.DM_Name.FieldName = "M_Name"
        Me.DM_Name.Name = "DM_Name"
        Me.DM_Name.OptionsColumn.AllowEdit = False
        Me.DM_Name.OptionsColumn.ReadOnly = True
        Me.DM_Name.Visible = True
        Me.DM_Name.VisibleIndex = 1
        Me.DM_Name.Width = 93
        '
        'DM_Gauge
        '
        Me.DM_Gauge.Caption = "規格"
        Me.DM_Gauge.FieldName = "M_Gauge"
        Me.DM_Gauge.Name = "DM_Gauge"
        Me.DM_Gauge.OptionsColumn.ReadOnly = True
        Me.DM_Gauge.Visible = True
        Me.DM_Gauge.VisibleIndex = 2
        Me.DM_Gauge.Width = 50
        '
        'DM_Unit
        '
        Me.DM_Unit.Caption = "單位"
        Me.DM_Unit.FieldName = "M_Unit"
        Me.DM_Unit.Name = "DM_Unit"
        Me.DM_Unit.OptionsColumn.AllowEdit = False
        Me.DM_Unit.OptionsColumn.ReadOnly = True
        Me.DM_Unit.Visible = True
        Me.DM_Unit.VisibleIndex = 3
        Me.DM_Unit.Width = 50
        '
        'DM_Source
        '
        Me.DM_Source.Caption = "來源碼"
        Me.DM_Source.FieldName = "M_Source"
        Me.DM_Source.Name = "DM_Source"
        Me.DM_Source.OptionsColumn.AllowEdit = False
        Me.DM_Source.OptionsColumn.ReadOnly = True
        Me.DM_Source.Visible = True
        Me.DM_Source.VisibleIndex = 4
        Me.DM_Source.Width = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(445, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "產品編號(&P)："
        '
        'txtSelect
        '
        Me.txtSelect.EditValue = "[A]:周數"
        Me.txtSelect.Location = New System.Drawing.Point(309, 41)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelect.Properties.Appearance.Options.UseFont = True
        Me.txtSelect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSelect.Properties.Items.AddRange(New Object() {"[A]:周數", "[B]:月份", "[C]:周數【客戶】", "[D]:月份【客戶】"})
        Me.txtSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtSelect.Size = New System.Drawing.Size(131, 24)
        Me.txtSelect.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(215, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "查詢類型(&R)："
        '
        'txtMO_CusterID
        '
        Me.txtMO_CusterID.EditValue = "*全部*"
        Me.txtMO_CusterID.Location = New System.Drawing.Point(309, 71)
        Me.txtMO_CusterID.Name = "txtMO_CusterID"
        Me.txtMO_CusterID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMO_CusterID.Properties.Appearance.Options.UseFont = True
        Me.txtMO_CusterID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMO_CusterID.Properties.DisplayMember = "SO_CusterID"
        Me.txtMO_CusterID.Properties.NullText = ""
        Me.txtMO_CusterID.Properties.View = Me.GridView2
        Me.txtMO_CusterID.Size = New System.Drawing.Size(131, 24)
        Me.txtMO_CusterID.TabIndex = 7
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MO_CusterID, Me.MO_CusterName})
        Me.GridView2.DetailHeight = 360
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'MO_CusterID
        '
        Me.MO_CusterID.Caption = "客戶編號"
        Me.MO_CusterID.FieldName = "MO_CusterID"
        Me.MO_CusterID.Name = "MO_CusterID"
        Me.MO_CusterID.Visible = True
        Me.MO_CusterID.VisibleIndex = 1
        '
        'MO_CusterName
        '
        Me.MO_CusterName.Caption = "客戶名稱"
        Me.MO_CusterName.FieldName = "MO_CusterName"
        Me.MO_CusterName.Name = "MO_CusterName"
        Me.MO_CusterName.Visible = True
        Me.MO_CusterName.VisibleIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(692, 71)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 24)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Excel(&S)"
        '
        'det_StartDate
        '
        Me.det_StartDate.EditValue = Nothing
        Me.det_StartDate.Location = New System.Drawing.Point(98, 41)
        Me.det_StartDate.Name = "det_StartDate"
        Me.det_StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.det_StartDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.det_StartDate.Properties.Appearance.Options.UseFont = True
        Me.det_StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.det_StartDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.det_StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.det_StartDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.det_StartDate.Size = New System.Drawing.Size(113, 24)
        Me.det_StartDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(215, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "客戶編號(&C)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "截止日期(&E)："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "起始日期(&B)："
        '
        'cmdFind
        '
        Me.cmdFind.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdFind.Appearance.Options.UseFont = True
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.Location = New System.Drawing.Point(692, 41)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(82, 24)
        Me.cmdFind.TabIndex = 11
        Me.cmdFind.Text = "查詢(&O)"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(3, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(175, 21)
        Me.Lbl_Title.TabIndex = 204
        Me.Lbl_Title.Text = "MRP預測訂單瀏覽"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1043, 32)
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "9月4日到9月11日"
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 10
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "9月12日到9月19日"
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 10
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "客戶名稱"
        Me.GridColumn1.FieldName = "MO_CusterName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'frmMRPForecastBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 481)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMRPForecastBrowse"
        Me.Text = "MRP預測訂單瀏覽"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.det_EndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gueSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_ToExcel.ResumeLayout(False)
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_CusterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.det_StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cms_ToExcelChild As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents det_EndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents det_StartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMO_CusterID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_CusterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSelect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GLU_MCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents stb_Sort As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Type As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cms_ToExcel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gueSource As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SourceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Source As System.Windows.Forms.Label
End Class
