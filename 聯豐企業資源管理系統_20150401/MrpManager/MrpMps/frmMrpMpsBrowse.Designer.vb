<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpMpsBrowse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpMpsBrowse))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cboGroupType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.dteBeginDate = New DevExpress.XtraEditors.DateEdit
        Me.dteEndDate = New DevExpress.XtraEditors.DateEdit
        Me.btnSelect = New DevExpress.XtraEditors.SimpleButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DM_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.BandedView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cboGroupType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteBeginDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(1, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 21)
        Me.lblTitle.TabIndex = 198
        Me.lblTitle.Text = "主生產計劃"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(841, 32)
        Me.PictureBox1.TabIndex = 199
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.cboGroupType)
        Me.Panel2.Controls.Add(Me.dteBeginDate)
        Me.Panel2.Controls.Add(Me.dteEndDate)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnExcel)
        Me.Panel2.Controls.Add(Me.gluM_Code)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 68)
        Me.Panel2.TabIndex = 213
        '
        'cboGroupType
        '
        Me.cboGroupType.EditValue = "周數"
        Me.cboGroupType.Location = New System.Drawing.Point(314, 7)
        Me.cboGroupType.Name = "cboGroupType"
        Me.cboGroupType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroupType.Properties.Appearance.Options.UseFont = True
        Me.cboGroupType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGroupType.Properties.Items.AddRange(New Object() {"周數", "月份", "周數【客戶】", "月份【客戶】"})
        Me.cboGroupType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGroupType.Size = New System.Drawing.Size(150, 24)
        Me.cboGroupType.TabIndex = 5
        '
        'dteBeginDate
        '
        Me.dteBeginDate.EditValue = Nothing
        Me.dteBeginDate.Location = New System.Drawing.Point(101, 7)
        Me.dteBeginDate.Name = "dteBeginDate"
        Me.dteBeginDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteBeginDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dteBeginDate.Properties.Appearance.Options.UseFont = True
        Me.dteBeginDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteBeginDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dteBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteBeginDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dteBeginDate.Size = New System.Drawing.Size(113, 24)
        Me.dteBeginDate.TabIndex = 1
        '
        'dteEndDate
        '
        Me.dteEndDate.EditValue = Nothing
        Me.dteEndDate.Location = New System.Drawing.Point(101, 37)
        Me.dteEndDate.Name = "dteEndDate"
        Me.dteEndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteEndDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dteEndDate.Properties.Appearance.Options.UseFont = True
        Me.dteEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteEndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dteEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteEndDate.Size = New System.Drawing.Size(113, 24)
        Me.dteEndDate.TabIndex = 3
        '
        'btnSelect
        '
        Me.btnSelect.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSelect.Appearance.Options.UseFont = True
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(479, 7)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(82, 24)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "查詢(&S)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "起始日期(&B)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "截止日期(&D)："
        '
        'btnExcel
        '
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(479, 37)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(82, 24)
        Me.btnExcel.TabIndex = 12
        Me.btnExcel.Text = "Excel(&E)"
        '
        'gluM_Code
        '
        Me.gluM_Code.EditValue = "ALL"
        Me.gluM_Code.Location = New System.Drawing.Point(314, 37)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.DisplayMember = "ParentGroup"
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.PopupFormWidth = 500
        Me.gluM_Code.Properties.ValueMember = "ParentGroup"
        Me.gluM_Code.Properties.View = Me.GridView4
        Me.gluM_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluM_Code.TabIndex = 9
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(218, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "查詢類型(&R)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(218, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "產品編號(&P)："
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 105)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(841, 408)
        Me.SplitContainer1.SplitterDistance = 202
        Me.SplitContainer1.TabIndex = 214
        '
        'Grid1
        '
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.BandedView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.Grid1.Size = New System.Drawing.Size(841, 408)
        Me.Grid1.TabIndex = 211
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedView1})
        '
        'BandedView1
        '
        Me.BandedView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3})
        Me.BandedView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6})
        Me.BandedView1.GridControl = Me.Grid1
        Me.BandedView1.Name = "BandedView1"
        Me.BandedView1.OptionsPrint.AutoWidth = False
        Me.BandedView1.OptionsView.ColumnAutoWidth = False
        Me.BandedView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "產品信息"
        Me.GridBand1.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn5)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 375
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "產品名稱"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.Visible = True
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "產品規格"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.Visible = True
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "產品編碼"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.Visible = True
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "單位"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.Visible = True
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.Caption = "來源碼"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "總計"
        Me.GridBand3.Columns.Add(Me.BandedGridColumn6)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 75
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "數量"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.Visible = True
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
        'frmMrpMpsBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 516)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpMpsBrowse"
        Me.Text = "主生產計劃瀏覽"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cboGroupType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteBeginDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboGroupType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dteBeginDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSelect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
