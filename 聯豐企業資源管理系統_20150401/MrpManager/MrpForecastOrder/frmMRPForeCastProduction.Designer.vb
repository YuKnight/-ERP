<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPForeCastProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPForeCastProduction))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.det_EndDate = New DevExpress.XtraEditors.DateEdit
        Me.det_StartDate = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.det_EndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.det_StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(882, 32)
        Me.PictureBox1.TabIndex = 203
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(6, 7)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(219, 21)
        Me.Lbl_Title.TabIndex = 205
        Me.Lbl_Title.Text = "MRP預測生產計劃瀏覽"
        '
        'det_EndDate
        '
        Me.det_EndDate.EditValue = Nothing
        Me.det_EndDate.Location = New System.Drawing.Point(97, 34)
        Me.det_EndDate.Name = "det_EndDate"
        Me.det_EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.det_EndDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.det_EndDate.Properties.Appearance.Options.UseFont = True
        Me.det_EndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.det_EndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.det_EndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.det_EndDate.Size = New System.Drawing.Size(113, 24)
        Me.det_EndDate.TabIndex = 209
        '
        'det_StartDate
        '
        Me.det_StartDate.EditValue = Nothing
        Me.det_StartDate.Location = New System.Drawing.Point(97, 4)
        Me.det_StartDate.Name = "det_StartDate"
        Me.det_StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.det_StartDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.det_StartDate.Properties.Appearance.Options.UseFont = True
        Me.det_StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.det_StartDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.det_StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.det_StartDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.det_StartDate.Size = New System.Drawing.Size(113, 24)
        Me.det_StartDate.TabIndex = 207
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 208
        Me.Label1.Text = "截止日期(&E)："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "起始日期(&B)："
        '
        'GLU_MCode
        '
        Me.GLU_MCode.EditValue = "*全部*"
        Me.GLU_MCode.Location = New System.Drawing.Point(548, 7)
        Me.GLU_MCode.Name = "GLU_MCode"
        Me.GLU_MCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GLU_MCode.Properties.Appearance.Options.UseFont = True
        Me.GLU_MCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_MCode.Properties.DisplayMember = "SO_CusterID"
        Me.GLU_MCode.Properties.NullText = ""
        Me.GLU_MCode.Properties.PopupFormWidth = 500
        Me.GLU_MCode.Properties.View = Me.GridView4
        Me.GLU_MCode.Size = New System.Drawing.Size(142, 24)
        Me.GLU_MCode.TabIndex = 213
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
        Me.Label2.Location = New System.Drawing.Point(452, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "產品編號(&P)："
        '
        'txtSelect
        '
        Me.txtSelect.EditValue = "[A]:周數"
        Me.txtSelect.Location = New System.Drawing.Point(316, 7)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelect.Properties.Appearance.Options.UseFont = True
        Me.txtSelect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSelect.Properties.Items.AddRange(New Object() {"[A]:周數", "[B]:月份"})
        Me.txtSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtSelect.Size = New System.Drawing.Size(131, 24)
        Me.txtSelect.TabIndex = 211
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(222, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 210
        Me.Label11.Text = "查詢類型(&R)："
        '
        'cmdFind
        '
        Me.cmdFind.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdFind.Appearance.Options.UseFont = True
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.Location = New System.Drawing.Point(699, 7)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(82, 24)
        Me.cmdFind.TabIndex = 214
        Me.cmdFind.Text = "查詢(&O)"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 97)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(882, 364)
        Me.GridControl1.TabIndex = 215
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsPrint.AutoWidth = False
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
        'btnExcel
        '
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(699, 37)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(82, 24)
        Me.btnExcel.TabIndex = 216
        Me.btnExcel.Text = "Excel(&S)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.det_StartDate)
        Me.Panel1.Controls.Add(Me.det_EndDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GLU_MCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdFind)
        Me.Panel1.Controls.Add(Me.txtSelect)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(2, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 62)
        Me.Panel1.TabIndex = 217
        '
        'frmMRPForeCastProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMRPForeCastProduction"
        Me.Text = "預測生產計劃瀏覽"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.det_EndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.det_StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents det_EndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents det_StartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GLU_MCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSelect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
