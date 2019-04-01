<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampAlarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNmetalSampAlarm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQurey = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_AddUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_OutD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_InD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_OutCardID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaSE_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_TypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_InTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_InCardID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDutyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOccurAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOccurReason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colSE_DelUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProcessResult = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colAddUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPutInQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPutInCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRatioQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRatioCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmailTilte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "报警信息服务"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1217, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsMenuStrip
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 32)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3})
        Me.Grid1.Size = New System.Drawing.Size(1217, 596)
        Me.Grid1.TabIndex = 89
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator3, Me.cmdView, Me.cmdQurey, Me.cmdCheck, Me.ToolStripSeparator2, Me.cmdRef, Me.cmdPrint, Me.cmdExcel})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(235, 236)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(234, 22)
        Me.cmdAdd.Text = "处理报警信息(&A)        "
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(234, 22)
        Me.cmdEdit.Text = "修改报警信息(&E)        "
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(234, 22)
        Me.cmdDel.Text = "刪除处理结果(&D)        "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(231, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(234, 22)
        Me.cmdView.Text = "查看(&W)      "
        '
        'cmdQurey
        '
        Me.cmdQurey.Image = CType(resources.GetObject("cmdQurey.Image"), System.Drawing.Image)
        Me.cmdQurey.Name = "cmdQurey"
        Me.cmdQurey.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQurey.Size = New System.Drawing.Size(234, 22)
        Me.cmdQurey.Text = "查询(&F)        "
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = CType(resources.GetObject("cmdCheck.Image"), System.Drawing.Image)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(234, 22)
        Me.cmdCheck.Text = "处理(&G)        "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(231, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = CType(resources.GetObject("cmdRef.Image"), System.Drawing.Image)
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(234, 22)
        Me.cmdRef.Text = "刷新(&R)       "
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(234, 22)
        Me.cmdPrint.Text = "打印(&P)        "
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = CType(resources.GetObject("cmdExcel.Image"), System.Drawing.Image)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmdExcel.Size = New System.Drawing.Size(234, 22)
        Me.cmdExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSE_ID, Me.colSO_SampleID, Me.colPM_M_Code, Me.colSE_Qty, Me.colSE_AddUserID, Me.colSE_OutD_Dep, Me.colSE_InD_Dep, Me.colSE_AddUserName, Me.colSE_AddDate, Me.colSE_OutCardID, Me.colaSE_AddDate, Me.colSE_TypeName, Me.colSE_InTime, Me.colSE_InCardID, Me.colD_Dep, Me.colDutyUserID, Me.colOccurAddress, Me.colOccurReason, Me.colSE_DelUserID, Me.colProcessResult, Me.colAddUserID, Me.colCheckBit, Me.colCheckAction, Me.colCheckDate, Me.colCheckRemark, Me.colAddUserName, Me.colCheckActionName, Me.colPutInQty, Me.colPutInCount, Me.colRatioQty, Me.colRatioCount, Me.colRemark, Me.colEmailTilte})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 40
        '
        'colSE_ID
        '
        Me.colSE_ID.Caption = "收发单号"
        Me.colSE_ID.FieldName = "SE_ID"
        Me.colSE_ID.Name = "colSE_ID"
        Me.colSE_ID.OptionsColumn.AllowEdit = False
        Me.colSE_ID.OptionsColumn.ReadOnly = True
        Me.colSE_ID.Width = 87
        '
        'colSO_SampleID
        '
        Me.colSO_SampleID.Caption = "样办单号"
        Me.colSO_SampleID.FieldName = "SO_SampleID"
        Me.colSO_SampleID.Name = "colSO_SampleID"
        Me.colSO_SampleID.OptionsColumn.AllowEdit = False
        Me.colSO_SampleID.OptionsColumn.ReadOnly = True
        Me.colSO_SampleID.Visible = True
        Me.colSO_SampleID.VisibleIndex = 2
        Me.colSO_SampleID.Width = 94
        '
        'colPM_M_Code
        '
        Me.colPM_M_Code.Caption = "产品编号"
        Me.colPM_M_Code.FieldName = "PM_M_Code"
        Me.colPM_M_Code.Name = "colPM_M_Code"
        Me.colPM_M_Code.OptionsColumn.AllowEdit = False
        Me.colPM_M_Code.OptionsColumn.ReadOnly = True
        '
        'colSE_Qty
        '
        Me.colSE_Qty.Caption = "数量"
        Me.colSE_Qty.FieldName = "SE_Qty"
        Me.colSE_Qty.Name = "colSE_Qty"
        Me.colSE_Qty.OptionsColumn.AllowEdit = False
        Me.colSE_Qty.OptionsColumn.ReadOnly = True
        Me.colSE_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.colSE_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSE_Qty.Visible = True
        Me.colSE_Qty.VisibleIndex = 6
        Me.colSE_Qty.Width = 45
        '
        'colSE_AddUserID
        '
        Me.colSE_AddUserID.Caption = "GridColumn5"
        Me.colSE_AddUserID.FieldName = "SE_AddUserID"
        Me.colSE_AddUserID.Name = "colSE_AddUserID"
        Me.colSE_AddUserID.OptionsColumn.AllowEdit = False
        Me.colSE_AddUserID.OptionsColumn.ReadOnly = True
        '
        'colSE_OutD_Dep
        '
        Me.colSE_OutD_Dep.Caption = "发料部门"
        Me.colSE_OutD_Dep.FieldName = "SE_OutD_Dep"
        Me.colSE_OutD_Dep.Name = "colSE_OutD_Dep"
        Me.colSE_OutD_Dep.OptionsColumn.AllowEdit = False
        Me.colSE_OutD_Dep.OptionsColumn.ReadOnly = True
        Me.colSE_OutD_Dep.Visible = True
        Me.colSE_OutD_Dep.VisibleIndex = 3
        '
        'colSE_InD_Dep
        '
        Me.colSE_InD_Dep.Caption = "收料部门"
        Me.colSE_InD_Dep.FieldName = "SE_InD_Dep"
        Me.colSE_InD_Dep.Name = "colSE_InD_Dep"
        Me.colSE_InD_Dep.OptionsColumn.AllowEdit = False
        Me.colSE_InD_Dep.OptionsColumn.ReadOnly = True
        Me.colSE_InD_Dep.SummaryItem.DisplayFormat = "{0}"
        Me.colSE_InD_Dep.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colSE_InD_Dep.Visible = True
        Me.colSE_InD_Dep.VisibleIndex = 7
        '
        'colSE_AddUserName
        '
        Me.colSE_AddUserName.Caption = "發料統計"
        Me.colSE_AddUserName.FieldName = "SE_AddUserName"
        Me.colSE_AddUserName.Name = "colSE_AddUserName"
        Me.colSE_AddUserName.OptionsColumn.AllowEdit = False
        Me.colSE_AddUserName.OptionsColumn.ReadOnly = True
        Me.colSE_AddUserName.Visible = True
        Me.colSE_AddUserName.VisibleIndex = 9
        '
        'colSE_AddDate
        '
        Me.colSE_AddDate.Caption = "发生日期"
        Me.colSE_AddDate.FieldName = "SE_AddDate"
        Me.colSE_AddDate.Name = "colSE_AddDate"
        Me.colSE_AddDate.OptionsColumn.AllowEdit = False
        Me.colSE_AddDate.OptionsColumn.ReadOnly = True
        Me.colSE_AddDate.Visible = True
        Me.colSE_AddDate.VisibleIndex = 0
        '
        'colSE_OutCardID
        '
        Me.colSE_OutCardID.Caption = "发料刷卡人"
        Me.colSE_OutCardID.FieldName = "SE_OutCardID"
        Me.colSE_OutCardID.Name = "colSE_OutCardID"
        Me.colSE_OutCardID.OptionsColumn.AllowEdit = False
        Me.colSE_OutCardID.OptionsColumn.ReadOnly = True
        Me.colSE_OutCardID.SummaryItem.DisplayFormat = "合計:"
        Me.colSE_OutCardID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colSE_OutCardID.Visible = True
        Me.colSE_OutCardID.VisibleIndex = 4
        Me.colSE_OutCardID.Width = 80
        '
        'colaSE_AddDate
        '
        Me.colaSE_AddDate.Caption = "发生时间"
        Me.colaSE_AddDate.DisplayFormat.FormatString = "HH:mm:ss"
        Me.colaSE_AddDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colaSE_AddDate.FieldName = "SE_AddDate"
        Me.colaSE_AddDate.GroupFormat.FormatString = "HH:mm:ss"
        Me.colaSE_AddDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colaSE_AddDate.Name = "colaSE_AddDate"
        Me.colaSE_AddDate.OptionsColumn.AllowEdit = False
        Me.colaSE_AddDate.OptionsColumn.ReadOnly = True
        Me.colaSE_AddDate.Visible = True
        Me.colaSE_AddDate.VisibleIndex = 1
        '
        'colSE_TypeName
        '
        Me.colSE_TypeName.Caption = "类型"
        Me.colSE_TypeName.FieldName = "SE_TypeName"
        Me.colSE_TypeName.Name = "colSE_TypeName"
        Me.colSE_TypeName.Visible = True
        Me.colSE_TypeName.VisibleIndex = 5
        Me.colSE_TypeName.Width = 45
        '
        'colSE_InTime
        '
        Me.colSE_InTime.Caption = "处理时间"
        Me.colSE_InTime.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.colSE_InTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSE_InTime.FieldName = "SE_InTime"
        Me.colSE_InTime.GroupFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.colSE_InTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSE_InTime.Name = "colSE_InTime"
        Me.colSE_InTime.ToolTip = "借出没有处理时间"
        Me.colSE_InTime.Visible = True
        Me.colSE_InTime.VisibleIndex = 13
        '
        'colSE_InCardID
        '
        Me.colSE_InCardID.Caption = "收料刷卡人"
        Me.colSE_InCardID.FieldName = "SE_InCardID"
        Me.colSE_InCardID.Name = "colSE_InCardID"
        Me.colSE_InCardID.OptionsColumn.AllowEdit = False
        Me.colSE_InCardID.OptionsColumn.ReadOnly = True
        Me.colSE_InCardID.Visible = True
        Me.colSE_InCardID.VisibleIndex = 8
        Me.colSE_InCardID.Width = 114
        '
        'colD_Dep
        '
        Me.colD_Dep.Caption = "责任部门"
        Me.colD_Dep.FieldName = "D_Dep"
        Me.colD_Dep.Name = "colD_Dep"
        Me.colD_Dep.OptionsColumn.AllowEdit = False
        Me.colD_Dep.OptionsColumn.ReadOnly = True
        Me.colD_Dep.Visible = True
        Me.colD_Dep.VisibleIndex = 14
        '
        'colDutyUserID
        '
        Me.colDutyUserID.Caption = "责任人"
        Me.colDutyUserID.FieldName = "DutyUserID"
        Me.colDutyUserID.Name = "colDutyUserID"
        Me.colDutyUserID.Visible = True
        Me.colDutyUserID.VisibleIndex = 15
        '
        'colOccurAddress
        '
        Me.colOccurAddress.Caption = "发生地址"
        Me.colOccurAddress.FieldName = "OccurAddress"
        Me.colOccurAddress.Name = "colOccurAddress"
        Me.colOccurAddress.OptionsColumn.AllowEdit = False
        Me.colOccurAddress.OptionsColumn.ReadOnly = True
        Me.colOccurAddress.Visible = True
        Me.colOccurAddress.VisibleIndex = 16
        '
        'colOccurReason
        '
        Me.colOccurReason.Caption = "发生原因"
        Me.colOccurReason.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colOccurReason.FieldName = "OccurReason"
        Me.colOccurReason.Name = "colOccurReason"
        Me.colOccurReason.OptionsColumn.ReadOnly = True
        Me.colOccurReason.Visible = True
        Me.colOccurReason.VisibleIndex = 11
        Me.colOccurReason.Width = 100
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colSE_DelUserID
        '
        Me.colSE_DelUserID.Caption = "辦單刪除人員"
        Me.colSE_DelUserID.FieldName = "SE_DelUserID"
        Me.colSE_DelUserID.Name = "colSE_DelUserID"
        Me.colSE_DelUserID.Visible = True
        Me.colSE_DelUserID.VisibleIndex = 10
        Me.colSE_DelUserID.Width = 92
        '
        'colProcessResult
        '
        Me.colProcessResult.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colProcessResult.AppearanceCell.Options.UseForeColor = True
        Me.colProcessResult.Caption = "解决对策"
        Me.colProcessResult.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colProcessResult.FieldName = "ProcessResult"
        Me.colProcessResult.Name = "colProcessResult"
        Me.colProcessResult.OptionsColumn.ReadOnly = True
        Me.colProcessResult.Visible = True
        Me.colProcessResult.VisibleIndex = 12
        Me.colProcessResult.Width = 108
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colAddUserID
        '
        Me.colAddUserID.Caption = "处理人员"
        Me.colAddUserID.FieldName = "AddUserID"
        Me.colAddUserID.Name = "colAddUserID"
        Me.colAddUserID.OptionsColumn.AllowEdit = False
        Me.colAddUserID.OptionsColumn.ReadOnly = True
        '
        'colCheckBit
        '
        Me.colCheckBit.Caption = "处理"
        Me.colCheckBit.FieldName = "CheckBit"
        Me.colCheckBit.Name = "colCheckBit"
        Me.colCheckBit.OptionsColumn.AllowEdit = False
        Me.colCheckBit.OptionsColumn.ReadOnly = True
        Me.colCheckBit.Visible = True
        Me.colCheckBit.VisibleIndex = 17
        Me.colCheckBit.Width = 45
        '
        'colCheckAction
        '
        Me.colCheckAction.Caption = "GridColumn15"
        Me.colCheckAction.FieldName = "CheckAction"
        Me.colCheckAction.Name = "colCheckAction"
        Me.colCheckAction.OptionsColumn.AllowEdit = False
        Me.colCheckAction.OptionsColumn.ReadOnly = True
        '
        'colCheckDate
        '
        Me.colCheckDate.Caption = "审核时间"
        Me.colCheckDate.FieldName = "CheckDate"
        Me.colCheckDate.Name = "colCheckDate"
        Me.colCheckDate.OptionsColumn.AllowEdit = False
        Me.colCheckDate.OptionsColumn.ReadOnly = True
        '
        'colCheckRemark
        '
        Me.colCheckRemark.Caption = "审核备注"
        Me.colCheckRemark.FieldName = "CheckRemark"
        Me.colCheckRemark.Name = "colCheckRemark"
        Me.colCheckRemark.OptionsColumn.AllowEdit = False
        Me.colCheckRemark.OptionsColumn.ReadOnly = True
        '
        'colAddUserName
        '
        Me.colAddUserName.Caption = "处理人员"
        Me.colAddUserName.FieldName = "AddUserName"
        Me.colAddUserName.Name = "colAddUserName"
        Me.colAddUserName.OptionsColumn.AllowEdit = False
        Me.colAddUserName.OptionsColumn.ReadOnly = True
        Me.colAddUserName.Visible = True
        Me.colAddUserName.VisibleIndex = 19
        '
        'colCheckActionName
        '
        Me.colCheckActionName.Caption = "确认人员"
        Me.colCheckActionName.FieldName = "CheckActionName"
        Me.colCheckActionName.Name = "colCheckActionName"
        Me.colCheckActionName.OptionsColumn.AllowEdit = False
        Me.colCheckActionName.OptionsColumn.ReadOnly = True
        Me.colCheckActionName.Visible = True
        Me.colCheckActionName.VisibleIndex = 18
        '
        'colPutInQty
        '
        Me.colPutInQty.Caption = "投入数量"
        Me.colPutInQty.FieldName = "PutInQty"
        Me.colPutInQty.Name = "colPutInQty"
        Me.colPutInQty.OptionsColumn.AllowEdit = False
        Me.colPutInQty.OptionsColumn.ReadOnly = True
        Me.colPutInQty.Visible = True
        Me.colPutInQty.VisibleIndex = 20
        '
        'colPutInCount
        '
        Me.colPutInCount.Caption = "投入次数"
        Me.colPutInCount.FieldName = "PutInCount"
        Me.colPutInCount.Name = "colPutInCount"
        Me.colPutInCount.OptionsColumn.AllowEdit = False
        Me.colPutInCount.OptionsColumn.ReadOnly = True
        Me.colPutInCount.Visible = True
        Me.colPutInCount.VisibleIndex = 21
        '
        'colRatioQty
        '
        Me.colRatioQty.Caption = "数量比率"
        Me.colRatioQty.FieldName = "RatioQty"
        Me.colRatioQty.Name = "colRatioQty"
        Me.colRatioQty.OptionsColumn.AllowEdit = False
        Me.colRatioQty.OptionsColumn.ReadOnly = True
        Me.colRatioQty.Visible = True
        Me.colRatioQty.VisibleIndex = 22
        '
        'colRatioCount
        '
        Me.colRatioCount.Caption = "次数比率"
        Me.colRatioCount.FieldName = "RatioCount"
        Me.colRatioCount.Name = "colRatioCount"
        Me.colRatioCount.OptionsColumn.AllowEdit = False
        Me.colRatioCount.OptionsColumn.ReadOnly = True
        Me.colRatioCount.Visible = True
        Me.colRatioCount.VisibleIndex = 23
        '
        'colRemark
        '
        Me.colRemark.Caption = "备注"
        Me.colRemark.FieldName = "Remark"
        Me.colRemark.Name = "colRemark"
        Me.colRemark.OptionsColumn.AllowEdit = False
        Me.colRemark.OptionsColumn.ReadOnly = True
        Me.colRemark.Visible = True
        Me.colRemark.VisibleIndex = 24
        '
        'colEmailTilte
        '
        Me.colEmailTilte.Caption = "邮件标题"
        Me.colEmailTilte.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colEmailTilte.FieldName = "EmailTilte"
        Me.colEmailTilte.Name = "colEmailTilte"
        Me.colEmailTilte.OptionsColumn.ReadOnly = True
        Me.colEmailTilte.Width = 500
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'frmSampAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 628)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSampAlarm"
        Me.Text = "报警信息服务"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_AddUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_OutD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_InD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_OutCardID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_InCardID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcessResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQurey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colOccurReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colaSE_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOccurAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPutInQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPutInCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatioQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatioCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailTilte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_DelUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colSE_InTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDutyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_TypeName As DevExpress.XtraGrid.Columns.GridColumn
End Class
