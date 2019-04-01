<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScanManagerMain
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.SF_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_Remark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_FileName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_Length = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_PerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SF_ActionName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.popScanManager = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popScanManagerDown = New System.Windows.Forms.ToolStripMenuItem
        Me.popScanManagerFind = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridUser = New System.Windows.Forms.DataGridView
        Me.U_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.U_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.popScanManagerScan = New System.Windows.Forms.ToolStripMenuItem
        Me.popScanManagerOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.popScanManagerDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popScanManagerEmail = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.popScanManagerRef = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popScanManager.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "掃描文件管理"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SF_No, Me.SF_Remark, Me.SF_FileName, Me.SF_Date, Me.SF_Length, Me.SF_PerName, Me.SF_ActionName})
        Me.Grid.ContextMenuStrip = Me.popScanManager
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(638, 544)
        Me.Grid.TabIndex = 31
        '
        'SF_No
        '
        Me.SF_No.DataPropertyName = "SF_No"
        Me.SF_No.HeaderText = "文件編號"
        Me.SF_No.Name = "SF_No"
        Me.SF_No.ReadOnly = True
        '
        'SF_Remark
        '
        Me.SF_Remark.DataPropertyName = "SF_Remark"
        Me.SF_Remark.HeaderText = "說明"
        Me.SF_Remark.Name = "SF_Remark"
        Me.SF_Remark.ReadOnly = True
        '
        'SF_FileName
        '
        Me.SF_FileName.DataPropertyName = "SF_FileName"
        Me.SF_FileName.HeaderText = "文件名"
        Me.SF_FileName.Name = "SF_FileName"
        Me.SF_FileName.ReadOnly = True
        '
        'SF_Date
        '
        Me.SF_Date.DataPropertyName = "SF_Date"
        Me.SF_Date.HeaderText = "掃描日期"
        Me.SF_Date.Name = "SF_Date"
        Me.SF_Date.ReadOnly = True
        '
        'SF_Length
        '
        Me.SF_Length.DataPropertyName = "SF_Length"
        Me.SF_Length.HeaderText = "大小"
        Me.SF_Length.Name = "SF_Length"
        Me.SF_Length.ReadOnly = True
        Me.SF_Length.Width = 80
        '
        'SF_PerName
        '
        Me.SF_PerName.DataPropertyName = "SF_PerName"
        Me.SF_PerName.HeaderText = "文件歸屬"
        Me.SF_PerName.Name = "SF_PerName"
        Me.SF_PerName.ReadOnly = True
        '
        'SF_ActionName
        '
        Me.SF_ActionName.DataPropertyName = "SF_ActionName"
        Me.SF_ActionName.HeaderText = "操作員"
        Me.SF_ActionName.Name = "SF_ActionName"
        Me.SF_ActionName.ReadOnly = True
        '
        'popScanManager
        '
        Me.popScanManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popScanManagerScan, Me.popScanManagerOpen, Me.popScanManagerDown, Me.popScanManagerDel, Me.popScanManagerFind, Me.popScanManagerRef, Me.popScanManagerEmail})
        Me.popScanManager.Name = "popScanManager"
        Me.popScanManager.Size = New System.Drawing.Size(232, 180)
        '
        'popScanManagerDown
        '
        Me.popScanManagerDown.Name = "popScanManagerDown"
        Me.popScanManagerDown.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerDown.Text = "下載(&L)..."
        '
        'popScanManagerFind
        '
        Me.popScanManagerFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popScanManagerFind.Name = "popScanManagerFind"
        Me.popScanManagerFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popScanManagerFind.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerFind.Text = "查詢(&F)..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridUser)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid)
        Me.SplitContainer1.Size = New System.Drawing.Size(839, 544)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 46
        '
        'GridUser
        '
        Me.GridUser.AllowUserToAddRows = False
        Me.GridUser.AllowUserToResizeRows = False
        Me.GridUser.BackgroundColor = System.Drawing.Color.White
        Me.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.U_ID, Me.U_Name})
        Me.GridUser.ContextMenuStrip = Me.popScanManager
        Me.GridUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridUser.EnableHeadersVisualStyles = False
        Me.GridUser.GridColor = System.Drawing.Color.Silver
        Me.GridUser.Location = New System.Drawing.Point(0, 0)
        Me.GridUser.MultiSelect = False
        Me.GridUser.Name = "GridUser"
        Me.GridUser.RowTemplate.Height = 24
        Me.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridUser.Size = New System.Drawing.Size(197, 544)
        Me.GridUser.TabIndex = 32
        '
        'U_ID
        '
        Me.U_ID.DataPropertyName = "U_ID"
        Me.U_ID.HeaderText = "編號"
        Me.U_ID.Name = "U_ID"
        Me.U_ID.Width = 75
        '
        'U_Name
        '
        Me.U_Name.DataPropertyName = "U_Name"
        Me.U_Name.HeaderText = "姓名"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.ReadOnly = True
        Me.U_Name.Width = 75
        '
        'popScanManagerScan
        '
        Me.popScanManagerScan.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.popScanManagerScan.Name = "popScanManagerScan"
        Me.popScanManagerScan.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerScan.Text = "掃描文件(&S)..."
        '
        'popScanManagerOpen
        '
        Me.popScanManagerOpen.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popScanManagerOpen.Name = "popScanManagerOpen"
        Me.popScanManagerOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popScanManagerOpen.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerOpen.Text = "查看文件(&W)..."
        '
        'popScanManagerDel
        '
        Me.popScanManagerDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popScanManagerDel.Name = "popScanManagerDel"
        Me.popScanManagerDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popScanManagerDel.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerDel.Text = "刪除(&D)"
        '
        'popScanManagerEmail
        '
        Me.popScanManagerEmail.Image = Global.LFERP.My.Resources.Resources.SharingOpenMailFolder
        Me.popScanManagerEmail.Name = "popScanManagerEmail"
        Me.popScanManagerEmail.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerEmail.Text = "Email轉發(&E)..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(839, 36)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'popScanManagerRef
        '
        Me.popScanManagerRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popScanManagerRef.Name = "popScanManagerRef"
        Me.popScanManagerRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popScanManagerRef.Size = New System.Drawing.Size(231, 22)
        Me.popScanManagerRef.Text = "刷新(&R)"
        '
        'frmScanManagerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 590)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmScanManagerMain"
        Me.Text = "掃描文件管理"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popScanManager.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents popScanManager As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popScanManagerScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popScanManagerOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popScanManagerDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popScanManagerEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridUser As System.Windows.Forms.DataGridView
    Friend WithEvents U_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents U_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popScanManagerDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SF_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_FileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_Length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_PerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SF_ActionName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popScanManagerFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popScanManagerRef As System.Windows.Forms.ToolStripMenuItem
End Class
