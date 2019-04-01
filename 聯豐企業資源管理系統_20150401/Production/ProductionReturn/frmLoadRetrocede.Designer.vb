<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadRetrocede
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdInsert = New DevExpress.XtraEditors.SimpleButton
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAll = New DevExpress.XtraEditors.SimpleButton
        Me.GoIn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Pro_Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_M_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_NoSendQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndexNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(104, 420)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 14)
        Me.LabelControl1.TabIndex = 253
        Me.LabelControl1.Text = "註:默認一個月"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 21)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "裝配退貨單(未退完)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(713, 37)
        Me.PictureBox1.TabIndex = 251
        Me.PictureBox1.TabStop = False
        '
        'cmdInsert
        '
        Me.cmdInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInsert.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.Appearance.Options.UseFont = True
        Me.cmdInsert.Location = New System.Drawing.Point(524, 412)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(75, 28)
        Me.cmdInsert.TabIndex = 250
        Me.cmdInsert.Text = "確定(&S)"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GoIn, Me.Pro_Type, Me.R_NO, Me.PM_M_Code, Me.PM_Type, Me.R_Date, Me.R_Qty, Me.R_NoSendQty, Me.IndexNO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.Location = New System.Drawing.Point(3, 43)
        Me.Grid.Name = "Grid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(711, 363)
        Me.Grid.TabIndex = 249
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(620, 412)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 248
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdAll
        '
        Me.cmdAll.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAll.Appearance.Options.UseFont = True
        Me.cmdAll.Location = New System.Drawing.Point(14, 412)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(74, 28)
        Me.cmdAll.TabIndex = 247
        Me.cmdAll.Text = "載入全部"
        '
        'GoIn
        '
        Me.GoIn.HeaderText = "加入"
        Me.GoIn.Name = "GoIn"
        Me.GoIn.Width = 50
        '
        'Pro_Type
        '
        Me.Pro_Type.DataPropertyName = "Pro_Type"
        Me.Pro_Type.HeaderText = "工藝類型"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.ReadOnly = True
        Me.Pro_Type.Visible = False
        '
        'R_NO
        '
        Me.R_NO.DataPropertyName = "R_NO"
        Me.R_NO.HeaderText = "退貨單"
        Me.R_NO.Name = "R_NO"
        Me.R_NO.ReadOnly = True
        '
        'PM_M_Code
        '
        Me.PM_M_Code.DataPropertyName = "PM_M_Code"
        Me.PM_M_Code.HeaderText = "產品編號"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.ReadOnly = True
        Me.PM_M_Code.Width = 120
        '
        'PM_Type
        '
        Me.PM_Type.DataPropertyName = "PM_Type"
        Me.PM_Type.HeaderText = "類型"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.ReadOnly = True
        Me.PM_Type.Width = 120
        '
        'R_Date
        '
        Me.R_Date.DataPropertyName = "R_Date"
        Me.R_Date.HeaderText = "退貨日期"
        Me.R_Date.Name = "R_Date"
        Me.R_Date.ReadOnly = True
        '
        'R_Qty
        '
        Me.R_Qty.DataPropertyName = "R_Qty"
        Me.R_Qty.HeaderText = "退貨數量"
        Me.R_Qty.Name = "R_Qty"
        Me.R_Qty.ReadOnly = True
        Me.R_Qty.Width = 85
        '
        'R_NoSendQty
        '
        Me.R_NoSendQty.DataPropertyName = "R_NoSendQty"
        Me.R_NoSendQty.HeaderText = "未退還數"
        Me.R_NoSendQty.Name = "R_NoSendQty"
        Me.R_NoSendQty.ReadOnly = True
        Me.R_NoSendQty.Width = 85
        '
        'IndexNO
        '
        Me.IndexNO.DataPropertyName = "IndexNO"
        Me.IndexNO.HeaderText = "流水號"
        Me.IndexNO.Name = "IndexNO"
        Me.IndexNO.ReadOnly = True
        Me.IndexNO.Visible = False
        '
        'frmLoadRetrocede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAll)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadRetrocede"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "導入單號"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdInsert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GoIn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Pro_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_M_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NoSendQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexNO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
