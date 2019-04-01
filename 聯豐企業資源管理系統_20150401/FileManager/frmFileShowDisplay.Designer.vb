<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileShowDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileShowDisplay))
        Me.popFileShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popFileShowOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.F_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_OldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.popFileShow.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'popFileShow
        '
        Me.popFileShow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popFileShowOpen})
        Me.popFileShow.Name = "popFileShow"
        Me.popFileShow.Size = New System.Drawing.Size(157, 26)
        '
        'popFileShowOpen
        '
        Me.popFileShowOpen.Image = Global.LFERP.My.Resources.Resources.folder_documents_blue_icon
        Me.popFileShowOpen.Name = "popFileShowOpen"
        Me.popFileShowOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.popFileShowOpen.Size = New System.Drawing.Size(156, 22)
        Me.popFileShowOpen.Text = "打開(&O)..."
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F_No, Me.F_OldName, Me.F_Name, Me.F_Detail, Me.F_AddDate, Me.F_Action})
        Me.Grid.ContextMenuStrip = Me.popFileShow
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.Location = New System.Drawing.Point(2, 42)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(539, 273)
        Me.Grid.TabIndex = 0
        '
        'F_No
        '
        Me.F_No.DataPropertyName = "F_No"
        Me.F_No.HeaderText = "文件編號"
        Me.F_No.Name = "F_No"
        Me.F_No.ReadOnly = True
        '
        'F_OldName
        '
        Me.F_OldName.DataPropertyName = "F_OldName"
        Me.F_OldName.HeaderText = "文件名"
        Me.F_OldName.Name = "F_OldName"
        Me.F_OldName.ReadOnly = True
        '
        'F_Name
        '
        Me.F_Name.DataPropertyName = "F_Name"
        Me.F_Name.HeaderText = "文件名稱"
        Me.F_Name.Name = "F_Name"
        Me.F_Name.ReadOnly = True
        '
        'F_Detail
        '
        Me.F_Detail.DataPropertyName = "F_Detail"
        Me.F_Detail.HeaderText = "文件內容"
        Me.F_Detail.Name = "F_Detail"
        Me.F_Detail.ReadOnly = True
        Me.F_Detail.Width = 300
        '
        'F_AddDate
        '
        Me.F_AddDate.DataPropertyName = "F_AddDate"
        Me.F_AddDate.HeaderText = "上傳日期"
        Me.F_AddDate.Name = "F_AddDate"
        Me.F_AddDate.ReadOnly = True
        '
        'F_Action
        '
        Me.F_Action.DataPropertyName = "F_Action"
        Me.F_Action.HeaderText = "操作員"
        Me.F_Action.Name = "F_Action"
        Me.F_Action.ReadOnly = True
        Me.F_Action.Width = 80
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "模塊內單號"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(440, 321)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 28)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "取消(&C)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "文件查看"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "模塊編號"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 36)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'frmFileShowDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFileShowDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件查看"
        Me.popFileShow.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents popFileShow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popFileShowOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents F_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
