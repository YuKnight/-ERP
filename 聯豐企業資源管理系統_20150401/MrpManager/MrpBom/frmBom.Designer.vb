<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBom
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
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.startDate = New DevExpress.XtraEditors.DateEdit
        Me.endDate = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtVersion = New DevExpress.XtraEditors.SpinEdit
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtSource = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGauge = New DevExpress.XtraEditors.TextEdit
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit
        Me.tab = New DevExpress.XtraTab.XtraTabControl
        Me.tabAdd = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridMCode = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridDetail = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BomDetailAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.BomDetailInsert = New System.Windows.Forms.ToolStripMenuItem
        Me.BomDetailDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Item = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChildGroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.ChildName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ChildGauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ChildMC_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReplaceType1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.UseFeatures = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Mount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.Tmrtc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.LossRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.SendUnit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IsUnfold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.EffectiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.InvalidDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabCheck = New DevExpress.XtraTab.XtraTabPage
        Me.lblCheckID = New System.Windows.Forms.Label
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.MemoCheck = New DevExpress.XtraEditors.MemoEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BomCheck = New DevExpress.XtraEditors.CheckEdit
        Me.okButton = New DevExpress.XtraEditors.SimpleButton
        Me.canButton = New DevExpress.XtraEditors.SimpleButton
        Me.lblinfo = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.startDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabAdd.SuspendLayout()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.GridMCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCheck.SuspendLayout()
        CType(Me.MemoCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BomCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Title.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.lbl_Title.ForeColor = System.Drawing.Color.Navy
        Me.lbl_Title.Location = New System.Drawing.Point(5, 8)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(0, 24)
        Me.lbl_Title.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "版        本："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "產品編號："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "產品規格："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(500, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "來  源  碼："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "生產單位："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "生效日期："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "失效日期："
        '
        'startDate
        '
        Me.startDate.EditValue = Nothing
        Me.startDate.Location = New System.Drawing.Point(332, 72)
        Me.startDate.Name = "startDate"
        Me.startDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.startDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.startDate.Properties.Appearance.Options.UseFont = True
        Me.startDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.startDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.startDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.startDate.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.startDate.Size = New System.Drawing.Size(160, 24)
        Me.startDate.TabIndex = 13
        '
        'endDate
        '
        Me.endDate.EditValue = Nothing
        Me.endDate.Location = New System.Drawing.Point(579, 74)
        Me.endDate.Name = "endDate"
        Me.endDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.endDate.Properties.Appearance.Options.UseFont = True
        Me.endDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.endDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.endDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.endDate.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.endDate.Size = New System.Drawing.Size(160, 24)
        Me.endDate.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVersion)
        Me.GroupBox1.Controls.Add(Me.gluM_Code)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.startDate)
        Me.GroupBox1.Controls.Add(Me.endDate)
        Me.GroupBox1.Controls.Add(Me.txtGauge)
        Me.GroupBox1.Controls.Add(Me.txtUnit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtVersion
        '
        Me.txtVersion.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtVersion.Location = New System.Drawing.Point(84, 74)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtVersion.Properties.Appearance.Options.UseFont = True
        Me.txtVersion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtVersion.Properties.DisplayFormat.FormatString = "V{0}"
        Me.txtVersion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtVersion.Properties.EditFormat.FormatString = "V{0}"
        Me.txtVersion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtVersion.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtVersion.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtVersion.Size = New System.Drawing.Size(170, 24)
        Me.txtVersion.TabIndex = 11
        '
        'gluM_Code
        '
        Me.gluM_Code.AllowDrop = True
        Me.gluM_Code.Location = New System.Drawing.Point(84, 14)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.PopupFormWidth = 300
        Me.gluM_Code.Properties.View = Me.GridLookUpEdit1View
        Me.gluM_Code.Size = New System.Drawing.Size(170, 24)
        Me.gluM_Code.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code1, Me.M_Name1, Me.GridColumn1, Me.GridColumn3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'M_Code1
        '
        Me.M_Code1.Caption = "產品編碼"
        Me.M_Code1.FieldName = "M_Code"
        Me.M_Code1.Name = "M_Code1"
        Me.M_Code1.Visible = True
        Me.M_Code1.VisibleIndex = 0
        Me.M_Code1.Width = 132
        '
        'M_Name1
        '
        Me.M_Name1.Caption = "名稱"
        Me.M_Name1.FieldName = "M_Name"
        Me.M_Name1.Name = "M_Name1"
        Me.M_Name1.Visible = True
        Me.M_Name1.VisibleIndex = 1
        Me.M_Name1.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "MC_SourceID"
        Me.GridColumn1.FieldName = "MC_SourceID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "來源碼"
        Me.GridColumn3.FieldName = "MC_Source"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 70
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(332, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtName.Properties.Appearance.Options.UseBackColor = True
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(160, 24)
        Me.txtName.TabIndex = 3
        '
        'txtSource
        '
        Me.txtSource.Enabled = False
        Me.txtSource.Location = New System.Drawing.Point(579, 46)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSource.Properties.Appearance.Options.UseFont = True
        Me.txtSource.Size = New System.Drawing.Size(160, 24)
        Me.txtSource.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(256, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "物料名稱："
        '
        'txtGauge
        '
        Me.txtGauge.Location = New System.Drawing.Point(84, 44)
        Me.txtGauge.Name = "txtGauge"
        Me.txtGauge.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtGauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtGauge.Properties.Appearance.Options.UseBackColor = True
        Me.txtGauge.Properties.Appearance.Options.UseFont = True
        Me.txtGauge.Size = New System.Drawing.Size(410, 24)
        Me.txtGauge.TabIndex = 7
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(579, 16)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Size = New System.Drawing.Size(160, 24)
        Me.txtUnit.TabIndex = 5
        '
        'tab
        '
        Me.tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab.Location = New System.Drawing.Point(1, 146)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabAdd
        Me.tab.Size = New System.Drawing.Size(792, 373)
        Me.tab.TabIndex = 0
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAdd, Me.tabCheck})
        '
        'tabAdd
        '
        Me.tabAdd.Controls.Add(Me.PopupContainerControl1)
        Me.tabAdd.Controls.Add(Me.GridDetail)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Size = New System.Drawing.Size(783, 341)
        Me.tabAdd.Text = "物料明細"
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.GridMCode)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(68, 53)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(553, 221)
        Me.PopupContainerControl1.TabIndex = 1
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'GridMCode
        '
        Me.GridMCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMCode.EmbeddedNavigator.Name = ""
        Me.GridMCode.Location = New System.Drawing.Point(0, 0)
        Me.GridMCode.MainView = Me.GridView1
        Me.GridMCode.Name = "GridMCode"
        Me.GridMCode.Size = New System.Drawing.Size(553, 221)
        Me.GridMCode.TabIndex = 0
        Me.GridMCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.MC_Source})
        Me.GridView1.GridControl = Me.GridMCode
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 145
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
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 200
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 45
        '
        'MC_Source
        '
        Me.MC_Source.Caption = "來源碼"
        Me.MC_Source.FieldName = "MC_Source"
        Me.MC_Source.Name = "MC_Source"
        Me.MC_Source.Visible = True
        Me.MC_Source.VisibleIndex = 4
        '
        'GridDetail
        '
        Me.GridDetail.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDetail.EmbeddedNavigator.Name = ""
        Me.GridDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridDetail.MainView = Me.GridView2
        Me.GridDetail.Name = "GridDetail"
        Me.GridDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemMRUEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemDateEdit1})
        Me.GridDetail.Size = New System.Drawing.Size(783, 341)
        Me.GridDetail.TabIndex = 0
        Me.GridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BomDetailAdd, Me.BomDetailInsert, Me.BomDetailDel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 70)
        '
        'BomDetailAdd
        '
        Me.BomDetailAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.BomDetailAdd.Name = "BomDetailAdd"
        Me.BomDetailAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.BomDetailAdd.Size = New System.Drawing.Size(162, 22)
        Me.BomDetailAdd.Text = "新增(&A)"
        '
        'BomDetailInsert
        '
        Me.BomDetailInsert.Image = Global.LFERP.My.Resources.Resources.BlogPublishMenu
        Me.BomDetailInsert.Name = "BomDetailInsert"
        Me.BomDetailInsert.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.BomDetailInsert.Size = New System.Drawing.Size(162, 22)
        Me.BomDetailInsert.Text = "插入(&I)"
        '
        'BomDetailDel
        '
        Me.BomDetailDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.BomDetailDel.Name = "BomDetailDel"
        Me.BomDetailDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.BomDetailDel.Size = New System.Drawing.Size(162, 22)
        Me.BomDetailDel.Text = "刪除(&D)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Item, Me.ChildGroup, Me.ChildName, Me.ChildGauge, Me.ChildMC_Source, Me.ReplaceType1, Me.UseFeatures, Me.Mount, Me.Tmrtc, Me.LossRate, Me.SendUnit, Me.IsUnfold, Me.EffectiveDate, Me.InvalidDate, Me.AutoID})
        Me.GridView2.GridControl = Me.GridDetail
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Item
        '
        Me.Item.Caption = "序號"
        Me.Item.FieldName = "Item"
        Me.Item.Name = "Item"
        Me.Item.OptionsColumn.AllowEdit = False
        Me.Item.Visible = True
        Me.Item.VisibleIndex = 0
        Me.Item.Width = 45
        '
        'ChildGroup
        '
        Me.ChildGroup.Caption = "元件料件"
        Me.ChildGroup.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.ChildGroup.FieldName = "ChildGroup"
        Me.ChildGroup.Name = "ChildGroup"
        Me.ChildGroup.Visible = True
        Me.ChildGroup.VisibleIndex = 1
        Me.ChildGroup.Width = 126
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl1
        '
        'ChildName
        '
        Me.ChildName.Caption = "名稱"
        Me.ChildName.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.ChildName.FieldName = "ChildName"
        Me.ChildName.Name = "ChildName"
        Me.ChildName.OptionsColumn.ReadOnly = True
        Me.ChildName.Visible = True
        Me.ChildName.VisibleIndex = 2
        Me.ChildName.Width = 101
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'ChildGauge
        '
        Me.ChildGauge.Caption = "規格"
        Me.ChildGauge.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.ChildGauge.FieldName = "ChildGauge"
        Me.ChildGauge.Name = "ChildGauge"
        Me.ChildGauge.OptionsColumn.ReadOnly = True
        Me.ChildGauge.Visible = True
        Me.ChildGauge.VisibleIndex = 3
        Me.ChildGauge.Width = 119
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'ChildMC_Source
        '
        Me.ChildMC_Source.Caption = "來源碼"
        Me.ChildMC_Source.FieldName = "ChildMC_Source"
        Me.ChildMC_Source.Name = "ChildMC_Source"
        Me.ChildMC_Source.OptionsColumn.ReadOnly = True
        Me.ChildMC_Source.Visible = True
        Me.ChildMC_Source.VisibleIndex = 4
        '
        'ReplaceType1
        '
        Me.ReplaceType1.Caption = "取代類型"
        Me.ReplaceType1.ColumnEdit = Me.RepositoryItemMRUEdit1
        Me.ReplaceType1.FieldName = "ReplaceType1"
        Me.ReplaceType1.Name = "ReplaceType1"
        Me.ReplaceType1.Visible = True
        Me.ReplaceType1.VisibleIndex = 5
        Me.ReplaceType1.Width = 95
        '
        'RepositoryItemMRUEdit1
        '
        Me.RepositoryItemMRUEdit1.AutoHeight = False
        Me.RepositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit1.Items.AddRange(New Object() {"正常(normal)", "取代(UTE)", "替代(SUB)"})
        Me.RepositoryItemMRUEdit1.Name = "RepositoryItemMRUEdit1"
        Me.RepositoryItemMRUEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'UseFeatures
        '
        Me.UseFeatures.Caption = "使用特性"
        Me.UseFeatures.FieldName = "UseFeatures"
        Me.UseFeatures.Name = "UseFeatures"
        Me.UseFeatures.Visible = True
        Me.UseFeatures.VisibleIndex = 6
        '
        'Mount
        '
        Me.Mount.Caption = "組成用量"
        Me.Mount.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.Mount.DisplayFormat.FormatString = "#,###0.######"
        Me.Mount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Mount.FieldName = "Mount"
        Me.Mount.Name = "Mount"
        Me.Mount.Visible = True
        Me.Mount.VisibleIndex = 7
        Me.Mount.Width = 70
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Tmrtc
        '
        Me.Tmrtc.Caption = "主件底數"
        Me.Tmrtc.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.Tmrtc.DisplayFormat.FormatString = "#,###0.######"
        Me.Tmrtc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tmrtc.FieldName = "Tmrtc"
        Me.Tmrtc.Name = "Tmrtc"
        Me.Tmrtc.Visible = True
        Me.Tmrtc.VisibleIndex = 8
        Me.Tmrtc.Width = 70
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'LossRate
        '
        Me.LossRate.Caption = "損耗率"
        Me.LossRate.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.LossRate.DisplayFormat.FormatString = "#,###0.######"
        Me.LossRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LossRate.FieldName = "LossRate"
        Me.LossRate.Name = "LossRate"
        Me.LossRate.Visible = True
        Me.LossRate.VisibleIndex = 9
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'SendUnit
        '
        Me.SendUnit.Caption = "發料單位"
        Me.SendUnit.FieldName = "SendUnit"
        Me.SendUnit.Name = "SendUnit"
        Me.SendUnit.OptionsColumn.AllowEdit = False
        Me.SendUnit.Visible = True
        Me.SendUnit.VisibleIndex = 10
        Me.SendUnit.Width = 70
        '
        'IsUnfold
        '
        Me.IsUnfold.Caption = "展開"
        Me.IsUnfold.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.IsUnfold.FieldName = "IsUnfold"
        Me.IsUnfold.Name = "IsUnfold"
        Me.IsUnfold.Visible = True
        Me.IsUnfold.VisibleIndex = 11
        Me.IsUnfold.Width = 45
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'EffectiveDate
        '
        Me.EffectiveDate.Caption = "生效日期"
        Me.EffectiveDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.EffectiveDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.EffectiveDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.EffectiveDate.FieldName = "EffectiveDate"
        Me.EffectiveDate.Name = "EffectiveDate"
        Me.EffectiveDate.Visible = True
        Me.EffectiveDate.VisibleIndex = 12
        Me.EffectiveDate.Width = 90
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'InvalidDate
        '
        Me.InvalidDate.Caption = "失效日期"
        Me.InvalidDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.InvalidDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.InvalidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.InvalidDate.FieldName = "InvalidDate"
        Me.InvalidDate.Name = "InvalidDate"
        Me.InvalidDate.Visible = True
        Me.InvalidDate.VisibleIndex = 13
        Me.InvalidDate.Width = 90
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.lblCheckID)
        Me.tabCheck.Controls.Add(Me.lblCheckDate)
        Me.tabCheck.Controls.Add(Me.MemoCheck)
        Me.tabCheck.Controls.Add(Me.Label11)
        Me.tabCheck.Controls.Add(Me.Label10)
        Me.tabCheck.Controls.Add(Me.Label9)
        Me.tabCheck.Controls.Add(Me.BomCheck)
        Me.tabCheck.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(783, 341)
        Me.tabCheck.Text = "審核"
        '
        'lblCheckID
        '
        Me.lblCheckID.AutoSize = True
        Me.lblCheckID.Location = New System.Drawing.Point(359, 16)
        Me.lblCheckID.Name = "lblCheckID"
        Me.lblCheckID.Size = New System.Drawing.Size(0, 15)
        Me.lblCheckID.TabIndex = 14
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Location = New System.Drawing.Point(603, 15)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(0, 15)
        Me.lblCheckDate.TabIndex = 13
        '
        'MemoCheck
        '
        Me.MemoCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoCheck.Location = New System.Drawing.Point(84, 40)
        Me.MemoCheck.Name = "MemoCheck"
        Me.MemoCheck.Properties.MaxLength = 200
        Me.MemoCheck.Size = New System.Drawing.Size(668, 200)
        Me.MemoCheck.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "備注："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(270, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "審  核  人："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(527, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "審核日期："
        '
        'BomCheck
        '
        Me.BomCheck.Location = New System.Drawing.Point(12, 14)
        Me.BomCheck.Name = "BomCheck"
        Me.BomCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.BomCheck.Properties.Appearance.Options.UseFont = True
        Me.BomCheck.Properties.Caption = "確認審核"
        Me.BomCheck.Size = New System.Drawing.Size(84, 20)
        Me.BomCheck.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.okButton.Appearance.Options.UseFont = True
        Me.okButton.BackgroundImage = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.okButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.okButton.Location = New System.Drawing.Point(597, 530)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 30)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "確定"
        '
        'canButton
        '
        Me.canButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.canButton.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.canButton.Appearance.Options.UseFont = True
        Me.canButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.canButton.Location = New System.Drawing.Point(698, 530)
        Me.canButton.Name = "canButton"
        Me.canButton.Size = New System.Drawing.Size(75, 30)
        Me.canButton.TabIndex = 2
        Me.canButton.Text = "取消"
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(1, 6)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(131, 21)
        Me.lblinfo.TabIndex = 239
        Me.lblinfo.Text = "BOM產品結構"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(796, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 240
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 105)
        Me.Panel1.TabIndex = 241
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "來源碼"
        Me.GridColumn2.FieldName = "MC_Source"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'frmBom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 564)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.canButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "frmBom"
        Me.Text = "BOM產品結構"
        CType(Me.startDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabAdd.ResumeLayout(False)
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.GridMCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCheck.ResumeLayout(False)
        Me.tabCheck.PerformLayout()
        CType(Me.MemoCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BomCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents startDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents endDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabAdd As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents okButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents canButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BomCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MemoCheck As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BomDetailAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BomDetailDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChildGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReplaceType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UseFeatures As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EffectiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvalidDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Mount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tmrtc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BomDetailInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSource As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsUnfold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChildName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChildGauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCheckID As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridMCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ChildMC_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LossRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtVersion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
