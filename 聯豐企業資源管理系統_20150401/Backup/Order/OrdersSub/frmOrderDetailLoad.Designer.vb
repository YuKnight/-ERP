<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDetailLoad
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GoIn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.OD_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OS_BatchID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OM_CusterNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_JiYu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OD_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OD_Detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BatchID = New DevExpress.XtraEditors.TextEdit
        Me.btnSelect = New DevExpress.XtraEditors.SimpleButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GoIn, Me.OD_ID, Me.OS_BatchID, Me.OM_CusterNO, Me.PM_JiYu, Me.OD_Name, Me.OD_Detail})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(543, 209)
        Me.DataGridView1.TabIndex = 5
        '
        'GoIn
        '
        Me.GoIn.HeaderText = "加入"
        Me.GoIn.Name = "GoIn"
        Me.GoIn.Visible = False
        Me.GoIn.Width = 50
        '
        'OD_ID
        '
        Me.OD_ID.DataPropertyName = "OD_ID"
        Me.OD_ID.HeaderText = "編號"
        Me.OD_ID.Name = "OD_ID"
        Me.OD_ID.Visible = False
        '
        'OS_BatchID
        '
        Me.OS_BatchID.DataPropertyName = "OS_BatchID"
        Me.OS_BatchID.HeaderText = "批次"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.ReadOnly = True
        Me.OS_BatchID.Width = 60
        '
        'OM_CusterNO
        '
        Me.OM_CusterNO.DataPropertyName = "OM_CusterNO"
        Me.OM_CusterNO.HeaderText = "客戶編號"
        Me.OM_CusterNO.Name = "OM_CusterNO"
        Me.OM_CusterNO.ReadOnly = True
        '
        'PM_JiYu
        '
        Me.PM_JiYu.DataPropertyName = "PM_JiYu"
        Me.PM_JiYu.HeaderText = strJIYU
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.ReadOnly = True
        Me.PM_JiYu.Width = 80
        '
        'OD_Name
        '
        Me.OD_Name.DataPropertyName = "OD_Name"
        Me.OD_Name.HeaderText = "項目名稱"
        Me.OD_Name.Name = "OD_Name"
        Me.OD_Name.ReadOnly = True
        Me.OD_Name.Width = 80
        '
        'OD_Detail
        '
        Me.OD_Detail.DataPropertyName = "OD_Detail"
        Me.OD_Detail.HeaderText = "項目內容"
        Me.OD_Detail.Name = "OD_Detail"
        Me.OD_Detail.ReadOnly = True
        Me.OD_Detail.Width = 180
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(351, 244)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(460, 244)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "取消(&C)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "產品編號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "批次編號(&I)："
        '
        'BatchID
        '
        Me.BatchID.Location = New System.Drawing.Point(351, 1)
        Me.BatchID.Name = "BatchID"
        Me.BatchID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchID.Properties.Appearance.Options.UseFont = True
        Me.BatchID.Size = New System.Drawing.Size(100, 22)
        Me.BatchID.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(461, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(74, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "查找(&F)"
        '
        'frmOrderDetailLoad
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(543, 273)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.BatchID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrderDetailLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "導入生成表"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BatchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSelect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GoIn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OD_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_BatchID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OM_CusterNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_JiYu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OD_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OD_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
