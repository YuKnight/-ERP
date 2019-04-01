<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionOutRetrocede
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
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPO_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabAutoID = New System.Windows.Forms.Label
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSuppName = New DevExpress.XtraEditors.TextEdit
        Me.txtOW_DO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtN_Qty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtR_Qty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtPO_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPSName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtPM_Code = New DevExpress.XtraEditors.TextEdit
        Me.txtPM_Type = New DevExpress.XtraEditors.TextEdit
        Me.lblTittle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.txtPO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOW_DO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtN_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtR_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPSName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseBackColor = True
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(238, 10)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl9.TabIndex = 28
        Me.LabelControl9.Text = "外發加工單號:"
        '
        'txtPO_ID
        '
        Me.txtPO_ID.Location = New System.Drawing.Point(338, 7)
        Me.txtPO_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPO_ID.Name = "txtPO_ID"
        Me.txtPO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtPO_ID.Properties.ReadOnly = True
        Me.txtPO_ID.Size = New System.Drawing.Size(114, 24)
        Me.txtPO_ID.TabIndex = 29
        Me.txtPO_ID.TabStop = False
        '
        'LabAutoID
        '
        Me.LabAutoID.AutoSize = True
        Me.LabAutoID.Location = New System.Drawing.Point(176, 10)
        Me.LabAutoID.Name = "LabAutoID"
        Me.LabAutoID.Size = New System.Drawing.Size(37, 12)
        Me.LabAutoID.TabIndex = 27
        Me.LabAutoID.Text = "Label1"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(305, 278)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "取消(&C)"
        '
        'cmdOK
        '
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdOK.Location = New System.Drawing.Point(99, 278)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(80, 28)
        Me.cmdOK.TabIndex = 25
        Me.cmdOK.Text = "確定(&O)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSuppName)
        Me.GroupBox1.Controls.Add(Me.txtOW_DO)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.txtN_Qty)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txtR_Qty)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txtPO_Remark)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtPSName)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txtPM_Code)
        Me.GroupBox1.Controls.Add(Me.txtPM_Type)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 229)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(73, 86)
        Me.txtSuppName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppName.Properties.Appearance.Options.UseFont = True
        Me.txtSuppName.Properties.ReadOnly = True
        Me.txtSuppName.Size = New System.Drawing.Size(376, 24)
        Me.txtSuppName.TabIndex = 23
        Me.txtSuppName.TabStop = False
        '
        'txtOW_DO
        '
        Me.txtOW_DO.Location = New System.Drawing.Point(302, 47)
        Me.txtOW_DO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOW_DO.Name = "txtOW_DO"
        Me.txtOW_DO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOW_DO.Properties.Appearance.Options.UseFont = True
        Me.txtOW_DO.Properties.ReadOnly = True
        Me.txtOW_DO.Size = New System.Drawing.Size(148, 24)
        Me.txtOW_DO.TabIndex = 21
        Me.txtOW_DO.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(4, 88)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "供應商名:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(232, 53)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "加工要求:"
        '
        'txtN_Qty
        '
        Me.txtN_Qty.Location = New System.Drawing.Point(302, 122)
        Me.txtN_Qty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtN_Qty.Name = "txtN_Qty"
        Me.txtN_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtN_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtN_Qty.Properties.Mask.EditMask = "d"
        Me.txtN_Qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtN_Qty.Size = New System.Drawing.Size(148, 24)
        Me.txtN_Qty.TabIndex = 19
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(232, 128)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "更改后數:"
        '
        'txtR_Qty
        '
        Me.txtR_Qty.Location = New System.Drawing.Point(73, 123)
        Me.txtR_Qty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtR_Qty.Name = "txtR_Qty"
        Me.txtR_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtR_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtR_Qty.Properties.ReadOnly = True
        Me.txtR_Qty.Size = New System.Drawing.Size(150, 24)
        Me.txtR_Qty.TabIndex = 17
        Me.txtR_Qty.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(5, 123)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "更改前數:"
        '
        'txtPO_Remark
        '
        Me.txtPO_Remark.Location = New System.Drawing.Point(72, 164)
        Me.txtPO_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPO_Remark.Name = "txtPO_Remark"
        Me.txtPO_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtPO_Remark.Size = New System.Drawing.Size(375, 47)
        Me.txtPO_Remark.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(15, 166)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "備注(&R):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(232, 16)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "配件名稱:"
        '
        'txtPSName
        '
        Me.txtPSName.Location = New System.Drawing.Point(73, 49)
        Me.txtPSName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPSName.Name = "txtPSName"
        Me.txtPSName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPSName.Properties.Appearance.Options.UseFont = True
        Me.txtPSName.Properties.ReadOnly = True
        Me.txtPSName.Size = New System.Drawing.Size(150, 24)
        Me.txtPSName.TabIndex = 13
        Me.txtPSName.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(4, 18)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "產品編號:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(4, 53)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "工序名稱:"
        '
        'txtPM_Code
        '
        Me.txtPM_Code.Location = New System.Drawing.Point(73, 12)
        Me.txtPM_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPM_Code.Name = "txtPM_Code"
        Me.txtPM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPM_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_Code.Properties.ReadOnly = True
        Me.txtPM_Code.Size = New System.Drawing.Size(150, 24)
        Me.txtPM_Code.TabIndex = 9
        Me.txtPM_Code.TabStop = False
        '
        'txtPM_Type
        '
        Me.txtPM_Type.Location = New System.Drawing.Point(302, 12)
        Me.txtPM_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPM_Type.Name = "txtPM_Type"
        Me.txtPM_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPM_Type.Properties.Appearance.Options.UseFont = True
        Me.txtPM_Type.Properties.ReadOnly = True
        Me.txtPM_Type.Size = New System.Drawing.Size(148, 24)
        Me.txtPM_Type.TabIndex = 11
        Me.txtPM_Type.TabStop = False
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTittle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(6, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(76, 21)
        Me.lblTittle.TabIndex = 23
        Me.lblTittle.Text = "更改單"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 35)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frmProductionOutRetrocede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 310)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtPO_ID)
        Me.Controls.Add(Me.LabAutoID)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionOutRetrocede"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "外發數量更改單"
        CType(Me.txtPO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOW_DO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtN_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtR_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPSName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabAutoID As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuppName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOW_DO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtN_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtR_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPO_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPSName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPM_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTittle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
