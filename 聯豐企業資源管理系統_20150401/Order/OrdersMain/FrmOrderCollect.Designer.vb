<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderCollect
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.custeridEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.Label
        Me.sendEdit = New DevExpress.XtraEditors.CheckEdit
        Me.orderEdit = New DevExpress.XtraEditors.CheckEdit
        Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonExit = New DevExpress.XtraEditors.SimpleButton
        Me.ButtonOK = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComboBoxType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.custeridEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sendEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "訂單匯總"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.custeridEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.sendEdit)
        Me.GroupBox1.Controls.Add(Me.orderEdit)
        Me.GroupBox1.Controls.Add(Me.dateEdit1)
        Me.GroupBox1.Controls.Add(Me.dateEdit2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 201)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxType
        '
        Me.ComboBoxType.EditValue = "未交完"
        Me.ComboBoxType.Location = New System.Drawing.Point(87, 55)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxType.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxType.Properties.Items.AddRange(New Object() {"全部", "未交完", "已交完"})
        Me.ComboBoxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxType.Size = New System.Drawing.Size(189, 24)
        Me.ComboBoxType.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "匯總類型:"
        '
        'custeridEdit
        '
        Me.custeridEdit.EditValue = ""
        Me.custeridEdit.EnterMoveNextControl = True
        Me.custeridEdit.Location = New System.Drawing.Point(87, 17)
        Me.custeridEdit.Name = "custeridEdit"
        Me.custeridEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.custeridEdit.Properties.Appearance.Options.UseFont = True
        Me.custeridEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.custeridEdit.Properties.NullText = ""
        Me.custeridEdit.Properties.View = Me.GridView1
        Me.custeridEdit.Size = New System.Drawing.Size(189, 24)
        Me.custeridEdit.TabIndex = 33
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OM_CusterID})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶代號"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        Me.OM_CusterID.Visible = True
        Me.OM_CusterID.VisibleIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "到"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt1.Location = New System.Drawing.Point(9, 20)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(71, 15)
        Me.txt1.TabIndex = 5
        Me.txt1.Text = "客戶代號:"
        '
        'sendEdit
        '
        Me.sendEdit.Location = New System.Drawing.Point(181, 175)
        Me.sendEdit.Name = "sendEdit"
        Me.sendEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.sendEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sendEdit.Properties.Appearance.Options.UseBackColor = True
        Me.sendEdit.Properties.Appearance.Options.UseFont = True
        Me.sendEdit.Properties.Caption = "交貨日期"
        Me.sendEdit.Size = New System.Drawing.Size(95, 20)
        Me.sendEdit.TabIndex = 7
        '
        'orderEdit
        '
        Me.orderEdit.EditValue = True
        Me.orderEdit.Location = New System.Drawing.Point(64, 175)
        Me.orderEdit.Name = "orderEdit"
        Me.orderEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.orderEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.orderEdit.Properties.Appearance.Options.UseBackColor = True
        Me.orderEdit.Properties.Appearance.Options.UseFont = True
        Me.orderEdit.Properties.Caption = "下單日期"
        Me.orderEdit.Size = New System.Drawing.Size(97, 20)
        Me.orderEdit.TabIndex = 6
        '
        'dateEdit1
        '
        Me.dateEdit1.EditValue = Nothing
        Me.dateEdit1.Location = New System.Drawing.Point(87, 98)
        Me.dateEdit1.Name = "dateEdit1"
        Me.dateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateEdit1.Properties.Appearance.Options.UseFont = True
        Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit1.Size = New System.Drawing.Size(189, 24)
        Me.dateEdit1.TabIndex = 1
        '
        'dateEdit2
        '
        Me.dateEdit2.EditValue = Nothing
        Me.dateEdit2.Location = New System.Drawing.Point(87, 139)
        Me.dateEdit2.Name = "dateEdit2"
        Me.dateEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateEdit2.Properties.Appearance.Options.UseFont = True
        Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit2.Size = New System.Drawing.Size(189, 24)
        Me.dateEdit2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "從"
        '
        'ButtonExit
        '
        Me.ButtonExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonExit.Appearance.Options.UseFont = True
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.Location = New System.Drawing.Point(174, 251)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(81, 34)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "取消(&C)"
        '
        'ButtonOK
        '
        Me.ButtonOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonOK.Appearance.Options.UseFont = True
        Me.ButtonOK.Location = New System.Drawing.Point(34, 251)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(81, 34)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "確定(&Q)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 36)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'FrmOrderCollect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonExit
        Me.ClientSize = New System.Drawing.Size(295, 292)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrderCollect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "訂單匯總"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComboBoxType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.custeridEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sendEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents custeridEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents sendEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ButtonExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents orderEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ButtonOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
