<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulaMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulaMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gridformula = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FormulaID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FormulaName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Formula_CH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RichTextBoxFormula = New System.Windows.Forms.RichTextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton
        Me.btncheck = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnRes = New DevExpress.XtraEditors.SimpleButton
        Me.txtformula = New DevExpress.XtraEditors.TextEdit
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.chkUsed = New DevExpress.XtraEditors.CheckEdit
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridformula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtformula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(921, 36)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "MRP自定義公式"
        '
        'gridformula
        '
        Me.gridformula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridformula.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridformula.EmbeddedNavigator.Name = ""
        Me.gridformula.Location = New System.Drawing.Point(0, 33)
        Me.gridformula.MainView = Me.GridView3
        Me.gridformula.Name = "gridformula"
        Me.gridformula.Size = New System.Drawing.Size(200, 622)
        Me.gridformula.TabIndex = 173
        Me.gridformula.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdDel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'cmdAdd
        '
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmdAdd.Text = "新增(&A)"
        '
        'cmdDel
        '
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(162, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.FormulaID, Me.FormulaName, Me.Formula_CH, Me.InCheck})
        Me.GridView3.GridControl = Me.gridformula
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "序號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowFocus = False
        '
        'FormulaID
        '
        Me.FormulaID.Caption = "公式ID"
        Me.FormulaID.FieldName = "FormulaID"
        Me.FormulaID.Name = "FormulaID"
        Me.FormulaID.OptionsColumn.AllowFocus = False
        '
        'FormulaName
        '
        Me.FormulaName.Caption = "公式名稱"
        Me.FormulaName.FieldName = "FormulaName"
        Me.FormulaName.Name = "FormulaName"
        Me.FormulaName.OptionsColumn.AllowEdit = False
        Me.FormulaName.OptionsColumn.AllowFocus = False
        Me.FormulaName.OptionsColumn.ReadOnly = True
        Me.FormulaName.Visible = True
        Me.FormulaName.VisibleIndex = 0
        Me.FormulaName.Width = 130
        '
        'Formula_CH
        '
        Me.Formula_CH.Caption = "公式"
        Me.Formula_CH.FieldName = "Formula_CH"
        Me.Formula_CH.Name = "Formula_CH"
        Me.Formula_CH.OptionsColumn.AllowFocus = False
        '
        'InCheck
        '
        Me.InCheck.Caption = "啟用"
        Me.InCheck.FieldName = "InCheck"
        Me.InCheck.Name = "InCheck"
        '
        'RichTextBoxFormula
        '
        Me.RichTextBoxFormula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxFormula.AutoWordSelection = True
        Me.RichTextBoxFormula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxFormula.EnableAutoDragDrop = True
        Me.RichTextBoxFormula.Location = New System.Drawing.Point(206, 359)
        Me.RichTextBoxFormula.Name = "RichTextBoxFormula"
        Me.RichTextBoxFormula.Size = New System.Drawing.Size(711, 294)
        Me.RichTextBoxFormula.TabIndex = 332
        Me.RichTextBoxFormula.Text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(0, 659)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(921, 36)
        Me.PictureBox2.TabIndex = 333
        Me.PictureBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(740, 662)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 30)
        Me.btnSave.TabIndex = 335
        Me.btnSave.Text = "保存(&S)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(831, 662)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 30)
        Me.btnExit.TabIndex = 336
        Me.btnExit.Text = "退出(&Q)"
        '
        'btncheck
        '
        Me.btncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncheck.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheck.Appearance.Options.UseFont = True
        Me.btncheck.Image = CType(resources.GetObject("btncheck.Image"), System.Drawing.Image)
        Me.btncheck.Location = New System.Drawing.Point(648, 662)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(87, 30)
        Me.btncheck.TabIndex = 334
        Me.btncheck.Text = "檢查(&C)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 337
        Me.Label3.Text = "公式名稱："
        '
        'btnRes
        '
        Me.btnRes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRes.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRes.Appearance.Options.UseFont = True
        Me.btnRes.Image = CType(resources.GetObject("btnRes.Image"), System.Drawing.Image)
        Me.btnRes.Location = New System.Drawing.Point(555, 662)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(87, 30)
        Me.btnRes.TabIndex = 339
        Me.btnRes.Text = "重置(&R)"
        '
        'txtformula
        '
        Me.txtformula.Location = New System.Drawing.Point(287, 40)
        Me.txtformula.Margin = New System.Windows.Forms.Padding(6)
        Me.txtformula.Name = "txtformula"
        Me.txtformula.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtformula.Properties.Appearance.Options.UseFont = True
        Me.txtformula.Size = New System.Drawing.Size(150, 24)
        Me.txtformula.TabIndex = 342
        '
        'TreeList1
        '
        Me.TreeList1.AllowDrop = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1})
        Me.TreeList1.Location = New System.Drawing.Point(206, 73)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.BeginUnboundLoad()
        Me.TreeList1.AppendNode(New Object() {"字段名"}, -1)
        Me.TreeList1.AppendNode(New Object() {"生產未領"}, 0)
        Me.TreeList1.AppendNode(New Object() {"在途數量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"安全庫存"}, 0)
        Me.TreeList1.AppendNode(New Object() {"待驗量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"訂貨批量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"庫存數量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"退貨數量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"最大訂購量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"最小訂購量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"最低庫存"}, 0)
        Me.TreeList1.AppendNode(New Object() {"經濟批量"}, 0)
        Me.TreeList1.AppendNode(New Object() {"總需求量"}, 0)
        Me.TreeList1.EndUnboundLoad()
        Me.TreeList1.OptionsBehavior.CanCloneNodesOnDrop = True
        Me.TreeList1.OptionsBehavior.DragNodes = True
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.TreeList1.Size = New System.Drawing.Size(168, 280)
        Me.TreeList1.TabIndex = 343
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "字段名"
        Me.TreeListColumn1.FieldName = "字段名"
        Me.TreeListColumn1.MinWidth = 46
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 226
        '
        'chkUsed
        '
        Me.chkUsed.Location = New System.Drawing.Point(455, 40)
        Me.chkUsed.Name = "chkUsed"
        Me.chkUsed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsed.Properties.Appearance.Options.UseFont = True
        Me.chkUsed.Properties.Caption = "啟用"
        Me.chkUsed.Size = New System.Drawing.Size(75, 24)
        Me.chkUsed.TabIndex = 344
        '
        'TreeList2
        '
        Me.TreeList2.AllowDrop = True
        Me.TreeList2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn2})
        Me.TreeList2.Location = New System.Drawing.Point(380, 73)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.BeginUnboundLoad()
        Me.TreeList2.AppendNode(New Object() {"運算符"}, -1)
        Me.TreeList2.AppendNode(New Object() {"+"}, 0)
        Me.TreeList2.AppendNode(New Object() {"-"}, 0)
        Me.TreeList2.AppendNode(New Object() {"*"}, 0)
        Me.TreeList2.AppendNode(New Object() {"/"}, 0)
        Me.TreeList2.AppendNode(New Object() {"%"}, 0)
        Me.TreeList2.AppendNode(New Object() {","}, 0)
        Me.TreeList2.AppendNode(New Object() {"("}, 0)
        Me.TreeList2.AppendNode(New Object() {")"}, 0)
        Me.TreeList2.AppendNode(New Object() {"RoundEx()"}, 0)
        Me.TreeList2.EndUnboundLoad()
        Me.TreeList2.OptionsBehavior.DragNodes = True
        Me.TreeList2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.TreeList2.Size = New System.Drawing.Size(537, 280)
        Me.TreeList2.TabIndex = 343
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "運算符"
        Me.TreeListColumn2.FieldName = "字段名"
        Me.TreeListColumn2.MinWidth = 46
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        Me.TreeListColumn2.VisibleIndex = 0
        Me.TreeListColumn2.Width = 226
        '
        'frmFormulaMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 696)
        Me.Controls.Add(Me.chkUsed)
        Me.Controls.Add(Me.txtformula)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBoxFormula)
        Me.Controls.Add(Me.gridformula)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmFormulaMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP自定义公式"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridformula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtformula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridformula As DevExpress.XtraGrid.GridControl
    Friend WithEvents RichTextBoxFormula As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FormulaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FormulaName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Formula_CH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtformula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents chkUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
