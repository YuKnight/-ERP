<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareBorrowChangeMain
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
        Me.CaptionLabel = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.checkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ChangeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChageDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChangeActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaptionLabel.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaptionLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaptionLabel.Location = New System.Drawing.Point(8, 7)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(130, 24)
        Me.CaptionLabel.TabIndex = 172
        Me.CaptionLabel.Text = "更改單作業"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(860, 36)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(2, 39)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(858, 422)
        Me.Grid1.TabIndex = 173
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ToolStripMenuItem1, Me.viewToolStripMenuItem, Me.checkToolStripMenuItem, Me.ToolStripMenuItem2, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 104)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Enabled = False
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AddToolStripMenuItem.Text = "新增(&A)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 6)
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.viewToolStripMenuItem.Text = "查看(&V)"
        '
        'checkToolStripMenuItem
        '
        Me.checkToolStripMenuItem.Name = "checkToolStripMenuItem"
        Me.checkToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.checkToolStripMenuItem.Text = "審核(&D)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RefreshToolStripMenuItem.Text = "刷新(&R)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ChangeNo, Me.WB_NUM, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.QtyS, Me.QtyE, Me.ChageDate, Me.ChangeActionName, Me.Check, Me.CheckDate, Me.CheckAction, Me.CheckActionName})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ChangeNo
        '
        Me.ChangeNo.Caption = "單號"
        Me.ChangeNo.FieldName = "ChangeNo"
        Me.ChangeNo.Name = "ChangeNo"
        Me.ChangeNo.OptionsColumn.ReadOnly = True
        Me.ChangeNo.Visible = True
        Me.ChangeNo.VisibleIndex = 0
        Me.ChangeNo.Width = 100
        '
        'WB_NUM
        '
        Me.WB_NUM.Caption = "借刀單"
        Me.WB_NUM.FieldName = "WB_NUM"
        Me.WB_NUM.Name = "WB_NUM"
        Me.WB_NUM.OptionsColumn.ReadOnly = True
        Me.WB_NUM.Visible = True
        Me.WB_NUM.VisibleIndex = 1
        Me.WB_NUM.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 120
        '
        'QtyS
        '
        Me.QtyS.Caption = "更改前數量"
        Me.QtyS.FieldName = "QtyS"
        Me.QtyS.Name = "QtyS"
        Me.QtyS.OptionsColumn.ReadOnly = True
        Me.QtyS.Visible = True
        Me.QtyS.VisibleIndex = 5
        Me.QtyS.Width = 90
        '
        'QtyE
        '
        Me.QtyE.Caption = "更改后數量"
        Me.QtyE.FieldName = "QtyE"
        Me.QtyE.Name = "QtyE"
        Me.QtyE.OptionsColumn.ReadOnly = True
        Me.QtyE.Visible = True
        Me.QtyE.VisibleIndex = 6
        Me.QtyE.Width = 90
        '
        'ChageDate
        '
        Me.ChageDate.Caption = "更改日期"
        Me.ChageDate.FieldName = "ChageDate"
        Me.ChageDate.Name = "ChageDate"
        Me.ChageDate.OptionsColumn.ReadOnly = True
        Me.ChageDate.Visible = True
        Me.ChageDate.VisibleIndex = 7
        '
        'ChangeActionName
        '
        Me.ChangeActionName.Caption = "更改人"
        Me.ChangeActionName.FieldName = "ChangeActionName"
        Me.ChangeActionName.Name = "ChangeActionName"
        Me.ChangeActionName.OptionsColumn.ReadOnly = True
        Me.ChangeActionName.Visible = True
        Me.ChangeActionName.VisibleIndex = 8
        '
        'Check
        '
        Me.Check.Caption = "審核狀態"
        Me.Check.FieldName = "Check"
        Me.Check.Name = "Check"
        Me.Check.Visible = True
        Me.Check.VisibleIndex = 9
        '
        'CheckDate
        '
        Me.CheckDate.Caption = "審核日期"
        Me.CheckDate.FieldName = "CheckDate"
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Visible = True
        Me.CheckDate.VisibleIndex = 10
        '
        'CheckAction
        '
        Me.CheckAction.Caption = "審核人"
        Me.CheckAction.FieldName = "CheckAction"
        Me.CheckAction.Name = "CheckAction"
        Me.CheckAction.Visible = True
        Me.CheckAction.VisibleIndex = 11
        '
        'CheckActionName
        '
        Me.CheckActionName.Caption = "審核人姓名"
        Me.CheckActionName.FieldName = "CheckActionName"
        Me.CheckActionName.Name = "CheckActionName"
        Me.CheckActionName.Visible = True
        Me.CheckActionName.VisibleIndex = 12
        Me.CheckActionName.Width = 85
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'frmWareBorrowChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 461)
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "frmWareBorrowChangeMain"
        Me.Text = "更改單作業"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChageDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChangeActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents viewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
End Class
