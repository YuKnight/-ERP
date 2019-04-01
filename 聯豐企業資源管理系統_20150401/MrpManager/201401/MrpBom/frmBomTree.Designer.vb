<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBomTree
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
        Me.sonsNum = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.ChildGroup = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Gauge = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Source = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Mount = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Tmrtc = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.QtyPer = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.LossRate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.LossQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.ActualQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Unit = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.EffectiveDate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.InvalidDate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.CreateUserName = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.CreateDate = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.isUnfold = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.checkBit = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cmsBomTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsBomTreeExport = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.caeQty = New DevExpress.XtraEditors.CalcEdit
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DM_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSource = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnExpand = New DevExpress.XtraEditors.SimpleButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtM_Gauge = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsBomTree.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.caeQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sonsNum
        '
        Me.sonsNum.Caption = "sonsNum"
        Me.sonsNum.FieldName = "sonsNum"
        Me.sonsNum.Name = "sonsNum"
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.ChildGroup, Me.M_Name, Me.M_Gauge, Me.M_Source, Me.Mount, Me.Tmrtc, Me.QtyPer, Me.LossRate, Me.LossQty, Me.ActualQty, Me.M_Unit, Me.sonsNum, Me.EffectiveDate, Me.InvalidDate, Me.CreateUserName, Me.CreateDate, Me.isUnfold, Me.checkBit})
        Me.TreeList1.ContextMenuStrip = Me.cmsBomTree
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.sonsNum
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = 0
        Me.TreeList1.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1})
        Me.TreeList1.Location = New System.Drawing.Point(4, 120)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.ParentFieldName = "PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.TreeList1.Size = New System.Drawing.Size(1255, 396)
        Me.TreeList1.TabIndex = 0
        '
        'ChildGroup
        '
        Me.ChildGroup.Caption = "物料編碼"
        Me.ChildGroup.FieldName = "ChildGroup"
        Me.ChildGroup.Name = "ChildGroup"
        Me.ChildGroup.OptionsColumn.ReadOnly = True
        Me.ChildGroup.VisibleIndex = 0
        Me.ChildGroup.Width = 175
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 133
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 162
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.VisibleIndex = 3
        Me.M_Source.Width = 76
        '
        'Mount
        '
        Me.Mount.Caption = "組成用量"
        Me.Mount.FieldName = "Mount"
        Me.Mount.Format.FormatString = "#,###0.######"
        Me.Mount.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Mount.Name = "Mount"
        Me.Mount.VisibleIndex = 4
        Me.Mount.Width = 66
        '
        'Tmrtc
        '
        Me.Tmrtc.Caption = "主件底數"
        Me.Tmrtc.FieldName = "Tmrtc"
        Me.Tmrtc.Format.FormatString = "#,###0.######"
        Me.Tmrtc.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tmrtc.Name = "Tmrtc"
        Me.Tmrtc.VisibleIndex = 5
        Me.Tmrtc.Width = 65
        '
        'QtyPer
        '
        Me.QtyPer.Caption = "單位用量"
        Me.QtyPer.FieldName = "QtyPer"
        Me.QtyPer.Format.FormatString = "#,###0.######"
        Me.QtyPer.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QtyPer.Name = "QtyPer"
        Me.QtyPer.VisibleIndex = 6
        Me.QtyPer.Width = 65
        '
        'LossRate
        '
        Me.LossRate.Caption = "損耗率"
        Me.LossRate.FieldName = "LossRate"
        Me.LossRate.Format.FormatString = "#,###0.######"
        Me.LossRate.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LossRate.Name = "LossRate"
        Me.LossRate.VisibleIndex = 7
        Me.LossRate.Width = 58
        '
        'LossQty
        '
        Me.LossQty.Caption = "損耗數量"
        Me.LossQty.FieldName = "LossQty"
        Me.LossQty.Format.FormatString = "#,###0.######"
        Me.LossQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LossQty.Name = "LossQty"
        Me.LossQty.VisibleIndex = 8
        Me.LossQty.Width = 64
        '
        'ActualQty
        '
        Me.ActualQty.Caption = "實際數量"
        Me.ActualQty.FieldName = "ActualQty"
        Me.ActualQty.Format.FormatString = "#,###0.######"
        Me.ActualQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ActualQty.Name = "ActualQty"
        Me.ActualQty.VisibleIndex = 9
        Me.ActualQty.Width = 70
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.VisibleIndex = 10
        Me.M_Unit.Width = 44
        '
        'EffectiveDate
        '
        Me.EffectiveDate.Caption = "生效日期"
        Me.EffectiveDate.FieldName = "EffectiveDate"
        Me.EffectiveDate.Name = "EffectiveDate"
        Me.EffectiveDate.VisibleIndex = 11
        Me.EffectiveDate.Width = 74
        '
        'InvalidDate
        '
        Me.InvalidDate.Caption = "失效日期"
        Me.InvalidDate.FieldName = "InvalidDate"
        Me.InvalidDate.Format.FormatString = "yyyy/MM/dd"
        Me.InvalidDate.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.InvalidDate.Name = "InvalidDate"
        Me.InvalidDate.VisibleIndex = 12
        Me.InvalidDate.Width = 67
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建用戶"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.CreateUserName.VisibleIndex = 13
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建日期"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Format.FormatString = "yyyy/MM/dd"
        Me.CreateDate.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.VisibleIndex = 14
        '
        'isUnfold
        '
        Me.isUnfold.Caption = "展開"
        Me.isUnfold.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.isUnfold.FieldName = "isUnfold"
        Me.isUnfold.Name = "isUnfold"
        Me.isUnfold.VisibleIndex = 15
        Me.isUnfold.Width = 43
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive
        '
        'checkBit
        '
        Me.checkBit.Caption = "審核"
        Me.checkBit.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.checkBit.FieldName = "checkBit"
        Me.checkBit.Name = "checkBit"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'cmsBomTree
        '
        Me.cmsBomTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsBomTreeExport})
        Me.cmsBomTree.Name = "cmsBomTree"
        Me.cmsBomTree.Size = New System.Drawing.Size(188, 26)
        '
        'cmsBomTreeExport
        '
        Me.cmsBomTreeExport.Name = "cmsBomTreeExport"
        Me.cmsBomTreeExport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsBomTreeExport.Size = New System.Drawing.Size(187, 22)
        Me.cmsBomTreeExport.Text = "導出Excel(&E)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.caeQty)
        Me.GroupBox1.Controls.Add(Me.gluM_Code)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.btnExpand)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtM_Gauge)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtM_Name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1255, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'caeQty
        '
        Me.caeQty.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.caeQty.Location = New System.Drawing.Point(621, 48)
        Me.caeQty.Name = "caeQty"
        Me.caeQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeQty.Properties.Appearance.Options.UseFont = True
        Me.caeQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeQty.Size = New System.Drawing.Size(122, 24)
        Me.caeQty.TabIndex = 11
        '
        'gluM_Code
        '
        Me.gluM_Code.EditValue = "*全部*"
        Me.gluM_Code.Location = New System.Drawing.Point(84, 15)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.DisplayMember = "SO_CusterID"
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.PopupFormWidth = 500
        Me.gluM_Code.Properties.View = Me.GridView4
        Me.gluM_Code.Size = New System.Drawing.Size(158, 24)
        Me.gluM_Code.TabIndex = 7
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
        'txtSource
        '
        Me.txtSource.Enabled = False
        Me.txtSource.Location = New System.Drawing.Point(621, 15)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSource.Properties.Appearance.Options.UseFont = True
        Me.txtSource.Properties.ReadOnly = True
        Me.txtSource.Size = New System.Drawing.Size(122, 24)
        Me.txtSource.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(561, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "來源碼："
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.SimpleButton1.Location = New System.Drawing.Point(761, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(77, 27)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Excel"
        '
        'btnExpand
        '
        Me.btnExpand.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExpand.Appearance.Options.UseFont = True
        Me.btnExpand.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnExpand.Location = New System.Drawing.Point(761, 45)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(77, 27)
        Me.btnExpand.TabIndex = 1
        Me.btnExpand.Text = "展開"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(576, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "數量："
        '
        'txtM_Gauge
        '
        Me.txtM_Gauge.Enabled = False
        Me.txtM_Gauge.Location = New System.Drawing.Point(84, 48)
        Me.txtM_Gauge.Name = "txtM_Gauge"
        Me.txtM_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txtM_Gauge.Properties.ReadOnly = True
        Me.txtM_Gauge.Size = New System.Drawing.Size(471, 24)
        Me.txtM_Gauge.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "物料規格："
        '
        'txtM_Name
        '
        Me.txtM_Name.Enabled = False
        Me.txtM_Name.Location = New System.Drawing.Point(324, 15)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Properties.ReadOnly = True
        Me.txtM_Name.Size = New System.Drawing.Size(231, 24)
        Me.txtM_Name.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "物料名稱："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "物料編碼："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bom物料展開表"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1270, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmBomTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 528)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TreeList1)
        Me.Name = "frmBomTree"
        Me.Text = "Bom物料展開表"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsBomTree.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.caeQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents ChildGroup As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ActualQty As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Gauge As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Unit As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExpand As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents caeQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtM_Gauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sonsNum As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents cmsBomTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsBomTreeExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EffectiveDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents InvalidDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents CreateUserName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents CreateDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents isUnfold As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Source As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents checkBit As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtSource As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Mount As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Tmrtc As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents QtyPer As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LossRate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents LossQty As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
