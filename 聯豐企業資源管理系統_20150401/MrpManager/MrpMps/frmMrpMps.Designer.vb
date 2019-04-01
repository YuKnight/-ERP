<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpMps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpMps))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtProductionQty = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtM_Unit = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCusterName = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.gluCusterID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.viewCuster = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtM_Gauge = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Source = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.viewMaterial = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ParentGroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.xtpGridView = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMps = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsMpsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMpsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMpsBatchAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.View1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PlanQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.ProducedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemdteNeedDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.WeeksNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TimeSpan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.E_AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpCheck = New DevExpress.XtraTab.XtraTabPage
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkCheck = New DevExpress.XtraEditors.CheckEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.lblCheckUser = New System.Windows.Forms.Label
        Me.txtrecheckaction = New System.Windows.Forms.Label
        Me.txtrecheckdate = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.txtMO = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtProductionQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluCusterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewCuster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpGridView.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMps.SuspendLayout()
        CType(Me.View1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemdteNeedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCheck.SuspendLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(1, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 21)
        Me.lblTitle.TabIndex = 196
        Me.lblTitle.Text = "主生產計劃"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 32)
        Me.PictureBox1.TabIndex = 197
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 115)
        Me.Panel1.TabIndex = 198
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProductionQty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtM_Unit)
        Me.GroupBox1.Controls.Add(Me.txtM_Name)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCusterName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.gluCusterID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtM_Gauge)
        Me.GroupBox1.Controls.Add(Me.txtM_Source)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.gluM_Code)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtProductionQty
        '
        Me.txtProductionQty.Enabled = False
        Me.txtProductionQty.Location = New System.Drawing.Point(727, 76)
        Me.txtProductionQty.Name = "txtProductionQty"
        Me.txtProductionQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtProductionQty.Properties.Appearance.Options.UseFont = True
        Me.txtProductionQty.Size = New System.Drawing.Size(58, 24)
        Me.txtProductionQty.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(632, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "生產數量(&U)："
        '
        'txtM_Unit
        '
        Me.txtM_Unit.Enabled = False
        Me.txtM_Unit.Location = New System.Drawing.Point(572, 76)
        Me.txtM_Unit.Name = "txtM_Unit"
        Me.txtM_Unit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Unit.Properties.Appearance.Options.UseFont = True
        Me.txtM_Unit.Size = New System.Drawing.Size(54, 24)
        Me.txtM_Unit.TabIndex = 13
        '
        'txtM_Name
        '
        Me.txtM_Name.Enabled = False
        Me.txtM_Name.Location = New System.Drawing.Point(355, 76)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Size = New System.Drawing.Size(142, 24)
        Me.txtM_Name.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(504, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "單位(&U)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(256, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "產品名稱(&G)："
        '
        'txtCusterName
        '
        Me.txtCusterName.Enabled = False
        Me.txtCusterName.Location = New System.Drawing.Point(355, 16)
        Me.txtCusterName.Name = "txtCusterName"
        Me.txtCusterName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCusterName.Properties.Appearance.Options.UseFont = True
        Me.txtCusterName.Size = New System.Drawing.Size(430, 24)
        Me.txtCusterName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(256, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "客戶名稱(&C)："
        '
        'gluCusterID
        '
        Me.gluCusterID.EditValue = ""
        Me.gluCusterID.Enabled = False
        Me.gluCusterID.Location = New System.Drawing.Point(108, 16)
        Me.gluCusterID.Name = "gluCusterID"
        Me.gluCusterID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluCusterID.Properties.Appearance.Options.UseFont = True
        Me.gluCusterID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluCusterID.Properties.DisplayMember = "MO_CusterID"
        Me.gluCusterID.Properties.NullText = ""
        Me.gluCusterID.Properties.ValueMember = "MO_CusterID"
        Me.gluCusterID.Properties.View = Me.viewCuster
        Me.gluCusterID.Size = New System.Drawing.Size(142, 24)
        Me.gluCusterID.TabIndex = 1
        '
        'viewCuster
        '
        Me.viewCuster.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MO_CusterID, Me.MO_CusterName})
        Me.viewCuster.DetailHeight = 360
        Me.viewCuster.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.viewCuster.Name = "viewCuster"
        Me.viewCuster.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewCuster.OptionsView.ShowAutoFilterRow = True
        Me.viewCuster.OptionsView.ShowGroupPanel = False
        '
        'MO_CusterID
        '
        Me.MO_CusterID.Caption = "客戶編號"
        Me.MO_CusterID.FieldName = "MO_CusterID"
        Me.MO_CusterID.Name = "MO_CusterID"
        Me.MO_CusterID.Visible = True
        Me.MO_CusterID.VisibleIndex = 1
        '
        'MO_CusterName
        '
        Me.MO_CusterName.Caption = "客戶名稱"
        Me.MO_CusterName.FieldName = "MO_CusterName"
        Me.MO_CusterName.Name = "MO_CusterName"
        Me.MO_CusterName.Visible = True
        Me.MO_CusterName.VisibleIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "客戶編號(&Q)："
        '
        'txtM_Gauge
        '
        Me.txtM_Gauge.Enabled = False
        Me.txtM_Gauge.Location = New System.Drawing.Point(355, 46)
        Me.txtM_Gauge.Name = "txtM_Gauge"
        Me.txtM_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txtM_Gauge.Size = New System.Drawing.Size(430, 24)
        Me.txtM_Gauge.TabIndex = 7
        '
        'txtM_Source
        '
        Me.txtM_Source.Enabled = False
        Me.txtM_Source.Location = New System.Drawing.Point(108, 76)
        Me.txtM_Source.Name = "txtM_Source"
        Me.txtM_Source.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Source.Properties.Appearance.Options.UseFont = True
        Me.txtM_Source.Size = New System.Drawing.Size(142, 24)
        Me.txtM_Source.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "來  源   碼(&J)："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(256, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "產品規格(&H)："
        '
        'gluM_Code
        '
        Me.gluM_Code.EditValue = ""
        Me.gluM_Code.Enabled = False
        Me.gluM_Code.Location = New System.Drawing.Point(108, 46)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.DisplayMember = "ParentGroup"
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.PopupFormWidth = 500
        Me.gluM_Code.Properties.ValueMember = "ParentGroup"
        Me.gluM_Code.Properties.View = Me.viewMaterial
        Me.gluM_Code.Size = New System.Drawing.Size(142, 24)
        Me.gluM_Code.TabIndex = 5
        '
        'viewMaterial
        '
        Me.viewMaterial.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ParentGroup, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.M_Source})
        Me.viewMaterial.DetailHeight = 540
        Me.viewMaterial.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.viewMaterial.Name = "viewMaterial"
        Me.viewMaterial.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewMaterial.OptionsView.ShowAutoFilterRow = True
        Me.viewMaterial.OptionsView.ShowGroupPanel = False
        '
        'ParentGroup
        '
        Me.ParentGroup.Caption = "產品編號"
        Me.ParentGroup.FieldName = "ParentGroup"
        Me.ParentGroup.Name = "ParentGroup"
        Me.ParentGroup.OptionsColumn.AllowEdit = False
        Me.ParentGroup.OptionsColumn.ReadOnly = True
        Me.ParentGroup.Visible = True
        Me.ParentGroup.VisibleIndex = 0
        Me.ParentGroup.Width = 116
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 93
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 50
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 50
        '
        'M_Source
        '
        Me.M_Source.Caption = "來源碼"
        Me.M_Source.FieldName = "M_Source"
        Me.M_Source.Name = "M_Source"
        Me.M_Source.OptionsColumn.AllowEdit = False
        Me.M_Source.OptionsColumn.ReadOnly = True
        Me.M_Source.Visible = True
        Me.M_Source.VisibleIndex = 4
        Me.M_Source.Width = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "產品編號(&D)："
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 158)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpGridView
        Me.XtraTabControl1.Size = New System.Drawing.Size(874, 365)
        Me.XtraTabControl1.TabIndex = 199
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGridView, Me.xtpCheck})
        '
        'xtpGridView
        '
        Me.xtpGridView.Controls.Add(Me.Grid1)
        Me.xtpGridView.Name = "xtpGridView"
        Me.xtpGridView.Size = New System.Drawing.Size(865, 333)
        Me.xtpGridView.Text = "生產明細"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsMps
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.View1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.ItemdteNeedDate})
        Me.Grid1.Size = New System.Drawing.Size(865, 333)
        Me.Grid1.TabIndex = 205
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.View1})
        '
        'cmsMps
        '
        Me.cmsMps.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsMpsAdd, Me.cmsMpsDel, Me.cmsMpsBatchAdd})
        Me.cmsMps.Name = "cmsMenuStrip"
        Me.cmsMps.Size = New System.Drawing.Size(173, 92)
        '
        'cmsMpsAdd
        '
        Me.cmsMpsAdd.Image = CType(resources.GetObject("cmsMpsAdd.Image"), System.Drawing.Image)
        Me.cmsMpsAdd.Name = "cmsMpsAdd"
        Me.cmsMpsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsMpsAdd.Size = New System.Drawing.Size(172, 22)
        Me.cmsMpsAdd.Text = "新增(&A)"
        '
        'cmsMpsDel
        '
        Me.cmsMpsDel.Image = CType(resources.GetObject("cmsMpsDel.Image"), System.Drawing.Image)
        Me.cmsMpsDel.Name = "cmsMpsDel"
        Me.cmsMpsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsMpsDel.Size = New System.Drawing.Size(172, 22)
        Me.cmsMpsDel.Text = "刪除(&D)"
        '
        'cmsMpsBatchAdd
        '
        Me.cmsMpsBatchAdd.Image = Global.LFERP.My.Resources.Resources.SmartArtOrganizationChartRightHanging
        Me.cmsMpsBatchAdd.Name = "cmsMpsBatchAdd"
        Me.cmsMpsBatchAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.cmsMpsBatchAdd.Size = New System.Drawing.Size(172, 22)
        Me.cmsMpsBatchAdd.Text = "批量添加"
        '
        'View1
        '
        Me.View1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PlanQty, Me.ProducedQty, Me.NeedDate, Me.WeeksNumber, Me.TimeSpan, Me.Remarks, Me.E_AutoID, Me.GridColumn1})
        Me.View1.GridControl = Me.Grid1
        Me.View1.Name = "View1"
        Me.View1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.View1.OptionsView.ColumnAutoWidth = False
        Me.View1.OptionsView.ShowFooter = True
        Me.View1.OptionsView.ShowGroupPanel = False
        '
        'PlanQty
        '
        Me.PlanQty.Caption = "計劃生產數量"
        Me.PlanQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PlanQty.FieldName = "PlanQty"
        Me.PlanQty.Name = "PlanQty"
        Me.PlanQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PlanQty.Visible = True
        Me.PlanQty.VisibleIndex = 0
        Me.PlanQty.Width = 100
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "N0"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "N0"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemCalcEdit1.Mask.EditMask = "[1-9]\d{0,10}"
        Me.RepositoryItemCalcEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemCalcEdit1.Mask.SaveLiteral = False
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'ProducedQty
        '
        Me.ProducedQty.Caption = "已生產數量"
        Me.ProducedQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.ProducedQty.FieldName = "ProducedQty"
        Me.ProducedQty.Name = "ProducedQty"
        Me.ProducedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ProducedQty.Visible = True
        Me.ProducedQty.VisibleIndex = 1
        Me.ProducedQty.Width = 86
        '
        'NeedDate
        '
        Me.NeedDate.Caption = "生產日期"
        Me.NeedDate.ColumnEdit = Me.ItemdteNeedDate
        Me.NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NeedDate.FieldName = "NeedDate"
        Me.NeedDate.Name = "NeedDate"
        Me.NeedDate.Visible = True
        Me.NeedDate.VisibleIndex = 2
        Me.NeedDate.Width = 89
        '
        'ItemdteNeedDate
        '
        Me.ItemdteNeedDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.ItemdteNeedDate.AutoHeight = False
        Me.ItemdteNeedDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemdteNeedDate.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.ItemdteNeedDate.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.ItemdteNeedDate.Name = "ItemdteNeedDate"
        '
        'WeeksNumber
        '
        Me.WeeksNumber.Caption = "周數"
        Me.WeeksNumber.FieldName = "WeeksNumber"
        Me.WeeksNumber.Name = "WeeksNumber"
        Me.WeeksNumber.OptionsColumn.AllowEdit = False
        Me.WeeksNumber.OptionsColumn.ReadOnly = True
        Me.WeeksNumber.Visible = True
        Me.WeeksNumber.VisibleIndex = 3
        Me.WeeksNumber.Width = 44
        '
        'TimeSpan
        '
        Me.TimeSpan.Caption = "時間段"
        Me.TimeSpan.FieldName = "TimeSpan"
        Me.TimeSpan.Name = "TimeSpan"
        Me.TimeSpan.OptionsColumn.AllowEdit = False
        Me.TimeSpan.OptionsColumn.ReadOnly = True
        Me.TimeSpan.Visible = True
        Me.TimeSpan.VisibleIndex = 4
        Me.TimeSpan.Width = 151
        '
        'Remarks
        '
        Me.Remarks.Caption = "备注"
        Me.Remarks.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remarks.FieldName = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Visible = True
        Me.Remarks.VisibleIndex = 5
        Me.Remarks.Width = 201
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'E_AutoID
        '
        Me.E_AutoID.Caption = "AutoID"
        Me.E_AutoID.FieldName = "AutoID"
        Me.E_AutoID.Name = "E_AutoID"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "MO"
        Me.GridColumn1.FieldName = "MO"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'xtpCheck
        '
        Me.xtpCheck.Controls.Add(Me.txtCheckRemark)
        Me.xtpCheck.Controls.Add(Me.Label6)
        Me.xtpCheck.Controls.Add(Me.chkCheck)
        Me.xtpCheck.Controls.Add(Me.Label10)
        Me.xtpCheck.Controls.Add(Me.lblCheckDate)
        Me.xtpCheck.Controls.Add(Me.lblCheckUser)
        Me.xtpCheck.Controls.Add(Me.txtrecheckaction)
        Me.xtpCheck.Controls.Add(Me.txtrecheckdate)
        Me.xtpCheck.Controls.Add(Me.Label17)
        Me.xtpCheck.Controls.Add(Me.Label18)
        Me.xtpCheck.Controls.Add(Me.Label19)
        Me.xtpCheck.Controls.Add(Me.Label21)
        Me.xtpCheck.Name = "xtpCheck"
        Me.xtpCheck.PageVisible = False
        Me.xtpCheck.Size = New System.Drawing.Size(865, 333)
        Me.xtpCheck.Text = "審核信息"
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(91, 41)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Properties.MaxLength = 200
        Me.txtCheckRemark.Size = New System.Drawing.Size(739, 200)
        Me.txtCheckRemark.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "備注(&N)："
        '
        'chkCheck
        '
        Me.chkCheck.Location = New System.Drawing.Point(91, 15)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheck.Properties.Appearance.Options.UseFont = True
        Me.chkCheck.Properties.Caption = "確認"
        Me.chkCheck.Size = New System.Drawing.Size(92, 20)
        Me.chkCheck.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "審核(&G)："
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(562, 18)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(82, 15)
        Me.lblCheckDate.TabIndex = 3
        Me.lblCheckDate.Text = "審核日期："
        Me.lblCheckDate.Visible = False
        '
        'lblCheckUser
        '
        Me.lblCheckUser.AutoSize = True
        Me.lblCheckUser.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUser.Location = New System.Drawing.Point(351, 18)
        Me.lblCheckUser.Name = "lblCheckUser"
        Me.lblCheckUser.Size = New System.Drawing.Size(67, 15)
        Me.lblCheckUser.TabIndex = 6
        Me.lblCheckUser.Text = "審核人："
        '
        'txtrecheckaction
        '
        Me.txtrecheckaction.AutoSize = True
        Me.txtrecheckaction.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckaction.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckaction.Location = New System.Drawing.Point(544, 18)
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
        Me.txtrecheckdate.Location = New System.Drawing.Point(424, 18)
        Me.txtrecheckdate.Name = "txtrecheckdate"
        Me.txtrecheckdate.Size = New System.Drawing.Size(0, 15)
        Me.txtrecheckdate.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(366, 18)
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
        Me.Label21.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(782, 529)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(696, 529)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 28)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "確定(&O)"
        '
        'txtMO
        '
        Me.txtMO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMO.Enabled = False
        Me.txtMO.Location = New System.Drawing.Point(721, 6)
        Me.txtMO.Name = "txtMO"
        Me.txtMO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMO.Properties.Appearance.Options.UseFont = True
        Me.txtMO.Properties.ReadOnly = True
        Me.txtMO.Size = New System.Drawing.Size(150, 24)
        Me.txtMO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(643, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "生產單號："
        '
        'frmMrpMps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 561)
        Me.Controls.Add(Me.txtMO)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpMps"
        Me.Text = "主生產計劃"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtProductionQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluCusterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewCuster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpGridView.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMps.ResumeLayout(False)
        CType(Me.View1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemdteNeedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents viewMaterial As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ParentGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtM_Gauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtM_Source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents lblCheckUser As System.Windows.Forms.Label
    Friend WithEvents txtrecheckaction As System.Windows.Forms.Label
    Friend WithEvents txtrecheckdate As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpGridView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents View1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PlanQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ProducedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WeeksNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TimeSpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents E_AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMps As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsMpsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMpsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMpsBatchAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemdteNeedDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtM_Unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCusterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gluCusterID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents viewCuster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_CusterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductionQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
