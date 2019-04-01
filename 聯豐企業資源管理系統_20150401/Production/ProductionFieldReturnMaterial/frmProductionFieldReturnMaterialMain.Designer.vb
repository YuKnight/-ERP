<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionFieldReturnMaterialMain
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
        Me.cmsProductionKaiLiaoReturn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProductionAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.R_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RInCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RIncheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RIncheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripInOK = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblCheck = New System.Windows.Forms.Label
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProductionKaiLiaoReturn.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 38)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(876, 492)
        Me.XtraTabControl1.TabIndex = 150
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(867, 460)
        Me.XtraTabPage1.Text = "生產退料"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.cmsProductionKaiLiaoReturn
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(867, 460)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsProductionKaiLiaoReturn
        '
        Me.cmsProductionKaiLiaoReturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductionAdd, Me.cmsProductionEdit, Me.cmsProductionDel, Me.ToolStripSeparator1, Me.cmsProductionSelect, Me.cmsProductionView, Me.cmsProductionRef, Me.ToolStripSeparator2, Me.cmsProductionCheck, Me.cmsProductionPrint})
        Me.cmsProductionKaiLiaoReturn.Name = "cmsProduction"
        Me.cmsProductionKaiLiaoReturn.Size = New System.Drawing.Size(165, 192)
        '
        'cmsProductionAdd
        '
        Me.cmsProductionAdd.Enabled = False
        Me.cmsProductionAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsProductionAdd.Name = "cmsProductionAdd"
        Me.cmsProductionAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductionAdd.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionAdd.Text = "新增(&A)..."
        '
        'cmsProductionEdit
        '
        Me.cmsProductionEdit.Enabled = False
        Me.cmsProductionEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsProductionEdit.Name = "cmsProductionEdit"
        Me.cmsProductionEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsProductionEdit.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionEdit.Text = "修改(&E)..."
        '
        'cmsProductionDel
        '
        Me.cmsProductionDel.Enabled = False
        Me.cmsProductionDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductionDel.Name = "cmsProductionDel"
        Me.cmsProductionDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductionDel.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'cmsProductionSelect
        '
        Me.cmsProductionSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsProductionSelect.Name = "cmsProductionSelect"
        Me.cmsProductionSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsProductionSelect.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionSelect.Text = "查詢(&F)..."
        '
        'cmsProductionView
        '
        Me.cmsProductionView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsProductionView.Name = "cmsProductionView"
        Me.cmsProductionView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsProductionView.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionView.Text = "查看(&W)..."
        '
        'cmsProductionRef
        '
        Me.cmsProductionRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsProductionRef.Name = "cmsProductionRef"
        Me.cmsProductionRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsProductionRef.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'cmsProductionCheck
        '
        Me.cmsProductionCheck.Enabled = False
        Me.cmsProductionCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsProductionCheck.Name = "cmsProductionCheck"
        Me.cmsProductionCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsProductionCheck.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionCheck.Text = "審核(&G)..."
        '
        'cmsProductionPrint
        '
        Me.cmsProductionPrint.Enabled = False
        Me.cmsProductionPrint.Name = "cmsProductionPrint"
        Me.cmsProductionPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsProductionPrint.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionPrint.Text = "退料單(&P)..."
        Me.cmsProductionPrint.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.R_NO, Me.Pro_Type, Me.PM_M_Code, Me.PM_Type, Me.DepName, Me.PS_Name, Me.RQty, Me.WH_Name, Me.RDate, Me.RCheck, Me.RInCheck, Me.RIncheckDate, Me.RIncheckActionName})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'R_NO
        '
        Me.R_NO.Caption = "退料單"
        Me.R_NO.FieldName = "R_NO"
        Me.R_NO.Name = "R_NO"
        Me.R_NO.Visible = True
        Me.R_NO.VisibleIndex = 0
        Me.R_NO.Width = 90
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
        Me.PM_M_Code.Width = 90
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類別"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 3
        '
        'DepName
        '
        Me.DepName.Caption = "部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 4
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "退料工序"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 5
        '
        'RQty
        '
        Me.RQty.Caption = "數量"
        Me.RQty.FieldName = "RQty"
        Me.RQty.Name = "RQty"
        Me.RQty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.RQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.RQty.Visible = True
        Me.RQty.VisibleIndex = 6
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "收料倉"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 7
        '
        'RDate
        '
        Me.RDate.Caption = "退料日期"
        Me.RDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RDate.FieldName = "RDate"
        Me.RDate.Name = "RDate"
        Me.RDate.Visible = True
        Me.RDate.VisibleIndex = 8
        Me.RDate.Width = 90
        '
        'RCheck
        '
        Me.RCheck.Caption = "審核"
        Me.RCheck.FieldName = "RCheck"
        Me.RCheck.Name = "RCheck"
        Me.RCheck.Visible = True
        Me.RCheck.VisibleIndex = 9
        '
        'RInCheck
        '
        Me.RInCheck.Caption = "收料審核"
        Me.RInCheck.FieldName = "RInCheck"
        Me.RInCheck.Name = "RInCheck"
        Me.RInCheck.Visible = True
        Me.RInCheck.VisibleIndex = 10
        '
        'RIncheckDate
        '
        Me.RIncheckDate.Caption = "收料日期"
        Me.RIncheckDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RIncheckDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RIncheckDate.FieldName = "RIncheckDate"
        Me.RIncheckDate.Name = "RIncheckDate"
        Me.RIncheckDate.Visible = True
        Me.RIncheckDate.VisibleIndex = 11
        '
        'RIncheckActionName
        '
        Me.RIncheckActionName.Caption = "收料人"
        Me.RIncheckActionName.FieldName = "RIncheckActionName"
        Me.RIncheckActionName.Name = "RIncheckActionName"
        Me.RIncheckActionName.Visible = True
        Me.RIncheckActionName.VisibleIndex = 12
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Grid2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(867, 460)
        Me.XtraTabPage2.Text = "倉庫收料"
        '
        'Grid2
        '
        Me.Grid2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(867, 460)
        Me.Grid2.TabIndex = 4
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripInOK, Me.ToolStripFind, Me.ToolStripView, Me.ToolStripRefresh, Me.ToolStripSeparator4})
        Me.ContextMenuStrip1.Name = "cmsProduction"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 98)
        '
        'ToolStripInOK
        '
        Me.ToolStripInOK.Enabled = False
        Me.ToolStripInOK.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.ToolStripInOK.Name = "ToolStripInOK"
        Me.ToolStripInOK.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripInOK.Text = "收料確認"
        '
        'ToolStripFind
        '
        Me.ToolStripFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.ToolStripFind.Name = "ToolStripFind"
        Me.ToolStripFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ToolStripFind.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripFind.Text = "查詢(&F)..."
        '
        'ToolStripView
        '
        Me.ToolStripView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.ToolStripView.Name = "ToolStripView"
        Me.ToolStripView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripView.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripView.Text = "查看(&W)..."
        '
        'ToolStripRefresh
        '
        Me.ToolStripRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ToolStripRefresh.Name = "ToolStripRefresh"
        Me.ToolStripRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripRefresh.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripRefresh.Text = "刷新(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "退料單"
        Me.GridColumn1.FieldName = "R_NO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 90
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "工藝類型"
        Me.GridColumn2.FieldName = "Pro_Type"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "產品編號"
        Me.GridColumn3.FieldName = "PM_M_Code"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 90
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "類別"
        Me.GridColumn4.FieldName = "PM_Type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "部門"
        Me.GridColumn5.FieldName = "DepName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "退料工序"
        Me.GridColumn6.FieldName = "PS_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "數量"
        Me.GridColumn7.FieldName = "RQty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.SummaryItem.DisplayFormat = "合計:{0}"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "收料倉"
        Me.GridColumn8.FieldName = "WH_Name"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "退料日期"
        Me.GridColumn9.FieldName = "RDate"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 90
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "審核"
        Me.GridColumn10.FieldName = "RCheck"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "收料審核"
        Me.GridColumn11.FieldName = "RInCheck"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "收料日期"
        Me.GridColumn12.FieldName = "RIncheckDate"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "收料人"
        Me.GridColumn13.FieldName = "RIncheckActionName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "生產退料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(871, 34)
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCheck.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheck.ForeColor = System.Drawing.Color.Red
        Me.lblCheck.Location = New System.Drawing.Point(144, 8)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(32, 16)
        Me.lblCheck.TabIndex = 153
        Me.lblCheck.Text = "***"
        '
        'frmProductionFieldReturnMaterialMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 527)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmProductionFieldReturnMaterialMain"
        Me.Text = "生產退料"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProductionKaiLiaoReturn.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents R_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RInCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProductionKaiLiaoReturn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProductionAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripInOK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RIncheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIncheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCheck As System.Windows.Forms.Label
End Class
