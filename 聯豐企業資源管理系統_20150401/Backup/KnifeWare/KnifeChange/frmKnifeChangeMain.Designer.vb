<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeChangeMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeChangeMain))
        Me.CaptionLabel = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButtonGroup = New System.Windows.Forms.Button
        Me.ButtonPer = New System.Windows.Forms.Button
        Me.Grid4 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CH_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CBegin_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CEnd_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CKType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BRPer_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BRPer_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CReMark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoExEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ContextMenuKuncun = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripOld = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripNew = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripView = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuBReturn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripBorrow = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripReturn = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripAddBorrow = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripViewB = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuKuncun.SuspendLayout()
        Me.ContextMenuBReturn.SuspendLayout()
        Me.SuspendLayout()
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaptionLabel.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaptionLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaptionLabel.Location = New System.Drawing.Point(6, 5)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(130, 24)
        Me.CaptionLabel.TabIndex = 180
        Me.CaptionLabel.Text = "刀具更改單"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(713, 36)
        Me.PictureBox1.TabIndex = 179
        Me.PictureBox1.TabStop = False
        '
        'ButtonGroup
        '
        Me.ButtonGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGroup.Location = New System.Drawing.Point(593, 7)
        Me.ButtonGroup.Name = "ButtonGroup"
        Me.ButtonGroup.Size = New System.Drawing.Size(102, 24)
        Me.ButtonGroup.TabIndex = 182
        Me.ButtonGroup.Text = "員工領.還刀更改"
        Me.ButtonGroup.UseVisualStyleBackColor = False
        '
        'ButtonPer
        '
        Me.ButtonPer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPer.Location = New System.Drawing.Point(452, 7)
        Me.ButtonPer.Name = "ButtonPer"
        Me.ButtonPer.Size = New System.Drawing.Size(102, 24)
        Me.ButtonPer.TabIndex = 181
        Me.ButtonPer.Text = "庫存更改"
        Me.ButtonPer.UseVisualStyleBackColor = False
        '
        'Grid4
        '
        Me.Grid4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid4.EmbeddedNavigator.Name = ""
        Me.Grid4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid4.Location = New System.Drawing.Point(0, 40)
        Me.Grid4.MainView = Me.GridView4
        Me.Grid4.Name = "Grid4"
        Me.Grid4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4, Me.RepositoryItemMemoExEdit6, Me.RepositoryItemMemoExEdit7, Me.RepositoryItemMemoExEdit1})
        Me.Grid4.Size = New System.Drawing.Size(711, 428)
        Me.Grid4.TabIndex = 185
        Me.Grid4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CH_Num, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.CBegin_Qty, Me.CEnd_Qty, Me.CKType, Me.WH_ID, Me.WH_Name, Me.BRPer_ID, Me.BRPer_Name, Me.C_Date, Me.CReMark})
        Me.GridView4.GridControl = Me.Grid4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView4.OptionsFilter.AllowFilterEditor = False
        Me.GridView4.OptionsFilter.AllowMRUFilterList = False
        Me.GridView4.OptionsMenu.EnableColumnMenu = False
        Me.GridView4.OptionsMenu.EnableFooterMenu = False
        Me.GridView4.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsSelection.MultiSelect = True
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'CH_Num
        '
        Me.CH_Num.Caption = "單號"
        Me.CH_Num.FieldName = "CH_Num"
        Me.CH_Num.Name = "CH_Num"
        Me.CH_Num.OptionsColumn.ReadOnly = True
        Me.CH_Num.Visible = True
        Me.CH_Num.VisibleIndex = 0
        Me.CH_Num.Width = 90
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        Me.M_Name.Width = 90
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 120
        '
        'CBegin_Qty
        '
        Me.CBegin_Qty.Caption = "更改前數"
        Me.CBegin_Qty.FieldName = "CBegin_Qty"
        Me.CBegin_Qty.Name = "CBegin_Qty"
        Me.CBegin_Qty.OptionsColumn.ReadOnly = True
        Me.CBegin_Qty.Visible = True
        Me.CBegin_Qty.VisibleIndex = 4
        '
        'CEnd_Qty
        '
        Me.CEnd_Qty.Caption = "更改后數量"
        Me.CEnd_Qty.FieldName = "CEnd_Qty"
        Me.CEnd_Qty.Name = "CEnd_Qty"
        Me.CEnd_Qty.OptionsColumn.ReadOnly = True
        Me.CEnd_Qty.Visible = True
        Me.CEnd_Qty.VisibleIndex = 5
        '
        'CKType
        '
        Me.CKType.Caption = "更改類型"
        Me.CKType.FieldName = "CKTypeName"
        Me.CKType.Name = "CKType"
        Me.CKType.OptionsColumn.ReadOnly = True
        Me.CKType.Visible = True
        Me.CKType.VisibleIndex = 6
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫代號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.OptionsColumn.ReadOnly = True
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 7
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "倉庫名稱"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.OptionsColumn.ReadOnly = True
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 8
        Me.WH_Name.Width = 85
        '
        'BRPer_ID
        '
        Me.BRPer_ID.Caption = "借/還人"
        Me.BRPer_ID.FieldName = "BRPer_ID"
        Me.BRPer_ID.Name = "BRPer_ID"
        Me.BRPer_ID.OptionsColumn.ReadOnly = True
        Me.BRPer_ID.Visible = True
        Me.BRPer_ID.VisibleIndex = 9
        '
        'BRPer_Name
        '
        Me.BRPer_Name.Caption = "借還人姓名"
        Me.BRPer_Name.FieldName = "BRPer_Name"
        Me.BRPer_Name.Name = "BRPer_Name"
        Me.BRPer_Name.OptionsColumn.ReadOnly = True
        Me.BRPer_Name.Visible = True
        Me.BRPer_Name.VisibleIndex = 10
        '
        'C_Date
        '
        Me.C_Date.Caption = "更改時間"
        Me.C_Date.FieldName = "C_Date"
        Me.C_Date.Name = "C_Date"
        Me.C_Date.OptionsColumn.ReadOnly = True
        Me.C_Date.Visible = True
        Me.C_Date.VisibleIndex = 11
        Me.C_Date.Width = 135
        '
        'CReMark
        '
        Me.CReMark.Caption = "備注"
        Me.CReMark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.CReMark.FieldName = "CReMark"
        Me.CReMark.Name = "CReMark"
        Me.CReMark.Visible = True
        Me.CReMark.VisibleIndex = 12
        Me.CReMark.Width = 120
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemMemoExEdit6
        '
        Me.RepositoryItemMemoExEdit6.AutoHeight = False
        Me.RepositoryItemMemoExEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit6.Name = "RepositoryItemMemoExEdit6"
        '
        'RepositoryItemMemoExEdit7
        '
        Me.RepositoryItemMemoExEdit7.AutoHeight = False
        Me.RepositoryItemMemoExEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit7.Name = "RepositoryItemMemoExEdit7"
        Me.RepositoryItemMemoExEdit7.ShowIcon = False
        '
        'ContextMenuKuncun
        '
        Me.ContextMenuKuncun.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripOld, Me.ToolStripSeparator1, Me.ToolStripNew, Me.ToolStripMenuItem3, Me.ToolStripView})
        Me.ContextMenuKuncun.Name = "ContextMenuKuncun"
        Me.ContextMenuKuncun.Size = New System.Drawing.Size(107, 82)
        '
        'ToolStripOld
        '
        Me.ToolStripOld.Enabled = False
        Me.ToolStripOld.Image = CType(resources.GetObject("ToolStripOld.Image"), System.Drawing.Image)
        Me.ToolStripOld.Name = "ToolStripOld"
        Me.ToolStripOld.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripOld.Text = "待處理"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(103, 6)
        '
        'ToolStripNew
        '
        Me.ToolStripNew.Enabled = False
        Me.ToolStripNew.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.ToolStripNew.Name = "ToolStripNew"
        Me.ToolStripNew.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripNew.Text = "新刀"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(103, 6)
        '
        'ToolStripView
        '
        Me.ToolStripView.Image = CType(resources.GetObject("ToolStripView.Image"), System.Drawing.Image)
        Me.ToolStripView.Name = "ToolStripView"
        Me.ToolStripView.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripView.Text = "查看"
        '
        'ContextMenuBReturn
        '
        Me.ContextMenuBReturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBorrow, Me.ToolStripMenuItem1, Me.ToolStripReturn, Me.ToolStripMenuItem2, Me.ToolStripAddBorrow, Me.ToolStripMenuItem4, Me.ToolStripViewB})
        Me.ContextMenuBReturn.Name = "ContextMenuKuncun"
        Me.ContextMenuBReturn.Size = New System.Drawing.Size(131, 110)
        '
        'ToolStripBorrow
        '
        Me.ToolStripBorrow.Enabled = False
        Me.ToolStripBorrow.Image = CType(resources.GetObject("ToolStripBorrow.Image"), System.Drawing.Image)
        Me.ToolStripBorrow.Name = "ToolStripBorrow"
        Me.ToolStripBorrow.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripBorrow.Text = "員工領刀數"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 6)
        '
        'ToolStripReturn
        '
        Me.ToolStripReturn.Enabled = False
        Me.ToolStripReturn.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.ToolStripReturn.Name = "ToolStripReturn"
        Me.ToolStripReturn.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripReturn.Text = "員工還刀數"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(127, 6)
        '
        'ToolStripAddBorrow
        '
        Me.ToolStripAddBorrow.Enabled = False
        Me.ToolStripAddBorrow.Name = "ToolStripAddBorrow"
        Me.ToolStripAddBorrow.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripAddBorrow.Text = "領刀單增加"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(127, 6)
        '
        'ToolStripViewB
        '
        Me.ToolStripViewB.Image = CType(resources.GetObject("ToolStripViewB.Image"), System.Drawing.Image)
        Me.ToolStripViewB.Name = "ToolStripViewB"
        Me.ToolStripViewB.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripViewB.Text = "查看(&D)"
        '
        'frmKnifeChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 471)
        Me.Controls.Add(Me.Grid4)
        Me.Controls.Add(Me.ButtonPer)
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.ButtonGroup)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmKnifeChangeMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "刀具更改單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuKuncun.ResumeLayout(False)
        Me.ContextMenuBReturn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGroup As System.Windows.Forms.Button
    Friend WithEvents ButtonPer As System.Windows.Forms.Button
    Friend WithEvents Grid4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ContextMenuKuncun As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuBReturn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CH_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CBegin_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CEnd_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CKType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripOld As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBorrow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripAddBorrow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripViewB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CReMark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents BRPer_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BRPer_Name As DevExpress.XtraGrid.Columns.GridColumn
End Class
