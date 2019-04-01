<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionFormula
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
        Me.components = New System.ComponentModel.Container
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("日薪")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("上班天數")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("平日加班")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("假日加班")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("字段名", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("+")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("-")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("*")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("/")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RoundEx()")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("运算符", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Me.TVwFiled = New System.Windows.Forms.TreeView
        Me.SimpButtonCheck = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabCaption = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.ComboFormulaName = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ConStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStrip = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FormulaName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TVwCalr = New System.Windows.Forms.TreeView
        Me.Labelxx = New System.Windows.Forms.Label
        Me.RichTextBoxFormula = New System.Windows.Forms.RichTextBox
        Me.Context2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StripCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.StripPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StripCut = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckAllow = New System.Windows.Forms.CheckBox
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboFormulaName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Context2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVwFiled
        '
        Me.TVwFiled.AllowDrop = True
        Me.TVwFiled.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVwFiled.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TVwFiled.Location = New System.Drawing.Point(173, 72)
        Me.TVwFiled.Name = "TVwFiled"
        TreeNode12.Name = "Node6"
        TreeNode12.Text = "日薪"
        TreeNode12.ToolTipText = "80"
        TreeNode13.Name = "Node7"
        TreeNode13.Text = "上班天數"
        TreeNode13.ToolTipText = "20"
        TreeNode14.Name = "Node10"
        TreeNode14.Text = "平日加班"
        TreeNode14.ToolTipText = "10"
        TreeNode15.Name = "Node11"
        TreeNode15.Text = "假日加班"
        TreeNode15.ToolTipText = "5"
        TreeNode16.Name = "Node4"
        TreeNode16.Text = "字段名"
        Me.TVwFiled.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.TVwFiled.Size = New System.Drawing.Size(196, 112)
        Me.TVwFiled.TabIndex = 33
        Me.TVwFiled.TabStop = False
        '
        'SimpButtonCheck
        '
        Me.SimpButtonCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpButtonCheck.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpButtonCheck.Appearance.Options.UseFont = True
        Me.SimpButtonCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.SimpButtonCheck.Location = New System.Drawing.Point(298, 333)
        Me.SimpButtonCheck.Name = "SimpButtonCheck"
        Me.SimpButtonCheck.Size = New System.Drawing.Size(80, 28)
        Me.SimpButtonCheck.TabIndex = 4
        Me.SimpButtonCheck.Text = "檢查(&C)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "公式名稱："
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.ForeColor = System.Drawing.Color.Navy
        Me.LabCaption.Location = New System.Drawing.Point(5, 7)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(230, 21)
        Me.LabCaption.TabIndex = 324
        Me.LabCaption.Text = "日薪工資計算公式編輯"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(0, 0)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(574, 36)
        Me.PicCaption.TabIndex = 323
        Me.PicCaption.TabStop = False
        '
        'ComboFormulaName
        '
        Me.ComboFormulaName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboFormulaName.Location = New System.Drawing.Point(245, 41)
        Me.ComboFormulaName.Name = "ComboFormulaName"
        Me.ComboFormulaName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboFormulaName.Properties.Appearance.Options.UseFont = True
        Me.ComboFormulaName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboFormulaName.Size = New System.Drawing.Size(270, 25)
        Me.ComboFormulaName.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(394, 333)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(486, 333)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "退出(&Q)"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ConStrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 39)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(168, 284)
        Me.Grid1.TabIndex = 329
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ConStrip
        '
        Me.ConStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStrip})
        Me.ConStrip.Name = "ConStrip"
        Me.ConStrip.Size = New System.Drawing.Size(160, 26)
        '
        'DelToolStrip
        '
        Me.DelToolStrip.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DelToolStrip.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.DelToolStrip.Name = "DelToolStrip"
        Me.DelToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DelToolStrip.Size = New System.Drawing.Size(159, 22)
        Me.DelToolStrip.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.FormulaName})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        '
        'FormulaName
        '
        Me.FormulaName.Caption = "公式名稱"
        Me.FormulaName.FieldName = "FormulaName"
        Me.FormulaName.Name = "FormulaName"
        Me.FormulaName.OptionsColumn.AllowEdit = False
        Me.FormulaName.Visible = True
        Me.FormulaName.VisibleIndex = 0
        '
        'TVwCalr
        '
        Me.TVwCalr.AllowDrop = True
        Me.TVwCalr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVwCalr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVwCalr.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TVwCalr.Location = New System.Drawing.Point(372, 72)
        Me.TVwCalr.Name = "TVwCalr"
        TreeNode17.Name = "Node12"
        TreeNode17.Text = "+"
        TreeNode18.Name = "Node13"
        TreeNode18.Text = "-"
        TreeNode19.Name = "Node14"
        TreeNode19.Text = "*"
        TreeNode20.Name = "Node15"
        TreeNode20.Text = "/"
        TreeNode21.Name = "Node0"
        TreeNode21.Text = "RoundEx()"
        TreeNode22.Name = "Node5"
        TreeNode22.Text = "运算符"
        Me.TVwCalr.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22})
        Me.TVwCalr.ShowNodeToolTips = True
        Me.TVwCalr.Size = New System.Drawing.Size(199, 112)
        Me.TVwCalr.TabIndex = 330
        Me.TVwCalr.TabStop = False
        '
        'Labelxx
        '
        Me.Labelxx.AutoSize = True
        Me.Labelxx.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Labelxx.Location = New System.Drawing.Point(287, 14)
        Me.Labelxx.Name = "Labelxx"
        Me.Labelxx.Size = New System.Drawing.Size(0, 12)
        Me.Labelxx.TabIndex = 331
        '
        'RichTextBoxFormula
        '
        Me.RichTextBoxFormula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxFormula.AutoWordSelection = True
        Me.RichTextBoxFormula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxFormula.ContextMenuStrip = Me.Context2
        Me.RichTextBoxFormula.EnableAutoDragDrop = True
        Me.RichTextBoxFormula.Location = New System.Drawing.Point(173, 190)
        Me.RichTextBoxFormula.Name = "RichTextBoxFormula"
        Me.RichTextBoxFormula.Size = New System.Drawing.Size(398, 133)
        Me.RichTextBoxFormula.TabIndex = 3
        Me.RichTextBoxFormula.Text = ""
        '
        'Context2
        '
        Me.Context2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripCopy, Me.StripPaste, Me.ToolStripSeparator1, Me.StripCut})
        Me.Context2.Name = "ContextMenuStrip1"
        Me.Context2.ShowImageMargin = False
        Me.Context2.Size = New System.Drawing.Size(167, 76)
        '
        'StripCopy
        '
        Me.StripCopy.Name = "StripCopy"
        Me.StripCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.StripCopy.Size = New System.Drawing.Size(166, 22)
        Me.StripCopy.Text = "   復制(&C)"
        '
        'StripPaste
        '
        Me.StripPaste.Name = "StripPaste"
        Me.StripPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.StripPaste.Size = New System.Drawing.Size(166, 22)
        Me.StripPaste.Text = "   粘貼(&V)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'StripCut
        '
        Me.StripCut.Name = "StripCut"
        Me.StripCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.StripCut.Size = New System.Drawing.Size(166, 22)
        Me.StripCut.Text = "   剪貼(&X)"
        '
        'CheckAllow
        '
        Me.CheckAllow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckAllow.AutoSize = True
        Me.CheckAllow.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckAllow.Location = New System.Drawing.Point(521, 45)
        Me.CheckAllow.Name = "CheckAllow"
        Me.CheckAllow.Size = New System.Drawing.Size(56, 19)
        Me.CheckAllow.TabIndex = 2
        Me.CheckAllow.Text = "啟用"
        Me.CheckAllow.UseVisualStyleBackColor = True
        '
        'frmProductionFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(574, 370)
        Me.Controls.Add(Me.CheckAllow)
        Me.Controls.Add(Me.RichTextBoxFormula)
        Me.Controls.Add(Me.Labelxx)
        Me.Controls.Add(Me.TVwCalr)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.ComboFormulaName)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PicCaption)
        Me.Controls.Add(Me.TVwFiled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpButtonCheck)
        Me.Name = "frmProductionFormula"
        Me.Text = "公式編輯"
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboFormulaName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Context2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TVwFiled As System.Windows.Forms.TreeView
    Friend WithEvents SimpButtonCheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents ComboFormulaName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TVwCalr As System.Windows.Forms.TreeView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FormulaName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Labelxx As System.Windows.Forms.Label
    Friend WithEvents ConStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBoxFormula As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckAllow As System.Windows.Forms.CheckBox
    Friend WithEvents Context2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StripCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StripPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StripCut As System.Windows.Forms.ToolStripMenuItem
End Class
