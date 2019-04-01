<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayMain
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
        Me.MenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolPiecePersonelCollect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolPiecePersonelCollectDay = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.PL_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButtonGroup = New System.Windows.Forms.Button
        Me.ButtonPer = New System.Windows.Forms.Button
        Me.MenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCollect2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrintNoPrice2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolPieceWGCollect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolPieceWGPersonelDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolPieceWGPersonelMoth = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuLoad = New System.Windows.Forms.ToolStripMenuItem
        Me.ButtonPerWG = New System.Windows.Forms.Button
        Me.MenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdRef3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdQuery3 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrintNoPrice3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuSameSamp = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.MenuStrip1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 35)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(684, 443)
        Me.Grid1.TabIndex = 11
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCollect, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdCheck, Me.ToolStripSeparator5, Me.cmdRef, Me.ToolStripSeparator6, Me.cmdView, Me.cmdQuery, Me.cmdPrintNoPrice, Me.ToolStripSeparator7, Me.ToolPiecePersonelCollect, Me.ToolPiecePersonelCollectDay, Me.ToolStripMenuItem1, Me.ExpotExcelToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuSameSamp})
        Me.MenuStrip1.Name = "MenuStrip"
        Me.MenuStrip1.Size = New System.Drawing.Size(234, 326)
        '
        'cmdCollect
        '
        Me.cmdCollect.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.cmdCollect.Name = "cmdCollect"
        Me.cmdCollect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdCollect.Size = New System.Drawing.Size(233, 22)
        Me.cmdCollect.Text = "匯總(&T)..."
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(233, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'cmdDel
        '
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(233, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(230, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(233, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(230, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(233, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(230, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(233, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(233, 22)
        Me.cmdQuery.Text = "查詢(&F)..."
        '
        'cmdPrintNoPrice
        '
        Me.cmdPrintNoPrice.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintNoPrice.Name = "cmdPrintNoPrice"
        Me.cmdPrintNoPrice.Size = New System.Drawing.Size(233, 22)
        Me.cmdPrintNoPrice.Text = "列印..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(230, 6)
        '
        'ToolPiecePersonelCollect
        '
        Me.ToolPiecePersonelCollect.Name = "ToolPiecePersonelCollect"
        Me.ToolPiecePersonelCollect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolPiecePersonelCollect.Size = New System.Drawing.Size(233, 22)
        Me.ToolPiecePersonelCollect.Text = "個人日計件匯總表(每月)"
        '
        'ToolPiecePersonelCollectDay
        '
        Me.ToolPiecePersonelCollectDay.Name = "ToolPiecePersonelCollectDay"
        Me.ToolPiecePersonelCollectDay.Size = New System.Drawing.Size(233, 22)
        Me.ToolPiecePersonelCollectDay.Text = "個人日計件匯總表(每日)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(230, 6)
        '
        'ExpotExcelToolStripMenuItem
        '
        Me.ExpotExcelToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem.Name = "ExpotExcelToolStripMenuItem"
        Me.ExpotExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ExpotExcelToolStripMenuItem.Text = "導出Excel(&U)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Per_NO, Me.Per_Name, Me.PL_YYMM, Me.FacName, Me.DepID, Me.DepName, Me.Per_DayPrice, Me.PL_OnDutyDays, Me.PL_UsualOverHours, Me.PL_HolidayOVerHours, Me.PL_CompensateSum, Me.PL_SubtractSum, Me.PL_MeritedPay, Me.PL_Check, Me.PL_AddUserName})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
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
        Me.Per_NO.SummaryItem.DisplayFormat = "記錄數：{0}"
        Me.Per_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
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
        Me.FacName.FieldName = "PL_FacName"
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
        Me.DepName.FieldName = "PL_DepName"
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
        Me.PL_Check.FieldName = "PL_Check"
        Me.PL_Check.Name = "PL_Check"
        Me.PL_Check.OptionsColumn.ReadOnly = True
        Me.PL_Check.Visible = True
        Me.PL_Check.VisibleIndex = 12
        Me.PL_Check.Width = 50
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "計件薪金管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(683, 34)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ButtonGroup
        '
        Me.ButtonGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGroup.Location = New System.Drawing.Point(422, 5)
        Me.ButtonGroup.Name = "ButtonGroup"
        Me.ButtonGroup.Size = New System.Drawing.Size(102, 24)
        Me.ButtonGroup.TabIndex = 60
        Me.ButtonGroup.Text = "承包計件月匯總"
        Me.ButtonGroup.UseVisualStyleBackColor = False
        '
        'ButtonPer
        '
        Me.ButtonPer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPer.Location = New System.Drawing.Point(298, 5)
        Me.ButtonPer.Name = "ButtonPer"
        Me.ButtonPer.Size = New System.Drawing.Size(102, 24)
        Me.ButtonPer.TabIndex = 59
        Me.ButtonPer.Text = "個人計件月匯總"
        Me.ButtonPer.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCollect2, Me.cmdEdit2, Me.cmdDel2, Me.ToolStripSeparator2, Me.cmdCheck2, Me.ToolStripSeparator3, Me.cmdRef2, Me.ToolStripSeparator4, Me.cmdView2, Me.cmdQuery2, Me.cmdPrintNoPrice2, Me.ToolStripSeparator8, Me.ToolPieceWGCollect, Me.ToolPieceWGPersonelDetail, Me.ToolPieceWGPersonelMoth, Me.ToolStripMenuItem2, Me.ExpotExcelToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ToolStripMenuLoad})
        Me.MenuStrip2.Name = "MenuStrip"
        Me.MenuStrip2.Size = New System.Drawing.Size(179, 326)
        '
        'cmdCollect2
        '
        Me.cmdCollect2.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.cmdCollect2.Name = "cmdCollect2"
        Me.cmdCollect2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdCollect2.Size = New System.Drawing.Size(178, 22)
        Me.cmdCollect2.Text = "匯總(&T)..."
        '
        'cmdEdit2
        '
        Me.cmdEdit2.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit2.Name = "cmdEdit2"
        Me.cmdEdit2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit2.Size = New System.Drawing.Size(178, 22)
        Me.cmdEdit2.Text = "修改(&E)..."
        '
        'cmdDel2
        '
        Me.cmdDel2.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel2.Name = "cmdDel2"
        Me.cmdDel2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel2.Size = New System.Drawing.Size(178, 22)
        Me.cmdDel2.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'cmdCheck2
        '
        Me.cmdCheck2.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck2.Name = "cmdCheck2"
        Me.cmdCheck2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck2.Size = New System.Drawing.Size(178, 22)
        Me.cmdCheck2.Text = "審核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(175, 6)
        '
        'cmdRef2
        '
        Me.cmdRef2.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef2.Name = "cmdRef2"
        Me.cmdRef2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef2.Size = New System.Drawing.Size(178, 22)
        Me.cmdRef2.Text = "刷新(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(175, 6)
        '
        'cmdView2
        '
        Me.cmdView2.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView2.Name = "cmdView2"
        Me.cmdView2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView2.Size = New System.Drawing.Size(178, 22)
        Me.cmdView2.Text = "查看(&W)..."
        '
        'cmdQuery2
        '
        Me.cmdQuery2.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery2.Name = "cmdQuery2"
        Me.cmdQuery2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery2.Size = New System.Drawing.Size(178, 22)
        Me.cmdQuery2.Text = "查詢(&F)..."
        '
        'cmdPrintNoPrice2
        '
        Me.cmdPrintNoPrice2.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintNoPrice2.Name = "cmdPrintNoPrice2"
        Me.cmdPrintNoPrice2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrintNoPrice2.Size = New System.Drawing.Size(178, 22)
        Me.cmdPrintNoPrice2.Text = "列印(&P)..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(175, 6)
        '
        'ToolPieceWGCollect
        '
        Me.ToolPieceWGCollect.Name = "ToolPieceWGCollect"
        Me.ToolPieceWGCollect.Size = New System.Drawing.Size(178, 22)
        Me.ToolPieceWGCollect.Text = "組別計件日匯總"
        '
        'ToolPieceWGPersonelDetail
        '
        Me.ToolPieceWGPersonelDetail.Name = "ToolPieceWGPersonelDetail"
        Me.ToolPieceWGPersonelDetail.Size = New System.Drawing.Size(178, 22)
        Me.ToolPieceWGPersonelDetail.Text = "組別計件個人明細表"
        '
        'ToolPieceWGPersonelMoth
        '
        Me.ToolPieceWGPersonelMoth.Name = "ToolPieceWGPersonelMoth"
        Me.ToolPieceWGPersonelMoth.Size = New System.Drawing.Size(178, 22)
        Me.ToolPieceWGPersonelMoth.Text = "組別名單月匯總"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 6)
        '
        'ExpotExcelToolStripMenuItem1
        '
        Me.ExpotExcelToolStripMenuItem1.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem1.Name = "ExpotExcelToolStripMenuItem1"
        Me.ExpotExcelToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.ExpotExcelToolStripMenuItem1.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(175, 6)
        '
        'ToolStripMenuLoad
        '
        Me.ToolStripMenuLoad.Enabled = False
        Me.ToolStripMenuLoad.Name = "ToolStripMenuLoad"
        Me.ToolStripMenuLoad.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuLoad.Text = "工時比例導入"
        '
        'ButtonPerWG
        '
        Me.ButtonPerWG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPerWG.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonPerWG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPerWG.Location = New System.Drawing.Point(544, 5)
        Me.ButtonPerWG.Name = "ButtonPerWG"
        Me.ButtonPerWG.Size = New System.Drawing.Size(102, 24)
        Me.ButtonPerWG.TabIndex = 61
        Me.ButtonPerWG.Text = "個人薪金匯總"
        Me.ButtonPerWG.UseVisualStyleBackColor = False
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRef3, Me.ToolStripSeparator9, Me.cmdQuery3, Me.cmdPrintNoPrice3, Me.ToolStripMenuItem3, Me.ExpotExcelToolStripMenuItem2})
        Me.MenuStrip3.Name = "MenuStrip"
        Me.MenuStrip3.Size = New System.Drawing.Size(174, 104)
        '
        'cmdRef3
        '
        Me.cmdRef3.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef3.Name = "cmdRef3"
        Me.cmdRef3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef3.Size = New System.Drawing.Size(173, 22)
        Me.cmdRef3.Text = "刷新(&R)"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(170, 6)
        '
        'cmdQuery3
        '
        Me.cmdQuery3.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery3.Name = "cmdQuery3"
        Me.cmdQuery3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery3.Size = New System.Drawing.Size(173, 22)
        Me.cmdQuery3.Text = "查詢(&F)..."
        '
        'cmdPrintNoPrice3
        '
        Me.cmdPrintNoPrice3.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrintNoPrice3.Name = "cmdPrintNoPrice3"
        Me.cmdPrintNoPrice3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrintNoPrice3.Size = New System.Drawing.Size(173, 22)
        Me.cmdPrintNoPrice3.Text = "列印(&P)..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(170, 6)
        '
        'ExpotExcelToolStripMenuItem2
        '
        Me.ExpotExcelToolStripMenuItem2.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem2.Name = "ExpotExcelToolStripMenuItem2"
        Me.ExpotExcelToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.ExpotExcelToolStripMenuItem2.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(230, 6)
        '
        'ToolStripMenuSameSamp
        '
        Me.ToolStripMenuSameSamp.Name = "ToolStripMenuSameSamp"
        Me.ToolStripMenuSameSamp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ToolStripMenuSameSamp.Size = New System.Drawing.Size(233, 22)
        Me.ToolStripMenuSameSamp.Text = "同步樣辦計時(&H)"
        Me.ToolStripMenuSameSamp.Visible = False
        '
        'frmProductionPiecePayMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 478)
        Me.Controls.Add(Me.ButtonPerWG)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGroup)
        Me.Controls.Add(Me.ButtonPer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionPiecePayMain"
        Me.Text = "計件薪金管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents MenuStrip1 As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_YYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_DayPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_OnDutyDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_UsualOverHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_HolidayOVerHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_CompensateSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_SubtractSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_MeritedPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PL_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGroup As System.Windows.Forms.Button
    Friend WithEvents ButtonPer As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCollect2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintNoPrice2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonPerWG As System.Windows.Forms.Button
    Friend WithEvents MenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRef3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdQuery3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintNoPrice3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolPiecePersonelCollect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolPieceWGCollect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolPieceWGPersonelDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolPiecePersonelCollectDay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolPieceWGPersonelMoth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuSameSamp As System.Windows.Forms.ToolStripMenuItem
End Class
