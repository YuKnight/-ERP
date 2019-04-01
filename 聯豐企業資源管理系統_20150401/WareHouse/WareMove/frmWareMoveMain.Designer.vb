<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareMoveMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("暫存區")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件區")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("驗貨區")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件倉", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("刀具區")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("待發區")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("底蓋倉", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Me.Label1 = New System.Windows.Forms.Label
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareMove = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareMoveOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveView = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveLook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareMoveIn = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareMoveflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMoveSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareMovePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemALL = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MV_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_ChangeDepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InOrOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Ack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_OutAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareMove.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "調撥作業"
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
        Me.tv1.Size = New System.Drawing.Size(140, 165)
        Me.tv1.TabIndex = 34
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
        TreeNode7.Name = "Node2"
        TreeNode7.Text = "暫存區"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "配件區"
        TreeNode9.Name = "Node5"
        TreeNode9.Text = "驗貨區"
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "配件倉"
        TreeNode11.Name = "Node6"
        TreeNode11.Text = "刀具區"
        TreeNode12.Name = "Node7"
        TreeNode12.Text = "待發區"
        TreeNode13.Name = "Node1"
        TreeNode13.Text = "底蓋倉"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode13})
        Me.TreeView1.Size = New System.Drawing.Size(140, 218)
        Me.TreeView1.TabIndex = 35
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer2.Size = New System.Drawing.Size(140, 387)
        Me.SplitContainer2.SplitterDistance = 218
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(652, 387)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 43
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
        Me.Grid1.Size = New System.Drawing.Size(508, 387)
        Me.Grid1.TabIndex = 163
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareMove
        '
        Me.popWareMove.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareMoveOutAdd, Me.popWareMoveEdit, Me.popWareMoveDel, Me.popWareMoveView, Me.popWareMoveLook, Me.ToolStripSeparator2, Me.popWareMoveIn, Me.popWareMoveCheck, Me.ToolStripSeparator1, Me.popWareMoveflesh, Me.popWareMoveSeek, Me.popWareMovePrint, Me.COPYToolStripMenuItem, Me.ToolStripMenuItemALL})
        Me.popWareMove.Name = "popWareInput"
        Me.popWareMove.Size = New System.Drawing.Size(163, 302)
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
        'popWareMoveLook
        '
        Me.popWareMoveLook.Name = "popWareMoveLook"
        Me.popWareMoveLook.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveLook.Text = "查看採購單(&S)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'popWareMoveIn
        '
        Me.popWareMoveIn.Enabled = False
        Me.popWareMoveIn.Name = "popWareMoveIn"
        Me.popWareMoveIn.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveIn.Text = "收料確認(&Y)..."
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
        Me.popWareMoveflesh.Text = "刷新(&R)"
        Me.popWareMoveflesh.Visible = False
        '
        'popWareMoveSeek
        '
        Me.popWareMoveSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareMoveSeek.Name = "popWareMoveSeek"
        Me.popWareMoveSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareMoveSeek.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveSeek.Text = "查詢(&F)..."
        '
        'popWareMovePrint
        '
        Me.popWareMovePrint.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.popWareMovePrint.Name = "popWareMovePrint"
        Me.popWareMovePrint.Size = New System.Drawing.Size(162, 22)
        Me.popWareMovePrint.Text = "導出(&U)..."
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.COPYToolStripMenuItem.Text = "復制(&C)"
        '
        'ToolStripMenuItemALL
        '
        Me.ToolStripMenuItemALL.Name = "ToolStripMenuItemALL"
        Me.ToolStripMenuItemALL.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItemALL.Text = "全部復制"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MV_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.MV_Qty, Me.M_Unit, Me.MV_Date, Me.DepotNO, Me.MV_ChangeDepotNO, Me.MV_InOrOut, Me.MV_Ack, Me.MV_Check, Me.MV_OutAction, Me.MV_InAction})
        Me.GridView1.GridControl = Me.Grid1
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
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MV_NO
        '
        Me.MV_NO.Caption = "調撥單號"
        Me.MV_NO.FieldName = "MV_NO"
        Me.MV_NO.Name = "MV_NO"
        Me.MV_NO.Visible = True
        Me.MV_NO.VisibleIndex = 0
        Me.MV_NO.Width = 91
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'MV_Qty
        '
        Me.MV_Qty.Caption = "調撥數量"
        Me.MV_Qty.FieldName = "MV_Qty"
        Me.MV_Qty.Name = "MV_Qty"
        Me.MV_Qty.Visible = True
        Me.MV_Qty.VisibleIndex = 4
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 5
        '
        'MV_Date
        '
        Me.MV_Date.Caption = "日期"
        Me.MV_Date.FieldName = "MV_Date"
        Me.MV_Date.Name = "MV_Date"
        Me.MV_Date.Visible = True
        Me.MV_Date.VisibleIndex = 6
        '
        'DepotNO
        '
        Me.DepotNO.Caption = "倉庫代號"
        Me.DepotNO.FieldName = "DepotNO"
        Me.DepotNO.Name = "DepotNO"
        Me.DepotNO.Visible = True
        Me.DepotNO.VisibleIndex = 7
        '
        'MV_ChangeDepotNO
        '
        Me.MV_ChangeDepotNO.Caption = "變更倉庫代號"
        Me.MV_ChangeDepotNO.FieldName = "MV_ChangeDepotNO"
        Me.MV_ChangeDepotNO.Name = "MV_ChangeDepotNO"
        Me.MV_ChangeDepotNO.Visible = True
        Me.MV_ChangeDepotNO.VisibleIndex = 8
        '
        'MV_InOrOut
        '
        Me.MV_InOrOut.Caption = "收發性質"
        Me.MV_InOrOut.FieldName = "MV_InOrOut"
        Me.MV_InOrOut.Name = "MV_InOrOut"
        Me.MV_InOrOut.Visible = True
        Me.MV_InOrOut.VisibleIndex = 9
        '
        'MV_Ack
        '
        Me.MV_Ack.Caption = "確認"
        Me.MV_Ack.FieldName = "MV_Ack"
        Me.MV_Ack.Name = "MV_Ack"
        Me.MV_Ack.Visible = True
        Me.MV_Ack.VisibleIndex = 10
        '
        'MV_Check
        '
        Me.MV_Check.Caption = "審核"
        Me.MV_Check.FieldName = "MV_Check"
        Me.MV_Check.Name = "MV_Check"
        Me.MV_Check.Visible = True
        Me.MV_Check.VisibleIndex = 11
        '
        'MV_OutAction
        '
        Me.MV_OutAction.Caption = "發出操作人"
        Me.MV_OutAction.FieldName = "MV_OutAction"
        Me.MV_OutAction.Name = "MV_OutAction"
        Me.MV_OutAction.Visible = True
        Me.MV_OutAction.VisibleIndex = 12
        '
        'MV_InAction
        '
        Me.MV_InAction.Caption = "收入操作人"
        Me.MV_InAction.FieldName = "MV_InAction"
        Me.MV_InAction.Name = "MV_InAction"
        Me.MV_InAction.Visible = True
        Me.MV_InAction.VisibleIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(652, 36)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'frmWareMoveMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 432)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmWareMoveMain"
        Me.Text = "調撥作業"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareMove.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents MV_OutAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareMove As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareMoveOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareMovePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareMoveLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
End Class
