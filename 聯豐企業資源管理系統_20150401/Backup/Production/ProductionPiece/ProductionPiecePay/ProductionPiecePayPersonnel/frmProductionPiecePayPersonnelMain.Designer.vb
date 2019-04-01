<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayPersonnelMain
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCollect = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrintNoPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_YYMM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_DayPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_OnDutyDays = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_UsualOverHours = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_HolidayOVerHours = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_CompensateSum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_SubtractSum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_MeritedPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PL_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PL_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "個人計件薪金管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(681, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.MenuStrip
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(681, 443)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCollect, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdCheck, Me.ToolStripSeparator5, Me.cmdRef, Me.ToolStripSeparator6, Me.cmdView, Me.cmdQuery, Me.cmdPrintNoPrice, Me.cmdPrint})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(189, 242)
        '
        'cmdCollect
        '
        Me.cmdCollect.Enabled = False
        Me.cmdCollect.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.cmdCollect.Name = "cmdCollect"
        Me.cmdCollect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdCollect.Size = New System.Drawing.Size(188, 22)
        Me.cmdCollect.Text = "匯總(&T)..."
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(188, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(188, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(188, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(185, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(188, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(185, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(188, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(188, 22)
        Me.cmdQuery.Text = "查詢(&F)..."
        '
        'cmdPrintNoPrice
        '
        Me.cmdPrintNoPrice.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintNoPrice.Name = "cmdPrintNoPrice"
        Me.cmdPrintNoPrice.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrintNoPrice.Size = New System.Drawing.Size(188, 22)
        Me.cmdPrintNoPrice.Text = "列印(&P)..."
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(188, 22)
        Me.cmdPrint.Text = "列印(工價)(&K)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Per_NO, Me.Per_Name, Me.PL_YYMM, Me.FacName, Me.DepID, Me.DepName, Me.Per_DayPrice, Me.PL_OnDutyDays, Me.PL_UsualOverHours, Me.PL_HolidayOVerHours, Me.PL_CompensateSum, Me.PL_SubtractSum, Me.PL_MeritedPay, Me.PL_Check, Me.PL_AddUserName})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "廠證編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.OptionsColumn.ReadOnly = True
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.ReadOnly = True
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        Me.Per_Name.Width = 60
        '
        'PL_YYMM
        '
        Me.PL_YYMM.Caption = "年月"
        Me.PL_YYMM.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.PL_YYMM.FieldName = "PL_YYMM"
        Me.PL_YYMM.Name = "PL_YYMM"
        Me.PL_YYMM.OptionsColumn.ReadOnly = True
        Me.PL_YYMM.Visible = True
        Me.PL_YYMM.VisibleIndex = 2
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "y"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "y"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "y"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.OptionsColumn.ReadOnly = True
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 3
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.ReadOnly = True
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 4
        '
        'Per_DayPrice
        '
        Me.Per_DayPrice.Caption = "日薪"
        Me.Per_DayPrice.FieldName = "Per_DayPrice"
        Me.Per_DayPrice.Name = "Per_DayPrice"
        Me.Per_DayPrice.OptionsColumn.ReadOnly = True
        Me.Per_DayPrice.Visible = True
        Me.Per_DayPrice.VisibleIndex = 5
        Me.Per_DayPrice.Width = 60
        '
        'PL_OnDutyDays
        '
        Me.PL_OnDutyDays.Caption = "上班天數"
        Me.PL_OnDutyDays.FieldName = "PL_OnDutyDays"
        Me.PL_OnDutyDays.Name = "PL_OnDutyDays"
        Me.PL_OnDutyDays.OptionsColumn.ReadOnly = True
        Me.PL_OnDutyDays.Visible = True
        Me.PL_OnDutyDays.VisibleIndex = 6
        '
        'PL_UsualOverHours
        '
        Me.PL_UsualOverHours.Caption = "平時加班"
        Me.PL_UsualOverHours.FieldName = "PL_UsualOverHours"
        Me.PL_UsualOverHours.Name = "PL_UsualOverHours"
        Me.PL_UsualOverHours.OptionsColumn.ReadOnly = True
        Me.PL_UsualOverHours.Visible = True
        Me.PL_UsualOverHours.VisibleIndex = 7
        '
        'PL_HolidayOVerHours
        '
        Me.PL_HolidayOVerHours.Caption = "假日加班"
        Me.PL_HolidayOVerHours.FieldName = "PL_HolidayOVerHours"
        Me.PL_HolidayOVerHours.Name = "PL_HolidayOVerHours"
        Me.PL_HolidayOVerHours.OptionsColumn.ReadOnly = True
        Me.PL_HolidayOVerHours.Visible = True
        Me.PL_HolidayOVerHours.VisibleIndex = 8
        '
        'PL_CompensateSum
        '
        Me.PL_CompensateSum.Caption = "應補金額"
        Me.PL_CompensateSum.FieldName = "PL_CompensateSum"
        Me.PL_CompensateSum.Name = "PL_CompensateSum"
        Me.PL_CompensateSum.OptionsColumn.ReadOnly = True
        Me.PL_CompensateSum.Visible = True
        Me.PL_CompensateSum.VisibleIndex = 9
        '
        'PL_SubtractSum
        '
        Me.PL_SubtractSum.Caption = "應扣金額"
        Me.PL_SubtractSum.FieldName = "PL_SubtractSum"
        Me.PL_SubtractSum.Name = "PL_SubtractSum"
        Me.PL_SubtractSum.OptionsColumn.ReadOnly = True
        Me.PL_SubtractSum.Visible = True
        Me.PL_SubtractSum.VisibleIndex = 10
        '
        'PL_MeritedPay
        '
        Me.PL_MeritedPay.Caption = "工資"
        Me.PL_MeritedPay.FieldName = "PL_MeritedPay"
        Me.PL_MeritedPay.Name = "PL_MeritedPay"
        Me.PL_MeritedPay.OptionsColumn.ReadOnly = True
        Me.PL_MeritedPay.Visible = True
        Me.PL_MeritedPay.VisibleIndex = 11
        Me.PL_MeritedPay.Width = 60
        '
        'PL_Check
        '
        Me.PL_Check.Caption = "審核"
        Me.PL_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.PL_Check.FieldName = "PL_Check"
        Me.PL_Check.Name = "PL_Check"
        Me.PL_Check.OptionsColumn.ReadOnly = True
        Me.PL_Check.Visible = True
        Me.PL_Check.VisibleIndex = 12
        Me.PL_Check.Width = 50
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'PL_AddUserName
        '
        Me.PL_AddUserName.Caption = "操作員"
        Me.PL_AddUserName.FieldName = "PL_AddUserName"
        Me.PL_AddUserName.Name = "PL_AddUserName"
        Me.PL_AddUserName.OptionsColumn.ReadOnly = True
        Me.PL_AddUserName.Visible = True
        Me.PL_AddUserName.VisibleIndex = 13
        Me.PL_AddUserName.Width = 60
        '
        'frmProductionPiecePayPersonnelMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 486)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionPiecePayPersonnelMain"
        Me.Text = "個人計件薪金管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_YYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_DayPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_OnDutyDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_UsualOverHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_HolidayOVerHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_CompensateSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_SubtractSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_MeritedPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCollect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintNoPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
End Class
