<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleEmailSettingAdd
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
        Me.U_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
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
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluU_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speCheckOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStateAlarmTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndAlarmTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "郵箱报警設置"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(111, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "用戶編號:"
        Me.Label2.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.EditValue = "mis@mail.megapt.com.cn"
        Me.txtEmail.Location = New System.Drawing.Point(82, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(198, 24)
        Me.txtEmail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(4, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "郵箱地址:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(4, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "邮件順序:"
        '
        'gluU_ID
        '
        Me.gluU_ID.EditValue = ""
        Me.gluU_ID.Location = New System.Drawing.Point(190, 5)
        Me.gluU_ID.Name = "gluU_ID"
        Me.gluU_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluU_ID.Properties.Appearance.Options.UseFont = True
        Me.gluU_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluU_ID.Properties.NullText = ""
        Me.gluU_ID.Properties.View = Me.GridView8
        Me.gluU_ID.Size = New System.Drawing.Size(198, 24)
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
        'speCheckOrder
        '
        Me.speCheckOrder.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCheckOrder.Location = New System.Drawing.Point(82, 41)
        Me.speCheckOrder.Name = "speCheckOrder"
        Me.speCheckOrder.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.speCheckOrder.Properties.Appearance.Options.UseFont = True
        Me.speCheckOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.speCheckOrder.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speCheckOrder.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCheckOrder.Size = New System.Drawing.Size(198, 24)
        Me.speCheckOrder.TabIndex = 3
        '
        'txtStateAlarmTime
        '
        Me.txtStateAlarmTime.EditValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtStateAlarmTime.Location = New System.Drawing.Point(94, 119)
        Me.txtStateAlarmTime.Name = "txtStateAlarmTime"
        Me.txtStateAlarmTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtStateAlarmTime.Properties.Appearance.Options.UseFont = True
        Me.txtStateAlarmTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStateAlarmTime.Properties.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtStateAlarmTime.Properties.MaxValue = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtStateAlarmTime.Properties.MinValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtStateAlarmTime.Size = New System.Drawing.Size(149, 24)
        Me.txtStateAlarmTime.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(-3, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "开始报警(分):"
        '
        'txtEndAlarmTime
        '
        Me.txtEndAlarmTime.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtEndAlarmTime.Location = New System.Drawing.Point(94, 146)
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
        Me.Label7.Location = New System.Drawing.Point(-3, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "截止报警(分):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(247, 125)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "分钟"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(247, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "分钟"
        Me.LabelControl2.Visible = False
        '
        'btnCancle
        '
        Me.btnCancle.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancle.Appearance.Options.UseFont = True
        Me.btnCancle.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancle.Location = New System.Drawing.Point(149, 176)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(72, 28)
        Me.btnCancle.TabIndex = 11
        Me.btnCancle.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnSave.Location = New System.Drawing.Point(67, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 28)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "保存"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 32)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "手机号码:"
        '
        'memoRemark
        '
        Me.memoRemark.Location = New System.Drawing.Point(82, 93)
        Me.memoRemark.Name = "memoRemark"
        Me.memoRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.memoRemark.Properties.Appearance.Options.UseFont = True
        Me.memoRemark.Size = New System.Drawing.Size(198, 24)
        Me.memoRemark.TabIndex = 51
        '
        'frmSampleEmailSettingAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 211)
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
        Me.Name = "frmSampleEmailSettingAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "郵箱报警設置"
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluU_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speCheckOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStateAlarmTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndAlarmTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
