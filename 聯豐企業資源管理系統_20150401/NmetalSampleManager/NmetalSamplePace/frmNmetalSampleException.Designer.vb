<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleException
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton
        Me.lbl_Name = New System.Windows.Forms.Label
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_user = New System.Windows.Forms.Label
        Me.txt_password = New DevExpress.XtraEditors.TextEdit
        Me.txt_User = New DevExpress.XtraEditors.TextEdit
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_User.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(40, 109)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(65, 25)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "保存"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(127, 109)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(65, 25)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "取消"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "工號："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "姓名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "備註："
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(63, 5)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(137, 25)
        Me.TextEdit1.TabIndex = 5
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(63, 36)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(137, 25)
        Me.TextEdit2.TabIndex = 6
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(63, 68)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit1.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit1.Size = New System.Drawing.Size(139, 35)
        Me.MemoEdit1.TabIndex = 7
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TextEdit1)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.TextEdit2)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.MemoEdit1)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(-1, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(230, 139)
        Me.PanelControl2.TabIndex = 2
        Me.PanelControl2.Text = "PanelControl2"
        Me.PanelControl2.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_close)
        Me.PanelControl1.Controls.Add(Me.btn_save)
        Me.PanelControl1.Controls.Add(Me.lbl_Name)
        Me.PanelControl1.Controls.Add(Me.lbl_password)
        Me.PanelControl1.Controls.Add(Me.lbl_user)
        Me.PanelControl1.Controls.Add(Me.txt_password)
        Me.PanelControl1.Controls.Add(Me.txt_User)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(218, 139)
        Me.PanelControl1.TabIndex = 9
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(119, 109)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(65, 25)
        Me.btn_close.TabIndex = 9
        Me.btn_close.Text = "取消"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(32, 109)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(65, 25)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "確定"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(68, 48)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(29, 12)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "姓名"
        Me.lbl_Name.Visible = False
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(5, 79)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(52, 15)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "密碼："
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(5, 21)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(52, 15)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "工號："
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(63, 73)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(137, 25)
        Me.txt_password.TabIndex = 1
        '
        'txt_User
        '
        Me.txt_User.Location = New System.Drawing.Point(63, 15)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_User.Properties.Appearance.Options.UseFont = True
        Me.txt_User.Size = New System.Drawing.Size(137, 25)
        Me.txt_User.TabIndex = 0
        '
        'frmNmetalSampleException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 143)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampleException"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "刷卡信息"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_User.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_User As DevExpress.XtraEditors.TextEdit
End Class
