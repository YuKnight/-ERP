<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleDivert
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQurey = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_OutSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OutPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_OutD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_OutPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_InSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_InD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_InPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "条码转移管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(878, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.cmsMenuStrip
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 32)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemButtonEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(878, 642)
        Me.Grid1.TabIndex = 84
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator3, Me.cmdView, Me.cmdQurey, Me.cmdCheck, Me.ToolStripSeparator2, Me.cmdRef, Me.cmdPrint, Me.cmdExcel})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(187, 214)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(186, 22)
        Me.cmdAdd.Text = "新增(&A)        "
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(186, 22)
        Me.cmdEdit.Text = "修改(&E)        "
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(186, 22)
        Me.cmdDel.Text = "刪除(&D)        "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(183, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(186, 22)
        Me.cmdView.Text = "查看(&W)      "
        '
        'cmdQurey
        '
        Me.cmdQurey.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQurey.Name = "cmdQurey"
        Me.cmdQurey.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQurey.Size = New System.Drawing.Size(186, 22)
        Me.cmdQurey.Text = "查询(&F)        "
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(186, 22)
        Me.cmdCheck.Text = "审核(&G)        "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(186, 22)
        Me.cmdRef.Text = "刷新(&R)       "
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(186, 22)
        Me.cmdPrint.Text = "打印(&P)        "
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmdExcel.Size = New System.Drawing.Size(186, 22)
        Me.cmdExcel.Text = "Excel(&X)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Code_ID, Me.SD_OutSO_ID, Me.OutPM_M_Code, Me.SD_OutD_ID, Me.SD_OutPS_NO, Me.SD_InSO_ID, Me.InPM_M_Code, Me.SD_InD_ID, Me.SD_InPS_NO, Me.SD_Qty, Me.SD_AddUserName, Me.SD_AddDate, Me.SD_Check, Me.SD_Remark, Me.SD_ID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'Code_ID
        '
        Me.Code_ID.Caption = "条码编号"
        Me.Code_ID.FieldName = "Code_ID"
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.Visible = True
        Me.Code_ID.VisibleIndex = 0
        Me.Code_ID.Width = 106
        '
        'SD_OutSO_ID
        '
        Me.SD_OutSO_ID.Caption = "发出板单"
        Me.SD_OutSO_ID.FieldName = "OutSO_SampleID"
        Me.SD_OutSO_ID.Name = "SD_OutSO_ID"
        Me.SD_OutSO_ID.Visible = True
        Me.SD_OutSO_ID.VisibleIndex = 1
        Me.SD_OutSO_ID.Width = 83
        '
        'OutPM_M_Code
        '
        Me.OutPM_M_Code.Caption = "发出产品"
        Me.OutPM_M_Code.FieldName = "OutPM_M_Code"
        Me.OutPM_M_Code.Name = "OutPM_M_Code"
        Me.OutPM_M_Code.Visible = True
        Me.OutPM_M_Code.VisibleIndex = 3
        '
        'SD_OutD_ID
        '
        Me.SD_OutD_ID.Caption = "发出部门"
        Me.SD_OutD_ID.FieldName = "SD_OutD_Name"
        Me.SD_OutD_ID.Name = "SD_OutD_ID"
        Me.SD_OutD_ID.Visible = True
        Me.SD_OutD_ID.VisibleIndex = 2
        Me.SD_OutD_ID.Width = 70
        '
        'SD_OutPS_NO
        '
        Me.SD_OutPS_NO.Caption = "发出工序"
        Me.SD_OutPS_NO.FieldName = "SD_OutPS_Name"
        Me.SD_OutPS_NO.Name = "SD_OutPS_NO"
        Me.SD_OutPS_NO.SummaryItem.DisplayFormat = "合计："
        Me.SD_OutPS_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.SD_OutPS_NO.Visible = True
        Me.SD_OutPS_NO.VisibleIndex = 4
        Me.SD_OutPS_NO.Width = 70
        '
        'SD_InSO_ID
        '
        Me.SD_InSO_ID.Caption = "收入板单"
        Me.SD_InSO_ID.FieldName = "InSO_SampleID"
        Me.SD_InSO_ID.Name = "SD_InSO_ID"
        Me.SD_InSO_ID.Visible = True
        Me.SD_InSO_ID.VisibleIndex = 6
        Me.SD_InSO_ID.Width = 83
        '
        'InPM_M_Code
        '
        Me.InPM_M_Code.Caption = "收入产品"
        Me.InPM_M_Code.FieldName = "InPM_M_Code"
        Me.InPM_M_Code.Name = "InPM_M_Code"
        Me.InPM_M_Code.Visible = True
        Me.InPM_M_Code.VisibleIndex = 7
        '
        'SD_InD_ID
        '
        Me.SD_InD_ID.Caption = "收入部门"
        Me.SD_InD_ID.FieldName = "SD_InD_Name"
        Me.SD_InD_ID.Name = "SD_InD_ID"
        Me.SD_InD_ID.Visible = True
        Me.SD_InD_ID.VisibleIndex = 8
        Me.SD_InD_ID.Width = 70
        '
        'SD_InPS_NO
        '
        Me.SD_InPS_NO.Caption = "收入工序"
        Me.SD_InPS_NO.FieldName = "SD_InPS_Name"
        Me.SD_InPS_NO.Name = "SD_InPS_NO"
        Me.SD_InPS_NO.Visible = True
        Me.SD_InPS_NO.VisibleIndex = 9
        Me.SD_InPS_NO.Width = 70
        '
        'SD_Qty
        '
        Me.SD_Qty.Caption = "数量"
        Me.SD_Qty.FieldName = "SD_Qty"
        Me.SD_Qty.Name = "SD_Qty"
        Me.SD_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.SD_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SD_Qty.Visible = True
        Me.SD_Qty.VisibleIndex = 5
        Me.SD_Qty.Width = 46
        '
        'SD_AddUserName
        '
        Me.SD_AddUserName.Caption = "新增人员"
        Me.SD_AddUserName.FieldName = "SD_AddUserName"
        Me.SD_AddUserName.Name = "SD_AddUserName"
        Me.SD_AddUserName.Visible = True
        Me.SD_AddUserName.VisibleIndex = 11
        Me.SD_AddUserName.Width = 70
        '
        'SD_AddDate
        '
        Me.SD_AddDate.Caption = "新增日期"
        Me.SD_AddDate.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.SD_AddDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SD_AddDate.FieldName = "SD_AddDate"
        Me.SD_AddDate.GroupFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.SD_AddDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SD_AddDate.Name = "SD_AddDate"
        Me.SD_AddDate.Visible = True
        Me.SD_AddDate.VisibleIndex = 12
        '
        'SD_Check
        '
        Me.SD_Check.Caption = "审核"
        Me.SD_Check.FieldName = "SD_Check"
        Me.SD_Check.Name = "SD_Check"
        Me.SD_Check.Visible = True
        Me.SD_Check.VisibleIndex = 10
        Me.SD_Check.Width = 45
        '
        'SD_Remark
        '
        Me.SD_Remark.Caption = "备注"
        Me.SD_Remark.FieldName = "SD_Remark"
        Me.SD_Remark.Name = "SD_Remark"
        Me.SD_Remark.Visible = True
        Me.SD_Remark.VisibleIndex = 13
        '
        'SD_ID
        '
        Me.SD_ID.Caption = "转移单号"
        Me.SD_ID.FieldName = "SD_ID"
        Me.SD_ID.Name = "SD_ID"
        Me.SD_ID.Visible = True
        Me.SD_ID.VisibleIndex = 14
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'frmSampleDivert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 674)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSampleDivert"
        Me.Text = "条码转移管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_OutSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_OutD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_OutPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_InSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SD_InD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_InPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SD_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQurey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
End Class
