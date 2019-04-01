<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareBorrowMain
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.WareBorrowContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripBorrowAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripBorrowDelay = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripBorrowFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripBorrowView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripBorrowRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripBorrowPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripBorrowNOReturn = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripBorrowExport = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_ReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_PerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WBR_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WBR_QtyStr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DelayDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.CaptionLabel = New System.Windows.Forms.Label
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WB_NUM2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyReal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Action2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RR_PerName2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Date2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkReal2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.Qty2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridC = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ChangeNoCh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NUMch = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Codech = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Namech = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gaugech = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtySch = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyEch = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChageDatech = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChangeActionNamech = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WareBorrowContext.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.WareBorrowContext
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(763, 297)
        Me.Grid1.TabIndex = 170
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'WareBorrowContext
        '
        Me.WareBorrowContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBorrowAdd, Me.ToolStripBorrowDelay, Me.ToolStripMenuItem1, Me.ToolStripBorrowFind, Me.ToolStripBorrowView, Me.ToolStripMenuItem2, Me.ToolStripBorrowRefresh, Me.ToolStripMenuItem3, Me.ToolStripBorrowPrint, Me.ToolStripBorrowNOReturn, Me.ToolStripMenuItem4, Me.ToolStripBorrowExport, Me.CopyToolStripMenuItem, Me.CopyALLToolStripMenuItem})
        Me.WareBorrowContext.Name = "WareBorrowContext"
        Me.WareBorrowContext.Size = New System.Drawing.Size(184, 248)
        '
        'ToolStripBorrowAdd
        '
        Me.ToolStripBorrowAdd.Enabled = False
        Me.ToolStripBorrowAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripBorrowAdd.Name = "ToolStripBorrowAdd"
        Me.ToolStripBorrowAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ToolStripBorrowAdd.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowAdd.Text = "借刀(&A)"
        '
        'ToolStripBorrowDelay
        '
        Me.ToolStripBorrowDelay.Enabled = False
        Me.ToolStripBorrowDelay.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.ToolStripBorrowDelay.Name = "ToolStripBorrowDelay"
        Me.ToolStripBorrowDelay.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ToolStripBorrowDelay.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowDelay.Text = "延期(&U)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripBorrowFind
        '
        Me.ToolStripBorrowFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.ToolStripBorrowFind.Name = "ToolStripBorrowFind"
        Me.ToolStripBorrowFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ToolStripBorrowFind.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowFind.Text = "查詢(&F)"
        '
        'ToolStripBorrowView
        '
        Me.ToolStripBorrowView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.ToolStripBorrowView.Name = "ToolStripBorrowView"
        Me.ToolStripBorrowView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripBorrowView.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowView.Text = "查看(&W)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripBorrowRefresh
        '
        Me.ToolStripBorrowRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ToolStripBorrowRefresh.Name = "ToolStripBorrowRefresh"
        Me.ToolStripBorrowRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripBorrowRefresh.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowRefresh.Text = "刷新(&R)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripBorrowPrint
        '
        Me.ToolStripBorrowPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ToolStripBorrowPrint.Name = "ToolStripBorrowPrint"
        Me.ToolStripBorrowPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripBorrowPrint.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowPrint.Text = "借刀單(&P)"
        '
        'ToolStripBorrowNOReturn
        '
        Me.ToolStripBorrowNOReturn.Name = "ToolStripBorrowNOReturn"
        Me.ToolStripBorrowNOReturn.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ToolStripBorrowNOReturn.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowNOReturn.Text = "列印未還刀(&K)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripBorrowExport
        '
        Me.ToolStripBorrowExport.Name = "ToolStripBorrowExport"
        Me.ToolStripBorrowExport.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripBorrowExport.Text = "導出(&E)"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CopyToolStripMenuItem.Text = "復制(&C)"
        '
        'CopyALLToolStripMenuItem
        '
        Me.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem"
        Me.CopyALLToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CopyALLToolStripMenuItem.Text = "復制全部"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.WB_NUM, Me.WB_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.Qty, Me.NO_ReQty, Me.WB_Action, Me.WB_PerName, Me.DPT_Name, Me.WH_Name, Me.WB_Date, Me.WB_ActionName, Me.WBR_NO, Me.WBR_QtyStr, Me.DelayDate})
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
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'WB_NUM
        '
        Me.WB_NUM.Caption = "借刀流水號"
        Me.WB_NUM.FieldName = "WB_NUM"
        Me.WB_NUM.Name = "WB_NUM"
        Me.WB_NUM.OptionsColumn.ReadOnly = True
        Me.WB_NUM.Visible = True
        Me.WB_NUM.VisibleIndex = 0
        Me.WB_NUM.Width = 92
        '
        'WB_NO
        '
        Me.WB_NO.Caption = "借刀單號"
        Me.WB_NO.FieldName = "WB_NO"
        Me.WB_NO.Name = "WB_NO"
        Me.WB_NO.OptionsColumn.ReadOnly = True
        Me.WB_NO.Visible = True
        Me.WB_NO.VisibleIndex = 1
        Me.WB_NO.Width = 92
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 140
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 90
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        '
        'Qty
        '
        Me.Qty.Caption = "借出數量"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.ReadOnly = True
        Me.Qty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 5
        '
        'NO_ReQty
        '
        Me.NO_ReQty.Caption = "未還數量"
        Me.NO_ReQty.FieldName = "NO_ReQty"
        Me.NO_ReQty.Name = "NO_ReQty"
        Me.NO_ReQty.OptionsColumn.ReadOnly = True
        Me.NO_ReQty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.NO_ReQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.NO_ReQty.Visible = True
        Me.NO_ReQty.VisibleIndex = 6
        '
        'WB_Action
        '
        Me.WB_Action.Caption = "借刀人工號"
        Me.WB_Action.FieldName = "WB_PerID"
        Me.WB_Action.Name = "WB_Action"
        Me.WB_Action.OptionsColumn.ReadOnly = True
        Me.WB_Action.Visible = True
        Me.WB_Action.VisibleIndex = 7
        Me.WB_Action.Width = 90
        '
        'WB_PerName
        '
        Me.WB_PerName.Caption = "借刀人"
        Me.WB_PerName.FieldName = "WB_PerName"
        Me.WB_PerName.Name = "WB_PerName"
        Me.WB_PerName.OptionsColumn.ReadOnly = True
        Me.WB_PerName.Visible = True
        Me.WB_PerName.VisibleIndex = 8
        '
        'DPT_Name
        '
        Me.DPT_Name.Caption = "部門"
        Me.DPT_Name.FieldName = "DPT_Name"
        Me.DPT_Name.Name = "DPT_Name"
        Me.DPT_Name.OptionsColumn.ReadOnly = True
        Me.DPT_Name.Visible = True
        Me.DPT_Name.VisibleIndex = 9
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "倉庫名稱"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.OptionsColumn.ReadOnly = True
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 10
        '
        'WB_Date
        '
        Me.WB_Date.Caption = "借出日期"
        Me.WB_Date.FieldName = "WB_Date"
        Me.WB_Date.Name = "WB_Date"
        Me.WB_Date.OptionsColumn.ReadOnly = True
        Me.WB_Date.Visible = True
        Me.WB_Date.VisibleIndex = 11
        '
        'WB_ActionName
        '
        Me.WB_ActionName.Caption = "操作人"
        Me.WB_ActionName.FieldName = "WB_ActionName"
        Me.WB_ActionName.Name = "WB_ActionName"
        Me.WB_ActionName.OptionsColumn.ReadOnly = True
        Me.WB_ActionName.Visible = True
        Me.WB_ActionName.VisibleIndex = 12
        '
        'WBR_NO
        '
        Me.WBR_NO.Caption = "歸還單號"
        Me.WBR_NO.FieldName = "WBR_NO"
        Me.WBR_NO.Name = "WBR_NO"
        Me.WBR_NO.OptionsColumn.ReadOnly = True
        '
        'WBR_QtyStr
        '
        Me.WBR_QtyStr.Caption = "歸還數量"
        Me.WBR_QtyStr.FieldName = "WBR_QtyStr"
        Me.WBR_QtyStr.Name = "WBR_QtyStr"
        Me.WBR_QtyStr.OptionsColumn.ReadOnly = True
        '
        'DelayDate
        '
        Me.DelayDate.Caption = "延期至"
        Me.DelayDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.DelayDate.FieldName = "DelayDate"
        Me.DelayDate.Name = "DelayDate"
        Me.DelayDate.OptionsColumn.AllowEdit = False
        Me.DelayDate.OptionsColumn.ReadOnly = True
        Me.DelayDate.Visible = True
        Me.DelayDate.VisibleIndex = 13
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaptionLabel.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaptionLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaptionLabel.Location = New System.Drawing.Point(6, 4)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(106, 24)
        Me.CaptionLabel.TabIndex = 169
        Me.CaptionLabel.Text = "借刀作業"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(1, 37)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(125, 448)
        Me.TreeView1.TabIndex = 168
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(895, 36)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Grid2
        '
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView1
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoExEdit3})
        Me.Grid2.Size = New System.Drawing.Size(754, 110)
        Me.Grid2.TabIndex = 175
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WB_NUM2, Me.WB_NO2, Me.M_Code2, Me.M_Name2, Me.M_Gauge2, Me.QtyReal, Me.WB_Action2, Me.RR_PerName2, Me.WH_Name2, Me.WB_Date2, Me.RemarkReal2, Me.Qty2})
        Me.GridView1.GridControl = Me.Grid2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
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
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'WB_NUM2
        '
        Me.WB_NUM2.Caption = "還刀流水號"
        Me.WB_NUM2.FieldName = "WB_NUM"
        Me.WB_NUM2.Name = "WB_NUM2"
        Me.WB_NUM2.OptionsColumn.ReadOnly = True
        Me.WB_NUM2.Visible = True
        Me.WB_NUM2.VisibleIndex = 0
        Me.WB_NUM2.Width = 90
        '
        'WB_NO2
        '
        Me.WB_NO2.Caption = "還刀單號"
        Me.WB_NO2.FieldName = "WB_NO"
        Me.WB_NO2.Name = "WB_NO2"
        Me.WB_NO2.OptionsColumn.ReadOnly = True
        Me.WB_NO2.Visible = True
        Me.WB_NO2.VisibleIndex = 1
        Me.WB_NO2.Width = 90
        '
        'M_Code2
        '
        Me.M_Code2.Caption = "刀具編碼"
        Me.M_Code2.FieldName = "M_Code"
        Me.M_Code2.Name = "M_Code2"
        Me.M_Code2.OptionsColumn.ReadOnly = True
        Me.M_Code2.Visible = True
        Me.M_Code2.VisibleIndex = 2
        Me.M_Code2.Width = 120
        '
        'M_Name2
        '
        Me.M_Name2.Caption = "名稱"
        Me.M_Name2.FieldName = "M_Name"
        Me.M_Name2.Name = "M_Name2"
        Me.M_Name2.OptionsColumn.ReadOnly = True
        Me.M_Name2.Visible = True
        Me.M_Name2.VisibleIndex = 3
        '
        'M_Gauge2
        '
        Me.M_Gauge2.Caption = "規格"
        Me.M_Gauge2.FieldName = "M_Gauge"
        Me.M_Gauge2.Name = "M_Gauge2"
        Me.M_Gauge2.OptionsColumn.ReadOnly = True
        Me.M_Gauge2.Visible = True
        Me.M_Gauge2.VisibleIndex = 4
        '
        'QtyReal
        '
        Me.QtyReal.AppearanceCell.Options.UseTextOptions = True
        Me.QtyReal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QtyReal.Caption = "還刀數"
        Me.QtyReal.FieldName = "QtyReal"
        Me.QtyReal.Name = "QtyReal"
        Me.QtyReal.OptionsColumn.ReadOnly = True
        Me.QtyReal.SummaryItem.DisplayFormat = "合計:{0}"
        Me.QtyReal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QtyReal.Visible = True
        Me.QtyReal.VisibleIndex = 5
        Me.QtyReal.Width = 60
        '
        'WB_Action2
        '
        Me.WB_Action2.Caption = "還刀人"
        Me.WB_Action2.FieldName = "WB_PerName"
        Me.WB_Action2.Name = "WB_Action2"
        Me.WB_Action2.OptionsColumn.ReadOnly = True
        Me.WB_Action2.Visible = True
        Me.WB_Action2.VisibleIndex = 6
        '
        'RR_PerName2
        '
        Me.RR_PerName2.Caption = "代還人"
        Me.RR_PerName2.FieldName = "RR_PerName"
        Me.RR_PerName2.Name = "RR_PerName2"
        Me.RR_PerName2.OptionsColumn.ReadOnly = True
        Me.RR_PerName2.Visible = True
        Me.RR_PerName2.VisibleIndex = 7
        '
        'WH_Name2
        '
        Me.WH_Name2.Caption = "倉庫名稱"
        Me.WH_Name2.FieldName = "WH_Name"
        Me.WH_Name2.Name = "WH_Name2"
        Me.WH_Name2.OptionsColumn.ReadOnly = True
        '
        'WB_Date2
        '
        Me.WB_Date2.Caption = "還刀日期"
        Me.WB_Date2.FieldName = "WB_Date"
        Me.WB_Date2.Name = "WB_Date2"
        Me.WB_Date2.OptionsColumn.ReadOnly = True
        Me.WB_Date2.Visible = True
        Me.WB_Date2.VisibleIndex = 8
        '
        'RemarkReal2
        '
        Me.RemarkReal2.Caption = "備注"
        Me.RemarkReal2.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.RemarkReal2.FieldName = "RemarkReal"
        Me.RemarkReal2.Name = "RemarkReal2"
        Me.RemarkReal2.OptionsColumn.ReadOnly = True
        Me.RemarkReal2.Visible = True
        Me.RemarkReal2.VisibleIndex = 9
        Me.RemarkReal2.Width = 120
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'Qty2
        '
        Me.Qty2.Caption = "數量"
        Me.Qty2.FieldName = "Qty"
        Me.Qty2.Name = "Qty2"
        Me.Qty2.OptionsColumn.ReadOnly = True
        Me.Qty2.Visible = True
        Me.Qty2.VisibleIndex = 10
        Me.Qty2.Width = 60
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(132, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(763, 443)
        Me.SplitContainer1.SplitterDistance = 297
        Me.SplitContainer1.TabIndex = 176
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(763, 142)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(754, 110)
        Me.XtraTabPage1.Text = "還刀記錄"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridC)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(754, 110)
        Me.XtraTabPage2.Text = "更改單"
        '
        'GridC
        '
        Me.GridC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridC.EmbeddedNavigator.Name = ""
        Me.GridC.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridC.Location = New System.Drawing.Point(0, 0)
        Me.GridC.MainView = Me.GridView3
        Me.GridC.Name = "GridC"
        Me.GridC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemMemoExEdit4, Me.RepositoryItemDateEdit2})
        Me.GridC.Size = New System.Drawing.Size(754, 110)
        Me.GridC.TabIndex = 175
        Me.GridC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ChangeNoCh, Me.WB_NUMch, Me.M_Codech, Me.M_Namech, Me.M_Gaugech, Me.QtySch, Me.QtyEch, Me.ChageDatech, Me.ChangeActionNamech})
        Me.GridView3.GridControl = Me.GridC
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'ChangeNoCh
        '
        Me.ChangeNoCh.Caption = "單號"
        Me.ChangeNoCh.FieldName = "ChangeNo"
        Me.ChangeNoCh.Name = "ChangeNoCh"
        Me.ChangeNoCh.OptionsColumn.ReadOnly = True
        Me.ChangeNoCh.Visible = True
        Me.ChangeNoCh.VisibleIndex = 0
        Me.ChangeNoCh.Width = 100
        '
        'WB_NUMch
        '
        Me.WB_NUMch.Caption = "借刀單"
        Me.WB_NUMch.FieldName = "WB_NUM"
        Me.WB_NUMch.Name = "WB_NUMch"
        Me.WB_NUMch.OptionsColumn.ReadOnly = True
        Me.WB_NUMch.Visible = True
        Me.WB_NUMch.VisibleIndex = 1
        Me.WB_NUMch.Width = 100
        '
        'M_Codech
        '
        Me.M_Codech.Caption = "編碼"
        Me.M_Codech.FieldName = "M_Code"
        Me.M_Codech.Name = "M_Codech"
        Me.M_Codech.OptionsColumn.ReadOnly = True
        Me.M_Codech.Visible = True
        Me.M_Codech.VisibleIndex = 2
        Me.M_Codech.Width = 100
        '
        'M_Namech
        '
        Me.M_Namech.Caption = "名稱"
        Me.M_Namech.FieldName = "M_Name"
        Me.M_Namech.Name = "M_Namech"
        Me.M_Namech.OptionsColumn.ReadOnly = True
        Me.M_Namech.Visible = True
        Me.M_Namech.VisibleIndex = 3
        '
        'M_Gaugech
        '
        Me.M_Gaugech.Caption = "規格"
        Me.M_Gaugech.FieldName = "M_Gauge"
        Me.M_Gaugech.Name = "M_Gaugech"
        Me.M_Gaugech.OptionsColumn.ReadOnly = True
        Me.M_Gaugech.Visible = True
        Me.M_Gaugech.VisibleIndex = 4
        Me.M_Gaugech.Width = 120
        '
        'QtySch
        '
        Me.QtySch.Caption = "更改前數量"
        Me.QtySch.FieldName = "QtyS"
        Me.QtySch.Name = "QtySch"
        Me.QtySch.OptionsColumn.ReadOnly = True
        Me.QtySch.Visible = True
        Me.QtySch.VisibleIndex = 5
        Me.QtySch.Width = 90
        '
        'QtyEch
        '
        Me.QtyEch.Caption = "更改后數量"
        Me.QtyEch.FieldName = "QtyE"
        Me.QtyEch.Name = "QtyEch"
        Me.QtyEch.OptionsColumn.ReadOnly = True
        Me.QtyEch.Visible = True
        Me.QtyEch.VisibleIndex = 6
        Me.QtyEch.Width = 90
        '
        'ChageDatech
        '
        Me.ChageDatech.Caption = "更改日期"
        Me.ChageDatech.FieldName = "ChageDate"
        Me.ChageDatech.Name = "ChageDatech"
        Me.ChageDatech.OptionsColumn.ReadOnly = True
        Me.ChageDatech.Visible = True
        Me.ChageDatech.VisibleIndex = 7
        '
        'ChangeActionNamech
        '
        Me.ChangeActionNamech.Caption = "更改人"
        Me.ChangeActionNamech.FieldName = "ChangeActionName"
        Me.ChangeActionNamech.Name = "ChangeActionNamech"
        Me.ChangeActionNamech.OptionsColumn.ReadOnly = True
        Me.ChangeActionNamech.Visible = True
        Me.ChangeActionNamech.VisibleIndex = 8
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'frmWareBorrowMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 491)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmWareBorrowMain"
        Me.Text = "借刀作業"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WareBorrowContext.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WareBorrowContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripBorrowAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBorrowFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBorrowView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBorrowRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WB_NUM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_Action2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RR_PerName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_Name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_ReQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_PerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WBR_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBorrowPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WBR_QtyStr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkReal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ToolStripBorrowDelay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ToolStripBorrowNOReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBorrowExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChangeNoCh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NUMch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Codech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Namech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gaugech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtySch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyEch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChageDatech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChangeActionNamech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents WB_Action As DevExpress.XtraGrid.Columns.GridColumn
End Class
