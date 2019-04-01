<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotationFWMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuItemEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuItemDel = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuItemSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuItemCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuItemRel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuEdit.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(733, 36)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuEdit
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(731, 465)
        Me.GridControl1.TabIndex = 32
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuEdit
        '
        Me.ContextMenuEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAdd, Me.MenuItemEdit, Me.MenuItemDel, Me.MenuItemSelect, Me.ToolStripSeparator2, Me.MenuItemCheck, Me.ToolStripSeparator3, Me.MenuItemRel})
        Me.ContextMenuEdit.Name = "ContextMenuEdit"
        Me.ContextMenuEdit.Size = New System.Drawing.Size(157, 148)
        '
        'MenuItemAdd
        '
        Me.MenuItemAdd.Enabled = False
        Me.MenuItemAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.MenuItemAdd.Name = "MenuItemAdd"
        Me.MenuItemAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuItemAdd.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemAdd.Text = "新增(&A)..."
        '
        'MenuItemEdit
        '
        Me.MenuItemEdit.Enabled = False
        Me.MenuItemEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.MenuItemEdit.Name = "MenuItemEdit"
        Me.MenuItemEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenuItemEdit.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemEdit.Text = "修改(&E)..."
        '
        'MenuItemDel
        '
        Me.MenuItemDel.Enabled = False
        Me.MenuItemDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.MenuItemDel.Name = "MenuItemDel"
        Me.MenuItemDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuItemDel.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemDel.Text = "刪除(&D)"
        '
        'MenuItemSelect
        '
        Me.MenuItemSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.MenuItemSelect.Name = "MenuItemSelect"
        Me.MenuItemSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MenuItemSelect.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemSelect.Text = "查找(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'MenuItemCheck
        '
        Me.MenuItemCheck.Enabled = False
        Me.MenuItemCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.MenuItemCheck.Name = "MenuItemCheck"
        Me.MenuItemCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MenuItemCheck.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemCheck.Text = "審核(&C)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(153, 6)
        '
        'MenuItemRel
        '
        Me.MenuItemRel.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.MenuItemRel.Name = "MenuItemRel"
        Me.MenuItemRel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuItemRel.Size = New System.Drawing.Size(156, 22)
        Me.MenuItemRel.Text = "刷新(&R)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "範圍單號"
        Me.GridColumn1.FieldName = "QuotationID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 78
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "主物料編碼"
        Me.GridColumn2.FieldName = "CodeMain"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "子物料編碼"
        Me.GridColumn3.FieldName = "CodeSub"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 89
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "審核狀態"
        Me.GridColumn4.FieldName = "Checked"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 8
        Me.GridColumn4.Width = 60
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "報價員"
        Me.GridColumn5.FieldName = "Code_UserName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 51
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "主物料名稱"
        Me.GridColumn6.FieldName = "CodeMain_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 85
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "主物料規格"
        Me.GridColumn7.FieldName = "CodeMain_Gauge"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 83
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "子物料名稱"
        Me.GridColumn8.FieldName = "CodeSub_Name"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 87
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "子物料規格"
        Me.GridColumn9.FieldName = "CodeSub_Gauge"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "範圍報價單管理"
        '
        'frmQuotationFWMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmQuotationFWMain"
        Me.Text = "範圍報價單管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuEdit.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuItemAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItemRel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItemSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
