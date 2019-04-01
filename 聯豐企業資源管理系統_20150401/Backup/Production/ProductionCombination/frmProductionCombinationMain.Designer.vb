<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionCombinationMain
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStripAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStripCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripRef = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStripPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PR_Ratio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_No1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PR_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PR_CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PR_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_AllDepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_OutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_InQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "組合工序管理"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripAdd, Me.MenuStripEdit, Me.MenuStripDel, Me.ToolStripSeparator1, Me.MenuStripCheck, Me.MenuStripPreView, Me.MenuStripRef, Me.MenuStripQuery, Me.ToolStripSeparator2, Me.MenuStripPrint})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(189, 192)
        '
        'MenuStripAdd
        '
        Me.MenuStripAdd.Enabled = False
        Me.MenuStripAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.MenuStripAdd.Name = "MenuStripAdd"
        Me.MenuStripAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuStripAdd.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripAdd.Text = "新增(&A)..."
        '
        'MenuStripEdit
        '
        Me.MenuStripEdit.Enabled = False
        Me.MenuStripEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.MenuStripEdit.Name = "MenuStripEdit"
        Me.MenuStripEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenuStripEdit.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripEdit.Text = "修改(&E)..."
        '
        'MenuStripDel
        '
        Me.MenuStripDel.Enabled = False
        Me.MenuStripDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.MenuStripDel.Name = "MenuStripDel"
        Me.MenuStripDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuStripDel.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripDel.Text = "刪除(&E)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'MenuStripCheck
        '
        Me.MenuStripCheck.Enabled = False
        Me.MenuStripCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.MenuStripCheck.Name = "MenuStripCheck"
        Me.MenuStripCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.MenuStripCheck.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripCheck.Text = "審核(&G)"
        '
        'MenuStripPreView
        '
        Me.MenuStripPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.MenuStripPreView.Name = "MenuStripPreView"
        Me.MenuStripPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuStripPreView.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripPreView.Text = "查看(&W)..."
        '
        'MenuStripRef
        '
        Me.MenuStripRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.MenuStripRef.Name = "MenuStripRef"
        Me.MenuStripRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuStripRef.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripRef.Text = "刷新(&R)"
        '
        'MenuStripQuery
        '
        Me.MenuStripQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.MenuStripQuery.Name = "MenuStripQuery"
        Me.MenuStripQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MenuStripQuery.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripQuery.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'MenuStripPrint
        '
        Me.MenuStripPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.MenuStripPrint.Name = "MenuStripPrint"
        Me.MenuStripPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripPrint.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripPrint.Text = "列印(&P)..."
        Me.MenuStripPrint.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(695, 29)
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.ContextMenuStrip = Me.MenuStrip
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 36)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(699, 437)
        Me.XtraTabControl1.TabIndex = 169
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(690, 405)
        Me.XtraTabPage1.Text = "工序比例"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.MenuStrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(690, 405)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Pro_Type, Me.PM_M_Code, Me.PM_Type, Me.Pro_No, Me.PS_Name, Me.PR_Ratio, Me.Pro_No1, Me.PS_Name1, Me.PM_Type1, Me.PM_M_Code1, Me.Pro_Type1, Me.PR_Check, Me.PR_CheckUserName, Me.PR_AddDate})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.OptionsColumn.ReadOnly = True
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        Me.PM_M_Code.Width = 100
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.ReadOnly = True
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 2
        '
        'Pro_No
        '
        Me.Pro_No.Caption = "大工序編號"
        Me.Pro_No.FieldName = "Pro_No"
        Me.Pro_No.Name = "Pro_No"
        Me.Pro_No.OptionsColumn.ReadOnly = True
        Me.Pro_No.Width = 85
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "大工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 3
        Me.PS_Name.Width = 85
        '
        'PR_Ratio
        '
        Me.PR_Ratio.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.PR_Ratio.AppearanceCell.Options.UseBackColor = True
        Me.PR_Ratio.Caption = "工序比例"
        Me.PR_Ratio.FieldName = "PR_Ratio"
        Me.PR_Ratio.Name = "PR_Ratio"
        Me.PR_Ratio.OptionsColumn.ReadOnly = True
        Me.PR_Ratio.Visible = True
        Me.PR_Ratio.VisibleIndex = 4
        '
        'Pro_No1
        '
        Me.Pro_No1.Caption = "小工序編號"
        Me.Pro_No1.FieldName = "Pro_No1"
        Me.Pro_No1.Name = "Pro_No1"
        Me.Pro_No1.OptionsColumn.ReadOnly = True
        Me.Pro_No1.Width = 85
        '
        'PS_Name1
        '
        Me.PS_Name1.Caption = "小工序名稱"
        Me.PS_Name1.FieldName = "PS_Name1"
        Me.PS_Name1.Name = "PS_Name1"
        Me.PS_Name1.OptionsColumn.ReadOnly = True
        Me.PS_Name1.Visible = True
        Me.PS_Name1.VisibleIndex = 5
        Me.PS_Name1.Width = 85
        '
        'PM_Type1
        '
        Me.PM_Type1.Caption = "配件名稱"
        Me.PM_Type1.FieldName = "PM_Type1"
        Me.PM_Type1.Name = "PM_Type1"
        Me.PM_Type1.OptionsColumn.ReadOnly = True
        Me.PM_Type1.Visible = True
        Me.PM_Type1.VisibleIndex = 6
        '
        'PM_M_Code1
        '
        Me.PM_M_Code1.Caption = "產品編號"
        Me.PM_M_Code1.FieldName = "PM_M_Code1"
        Me.PM_M_Code1.Name = "PM_M_Code1"
        Me.PM_M_Code1.OptionsColumn.ReadOnly = True
        Me.PM_M_Code1.Visible = True
        Me.PM_M_Code1.VisibleIndex = 7
        Me.PM_M_Code1.Width = 100
        '
        'Pro_Type1
        '
        Me.Pro_Type1.Caption = "工藝類型"
        Me.Pro_Type1.FieldName = "Pro_Type1"
        Me.Pro_Type1.Name = "Pro_Type1"
        Me.Pro_Type1.OptionsColumn.ReadOnly = True
        Me.Pro_Type1.Visible = True
        Me.Pro_Type1.VisibleIndex = 8
        '
        'PR_Check
        '
        Me.PR_Check.Caption = "審核"
        Me.PR_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.PR_Check.FieldName = "PR_Check"
        Me.PR_Check.Name = "PR_Check"
        Me.PR_Check.OptionsColumn.ReadOnly = True
        Me.PR_Check.Visible = True
        Me.PR_Check.VisibleIndex = 9
        Me.PR_Check.Width = 55
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'PR_CheckUserName
        '
        Me.PR_CheckUserName.Caption = "審核人"
        Me.PR_CheckUserName.FieldName = "PR_CheckUserName"
        Me.PR_CheckUserName.Name = "PR_CheckUserName"
        Me.PR_CheckUserName.OptionsColumn.ReadOnly = True
        Me.PR_CheckUserName.Visible = True
        Me.PR_CheckUserName.VisibleIndex = 10
        Me.PR_CheckUserName.Width = 65
        '
        'PR_AddDate
        '
        Me.PR_AddDate.Caption = "操作日期"
        Me.PR_AddDate.DisplayFormat.FormatString = "d"
        Me.PR_AddDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PR_AddDate.FieldName = "PR_AddDate"
        Me.PR_AddDate.Name = "PR_AddDate"
        Me.PR_AddDate.OptionsColumn.ReadOnly = True
        Me.PR_AddDate.Visible = True
        Me.PR_AddDate.VisibleIndex = 11
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Grid)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(690, 405)
        Me.XtraTabPage2.Text = "組合信息"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(690, 405)
        Me.Grid.TabIndex = 169
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsView, Me.cmsFind})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 48)
        '
        'cmsView
        '
        Me.cmsView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsView.Name = "cmsView"
        Me.cmsView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsView.Size = New System.Drawing.Size(188, 22)
        Me.cmsView.Text = "查看(&W)..."
        '
        'cmsFind
        '
        Me.cmsFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsFind.Size = New System.Drawing.Size(188, 22)
        Me.cmsFind.Text = "查詢(&F)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_ID, Me.M_Type, Me.M_AllDepName, Me.PM_M_Code3, Me.PM_Type3, Me.PS_Name3, Me.M_OutQty, Me.PM_M_Code2, Me.PM_Type2, Me.PS_Name2, Me.M_InQty, Me.M_Date})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_ID
        '
        Me.M_ID.Caption = "單號"
        Me.M_ID.FieldName = "M_ID"
        Me.M_ID.Name = "M_ID"
        Me.M_ID.OptionsColumn.ReadOnly = True
        Me.M_ID.Visible = True
        Me.M_ID.VisibleIndex = 0
        '
        'M_Type
        '
        Me.M_Type.Caption = "類型"
        Me.M_Type.FieldName = "M_Type"
        Me.M_Type.Name = "M_Type"
        Me.M_Type.OptionsColumn.ReadOnly = True
        Me.M_Type.Visible = True
        Me.M_Type.VisibleIndex = 1
        '
        'M_AllDepName
        '
        Me.M_AllDepName.Caption = "操作部門"
        Me.M_AllDepName.FieldName = "M_AllDepName"
        Me.M_AllDepName.Name = "M_AllDepName"
        Me.M_AllDepName.OptionsColumn.ReadOnly = True
        Me.M_AllDepName.Visible = True
        Me.M_AllDepName.VisibleIndex = 2
        '
        'PM_M_Code3
        '
        Me.PM_M_Code3.Caption = "發料產品"
        Me.PM_M_Code3.FieldName = "PM_M_Code1"
        Me.PM_M_Code3.Name = "PM_M_Code3"
        Me.PM_M_Code3.OptionsColumn.ReadOnly = True
        Me.PM_M_Code3.Visible = True
        Me.PM_M_Code3.VisibleIndex = 3
        Me.PM_M_Code3.Width = 100
        '
        'PM_Type3
        '
        Me.PM_Type3.Caption = "發料配件"
        Me.PM_Type3.FieldName = "PM_Type1"
        Me.PM_Type3.Name = "PM_Type3"
        Me.PM_Type3.OptionsColumn.ReadOnly = True
        Me.PM_Type3.Visible = True
        Me.PM_Type3.VisibleIndex = 4
        '
        'PS_Name3
        '
        Me.PS_Name3.Caption = "發料工序"
        Me.PS_Name3.FieldName = "PS_Name1"
        Me.PS_Name3.Name = "PS_Name3"
        Me.PS_Name3.OptionsColumn.ReadOnly = True
        Me.PS_Name3.Visible = True
        Me.PS_Name3.VisibleIndex = 5
        '
        'M_OutQty
        '
        Me.M_OutQty.Caption = "發料數量"
        Me.M_OutQty.FieldName = "M_OutQty"
        Me.M_OutQty.Name = "M_OutQty"
        Me.M_OutQty.OptionsColumn.ReadOnly = True
        Me.M_OutQty.Visible = True
        Me.M_OutQty.VisibleIndex = 6
        '
        'PM_M_Code2
        '
        Me.PM_M_Code2.Caption = "收料產品"
        Me.PM_M_Code2.FieldName = "PM_M_Code"
        Me.PM_M_Code2.Name = "PM_M_Code2"
        Me.PM_M_Code2.OptionsColumn.ReadOnly = True
        Me.PM_M_Code2.Visible = True
        Me.PM_M_Code2.VisibleIndex = 7
        Me.PM_M_Code2.Width = 100
        '
        'PM_Type2
        '
        Me.PM_Type2.Caption = "收料配件"
        Me.PM_Type2.FieldName = "PM_Type"
        Me.PM_Type2.Name = "PM_Type2"
        Me.PM_Type2.OptionsColumn.ReadOnly = True
        Me.PM_Type2.Visible = True
        Me.PM_Type2.VisibleIndex = 8
        '
        'PS_Name2
        '
        Me.PS_Name2.Caption = "收料工序"
        Me.PS_Name2.FieldName = "PS_Name"
        Me.PS_Name2.Name = "PS_Name2"
        Me.PS_Name2.OptionsColumn.ReadOnly = True
        Me.PS_Name2.Visible = True
        Me.PS_Name2.VisibleIndex = 9
        '
        'M_InQty
        '
        Me.M_InQty.Caption = "收料數量"
        Me.M_InQty.FieldName = "M_InQty"
        Me.M_InQty.Name = "M_InQty"
        Me.M_InQty.OptionsColumn.ReadOnly = True
        Me.M_InQty.Visible = True
        Me.M_InQty.VisibleIndex = 10
        '
        'M_Date
        '
        Me.M_Date.Caption = "操作日期"
        Me.M_Date.FieldName = "M_Date"
        Me.M_Date.Name = "M_Date"
        Me.M_Date.OptionsColumn.ReadOnly = True
        Me.M_Date.Visible = True
        Me.M_Date.VisibleIndex = 11
        '
        'frmProductionCombinationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 473)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionCombinationMain"
        Me.Text = "組合工序管理"
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStripAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PR_Ratio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PR_CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PR_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PR_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Pro_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_No1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_AllDepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_OutQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_InQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStripCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
End Class
