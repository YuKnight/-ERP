<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionWareOutMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.popWareOut = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareOutCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareOutflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutReport = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PWO_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_WareName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareOut.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.popWareOut
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 37)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(672, 393)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareOut
        '
        Me.popWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.popWareOutEdit, Me.popWareOutDel, Me.popWareOutView, Me.ToolStripSeparator2, Me.popWareOutCheck, Me.ToolStripSeparator1, Me.popWareOutflesh, Me.popWareOutSeek, Me.popWareOutReport})
        Me.popWareOut.Name = "popWareInput"
        Me.popWareOut.Size = New System.Drawing.Size(194, 192)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Enabled = False
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutAdd.Text = "出貨(&A)..."
        '
        'popWareOutEdit
        '
        Me.popWareOutEdit.Enabled = False
        Me.popWareOutEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareOutEdit.Name = "popWareOutEdit"
        Me.popWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareOutEdit.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutEdit.Text = "修改(&E)..."
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Enabled = False
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'popWareOutView
        '
        Me.popWareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareOutView.Name = "popWareOutView"
        Me.popWareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareOutView.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'popWareOutCheck
        '
        Me.popWareOutCheck.Enabled = False
        Me.popWareOutCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareOutCheck.Name = "popWareOutCheck"
        Me.popWareOutCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareOutCheck.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'popWareOutflesh
        '
        Me.popWareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareOutflesh.Name = "popWareOutflesh"
        Me.popWareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareOutflesh.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutflesh.Text = "刷新(&R)"
        '
        'popWareOutSeek
        '
        Me.popWareOutSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareOutSeek.Name = "popWareOutSeek"
        Me.popWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareOutSeek.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutSeek.Text = "查詢(&F)..."
        '
        'popWareOutReport
        '
        Me.popWareOutReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutReport.Name = "popWareOutReport"
        Me.popWareOutReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareOutReport.Size = New System.Drawing.Size(193, 22)
        Me.popWareOutReport.Text = "出貨單(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PWO_NO, Me.PS_Num, Me.PWO_M_Code, Me.M_Name, Me.PWO_WareName, Me.PWO_DepName, Me.PWO_Qty, Me.PWO_AddDate, Me.PWO_Action, Me.PWO_Check, Me.PWO_CheckDate, Me.PWO_CheckAction, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PWO_NO
        '
        Me.PWO_NO.Caption = "出貨單號"
        Me.PWO_NO.FieldName = "PWO_NO"
        Me.PWO_NO.Name = "PWO_NO"
        Me.PWO_NO.Visible = True
        Me.PWO_NO.VisibleIndex = 0
        Me.PWO_NO.Width = 95
        '
        'PS_Num
        '
        Me.PS_Num.Caption = "項目流水號"
        Me.PS_Num.FieldName = "PS_Num"
        Me.PS_Num.Name = "PS_Num"
        Me.PS_Num.Width = 90
        '
        'PWO_M_Code
        '
        Me.PWO_M_Code.Caption = "物料編碼"
        Me.PWO_M_Code.FieldName = "PWO_M_Code"
        Me.PWO_M_Code.Name = "PWO_M_Code"
        Me.PWO_M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 4
        Me.M_Name.Width = 65
        '
        'PWO_WareName
        '
        Me.PWO_WareName.Caption = "出貨倉庫"
        Me.PWO_WareName.FieldName = "PWO_OutName"
        Me.PWO_WareName.Name = "PWO_WareName"
        Me.PWO_WareName.Visible = True
        Me.PWO_WareName.VisibleIndex = 5
        '
        'PWO_DepName
        '
        Me.PWO_DepName.Caption = "出貨部門"
        Me.PWO_DepName.FieldName = "PWO_DepName"
        Me.PWO_DepName.Name = "PWO_DepName"
        Me.PWO_DepName.Visible = True
        Me.PWO_DepName.VisibleIndex = 6
        '
        'PWO_Qty
        '
        Me.PWO_Qty.Caption = "出貨數量"
        Me.PWO_Qty.FieldName = "PWO_Qty"
        Me.PWO_Qty.Name = "PWO_Qty"
        Me.PWO_Qty.Visible = True
        Me.PWO_Qty.VisibleIndex = 7
        '
        'PWO_AddDate
        '
        Me.PWO_AddDate.Caption = "出貨日期"
        Me.PWO_AddDate.FieldName = "PWO_AddDate"
        Me.PWO_AddDate.Name = "PWO_AddDate"
        Me.PWO_AddDate.Visible = True
        Me.PWO_AddDate.VisibleIndex = 8
        '
        'PWO_Action
        '
        Me.PWO_Action.Caption = "操作員"
        Me.PWO_Action.FieldName = "PWO_ActionName"
        Me.PWO_Action.Name = "PWO_Action"
        Me.PWO_Action.Visible = True
        Me.PWO_Action.VisibleIndex = 9
        Me.PWO_Action.Width = 65
        '
        'PWO_Check
        '
        Me.PWO_Check.Caption = "審核"
        Me.PWO_Check.FieldName = "PWO_Check"
        Me.PWO_Check.Name = "PWO_Check"
        Me.PWO_Check.Visible = True
        Me.PWO_Check.VisibleIndex = 10
        Me.PWO_Check.Width = 55
        '
        'PWO_CheckDate
        '
        Me.PWO_CheckDate.Caption = "審核日期"
        Me.PWO_CheckDate.FieldName = "PWO_CheckDate"
        Me.PWO_CheckDate.Name = "PWO_CheckDate"
        '
        'PWO_CheckAction
        '
        Me.PWO_CheckAction.Caption = "審核員"
        Me.PWO_CheckAction.FieldName = "PWO_CheckActionName"
        Me.PWO_CheckAction.Name = "PWO_CheckAction"
        Me.PWO_CheckAction.Visible = True
        Me.PWO_CheckAction.VisibleIndex = 11
        Me.PWO_CheckAction.Width = 65
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
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
        Me.PM_JiYu.VisibleIndex = 2
        Me.PM_JiYu.Width = 65
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.AllowEdit = False
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "生產倉出貨"
        '
        'ProductionWareOutMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 430)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "ProductionWareOutMain"
        Me.Text = "生產倉出貨"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareOut.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PWO_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_WareName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PWO_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOut As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareOutCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareOutflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
