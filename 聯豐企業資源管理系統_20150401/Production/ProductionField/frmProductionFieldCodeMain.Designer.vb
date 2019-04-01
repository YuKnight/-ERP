<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionFieldCodeMain
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收入項目", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("發出項目", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ControlDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.twWare = New System.Windows.Forms.TreeView
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuCodeInAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.smKaiLiao = New System.Windows.Forms.ToolStripMenuItem
        Me.smJiaCun = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.smDaHuo = New System.Windows.Forms.ToolStripMenuItem
        Me.smChuHuo = New System.Windows.Forms.ToolStripMenuItem
        Me.smZuhe = New System.Windows.Forms.ToolStripMenuItem
        Me.smChaiFen = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.smChengPin = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.smFanXiu = New System.Windows.Forms.ToolStripMenuItem
        Me.smRePairOut = New System.Windows.Forms.ToolStripMenuItem
        Me.smWaiFa = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.smSunHuai = New System.Windows.Forms.ToolStripMenuItem
        Me.smDiuShi = New System.Windows.Forms.ToolStripMenuItem
        Me.smBuLiang = New System.Windows.Forms.ToolStripMenuItem
        Me.smLiuBan = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.smCunHuo = New System.Windows.Forms.ToolStripMenuItem
        Me.smCunCang = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolWareFaLiao = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolWaiFaASS = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolASSBuNiang = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuCodeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuCodePreView = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuCodeInCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuCodeExport = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuCodeRecord = New System.Windows.Forms.ToolStripMenuItem
        Me.DeltialMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLiuBan = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_InDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_InCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.chkOutProcess = New System.Windows.Forms.CheckBox
        Me.chkBlocProcess = New System.Windows.Forms.CheckBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.ComboPro_Type = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboPro_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1026, 37)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "物料收發管理"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid)
        Me.SplitContainer1.Size = New System.Drawing.Size(1025, 404)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 41
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.twWare)
        Me.SplitContainer2.Size = New System.Drawing.Size(125, 404)
        Me.SplitContainer2.SplitterDistance = 229
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemMRUEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemImageEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemColorEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTrackBar2})
        Me.GridControl2.Size = New System.Drawing.Size(125, 229)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepName, Me.ControlDep})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsPrint.AutoWidth = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'DepName
        '
        Me.DepName.Caption = "部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 0
        Me.DepName.Width = 116
        '
        'ControlDep
        '
        Me.ControlDep.Caption = "部門編號"
        Me.ControlDep.FieldName = "ControlDep"
        Me.ControlDep.Name = "ControlDep"
        Me.ControlDep.Width = 74
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territories", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China, People\'\'s Republic of", "Christmas Island", "Cocos Islands", "Columbia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Cote D\'\'ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "France, Metropolitan", "French Guiana", "French Polynesia", "French Southern Territories", "FYROM", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Island And Mcdonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic Peoples Republic of", "Korea, Republic of", "Kuwait", "Kyrgyzstan", "Lao Peoples Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and The Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and Sandwich Islands", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and JanMayen", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Wallis And Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe", "Guernsey", "Malaga", "Denmark", "Jersey"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("MasterCard", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("AmEx", 4, 3)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemMRUEdit1
        '
        Me.RepositoryItemMRUEdit1.AutoHeight = False
        Me.RepositoryItemMRUEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemMRUEdit1.Items.AddRange(New Object() {"Green", "Blue", "Black", "White"})
        Me.RepositoryItemMRUEdit1.Name = "RepositoryItemMRUEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Male"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Female")})
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.CloseOnOuterMouseClick = False
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        Me.RepositoryItemImageEdit1.PopupStartSize = New System.Drawing.Size(250, 300)
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.PopupStartSize = New System.Drawing.Size(250, 150)
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnName", "Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnDepartment", "Department", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "clnName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.PopupWidth = 290
        Me.RepositoryItemLookUpEdit1.ValueMember = "clnId"
        '
        'RepositoryItemTrackBar2
        '
        Me.RepositoryItemTrackBar2.Name = "RepositoryItemTrackBar2"
        '
        'twWare
        '
        Me.twWare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twWare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twWare.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twWare.FullRowSelect = True
        Me.twWare.HideSelection = False
        Me.twWare.Location = New System.Drawing.Point(0, 0)
        Me.twWare.Name = "twWare"
        TreeNode1.Name = "Node4"
        TreeNode1.Text = "未審核"
        TreeNode2.Name = "Node5"
        TreeNode2.Text = "已審核"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "收入項目"
        TreeNode4.Name = "Node6"
        TreeNode4.Text = "未審核"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "已審核"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "發出項目"
        Me.twWare.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6})
        Me.twWare.Size = New System.Drawing.Size(125, 171)
        Me.twWare.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2})
        Me.Grid.Size = New System.Drawing.Size(896, 404)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCodeInAdd, Me.MenuCodeOutAdd, Me.ToolStripSeparator1, Me.MenuCodeEdit, Me.MenuCodeDel, Me.ToolStripSeparator2, Me.MenuCodePreView, Me.MenuCodeQuery, Me.MenuCodeRef, Me.ToolStripSeparator3, Me.MenuCodeInCheck, Me.MenuCodeCheck, Me.MenuCodeExport, Me.ToolStripMenuItem1, Me.MenuCodeRecord, Me.DeltialMenuItem, Me.ToolStripMenuItem3, Me.ToolStripLiuBan})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(177, 320)
        '
        'MenuCodeInAdd
        '
        Me.MenuCodeInAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smKaiLiao, Me.smJiaCun})
        Me.MenuCodeInAdd.Enabled = False
        Me.MenuCodeInAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.MenuCodeInAdd.Name = "MenuCodeInAdd"
        Me.MenuCodeInAdd.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeInAdd.Text = "收料(&A)"
        '
        'smKaiLiao
        '
        Me.smKaiLiao.Enabled = False
        Me.smKaiLiao.Name = "smKaiLiao"
        Me.smKaiLiao.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.smKaiLiao.Size = New System.Drawing.Size(156, 22)
        Me.smKaiLiao.Text = "開料(&A)..."
        '
        'smJiaCun
        '
        Me.smJiaCun.Enabled = False
        Me.smJiaCun.Name = "smJiaCun"
        Me.smJiaCun.Size = New System.Drawing.Size(156, 22)
        Me.smJiaCun.Text = "加存(&S)..."
        '
        'MenuCodeOutAdd
        '
        Me.MenuCodeOutAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smDaHuo, Me.smChuHuo, Me.smZuhe, Me.smChaiFen, Me.ToolStripSeparator5, Me.smChengPin, Me.ToolStripSeparator7, Me.smFanXiu, Me.smRePairOut, Me.smWaiFa, Me.ToolStripSeparator6, Me.smSunHuai, Me.smDiuShi, Me.smBuLiang, Me.smLiuBan, Me.ToolStripSeparator4, Me.smCunHuo, Me.smCunCang, Me.ToolStripMenuItem2, Me.ToolWareFaLiao, Me.ToolWaiFaASS, Me.ToolASSBuNiang})
        Me.MenuCodeOutAdd.Enabled = False
        Me.MenuCodeOutAdd.Image = Global.LFERP.My.Resources.Resources.OutlineDemoteToBodyText
        Me.MenuCodeOutAdd.Name = "MenuCodeOutAdd"
        Me.MenuCodeOutAdd.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeOutAdd.Text = "發料(&T)"
        '
        'smDaHuo
        '
        Me.smDaHuo.Name = "smDaHuo"
        Me.smDaHuo.Size = New System.Drawing.Size(154, 22)
        Me.smDaHuo.Text = "大貨(&B)..."
        '
        'smChuHuo
        '
        Me.smChuHuo.Name = "smChuHuo"
        Me.smChuHuo.Size = New System.Drawing.Size(154, 22)
        Me.smChuHuo.Text = "完工(&W)..."
        '
        'smZuhe
        '
        Me.smZuhe.Name = "smZuhe"
        Me.smZuhe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.smZuhe.Size = New System.Drawing.Size(154, 22)
        Me.smZuhe.Text = "組合(&Z)..."
        '
        'smChaiFen
        '
        Me.smChaiFen.Name = "smChaiFen"
        Me.smChaiFen.Size = New System.Drawing.Size(154, 22)
        Me.smChaiFen.Text = "拆分(C)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(151, 6)
        '
        'smChengPin
        '
        Me.smChengPin.Name = "smChengPin"
        Me.smChengPin.Size = New System.Drawing.Size(154, 22)
        Me.smChengPin.Text = "成品倉"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(151, 6)
        '
        'smFanXiu
        '
        Me.smFanXiu.Name = "smFanXiu"
        Me.smFanXiu.Size = New System.Drawing.Size(154, 22)
        Me.smFanXiu.Text = "返修(&X)..."
        '
        'smRePairOut
        '
        Me.smRePairOut.Name = "smRePairOut"
        Me.smRePairOut.Size = New System.Drawing.Size(154, 22)
        Me.smRePairOut.Text = "補返修(&F)..."
        '
        'smWaiFa
        '
        Me.smWaiFa.Name = "smWaiFa"
        Me.smWaiFa.Size = New System.Drawing.Size(154, 22)
        Me.smWaiFa.Text = "外發(&I)..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(151, 6)
        '
        'smSunHuai
        '
        Me.smSunHuai.Name = "smSunHuai"
        Me.smSunHuai.Size = New System.Drawing.Size(154, 22)
        Me.smSunHuai.Text = "損壞(&J)..."
        '
        'smDiuShi
        '
        Me.smDiuShi.Name = "smDiuShi"
        Me.smDiuShi.Size = New System.Drawing.Size(154, 22)
        Me.smDiuShi.Text = "丟失(&D)..."
        '
        'smBuLiang
        '
        Me.smBuLiang.Name = "smBuLiang"
        Me.smBuLiang.Size = New System.Drawing.Size(154, 22)
        Me.smBuLiang.Text = "物料不良(&L)..."
        '
        'smLiuBan
        '
        Me.smLiuBan.Name = "smLiuBan"
        Me.smLiuBan.Size = New System.Drawing.Size(154, 22)
        Me.smLiuBan.Text = "留辦(&T)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(151, 6)
        '
        'smCunHuo
        '
        Me.smCunHuo.Name = "smCunHuo"
        Me.smCunHuo.Size = New System.Drawing.Size(154, 22)
        Me.smCunHuo.Text = "存貨(&S)..."
        '
        'smCunCang
        '
        Me.smCunCang.Name = "smCunCang"
        Me.smCunCang.Size = New System.Drawing.Size(154, 22)
        Me.smCunCang.Text = "存倉(&H)..."
        Me.smCunCang.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(151, 6)
        '
        'ToolWareFaLiao
        '
        Me.ToolWareFaLiao.Name = "ToolWareFaLiao"
        Me.ToolWareFaLiao.Size = New System.Drawing.Size(154, 22)
        Me.ToolWareFaLiao.Text = "生產倉發料"
        Me.ToolWareFaLiao.Visible = False
        '
        'ToolWaiFaASS
        '
        Me.ToolWaiFaASS.Name = "ToolWaiFaASS"
        Me.ToolWaiFaASS.Size = New System.Drawing.Size(154, 22)
        Me.ToolWaiFaASS.Text = "外發送裝配"
        Me.ToolWaiFaASS.Visible = False
        '
        'ToolASSBuNiang
        '
        Me.ToolASSBuNiang.Name = "ToolASSBuNiang"
        Me.ToolASSBuNiang.Size = New System.Drawing.Size(154, 22)
        Me.ToolASSBuNiang.Text = "裝配不良"
        Me.ToolASSBuNiang.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'MenuCodeEdit
        '
        Me.MenuCodeEdit.Enabled = False
        Me.MenuCodeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.MenuCodeEdit.Name = "MenuCodeEdit"
        Me.MenuCodeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenuCodeEdit.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeEdit.Text = "修改(&E)..."
        '
        'MenuCodeDel
        '
        Me.MenuCodeDel.Enabled = False
        Me.MenuCodeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.MenuCodeDel.Name = "MenuCodeDel"
        Me.MenuCodeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuCodeDel.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        'MenuCodePreView
        '
        Me.MenuCodePreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.MenuCodePreView.Name = "MenuCodePreView"
        Me.MenuCodePreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuCodePreView.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodePreView.Text = "查看(&W)..."
        '
        'MenuCodeQuery
        '
        Me.MenuCodeQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.MenuCodeQuery.Name = "MenuCodeQuery"
        Me.MenuCodeQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MenuCodeQuery.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeQuery.Text = "查詢(&F)..."
        '
        'MenuCodeRef
        '
        Me.MenuCodeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.MenuCodeRef.Name = "MenuCodeRef"
        Me.MenuCodeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuCodeRef.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(173, 6)
        '
        'MenuCodeInCheck
        '
        Me.MenuCodeInCheck.Enabled = False
        Me.MenuCodeInCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.MenuCodeInCheck.Name = "MenuCodeInCheck"
        Me.MenuCodeInCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuCodeInCheck.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeInCheck.Text = "收料確認(&S)..."
        '
        'MenuCodeCheck
        '
        Me.MenuCodeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.MenuCodeCheck.Name = "MenuCodeCheck"
        Me.MenuCodeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.MenuCodeCheck.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeCheck.Text = "審核(&G)..."
        Me.MenuCodeCheck.Visible = False
        '
        'MenuCodeExport
        '
        Me.MenuCodeExport.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.MenuCodeExport.Name = "MenuCodeExport"
        Me.MenuCodeExport.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeExport.Text = "導出(&U)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'MenuCodeRecord
        '
        Me.MenuCodeRecord.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.MenuCodeRecord.Name = "MenuCodeRecord"
        Me.MenuCodeRecord.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuCodeRecord.Size = New System.Drawing.Size(176, 22)
        Me.MenuCodeRecord.Text = "收發記錄(&P)..."
        '
        'DeltialMenuItem
        '
        Me.DeltialMenuItem.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.DeltialMenuItem.Name = "DeltialMenuItem"
        Me.DeltialMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeltialMenuItem.Text = "收發明細(&M)..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripLiuBan
        '
        Me.ToolStripLiuBan.Name = "ToolStripLiuBan"
        Me.ToolStripLiuBan.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripLiuBan.Text = "留辦記錄表"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FP_NO, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type, Me.Pro_NO, Me.Pro_NO1, Me.FP_OutDep, Me.FP_InDep, Me.FP_Qty, Me.FP_Date, Me.FP_InCheckDate, Me.FP_Remark, Me.FP_Type, Me.FP_OutOK, Me.FP_Detail, Me.FP_OutType, Me.FP_Num, Me.FP_Check, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.AutoID})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'FP_NO
        '
        Me.FP_NO.Caption = "收發單號"
        Me.FP_NO.FieldName = "FP_NO"
        Me.FP_NO.Name = "FP_NO"
        Me.FP_NO.Visible = True
        Me.FP_NO.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "別名"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 2
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類型"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 3
        '
        'Pro_NO
        '
        Me.Pro_NO.Caption = "發料工序"
        Me.Pro_NO.FieldName = "PS_Name"
        Me.Pro_NO.Name = "Pro_NO"
        Me.Pro_NO.Visible = True
        Me.Pro_NO.VisibleIndex = 4
        Me.Pro_NO.Width = 88
        '
        'Pro_NO1
        '
        Me.Pro_NO1.Caption = "收料工序"
        Me.Pro_NO1.FieldName = "PS_Name1"
        Me.Pro_NO1.Name = "Pro_NO1"
        Me.Pro_NO1.Visible = True
        Me.Pro_NO1.VisibleIndex = 5
        Me.Pro_NO1.Width = 82
        '
        'FP_OutDep
        '
        Me.FP_OutDep.Caption = "部門"
        Me.FP_OutDep.FieldName = "DepOutName"
        Me.FP_OutDep.Name = "FP_OutDep"
        Me.FP_OutDep.Visible = True
        Me.FP_OutDep.VisibleIndex = 6
        '
        'FP_InDep
        '
        Me.FP_InDep.Caption = "變更部門"
        Me.FP_InDep.FieldName = "DepInName"
        Me.FP_InDep.Name = "FP_InDep"
        Me.FP_InDep.Visible = True
        Me.FP_InDep.VisibleIndex = 7
        '
        'FP_Qty
        '
        Me.FP_Qty.Caption = "數量"
        Me.FP_Qty.FieldName = "FP_Qty"
        Me.FP_Qty.Name = "FP_Qty"
        Me.FP_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FP_Qty.Visible = True
        Me.FP_Qty.VisibleIndex = 8
        '
        'FP_Date
        '
        Me.FP_Date.Caption = "發料時間"
        Me.FP_Date.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.FP_Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FP_Date.FieldName = "FP_Date"
        Me.FP_Date.Name = "FP_Date"
        Me.FP_Date.Visible = True
        Me.FP_Date.VisibleIndex = 9
        Me.FP_Date.Width = 90
        '
        'FP_InCheckDate
        '
        Me.FP_InCheckDate.Caption = "確認收料時間"
        Me.FP_InCheckDate.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.FP_InCheckDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FP_InCheckDate.FieldName = "FP_InCheckDates"
        Me.FP_InCheckDate.Name = "FP_InCheckDate"
        Me.FP_InCheckDate.Visible = True
        Me.FP_InCheckDate.VisibleIndex = 10
        Me.FP_InCheckDate.Width = 95
        '
        'FP_Remark
        '
        Me.FP_Remark.Caption = "備註"
        Me.FP_Remark.FieldName = "FP_Remark"
        Me.FP_Remark.Name = "FP_Remark"
        Me.FP_Remark.Visible = True
        Me.FP_Remark.VisibleIndex = 13
        '
        'FP_Type
        '
        Me.FP_Type.Caption = "收發類型"
        Me.FP_Type.FieldName = "FP_Type"
        Me.FP_Type.Name = "FP_Type"
        Me.FP_Type.Visible = True
        Me.FP_Type.VisibleIndex = 11
        '
        'FP_OutOK
        '
        Me.FP_OutOK.Caption = "確認發出"
        Me.FP_OutOK.FieldName = "FP_OutOK"
        Me.FP_OutOK.Name = "FP_OutOK"
        Me.FP_OutOK.Visible = True
        Me.FP_OutOK.VisibleIndex = 12
        '
        'FP_Detail
        '
        Me.FP_Detail.Caption = "屬性"
        Me.FP_Detail.FieldName = "PT_Type"
        Me.FP_Detail.Name = "FP_Detail"
        Me.FP_Detail.Visible = True
        Me.FP_Detail.VisibleIndex = 14
        '
        'FP_OutType
        '
        Me.FP_OutType.Caption = "外發類型"
        Me.FP_OutType.FieldName = "FP_OutType"
        Me.FP_OutType.Name = "FP_OutType"
        Me.FP_OutType.Visible = True
        Me.FP_OutType.VisibleIndex = 15
        '
        'FP_Num
        '
        Me.FP_Num.Caption = "流水號"
        Me.FP_Num.FieldName = "FP_Num"
        Me.FP_Num.Name = "FP_Num"
        '
        'FP_Check
        '
        Me.FP_Check.Caption = "審核"
        Me.FP_Check.FieldName = "FP_Check"
        Me.FP_Check.Name = "FP_Check"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "工藝類型"
        Me.GridColumn1.FieldName = "Pro_Type"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "發料員"
        Me.GridColumn2.FieldName = "FP_OutActionName"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "收料確認員"
        Me.GridColumn3.FieldName = "FP_InActionName"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'chkOutProcess
        '
        Me.chkOutProcess.AutoSize = True
        Me.chkOutProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chkOutProcess.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkOutProcess.Location = New System.Drawing.Point(202, 12)
        Me.chkOutProcess.Name = "chkOutProcess"
        Me.chkOutProcess.Size = New System.Drawing.Size(147, 17)
        Me.chkOutProcess.TabIndex = 42
        Me.chkOutProcess.Text = "顯示外發加工記錄(&O)"
        Me.chkOutProcess.UseVisualStyleBackColor = False
        '
        'chkBlocProcess
        '
        Me.chkBlocProcess.AutoSize = True
        Me.chkBlocProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chkBlocProcess.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkBlocProcess.Location = New System.Drawing.Point(375, 12)
        Me.chkBlocProcess.Name = "chkBlocProcess"
        Me.chkBlocProcess.Size = New System.Drawing.Size(168, 17)
        Me.chkBlocProcess.TabIndex = 42
        Me.chkBlocProcess.Text = "顯示集團內部加工記錄(&I)"
        Me.chkBlocProcess.UseVisualStyleBackColor = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(940, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(76, 30)
        Me.SimpleButton1.TabIndex = 43
        Me.SimpleButton1.Text = "SimpleButton1"
        Me.SimpleButton1.Visible = False
        '
        'ComboPro_Type
        '
        Me.ComboPro_Type.Enabled = False
        Me.ComboPro_Type.Location = New System.Drawing.Point(652, 9)
        Me.ComboPro_Type.Name = "ComboPro_Type"
        Me.ComboPro_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboPro_Type.Properties.Appearance.Options.UseFont = True
        Me.ComboPro_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboPro_Type.Properties.Items.AddRange(New Object() {"全部", "生產加工", "裝配出貨", "胚部加工"})
        Me.ComboPro_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboPro_Type.Size = New System.Drawing.Size(120, 22)
        Me.ComboPro_Type.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(562, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "工藝類型(&G)："
        '
        'frmProductionFieldCodeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 445)
        Me.Controls.Add(Me.ComboPro_Type)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.chkOutProcess)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.chkBlocProcess)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionFieldCodeMain"
        Me.Text = "物料收發管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboPro_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_OutDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_InDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuCodeInAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodePreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeInCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCodeCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Pro_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuCodeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents smKaiLiao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smJiaCun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smDaHuo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smFanXiu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smSunHuai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smDiuShi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smBuLiang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smLiuBan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smCunHuo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smCunCang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smChuHuo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents smWaiFa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuCodeExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ControlDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Private WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Private WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Private WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Private WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Private WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Private WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Private WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Private WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Private WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTrackBar2 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents smRePairOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smZuhe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smChaiFen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smChengPin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FP_OutType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkOutProcess As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlocProcess As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeltialMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FP_OutOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FP_InCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuCodeRecord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolWareFaLiao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolWaiFaASS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolASSBuNiang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboPro_Type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLiuBan As System.Windows.Forms.ToolStripMenuItem
End Class
