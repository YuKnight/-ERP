<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareOutMain
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
        Dim WO_AddDate As DevExpress.XtraGrid.Columns.GridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeWareOutMain))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.popWareOut = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareOutAddNew = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutAddOld = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutAddBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutAdd_Process = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyRemarkTool = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareOutCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popwareOutView = New System.Windows.Forms.ToolStripMenuItem
        Me.popwareOutflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popwareOutLoadFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutPrintColl = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportlStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemALL = New System.Windows.Forms.ToolStripMenuItem
        Me.WareoutcollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WO_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KnifeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_PerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_PerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HKDRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Currency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        WO_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.popWareOut.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WO_AddDate
        '
        WO_AddDate.Caption = "出庫日期"
        WO_AddDate.FieldName = "WO_AddDate"
        WO_AddDate.Name = "WO_AddDate"
        WO_AddDate.OptionsColumn.ReadOnly = True
        WO_AddDate.Visible = True
        WO_AddDate.VisibleIndex = 7
        WO_AddDate.Width = 80
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
        Me.TreeView1.Size = New System.Drawing.Size(112, 407)
        Me.TreeView1.TabIndex = 44
        '
        'popWareOut
        '
        Me.popWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAddNew, Me.popWareOutAddOld, Me.popWareOutAddBarCode, Me.popWareOutAdd_Process, Me.popWareOutEdit, Me.ModifyRemarkTool, Me.popWareOutDel, Me.ToolStripSeparator1, Me.popWareOutCheck, Me.popWareOutReCheck, Me.ToolStripSeparator3, Me.popwareOutView, Me.popwareOutflesh, Me.popWareOutSeek, Me.popwareOutLoadFile, Me.popWareOutPrint, Me.popWareOutPrintColl, Me.ExportlStripMenuItem, Me.ToolStripMenuItem1, Me.CopyToolStripMenuItem, Me.ToolStripMenuItemALL, Me.WareoutcollToolStripMenuItem})
        Me.popWareOut.Name = "popWareInput"
        Me.popWareOut.Size = New System.Drawing.Size(200, 478)
        '
        'popWareOutAddNew
        '
        Me.popWareOutAddNew.Enabled = False
        Me.popWareOutAddNew.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAddNew.Name = "popWareOutAddNew"
        Me.popWareOutAddNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.popWareOutAddNew.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutAddNew.Text = "新增--新刀(&A)..."
        '
        'popWareOutAddOld
        '
        Me.popWareOutAddOld.Enabled = False
        Me.popWareOutAddOld.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.popWareOutAddOld.Name = "popWareOutAddOld"
        Me.popWareOutAddOld.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.popWareOutAddOld.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutAddOld.Text = "新增--待處理(&K)"
        '
        'popWareOutAddBarCode
        '
        Me.popWareOutAddBarCode.Enabled = False
        Me.popWareOutAddBarCode.Name = "popWareOutAddBarCode"
        Me.popWareOutAddBarCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.popWareOutAddBarCode.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutAddBarCode.Text = "新增--條碼掃描-(&J)"
        Me.popWareOutAddBarCode.Visible = False
        '
        'popWareOutAdd_Process
        '
        Me.popWareOutAdd_Process.Enabled = False
        Me.popWareOutAdd_Process.Name = "popWareOutAdd_Process"
        Me.popWareOutAdd_Process.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareOutAdd_Process.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutAdd_Process.Text = "新增--轉工序(&T)..."
        Me.popWareOutAdd_Process.Visible = False
        '
        'popWareOutEdit
        '
        Me.popWareOutEdit.Enabled = False
        Me.popWareOutEdit.Name = "popWareOutEdit"
        Me.popWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareOutEdit.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutEdit.Text = "修改(&E)..."
        Me.popWareOutEdit.Visible = False
        '
        'ModifyRemarkTool
        '
        Me.ModifyRemarkTool.Name = "ModifyRemarkTool"
        Me.ModifyRemarkTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ModifyRemarkTool.Size = New System.Drawing.Size(199, 22)
        Me.ModifyRemarkTool.Text = "修改備注(&K)"
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Enabled = False
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        Me.popWareOutDel.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'popWareOutCheck
        '
        Me.popWareOutCheck.Enabled = False
        Me.popWareOutCheck.Name = "popWareOutCheck"
        Me.popWareOutCheck.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutCheck.Text = "審核(&Z)..."
        Me.popWareOutCheck.Visible = False
        '
        'popWareOutReCheck
        '
        Me.popWareOutReCheck.Enabled = False
        Me.popWareOutReCheck.Name = "popWareOutReCheck"
        Me.popWareOutReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareOutReCheck.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutReCheck.Text = "復核(&G)..."
        Me.popWareOutReCheck.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'popwareOutView
        '
        Me.popwareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popwareOutView.Name = "popwareOutView"
        Me.popwareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popwareOutView.Size = New System.Drawing.Size(199, 22)
        Me.popwareOutView.Text = "查看(&W)..."
        '
        'popwareOutflesh
        '
        Me.popwareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popwareOutflesh.Name = "popwareOutflesh"
        Me.popwareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popwareOutflesh.Size = New System.Drawing.Size(199, 22)
        Me.popwareOutflesh.Text = "刷新(&R)"
        '
        'popWareOutSeek
        '
        Me.popWareOutSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareOutSeek.Name = "popWareOutSeek"
        Me.popWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareOutSeek.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutSeek.Text = "查詢(&F)..."
        '
        'popwareOutLoadFile
        '
        Me.popwareOutLoadFile.Name = "popwareOutLoadFile"
        Me.popwareOutLoadFile.Size = New System.Drawing.Size(199, 22)
        Me.popwareOutLoadFile.Text = "附加文件(&B)..."
        Me.popwareOutLoadFile.Visible = False
        '
        'popWareOutPrint
        '
        Me.popWareOutPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutPrint.Name = "popWareOutPrint"
        Me.popWareOutPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareOutPrint.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutPrint.Text = "出庫單(&P)..."
        '
        'popWareOutPrintColl
        '
        Me.popWareOutPrintColl.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutPrintColl.Name = "popWareOutPrintColl"
        Me.popWareOutPrintColl.Size = New System.Drawing.Size(199, 22)
        Me.popWareOutPrintColl.Text = "出庫單匯總"
        '
        'ExportlStripMenuItem
        '
        Me.ExportlStripMenuItem.Name = "ExportlStripMenuItem"
        Me.ExportlStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ExportlStripMenuItem.Text = "導出(&U)..."
        Me.ExportlStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItem1.Text = "導出1(&E)"
        Me.ToolStripMenuItem1.Visible = False
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CopyToolStripMenuItem.Text = "復制(&C)"
        Me.CopyToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItemALL
        '
        Me.ToolStripMenuItemALL.Name = "ToolStripMenuItemALL"
        Me.ToolStripMenuItemALL.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItemALL.Text = "全部復制"
        Me.ToolStripMenuItemALL.Visible = False
        '
        'WareoutcollToolStripMenuItem
        '
        Me.WareoutcollToolStripMenuItem.Enabled = False
        Me.WareoutcollToolStripMenuItem.Name = "WareoutcollToolStripMenuItem"
        Me.WareoutcollToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.WareoutcollToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.WareoutcollToolStripMenuItem.Text = "出庫月匯總(&H)"
        Me.WareoutcollToolStripMenuItem.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 51)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(761, 407)
        Me.SplitContainer1.SplitterDistance = 112
        Me.SplitContainer1.TabIndex = 45
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popWareOut
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(645, 407)
        Me.Grid1.TabIndex = 168
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WO_NUM, Me.WO_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WO_Qty, Me.KnifeType, Me.M_Unit, Me.WO_Check, Me.OS_BatchID, Me.WO_PerName, Me.GridColumn1, Me.WO_ActionName, Me.GridColumn2, WO_AddDate, Me.WO_CheckRemark, Me.WO_PerID, Me.AP_NO, Me.WO_ReCheck, Me.HKDRate, Me.M_Currency, Me.M_Price})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'WO_NUM
        '
        Me.WO_NUM.Caption = "唯一編號"
        Me.WO_NUM.FieldName = "WO_NUM"
        Me.WO_NUM.Name = "WO_NUM"
        Me.WO_NUM.OptionsColumn.ReadOnly = True
        '
        'WO_ID
        '
        Me.WO_ID.Caption = "出庫單號"
        Me.WO_ID.FieldName = "WO_ID"
        Me.WO_ID.Name = "WO_ID"
        Me.WO_ID.OptionsColumn.ReadOnly = True
        Me.WO_ID.Visible = True
        Me.WO_ID.VisibleIndex = 0
        Me.WO_ID.Width = 90
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 125
        '
        'M_Name
        '
        Me.M_Name.Caption = "刀具名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 100
        '
        'WO_Qty
        '
        Me.WO_Qty.Caption = "出庫數量"
        Me.WO_Qty.FieldName = "WO_Qty"
        Me.WO_Qty.Name = "WO_Qty"
        Me.WO_Qty.OptionsColumn.ReadOnly = True
        Me.WO_Qty.Visible = True
        Me.WO_Qty.VisibleIndex = 4
        '
        'KnifeType
        '
        Me.KnifeType.Caption = "刀具屬性"
        Me.KnifeType.FieldName = "KnifeType"
        Me.KnifeType.Name = "KnifeType"
        Me.KnifeType.Visible = True
        Me.KnifeType.VisibleIndex = 5
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 6
        Me.M_Unit.Width = 50
        '
        'WO_Check
        '
        Me.WO_Check.Caption = "審核"
        Me.WO_Check.FieldName = "WO_Check"
        Me.WO_Check.Name = "WO_Check"
        Me.WO_Check.OptionsColumn.ReadOnly = True
        Me.WO_Check.Width = 50
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.OptionsColumn.ReadOnly = True
        '
        'WO_PerName
        '
        Me.WO_PerName.Caption = "領料人姓名"
        Me.WO_PerName.FieldName = "WO_PerNameS"
        Me.WO_PerName.Name = "WO_PerName"
        Me.WO_PerName.OptionsColumn.ReadOnly = True
        Me.WO_PerName.Visible = True
        Me.WO_PerName.VisibleIndex = 12
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "領料部門"
        Me.GridColumn1.FieldName = "DPT_Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'WO_ActionName
        '
        Me.WO_ActionName.Caption = "操作員"
        Me.WO_ActionName.FieldName = "WO_ActionName"
        Me.WO_ActionName.Name = "WO_ActionName"
        Me.WO_ActionName.OptionsColumn.ReadOnly = True
        Me.WO_ActionName.Visible = True
        Me.WO_ActionName.VisibleIndex = 9
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "備註"
        Me.GridColumn2.FieldName = "WO_Remark"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 10
        '
        'WO_CheckRemark
        '
        Me.WO_CheckRemark.Caption = "審核備注"
        Me.WO_CheckRemark.FieldName = "WO_CheckRemark"
        Me.WO_CheckRemark.Name = "WO_CheckRemark"
        Me.WO_CheckRemark.OptionsColumn.ReadOnly = True
        Me.WO_CheckRemark.Width = 100
        '
        'WO_PerID
        '
        Me.WO_PerID.Caption = "領料人工號"
        Me.WO_PerID.FieldName = "WO_PerID"
        Me.WO_PerID.Name = "WO_PerID"
        Me.WO_PerID.OptionsColumn.ReadOnly = True
        Me.WO_PerID.Visible = True
        Me.WO_PerID.VisibleIndex = 11
        '
        'AP_NO
        '
        Me.AP_NO.Caption = "申領單號"
        Me.AP_NO.FieldName = "AP_NO"
        Me.AP_NO.Name = "AP_NO"
        Me.AP_NO.OptionsColumn.ReadOnly = True
        '
        'WO_ReCheck
        '
        Me.WO_ReCheck.Caption = "復核"
        Me.WO_ReCheck.FieldName = "WO_ReCheck"
        Me.WO_ReCheck.Name = "WO_ReCheck"
        Me.WO_ReCheck.OptionsColumn.ReadOnly = True
        Me.WO_ReCheck.Width = 50
        '
        'HKDRate
        '
        Me.HKDRate.Caption = "兌港幣"
        Me.HKDRate.FieldName = "HKDRate"
        Me.HKDRate.Name = "HKDRate"
        Me.HKDRate.OptionsColumn.ReadOnly = True
        '
        'M_Currency
        '
        Me.M_Currency.Caption = "幣別"
        Me.M_Currency.FieldName = "M_Currency"
        Me.M_Currency.Name = "M_Currency"
        Me.M_Currency.OptionsColumn.ReadOnly = True
        '
        'M_Price
        '
        Me.M_Price.Caption = "單價"
        Me.M_Price.FieldName = "M_Price"
        Me.M_Price.Name = "M_Price"
        Me.M_Price.OptionsColumn.ReadOnly = True
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.barDockControlTop)
        Me.BarManager2.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager2.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager2.DockControls.Add(Me.barDockControlRight)
        Me.BarManager2.Form = Me
        Me.BarManager2.MainMenu = Me.Bar2
        Me.BarManager2.MaxItemId = 2
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "warehouse.ico")
        '
        'frmKnifeWareOutMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 460)
        Me.ContextMenuStrip = Me.popWareOut
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmKnifeWareOutMain"
        Me.Text = "刀具出庫"
        Me.popWareOut.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents popWareOut As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareOutAddNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutAddBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutAdd_Process As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRemarkTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareOutCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popwareOutView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popwareOutflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popwareOutLoadFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportlStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareoutcollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WO_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_PerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_PerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HKDRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Currency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOutAddOld As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KnifeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents popWareOutPrintColl As System.Windows.Forms.ToolStripMenuItem
End Class
