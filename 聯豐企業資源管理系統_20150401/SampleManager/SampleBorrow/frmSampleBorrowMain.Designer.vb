<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleBorrowMain
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
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsBorrow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsBorrowAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRepay = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBorrowView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBorrowCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBorrowExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.viewWareInventory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colaAutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaMaterialTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemPceMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.colaD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSWI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaBorrow_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.colaRepayQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaNoBorrow_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaAvailableQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItempceCurrency = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.cmsRepaySub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdPrintBorrow = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdViewSub = New System.Windows.Forms.ToolStripMenuItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.viewBorrow = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.grid3 = New DevExpress.XtraGrid.GridControl
        Me.viewRepay = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepayID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OutDeptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InDeptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid4 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemPopupContainerEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
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
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsBorrow.SuspendLayout()
        CType(Me.viewWareInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItempceCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.cmsRepaySub.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewRepay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 667)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1241, 633)
        Me.SplitContainer2.SplitterDistance = 117
        Me.SplitContainer2.TabIndex = 9
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
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemMRUEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemImageEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemColorEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTrackBar2})
        Me.GridControl2.Size = New System.Drawing.Size(117, 633)
        Me.GridControl2.TabIndex = 1
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 633)
        Me.SplitContainer1.SplitterDistance = 339
        Me.SplitContainer1.TabIndex = 9
        '
        'grid1
        '
        Me.grid1.ContextMenuStrip = Me.cmsBorrow
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EmbeddedNavigator.Name = ""
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.MainView = Me.viewWareInventory
        Me.grid1.Name = "grid1"
        Me.grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemPceMaterial, Me.ItempceCurrency, Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1})
        Me.grid1.Size = New System.Drawing.Size(1120, 339)
        Me.grid1.TabIndex = 245
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewWareInventory})
        '
        'cmsBorrow
        '
        Me.cmsBorrow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsBorrowAdd, Me.cmdRepay, Me.cmsBorrowEdit, Me.cmsBorrowDel, Me.ToolStripMenuItem1, Me.cmsBorrowView, Me.cmsBorrowSelect, Me.cmsBorrowRefresh, Me.ToolStripMenuItem2, Me.cmsBorrowCheck, Me.cmsBorrowPrint, Me.cmsPrint, Me.cmsBorrowExcel})
        Me.cmsBorrow.Name = "cmsMRP"
        Me.cmsBorrow.Size = New System.Drawing.Size(210, 258)
        '
        'cmsBorrowAdd
        '
        Me.cmsBorrowAdd.Enabled = False
        Me.cmsBorrowAdd.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.cmsBorrowAdd.Name = "cmsBorrowAdd"
        Me.cmsBorrowAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.cmsBorrowAdd.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowAdd.Text = "生产领料(&B)"
        '
        'cmdRepay
        '
        Me.cmdRepay.Enabled = False
        Me.cmdRepay.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.cmdRepay.Name = "cmdRepay"
        Me.cmdRepay.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdRepay.Size = New System.Drawing.Size(209, 22)
        Me.cmdRepay.Text = "生产还料(&T)"
        '
        'cmsBorrowEdit
        '
        Me.cmsBorrowEdit.Enabled = False
        Me.cmsBorrowEdit.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.cmsBorrowEdit.Name = "cmsBorrowEdit"
        Me.cmsBorrowEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.cmsBorrowEdit.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowEdit.Text = "修改(&U)"
        Me.cmsBorrowEdit.Visible = False
        '
        'cmsBorrowDel
        '
        Me.cmsBorrowDel.Enabled = False
        Me.cmsBorrowDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsBorrowDel.Name = "cmsBorrowDel"
        Me.cmsBorrowDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsBorrowDel.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowDel.Text = "刪除(&D)"
        Me.cmsBorrowDel.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 6)
        '
        'cmsBorrowView
        '
        Me.cmsBorrowView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsBorrowView.Name = "cmsBorrowView"
        Me.cmsBorrowView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.cmsBorrowView.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowView.Text = "查看(&V)"
        Me.cmsBorrowView.Visible = False
        '
        'cmsBorrowSelect
        '
        Me.cmsBorrowSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsBorrowSelect.Name = "cmsBorrowSelect"
        Me.cmsBorrowSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmsBorrowSelect.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowSelect.Text = "查询(&S)"
        Me.cmsBorrowSelect.Visible = False
        '
        'cmsBorrowRefresh
        '
        Me.cmsBorrowRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsBorrowRefresh.Name = "cmsBorrowRefresh"
        Me.cmsBorrowRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsBorrowRefresh.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowRefresh.Text = "刷新(&R)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 6)
        '
        'cmsBorrowCheck
        '
        Me.cmsBorrowCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsBorrowCheck.Name = "cmsBorrowCheck"
        Me.cmsBorrowCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsBorrowCheck.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowCheck.Text = "审核/取消审核(&F)"
        Me.cmsBorrowCheck.Visible = False
        '
        'cmsBorrowPrint
        '
        Me.cmsBorrowPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsBorrowPrint.Name = "cmsBorrowPrint"
        Me.cmsBorrowPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsBorrowPrint.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowPrint.Text = "列印(&P)"
        '
        'cmsPrint
        '
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.Size = New System.Drawing.Size(209, 22)
        Me.cmsPrint.Text = "列印汇总"
        Me.cmsPrint.Visible = False
        '
        'cmsBorrowExcel
        '
        Me.cmsBorrowExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmsBorrowExcel.Name = "cmsBorrowExcel"
        Me.cmsBorrowExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsBorrowExcel.Size = New System.Drawing.Size(209, 22)
        Me.cmsBorrowExcel.Text = "Excel(&E)"
        '
        'viewWareInventory
        '
        Me.viewWareInventory.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.viewWareInventory.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.viewWareInventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colaAutoID, Me.colaSO_ID, Me.colaSO_SampleID, Me.colaMaterialTypeName, Me.colaPM_M_Code, Me.colaD_Dep, Me.colaPS_Name, Me.colaSWI_Qty, Me.colaBorrow_Qty, Me.colaRepayQty, Me.colaNoBorrow_Qty, Me.colaAvailableQty, Me.colaPS_NO, Me.colaD_ID})
        Me.viewWareInventory.GridControl = Me.grid1
        Me.viewWareInventory.Name = "viewWareInventory"
        Me.viewWareInventory.OptionsBehavior.Editable = False
        Me.viewWareInventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewWareInventory.OptionsView.ColumnAutoWidth = False
        Me.viewWareInventory.OptionsView.ShowAutoFilterRow = True
        Me.viewWareInventory.OptionsView.ShowFooter = True
        Me.viewWareInventory.OptionsView.ShowGroupPanel = False
        '
        'colaAutoID
        '
        Me.colaAutoID.Caption = "自动ID"
        Me.colaAutoID.FieldName = "AutoID"
        Me.colaAutoID.Name = "colaAutoID"
        '
        'colaSO_ID
        '
        Me.colaSO_ID.Caption = "订单编号"
        Me.colaSO_ID.FieldName = "SO_ID"
        Me.colaSO_ID.Name = "colaSO_ID"
        '
        'colaSO_SampleID
        '
        Me.colaSO_SampleID.Caption = "样办单号"
        Me.colaSO_SampleID.FieldName = "SO_SampleID"
        Me.colaSO_SampleID.Name = "colaSO_SampleID"
        Me.colaSO_SampleID.Visible = True
        Me.colaSO_SampleID.VisibleIndex = 0
        '
        'colaMaterialTypeName
        '
        Me.colaMaterialTypeName.Caption = "材料"
        Me.colaMaterialTypeName.FieldName = "MaterialTypeName"
        Me.colaMaterialTypeName.Name = "colaMaterialTypeName"
        Me.colaMaterialTypeName.Visible = True
        Me.colaMaterialTypeName.VisibleIndex = 1
        Me.colaMaterialTypeName.Width = 98
        '
        'colaPM_M_Code
        '
        Me.colaPM_M_Code.Caption = "产品编号"
        Me.colaPM_M_Code.ColumnEdit = Me.ItemPceMaterial
        Me.colaPM_M_Code.FieldName = "PM_M_Code"
        Me.colaPM_M_Code.Name = "colaPM_M_Code"
        Me.colaPM_M_Code.Visible = True
        Me.colaPM_M_Code.VisibleIndex = 2
        Me.colaPM_M_Code.Width = 143
        '
        'ItemPceMaterial
        '
        Me.ItemPceMaterial.AutoHeight = False
        Me.ItemPceMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemPceMaterial.Name = "ItemPceMaterial"
        '
        'colaD_Dep
        '
        Me.colaD_Dep.Caption = "部门"
        Me.colaD_Dep.FieldName = "D_Dep"
        Me.colaD_Dep.Name = "colaD_Dep"
        Me.colaD_Dep.Visible = True
        Me.colaD_Dep.VisibleIndex = 3
        Me.colaD_Dep.Width = 73
        '
        'colaPS_Name
        '
        Me.colaPS_Name.Caption = "工序名称"
        Me.colaPS_Name.FieldName = "PS_Name"
        Me.colaPS_Name.Name = "colaPS_Name"
        Me.colaPS_Name.Visible = True
        Me.colaPS_Name.VisibleIndex = 4
        '
        'colaSWI_Qty
        '
        Me.colaSWI_Qty.Caption = "库存数量"
        Me.colaSWI_Qty.FieldName = "SWI_Qty"
        Me.colaSWI_Qty.Name = "colaSWI_Qty"
        Me.colaSWI_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.colaSWI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaSWI_Qty.Visible = True
        Me.colaSWI_Qty.VisibleIndex = 5
        '
        'colaBorrow_Qty
        '
        Me.colaBorrow_Qty.Caption = "领料数量"
        Me.colaBorrow_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colaBorrow_Qty.FieldName = "Borrow_Qty"
        Me.colaBorrow_Qty.Name = "colaBorrow_Qty"
        Me.colaBorrow_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.colaBorrow_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min
        Me.colaBorrow_Qty.Visible = True
        Me.colaBorrow_Qty.VisibleIndex = 6
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'colaRepayQty
        '
        Me.colaRepayQty.Caption = "还料数量"
        Me.colaRepayQty.FieldName = "RepayQty"
        Me.colaRepayQty.Name = "colaRepayQty"
        Me.colaRepayQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaRepayQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaRepayQty.Visible = True
        Me.colaRepayQty.VisibleIndex = 7
        Me.colaRepayQty.Width = 98
        '
        'colaNoBorrow_Qty
        '
        Me.colaNoBorrow_Qty.Caption = "末还数量"
        Me.colaNoBorrow_Qty.FieldName = "NoBorrow_Qty"
        Me.colaNoBorrow_Qty.Name = "colaNoBorrow_Qty"
        Me.colaNoBorrow_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.colaNoBorrow_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaNoBorrow_Qty.Visible = True
        Me.colaNoBorrow_Qty.VisibleIndex = 8
        '
        'colaAvailableQty
        '
        Me.colaAvailableQty.Caption = "可领数量"
        Me.colaAvailableQty.FieldName = "AvailableQty"
        Me.colaAvailableQty.Name = "colaAvailableQty"
        Me.colaAvailableQty.SummaryItem.DisplayFormat = "{0}"
        Me.colaAvailableQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colaAvailableQty.Visible = True
        Me.colaAvailableQty.VisibleIndex = 9
        '
        'colaPS_NO
        '
        Me.colaPS_NO.Caption = "工序"
        Me.colaPS_NO.FieldName = "PS_NO"
        Me.colaPS_NO.Name = "colaPS_NO"
        Me.colaPS_NO.SummaryItem.DisplayFormat = "合计"""
        Me.colaPS_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        '
        'colaD_ID
        '
        Me.colaD_ID.Caption = "部门"
        Me.colaD_ID.FieldName = "D_ID"
        Me.colaD_ID.Name = "colaD_ID"
        '
        'ItempceCurrency
        '
        Me.ItempceCurrency.AutoHeight = False
        Me.ItempceCurrency.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItempceCurrency.Name = "ItempceCurrency"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.ContextMenuStrip = Me.cmsRepaySub
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1120, 290)
        Me.XtraTabControl1.TabIndex = 243
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1, Me.XtraTabPage3})
        '
        'cmsRepaySub
        '
        Me.cmsRepaySub.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrintBorrow, Me.cmdViewSub})
        Me.cmsRepaySub.Name = "cmsRepaySub"
        Me.cmsRepaySub.Size = New System.Drawing.Size(216, 48)
        '
        'cmdPrintBorrow
        '
        Me.cmdPrintBorrow.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintBorrow.Name = "cmdPrintBorrow"
        Me.cmdPrintBorrow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrintBorrow.Size = New System.Drawing.Size(215, 22)
        Me.cmdPrintBorrow.Text = "列印产品借出人员"
        '
        'cmdViewSub
        '
        Me.cmdViewSub.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdViewSub.Name = "cmdViewSub"
        Me.cmdViewSub.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.cmdViewSub.Size = New System.Drawing.Size(215, 22)
        Me.cmdViewSub.Text = "转Excel(&V)"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.ContextMenuStrip = Me.cmsRepaySub
        Me.XtraTabPage2.Controls.Add(Me.Grid2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1111, 258)
        Me.XtraTabPage2.Text = "部门生产领料明细"
        '
        'Grid2
        '
        Me.Grid2.ContextMenuStrip = Me.cmsRepaySub
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.viewBorrow
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupContainerEdit2, Me.RepositoryItemPopupContainerEdit3, Me.RepositoryItemCalcEdit3, Me.RepositoryItemDateEdit3})
        Me.Grid2.Size = New System.Drawing.Size(1111, 258)
        Me.Grid2.TabIndex = 246
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBorrow})
        '
        'viewBorrow
        '
        Me.viewBorrow.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.viewBorrow.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.viewBorrow.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn16, Me.GridColumn18, Me.GridColumn24, Me.GridColumn25, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37})
        Me.viewBorrow.GridControl = Me.Grid2
        Me.viewBorrow.Name = "viewBorrow"
        Me.viewBorrow.OptionsBehavior.Editable = False
        Me.viewBorrow.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewBorrow.OptionsView.ColumnAutoWidth = False
        Me.viewBorrow.OptionsView.ShowAutoFilterRow = True
        Me.viewBorrow.OptionsView.ShowFooter = True
        Me.viewBorrow.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "自动ID"
        Me.GridColumn1.FieldName = "AutoID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "领料单号"
        Me.GridColumn2.FieldName = "BorrowID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 106
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "订单编号"
        Me.GridColumn9.FieldName = "SO_ID"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "样办单号"
        Me.GridColumn16.FieldName = "SO_SampleID"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "材料"
        Me.GridColumn18.FieldName = "MaterialTypeName"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "产品编号"
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemPopupContainerEdit2
        Me.GridColumn24.FieldName = "PM_M_Code"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Width = 139
        '
        'RepositoryItemPopupContainerEdit2
        '
        Me.RepositoryItemPopupContainerEdit2.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit2.Name = "RepositoryItemPopupContainerEdit2"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "工序"
        Me.GridColumn25.FieldName = "PS_NO"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "领料数量"
        Me.GridColumn27.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.GridColumn27.FieldName = "Borrow_Qty"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn27.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 2
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "未还数量"
        Me.GridColumn28.FieldName = "NoBorrow_Qty"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn28.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn28.Width = 98
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "部门"
        Me.GridColumn29.FieldName = "D_Dep"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Width = 62
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "领料刷卡"
        Me.GridColumn30.FieldName = "OutCardID"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 0
        Me.GridColumn30.Width = 163
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "领料日期"
        Me.GridColumn31.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn31.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn31.FieldName = "BorrowDate"
        Me.GridColumn31.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn31.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.SummaryItem.DisplayFormat = "合计："
        Me.GridColumn31.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 1
        Me.GridColumn31.Width = 88
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "CheckBit"
        Me.GridColumn32.FieldName = "CheckBit"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "CheckUserName"
        Me.GridColumn33.FieldName = "CheckUserName"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "CheckDate"
        Me.GridColumn34.FieldName = "CheckDate"
        Me.GridColumn34.Name = "GridColumn34"
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "创建人员"
        Me.GridColumn35.FieldName = "CreateUserName"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 4
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "CreateDate"
        Me.GridColumn36.FieldName = "CreateDate"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "备注"
        Me.GridColumn37.FieldName = "Remark"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 3
        Me.GridColumn37.Width = 203
        '
        'RepositoryItemPopupContainerEdit3
        '
        Me.RepositoryItemPopupContainerEdit3.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit3.Name = "RepositoryItemPopupContainerEdit3"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit3.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.ContextMenuStrip = Me.cmsRepaySub
        Me.XtraTabPage1.Controls.Add(Me.grid3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1111, 258)
        Me.XtraTabPage1.Text = "部门生产退还明细"
        '
        'grid3
        '
        Me.grid3.ContextMenuStrip = Me.cmsRepaySub
        Me.grid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid3.EmbeddedNavigator.Name = ""
        Me.grid3.Location = New System.Drawing.Point(0, 0)
        Me.grid3.MainView = Me.viewRepay
        Me.grid3.Name = "grid3"
        Me.grid3.Size = New System.Drawing.Size(1111, 258)
        Me.grid3.TabIndex = 243
        Me.grid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewRepay})
        '
        'viewRepay
        '
        Me.viewRepay.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.viewRepay.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.viewRepay.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.RepayID, Me.OutDeptName, Me.GridColumn26, Me.InDeptName, Me.PM_M_Code, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn10})
        Me.viewRepay.GridControl = Me.grid3
        Me.viewRepay.Name = "viewRepay"
        Me.viewRepay.OptionsBehavior.Editable = False
        Me.viewRepay.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewRepay.OptionsView.ColumnAutoWidth = False
        Me.viewRepay.OptionsView.ShowAutoFilterRow = True
        Me.viewRepay.OptionsView.ShowFooter = True
        Me.viewRepay.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'RepayID
        '
        Me.RepayID.Caption = "还入单号"
        Me.RepayID.FieldName = "RepayID"
        Me.RepayID.Name = "RepayID"
        Me.RepayID.Visible = True
        Me.RepayID.VisibleIndex = 3
        Me.RepayID.Width = 98
        '
        'OutDeptName
        '
        Me.OutDeptName.Caption = "借出部門"
        Me.OutDeptName.FieldName = "OutDeptName"
        Me.OutDeptName.Name = "OutDeptName"
        Me.OutDeptName.Width = 99
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "样办单号"
        Me.GridColumn26.FieldName = "SO_SampleID"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'InDeptName
        '
        Me.InDeptName.Caption = "还回部门"
        Me.InDeptName.FieldName = "InDeptName"
        Me.InDeptName.Name = "InDeptName"
        Me.InDeptName.Width = 87
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Width = 116
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料名称"
        Me.GridColumn3.FieldName = "M_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 96
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "M_Gauge"
        Me.GridColumn4.FieldName = "M_Gauge"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 101
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "M_Unit"
        Me.GridColumn5.FieldName = "M_Unit"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "还回数量"
        Me.GridColumn6.FieldName = "RepayQty"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "还回日期"
        Me.GridColumn7.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "RepayDate"
        Me.GridColumn7.GroupFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn7.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.SummaryItem.DisplayFormat = "合计:"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "刷卡人员"
        Me.GridColumn8.FieldName = "InCardID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 158
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "审核"
        Me.GridColumn11.FieldName = "CheckBit"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "CheckDate"
        Me.GridColumn12.FieldName = "CheckDate"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "审核人员"
        Me.GridColumn13.FieldName = "CheckUserName"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "创建人员"
        Me.GridColumn14.FieldName = "CreateUserName"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 94
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "CreateDate"
        Me.GridColumn15.FieldName = "CreateDate"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "备注"
        Me.GridColumn10.FieldName = "Remarks"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 202
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.ContextMenuStrip = Me.cmsRepaySub
        Me.XtraTabPage3.Controls.Add(Me.Grid4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1111, 258)
        Me.XtraTabPage3.Text = "员工领还汇总"
        '
        'Grid4
        '
        Me.Grid4.ContextMenuStrip = Me.cmsRepaySub
        Me.Grid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid4.EmbeddedNavigator.Name = ""
        Me.Grid4.Location = New System.Drawing.Point(0, 0)
        Me.Grid4.MainView = Me.GridView1
        Me.Grid4.Name = "Grid4"
        Me.Grid4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupContainerEdit4, Me.RepositoryItemPopupContainerEdit5, Me.RepositoryItemCalcEdit4, Me.RepositoryItemDateEdit4})
        Me.Grid4.Size = New System.Drawing.Size(1111, 258)
        Me.Grid4.TabIndex = 247
        Me.Grid4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn38, Me.GridColumn23, Me.GridColumn39})
        Me.GridView1.GridControl = Me.Grid4
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "自动ID"
        Me.GridColumn17.FieldName = "AutoID"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "员工刷卡"
        Me.GridColumn19.FieldName = "OutCardID"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.SummaryItem.DisplayFormat = "合计"
        Me.GridColumn19.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        Me.GridColumn19.Width = 163
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "领料总数量"
        Me.GridColumn20.FieldName = "Borrow_Qty"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn20.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 1
        Me.GridColumn20.Width = 107
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "还料总数量"
        Me.GridColumn21.FieldName = "RepayQty"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn21.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 2
        Me.GridColumn21.Width = 92
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "未还总数量"
        Me.GridColumn22.FieldName = "NoBorrow_Qty"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn22.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 3
        Me.GridColumn22.Width = 82
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "部门"
        Me.GridColumn38.FieldName = "D_Dep"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Width = 109
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "工序"
        Me.GridColumn23.FieldName = "PS_Name"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "产品编号"
        Me.GridColumn39.FieldName = "PM_M_Code"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Width = 116
        '
        'RepositoryItemPopupContainerEdit4
        '
        Me.RepositoryItemPopupContainerEdit4.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit4.Name = "RepositoryItemPopupContainerEdit4"
        '
        'RepositoryItemPopupContainerEdit5
        '
        Me.RepositoryItemPopupContainerEdit5.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit5.Name = "RepositoryItemPopupContainerEdit5"
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit4.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "生产领退料"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1241, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmSampleBorrowMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSampleBorrowMain"
        Me.Text = "生产领退料"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsBorrow.ResumeLayout(False)
        CType(Me.viewWareInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItempceCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.cmsRepaySub.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewRepay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmsBorrow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsBorrowAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBorrowView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBorrowCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBorrowExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewWareInventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colaAutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemPceMaterial As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents colaBorrow_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colaRepayQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaMaterialTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItempceCurrency As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmdRepay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRepaySub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdViewSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colaSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBorrow As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewRepay As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OutDeptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InDeptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaAvailableQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaSWI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemPopupContainerEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaNoBorrow_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrintBorrow As System.Windows.Forms.ToolStripMenuItem
End Class
