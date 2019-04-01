<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyAdd
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
        Me.cmdDelPhoto = New System.Windows.Forms.Button
        Me.cmdOpenPhoto = New System.Windows.Forms.Button
        Me.pPhoto = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDelPhoto
        '
        Me.cmdDelPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelPhoto.Location = New System.Drawing.Point(216, 382)
        Me.cmdDelPhoto.Name = "cmdDelPhoto"
        Me.cmdDelPhoto.Size = New System.Drawing.Size(87, 31)
        Me.cmdDelPhoto.TabIndex = 47
        Me.cmdDelPhoto.Text = "保存圖片cb"
        Me.cmdDelPhoto.UseVisualStyleBackColor = True
        '
        'cmdOpenPhoto
        '
        Me.cmdOpenPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOpenPhoto.Location = New System.Drawing.Point(123, 382)
        Me.cmdOpenPhoto.Name = "cmdOpenPhoto"
        Me.cmdOpenPhoto.Size = New System.Drawing.Size(87, 31)
        Me.cmdOpenPhoto.TabIndex = 46
        Me.cmdOpenPhoto.Text = "打開圖片"
        Me.cmdOpenPhoto.UseVisualStyleBackColor = True
        '
        'pPhoto
        '
        Me.pPhoto.BackColor = System.Drawing.Color.Transparent
        Me.pPhoto.Location = New System.Drawing.Point(120, 43)
        Me.pPhoto.Name = "pPhoto"
        Me.pPhoto.Size = New System.Drawing.Size(558, 330)
        Me.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pPhoto.TabIndex = 45
        Me.pPhoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(321, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 31)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "保存圖片lf"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(427, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 31)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "保存圖片mg"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCompanyAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 456)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdDelPhoto)
        Me.Controls.Add(Me.cmdOpenPhoto)
        Me.Controls.Add(Me.pPhoto)
        Me.Name = "FrmCompanyAdd"
        Me.Text = "FrmCompanyAdd"
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdDelPhoto As System.Windows.Forms.Button
    Friend WithEvents cmdOpenPhoto As System.Windows.Forms.Button
    Private WithEvents pPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
