<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpSelect
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbltip = New System.Windows.Forms.Label
        Me.gluID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ViewID = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridColumn = New DevExpress.XtraGrid.GridControl
        Me.ViewColumn = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FieldType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTab = New DevExpress.XtraTab.XtraTabControl
        Me.xtpText = New DevExpress.XtraTab.XtraTabPage
        Me.txtText = New System.Windows.Forms.TextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnText = New DevExpress.XtraEditors.SimpleButton
        Me.xtpDate = New DevExpress.XtraTab.XtraTabPage
        Me.btnDate = New DevExpress.XtraEditors.SimpleButton
        Me.dteDate = New DevExpress.XtraEditors.DateEdit
        Me.cboDate = New DevExpress.XtraEditors.ComboBoxEdit
        Me.xtpNumber = New DevExpress.XtraTab.XtraTabPage
        Me.clcNumber = New DevExpress.XtraEditors.CalcEdit
        Me.btnNumber = New DevExpress.XtraEditors.SimpleButton
        Me.cboNumber = New DevExpress.XtraEditors.ComboBoxEdit
        Me.xtpBoolean = New DevExpress.XtraTab.XtraTabPage
        Me.cboBoolean = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnBoolean = New DevExpress.XtraEditors.SimpleButton
        Me.GridCondition = New DevExpress.XtraGrid.GridControl
        Me.viewCondition = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton
        Me.cboCondition = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmdCancle = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSubmit = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gluID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XtraTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTab.SuspendLayout()
        Me.xtpText.SuspendLayout()
        Me.xtpDate.SuspendLayout()
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpNumber.SuspendLayout()
        CType(Me.clcNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpBoolean.SuspendLayout()
        CType(Me.cboBoolean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblTitle.Location = New System.Drawing.Point(5, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 21)
        Me.lblTitle.TabIndex = 240
        Me.lblTitle.Text = "查詢模塊"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 241
        Me.PictureBox1.TabStop = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 38)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(466, 329)
        Me.XtraTabControl1.TabIndex = 239
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "篩選樣式"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(457, 297)
        Me.XtraTabPage1.Text = "固定樣式"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltip)
        Me.GroupBox2.Controls.Add(Me.gluID)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 285)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選擇"
        '
        'lbltip
        '
        Me.lbltip.AutoSize = True
        Me.lbltip.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbltip.Location = New System.Drawing.Point(35, 60)
        Me.lbltip.Name = "lbltip"
        Me.lbltip.Size = New System.Drawing.Size(86, 15)
        Me.lbltip.TabIndex = 0
        Me.lbltip.Text = "請選擇編碼:"
        Me.lbltip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gluID
        '
        Me.gluID.EditValue = ""
        Me.gluID.Location = New System.Drawing.Point(127, 51)
        Me.gluID.Name = "gluID"
        Me.gluID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluID.Properties.Appearance.Options.UseFont = True
        Me.gluID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluID.Properties.DisplayMember = "SO_CusterID"
        Me.gluID.Properties.MaxLength = 111
        Me.gluID.Properties.NullText = ""
        Me.gluID.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.gluID.Properties.PopupFormWidth = 222
        Me.gluID.Properties.View = Me.ViewID
        Me.gluID.Size = New System.Drawing.Size(199, 24)
        Me.gluID.TabIndex = 1
        '
        'ViewID
        '
        Me.ViewID.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6})
        Me.ViewID.DetailHeight = 500
        Me.ViewID.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ViewID.Name = "ViewID"
        Me.ViewID.OptionsPrint.AutoWidth = False
        Me.ViewID.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ViewID.OptionsView.ShowAutoFilterRow = True
        Me.ViewID.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "產品編號"
        Me.GridColumn6.FieldName = "M_Code"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 70
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridColumn)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(457, 297)
        Me.XtraTabPage2.Text = "自定義樣式"
        '
        'GridColumn
        '
        Me.GridColumn.EmbeddedNavigator.Name = ""
        Me.GridColumn.Location = New System.Drawing.Point(-1, 0)
        Me.GridColumn.MainView = Me.ViewColumn
        Me.GridColumn.Name = "GridColumn"
        Me.GridColumn.Size = New System.Drawing.Size(167, 296)
        Me.GridColumn.TabIndex = 0
        Me.GridColumn.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewColumn})
        '
        'ViewColumn
        '
        Me.ViewColumn.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColName, Me.FieldType, Me.Descr, Me.ColID})
        Me.ViewColumn.GridControl = Me.GridColumn
        Me.ViewColumn.Name = "ViewColumn"
        Me.ViewColumn.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.ViewColumn.OptionsView.ShowGroupPanel = False
        '
        'ColName
        '
        Me.ColName.Caption = "ColName"
        Me.ColName.FieldName = "ColName"
        Me.ColName.Name = "ColName"
        Me.ColName.OptionsColumn.AllowEdit = False
        Me.ColName.OptionsColumn.AllowFocus = False
        Me.ColName.OptionsColumn.ReadOnly = True
        Me.ColName.Width = 117
        '
        'FieldType
        '
        Me.FieldType.Caption = "FieldType"
        Me.FieldType.FieldName = "FieldType"
        Me.FieldType.Name = "FieldType"
        Me.FieldType.OptionsColumn.AllowEdit = False
        Me.FieldType.OptionsColumn.AllowFocus = False
        Me.FieldType.OptionsColumn.ReadOnly = True
        Me.FieldType.Width = 48
        '
        'Descr
        '
        Me.Descr.Caption = "字段名稱"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.OptionsColumn.AllowEdit = False
        Me.Descr.OptionsColumn.AllowFocus = False
        Me.Descr.OptionsColumn.ReadOnly = True
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 0
        Me.Descr.Width = 88
        '
        'ColID
        '
        Me.ColID.AppearanceCell.Options.UseTextOptions = True
        Me.ColID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColID.Caption = "列ID"
        Me.ColID.FieldName = "ColID"
        Me.ColID.Name = "ColID"
        Me.ColID.Width = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.XtraTab)
        Me.GroupBox1.Controls.Add(Me.GridCondition)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.cboCondition)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 293)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 101)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "請選擇查詢條件:"
        '
        'XtraTab
        '
        Me.XtraTab.Location = New System.Drawing.Point(3, 12)
        Me.XtraTab.Name = "XtraTab"
        Me.XtraTab.SelectedTabPage = Me.xtpText
        Me.XtraTab.Size = New System.Drawing.Size(290, 74)
        Me.XtraTab.TabIndex = 0
        Me.XtraTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpText, Me.xtpDate, Me.xtpNumber, Me.xtpBoolean})
        Me.XtraTab.Text = "XtraTab"
        '
        'xtpText
        '
        Me.xtpText.Controls.Add(Me.txtText)
        Me.xtpText.Controls.Add(Me.LabelControl2)
        Me.xtpText.Controls.Add(Me.btnText)
        Me.xtpText.Name = "xtpText"
        Me.xtpText.Size = New System.Drawing.Size(281, 42)
        Me.xtpText.Text = "文字"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(35, 10)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(163, 22)
        Me.txtText.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Like"
        '
        'btnText
        '
        Me.btnText.Image = Global.LFERP.My.Resources.Resources.SmartArtPromote
        Me.btnText.Location = New System.Drawing.Point(201, 10)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(78, 24)
        Me.btnText.TabIndex = 2
        Me.btnText.Text = "添加(&A)"
        '
        'xtpDate
        '
        Me.xtpDate.Controls.Add(Me.btnDate)
        Me.xtpDate.Controls.Add(Me.dteDate)
        Me.xtpDate.Controls.Add(Me.cboDate)
        Me.xtpDate.Name = "xtpDate"
        Me.xtpDate.Size = New System.Drawing.Size(281, 42)
        Me.xtpDate.Text = "日期"
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(206, 12)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(58, 24)
        Me.btnDate.TabIndex = 13
        Me.btnDate.Text = "添加(&A)"
        '
        'dteDate
        '
        Me.dteDate.EditValue = Nothing
        Me.dteDate.Location = New System.Drawing.Point(99, 14)
        Me.dteDate.Name = "dteDate"
        Me.dteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDate.Size = New System.Drawing.Size(106, 21)
        Me.dteDate.TabIndex = 12
        '
        'cboDate
        '
        Me.cboDate.EditValue = "=(等於)"
        Me.cboDate.Location = New System.Drawing.Point(0, 14)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDate.Properties.Items.AddRange(New Object() {"=(等於)", ">(大於)", "<(小於)"})
        Me.cboDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDate.Size = New System.Drawing.Size(97, 21)
        Me.cboDate.TabIndex = 11
        '
        'xtpNumber
        '
        Me.xtpNumber.Controls.Add(Me.clcNumber)
        Me.xtpNumber.Controls.Add(Me.btnNumber)
        Me.xtpNumber.Controls.Add(Me.cboNumber)
        Me.xtpNumber.Name = "xtpNumber"
        Me.xtpNumber.Size = New System.Drawing.Size(281, 42)
        Me.xtpNumber.Text = "數字"
        '
        'clcNumber
        '
        Me.clcNumber.Location = New System.Drawing.Point(103, 14)
        Me.clcNumber.Name = "clcNumber"
        Me.clcNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.clcNumber.Size = New System.Drawing.Size(100, 21)
        Me.clcNumber.TabIndex = 15
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(204, 12)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(58, 24)
        Me.btnNumber.TabIndex = 14
        Me.btnNumber.Text = "添加(&A)"
        '
        'cboNumber
        '
        Me.cboNumber.EditValue = "=(等於)"
        Me.cboNumber.Location = New System.Drawing.Point(0, 14)
        Me.cboNumber.Name = "cboNumber"
        Me.cboNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNumber.Properties.Items.AddRange(New Object() {"=(等於)", ">(大於)", "<(小於)"})
        Me.cboNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboNumber.Size = New System.Drawing.Size(97, 21)
        Me.cboNumber.TabIndex = 12
        '
        'xtpBoolean
        '
        Me.xtpBoolean.Controls.Add(Me.cboBoolean)
        Me.xtpBoolean.Controls.Add(Me.LabelControl3)
        Me.xtpBoolean.Controls.Add(Me.btnBoolean)
        Me.xtpBoolean.Name = "xtpBoolean"
        Me.xtpBoolean.Size = New System.Drawing.Size(281, 42)
        Me.xtpBoolean.Text = "其他"
        '
        'cboBoolean
        '
        Me.cboBoolean.EditValue = "是"
        Me.cboBoolean.Location = New System.Drawing.Point(84, 11)
        Me.cboBoolean.Name = "cboBoolean"
        Me.cboBoolean.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBoolean.Properties.Items.AddRange(New Object() {"是", "否"})
        Me.cboBoolean.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBoolean.Size = New System.Drawing.Size(89, 21)
        Me.cboBoolean.TabIndex = 18
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "等於"
        '
        'btnBoolean
        '
        Me.btnBoolean.Location = New System.Drawing.Point(194, 9)
        Me.btnBoolean.Name = "btnBoolean"
        Me.btnBoolean.Size = New System.Drawing.Size(58, 24)
        Me.btnBoolean.TabIndex = 16
        Me.btnBoolean.Text = "添加(&A)"
        '
        'GridCondition
        '
        Me.GridCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCondition.EmbeddedNavigator.Name = ""
        Me.GridCondition.Location = New System.Drawing.Point(3, 131)
        Me.GridCondition.MainView = Me.viewCondition
        Me.GridCondition.Name = "GridCondition"
        Me.GridCondition.Size = New System.Drawing.Size(275, 133)
        Me.GridCondition.TabIndex = 18
        Me.GridCondition.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewCondition})
        '
        'viewCondition
        '
        Me.viewCondition.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.viewCondition.GridControl = Me.GridCondition
        Me.viewCondition.Name = "viewCondition"
        Me.viewCondition.OptionsBehavior.Editable = False
        Me.viewCondition.OptionsCustomization.AllowSort = False
        Me.viewCondition.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ConditionValue"
        Me.GridColumn4.FieldName = "ConditionValue"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 248
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "篩選條件"
        Me.GridColumn5.FieldName = "ConditionText"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'btnDel
        '
        Me.btnDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.btnDel.Location = New System.Drawing.Point(201, 266)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(78, 24)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "刪除(&D)"
        '
        'cboCondition
        '
        Me.cboCondition.EditValue = " AND (並且)"
        Me.cboCondition.Location = New System.Drawing.Point(98, 98)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCondition.Properties.Items.AddRange(New Object() {" AND (並且)", " OR   (或者)"})
        Me.cboCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCondition.Size = New System.Drawing.Size(180, 21)
        Me.cboCondition.TabIndex = 2
        '
        'cmdCancle
        '
        Me.cmdCancle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancle.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancle.Location = New System.Drawing.Point(379, 372)
        Me.cmdCancle.Name = "cmdCancle"
        Me.cmdCancle.Size = New System.Drawing.Size(74, 31)
        Me.cmdCancle.TabIndex = 243
        Me.cmdCancle.Text = "取消(&C)"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdSubmit.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSubmit.Location = New System.Drawing.Point(286, 373)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(74, 30)
        Me.cmdSubmit.TabIndex = 242
        Me.cmdSubmit.Text = "確定(&O)"
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 405)
        Me.Controls.Add(Me.cmdCancle)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "查詢"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gluID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.XtraTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTab.ResumeLayout(False)
        Me.xtpText.ResumeLayout(False)
        Me.xtpText.PerformLayout()
        Me.xtpDate.ResumeLayout(False)
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpNumber.ResumeLayout(False)
        CType(Me.clcNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpBoolean.ResumeLayout(False)
        Me.xtpBoolean.PerformLayout()
        CType(Me.cboBoolean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltip As System.Windows.Forms.Label
    Friend WithEvents gluID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ViewID As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridColumn As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewColumn As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FieldType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpText As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnText As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xtpDate As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboDate As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents xtpNumber As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnNumber As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboNumber As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents xtpBoolean As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboBoolean As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBoolean As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCondition As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewCondition As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCondition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents clcNumber As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents cmdCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSubmit As DevExpress.XtraEditors.SimpleButton
End Class
