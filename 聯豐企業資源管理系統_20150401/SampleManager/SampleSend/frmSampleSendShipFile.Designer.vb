<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleSendShipFile
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtHandle = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtProject = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAddressee = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLC = New DevExpress.XtraEditors.TextEdit
        Me.lblLC = New System.Windows.Forms.Label
        Me.txtQPN = New DevExpress.XtraEditors.TextEdit
        Me.lblQPN = New System.Windows.Forms.Label
        Me.txtPalletID = New DevExpress.XtraEditors.TextEdit
        Me.lblPalletID = New System.Windows.Forms.Label
        Me.txtSP_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtWeighing = New DevExpress.XtraEditors.TextEdit
        Me.lblSP_ID = New System.Windows.Forms.Label
        Me.txtSP_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtCode_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.txtPartName = New DevExpress.XtraEditors.TextEdit
        Me.txtPM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.txtCO_ID = New DevExpress.XtraEditors.TextEdit
        Me.lblSP_Qty = New System.Windows.Forms.Label
        Me.lblWeighing = New System.Windows.Forms.Label
        Me.lblCode_ID = New System.Windows.Forms.Label
        Me.lblBoxID = New System.Windows.Forms.Label
        Me.lblPartName = New System.Windows.Forms.Label
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.lblCO_ID = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtHandle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddressee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPalletID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSP_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeighing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSP_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 21)
        Me.lblTitle.TabIndex = 88
        Me.lblTitle.Text = "出货标签"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 32)
        Me.Panel2.TabIndex = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtHandle)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtProject)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtAddressee)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLC)
        Me.GroupBox1.Controls.Add(Me.lblLC)
        Me.GroupBox1.Controls.Add(Me.txtQPN)
        Me.GroupBox1.Controls.Add(Me.lblQPN)
        Me.GroupBox1.Controls.Add(Me.txtPalletID)
        Me.GroupBox1.Controls.Add(Me.lblPalletID)
        Me.GroupBox1.Controls.Add(Me.txtSP_ID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtWeighing)
        Me.GroupBox1.Controls.Add(Me.lblSP_ID)
        Me.GroupBox1.Controls.Add(Me.txtSP_Qty)
        Me.GroupBox1.Controls.Add(Me.txtCode_ID)
        Me.GroupBox1.Controls.Add(Me.txtBoxID)
        Me.GroupBox1.Controls.Add(Me.txtPartName)
        Me.GroupBox1.Controls.Add(Me.txtPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.txtCO_ID)
        Me.GroupBox1.Controls.Add(Me.lblSP_Qty)
        Me.GroupBox1.Controls.Add(Me.lblWeighing)
        Me.GroupBox1.Controls.Add(Me.lblCode_ID)
        Me.GroupBox1.Controls.Add(Me.lblBoxID)
        Me.GroupBox1.Controls.Add(Me.lblPartName)
        Me.GroupBox1.Controls.Add(Me.lblPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.lblCO_ID)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本数据"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.CausesValidation = False
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(561, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 15)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.CausesValidation = False
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(278, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 15)
        Me.Label13.TabIndex = 184
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.CausesValidation = False
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(561, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 15)
        Me.Label12.TabIndex = 183
        Me.Label12.Text = "*"
        '
        'txtHandle
        '
        Me.txtHandle.Location = New System.Drawing.Point(383, 139)
        Me.txtHandle.Name = "txtHandle"
        Me.txtHandle.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtHandle.Properties.Appearance.Options.UseFont = True
        Me.txtHandle.Properties.MaxLength = 50
        Me.txtHandle.Size = New System.Drawing.Size(173, 24)
        Me.txtHandle.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(294, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "跟  办  人(&H):"
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(102, 139)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtProject.Properties.Appearance.Options.UseFont = True
        Me.txtProject.Properties.MaxLength = 50
        Me.txtProject.Size = New System.Drawing.Size(172, 24)
        Me.txtProject.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.CausesValidation = False
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "项  目  人(&X):"
        '
        'txtAddressee
        '
        Me.txtAddressee.Location = New System.Drawing.Point(383, 114)
        Me.txtAddressee.Name = "txtAddressee"
        Me.txtAddressee.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAddressee.Properties.Appearance.Options.UseFont = True
        Me.txtAddressee.Properties.MaxLength = 50
        Me.txtAddressee.Size = New System.Drawing.Size(173, 24)
        Me.txtAddressee.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.CausesValidation = False
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(282, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "客户收件人(&S):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.CausesValidation = False
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(207, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 15)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.CausesValidation = False
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(278, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 15)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.CausesValidation = False
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(278, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.CausesValidation = False
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(561, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(278, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(561, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(278, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "*"
        '
        'txtLC
        '
        Me.txtLC.Location = New System.Drawing.Point(102, 114)
        Me.txtLC.Name = "txtLC"
        Me.txtLC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtLC.Properties.Appearance.Options.UseFont = True
        Me.txtLC.Properties.MaxLength = 50
        Me.txtLC.Size = New System.Drawing.Size(172, 24)
        Me.txtLC.TabIndex = 17
        '
        'lblLC
        '
        Me.lblLC.AutoSize = True
        Me.lblLC.BackColor = System.Drawing.Color.Transparent
        Me.lblLC.CausesValidation = False
        Me.lblLC.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblLC.ForeColor = System.Drawing.Color.Black
        Me.lblLC.Location = New System.Drawing.Point(14, 119)
        Me.lblLC.Name = "lblLC"
        Me.lblLC.Size = New System.Drawing.Size(90, 15)
        Me.lblLC.TabIndex = 16
        Me.lblLC.Text = "付款方式(&T):"
        '
        'txtQPN
        '
        Me.txtQPN.Location = New System.Drawing.Point(383, 89)
        Me.txtQPN.Name = "txtQPN"
        Me.txtQPN.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtQPN.Properties.Appearance.Options.UseFont = True
        Me.txtQPN.Properties.MaxLength = 50
        Me.txtQPN.Size = New System.Drawing.Size(173, 24)
        Me.txtQPN.TabIndex = 15
        '
        'lblQPN
        '
        Me.lblQPN.AutoSize = True
        Me.lblQPN.BackColor = System.Drawing.Color.Transparent
        Me.lblQPN.CausesValidation = False
        Me.lblQPN.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblQPN.ForeColor = System.Drawing.Color.Black
        Me.lblQPN.Location = New System.Drawing.Point(294, 94)
        Me.lblQPN.Name = "lblQPN"
        Me.lblQPN.Size = New System.Drawing.Size(92, 15)
        Me.lblQPN.TabIndex = 14
        Me.lblQPN.Text = "质        检(&R):"
        '
        'txtPalletID
        '
        Me.txtPalletID.Location = New System.Drawing.Point(383, 64)
        Me.txtPalletID.Name = "txtPalletID"
        Me.txtPalletID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPalletID.Properties.Appearance.Options.UseFont = True
        Me.txtPalletID.Properties.MaxLength = 50
        Me.txtPalletID.Size = New System.Drawing.Size(173, 24)
        Me.txtPalletID.TabIndex = 11
        '
        'lblPalletID
        '
        Me.lblPalletID.AutoSize = True
        Me.lblPalletID.BackColor = System.Drawing.Color.Transparent
        Me.lblPalletID.CausesValidation = False
        Me.lblPalletID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPalletID.ForeColor = System.Drawing.Color.Black
        Me.lblPalletID.Location = New System.Drawing.Point(295, 69)
        Me.lblPalletID.Name = "lblPalletID"
        Me.lblPalletID.Size = New System.Drawing.Size(91, 15)
        Me.lblPalletID.TabIndex = 10
        Me.lblPalletID.Text = "托  盘  号(&R):"
        '
        'txtSP_ID
        '
        Me.txtSP_ID.Enabled = False
        Me.txtSP_ID.Location = New System.Drawing.Point(102, 14)
        Me.txtSP_ID.Name = "txtSP_ID"
        Me.txtSP_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSP_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSP_ID.Size = New System.Drawing.Size(172, 24)
        Me.txtSP_ID.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.CausesValidation = False
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(490, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "g"
        '
        'txtWeighing
        '
        Me.txtWeighing.EditValue = "0"
        Me.txtWeighing.Location = New System.Drawing.Point(383, 164)
        Me.txtWeighing.Name = "txtWeighing"
        Me.txtWeighing.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWeighing.Properties.Appearance.Options.UseFont = True
        Me.txtWeighing.Properties.DisplayFormat.FormatString = "########0.00"
        Me.txtWeighing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWeighing.Properties.Mask.EditMask = "######0.00"
        Me.txtWeighing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtWeighing.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtWeighing.Size = New System.Drawing.Size(101, 24)
        Me.txtWeighing.TabIndex = 27
        '
        'lblSP_ID
        '
        Me.lblSP_ID.AutoSize = True
        Me.lblSP_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSP_ID.CausesValidation = False
        Me.lblSP_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSP_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSP_ID.Location = New System.Drawing.Point(13, 19)
        Me.lblSP_ID.Name = "lblSP_ID"
        Me.lblSP_ID.Size = New System.Drawing.Size(91, 15)
        Me.lblSP_ID.TabIndex = 0
        Me.lblSP_ID.Text = "寄送单号(&Q):"
        '
        'txtSP_Qty
        '
        Me.txtSP_Qty.EditValue = "0"
        Me.txtSP_Qty.Location = New System.Drawing.Point(102, 164)
        Me.txtSP_Qty.Name = "txtSP_Qty"
        Me.txtSP_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSP_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtSP_Qty.Properties.DisplayFormat.FormatString = "######0"
        Me.txtSP_Qty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSP_Qty.Properties.Mask.EditMask = "######0"
        Me.txtSP_Qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSP_Qty.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSP_Qty.Size = New System.Drawing.Size(101, 24)
        Me.txtSP_Qty.TabIndex = 25
        '
        'txtCode_ID
        '
        Me.txtCode_ID.Location = New System.Drawing.Point(102, 89)
        Me.txtCode_ID.Name = "txtCode_ID"
        Me.txtCode_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCode_ID.Properties.Appearance.Options.UseFont = True
        Me.txtCode_ID.Properties.MaxLength = 50
        Me.txtCode_ID.Size = New System.Drawing.Size(172, 24)
        Me.txtCode_ID.TabIndex = 13
        '
        'txtBoxID
        '
        Me.txtBoxID.Location = New System.Drawing.Point(102, 64)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtBoxID.Properties.Appearance.Options.UseFont = True
        Me.txtBoxID.Properties.MaxLength = 50
        Me.txtBoxID.Size = New System.Drawing.Size(172, 24)
        Me.txtBoxID.TabIndex = 9
        '
        'txtPartName
        '
        Me.txtPartName.Location = New System.Drawing.Point(383, 39)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPartName.Properties.Appearance.Options.UseFont = True
        Me.txtPartName.Properties.MaxLength = 50
        Me.txtPartName.Size = New System.Drawing.Size(173, 24)
        Me.txtPartName.TabIndex = 7
        '
        'txtPM_M_Code
        '
        Me.txtPM_M_Code.Location = New System.Drawing.Point(102, 39)
        Me.txtPM_M_Code.Name = "txtPM_M_Code"
        Me.txtPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_M_Code.Properties.MaxLength = 30
        Me.txtPM_M_Code.Size = New System.Drawing.Size(172, 24)
        Me.txtPM_M_Code.TabIndex = 5
        '
        'txtCO_ID
        '
        Me.txtCO_ID.EditValue = "MG"
        Me.txtCO_ID.Location = New System.Drawing.Point(383, 14)
        Me.txtCO_ID.Name = "txtCO_ID"
        Me.txtCO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ID.Properties.MaxLength = 30
        Me.txtCO_ID.Size = New System.Drawing.Size(173, 24)
        Me.txtCO_ID.TabIndex = 3
        '
        'lblSP_Qty
        '
        Me.lblSP_Qty.AutoSize = True
        Me.lblSP_Qty.BackColor = System.Drawing.Color.Transparent
        Me.lblSP_Qty.CausesValidation = False
        Me.lblSP_Qty.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSP_Qty.ForeColor = System.Drawing.Color.Black
        Me.lblSP_Qty.Location = New System.Drawing.Point(11, 169)
        Me.lblSP_Qty.Name = "lblSP_Qty"
        Me.lblSP_Qty.Size = New System.Drawing.Size(92, 15)
        Me.lblSP_Qty.TabIndex = 24
        Me.lblSP_Qty.Text = "数       量(&M):"
        '
        'lblWeighing
        '
        Me.lblWeighing.AutoSize = True
        Me.lblWeighing.BackColor = System.Drawing.Color.Transparent
        Me.lblWeighing.CausesValidation = False
        Me.lblWeighing.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWeighing.ForeColor = System.Drawing.Color.Black
        Me.lblWeighing.Location = New System.Drawing.Point(294, 169)
        Me.lblWeighing.Name = "lblWeighing"
        Me.lblWeighing.Size = New System.Drawing.Size(92, 15)
        Me.lblWeighing.TabIndex = 26
        Me.lblWeighing.Text = "重       量(&W):"
        '
        'lblCode_ID
        '
        Me.lblCode_ID.AutoSize = True
        Me.lblCode_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblCode_ID.CausesValidation = False
        Me.lblCode_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCode_ID.ForeColor = System.Drawing.Color.Black
        Me.lblCode_ID.Location = New System.Drawing.Point(12, 94)
        Me.lblCode_ID.Name = "lblCode_ID"
        Me.lblCode_ID.Size = New System.Drawing.Size(92, 15)
        Me.lblCode_ID.TabIndex = 12
        Me.lblCode_ID.Text = "条        码(&B):"
        '
        'lblBoxID
        '
        Me.lblBoxID.AutoSize = True
        Me.lblBoxID.BackColor = System.Drawing.Color.Transparent
        Me.lblBoxID.CausesValidation = False
        Me.lblBoxID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBoxID.ForeColor = System.Drawing.Color.Black
        Me.lblBoxID.Location = New System.Drawing.Point(11, 69)
        Me.lblBoxID.Name = "lblBoxID"
        Me.lblBoxID.Size = New System.Drawing.Size(93, 15)
        Me.lblBoxID.TabIndex = 8
        Me.lblBoxID.Text = "箱        号(&H):"
        '
        'lblPartName
        '
        Me.lblPartName.AutoSize = True
        Me.lblPartName.BackColor = System.Drawing.Color.Transparent
        Me.lblPartName.CausesValidation = False
        Me.lblPartName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPartName.ForeColor = System.Drawing.Color.Black
        Me.lblPartName.Location = New System.Drawing.Point(295, 44)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(91, 15)
        Me.lblPartName.TabIndex = 6
        Me.lblPartName.Text = "产品名称(&N):"
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblPM_M_Code.CausesValidation = False
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.ForeColor = System.Drawing.Color.Black
        Me.lblPM_M_Code.Location = New System.Drawing.Point(15, 44)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(89, 15)
        Me.lblPM_M_Code.TabIndex = 4
        Me.lblPM_M_Code.Text = "产品编号(&P):"
        '
        'lblCO_ID
        '
        Me.lblCO_ID.AutoSize = True
        Me.lblCO_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblCO_ID.CausesValidation = False
        Me.lblCO_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCO_ID.ForeColor = System.Drawing.Color.Black
        Me.lblCO_ID.Location = New System.Drawing.Point(296, 19)
        Me.lblCO_ID.Name = "lblCO_ID"
        Me.lblCO_ID.Size = New System.Drawing.Size(90, 15)
        Me.lblCO_ID.TabIndex = 2
        Me.lblCO_ID.Text = "公司代号(&C):"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(306, 242)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(81, 27)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "取消(&E)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.cmdSave.Location = New System.Drawing.Point(197, 242)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(81, 27)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "确认(&S)"
        '
        'frmSampleSendShipFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 279)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampleSendShipFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出货标签"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtHandle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddressee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPalletID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSP_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeighing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSP_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPalletID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPalletID As System.Windows.Forms.Label
    Friend WithEvents txtSP_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWeighing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSP_ID As System.Windows.Forms.Label
    Friend WithEvents txtSP_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPartName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSP_Qty As System.Windows.Forms.Label
    Friend WithEvents lblWeighing As System.Windows.Forms.Label
    Friend WithEvents lblCode_ID As System.Windows.Forms.Label
    Friend WithEvents lblBoxID As System.Windows.Forms.Label
    Friend WithEvents lblPartName As System.Windows.Forms.Label
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents lblCO_ID As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLC As System.Windows.Forms.Label
    Friend WithEvents txtQPN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQPN As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHandle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddressee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
