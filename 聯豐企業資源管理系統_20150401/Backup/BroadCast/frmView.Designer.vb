<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit
        Me.lbl_M_out = New System.Windows.Forms.Label
        Me.lbl_M_In = New System.Windows.Forms.Label
        Me.lbl_M_Date = New System.Windows.Forms.Label
        Me.lbl_M_Time = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_M_Type = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "詳細資料"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 36)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "發送人:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "接收人:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "類型:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(204, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "時間:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(204, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "日期:"
        '
        'Savebutton
        '
        Me.Savebutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.Savebutton.Location = New System.Drawing.Point(288, 355)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(57, 27)
        Me.Savebutton.TabIndex = 2
        Me.Savebutton.Text = "確認"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(361, 355)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(57, 27)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "退出"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.LFERP.My.Resources.Resources.Areply
        Me.SimpleButton1.Location = New System.Drawing.Point(195, 355)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(73, 27)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "回復"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(0, 95)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Properties.Appearance.Font = New System.Drawing.Font("細明體", 11.25!)
        Me.txtMessage.Properties.Appearance.Options.UseFont = True
        Me.txtMessage.Size = New System.Drawing.Size(434, 252)
        Me.txtMessage.TabIndex = 3
        '
        'lbl_M_out
        '
        Me.lbl_M_out.AutoSize = True
        Me.lbl_M_out.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_M_out.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_out.Location = New System.Drawing.Point(82, 39)
        Me.lbl_M_out.Name = "lbl_M_out"
        Me.lbl_M_out.Size = New System.Drawing.Size(64, 16)
        Me.lbl_M_out.TabIndex = 98
        Me.lbl_M_out.Text = "發送人:"
        '
        'lbl_M_In
        '
        Me.lbl_M_In.AutoSize = True
        Me.lbl_M_In.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_M_In.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_In.Location = New System.Drawing.Point(82, 71)
        Me.lbl_M_In.Name = "lbl_M_In"
        Me.lbl_M_In.Size = New System.Drawing.Size(64, 16)
        Me.lbl_M_In.TabIndex = 99
        Me.lbl_M_In.Text = "發送人:"
        '
        'lbl_M_Date
        '
        Me.lbl_M_Date.AutoSize = True
        Me.lbl_M_Date.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_M_Date.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_Date.Location = New System.Drawing.Point(258, 39)
        Me.lbl_M_Date.Name = "lbl_M_Date"
        Me.lbl_M_Date.Size = New System.Drawing.Size(64, 16)
        Me.lbl_M_Date.TabIndex = 100
        Me.lbl_M_Date.Text = "發送人:"
        '
        'lbl_M_Time
        '
        Me.lbl_M_Time.AutoSize = True
        Me.lbl_M_Time.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_M_Time.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_Time.Location = New System.Drawing.Point(258, 71)
        Me.lbl_M_Time.Name = "lbl_M_Time"
        Me.lbl_M_Time.Size = New System.Drawing.Size(64, 16)
        Me.lbl_M_Time.TabIndex = 101
        Me.lbl_M_Time.Text = "發送人:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(344, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "發送人:"
        Me.Label12.Visible = False
        '
        'lbl_M_Type
        '
        Me.lbl_M_Type.AutoSize = True
        Me.lbl_M_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_M_Type.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_Type.Location = New System.Drawing.Point(344, 9)
        Me.lbl_M_Type.Name = "lbl_M_Type"
        Me.lbl_M_Type.Size = New System.Drawing.Size(64, 16)
        Me.lbl_M_Type.TabIndex = 103
        Me.lbl_M_Type.Text = "發送人:"
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 389)
        Me.Controls.Add(Me.lbl_M_Type)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_M_Time)
        Me.Controls.Add(Me.lbl_M_Date)
        Me.Controls.Add(Me.lbl_M_In)
        Me.Controls.Add(Me.lbl_M_out)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "詳細信息"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl_M_out As System.Windows.Forms.Label
    Friend WithEvents lbl_M_In As System.Windows.Forms.Label
    Friend WithEvents lbl_M_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_M_Time As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_M_Type As System.Windows.Forms.Label
End Class
