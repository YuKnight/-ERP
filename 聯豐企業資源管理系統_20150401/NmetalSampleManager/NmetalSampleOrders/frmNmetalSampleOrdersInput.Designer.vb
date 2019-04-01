<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleOrdersInput
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCODEDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IWeight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonLoad = New DevExpress.XtraEditors.SimpleButton
        Me.txtWeight = New DevExpress.XtraEditors.TextEdit
        Me.lbl_Qty = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode_ID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_SO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.txt_PM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.lbl_so_sampleID = New System.Windows.Forms.Label
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_SO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.Grid1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.Grid1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid1.Location = New System.Drawing.Point(0, 170)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2})
        Me.Grid1.Size = New System.Drawing.Size(533, 302)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.cmdCODEDel, Me.ToolStripSeparator6})
        Me.ContextMenuStrip1.Name = "cmsMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 44)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(196, 6)
        '
        'cmdCODEDel
        '
        Me.cmdCODEDel.AutoSize = False
        Me.cmdCODEDel.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCODEDel.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.cmdCODEDel.Name = "cmdCODEDel"
        Me.cmdCODEDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdCODEDel.Size = New System.Drawing.Size(202, 28)
        Me.cmdCODEDel.Text = "删除条码(&D)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(196, 6)
        '
        'GridView2
        '
        Me.GridView2.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView2.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Code_ID, Me.Qty, Me.PM_M_Code, Me.IWeight})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Code_ID
        '
        Me.Code_ID.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.Code_ID.AppearanceHeader.Options.UseBorderColor = True
        Me.Code_ID.Caption = "条码编号"
        Me.Code_ID.FieldName = "Code_ID"
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.OptionsColumn.ReadOnly = True
        Me.Code_ID.SummaryItem.DisplayFormat = "条码数量:{0}"
        Me.Code_ID.SummaryItem.FieldName = "WareCode"
        Me.Code_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.Code_ID.Visible = True
        Me.Code_ID.VisibleIndex = 0
        Me.Code_ID.Width = 210
        '
        'Qty
        '
        Me.Qty.Caption = "数量"
        Me.Qty.FieldName = "Code_Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.ReadOnly = True
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 1
        Me.Qty.Width = 44
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品资料"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Width = 81
        '
        'IWeight
        '
        Me.IWeight.Caption = "來料重量"
        Me.IWeight.FieldName = "IWeight"
        Me.IWeight.Name = "IWeight"
        Me.IWeight.OptionsColumn.ReadOnly = True
        Me.IWeight.Visible = True
        Me.IWeight.VisibleIndex = 2
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 21)
        Me.lblTitle.TabIndex = 83
        Me.lblTitle.Text = "條碼采集入庫"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(535, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "产品编号:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonLoad)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.lbl_Qty)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCode_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 90)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLoad.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonLoad.Appearance.Options.UseFont = True
        Me.ButtonLoad.Location = New System.Drawing.Point(441, 11)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(75, 32)
        Me.ButtonLoad.TabIndex = 174
        Me.ButtonLoad.Text = "載入"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(93, 56)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Properties.Appearance.Options.UseFont = True
        Me.txtWeight.Properties.Mask.EditMask = "n3"
        Me.txtWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtWeight.Size = New System.Drawing.Size(336, 24)
        Me.txtWeight.TabIndex = 171
        '
        'lbl_Qty
        '
        Me.lbl_Qty.AutoSize = True
        Me.lbl_Qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Qty.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Qty.Location = New System.Drawing.Point(3, 61)
        Me.lbl_Qty.Name = "lbl_Qty"
        Me.lbl_Qty.Size = New System.Drawing.Size(88, 15)
        Me.lbl_Qty.TabIndex = 170
        Me.lbl_Qty.Text = "來料重量(g):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "条码编号:"
        '
        'txtCode_ID
        '
        Me.txtCode_ID.Location = New System.Drawing.Point(93, 11)
        Me.txtCode_ID.Name = "txtCode_ID"
        Me.txtCode_ID.Properties.Appearance.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCode_ID.Properties.Appearance.Options.UseFont = True
        Me.txtCode_ID.Size = New System.Drawing.Size(336, 38)
        Me.txtCode_ID.TabIndex = 144
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txt_SO_SampleID)
        Me.GroupBox2.Controls.Add(Me.txt_PM_M_Code)
        Me.GroupBox2.Controls.Add(Me.lbl_so_sampleID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 44)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        '
        'txt_SO_SampleID
        '
        Me.txt_SO_SampleID.Enabled = False
        Me.txt_SO_SampleID.Location = New System.Drawing.Point(308, 14)
        Me.txt_SO_SampleID.Name = "txt_SO_SampleID"
        Me.txt_SO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_SO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txt_SO_SampleID.Size = New System.Drawing.Size(121, 24)
        Me.txt_SO_SampleID.TabIndex = 148
        '
        'txt_PM_M_Code
        '
        Me.txt_PM_M_Code.Enabled = False
        Me.txt_PM_M_Code.Location = New System.Drawing.Point(93, 13)
        Me.txt_PM_M_Code.Name = "txt_PM_M_Code"
        Me.txt_PM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_PM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txt_PM_M_Code.Size = New System.Drawing.Size(123, 24)
        Me.txt_PM_M_Code.TabIndex = 147
        '
        'lbl_so_sampleID
        '
        Me.lbl_so_sampleID.AutoSize = True
        Me.lbl_so_sampleID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_so_sampleID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_so_sampleID.Location = New System.Drawing.Point(248, 18)
        Me.lbl_so_sampleID.Name = "lbl_so_sampleID"
        Me.lbl_so_sampleID.Size = New System.Drawing.Size(56, 15)
        Me.lbl_so_sampleID.TabIndex = 146
        Me.lbl_so_sampleID.Text = "板單號:"
        '
        'Savebutton
        '
        Me.Savebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Savebutton.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Savebutton.Appearance.Options.UseFont = True
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.Savebutton.Location = New System.Drawing.Point(334, 479)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(75, 32)
        Me.Savebutton.TabIndex = 150
        Me.Savebutton.Text = "确认(&S)"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CloseButton.Appearance.Options.UseFont = True
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(442, 479)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 32)
        Me.CloseButton.TabIndex = 151
        Me.CloseButton.Text = "取消(&E)"
        '
        'frmNmetalSampleOrdersInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 516)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmNmetalSampleOrdersInput"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "條碼采集入庫"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_SO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode_ID As DevExpress.XtraEditors.TextEdit
    Public WithEvents lbl_Qty As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents lbl_so_sampleID As System.Windows.Forms.Label
    Friend WithEvents txt_SO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_PM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCODEDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
End Class
