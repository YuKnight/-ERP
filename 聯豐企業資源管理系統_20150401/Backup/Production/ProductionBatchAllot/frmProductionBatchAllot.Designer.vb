<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionBatchAllot
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gluOS_BatchID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtePBA_AddDate = New DevExpress.XtraEditors.DateEdit
        Me.txtPBA_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSelectAll = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rbteM_Code = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rgluFacName = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PBA_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PBA_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PBA_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rgluM_Code = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedQty1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gluOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePBA_AddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPBA_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbteM_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgluFacName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgluM_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Appearance.Options.UseForeColor = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 11)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(173, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "生產派工單-新增"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(850, 37)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.gluOS_BatchID)
        Me.GroupBox1.Controls.Add(Me.dtePBA_AddDate)
        Me.GroupBox1.Controls.Add(Me.txtPBA_ID)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gluOS_BatchID
        '
        Me.gluOS_BatchID.EditValue = ""
        Me.gluOS_BatchID.Location = New System.Drawing.Point(377, 24)
        Me.gluOS_BatchID.Name = "gluOS_BatchID"
        Me.gluOS_BatchID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluOS_BatchID.Properties.Appearance.Options.UseFont = True
        Me.gluOS_BatchID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluOS_BatchID.Properties.NullText = ""
        Me.gluOS_BatchID.Properties.PopupFormWidth = 145
        Me.gluOS_BatchID.Properties.View = Me.GridLookUpEdit1View
        Me.gluOS_BatchID.Size = New System.Drawing.Size(150, 24)
        Me.gluOS_BatchID.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OS_BatchID})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowColumnMoving = False
        Me.GridLookUpEdit1View.OptionsNavigation.AutoFocusNewRow = True
        Me.GridLookUpEdit1View.OptionsNavigation.UseTabKey = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.OptionsColumn.ReadOnly = True
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 0
        '
        'dtePBA_AddDate
        '
        Me.dtePBA_AddDate.EditValue = Nothing
        Me.dtePBA_AddDate.Location = New System.Drawing.Point(646, 24)
        Me.dtePBA_AddDate.Name = "dtePBA_AddDate"
        Me.dtePBA_AddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePBA_AddDate.Properties.Appearance.Options.UseFont = True
        Me.dtePBA_AddDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePBA_AddDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dtePBA_AddDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePBA_AddDate.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.dtePBA_AddDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePBA_AddDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dtePBA_AddDate.Size = New System.Drawing.Size(150, 24)
        Me.dtePBA_AddDate.TabIndex = 5
        '
        'txtPBA_ID
        '
        Me.txtPBA_ID.Enabled = False
        Me.txtPBA_ID.Location = New System.Drawing.Point(108, 24)
        Me.txtPBA_ID.Name = "txtPBA_ID"
        Me.txtPBA_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPBA_ID.Properties.Appearance.Options.UseFont = True
        Me.txtPBA_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtPBA_ID.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(545, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "新增日期(&D)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(277, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "批次編號(&B)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 15)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "派工單號(&I)："
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnSelectAll)
        Me.PanelControl2.Controls.Add(Me.btnOK)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 428)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(850, 56)
        Me.PanelControl2.TabIndex = 2
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(727, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.Appearance.Options.UseFont = True
        Me.btnSelectAll.Location = New System.Drawing.Point(514, 16)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(80, 28)
        Me.btnSelectAll.TabIndex = 0
        Me.btnSelectAll.Text = "全選(&A)"
        Me.btnSelectAll.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnOK.Location = New System.Drawing.Point(620, 16)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "確定(&O)"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cms
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 104)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rgluFacName, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemCheckEdit1, Me.rgluM_Code, Me.rbteM_Code})
        Me.GridControl1.Size = New System.Drawing.Size(850, 324)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsDelete})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(169, 48)
        '
        'cmsAdd
        '
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(168, 22)
        Me.cmsAdd.Text = "新增(&A)"
        '
        'cmsDelete
        '
        Me.cmsDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDelete.Size = New System.Drawing.Size(168, 22)
        Me.cmsDelete.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.ON_NeedQty, Me.FacName, Me.PBA_Qty, Me.PBA_Remark, Me.PBA_Check})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.ColumnEdit = Me.rbteM_Code
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 150
        '
        'rbteM_Code
        '
        Me.rbteM_Code.AutoHeight = False
        Me.rbteM_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.rbteM_Code.Name = "rbteM_Code"
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 100
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 130
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 55
        '
        'ON_NeedQty
        '
        Me.ON_NeedQty.Caption = "需求量"
        Me.ON_NeedQty.FieldName = "ON_NeedQty"
        Me.ON_NeedQty.Name = "ON_NeedQty"
        Me.ON_NeedQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedQty.Visible = True
        Me.ON_NeedQty.VisibleIndex = 4
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.ColumnEdit = Me.rgluFacName
        Me.FacName.FieldName = "FacID"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 5
        Me.FacName.Width = 100
        '
        'rgluFacName
        '
        Me.rgluFacName.AutoHeight = False
        Me.rgluFacName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rgluFacName.Name = "rgluFacName"
        Me.rgluFacName.NullText = ""
        Me.rgluFacName.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FacID, Me.FacName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsCustomization.AllowColumnMoving = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsNavigation.UseTabKey = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'FacID
        '
        Me.FacID.Caption = "廠別編號"
        Me.FacID.FieldName = "FacID"
        Me.FacID.Name = "FacID"
        Me.FacID.OptionsColumn.ReadOnly = True
        Me.FacID.Visible = True
        Me.FacID.VisibleIndex = 0
        Me.FacID.Width = 120
        '
        'FacName1
        '
        Me.FacName1.Caption = "廠別名稱"
        Me.FacName1.FieldName = "FacName"
        Me.FacName1.Name = "FacName1"
        Me.FacName1.OptionsColumn.ReadOnly = True
        Me.FacName1.Visible = True
        Me.FacName1.VisibleIndex = 1
        Me.FacName1.Width = 261
        '
        'PBA_Qty
        '
        Me.PBA_Qty.Caption = "分派數量"
        Me.PBA_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PBA_Qty.FieldName = "PBA_Qty"
        Me.PBA_Qty.Name = "PBA_Qty"
        Me.PBA_Qty.Visible = True
        Me.PBA_Qty.VisibleIndex = 6
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'PBA_Remark
        '
        Me.PBA_Remark.Caption = "備注"
        Me.PBA_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.PBA_Remark.FieldName = "PBA_Remark"
        Me.PBA_Remark.Name = "PBA_Remark"
        Me.PBA_Remark.Visible = True
        Me.PBA_Remark.VisibleIndex = 7
        Me.PBA_Remark.Width = 140
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'PBA_Check
        '
        Me.PBA_Check.Caption = "審核"
        Me.PBA_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.PBA_Check.FieldName = "PBA_Check"
        Me.PBA_Check.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.PBA_Check.Name = "PBA_Check"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'rgluM_Code
        '
        Me.rgluM_Code.AutoHeight = False
        Me.rgluM_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rgluM_Code.Name = "rgluM_Code"
        Me.rgluM_Code.NullText = ""
        Me.rgluM_Code.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code1, Me.M_Name1, Me.M_Gauge1, Me.M_Unit1, Me.ON_NeedQty1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'M_Code1
        '
        Me.M_Code1.Caption = "物料編碼"
        Me.M_Code1.FieldName = "M_Code"
        Me.M_Code1.Name = "M_Code1"
        Me.M_Code1.Visible = True
        Me.M_Code1.VisibleIndex = 0
        Me.M_Code1.Width = 220
        '
        'M_Name1
        '
        Me.M_Name1.Caption = "物料名稱"
        Me.M_Name1.FieldName = "M_Name"
        Me.M_Name1.Name = "M_Name1"
        Me.M_Name1.Visible = True
        Me.M_Name1.VisibleIndex = 1
        Me.M_Name1.Width = 161
        '
        'M_Gauge1
        '
        Me.M_Gauge1.Caption = "物料規格"
        Me.M_Gauge1.FieldName = "M_Gauge"
        Me.M_Gauge1.Name = "M_Gauge1"
        '
        'M_Unit1
        '
        Me.M_Unit1.Caption = "單位"
        Me.M_Unit1.FieldName = "M_Unit"
        Me.M_Unit1.Name = "M_Unit1"
        '
        'ON_NeedQty1
        '
        Me.ON_NeedQty1.Caption = "需求量"
        Me.ON_NeedQty1.FieldName = "ON_NeedQty"
        Me.ON_NeedQty1.Name = "ON_NeedQty1"
        '
        'frmProductionBatchAllot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(850, 484)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmProductionBatchAllot"
        Me.Text = "生產派工單-新增"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gluOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePBA_AddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPBA_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbteM_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgluFacName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgluM_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtePBA_AddDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPBA_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gluOS_BatchID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rgluFacName As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PBA_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBA_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PBA_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rgluM_Code As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedQty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbteM_Code As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnSelectAll As DevExpress.XtraEditors.SimpleButton
End Class
