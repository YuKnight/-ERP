<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareOutMain
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
        Dim WO_AddDate As DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareOut = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutAddBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemPD = New System.Windows.Forms.ToolStripMenuItem
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
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popwareOutLoadFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportlStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemALL = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.WareoutcollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WO_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_PerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_PerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HKDRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Currency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        WO_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareOut.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(664, 432)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 43
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
        Me.TreeView1.Size = New System.Drawing.Size(125, 432)
        Me.TreeView1.TabIndex = 41
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
        Me.Grid1.Size = New System.Drawing.Size(535, 432)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popWareOut
        '
        Me.popWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.popWareOutAddBarCode, Me.ToolStripMenuItemPD, Me.popWareOutAdd_Process, Me.popWareOutEdit, Me.ModifyRemarkTool, Me.popWareOutDel, Me.ToolStripSeparator1, Me.popWareOutCheck, Me.popWareOutReCheck, Me.ToolStripSeparator3, Me.popwareOutView, Me.popwareOutflesh, Me.popWareOutSeek, Me.ToolStripSeparator2, Me.popwareOutLoadFile, Me.popWareOutPrint, Me.ExportlStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator4, Me.CopyToolStripMenuItem, Me.ToolStripMenuItemALL, Me.ToolStripMenuItem2, Me.WareoutcollToolStripMenuItem})
        Me.popWareOut.Name = "popWareInput"
        Me.popWareOut.Size = New System.Drawing.Size(199, 474)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Enabled = False
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutAdd.Text = "新增(&A)..."
        '
        'popWareOutAddBarCode
        '
        Me.popWareOutAddBarCode.Enabled = False
        Me.popWareOutAddBarCode.Name = "popWareOutAddBarCode"
        Me.popWareOutAddBarCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.popWareOutAddBarCode.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutAddBarCode.Text = "新增(條碼掃描)(&J)"
        '
        'ToolStripMenuItemPD
        '
        Me.ToolStripMenuItemPD.Name = "ToolStripMenuItemPD"
        Me.ToolStripMenuItemPD.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItemPD.Text = "新增(盤點機)"
        Me.ToolStripMenuItemPD.Visible = False
        '
        'popWareOutAdd_Process
        '
        Me.popWareOutAdd_Process.Enabled = False
        Me.popWareOutAdd_Process.Name = "popWareOutAdd_Process"
        Me.popWareOutAdd_Process.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareOutAdd_Process.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutAdd_Process.Text = "新增(轉工序)(&T)..."
        '
        'popWareOutEdit
        '
        Me.popWareOutEdit.Enabled = False
        Me.popWareOutEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareOutEdit.Name = "popWareOutEdit"
        Me.popWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareOutEdit.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutEdit.Text = "修改(&E)..."
        '
        'ModifyRemarkTool
        '
        Me.ModifyRemarkTool.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ModifyRemarkTool.Name = "ModifyRemarkTool"
        Me.ModifyRemarkTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ModifyRemarkTool.Size = New System.Drawing.Size(198, 22)
        Me.ModifyRemarkTool.Text = "修改備注(&K)"
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Enabled = False
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'popWareOutCheck
        '
        Me.popWareOutCheck.Enabled = False
        Me.popWareOutCheck.Name = "popWareOutCheck"
        Me.popWareOutCheck.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutCheck.Text = "取消審核(&Z)..."
        '
        'popWareOutReCheck
        '
        Me.popWareOutReCheck.Enabled = False
        Me.popWareOutReCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareOutReCheck.Name = "popWareOutReCheck"
        Me.popWareOutReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareOutReCheck.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutReCheck.Text = "復核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(195, 6)
        '
        'popwareOutView
        '
        Me.popwareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popwareOutView.Name = "popwareOutView"
        Me.popwareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popwareOutView.Size = New System.Drawing.Size(198, 22)
        Me.popwareOutView.Text = "查看(&W)..."
        '
        'popwareOutflesh
        '
        Me.popwareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popwareOutflesh.Name = "popwareOutflesh"
        Me.popwareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popwareOutflesh.Size = New System.Drawing.Size(198, 22)
        Me.popwareOutflesh.Text = "刷新(&R)"
        '
        'popWareOutSeek
        '
        Me.popWareOutSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareOutSeek.Name = "popWareOutSeek"
        Me.popWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareOutSeek.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'popwareOutLoadFile
        '
        Me.popwareOutLoadFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popwareOutLoadFile.Name = "popwareOutLoadFile"
        Me.popwareOutLoadFile.Size = New System.Drawing.Size(198, 22)
        Me.popwareOutLoadFile.Text = "附加文件(&B)..."
        '
        'popWareOutPrint
        '
        Me.popWareOutPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutPrint.Name = "popWareOutPrint"
        Me.popWareOutPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareOutPrint.Size = New System.Drawing.Size(198, 22)
        Me.popWareOutPrint.Text = "出庫單(&P)..."
        '
        'ExportlStripMenuItem
        '
        Me.ExportlStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExportlStripMenuItem.Name = "ExportlStripMenuItem"
        Me.ExportlStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ExportlStripMenuItem.Text = "導出(&U)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItem1.Text = "導出1(&E)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(195, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CopyToolStripMenuItem.Text = "復制(&C)"
        '
        'ToolStripMenuItemALL
        '
        Me.ToolStripMenuItemALL.Name = "ToolStripMenuItemALL"
        Me.ToolStripMenuItemALL.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItemALL.Text = "全部復制"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 6)
        '
        'WareoutcollToolStripMenuItem
        '
        Me.WareoutcollToolStripMenuItem.Enabled = False
        Me.WareoutcollToolStripMenuItem.Name = "WareoutcollToolStripMenuItem"
        Me.WareoutcollToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.WareoutcollToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.WareoutcollToolStripMenuItem.Text = "出庫月匯總(&H)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WO_NUM, Me.WO_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WO_Qty, Me.M_Unit, Me.WH_AllName, Me.OS_BatchID, Me.WO_PerName, Me.GridColumn1, Me.WO_ActionName, Me.GridColumn2, Me.WO_Check, WO_AddDate, Me.WO_CheckRemark, Me.WO_PerID, Me.AP_NO, Me.WO_ReCheck, Me.HKDRate, Me.M_Currency, Me.M_Price})
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
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 125
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
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
        Me.WO_Qty.Width = 65
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 5
        Me.M_Unit.Width = 50
        '
        'WH_AllName
        '
        Me.WH_AllName.Caption = "倉庫名稱"
        Me.WH_AllName.FieldName = "WH_AllName"
        Me.WH_AllName.Name = "WH_AllName"
        Me.WH_AllName.OptionsColumn.ReadOnly = True
        Me.WH_AllName.Visible = True
        Me.WH_AllName.VisibleIndex = 6
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
        Me.WO_PerName.Caption = "領料人"
        Me.WO_PerName.FieldName = "WO_PerName"
        Me.WO_PerName.Name = "WO_PerName"
        Me.WO_PerName.OptionsColumn.ReadOnly = True
        Me.WO_PerName.Visible = True
        Me.WO_PerName.VisibleIndex = 9
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "領料部門"
        Me.GridColumn1.FieldName = "DPT_Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        '
        'WO_ActionName
        '
        Me.WO_ActionName.Caption = "操作員"
        Me.WO_ActionName.FieldName = "WO_ActionName"
        Me.WO_ActionName.Name = "WO_ActionName"
        Me.WO_ActionName.OptionsColumn.ReadOnly = True
        Me.WO_ActionName.Visible = True
        Me.WO_ActionName.VisibleIndex = 11
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "備註"
        Me.GridColumn2.FieldName = "WO_Remark"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 12
        '
        'WO_Check
        '
        Me.WO_Check.Caption = "審核"
        Me.WO_Check.FieldName = "WO_Check"
        Me.WO_Check.Name = "WO_Check"
        Me.WO_Check.OptionsColumn.ReadOnly = True
        Me.WO_Check.Width = 50
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
        Me.WO_PerID.VisibleIndex = 14
        '
        'AP_NO
        '
        Me.AP_NO.Caption = "申領單號"
        Me.AP_NO.FieldName = "AP_NO"
        Me.AP_NO.Name = "AP_NO"
        Me.AP_NO.OptionsColumn.ReadOnly = True
        Me.AP_NO.Visible = True
        Me.AP_NO.VisibleIndex = 8
        '
        'WO_ReCheck
        '
        Me.WO_ReCheck.Caption = "復核"
        Me.WO_ReCheck.FieldName = "WO_ReCheck"
        Me.WO_ReCheck.Name = "WO_ReCheck"
        Me.WO_ReCheck.OptionsColumn.ReadOnly = True
        Me.WO_ReCheck.Visible = True
        Me.WO_ReCheck.VisibleIndex = 13
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "出庫作業"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(664, 36)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'frmWareOutMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 477)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareOutMain"
        Me.Text = "出庫作業"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareOut.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents WO_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_PerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOut As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popwareOutflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popwareOutView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WO_PerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExportlStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popwareOutLoadFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOutReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOutAdd_Process As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WareoutcollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HKDRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Currency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareOutAddBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRemarkTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemALL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemPD As System.Windows.Forms.ToolStripMenuItem
End Class
