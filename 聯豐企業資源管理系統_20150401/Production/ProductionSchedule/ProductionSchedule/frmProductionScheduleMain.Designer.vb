<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionScheduleMain
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
        Me.cmsProduction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProductionAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductionCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductionMaterial = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_DayNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_ActualNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProduction.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsProduction
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 41)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(812, 362)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsProduction
        '
        Me.cmsProduction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductionAdd, Me.cmsProductionEdit, Me.cmsProductionDel, Me.ToolStripSeparator1, Me.cmsProductionSelect, Me.cmsProductionView, Me.cmsProductionRef, Me.ToolStripSeparator2, Me.cmsProductionCheck, Me.cmsProductionMaterial})
        Me.cmsProduction.Name = "cmsProduction"
        Me.cmsProduction.Size = New System.Drawing.Size(228, 192)
        '
        'cmsProductionAdd
        '
        Me.cmsProductionAdd.Enabled = False
        Me.cmsProductionAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsProductionAdd.Name = "cmsProductionAdd"
        Me.cmsProductionAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductionAdd.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionAdd.Text = "新增(&A)..."
        '
        'cmsProductionEdit
        '
        Me.cmsProductionEdit.Enabled = False
        Me.cmsProductionEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsProductionEdit.Name = "cmsProductionEdit"
        Me.cmsProductionEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsProductionEdit.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionEdit.Text = "修改(&E)..."
        '
        'cmsProductionDel
        '
        Me.cmsProductionDel.Enabled = False
        Me.cmsProductionDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductionDel.Name = "cmsProductionDel"
        Me.cmsProductionDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductionDel.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(224, 6)
        '
        'cmsProductionSelect
        '
        Me.cmsProductionSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsProductionSelect.Name = "cmsProductionSelect"
        Me.cmsProductionSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsProductionSelect.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionSelect.Text = "查詢(&F)..."
        '
        'cmsProductionView
        '
        Me.cmsProductionView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsProductionView.Name = "cmsProductionView"
        Me.cmsProductionView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsProductionView.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionView.Text = "查看(&W)..."
        '
        'cmsProductionRef
        '
        Me.cmsProductionRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsProductionRef.Name = "cmsProductionRef"
        Me.cmsProductionRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsProductionRef.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'cmsProductionCheck
        '
        Me.cmsProductionCheck.Enabled = False
        Me.cmsProductionCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsProductionCheck.Name = "cmsProductionCheck"
        Me.cmsProductionCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsProductionCheck.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionCheck.Text = "審核(&G)..."
        '
        'cmsProductionMaterial
        '
        Me.cmsProductionMaterial.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.cmsProductionMaterial.Name = "cmsProductionMaterial"
        Me.cmsProductionMaterial.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmsProductionMaterial.Size = New System.Drawing.Size(227, 22)
        Me.cmsProductionMaterial.Text = "原材料使用狀況(&T)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.PS_Num, Me.Pro_Type, Me.PM_M_Code, Me.M_Code, Me.PM_JiYu, Me.PM_Type, Me.PS_Date, Me.PS_DayNumber, Me.PS_ActualNumber, Me.FacName, Me.PS_Action, Me.PS_AddDate, Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "計劃項目號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.Visible = True
        Me.PS_NO.VisibleIndex = 0
        Me.PS_NO.Width = 88
        '
        'PS_Num
        '
        Me.PS_Num.Caption = "項目流水號"
        Me.PS_Num.FieldName = "PS_Num"
        Me.PS_Num.Name = "PS_Num"
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 1
        Me.Pro_Type.Width = 82
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Width = 95
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "別名"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 3
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類型"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 4
        Me.PM_Type.Width = 56
        '
        'PS_Date
        '
        Me.PS_Date.Caption = "生產日期"
        Me.PS_Date.FieldName = "PS_Date"
        Me.PS_Date.Name = "PS_Date"
        Me.PS_Date.Visible = True
        Me.PS_Date.VisibleIndex = 5
        Me.PS_Date.Width = 78
        '
        'PS_DayNumber
        '
        Me.PS_DayNumber.Caption = "生產計劃數"
        Me.PS_DayNumber.FieldName = "PS_DayNumber"
        Me.PS_DayNumber.Name = "PS_DayNumber"
        Me.PS_DayNumber.Visible = True
        Me.PS_DayNumber.VisibleIndex = 6
        Me.PS_DayNumber.Width = 85
        '
        'PS_ActualNumber
        '
        Me.PS_ActualNumber.Caption = "實際完成數"
        Me.PS_ActualNumber.FieldName = "PS_ActualNumber"
        Me.PS_ActualNumber.Name = "PS_ActualNumber"
        Me.PS_ActualNumber.Visible = True
        Me.PS_ActualNumber.VisibleIndex = 7
        Me.PS_ActualNumber.Width = 85
        '
        'FacName
        '
        Me.FacName.Caption = "生產部門"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 8
        Me.FacName.Width = 74
        '
        'PS_Action
        '
        Me.PS_Action.Caption = "操作員"
        Me.PS_Action.FieldName = "PS_Action"
        Me.PS_Action.Name = "PS_Action"
        Me.PS_Action.Visible = True
        Me.PS_Action.VisibleIndex = 9
        Me.PS_Action.Width = 61
        '
        'PS_AddDate
        '
        Me.PS_AddDate.Caption = "建立日期"
        Me.PS_AddDate.FieldName = "PS_AddDate"
        Me.PS_AddDate.Name = "PS_AddDate"
        Me.PS_AddDate.Visible = True
        Me.PS_AddDate.VisibleIndex = 10
        Me.PS_AddDate.Width = 72
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "審核"
        Me.GridColumn1.FieldName = "PS_Check"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 11
        Me.GridColumn1.Width = 53
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "審核員"
        Me.GridColumn2.FieldName = "CheckActionName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 12
        Me.GridColumn2.Width = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(812, 37)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "生產計劃"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(129, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "視圖"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'frmProductionScheduleMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionScheduleMain"
        Me.Text = "生產計劃管理"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProduction.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_DayNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProduction As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProductionAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductionRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PS_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PS_ActualNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsProductionMaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
