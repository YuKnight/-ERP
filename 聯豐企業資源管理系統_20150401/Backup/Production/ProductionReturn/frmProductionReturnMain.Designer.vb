<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionReturnMain
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmstrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReturnAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ReturnEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ReturnPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ReturnCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripIncheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AR_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmstrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.cmstrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(670, 377)
        Me.Grid1.TabIndex = 6
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmstrip
        '
        Me.cmstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnAdd, Me.ToolStripSeparator1, Me.ReturnEdit, Me.ReturnDel, Me.ToolStripSeparator2, Me.ReturnPreView, Me.ReturnQuery, Me.ReturnRef, Me.ToolStripSeparator4, Me.ReturnCheck, Me.ToolStripSeparator3, Me.ToolStripIncheck, Me.ReturnPrint})
        Me.cmstrip.Name = "cmstrip"
        Me.cmstrip.Size = New System.Drawing.Size(221, 226)
        '
        'ReturnAdd
        '
        Me.ReturnAdd.Enabled = False
        Me.ReturnAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ReturnAdd.Name = "ReturnAdd"
        Me.ReturnAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ReturnAdd.Size = New System.Drawing.Size(220, 22)
        Me.ReturnAdd.Text = "新增退貨-送貨單(&A)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'ReturnEdit
        '
        Me.ReturnEdit.Enabled = False
        Me.ReturnEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ReturnEdit.Name = "ReturnEdit"
        Me.ReturnEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ReturnEdit.Size = New System.Drawing.Size(220, 22)
        Me.ReturnEdit.Text = "修改(&E)..."
        '
        'ReturnDel
        '
        Me.ReturnDel.Enabled = False
        Me.ReturnDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.ReturnDel.Name = "ReturnDel"
        Me.ReturnDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ReturnDel.Size = New System.Drawing.Size(220, 22)
        Me.ReturnDel.Text = "刪除(&D)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(217, 6)
        '
        'ReturnPreView
        '
        Me.ReturnPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.ReturnPreView.Name = "ReturnPreView"
        Me.ReturnPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ReturnPreView.Size = New System.Drawing.Size(220, 22)
        Me.ReturnPreView.Text = "查看(&W)..."
        '
        'ReturnQuery
        '
        Me.ReturnQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.ReturnQuery.Name = "ReturnQuery"
        Me.ReturnQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ReturnQuery.Size = New System.Drawing.Size(220, 22)
        Me.ReturnQuery.Text = "查詢(&F)..."
        '
        'ReturnRef
        '
        Me.ReturnRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ReturnRef.Name = "ReturnRef"
        Me.ReturnRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReturnRef.Size = New System.Drawing.Size(220, 22)
        Me.ReturnRef.Text = "刷新(&R)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(217, 6)
        '
        'ReturnCheck
        '
        Me.ReturnCheck.Enabled = False
        Me.ReturnCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.ReturnCheck.Name = "ReturnCheck"
        Me.ReturnCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ReturnCheck.Size = New System.Drawing.Size(220, 22)
        Me.ReturnCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(217, 6)
        '
        'ToolStripIncheck
        '
        Me.ToolStripIncheck.Enabled = False
        Me.ToolStripIncheck.Name = "ToolStripIncheck"
        Me.ToolStripIncheck.Size = New System.Drawing.Size(220, 22)
        Me.ToolStripIncheck.Text = "收料審核"
        '
        'ReturnPrint
        '
        Me.ReturnPrint.Enabled = False
        Me.ReturnPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ReturnPrint.Name = "ReturnPrint"
        Me.ReturnPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ReturnPrint.Size = New System.Drawing.Size(220, 22)
        Me.ReturnPrint.Text = "送貨單(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn9, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.GridColumn6, Me.GridColumn12, Me.AR_InCheck})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "送貨單號"
        Me.GridColumn1.FieldName = "AR_NO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 85
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "退貨單號"
        Me.GridColumn5.FieldName = "R_NO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "工藝類型"
        Me.GridColumn2.FieldName = "Pro_Type"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "產品編號"
        Me.GridColumn3.FieldName = "PM_M_Code"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "類型"
        Me.GridColumn4.FieldName = "PM_Type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "數量"
        Me.GridColumn7.FieldName = "AR_Qty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "收料倉庫"
        Me.GridColumn9.FieldName = "WH_InName"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "備註"
        Me.GridColumn8.FieldName = "AR_Remark"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 100
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "送貨倉庫"
        Me.GridColumn10.FieldName = "WH_ID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "送貨類型"
        Me.GridColumn11.FieldName = "AR_Type"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 7
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "送貨日期"
        Me.GridColumn6.FieldName = "AR_Date"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "審核"
        Me.GridColumn12.FieldName = "AR_Check"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 9
        Me.GridColumn12.Width = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "生產-補退貨管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(670, 35)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AR_InCheck
        '
        Me.AR_InCheck.Caption = "收料審核"
        Me.AR_InCheck.FieldName = "AR_InCheck"
        Me.AR_InCheck.Name = "AR_InCheck"
        Me.AR_InCheck.OptionsColumn.ReadOnly = True
        Me.AR_InCheck.Visible = True
        Me.AR_InCheck.VisibleIndex = 10
        '
        'frmProductionReturnMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 415)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionReturnMain"
        Me.Text = "生產-補退貨管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmstrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmstrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReturnAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReturnCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripIncheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AR_InCheck As DevExpress.XtraGrid.Columns.GridColumn
End Class
