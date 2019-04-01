<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhiteUserSub
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
        Me.lblMain = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_UserID = New DevExpress.XtraEditors.TextEdit
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.txt_UserName = New DevExpress.XtraEditors.TextEdit
        Me.txt_FacName = New DevExpress.XtraEditors.TextEdit
        Me.txt_WMax = New DevExpress.XtraEditors.TextEdit
        Me.txtDepName = New DevExpress.XtraEditors.TextEdit
        Me.txt_WH_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.txt_Remark = New DevExpress.XtraEditors.TextEdit
        Me.txt_GNO = New DevExpress.XtraEditors.TextEdit
        Me.txt_AutoID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblWType = New System.Windows.Forms.Label
        Me.FindButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FacName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WH_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AutoID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMain.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Navy
        Me.lblMain.Location = New System.Drawing.Point(6, 7)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(88, 16)
        Me.lblMain.TabIndex = 4
        Me.lblMain.Text = "白名單設置"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 33)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(170, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "上 限:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "部 門:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(170, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "廠 別:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "姓 名:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "備註:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "工 號:"
        '
        'txt_UserID
        '
        Me.txt_UserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_UserID.Location = New System.Drawing.Point(49, 19)
        Me.txt_UserID.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_UserID.Properties.Appearance.Options.UseFont = True
        Me.txt_UserID.Size = New System.Drawing.Size(120, 24)
        Me.txt_UserID.TabIndex = 0
        '
        'cmdNew
        '
        Me.cmdNew.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdNew.Appearance.Options.UseFont = True
        Me.cmdNew.Location = New System.Drawing.Point(10, 217)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(70, 32)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "新增(&A)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(260, 218)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(70, 32)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "取消(&Q)"
        '
        'txt_UserName
        '
        Me.txt_UserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_UserName.Enabled = False
        Me.txt_UserName.Location = New System.Drawing.Point(49, 57)
        Me.txt_UserName.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_UserName.Properties.Appearance.Options.UseFont = True
        Me.txt_UserName.Size = New System.Drawing.Size(120, 24)
        Me.txt_UserName.TabIndex = 2
        '
        'txt_FacName
        '
        Me.txt_FacName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_FacName.Enabled = False
        Me.txt_FacName.Location = New System.Drawing.Point(216, 57)
        Me.txt_FacName.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_FacName.Name = "txt_FacName"
        Me.txt_FacName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_FacName.Properties.Appearance.Options.UseFont = True
        Me.txt_FacName.Size = New System.Drawing.Size(120, 24)
        Me.txt_FacName.TabIndex = 3
        '
        'txt_WMax
        '
        Me.txt_WMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_WMax.Location = New System.Drawing.Point(216, 93)
        Me.txt_WMax.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_WMax.Name = "txt_WMax"
        Me.txt_WMax.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_WMax.Properties.Appearance.Options.UseFont = True
        Me.txt_WMax.Properties.Mask.EditMask = "d"
        Me.txt_WMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_WMax.Size = New System.Drawing.Size(120, 24)
        Me.txt_WMax.TabIndex = 5
        '
        'txtDepName
        '
        Me.txtDepName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDepName.Enabled = False
        Me.txtDepName.Location = New System.Drawing.Point(49, 95)
        Me.txtDepName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDepName.Name = "txtDepName"
        Me.txtDepName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtDepName.Properties.Appearance.Options.UseFont = True
        Me.txtDepName.Size = New System.Drawing.Size(120, 24)
        Me.txtDepName.TabIndex = 4
        '
        'txt_WH_ID
        '
        Me.txt_WH_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_WH_ID.Enabled = False
        Me.txt_WH_ID.Location = New System.Drawing.Point(103, 7)
        Me.txt_WH_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_WH_ID.Name = "txt_WH_ID"
        Me.txt_WH_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_WH_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_WH_ID.Size = New System.Drawing.Size(25, 22)
        Me.txt_WH_ID.TabIndex = 7
        Me.txt_WH_ID.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(168, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "倉庫:"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(138, 218)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(70, 32)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "保存(&S)"
        '
        'txt_Remark
        '
        Me.txt_Remark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Remark.Location = New System.Drawing.Point(49, 134)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_Remark.Properties.Appearance.Options.UseFont = True
        Me.txt_Remark.Size = New System.Drawing.Size(287, 24)
        Me.txt_Remark.TabIndex = 1
        '
        'txt_GNO
        '
        Me.txt_GNO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_GNO.EditValue = "init"
        Me.txt_GNO.Enabled = False
        Me.txt_GNO.Location = New System.Drawing.Point(134, 7)
        Me.txt_GNO.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_GNO.Name = "txt_GNO"
        Me.txt_GNO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_GNO.Properties.Appearance.Options.UseFont = True
        Me.txt_GNO.Size = New System.Drawing.Size(25, 22)
        Me.txt_GNO.TabIndex = 47
        Me.txt_GNO.Visible = False
        '
        'txt_AutoID
        '
        Me.txt_AutoID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_AutoID.Enabled = False
        Me.txt_AutoID.Location = New System.Drawing.Point(261, 7)
        Me.txt_AutoID.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_AutoID.Name = "txt_AutoID"
        Me.txt_AutoID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_AutoID.Properties.Appearance.Options.UseFont = True
        Me.txt_AutoID.Size = New System.Drawing.Size(69, 22)
        Me.txt_AutoID.TabIndex = 7
        Me.txt_AutoID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FindButton)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Remark)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_UserID)
        Me.GroupBox1.Controls.Add(Me.txtDepName)
        Me.GroupBox1.Controls.Add(Me.txt_WMax)
        Me.GroupBox1.Controls.Add(Me.txt_UserName)
        Me.GroupBox1.Controls.Add(Me.txt_FacName)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblWType
        '
        Me.lblWType.AutoSize = True
        Me.lblWType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblWType.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWType.ForeColor = System.Drawing.Color.Navy
        Me.lblWType.Location = New System.Drawing.Point(206, 11)
        Me.lblWType.Name = "lblWType"
        Me.lblWType.Size = New System.Drawing.Size(25, 13)
        Me.lblWType.TabIndex = 6
        Me.lblWType.Text = "***"
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(265, 14)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(62, 25)
        Me.FindButton.TabIndex = 12
        Me.FindButton.Text = "查詢"
        '
        'frmWhiteUserSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(346, 261)
        Me.Controls.Add(Me.txt_AutoID)
        Me.Controls.Add(Me.txt_GNO)
        Me.Controls.Add(Me.lblWType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_WH_ID)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWhiteUserSub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "刀具倉白名單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FacName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WH_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AutoID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_UserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_UserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_FacName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_WMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_WH_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Remark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_GNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AutoID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblWType As System.Windows.Forms.Label
    Friend WithEvents FindButton As DevExpress.XtraEditors.SimpleButton
End Class
