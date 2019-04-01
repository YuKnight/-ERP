<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialTypeManger
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
        Me.components = New System.ComponentModel.Container
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.cmenuMaterialType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmenuMaterialTypeAdd0 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmenuMaterialTypeAdd1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmenuMaterialTypeAdd2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmenuMaterialTypeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmenuMaterialTypeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdRef = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmenuMaterialType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tv1
        '
        Me.tv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.ContextMenuStrip = Me.cmenuMaterialType
        Me.tv1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(2, 46)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(471, 448)
        Me.tv1.TabIndex = 34
        '
        'cmenuMaterialType
        '
        Me.cmenuMaterialType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmenuMaterialType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmenuMaterialTypeAdd0, Me.cmenuMaterialTypeAdd1, Me.cmenuMaterialTypeAdd2, Me.cmenuMaterialTypeEdit, Me.cmenuMaterialTypeDel})
        Me.cmenuMaterialType.Name = "cmenuMaterialType"
        Me.cmenuMaterialType.Size = New System.Drawing.Size(214, 114)
        '
        'cmenuMaterialTypeAdd0
        '
        Me.cmenuMaterialTypeAdd0.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmenuMaterialTypeAdd0.Name = "cmenuMaterialTypeAdd0"
        Me.cmenuMaterialTypeAdd0.Size = New System.Drawing.Size(213, 22)
        Me.cmenuMaterialTypeAdd0.Text = "新增大類(&A)..."
        '
        'cmenuMaterialTypeAdd1
        '
        Me.cmenuMaterialTypeAdd1.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmenuMaterialTypeAdd1.Name = "cmenuMaterialTypeAdd1"
        Me.cmenuMaterialTypeAdd1.Size = New System.Drawing.Size(213, 22)
        Me.cmenuMaterialTypeAdd1.Text = "新增中類(&A)..."
        '
        'cmenuMaterialTypeAdd2
        '
        Me.cmenuMaterialTypeAdd2.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmenuMaterialTypeAdd2.Name = "cmenuMaterialTypeAdd2"
        Me.cmenuMaterialTypeAdd2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmenuMaterialTypeAdd2.Size = New System.Drawing.Size(213, 22)
        Me.cmenuMaterialTypeAdd2.Text = "新增小類(&A)..."
        '
        'cmenuMaterialTypeEdit
        '
        Me.cmenuMaterialTypeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmenuMaterialTypeEdit.Name = "cmenuMaterialTypeEdit"
        Me.cmenuMaterialTypeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmenuMaterialTypeEdit.Size = New System.Drawing.Size(213, 22)
        Me.cmenuMaterialTypeEdit.Text = "修改(&E)..."
        '
        'cmenuMaterialTypeDel
        '
        Me.cmenuMaterialTypeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmenuMaterialTypeDel.Name = "cmenuMaterialTypeDel"
        Me.cmenuMaterialTypeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmenuMaterialTypeDel.Size = New System.Drawing.Size(213, 22)
        Me.cmenuMaterialTypeDel.Text = "刪除(&D)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "物料類別設置"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(578, 36)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'cmdRef
        '
        Me.cmdRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRef.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRef.Appearance.Options.UseFont = True
        Me.cmdRef.Location = New System.Drawing.Point(479, 46)
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.Size = New System.Drawing.Size(101, 33)
        Me.cmdRef.TabIndex = 70
        Me.cmdRef.Text = "刷新(&R)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(479, 100)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(101, 33)
        Me.cmdExit.TabIndex = 69
        Me.cmdExit.Text = "取消(&C)"
        '
        'frmMaterialTypeManger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 498)
        Me.Controls.Add(Me.cmdRef)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.tv1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMaterialTypeManger"
        Me.ShowIcon = False
        Me.Text = "物料類別設置"
        Me.cmenuMaterialType.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmenuMaterialType As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmenuMaterialTypeAdd0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmenuMaterialTypeAdd1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmenuMaterialTypeAdd2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmenuMaterialTypeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmenuMaterialTypeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
End Class
