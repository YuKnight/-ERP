<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleOrdersType
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cobOrdersType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.cobTMaterialType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtM_Code_Type = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSO_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtPM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cobOrdersType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cobTMaterialType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 21)
        Me.lblTitle.TabIndex = 46
        Me.lblTitle.Text = "产品类别"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 33)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobOrdersType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cobTMaterialType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtM_Code_Type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSO_ID)
        Me.GroupBox1.Controls.Add(Me.txtPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSO_SampleID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.SimpleButton2)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 231)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本数据"
        '
        'cobOrdersType
        '
        Me.cobOrdersType.EditValue = "樣板"
        Me.cobOrdersType.Location = New System.Drawing.Point(110, 103)
        Me.cobOrdersType.Name = "cobOrdersType"
        Me.cobOrdersType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobOrdersType.Properties.Appearance.Options.UseFont = True
        Me.cobOrdersType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cobOrdersType.Properties.Items.AddRange(New Object() {"樣板", "大貨"})
        Me.cobOrdersType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cobOrdersType.Size = New System.Drawing.Size(88, 24)
        Me.cobOrdersType.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1)
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "訂單類型(&O):"
        '
        'cobTMaterialType
        '
        Me.cobTMaterialType.EditValue = "钢"
        Me.cobTMaterialType.Location = New System.Drawing.Point(108, 161)
        Me.cobTMaterialType.Name = "cobTMaterialType"
        Me.cobTMaterialType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobTMaterialType.Properties.Appearance.Options.UseFont = True
        Me.cobTMaterialType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cobTMaterialType.Properties.Items.AddRange(New Object() {"钢", "铝", "黃金", "玫瑰金"})
        Me.cobTMaterialType.Size = New System.Drawing.Size(88, 24)
        Me.cobTMaterialType.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(1)
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "材料类别(&E):"
        '
        'txtM_Code_Type
        '
        Me.txtM_Code_Type.Location = New System.Drawing.Point(108, 132)
        Me.txtM_Code_Type.Name = "txtM_Code_Type"
        Me.txtM_Code_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Code_Type.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code_Type.Size = New System.Drawing.Size(179, 24)
        Me.txtM_Code_Type.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "产品类别(&L):"
        '
        'txtSO_ID
        '
        Me.txtSO_ID.Enabled = False
        Me.txtSO_ID.Location = New System.Drawing.Point(108, 16)
        Me.txtSO_ID.Name = "txtSO_ID"
        Me.txtSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_ID.Size = New System.Drawing.Size(179, 24)
        Me.txtSO_ID.TabIndex = 50
        '
        'txtPM_M_Code
        '
        Me.txtPM_M_Code.Enabled = False
        Me.txtPM_M_Code.Location = New System.Drawing.Point(108, 74)
        Me.txtPM_M_Code.Name = "txtPM_M_Code"
        Me.txtPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_M_Code.Size = New System.Drawing.Size(179, 24)
        Me.txtPM_M_Code.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 15)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "订单编号(&H):"
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.Enabled = False
        Me.txtSO_SampleID.Location = New System.Drawing.Point(108, 45)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(179, 24)
        Me.txtSO_SampleID.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "样办单号(&B):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "产品编号(&C):"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.SimpleButton2.Location = New System.Drawing.Point(186, 191)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(71, 29)
        Me.SimpleButton2.TabIndex = 60
        Me.SimpleButton2.Text = "取消(&E)"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.SimpleButton1.Location = New System.Drawing.Point(73, 191)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(71, 29)
        Me.SimpleButton1.TabIndex = 59
        Me.SimpleButton1.Text = "更改(&S)"
        '
        'frmNmetalSampleOrdersType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 273)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampleOrdersType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "产品类别"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cobOrdersType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cobTMaterialType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cobOrdersType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cobTMaterialType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtM_Code_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
