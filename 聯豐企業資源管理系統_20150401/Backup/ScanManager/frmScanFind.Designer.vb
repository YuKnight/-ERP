<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScanFind
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dteSF_DateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dteSF_DateBegin = New DevExpress.XtraEditors.DateEdit
        Me.txtSF_Remark = New DevExpress.XtraEditors.TextEdit
        Me.txtSF_No = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dteSF_DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteSF_DateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSF_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSF_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dteSF_DateEnd)
        Me.GroupBox1.Controls.Add(Me.dteSF_DateBegin)
        Me.GroupBox1.Controls.Add(Me.txtSF_Remark)
        Me.GroupBox1.Controls.Add(Me.txtSF_No)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'dteSF_DateEnd
        '
        Me.dteSF_DateEnd.EditValue = Nothing
        Me.dteSF_DateEnd.Location = New System.Drawing.Point(140, 130)
        Me.dteSF_DateEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.dteSF_DateEnd.Name = "dteSF_DateEnd"
        Me.dteSF_DateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteSF_DateEnd.Properties.Appearance.Options.UseFont = True
        Me.dteSF_DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteSF_DateEnd.Size = New System.Drawing.Size(150, 24)
        Me.dteSF_DateEnd.TabIndex = 6
        '
        'dteSF_DateBegin
        '
        Me.dteSF_DateBegin.EditValue = Nothing
        Me.dteSF_DateBegin.Location = New System.Drawing.Point(140, 94)
        Me.dteSF_DateBegin.Margin = New System.Windows.Forms.Padding(6)
        Me.dteSF_DateBegin.Name = "dteSF_DateBegin"
        Me.dteSF_DateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteSF_DateBegin.Properties.Appearance.Options.UseFont = True
        Me.dteSF_DateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteSF_DateBegin.Size = New System.Drawing.Size(150, 24)
        Me.dteSF_DateBegin.TabIndex = 5
        '
        'txtSF_Remark
        '
        Me.txtSF_Remark.Location = New System.Drawing.Point(110, 58)
        Me.txtSF_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSF_Remark.Name = "txtSF_Remark"
        Me.txtSF_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSF_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtSF_Remark.Size = New System.Drawing.Size(180, 24)
        Me.txtSF_Remark.TabIndex = 3
        '
        'txtSF_No
        '
        Me.txtSF_No.Location = New System.Drawing.Point(110, 22)
        Me.txtSF_No.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSF_No.Name = "txtSF_No"
        Me.txtSF_No.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSF_No.Properties.Appearance.Options.UseFont = True
        Me.txtSF_No.Size = New System.Drawing.Size(180, 24)
        Me.txtSF_No.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(114, 132)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(15, 18)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "到"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 97)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(117, 18)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "掃描日期(&D)： 從"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 18)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "說     明(&S)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 18)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "文件編號(&I)："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Location = New System.Drawing.Point(49, 21)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(80, 28)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "查詢(&F)"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(171, 21)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        '
        'frmScanFind
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(319, 255)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScanFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "掃描文件查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dteSF_DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteSF_DateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSF_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSF_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteSF_DateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSF_Remark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSF_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteSF_DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
End Class
