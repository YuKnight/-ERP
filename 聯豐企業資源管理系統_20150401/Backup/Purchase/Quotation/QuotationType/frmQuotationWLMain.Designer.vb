<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotationWLMain
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
        Me.Q_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_AccCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_CheckType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_Currency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_AccCheckType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PN_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_AccCheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popQuotation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popQuotationNew = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationDel = New System.Windows.Forms.ToolStripMenuItem
        Me.QuotationRead = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popQuotationCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popQuotationCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popQuotationRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popQuotationSend = New System.Windows.Forms.ToolStripMenuItem
        Me.發送消息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsglook = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsgCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsgAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popQuotationFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuotationPrint2 = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_QuoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_SupplierNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Type3Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_ExchangeRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popQuotation.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q_Check
        '
        Me.Q_Check.Caption = "部門審核"
        Me.Q_Check.FieldName = "Q_Check"
        Me.Q_Check.Name = "Q_Check"
        Me.Q_Check.Visible = True
        Me.Q_Check.VisibleIndex = 13
        '
        'Q_AccCheck
        '
        Me.Q_AccCheck.Caption = "審計部審核"
        Me.Q_AccCheck.FieldName = "Q_AccCheck"
        Me.Q_AccCheck.Name = "Q_AccCheck"
        Me.Q_AccCheck.Visible = True
        Me.Q_AccCheck.VisibleIndex = 14
        '
        'Q_CheckType
        '
        Me.Q_CheckType.Caption = "部門審核類型"
        Me.Q_CheckType.FieldName = "Q_CheckType"
        Me.Q_CheckType.Name = "Q_CheckType"
        Me.Q_CheckType.Visible = True
        Me.Q_CheckType.VisibleIndex = 12
        '
        'Q_Currency
        '
        Me.Q_Currency.Caption = "幣種"
        Me.Q_Currency.FieldName = "Q_Currency"
        Me.Q_Currency.Name = "Q_Currency"
        Me.Q_Currency.Visible = True
        Me.Q_Currency.VisibleIndex = 11
        Me.Q_Currency.Width = 50
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 5
        Me.M_Unit.Width = 50
        '
        'Q_AccCheckType
        '
        Me.Q_AccCheckType.Caption = "審計審核類型"
        Me.Q_AccCheckType.FieldName = "Q_AccCheckType"
        Me.Q_AccCheckType.Name = "Q_AccCheckType"
        Me.Q_AccCheckType.Visible = True
        Me.Q_AccCheckType.VisibleIndex = 15
        '
        'Q_EditDate
        '
        Me.Q_EditDate.Caption = "修改日期"
        Me.Q_EditDate.FieldName = "Q_EditDate"
        Me.Q_EditDate.Name = "Q_EditDate"
        Me.Q_EditDate.Visible = True
        Me.Q_EditDate.VisibleIndex = 19
        '
        'Q_ActionName
        '
        Me.Q_ActionName.Caption = "報價員"
        Me.Q_ActionName.FieldName = "Q_ActionName"
        Me.Q_ActionName.Name = "Q_ActionName"
        Me.Q_ActionName.Visible = True
        Me.Q_ActionName.VisibleIndex = 20
        '
        'PN_NO
        '
        Me.PN_NO.Caption = "申購單號"
        Me.PN_NO.FieldName = "PN_NO"
        Me.PN_NO.Name = "PN_NO"
        Me.PN_NO.Visible = True
        Me.PN_NO.VisibleIndex = 18
        '
        'Q_AccCheckActionName
        '
        Me.Q_AccCheckActionName.Caption = "審計部審核人"
        Me.Q_AccCheckActionName.FieldName = "Q_AccCheckActionName"
        Me.Q_AccCheckActionName.Name = "Q_AccCheckActionName"
        Me.Q_AccCheckActionName.Visible = True
        Me.Q_AccCheckActionName.VisibleIndex = 16
        '
        'Q_AddDate
        '
        Me.Q_AddDate.Caption = "報價日期"
        Me.Q_AddDate.FieldName = "Q_AddDate"
        Me.Q_AddDate.Name = "Q_AddDate"
        Me.Q_AddDate.Visible = True
        Me.Q_AddDate.VisibleIndex = 17
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popQuotation
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 37)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(840, 431)
        Me.Grid1.TabIndex = 171
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popQuotation
        '
        Me.popQuotation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popQuotationNew, Me.popQuotationEdit, Me.popQuotationDel, Me.QuotationRead, Me.ToolStripSeparator5, Me.popQuotationCopy, Me.ToolStripSeparator1, Me.popQuotationCheck, Me.popQuotationAccCheck, Me.ToolStripSeparator2, Me.popQuotationRef, Me.popQuotationSeek, Me.ToolStripSeparator3, Me.popQuotationSend, Me.發送消息ToolStripMenuItem, Me.ToolStripSeparator4, Me.popQuotationFile, Me.popQuotationPrint, Me.popQuotationPrint2})
        Me.popQuotation.Name = "popQuotation"
        Me.popQuotation.Size = New System.Drawing.Size(204, 342)
        '
        'popQuotationNew
        '
        Me.popQuotationNew.Enabled = False
        Me.popQuotationNew.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popQuotationNew.Name = "popQuotationNew"
        Me.popQuotationNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popQuotationNew.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationNew.Text = "新增(&A)..."
        '
        'popQuotationEdit
        '
        Me.popQuotationEdit.Enabled = False
        Me.popQuotationEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popQuotationEdit.Name = "popQuotationEdit"
        Me.popQuotationEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popQuotationEdit.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationEdit.Text = "修改(&E)..."
        '
        'popQuotationDel
        '
        Me.popQuotationDel.Enabled = False
        Me.popQuotationDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popQuotationDel.Name = "popQuotationDel"
        Me.popQuotationDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popQuotationDel.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationDel.Text = "刪除(&D)"
        '
        'QuotationRead
        '
        Me.QuotationRead.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.QuotationRead.Name = "QuotationRead"
        Me.QuotationRead.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.QuotationRead.Size = New System.Drawing.Size(203, 22)
        Me.QuotationRead.Text = "查看(&W)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(200, 6)
        '
        'popQuotationCopy
        '
        Me.popQuotationCopy.Enabled = False
        Me.popQuotationCopy.Image = Global.LFERP.My.Resources.Resources.SmartArtRightToLeft
        Me.popQuotationCopy.Name = "popQuotationCopy"
        Me.popQuotationCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popQuotationCopy.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationCopy.Text = "復制(&C)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'popQuotationCheck
        '
        Me.popQuotationCheck.Enabled = False
        Me.popQuotationCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popQuotationCheck.Name = "popQuotationCheck"
        Me.popQuotationCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popQuotationCheck.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationCheck.Text = "審核(&G)..."
        '
        'popQuotationAccCheck
        '
        Me.popQuotationAccCheck.Enabled = False
        Me.popQuotationAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popQuotationAccCheck.Name = "popQuotationAccCheck"
        Me.popQuotationAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popQuotationAccCheck.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationAccCheck.Text = "部門復核(&S)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'popQuotationRef
        '
        Me.popQuotationRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popQuotationRef.Name = "popQuotationRef"
        Me.popQuotationRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popQuotationRef.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationRef.Text = "刷新(&R)"
        '
        'popQuotationSeek
        '
        Me.popQuotationSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popQuotationSeek.Name = "popQuotationSeek"
        Me.popQuotationSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popQuotationSeek.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(200, 6)
        '
        'popQuotationSend
        '
        Me.popQuotationSend.Enabled = False
        Me.popQuotationSend.Image = Global.LFERP.My.Resources.Resources.SharingOpenMailFolder
        Me.popQuotationSend.Name = "popQuotationSend"
        Me.popQuotationSend.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationSend.Text = "Email詢價(&L)..."
        '
        '發送消息ToolStripMenuItem
        '
        Me.發送消息ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PopMsglook, Me.PopMsgCheck, Me.PopMsgAccCheck})
        Me.發送消息ToolStripMenuItem.Name = "發送消息ToolStripMenuItem"
        Me.發送消息ToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.發送消息ToolStripMenuItem.Text = "發送消息(&I)"
        '
        'PopMsglook
        '
        Me.PopMsglook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.PopMsglook.Name = "PopMsglook"
        Me.PopMsglook.Size = New System.Drawing.Size(143, 22)
        Me.PopMsglook.Text = "查看(&W)..."
        '
        'PopMsgCheck
        '
        Me.PopMsgCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.PopMsgCheck.Name = "PopMsgCheck"
        Me.PopMsgCheck.Size = New System.Drawing.Size(143, 22)
        Me.PopMsgCheck.Text = "部門審核(&G)..."
        '
        'PopMsgAccCheck
        '
        Me.PopMsgAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.PopMsgAccCheck.Name = "PopMsgAccCheck"
        Me.PopMsgAccCheck.Size = New System.Drawing.Size(143, 22)
        Me.PopMsgAccCheck.Text = "審計審核(&S)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'popQuotationFile
        '
        Me.popQuotationFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popQuotationFile.Name = "popQuotationFile"
        Me.popQuotationFile.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationFile.Text = "附加文件(&B)..."
        '
        'popQuotationPrint
        '
        Me.popQuotationPrint.Enabled = False
        Me.popQuotationPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popQuotationPrint.Name = "popQuotationPrint"
        Me.popQuotationPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popQuotationPrint.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationPrint.Text = "詢價單/報價單(&P)..."
        '
        'popQuotationPrint2
        '
        Me.popQuotationPrint2.Enabled = False
        Me.popQuotationPrint2.Name = "popQuotationPrint2"
        Me.popQuotationPrint2.Size = New System.Drawing.Size(203, 22)
        Me.popQuotationPrint2.Text = "詢價單2/報價單2(&J)..."
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Q_Supplier, Me.CO_ID, Me.Q_QuoID, Me.Q_SupplierName, Me.Q_SupplierNo, Me.Type3Name, Me.M_Name, Me.M_Gauge, Me.Q_Price, Me.Q_Currency, Me.M_Unit, Me.Q_CheckType, Me.Q_Check, Me.Q_AccCheck, Me.Q_AccCheckType, Me.Q_AccCheckActionName, Me.Q_AddDate, Me.PN_NO, Me.Q_EditDate, Me.Q_ActionName, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.Q_ExchangeRate})
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
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "單號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.Width = 90
        '
        'Q_Supplier
        '
        Me.Q_Supplier.Caption = "供應商"
        Me.Q_Supplier.FieldName = "Q_Supplier"
        Me.Q_Supplier.Name = "Q_Supplier"
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        '
        'Q_QuoID
        '
        Me.Q_QuoID.Caption = "報價單編號"
        Me.Q_QuoID.FieldName = "Q_QuoID"
        Me.Q_QuoID.Name = "Q_QuoID"
        Me.Q_QuoID.Visible = True
        Me.Q_QuoID.VisibleIndex = 0
        Me.Q_QuoID.Width = 90
        '
        'Q_SupplierName
        '
        Me.Q_SupplierName.Caption = "供應商名"
        Me.Q_SupplierName.FieldName = "Q_SupplierName"
        Me.Q_SupplierName.Name = "Q_SupplierName"
        Me.Q_SupplierName.Visible = True
        Me.Q_SupplierName.VisibleIndex = 1
        Me.Q_SupplierName.Width = 90
        '
        'Q_SupplierNo
        '
        Me.Q_SupplierNo.Caption = "供應商編號"
        Me.Q_SupplierNo.FieldName = "Q_SupplierNo"
        Me.Q_SupplierNo.Name = "Q_SupplierNo"
        '
        'Type3Name
        '
        Me.Type3Name.Caption = "物料類別"
        Me.Type3Name.FieldName = "Type3Name"
        Me.Type3Name.Name = "Type3Name"
        Me.Type3Name.Visible = True
        Me.Type3Name.VisibleIndex = 2
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 60
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 140
        '
        'Q_Price
        '
        Me.Q_Price.Caption = "單價"
        Me.Q_Price.FieldName = "Q_Price"
        Me.Q_Price.Name = "Q_Price"
        Me.Q_Price.Visible = True
        Me.Q_Price.VisibleIndex = 8
        Me.Q_Price.Width = 60
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "數量"
        Me.GridColumn1.FieldName = "Q_Qty"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 60
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "總金額"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Q_Total"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 10
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "小計"
        Me.GridColumn3.FieldName = "Q_SubTotal"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        '
        'Q_ExchangeRate
        '
        Me.Q_ExchangeRate.AppearanceCell.Options.UseTextOptions = True
        Me.Q_ExchangeRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Q_ExchangeRate.Caption = "匯率(兌港幣)"
        Me.Q_ExchangeRate.FieldName = "Q_ExchangeRate"
        Me.Q_ExchangeRate.Name = "Q_ExchangeRate"
        Me.Q_ExchangeRate.Visible = True
        Me.Q_ExchangeRate.VisibleIndex = 7
        Me.Q_ExchangeRate.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "報價單管理-物料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(840, 36)
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'frmQuotationWLMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 465)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmQuotationWLMain"
        Me.Text = "報價單管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popQuotation.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Q_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_AccCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_CheckType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_Currency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_AccCheckType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PN_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_AccCheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_QuoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_SupplierNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popQuotation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popQuotationNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationRead As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popQuotationCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popQuotationCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popQuotationRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popQuotationSend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 發送消息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsglook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsgCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsgAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popQuotationFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuotationPrint2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Type3Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_ExchangeRate As DevExpress.XtraGrid.Columns.GridColumn
End Class
