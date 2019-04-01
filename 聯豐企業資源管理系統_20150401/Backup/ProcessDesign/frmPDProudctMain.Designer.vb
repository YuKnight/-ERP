<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDProductMain
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripModifyPSName = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.PreViewMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.EXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "產品資料工藝流程"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(742, 36)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.MenuStrip
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(152, 42)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(592, 447)
        Me.GridControl1.TabIndex = 40
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.ToolStripModifyPSName, Me.cmdDel, Me.cmdView, Me.ToolStripSeparator4, Me.cmdQuery, Me.cmdRef, Me.ToolStripSeparator5, Me.cmdCheck, Me.PreViewMenuItem, Me.ToolStripMenuItem1, Me.EXToolStripMenuItem})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(163, 264)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmdAdd.Text = "新增(&A)..."
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(162, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'ToolStripModifyPSName
        '
        Me.ToolStripModifyPSName.Enabled = False
        Me.ToolStripModifyPSName.Name = "ToolStripModifyPSName"
        Me.ToolStripModifyPSName.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripModifyPSName.Text = "修改工序名稱"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(162, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(162, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(162, 22)
        Me.cmdQuery.Text = "查詢(&F)..."
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(162, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(162, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'PreViewMenuItem
        '
        Me.PreViewMenuItem.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.PreViewMenuItem.Name = "PreViewMenuItem"
        Me.PreViewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PreViewMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PreViewMenuItem.Text = "預覽(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.PM_Type, Me.GridColumn2, Me.GridColumn4, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "產品編號"
        Me.GridColumn1.FieldName = "PM_M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 68
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類別"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.ReadOnly = True
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 2
        Me.PM_Type.Width = 60
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "類型"
        Me.GridColumn2.FieldName = "Type3ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 51
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "客戶"
        Me.GridColumn4.FieldName = "CustomerNO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 51
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "操作員"
        Me.GridColumn3.FieldName = "ActionName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 56
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "修改日期"
        Me.GridColumn5.FieldName = "Pro_EditDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        Me.GridColumn5.Width = 65
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "審核"
        Me.GridColumn6.FieldName = "Pro_Check"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        Me.GridColumn6.Width = 51
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "審核員"
        Me.GridColumn7.FieldName = "CheckActionName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 88
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "審核日期"
        Me.GridColumn8.FieldName = "Pro_CheckDate"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "工藝流程單號"
        Me.GridColumn9.FieldName = "Pro_NO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 81
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(4, 42)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(144, 447)
        Me.TreeView1.TabIndex = 41
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'EXToolStripMenuItem
        '
        Me.EXToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.EXToolStripMenuItem.Name = "EXToolStripMenuItem"
        Me.EXToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EXToolStripMenuItem.Text = "導出"
        '
        'frmPDProductMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 493)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPDProductMain"
        Me.Text = "產品資料工藝流程"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreViewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripModifyPSName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
