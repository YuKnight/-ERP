<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialParam
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dGrid = New System.Windows.Forms.DataGridView
        Me.ParamName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ParamGauge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dGrid2 = New System.Windows.Forms.DataGridView
        Me.ParamName1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ParamGauge1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRef = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dGrid
        '
        Me.dGrid.AllowUserToAddRows = False
        Me.dGrid.AllowUserToResizeRows = False
        Me.dGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dGrid.BackgroundColor = System.Drawing.Color.Silver
        Me.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParamName, Me.ParamGauge})
        Me.dGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dGrid.EnableHeadersVisualStyles = False
        Me.dGrid.Location = New System.Drawing.Point(295, 44)
        Me.dGrid.MultiSelect = False
        Me.dGrid.Name = "dGrid"
        Me.dGrid.RowHeadersVisible = False
        Me.dGrid.RowTemplate.Height = 24
        Me.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGrid.Size = New System.Drawing.Size(243, 447)
        Me.dGrid.TabIndex = 10
        '
        'ParamName
        '
        Me.ParamName.DataPropertyName = "ParamTypeName"
        Me.ParamName.HeaderText = "參數名稱"
        Me.ParamName.Name = "ParamName"
        Me.ParamName.ReadOnly = True
        '
        'ParamGauge
        '
        Me.ParamGauge.DataPropertyName = "ParamTypeGauge"
        Me.ParamGauge.HeaderText = "參數規格"
        Me.ParamGauge.Name = "ParamGauge"
        Me.ParamGauge.Width = 300
        '
        'dGrid2
        '
        Me.dGrid2.AllowUserToAddRows = False
        Me.dGrid2.AllowUserToDeleteRows = False
        Me.dGrid2.AllowUserToResizeRows = False
        Me.dGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGrid2.BackgroundColor = System.Drawing.Color.Silver
        Me.dGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParamName1, Me.ParamGauge1})
        Me.dGrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dGrid2.EnableHeadersVisualStyles = False
        Me.dGrid2.Location = New System.Drawing.Point(587, 44)
        Me.dGrid2.MultiSelect = False
        Me.dGrid2.Name = "dGrid2"
        Me.dGrid2.RowHeadersVisible = False
        Me.dGrid2.RowTemplate.Height = 24
        Me.dGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGrid2.Size = New System.Drawing.Size(140, 447)
        Me.dGrid2.TabIndex = 11
        Me.dGrid2.VirtualMode = True
        '
        'ParamName1
        '
        Me.ParamName1.DataPropertyName = "ParamName"
        Me.ParamName1.HeaderText = "參數名稱"
        Me.ParamName1.Name = "ParamName1"
        Me.ParamName1.ReadOnly = True
        Me.ParamName1.Width = 120
        '
        'ParamGauge1
        '
        Me.ParamGauge1.DataPropertyName = "ParamGauge"
        Me.ParamGauge1.HeaderText = "參數規格"
        Me.ParamGauge1.Name = "ParamGauge1"
        Me.ParamGauge1.Width = 300
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(544, 55)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(37, 41)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = ">"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(544, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 41)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(544, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 41)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(722, 36)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "物料規格設置"
        '
        'tv1
        '
        Me.tv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(5, 44)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(284, 447)
        Me.tv1.TabIndex = 23
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(509, 499)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 32)
        Me.cmdSave.TabIndex = 25
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(627, 499)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 32)
        Me.cmdExit.TabIndex = 26
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdRef
        '
        Me.cmdRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRef.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRef.Appearance.Options.UseFont = True
        Me.cmdRef.Location = New System.Drawing.Point(5, 497)
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.Size = New System.Drawing.Size(143, 32)
        Me.cmdRef.TabIndex = 27
        Me.cmdRef.Text = "刷新類型及參數(&R)"
        '
        'frmMaterialParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 536)
        Me.Controls.Add(Me.cmdRef)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.tv1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dGrid2)
        Me.Controls.Add(Me.dGrid)
        Me.Name = "frmMaterialParam"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "物料規格設置"
        CType(Me.dGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dGrid2 As System.Windows.Forms.DataGridView
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ParamName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParamGauge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParamName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParamGauge1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
