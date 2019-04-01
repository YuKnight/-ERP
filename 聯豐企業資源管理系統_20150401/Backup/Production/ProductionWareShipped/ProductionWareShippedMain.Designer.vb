<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionWareShippedMain
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
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
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareOutReport = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInTotalAReport = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PWS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_WareName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InWareName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InAddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareIn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareInView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInInCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInTotalBReport = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInReport = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PWS_NOB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NumB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_M_CodeB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_NameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_OutNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_DepNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_QtyB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_AddDateB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_ActionNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InAddDateB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InActionNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_InCheckB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckDateB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_CheckActionNameB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_CodeB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYuB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_TypeB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblCheck = New System.Windows.Forms.Label
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareOut.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareIn.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 35)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(783, 389)
        Me.XtraTabControl1.TabIndex = 149
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(774, 357)
        Me.XtraTabPage1.Text = "出貨管理"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.popWareOut
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(774, 357)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareOut
        '
        Me.popWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.popWareOutEdit, Me.popWareOutDel, Me.popWareOutView, Me.ToolStripSeparator2, Me.popWareOutCheck, Me.ToolStripSeparator1, Me.popWareOutflesh, Me.popWareOutSeek, Me.ToolStripSeparator6, Me.popWareOutReport, Me.popWareInTotalAReport})
        Me.popWareOut.Name = "popWareInput"
        Me.popWareOut.Size = New System.Drawing.Size(204, 220)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Enabled = False
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutAdd.Text = "出貨(&A)..."
        '
        'popWareOutEdit
        '
        Me.popWareOutEdit.Enabled = False
        Me.popWareOutEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareOutEdit.Name = "popWareOutEdit"
        Me.popWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareOutEdit.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutEdit.Text = "修改(&E)..."
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Enabled = False
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'popWareOutView
        '
        Me.popWareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareOutView.Name = "popWareOutView"
        Me.popWareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareOutView.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'popWareOutCheck
        '
        Me.popWareOutCheck.Enabled = False
        Me.popWareOutCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareOutCheck.Name = "popWareOutCheck"
        Me.popWareOutCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareOutCheck.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'popWareOutflesh
        '
        Me.popWareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareOutflesh.Name = "popWareOutflesh"
        Me.popWareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareOutflesh.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutflesh.Text = "刷新(&R)"
        '
        'popWareOutSeek
        '
        Me.popWareOutSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareOutSeek.Name = "popWareOutSeek"
        Me.popWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareOutSeek.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(200, 6)
        '
        'popWareOutReport
        '
        Me.popWareOutReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutReport.Name = "popWareOutReport"
        Me.popWareOutReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareOutReport.Size = New System.Drawing.Size(203, 22)
        Me.popWareOutReport.Text = "出貨單(&P)..."
        '
        'popWareInTotalAReport
        '
        Me.popWareInTotalAReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInTotalAReport.Name = "popWareInTotalAReport"
        Me.popWareInTotalAReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareInTotalAReport.Size = New System.Drawing.Size(203, 22)
        Me.popWareInTotalAReport.Text = "出貨單匯總(&T)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PWS_NO, Me.PS_Num, Me.PWS_M_Code, Me.M_Name, Me.M_Gauge, Me.PWS_WareName, Me.PWS_DepName, Me.PWS_Qty, Me.PWS_AddDate, Me.PWS_Action, Me.PWS_InWareName, Me.PWS_InAddDate, Me.PWS_InActionName, Me.PWS_Check, Me.PWS_InCheck, Me.PWS_CheckDate, Me.PWS_CheckAction, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type})
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
        'PWS_NO
        '
        Me.PWS_NO.Caption = "出貨單號"
        Me.PWS_NO.FieldName = "PWS_NO"
        Me.PWS_NO.Name = "PWS_NO"
        Me.PWS_NO.Visible = True
        Me.PWS_NO.VisibleIndex = 0
        Me.PWS_NO.Width = 95
        '
        'PS_Num
        '
        Me.PS_Num.Caption = "項目流水號"
        Me.PS_Num.FieldName = "PS_Num"
        Me.PS_Num.Name = "PS_Num"
        Me.PS_Num.Width = 90
        '
        'PWS_M_Code
        '
        Me.PWS_M_Code.Caption = "物料編碼"
        Me.PWS_M_Code.FieldName = "PWS_M_Code"
        Me.PWS_M_Code.Name = "PWS_M_Code"
        Me.PWS_M_Code.Width = 100
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
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 5
        Me.M_Gauge.Width = 80
        '
        'PWS_WareName
        '
        Me.PWS_WareName.Caption = "出貨倉庫"
        Me.PWS_WareName.FieldName = "PWS_OutName"
        Me.PWS_WareName.Name = "PWS_WareName"
        Me.PWS_WareName.Visible = True
        Me.PWS_WareName.VisibleIndex = 6
        '
        'PWS_DepName
        '
        Me.PWS_DepName.Caption = "出貨部門"
        Me.PWS_DepName.FieldName = "PWS_DepName"
        Me.PWS_DepName.Name = "PWS_DepName"
        '
        'PWS_Qty
        '
        Me.PWS_Qty.Caption = "出貨數量"
        Me.PWS_Qty.FieldName = "PWS_Qty"
        Me.PWS_Qty.Name = "PWS_Qty"
        Me.PWS_Qty.Visible = True
        Me.PWS_Qty.VisibleIndex = 7
        '
        'PWS_AddDate
        '
        Me.PWS_AddDate.Caption = "出貨日期"
        Me.PWS_AddDate.FieldName = "PWS_AddDate"
        Me.PWS_AddDate.Name = "PWS_AddDate"
        Me.PWS_AddDate.Visible = True
        Me.PWS_AddDate.VisibleIndex = 8
        '
        'PWS_Action
        '
        Me.PWS_Action.Caption = "操作員"
        Me.PWS_Action.FieldName = "PWS_ActionName"
        Me.PWS_Action.Name = "PWS_Action"
        Me.PWS_Action.Visible = True
        Me.PWS_Action.VisibleIndex = 12
        Me.PWS_Action.Width = 65
        '
        'PWS_InWareName
        '
        Me.PWS_InWareName.Caption = "收貨倉庫"
        Me.PWS_InWareName.FieldName = "PWS_InName"
        Me.PWS_InWareName.Name = "PWS_InWareName"
        Me.PWS_InWareName.Visible = True
        Me.PWS_InWareName.VisibleIndex = 9
        '
        'PWS_InAddDate
        '
        Me.PWS_InAddDate.Caption = "收貨日期"
        Me.PWS_InAddDate.FieldName = "PWS_InAddDate"
        Me.PWS_InAddDate.Name = "PWS_InAddDate"
        Me.PWS_InAddDate.Visible = True
        Me.PWS_InAddDate.VisibleIndex = 10
        '
        'PWS_InActionName
        '
        Me.PWS_InActionName.Caption = "收貨人員"
        Me.PWS_InActionName.FieldName = "PWS_InActionName"
        Me.PWS_InActionName.Name = "PWS_InActionName"
        Me.PWS_InActionName.Visible = True
        Me.PWS_InActionName.VisibleIndex = 11
        '
        'PWS_Check
        '
        Me.PWS_Check.Caption = "審核"
        Me.PWS_Check.FieldName = "PWS_Check"
        Me.PWS_Check.Name = "PWS_Check"
        Me.PWS_Check.Visible = True
        Me.PWS_Check.VisibleIndex = 13
        Me.PWS_Check.Width = 55
        '
        'PWS_InCheck
        '
        Me.PWS_InCheck.Caption = "收貨確認"
        Me.PWS_InCheck.FieldName = "PWS_InCheck"
        Me.PWS_InCheck.Name = "PWS_InCheck"
        Me.PWS_InCheck.Visible = True
        Me.PWS_InCheck.VisibleIndex = 14
        '
        'PWS_CheckDate
        '
        Me.PWS_CheckDate.Caption = "審核日期"
        Me.PWS_CheckDate.FieldName = "PWS_CheckDate"
        Me.PWS_CheckDate.Name = "PWS_CheckDate"
        '
        'PWS_CheckAction
        '
        Me.PWS_CheckAction.Caption = "審核員"
        Me.PWS_CheckAction.FieldName = "PWS_CheckActionName"
        Me.PWS_CheckAction.Name = "PWS_CheckAction"
        Me.PWS_CheckAction.Visible = True
        Me.PWS_CheckAction.VisibleIndex = 15
        Me.PWS_CheckAction.Width = 65
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
        Me.PM_JiYu.Caption = "別名"
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Grid1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(774, 357)
        Me.XtraTabPage2.Text = "收貨管理"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popWareIn
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(774, 357)
        Me.Grid1.TabIndex = 4
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popWareIn
        '
        Me.popWareIn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInView, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.popWareInInCheck, Me.popWareInflesh, Me.popWareInSeek, Me.ToolStripSeparator5, Me.popWareInReport, Me.popWareInTotalBReport})
        Me.popWareIn.Name = "popWareInput"
        Me.popWareIn.Size = New System.Drawing.Size(204, 176)
        '
        'popWareInView
        '
        Me.popWareInView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareInView.Name = "popWareInView"
        Me.popWareInView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareInView.Size = New System.Drawing.Size(203, 22)
        Me.popWareInView.Text = "查看(&W)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(200, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'popWareInInCheck
        '
        Me.popWareInInCheck.Enabled = False
        Me.popWareInInCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popWareInInCheck.Name = "popWareInInCheck"
        Me.popWareInInCheck.Size = New System.Drawing.Size(203, 22)
        Me.popWareInInCheck.Text = "收貨確認(&I)       Ctrl+I"
        '
        'popWareInflesh
        '
        Me.popWareInflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareInflesh.Name = "popWareInflesh"
        Me.popWareInflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareInflesh.Size = New System.Drawing.Size(203, 22)
        Me.popWareInflesh.Text = "刷新(&R)"
        '
        'popWareInSeek
        '
        Me.popWareInSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareInSeek.Name = "popWareInSeek"
        Me.popWareInSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInSeek.Size = New System.Drawing.Size(203, 22)
        Me.popWareInSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(200, 6)
        '
        'popWareInTotalBReport
        '
        Me.popWareInTotalBReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInTotalBReport.Name = "popWareInTotalBReport"
        Me.popWareInTotalBReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareInTotalBReport.Size = New System.Drawing.Size(203, 22)
        Me.popWareInTotalBReport.Text = "出貨單匯總(&T)..."
        '
        'popWareInReport
        '
        Me.popWareInReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInReport.Name = "popWareInReport"
        Me.popWareInReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareInReport.Size = New System.Drawing.Size(203, 22)
        Me.popWareInReport.Text = "出貨單(&P)..."
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PWS_NOB, Me.PS_NumB, Me.PWS_M_CodeB, Me.M_NameB, Me.M_Gauge1, Me.PWS_OutNameB, Me.PWS_DepNameB, Me.PWS_QtyB, Me.PWS_AddDateB, Me.PWS_ActionNameB, Me.PWS_InNameB, Me.PWS_InAddDateB, Me.PWS_InActionNameB, Me.PWS_CheckB, Me.PWS_InCheckB, Me.PWS_CheckDateB, Me.PWS_CheckActionNameB, Me.PM_M_CodeB, Me.PM_JiYuB, Me.PM_TypeB})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'PWS_NOB
        '
        Me.PWS_NOB.Caption = "出貨單號"
        Me.PWS_NOB.FieldName = "PWS_NO"
        Me.PWS_NOB.Name = "PWS_NOB"
        Me.PWS_NOB.Visible = True
        Me.PWS_NOB.VisibleIndex = 0
        Me.PWS_NOB.Width = 95
        '
        'PS_NumB
        '
        Me.PS_NumB.Caption = "項目流水號"
        Me.PS_NumB.FieldName = "PS_Num"
        Me.PS_NumB.Name = "PS_NumB"
        Me.PS_NumB.Width = 90
        '
        'PWS_M_CodeB
        '
        Me.PWS_M_CodeB.Caption = "物料編碼"
        Me.PWS_M_CodeB.FieldName = "PWS_M_Code"
        Me.PWS_M_CodeB.Name = "PWS_M_CodeB"
        Me.PWS_M_CodeB.Width = 100
        '
        'M_NameB
        '
        Me.M_NameB.Caption = "名稱"
        Me.M_NameB.FieldName = "M_Name"
        Me.M_NameB.Name = "M_NameB"
        Me.M_NameB.Visible = True
        Me.M_NameB.VisibleIndex = 4
        Me.M_NameB.Width = 65
        '
        'M_Gauge1
        '
        Me.M_Gauge1.Caption = "規格"
        Me.M_Gauge1.FieldName = "M_Gauge"
        Me.M_Gauge1.Name = "M_Gauge1"
        Me.M_Gauge1.OptionsColumn.ReadOnly = True
        Me.M_Gauge1.Visible = True
        Me.M_Gauge1.VisibleIndex = 5
        '
        'PWS_OutNameB
        '
        Me.PWS_OutNameB.Caption = "出貨倉庫"
        Me.PWS_OutNameB.FieldName = "PWS_OutName"
        Me.PWS_OutNameB.Name = "PWS_OutNameB"
        Me.PWS_OutNameB.Visible = True
        Me.PWS_OutNameB.VisibleIndex = 6
        '
        'PWS_DepNameB
        '
        Me.PWS_DepNameB.Caption = "出貨部門"
        Me.PWS_DepNameB.FieldName = "PWS_DepName"
        Me.PWS_DepNameB.Name = "PWS_DepNameB"
        '
        'PWS_QtyB
        '
        Me.PWS_QtyB.Caption = "出貨數量"
        Me.PWS_QtyB.FieldName = "PWS_Qty"
        Me.PWS_QtyB.Name = "PWS_QtyB"
        Me.PWS_QtyB.Visible = True
        Me.PWS_QtyB.VisibleIndex = 7
        '
        'PWS_AddDateB
        '
        Me.PWS_AddDateB.Caption = "出貨日期"
        Me.PWS_AddDateB.FieldName = "PWS_AddDate"
        Me.PWS_AddDateB.Name = "PWS_AddDateB"
        Me.PWS_AddDateB.Visible = True
        Me.PWS_AddDateB.VisibleIndex = 8
        '
        'PWS_ActionNameB
        '
        Me.PWS_ActionNameB.Caption = "操作員"
        Me.PWS_ActionNameB.FieldName = "PWS_ActionName"
        Me.PWS_ActionNameB.Name = "PWS_ActionNameB"
        Me.PWS_ActionNameB.Visible = True
        Me.PWS_ActionNameB.VisibleIndex = 12
        Me.PWS_ActionNameB.Width = 65
        '
        'PWS_InNameB
        '
        Me.PWS_InNameB.Caption = "收貨倉庫"
        Me.PWS_InNameB.FieldName = "PWS_InName"
        Me.PWS_InNameB.Name = "PWS_InNameB"
        Me.PWS_InNameB.Visible = True
        Me.PWS_InNameB.VisibleIndex = 9
        '
        'PWS_InAddDateB
        '
        Me.PWS_InAddDateB.Caption = "收貨日期"
        Me.PWS_InAddDateB.FieldName = "PWS_InAddDate"
        Me.PWS_InAddDateB.Name = "PWS_InAddDateB"
        Me.PWS_InAddDateB.Visible = True
        Me.PWS_InAddDateB.VisibleIndex = 10
        '
        'PWS_InActionNameB
        '
        Me.PWS_InActionNameB.Caption = "收貨人員"
        Me.PWS_InActionNameB.FieldName = "PWS_InActionName"
        Me.PWS_InActionNameB.Name = "PWS_InActionNameB"
        Me.PWS_InActionNameB.Visible = True
        Me.PWS_InActionNameB.VisibleIndex = 11
        '
        'PWS_CheckB
        '
        Me.PWS_CheckB.Caption = "審核"
        Me.PWS_CheckB.FieldName = "PWS_Check"
        Me.PWS_CheckB.Name = "PWS_CheckB"
        Me.PWS_CheckB.Visible = True
        Me.PWS_CheckB.VisibleIndex = 13
        Me.PWS_CheckB.Width = 55
        '
        'PWS_InCheckB
        '
        Me.PWS_InCheckB.Caption = "收貨確認"
        Me.PWS_InCheckB.FieldName = "PWS_InCheck"
        Me.PWS_InCheckB.Name = "PWS_InCheckB"
        Me.PWS_InCheckB.Visible = True
        Me.PWS_InCheckB.VisibleIndex = 14
        '
        'PWS_CheckDateB
        '
        Me.PWS_CheckDateB.Caption = "審核日期"
        Me.PWS_CheckDateB.FieldName = "PWS_CheckDate"
        Me.PWS_CheckDateB.Name = "PWS_CheckDateB"
        '
        'PWS_CheckActionNameB
        '
        Me.PWS_CheckActionNameB.Caption = "審核員"
        Me.PWS_CheckActionNameB.FieldName = "PWS_CheckActionName"
        Me.PWS_CheckActionNameB.Name = "PWS_CheckActionNameB"
        Me.PWS_CheckActionNameB.Visible = True
        Me.PWS_CheckActionNameB.VisibleIndex = 15
        Me.PWS_CheckActionNameB.Width = 65
        '
        'PM_M_CodeB
        '
        Me.PM_M_CodeB.Caption = "產品編號"
        Me.PM_M_CodeB.FieldName = "PM_M_Code"
        Me.PM_M_CodeB.Name = "PM_M_CodeB"
        Me.PM_M_CodeB.Visible = True
        Me.PM_M_CodeB.VisibleIndex = 1
        Me.PM_M_CodeB.Width = 100
        '
        'PM_JiYuB
        '
        Me.PM_JiYuB.Caption = "別名"
        Me.PM_JiYuB.FieldName = "PM_JiYu"
        Me.PM_JiYuB.Name = "PM_JiYuB"
        Me.PM_JiYuB.OptionsColumn.AllowEdit = False
        Me.PM_JiYuB.OptionsColumn.AllowFocus = False
        Me.PM_JiYuB.Visible = True
        Me.PM_JiYuB.VisibleIndex = 2
        Me.PM_JiYuB.Width = 65
        '
        'PM_TypeB
        '
        Me.PM_TypeB.Caption = "配件名稱"
        Me.PM_TypeB.FieldName = "PM_Type"
        Me.PM_TypeB.Name = "PM_TypeB"
        Me.PM_TypeB.OptionsColumn.AllowEdit = False
        Me.PM_TypeB.Visible = True
        Me.PM_TypeB.VisibleIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "裝配倉出貨"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 34)
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCheck.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheck.ForeColor = System.Drawing.Color.Red
        Me.lblCheck.Location = New System.Drawing.Point(132, 10)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(0, 16)
        Me.lblCheck.TabIndex = 150
        '
        'ProductionWareShippedMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 425)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductionWareShippedMain"
        Me.Text = "裝配倉出貨"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareOut.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareIn.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PWS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_WareName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InWareName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InAddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PWS_NOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NumB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_M_CodeB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_NameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_OutNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_DepNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_QtyB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_AddDateB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_ActionNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InAddDateB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InActionNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_InCheckB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckDateB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWS_CheckActionNameB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_CodeB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYuB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_TypeB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents popWareIn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareInInCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInTotalAReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareInTotalBReport As System.Windows.Forms.ToolStripMenuItem
End Class
