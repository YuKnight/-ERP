<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuotationTemp
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Q_QuoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Depict = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_ActionName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Q_AccCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "物料編碼"
        Me.Label3.Visible = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Q_QuoID, Me.Q_SupplierName, Me.Q_Price, Me.Q_Depict, Me.Q_ActionName, Me.Q_AddDate, Me.Q_Check, Me.Q_AccCheck})
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.Location = New System.Drawing.Point(1, 35)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersWidth = 10
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(643, 219)
        Me.Grid.TabIndex = 85
        '
        'Q_QuoID
        '
        Me.Q_QuoID.DataPropertyName = "Q_QuoID"
        Me.Q_QuoID.HeaderText = "報價單"
        Me.Q_QuoID.Name = "Q_QuoID"
        Me.Q_QuoID.Width = 80
        '
        'Q_SupplierName
        '
        Me.Q_SupplierName.DataPropertyName = "Q_SupplierName"
        Me.Q_SupplierName.HeaderText = "供應商"
        Me.Q_SupplierName.Name = "Q_SupplierName"
        Me.Q_SupplierName.Width = 80
        '
        'Q_Price
        '
        Me.Q_Price.DataPropertyName = "Q_Price"
        Me.Q_Price.HeaderText = "單價"
        Me.Q_Price.Name = "Q_Price"
        Me.Q_Price.ReadOnly = True
        Me.Q_Price.Width = 60
        '
        'Q_Depict
        '
        Me.Q_Depict.DataPropertyName = "Q_Depict"
        Me.Q_Depict.HeaderText = "備注"
        Me.Q_Depict.Name = "Q_Depict"
        '
        'Q_ActionName
        '
        Me.Q_ActionName.DataPropertyName = "Q_ActionName"
        Me.Q_ActionName.HeaderText = "報價員"
        Me.Q_ActionName.Name = "Q_ActionName"
        Me.Q_ActionName.Width = 70
        '
        'Q_AddDate
        '
        Me.Q_AddDate.DataPropertyName = "Q_AddDate"
        Me.Q_AddDate.HeaderText = "報價日期"
        Me.Q_AddDate.Name = "Q_AddDate"
        Me.Q_AddDate.Width = 80
        '
        'Q_Check
        '
        Me.Q_Check.DataPropertyName = "Q_Check"
        Me.Q_Check.HeaderText = "部門審核"
        Me.Q_Check.Name = "Q_Check"
        Me.Q_Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Q_Check.Width = 80
        '
        'Q_AccCheck
        '
        Me.Q_AccCheck.DataPropertyName = "Q_AccCheck"
        Me.Q_AccCheck.HeaderText = "審計審核"
        Me.Q_AccCheck.Name = "Q_AccCheck"
        Me.Q_AccCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_AccCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Q_AccCheck.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "報價記錄"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(129, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "名稱"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(555, 260)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 27)
        Me.cmdSave.TabIndex = 84
        Me.cmdSave.Text = "關閉(&C)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(643, 28)
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'FrmQuotationTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSave
        Me.ClientSize = New System.Drawing.Size(647, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmQuotationTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "報價記錄"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Q_QuoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_SupplierName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Depict As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_ActionName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Q_AccCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
