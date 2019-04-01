<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleEmailSettingAdd
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gluU_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.speCheckOrder = New DevExpress.XtraEditors.SpinEdit
        Me.txtStateAlarmTime = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEndAlarmTime = New DevExpress.XtraEditors.SpinEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnCancle = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.memoRemark = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtStoreTime = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCypleTime = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_StoreCyCleTime = New DevExpress.XtraEditors.SpinEdit
        Me.lbl_StoreCyCleTime = New System.Windows.Forms.Label
        Me.U_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluU_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speCheckOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStateAlarmTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndAlarmTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoreTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCypleTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StoreCyCleTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "邮箱报警设置"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(153, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "用户编号:"
        Me.Label2.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.EditValue = "mis@mail.megapt.com.cn"
        Me.txtEmail.Location = New System.Drawing.Point(106, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(198, 24)
        Me.txtEmail.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(28, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "邮箱地址:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(28, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "邮件顺序:"
        '
        'gluU_ID
        '
        Me.gluU_ID.EditValue = ""
        Me.gluU_ID.Location = New System.Drawing.Point(227, 4)
        Me.gluU_ID.Name = "gluU_ID"
        Me.gluU_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluU_ID.Properties.Appearance.Options.UseFont = True
        Me.gluU_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluU_ID.Properties.NullText = ""
        Me.gluU_ID.Properties.View = Me.GridView8
        Me.gluU_ID.Size = New System.Drawing.Size(108, 24)
        Me.gluU_ID.TabIndex = 1
        Me.gluU_ID.Visible = False
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.U_ID, Me.U_Name})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'speCheckOrder
        '
        Me.speCheckOrder.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCheckOrder.Location = New System.Drawing.Point(106, 41)
        Me.speCheckOrder.Name = "speCheckOrder"
        Me.speCheckOrder.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.speCheckOrder.Properties.Appearance.Options.UseFont = True
        Me.speCheckOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.speCheckOrder.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speCheckOrder.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCheckOrder.Size = New System.Drawing.Size(198, 24)
        Me.speCheckOrder.TabIndex = 1
        '
        'txtStateAlarmTime
        '
        Me.txtStateAlarmTime.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStateAlarmTime.Location = New System.Drawing.Point(141, 130)
        Me.txtStateAlarmTime.Name = "txtStateAlarmTime"
        Me.txtStateAlarmTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtStateAlarmTime.Properties.Appearance.Options.UseFont = True
        Me.txtStateAlarmTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStateAlarmTime.Properties.Increment = New Decimal(New Integer() {14, 0, 0, 0})
        Me.txtStateAlarmTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtStateAlarmTime.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStateAlarmTime.Size = New System.Drawing.Size(149, 24)
        Me.txtStateAlarmTime.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(42, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "开始报警(分):"
        '
        'txtEndAlarmTime
        '
        Me.txtEndAlarmTime.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtEndAlarmTime.Location = New System.Drawing.Point(141, 161)
        Me.txtEndAlarmTime.Name = "txtEndAlarmTime"
        Me.txtEndAlarmTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtEndAlarmTime.Properties.Appearance.Options.UseFont = True
        Me.txtEndAlarmTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtEndAlarmTime.Properties.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtEndAlarmTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtEndAlarmTime.Properties.MinValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtEndAlarmTime.Size = New System.Drawing.Size(149, 24)
        Me.txtEndAlarmTime.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(41, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "截止报警(分):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(294, 134)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "分钟"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(293, 164)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "分钟"
        '
        'btnCancle
        '
        Me.btnCancle.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancle.Appearance.Options.UseFont = True
        Me.btnCancle.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancle.Location = New System.Drawing.Point(212, 293)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(72, 28)
        Me.btnCancle.TabIndex = 16
        Me.btnCancle.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnSave.Location = New System.Drawing.Point(57, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 28)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "保存"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 32)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "手机号码:"
        '
        'memoRemark
        '
        Me.memoRemark.Location = New System.Drawing.Point(106, 100)
        Me.memoRemark.Name = "memoRemark"
        Me.memoRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.memoRemark.Properties.Appearance.Options.UseFont = True
        Me.memoRemark.Properties.MaxLength = 11
        Me.memoRemark.Size = New System.Drawing.Size(198, 24)
        Me.memoRemark.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(41, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "存放时间(时):"
        '
        'txtStoreTime
        '
        Me.txtStoreTime.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStoreTime.Location = New System.Drawing.Point(141, 194)
        Me.txtStoreTime.Name = "txtStoreTime"
        Me.txtStoreTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtStoreTime.Properties.Appearance.Options.UseFont = True
        Me.txtStoreTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStoreTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtStoreTime.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStoreTime.Size = New System.Drawing.Size(149, 24)
        Me.txtStoreTime.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(294, 200)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "小时"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(42, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "循环时长(分):"
        '
        'txtCypleTime
        '
        Me.txtCypleTime.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtCypleTime.Location = New System.Drawing.Point(141, 226)
        Me.txtCypleTime.Name = "txtCypleTime"
        Me.txtCypleTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtCypleTime.Properties.Appearance.Options.UseFont = True
        Me.txtCypleTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCypleTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtCypleTime.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtCypleTime.Size = New System.Drawing.Size(149, 24)
        Me.txtCypleTime.TabIndex = 13
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(294, 231)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "分钟"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(294, 262)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl5.TabIndex = 25
        Me.LabelControl5.Text = "分钟"
        '
        'txt_StoreCyCleTime
        '
        Me.txt_StoreCyCleTime.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_StoreCyCleTime.Location = New System.Drawing.Point(141, 257)
        Me.txt_StoreCyCleTime.Name = "txt_StoreCyCleTime"
        Me.txt_StoreCyCleTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txt_StoreCyCleTime.Properties.Appearance.Options.UseFont = True
        Me.txt_StoreCyCleTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_StoreCyCleTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txt_StoreCyCleTime.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_StoreCyCleTime.Size = New System.Drawing.Size(149, 24)
        Me.txt_StoreCyCleTime.TabIndex = 24
        '
        'lbl_StoreCyCleTime
        '
        Me.lbl_StoreCyCleTime.AutoSize = True
        Me.lbl_StoreCyCleTime.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lbl_StoreCyCleTime.Location = New System.Drawing.Point(11, 261)
        Me.lbl_StoreCyCleTime.Name = "lbl_StoreCyCleTime"
        Me.lbl_StoreCyCleTime.Size = New System.Drawing.Size(126, 15)
        Me.lbl_StoreCyCleTime.TabIndex = 23
        Me.lbl_StoreCyCleTime.Text = "循环存放时长(分):"
        '
        'U_ID
        '
        Me.U_ID.Caption = "用戶編號"
        Me.U_ID.FieldName = "U_ID"
        Me.U_ID.Name = "U_ID"
        Me.U_ID.Visible = True
        Me.U_ID.VisibleIndex = 0
        Me.U_ID.Width = 100
        '
        'U_Name
        '
        Me.U_Name.Caption = "用戶名稱"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 1
        '
        'frmNmetalSampleEmailSettingAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 328)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_StoreCyCleTime)
        Me.Controls.Add(Me.lbl_StoreCyCleTime)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCypleTime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtStoreTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.memoRemark)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtEndAlarmTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStateAlarmTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.speCheckOrder)
        Me.Controls.Add(Me.gluU_ID)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampleEmailSettingAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "邮箱报警设置"
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluU_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speCheckOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStateAlarmTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndAlarmTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoreTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCypleTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StoreCyCleTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gluU_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents U_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents speCheckOrder As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStateAlarmTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEndAlarmTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents memoRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStoreTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCypleTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_StoreCyCleTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_StoreCyCleTime As System.Windows.Forms.Label
End Class
