<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareMoveMain
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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收入項目", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未審核")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已審核")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("發出項目", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeWareMoveMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popKnifeWareMove = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdAddKnife = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRemarkEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdIn = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCopyAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMoveRecord = New System.Windows.Forms.ToolStripMenuItem
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
        Me.KnifeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Ack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.MV_OutAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_InAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MV_ChangeDepotNO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popKnifeWareMove.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(-1, 51)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(849, 377)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 45
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
        Me.SplitContainer2.Size = New System.Drawing.Size(140, 377)
        Me.SplitContainer2.SplitterDistance = 218
        Me.SplitContainer2.TabIndex = 0
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
        Me.TreeView1.Size = New System.Drawing.Size(140, 218)
        Me.TreeView1.TabIndex = 35
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
        TreeNode7.Name = "Node1"
        TreeNode7.Text = "未審核"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "已審核"
        TreeNode9.Name = "Node0"
        TreeNode9.Text = "收入項目"
        TreeNode10.Name = "Node6"
        TreeNode10.Text = "未審核"
        TreeNode11.Name = "Node7"
        TreeNode11.Text = "已審核"
        TreeNode12.Name = "Node3"
        TreeNode12.Text = "發出項目"
        Me.tv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode12})
        Me.tv1.Size = New System.Drawing.Size(140, 155)
        Me.tv1.TabIndex = 34
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popKnifeWareMove
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit1})
        Me.Grid1.Size = New System.Drawing.Size(705, 377)
        Me.Grid1.TabIndex = 163
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popKnifeWareMove
        '
        Me.popKnifeWareMove.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdAddKnife, Me.cmdEdit, Me.cmdRemarkEdit, Me.cmdDel, Me.cmdView, Me.cmdLook, Me.ToolStripSeparator2, Me.cmdIn, Me.cmdCheck, Me.ToolStripSeparator1, Me.cmdflesh, Me.cmdSeek, Me.cmdPrint, Me.cmdCopy, Me.cmdCopyAll, Me.ToolStripMenuItem1, Me.ToolStripMoveRecord})
        Me.popKnifeWareMove.Name = "popWareInput"
        Me.popKnifeWareMove.Size = New System.Drawing.Size(214, 374)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(213, 22)
        Me.cmdAdd.Text = "發料--新刀(&A)..."
        '
        'cmdAddKnife
        '
        Me.cmdAddKnife.Enabled = False
        Me.cmdAddKnife.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.cmdAddKnife.Name = "cmdAddKnife"
        Me.cmdAddKnife.Size = New System.Drawing.Size(213, 22)
        Me.cmdAddKnife.Text = "發料--待處理(&K)         Ctrl+K"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(213, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'cmdRemarkEdit
        '
        Me.cmdRemarkEdit.Enabled = False
        Me.cmdRemarkEdit.Name = "cmdRemarkEdit"
        Me.cmdRemarkEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.cmdRemarkEdit.Size = New System.Drawing.Size(213, 22)
        Me.cmdRemarkEdit.Text = "修改備注(&M)"
        Me.cmdRemarkEdit.Visible = False
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(213, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(213, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'cmdLook
        '
        Me.cmdLook.Name = "cmdLook"
        Me.cmdLook.Size = New System.Drawing.Size(213, 22)
        Me.cmdLook.Text = "查看採購單(&S)..."
        Me.cmdLook.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'cmdIn
        '
        Me.cmdIn.Enabled = False
        Me.cmdIn.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.cmdIn.Name = "cmdIn"
        Me.cmdIn.Size = New System.Drawing.Size(213, 22)
        Me.cmdIn.Text = "收料確認(&Y)..."
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(213, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'cmdflesh
        '
        Me.cmdflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdflesh.Name = "cmdflesh"
        Me.cmdflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdflesh.Size = New System.Drawing.Size(213, 22)
        Me.cmdflesh.Text = "刷新(&R)"
        Me.cmdflesh.Visible = False
        '
        'cmdSeek
        '
        Me.cmdSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSeek.Name = "cmdSeek"
        Me.cmdSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdSeek.Size = New System.Drawing.Size(213, 22)
        Me.cmdSeek.Text = "查詢(&F)..."
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(213, 22)
        Me.cmdPrint.Text = "導出(&U)..."
        '
        'cmdCopy
        '
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmdCopy.Size = New System.Drawing.Size(213, 22)
        Me.cmdCopy.Text = "復制(&C)"
        Me.cmdCopy.Visible = False
        '
        'cmdCopyAll
        '
        Me.cmdCopyAll.Name = "cmdCopyAll"
        Me.cmdCopyAll.Size = New System.Drawing.Size(213, 22)
        Me.cmdCopyAll.Text = "全部復制"
        Me.cmdCopyAll.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(210, 6)
        '
        'ToolStripMoveRecord
        '
        Me.ToolStripMoveRecord.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ToolStripMoveRecord.Name = "ToolStripMoveRecord"
        Me.ToolStripMoveRecord.Size = New System.Drawing.Size(213, 22)
        Me.ToolStripMoveRecord.Text = "列印調撥記錄"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MV_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.MV_Qty, Me.M_Unit, Me.MV_Date, Me.DepotNO, Me.MV_ChangeDepotNO, Me.MV_InOrOut, Me.KnifeType, Me.MV_Ack, Me.MV_Check, Me.MV_CheckRemark, Me.MV_OutAction, Me.MV_InAction, Me.DepotNO1, Me.MV_ChangeDepotNO1})
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
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        '
        'M_Name
        '
        Me.M_Name.Caption = "刀具名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "刀具規格"
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
        Me.M_Unit.Width = 48
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
        Me.DepotNO.FieldName = "DepotAllName"
        Me.DepotNO.Name = "DepotNO"
        Me.DepotNO.Visible = True
        Me.DepotNO.VisibleIndex = 8
        Me.DepotNO.Width = 90
        '
        'MV_ChangeDepotNO
        '
        Me.MV_ChangeDepotNO.Caption = "變更倉庫代號"
        Me.MV_ChangeDepotNO.FieldName = "MV_ChangeDepotAllName"
        Me.MV_ChangeDepotNO.Name = "MV_ChangeDepotNO"
        Me.MV_ChangeDepotNO.Visible = True
        Me.MV_ChangeDepotNO.VisibleIndex = 9
        Me.MV_ChangeDepotNO.Width = 90
        '
        'MV_InOrOut
        '
        Me.MV_InOrOut.Caption = "收發性質"
        Me.MV_InOrOut.FieldName = "MV_InOrOut"
        Me.MV_InOrOut.Name = "MV_InOrOut"
        Me.MV_InOrOut.Visible = True
        Me.MV_InOrOut.VisibleIndex = 10
        '
        'KnifeType
        '
        Me.KnifeType.Caption = "刀具屬性"
        Me.KnifeType.FieldName = "KnifeType"
        Me.KnifeType.Name = "KnifeType"
        Me.KnifeType.Visible = True
        Me.KnifeType.VisibleIndex = 7
        Me.KnifeType.Width = 65
        '
        'MV_Ack
        '
        Me.MV_Ack.Caption = "確認"
        Me.MV_Ack.FieldName = "MV_Ack"
        Me.MV_Ack.Name = "MV_Ack"
        Me.MV_Ack.Visible = True
        Me.MV_Ack.VisibleIndex = 11
        Me.MV_Ack.Width = 50
        '
        'MV_Check
        '
        Me.MV_Check.Caption = "審核"
        Me.MV_Check.FieldName = "MV_Check"
        Me.MV_Check.Name = "MV_Check"
        Me.MV_Check.Visible = True
        Me.MV_Check.VisibleIndex = 12
        Me.MV_Check.Width = 50
        '
        'MV_CheckRemark
        '
        Me.MV_CheckRemark.Caption = "備註"
        Me.MV_CheckRemark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.MV_CheckRemark.FieldName = "MV_Remark"
        Me.MV_CheckRemark.Name = "MV_CheckRemark"
        Me.MV_CheckRemark.Visible = True
        Me.MV_CheckRemark.VisibleIndex = 13
        Me.MV_CheckRemark.Width = 100
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'MV_OutAction
        '
        Me.MV_OutAction.Caption = "發出操作人"
        Me.MV_OutAction.FieldName = "MV_OutActionName"
        Me.MV_OutAction.Name = "MV_OutAction"
        Me.MV_OutAction.Visible = True
        Me.MV_OutAction.VisibleIndex = 14
        '
        'MV_InAction
        '
        Me.MV_InAction.Caption = "收入操作人"
        Me.MV_InAction.FieldName = "MV_InActionName"
        Me.MV_InAction.Name = "MV_InAction"
        Me.MV_InAction.Visible = True
        Me.MV_InAction.VisibleIndex = 15
        '
        'DepotNO1
        '
        Me.DepotNO1.Caption = "GridColumn1"
        Me.DepotNO1.FieldName = "DepotNO"
        Me.DepotNO1.Name = "DepotNO1"
        '
        'MV_ChangeDepotNO1
        '
        Me.MV_ChangeDepotNO1.Caption = "GridColumn1"
        Me.MV_ChangeDepotNO1.FieldName = "MV_ChangeDepotNO"
        Me.MV_ChangeDepotNO1.Name = "MV_ChangeDepotNO1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "warehouse.ico")
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 0
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'frmKnifeWareMoveMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 432)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmKnifeWareMoveMain"
        Me.Text = "刀具調撥"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popKnifeWareMove.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MV_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_ChangeDepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InOrOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Ack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_OutAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_InAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popKnifeWareMove As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopyAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KnifeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAddKnife As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MV_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents DepotNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MV_ChangeDepotNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMoveRecord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemarkEdit As System.Windows.Forms.ToolStripMenuItem
End Class
