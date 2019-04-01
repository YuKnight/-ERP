<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WareInventoryMothCollSelect
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.YearDate = New DevExpress.XtraEditors.TimeEdit
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PopupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.Tv1 = New System.Windows.Forms.TreeView
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.YearDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(2, 164)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 210
        Me.cmdSave.Text = "打印(&P)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(245, 165)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 211
        Me.cmdExit.Text = "取消(&C)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "類別(&T)："
        '
        'YearDate
        '
        Me.YearDate.EditValue = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.YearDate.Location = New System.Drawing.Point(83, 19)
        Me.YearDate.Name = "YearDate"
        Me.YearDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearDate.Properties.Appearance.Options.UseFont = True
        Me.YearDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.YearDate.Properties.Mask.EditMask = "yyyy年MM月"
        Me.YearDate.Size = New System.Drawing.Size(240, 24)
        Me.YearDate.TabIndex = 207
        '
        'txtWH
        '
        Me.txtWH.EnterMoveNextControl = True
        Me.txtWH.Location = New System.Drawing.Point(83, 61)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(240, 24)
        Me.txtWH.TabIndex = 206
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "月份(&M)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "倉庫(&W)："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PopupContainerEdit1)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.YearDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 139)
        Me.GroupBox1.TabIndex = 212
        Me.GroupBox1.TabStop = False
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(83, 101)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PopupContainerEdit1.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(240, 24)
        Me.PopupContainerEdit1.TabIndex = 216
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.Tv1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(350, 146)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(253, 188)
        Me.PopupContainerControl1.TabIndex = 215
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'Tv1
        '
        Me.Tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tv1.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Tv1.FullRowSelect = True
        Me.Tv1.HideSelection = False
        Me.Tv1.Location = New System.Drawing.Point(0, 0)
        Me.Tv1.Name = "Tv1"
        Me.Tv1.Size = New System.Drawing.Size(253, 188)
        Me.Tv1.TabIndex = 167
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.LFERP.My.Resources.Resources.SmartArtOrganizationChartRightHanging
        Me.SimpleButton1.Location = New System.Drawing.Point(133, 165)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 28)
        Me.SimpleButton1.TabIndex = 213
        Me.SimpleButton1.Text = "導出(&E)"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 199)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(334, 10)
        Me.ProgressBar1.TabIndex = 214
        Me.ProgressBar1.Visible = False
        '
        'WareInventoryMothCollSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(337, 217)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "WareInventoryMothCollSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "倉庫庫存月報表"
        CType(Me.YearDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents YearDate As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents Tv1 As System.Windows.Forms.TreeView
    Friend WithEvents PopupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
End Class
