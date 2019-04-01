<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInventoryOutMain
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
        Me.popWareOutReport = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInTotalAReport = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.PO_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PO_EndQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWS_OutName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.popWareIn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareInView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInInCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInReport = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInTotalBReport = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblCheck = New System.Windows.Forms.Label
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareOut.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareIn.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(738, 439)
        Me.XtraTabControl1.TabIndex = 149
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = " "
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(729, 407)
        Me.XtraTabPage1.Text = "出庫管理"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.popWareOut
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.Grid.Size = New System.Drawing.Size(729, 407)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareOut
        '
        Me.popWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.popWareOutEdit, Me.popWareOutDel, Me.popWareOutView, Me.ToolStripSeparator2, Me.popWareOutCheck, Me.ToolStripSeparator1, Me.popWareOutflesh, Me.popWareOutSeek, Me.popWareOutReport, Me.popWareInTotalAReport})
        Me.popWareOut.Name = "popWareInput"
        Me.popWareOut.Size = New System.Drawing.Size(191, 214)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Enabled = False
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutAdd.Text = "出貨(&A)..."
        '
        'popWareOutEdit
        '
        Me.popWareOutEdit.Enabled = False
        Me.popWareOutEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareOutEdit.Name = "popWareOutEdit"
        Me.popWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareOutEdit.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutEdit.Text = "修改(&E)..."
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Enabled = False
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'popWareOutView
        '
        Me.popWareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareOutView.Name = "popWareOutView"
        Me.popWareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareOutView.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'popWareOutCheck
        '
        Me.popWareOutCheck.Enabled = False
        Me.popWareOutCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareOutCheck.Name = "popWareOutCheck"
        Me.popWareOutCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareOutCheck.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'popWareOutflesh
        '
        Me.popWareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareOutflesh.Name = "popWareOutflesh"
        Me.popWareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareOutflesh.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutflesh.Text = "刷新(&R)"
        '
        'popWareOutSeek
        '
        Me.popWareOutSeek.Enabled = False
        Me.popWareOutSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareOutSeek.Name = "popWareOutSeek"
        Me.popWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareOutSeek.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutSeek.Text = "查詢(&F)..."
        Me.popWareOutSeek.Visible = False
        '
        'popWareOutReport
        '
        Me.popWareOutReport.Enabled = False
        Me.popWareOutReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareOutReport.Name = "popWareOutReport"
        Me.popWareOutReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareOutReport.Size = New System.Drawing.Size(190, 22)
        Me.popWareOutReport.Text = "出貨單(&P)..."
        Me.popWareOutReport.Visible = False
        '
        'popWareInTotalAReport
        '
        Me.popWareInTotalAReport.Enabled = False
        Me.popWareInTotalAReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInTotalAReport.Name = "popWareInTotalAReport"
        Me.popWareInTotalAReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareInTotalAReport.Size = New System.Drawing.Size(190, 22)
        Me.popWareInTotalAReport.Text = "出貨單匯總(&T)..."
        Me.popWareInTotalAReport.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.PO_NO, Me.Pro_Type, Me.M_Name, Me.M_Code, Me.WH_ID, Me.PO_Qty, Me.PO_Date, Me.PO_Action, Me.PO_Remark, Me.PO_Check, Me.PO_CheckAction, Me.PO_CheckDate, Me.PO_CheckRemark, Me.PO_EndQty, Me.PM_JiYu, Me.PM_Type, Me.PWS_OutName})
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
        'AutoID
        '
        Me.AutoID.Caption = "自動單號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.Width = 95
        '
        'PO_NO
        '
        Me.PO_NO.Caption = "出庫單號"
        Me.PO_NO.FieldName = "PO_NO"
        Me.PO_NO.Name = "PO_NO"
        Me.PO_NO.Visible = True
        Me.PO_NO.VisibleIndex = 0
        Me.PO_NO.Width = 90
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 1
        Me.Pro_Type.Width = 90
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品編號"
        Me.M_Name.FieldName = "PM_M_Code"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        Me.M_Name.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 3
        Me.M_Code.Width = 100
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "出倉編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Width = 90
        '
        'PO_Qty
        '
        Me.PO_Qty.AppearanceCell.Options.UseTextOptions = True
        Me.PO_Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PO_Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.PO_Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PO_Qty.Caption = "出貨數量"
        Me.PO_Qty.FieldName = "PO_Qty"
        Me.PO_Qty.Name = "PO_Qty"
        Me.PO_Qty.Visible = True
        Me.PO_Qty.VisibleIndex = 4
        Me.PO_Qty.Width = 90
        '
        'PO_Date
        '
        Me.PO_Date.Caption = "出貨日期"
        Me.PO_Date.FieldName = "PO_Date"
        Me.PO_Date.Name = "PO_Date"
        Me.PO_Date.Visible = True
        Me.PO_Date.VisibleIndex = 5
        Me.PO_Date.Width = 90
        '
        'PO_Action
        '
        Me.PO_Action.AppearanceCell.Options.UseTextOptions = True
        Me.PO_Action.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_Action.AppearanceHeader.Options.UseTextOptions = True
        Me.PO_Action.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_Action.Caption = "操作員"
        Me.PO_Action.FieldName = "PWS_ActionName"
        Me.PO_Action.Name = "PO_Action"
        Me.PO_Action.Visible = True
        Me.PO_Action.VisibleIndex = 6
        Me.PO_Action.Width = 90
        '
        'PO_Remark
        '
        Me.PO_Remark.Caption = "備註"
        Me.PO_Remark.FieldName = "PO_Remark"
        Me.PO_Remark.Name = "PO_Remark"
        Me.PO_Remark.Width = 90
        '
        'PO_Check
        '
        Me.PO_Check.AppearanceCell.Options.UseTextOptions = True
        Me.PO_Check.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_Check.AppearanceHeader.Options.UseTextOptions = True
        Me.PO_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_Check.Caption = "審核"
        Me.PO_Check.FieldName = "PO_Check"
        Me.PO_Check.Name = "PO_Check"
        Me.PO_Check.Visible = True
        Me.PO_Check.VisibleIndex = 7
        Me.PO_Check.Width = 90
        '
        'PO_CheckAction
        '
        Me.PO_CheckAction.AppearanceCell.Options.UseTextOptions = True
        Me.PO_CheckAction.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_CheckAction.AppearanceHeader.Options.UseTextOptions = True
        Me.PO_CheckAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PO_CheckAction.Caption = "審核人"
        Me.PO_CheckAction.FieldName = "PWS_CheckActionName"
        Me.PO_CheckAction.Name = "PO_CheckAction"
        Me.PO_CheckAction.Visible = True
        Me.PO_CheckAction.VisibleIndex = 8
        Me.PO_CheckAction.Width = 90
        '
        'PO_CheckDate
        '
        Me.PO_CheckDate.Caption = "審核日期"
        Me.PO_CheckDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.PO_CheckDate.FieldName = "PO_CheckDate"
        Me.PO_CheckDate.Name = "PO_CheckDate"
        Me.PO_CheckDate.Visible = True
        Me.PO_CheckDate.VisibleIndex = 9
        Me.PO_CheckDate.Width = 130
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.MaxValue = New Date(5555, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'PO_CheckRemark
        '
        Me.PO_CheckRemark.Caption = "審核備註"
        Me.PO_CheckRemark.FieldName = "PO_CheckRemark"
        Me.PO_CheckRemark.Name = "PO_CheckRemark"
        Me.PO_CheckRemark.Width = 90
        '
        'PO_EndQty
        '
        Me.PO_EndQty.Caption = "結餘數"
        Me.PO_EndQty.FieldName = "PO_EndQty"
        Me.PO_EndQty.Name = "PO_EndQty"
        Me.PO_EndQty.Width = 90
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "別名"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Width = 90
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.AllowEdit = False
        Me.PM_Type.Width = 90
        '
        'PWS_OutName
        '
        Me.PWS_OutName.Caption = "出倉倉庫"
        Me.PWS_OutName.FieldName = "PWS_OutName"
        Me.PWS_OutName.Name = "PWS_OutName"
        Me.PWS_OutName.Visible = True
        Me.PWS_OutName.VisibleIndex = 10
        Me.PWS_OutName.Width = 90
        '
        'popWareIn
        '
        Me.popWareIn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInView, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.popWareInInCheck, Me.popWareInflesh, Me.popWareInSeek, Me.popWareInReport, Me.popWareInTotalBReport})
        Me.popWareIn.Name = "popWareInput"
        Me.popWareIn.Size = New System.Drawing.Size(191, 148)
        '
        'popWareInView
        '
        Me.popWareInView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareInView.Name = "popWareInView"
        Me.popWareInView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareInView.Size = New System.Drawing.Size(190, 22)
        Me.popWareInView.Text = "查看(&W)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(187, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(187, 6)
        '
        'popWareInInCheck
        '
        Me.popWareInInCheck.Enabled = False
        Me.popWareInInCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popWareInInCheck.Name = "popWareInInCheck"
        Me.popWareInInCheck.Size = New System.Drawing.Size(190, 22)
        Me.popWareInInCheck.Text = "收貨確認(&I)       Ctrl+I"
        '
        'popWareInflesh
        '
        Me.popWareInflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWareInflesh.Name = "popWareInflesh"
        Me.popWareInflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWareInflesh.Size = New System.Drawing.Size(190, 22)
        Me.popWareInflesh.Text = "刷新(&R)"
        '
        'popWareInSeek
        '
        Me.popWareInSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareInSeek.Name = "popWareInSeek"
        Me.popWareInSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInSeek.Size = New System.Drawing.Size(190, 22)
        Me.popWareInSeek.Text = "查詢(&F)..."
        '
        'popWareInReport
        '
        Me.popWareInReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInReport.Name = "popWareInReport"
        Me.popWareInReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareInReport.Size = New System.Drawing.Size(190, 22)
        Me.popWareInReport.Text = "出貨單(&P)..."
        '
        'popWareInTotalBReport
        '
        Me.popWareInTotalBReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInTotalBReport.Name = "popWareInTotalBReport"
        Me.popWareInTotalBReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popWareInTotalBReport.Size = New System.Drawing.Size(190, 22)
        Me.popWareInTotalBReport.Text = "出貨單匯總(&T)..."
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
        Me.Label1.Text = "生產倉出庫"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 34)
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
        'ProductInventoryOutMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 475)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "ProductInventoryOutMain"
        Me.Text = "生產倉出庫"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareOut.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareIn.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PO_EndQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents popWareInTotalBReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInTotalAReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PWS_OutName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
