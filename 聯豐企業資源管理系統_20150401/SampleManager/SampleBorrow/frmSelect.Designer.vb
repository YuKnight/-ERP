<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Me.lblinfo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdCancle = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSubmit = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gueID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.viewID = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblID = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmdAdd_Char = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.cmdAdd_Date = New DevExpress.XtraEditors.SimpleButton
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.cmdAdd_Number = New DevExpress.XtraEditors.SimpleButton
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.cboLogic = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmdAdd_Other = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdDel = New DevExpress.XtraEditors.SimpleButton
        Me.cboCondition = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gueID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLogic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(4, 4)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(98, 21)
        Me.lblinfo.TabIndex = 239
        Me.lblinfo.Text = "查詢模塊"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 240
        Me.PictureBox1.TabStop = False
        '
        'cmdCancle
        '
        Me.cmdCancle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancle.Location = New System.Drawing.Point(381, 380)
        Me.cmdCancle.Name = "cmdCancle"
        Me.cmdCancle.Size = New System.Drawing.Size(74, 31)
        Me.cmdCancle.TabIndex = 243
        Me.cmdCancle.Text = "取消(&C)"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSubmit.Location = New System.Drawing.Point(301, 381)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(74, 30)
        Me.cmdSubmit.TabIndex = 242
        Me.cmdSubmit.Text = "確定(&O)"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 38)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(463, 336)
        Me.XtraTabControl1.TabIndex = 241
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "篩選樣式"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(454, 304)
        Me.XtraTabPage1.Text = "固定樣式"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gueID)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 259)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選擇"
        '
        'gueID
        '
        Me.gueID.EditValue = ""
        Me.gueID.Location = New System.Drawing.Point(151, 50)
        Me.gueID.Name = "gueID"
        Me.gueID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gueID.Properties.Appearance.Options.UseFont = True
        Me.gueID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gueID.Properties.DisplayMember = "SO_CusterID"
        Me.gueID.Properties.MaxLength = 111
        Me.gueID.Properties.NullText = ""
        Me.gueID.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.gueID.Properties.PopupFormWidth = 222
        Me.gueID.Properties.View = Me.viewID
        Me.gueID.Size = New System.Drawing.Size(226, 24)
        Me.gueID.TabIndex = 19
        '
        'viewID
        '
        Me.viewID.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6})
        Me.viewID.DetailHeight = 500
        Me.viewID.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.viewID.Name = "viewID"
        Me.viewID.OptionsPrint.AutoWidth = False
        Me.viewID.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewID.OptionsView.ShowAutoFilterRow = True
        Me.viewID.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "单号"
        Me.GridColumn6.FieldName = "ID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 70
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblID.Location = New System.Drawing.Point(31, 54)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(116, 15)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "請選擇物料編碼:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(454, 304)
        Me.XtraTabPage2.Text = "自定義樣式"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(-1, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(160, 296)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Type"
        Me.GridColumn2.FieldName = "Type"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Width = 48
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "FieldName"
        Me.GridColumn3.FieldName = "FieldName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Width = 88
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "类别"
        Me.GridColumn1.FieldName = "Category"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.XtraTabControl2)
        Me.GroupBox1.Controls.Add(Me.GridControl2)
        Me.GroupBox1.Controls.Add(Me.cmdDel)
        Me.GroupBox1.Controls.Add(Me.cboCondition)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 307)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 101)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "請選擇查詢條件:"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(3, 12)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(274, 74)
        Me.XtraTabControl2.TabIndex = 9
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TextBox1)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage3.Controls.Add(Me.cmdAdd_Char)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(265, 42)
        Me.XtraTabPage3.Text = "文字"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 22)
        Me.TextBox1.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Like"
        '
        'cmdAdd_Char
        '
        Me.cmdAdd_Char.Location = New System.Drawing.Point(201, 10)
        Me.cmdAdd_Char.Name = "cmdAdd_Char"
        Me.cmdAdd_Char.Size = New System.Drawing.Size(58, 24)
        Me.cmdAdd_Char.TabIndex = 10
        Me.cmdAdd_Char.Text = "添加(&A)"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.cmdAdd_Date)
        Me.XtraTabPage4.Controls.Add(Me.DateEdit1)
        Me.XtraTabPage4.Controls.Add(Me.ComboBoxEdit2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(265, 42)
        Me.XtraTabPage4.Text = "日期"
        '
        'cmdAdd_Date
        '
        Me.cmdAdd_Date.Location = New System.Drawing.Point(206, 12)
        Me.cmdAdd_Date.Name = "cmdAdd_Date"
        Me.cmdAdd_Date.Size = New System.Drawing.Size(58, 24)
        Me.cmdAdd_Date.TabIndex = 13
        Me.cmdAdd_Date.Text = "添加(&A)"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(99, 14)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(106, 21)
        Me.DateEdit1.TabIndex = 12
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.EditValue = "=       等於"
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(0, 14)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"=       等於", ">     大於", "<     小於"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(97, 21)
        Me.ComboBoxEdit2.TabIndex = 11
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.cmdAdd_Number)
        Me.XtraTabPage5.Controls.Add(Me.txtQty)
        Me.XtraTabPage5.Controls.Add(Me.cboLogic)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(265, 42)
        Me.XtraTabPage5.Text = "數字"
        '
        'cmdAdd_Number
        '
        Me.cmdAdd_Number.Location = New System.Drawing.Point(204, 12)
        Me.cmdAdd_Number.Name = "cmdAdd_Number"
        Me.cmdAdd_Number.Size = New System.Drawing.Size(58, 24)
        Me.cmdAdd_Number.TabIndex = 14
        Me.cmdAdd_Number.Text = "添加(&A)"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(98, 14)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(105, 21)
        Me.txtQty.TabIndex = 13
        '
        'cboLogic
        '
        Me.cboLogic.EditValue = "=       等於"
        Me.cboLogic.Location = New System.Drawing.Point(0, 14)
        Me.cboLogic.Name = "cboLogic"
        Me.cboLogic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLogic.Properties.Items.AddRange(New Object() {"=       等於", ">       大於", ">=     大於并等於", "<       小於", "<=     小於并等於"})
        Me.cboLogic.Size = New System.Drawing.Size(97, 21)
        Me.cboLogic.TabIndex = 12
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage6.Controls.Add(Me.cmdAdd_Other)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(265, 42)
        Me.XtraTabPage6.Text = "其他"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "是"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(84, 11)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"是", "否"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBoxEdit1.TabIndex = 18
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "等於"
        '
        'cmdAdd_Other
        '
        Me.cmdAdd_Other.Location = New System.Drawing.Point(194, 9)
        Me.cmdAdd_Other.Name = "cmdAdd_Other"
        Me.cmdAdd_Other.Size = New System.Drawing.Size(58, 24)
        Me.cmdAdd_Other.TabIndex = 16
        Me.cmdAdd_Other.Text = "添加(&A)"
        '
        'GridControl2
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(3, 131)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(275, 133)
        Me.GridControl2.TabIndex = 18
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "篩選條件"
        Me.GridColumn4.FieldName = "DelConditon"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 248
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "顯示篩選"
        Me.GridColumn5.FieldName = "DelDisplay"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'cmdDel
        '
        Me.cmdDel.Location = New System.Drawing.Point(218, 268)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(58, 24)
        Me.cmdDel.TabIndex = 17
        Me.cmdDel.Text = "刪除(&D)"
        '
        'cboCondition
        '
        Me.cboCondition.EditValue = "AND　並且"
        Me.cboCondition.Location = New System.Drawing.Point(98, 98)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCondition.Properties.Items.AddRange(New Object() {"AND    並且", " OR     或者"})
        Me.cboCondition.Size = New System.Drawing.Size(180, 21)
        Me.cboCondition.TabIndex = 15
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 414)
        Me.Controls.Add(Me.cmdCancle)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查询"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gueID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLogic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents gueID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents viewID As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAdd_Char As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdAdd_Date As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdAdd_Number As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboLogic As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAdd_Other As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCondition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
