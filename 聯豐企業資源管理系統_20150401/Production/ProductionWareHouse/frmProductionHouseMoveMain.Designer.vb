<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionHouseMoveMain
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收入項目", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("發出項目", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("胚部倉")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("生產倉")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("半成品倉")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("成品倉")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("裝配倉", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MV_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_ChangeDepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InOrOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Ack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWM_OutAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWM_InAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareMove = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareMoveOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareMoveIn = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareMoveflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareMove.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv1
        '
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "未審核"
        TreeNode2.Name = "Node4"
        TreeNode2.Text = "已審核"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "收入項目"
        TreeNode4.Name = "Node6"
        TreeNode4.Text = "未審核"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "已審核"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "發出項目"
        Me.tv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6})
        Me.tv1.Size = New System.Drawing.Size(114, 212)
        Me.tv1.TabIndex = 165
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "胚部倉"
        TreeNode8.Name = "Node1"
        TreeNode8.Text = "生產倉"
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "半成品倉"
        TreeNode10.Name = "Node2"
        TreeNode10.Text = "成品倉"
        TreeNode11.Name = "Node0"
        TreeNode11.Text = "裝配倉"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode11})
        Me.TreeView1.Size = New System.Drawing.Size(114, 231)
        Me.TreeView1.TabIndex = 164
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MV_NO, Me.PM_M_Code, Me.PWM_Type, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.MV_Qty, Me.MV_Date, Me.DepotNO, Me.MV_ChangeDepotNO, Me.MV_InOrOut, Me.MV_Ack, Me.MV_Check, Me.PWM_OutAction, Me.PWM_InAction, Me.AutoID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MV_NO
        '
        Me.MV_NO.Caption = "調撥單號"
        Me.MV_NO.FieldName = "PWM_NO"
        Me.MV_NO.Name = "MV_NO"
        Me.MV_NO.OptionsColumn.ReadOnly = True
        Me.MV_NO.Visible = True
        Me.MV_NO.VisibleIndex = 0
        Me.MV_NO.Width = 85
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'PWM_Type
        '
        Me.PWM_Type.Caption = "配件名稱"
        Me.PWM_Type.FieldName = "PWM_Type"
        Me.PWM_Type.Name = "PWM_Type"
        Me.PWM_Type.OptionsColumn.ReadOnly = True
        Me.PWM_Type.Visible = True
        Me.PWM_Type.VisibleIndex = 2
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 3
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 4
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 5
        Me.M_Gauge.Width = 100
        '
        'MV_Qty
        '
        Me.MV_Qty.Caption = "調撥數量"
        Me.MV_Qty.FieldName = "PWM_Qty"
        Me.MV_Qty.Name = "MV_Qty"
        Me.MV_Qty.OptionsColumn.ReadOnly = True
        Me.MV_Qty.Visible = True
        Me.MV_Qty.VisibleIndex = 6
        '
        'MV_Date
        '
        Me.MV_Date.Caption = "日期"
        Me.MV_Date.FieldName = "PWM_AddDate"
        Me.MV_Date.Name = "MV_Date"
        Me.MV_Date.OptionsColumn.ReadOnly = True
        Me.MV_Date.Visible = True
        Me.MV_Date.VisibleIndex = 7
        '
        'DepotNO
        '
        Me.DepotNO.Caption = "發出倉庫"
        Me.DepotNO.FieldName = "PH_OutName"
        Me.DepotNO.Name = "DepotNO"
        Me.DepotNO.OptionsColumn.ReadOnly = True
        Me.DepotNO.Visible = True
        Me.DepotNO.VisibleIndex = 8
        '
        'MV_ChangeDepotNO
        '
        Me.MV_ChangeDepotNO.Caption = "接收倉庫"
        Me.MV_ChangeDepotNO.FieldName = "PH_InName"
        Me.MV_ChangeDepotNO.Name = "MV_ChangeDepotNO"
        Me.MV_ChangeDepotNO.OptionsColumn.ReadOnly = True
        Me.MV_ChangeDepotNO.Visible = True
        Me.MV_ChangeDepotNO.VisibleIndex = 9
        '
        'MV_InOrOut
        '
        Me.MV_InOrOut.Caption = "收發性質"
        Me.MV_InOrOut.FieldName = "PWM_Type"
        Me.MV_InOrOut.Name = "MV_InOrOut"
        Me.MV_InOrOut.OptionsColumn.ReadOnly = True
        '
        'MV_Ack
        '
        Me.MV_Ack.Caption = "確認"
        Me.MV_Ack.FieldName = "PWM_InCheck"
        Me.MV_Ack.Name = "MV_Ack"
        Me.MV_Ack.OptionsColumn.ReadOnly = True
        Me.MV_Ack.Visible = True
        Me.MV_Ack.VisibleIndex = 10
        Me.MV_Ack.Width = 55
        '
        'MV_Check
        '
        Me.MV_Check.Caption = "審核"
        Me.MV_Check.FieldName = "PWM_Check"
        Me.MV_Check.Name = "MV_Check"
        Me.MV_Check.OptionsColumn.ReadOnly = True
        Me.MV_Check.Visible = True
        Me.MV_Check.VisibleIndex = 11
        Me.MV_Check.Width = 55
        '
        'PWM_OutAction
        '
        Me.PWM_OutAction.Caption = "發出操作人"
        Me.PWM_OutAction.FieldName = "PWM_OutAction"
        Me.PWM_OutAction.Name = "PWM_OutAction"
        Me.PWM_OutAction.OptionsColumn.ReadOnly = True
        Me.PWM_OutAction.Visible = True
        Me.PWM_OutAction.VisibleIndex = 12
        Me.PWM_OutAction.Width = 85
        '
        'PWM_InAction
        '
        Me.PWM_InAction.Caption = "收入操作人"
        Me.PWM_InAction.FieldName = "PWM_InAction"
        Me.PWM_InAction.Name = "PWM_InAction"
        Me.PWM_InAction.OptionsColumn.ReadOnly = True
        Me.PWM_InAction.Visible = True
        Me.PWM_InAction.VisibleIndex = 13
        Me.PWM_InAction.Width = 85
        '
        'AutoID
        '
        Me.AutoID.Caption = "流水號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        Me.AutoID.Width = 65
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popWareMove
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(559, 447)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareMove
        '
        Me.popWareMove.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareMoveOutAdd, Me.popWareMoveEdit, Me.popWareMoveDel, Me.popWareMoveView, Me.ToolStripSeparator2, Me.popWareMoveIn, Me.popWareMoveCheck, Me.ToolStripSeparator1, Me.popWareMoveflesh, Me.popWareMoveSeek})
        Me.popWareMove.Name = "popWareInput"
        Me.popWareMove.Size = New System.Drawing.Size(163, 192)
        '
        'popWareMoveOutAdd
        '
        Me.popWareMoveOutAdd.Enabled = False
        Me.popWareMoveOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareMoveOutAdd.Name = "popWareMoveOutAdd"
        Me.popWareMoveOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareMoveOutAdd.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveOutAdd.Text = "發料(&A)..."
        '
        'popWareMoveEdit
        '
        Me.popWareMoveEdit.Enabled = False
        Me.popWareMoveEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareMoveEdit.Name = "popWareMoveEdit"
        Me.popWareMoveEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareMoveEdit.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveEdit.Text = "修改(&E)..."
        '
        'popWareMoveDel
        '
        Me.popWareMoveDel.Enabled = False
        Me.popWareMoveDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareMoveDel.Name = "popWareMoveDel"
        Me.popWareMoveDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareMoveDel.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveDel.Text = "刪除(&D)"
        '
        'popWareMoveView
        '
        Me.popWareMoveView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareMoveView.Name = "popWareMoveView"
        Me.popWareMoveView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareMoveView.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'popWareMoveIn
        '
        Me.popWareMoveIn.Enabled = False
        Me.popWareMoveIn.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popWareMoveIn.Name = "popWareMoveIn"
        Me.popWareMoveIn.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveIn.Text = "收料確認(&K)..."
        '
        'popWareMoveCheck
        '
        Me.popWareMoveCheck.Enabled = False
        Me.popWareMoveCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareMoveCheck.Name = "popWareMoveCheck"
        Me.popWareMoveCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareMoveCheck.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'popWareMoveflesh
        '
        Me.popWareMoveflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareMoveflesh.Name = "popWareMoveflesh"
        Me.popWareMoveflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareMoveflesh.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveflesh.Text = "刷新(&R)..."
        '
        'popWareMoveSeek
        '
        Me.popWareMoveSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareMoveSeek.Name = "popWareMoveSeek"
        Me.popWareMoveSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareMoveSeek.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveSeek.Text = "查詢(&F)..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "生產倉庫調撥"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(676, 36)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(677, 447)
        Me.SplitContainer1.SplitterDistance = 114
        Me.SplitContainer1.TabIndex = 167
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.tv1)
        Me.SplitContainer2.Size = New System.Drawing.Size(114, 447)
        Me.SplitContainer2.SplitterDistance = 231
        Me.SplitContainer2.TabIndex = 0
        '
        'frmProductionHouseMoveMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 447)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionHouseMoveMain"
        Me.Text = "生產倉庫調撥管理"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareMove.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MV_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_ChangeDepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InOrOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Ack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWM_OutAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWM_InAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popWareMove As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareMoveOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareMoveIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareMoveflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWM_Type As DevExpress.XtraGrid.Columns.GridColumn
End Class
