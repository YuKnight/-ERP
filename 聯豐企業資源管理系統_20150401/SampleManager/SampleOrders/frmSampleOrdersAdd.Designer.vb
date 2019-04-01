<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleOrdersAdd
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具进行修改。
    '请不要使用程式碼編輯器进行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_OrdersType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblOrdersType = New System.Windows.Forms.Label
        Me.lblSO_SampleID = New System.Windows.Forms.Label
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.cmdSampType = New DevExpress.XtraEditors.SimpleButton
        Me.cmdMaterialType = New DevExpress.XtraEditors.SimpleButton
        Me.GridLookUpSampType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SampTypeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SampTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.GridLookUpMaterialType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MaterialTypeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MaterialTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAddress1 = New DevExpress.XtraEditors.TextEdit
        Me.lblAddress1 = New System.Windows.Forms.Label
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.txtContacts = New DevExpress.XtraEditors.TextEdit
        Me.lblContacts = New System.Windows.Forms.Label
        Me.dtp_podate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_customerid = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txt_customerpo = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_company = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CO_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtordersid = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl2 = New DevExpress.XtraEditors.PopupContainerControl
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SO_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CusterNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ride_senddate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SO_OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.SO_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_PriceUine = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.SO_Rank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmb_rank = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_checkdate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_checkuser = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.txt_checkremark = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_OrdersType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpSampType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpMaterialType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_podate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customerid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customerpo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_company.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtordersid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ride_senddate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_checkremark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "样办订单管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1007, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_OrdersType)
        Me.Panel1.Controls.Add(Me.lblOrdersType)
        Me.Panel1.Controls.Add(Me.lblSO_SampleID)
        Me.Panel1.Controls.Add(Me.txtSO_SampleID)
        Me.Panel1.Controls.Add(Me.cmdSampType)
        Me.Panel1.Controls.Add(Me.cmdMaterialType)
        Me.Panel1.Controls.Add(Me.GridLookUpSampType)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.GridLookUpMaterialType)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtAddress1)
        Me.Panel1.Controls.Add(Me.lblAddress1)
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.txtContacts)
        Me.Panel1.Controls.Add(Me.lblContacts)
        Me.Panel1.Controls.Add(Me.dtp_podate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_customerid)
        Me.Panel1.Controls.Add(Me.txt_customerpo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 94)
        Me.Panel1.TabIndex = 2
        '
        'txt_OrdersType
        '
        Me.txt_OrdersType.EditValue = "樣板"
        Me.txt_OrdersType.Location = New System.Drawing.Point(611, 33)
        Me.txt_OrdersType.Name = "txt_OrdersType"
        Me.txt_OrdersType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_OrdersType.Properties.Appearance.Options.UseFont = True
        Me.txt_OrdersType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_OrdersType.Properties.Items.AddRange(New Object() {"樣板", "大貨"})
        Me.txt_OrdersType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_OrdersType.Size = New System.Drawing.Size(150, 24)
        Me.txt_OrdersType.TabIndex = 15
        '
        'lblOrdersType
        '
        Me.lblOrdersType.AutoSize = True
        Me.lblOrdersType.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOrdersType.Location = New System.Drawing.Point(516, 35)
        Me.lblOrdersType.Name = "lblOrdersType"
        Me.lblOrdersType.Padding = New System.Windows.Forms.Padding(1)
        Me.lblOrdersType.Size = New System.Drawing.Size(90, 17)
        Me.lblOrdersType.TabIndex = 14
        Me.lblOrdersType.Text = "類       型(&T):"
        '
        'lblSO_SampleID
        '
        Me.lblSO_SampleID.AutoSize = True
        Me.lblSO_SampleID.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSO_SampleID.Location = New System.Drawing.Point(8, 9)
        Me.lblSO_SampleID.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.lblSO_SampleID.Name = "lblSO_SampleID"
        Me.lblSO_SampleID.Size = New System.Drawing.Size(91, 15)
        Me.lblSO_SampleID.TabIndex = 0
        Me.lblSO_SampleID.Text = "样办单号(&Y):"
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.Location = New System.Drawing.Point(106, 4)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(182, 24)
        Me.txtSO_SampleID.TabIndex = 1
        '
        'cmdSampType
        '
        Me.cmdSampType.Location = New System.Drawing.Point(264, 32)
        Me.cmdSampType.Name = "cmdSampType"
        Me.cmdSampType.Size = New System.Drawing.Size(25, 25)
        Me.cmdSampType.TabIndex = 10
        Me.cmdSampType.Text = "..."
        '
        'cmdMaterialType
        '
        Me.cmdMaterialType.Location = New System.Drawing.Point(489, 32)
        Me.cmdMaterialType.Name = "cmdMaterialType"
        Me.cmdMaterialType.Size = New System.Drawing.Size(25, 25)
        Me.cmdMaterialType.TabIndex = 13
        Me.cmdMaterialType.Text = "..."
        '
        'GridLookUpSampType
        '
        Me.GridLookUpSampType.AllowDrop = True
        Me.GridLookUpSampType.Location = New System.Drawing.Point(106, 32)
        Me.GridLookUpSampType.Name = "GridLookUpSampType"
        Me.GridLookUpSampType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpSampType.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpSampType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpSampType.Properties.DisplayMember = "CO_ID"
        Me.GridLookUpSampType.Properties.NullText = ""
        Me.GridLookUpSampType.Properties.View = Me.GridView5
        Me.GridLookUpSampType.Size = New System.Drawing.Size(156, 24)
        Me.GridLookUpSampType.TabIndex = 9
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SampTypeID, Me.SampTypeName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'SampTypeID
        '
        Me.SampTypeID.Caption = "編號"
        Me.SampTypeID.FieldName = "TID"
        Me.SampTypeID.Name = "SampTypeID"
        '
        'SampTypeName
        '
        Me.SampTypeName.Caption = "样办阶段"
        Me.SampTypeName.FieldName = "TName"
        Me.SampTypeName.Name = "SampTypeName"
        Me.SampTypeName.Visible = True
        Me.SampTypeName.VisibleIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 15)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "样办阶段(&A):"
        '
        'GridLookUpMaterialType
        '
        Me.GridLookUpMaterialType.Location = New System.Drawing.Point(363, 32)
        Me.GridLookUpMaterialType.Name = "GridLookUpMaterialType"
        Me.GridLookUpMaterialType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpMaterialType.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpMaterialType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpMaterialType.Properties.DisplayMember = "CO_ID"
        Me.GridLookUpMaterialType.Properties.NullText = ""
        Me.GridLookUpMaterialType.Properties.View = Me.GridView4
        Me.GridLookUpMaterialType.Size = New System.Drawing.Size(124, 24)
        Me.GridLookUpMaterialType.TabIndex = 12
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaterialTypeID, Me.MaterialTypeName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'MaterialTypeID
        '
        Me.MaterialTypeID.Caption = "編號"
        Me.MaterialTypeID.FieldName = "TID"
        Me.MaterialTypeID.Name = "MaterialTypeID"
        '
        'MaterialTypeName
        '
        Me.MaterialTypeName.Caption = "名稱"
        Me.MaterialTypeName.FieldName = "TName"
        Me.MaterialTypeName.Name = "MaterialTypeName"
        Me.MaterialTypeName.Visible = True
        Me.MaterialTypeName.VisibleIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(294, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "材  料(&S):"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(611, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(150, 24)
        Me.txtEmail.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(515, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "邮箱地址(&G):"
        '
        'txtAddress1
        '
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Location = New System.Drawing.Point(106, 60)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtAddress1.Properties.Appearance.Options.UseFont = True
        Me.txtAddress1.Size = New System.Drawing.Size(407, 24)
        Me.txtAddress1.TabIndex = 19
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAddress1.Location = New System.Drawing.Point(8, 64)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Padding = New System.Windows.Forms.Padding(1)
        Me.lblAddress1.Size = New System.Drawing.Size(91, 17)
        Me.lblAddress1.TabIndex = 18
        Me.lblAddress1.Text = "地       址(&G):"
        '
        'txtDepartment
        '
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Location = New System.Drawing.Point(851, 60)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtDepartment.Properties.Appearance.Options.UseFont = True
        Me.txtDepartment.Size = New System.Drawing.Size(150, 24)
        Me.txtDepartment.TabIndex = 23
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(760, 64)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Padding = New System.Windows.Forms.Padding(1)
        Me.lblDepartment.Size = New System.Drawing.Size(86, 17)
        Me.lblDepartment.TabIndex = 22
        Me.lblDepartment.Text = "部      門(&B):"
        '
        'txtContacts
        '
        Me.txtContacts.Enabled = False
        Me.txtContacts.Location = New System.Drawing.Point(851, 32)
        Me.txtContacts.Name = "txtContacts"
        Me.txtContacts.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtContacts.Properties.Appearance.Options.UseFont = True
        Me.txtContacts.Size = New System.Drawing.Size(150, 24)
        Me.txtContacts.TabIndex = 17
        '
        'lblContacts
        '
        Me.lblContacts.AutoSize = True
        Me.lblContacts.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblContacts.Location = New System.Drawing.Point(761, 36)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Padding = New System.Windows.Forms.Padding(1)
        Me.lblContacts.Size = New System.Drawing.Size(85, 17)
        Me.lblContacts.TabIndex = 16
        Me.lblContacts.Text = "联 系 人(&E):"
        '
        'dtp_podate
        '
        Me.dtp_podate.EditValue = Nothing
        Me.dtp_podate.Location = New System.Drawing.Point(851, 4)
        Me.dtp_podate.Name = "dtp_podate"
        Me.dtp_podate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_podate.Properties.Appearance.Options.UseFont = True
        Me.dtp_podate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_podate.Size = New System.Drawing.Size(150, 24)
        Me.dtp_podate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(763, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PO 日期(&D):"
        '
        'txt_customerid
        '
        Me.txt_customerid.EditValue = ""
        Me.txt_customerid.Location = New System.Drawing.Point(363, 4)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_customerid.Properties.Appearance.Options.UseFont = True
        Me.txt_customerid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_customerid.Properties.DisplayMember = "SO_CusterID"
        Me.txt_customerid.Properties.NullText = ""
        Me.txt_customerid.Properties.View = Me.GridView2
        Me.txt_customerid.Size = New System.Drawing.Size(150, 24)
        Me.txt_customerid.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn5})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "客戶代号"
        Me.GridColumn2.FieldName = "C_CusterID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 70
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "客戶名称"
        Me.GridColumn3.FieldName = "C_ChsName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 80
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "聯系人"
        Me.GridColumn5.FieldName = "C_Link"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 80
        '
        'txt_customerpo
        '
        Me.txt_customerpo.Location = New System.Drawing.Point(611, 4)
        Me.txt_customerpo.Name = "txt_customerpo"
        Me.txt_customerpo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_customerpo.Properties.Appearance.Options.UseFont = True
        Me.txt_customerpo.Size = New System.Drawing.Size(150, 24)
        Me.txt_customerpo.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(295, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(1)
        Me.Label13.Size = New System.Drawing.Size(66, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "客 戶(&C):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(513, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(1)
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "客        戶P&O:"
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(423, -1)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_company.Properties.Appearance.Options.UseFont = True
        Me.txt_company.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_company.Properties.DisplayMember = "CO_ID"
        Me.txt_company.Properties.NullText = ""
        Me.txt_company.Properties.View = Me.GridLookUpEdit1View
        Me.txt_company.Size = New System.Drawing.Size(150, 24)
        Me.txt_company.TabIndex = 14
        Me.txt_company.Visible = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CO_ID, Me.CO_No})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        Me.CO_ID.Visible = True
        Me.CO_ID.VisibleIndex = 0
        '
        'CO_No
        '
        Me.CO_No.Caption = "公司名"
        Me.CO_No.FieldName = "CO_No"
        Me.CO_No.Name = "CO_No"
        Me.CO_No.Visible = True
        Me.CO_No.VisibleIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "公     司(&G):"
        Me.Label3.Visible = False
        '
        'txtordersid
        '
        Me.txtordersid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtordersid.Enabled = False
        Me.txtordersid.Location = New System.Drawing.Point(850, 5)
        Me.txtordersid.Name = "txtordersid"
        Me.txtordersid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtordersid.Properties.Appearance.Options.UseFont = True
        Me.txtordersid.Properties.ReadOnly = True
        Me.txtordersid.Size = New System.Drawing.Size(151, 24)
        Me.txtordersid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(757, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "订单编号(&I)："
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem1.Text = "新增(&A)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "刪除(&D)"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(890, 15)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 32)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "取消(&E)"
        '
        'Savebutton
        '
        Me.Savebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.Savebutton.Location = New System.Drawing.Point(793, 15)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(75, 32)
        Me.Savebutton.TabIndex = 0
        Me.Savebutton.Text = "确认(&S)"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Savebutton)
        Me.Panel3.Controls.Add(Me.CloseButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 495)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1007, 59)
        Me.Panel3.TabIndex = 4
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 126)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1007, 369)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "审核"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PopupContainerControl2)
        Me.XtraTabPage1.Controls.Add(Me.PopupContainerControl1)
        Me.XtraTabPage1.Controls.Add(Me.Grid1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(998, 337)
        Me.XtraTabPage1.Text = "产品信息"
        '
        'PopupContainerControl2
        '
        Me.PopupContainerControl2.Controls.Add(Me.TreeList1)
        Me.PopupContainerControl2.Location = New System.Drawing.Point(356, 78)
        Me.PopupContainerControl2.Name = "PopupContainerControl2"
        Me.PopupContainerControl2.Size = New System.Drawing.Size(231, 231)
        Me.PopupContainerControl2.TabIndex = 2
        Me.PopupContainerControl2.Text = "PopupContainerControl2"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.KeyFieldName = "M_KEY"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "M_PID"
        Me.TreeList1.Size = New System.Drawing.Size(231, 231)
        Me.TreeList1.TabIndex = 146
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "配件名称"
        Me.TreeListColumn1.FieldName = "M_Name"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "物料编码"
        Me.TreeListColumn2.FieldName = "M_Code"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.Grid2)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(58, 78)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(290, 243)
        Me.PopupContainerControl1.TabIndex = 1
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'Grid2
        '
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView3
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupContainerEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.Grid2.Size = New System.Drawing.Size(290, 243)
        Me.Grid2.TabIndex = 1
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code1, Me.GridColumn11, Me.M_Name, Me.SO_Gauge})
        Me.GridView3.GridControl = Me.Grid2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        'GridColumn11
        '
        Me.GridColumn11.Caption = "客户编号"
        Me.GridColumn11.FieldName = "PM_CusterNO"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        '
        'M_Name
        '
        Me.M_Name.Caption = "配件名称"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Width = 177
        '
        'SO_Gauge
        '
        Me.SO_Gauge.Caption = "规格/型号"
        Me.SO_Gauge.FieldName = "SO_Gauge"
        Me.SO_Gauge.Name = "SO_Gauge"
        Me.SO_Gauge.Width = 196
        '
        'RepositoryItemPopupContainerEdit2
        '
        Me.RepositoryItemPopupContainerEdit2.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit2.Name = "RepositoryItemPopupContainerEdit2"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1, Me.ride_senddate, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemLookUpEdit1, Me.cmb_rank, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemPopupContainerEdit3, Me.RepositoryItemComboBox1})
        Me.Grid1.Size = New System.Drawing.Size(998, 337)
        Me.Grid1.TabIndex = 0
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SO_No, Me.PM_M_Code, Me.M_Code, Me.GridColumn12, Me.GridColumn10, Me.GridColumn1, Me.SO_CusterNo, Me.SO_SendDate, Me.SO_OrderQty, Me.SO_Price, Me.SO_PriceUine, Me.SO_Remark, Me.SO_Rank, Me.AutoID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SO_No
        '
        Me.SO_No.Caption = "流水号"
        Me.SO_No.FieldName = "SO_No"
        Me.SO_No.Name = "SO_No"
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        Me.PM_M_Code.Width = 133
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl1
        '
        'M_Code
        '
        Me.M_Code.Caption = "产品类別"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.Width = 154
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "材料"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn12.FieldName = "TMaterialType"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"钢", "铝"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "配件名称"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemPopupContainerEdit3
        Me.GridColumn10.FieldName = "M_Name"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 96
        '
        'RepositoryItemPopupContainerEdit3
        '
        Me.RepositoryItemPopupContainerEdit3.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit3.Name = "RepositoryItemPopupContainerEdit3"
        Me.RepositoryItemPopupContainerEdit3.PopupControl = Me.PopupContainerControl2
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "产品类别"
        Me.GridColumn1.FieldName = "M_Code_Type"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 123
        '
        'SO_CusterNo
        '
        Me.SO_CusterNo.Caption = "客户编号"
        Me.SO_CusterNo.FieldName = "SO_CusterNo"
        Me.SO_CusterNo.Name = "SO_CusterNo"
        Me.SO_CusterNo.OptionsColumn.ReadOnly = True
        Me.SO_CusterNo.Visible = True
        Me.SO_CusterNo.VisibleIndex = 4
        Me.SO_CusterNo.Width = 97
        '
        'SO_SendDate
        '
        Me.SO_SendDate.Caption = "交货日期"
        Me.SO_SendDate.ColumnEdit = Me.ride_senddate
        Me.SO_SendDate.DisplayFormat.FormatString = "d"
        Me.SO_SendDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SO_SendDate.FieldName = "SO_SendDate"
        Me.SO_SendDate.Name = "SO_SendDate"
        Me.SO_SendDate.Visible = True
        Me.SO_SendDate.VisibleIndex = 5
        Me.SO_SendDate.Width = 123
        '
        'ride_senddate
        '
        Me.ride_senddate.AutoHeight = False
        Me.ride_senddate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ride_senddate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.ride_senddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ride_senddate.EditFormat.FormatString = "yyyy/MM/dd"
        Me.ride_senddate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ride_senddate.Mask.EditMask = "yyyy/MM/dd"
        Me.ride_senddate.Name = "ride_senddate"
        '
        'SO_OrderQty
        '
        Me.SO_OrderQty.Caption = "订单数量"
        Me.SO_OrderQty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.SO_OrderQty.FieldName = "SO_OrderQty"
        Me.SO_OrderQty.Name = "SO_OrderQty"
        Me.SO_OrderQty.Visible = True
        Me.SO_OrderQty.VisibleIndex = 7
        Me.SO_OrderQty.Width = 117
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'SO_Price
        '
        Me.SO_Price.Caption = "单价"
        Me.SO_Price.FieldName = "SO_Price"
        Me.SO_Price.Name = "SO_Price"
        '
        'SO_PriceUine
        '
        Me.SO_PriceUine.Caption = "币別"
        Me.SO_PriceUine.FieldName = "SO_PriceUine"
        Me.SO_PriceUine.Name = "SO_PriceUine"
        '
        'SO_Remark
        '
        Me.SO_Remark.Caption = "备注"
        Me.SO_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.SO_Remark.FieldName = "SO_Remark"
        Me.SO_Remark.Name = "SO_Remark"
        Me.SO_Remark.Visible = True
        Me.SO_Remark.VisibleIndex = 8
        Me.SO_Remark.Width = 274
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'SO_Rank
        '
        Me.SO_Rank.Caption = "订单等级"
        Me.SO_Rank.ColumnEdit = Me.cmb_rank
        Me.SO_Rank.FieldName = "SO_Rank"
        Me.SO_Rank.Name = "SO_Rank"
        Me.SO_Rank.Visible = True
        Me.SO_Rank.VisibleIndex = 6
        Me.SO_Rank.Width = 78
        '
        'cmb_rank
        '
        Me.cmb_rank.AutoHeight = False
        Me.cmb_rank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rank.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmb_rank.Name = "cmb_rank"
        Me.cmb_rank.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "PM_M_Code"
        Me.RepositoryItemGridLookUpEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "PM_M_Code"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "产品编号"
        Me.GridColumn8.FieldName = "PM_M_Code"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "产品类別"
        Me.GridColumn9.FieldName = "M_Code"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.lbl_checkdate)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.lbl_checkuser)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.txt_checkremark)
        Me.XtraTabPage2.Controls.Add(Me.Label4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(998, 337)
        Me.XtraTabPage2.Text = "审核"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "审核(&G)："
        '
        'lbl_checkdate
        '
        Me.lbl_checkdate.AutoSize = True
        Me.lbl_checkdate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_checkdate.Location = New System.Drawing.Point(457, 30)
        Me.lbl_checkdate.Name = "lbl_checkdate"
        Me.lbl_checkdate.Size = New System.Drawing.Size(67, 15)
        Me.lbl_checkdate.TabIndex = 34
        Me.lbl_checkdate.Text = "审核日期"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(369, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "审核日期："
        '
        'lbl_checkuser
        '
        Me.lbl_checkuser.AutoSize = True
        Me.lbl_checkuser.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_checkuser.Location = New System.Drawing.Point(691, 30)
        Me.lbl_checkuser.Name = "lbl_checkuser"
        Me.lbl_checkuser.Size = New System.Drawing.Size(52, 15)
        Me.lbl_checkuser.TabIndex = 32
        Me.lbl_checkuser.Text = "审核人"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(618, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "审核人："
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(81, 22)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "审核"
        Me.CheckEdit1.Size = New System.Drawing.Size(83, 23)
        Me.CheckEdit1.TabIndex = 28
        '
        'txt_checkremark
        '
        Me.txt_checkremark.Location = New System.Drawing.Point(81, 69)
        Me.txt_checkremark.Name = "txt_checkremark"
        Me.txt_checkremark.Size = New System.Drawing.Size(743, 134)
        Me.txt_checkremark.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "备注(&R)："
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "产品编号"
        Me.GridColumn6.FieldName = "PM_M_Code"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "产品类別"
        Me.GridColumn7.FieldName = "M_Code"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "聯系人"
        Me.GridColumn4.FieldName = "C_Link"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 70
        '
        'frmSampleOrdersAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 554)
        Me.Controls.Add(Me.txtordersid)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_company)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmSampleOrdersAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "样办订单管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_OrdersType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpSampType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpMaterialType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_podate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customerid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customerpo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_company.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtordersid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl2.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ride_senddate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_checkremark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtordersid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_customerpo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SO_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ride_senddate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SO_OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SO_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_PriceUine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_checkremark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_customerid As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_checkuser As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtp_podate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_checkdate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_Rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmb_rank As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemPopupContainerEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents PM_M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupContainerControl2 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemPopupContainerEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtContacts As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents txt_company As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpMaterialType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MaterialTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpSampType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MaterialTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CusterNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSampType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMaterialType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSO_SampleID As System.Windows.Forms.Label
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lblOrdersType As System.Windows.Forms.Label
    Friend WithEvents txt_OrdersType As DevExpress.XtraEditors.ComboBoxEdit
End Class
