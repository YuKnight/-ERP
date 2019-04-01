<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionKaiLiaoMain
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
        Dim M_Unit As DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Weight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Number = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmsProductionKaiLiaoA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProductionAddA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionEditA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionDelA = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionSelectA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionViewA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionRefA = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionCheckA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionPrintA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutPrintA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionKaiLiao = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.cmsOutPrint = New System.Windows.Forms.ToolStripMenuItem
        M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProductionKaiLiaoA.SuspendLayout()
        Me.cmsProductionKaiLiao.SuspendLayout()
        Me.SuspendLayout()
        '
        'M_Unit
        '
        M_Unit.Caption = "單位"
        M_Unit.FieldName = "M_Unit"
        M_Unit.Name = "M_Unit"
        M_Unit.Visible = True
        M_Unit.VisibleIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(705, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "開料管理"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 34)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(705, 382)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_NO, Me.Pro_Type, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.PS_Dep, Me.PS_Action, Me.C_AddDate, Me.C_Qty, Me.C_Weight, Me.C_Type, Me.C_Action, M_Unit, Me.C_Check, Me.C_Number})
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
        'C_NO
        '
        Me.C_NO.Caption = "開料單號"
        Me.C_NO.FieldName = "C_NO"
        Me.C_NO.Name = "C_NO"
        Me.C_NO.Visible = True
        Me.C_NO.VisibleIndex = 0
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 1
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        Me.PM_M_Code.Width = 100
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 3
        Me.PM_JiYu.Width = 60
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類型"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 4
        Me.PM_Type.Width = 60
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 5
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 6
        Me.M_Gauge.Width = 100
        '
        'PS_Dep
        '
        Me.PS_Dep.Caption = "領料部門"
        Me.PS_Dep.FieldName = "PS_Dep"
        Me.PS_Dep.Name = "PS_Dep"
        '
        'PS_Action
        '
        Me.PS_Action.Caption = "領料人"
        Me.PS_Action.FieldName = "PS_Action"
        Me.PS_Action.Name = "PS_Action"
        Me.PS_Action.Visible = True
        Me.PS_Action.VisibleIndex = 7
        Me.PS_Action.Width = 65
        '
        'C_AddDate
        '
        Me.C_AddDate.Caption = "開料日期"
        Me.C_AddDate.FieldName = "C_AddDate"
        Me.C_AddDate.Name = "C_AddDate"
        Me.C_AddDate.Visible = True
        Me.C_AddDate.VisibleIndex = 8
        '
        'C_Qty
        '
        Me.C_Qty.Caption = "數量"
        Me.C_Qty.FieldName = "C_Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.Width = 55
        '
        'C_Weight
        '
        Me.C_Weight.Caption = "數量"
        Me.C_Weight.FieldName = "C_Weight"
        Me.C_Weight.Name = "C_Weight"
        Me.C_Weight.Visible = True
        Me.C_Weight.VisibleIndex = 9
        Me.C_Weight.Width = 55
        '
        'C_Type
        '
        Me.C_Type.Caption = "類型"
        Me.C_Type.FieldName = "C_Type"
        Me.C_Type.Name = "C_Type"
        Me.C_Type.Width = 55
        '
        'C_Action
        '
        Me.C_Action.Caption = "開料人"
        Me.C_Action.FieldName = "C_Action"
        Me.C_Action.Name = "C_Action"
        Me.C_Action.Width = 65
        '
        'C_Check
        '
        Me.C_Check.Caption = "審核"
        Me.C_Check.FieldName = "C_Check"
        Me.C_Check.Name = "C_Check"
        Me.C_Check.Visible = True
        Me.C_Check.VisibleIndex = 11
        Me.C_Check.Width = 55
        '
        'C_Number
        '
        Me.C_Number.Caption = "單號"
        Me.C_Number.FieldName = "C_Number"
        Me.C_Number.Name = "C_Number"
        '
        'cmsProductionKaiLiaoA
        '
        Me.cmsProductionKaiLiaoA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductionAddA, Me.cmsProductionEditA, Me.cmsProductionDelA, Me.ToolStripSeparator3, Me.cmsProductionSelectA, Me.cmsProductionViewA, Me.cmsProductionRefA, Me.ToolStripSeparator4, Me.cmsProductionCheckA, Me.cmsProductionPrintA, Me.cmsOutPrintA})
        Me.cmsProductionKaiLiaoA.Name = "cmsProduction"
        Me.cmsProductionKaiLiaoA.Size = New System.Drawing.Size(180, 236)
        '
        'cmsProductionAddA
        '
        Me.cmsProductionAddA.Enabled = False
        Me.cmsProductionAddA.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsProductionAddA.Name = "cmsProductionAddA"
        Me.cmsProductionAddA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductionAddA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionAddA.Text = "新增(&A)..."
        '
        'cmsProductionEditA
        '
        Me.cmsProductionEditA.Enabled = False
        Me.cmsProductionEditA.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsProductionEditA.Name = "cmsProductionEditA"
        Me.cmsProductionEditA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsProductionEditA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionEditA.Text = "修改(&E)..."
        '
        'cmsProductionDelA
        '
        Me.cmsProductionDelA.Enabled = False
        Me.cmsProductionDelA.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductionDelA.Name = "cmsProductionDelA"
        Me.cmsProductionDelA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductionDelA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionDelA.Text = "刪除(&D)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(176, 6)
        '
        'cmsProductionSelectA
        '
        Me.cmsProductionSelectA.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsProductionSelectA.Name = "cmsProductionSelectA"
        Me.cmsProductionSelectA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsProductionSelectA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionSelectA.Text = "查詢(&F)..."
        '
        'cmsProductionViewA
        '
        Me.cmsProductionViewA.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsProductionViewA.Name = "cmsProductionViewA"
        Me.cmsProductionViewA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsProductionViewA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionViewA.Text = "查看(&W)..."
        '
        'cmsProductionRefA
        '
        Me.cmsProductionRefA.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsProductionRefA.Name = "cmsProductionRefA"
        Me.cmsProductionRefA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsProductionRefA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionRefA.Text = "刷新(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(176, 6)
        '
        'cmsProductionCheckA
        '
        Me.cmsProductionCheckA.Enabled = False
        Me.cmsProductionCheckA.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsProductionCheckA.Name = "cmsProductionCheckA"
        Me.cmsProductionCheckA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsProductionCheckA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionCheckA.Text = "審核(&G)..."
        '
        'cmsProductionPrintA
        '
        Me.cmsProductionPrintA.Enabled = False
        Me.cmsProductionPrintA.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsProductionPrintA.Name = "cmsProductionPrintA"
        Me.cmsProductionPrintA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsProductionPrintA.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionPrintA.Text = "開料單(&P)..."
        '
        'cmsOutPrintA
        '
        Me.cmsOutPrintA.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsOutPrintA.Name = "cmsOutPrintA"
        Me.cmsOutPrintA.Size = New System.Drawing.Size(179, 22)
        Me.cmsOutPrintA.Text = "部門領出記錄(&J)..."
        '
        'cmsProductionKaiLiao
        '
        Me.cmsProductionKaiLiao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductionAdd, Me.cmsProductionEdit, Me.cmsProductionDel, Me.ToolStripSeparator1, Me.cmsProductionSelect, Me.cmsProductionView, Me.cmsProductionRef, Me.ToolStripSeparator2, Me.cmsProductionCheck, Me.cmsProductionPrint, Me.cmsOutPrint})
        Me.cmsProductionKaiLiao.Name = "cmsProduction"
        Me.cmsProductionKaiLiao.Size = New System.Drawing.Size(180, 214)
        '
        'cmsProductionAdd
        '
        Me.cmsProductionAdd.Enabled = False
        Me.cmsProductionAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsProductionAdd.Name = "cmsProductionAdd"
        Me.cmsProductionAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductionAdd.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionAdd.Text = "新增(&A)..."
        '
        'cmsProductionEdit
        '
        Me.cmsProductionEdit.Enabled = False
        Me.cmsProductionEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsProductionEdit.Name = "cmsProductionEdit"
        Me.cmsProductionEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsProductionEdit.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionEdit.Text = "修改(&E)..."
        '
        'cmsProductionDel
        '
        Me.cmsProductionDel.Enabled = False
        Me.cmsProductionDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductionDel.Name = "cmsProductionDel"
        Me.cmsProductionDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductionDel.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'cmsProductionSelect
        '
        Me.cmsProductionSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsProductionSelect.Name = "cmsProductionSelect"
        Me.cmsProductionSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsProductionSelect.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionSelect.Text = "查詢(&F)..."
        '
        'cmsProductionView
        '
        Me.cmsProductionView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsProductionView.Name = "cmsProductionView"
        Me.cmsProductionView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsProductionView.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionView.Text = "查看(&W)..."
        '
        'cmsProductionRef
        '
        Me.cmsProductionRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsProductionRef.Name = "cmsProductionRef"
        Me.cmsProductionRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsProductionRef.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(176, 6)
        '
        'cmsProductionCheck
        '
        Me.cmsProductionCheck.Enabled = False
        Me.cmsProductionCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsProductionCheck.Name = "cmsProductionCheck"
        Me.cmsProductionCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsProductionCheck.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionCheck.Text = "審核(&G)..."
        '
        'cmsProductionPrint
        '
        Me.cmsProductionPrint.Enabled = False
        Me.cmsProductionPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsProductionPrint.Name = "cmsProductionPrint"
        Me.cmsProductionPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsProductionPrint.Size = New System.Drawing.Size(179, 22)
        Me.cmsProductionPrint.Text = "開料單(&P)..."
        '
        'cmsOutPrint
        '
        Me.cmsOutPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsOutPrint.Name = "cmsOutPrint"
        Me.cmsOutPrint.Size = New System.Drawing.Size(179, 22)
        Me.cmsOutPrint.Text = "部門領出記錄(&J)..."
        '
        'frmProductionKaiLiaoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 416)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionKaiLiaoMain"
        Me.Text = "開料管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProductionKaiLiaoA.ResumeLayout(False)
        Me.cmsProductionKaiLiao.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProductionKaiLiao As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsOutPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C_Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProductionKaiLiaoA As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProductionAddA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionEditA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionDelA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionSelectA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionViewA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionRefA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductionCheckA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionPrintA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutPrintA As System.Windows.Forms.ToolStripMenuItem
End Class
