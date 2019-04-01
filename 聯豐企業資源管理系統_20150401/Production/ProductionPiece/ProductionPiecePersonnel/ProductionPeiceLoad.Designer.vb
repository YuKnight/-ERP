<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPeiceLoad
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton
        Me.組別名稱 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.薪金類型 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.組別編號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.部門 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.編號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.工號 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.姓名 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.廠別 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.班制 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonLoad = New DevExpress.XtraEditors.SimpleButton
        Me.PathTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QuitButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveButton
        '
        Me.SaveButton.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Appearance.Options.UseFont = True
        Me.SaveButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.SaveButton.Location = New System.Drawing.Point(381, 448)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(83, 32)
        Me.SaveButton.TabIndex = 111
        Me.SaveButton.Text = "保存(&S)"
        '
        '組別名稱
        '
        Me.組別名稱.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.組別名稱.AppearanceCell.Options.UseBackColor = True
        Me.組別名稱.Caption = "組別名稱"
        Me.組別名稱.FieldName = "組別名稱"
        Me.組別名稱.Name = "組別名稱"
        Me.組別名稱.OptionsColumn.AllowEdit = False
        Me.組別名稱.OptionsColumn.AllowFocus = False
        Me.組別名稱.Visible = True
        Me.組別名稱.VisibleIndex = 5
        Me.組別名稱.Width = 73
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 468)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 16)
        Me.RadioButton2.TabIndex = 110
        Me.RadioButton2.Text = "office2007以上"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        '薪金類型
        '
        Me.薪金類型.Caption = "薪金類型"
        Me.薪金類型.FieldName = "薪金類型"
        Me.薪金類型.Name = "薪金類型"
        Me.薪金類型.OptionsColumn.AllowEdit = False
        Me.薪金類型.OptionsColumn.AllowFocus = False
        Me.薪金類型.Visible = True
        Me.薪金類型.VisibleIndex = 6
        Me.薪金類型.Width = 83
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 446)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(154, 16)
        Me.RadioButton1.TabIndex = 109
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "office2007以下(包括2007)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 490)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(572, 13)
        Me.ProgressBar1.TabIndex = 108
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "計件人員名單批量導入"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 35)
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        '組別編號
        '
        Me.組別編號.Caption = "組別編號"
        Me.組別編號.FieldName = "組別編號"
        Me.組別編號.Name = "組別編號"
        Me.組別編號.OptionsColumn.AllowEdit = False
        Me.組別編號.OptionsColumn.AllowFocus = False
        Me.組別編號.Visible = True
        Me.組別編號.VisibleIndex = 4
        Me.組別編號.Width = 73
        '
        '部門
        '
        Me.部門.Caption = "部門"
        Me.部門.FieldName = "部門"
        Me.部門.Name = "部門"
        Me.部門.OptionsColumn.AllowEdit = False
        Me.部門.OptionsColumn.AllowFocus = False
        Me.部門.Visible = True
        Me.部門.VisibleIndex = 3
        Me.部門.Width = 73
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 71)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(575, 369)
        Me.GridControl1.TabIndex = 102
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.編號, Me.工號, Me.姓名, Me.廠別, Me.部門, Me.組別編號, Me.組別名稱, Me.薪金類型, Me.班制})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        '編號
        '
        Me.編號.Caption = "編號"
        Me.編號.FieldName = "編號"
        Me.編號.Name = "編號"
        Me.編號.OptionsColumn.AllowEdit = False
        Me.編號.OptionsColumn.AllowFocus = False
        Me.編號.Width = 20
        '
        '工號
        '
        Me.工號.Caption = "工號"
        Me.工號.FieldName = "工號"
        Me.工號.Name = "工號"
        Me.工號.OptionsColumn.AllowEdit = False
        Me.工號.OptionsColumn.AllowFocus = False
        Me.工號.Visible = True
        Me.工號.VisibleIndex = 0
        Me.工號.Width = 73
        '
        '姓名
        '
        Me.姓名.Caption = "姓名"
        Me.姓名.FieldName = "姓名"
        Me.姓名.Name = "姓名"
        Me.姓名.OptionsColumn.AllowEdit = False
        Me.姓名.OptionsColumn.AllowFocus = False
        Me.姓名.Visible = True
        Me.姓名.VisibleIndex = 1
        Me.姓名.Width = 73
        '
        '廠別
        '
        Me.廠別.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.廠別.AppearanceCell.Options.UseBackColor = True
        Me.廠別.Caption = "廠別"
        Me.廠別.FieldName = "廠別"
        Me.廠別.Name = "廠別"
        Me.廠別.OptionsColumn.AllowEdit = False
        Me.廠別.OptionsColumn.AllowFocus = False
        Me.廠別.Visible = True
        Me.廠別.VisibleIndex = 2
        Me.廠別.Width = 73
        '
        '班制
        '
        Me.班制.Caption = "班制"
        Me.班制.FieldName = "班制"
        Me.班制.Name = "班制"
        Me.班制.OptionsColumn.ReadOnly = True
        Me.班制.Visible = True
        Me.班制.VisibleIndex = 7
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad.Appearance.Options.UseFont = True
        Me.ButtonLoad.Location = New System.Drawing.Point(525, 40)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(50, 29)
        Me.ButtonLoad.TabIndex = 105
        Me.ButtonLoad.Text = "..."
        '
        'PathTextBox
        '
        Me.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PathTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PathTextBox.Location = New System.Drawing.Point(88, 45)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(431, 20)
        Me.PathTextBox.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "選擇路徑:"
        '
        'QuitButton
        '
        Me.QuitButton.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Appearance.Options.UseFont = True
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.QuitButton.Location = New System.Drawing.Point(488, 448)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(87, 32)
        Me.QuitButton.TabIndex = 112
        Me.QuitButton.Text = "退出(&Q)"
        '
        'ProductionPeiceLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(579, 510)
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
        Me.Name = "ProductionPeiceLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "計件名單批量導入"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents 組別名稱 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents 薪金類型 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents 組別編號 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 部門 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 編號 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 工號 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 姓名 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 廠別 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuitButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents 班制 As DevExpress.XtraGrid.Columns.GridColumn
End Class
