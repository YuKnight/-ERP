<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpPurchaseOrder
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gluPR = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MrpPurchaseID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gluWareHouse = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkIsUrgency = New DevExpress.XtraEditors.CheckEdit
        Me.dteRequestDate = New DevExpress.XtraEditors.DateEdit
        Me.gluUserID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCurrencyName = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtContacts = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPaymentType = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.gluDept = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.gluSupplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.viewSupplier = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lable10 = New System.Windows.Forms.Label
        Me.txtPO = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.xtpGridView = New DevExpress.XtraTab.XtraTabPage
        Me.pccMaterial = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridMaterial = New DevExpress.XtraGrid.GridControl
        Me.ViewMaterial = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridPurchaseOrder = New DevExpress.XtraGrid.GridControl
        Me.cmsPurOrder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPurOrderAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsPurOrderDel = New System.Windows.Forms.ToolStripMenuItem
        Me.viewPurchaseOrder = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemPceMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NeedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.xtpCheck = New DevExpress.XtraTab.XtraTabPage
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.lblCheckUserName = New System.Windows.Forms.Label
        Me.chkCheck = New DevExpress.XtraEditors.CheckEdit
        Me.lblCheck = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gluWareHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsUrgency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteRequestDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluUserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrencyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpGridView.SuspendLayout()
        CType(Me.pccMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccMaterial.SuspendLayout()
        CType(Me.GridMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPurOrder.SuspendLayout()
        CType(Me.viewPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCheck.SuspendLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!)
        Me.lblTitle.Location = New System.Drawing.Point(4, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(109, 21)
        Me.lblTitle.TabIndex = 238
        Me.lblTitle.Text = "MRP采購單"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(976, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 237
        Me.PictureBox1.TabStop = False
        '
        'gluPR
        '
        Me.gluPR.EditValue = ""
        Me.gluPR.Enabled = False
        Me.gluPR.Location = New System.Drawing.Point(78, 15)
        Me.gluPR.Name = "gluPR"
        Me.gluPR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPR.Properties.Appearance.Options.UseFont = True
        Me.gluPR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPR.Properties.DisplayMember = "MrpPurchaseID"
        Me.gluPR.Properties.NullText = ""
        Me.gluPR.Properties.PopupFormWidth = 178
        Me.gluPR.Properties.ValueMember = "MrpPurchaseID"
        Me.gluPR.Properties.View = Me.GridView6
        Me.gluPR.Size = New System.Drawing.Size(178, 24)
        Me.gluPR.TabIndex = 1
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MrpPurchaseID})
        Me.GridView6.DetailHeight = 100
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'MrpPurchaseID
        '
        Me.MrpPurchaseID.Caption = "請購單號"
        Me.MrpPurchaseID.FieldName = "MrpPurchaseID"
        Me.MrpPurchaseID.Name = "MrpPurchaseID"
        Me.MrpPurchaseID.Visible = True
        Me.MrpPurchaseID.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "請購單號："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gluWareHouse)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.chkIsUrgency)
        Me.GroupBox1.Controls.Add(Me.dteRequestDate)
        Me.GroupBox1.Controls.Add(Me.gluUserID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCurrencyName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.GridLookUpEdit1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtContacts)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPaymentType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.gluDept)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.gluPR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.gluSupplier)
        Me.GroupBox1.Controls.Add(Me.lable10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 177)
        Me.GroupBox1.TabIndex = 241
        Me.GroupBox1.TabStop = False
        '
        'gluWareHouse
        '
        Me.gluWareHouse.Location = New System.Drawing.Point(78, 96)
        Me.gluWareHouse.Name = "gluWareHouse"
        Me.gluWareHouse.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluWareHouse.Properties.Appearance.Options.UseFont = True
        Me.gluWareHouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluWareHouse.Properties.DisplayMember = "WH_ID"
        Me.gluWareHouse.Properties.NullText = ""
        Me.gluWareHouse.Properties.PopupFormWidth = 178
        Me.gluWareHouse.Properties.ValueMember = "WH_Name"
        Me.gluWareHouse.Properties.View = Me.GridView3
        Me.gluWareHouse.Size = New System.Drawing.Size(178, 24)
        Me.gluWareHouse.TabIndex = 12
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.GridColumn29})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "倉庫編號"
        Me.GridColumn28.FieldName = "WH_ID"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        Me.GridColumn28.Width = 70
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "倉庫名稱"
        Me.GridColumn29.FieldName = "WH_Name"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 1
        Me.GridColumn29.Width = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(3, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 15)
        Me.Label14.TabIndex = 285
        Me.Label14.Text = "進貨倉庫："
        '
        'chkIsUrgency
        '
        Me.chkIsUrgency.Location = New System.Drawing.Point(282, 97)
        Me.chkIsUrgency.Name = "chkIsUrgency"
        Me.chkIsUrgency.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.chkIsUrgency.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.chkIsUrgency.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkIsUrgency.Properties.Appearance.Options.UseBackColor = True
        Me.chkIsUrgency.Properties.Appearance.Options.UseFont = True
        Me.chkIsUrgency.Properties.Appearance.Options.UseForeColor = True
        Me.chkIsUrgency.Properties.Caption = "是否緊急"
        Me.chkIsUrgency.Size = New System.Drawing.Size(93, 20)
        Me.chkIsUrgency.TabIndex = 13
        '
        'dteRequestDate
        '
        Me.dteRequestDate.EditValue = Nothing
        Me.dteRequestDate.Location = New System.Drawing.Point(765, 15)
        Me.dteRequestDate.Name = "dteRequestDate"
        Me.dteRequestDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteRequestDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteRequestDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dteRequestDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteRequestDate.Size = New System.Drawing.Size(120, 21)
        Me.dteRequestDate.TabIndex = 3
        '
        'gluUserID
        '
        Me.gluUserID.EditValue = ""
        Me.gluUserID.EnterMoveNextControl = True
        Me.gluUserID.Location = New System.Drawing.Point(554, 15)
        Me.gluUserID.Name = "gluUserID"
        Me.gluUserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluUserID.Properties.Appearance.Options.UseFont = True
        Me.gluUserID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluUserID.Properties.DisplayMember = "U_Name"
        Me.gluUserID.Properties.NullText = ""
        Me.gluUserID.Properties.PopupFormWidth = 180
        Me.gluUserID.Properties.ValueMember = "U_ID"
        Me.gluUserID.Properties.View = Me.GridLookUpEdit1View
        Me.gluUserID.Size = New System.Drawing.Size(120, 24)
        Me.gluUserID.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Appearance.Row.Options.UseTextOptions = True
        Me.GridLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn25})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "帳號"
        Me.GridColumn4.FieldName = "U_ID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 70
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.Caption = "姓名"
        Me.GridColumn25.FieldName = "U_Name"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 1
        Me.GridColumn25.Width = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(478, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 280
        Me.Label12.Text = "請購人員："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(689, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "請購日期："
        '
        'txtCurrencyName
        '
        Me.txtCurrencyName.Enabled = False
        Me.txtCurrencyName.Location = New System.Drawing.Point(554, 43)
        Me.txtCurrencyName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCurrencyName.Name = "txtCurrencyName"
        Me.txtCurrencyName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCurrencyName.Properties.Appearance.Options.UseFont = True
        Me.txtCurrencyName.Size = New System.Drawing.Size(120, 24)
        Me.txtCurrencyName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(479, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 266
        Me.Label5.Text = "幣       別："
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(344, 71)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(120, 24)
        Me.txtEmail.TabIndex = 9
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Enabled = False
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(765, 71)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DisplayMember = "DeptName"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFormWidth = 250
        Me.GridLookUpEdit1.Properties.ValueMember = "DeptID"
        Me.GridLookUpEdit1.Properties.View = Me.GridView2
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(120, 24)
        Me.GridLookUpEdit1.TabIndex = 11
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn26, Me.GridColumn27})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "部門編號"
        Me.GridColumn26.FieldName = "DeptID"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "部門名稱"
        Me.GridColumn27.FieldName = "DeptName"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(268, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 276
        Me.Label11.Text = "郵       件："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(688, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 282
        Me.Label13.Text = "送貨方式："
        '
        'txtFax
        '
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(554, 71)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Size = New System.Drawing.Size(120, 24)
        Me.txtFax.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(478, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 274
        Me.Label9.Text = "傳       真："
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(78, 69)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Size = New System.Drawing.Size(178, 24)
        Me.txtTel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = " 電       話："
        '
        'txtContacts
        '
        Me.txtContacts.Enabled = False
        Me.txtContacts.Location = New System.Drawing.Point(765, 41)
        Me.txtContacts.Margin = New System.Windows.Forms.Padding(6)
        Me.txtContacts.Name = "txtContacts"
        Me.txtContacts.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtContacts.Properties.Appearance.Options.UseFont = True
        Me.txtContacts.Size = New System.Drawing.Size(120, 24)
        Me.txtContacts.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(686, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 270
        Me.Label7.Text = " 聯  系  人："
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Enabled = False
        Me.txtPaymentType.Location = New System.Drawing.Point(344, 43)
        Me.txtPaymentType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPaymentType.Properties.Appearance.Options.UseFont = True
        Me.txtPaymentType.Size = New System.Drawing.Size(120, 24)
        Me.txtPaymentType.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(268, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 268
        Me.Label6.Text = "付款方式："
        '
        'gluDept
        '
        Me.gluDept.Location = New System.Drawing.Point(344, 15)
        Me.gluDept.Name = "gluDept"
        Me.gluDept.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluDept.Properties.Appearance.Options.UseFont = True
        Me.gluDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluDept.Properties.DisplayMember = "DeptName"
        Me.gluDept.Properties.NullText = ""
        Me.gluDept.Properties.PopupFormWidth = 250
        Me.gluDept.Properties.ValueMember = "DeptID"
        Me.gluDept.Properties.View = Me.GridView1
        Me.gluDept.Size = New System.Drawing.Size(120, 24)
        Me.gluDept.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn11})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "部門編號"
        Me.GridColumn5.FieldName = "DeptID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "部門名稱"
        Me.GridColumn11.FieldName = "DeptName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(267, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 263
        Me.Label3.Text = "請購部門："
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(78, 123)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(807, 44)
        Me.txtRemarks.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 261
        Me.Label2.Text = "備       注："
        '
        'gluSupplier
        '
        Me.gluSupplier.Enabled = False
        Me.gluSupplier.Location = New System.Drawing.Point(78, 42)
        Me.gluSupplier.Name = "gluSupplier"
        Me.gluSupplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSupplier.Properties.Appearance.Options.UseFont = True
        Me.gluSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSupplier.Properties.DisplayMember = "S_SupplierName"
        Me.gluSupplier.Properties.NullText = ""
        Me.gluSupplier.Properties.PopupFormWidth = 250
        Me.gluSupplier.Properties.ValueMember = "S_Supplier"
        Me.gluSupplier.Properties.View = Me.viewSupplier
        Me.gluSupplier.Size = New System.Drawing.Size(178, 24)
        Me.gluSupplier.TabIndex = 4
        '
        'viewSupplier
        '
        Me.viewSupplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24})
        Me.viewSupplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.viewSupplier.Name = "viewSupplier"
        Me.viewSupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewSupplier.OptionsView.ColumnAutoWidth = False
        Me.viewSupplier.OptionsView.ShowAutoFilterRow = True
        Me.viewSupplier.OptionsView.ShowGroupPanel = False
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編碼"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        Me.S_Supplier.Width = 85
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        Me.S_SupplierName.Width = 165
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "S_ToFrom"
        Me.GridColumn19.FieldName = "S_ToFrom"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "S_Tel"
        Me.GridColumn20.FieldName = "S_Tel"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "S_Associate"
        Me.GridColumn21.FieldName = "S_Associate"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "CurrencyName"
        Me.GridColumn22.FieldName = "CurrencyName"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "S_Email"
        Me.GridColumn23.FieldName = "S_Email"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "S_Fax"
        Me.GridColumn24.FieldName = "S_Fax"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'lable10
        '
        Me.lable10.AutoSize = True
        Me.lable10.BackColor = System.Drawing.Color.Transparent
        Me.lable10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lable10.ForeColor = System.Drawing.Color.Black
        Me.lable10.Location = New System.Drawing.Point(3, 46)
        Me.lable10.Name = "lable10"
        Me.lable10.Size = New System.Drawing.Size(79, 15)
        Me.lable10.TabIndex = 256
        Me.lable10.Text = "供 應  商："
        '
        'txtPO
        '
        Me.txtPO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPO.Enabled = False
        Me.txtPO.Location = New System.Drawing.Point(845, 3)
        Me.txtPO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPO.Properties.Appearance.Options.UseFont = True
        Me.txtPO.Size = New System.Drawing.Size(120, 24)
        Me.txtPO.TabIndex = 258
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(775, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "采購單號:"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(8, 221)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpGridView
        Me.XtraTabControl1.Size = New System.Drawing.Size(963, 317)
        Me.XtraTabControl1.TabIndex = 242
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGridView, Me.xtpCheck})
        '
        'xtpGridView
        '
        Me.xtpGridView.Controls.Add(Me.pccMaterial)
        Me.xtpGridView.Controls.Add(Me.GridPurchaseOrder)
        Me.xtpGridView.Name = "xtpGridView"
        Me.xtpGridView.Size = New System.Drawing.Size(954, 285)
        Me.xtpGridView.Text = "物料明細"
        '
        'pccMaterial
        '
        Me.pccMaterial.Controls.Add(Me.GridMaterial)
        Me.pccMaterial.Location = New System.Drawing.Point(3, 122)
        Me.pccMaterial.Name = "pccMaterial"
        Me.pccMaterial.Size = New System.Drawing.Size(397, 185)
        Me.pccMaterial.TabIndex = 207
        Me.pccMaterial.Text = "PopupContainerControl1"
        '
        'GridMaterial
        '
        Me.GridMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterial.EmbeddedNavigator.Name = ""
        Me.GridMaterial.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterial.MainView = Me.ViewMaterial
        Me.GridMaterial.Name = "GridMaterial"
        Me.GridMaterial.Size = New System.Drawing.Size(397, 185)
        Me.GridMaterial.TabIndex = 0
        Me.GridMaterial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewMaterial})
        '
        'ViewMaterial
        '
        Me.ViewMaterial.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.ViewMaterial.GridControl = Me.GridMaterial
        Me.ViewMaterial.Name = "ViewMaterial"
        Me.ViewMaterial.OptionsBehavior.Editable = False
        Me.ViewMaterial.OptionsView.ColumnAutoWidth = False
        Me.ViewMaterial.OptionsView.ShowAutoFilterRow = True
        Me.ViewMaterial.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "物料編碼"
        Me.GridColumn6.FieldName = "M_Code"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 127
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "物料名稱"
        Me.GridColumn7.FieldName = "M_Name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 106
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "物料規格"
        Me.GridColumn8.FieldName = "M_Gauge"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 147
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "單位"
        Me.GridColumn9.FieldName = "M_Unit"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "來源碼"
        Me.GridColumn10.FieldName = "MC_Source"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridPurchaseOrder
        '
        Me.GridPurchaseOrder.ContextMenuStrip = Me.cmsPurOrder
        Me.GridPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPurchaseOrder.EmbeddedNavigator.Name = ""
        Me.GridPurchaseOrder.Location = New System.Drawing.Point(0, 0)
        Me.GridPurchaseOrder.MainView = Me.viewPurchaseOrder
        Me.GridPurchaseOrder.Name = "GridPurchaseOrder"
        Me.GridPurchaseOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemPceMaterial, Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1})
        Me.GridPurchaseOrder.Size = New System.Drawing.Size(954, 285)
        Me.GridPurchaseOrder.TabIndex = 243
        Me.GridPurchaseOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewPurchaseOrder})
        '
        'cmsPurOrder
        '
        Me.cmsPurOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPurOrderAdd, Me.cmsPurOrderDel})
        Me.cmsPurOrder.Name = "cmsBill"
        Me.cmsPurOrder.Size = New System.Drawing.Size(163, 70)
        '
        'cmsPurOrderAdd
        '
        Me.cmsPurOrderAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsPurOrderAdd.Name = "cmsPurOrderAdd"
        Me.cmsPurOrderAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsPurOrderAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsPurOrderAdd.Text = "新增(&A)"
        '
        'cmsPurOrderDel
        '
        Me.cmsPurOrderDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsPurOrderDel.Name = "cmsPurOrderDel"
        Me.cmsPurOrderDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsPurOrderDel.Size = New System.Drawing.Size(162, 22)
        Me.cmsPurOrderDel.Text = "刪除(&D)"
        '
        'viewPurchaseOrder
        '
        Me.viewPurchaseOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.GridColumn2, Me.PurchaseQty, Me.UnitPrice, Me.TotalPrice, Me.NeedDate, Me.GridColumn3, Me.GridColumn17})
        Me.viewPurchaseOrder.GridControl = Me.GridPurchaseOrder
        Me.viewPurchaseOrder.Name = "viewPurchaseOrder"
        Me.viewPurchaseOrder.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewPurchaseOrder.OptionsView.ColumnAutoWidth = False
        Me.viewPurchaseOrder.OptionsView.ShowFooter = True
        Me.viewPurchaseOrder.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "AutoID"
        Me.GridColumn1.FieldName = "AutoID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.ColumnEdit = Me.ItemPceMaterial
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 143
        '
        'ItemPceMaterial
        '
        Me.ItemPceMaterial.AutoHeight = False
        Me.ItemPceMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemPceMaterial.Name = "ItemPceMaterial"
        Me.ItemPceMaterial.PopupControl = Me.pccMaterial
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 130
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 140
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "物料單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "來源碼"
        Me.GridColumn2.FieldName = "Source"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.SummaryItem.DisplayFormat = "數量："
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'PurchaseQty
        '
        Me.PurchaseQty.Caption = "采購數量"
        Me.PurchaseQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PurchaseQty.FieldName = "PurchaseQty"
        Me.PurchaseQty.Name = "PurchaseQty"
        Me.PurchaseQty.SummaryItem.DisplayFormat = "{0}"
        Me.PurchaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PurchaseQty.Visible = True
        Me.PurchaseQty.VisibleIndex = 5
        Me.PurchaseQty.Width = 87
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "單價"
        Me.UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.SummaryItem.DisplayFormat = "金額："
        Me.UnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 6
        '
        'TotalPrice
        '
        Me.TotalPrice.Caption = "金額"
        Me.TotalPrice.FieldName = "TotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.OptionsColumn.AllowEdit = False
        Me.TotalPrice.SummaryItem.DisplayFormat = "{0}"
        Me.TotalPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalPrice.Visible = True
        Me.TotalPrice.VisibleIndex = 7
        Me.TotalPrice.Width = 91
        '
        'NeedDate
        '
        Me.NeedDate.Caption = "需求日期"
        Me.NeedDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.NeedDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.NeedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NeedDate.FieldName = "NeedDate"
        Me.NeedDate.Name = "NeedDate"
        Me.NeedDate.Visible = True
        Me.NeedDate.VisibleIndex = 8
        Me.NeedDate.Width = 84
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "預定交期"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn3.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn3.FieldName = "DeliveryDate"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "備注"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn17.FieldName = "Remarks"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 10
        Me.GridColumn17.Width = 203
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'xtpCheck
        '
        Me.xtpCheck.Controls.Add(Me.txtCheckRemark)
        Me.xtpCheck.Controls.Add(Me.Label15)
        Me.xtpCheck.Controls.Add(Me.lblCheckDate)
        Me.xtpCheck.Controls.Add(Me.lblCheckUserName)
        Me.xtpCheck.Controls.Add(Me.chkCheck)
        Me.xtpCheck.Controls.Add(Me.lblCheck)
        Me.xtpCheck.Controls.Add(Me.Label18)
        Me.xtpCheck.Controls.Add(Me.Label19)
        Me.xtpCheck.Controls.Add(Me.Label21)
        Me.xtpCheck.Name = "xtpCheck"
        Me.xtpCheck.PageVisible = False
        Me.xtpCheck.Size = New System.Drawing.Size(954, 285)
        Me.xtpCheck.Text = "審核信息"
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
        Me.txtCheckRemark.Size = New System.Drawing.Size(844, 200)
        Me.txtCheckRemark.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "備注："
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(567, 17)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(82, 15)
        Me.lblCheckDate.TabIndex = 9
        Me.lblCheckDate.Text = "審核日期："
        '
        'lblCheckUserName
        '
        Me.lblCheckUserName.AutoSize = True
        Me.lblCheckUserName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckUserName.Location = New System.Drawing.Point(338, 17)
        Me.lblCheckUserName.Name = "lblCheckUserName"
        Me.lblCheckUserName.Size = New System.Drawing.Size(82, 15)
        Me.lblCheckUserName.TabIndex = 8
        Me.lblCheckUserName.Text = "審核人員："
        '
        'chkCheck
        '
        Me.chkCheck.Location = New System.Drawing.Point(71, 15)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheck.Properties.Appearance.Options.UseFont = True
        Me.chkCheck.Properties.Caption = "確認"
        Me.chkCheck.Size = New System.Drawing.Size(92, 20)
        Me.chkCheck.TabIndex = 1
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheck.Location = New System.Drawing.Point(21, 17)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(52, 15)
        Me.lblCheck.TabIndex = 0
        Me.lblCheck.Text = "審核："
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
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(883, 544)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 27)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnSave.Location = New System.Drawing.Point(773, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "確認(&O)"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "PaymentType"
        Me.GridColumn12.FieldName = "PaymentType"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tel"
        Me.GridColumn13.FieldName = "Tel"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Contacts"
        Me.GridColumn14.FieldName = "Contacts"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "CurrencyName"
        Me.GridColumn15.FieldName = "CurrencyName"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Email"
        Me.GridColumn16.FieldName = "Email"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Fax"
        Me.GridColumn18.FieldName = "Fax"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 177)
        Me.Panel1.TabIndex = 260
        '
        'frmMrpPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMrpPurchaseOrder"
        Me.Text = "MRP采購單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gluWareHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsUrgency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteRequestDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluUserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrencyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpGridView.ResumeLayout(False)
        CType(Me.pccMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccMaterial.ResumeLayout(False)
        CType(Me.GridMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPurOrder.ResumeLayout(False)
        CType(Me.viewPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPceMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCheck.ResumeLayout(False)
        Me.xtpCheck.PerformLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents gluPR As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MrpPurchaseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gluSupplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents viewSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lable10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpGridView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pccMaterial As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridMaterial As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewMaterial As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridPurchaseOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewPurchaseOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmsPurOrder As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsPurOrderAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPurOrderDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemPceMaterial As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gluDept As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContacts As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCurrencyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dteRequestDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gluUserID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents chkIsUrgency As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCheckUserName As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents gluWareHouse As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
