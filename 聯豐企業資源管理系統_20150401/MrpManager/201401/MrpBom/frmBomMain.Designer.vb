<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBomMain
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
        Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Me.sonsNum = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridBom_Main = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdBom = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ParentGroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Version = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ProductionUnit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EffectiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InvalidDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.xtcTable = New DevExpress.XtraTab.XtraTabControl
        Me.xtpB = New DevExpress.XtraTab.XtraTabPage
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.QtyPer = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn12 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.LossQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.ActualQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.M_Unit = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn8 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.CreateUserName = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn9 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn10 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.TreeListColumn11 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.xtpA = New DevExpress.XtraTab.XtraTabPage
        Me.GridBom_Detail = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Item = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChildGroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChildName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ChildGauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.IsUnfold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReplaceType1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UseFeatures = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Mount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tmrtc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SendUnit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LossRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EffectiveDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InvalidDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.lblCheckUserID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtrecheckaction = New System.Windows.Forms.Label
        Me.txtrecheckdate = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.xtpC = New DevExpress.XtraTab.XtraTabPage
        Me.Grid3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
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
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblinfo = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridBom_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTable.SuspendLayout()
        Me.xtpB.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpA.SuspendLayout()
        CType(Me.GridBom_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpC.SuspendLayout()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sonsNum
        '
        Me.sonsNum.Caption = "sonsNum"
        Me.sonsNum.FieldName = "sonsNum"
        Me.sonsNum.Name = "sonsNum"
        Me.sonsNum.OptionsColumn.AllowEdit = False
        Me.sonsNum.OptionsColumn.ReadOnly = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.SplitContainer1)
        Me.PanelControl1.Location = New System.Drawing.Point(1, 36)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(857, 585)
        Me.PanelControl1.TabIndex = 2
        Me.PanelControl1.Text = "PanelControl1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridBom_Main)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.xtcTable)
        Me.SplitContainer1.Size = New System.Drawing.Size(853, 581)
        Me.SplitContainer1.SplitterDistance = 357
        Me.SplitContainer1.TabIndex = 0
        '
        'GridBom_Main
        '
        Me.GridBom_Main.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridBom_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBom_Main.EmbeddedNavigator.Name = ""
        Me.GridBom_Main.Location = New System.Drawing.Point(0, 0)
        Me.GridBom_Main.MainView = Me.GridView1
        Me.GridBom_Main.Name = "GridBom_Main"
        Me.GridBom_Main.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemDateEdit3, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemMemoExEdit4})
        Me.GridBom_Main.Size = New System.Drawing.Size(853, 357)
        Me.GridBom_Main.TabIndex = 0
        Me.GridBom_Main.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdCheck, Me.ToolStripSeparator2, Me.cmdBom, Me.cmdView, Me.cmdFind, Me.cmdRefresh, Me.cmdPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(212, 214)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(211, 22)
        Me.cmdAdd.Text = "新增(&A)"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(211, 22)
        Me.cmdEdit.Text = "修改(&E)"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(211, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(211, 22)
        Me.cmdCheck.Text = "審核(&G)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        'cmdBom
        '
        Me.cmdBom.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdBom.Name = "cmdBom"
        Me.cmdBom.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.cmdBom.Size = New System.Drawing.Size(211, 22)
        Me.cmdBom.Text = "BOM產品展開(&K)"
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(211, 22)
        Me.cmdView.Text = "查看(&W)"
        '
        'cmdFind
        '
        Me.cmdFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdFind.Size = New System.Drawing.Size(211, 22)
        Me.cmdFind.Text = "查詢(&F)"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRefresh.Size = New System.Drawing.Size(211, 22)
        Me.cmdRefresh.Text = "刷新(&R)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(211, 22)
        Me.cmdPrint.Text = "列印(&P)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.ParentGroup, Me.M_Name, Me.M_Gauge, Me.M_Source, Me.Version, Me.ProductionUnit, Me.EffectiveDate, Me.InvalidDate, Me.CreateUserID, Me.CreateDate, Me.ModifyUserID, Me.ModifyDate, Me.CheckBit, Me.CheckUserID, Me.CheckDate, Me.CheckRemark})
        Me.GridView1.GridControl = Me.GridBom_Main
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "#"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'ParentGroup
        '
        Me.ParentGroup.Caption = "產品編號"
        Me.ParentGroup.FieldName = "ParentGroup"
        Me.ParentGroup.Name = "ParentGroup"
        Me.ParentGroup.OptionsColumn.ReadOnly = True
        Me.ParentGroup.Visible = True
        Me.ParentGroup.VisibleIndex = 0
        Me.ParentGroup.Width = 134
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 117
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 131
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.OptionsColumn.ReadOnly = True
        Me.M_Source.Visible = True
        Me.M_Source.VisibleIndex = 3
        Me.M_Source.Width = 70
        '
        'Version
        '
        Me.Version.Caption = "版本"
        Me.Version.FieldName = "Version"
        Me.Version.Name = "Version"
        Me.Version.OptionsColumn.ReadOnly = True
        Me.Version.Visible = True
        Me.Version.VisibleIndex = 4
        Me.Version.Width = 45
        '
        'ProductionUnit
        '
        Me.ProductionUnit.Caption = "單位"
        Me.ProductionUnit.FieldName = "M_Unit"
        Me.ProductionUnit.Name = "ProductionUnit"
        Me.ProductionUnit.OptionsColumn.ReadOnly = True
        Me.ProductionUnit.Visible = True
        Me.ProductionUnit.VisibleIndex = 5
        Me.ProductionUnit.Width = 70
        '
        'EffectiveDate
        '
        Me.EffectiveDate.Caption = "生效日期"
        Me.EffectiveDate.DisplayFormat.FormatString = "d"
        Me.EffectiveDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EffectiveDate.FieldName = "EffectiveDate"
        Me.EffectiveDate.Name = "EffectiveDate"
        Me.EffectiveDate.OptionsColumn.ReadOnly = True
        Me.EffectiveDate.Visible = True
        Me.EffectiveDate.VisibleIndex = 6
        '
        'InvalidDate
        '
        Me.InvalidDate.Caption = "失效日期"
        Me.InvalidDate.DisplayFormat.FormatString = "d"
        Me.InvalidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvalidDate.FieldName = "InvalidDate"
        Me.InvalidDate.Name = "InvalidDate"
        Me.InvalidDate.OptionsColumn.ReadOnly = True
        Me.InvalidDate.Visible = True
        Me.InvalidDate.VisibleIndex = 7
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "創建人員"
        Me.CreateUserID.FieldName = "CreateUserName"
        Me.CreateUserID.Name = "CreateUserID"
        Me.CreateUserID.OptionsColumn.ReadOnly = True
        Me.CreateUserID.Visible = True
        Me.CreateUserID.VisibleIndex = 8
        Me.CreateUserID.Width = 70
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建日期"
        Me.CreateDate.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.OptionsColumn.ReadOnly = True
        Me.CreateDate.Visible = True
        Me.CreateDate.VisibleIndex = 9
        '
        'ModifyUserID
        '
        Me.ModifyUserID.Caption = "修改人員"
        Me.ModifyUserID.FieldName = "ModifyUserID"
        Me.ModifyUserID.Name = "ModifyUserID"
        Me.ModifyUserID.OptionsColumn.ReadOnly = True
        Me.ModifyUserID.Width = 70
        '
        'ModifyDate
        '
        Me.ModifyDate.Caption = "修改日期"
        Me.ModifyDate.DisplayFormat.FormatString = "d"
        Me.ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ModifyDate.FieldName = "ModifyDate"
        Me.ModifyDate.Name = "ModifyDate"
        Me.ModifyDate.OptionsColumn.ReadOnly = True
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.ReadOnly = True
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 10
        Me.CheckBit.Width = 45
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人員"
        Me.CheckUserID.FieldName = "CheckUserName"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.OptionsColumn.ReadOnly = True
        Me.CheckUserID.Visible = True
        Me.CheckUserID.VisibleIndex = 12
        Me.CheckUserID.Width = 70
        '
        'CheckDate
        '
        Me.CheckDate.Caption = "審核日期"
        Me.CheckDate.DisplayFormat.FormatString = "d"
        Me.CheckDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CheckDate.FieldName = "CheckDate"
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.OptionsColumn.ReadOnly = True
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.ReadOnly = True
        Me.CheckRemark.Visible = True
        Me.CheckRemark.VisibleIndex = 11
        Me.CheckRemark.Width = 100
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'xtcTable
        '
        Me.xtcTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcTable.Location = New System.Drawing.Point(0, 0)
        Me.xtcTable.Name = "xtcTable"
        Me.xtcTable.SelectedTabPage = Me.xtpB
        Me.xtcTable.Size = New System.Drawing.Size(853, 220)
        Me.xtcTable.TabIndex = 1
        Me.xtcTable.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpB, Me.xtpA, Me.xtpC})
        '
        'xtpB
        '
        Me.xtpB.Controls.Add(Me.TreeList1)
        Me.xtpB.Name = "xtpB"
        Me.xtpB.Size = New System.Drawing.Size(844, 188)
        Me.xtpB.Text = "展開圖表"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3, Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6, Me.QtyPer, Me.TreeListColumn12, Me.LossQty, Me.ActualQty, Me.M_Unit, Me.sonsNum, Me.TreeListColumn7, Me.TreeListColumn8, Me.CreateUserName, Me.TreeListColumn9, Me.TreeListColumn10, Me.TreeListColumn11})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.sonsNum
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = 0
        Me.TreeList1.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1})
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.ParentFieldName = "PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.TreeList1.Size = New System.Drawing.Size(844, 188)
        Me.TreeList1.TabIndex = 1
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "物料編碼"
        Me.TreeListColumn1.FieldName = "ChildGroup"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 149
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "物料名稱"
        Me.TreeListColumn2.FieldName = "M_Name"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        Me.TreeListColumn2.VisibleIndex = 1
        Me.TreeListColumn2.Width = 137
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "物料規格"
        Me.TreeListColumn3.FieldName = "M_Gauge"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.OptionsColumn.AllowEdit = False
        Me.TreeListColumn3.OptionsColumn.ReadOnly = True
        Me.TreeListColumn3.VisibleIndex = 2
        Me.TreeListColumn3.Width = 147
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "來源碼"
        Me.TreeListColumn4.FieldName = "M_Source"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.AllowEdit = False
        Me.TreeListColumn4.OptionsColumn.ReadOnly = True
        Me.TreeListColumn4.VisibleIndex = 3
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "組成用量"
        Me.TreeListColumn5.FieldName = "Mount"
        Me.TreeListColumn5.Format.FormatString = "#,###0.######"
        Me.TreeListColumn5.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.OptionsColumn.AllowEdit = False
        Me.TreeListColumn5.OptionsColumn.ReadOnly = True
        Me.TreeListColumn5.VisibleIndex = 4
        Me.TreeListColumn5.Width = 66
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "主件底數"
        Me.TreeListColumn6.FieldName = "Tmrtc"
        Me.TreeListColumn6.Format.FormatString = "#,###0.######"
        Me.TreeListColumn6.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.OptionsColumn.AllowEdit = False
        Me.TreeListColumn6.OptionsColumn.ReadOnly = True
        Me.TreeListColumn6.VisibleIndex = 5
        Me.TreeListColumn6.Width = 65
        '
        'QtyPer
        '
        Me.QtyPer.Caption = "單位用量"
        Me.QtyPer.FieldName = "QtyPer"
        Me.QtyPer.Format.FormatString = "#,###0.######"
        Me.QtyPer.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QtyPer.Name = "QtyPer"
        Me.QtyPer.OptionsColumn.AllowEdit = False
        Me.QtyPer.OptionsColumn.ReadOnly = True
        Me.QtyPer.VisibleIndex = 6
        Me.QtyPer.Width = 65
        '
        'TreeListColumn12
        '
        Me.TreeListColumn12.Caption = "損耗率"
        Me.TreeListColumn12.FieldName = "LossRate"
        Me.TreeListColumn12.Format.FormatString = "#,###0.######"
        Me.TreeListColumn12.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TreeListColumn12.Name = "TreeListColumn12"
        Me.TreeListColumn12.VisibleIndex = 7
        Me.TreeListColumn12.Width = 69
        '
        'LossQty
        '
        Me.LossQty.Caption = "損耗數量"
        Me.LossQty.FieldName = "LossQty"
        Me.LossQty.Format.FormatString = "#,###0.######"
        Me.LossQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LossQty.Name = "LossQty"
        Me.LossQty.VisibleIndex = 8
        '
        'ActualQty
        '
        Me.ActualQty.Caption = "實際數量"
        Me.ActualQty.FieldName = "ActualQty"
        Me.ActualQty.Format.FormatString = "#,###0.######"
        Me.ActualQty.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ActualQty.Name = "ActualQty"
        Me.ActualQty.OptionsColumn.AllowEdit = False
        Me.ActualQty.OptionsColumn.ReadOnly = True
        Me.ActualQty.VisibleIndex = 9
        Me.ActualQty.Width = 64
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.VisibleIndex = 10
        Me.M_Unit.Width = 54
        '
        'TreeListColumn7
        '
        Me.TreeListColumn7.Caption = "生效日期"
        Me.TreeListColumn7.FieldName = "EffectiveDate"
        Me.TreeListColumn7.Name = "TreeListColumn7"
        Me.TreeListColumn7.OptionsColumn.AllowEdit = False
        Me.TreeListColumn7.OptionsColumn.ReadOnly = True
        Me.TreeListColumn7.VisibleIndex = 11
        '
        'TreeListColumn8
        '
        Me.TreeListColumn8.Caption = "失效日期"
        Me.TreeListColumn8.FieldName = "InvalidDate"
        Me.TreeListColumn8.Format.FormatString = "yyyy/MM/dd"
        Me.TreeListColumn8.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TreeListColumn8.Name = "TreeListColumn8"
        Me.TreeListColumn8.OptionsColumn.AllowEdit = False
        Me.TreeListColumn8.OptionsColumn.ReadOnly = True
        Me.TreeListColumn8.VisibleIndex = 12
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建用戶"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.OptionsColumn.AllowEdit = False
        Me.CreateUserName.OptionsColumn.ReadOnly = True
        Me.CreateUserName.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.CreateUserName.VisibleIndex = 13
        '
        'TreeListColumn9
        '
        Me.TreeListColumn9.Caption = "創建日期"
        Me.TreeListColumn9.FieldName = "CreateDate"
        Me.TreeListColumn9.Format.FormatString = "yyyy/MM/dd"
        Me.TreeListColumn9.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TreeListColumn9.Name = "TreeListColumn9"
        Me.TreeListColumn9.OptionsColumn.AllowEdit = False
        Me.TreeListColumn9.OptionsColumn.ReadOnly = True
        Me.TreeListColumn9.VisibleIndex = 14
        '
        'TreeListColumn10
        '
        Me.TreeListColumn10.Caption = "展開"
        Me.TreeListColumn10.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.TreeListColumn10.FieldName = "isUnfold"
        Me.TreeListColumn10.Name = "TreeListColumn10"
        Me.TreeListColumn10.OptionsColumn.AllowEdit = False
        Me.TreeListColumn10.OptionsColumn.ReadOnly = True
        Me.TreeListColumn10.VisibleIndex = 15
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive
        '
        'TreeListColumn11
        '
        Me.TreeListColumn11.Caption = "審核"
        Me.TreeListColumn11.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.TreeListColumn11.FieldName = "checkBit"
        Me.TreeListColumn11.Name = "TreeListColumn11"
        Me.TreeListColumn11.OptionsColumn.AllowEdit = False
        Me.TreeListColumn11.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'xtpA
        '
        Me.xtpA.Controls.Add(Me.GridBom_Detail)
        Me.xtpA.Controls.Add(Me.lblCheckUserID)
        Me.xtpA.Controls.Add(Me.Label9)
        Me.xtpA.Controls.Add(Me.txtrecheckaction)
        Me.xtpA.Controls.Add(Me.txtrecheckdate)
        Me.xtpA.Controls.Add(Me.Label17)
        Me.xtpA.Controls.Add(Me.Label18)
        Me.xtpA.Controls.Add(Me.Label19)
        Me.xtpA.Controls.Add(Me.Label21)
        Me.xtpA.Name = "xtpA"
        Me.xtpA.Size = New System.Drawing.Size(844, 188)
        Me.xtpA.Text = "物料明細"
        '
        'GridBom_Detail
        '
        Me.GridBom_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBom_Detail.EmbeddedNavigator.Name = ""
        Me.GridBom_Detail.Location = New System.Drawing.Point(0, 0)
        Me.GridBom_Detail.MainView = Me.GridView2
        Me.GridBom_Detail.Name = "GridBom_Detail"
        Me.GridBom_Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit5})
        Me.GridBom_Detail.Size = New System.Drawing.Size(844, 188)
        Me.GridBom_Detail.TabIndex = 7
        Me.GridBom_Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Item, Me.ChildGroup, Me.ChildName, Me.ChildGauge, Me.IsUnfold, Me.ReplaceType1, Me.UseFeatures, Me.Mount, Me.Tmrtc, Me.SendUnit, Me.LossRate, Me.EffectiveDate1, Me.InvalidDate1, Me.CreateUserID1, Me.CreateDate1, Me.ModifyUserID1, Me.ModifyDate1})
        Me.GridView2.GridControl = Me.GridBom_Detail
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Item
        '
        Me.Item.Caption = "序號"
        Me.Item.FieldName = "Item"
        Me.Item.Name = "Item"
        Me.Item.OptionsColumn.ReadOnly = True
        Me.Item.Visible = True
        Me.Item.VisibleIndex = 0
        Me.Item.Width = 45
        '
        'ChildGroup
        '
        Me.ChildGroup.Caption = "元件料件"
        Me.ChildGroup.FieldName = "ChildGroup"
        Me.ChildGroup.Name = "ChildGroup"
        Me.ChildGroup.OptionsColumn.ReadOnly = True
        Me.ChildGroup.Visible = True
        Me.ChildGroup.VisibleIndex = 1
        Me.ChildGroup.Width = 129
        '
        'ChildName
        '
        Me.ChildName.Caption = "名稱"
        Me.ChildName.ColumnEdit = Me.RepositoryItemMemoExEdit5
        Me.ChildName.FieldName = "ChildName"
        Me.ChildName.Name = "ChildName"
        Me.ChildName.Visible = True
        Me.ChildName.VisibleIndex = 2
        Me.ChildName.Width = 118
        '
        'RepositoryItemMemoExEdit5
        '
        Me.RepositoryItemMemoExEdit5.AutoHeight = False
        Me.RepositoryItemMemoExEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit5.Name = "RepositoryItemMemoExEdit5"
        Me.RepositoryItemMemoExEdit5.ShowIcon = False
        '
        'ChildGauge
        '
        Me.ChildGauge.Caption = "規格"
        Me.ChildGauge.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.ChildGauge.FieldName = "ChildGauge"
        Me.ChildGauge.Name = "ChildGauge"
        Me.ChildGauge.Visible = True
        Me.ChildGauge.VisibleIndex = 3
        Me.ChildGauge.Width = 119
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'IsUnfold
        '
        Me.IsUnfold.Caption = "展開"
        Me.IsUnfold.FieldName = "IsUnfold"
        Me.IsUnfold.Name = "IsUnfold"
        Me.IsUnfold.OptionsColumn.ReadOnly = True
        Me.IsUnfold.Visible = True
        Me.IsUnfold.VisibleIndex = 4
        Me.IsUnfold.Width = 45
        '
        'ReplaceType1
        '
        Me.ReplaceType1.Caption = "替代類型"
        Me.ReplaceType1.FieldName = "ReplaceType1"
        Me.ReplaceType1.Name = "ReplaceType1"
        Me.ReplaceType1.OptionsColumn.ReadOnly = True
        Me.ReplaceType1.Visible = True
        Me.ReplaceType1.VisibleIndex = 5
        Me.ReplaceType1.Width = 80
        '
        'UseFeatures
        '
        Me.UseFeatures.Caption = "使用特性"
        Me.UseFeatures.FieldName = "UseFeatures"
        Me.UseFeatures.Name = "UseFeatures"
        Me.UseFeatures.OptionsColumn.ReadOnly = True
        Me.UseFeatures.Visible = True
        Me.UseFeatures.VisibleIndex = 6
        Me.UseFeatures.Width = 70
        '
        'Mount
        '
        Me.Mount.Caption = "組成用量"
        Me.Mount.DisplayFormat.FormatString = "#,###0.######"
        Me.Mount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Mount.FieldName = "Mount"
        Me.Mount.Name = "Mount"
        Me.Mount.OptionsColumn.ReadOnly = True
        Me.Mount.Visible = True
        Me.Mount.VisibleIndex = 7
        Me.Mount.Width = 70
        '
        'Tmrtc
        '
        Me.Tmrtc.Caption = "主件底數"
        Me.Tmrtc.DisplayFormat.FormatString = "#,###0.######"
        Me.Tmrtc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tmrtc.FieldName = "Tmrtc"
        Me.Tmrtc.Name = "Tmrtc"
        Me.Tmrtc.OptionsColumn.ReadOnly = True
        Me.Tmrtc.Visible = True
        Me.Tmrtc.VisibleIndex = 8
        Me.Tmrtc.Width = 70
        '
        'SendUnit
        '
        Me.SendUnit.Caption = "發料單位"
        Me.SendUnit.FieldName = "SendUnit"
        Me.SendUnit.Name = "SendUnit"
        Me.SendUnit.OptionsColumn.ReadOnly = True
        Me.SendUnit.Visible = True
        Me.SendUnit.VisibleIndex = 9
        Me.SendUnit.Width = 70
        '
        'LossRate
        '
        Me.LossRate.Caption = "損率"
        Me.LossRate.DisplayFormat.FormatString = "#,###0.######"
        Me.LossRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LossRate.FieldName = "LossRate"
        Me.LossRate.Name = "LossRate"
        Me.LossRate.OptionsColumn.ReadOnly = True
        Me.LossRate.Visible = True
        Me.LossRate.VisibleIndex = 10
        Me.LossRate.Width = 60
        '
        'EffectiveDate1
        '
        Me.EffectiveDate1.Caption = "生效日期"
        Me.EffectiveDate1.DisplayFormat.FormatString = "d"
        Me.EffectiveDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EffectiveDate1.FieldName = "EffectiveDate"
        Me.EffectiveDate1.Name = "EffectiveDate1"
        Me.EffectiveDate1.OptionsColumn.ReadOnly = True
        Me.EffectiveDate1.Visible = True
        Me.EffectiveDate1.VisibleIndex = 11
        '
        'InvalidDate1
        '
        Me.InvalidDate1.Caption = "失效日期"
        Me.InvalidDate1.DisplayFormat.FormatString = "d"
        Me.InvalidDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvalidDate1.FieldName = "InvalidDate"
        Me.InvalidDate1.Name = "InvalidDate1"
        Me.InvalidDate1.OptionsColumn.ReadOnly = True
        Me.InvalidDate1.Visible = True
        Me.InvalidDate1.VisibleIndex = 12
        '
        'CreateUserID1
        '
        Me.CreateUserID1.Caption = "創建人員"
        Me.CreateUserID1.FieldName = "CreateUserID"
        Me.CreateUserID1.Name = "CreateUserID1"
        Me.CreateUserID1.OptionsColumn.ReadOnly = True
        Me.CreateUserID1.Width = 70
        '
        'CreateDate1
        '
        Me.CreateDate1.Caption = "創建日期"
        Me.CreateDate1.DisplayFormat.FormatString = "d"
        Me.CreateDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CreateDate1.FieldName = "CreateDate"
        Me.CreateDate1.Name = "CreateDate1"
        Me.CreateDate1.OptionsColumn.ReadOnly = True
        '
        'ModifyUserID1
        '
        Me.ModifyUserID1.Caption = "修改人員"
        Me.ModifyUserID1.FieldName = "ModifyUserID"
        Me.ModifyUserID1.Name = "ModifyUserID1"
        Me.ModifyUserID1.OptionsColumn.ReadOnly = True
        Me.ModifyUserID1.Width = 70
        '
        'ModifyDate1
        '
        Me.ModifyDate1.Caption = "修改日期"
        Me.ModifyDate1.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.ModifyDate1.DisplayFormat.FormatString = "d"
        Me.ModifyDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ModifyDate1.FieldName = "ModifyDate"
        Me.ModifyDate1.Name = "ModifyDate1"
        Me.ModifyDate1.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'lblCheckUserID
        '
        Me.lblCheckUserID.AutoSize = True
        Me.lblCheckUserID.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUserID.Location = New System.Drawing.Point(602, 18)
        Me.lblCheckUserID.Name = "lblCheckUserID"
        Me.lblCheckUserID.Size = New System.Drawing.Size(52, 15)
        Me.lblCheckUserID.TabIndex = 5
        Me.lblCheckUserID.Text = "審核人"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(529, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "審核人："
        '
        'txtrecheckaction
        '
        Me.txtrecheckaction.AutoSize = True
        Me.txtrecheckaction.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckaction.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckaction.Location = New System.Drawing.Point(274, 18)
        Me.txtrecheckaction.Name = "txtrecheckaction"
        Me.txtrecheckaction.Size = New System.Drawing.Size(0, 15)
        Me.txtrecheckaction.TabIndex = 3
        '
        'txtrecheckdate
        '
        Me.txtrecheckdate.AutoSize = True
        Me.txtrecheckdate.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckdate.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckdate.Location = New System.Drawing.Point(468, 18)
        Me.txtrecheckdate.Name = "txtrecheckdate"
        Me.txtrecheckdate.Size = New System.Drawing.Size(0, 15)
        Me.txtrecheckdate.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(394, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 15)
        Me.Label17.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(217, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 15)
        Me.Label18.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 15)
        Me.Label19.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(15, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 15)
        Me.Label21.TabIndex = 0
        '
        'xtpC
        '
        Me.xtpC.Controls.Add(Me.Grid3)
        Me.xtpC.Name = "xtpC"
        Me.xtpC.Size = New System.Drawing.Size(844, 188)
        Me.xtpC.Text = "需求物料"
        '
        'Grid3
        '
        Me.Grid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid3.EmbeddedNavigator.Name = ""
        Me.Grid3.Location = New System.Drawing.Point(0, 0)
        Me.Grid3.MainView = Me.GridView3
        Me.Grid3.Name = "Grid3"
        Me.Grid3.Size = New System.Drawing.Size(844, 188)
        Me.Grid3.TabIndex = 0
        Me.Grid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn14, Me.GridColumn13})
        Me.GridView3.GridControl = Me.Grid3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "物料編碼"
        Me.GridColumn1.FieldName = "ChildGroup"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 139
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料名稱"
        Me.GridColumn2.FieldName = "M_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 103
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料規格"
        Me.GridColumn3.FieldName = "M_Gauge"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 115
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "來源碼"
        Me.GridColumn4.FieldName = "M_Source"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "單位"
        Me.GridColumn5.FieldName = "M_Unit"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 47
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "組成用量"
        Me.GridColumn6.DisplayFormat.FormatString = "#,###0.######"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Mount"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 71
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "主件底數"
        Me.GridColumn7.DisplayFormat.FormatString = "#,###0.######"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Tmrtc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 73
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "單位用量"
        Me.GridColumn8.DisplayFormat.FormatString = "#,###0.######"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "QtyPer"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "總用量"
        Me.GridColumn9.DisplayFormat.FormatString = "#,###0.######"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "SumQty"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 62
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "生效日期"
        Me.GridColumn10.FieldName = "EffectiveDate"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "失效日期"
        Me.GridColumn11.FieldName = "InvalidDate"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "創建日期"
        Me.GridColumn14.FieldName = "CreateDate"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 11
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "創建人員"
        Me.GridColumn13.FieldName = "CreateUserName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblinfo.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblinfo.Location = New System.Drawing.Point(3, 6)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(131, 21)
        Me.lblinfo.TabIndex = 237
        Me.lblinfo.Text = "BOM產品結構"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(857, 32)
        Me.PictureBox2.TabIndex = 238
        Me.PictureBox2.TabStop = False
        '
        'frmBomMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 619)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmBomMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOM產品結構"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridBom_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTable.ResumeLayout(False)
        Me.xtpB.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpA.ResumeLayout(False)
        Me.xtpA.PerformLayout()
        CType(Me.GridBom_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpC.ResumeLayout(False)
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridBom_Main As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ParentGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Version As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductionUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EffectiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvalidDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xtcTable As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpA As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridBom_Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChildGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChildName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ChildGauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents IsUnfold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReplaceType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UseFeatures As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Mount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tmrtc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LossRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EffectiveDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvalidDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lblCheckUserID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtrecheckaction As System.Windows.Forms.Label
    Friend WithEvents txtrecheckdate As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents xtpB As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents QtyPer As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ActualQty As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents M_Unit As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents sonsNum As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn8 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents CreateUserName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn9 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn10 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TreeListColumn11 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents xtpC As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeListColumn12 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents LossQty As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
