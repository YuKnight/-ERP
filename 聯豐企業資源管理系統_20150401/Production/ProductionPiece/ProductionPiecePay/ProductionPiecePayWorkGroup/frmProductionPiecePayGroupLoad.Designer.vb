<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayGroupLoad
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
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.編號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.組別編號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.工號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.工時比例 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.年月 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonLoad = New DevExpress.XtraEditors.SimpleButton
        Me.PathTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QuitButton = New DevExpress.XtraEditors.SimpleButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Appearance.Options.UseFont = True
        Me.SaveButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.SaveButton.Location = New System.Drawing.Point(384, 453)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(83, 32)
        Me.SaveButton.TabIndex = 122
        Me.SaveButton.Text = "保存(&S)"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 473)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 16)
        Me.RadioButton2.TabIndex = 121
        Me.RadioButton2.Text = "office2007以上"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 451)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(154, 16)
        Me.RadioButton1.TabIndex = 120
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "office2007以下(包括2007)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 495)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(572, 13)
        Me.ProgressBar1.TabIndex = 119
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "組別員工工時比例導入"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(576, 35)
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(3, 76)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(575, 369)
        Me.GridControl1.TabIndex = 113
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.編號, Me.組別編號, Me.工號, Me.工時比例, Me.年月})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        '編號
        '
        Me.編號.Caption = "編號"
        Me.編號.FieldName = "編號"
        Me.編號.Name = "編號"
        Me.編號.Visible = True
        Me.編號.VisibleIndex = 0
        Me.編號.Width = 50
        '
        '組別編號
        '
        Me.組別編號.Caption = "組別編號"
        Me.組別編號.FieldName = "組別編號"
        Me.組別編號.Name = "組別編號"
        Me.組別編號.Visible = True
        Me.組別編號.VisibleIndex = 1
        Me.組別編號.Width = 126
        '
        '工號
        '
        Me.工號.Caption = "工號"
        Me.工號.FieldName = "工號"
        Me.工號.Name = "工號"
        Me.工號.OptionsColumn.AllowEdit = False
        Me.工號.OptionsColumn.AllowFocus = False
        Me.工號.Visible = True
        Me.工號.VisibleIndex = 2
        Me.工號.Width = 122
        '
        '工時比例
        '
        Me.工時比例.Caption = "工時比例"
        Me.工時比例.FieldName = "工時比例"
        Me.工時比例.Name = "工時比例"
        Me.工時比例.Visible = True
        Me.工時比例.VisibleIndex = 3
        Me.工時比例.Width = 126
        '
        '年月
        '
        Me.年月.Caption = "年月"
        Me.年月.FieldName = "年月"
        Me.年月.Name = "年月"
        Me.年月.Visible = True
        Me.年月.VisibleIndex = 4
        Me.年月.Width = 130
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad.Appearance.Options.UseFont = True
        Me.ButtonLoad.Location = New System.Drawing.Point(528, 39)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(50, 29)
        Me.ButtonLoad.TabIndex = 116
        Me.ButtonLoad.Text = "..."
        '
        'PathTextBox
        '
        Me.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PathTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PathTextBox.Location = New System.Drawing.Point(91, 44)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(431, 20)
        Me.PathTextBox.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "選擇路徑:"
        '
        'QuitButton
        '
        Me.QuitButton.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Appearance.Options.UseFont = True
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.QuitButton.Location = New System.Drawing.Point(486, 453)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(87, 32)
        Me.QuitButton.TabIndex = 123
        Me.QuitButton.Text = "退出(&Q)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmProductionPiecePayGroupLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(579, 507)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.PathTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductionPiecePayGroupLoad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "組別員工工時比例導入"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 工號 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuitButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents 組別編號 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 工時比例 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 年月 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents 編號 As DevExpress.XtraGrid.Columns.GridColumn
End Class
