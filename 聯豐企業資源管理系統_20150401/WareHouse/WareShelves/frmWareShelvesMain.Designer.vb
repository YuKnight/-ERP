<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareShelvesMain
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("暫存區")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件區")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("驗貨區")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件倉", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("刀具區")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("待發區")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("底蓋倉", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8", New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7", New System.Windows.Forms.TreeNode() {TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node22")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node19", New System.Windows.Forms.TreeNode() {TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10", New System.Windows.Forms.TreeNode() {TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node23")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13", New System.Windows.Forms.TreeNode() {TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11", New System.Windows.Forms.TreeNode() {TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node24")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14", New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12", New System.Windows.Forms.TreeNode() {TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode17, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node25")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17", New System.Windows.Forms.TreeNode() {TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node27")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node21", New System.Windows.Forms.TreeNode() {TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node20", New System.Windows.Forms.TreeNode() {TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Me.Q_EditDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_CheckType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_AccCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Q_Currency = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Q_QuoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PN_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_SupplierNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Gauge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Q_Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AutoID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Q_AddDate
        '
        Me.Q_AddDate.DataPropertyName = "Q_AddDate"
        Me.Q_AddDate.HeaderText = "報價日期"
        Me.Q_AddDate.Name = "Q_AddDate"
        Me.Q_AddDate.ReadOnly = True
        Me.Q_AddDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_AddDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Q_Currency
        '
        Me.Q_Currency.DataPropertyName = "Q_Currency"
        Me.Q_Currency.HeaderText = "幣別"
        Me.Q_Currency.Name = "Q_Currency"
        Me.Q_Currency.ReadOnly = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid)
        Me.SplitContainer1.Size = New System.Drawing.Size(747, 513)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 40
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.tv1)
        Me.SplitContainer2.Size = New System.Drawing.Size(152, 513)
        Me.SplitContainer2.SplitterDistance = 122
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "暫存區"
        TreeNode2.Name = "Node4"
        TreeNode2.Text = "配件區"
        TreeNode3.Name = "Node5"
        TreeNode3.Text = "驗貨區"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "配件倉"
        TreeNode5.Name = "Node6"
        TreeNode5.Text = "刀具區"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "待發區"
        TreeNode7.Name = "Node1"
        TreeNode7.Text = "底蓋倉"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(152, 122)
        Me.TreeView1.TabIndex = 35
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
        TreeNode8.Name = "Node9"
        TreeNode8.Text = "Node9"
        TreeNode9.Name = "Node8"
        TreeNode9.Text = "Node8"
        TreeNode10.Name = "Node7"
        TreeNode10.Text = "Node7"
        TreeNode11.Name = "Node0"
        TreeNode11.Text = "Node0"
        TreeNode12.Name = "Node22"
        TreeNode12.Text = "Node22"
        TreeNode13.Name = "Node19"
        TreeNode13.Text = "Node19"
        TreeNode14.Name = "Node10"
        TreeNode14.Text = "Node10"
        TreeNode15.Name = "Node23"
        TreeNode15.Text = "Node23"
        TreeNode16.Name = "Node13"
        TreeNode16.Text = "Node13"
        TreeNode17.Name = "Node11"
        TreeNode17.Text = "Node11"
        TreeNode18.Name = "Node24"
        TreeNode18.Text = "Node24"
        TreeNode19.Name = "Node14"
        TreeNode19.Text = "Node14"
        TreeNode20.Name = "Node12"
        TreeNode20.Text = "Node12"
        TreeNode21.Name = "Node1"
        TreeNode21.Text = "Node1"
        TreeNode22.Name = "Node2"
        TreeNode22.Text = "Node2"
        TreeNode23.Name = "Node15"
        TreeNode23.Text = "Node15"
        TreeNode24.Name = "Node25"
        TreeNode24.Text = "Node25"
        TreeNode25.Name = "Node17"
        TreeNode25.Text = "Node17"
        TreeNode26.Name = "Node18"
        TreeNode26.Text = "Node18"
        TreeNode27.Name = "Node16"
        TreeNode27.Text = "Node16"
        TreeNode28.Name = "Node3"
        TreeNode28.Text = "Node3"
        TreeNode29.Name = "Node27"
        TreeNode29.Text = "Node27"
        TreeNode30.Name = "Node21"
        TreeNode30.Text = "Node21"
        TreeNode31.Name = "Node20"
        TreeNode31.Text = "Node20"
        TreeNode32.Name = "Node4"
        TreeNode32.Text = "Node4"
        TreeNode33.Name = "Node5"
        TreeNode33.Text = "Node5"
        TreeNode34.Name = "Node6"
        TreeNode34.Text = "Node6"
        Me.tv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode21, TreeNode22, TreeNode28, TreeNode32, TreeNode33, TreeNode34})
        Me.tv1.Size = New System.Drawing.Size(152, 387)
        Me.tv1.TabIndex = 34
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
        Me.Grid.Size = New System.Drawing.Size(591, 513)
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
        'Q_SupplierNo
        '
        Me.Q_SupplierNo.DataPropertyName = "Q_SupplierNo"
        Me.Q_SupplierNo.HeaderText = "供應商編號"
        Me.Q_SupplierNo.Name = "Q_SupplierNo"
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
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "貨架管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(747, 36)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'frmWareShelvesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 557)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareShelvesMain"
        Me.Text = "frmShelvesMain"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Q_EditDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_CheckType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_AccCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Q_Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Q_QuoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PN_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_SupplierNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Gauge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
