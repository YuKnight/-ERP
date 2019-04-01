<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerFeedbackRemark
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具进行修改。
    '请不要使用程式碼編輯器进行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_remark = New DevExpress.XtraEditors.MemoEdit
        Me.cancelButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txt_remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_remark
        '
        Me.txt_remark.Location = New System.Drawing.Point(2, 2)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(432, 217)
        Me.txt_remark.TabIndex = 1
        '
        'cancelButton1
        '
        Me.cancelButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton1.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cancelButton1.Location = New System.Drawing.Point(350, 229)
        Me.cancelButton1.Name = "cancelButton1"
        Me.cancelButton1.Size = New System.Drawing.Size(73, 29)
        Me.cancelButton1.TabIndex = 97
        Me.cancelButton1.Text = "取消(&E)"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.SaveButton.Location = New System.Drawing.Point(259, 230)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(73, 29)
        Me.SaveButton.TabIndex = 96
        Me.SaveButton.Text = "保存(&S)"
        '
        'frmCustomerFeedbackRemark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 270)
        Me.Controls.Add(Me.cancelButton1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.txt_remark)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerFeedbackRemark"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "请输入订单版本的备注"
        CType(Me.txt_remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cancelButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton

End Class
