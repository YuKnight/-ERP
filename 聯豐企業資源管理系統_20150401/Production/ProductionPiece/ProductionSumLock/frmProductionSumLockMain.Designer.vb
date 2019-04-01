<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionSumLockMain
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProductionSumLockAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ProductionSumLockModif = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemref = New System.Windows.Forms.ToolStripMenuItem
        Me.msgLabel = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LockYYYYMM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LockCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductionSumLockAdd, Me.ToolStripSeparator1, Me.ProductionSumLockModif, Me.ToolStripMenuItem1, Me.ToolStripMenuItemref})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 82)
        '
        'ProductionSumLockAdd
        '
        Me.ProductionSumLockAdd.Image = Global.LFERP.My.Resources.Resources.OutlinePromote
        Me.ProductionSumLockAdd.Name = "ProductionSumLockAdd"
        Me.ProductionSumLockAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ProductionSumLockAdd.Size = New System.Drawing.Size(171, 22)
        Me.ProductionSumLockAdd.Text = "鎖定(&I)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'ProductionSumLockModif
        '
        Me.ProductionSumLockModif.Image = Global.LFERP.My.Resources.Resources.OutlineDemote
        Me.ProductionSumLockModif.Name = "ProductionSumLockModif"
        Me.ProductionSumLockModif.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ProductionSumLockModif.Size = New System.Drawing.Size(171, 22)
        Me.ProductionSumLockModif.Text = "取消鎖定(&Q)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'ToolStripMenuItemref
        '
        Me.ToolStripMenuItemref.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ToolStripMenuItemref.Name = "ToolStripMenuItemref"
        Me.ToolStripMenuItemref.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemref.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripMenuItemref.Text = "刷新(&R)"
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Location = New System.Drawing.Point(198, 16)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(37, 12)
        Me.msgLabel.TabIndex = 43
        Me.msgLabel.Text = "Label2"
        Me.msgLabel.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(193, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(470, 411)
        Me.GridControl1.TabIndex = 42
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.FacName, Me.DepName, Me.LockYYYYMM, Me.LockCheck, Me.AddDate, Me.U_Name, Me.FacID, Me.DepID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        Me.AutoID.Visible = True
        Me.AutoID.VisibleIndex = 0
        '
        'FacName
        '
        Me.FacName.Caption = "廠別"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.OptionsColumn.ReadOnly = True
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 1
        '
        'DepName
        '
        Me.DepName.Caption = "部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.OptionsColumn.ReadOnly = True
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 2
        '
        'LockYYYYMM
        '
        Me.LockYYYYMM.Caption = "鎖定月份"
        Me.LockYYYYMM.FieldName = "LockYYYYMM"
        Me.LockYYYYMM.Name = "LockYYYYMM"
        Me.LockYYYYMM.OptionsColumn.ReadOnly = True
        Me.LockYYYYMM.Visible = True
        Me.LockYYYYMM.VisibleIndex = 3
        '
        'LockCheck
        '
        Me.LockCheck.Caption = "鎖定狀態"
        Me.LockCheck.FieldName = "LockCheck"
        Me.LockCheck.Name = "LockCheck"
        Me.LockCheck.OptionsColumn.ReadOnly = True
        Me.LockCheck.Visible = True
        Me.LockCheck.VisibleIndex = 4
        '
        'AddDate
        '
        Me.AddDate.Caption = "操作日期"
        Me.AddDate.FieldName = "AddDate"
        Me.AddDate.Name = "AddDate"
        Me.AddDate.OptionsColumn.ReadOnly = True
        Me.AddDate.Visible = True
        Me.AddDate.VisibleIndex = 5
        '
        'U_Name
        '
        Me.U_Name.Caption = "操作人"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.OptionsColumn.ReadOnly = True
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 6
        '
        'FacID
        '
        Me.FacID.Caption = "GridColumn1"
        Me.FacID.FieldName = "FacID"
        Me.FacID.Name = "FacID"
        '
        'DepID
        '
        Me.DepID.Caption = "GridColumn2"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        '
        'TreeList2
        '
        Me.TreeList2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6})
        Me.TreeList2.CustomizationFormBounds = New System.Drawing.Rectangle(806, 465, 208, 175)
        Me.TreeList2.KeyFieldName = "DepID"
        Me.TreeList2.Location = New System.Drawing.Point(1, 41)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.OptionsBehavior.Editable = False
        Me.TreeList2.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeList2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.TreeList2.OptionsView.ShowHorzLines = False
        Me.TreeList2.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList2.OptionsView.ShowIndicator = False
        Me.TreeList2.OptionsView.ShowVertLines = False
        Me.TreeList2.ParentFieldName = "DepPID"
        Me.TreeList2.Size = New System.Drawing.Size(188, 412)
        Me.TreeList2.TabIndex = 41
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "部門編號"
        Me.TreeListColumn4.FieldName = "DepID"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.AllowEdit = False
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "部門名稱"
        Me.TreeListColumn5.FieldName = "DepName"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.OptionsColumn.AllowEdit = False
        Me.TreeListColumn5.VisibleIndex = 0
        Me.TreeListColumn5.Width = 126
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "部門父ID"
        Me.TreeListColumn6.FieldName = "DepPID"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.OptionsColumn.AllowEdit = False
        Me.TreeListColumn6.Width = 126
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "計件錄入鎖定"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(661, 36)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'frmProductionSumLockMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 456)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionSumLockMain"
        Me.Text = "計件錄入鎖定"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProductionSumLockAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductionSumLockModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemref As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LockYYYYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LockCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
