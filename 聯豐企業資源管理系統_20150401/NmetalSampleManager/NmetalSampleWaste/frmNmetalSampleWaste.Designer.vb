<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleWaste
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
        Me.glu_PS_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_PM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblOutPS_NO = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSE_Remark = New System.Windows.Forms.Label
        Me.dtp_ReDate = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_ReWeight = New DevExpress.XtraEditors.TextEdit
        Me.lblOutWeighing = New System.Windows.Forms.Label
        Me.lblSE_OutD_ID = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.glu_OutDepID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblSE_InD_ID = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        Me.txt_ReNo = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_ReType = New DevExpress.XtraEditors.TextEdit
        Me.glu_PM_Type = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblM_Code = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Remark = New System.Windows.Forms.TextBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_checkdate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_checkuser = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ReCheck = New DevExpress.XtraEditors.CheckEdit
        Me.txt_checkremark = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_ReDepID = New DevExpress.XtraEditors.GridLookUpEdit
        CType(Me.glu_PS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_ReDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ReWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_OutDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ReNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_ReType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_PM_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ReCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_checkremark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_ReDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'glu_PS_NO
        '
        Me.glu_PS_NO.EditValue = ""
        Me.glu_PS_NO.Location = New System.Drawing.Point(80, 107)
        Me.glu_PS_NO.Name = "glu_PS_NO"
        Me.glu_PS_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PS_NO.Properties.Appearance.Options.UseFont = True
        Me.glu_PS_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PS_NO.Properties.DisplayMember = "PS_NoName"
        Me.glu_PS_NO.Properties.ImmediatePopup = True
        Me.glu_PS_NO.Properties.NullText = ""
        Me.glu_PS_NO.Properties.PopupFormWidth = 280
        Me.glu_PS_NO.Properties.ValueMember = "PS_NO"
        Me.glu_PS_NO.Properties.View = Me.GridView5
        Me.glu_PS_NO.Size = New System.Drawing.Size(137, 24)
        Me.glu_PS_NO.TabIndex = 273
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn33, Me.GridColumn13, Me.GridColumn14, Me.GridColumn35, Me.GridColumn37})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "序号"
        Me.GridColumn33.FieldName = "PS_Num"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Width = 195
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "工艺编号"
        Me.GridColumn13.FieldName = "PS_NO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 230
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "工艺名称"
        Me.GridColumn14.FieldName = "PS_Name"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 168
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "工艺编号名称"
        Me.GridColumn35.FieldName = "PS_NoName"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "注意事項"
        Me.GridColumn37.FieldName = "PS_Remark"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Width = 402
        '
        'glu_PM_M_Code
        '
        Me.glu_PM_M_Code.EditValue = ""
        Me.glu_PM_M_Code.Location = New System.Drawing.Point(80, 73)
        Me.glu_PM_M_Code.Name = "glu_PM_M_Code"
        Me.glu_PM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.glu_PM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.glu_PM_M_Code.Properties.NullText = ""
        Me.glu_PM_M_Code.Properties.ValueMember = "PM_M_Code"
        Me.glu_PM_M_Code.Properties.View = Me.GridView8
        Me.glu_PM_M_Code.Size = New System.Drawing.Size(137, 24)
        Me.glu_PM_M_Code.TabIndex = 275
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "产品编号"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "产品名称"
        Me.GridColumn6.FieldName = "pm_m_name"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'lblOutPS_NO
        '
        Me.lblOutPS_NO.AutoSize = True
        Me.lblOutPS_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutPS_NO.ForeColor = System.Drawing.Color.Black
        Me.lblOutPS_NO.Location = New System.Drawing.Point(3, 112)
        Me.lblOutPS_NO.Name = "lblOutPS_NO"
        Me.lblOutPS_NO.Size = New System.Drawing.Size(71, 15)
        Me.lblOutPS_NO.TabIndex = 272
        Me.lblOutPS_NO.Text = "收料工序:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "產品編號:"
        '
        'lblSE_Remark
        '
        Me.lblSE_Remark.AutoSize = True
        Me.lblSE_Remark.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_Remark.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_Remark.ForeColor = System.Drawing.Color.Black
        Me.lblSE_Remark.Location = New System.Drawing.Point(9, 153)
        Me.lblSE_Remark.Name = "lblSE_Remark"
        Me.lblSE_Remark.Size = New System.Drawing.Size(73, 15)
        Me.lblSE_Remark.TabIndex = 268
        Me.lblSE_Remark.Text = "备        注:"
        '
        'dtp_ReDate
        '
        Me.dtp_ReDate.EditValue = Nothing
        Me.dtp_ReDate.Location = New System.Drawing.Point(300, 9)
        Me.dtp_ReDate.Name = "dtp_ReDate"
        Me.dtp_ReDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_ReDate.Properties.Appearance.Options.UseFont = True
        Me.dtp_ReDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_ReDate.Size = New System.Drawing.Size(137, 24)
        Me.dtp_ReDate.TabIndex = 267
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 266
        Me.Label5.Text = "日      期:"
        '
        'txt_ReWeight
        '
        Me.txt_ReWeight.EditValue = "0"
        Me.txt_ReWeight.Location = New System.Drawing.Point(300, 110)
        Me.txt_ReWeight.Name = "txt_ReWeight"
        Me.txt_ReWeight.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_ReWeight.Properties.Appearance.Options.UseFont = True
        Me.txt_ReWeight.Properties.DisplayFormat.FormatString = "########0.0"
        Me.txt_ReWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_ReWeight.Properties.Mask.EditMask = "######0.000"
        Me.txt_ReWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_ReWeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_ReWeight.Size = New System.Drawing.Size(114, 24)
        Me.txt_ReWeight.TabIndex = 263
        '
        'lblOutWeighing
        '
        Me.lblOutWeighing.AutoSize = True
        Me.lblOutWeighing.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutWeighing.ForeColor = System.Drawing.Color.Black
        Me.lblOutWeighing.Location = New System.Drawing.Point(224, 114)
        Me.lblOutWeighing.Name = "lblOutWeighing"
        Me.lblOutWeighing.Size = New System.Drawing.Size(65, 15)
        Me.lblOutWeighing.TabIndex = 260
        Me.lblOutWeighing.Text = "重      量:"
        '
        'lblSE_OutD_ID
        '
        Me.lblSE_OutD_ID.AutoSize = True
        Me.lblSE_OutD_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_OutD_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_OutD_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_OutD_ID.Location = New System.Drawing.Point(5, 45)
        Me.lblSE_OutD_ID.Name = "lblSE_OutD_ID"
        Me.lblSE_OutD_ID.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_OutD_ID.TabIndex = 256
        Me.lblSE_OutD_ID.Text = "廢料來源:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(227, 41)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(69, 15)
        Me.lblType.TabIndex = 261
        Me.lblType.Text = "类       型:"
        '
        'glu_OutDepID
        '
        Me.glu_OutDepID.EditValue = ""
        Me.glu_OutDepID.Location = New System.Drawing.Point(82, 39)
        Me.glu_OutDepID.Name = "glu_OutDepID"
        Me.glu_OutDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_OutDepID.Properties.Appearance.Options.UseFont = True
        Me.glu_OutDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_OutDepID.Properties.DisplayMember = "DepName"
        Me.glu_OutDepID.Properties.NullText = ""
        Me.glu_OutDepID.Properties.PopupFormWidth = 150
        Me.glu_OutDepID.Properties.ValueMember = "DepID"
        Me.glu_OutDepID.Properties.View = Me.GridView6
        Me.glu_OutDepID.Size = New System.Drawing.Size(137, 24)
        Me.glu_OutDepID.TabIndex = 259
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "部门编号"
        Me.GridColumn15.FieldName = "DepID"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 50
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "部门"
        Me.GridColumn16.FieldName = "DepName"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        Me.GridColumn16.Width = 60
        '
        'lblSE_InD_ID
        '
        Me.lblSE_InD_ID.AutoSize = True
        Me.lblSE_InD_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_InD_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_InD_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_InD_ID.Location = New System.Drawing.Point(6, 15)
        Me.lblSE_InD_ID.Name = "lblSE_InD_ID"
        Me.lblSE_InD_ID.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_InD_ID.TabIndex = 257
        Me.lblSE_InD_ID.Text = "登記部门:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(153, 21)
        Me.lblTitle.TabIndex = 83
        Me.lblTitle.Text = "廢料/尾料登記"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(459, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Savebutton
        '
        Me.Savebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Savebutton.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Savebutton.Appearance.Options.UseFont = True
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.Savebutton.Location = New System.Drawing.Point(275, 345)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(75, 32)
        Me.Savebutton.TabIndex = 2
        Me.Savebutton.Text = "保存(&S)"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CloseButton.Appearance.Options.UseFont = True
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(372, 345)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 32)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "退出(&C)"
        '
        'txt_ReNo
        '
        Me.txt_ReNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ReNo.Enabled = False
        Me.txt_ReNo.Location = New System.Drawing.Point(330, 4)
        Me.txt_ReNo.Name = "txt_ReNo"
        Me.txt_ReNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_ReNo.Properties.Appearance.Options.UseFont = True
        Me.txt_ReNo.Properties.ReadOnly = True
        Me.txt_ReNo.Size = New System.Drawing.Size(125, 24)
        Me.txt_ReNo.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "编号:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_ReType)
        Me.GroupBox1.Controls.Add(Me.glu_PM_Type)
        Me.GroupBox1.Controls.Add(Me.lblM_Code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Remark)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblSE_OutD_ID)
        Me.GroupBox1.Controls.Add(Me.glu_PS_NO)
        Me.GroupBox1.Controls.Add(Me.lblType)
        Me.GroupBox1.Controls.Add(Me.lblOutWeighing)
        Me.GroupBox1.Controls.Add(Me.glu_PM_M_Code)
        Me.GroupBox1.Controls.Add(Me.glu_OutDepID)
        Me.GroupBox1.Controls.Add(Me.txt_ReWeight)
        Me.GroupBox1.Controls.Add(Me.lblOutPS_NO)
        Me.GroupBox1.Controls.Add(Me.glu_ReDepID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSE_InD_ID)
        Me.GroupBox1.Controls.Add(Me.lblSE_Remark)
        Me.GroupBox1.Controls.Add(Me.dtp_ReDate)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 268)
        Me.GroupBox1.TabIndex = 277
        Me.GroupBox1.TabStop = False
        '
        'txt_ReType
        '
        Me.txt_ReType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ReType.Location = New System.Drawing.Point(300, 39)
        Me.txt_ReType.Name = "txt_ReType"
        Me.txt_ReType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_ReType.Properties.Appearance.Options.UseFont = True
        Me.txt_ReType.Size = New System.Drawing.Size(137, 24)
        Me.txt_ReType.TabIndex = 280
        '
        'glu_PM_Type
        '
        Me.glu_PM_Type.EditValue = ""
        Me.glu_PM_Type.Location = New System.Drawing.Point(300, 73)
        Me.glu_PM_Type.Name = "glu_PM_Type"
        Me.glu_PM_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PM_Type.Properties.Appearance.Options.UseFont = True
        Me.glu_PM_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PM_Type.Properties.DisplayMember = "Type3ID"
        Me.glu_PM_Type.Properties.NullText = ""
        Me.glu_PM_Type.Properties.ValueMember = "Type3ID"
        Me.glu_PM_Type.Properties.View = Me.GridView3
        Me.glu_PM_Type.Size = New System.Drawing.Size(137, 24)
        Me.glu_PM_Type.TabIndex = 279
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "產品類型"
        Me.GridColumn8.FieldName = "Type3ID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "AutoID"
        Me.GridColumn9.FieldName = "AutoID"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'lblM_Code
        '
        Me.lblM_Code.AutoSize = True
        Me.lblM_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblM_Code.CausesValidation = False
        Me.lblM_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblM_Code.ForeColor = System.Drawing.Color.Black
        Me.lblM_Code.Location = New System.Drawing.Point(223, 78)
        Me.lblM_Code.Name = "lblM_Code"
        Me.lblM_Code.Size = New System.Drawing.Size(71, 15)
        Me.lblM_Code.TabIndex = 278
        Me.lblM_Code.Text = "产品类型:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(420, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 277
        Me.Label3.Text = "g"
        '
        'txt_Remark
        '
        Me.txt_Remark.Font = New System.Drawing.Font("新宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Remark.Location = New System.Drawing.Point(82, 152)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(362, 105)
        Me.txt_Remark.TabIndex = 276
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 34)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(460, 301)
        Me.XtraTabControl1.TabIndex = 278
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(451, 269)
        Me.XtraTabPage1.Text = "登記"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(451, 269)
        Me.XtraTabPage2.Text = "審核"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_checkdate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbl_checkuser)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ReCheck)
        Me.GroupBox2.Controls.Add(Me.txt_checkremark)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 266)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "审       核:"
        '
        'lbl_checkdate
        '
        Me.lbl_checkdate.AutoSize = True
        Me.lbl_checkdate.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_checkdate.Location = New System.Drawing.Point(91, 68)
        Me.lbl_checkdate.Name = "lbl_checkdate"
        Me.lbl_checkdate.Size = New System.Drawing.Size(67, 15)
        Me.lbl_checkdate.TabIndex = 42
        Me.lbl_checkdate.Text = "审核日期"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "日      期："
        '
        'lbl_checkuser
        '
        Me.lbl_checkuser.AutoSize = True
        Me.lbl_checkuser.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_checkuser.Location = New System.Drawing.Point(342, 68)
        Me.lbl_checkuser.Name = "lbl_checkuser"
        Me.lbl_checkuser.Size = New System.Drawing.Size(52, 15)
        Me.lbl_checkuser.TabIndex = 40
        Me.lbl_checkuser.Text = "审核人"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "审 核 人："
        '
        'ReCheck
        '
        Me.ReCheck.Location = New System.Drawing.Point(87, 24)
        Me.ReCheck.Name = "ReCheck"
        Me.ReCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ReCheck.Properties.Appearance.Options.UseFont = True
        Me.ReCheck.Properties.Caption = "审核"
        Me.ReCheck.Size = New System.Drawing.Size(83, 23)
        Me.ReCheck.TabIndex = 36
        '
        'txt_checkremark
        '
        Me.txt_checkremark.Location = New System.Drawing.Point(79, 111)
        Me.txt_checkremark.Name = "txt_checkremark"
        Me.txt_checkremark.Size = New System.Drawing.Size(364, 134)
        Me.txt_checkremark.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "备    註:"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "部门编号"
        Me.GridColumn1.FieldName = "DepID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "部门"
        Me.GridColumn2.FieldName = "DepName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 60
        '
        'glu_ReDepID
        '
        Me.glu_ReDepID.EditValue = ""
        Me.glu_ReDepID.Enabled = False
        Me.glu_ReDepID.Location = New System.Drawing.Point(83, 9)
        Me.glu_ReDepID.Name = "glu_ReDepID"
        Me.glu_ReDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_ReDepID.Properties.Appearance.Options.UseFont = True
        Me.glu_ReDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_ReDepID.Properties.DisplayMember = "DepName"
        Me.glu_ReDepID.Properties.NullText = ""
        Me.glu_ReDepID.Properties.PopupFormWidth = 150
        Me.glu_ReDepID.Properties.ValueMember = "DepID"
        Me.glu_ReDepID.Properties.View = Me.GridView1
        Me.glu_ReDepID.Size = New System.Drawing.Size(136, 24)
        Me.glu_ReDepID.TabIndex = 258
        '
        'frmNmetalSampleWaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(459, 389)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.txt_ReNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampleWaste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "廢料/尾料登記"
        CType(Me.glu_PS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_ReDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ReWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_OutDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ReNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_ReType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_PM_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ReCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_checkremark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_ReDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_ReWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOutWeighing As System.Windows.Forms.Label
    Friend WithEvents lblSE_OutD_ID As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents glu_OutDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblSE_InD_ID As System.Windows.Forms.Label
    Friend WithEvents dtp_ReDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ReNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSE_Remark As System.Windows.Forms.Label
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents glu_PS_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glu_PM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblOutPS_NO As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Remark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_checkdate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_checkuser As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ReCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_checkremark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents glu_PM_Type As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblM_Code As System.Windows.Forms.Label
    Friend WithEvents txt_ReType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents glu_ReDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
