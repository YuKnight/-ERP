<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionKaiLiaoReturnMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.cmsProductionKaiLiaoReturn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProductionAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProductionKaiLiaoReturn.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsProductionKaiLiaoReturn
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(2, 35)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(874, 431)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsProductionKaiLiaoReturn
        '
        Me.cmsProductionKaiLiaoReturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductionAdd, Me.cmsProductionEdit, Me.cmsProductionDel, Me.ToolStripSeparator1, Me.cmsProductionSelect, Me.cmsProductionView, Me.cmsProductionRef, Me.ToolStripSeparator2, Me.cmsProductionCheck, Me.cmsProductionPrint})
        Me.cmsProductionKaiLiaoReturn.Name = "cmsProduction"
        Me.cmsProductionKaiLiaoReturn.Size = New System.Drawing.Size(165, 214)
        '
        'cmsProductionAdd
        '
        Me.cmsProductionAdd.Enabled = False
        Me.cmsProductionAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsProductionAdd.Name = "cmsProductionAdd"
        Me.cmsProductionAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductionAdd.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionAdd.Text = "新增(&A)..."
        '
        'cmsProductionEdit
        '
        Me.cmsProductionEdit.Enabled = False
        Me.cmsProductionEdit.Image = Global.LFERP.My.Resources.Resources.SignatureLineInsertMenu
        Me.cmsProductionEdit.Name = "cmsProductionEdit"
        Me.cmsProductionEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsProductionEdit.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionEdit.Text = "修改(&E)..."
        '
        'cmsProductionDel
        '
        Me.cmsProductionDel.Enabled = False
        Me.cmsProductionDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductionDel.Name = "cmsProductionDel"
        Me.cmsProductionDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductionDel.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'cmsProductionSelect
        '
        Me.cmsProductionSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsProductionSelect.Name = "cmsProductionSelect"
        Me.cmsProductionSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsProductionSelect.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionSelect.Text = "查詢(&F)..."
        '
        'cmsProductionView
        '
        Me.cmsProductionView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsProductionView.Name = "cmsProductionView"
        Me.cmsProductionView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsProductionView.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionView.Text = "查看(&W)..."
        '
        'cmsProductionRef
        '
        Me.cmsProductionRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsProductionRef.Name = "cmsProductionRef"
        Me.cmsProductionRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsProductionRef.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'cmsProductionCheck
        '
        Me.cmsProductionCheck.Enabled = False
        Me.cmsProductionCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsProductionCheck.Name = "cmsProductionCheck"
        Me.cmsProductionCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsProductionCheck.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionCheck.Text = "審核(&G)..."
        '
        'cmsProductionPrint
        '
        Me.cmsProductionPrint.Enabled = False
        Me.cmsProductionPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsProductionPrint.Name = "cmsProductionPrint"
        Me.cmsProductionPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsProductionPrint.Size = New System.Drawing.Size(164, 22)
        Me.cmsProductionPrint.Text = "退料單(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.R_NO, Me.C_NO, Me.Pro_Type, Me.PM_M_Code, Me.PM_Type, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.RDate, Me.RActionName, Me.RCheck, Me.RCheckDate, Me.RCheckActionName})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動流水號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'R_NO
        '
        Me.R_NO.Caption = "退料單號"
        Me.R_NO.FieldName = "R_NO"
        Me.R_NO.Name = "R_NO"
        Me.R_NO.Visible = True
        Me.R_NO.VisibleIndex = 0
        Me.R_NO.Width = 100
        '
        'C_NO
        '
        Me.C_NO.Caption = "開料單號"
        Me.C_NO.FieldName = "C_NO"
        Me.C_NO.Name = "C_NO"
        Me.C_NO.Visible = True
        Me.C_NO.VisibleIndex = 1
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 2
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 3
        Me.PM_M_Code.Width = 90
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類型"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 4
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 5
        Me.M_Code.Width = 80
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 6
        Me.M_Name.Width = 85
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 7
        Me.M_Gauge.Width = 80
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 8
        '
        'RDate
        '
        Me.RDate.Caption = "退料日期"
        Me.RDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RDate.FieldName = "RDate"
        Me.RDate.Name = "RDate"
        Me.RDate.Visible = True
        Me.RDate.VisibleIndex = 9
        '
        'RActionName
        '
        Me.RActionName.Caption = "退料人"
        Me.RActionName.FieldName = "RActionName"
        Me.RActionName.Name = "RActionName"
        Me.RActionName.Visible = True
        Me.RActionName.VisibleIndex = 10
        '
        'RCheck
        '
        Me.RCheck.Caption = "審核"
        Me.RCheck.FieldName = "RCheck"
        Me.RCheck.Name = "RCheck"
        Me.RCheck.Visible = True
        Me.RCheck.VisibleIndex = 11
        '
        'RCheckDate
        '
        Me.RCheckDate.Caption = "審核日期"
        Me.RCheckDate.FieldName = "RCheckDate"
        Me.RCheckDate.Name = "RCheckDate"
        Me.RCheckDate.Visible = True
        Me.RCheckDate.VisibleIndex = 12
        '
        'RCheckActionName
        '
        Me.RCheckActionName.Caption = "審核人"
        Me.RCheckActionName.FieldName = "RCheckActionName"
        Me.RCheckActionName.Name = "RCheckActionName"
        Me.RCheckActionName.Visible = True
        Me.RCheckActionName.VisibleIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "生產退料管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 32)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmProductionKaiLiaoReturnMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionKaiLiaoReturnMain"
        Me.Text = "生產退料"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProductionKaiLiaoReturn.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmsProductionKaiLiaoReturn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProductionAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RCheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
End Class
