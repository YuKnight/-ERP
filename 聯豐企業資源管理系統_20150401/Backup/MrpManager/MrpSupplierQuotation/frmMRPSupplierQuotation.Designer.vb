<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRPSupplierQuotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRPSupplierQuotation))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MrpPurchaseID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IsPurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MPP_CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_UnitPrice = New DevExpress.XtraEditors.TextEdit
        Me.txt_S_SupplierName = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_MinQty = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_MaxQty = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_DeliveryDate = New DevExpress.XtraEditors.TextEdit
        Me.txt_OrderQty = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_EconomicQty = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Gauge = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Source = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Unit = New DevExpress.XtraEditors.TextEdit
        Me.txt_M_Name = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GLU_MCode = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DM_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DM_Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_ResponsibleUserName = New DevExpress.XtraEditors.TextEdit
        Me.txt_S_Supplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMrpSQID = New DevExpress.XtraEditors.TextEdit
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_UnitPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_SupplierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MinQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaxQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DeliveryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OrderQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EconomicQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_M_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ResponsibleUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMrpSQID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTable.SuspendLayout()
        Me.xtpCheck.SuspendLayout()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(846, 32)
        Me.PictureBox1.TabIndex = 203
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(5, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(197, 21)
        Me.Lbl_Title.TabIndex = 204
        Me.Lbl_Title.Text = "MRP供應商報價信息"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 200)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MrpPurchaseID, Me.MRP_ID, Me.MPP_CreateUserName, Me.MPP_CreateDate, Me.MPP_ModifyUserName, Me.MPP_ModifyDate, Me.MPP_CheckUserName, Me.MPP_CheckDate, Me.CheckBit, Me.CheckRemark, Me.IsPurchase, Me.MPP_CreateUserID, Me.MPP_ModifyUserID, Me.MPP_CheckUserID, Me.AutoID})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MrpPurchaseID
        '
        Me.MrpPurchaseID.Caption = "MRP請購單號"
        Me.MrpPurchaseID.FieldName = "MrpPurchaseID"
        Me.MrpPurchaseID.Name = "MrpPurchaseID"
        Me.MrpPurchaseID.OptionsColumn.AllowEdit = False
        Me.MrpPurchaseID.OptionsColumn.ReadOnly = True
        Me.MrpPurchaseID.Visible = True
        Me.MrpPurchaseID.VisibleIndex = 0
        Me.MrpPurchaseID.Width = 142
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "MRP運算單號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.OptionsColumn.AllowEdit = False
        Me.MRP_ID.OptionsColumn.ReadOnly = True
        Me.MRP_ID.Visible = True
        Me.MRP_ID.VisibleIndex = 1
        Me.MRP_ID.Width = 112
        '
        'MPP_CreateUserName
        '
        Me.MPP_CreateUserName.Caption = "創建人員"
        Me.MPP_CreateUserName.FieldName = "MPP_CreateUserName"
        Me.MPP_CreateUserName.Name = "MPP_CreateUserName"
        Me.MPP_CreateUserName.OptionsColumn.AllowEdit = False
        Me.MPP_CreateUserName.OptionsColumn.ReadOnly = True
        Me.MPP_CreateUserName.Visible = True
        Me.MPP_CreateUserName.VisibleIndex = 2
        Me.MPP_CreateUserName.Width = 76
        '
        'MPP_CreateDate
        '
        Me.MPP_CreateDate.Caption = "創建時間"
        Me.MPP_CreateDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPP_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPP_CreateDate.FieldName = "MPP_CreateDate"
        Me.MPP_CreateDate.Name = "MPP_CreateDate"
        Me.MPP_CreateDate.OptionsColumn.AllowEdit = False
        Me.MPP_CreateDate.OptionsColumn.ReadOnly = True
        Me.MPP_CreateDate.Visible = True
        Me.MPP_CreateDate.VisibleIndex = 3
        Me.MPP_CreateDate.Width = 111
        '
        'MPP_ModifyUserName
        '
        Me.MPP_ModifyUserName.Caption = "修改人員"
        Me.MPP_ModifyUserName.FieldName = "MPP_ModifyUserName"
        Me.MPP_ModifyUserName.Name = "MPP_ModifyUserName"
        Me.MPP_ModifyUserName.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyUserName.OptionsColumn.ReadOnly = True
        '
        'MPP_ModifyDate
        '
        Me.MPP_ModifyDate.Caption = "修改時間"
        Me.MPP_ModifyDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MPP_ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MPP_ModifyDate.FieldName = "MPP_ModifyDate"
        Me.MPP_ModifyDate.Name = "MPP_ModifyDate"
        Me.MPP_ModifyDate.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyDate.OptionsColumn.ReadOnly = True
        '
        'MPP_CheckUserName
        '
        Me.MPP_CheckUserName.Caption = "審核人員"
        Me.MPP_CheckUserName.FieldName = "MPP_CheckUserName"
        Me.MPP_CheckUserName.Name = "MPP_CheckUserName"
        Me.MPP_CheckUserName.OptionsColumn.AllowEdit = False
        Me.MPP_CheckUserName.OptionsColumn.ReadOnly = True
        Me.MPP_CheckUserName.Visible = True
        Me.MPP_CheckUserName.VisibleIndex = 4
        Me.MPP_CheckUserName.Width = 71
        '
        'MPP_CheckDate
        '
        Me.MPP_CheckDate.Caption = "審核時間"
        Me.MPP_CheckDate.FieldName = "MPP_CheckDate"
        Me.MPP_CheckDate.Name = "MPP_CheckDate"
        Me.MPP_CheckDate.OptionsColumn.AllowEdit = False
        Me.MPP_CheckDate.OptionsColumn.ReadOnly = True
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.OptionsColumn.ReadOnly = True
        Me.CheckBit.Tag = False
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 5
        Me.CheckBit.Width = 51
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.AllowEdit = False
        Me.CheckRemark.OptionsColumn.ReadOnly = True
        Me.CheckRemark.Visible = True
        Me.CheckRemark.VisibleIndex = 6
        Me.CheckRemark.Width = 174
        '
        'IsPurchase
        '
        Me.IsPurchase.Caption = "是否請購"
        Me.IsPurchase.FieldName = "IsPurchase"
        Me.IsPurchase.Name = "IsPurchase"
        Me.IsPurchase.OptionsColumn.AllowEdit = False
        Me.IsPurchase.OptionsColumn.ReadOnly = True
        Me.IsPurchase.Visible = True
        Me.IsPurchase.VisibleIndex = 7
        Me.IsPurchase.Width = 74
        '
        'MPP_CreateUserID
        '
        Me.MPP_CreateUserID.Caption = "創建人員"
        Me.MPP_CreateUserID.FieldName = "MPP_CreateUserID"
        Me.MPP_CreateUserID.Name = "MPP_CreateUserID"
        Me.MPP_CreateUserID.OptionsColumn.AllowEdit = False
        Me.MPP_CreateUserID.OptionsColumn.ReadOnly = True
        Me.MPP_CreateUserID.Width = 104
        '
        'MPP_ModifyUserID
        '
        Me.MPP_ModifyUserID.Caption = "修改人員"
        Me.MPP_ModifyUserID.FieldName = "MPP_ModifyUserID"
        Me.MPP_ModifyUserID.Name = "MPP_ModifyUserID"
        Me.MPP_ModifyUserID.OptionsColumn.AllowEdit = False
        Me.MPP_ModifyUserID.OptionsColumn.ReadOnly = True
        '
        'MPP_CheckUserID
        '
        Me.MPP_CheckUserID.Caption = "審核人員"
        Me.MPP_CheckUserID.FieldName = "MPP_CheckUserID"
        Me.MPP_CheckUserID.Name = "MPP_CheckUserID"
        Me.MPP_CheckUserID.OptionsColumn.AllowEdit = False
        Me.MPP_CheckUserID.OptionsColumn.ReadOnly = True
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_UnitPrice)
        Me.GroupBox1.Controls.Add(Me.txt_S_SupplierName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txt_MinQty)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_MaxQty)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_DeliveryDate)
        Me.GroupBox1.Controls.Add(Me.txt_OrderQty)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_EconomicQty)
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
        Me.GroupBox1.Controls.Add(Me.txt_ResponsibleUserName)
        Me.GroupBox1.Controls.Add(Me.txt_S_Supplier)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 359)
        Me.GroupBox1.TabIndex = 205
        Me.GroupBox1.TabStop = False
        '
        'txt_UnitPrice
        '
        Me.txt_UnitPrice.Location = New System.Drawing.Point(750, 15)
        Me.txt_UnitPrice.Name = "txt_UnitPrice"
        Me.txt_UnitPrice.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_UnitPrice.Properties.Appearance.Options.UseFont = True
        Me.txt_UnitPrice.Size = New System.Drawing.Size(90, 24)
        Me.txt_UnitPrice.TabIndex = 33
        '
        'txt_S_SupplierName
        '
        Me.txt_S_SupplierName.Enabled = False
        Me.txt_S_SupplierName.Location = New System.Drawing.Point(329, 78)
        Me.txt_S_SupplierName.Name = "txt_S_SupplierName"
        Me.txt_S_SupplierName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_S_SupplierName.Properties.Appearance.Options.UseFont = True
        Me.txt_S_SupplierName.Size = New System.Drawing.Size(102, 24)
        Me.txt_S_SupplierName.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(213, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 15)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "供應商名稱(&H)："
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(676, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 15)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "單價(&D)："
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(449, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 15)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "負責人(&S)："
        '
        'txt_MinQty
        '
        Me.txt_MinQty.Location = New System.Drawing.Point(329, 110)
        Me.txt_MinQty.Name = "txt_MinQty"
        Me.txt_MinQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_MinQty.Properties.Appearance.Options.UseFont = True
        Me.txt_MinQty.Size = New System.Drawing.Size(103, 24)
        Me.txt_MinQty.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(229, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "最小數量(&T)："
        '
        'txt_MaxQty
        '
        Me.txt_MaxQty.Location = New System.Drawing.Point(104, 110)
        Me.txt_MaxQty.Name = "txt_MaxQty"
        Me.txt_MaxQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_MaxQty.Properties.Appearance.Options.UseFont = True
        Me.txt_MaxQty.Size = New System.Drawing.Size(110, 24)
        Me.txt_MaxQty.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "最大數量(&R)："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(643, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "採購週期(&W)："
        '
        'txt_DeliveryDate
        '
        Me.txt_DeliveryDate.Location = New System.Drawing.Point(750, 78)
        Me.txt_DeliveryDate.Name = "txt_DeliveryDate"
        Me.txt_DeliveryDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_DeliveryDate.Properties.Appearance.Options.UseFont = True
        Me.txt_DeliveryDate.Size = New System.Drawing.Size(90, 24)
        Me.txt_DeliveryDate.TabIndex = 26
        '
        'txt_OrderQty
        '
        Me.txt_OrderQty.Location = New System.Drawing.Point(538, 78)
        Me.txt_OrderQty.Name = "txt_OrderQty"
        Me.txt_OrderQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_OrderQty.Properties.Appearance.Options.UseFont = True
        Me.txt_OrderQty.Size = New System.Drawing.Size(90, 24)
        Me.txt_OrderQty.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(444, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "訂購批量(&Q)："
        '
        'txt_EconomicQty
        '
        Me.txt_EconomicQty.Location = New System.Drawing.Point(750, 110)
        Me.txt_EconomicQty.Name = "txt_EconomicQty"
        Me.txt_EconomicQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_EconomicQty.Properties.Appearance.Options.UseFont = True
        Me.txt_EconomicQty.Size = New System.Drawing.Size(90, 24)
        Me.txt_EconomicQty.TabIndex = 23
        '
        'txt_M_Gauge
        '
        Me.txt_M_Gauge.Enabled = False
        Me.txt_M_Gauge.Location = New System.Drawing.Point(329, 44)
        Me.txt_M_Gauge.Name = "txt_M_Gauge"
        Me.txt_M_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Gauge.Size = New System.Drawing.Size(512, 24)
        Me.txt_M_Gauge.TabIndex = 17
        '
        'txt_M_Source
        '
        Me.txt_M_Source.Enabled = False
        Me.txt_M_Source.Location = New System.Drawing.Point(104, 44)
        Me.txt_M_Source.Name = "txt_M_Source"
        Me.txt_M_Source.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Source.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Source.Size = New System.Drawing.Size(110, 24)
        Me.txt_M_Source.TabIndex = 15
        '
        'txt_M_Unit
        '
        Me.txt_M_Unit.Enabled = False
        Me.txt_M_Unit.Location = New System.Drawing.Point(630, 15)
        Me.txt_M_Unit.Name = "txt_M_Unit"
        Me.txt_M_Unit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_M_Unit.Properties.Appearance.Options.UseFont = True
        Me.txt_M_Unit.Size = New System.Drawing.Size(41, 24)
        Me.txt_M_Unit.TabIndex = 13
        '
        'txt_M_Name
        '
        Me.txt_M_Name.Enabled = False
        Me.txt_M_Name.Location = New System.Drawing.Point(329, 15)
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
        Me.Label15.Location = New System.Drawing.Point(21, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "來源碼(&E)："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(549, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "單位(&C)："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(230, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "產品規格(&F)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(229, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "產品名稱(&B)："
        '
        'GLU_MCode
        '
        Me.GLU_MCode.EditValue = ""
        Me.GLU_MCode.Location = New System.Drawing.Point(104, 15)
        Me.GLU_MCode.Name = "GLU_MCode"
        Me.GLU_MCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GLU_MCode.Properties.Appearance.Options.UseFont = True
        Me.GLU_MCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_MCode.Properties.DisplayMember = "SO_CusterID"
        Me.GLU_MCode.Properties.NullText = ""
        Me.GLU_MCode.Properties.PopupFormWidth = 500
        Me.GLU_MCode.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2})
        Me.GLU_MCode.Properties.View = Me.GridView4
        Me.GLU_MCode.Size = New System.Drawing.Size(110, 24)
        Me.GLU_MCode.TabIndex = 9
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
        Me.DM_Code.FieldName = "M_Code"
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
        Me.DM_Source.FieldName = "Source"
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
        Me.Label13.Location = New System.Drawing.Point(5, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "產品編號(&A)："
        '
        'txt_ResponsibleUserName
        '
        Me.txt_ResponsibleUserName.Location = New System.Drawing.Point(538, 110)
        Me.txt_ResponsibleUserName.Name = "txt_ResponsibleUserName"
        Me.txt_ResponsibleUserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_ResponsibleUserName.Properties.Appearance.Options.UseFont = True
        Me.txt_ResponsibleUserName.Size = New System.Drawing.Size(90, 24)
        Me.txt_ResponsibleUserName.TabIndex = 3
        '
        'txt_S_Supplier
        '
        Me.txt_S_Supplier.EditValue = ""
        Me.txt_S_Supplier.Location = New System.Drawing.Point(104, 78)
        Me.txt_S_Supplier.Name = "txt_S_Supplier"
        Me.txt_S_Supplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_S_Supplier.Properties.Appearance.Options.UseFont = True
        Me.txt_S_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_S_Supplier.Properties.DisplayMember = "SO_CusterID"
        Me.txt_S_Supplier.Properties.NullText = ""
        Me.txt_S_Supplier.Properties.View = Me.GridView2
        Me.txt_S_Supplier.Size = New System.Drawing.Size(110, 24)
        Me.txt_S_Supplier.TabIndex = 1
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView2.DetailHeight = 360
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "供應商編號"
        Me.GridColumn1.FieldName = "S_Supplier"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "供應商名稱"
        Me.GridColumn2.FieldName = "S_SupplierName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "供 應 商(&G)："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(646, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "經濟批量(&X)："
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(750, 432)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(664, 432)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "確定(&O)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(531, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "供應商報價信息編號："
        '
        'txtMrpSQID
        '
        Me.txtMrpSQID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMrpSQID.Enabled = False
        Me.txtMrpSQID.Location = New System.Drawing.Point(694, 5)
        Me.txtMrpSQID.Name = "txtMrpSQID"
        Me.txtMrpSQID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMrpSQID.Properties.Appearance.Options.UseFont = True
        Me.txtMrpSQID.Size = New System.Drawing.Size(144, 24)
        Me.txtMrpSQID.TabIndex = 207
        '
        'xtcTable
        '
        Me.xtcTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcTable.Location = New System.Drawing.Point(3, 416)
        Me.xtcTable.Name = "xtcTable"
        Me.xtcTable.SelectedTabPage = Me.xtpCheck
        Me.xtcTable.Size = New System.Drawing.Size(843, 10)
        Me.xtcTable.TabIndex = 208
        Me.xtcTable.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpCheck})
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
        Me.xtpCheck.Size = New System.Drawing.Size(834, 0)
        Me.xtpCheck.Text = "審核信息"
        '
        'chkCheckBit
        '
        Me.chkCheckBit.Location = New System.Drawing.Point(71, 15)
        Me.chkCheckBit.Name = "chkCheckBit"
        Me.chkCheckBit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckBit.Properties.Appearance.Options.UseFont = True
        Me.chkCheckBit.Properties.Caption = "確認"
        Me.chkCheckBit.Size = New System.Drawing.Size(92, 20)
        Me.chkCheckBit.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "審核(&G)："
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(368, 18)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(67, 15)
        Me.lblCheckDate.TabIndex = 4
        Me.lblCheckDate.Text = "審核日期"
        Me.lblCheckDate.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "審核日期："
        Me.Label8.Visible = False
        '
        'lblCheckUserID
        '
        Me.lblCheckUserID.AutoSize = True
        Me.lblCheckUserID.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUserID.Location = New System.Drawing.Point(602, 18)
        Me.lblCheckUserID.Name = "lblCheckUserID"
        Me.lblCheckUserID.Size = New System.Drawing.Size(52, 15)
        Me.lblCheckUserID.TabIndex = 7
        Me.lblCheckUserID.Text = "審核人"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(529, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 6
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
        Me.txtrecheckdate.TabIndex = 5
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
        Me.Label21.TabIndex = 8
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(71, 41)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Size = New System.Drawing.Size(613, 134)
        Me.txtCheckRemark.TabIndex = 9
        '
        'frmMRPSupplierQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 459)
        Me.Controls.Add(Me.xtcTable)
        Me.Controls.Add(Me.txtMrpSQID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMRPSupplierQuotation"
        Me.Text = "frmMRPSupplierQuotation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_UnitPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_SupplierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MinQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaxQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DeliveryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OrderQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EconomicQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_M_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_MCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ResponsibleUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMrpSQID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTable.ResumeLayout(False)
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        CType(Me.chkCheckBit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MrpPurchaseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsPurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MPP_CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_M_Gauge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_M_Source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_M_Unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_M_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GLU_MCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DM_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_ResponsibleUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_S_Supplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMrpSQID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_OrderQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EconomicQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DeliveryDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_MinQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_MaxQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_UnitPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_S_SupplierName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
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
End Class
