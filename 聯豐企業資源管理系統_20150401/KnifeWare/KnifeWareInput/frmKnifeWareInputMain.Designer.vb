<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareInputMain
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
        Dim WIP_AddDate As DevExpress.XtraGrid.Columns.GridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeWareInputMain))
        Me.popKnifeWareInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareInputAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputAddKnife = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInputReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputView = New System.Windows.Forms.ToolStripMenuItem
        Me.popwareinputflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popwareInputLoadFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputPrintColl = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.twWare = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WIP_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KnifeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        WIP_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.popKnifeWareInput.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WIP_AddDate
        '
        WIP_AddDate.Caption = "入庫日期"
        WIP_AddDate.FieldName = "WIP_AddDate"
        WIP_AddDate.Name = "WIP_AddDate"
        WIP_AddDate.Visible = True
        WIP_AddDate.VisibleIndex = 6
        WIP_AddDate.Width = 80
        '
        'popKnifeWareInput
        '
        Me.popKnifeWareInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInputAdd, Me.popWareInputAddKnife, Me.popWareInputEdit, Me.popWareInputDel, Me.popWareInputCheck, Me.ToolStripSeparator2, Me.popWareInputReCheck, Me.popWareInputView, Me.popwareinputflesh, Me.popWareInputSeek, Me.ToolStripSeparator3, Me.popwareInputLoadFile, Me.popWareInputPrint, Me.popWareInputPrintColl, Me.ExportStripMenuItem, Me.COPYToolStripMenuItem})
        Me.popKnifeWareInput.Name = "popWareInput"
        Me.popKnifeWareInput.Size = New System.Drawing.Size(224, 346)
        '
        'popWareInputAdd
        '
        Me.popWareInputAdd.Enabled = False
        Me.popWareInputAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareInputAdd.Name = "popWareInputAdd"
        Me.popWareInputAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareInputAdd.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputAdd.Text = "新增--新刀(&A)"
        '
        'popWareInputAddKnife
        '
        Me.popWareInputAddKnife.Enabled = False
        Me.popWareInputAddKnife.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.popWareInputAddKnife.Name = "popWareInputAddKnife"
        Me.popWareInputAddKnife.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputAddKnife.Text = "新增--待處理(&K)             Ctrl+F"
        '
        'popWareInputEdit
        '
        Me.popWareInputEdit.Enabled = False
        Me.popWareInputEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareInputEdit.Name = "popWareInputEdit"
        Me.popWareInputEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareInputEdit.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputEdit.Text = "修改(&E)..."
        Me.popWareInputEdit.Visible = False
        '
        'popWareInputDel
        '
        Me.popWareInputDel.Enabled = False
        Me.popWareInputDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareInputDel.Name = "popWareInputDel"
        Me.popWareInputDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareInputDel.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputDel.Text = "刪除(&D)"
        Me.popWareInputDel.Visible = False
        '
        'popWareInputCheck
        '
        Me.popWareInputCheck.Enabled = False
        Me.popWareInputCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareInputCheck.Name = "popWareInputCheck"
        Me.popWareInputCheck.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputCheck.Text = "審核"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(220, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'popWareInputReCheck
        '
        Me.popWareInputReCheck.Enabled = False
        Me.popWareInputReCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popWareInputReCheck.Name = "popWareInputReCheck"
        Me.popWareInputReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareInputReCheck.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputReCheck.Text = "復核(&G)..."
        Me.popWareInputReCheck.Visible = False
        '
        'popWareInputView
        '
        Me.popWareInputView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareInputView.Name = "popWareInputView"
        Me.popWareInputView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareInputView.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputView.Text = "查看(&W)..."
        '
        'popwareinputflesh
        '
        Me.popwareinputflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popwareinputflesh.Name = "popwareinputflesh"
        Me.popwareinputflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popwareinputflesh.Size = New System.Drawing.Size(223, 22)
        Me.popwareinputflesh.Text = "刷新(&R)"
        '
        'popWareInputSeek
        '
        Me.popWareInputSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareInputSeek.Name = "popWareInputSeek"
        Me.popWareInputSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInputSeek.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(220, 6)
        '
        'popwareInputLoadFile
        '
        Me.popwareInputLoadFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popwareInputLoadFile.Name = "popwareInputLoadFile"
        Me.popwareInputLoadFile.Size = New System.Drawing.Size(223, 22)
        Me.popwareInputLoadFile.Text = "附加文件(&B)..."
        Me.popwareInputLoadFile.Visible = False
        '
        'popWareInputPrint
        '
        Me.popWareInputPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInputPrint.Name = "popWareInputPrint"
        Me.popWareInputPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareInputPrint.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputPrint.Text = "入庫單(&P)..."
        '
        'popWareInputPrintColl
        '
        Me.popWareInputPrintColl.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInputPrintColl.Name = "popWareInputPrintColl"
        Me.popWareInputPrintColl.Size = New System.Drawing.Size(223, 22)
        Me.popWareInputPrintColl.Text = "入庫月匯總(&J)"
        '
        'ExportStripMenuItem
        '
        Me.ExportStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExportStripMenuItem.Name = "ExportStripMenuItem"
        Me.ExportStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ExportStripMenuItem.Text = "導出(&U)..."
        Me.ExportStripMenuItem.Visible = False
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.COPYToolStripMenuItem.Text = "復制(&C)"
        Me.COPYToolStripMenuItem.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 47)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.twWare)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1083, 454)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 169
        '
        'twWare
        '
        Me.twWare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twWare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twWare.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twWare.FullRowSelect = True
        Me.twWare.HideSelection = False
        Me.twWare.Location = New System.Drawing.Point(0, 0)
        Me.twWare.Name = "twWare"
        Me.twWare.Size = New System.Drawing.Size(125, 454)
        Me.twWare.TabIndex = 41
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(954, 454)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WIP_NUM, Me.WIP_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WIP_Qty, Me.M_Unit, Me.WIP_Remark, Me.OS_BatchID, Me.WIP_ActionName, Me.KnifeType, WIP_AddDate, Me.WIP_CheckRemark, Me.WIP_Check, Me.WIP_ReCheck})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'WIP_NUM
        '
        Me.WIP_NUM.Caption = "唯一編號"
        Me.WIP_NUM.FieldName = "WIP_NUM"
        Me.WIP_NUM.Name = "WIP_NUM"
        '
        'WIP_ID
        '
        Me.WIP_ID.Caption = "入庫單號"
        Me.WIP_ID.FieldName = "WIP_ID"
        Me.WIP_ID.Name = "WIP_ID"
        Me.WIP_ID.Visible = True
        Me.WIP_ID.VisibleIndex = 0
        Me.WIP_ID.Width = 90
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 125
        '
        'M_Name
        '
        Me.M_Name.Caption = "刀具名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 100
        '
        'WIP_Qty
        '
        Me.WIP_Qty.Caption = "入庫數量"
        Me.WIP_Qty.FieldName = "WIP_Qty"
        Me.WIP_Qty.Name = "WIP_Qty"
        Me.WIP_Qty.Visible = True
        Me.WIP_Qty.VisibleIndex = 4
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 7
        '
        'WIP_Remark
        '
        Me.WIP_Remark.Caption = "備註"
        Me.WIP_Remark.FieldName = "WIP_Remark"
        Me.WIP_Remark.Name = "WIP_Remark"
        Me.WIP_Remark.Visible = True
        Me.WIP_Remark.VisibleIndex = 9
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        '
        'WIP_ActionName
        '
        Me.WIP_ActionName.Caption = "操作員"
        Me.WIP_ActionName.FieldName = "WIP_ActionName"
        Me.WIP_ActionName.Name = "WIP_ActionName"
        Me.WIP_ActionName.Visible = True
        Me.WIP_ActionName.VisibleIndex = 8
        '
        'KnifeType
        '
        Me.KnifeType.Caption = "刀具屬性"
        Me.KnifeType.FieldName = "KnifeType"
        Me.KnifeType.Name = "KnifeType"
        Me.KnifeType.Visible = True
        Me.KnifeType.VisibleIndex = 5
        '
        'WIP_CheckRemark
        '
        Me.WIP_CheckRemark.Caption = "審核備注"
        Me.WIP_CheckRemark.FieldName = "WIP_CheckRemark"
        Me.WIP_CheckRemark.Name = "WIP_CheckRemark"
        Me.WIP_CheckRemark.Width = 100
        '
        'WIP_Check
        '
        Me.WIP_Check.Caption = "審核"
        Me.WIP_Check.FieldName = "WIP_Check"
        Me.WIP_Check.Name = "WIP_Check"
        Me.WIP_Check.Visible = True
        Me.WIP_Check.VisibleIndex = 10
        Me.WIP_Check.Width = 50
        '
        'WIP_ReCheck
        '
        Me.WIP_ReCheck.Caption = "復核"
        Me.WIP_ReCheck.FieldName = "WIP_ReCheck"
        Me.WIP_ReCheck.Name = "WIP_ReCheck"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 0
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "warehouse.ico")
        '
        'frmKnifeWareInputMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 505)
        Me.ContextMenuStrip = Me.popKnifeWareInput
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmKnifeWareInputMain"
        Me.Text = "刀具入庫"
        Me.popKnifeWareInput.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents popKnifeWareInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInputAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWareInputReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popwareinputflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popwareInputLoadFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WIP_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnifeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInputAddKnife As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents popWareInputPrintColl As System.Windows.Forms.ToolStripMenuItem
End Class
