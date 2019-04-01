<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionBatchAllotMain
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
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsTrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Appearance.Options.UseForeColor = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 11)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(115, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "生產派工單"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(792, 37)
        Me.PanelControl1.TabIndex = 5
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsTrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(792, 508)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsTrip
        '
        Me.cmsTrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsEdit, Me.cmsDel, Me.ToolStripSeparator2, Me.cmsCheck, Me.ToolStripSeparator4, Me.cmsPreView, Me.cmsQuery, Me.cmsRef, Me.ToolStripSeparator3, Me.cmsPrint})
        Me.cmsTrip.Name = "cmsTrip"
        Me.cmsTrip.Size = New System.Drawing.Size(189, 220)
        '
        'cmsAdd
        '
        Me.cmsAdd.Enabled = False
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(188, 22)
        Me.cmsAdd.Text = "新增(&A)..."
        '
        'cmsEdit
        '
        Me.cmsEdit.Enabled = False
        Me.cmsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsEdit.Size = New System.Drawing.Size(188, 22)
        Me.cmsEdit.Text = "修改(&E)..."
        '
        'cmsDel
        '
        Me.cmsDel.Enabled = False
        Me.cmsDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDel.Name = "cmsDel"
        Me.cmsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDel.Size = New System.Drawing.Size(188, 22)
        Me.cmsDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'cmsCheck
        '
        Me.cmsCheck.Enabled = False
        Me.cmsCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsCheck.Name = "cmsCheck"
        Me.cmsCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsCheck.Size = New System.Drawing.Size(188, 22)
        Me.cmsCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'cmsPreView
        '
        Me.cmsPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsPreView.Name = "cmsPreView"
        Me.cmsPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsPreView.Size = New System.Drawing.Size(188, 22)
        Me.cmsPreView.Text = "查看(&W)..."
        '
        'cmsQuery
        '
        Me.cmsQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsQuery.Name = "cmsQuery"
        Me.cmsQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsQuery.Size = New System.Drawing.Size(188, 22)
        Me.cmsQuery.Text = "查詢(&F)..."
        '
        'cmsRef
        '
        Me.cmsRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsRef.Name = "cmsRef"
        Me.cmsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsRef.Size = New System.Drawing.Size(188, 22)
        Me.cmsRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'cmsPrint
        '
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(188, 22)
        Me.cmsPrint.Text = "列印(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.PBA_ID, Me.OS_BatchID, Me.M_Code, Me.M_Name, Me.M_Unit, Me.FacName, Me.FacID, Me.ON_NeedQty, Me.PBA_Qty, Me.PBA_AddDate, Me.PBA_AddUserName, Me.PBA_CheckDate, Me.PBA_CheckUserName, Me.PBA_Check})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "拖動列表頭到此處進行可分組"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'PBA_ID
        '
        Me.PBA_ID.Caption = "派工單號"
        Me.PBA_ID.FieldName = "PBA_ID"
        Me.PBA_ID.Name = "PBA_ID"
        Me.PBA_ID.OptionsColumn.ReadOnly = True
        Me.PBA_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.PBA_ID.Visible = True
        Me.PBA_ID.VisibleIndex = 0
        Me.PBA_ID.Width = 100
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.OptionsColumn.ReadOnly = True
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 130
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "物料單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 4
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.OptionsColumn.ReadOnly = True
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 5
        '
        'FacID
        '
        Me.FacID.Caption = "廠別編號"
        Me.FacID.FieldName = "FacID"
        Me.FacID.Name = "FacID"
        Me.FacID.OptionsColumn.ReadOnly = True
        '
        'ON_NeedQty
        '
        Me.ON_NeedQty.Caption = "批次需求量"
        Me.ON_NeedQty.FieldName = "ON_NeedQty"
        Me.ON_NeedQty.Name = "ON_NeedQty"
        Me.ON_NeedQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_NeedQty.Visible = True
        Me.ON_NeedQty.VisibleIndex = 6
        Me.ON_NeedQty.Width = 85
        '
        'PBA_Qty
        '
        Me.PBA_Qty.Caption = "分派數量"
        Me.PBA_Qty.FieldName = "PBA_Qty"
        Me.PBA_Qty.Name = "PBA_Qty"
        Me.PBA_Qty.OptionsColumn.ReadOnly = True
        Me.PBA_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PBA_Qty.Visible = True
        Me.PBA_Qty.VisibleIndex = 7
        '
        'PBA_AddDate
        '
        Me.PBA_AddDate.Caption = "新增日期"
        Me.PBA_AddDate.FieldName = "PBA_AddDate"
        Me.PBA_AddDate.Name = "PBA_AddDate"
        Me.PBA_AddDate.OptionsColumn.ReadOnly = True
        Me.PBA_AddDate.Visible = True
        Me.PBA_AddDate.VisibleIndex = 8
        Me.PBA_AddDate.Width = 85
        '
        'PBA_AddUserName
        '
        Me.PBA_AddUserName.Caption = "新增人"
        Me.PBA_AddUserName.FieldName = "PBA_AddUserName"
        Me.PBA_AddUserName.Name = "PBA_AddUserName"
        Me.PBA_AddUserName.OptionsColumn.ReadOnly = True
        Me.PBA_AddUserName.Visible = True
        Me.PBA_AddUserName.VisibleIndex = 9
        '
        'PBA_CheckDate
        '
        Me.PBA_CheckDate.Caption = "審核日期"
        Me.PBA_CheckDate.FieldName = "PBA_CheckDate"
        Me.PBA_CheckDate.Name = "PBA_CheckDate"
        Me.PBA_CheckDate.OptionsColumn.ReadOnly = True
        Me.PBA_CheckDate.Visible = True
        Me.PBA_CheckDate.VisibleIndex = 10
        '
        'PBA_CheckUserName
        '
        Me.PBA_CheckUserName.Caption = "審核人"
        Me.PBA_CheckUserName.FieldName = "PBA_CheckUserName"
        Me.PBA_CheckUserName.Name = "PBA_CheckUserName"
        Me.PBA_CheckUserName.OptionsColumn.ReadOnly = True
        Me.PBA_CheckUserName.Visible = True
        Me.PBA_CheckUserName.VisibleIndex = 11
        '
        'PBA_Check
        '
        Me.PBA_Check.Caption = "審核"
        Me.PBA_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.PBA_Check.FieldName = "PBA_Check"
        Me.PBA_Check.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.PBA_Check.Name = "PBA_Check"
        Me.PBA_Check.OptionsColumn.ReadOnly = True
        Me.PBA_Check.Visible = True
        Me.PBA_Check.VisibleIndex = 12
        Me.PBA_Check.Width = 55
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmProductionBatchAllotMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 545)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmProductionBatchAllotMain"
        Me.Text = "生產派工單"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsTrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PBA_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
End Class
