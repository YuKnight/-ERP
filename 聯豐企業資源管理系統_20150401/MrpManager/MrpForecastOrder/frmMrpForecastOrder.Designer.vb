<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpForecastOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpForecastOrder))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.caeNeedQty = New DevExpress.XtraEditors.CalcEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtPlanType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_M_Gauge = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Source = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Unit = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Name = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GLU_MCode = New DevExpress.XtraEditors.GridLookUpEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DM_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.ChkCancellation = New DevExpress.XtraEditors.CheckEdit
        Me.txt_CusterPO = New DevExpress.XtraEditors.TextEdit
        Me.det_ForecastDate = New DevExpress.XtraEditors.DateEdit
        Me.txtMO_CusterID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtUserID = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.xtcTable = New DevExpress.XtraTab.XtraTabControl
        Me.xtpCheck = New DevExpress.XtraTab.XtraTabPage
        Me.chkCheckBit = New DevExpress.XtraEditors.CheckEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblCheckUserID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtrecheckaction = New System.Windows.Forms.Label
        Me.txtrecheckdate = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.xtpGridView = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_MAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_Check = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PurchasedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PlanQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeliveryQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_NeedDateRIDE = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MI_WeekNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DateCross = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_Note = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.IsMrpOperation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.E_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ForecastID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISpurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISPpurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_ISWorkOrder = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.E_AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MI_IsCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MCodeText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PWO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PWO_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.txtForecastID = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PM_M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.caeNeedQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlanType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkCancellation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CusterPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.det_ForecastDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_CusterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTable.SuspendLayout()
        Me.xtpCheck.SuspendLayout()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpGridView.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtForecastID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1056, 32)
        Me.PictureBox1.TabIndex = 195
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.caeNeedQty)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtPlanType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_M_Gauge)
        Me.GroupBox1.Controls.Add(Me.txt_M_Source)
        Me.GroupBox1.Controls.Add(Me.txt_M_Unit)
        Me.GroupBox1.Controls.Add(Me.txt_M_Name)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GLU_MCode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ChkCancellation)
        Me.GroupBox1.Controls.Add(Me.txt_CusterPO)
        Me.GroupBox1.Controls.Add(Me.det_ForecastDate)
        Me.GroupBox1.Controls.Add(Me.txtMO_CusterID)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'caeNeedQty
        '
        Me.caeNeedQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.caeNeedQty.Enabled = False
        Me.caeNeedQty.Location = New System.Drawing.Point(872, 45)
        Me.caeNeedQty.Name = "caeNeedQty"
        Me.caeNeedQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.caeNeedQty.Properties.Appearance.Options.UseFont = True
        Me.caeNeedQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeNeedQty.Properties.Precision = 0
        Me.caeNeedQty.Size = New System.Drawing.Size(130, 24)
        Me.caeNeedQty.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(772, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "需求數量(&T)："
        '
        'txtPlanType
        '
        Me.txtPlanType.EditValue = "訂單"
        Me.txtPlanType.Location = New System.Drawing.Point(687, 15)
        Me.txtPlanType.Name = "txtPlanType"
        Me.txtPlanType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanType.Properties.Appearance.Options.UseFont = True
        Me.txtPlanType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPlanType.Properties.Items.AddRange(New Object() {"訂單", "備料", "例領", "重工", "樣板"})
        Me.txtPlanType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPlanType.Size = New System.Drawing.Size(79, 24)
        Me.txtPlanType.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(576, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "訂單類型(&M)："
        '
        'txt_M_Gauge
        '
        Me.txt_M_Gauge.Enabled = False
        Me.txt_M_Gauge.Location = New System.Drawing.Point(350, 71)
        Me.txt_M_Gauge.Name = "txt_M_Gauge"
        Me.txt_M_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Gauge.Size = New System.Drawing.Size(416, 24)
        Me.txt_M_Gauge.TabIndex = 19
        '
        'txt_M_Source
        '
        Me.txt_M_Source.Enabled = False
        Me.txt_M_Source.Location = New System.Drawing.Point(103, 71)
        Me.txt_M_Source.Name = "txt_M_Source"
        Me.txt_M_Source.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Source.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Source.Size = New System.Drawing.Size(142, 24)
        Me.txt_M_Source.TabIndex = 17
        '
        'txt_M_Unit
        '
        Me.txt_M_Unit.Enabled = False
        Me.txt_M_Unit.Location = New System.Drawing.Point(688, 43)
        Me.txt_M_Unit.Name = "txt_M_Unit"
        Me.txt_M_Unit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Unit.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Unit.Size = New System.Drawing.Size(79, 24)
        Me.txt_M_Unit.TabIndex = 13
        '
        'txt_M_Name
        '
        Me.txt_M_Name.Enabled = False
        Me.txt_M_Name.Location = New System.Drawing.Point(350, 43)
        Me.txt_M_Name.Name = "txt_M_Name"
        Me.txt_M_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Name.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Name.Size = New System.Drawing.Size(210, 24)
        Me.txt_M_Name.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(2, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "來  源   碼(&J)："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(577, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "單        位(&U)："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(251, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "產品規格(&H)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(251, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "產品名稱(&G)："
        '
        'GLU_MCode
        '
        Me.GLU_MCode.EditValue = ""
        Me.GLU_MCode.Enabled = False
        Me.GLU_MCode.Location = New System.Drawing.Point(103, 43)
        Me.GLU_MCode.Name = "GLU_MCode"
        Me.GLU_MCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GLU_MCode.Properties.Appearance.Options.UseFont = True
        Me.GLU_MCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_MCode.Properties.DisplayMember = "SO_CusterID"
        Me.GLU_MCode.Properties.NullText = ""
        Me.GLU_MCode.Properties.PopupFormWidth = 500
        Me.GLU_MCode.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2})
        Me.GLU_MCode.Properties.View = Me.GridView4
        Me.GLU_MCode.Size = New System.Drawing.Size(142, 24)
        Me.GLU_MCode.TabIndex = 9
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DM_Code, Me.DM_Name, Me.DM_Gauge, Me.DM_Unit, Me.DM_Source})
        Me.GridView4.DetailHeight = 540
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'DM_Code
        '
        Me.DM_Code.Caption = "產品編號"
        Me.DM_Code.FieldName = "ParentGroup"
        Me.DM_Code.Name = "DM_Code"
        Me.DM_Code.OptionsColumn.AllowEdit = False
        Me.DM_Code.OptionsColumn.ReadOnly = True
        Me.DM_Code.Visible = True
        Me.DM_Code.VisibleIndex = 0
        Me.DM_Code.Width = 116
        '
        'DM_Name
        '
        Me.DM_Name.Caption = "產品名稱"
        Me.DM_Name.FieldName = "M_Name"
        Me.DM_Name.Name = "DM_Name"
        Me.DM_Name.OptionsColumn.AllowEdit = False
        Me.DM_Name.OptionsColumn.ReadOnly = True
        Me.DM_Name.Visible = True
        Me.DM_Name.VisibleIndex = 1
        Me.DM_Name.Width = 93
        '
        'DM_Gauge
        '
        Me.DM_Gauge.Caption = "規格"
        Me.DM_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.DM_Gauge.FieldName = "M_Gauge"
        Me.DM_Gauge.Name = "DM_Gauge"
        Me.DM_Gauge.OptionsColumn.ReadOnly = True
        Me.DM_Gauge.Visible = True
        Me.DM_Gauge.VisibleIndex = 2
        Me.DM_Gauge.Width = 50
        '
        'DM_Unit
        '
        Me.DM_Unit.Caption = "單位"
        Me.DM_Unit.FieldName = "M_Unit"
        Me.DM_Unit.Name = "DM_Unit"
        Me.DM_Unit.OptionsColumn.AllowEdit = False
        Me.DM_Unit.OptionsColumn.ReadOnly = True
        Me.DM_Unit.Visible = True
        Me.DM_Unit.VisibleIndex = 3
        Me.DM_Unit.Width = 50
        '
        'DM_Source
        '
        Me.DM_Source.Caption = "來源碼"
        Me.DM_Source.FieldName = "M_Source"
        Me.DM_Source.Name = "DM_Source"
        Me.DM_Source.OptionsColumn.AllowEdit = False
        Me.DM_Source.OptionsColumn.ReadOnly = True
        Me.DM_Source.Visible = True
        Me.DM_Source.VisibleIndex = 4
        Me.DM_Source.Width = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(2, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "產品編號(&D)："
        '
        'ChkCancellation
        '
        Me.ChkCancellation.Enabled = False
        Me.ChkCancellation.Location = New System.Drawing.Point(872, 71)
        Me.ChkCancellation.Name = "ChkCancellation"
        Me.ChkCancellation.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCancellation.Properties.Appearance.Options.UseFont = True
        Me.ChkCancellation.Properties.Caption = "確認"
        Me.ChkCancellation.Size = New System.Drawing.Size(92, 20)
        Me.ChkCancellation.TabIndex = 21
        '
        'txt_CusterPO
        '
        Me.txt_CusterPO.Location = New System.Drawing.Point(350, 15)
        Me.txt_CusterPO.Name = "txt_CusterPO"
        Me.txt_CusterPO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_CusterPO.Properties.Appearance.Options.UseFont = True
        Me.txt_CusterPO.Size = New System.Drawing.Size(210, 24)
        Me.txt_CusterPO.TabIndex = 3
        '
        'det_ForecastDate
        '
        Me.det_ForecastDate.EditValue = "now"
        Me.det_ForecastDate.Enabled = False
        Me.det_ForecastDate.Location = New System.Drawing.Point(646, 119)
        Me.det_ForecastDate.Name = "det_ForecastDate"
        Me.det_ForecastDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.det_ForecastDate.Properties.Appearance.Options.UseFont = True
        Me.det_ForecastDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.det_ForecastDate.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.det_ForecastDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.det_ForecastDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.det_ForecastDate.Properties.Mask.ShowPlaceHolders = False
        Me.det_ForecastDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.det_ForecastDate.Size = New System.Drawing.Size(142, 24)
        Me.det_ForecastDate.TabIndex = 19
        Me.det_ForecastDate.Visible = False
        '
        'txtMO_CusterID
        '
        Me.txtMO_CusterID.EditValue = ""
        Me.txtMO_CusterID.Enabled = False
        Me.txtMO_CusterID.Location = New System.Drawing.Point(103, 15)
        Me.txtMO_CusterID.Name = "txtMO_CusterID"
        Me.txtMO_CusterID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMO_CusterID.Properties.Appearance.Options.UseFont = True
        Me.txtMO_CusterID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMO_CusterID.Properties.DisplayMember = "SO_CusterID"
        Me.txtMO_CusterID.Properties.NullText = ""
        Me.txtMO_CusterID.Properties.View = Me.GridView2
        Me.txtMO_CusterID.Size = New System.Drawing.Size(142, 24)
        Me.txtMO_CusterID.TabIndex = 1
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MO_CusterID, Me.MO_CusterName})
        Me.GridView2.DetailHeight = 360
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(872, 15)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtUserID.Properties.Appearance.Options.UseFont = True
        Me.txtUserID.Size = New System.Drawing.Size(129, 24)
        Me.txtUserID.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(774, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "是否作廢(&F)："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "客戶編號(&Q)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(772, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "創建人員(&E)："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(547, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "預測日期(&S)："
        Me.Label6.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(251, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "客戶訂單(&V)："
        '
        'xtcTable
        '
        Me.xtcTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcTable.Location = New System.Drawing.Point(6, 144)
        Me.xtcTable.Name = "xtcTable"
        Me.xtcTable.SelectedTabPage = Me.xtpCheck
        Me.xtcTable.Size = New System.Drawing.Size(1046, 391)
        Me.xtcTable.TabIndex = 1
        Me.xtcTable.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGridView, Me.xtpCheck})
        '
        'xtpCheck
        '
        Me.xtpCheck.Controls.Add(Me.chkCheckBit)
        Me.xtpCheck.Controls.Add(Me.Label10)
        Me.xtpCheck.Controls.Add(Me.lblCheckDate)
        Me.xtpCheck.Controls.Add(Me.Label8)
        Me.xtpCheck.Controls.Add(Me.lblCheckUserID)
        Me.xtpCheck.Controls.Add(Me.Label9)
        Me.xtpCheck.Controls.Add(Me.txtrecheckaction)
        Me.xtpCheck.Controls.Add(Me.txtrecheckdate)
        Me.xtpCheck.Controls.Add(Me.Label17)
        Me.xtpCheck.Controls.Add(Me.Label18)
        Me.xtpCheck.Controls.Add(Me.Label19)
        Me.xtpCheck.Controls.Add(Me.Label21)
        Me.xtpCheck.Controls.Add(Me.txtCheckRemark)
        Me.xtpCheck.Name = "xtpCheck"
        Me.xtpCheck.PageVisible = False
        Me.xtpCheck.Size = New System.Drawing.Size(1037, 359)
        Me.xtpCheck.Text = "審核信息"
        '
        'chkCheckBit
        '
        Me.chkCheckBit.Location = New System.Drawing.Point(71, 16)
        Me.chkCheckBit.Name = "chkCheckBit"
        Me.chkCheckBit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckBit.Properties.Appearance.Options.UseFont = True
        Me.chkCheckBit.Properties.Caption = "確認"
        Me.chkCheckBit.Size = New System.Drawing.Size(92, 20)
        Me.chkCheckBit.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "審核(&G)："
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(759, 18)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(23, 15)
        Me.lblCheckDate.TabIndex = 11
        Me.lblCheckDate.Text = "    "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(682, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "審核日期："
        '
        'lblCheckUserID
        '
        Me.lblCheckUserID.AutoSize = True
        Me.lblCheckUserID.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUserID.Location = New System.Drawing.Point(428, 18)
        Me.lblCheckUserID.Name = "lblCheckUserID"
        Me.lblCheckUserID.Size = New System.Drawing.Size(23, 15)
        Me.lblCheckUserID.TabIndex = 8
        Me.lblCheckUserID.Text = "    "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(365, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 7
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
        Me.txtrecheckaction.TabIndex = 6
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
        Me.txtrecheckdate.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(796, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 15)
        Me.Label17.TabIndex = 12
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
        Me.Label18.TabIndex = 5
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
        Me.Label21.TabIndex = 1
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(71, 41)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Properties.MaxLength = 200
        Me.txtCheckRemark.ShowToolTips = False
        Me.txtCheckRemark.Size = New System.Drawing.Size(928, 200)
        Me.txtCheckRemark.TabIndex = 0
        '
        'xtpGridView
        '
        Me.xtpGridView.Controls.Add(Me.Grid1)
        Me.xtpGridView.Name = "xtpGridView"
        Me.xtpGridView.Size = New System.Drawing.Size(1037, 359)
        Me.xtpGridView.Text = "需求明細"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsMenuStrip
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit2, Me.MI_NeedDateRIDE})
        Me.Grid1.Size = New System.Drawing.Size(1037, 359)
        Me.Grid1.TabIndex = 205
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmDelete, Me.tsm_MAdd, Me.tsm_Check})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(173, 92)
        '
        'tsmNew
        '
        Me.tsmNew.Enabled = False
        Me.tsmNew.Image = CType(resources.GetObject("tsmNew.Image"), System.Drawing.Image)
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(172, 22)
        Me.tsmNew.Text = "新增(&A)"
        Me.tsmNew.Visible = False
        '
        'tsmDelete
        '
        Me.tsmDelete.Enabled = False
        Me.tsmDelete.Image = CType(resources.GetObject("tsmDelete.Image"), System.Drawing.Image)
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmDelete.Size = New System.Drawing.Size(172, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        Me.tsmDelete.Visible = False
        '
        'tsm_MAdd
        '
        Me.tsm_MAdd.Enabled = False
        Me.tsm_MAdd.Image = Global.LFERP.My.Resources.Resources.SmartArtOrganizationChartRightHanging
        Me.tsm_MAdd.Name = "tsm_MAdd"
        Me.tsm_MAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.tsm_MAdd.Size = New System.Drawing.Size(172, 22)
        Me.tsm_MAdd.Text = "批量添加"
        Me.tsm_MAdd.Visible = False
        '
        'tsm_Check
        '
        Me.tsm_Check.Enabled = False
        Me.tsm_Check.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.tsm_Check.Name = "tsm_Check"
        Me.tsm_Check.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsm_Check.Size = New System.Drawing.Size(172, 22)
        Me.tsm_Check.Text = "審核(&C)"
        Me.tsm_Check.Visible = False
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MI_Qty, Me.PurchasedQty, Me.PlanQty, Me.DeliveryQty, Me.MI_NeedDate, Me.MI_WeekNumber, Me.DateCross, Me.MI_Note, Me.IsMrpOperation, Me.E_CreateUserName, Me.E_CreateDate, Me.E_ModifyUserName, Me.E_ModifyDate, Me.E_ForecastID, Me.MI_ISpurchase, Me.MI_ISPpurchase, Me.MI_ISWorkOrder, Me.E_CreateUserID, Me.E_ModifyUserID, Me.E_AutoID, Me.MI_IsCheck})
        Me.GridView.GridControl = Me.Grid1
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'MI_Qty
        '
        Me.MI_Qty.Caption = "訂單數量"
        Me.MI_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.MI_Qty.FieldName = "MI_Qty"
        Me.MI_Qty.Name = "MI_Qty"
        Me.MI_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.MI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.MI_Qty.Visible = True
        Me.MI_Qty.VisibleIndex = 3
        Me.MI_Qty.Width = 100
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
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'PurchasedQty
        '
        Me.PurchasedQty.Caption = "已採數量"
        Me.PurchasedQty.FieldName = "PurchasedQty"
        Me.PurchasedQty.Name = "PurchasedQty"
        Me.PurchasedQty.OptionsColumn.AllowEdit = False
        Me.PurchasedQty.OptionsColumn.ReadOnly = True
        Me.PurchasedQty.SummaryItem.DisplayFormat = "{0}"
        Me.PurchasedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PurchasedQty.Visible = True
        Me.PurchasedQty.VisibleIndex = 4
        Me.PurchasedQty.Width = 100
        '
        'PlanQty
        '
        Me.PlanQty.Caption = "計劃生產數量"
        Me.PlanQty.FieldName = "PlanQty"
        Me.PlanQty.Name = "PlanQty"
        Me.PlanQty.OptionsColumn.AllowEdit = False
        Me.PlanQty.SummaryItem.DisplayFormat = "{0}"
        Me.PlanQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PlanQty.Width = 100
        '
        'DeliveryQty
        '
        Me.DeliveryQty.Caption = "已交數量"
        Me.DeliveryQty.FieldName = "DeliveryQty"
        Me.DeliveryQty.Name = "DeliveryQty"
        Me.DeliveryQty.OptionsColumn.AllowEdit = False
        Me.DeliveryQty.OptionsColumn.ReadOnly = True
        Me.DeliveryQty.SummaryItem.DisplayFormat = "{0}"
        Me.DeliveryQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.DeliveryQty.Visible = True
        Me.DeliveryQty.VisibleIndex = 5
        '
        'MI_NeedDate
        '
        Me.MI_NeedDate.Caption = "需求日期"
        Me.MI_NeedDate.ColumnEdit = Me.MI_NeedDateRIDE
        Me.MI_NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MI_NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MI_NeedDate.FieldName = "MI_NeedDate"
        Me.MI_NeedDate.Name = "MI_NeedDate"
        Me.MI_NeedDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.MI_NeedDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.MI_NeedDate.Visible = True
        Me.MI_NeedDate.VisibleIndex = 0
        Me.MI_NeedDate.Width = 89
        '
        'MI_NeedDateRIDE
        '
        Me.MI_NeedDateRIDE.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.MI_NeedDateRIDE.AutoHeight = False
        Me.MI_NeedDateRIDE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MI_NeedDateRIDE.Name = "MI_NeedDateRIDE"
        Me.MI_NeedDateRIDE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MI_WeekNumber
        '
        Me.MI_WeekNumber.Caption = "周數"
        Me.MI_WeekNumber.FieldName = "MI_WeekNumber"
        Me.MI_WeekNumber.Name = "MI_WeekNumber"
        Me.MI_WeekNumber.OptionsColumn.AllowEdit = False
        Me.MI_WeekNumber.OptionsColumn.ReadOnly = True
        Me.MI_WeekNumber.Visible = True
        Me.MI_WeekNumber.VisibleIndex = 1
        Me.MI_WeekNumber.Width = 44
        '
        'DateCross
        '
        Me.DateCross.Caption = "時間段"
        Me.DateCross.FieldName = "DateCross"
        Me.DateCross.Name = "DateCross"
        Me.DateCross.OptionsColumn.AllowEdit = False
        Me.DateCross.OptionsColumn.ReadOnly = True
        Me.DateCross.Visible = True
        Me.DateCross.VisibleIndex = 2
        Me.DateCross.Width = 161
        '
        'MI_Note
        '
        Me.MI_Note.Caption = "备注"
        Me.MI_Note.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.MI_Note.FieldName = "MI_Note"
        Me.MI_Note.Name = "MI_Note"
        Me.MI_Note.Visible = True
        Me.MI_Note.VisibleIndex = 6
        Me.MI_Note.Width = 189
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'IsMrpOperation
        '
        Me.IsMrpOperation.Caption = "是否運算"
        Me.IsMrpOperation.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.IsMrpOperation.FieldName = "IsMrpOperation"
        Me.IsMrpOperation.Name = "IsMrpOperation"
        Me.IsMrpOperation.OptionsColumn.AllowEdit = False
        Me.IsMrpOperation.OptionsColumn.ReadOnly = True
        Me.IsMrpOperation.Visible = True
        Me.IsMrpOperation.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'E_CreateUserName
        '
        Me.E_CreateUserName.Caption = "創建人員"
        Me.E_CreateUserName.FieldName = "CreateUserName"
        Me.E_CreateUserName.Name = "E_CreateUserName"
        '
        'E_CreateDate
        '
        Me.E_CreateDate.Caption = "創建時間"
        Me.E_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.E_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.E_CreateDate.FieldName = "CreateDate"
        Me.E_CreateDate.Name = "E_CreateDate"
        '
        'E_ModifyUserName
        '
        Me.E_ModifyUserName.Caption = "修改人員"
        Me.E_ModifyUserName.FieldName = "ModifyUserName"
        Me.E_ModifyUserName.Name = "E_ModifyUserName"
        '
        'E_ModifyDate
        '
        Me.E_ModifyDate.Caption = "修改時間"
        Me.E_ModifyDate.FieldName = "ModifyDate"
        Me.E_ModifyDate.Name = "E_ModifyDate"
        '
        'E_ForecastID
        '
        Me.E_ForecastID.Caption = "预测单号"
        Me.E_ForecastID.FieldName = "ForecastID"
        Me.E_ForecastID.Name = "E_ForecastID"
        '
        'MI_ISpurchase
        '
        Me.MI_ISpurchase.Caption = "是否訂購"
        Me.MI_ISpurchase.FieldName = "MI_ISpurchase"
        Me.MI_ISpurchase.Name = "MI_ISpurchase"
        '
        'MI_ISPpurchase
        '
        Me.MI_ISPpurchase.Caption = "是否轉請購"
        Me.MI_ISPpurchase.FieldName = "MI_ISPpurchase"
        Me.MI_ISPpurchase.Name = "MI_ISPpurchase"
        '
        'MI_ISWorkOrder
        '
        Me.MI_ISWorkOrder.Caption = "是否購工單"
        Me.MI_ISWorkOrder.FieldName = "MI_ISWorkOrder"
        Me.MI_ISWorkOrder.Name = "MI_ISWorkOrder"
        '
        'E_CreateUserID
        '
        Me.E_CreateUserID.Caption = "CreateUserID"
        Me.E_CreateUserID.FieldName = "CreateUserID"
        Me.E_CreateUserID.Name = "E_CreateUserID"
        '
        'E_ModifyUserID
        '
        Me.E_ModifyUserID.Caption = "ModifyUserID"
        Me.E_ModifyUserID.FieldName = "ModifyUserID"
        Me.E_ModifyUserID.Name = "E_ModifyUserID"
        '
        'E_AutoID
        '
        Me.E_AutoID.Caption = "AutoID"
        Me.E_AutoID.FieldName = "AutoID"
        Me.E_AutoID.Name = "E_AutoID"
        '
        'MI_IsCheck
        '
        Me.MI_IsCheck.Caption = "審核"
        Me.MI_IsCheck.FieldName = "IsCheck"
        Me.MI_IsCheck.Name = "MI_IsCheck"
        Me.MI_IsCheck.OptionsColumn.AllowEdit = False
        Me.MI_IsCheck.Visible = True
        Me.MI_IsCheck.VisibleIndex = 8
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(881, 537)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(967, 537)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "取消(&C)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.PM_JiYu, Me.PM_Type, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.PWO_Qty, Me.PI_Qty, Me.M_Unit, Me.PWO_Type, Me.GridColumn3})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "產品編號"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 93
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "機玉"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.ReadOnly = True
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.ColumnEdit = Me.RepositoryItemComboBox1
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 2
        Me.PM_Type.Width = 95
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.ColumnEdit = Me.MCodeText
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 3
        Me.M_Code.Width = 125
        '
        'MCodeText
        '
        Me.MCodeText.AutoHeight = False
        Me.MCodeText.Name = "MCodeText"
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 4
        Me.M_Name.Width = 73
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 5
        Me.M_Gauge.Width = 150
        '
        'RemarkItemMemoExEdit1
        '
        Me.RemarkItemMemoExEdit1.AutoHeight = False
        Me.RemarkItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkItemMemoExEdit1.Name = "RemarkItemMemoExEdit1"
        Me.RemarkItemMemoExEdit1.ShowIcon = False
        '
        'PWO_Qty
        '
        Me.PWO_Qty.Caption = "出庫數量"
        Me.PWO_Qty.ColumnEdit = Me.QtyItemCalcEdit
        Me.PWO_Qty.FieldName = "PWO_Qty"
        Me.PWO_Qty.Name = "PWO_Qty"
        Me.PWO_Qty.Visible = True
        Me.PWO_Qty.VisibleIndex = 6
        Me.PWO_Qty.Width = 81
        '
        'QtyItemCalcEdit
        '
        Me.QtyItemCalcEdit.AutoHeight = False
        Me.QtyItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyItemCalcEdit.Name = "QtyItemCalcEdit"
        '
        'PI_Qty
        '
        Me.PI_Qty.Caption = "庫存數量"
        Me.PI_Qty.FieldName = "PI_Qty"
        Me.PI_Qty.Name = "PI_Qty"
        Me.PI_Qty.OptionsColumn.ReadOnly = True
        Me.PI_Qty.Visible = True
        Me.PI_Qty.VisibleIndex = 7
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 8
        Me.M_Unit.Width = 45
        '
        'PWO_Type
        '
        Me.PWO_Type.Caption = "出庫類型"
        Me.PWO_Type.FieldName = "PWO_SubType"
        Me.PWO_Type.Name = "PWO_Type"
        Me.PWO_Type.Visible = True
        Me.PWO_Type.VisibleIndex = 9
        Me.PWO_Type.Width = 76
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "備註"
        Me.GridColumn3.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.GridColumn3.FieldName = "PWO_SubRemark"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 10
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(1, 5)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(131, 21)
        Me.Lbl_Title.TabIndex = 0
        Me.Lbl_Title.Text = "MRP預測訂單"
        '
        'txtForecastID
        '
        Me.txtForecastID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtForecastID.Enabled = False
        Me.txtForecastID.Location = New System.Drawing.Point(908, 3)
        Me.txtForecastID.Name = "txtForecastID"
        Me.txtForecastID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtForecastID.Properties.Appearance.Options.UseFont = True
        Me.txtForecastID.Size = New System.Drawing.Size(144, 24)
        Me.txtForecastID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(817, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "預測訂單號:"
        '
        'PM_M_Code1
        '
        Me.PM_M_Code1.Caption = "产品编号"
        Me.PM_M_Code1.FieldName = "PM_M_Code"
        Me.PM_M_Code1.Name = "PM_M_Code1"
        Me.PM_M_Code1.Visible = True
        Me.PM_M_Code1.VisibleIndex = 0
        Me.PM_M_Code1.Width = 123
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(6, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1046, 100)
        Me.Panel2.TabIndex = 196
        '
        'frmMrpForecastOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 574)
        Me.Controls.Add(Me.xtcTable)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtForecastID)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpForecastOrder"
        Me.Text = "MRP預測訂單"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.caeNeedQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlanType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkCancellation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CusterPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.det_ForecastDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_CusterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTable.ResumeLayout(False)
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpGridView.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MI_NeedDateRIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtForecastID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MCodeText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PWO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents PI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PWO_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents ChkCancellation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtForecastID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents det_ForecastDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMO_CusterID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MO_CusterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_CusterPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tsm_MAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GLU_MCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_M_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_M_Source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_M_Unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtcTable As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkCheckBit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCheckUserID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtrecheckaction As System.Windows.Forms.Label
    Friend WithEvents txtrecheckdate As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpGridView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_M_Gauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents PurchasedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PlanQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_WeekNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateCross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_Note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents E_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ForecastID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISpurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISPpurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI_ISWorkOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents E_AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPlanType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents IsMrpOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MI_NeedDateRIDE As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DeliveryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents caeNeedQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tsm_Check As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MI_IsCheck As DevExpress.XtraGrid.Columns.GridColumn
    '   Friend WithEvents CachedCrystal_Report115rptUseKnifeScatter1 As LFERP.CachedCrystal_Report115rptUseKnifeScatter
End Class
