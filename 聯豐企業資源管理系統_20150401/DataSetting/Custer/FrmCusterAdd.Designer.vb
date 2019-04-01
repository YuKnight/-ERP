<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusterAdd
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
        Me.txtCustomer = New DevExpress.XtraEditors.TextEdit
        Me.lbl_Customer = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        Me.txtC_EngName = New DevExpress.XtraEditors.TextEdit
        Me.lbl = New System.Windows.Forms.Label
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dateCreateDate = New DevExpress.XtraEditors.DateEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtC_EngName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "客戶資料"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(95, 39)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtCustomer.Size = New System.Drawing.Size(192, 24)
        Me.txtCustomer.TabIndex = 1
        '
        'lbl_Customer
        '
        Me.lbl_Customer.AutoSize = True
        Me.lbl_Customer.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Customer.Location = New System.Drawing.Point(1, 44)
        Me.lbl_Customer.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.lbl_Customer.Name = "lbl_Customer"
        Me.lbl_Customer.Size = New System.Drawing.Size(95, 15)
        Me.lbl_Customer.TabIndex = 0
        Me.lbl_Customer.Text = "客戶代號(&A): "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 34)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Savebutton
        '
        Me.Savebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.Savebutton.Location = New System.Drawing.Point(390, 268)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(75, 32)
        Me.Savebutton.TabIndex = 24
        Me.Savebutton.Text = "保存"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(496, 268)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 32)
        Me.CloseButton.TabIndex = 25
        Me.CloseButton.Text = "取消"
        '
        'txtC_EngName
        '
        Me.txtC_EngName.Location = New System.Drawing.Point(95, 67)
        Me.txtC_EngName.Name = "txtC_EngName"
        Me.txtC_EngName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtC_EngName.Properties.Appearance.Options.UseFont = True
        Me.txtC_EngName.Size = New System.Drawing.Size(192, 24)
        Me.txtC_EngName.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl.Location = New System.Drawing.Point(17, 72)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(79, 15)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "英文名(&B): "
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(379, 95)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "中文名(&U): "
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(95, 95)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "聯系人(&C): "
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(379, 123)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit4.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "聯系電話(&S): "
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(379, 152)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit5.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 157)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "傳真號碼(&Z): "
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(95, 123)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit6.Properties.Appearance.Options.UseFont = True
        Me.TextEdit6.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit6.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "部    門(&D): "
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(95, 236)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit8.Properties.Appearance.Options.UseFont = True
        Me.TextEdit8.Size = New System.Drawing.Size(476, 24)
        Me.TextEdit8.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 241)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "國    家(&G): "
        '
        'TextEdit9
        '
        Me.TextEdit9.Location = New System.Drawing.Point(95, 208)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit9.Properties.Appearance.Options.UseFont = True
        Me.TextEdit9.Size = New System.Drawing.Size(476, 24)
        Me.TextEdit9.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 213)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "城    市(&F): "
        '
        'TextEdit10
        '
        Me.TextEdit10.Location = New System.Drawing.Point(95, 180)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Size = New System.Drawing.Size(476, 24)
        Me.TextEdit10.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 185)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "地    址(&E): "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(287, 72)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "建交日期(&H): "
        Me.Label12.Visible = False
        '
        'dateCreateDate
        '
        Me.dateCreateDate.EditValue = Nothing
        Me.dateCreateDate.Enabled = False
        Me.dateCreateDate.Location = New System.Drawing.Point(379, 67)
        Me.dateCreateDate.Name = "dateCreateDate"
        Me.dateCreateDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dateCreateDate.Properties.Appearance.Options.UseFont = True
        Me.dateCreateDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateCreateDate.Size = New System.Drawing.Size(131, 24)
        Me.dateCreateDate.TabIndex = 5
        Me.dateCreateDate.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(95, 152)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(192, 24)
        Me.TextEdit1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "邮件地址(&M): "
        '
        'FrmCusterAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(575, 304)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateCreateDate)
        Me.Controls.Add(Me.TextEdit6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextEdit8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextEdit9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextEdit10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextEdit5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtC_EngName)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lbl_Customer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCusterAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "客戶資料"
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtC_EngName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_Customer As System.Windows.Forms.Label
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtC_EngName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dateCreateDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
