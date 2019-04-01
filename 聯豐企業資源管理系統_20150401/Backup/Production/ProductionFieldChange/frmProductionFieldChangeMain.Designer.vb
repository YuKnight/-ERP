<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionFieldChangeMain
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
        Me.cmsProductionChange = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeReAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangePreView = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PC_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_ReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PC_Check = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProductionChange.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "生產更改單管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(703, 34)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsProductionChange
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 36)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(703, 382)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsProductionChange
        '
        Me.cmsProductionChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeAdd, Me.ChangeReAdd, Me.ChangeEdit, Me.ChangeDel, Me.ToolStripSeparator1, Me.ChangePreView, Me.ChangeRef, Me.ToolStripSeparator2, Me.ChangeCheck, Me.ChangePrint})
        Me.cmsProductionChange.Name = "cmsProduction"
        Me.cmsProductionChange.Size = New System.Drawing.Size(211, 192)
        '
        'ChangeAdd
        '
        Me.ChangeAdd.Enabled = False
        Me.ChangeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ChangeAdd.Name = "ChangeAdd"
        Me.ChangeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ChangeAdd.Size = New System.Drawing.Size(210, 22)
        Me.ChangeAdd.Text = "新增大貨(&A)..."
        '
        'ChangeReAdd
        '
        Me.ChangeReAdd.Enabled = False
        Me.ChangeReAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.ChangeReAdd.Name = "ChangeReAdd"
        Me.ChangeReAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ChangeReAdd.Size = New System.Drawing.Size(210, 22)
        Me.ChangeReAdd.Text = "新增返修(&T)..."
        '
        'ChangeEdit
        '
        Me.ChangeEdit.Enabled = False
        Me.ChangeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ChangeEdit.Name = "ChangeEdit"
        Me.ChangeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ChangeEdit.Size = New System.Drawing.Size(210, 22)
        Me.ChangeEdit.Text = "修改(&E)..."
        '
        'ChangeDel
        '
        Me.ChangeDel.Enabled = False
        Me.ChangeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.ChangeDel.Name = "ChangeDel"
        Me.ChangeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ChangeDel.Size = New System.Drawing.Size(210, 22)
        Me.ChangeDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'ChangePreView
        '
        Me.ChangePreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.ChangePreView.Name = "ChangePreView"
        Me.ChangePreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ChangePreView.Size = New System.Drawing.Size(210, 22)
        Me.ChangePreView.Text = "查看(&W)..."
        '
        'ChangeRef
        '
        Me.ChangeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ChangeRef.Name = "ChangeRef"
        Me.ChangeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ChangeRef.Size = New System.Drawing.Size(210, 22)
        Me.ChangeRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
        '
        'ChangeCheck
        '
        Me.ChangeCheck.Enabled = False
        Me.ChangeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.ChangeCheck.Name = "ChangeCheck"
        Me.ChangeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ChangeCheck.Size = New System.Drawing.Size(210, 22)
        Me.ChangeCheck.Text = "審核(&G)..."
        '
        'ChangePrint
        '
        Me.ChangePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ChangePrint.Name = "ChangePrint"
        Me.ChangePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ChangePrint.Size = New System.Drawing.Size(210, 22)
        Me.ChangePrint.Text = "更改單(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PC_NO, Me.Pro_Type, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type, Me.PS_Name, Me.DepName, Me.PC_Qty, Me.PC_ReQty, Me.ActionName, Me.PC_Date, Me.PC_Check})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PC_NO
        '
        Me.PC_NO.Caption = "更改單號"
        Me.PC_NO.FieldName = "PC_NO"
        Me.PC_NO.Name = "PC_NO"
        Me.PC_NO.Visible = True
        Me.PC_NO.VisibleIndex = 0
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 1
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        Me.PM_M_Code.Width = 100
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 3
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類型"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 4
        Me.PM_Type.Width = 65
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 5
        '
        'DepName
        '
        Me.DepName.Caption = "更改部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 6
        '
        'PC_Qty
        '
        Me.PC_Qty.Caption = "更改大貨數量"
        Me.PC_Qty.FieldName = "PC_Qty"
        Me.PC_Qty.Name = "PC_Qty"
        Me.PC_Qty.Visible = True
        Me.PC_Qty.VisibleIndex = 7
        Me.PC_Qty.Width = 95
        '
        'PC_ReQty
        '
        Me.PC_ReQty.Caption = "更改返修數量"
        Me.PC_ReQty.FieldName = "PC_ReQty"
        Me.PC_ReQty.Name = "PC_ReQty"
        Me.PC_ReQty.Visible = True
        Me.PC_ReQty.VisibleIndex = 8
        Me.PC_ReQty.Width = 95
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 9
        Me.ActionName.Width = 70
        '
        'PC_Date
        '
        Me.PC_Date.Caption = "更改日期"
        Me.PC_Date.FieldName = "PC_Date"
        Me.PC_Date.Name = "PC_Date"
        Me.PC_Date.Visible = True
        Me.PC_Date.VisibleIndex = 10
        Me.PC_Date.Width = 78
        '
        'PC_Check
        '
        Me.PC_Check.Caption = "審核"
        Me.PC_Check.FieldName = "PC_Check"
        Me.PC_Check.Name = "PC_Check"
        Me.PC_Check.Visible = True
        Me.PC_Check.VisibleIndex = 11
        Me.PC_Check.Width = 50
        '
        'frmProductionFieldChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 418)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionFieldChangeMain"
        Me.Text = "生產更改單管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProductionChange.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProductionChange As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChangePreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChangeCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeReAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PC_ReQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
