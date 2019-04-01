<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareQualityAdd
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.dteAddDate = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWQ_Code = New DevExpress.XtraEditors.TextEdit
        Me.bteWQ_Dpt = New DevExpress.XtraEditors.ButtonEdit
        Me.bteM_Code = New DevExpress.XtraEditors.ButtonEdit
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Gauge = New DevExpress.XtraEditors.MemoEdit
        Me.txtWO_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtWO_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtWQ_UserName = New DevExpress.XtraEditors.TextEdit
        Me.txtWQ_Description = New DevExpress.XtraEditors.MemoEdit
        Me.txtPS_Opinion = New DevExpress.XtraEditors.MemoEdit
        Me.txtPS_UserName = New DevExpress.XtraEditors.TextEdit
        Me.txtACC_Opinion = New DevExpress.XtraEditors.MemoEdit
        Me.lblM_Unit = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtCostAcc_Opinion = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtPD_Opinion = New DevExpress.XtraEditors.MemoEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteAddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtWQ_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bteWQ_Dpt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bteM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWO_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWQ_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWQ_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPS_Opinion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPS_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtACC_Opinion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostAcc_Opinion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPD_Opinion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(741, 36)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Navy
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(219, 21)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "物料品質反饋單-添加"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.cmdSave.Location = New System.Drawing.Point(502, 561)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(602, 561)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "取消(&C)"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl11.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseBackColor = True
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(395, 151)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl11.TabIndex = 17
        Me.LabelControl11.Text = "添加日期(&D)："
        '
        'dteAddDate
        '
        Me.dteAddDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dteAddDate.EditValue = Nothing
        Me.dteAddDate.Enabled = False
        Me.dteAddDate.Location = New System.Drawing.Point(493, 147)
        Me.dteAddDate.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.dteAddDate.Name = "dteAddDate"
        Me.dteAddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteAddDate.Properties.Appearance.Options.UseFont = True
        Me.dteAddDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteAddDate.Size = New System.Drawing.Size(180, 24)
        Me.dteAddDate.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 600)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWQ_Code)
        Me.GroupBox1.Controls.Add(Me.bteWQ_Dpt)
        Me.GroupBox1.Controls.Add(Me.bteM_Code)
        Me.GroupBox1.Controls.Add(Me.txtM_Name)
        Me.GroupBox1.Controls.Add(Me.txtM_Gauge)
        Me.GroupBox1.Controls.Add(Me.txtWO_ID)
        Me.GroupBox1.Controls.Add(Me.txtWO_Qty)
        Me.GroupBox1.Controls.Add(Me.txtWQ_UserName)
        Me.GroupBox1.Controls.Add(Me.dteAddDate)
        Me.GroupBox1.Controls.Add(Me.txtWQ_Description)
        Me.GroupBox1.Controls.Add(Me.txtPD_Opinion)
        Me.GroupBox1.Controls.Add(Me.txtCostAcc_Opinion)
        Me.GroupBox1.Controls.Add(Me.txtPS_Opinion)
        Me.GroupBox1.Controls.Add(Me.txtPS_UserName)
        Me.GroupBox1.Controls.Add(Me.txtACC_Opinion)
        Me.GroupBox1.Controls.Add(Me.lblM_Unit)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.LabelControl15)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 544)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtWQ_Code
        '
        Me.txtWQ_Code.EditValue = ""
        Me.txtWQ_Code.Location = New System.Drawing.Point(148, 19)
        Me.txtWQ_Code.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtWQ_Code.Name = "txtWQ_Code"
        Me.txtWQ_Code.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtWQ_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWQ_Code.Properties.Appearance.Options.UseBackColor = True
        Me.txtWQ_Code.Properties.Appearance.Options.UseFont = True
        Me.txtWQ_Code.Properties.ReadOnly = True
        Me.txtWQ_Code.Size = New System.Drawing.Size(180, 24)
        Me.txtWQ_Code.TabIndex = 2
        '
        'bteWQ_Dpt
        '
        Me.bteWQ_Dpt.Location = New System.Drawing.Point(148, 83)
        Me.bteWQ_Dpt.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.bteWQ_Dpt.Name = "bteWQ_Dpt"
        Me.bteWQ_Dpt.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteWQ_Dpt.Properties.Appearance.Options.UseFont = True
        Me.bteWQ_Dpt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bteWQ_Dpt.Properties.ReadOnly = True
        Me.bteWQ_Dpt.Size = New System.Drawing.Size(180, 24)
        Me.bteWQ_Dpt.TabIndex = 10
        '
        'bteM_Code
        '
        Me.bteM_Code.Location = New System.Drawing.Point(493, 19)
        Me.bteM_Code.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.bteM_Code.Name = "bteM_Code"
        Me.bteM_Code.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.bteM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteM_Code.Properties.Appearance.Options.UseBackColor = True
        Me.bteM_Code.Properties.Appearance.Options.UseFont = True
        Me.bteM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bteM_Code.Properties.ReadOnly = True
        Me.bteM_Code.Size = New System.Drawing.Size(180, 24)
        Me.bteM_Code.TabIndex = 4
        '
        'txtM_Name
        '
        Me.txtM_Name.Location = New System.Drawing.Point(148, 51)
        Me.txtM_Name.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseBackColor = True
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Properties.ReadOnly = True
        Me.txtM_Name.Size = New System.Drawing.Size(180, 24)
        Me.txtM_Name.TabIndex = 6
        '
        'txtM_Gauge
        '
        Me.txtM_Gauge.Location = New System.Drawing.Point(493, 51)
        Me.txtM_Gauge.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtM_Gauge.Name = "txtM_Gauge"
        Me.txtM_Gauge.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtM_Gauge.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Gauge.Properties.Appearance.Options.UseBackColor = True
        Me.txtM_Gauge.Properties.Appearance.Options.UseFont = True
        Me.txtM_Gauge.Properties.ReadOnly = True
        Me.txtM_Gauge.Size = New System.Drawing.Size(180, 56)
        Me.txtM_Gauge.TabIndex = 8
        '
        'txtWO_ID
        '
        Me.txtWO_ID.Location = New System.Drawing.Point(148, 115)
        Me.txtWO_ID.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtWO_ID.Name = "txtWO_ID"
        Me.txtWO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtWO_ID.Size = New System.Drawing.Size(180, 24)
        Me.txtWO_ID.TabIndex = 12
        '
        'txtWO_Qty
        '
        Me.txtWO_Qty.Location = New System.Drawing.Point(493, 115)
        Me.txtWO_Qty.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtWO_Qty.Name = "txtWO_Qty"
        Me.txtWO_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWO_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtWO_Qty.Size = New System.Drawing.Size(132, 24)
        Me.txtWO_Qty.TabIndex = 14
        '
        'txtWQ_UserName
        '
        Me.txtWQ_UserName.Location = New System.Drawing.Point(148, 147)
        Me.txtWQ_UserName.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtWQ_UserName.Name = "txtWQ_UserName"
        Me.txtWQ_UserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWQ_UserName.Properties.Appearance.Options.UseFont = True
        Me.txtWQ_UserName.Size = New System.Drawing.Size(180, 24)
        Me.txtWQ_UserName.TabIndex = 16
        '
        'txtWQ_Description
        '
        Me.txtWQ_Description.EditValue = ""
        Me.txtWQ_Description.Location = New System.Drawing.Point(148, 179)
        Me.txtWQ_Description.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtWQ_Description.Name = "txtWQ_Description"
        Me.txtWQ_Description.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWQ_Description.Properties.Appearance.Options.UseFont = True
        Me.txtWQ_Description.Size = New System.Drawing.Size(525, 58)
        Me.txtWQ_Description.TabIndex = 20
        '
        'txtPS_Opinion
        '
        Me.txtPS_Opinion.EditValue = ""
        Me.txtPS_Opinion.Location = New System.Drawing.Point(148, 377)
        Me.txtPS_Opinion.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtPS_Opinion.Name = "txtPS_Opinion"
        Me.txtPS_Opinion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPS_Opinion.Properties.Appearance.Options.UseFont = True
        Me.txtPS_Opinion.Size = New System.Drawing.Size(525, 58)
        Me.txtPS_Opinion.TabIndex = 26
        '
        'txtPS_UserName
        '
        Me.txtPS_UserName.Location = New System.Drawing.Point(148, 443)
        Me.txtPS_UserName.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtPS_UserName.Name = "txtPS_UserName"
        Me.txtPS_UserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPS_UserName.Properties.Appearance.Options.UseFont = True
        Me.txtPS_UserName.Size = New System.Drawing.Size(180, 24)
        Me.txtPS_UserName.TabIndex = 28
        '
        'txtACC_Opinion
        '
        Me.txtACC_Opinion.EditValue = ""
        Me.txtACC_Opinion.Location = New System.Drawing.Point(148, 475)
        Me.txtACC_Opinion.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtACC_Opinion.Name = "txtACC_Opinion"
        Me.txtACC_Opinion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACC_Opinion.Properties.Appearance.Options.UseFont = True
        Me.txtACC_Opinion.Size = New System.Drawing.Size(525, 58)
        Me.txtACC_Opinion.TabIndex = 30
        '
        'lblM_Unit
        '
        Me.lblM_Unit.Location = New System.Drawing.Point(630, 121)
        Me.lblM_Unit.Name = "lblM_Unit"
        Me.lblM_Unit.Size = New System.Drawing.Size(24, 14)
        Me.lblM_Unit.TabIndex = 27
        Me.lblM_Unit.Text = "單位"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(365, 55)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(125, 15)
        Me.LabelControl13.TabIndex = 7
        Me.LabelControl13.Text = "反饋物料規格(&G)："
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(20, 55)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(125, 15)
        Me.LabelControl12.TabIndex = 5
        Me.LabelControl12.Text = "反饋物料名稱(&N)："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(21, 478)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(124, 15)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "物控中心意見(&T)："
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(65, 446)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(80, 15)
        Me.LabelControl9.TabIndex = 27
        Me.LabelControl9.Text = "採購員(&Y)："
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(40, 381)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(105, 15)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "採購部意見(&J)："
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(65, 151)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(80, 15)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "反饋人(&U)："
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(17, 183)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(128, 15)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "品質問題描述(&W)："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(366, 119)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(124, 15)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "物料發出數量(&L)："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(20, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(125, 15)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "物料發出單號(&O)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(52, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(93, 15)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "反饋部門(&P)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(362, 22)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 15)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "反饋物料編號(&M)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(40, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 15)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "反饋單編號(&I)："
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(20, 249)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(125, 15)
        Me.LabelControl14.TabIndex = 21
        Me.LabelControl14.Text = "成本會計意見(&A)："
        '
        'txtCostAcc_Opinion
        '
        Me.txtCostAcc_Opinion.EditValue = ""
        Me.txtCostAcc_Opinion.Location = New System.Drawing.Point(148, 245)
        Me.txtCostAcc_Opinion.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtCostAcc_Opinion.Name = "txtCostAcc_Opinion"
        Me.txtCostAcc_Opinion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostAcc_Opinion.Properties.Appearance.Options.UseFont = True
        Me.txtCostAcc_Opinion.Size = New System.Drawing.Size(525, 58)
        Me.txtCostAcc_Opinion.TabIndex = 22
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(21, 315)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(124, 15)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "總生產部意見(&B)："
        '
        'txtPD_Opinion
        '
        Me.txtPD_Opinion.EditValue = ""
        Me.txtPD_Opinion.Location = New System.Drawing.Point(148, 311)
        Me.txtPD_Opinion.Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
        Me.txtPD_Opinion.Name = "txtPD_Opinion"
        Me.txtPD_Opinion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPD_Opinion.Properties.Appearance.Options.UseFont = True
        Me.txtPD_Opinion.Size = New System.Drawing.Size(525, 58)
        Me.txtPD_Opinion.TabIndex = 24
        '
        'frmWareQualityAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(742, 639)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareQualityAdd"
        Me.Text = "物料品質反饋單-添加"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteAddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtWQ_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bteWQ_Dpt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bteM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Gauge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWO_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWQ_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWQ_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPS_Opinion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPS_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtACC_Opinion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostAcc_Opinion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPD_Opinion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteAddDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtACC_Opinion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPS_UserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWQ_UserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWO_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWQ_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPS_Opinion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtWQ_Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtM_Gauge As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents bteWQ_Dpt As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bteM_Code As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblM_Unit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCostAcc_Opinion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPD_Opinion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
End Class
