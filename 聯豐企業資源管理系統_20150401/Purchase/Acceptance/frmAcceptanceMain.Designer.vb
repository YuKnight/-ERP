<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceptanceMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim A_PayCheck As DevExpress.XtraGrid.Columns.GridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcceptanceMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.popAcceptance = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popAcceptanceAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popBatchCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptancePayCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popBatchPayCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.popDetail1 = New System.Windows.Forms.ToolStripMenuItem
        Me.popDetail2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareMove = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator４ = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptancePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceGether = New System.Windows.Forms.ToolStripMenuItem
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PN_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_UpdateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_ToFrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        A_PayCheck = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popAcceptance.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A_PayCheck
        '
        A_PayCheck.Caption = "付款確認"
        A_PayCheck.FieldName = "A_PayCheck"
        A_PayCheck.Name = "A_PayCheck"
        A_PayCheck.Visible = True
        A_PayCheck.VisibleIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "驗收管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(711, 36)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'popAcceptance
        '
        Me.popAcceptance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popAcceptanceAdd, Me.popAcceptanceEdit, Me.popAcceptanceDel, Me.popAcceptanceView, Me.ToolStripSeparator1, Me.popAcceptanceCheck, Me.popAcceptanceAccCheck, Me.popBatchCheck, Me.popAcceptancePayCheck, Me.popBatchPayCheck, Me.popAcceptanceDetail, Me.ToolStripSeparator3, Me.popWareMove, Me.ToolStripSeparator４, Me.popAcceptanceRef, Me.popAcceptanceFile, Me.ToolStripSeparator2, Me.popAcceptanceSeek, Me.popAcceptancePrint, Me.popAcceptanceGether})
        Me.popAcceptance.Name = "popAcceptance"
        Me.popAcceptance.Size = New System.Drawing.Size(235, 380)
        '
        'popAcceptanceAdd
        '
        Me.popAcceptanceAdd.Enabled = False
        Me.popAcceptanceAdd.Image = CType(resources.GetObject("popAcceptanceAdd.Image"), System.Drawing.Image)
        Me.popAcceptanceAdd.Name = "popAcceptanceAdd"
        Me.popAcceptanceAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popAcceptanceAdd.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceAdd.Text = "暫收(&T)..."
        '
        'popAcceptanceEdit
        '
        Me.popAcceptanceEdit.Enabled = False
        Me.popAcceptanceEdit.Image = CType(resources.GetObject("popAcceptanceEdit.Image"), System.Drawing.Image)
        Me.popAcceptanceEdit.Name = "popAcceptanceEdit"
        Me.popAcceptanceEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popAcceptanceEdit.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceEdit.Text = "修改(&E)..."
        '
        'popAcceptanceDel
        '
        Me.popAcceptanceDel.Enabled = False
        Me.popAcceptanceDel.Image = CType(resources.GetObject("popAcceptanceDel.Image"), System.Drawing.Image)
        Me.popAcceptanceDel.Name = "popAcceptanceDel"
        Me.popAcceptanceDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popAcceptanceDel.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceDel.Text = "刪除(&D)"
        '
        'popAcceptanceView
        '
        Me.popAcceptanceView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popAcceptanceView.Name = "popAcceptanceView"
        Me.popAcceptanceView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popAcceptanceView.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(231, 6)
        '
        'popAcceptanceCheck
        '
        Me.popAcceptanceCheck.Enabled = False
        Me.popAcceptanceCheck.Image = CType(resources.GetObject("popAcceptanceCheck.Image"), System.Drawing.Image)
        Me.popAcceptanceCheck.Name = "popAcceptanceCheck"
        Me.popAcceptanceCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popAcceptanceCheck.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceCheck.Text = "驗收審核(&G)..."
        '
        'popAcceptanceAccCheck
        '
        Me.popAcceptanceAccCheck.Enabled = False
        Me.popAcceptanceAccCheck.Image = CType(resources.GetObject("popAcceptanceAccCheck.Image"), System.Drawing.Image)
        Me.popAcceptanceAccCheck.Name = "popAcceptanceAccCheck"
        Me.popAcceptanceAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popAcceptanceAccCheck.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceAccCheck.Text = "會計部審核(&S)..."
        '
        'popBatchCheck
        '
        Me.popBatchCheck.Enabled = False
        Me.popBatchCheck.Name = "popBatchCheck"
        Me.popBatchCheck.Size = New System.Drawing.Size(234, 22)
        Me.popBatchCheck.Text = "批量審核(&K)..."
        '
        'popAcceptancePayCheck
        '
        Me.popAcceptancePayCheck.Enabled = False
        Me.popAcceptancePayCheck.Name = "popAcceptancePayCheck"
        Me.popAcceptancePayCheck.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptancePayCheck.Text = "付款確認(&O)..."
        '
        'popBatchPayCheck
        '
        Me.popBatchPayCheck.Enabled = False
        Me.popBatchPayCheck.Name = "popBatchPayCheck"
        Me.popBatchPayCheck.Size = New System.Drawing.Size(234, 22)
        Me.popBatchPayCheck.Text = "批量付款確認(&Q)..."
        '
        'popAcceptanceDetail
        '
        Me.popAcceptanceDetail.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popDetail1, Me.popDetail2})
        Me.popAcceptanceDetail.Enabled = False
        Me.popAcceptanceDetail.Name = "popAcceptanceDetail"
        Me.popAcceptanceDetail.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceDetail.Text = "狀態調變更為(&H)"
        '
        'popDetail1
        '
        Me.popDetail1.Name = "popDetail1"
        Me.popDetail1.Size = New System.Drawing.Size(173, 22)
        Me.popDetail1.Text = "已結單(&Y)"
        '
        'popDetail2
        '
        Me.popDetail2.Name = "popDetail2"
        Me.popDetail2.Size = New System.Drawing.Size(173, 22)
        Me.popDetail2.Text = "退貨未處理(&N)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(231, 6)
        '
        'popWareMove
        '
        Me.popWareMove.Enabled = False
        Me.popWareMove.Image = Global.LFERP.My.Resources.Resources.SmartArtRightToLeft
        Me.popWareMove.Name = "popWareMove"
        Me.popWareMove.Size = New System.Drawing.Size(234, 22)
        Me.popWareMove.Text = "調撥單(&I)..."
        '
        'ToolStripSeparator４
        '
        Me.ToolStripSeparator４.Name = "ToolStripSeparator４"
        Me.ToolStripSeparator４.Size = New System.Drawing.Size(231, 6)
        '
        'popAcceptanceRef
        '
        Me.popAcceptanceRef.Image = CType(resources.GetObject("popAcceptanceRef.Image"), System.Drawing.Image)
        Me.popAcceptanceRef.Name = "popAcceptanceRef"
        Me.popAcceptanceRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popAcceptanceRef.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceRef.Text = "刷新(&R)"
        '
        'popAcceptanceFile
        '
        Me.popAcceptanceFile.Image = CType(resources.GetObject("popAcceptanceFile.Image"), System.Drawing.Image)
        Me.popAcceptanceFile.Name = "popAcceptanceFile"
        Me.popAcceptanceFile.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceFile.Text = "附加文件(&B)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(231, 6)
        '
        'popAcceptanceSeek
        '
        Me.popAcceptanceSeek.Image = CType(resources.GetObject("popAcceptanceSeek.Image"), System.Drawing.Image)
        Me.popAcceptanceSeek.Name = "popAcceptanceSeek"
        Me.popAcceptanceSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popAcceptanceSeek.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceSeek.Text = "查詢(&F)..."
        '
        'popAcceptancePrint
        '
        Me.popAcceptancePrint.Name = "popAcceptancePrint"
        Me.popAcceptancePrint.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptancePrint.Text = "送貨詳細表(&L)..."
        '
        'popAcceptanceGether
        '
        Me.popAcceptanceGether.Enabled = False
        Me.popAcceptanceGether.Name = "popAcceptanceGether"
        Me.popAcceptanceGether.Size = New System.Drawing.Size(234, 22)
        Me.popAcceptanceGether.Text = "驗收記錄匯總(&Y)..."
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popAcceptance
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 37)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(711, 339)
        Me.Grid1.TabIndex = 164
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.A_AcceptanceNO, Me.PM_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.DepotNO, Me.A_SendNO, Me.PN_NO, Me.A_Qty, Me.A_Check, Me.A_AccountCheck, A_PayCheck, Me.A_Detail, Me.OS_BatchID, Me.A_SendType, Me.A_SendDate, Me.A_UpdateDate, Me.A_ToFrom, Me.S_SupplierName})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Visible = True
        Me.A_AcceptanceNO.VisibleIndex = 0
        Me.A_AcceptanceNO.Width = 100
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 1
        Me.PM_NO.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 100
        '
        'DepotNO
        '
        Me.DepotNO.Caption = "倉庫代號"
        Me.DepotNO.FieldName = "DepotNO"
        Me.DepotNO.Name = "DepotNO"
        '
        'A_SendNO
        '
        Me.A_SendNO.Caption = "送貨單號"
        Me.A_SendNO.FieldName = "A_SendNO"
        Me.A_SendNO.Name = "A_SendNO"
        Me.A_SendNO.Visible = True
        Me.A_SendNO.VisibleIndex = 7
        '
        'PN_NO
        '
        Me.PN_NO.Caption = "申購單號"
        Me.PN_NO.FieldName = "PN_NO"
        Me.PN_NO.Name = "PN_NO"
        Me.PN_NO.Visible = True
        Me.PN_NO.VisibleIndex = 8
        Me.PN_NO.Width = 100
        '
        'A_Qty
        '
        Me.A_Qty.Caption = "送貨數量"
        Me.A_Qty.FieldName = "A_Qty"
        Me.A_Qty.Name = "A_Qty"
        Me.A_Qty.Visible = True
        Me.A_Qty.VisibleIndex = 9
        '
        'A_Check
        '
        Me.A_Check.Caption = "驗收審核"
        Me.A_Check.FieldName = "A_Check"
        Me.A_Check.Name = "A_Check"
        Me.A_Check.Visible = True
        Me.A_Check.VisibleIndex = 10
        '
        'A_AccountCheck
        '
        Me.A_AccountCheck.Caption = "會計部審核"
        Me.A_AccountCheck.FieldName = "A_AccountCheck"
        Me.A_AccountCheck.Name = "A_AccountCheck"
        Me.A_AccountCheck.Visible = True
        Me.A_AccountCheck.VisibleIndex = 11
        '
        'A_Detail
        '
        Me.A_Detail.Caption = "狀態"
        Me.A_Detail.FieldName = "A_Detail"
        Me.A_Detail.Name = "A_Detail"
        Me.A_Detail.Visible = True
        Me.A_Detail.VisibleIndex = 5
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        '
        'A_SendType
        '
        Me.A_SendType.Caption = "送貨類型"
        Me.A_SendType.FieldName = "A_SendType"
        Me.A_SendType.Name = "A_SendType"
        Me.A_SendType.Visible = True
        Me.A_SendType.VisibleIndex = 6
        '
        'A_SendDate
        '
        Me.A_SendDate.Caption = "送貨日期"
        Me.A_SendDate.FieldName = "A_SendDate"
        Me.A_SendDate.Name = "A_SendDate"
        Me.A_SendDate.Visible = True
        Me.A_SendDate.VisibleIndex = 13
        '
        'A_UpdateDate
        '
        Me.A_UpdateDate.Caption = "修改日期"
        Me.A_UpdateDate.FieldName = "A_UpdateDate"
        Me.A_UpdateDate.Name = "A_UpdateDate"
        Me.A_UpdateDate.Visible = True
        Me.A_UpdateDate.VisibleIndex = 14
        '
        'A_ToFrom
        '
        Me.A_ToFrom.Caption = "付款類型"
        Me.A_ToFrom.FieldName = "A_ToFrom"
        Me.A_ToFrom.Name = "A_ToFrom"
        Me.A_ToFrom.Visible = True
        Me.A_ToFrom.VisibleIndex = 15
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 16
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 379)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(711, 128)
        Me.XtraTabControl1.TabIndex = 166
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(702, 96)
        Me.XtraTabPage2.Text = "退貨記錄"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(702, 96)
        Me.GridControl2.TabIndex = 165
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "物料編碼"
        Me.GridColumn10.FieldName = "M_Code"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 150
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "物料名稱"
        Me.GridColumn11.FieldName = "M_Name"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 100
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "驗收單號"
        Me.GridColumn12.FieldName = "A_AcceptanceNO"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "退貨單號"
        Me.GridColumn13.FieldName = "R_RetrocedeNO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "退貨日期"
        Me.GridColumn14.FieldName = "R_ReturnDate"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        Me.GridColumn14.Width = 100
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "退貨數量"
        Me.GridColumn15.FieldName = "R_Qty"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "退貨審核"
        Me.GridColumn16.FieldName = "R_Check"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "會計部審核"
        Me.GridColumn17.FieldName = "R_AccountCheck"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'frmAcceptanceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 503)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAcceptanceMain"
        Me.Text = "驗收管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popAcceptance.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popAcceptance As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popAcceptanceAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popAcceptanceFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popAcceptancePayCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_UpdateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PN_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popAcceptanceView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents A_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popAcceptancePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents A_ToFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popAcceptanceDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popDetail1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popDetail2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareMove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator４ As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popBatchCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceGether As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popBatchPayCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
End Class
