<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleStorage
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridControl = New DevExpress.XtraGrid.GridControl
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
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridMain = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmRefash = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmPrintTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colaCheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaDeptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCode_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSS_ShelveID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSS_StorageLocation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaSE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ColaCreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColaCheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaAutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaCreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridChild = New DevExpress.XtraGrid.GridControl
        Me.ViewChild = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColbD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbDeptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbCode_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbSS_ShelveID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbSS_StorageLocation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbCreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbCreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ColbOperate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbAutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbOperateType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbCreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 632)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1269, 579)
        Me.SplitContainer1.SplitterDistance = 123
        Me.SplitContainer1.TabIndex = 89
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView2
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemMRUEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemImageEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemColorEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTrackBar2})
        Me.GridControl.Size = New System.Drawing.Size(123, 579)
        Me.GridControl.TabIndex = 2
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepName, Me.ControlDep})
        Me.GridView2.GridControl = Me.GridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsPrint.AutoWidth = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
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
        Me.RepositoryItemMRUEdit1.Items.AddRange(New Object() {"White", "Black", "Blue", "Green"})
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
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
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
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridMain)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1142, 579)
        Me.SplitContainer2.SplitterDistance = 289
        Me.SplitContainer2.TabIndex = 89
        '
        'GridMain
        '
        Me.GridMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMain.EmbeddedNavigator.Name = ""
        Me.GridMain.Location = New System.Drawing.Point(0, 0)
        Me.GridMain.MainView = Me.ViewMain
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2})
        Me.GridMain.Size = New System.Drawing.Size(1142, 289)
        Me.GridMain.TabIndex = 88
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewMain})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdd, Me.tsmEdit, Me.tsmDelete, Me.tsmSelect, Me.tsmRefash, Me.tsmView, Me.ToolStripSeparator1, Me.tsmCheck, Me.tsmPrintTotal, Me.tsmPrint, Me.tsmExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 230)
        '
        'tsmAdd
        '
        Me.tsmAdd.Enabled = False
        Me.tsmAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.tsmAdd.Name = "tsmAdd"
        Me.tsmAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmAdd.Size = New System.Drawing.Size(184, 22)
        Me.tsmAdd.Text = "装箱新增(&A)"
        '
        'tsmEdit
        '
        Me.tsmEdit.Enabled = False
        Me.tsmEdit.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmEdit.Size = New System.Drawing.Size(184, 22)
        Me.tsmEdit.Text = "修改(&E)"
        '
        'tsmDelete
        '
        Me.tsmDelete.Enabled = False
        Me.tsmDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(184, 22)
        Me.tsmDelete.Text = "删除(&D)"
        '
        'tsmSelect
        '
        Me.tsmSelect.Image = Global.LFERP.My.Resources.Resources.chinaz14
        Me.tsmSelect.Name = "tsmSelect"
        Me.tsmSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmSelect.Size = New System.Drawing.Size(184, 22)
        Me.tsmSelect.Text = "查询(&S)"
        Me.tsmSelect.Visible = False
        '
        'tsmRefash
        '
        Me.tsmRefash.Image = Global.LFERP.My.Resources.Resources.GroupAppointmentOptions
        Me.tsmRefash.Name = "tsmRefash"
        Me.tsmRefash.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmRefash.Size = New System.Drawing.Size(184, 22)
        Me.tsmRefash.Text = "刷新(&R)"
        '
        'tsmView
        '
        Me.tsmView.Image = Global.LFERP.My.Resources.Resources.BlogPublishMenu
        Me.tsmView.Name = "tsmView"
        Me.tsmView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.tsmView.Size = New System.Drawing.Size(184, 22)
        Me.tsmView.Text = "查看(&V)"
        Me.tsmView.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'tsmCheck
        '
        Me.tsmCheck.Enabled = False
        Me.tsmCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.tsmCheck.Name = "tsmCheck"
        Me.tsmCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmCheck.Size = New System.Drawing.Size(184, 22)
        Me.tsmCheck.Text = "审核(&C)"
        Me.tsmCheck.Visible = False
        '
        'tsmPrintTotal
        '
        Me.tsmPrintTotal.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsmPrintTotal.Name = "tsmPrintTotal"
        Me.tsmPrintTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.tsmPrintTotal.Size = New System.Drawing.Size(184, 22)
        Me.tsmPrintTotal.Text = "打印汇总(&T)"
        '
        'tsmPrint
        '
        Me.tsmPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.tsmPrint.Name = "tsmPrint"
        Me.tsmPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPrint.Size = New System.Drawing.Size(184, 22)
        Me.tsmPrint.Text = "打印明细(&P)"
        '
        'tsmExcel
        '
        Me.tsmExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.tsmExcel.Name = "tsmExcel"
        Me.tsmExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tsmExcel.Size = New System.Drawing.Size(184, 22)
        Me.tsmExcel.Text = "Excel(&X)"
        '
        'ViewMain
        '
        Me.ViewMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colaCheckBit, Me.colaD_ID, Me.ColaDeptName, Me.colaCode_ID, Me.ColaSO_SampleID, Me.ColaPM_M_Code, Me.colaSS_ShelveID, Me.colaSS_StorageLocation, Me.ColaSE_ID, Me.colaRemark, Me.ColaCreateUserName, Me.colaCreateDate, Me.ColaModifyUserName, Me.colaModifyDate, Me.ColaCheckUserName, Me.colaCheckDate, Me.colaCheckRemark, Me.colaCheckUserID, Me.colaAutoID, Me.colaModifyUserID, Me.colaCreateUserID})
        Me.ViewMain.GridControl = Me.GridMain
        Me.ViewMain.Name = "ViewMain"
        Me.ViewMain.OptionsCustomization.AllowColumnMoving = False
        Me.ViewMain.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ViewMain.OptionsSelection.UseIndicatorForSelection = False
        Me.ViewMain.OptionsView.ColumnAutoWidth = False
        Me.ViewMain.OptionsView.ShowAutoFilterRow = True
        Me.ViewMain.OptionsView.ShowGroupPanel = False
        '
        'colaCheckBit
        '
        Me.colaCheckBit.Caption = "审核"
        Me.colaCheckBit.FieldName = "CheckBit"
        Me.colaCheckBit.Name = "colaCheckBit"
        Me.colaCheckBit.OptionsColumn.AllowEdit = False
        Me.colaCheckBit.OptionsColumn.ReadOnly = True
        Me.colaCheckBit.Width = 100
        '
        'colaD_ID
        '
        Me.colaD_ID.Caption = "部门编码"
        Me.colaD_ID.FieldName = "D_ID"
        Me.colaD_ID.Name = "colaD_ID"
        Me.colaD_ID.OptionsColumn.AllowEdit = False
        Me.colaD_ID.OptionsColumn.ReadOnly = True
        Me.colaD_ID.Width = 100
        '
        'ColaDeptName
        '
        Me.ColaDeptName.Caption = "部门"
        Me.ColaDeptName.FieldName = "DepName"
        Me.ColaDeptName.Name = "ColaDeptName"
        Me.ColaDeptName.OptionsColumn.AllowEdit = False
        Me.ColaDeptName.OptionsColumn.ReadOnly = True
        Me.ColaDeptName.Visible = True
        Me.ColaDeptName.VisibleIndex = 0
        Me.ColaDeptName.Width = 59
        '
        'colaCode_ID
        '
        Me.colaCode_ID.Caption = "条码"
        Me.colaCode_ID.FieldName = "Code_ID"
        Me.colaCode_ID.Name = "colaCode_ID"
        Me.colaCode_ID.OptionsColumn.AllowEdit = False
        Me.colaCode_ID.OptionsColumn.ReadOnly = True
        Me.colaCode_ID.Visible = True
        Me.colaCode_ID.VisibleIndex = 1
        Me.colaCode_ID.Width = 133
        '
        'ColaSO_SampleID
        '
        Me.ColaSO_SampleID.Caption = "样板单号"
        Me.ColaSO_SampleID.FieldName = "SO_SampleID"
        Me.ColaSO_SampleID.Name = "ColaSO_SampleID"
        Me.ColaSO_SampleID.OptionsColumn.AllowEdit = False
        Me.ColaSO_SampleID.OptionsColumn.ReadOnly = True
        Me.ColaSO_SampleID.Visible = True
        Me.ColaSO_SampleID.VisibleIndex = 2
        Me.ColaSO_SampleID.Width = 81
        '
        'ColaPM_M_Code
        '
        Me.ColaPM_M_Code.Caption = "产品编号"
        Me.ColaPM_M_Code.FieldName = "PM_M_Code"
        Me.ColaPM_M_Code.Name = "ColaPM_M_Code"
        Me.ColaPM_M_Code.OptionsColumn.AllowEdit = False
        Me.ColaPM_M_Code.OptionsColumn.ReadOnly = True
        Me.ColaPM_M_Code.Visible = True
        Me.ColaPM_M_Code.VisibleIndex = 3
        Me.ColaPM_M_Code.Width = 99
        '
        'colaSS_ShelveID
        '
        Me.colaSS_ShelveID.Caption = "货架编号"
        Me.colaSS_ShelveID.FieldName = "SS_ShelveID"
        Me.colaSS_ShelveID.Name = "colaSS_ShelveID"
        Me.colaSS_ShelveID.OptionsColumn.AllowEdit = False
        Me.colaSS_ShelveID.OptionsColumn.ReadOnly = True
        Me.colaSS_ShelveID.Visible = True
        Me.colaSS_ShelveID.VisibleIndex = 4
        Me.colaSS_ShelveID.Width = 100
        '
        'colaSS_StorageLocation
        '
        Me.colaSS_StorageLocation.Caption = "储存区域"
        Me.colaSS_StorageLocation.FieldName = "SS_StorageLocation"
        Me.colaSS_StorageLocation.Name = "colaSS_StorageLocation"
        Me.colaSS_StorageLocation.OptionsColumn.AllowEdit = False
        Me.colaSS_StorageLocation.OptionsColumn.ReadOnly = True
        Me.colaSS_StorageLocation.Visible = True
        Me.colaSS_StorageLocation.VisibleIndex = 5
        Me.colaSS_StorageLocation.Width = 100
        '
        'ColaSE_ID
        '
        Me.ColaSE_ID.Caption = "单号"
        Me.ColaSE_ID.FieldName = "SE_ID"
        Me.ColaSE_ID.Name = "ColaSE_ID"
        Me.ColaSE_ID.OptionsColumn.AllowEdit = False
        Me.ColaSE_ID.OptionsColumn.ReadOnly = True
        Me.ColaSE_ID.Width = 100
        '
        'colaRemark
        '
        Me.colaRemark.Caption = "备注"
        Me.colaRemark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.colaRemark.FieldName = "Remark"
        Me.colaRemark.Name = "colaRemark"
        Me.colaRemark.OptionsColumn.ReadOnly = True
        Me.colaRemark.Visible = True
        Me.colaRemark.VisibleIndex = 8
        Me.colaRemark.Width = 132
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'ColaCreateUserName
        '
        Me.ColaCreateUserName.Caption = "创建人员"
        Me.ColaCreateUserName.FieldName = "CreateUserName"
        Me.ColaCreateUserName.Name = "ColaCreateUserName"
        Me.ColaCreateUserName.OptionsColumn.AllowEdit = False
        Me.ColaCreateUserName.OptionsColumn.ReadOnly = True
        Me.ColaCreateUserName.Visible = True
        Me.ColaCreateUserName.VisibleIndex = 6
        '
        'colaCreateDate
        '
        Me.colaCreateDate.Caption = "创建时间"
        Me.colaCreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.colaCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colaCreateDate.FieldName = "CreateDate"
        Me.colaCreateDate.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.colaCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colaCreateDate.Name = "colaCreateDate"
        Me.colaCreateDate.OptionsColumn.AllowEdit = False
        Me.colaCreateDate.OptionsColumn.ReadOnly = True
        Me.colaCreateDate.Visible = True
        Me.colaCreateDate.VisibleIndex = 7
        Me.colaCreateDate.Width = 78
        '
        'ColaModifyUserName
        '
        Me.ColaModifyUserName.Caption = "修改人员"
        Me.ColaModifyUserName.FieldName = "ModifyUserName"
        Me.ColaModifyUserName.Name = "ColaModifyUserName"
        Me.ColaModifyUserName.OptionsColumn.AllowEdit = False
        Me.ColaModifyUserName.OptionsColumn.ReadOnly = True
        Me.ColaModifyUserName.Width = 100
        '
        'colaModifyDate
        '
        Me.colaModifyDate.Caption = "修改时间"
        Me.colaModifyDate.FieldName = "ModifyDate"
        Me.colaModifyDate.Name = "colaModifyDate"
        Me.colaModifyDate.OptionsColumn.AllowEdit = False
        Me.colaModifyDate.OptionsColumn.ReadOnly = True
        Me.colaModifyDate.Width = 100
        '
        'ColaCheckUserName
        '
        Me.ColaCheckUserName.Caption = "审核人员"
        Me.ColaCheckUserName.FieldName = "CheckUserName"
        Me.ColaCheckUserName.Name = "ColaCheckUserName"
        Me.ColaCheckUserName.OptionsColumn.AllowEdit = False
        Me.ColaCheckUserName.OptionsColumn.ReadOnly = True
        Me.ColaCheckUserName.Width = 100
        '
        'colaCheckDate
        '
        Me.colaCheckDate.Caption = "审核时间"
        Me.colaCheckDate.FieldName = "CheckDate"
        Me.colaCheckDate.Name = "colaCheckDate"
        Me.colaCheckDate.OptionsColumn.AllowEdit = False
        Me.colaCheckDate.OptionsColumn.ReadOnly = True
        Me.colaCheckDate.Width = 100
        '
        'colaCheckRemark
        '
        Me.colaCheckRemark.Caption = "审核备注"
        Me.colaCheckRemark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.colaCheckRemark.FieldName = "CheckRemark"
        Me.colaCheckRemark.Name = "colaCheckRemark"
        Me.colaCheckRemark.OptionsColumn.ReadOnly = True
        Me.colaCheckRemark.Width = 100
        '
        'colaCheckUserID
        '
        Me.colaCheckUserID.Caption = "审核人"
        Me.colaCheckUserID.FieldName = "CheckUserID"
        Me.colaCheckUserID.Name = "colaCheckUserID"
        Me.colaCheckUserID.OptionsColumn.AllowEdit = False
        Me.colaCheckUserID.OptionsColumn.ReadOnly = True
        Me.colaCheckUserID.Width = 100
        '
        'colaAutoID
        '
        Me.colaAutoID.Caption = "自动编码"
        Me.colaAutoID.FieldName = "AutoID"
        Me.colaAutoID.Name = "colaAutoID"
        Me.colaAutoID.OptionsColumn.AllowEdit = False
        Me.colaAutoID.OptionsColumn.ReadOnly = True
        Me.colaAutoID.Width = 100
        '
        'colaModifyUserID
        '
        Me.colaModifyUserID.Caption = "修改人"
        Me.colaModifyUserID.FieldName = "ModifyUserID"
        Me.colaModifyUserID.Name = "colaModifyUserID"
        Me.colaModifyUserID.OptionsColumn.AllowEdit = False
        Me.colaModifyUserID.OptionsColumn.ReadOnly = True
        Me.colaModifyUserID.Width = 100
        '
        'colaCreateUserID
        '
        Me.colaCreateUserID.Caption = "创建人"
        Me.colaCreateUserID.FieldName = "CreateUserID"
        Me.colaCreateUserID.Name = "colaCreateUserID"
        Me.colaCreateUserID.OptionsColumn.AllowEdit = False
        Me.colaCreateUserID.OptionsColumn.ReadOnly = True
        Me.colaCreateUserID.Width = 100
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1142, 286)
        Me.XtraTabControl1.TabIndex = 90
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridChild)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1133, 254)
        Me.XtraTabPage1.Text = "条码日志记录"
        '
        'GridChild
        '
        Me.GridChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridChild.EmbeddedNavigator.Name = ""
        Me.GridChild.Location = New System.Drawing.Point(0, 0)
        Me.GridChild.MainView = Me.ViewChild
        Me.GridChild.Name = "GridChild"
        Me.GridChild.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit3})
        Me.GridChild.Size = New System.Drawing.Size(1133, 254)
        Me.GridChild.TabIndex = 90
        Me.GridChild.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewChild})
        '
        'ViewChild
        '
        Me.ViewChild.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColbD_ID, Me.ColbDeptName, Me.ColbCode_ID, Me.ColbSS_ShelveID, Me.ColbSS_StorageLocation, Me.ColbCreateUserName, Me.ColbCreateDate, Me.ColbRemark, Me.ColbOperate, Me.ColbAutoID, Me.ColbOperateType, Me.ColbCreateUserID})
        Me.ViewChild.GridControl = Me.GridChild
        Me.ViewChild.Name = "ViewChild"
        Me.ViewChild.OptionsBehavior.Editable = False
        Me.ViewChild.OptionsCustomization.AllowColumnMoving = False
        Me.ViewChild.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ViewChild.OptionsSelection.UseIndicatorForSelection = False
        Me.ViewChild.OptionsView.ColumnAutoWidth = False
        Me.ViewChild.OptionsView.ShowAutoFilterRow = True
        Me.ViewChild.OptionsView.ShowGroupPanel = False
        '
        'ColbD_ID
        '
        Me.ColbD_ID.Caption = "部门编码"
        Me.ColbD_ID.FieldName = "D_ID"
        Me.ColbD_ID.Name = "ColbD_ID"
        Me.ColbD_ID.OptionsColumn.AllowEdit = False
        Me.ColbD_ID.OptionsColumn.ReadOnly = True
        Me.ColbD_ID.Width = 100
        '
        'ColbDeptName
        '
        Me.ColbDeptName.Caption = "部门"
        Me.ColbDeptName.FieldName = "DepName"
        Me.ColbDeptName.Name = "ColbDeptName"
        Me.ColbDeptName.OptionsColumn.AllowEdit = False
        Me.ColbDeptName.OptionsColumn.ReadOnly = True
        Me.ColbDeptName.Visible = True
        Me.ColbDeptName.VisibleIndex = 0
        Me.ColbDeptName.Width = 100
        '
        'ColbCode_ID
        '
        Me.ColbCode_ID.Caption = "条码"
        Me.ColbCode_ID.FieldName = "Code_ID"
        Me.ColbCode_ID.Name = "ColbCode_ID"
        Me.ColbCode_ID.OptionsColumn.AllowEdit = False
        Me.ColbCode_ID.OptionsColumn.ReadOnly = True
        Me.ColbCode_ID.Visible = True
        Me.ColbCode_ID.VisibleIndex = 1
        Me.ColbCode_ID.Width = 100
        '
        'ColbSS_ShelveID
        '
        Me.ColbSS_ShelveID.Caption = "货架编号"
        Me.ColbSS_ShelveID.FieldName = "SS_ShelveID"
        Me.ColbSS_ShelveID.Name = "ColbSS_ShelveID"
        Me.ColbSS_ShelveID.OptionsColumn.AllowEdit = False
        Me.ColbSS_ShelveID.OptionsColumn.ReadOnly = True
        Me.ColbSS_ShelveID.Visible = True
        Me.ColbSS_ShelveID.VisibleIndex = 2
        Me.ColbSS_ShelveID.Width = 100
        '
        'ColbSS_StorageLocation
        '
        Me.ColbSS_StorageLocation.Caption = "储存区域"
        Me.ColbSS_StorageLocation.FieldName = "SS_StorageLocation"
        Me.ColbSS_StorageLocation.Name = "ColbSS_StorageLocation"
        Me.ColbSS_StorageLocation.OptionsColumn.AllowEdit = False
        Me.ColbSS_StorageLocation.OptionsColumn.ReadOnly = True
        Me.ColbSS_StorageLocation.Visible = True
        Me.ColbSS_StorageLocation.VisibleIndex = 3
        Me.ColbSS_StorageLocation.Width = 100
        '
        'ColbCreateUserName
        '
        Me.ColbCreateUserName.Caption = "创建人员"
        Me.ColbCreateUserName.FieldName = "CreateUserName"
        Me.ColbCreateUserName.Name = "ColbCreateUserName"
        Me.ColbCreateUserName.OptionsColumn.AllowEdit = False
        Me.ColbCreateUserName.OptionsColumn.ReadOnly = True
        Me.ColbCreateUserName.Visible = True
        Me.ColbCreateUserName.VisibleIndex = 4
        Me.ColbCreateUserName.Width = 100
        '
        'ColbCreateDate
        '
        Me.ColbCreateDate.Caption = "创建时间"
        Me.ColbCreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.ColbCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColbCreateDate.FieldName = "CreateDate"
        Me.ColbCreateDate.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.ColbCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColbCreateDate.Name = "ColbCreateDate"
        Me.ColbCreateDate.OptionsColumn.AllowEdit = False
        Me.ColbCreateDate.OptionsColumn.ReadOnly = True
        Me.ColbCreateDate.Visible = True
        Me.ColbCreateDate.VisibleIndex = 6
        Me.ColbCreateDate.Width = 100
        '
        'ColbRemark
        '
        Me.ColbRemark.Caption = "备注"
        Me.ColbRemark.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.ColbRemark.FieldName = "Remark"
        Me.ColbRemark.Name = "ColbRemark"
        Me.ColbRemark.OptionsColumn.ReadOnly = True
        Me.ColbRemark.Visible = True
        Me.ColbRemark.VisibleIndex = 5
        Me.ColbRemark.Width = 127
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'ColbOperate
        '
        Me.ColbOperate.Caption = "操作类型"
        Me.ColbOperate.FieldName = "Operate"
        Me.ColbOperate.Name = "ColbOperate"
        Me.ColbOperate.OptionsColumn.AllowEdit = False
        Me.ColbOperate.OptionsColumn.ReadOnly = True
        Me.ColbOperate.Visible = True
        Me.ColbOperate.VisibleIndex = 7
        Me.ColbOperate.Width = 100
        '
        'ColbAutoID
        '
        Me.ColbAutoID.Caption = "自动编码"
        Me.ColbAutoID.FieldName = "AutoID"
        Me.ColbAutoID.Name = "ColbAutoID"
        Me.ColbAutoID.OptionsColumn.AllowEdit = False
        Me.ColbAutoID.OptionsColumn.ReadOnly = True
        Me.ColbAutoID.Width = 100
        '
        'ColbOperateType
        '
        Me.ColbOperateType.Caption = "操作"
        Me.ColbOperateType.FieldName = "OperateType"
        Me.ColbOperateType.Name = "ColbOperateType"
        Me.ColbOperateType.OptionsColumn.AllowEdit = False
        Me.ColbOperateType.OptionsColumn.ReadOnly = True
        Me.ColbOperateType.Width = 100
        '
        'ColbCreateUserID
        '
        Me.ColbCreateUserID.Caption = "创建人"
        Me.ColbCreateUserID.FieldName = "CreateUserID"
        Me.ColbCreateUserID.Name = "ColbCreateUserID"
        Me.ColbCreateUserID.OptionsColumn.AllowEdit = False
        Me.ColbCreateUserID.OptionsColumn.ReadOnly = True
        Me.ColbCreateUserID.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "货架信息"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1269, 32)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "TreeListColumn1"
        Me.TreeListColumn1.FieldName = "TreeListColumn1"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'frmSampleStorage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 632)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSampleStorage"
        Me.Text = "货架信息"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colaAutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCode_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaSS_StorageLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaSS_ShelveID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaCheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRefash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColaCreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColaModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColaCheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColaDeptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ControlDep As DevExpress.XtraGrid.Columns.GridColumn
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
    Private WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Private WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTrackBar2 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ColaSE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColaSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents tsmAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmPrintTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridChild As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewChild As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColbD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbDeptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbCode_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbSS_ShelveID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbSS_StorageLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbCreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ColbOperate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbAutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbOperateType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbCreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColaPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
End Class
