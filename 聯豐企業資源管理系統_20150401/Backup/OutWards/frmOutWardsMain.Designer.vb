<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutWardsMain
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
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsTrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDaoJuPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSonHuoColl = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OW_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Plate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OW_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Sprace = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OW_Sprace = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OW_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OW_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmsMG = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsOutWardsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutWardsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutWardsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsOutWardsCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsOutWardsView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutWardsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOutWardsRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsOutWardsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripPOColl = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMG.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(88, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "送貨管理"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(853, 37)
        Me.PanelControl1.TabIndex = 2
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cmsTrip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(853, 514)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsTrip
        '
        Me.cmsTrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsEdit, Me.cmsDel, Me.ToolStripSeparator2, Me.cmsCheck, Me.ToolStripSeparator4, Me.cmsPreView, Me.cmsQuery, Me.cmsRef, Me.ToolStripSeparator3, Me.cmsPrint, Me.cmsDaoJuPrint, Me.ToolStripMenuItem1, Me.CopyToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSonHuoColl, Me.ToolStripPOColl})
        Me.cmsTrip.Name = "cmsTrip"
        Me.cmsTrip.Size = New System.Drawing.Size(166, 298)
        '
        'cmsAdd
        '
        Me.cmsAdd.Enabled = False
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(165, 22)
        Me.cmsAdd.Text = "新增(&A)..."
        '
        'cmsEdit
        '
        Me.cmsEdit.Enabled = False
        Me.cmsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsEdit.Size = New System.Drawing.Size(165, 22)
        Me.cmsEdit.Text = "修改(&E)..."
        '
        'cmsDel
        '
        Me.cmsDel.Enabled = False
        Me.cmsDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDel.Name = "cmsDel"
        Me.cmsDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDel.Size = New System.Drawing.Size(165, 22)
        Me.cmsDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'cmsCheck
        '
        Me.cmsCheck.Enabled = False
        Me.cmsCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsCheck.Name = "cmsCheck"
        Me.cmsCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsCheck.Size = New System.Drawing.Size(165, 22)
        Me.cmsCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(162, 6)
        '
        'cmsPreView
        '
        Me.cmsPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsPreView.Name = "cmsPreView"
        Me.cmsPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsPreView.Size = New System.Drawing.Size(165, 22)
        Me.cmsPreView.Text = "查看(&W)..."
        '
        'cmsQuery
        '
        Me.cmsQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsQuery.Name = "cmsQuery"
        Me.cmsQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsQuery.Size = New System.Drawing.Size(165, 22)
        Me.cmsQuery.Text = "查詢(&F)..."
        '
        'cmsRef
        '
        Me.cmsRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsRef.Name = "cmsRef"
        Me.cmsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsRef.Size = New System.Drawing.Size(165, 22)
        Me.cmsRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        'cmsPrint
        '
        Me.cmsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsPrint.Name = "cmsPrint"
        Me.cmsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsPrint.Size = New System.Drawing.Size(165, 22)
        Me.cmsPrint.Text = "列印(&P)..."
        '
        'cmsDaoJuPrint
        '
        Me.cmsDaoJuPrint.Name = "cmsDaoJuPrint"
        Me.cmsDaoJuPrint.Size = New System.Drawing.Size(165, 22)
        Me.cmsDaoJuPrint.Text = "列印(刀具倉)(&M)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CopyToolStripMenuItem.Text = "復制全部"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(162, 6)
        '
        'ToolStripSonHuoColl
        '
        Me.ToolStripSonHuoColl.Name = "ToolStripSonHuoColl"
        Me.ToolStripSonHuoColl.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripSonHuoColl.Text = "送貨匯總表"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OW_NO, Me.OS_BatchID, Me.OM_ID, Me.OM_CusterID, Me.OM_CusterNO, Me.OM_CusterPO, Me.PM_M_Code, Me.PM_Type, Me.OS_Plate, Me.OW_Qty, Me.OS_Sprace, Me.OW_Sprace, Me.OW_Date, Me.OW_Check, Me.M_Name, Me.M_Gauge, Me.M_Unit})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'OW_NO
        '
        Me.OW_NO.Caption = "送貨單號"
        Me.OW_NO.FieldName = "OW_NO"
        Me.OW_NO.Name = "OW_NO"
        Me.OW_NO.OptionsColumn.ReadOnly = True
        Me.OW_NO.Visible = True
        Me.OW_NO.VisibleIndex = 0
        Me.OW_NO.Width = 80
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.OptionsColumn.ReadOnly = True
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 1
        '
        'OM_ID
        '
        Me.OM_ID.Caption = "訂單唯一編號"
        Me.OM_ID.FieldName = "OM_ID"
        Me.OM_ID.Name = "OM_ID"
        Me.OM_ID.OptionsColumn.ReadOnly = True
        '
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶代號"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        Me.OM_CusterID.OptionsColumn.ReadOnly = True
        Me.OM_CusterID.Visible = True
        Me.OM_CusterID.VisibleIndex = 2
        '
        'OM_CusterNO
        '
        Me.OM_CusterNO.Caption = "客戶編號"
        Me.OM_CusterNO.FieldName = "OM_CusterNO"
        Me.OM_CusterNO.Name = "OM_CusterNO"
        Me.OM_CusterNO.OptionsColumn.ReadOnly = True
        Me.OM_CusterNO.Visible = True
        Me.OM_CusterNO.VisibleIndex = 3
        '
        'OM_CusterPO
        '
        Me.OM_CusterPO.Caption = "客戶PO NO."
        Me.OM_CusterPO.FieldName = "OM_CusterPO"
        Me.OM_CusterPO.Name = "OM_CusterPO"
        Me.OM_CusterPO.OptionsColumn.ReadOnly = True
        Me.OM_CusterPO.Visible = True
        Me.OM_CusterPO.VisibleIndex = 4
        Me.OM_CusterPO.Width = 90
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 5
        Me.PM_M_Code.Width = 90
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.ReadOnly = True
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 6
        '
        'OS_Plate
        '
        Me.OS_Plate.Caption = "顏色"
        Me.OS_Plate.FieldName = "OS_Plate"
        Me.OS_Plate.Name = "OS_Plate"
        Me.OS_Plate.OptionsColumn.ReadOnly = True
        Me.OS_Plate.Visible = True
        Me.OS_Plate.VisibleIndex = 7
        Me.OS_Plate.Width = 50
        '
        'OW_Qty
        '
        Me.OW_Qty.Caption = "出貨數量"
        Me.OW_Qty.FieldName = "OW_Qty"
        Me.OW_Qty.Name = "OW_Qty"
        Me.OW_Qty.OptionsColumn.ReadOnly = True
        Me.OW_Qty.Visible = True
        Me.OW_Qty.VisibleIndex = 8
        '
        'OS_Sprace
        '
        Me.OS_Sprace.Caption = "批次士啤"
        Me.OS_Sprace.FieldName = "OS_Sprace"
        Me.OS_Sprace.Name = "OS_Sprace"
        Me.OS_Sprace.OptionsColumn.ReadOnly = True
        Me.OS_Sprace.Visible = True
        Me.OS_Sprace.VisibleIndex = 9
        '
        'OW_Sprace
        '
        Me.OW_Sprace.Caption = "送貨士啤"
        Me.OW_Sprace.FieldName = "OW_Sprace"
        Me.OW_Sprace.Name = "OW_Sprace"
        Me.OW_Sprace.OptionsColumn.ReadOnly = True
        Me.OW_Sprace.Visible = True
        Me.OW_Sprace.VisibleIndex = 10
        '
        'OW_Date
        '
        Me.OW_Date.Caption = "送貨日期"
        Me.OW_Date.FieldName = "OW_Date"
        Me.OW_Date.Name = "OW_Date"
        Me.OW_Date.OptionsColumn.ReadOnly = True
        Me.OW_Date.Visible = True
        Me.OW_Date.VisibleIndex = 11
        '
        'OW_Check
        '
        Me.OW_Check.Caption = "審核"
        Me.OW_Check.FieldName = "OW_Check"
        Me.OW_Check.Name = "OW_Check"
        Me.OW_Check.OptionsColumn.ReadOnly = True
        Me.OW_Check.Visible = True
        Me.OW_Check.VisibleIndex = 12
        Me.OW_Check.Width = 50
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        '
        'cmsMG
        '
        Me.cmsMG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsOutWardsAdd, Me.cmsOutWardsEdit, Me.cmsOutWardsDelete, Me.ToolStripSeparator1, Me.cmsOutWardsCheck, Me.ToolStripSeparator5, Me.cmsOutWardsView, Me.cmsOutWardsFind, Me.cmsOutWardsRef, Me.ToolStripSeparator6, Me.cmsOutWardsPrint})
        Me.cmsMG.Name = "cmsTrip"
        Me.cmsMG.Size = New System.Drawing.Size(163, 198)
        '
        'cmsOutWardsAdd
        '
        Me.cmsOutWardsAdd.Enabled = False
        Me.cmsOutWardsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsOutWardsAdd.Name = "cmsOutWardsAdd"
        Me.cmsOutWardsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsOutWardsAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsAdd.Text = "新增(&A)..."
        '
        'cmsOutWardsEdit
        '
        Me.cmsOutWardsEdit.Enabled = False
        Me.cmsOutWardsEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsOutWardsEdit.Name = "cmsOutWardsEdit"
        Me.cmsOutWardsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsOutWardsEdit.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsEdit.Text = "修改(&E)..."
        '
        'cmsOutWardsDelete
        '
        Me.cmsOutWardsDelete.Enabled = False
        Me.cmsOutWardsDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsOutWardsDelete.Name = "cmsOutWardsDelete"
        Me.cmsOutWardsDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsOutWardsDelete.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsDelete.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'cmsOutWardsCheck
        '
        Me.cmsOutWardsCheck.Enabled = False
        Me.cmsOutWardsCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsOutWardsCheck.Name = "cmsOutWardsCheck"
        Me.cmsOutWardsCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsOutWardsCheck.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'cmsOutWardsView
        '
        Me.cmsOutWardsView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsOutWardsView.Name = "cmsOutWardsView"
        Me.cmsOutWardsView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmsOutWardsView.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsView.Text = "查看(&W)..."
        '
        'cmsOutWardsFind
        '
        Me.cmsOutWardsFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsOutWardsFind.Name = "cmsOutWardsFind"
        Me.cmsOutWardsFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsOutWardsFind.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsFind.Text = "查詢(&F)..."
        '
        'cmsOutWardsRef
        '
        Me.cmsOutWardsRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsOutWardsRef.Name = "cmsOutWardsRef"
        Me.cmsOutWardsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsOutWardsRef.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        'cmsOutWardsPrint
        '
        Me.cmsOutWardsPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsOutWardsPrint.Name = "cmsOutWardsPrint"
        Me.cmsOutWardsPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsOutWardsPrint.Size = New System.Drawing.Size(162, 22)
        Me.cmsOutWardsPrint.Text = "列印(&P)..."
        '
        'ToolStripPOColl
        '
        Me.ToolStripPOColl.Name = "ToolStripPOColl"
        Me.ToolStripPOColl.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripPOColl.Text = "訂單匯總表"
        '
        'frmOutWardsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 551)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmOutWardsMain"
        Me.Text = "送貨管理"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMG.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OW_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Plate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OW_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Sprace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OW_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OW_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsTrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsDaoJuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMG As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOutWardsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutWardsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutWardsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsOutWardsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsOutWardsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutWardsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOutWardsRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsOutWardsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OW_Sprace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSonHuoColl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripPOColl As System.Windows.Forms.ToolStripMenuItem
End Class
