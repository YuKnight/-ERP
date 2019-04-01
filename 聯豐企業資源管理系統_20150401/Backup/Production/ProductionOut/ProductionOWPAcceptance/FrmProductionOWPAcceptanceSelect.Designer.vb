<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductionOWPAcceptanceSelect
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
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CmdLoad = New DevExpress.XtraEditors.SimpleButton
        Me.txtPM_NO = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.GoIn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OW_Do = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_NOsub = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AutoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(498, 248)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.cmdSave.Location = New System.Drawing.Point(395, 248)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "確定(&O)"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GoIn, Me.Column1, Me.Column2, Me.Column3, Me.OW_Do, Me.O_NOsub, Me.AutoID})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(3, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(578, 209)
        Me.DataGridView1.TabIndex = 17
        '
        'CmdLoad
        '
        Me.CmdLoad.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CmdLoad.Appearance.Options.UseFont = True
        Me.CmdLoad.Location = New System.Drawing.Point(505, 3)
        Me.CmdLoad.Name = "CmdLoad"
        Me.CmdLoad.Size = New System.Drawing.Size(72, 25)
        Me.CmdLoad.TabIndex = 14
        Me.CmdLoad.Text = "載入(&L)"
        '
        'txtPM_NO
        '
        Me.txtPM_NO.EditValue = ""
        Me.txtPM_NO.Location = New System.Drawing.Point(91, 5)
        Me.txtPM_NO.Name = "txtPM_NO"
        Me.txtPM_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPM_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPM_NO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPM_NO.Size = New System.Drawing.Size(408, 24)
        Me.txtPM_NO.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(0, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 15)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "外發單號(&I):"
        '
        'GoIn
        '
        Me.GoIn.HeaderText = "加入"
        Me.GoIn.Name = "GoIn"
        Me.GoIn.Width = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PM_M_Code"
        Me.Column1.HeaderText = "產品編號"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PM_Type"
        Me.Column2.HeaderText = "配件名稱"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "PS_Name"
        Me.Column3.HeaderText = "工序名稱"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'OW_Do
        '
        Me.OW_Do.DataPropertyName = "OW_Do"
        Me.OW_Do.HeaderText = "加工要求"
        Me.OW_Do.Name = "OW_Do"
        Me.OW_Do.ReadOnly = True
        Me.OW_Do.Width = 200
        '
        'O_NOsub
        '
        Me.O_NOsub.DataPropertyName = "PO_ID"
        Me.O_NOsub.HeaderText = "外发編號"
        Me.O_NOsub.Name = "O_NOsub"
        Me.O_NOsub.ReadOnly = True
        Me.O_NOsub.Visible = False
        '
        'AutoID
        '
        Me.AutoID.DataPropertyName = "AutoID"
        Me.AutoID.HeaderText = "編號"
        Me.AutoID.Name = "AutoID"
        '
        'FrmProductionOWPAcceptanceSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(584, 282)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdLoad)
        Me.Controls.Add(Me.txtPM_NO)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmProductionOWPAcceptanceSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "選擇驗收的產品工序"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPM_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GoIn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OW_Do As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_NOsub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
