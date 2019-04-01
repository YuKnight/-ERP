<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionShipmentMain
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
        Me.popShipmentWareOut = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popShipmentWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popShipmentWareOutEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popShipmentWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popShipmentWareOutView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popShipmentWareOutCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popShipmentWareOutflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popShipmentWareOutSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popShipmentWareOutReport = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_WareID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.popShipmentWareOut.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'popShipmentWareOut
        '
        Me.popShipmentWareOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popShipmentWareOutAdd, Me.popShipmentWareOutEdit, Me.popShipmentWareOutDel, Me.popShipmentWareOutView, Me.ToolStripSeparator2, Me.popShipmentWareOutCheck, Me.ToolStripSeparator1, Me.popShipmentWareOutflesh, Me.popShipmentWareOutSeek, Me.popShipmentWareOutReport})
        Me.popShipmentWareOut.Name = "popWareInput"
        Me.popShipmentWareOut.Size = New System.Drawing.Size(194, 192)
        '
        'popShipmentWareOutAdd
        '
        Me.popShipmentWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popShipmentWareOutAdd.Name = "popShipmentWareOutAdd"
        Me.popShipmentWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popShipmentWareOutAdd.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutAdd.Text = "出貨(&A)..."
        '
        'popShipmentWareOutEdit
        '
        Me.popShipmentWareOutEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popShipmentWareOutEdit.Name = "popShipmentWareOutEdit"
        Me.popShipmentWareOutEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popShipmentWareOutEdit.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutEdit.Text = "修改(&E)..."
        '
        'popShipmentWareOutDel
        '
        Me.popShipmentWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popShipmentWareOutDel.Name = "popShipmentWareOutDel"
        Me.popShipmentWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popShipmentWareOutDel.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutDel.Text = "刪除(&D)"
        '
        'popShipmentWareOutView
        '
        Me.popShipmentWareOutView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popShipmentWareOutView.Name = "popShipmentWareOutView"
        Me.popShipmentWareOutView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popShipmentWareOutView.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'popShipmentWareOutCheck
        '
        Me.popShipmentWareOutCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popShipmentWareOutCheck.Name = "popShipmentWareOutCheck"
        Me.popShipmentWareOutCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popShipmentWareOutCheck.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'popShipmentWareOutflesh
        '
        Me.popShipmentWareOutflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popShipmentWareOutflesh.Name = "popShipmentWareOutflesh"
        Me.popShipmentWareOutflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popShipmentWareOutflesh.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutflesh.Text = "刷新(&R)"
        '
        'popShipmentWareOutSeek
        '
        Me.popShipmentWareOutSeek.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.popShipmentWareOutSeek.Name = "popShipmentWareOutSeek"
        Me.popShipmentWareOutSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popShipmentWareOutSeek.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutSeek.Text = "查詢(&F)..."
        '
        'popShipmentWareOutReport
        '
        Me.popShipmentWareOutReport.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popShipmentWareOutReport.Name = "popShipmentWareOutReport"
        Me.popShipmentWareOutReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popShipmentWareOutReport.Size = New System.Drawing.Size(193, 22)
        Me.popShipmentWareOutReport.Text = "出貨單(&P)..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "生產送貨"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(680, 34)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.popShipmentWareOut
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(2, 42)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid.Size = New System.Drawing.Size(680, 396)
        Me.Grid.TabIndex = 12
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.PM_M_Code, Me.PS_M_Name, Me.PS_WareID, Me.PS_Qty, Me.PS_M_Unit, Me.PS_Type, Me.PS_Date, Me.PS_Check, Me.PS_CheckDate, Me.PS_CheckAction})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "送貨單號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.PS_NO.Visible = True
        Me.PS_NO.VisibleIndex = 0
        Me.PS_NO.Width = 85
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        Me.PM_M_Code.Width = 100
        '
        'PS_M_Name
        '
        Me.PS_M_Name.Caption = "名稱"
        Me.PS_M_Name.FieldName = "PS_M_Name"
        Me.PS_M_Name.Name = "PS_M_Name"
        Me.PS_M_Name.Visible = True
        Me.PS_M_Name.VisibleIndex = 2
        Me.PS_M_Name.Width = 85
        '
        'PS_WareID
        '
        Me.PS_WareID.Caption = "出貨倉庫"
        Me.PS_WareID.FieldName = "PS_OutName"
        Me.PS_WareID.Name = "PS_WareID"
        Me.PS_WareID.Visible = True
        Me.PS_WareID.VisibleIndex = 3
        '
        'PS_Qty
        '
        Me.PS_Qty.AppearanceCell.Options.UseTextOptions = True
        Me.PS_Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PS_Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PS_Qty.Caption = "出貨數量"
        Me.PS_Qty.FieldName = "PS_Qty"
        Me.PS_Qty.Name = "PS_Qty"
        Me.PS_Qty.Visible = True
        Me.PS_Qty.VisibleIndex = 4
        '
        'PS_M_Unit
        '
        Me.PS_M_Unit.Caption = "單位"
        Me.PS_M_Unit.FieldName = "PS_M_Unit"
        Me.PS_M_Unit.Name = "PS_M_Unit"
        Me.PS_M_Unit.Visible = True
        Me.PS_M_Unit.VisibleIndex = 5
        Me.PS_M_Unit.Width = 50
        '
        'PS_Type
        '
        Me.PS_Type.Caption = "出貨類型"
        Me.PS_Type.FieldName = "PS_Type"
        Me.PS_Type.Name = "PS_Type"
        Me.PS_Type.Visible = True
        Me.PS_Type.VisibleIndex = 6
        '
        'PS_Date
        '
        Me.PS_Date.Caption = "出貨日期"
        Me.PS_Date.FieldName = "PS_Date"
        Me.PS_Date.Name = "PS_Date"
        Me.PS_Date.Visible = True
        Me.PS_Date.VisibleIndex = 8
        '
        'PS_Check
        '
        Me.PS_Check.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PS_Check.Caption = "審核"
        Me.PS_Check.FieldName = "PS_Check"
        Me.PS_Check.Name = "PS_Check"
        Me.PS_Check.Visible = True
        Me.PS_Check.VisibleIndex = 7
        Me.PS_Check.Width = 55
        '
        'PS_CheckDate
        '
        Me.PS_CheckDate.Caption = "審核日期"
        Me.PS_CheckDate.FieldName = "PS_CheckDate"
        Me.PS_CheckDate.Name = "PS_CheckDate"
        Me.PS_CheckDate.Visible = True
        Me.PS_CheckDate.VisibleIndex = 10
        '
        'PS_CheckAction
        '
        Me.PS_CheckAction.Caption = "審核員"
        Me.PS_CheckAction.FieldName = "PS_CheckAction_N"
        Me.PS_CheckAction.Name = "PS_CheckAction"
        Me.PS_CheckAction.Visible = True
        Me.PS_CheckAction.VisibleIndex = 9
        Me.PS_CheckAction.Width = 65
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = False
        '
        'frmProductionShipmentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 447)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionShipmentMain"
        Me.Text = "生產送貨"
        Me.popShipmentWareOut.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents popShipmentWareOut As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popShipmentWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popShipmentWareOutEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popShipmentWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popShipmentWareOutView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popShipmentWareOutCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popShipmentWareOutflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popShipmentWareOutSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popShipmentWareOutReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_WareID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
