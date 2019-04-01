<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareShelvesOut
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7", New System.Windows.Forms.TreeNode() {TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node22")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node19", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node23")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13", New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11", New System.Windows.Forms.TreeNode() {TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node24")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14", New System.Windows.Forms.TreeNode() {TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12", New System.Windows.Forms.TreeNode() {TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode10, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node25")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17", New System.Windows.Forms.TreeNode() {TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node27")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node21", New System.Windows.Forms.TreeNode() {TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node20", New System.Windows.Forms.TreeNode() {TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Me.Q_SupplierNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Q_QuoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PN_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Gauge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_CheckType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_AccCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Q_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_EditDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Currency = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AutoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q_SupplierNo
        '
        Me.Q_SupplierNo.DataPropertyName = "Q_SupplierNo"
        Me.Q_SupplierNo.HeaderText = "供應商編號"
        Me.Q_SupplierNo.Name = "Q_SupplierNo"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Q_QuoID, Me.CO_ID, Me.PN_NO, Me.Q_Supplier, Me.Q_SupplierNo, Me.M_Name, Me.M_Gauge, Me.Q_Price, Me.M_Unit, Me.Q_CheckType, Me.Q_AccCheck, Me.Q_AddDate, Me.Q_EditDate, Me.Q_Action, Me.Q_Currency, Me.AutoID})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(430, 272)
        Me.Grid.TabIndex = 31
        '
        'Q_QuoID
        '
        Me.Q_QuoID.DataPropertyName = "Q_QuoID"
        Me.Q_QuoID.HeaderText = "報價單編號"
        Me.Q_QuoID.Name = "Q_QuoID"
        '
        'CO_ID
        '
        Me.CO_ID.DataPropertyName = "CO_ID"
        Me.CO_ID.HeaderText = "公司代號"
        Me.CO_ID.Name = "CO_ID"
        Me.CO_ID.ReadOnly = True
        Me.CO_ID.Visible = False
        '
        'PN_NO
        '
        Me.PN_NO.DataPropertyName = "PN_NO"
        Me.PN_NO.HeaderText = "申購單號"
        Me.PN_NO.Name = "PN_NO"
        '
        'Q_Supplier
        '
        Me.Q_Supplier.DataPropertyName = "Q_Supplier"
        Me.Q_Supplier.HeaderText = "供應商"
        Me.Q_Supplier.Name = "Q_Supplier"
        '
        'M_Name
        '
        Me.M_Name.DataPropertyName = "M_Name"
        Me.M_Name.HeaderText = "名稱"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.ReadOnly = True
        '
        'M_Gauge
        '
        Me.M_Gauge.DataPropertyName = "M_Gauge"
        Me.M_Gauge.HeaderText = "規格"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.ReadOnly = True
        Me.M_Gauge.Width = 200
        '
        'Q_Price
        '
        Me.Q_Price.DataPropertyName = "Q_Price"
        Me.Q_Price.HeaderText = "報價"
        Me.Q_Price.Name = "Q_Price"
        '
        'M_Unit
        '
        Me.M_Unit.DataPropertyName = "M_Unit"
        Me.M_Unit.HeaderText = "單位"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.ReadOnly = True
        Me.M_Unit.Width = 70
        '
        'Q_CheckType
        '
        Me.Q_CheckType.DataPropertyName = "Q_CheckType"
        Me.Q_CheckType.HeaderText = "部門審核類型"
        Me.Q_CheckType.Name = "Q_CheckType"
        Me.Q_CheckType.Width = 120
        '
        'Q_AccCheck
        '
        Me.Q_AccCheck.DataPropertyName = "Q_AccCheck"
        Me.Q_AccCheck.HeaderText = "會計部審核"
        Me.Q_AccCheck.Name = "Q_AccCheck"
        Me.Q_AccCheck.ReadOnly = True
        '
        'Q_AddDate
        '
        Me.Q_AddDate.DataPropertyName = "Q_AddDate"
        Me.Q_AddDate.HeaderText = "報價日期"
        Me.Q_AddDate.Name = "Q_AddDate"
        Me.Q_AddDate.ReadOnly = True
        Me.Q_AddDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_AddDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Q_EditDate
        '
        Me.Q_EditDate.DataPropertyName = "Q_EditDate"
        Me.Q_EditDate.HeaderText = "修改日期"
        Me.Q_EditDate.Name = "Q_EditDate"
        Me.Q_EditDate.ReadOnly = True
        Me.Q_EditDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_EditDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Q_Action
        '
        Me.Q_Action.DataPropertyName = "Q_Action"
        Me.Q_Action.HeaderText = "報價員"
        Me.Q_Action.Name = "Q_Action"
        Me.Q_Action.ReadOnly = True
        Me.Q_Action.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Q_Currency
        '
        Me.Q_Currency.DataPropertyName = "Q_Currency"
        Me.Q_Currency.HeaderText = "幣別"
        Me.Q_Currency.Name = "Q_Currency"
        Me.Q_Currency.ReadOnly = True
        '
        'AutoID
        '
        Me.AutoID.DataPropertyName = "AutoID"
        Me.AutoID.HeaderText = "單號"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "出庫貨架選擇"
        '
        'tv1
        '
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        TreeNode1.Name = "Node9"
        TreeNode1.Text = "Node9"
        TreeNode2.Name = "Node8"
        TreeNode2.Text = "Node8"
        TreeNode3.Name = "Node7"
        TreeNode3.Text = "Node7"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Node0"
        TreeNode5.Name = "Node22"
        TreeNode5.Text = "Node22"
        TreeNode6.Name = "Node19"
        TreeNode6.Text = "Node19"
        TreeNode7.Name = "Node10"
        TreeNode7.Text = "Node10"
        TreeNode8.Name = "Node23"
        TreeNode8.Text = "Node23"
        TreeNode9.Name = "Node13"
        TreeNode9.Text = "Node13"
        TreeNode10.Name = "Node11"
        TreeNode10.Text = "Node11"
        TreeNode11.Name = "Node24"
        TreeNode11.Text = "Node24"
        TreeNode12.Name = "Node14"
        TreeNode12.Text = "Node14"
        TreeNode13.Name = "Node12"
        TreeNode13.Text = "Node12"
        TreeNode14.Name = "Node1"
        TreeNode14.Text = "Node1"
        TreeNode15.Name = "Node2"
        TreeNode15.Text = "Node2"
        TreeNode16.Name = "Node15"
        TreeNode16.Text = "Node15"
        TreeNode17.Name = "Node25"
        TreeNode17.Text = "Node25"
        TreeNode18.Name = "Node17"
        TreeNode18.Text = "Node17"
        TreeNode19.Name = "Node18"
        TreeNode19.Text = "Node18"
        TreeNode20.Name = "Node16"
        TreeNode20.Text = "Node16"
        TreeNode21.Name = "Node3"
        TreeNode21.Text = "Node3"
        TreeNode22.Name = "Node27"
        TreeNode22.Text = "Node27"
        TreeNode23.Name = "Node21"
        TreeNode23.Text = "Node21"
        TreeNode24.Name = "Node20"
        TreeNode24.Text = "Node20"
        TreeNode25.Name = "Node4"
        TreeNode25.Text = "Node4"
        TreeNode26.Name = "Node5"
        TreeNode26.Text = "Node5"
        TreeNode27.Name = "Node6"
        TreeNode27.Text = "Node6"
        Me.tv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode14, TreeNode15, TreeNode21, TreeNode25, TreeNode26, TreeNode27})
        Me.tv1.Size = New System.Drawing.Size(128, 272)
        Me.tv1.TabIndex = 34
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid)
        Me.SplitContainer1.Size = New System.Drawing.Size(562, 272)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(562, 32)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(396, 314)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 160
        Me.cmdSave.Text = "確定"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(491, 314)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 159
        Me.cmdExit.Text = "取消"
        '
        'frmWareShelvesOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWareShelvesOut"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWareShelvesSelect"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Q_SupplierNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Q_QuoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PN_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Gauge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_CheckType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_AccCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Q_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_EditDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
End Class
