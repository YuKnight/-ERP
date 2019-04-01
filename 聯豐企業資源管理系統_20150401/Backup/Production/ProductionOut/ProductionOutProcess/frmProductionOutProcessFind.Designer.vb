<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionOutProcessFind
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtePO_OutDateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dtePO_OutDateBegin = New DevExpress.XtraEditors.DateEdit
        Me.gluS_SupplierName = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPS_Name = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPM_Type = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPO_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lblPO_ID = New DevExpress.XtraEditors.LabelControl
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtePO_OutDateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePO_OutDateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluS_SupplierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPS_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtePO_OutDateEnd)
        Me.GroupBox1.Controls.Add(Me.dtePO_OutDateBegin)
        Me.GroupBox1.Controls.Add(Me.gluS_SupplierName)
        Me.GroupBox1.Controls.Add(Me.gluPS_Name)
        Me.GroupBox1.Controls.Add(Me.gluPM_Type)
        Me.GroupBox1.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.txtPO_ID)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.lblPO_ID)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'dtePO_OutDateEnd
        '
        Me.dtePO_OutDateEnd.EditValue = Nothing
        Me.dtePO_OutDateEnd.Location = New System.Drawing.Point(152, 190)
        Me.dtePO_OutDateEnd.Name = "dtePO_OutDateEnd"
        Me.dtePO_OutDateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtePO_OutDateEnd.Properties.Appearance.Options.UseFont = True
        Me.dtePO_OutDateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePO_OutDateEnd.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dtePO_OutDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePO_OutDateEnd.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dtePO_OutDateEnd.Size = New System.Drawing.Size(120, 22)
        Me.dtePO_OutDateEnd.TabIndex = 12
        '
        'dtePO_OutDateBegin
        '
        Me.dtePO_OutDateBegin.EditValue = Nothing
        Me.dtePO_OutDateBegin.Location = New System.Drawing.Point(152, 162)
        Me.dtePO_OutDateBegin.Name = "dtePO_OutDateBegin"
        Me.dtePO_OutDateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtePO_OutDateBegin.Properties.Appearance.Options.UseFont = True
        Me.dtePO_OutDateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePO_OutDateBegin.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dtePO_OutDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePO_OutDateBegin.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dtePO_OutDateBegin.Size = New System.Drawing.Size(120, 22)
        Me.dtePO_OutDateBegin.TabIndex = 11
        '
        'gluS_SupplierName
        '
        Me.gluS_SupplierName.Location = New System.Drawing.Point(122, 134)
        Me.gluS_SupplierName.Name = "gluS_SupplierName"
        Me.gluS_SupplierName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluS_SupplierName.Properties.Appearance.Options.UseFont = True
        Me.gluS_SupplierName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluS_SupplierName.Properties.NullText = ""
        Me.gluS_SupplierName.Properties.PopupFormWidth = 200
        Me.gluS_SupplierName.Properties.View = Me.GridView3
        Me.gluS_SupplierName.Size = New System.Drawing.Size(150, 22)
        Me.gluS_SupplierName.TabIndex = 9
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.OptionsColumn.ReadOnly = True
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        Me.S_Supplier.Width = 180
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        Me.S_SupplierName.Width = 201
        '
        'gluPS_Name
        '
        Me.gluPS_Name.Location = New System.Drawing.Point(122, 106)
        Me.gluPS_Name.Name = "gluPS_Name"
        Me.gluPS_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPS_Name.Properties.Appearance.Options.UseFont = True
        Me.gluPS_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPS_Name.Properties.NullText = ""
        Me.gluPS_Name.Properties.PopupFormWidth = 200
        Me.gluPS_Name.Properties.View = Me.GridView2
        Me.gluPS_Name.Size = New System.Drawing.Size(150, 22)
        Me.gluPS_Name.TabIndex = 7
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.PS_Name})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序編號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 0
        '
        'gluPM_Type
        '
        Me.gluPM_Type.Location = New System.Drawing.Point(122, 78)
        Me.gluPM_Type.Name = "gluPM_Type"
        Me.gluPM_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_Type.Properties.Appearance.Options.UseFont = True
        Me.gluPM_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_Type.Properties.NullText = ""
        Me.gluPM_Type.Properties.PopupFormWidth = 200
        Me.gluPM_Type.Properties.View = Me.GridView1
        Me.gluPM_Type.Size = New System.Drawing.Size(150, 22)
        Me.gluPM_Type.TabIndex = 5
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_Type})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.ReadOnly = True
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 0
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.Location = New System.Drawing.Point(122, 50)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 200
        Me.gluPM_M_Code.Properties.View = Me.GridLookUpEdit1View
        Me.gluPM_M_Code.Size = New System.Drawing.Size(150, 22)
        Me.gluPM_M_Code.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code, Me.PM_JiYu})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        '
        'txtPO_ID
        '
        Me.txtPO_ID.Location = New System.Drawing.Point(122, 22)
        Me.txtPO_ID.Name = "txtPO_ID"
        Me.txtPO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtPO_ID.Size = New System.Drawing.Size(150, 22)
        Me.txtPO_ID.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(128, 194)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "到"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(128, 166)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "從"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(17, 166)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "外  發  日  期(&D)："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 137)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "供 應 商 名 稱(&P)："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(17, 109)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "工  序  名  稱(&G)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(17, 81)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "配  件  名  稱(&N)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 53)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "產  品  編  號(&M)："
        '
        'lblPO_ID
        '
        Me.lblPO_ID.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPO_ID.Appearance.Options.UseFont = True
        Me.lblPO_ID.Appearance.Options.UseTextOptions = True
        Me.lblPO_ID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPO_ID.Location = New System.Drawing.Point(14, 25)
        Me.lblPO_ID.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.lblPO_ID.Name = "lblPO_ID"
        Me.lblPO_ID.Size = New System.Drawing.Size(103, 13)
        Me.lblPO_ID.TabIndex = 0
        Me.lblPO_ID.Text = "外發加工單號(&I)："
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(176, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "取消(&C)"
        '
        'cmdOK
        '
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdOK.Location = New System.Drawing.Point(50, 241)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(80, 28)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "查詢(&F)"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.cmdCancel)
        Me.PanelControl1.Controls.Add(Me.cmdOK)
        Me.PanelControl1.Location = New System.Drawing.Point(2, -1)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Size = New System.Drawing.Size(306, 278)
        Me.PanelControl1.TabIndex = 2
        Me.PanelControl1.Text = "PanelControl1"
        '
        'frmProductionOutProcessFind
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(310, 279)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionOutProcessFind"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "外發加工單查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtePO_OutDateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePO_OutDateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluS_SupplierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPS_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPO_ID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluPS_Name As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluPM_Type As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluS_SupplierName As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtePO_OutDateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtePO_OutDateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
