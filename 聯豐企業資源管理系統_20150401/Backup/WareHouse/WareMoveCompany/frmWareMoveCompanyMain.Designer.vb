<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareMoveCompanyMain
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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("暫存區")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件區")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("驗貨區")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件倉", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("刀具區")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("待發區")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("底蓋倉", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OUT_Company = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OUT_WHID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OUT_WHName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_IN_Company = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_IN_WHID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_IN_WHName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_AddActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_InActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_InDate = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.popWareMoveSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LabBZ = New System.Windows.Forms.Label
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareMove.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tv1.Size = New System.Drawing.Size(140, 178)
        Me.tv1.TabIndex = 34
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.MC_Num, Me.MC_NO, Me.MC_OUT_Company, Me.MC_OUT_WHID, Me.MC_OUT_WHName, Me.MC_IN_Company, Me.MC_IN_WHID, Me.MC_IN_WHName, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.MC_Qty, Me.MC_AddActionName, Me.MC_AddDate, Me.MC_Check, Me.MC_CheckActionName, Me.MC_CheckDate, Me.MC_InCheck, Me.MC_InActionName, Me.MC_InDate})
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
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'MC_Num
        '
        Me.MC_Num.Caption = "調撥流水號"
        Me.MC_Num.FieldName = "MC_Num"
        Me.MC_Num.Name = "MC_Num"
        Me.MC_Num.Visible = True
        Me.MC_Num.VisibleIndex = 0
        '
        'MC_NO
        '
        Me.MC_NO.Caption = "調撥單號"
        Me.MC_NO.FieldName = "MC_NO"
        Me.MC_NO.Name = "MC_NO"
        Me.MC_NO.Visible = True
        Me.MC_NO.VisibleIndex = 1
        Me.MC_NO.Width = 105
        '
        'MC_OUT_Company
        '
        Me.MC_OUT_Company.Caption = "發出公司"
        Me.MC_OUT_Company.FieldName = "MC_OUT_Company"
        Me.MC_OUT_Company.Name = "MC_OUT_Company"
        Me.MC_OUT_Company.Visible = True
        Me.MC_OUT_Company.VisibleIndex = 2
        '
        'MC_OUT_WHID
        '
        Me.MC_OUT_WHID.Caption = "發出倉庫編號"
        Me.MC_OUT_WHID.FieldName = "MC_OUT_WHID"
        Me.MC_OUT_WHID.Name = "MC_OUT_WHID"
        Me.MC_OUT_WHID.Visible = True
        Me.MC_OUT_WHID.VisibleIndex = 3
        '
        'MC_OUT_WHName
        '
        Me.MC_OUT_WHName.Caption = "發出倉庫"
        Me.MC_OUT_WHName.FieldName = "MC_OUT_WHName"
        Me.MC_OUT_WHName.Name = "MC_OUT_WHName"
        Me.MC_OUT_WHName.Visible = True
        Me.MC_OUT_WHName.VisibleIndex = 4
        '
        'MC_IN_Company
        '
        Me.MC_IN_Company.Caption = "收入公司"
        Me.MC_IN_Company.FieldName = "MC_IN_Company"
        Me.MC_IN_Company.Name = "MC_IN_Company"
        Me.MC_IN_Company.Visible = True
        Me.MC_IN_Company.VisibleIndex = 5
        '
        'MC_IN_WHID
        '
        Me.MC_IN_WHID.Caption = "收入倉庫編號"
        Me.MC_IN_WHID.FieldName = "MC_IN_WHID"
        Me.MC_IN_WHID.Name = "MC_IN_WHID"
        Me.MC_IN_WHID.Visible = True
        Me.MC_IN_WHID.VisibleIndex = 6
        '
        'MC_IN_WHName
        '
        Me.MC_IN_WHName.Caption = "收入倉庫"
        Me.MC_IN_WHName.FieldName = "MC_IN_WHName"
        Me.MC_IN_WHName.Name = "MC_IN_WHName"
        Me.MC_IN_WHName.Visible = True
        Me.MC_IN_WHName.VisibleIndex = 7
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 8
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 9
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 10
        '
        'MC_Qty
        '
        Me.MC_Qty.Caption = "數量"
        Me.MC_Qty.FieldName = "MC_Qty"
        Me.MC_Qty.Name = "MC_Qty"
        Me.MC_Qty.Visible = True
        Me.MC_Qty.VisibleIndex = 11
        '
        'MC_AddActionName
        '
        Me.MC_AddActionName.Caption = "增加人"
        Me.MC_AddActionName.FieldName = "MC_AddActionName"
        Me.MC_AddActionName.Name = "MC_AddActionName"
        Me.MC_AddActionName.Visible = True
        Me.MC_AddActionName.VisibleIndex = 12
        '
        'MC_AddDate
        '
        Me.MC_AddDate.Caption = "增加日期"
        Me.MC_AddDate.FieldName = "MC_AddDate"
        Me.MC_AddDate.Name = "MC_AddDate"
        Me.MC_AddDate.Visible = True
        Me.MC_AddDate.VisibleIndex = 13
        '
        'MC_Check
        '
        Me.MC_Check.Caption = "審核"
        Me.MC_Check.FieldName = "MC_Check"
        Me.MC_Check.Name = "MC_Check"
        Me.MC_Check.Visible = True
        Me.MC_Check.VisibleIndex = 14
        '
        'MC_CheckActionName
        '
        Me.MC_CheckActionName.Caption = "審核人員"
        Me.MC_CheckActionName.FieldName = "MC_CheckActionName"
        Me.MC_CheckActionName.Name = "MC_CheckActionName"
        Me.MC_CheckActionName.Visible = True
        Me.MC_CheckActionName.VisibleIndex = 15
        '
        'MC_CheckDate
        '
        Me.MC_CheckDate.Caption = "審核日期"
        Me.MC_CheckDate.FieldName = "MC_CheckDate"
        Me.MC_CheckDate.Name = "MC_CheckDate"
        Me.MC_CheckDate.Visible = True
        Me.MC_CheckDate.VisibleIndex = 16
        '
        'MC_InCheck
        '
        Me.MC_InCheck.Caption = "收料確認"
        Me.MC_InCheck.FieldName = "MC_InCheck"
        Me.MC_InCheck.Name = "MC_InCheck"
        Me.MC_InCheck.Visible = True
        Me.MC_InCheck.VisibleIndex = 17
        '
        'MC_InActionName
        '
        Me.MC_InActionName.Caption = "收料人員"
        Me.MC_InActionName.FieldName = "MC_InActionName"
        Me.MC_InActionName.Name = "MC_InActionName"
        Me.MC_InActionName.Visible = True
        Me.MC_InActionName.VisibleIndex = 18
        '
        'MC_InDate
        '
        Me.MC_InDate.Caption = "收料日期"
        Me.MC_InDate.FieldName = "MC_InDate"
        Me.MC_InDate.Name = "MC_InDate"
        Me.MC_InDate.Visible = True
        Me.MC_InDate.VisibleIndex = 19
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
        Me.Grid1.Size = New System.Drawing.Size(664, 400)
        Me.Grid1.TabIndex = 163
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareMove
        '
        Me.popWareMove.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareMoveOutAdd, Me.popWareMoveEdit, Me.popWareMoveDel, Me.popWareMoveView, Me.ToolStripSeparator2, Me.popWareMoveIn, Me.popWareMoveCheck, Me.ToolStripSeparator1, Me.popWareMoveSeek})
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
        'popWareMoveSeek
        '
        Me.popWareMoveSeek.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.popWareMoveSeek.Name = "popWareMoveSeek"
        Me.popWareMoveSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareMoveSeek.Size = New System.Drawing.Size(162, 22)
        Me.popWareMoveSeek.Text = "查詢(&F)..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "跨廠區調撥"
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
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(808, 400)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 249
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
        Me.SplitContainer2.Size = New System.Drawing.Size(140, 400)
        Me.SplitContainer2.SplitterDistance = 218
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(809, 36)
        Me.PictureBox2.TabIndex = 247
        Me.PictureBox2.TabStop = False
        '
        'LabBZ
        '
        Me.LabBZ.AutoSize = True
        Me.LabBZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabBZ.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabBZ.Location = New System.Drawing.Point(211, 14)
        Me.LabBZ.Name = "LabBZ"
        Me.LabBZ.Size = New System.Drawing.Size(28, 15)
        Me.LabBZ.TabIndex = 252
        Me.LabBZ.Text = "***"
        '
        'frmWareMoveCompanyMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 441)
        Me.Controls.Add(Me.LabBZ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmWareMoveCompanyMain"
        Me.Text = "跨廠區調撥"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareMove.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents popWareMove As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareMoveOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareMoveIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareMoveCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareMoveSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OUT_Company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OUT_WHID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OUT_WHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_IN_Company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_IN_WHID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_IN_WHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_AddActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_InActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_InDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabBZ As System.Windows.Forms.Label
End Class
