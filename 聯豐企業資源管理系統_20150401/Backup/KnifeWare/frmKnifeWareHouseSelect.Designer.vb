<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareHouseSelect
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("暫存區")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件區")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("驗貨區")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("配件倉", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("刀具區")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("待發區")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("底蓋倉", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Me.Labelxx = New System.Windows.Forms.Label
        Me.tw = New System.Windows.Forms.TreeView
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'Labelxx
        '
        Me.Labelxx.AutoSize = True
        Me.Labelxx.Location = New System.Drawing.Point(1, 156)
        Me.Labelxx.Name = "Labelxx"
        Me.Labelxx.Size = New System.Drawing.Size(37, 12)
        Me.Labelxx.TabIndex = 80
        Me.Labelxx.Text = "Label1"
        '
        'tw
        '
        Me.tw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tw.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tw.FullRowSelect = True
        Me.tw.HideSelection = False
        Me.tw.Location = New System.Drawing.Point(1, 0)
        Me.tw.Name = "tw"
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
        Me.tw.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Me.tw.Size = New System.Drawing.Size(197, 153)
        Me.tw.TabIndex = 77
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(41, 157)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 23)
        Me.cmdSave.TabIndex = 79
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(121, 157)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 23)
        Me.cmdExit.TabIndex = 78
        Me.cmdExit.Text = "取消(&C)"
        '
        'frmKnifeWareHouseSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 187)
        Me.Controls.Add(Me.Labelxx)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.tw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKnifeWareHouseSelect"
        Me.Text = "倉庫選擇"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelxx As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tw As System.Windows.Forms.TreeView
End Class
