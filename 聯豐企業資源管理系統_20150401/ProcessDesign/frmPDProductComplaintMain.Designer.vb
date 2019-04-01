<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDProductComplaintMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.cmsComplaint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsComplaintAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsComplaintEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsComplaintDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsComplaintView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsComplaintRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsComplaintQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ReViewMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PC_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsComplaint.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "工藝流程投訴管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(635, 36)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsComplaint
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 38)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(635, 385)
        Me.Grid.TabIndex = 45
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsComplaint
        '
        Me.cmsComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsComplaintAdd, Me.cmsComplaintEdit, Me.cmsComplaintDel, Me.ToolStripSeparator1, Me.cmsComplaintView, Me.cmsComplaintRef, Me.cmsComplaintQuery, Me.ReViewMenuItem})
        Me.cmsComplaint.Name = "cmsComplaint"
        Me.cmsComplaint.Size = New System.Drawing.Size(163, 164)
        '
        'cmsComplaintAdd
        '
        Me.cmsComplaintAdd.Enabled = False
        Me.cmsComplaintAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsComplaintAdd.Name = "cmsComplaintAdd"
        Me.cmsComplaintAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsComplaintAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintAdd.Text = "新增(&A)..."
        '
        'cmsComplaintEdit
        '
        Me.cmsComplaintEdit.Enabled = False
        Me.cmsComplaintEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsComplaintEdit.Name = "cmsComplaintEdit"
        Me.cmsComplaintEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsComplaintEdit.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintEdit.Text = "修改(&E)..."
        '
        'cmsComplaintDel
        '
        Me.cmsComplaintDel.Enabled = False
        Me.cmsComplaintDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsComplaintDel.Name = "cmsComplaintDel"
        Me.cmsComplaintDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsComplaintDel.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintDel.Text = "刪除(&D)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'cmsComplaintView
        '
        Me.cmsComplaintView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsComplaintView.Name = "cmsComplaintView"
        Me.cmsComplaintView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsComplaintView.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintView.Text = "查看(&W)..."
        '
        'cmsComplaintRef
        '
        Me.cmsComplaintRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsComplaintRef.Name = "cmsComplaintRef"
        Me.cmsComplaintRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsComplaintRef.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintRef.Text = "刷新(&R)..."
        '
        'cmsComplaintQuery
        '
        Me.cmsComplaintQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsComplaintQuery.Name = "cmsComplaintQuery"
        Me.cmsComplaintQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsComplaintQuery.Size = New System.Drawing.Size(162, 22)
        Me.cmsComplaintQuery.Text = "查詢(&F)..."
        '
        'ReViewMenuItem
        '
        Me.ReViewMenuItem.Image = Global.LFERP.My.Resources.Resources.Summer_Collection_005
        Me.ReViewMenuItem.Name = "ReViewMenuItem"
        Me.ReViewMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ReViewMenuItem.Text = "預覽(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PC_NO, Me.Pro_NO, Me.PM_M_Code, Me.PC_Remark, Me.ActionName, Me.PC_AddDate})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PC_NO
        '
        Me.PC_NO.Caption = "投訴單號"
        Me.PC_NO.FieldName = "PC_NO"
        Me.PC_NO.Name = "PC_NO"
        Me.PC_NO.Visible = True
        Me.PC_NO.VisibleIndex = 0
        '
        'Pro_NO
        '
        Me.Pro_NO.Caption = "工藝流程單號"
        Me.Pro_NO.FieldName = "Pro_NO"
        Me.Pro_NO.Name = "Pro_NO"
        Me.Pro_NO.Visible = True
        Me.Pro_NO.VisibleIndex = 1
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        '
        'PC_Remark
        '
        Me.PC_Remark.Caption = "備註"
        Me.PC_Remark.FieldName = "PC_Remark"
        Me.PC_Remark.Name = "PC_Remark"
        Me.PC_Remark.Visible = True
        Me.PC_Remark.VisibleIndex = 3
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 4
        '
        'PC_AddDate
        '
        Me.PC_AddDate.Caption = "建立日期"
        Me.PC_AddDate.FieldName = "PC_AddDate"
        Me.PC_AddDate.Name = "PC_AddDate"
        Me.PC_AddDate.Visible = True
        Me.PC_AddDate.VisibleIndex = 5
        '
        'frmPDProductComplaintMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 425)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPDProductComplaintMain"
        Me.Text = "frmPDProductComplaintMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsComplaint.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsComplaint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsComplaintAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsComplaintEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsComplaintDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsComplaintRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsComplaintQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsComplaintView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReViewMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
