<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermissionModule
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
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.pop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.PopEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popDel = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pop.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn2, Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6, Me.TreeListColumn7, Me.TreeListColumn1})
        Me.TreeList1.ContextMenuStrip = Me.pop
        Me.TreeList1.KeyFieldName = "PM_ID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "PM_PID"
        Me.TreeList1.Size = New System.Drawing.Size(640, 398)
        Me.TreeList1.TabIndex = 0
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "項目名稱"
        Me.TreeListColumn2.FieldName = "PM_Name"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        Me.TreeListColumn2.VisibleIndex = 0
        Me.TreeListColumn2.Width = 137
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "項目等級"
        Me.TreeListColumn4.FieldName = "PM_Level"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.ReadOnly = True
        Me.TreeListColumn4.VisibleIndex = 1
        Me.TreeListColumn4.Width = 60
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "是否有子項目"
        Me.TreeListColumn5.FieldName = "PM_Sub"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.OptionsColumn.ReadOnly = True
        Me.TreeListColumn5.VisibleIndex = 2
        Me.TreeListColumn5.Width = 87
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "未選擇時顯示圖片編號"
        Me.TreeListColumn6.FieldName = "PM_Image"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.OptionsColumn.ReadOnly = True
        Me.TreeListColumn6.VisibleIndex = 3
        Me.TreeListColumn6.Width = 138
        '
        'TreeListColumn7
        '
        Me.TreeListColumn7.Caption = "被選擇時顯示圖片編號"
        Me.TreeListColumn7.FieldName = "PM_SelectImage"
        Me.TreeListColumn7.Name = "TreeListColumn7"
        Me.TreeListColumn7.OptionsColumn.ReadOnly = True
        Me.TreeListColumn7.VisibleIndex = 4
        Me.TreeListColumn7.Width = 147
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "項目ID"
        Me.TreeListColumn1.FieldName = "PM_ID"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 5
        Me.TreeListColumn1.Width = 50
        '
        'pop
        '
        Me.pop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popAdd, Me.PopEdit, Me.popDel})
        Me.pop.Name = "pop"
        Me.pop.Size = New System.Drawing.Size(157, 70)
        '
        'popAdd
        '
        Me.popAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popAdd.Name = "popAdd"
        Me.popAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popAdd.Size = New System.Drawing.Size(156, 22)
        Me.popAdd.Text = "新增(&A)..."
        '
        'PopEdit
        '
        Me.PopEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.PopEdit.Name = "PopEdit"
        Me.PopEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.PopEdit.Size = New System.Drawing.Size(156, 22)
        Me.PopEdit.Text = "修改(&E)..."
        '
        'popDel
        '
        Me.popDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popDel.Name = "popDel"
        Me.popDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popDel.Size = New System.Drawing.Size(156, 22)
        Me.popDel.Text = "刪除(&D)"
        '
        'FrmPermissionModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 398)
        Me.Controls.Add(Me.TreeList1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermissionModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "模塊管理"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents pop As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
