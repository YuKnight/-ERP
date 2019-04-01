<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionOutWardMain
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
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收入項目", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("發出項目", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收發記錄", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode13})
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.twWare = New System.Windows.Forms.TreeView
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.cmsTrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsInAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsSend = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsInCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPrintAll = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_NO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_OutDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_InDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "生產外發管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 30)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'twWare
        '
        Me.twWare.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.twWare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twWare.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twWare.FullRowSelect = True
        Me.twWare.HideSelection = False
        Me.twWare.Location = New System.Drawing.Point(0, 33)
        Me.twWare.Name = "twWare"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "未審核"
        TreeNode9.Name = "Node5"
        TreeNode9.Text = "已審核"
        TreeNode10.Name = "Node1"
        TreeNode10.Text = "收入項目"
        TreeNode11.Name = "Node11"
        TreeNode11.Text = "未審核"
        TreeNode12.Name = "Node12"
        TreeNode12.Text = "已審核"
        TreeNode13.Name = "Node3"
        TreeNode13.Text = "發出項目"
        TreeNode14.Name = "Node0"
        TreeNode14.Text = "收發記錄"
        Me.twWare.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14})
        Me.twWare.Size = New System.Drawing.Size(133, 383)
        Me.twWare.TabIndex = 42
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsTrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(134, 33)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(532, 382)
        Me.Grid.TabIndex = 166
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsTrip
        '
        Me.cmsTrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsInAdd, Me.cmsOutAdd, Me.cmsSend, Me.ToolStripSeparator1, Me.cmsEdit, Me.cmsDel, Me.ToolStripSeparator2, Me.cmsPreView, Me.cmsQuery, Me.cmsRef, Me.ToolStripSeparator3, Me.cmsInCheck, Me.cmsPrint, Me.cmsPrintAll})
        Me.cmsTrip.Name = "cmsTrip"
        Me.cmsTrip.Size = New System.Drawing.Size(181, 286)
        '
        'cmsInAdd
        '
        Me.cmsInAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsInAdd.Name = "cmsInAdd"
        Me.cmsInAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsInAdd.Size = New System.Drawing.Size(166, 22)
        Me.cmsInAdd.Text = "收料(&A)..."
        '
        'cmsOutAdd
        '
        Me.cmsOutAdd.Image = Global.LFERP.My.Resources.Resources.OutlineDemoteToBodyText
        Me.cmsOutAdd.Name = "cmsOutAdd"
        Me.cmsOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmsOutAdd.Size = New System.Drawing.Size(166, 22)
        Me.cmsOutAdd.Text = "發聯豐(&T)..."
        '
        'cmsSend
        '
        Me.cmsSend.Image = Global.LFERP.My.Resources.Resources.OutlinePromoteToHeading
        Me.cmsSend.Name = "cmsSend"
        Me.cmsSend.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmsSend.Size = New System.Drawing.Size(166, 22)
        Me.cmsSend.Text = "送生產(&S)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'cmsEdit
        '
        Me.cmsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsEdit.Size = New System.Drawing.Size(180, 22)
        Me.cmsEdit.Text = "修改(&E)..."
        '
        'cmsDel
        '
        Me.cmsDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDel.Name = "cmsDel"
        Me.cmsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDel.Size = New System.Drawing.Size(180, 22)
        Me.cmsDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'cmsPreView
        '
        Me.cmsPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsPreView.Name = "cmsPreView"
        Me.cmsPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsPreView.Size = New System.Drawing.Size(180, 22)
        Me.cmsPreView.Text = "查看(&W)..."
        '
        'cmsQuery
        '
        Me.cmsQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsQuery.Name = "cmsQuery"
        Me.cmsQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsQuery.Size = New System.Drawing.Size(180, 22)
        Me.cmsQuery.Text = "查詢(&F)..."
        '
        'cmsRef
        '
        Me.cmsRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsRef.Name = "cmsRef"
        Me.cmsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsRef.Size = New System.Drawing.Size(180, 22)
        Me.cmsRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(163, 6)
        '
        'cmsInCheck
        '
        Me.cmsInCheck.Image = Global.LFERP.My.Resources.Resources.SignatureLineInsertMenu
        Me.cmsInCheck.Name = "cmsInCheck"
        Me.cmsInCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsInCheck.Size = New System.Drawing.Size(180, 22)
        Me.cmsInCheck.Text = "收料確認(&G)..."
        '
        'cmsPrint
        '
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(180, 22)
        Me.cmsPrint.Text = "外發單(&P)..."
        '
        'cmsPrintAll
        '
        Me.cmsPrintAll.Name = "cmsPrintAll"
        Me.cmsPrintAll.Size = New System.Drawing.Size(166, 22)
        Me.cmsPrintAll.Text = "外發匯總信息(&J)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FP_NO, Me.PM_M_Code, Me.Pro_NO, Me.Pro_NO1, Me.FP_OutDep, Me.FP_InDep, Me.FP_Qty, Me.FP_Date, Me.FP_Remark, Me.FP_Type, Me.FP_Detail, Me.FP_Num, Me.FP_Check})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'FP_NO
        '
        Me.FP_NO.Caption = "收發單號"
        Me.FP_NO.FieldName = "FP_NO"
        Me.FP_NO.Name = "FP_NO"
        Me.FP_NO.Visible = True
        Me.FP_NO.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'Pro_NO
        '
        Me.Pro_NO.Caption = "發料工序"
        Me.Pro_NO.FieldName = "PS_Name"
        Me.Pro_NO.Name = "Pro_NO"
        Me.Pro_NO.Visible = True
        Me.Pro_NO.VisibleIndex = 2
        Me.Pro_NO.Width = 88
        '
        'Pro_NO1
        '
        Me.Pro_NO1.Caption = "收料工序"
        Me.Pro_NO1.FieldName = "PS_Name1"
        Me.Pro_NO1.Name = "Pro_NO1"
        Me.Pro_NO1.Visible = True
        Me.Pro_NO1.VisibleIndex = 3
        Me.Pro_NO1.Width = 82
        '
        'FP_OutDep
        '
        Me.FP_OutDep.Caption = "部門"
        Me.FP_OutDep.FieldName = "DepOutName"
        Me.FP_OutDep.Name = "FP_OutDep"
        Me.FP_OutDep.Visible = True
        Me.FP_OutDep.VisibleIndex = 4
        '
        'FP_InDep
        '
        Me.FP_InDep.Caption = "變更部門"
        Me.FP_InDep.FieldName = "DepInName"
        Me.FP_InDep.Name = "FP_InDep"
        Me.FP_InDep.Visible = True
        Me.FP_InDep.VisibleIndex = 5
        '
        'FP_Qty
        '
        Me.FP_Qty.Caption = "數量"
        Me.FP_Qty.FieldName = "FP_Qty"
        Me.FP_Qty.Name = "FP_Qty"
        Me.FP_Qty.Visible = True
        Me.FP_Qty.VisibleIndex = 6
        '
        'FP_Date
        '
        Me.FP_Date.Caption = "日期"
        Me.FP_Date.FieldName = "FP_Date"
        Me.FP_Date.Name = "FP_Date"
        Me.FP_Date.Visible = True
        Me.FP_Date.VisibleIndex = 7
        '
        'FP_Remark
        '
        Me.FP_Remark.Caption = "備註"
        Me.FP_Remark.FieldName = "FP_Remark"
        Me.FP_Remark.Name = "FP_Remark"
        Me.FP_Remark.Visible = True
        Me.FP_Remark.VisibleIndex = 9
        '
        'FP_Type
        '
        Me.FP_Type.Caption = "收發類型"
        Me.FP_Type.FieldName = "FP_Type"
        Me.FP_Type.Name = "FP_Type"
        Me.FP_Type.Visible = True
        Me.FP_Type.VisibleIndex = 8
        '
        'FP_Detail
        '
        Me.FP_Detail.Caption = "屬性"
        Me.FP_Detail.FieldName = "PT_Type"
        Me.FP_Detail.Name = "FP_Detail"
        Me.FP_Detail.Visible = True
        Me.FP_Detail.VisibleIndex = 10
        '
        'FP_Num
        '
        Me.FP_Num.Caption = "流水號"
        Me.FP_Num.FieldName = "FP_Num"
        Me.FP_Num.Name = "FP_Num"
        '
        'FP_Check
        '
        Me.FP_Check.Caption = "審核"
        Me.FP_Check.FieldName = "FP_Check"
        Me.FP_Check.Name = "FP_Check"
        '
        'ProductionOutWardMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 417)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.twWare)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "ProductionOutWardMain"
        Me.Text = "生產外發管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_OutDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_InDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsTrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsInAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsInCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrintAll As System.Windows.Forms.ToolStripMenuItem
End Class
