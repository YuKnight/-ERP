<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionRetrocedeMain
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
        Me.RetrocedeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RetrocedeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.RetrocedeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.RetrocedePreView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RetrocedeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripIncheck = New System.Windows.Forms.ToolStripMenuItem
        Me.RetrocedeQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.RetrocedeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.RetrocedePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.RetrocedeTotalPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_InName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmstrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmstrip
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(731, 302)
        Me.Grid1.TabIndex = 6
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmstrip
        '
        Me.cmstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetrocedeAdd, Me.ToolStripSeparator1, Me.RetrocedeEdit, Me.RetrocedeDel, Me.RetrocedePreView, Me.ToolStripSeparator2, Me.RetrocedeCheck, Me.ToolStripSeparator3, Me.ToolStripIncheck, Me.RetrocedeQuery, Me.RetrocedeRef, Me.ToolStripSeparator4, Me.RetrocedePrint, Me.RetrocedeTotalPrint})
        Me.cmstrip.Name = "cmstrip"
        Me.cmstrip.Size = New System.Drawing.Size(193, 248)
        '
        'RetrocedeAdd
        '
        Me.RetrocedeAdd.Enabled = False
        Me.RetrocedeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.RetrocedeAdd.Name = "RetrocedeAdd"
        Me.RetrocedeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.RetrocedeAdd.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeAdd.Text = "新增退貨單(&A)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'RetrocedeEdit
        '
        Me.RetrocedeEdit.Enabled = False
        Me.RetrocedeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.RetrocedeEdit.Name = "RetrocedeEdit"
        Me.RetrocedeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.RetrocedeEdit.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeEdit.Text = "修改(&E)..."
        '
        'RetrocedeDel
        '
        Me.RetrocedeDel.Enabled = False
        Me.RetrocedeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.RetrocedeDel.Name = "RetrocedeDel"
        Me.RetrocedeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.RetrocedeDel.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeDel.Text = "刪除(&D)"
        '
        'RetrocedePreView
        '
        Me.RetrocedePreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.RetrocedePreView.Name = "RetrocedePreView"
        Me.RetrocedePreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.RetrocedePreView.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedePreView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'RetrocedeCheck
        '
        Me.RetrocedeCheck.Enabled = False
        Me.RetrocedeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.RetrocedeCheck.Name = "RetrocedeCheck"
        Me.RetrocedeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.RetrocedeCheck.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(189, 6)
        '
        'ToolStripIncheck
        '
        Me.ToolStripIncheck.Enabled = False
        Me.ToolStripIncheck.Name = "ToolStripIncheck"
        Me.ToolStripIncheck.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripIncheck.Text = "收料確認"
        '
        'RetrocedeQuery
        '
        Me.RetrocedeQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.RetrocedeQuery.Name = "RetrocedeQuery"
        Me.RetrocedeQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.RetrocedeQuery.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeQuery.Text = "查詢(&F)..."
        '
        'RetrocedeRef
        '
        Me.RetrocedeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.RetrocedeRef.Name = "RetrocedeRef"
        Me.RetrocedeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RetrocedeRef.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
        '
        'RetrocedePrint
        '
        Me.RetrocedePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.RetrocedePrint.Name = "RetrocedePrint"
        Me.RetrocedePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.RetrocedePrint.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedePrint.Text = "退貨單(&P)..."
        '
        'RetrocedeTotalPrint
        '
        Me.RetrocedeTotalPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.RetrocedeTotalPrint.Name = "RetrocedeTotalPrint"
        Me.RetrocedeTotalPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.RetrocedeTotalPrint.Size = New System.Drawing.Size(192, 22)
        Me.RetrocedeTotalPrint.Text = "退貨單匯總(&T)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn12, Me.GridColumn9, Me.WH_InName, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.R_Date, Me.R_Check, Me.R_InCheck})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "退貨單號"
        Me.GridColumn1.FieldName = "R_NO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
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
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "類型"
        Me.GridColumn4.FieldName = "PM_Type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "數量"
        Me.GridColumn7.FieldName = "R_Qty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "未交數"
        Me.GridColumn12.FieldName = "R_NoSendQty"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "退貨倉庫"
        Me.GridColumn9.FieldName = "WH_Name"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        '
        'WH_InName
        '
        Me.WH_InName.Caption = "接收倉庫"
        Me.WH_InName.FieldName = "WH_InName"
        Me.WH_InName.Name = "WH_InName"
        Me.WH_InName.OptionsColumn.ReadOnly = True
        Me.WH_InName.Visible = True
        Me.WH_InName.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "退貨原因"
        Me.GridColumn8.FieldName = "R_Detail"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "倉庫ID"
        Me.GridColumn10.FieldName = "WH_ID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "退貨類型"
        Me.GridColumn11.FieldName = "R_Type"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        '
        'R_Date
        '
        Me.R_Date.Caption = "退貨日期"
        Me.R_Date.FieldName = "R_Date"
        Me.R_Date.Name = "R_Date"
        Me.R_Date.OptionsColumn.ReadOnly = True
        Me.R_Date.Visible = True
        Me.R_Date.VisibleIndex = 9
        '
        'R_Check
        '
        Me.R_Check.Caption = "審核"
        Me.R_Check.FieldName = "R_Check"
        Me.R_Check.Name = "R_Check"
        Me.R_Check.OptionsColumn.ReadOnly = True
        Me.R_Check.Visible = True
        Me.R_Check.VisibleIndex = 10
        Me.R_Check.Width = 55
        '
        'R_InCheck
        '
        Me.R_InCheck.Caption = "收料審核"
        Me.R_InCheck.FieldName = "R_InCheck"
        Me.R_InCheck.Name = "R_InCheck"
        Me.R_InCheck.OptionsColumn.ReadOnly = True
        Me.R_InCheck.Visible = True
        Me.R_InCheck.VisibleIndex = 11
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "工序編號"
        Me.GridColumn5.FieldName = "Pro_NO"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "工序名稱"
        Me.GridColumn6.FieldName = "PS_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "裝配-退貨管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(731, 31)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmstrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(731, 101)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn18, Me.GridColumn16, Me.GridColumn15, Me.GridColumn20})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "送貨單號"
        Me.GridColumn13.FieldName = "AR_NO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 86
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "退貨單號"
        Me.GridColumn14.FieldName = "R_NO"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Width = 66
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "數量"
        Me.GridColumn18.FieldName = "AR_Qty"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        Me.GridColumn18.Width = 66
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "送貨類型"
        Me.GridColumn16.FieldName = "AR_Type"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "審核"
        Me.GridColumn15.FieldName = "AR_Check"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "備註"
        Me.GridColumn20.FieldName = "AR_Remark"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 4
        Me.GridColumn20.Width = 66
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(731, 407)
        Me.SplitContainer1.SplitterDistance = 302
        Me.SplitContainer1.TabIndex = 9
        '
        'frmProductionRetrocedeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 440)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionRetrocedeMain"
        Me.Text = "裝配-退貨管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmstrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmstrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RetrocedeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedePreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedeQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrocedePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RetrocedeCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents R_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_InName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RetrocedeTotalPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripIncheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents R_InCheck As DevExpress.XtraGrid.Columns.GridColumn
End Class
