<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierSelect
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.PopupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.txtDai = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(107, 16)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "供應商編號(&I)："
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "供應商名稱(&N)："
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 89)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(110, 16)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "供應商類型(&T)："
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(12, 125)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(107, 16)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Text = "信 用 等 級(&L)："
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(117, 19)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(174, 21)
        Me.TextEdit1.TabIndex = 0
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(117, 53)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(174, 21)
        Me.TextEdit2.TabIndex = 2
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(117, 86)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(174, 21)
        Me.PopupContainerEdit1.TabIndex = 4
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.TreeList1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(38, 258)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(365, 193)
        Me.PopupContainerControl1.TabIndex = 177
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6})
        Me.TreeList1.KeyFieldName = "S_TypeID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "S_TypePID"
        Me.TreeList1.Size = New System.Drawing.Size(365, 193)
        Me.TreeList1.TabIndex = 1
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "供應商名稱"
        Me.TreeListColumn4.FieldName = "S_TypeName"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.ReadOnly = True
        Me.TreeListColumn4.VisibleIndex = 0
        Me.TreeListColumn4.Width = 177
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "說明"
        Me.TreeListColumn5.FieldName = "S_TypeRemark"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.OptionsColumn.ReadOnly = True
        Me.TreeListColumn5.VisibleIndex = 1
        Me.TreeListColumn5.Width = 101
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "代號"
        Me.TreeListColumn6.FieldName = "S_TypeID"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.VisibleIndex = 2
        Me.TreeListColumn6.Width = 66
        '
        'txtDai
        '
        Me.txtDai.EnterMoveNextControl = True
        Me.txtDai.Location = New System.Drawing.Point(117, 117)
        Me.txtDai.Name = "txtDai"
        Me.txtDai.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDai.Properties.Appearance.Options.UseFont = True
        Me.txtDai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDai.Properties.Items.AddRange(New Object() {"A   合格", "B   暫存", "C   不合格"})
        Me.txtDai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDai.Size = New System.Drawing.Size(174, 24)
        Me.txtDai.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Location = New System.Drawing.Point(-10, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 62)
        Me.Panel1.TabIndex = 8
        Me.Panel1.TabStop = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(225, 15)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(76, 29)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "退出(&X)"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(126, 15)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(76, 29)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "查詢(&F)"
        '
        'frmSupplierSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 211)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDai)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.PopupContainerEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplierSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "供應商查詢"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PopupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtDai As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
