<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseYBMain
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
        Me.popQuotation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPurchaseNew = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchaseEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchaseDel = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseRead = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popPurchaseCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchaseAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popPurchaseRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchaseSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popPurchaseSend = New System.Windows.Forms.ToolStripMenuItem
        Me.發送信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsgLookPur = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsgCheckPur = New System.Windows.Forms.ToolStripMenuItem
        Me.PopMsgAccCheckPur = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popPurchaseFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchasePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchasePrintEng = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_QTY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_PurchaseDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_PurchaseType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_AccountCheckType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_AccCheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_PayCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_ChangeNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.C_Reason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popQuotation.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "採購管理-樣辦"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.Grid1.Size = New System.Drawing.Size(519, 252)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popQuotation
        '
        Me.popQuotation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPurchaseNew, Me.popPurchaseEdit, Me.popPurchaseDel, Me.PurchaseRead, Me.ToolStripSeparator1, Me.popPurchaseCheck, Me.popPurchaseAccCheck, Me.ToolStripSeparator2, Me.popPurchaseRef, Me.popPurchaseSeek, Me.ToolStripSeparator3, Me.popPurchaseSend, Me.發送信息ToolStripMenuItem, Me.ToolStripSeparator4, Me.popPurchaseFile, Me.popPurchasePrint, Me.popPurchasePrintEng})
        Me.popQuotation.Name = "popQuotation"
        Me.popQuotation.Size = New System.Drawing.Size(197, 314)
        '
        'popPurchaseNew
        '
        Me.popPurchaseNew.Enabled = False
        Me.popPurchaseNew.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPurchaseNew.Name = "popPurchaseNew"
        Me.popPurchaseNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPurchaseNew.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseNew.Text = "新增(&A)..."
        '
        'popPurchaseEdit
        '
        Me.popPurchaseEdit.Enabled = False
        Me.popPurchaseEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popPurchaseEdit.Name = "popPurchaseEdit"
        Me.popPurchaseEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popPurchaseEdit.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseEdit.Text = "修改(&E)..."
        '
        'popPurchaseDel
        '
        Me.popPurchaseDel.Enabled = False
        Me.popPurchaseDel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.popPurchaseDel.Name = "popPurchaseDel"
        Me.popPurchaseDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPurchaseDel.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseDel.Text = "刪除(&D)"
        '
        'PurchaseRead
        '
        Me.PurchaseRead.Enabled = False
        Me.PurchaseRead.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.PurchaseRead.Name = "PurchaseRead"
        Me.PurchaseRead.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.PurchaseRead.Size = New System.Drawing.Size(196, 22)
        Me.PurchaseRead.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'popPurchaseCheck
        '
        Me.popPurchaseCheck.Enabled = False
        Me.popPurchaseCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popPurchaseCheck.Name = "popPurchaseCheck"
        Me.popPurchaseCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popPurchaseCheck.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseCheck.Text = "審核(&G)..."
        '
        'popPurchaseAccCheck
        '
        Me.popPurchaseAccCheck.Enabled = False
        Me.popPurchaseAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popPurchaseAccCheck.Name = "popPurchaseAccCheck"
        Me.popPurchaseAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popPurchaseAccCheck.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseAccCheck.Text = "會計部審核(&S)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'popPurchaseRef
        '
        Me.popPurchaseRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popPurchaseRef.Name = "popPurchaseRef"
        Me.popPurchaseRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popPurchaseRef.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseRef.Text = "刷新(&R)"
        '
        'popPurchaseSeek
        '
        Me.popPurchaseSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popPurchaseSeek.Name = "popPurchaseSeek"
        Me.popPurchaseSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popPurchaseSeek.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(193, 6)
        '
        'popPurchaseSend
        '
        Me.popPurchaseSend.Enabled = False
        Me.popPurchaseSend.Image = Global.LFERP.My.Resources.Resources.SharingOpenMailFolder
        Me.popPurchaseSend.Name = "popPurchaseSend"
        Me.popPurchaseSend.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseSend.Text = "Email採購(&L)..."
        '
        '發送信息ToolStripMenuItem
        '
        Me.發送信息ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PopMsgLookPur, Me.PopMsgCheckPur, Me.PopMsgAccCheckPur})
        Me.發送信息ToolStripMenuItem.Name = "發送信息ToolStripMenuItem"
        Me.發送信息ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.發送信息ToolStripMenuItem.Text = "發送信息(&I)"
        '
        'PopMsgLookPur
        '
        Me.PopMsgLookPur.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.PopMsgLookPur.Name = "PopMsgLookPur"
        Me.PopMsgLookPur.Size = New System.Drawing.Size(143, 22)
        Me.PopMsgLookPur.Text = "查看(&W)..."
        '
        'PopMsgCheckPur
        '
        Me.PopMsgCheckPur.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.PopMsgCheckPur.Name = "PopMsgCheckPur"
        Me.PopMsgCheckPur.Size = New System.Drawing.Size(143, 22)
        Me.PopMsgCheckPur.Text = "部門審核(&G)..."
        '
        'PopMsgAccCheckPur
        '
        Me.PopMsgAccCheckPur.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.PopMsgAccCheckPur.Name = "PopMsgAccCheckPur"
        Me.PopMsgAccCheckPur.Size = New System.Drawing.Size(143, 22)
        Me.PopMsgAccCheckPur.Text = "會計審核(&S)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(193, 6)
        '
        'popPurchaseFile
        '
        Me.popPurchaseFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popPurchaseFile.Name = "popPurchaseFile"
        Me.popPurchaseFile.Size = New System.Drawing.Size(196, 22)
        Me.popPurchaseFile.Text = "附加文件(&B)..."
        '
        'popPurchasePrint
        '
        Me.popPurchasePrint.Enabled = False
        Me.popPurchasePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popPurchasePrint.Name = "popPurchasePrint"
        Me.popPurchasePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popPurchasePrint.Size = New System.Drawing.Size(196, 22)
        Me.popPurchasePrint.Text = "採購單(中文)(&P)..."
        '
        'popPurchasePrintEng
        '
        Me.popPurchasePrintEng.Enabled = False
        Me.popPurchasePrintEng.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popPurchasePrintEng.Name = "popPurchasePrintEng"
        Me.popPurchasePrintEng.Size = New System.Drawing.Size(196, 22)
        Me.popPurchasePrintEng.Text = "採購單(英文)(&H)..."
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_NO, Me.S_SupplierName, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.OS_BatchID, Me.PS_Price, Me.C_ID, Me.PS_QTY, Me.PS_NoSendQty, Me.PM_PurchaseDate, Me.PM_PurchaseType, Me.PM_Check, Me.PM_AccountCheck, Me.PM_AccountCheckType, Me.PM_AccCheckActionName, Me.PM_ActionName, Me.CO_ID, Me.PS_NO, Me.S_Supplier, Me.S_SupplierNo})
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
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 0
        Me.PM_NO.Width = 90
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 126
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
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 5
        '
        'PS_Price
        '
        Me.PS_Price.Caption = "單價"
        Me.PS_Price.FieldName = "PS_Price"
        Me.PS_Price.Name = "PS_Price"
        Me.PS_Price.Visible = True
        Me.PS_Price.VisibleIndex = 7
        Me.PS_Price.Width = 50
        '
        'C_ID
        '
        Me.C_ID.Caption = "幣別"
        Me.C_ID.FieldName = "C_ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.Visible = True
        Me.C_ID.VisibleIndex = 8
        Me.C_ID.Width = 50
        '
        'PS_QTY
        '
        Me.PS_QTY.Caption = "數量"
        Me.PS_QTY.FieldName = "PS_QTY"
        Me.PS_QTY.Name = "PS_QTY"
        Me.PS_QTY.Visible = True
        Me.PS_QTY.VisibleIndex = 9
        Me.PS_QTY.Width = 60
        '
        'PS_NoSendQty
        '
        Me.PS_NoSendQty.Caption = "未交數"
        Me.PS_NoSendQty.FieldName = "PS_NoSendQty"
        Me.PS_NoSendQty.Name = "PS_NoSendQty"
        Me.PS_NoSendQty.Visible = True
        Me.PS_NoSendQty.VisibleIndex = 10
        Me.PS_NoSendQty.Width = 60
        '
        'PM_PurchaseDate
        '
        Me.PM_PurchaseDate.Caption = "採購日期"
        Me.PM_PurchaseDate.FieldName = "PM_PurchaseDate"
        Me.PM_PurchaseDate.Name = "PM_PurchaseDate"
        Me.PM_PurchaseDate.Visible = True
        Me.PM_PurchaseDate.VisibleIndex = 11
        '
        'PM_PurchaseType
        '
        Me.PM_PurchaseType.Caption = "採購類型"
        Me.PM_PurchaseType.FieldName = "PM_PurchaseType"
        Me.PM_PurchaseType.Name = "PM_PurchaseType"
        '
        'PM_Check
        '
        Me.PM_Check.Caption = "部門審核"
        Me.PM_Check.FieldName = "PM_Check"
        Me.PM_Check.Name = "PM_Check"
        Me.PM_Check.Visible = True
        Me.PM_Check.VisibleIndex = 12
        '
        'PM_AccountCheck
        '
        Me.PM_AccountCheck.Caption = "會計審核"
        Me.PM_AccountCheck.FieldName = "PM_AccountCheck"
        Me.PM_AccountCheck.Name = "PM_AccountCheck"
        Me.PM_AccountCheck.Visible = True
        Me.PM_AccountCheck.VisibleIndex = 13
        '
        'PM_AccountCheckType
        '
        Me.PM_AccountCheckType.Caption = "會計審核類型"
        Me.PM_AccountCheckType.FieldName = "PM_AccountCheckType"
        Me.PM_AccountCheckType.Name = "PM_AccountCheckType"
        Me.PM_AccountCheckType.Visible = True
        Me.PM_AccountCheckType.VisibleIndex = 14
        '
        'PM_AccCheckActionName
        '
        Me.PM_AccCheckActionName.Caption = "會計部審核員"
        Me.PM_AccCheckActionName.FieldName = "PM_AccCheckActionName"
        Me.PM_AccCheckActionName.Name = "PM_AccCheckActionName"
        Me.PM_AccCheckActionName.Visible = True
        Me.PM_AccCheckActionName.VisibleIndex = 15
        '
        'PM_ActionName
        '
        Me.PM_ActionName.Caption = "操作員"
        Me.PM_ActionName.FieldName = "PM_ActionName"
        Me.PM_ActionName.Name = "PM_ActionName"
        Me.PM_ActionName.Visible = True
        Me.PM_ActionName.VisibleIndex = 16
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "PS_NO"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "S_Supplier"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        '
        'S_SupplierNo
        '
        Me.S_SupplierNo.Caption = "供應商編號"
        Me.S_SupplierNo.FieldName = "S_SupplierNo"
        Me.S_SupplierNo.Name = "S_SupplierNo"
        Me.S_SupplierNo.Visible = True
        Me.S_SupplierNo.VisibleIndex = 6
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 292)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(519, 178)
        Me.XtraTabControl1.TabIndex = 167
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(510, 146)
        Me.XtraTabPage1.Text = "送貨記錄"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(510, 145)
        Me.GridControl1.TabIndex = 167
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.A_AcceptanceNO, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.A_Check, Me.A_AccountCheck, Me.A_PayCheck})
        Me.GridView1.GridControl = Me.GridControl1
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "物料編碼"
        Me.GridColumn1.FieldName = "M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 130
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料名稱"
        Me.GridColumn2.FieldName = "M_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Visible = True
        Me.A_AcceptanceNO.VisibleIndex = 2
        Me.A_AcceptanceNO.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "送貨單號"
        Me.GridColumn3.FieldName = "A_SendNO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 85
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "送貨日期"
        Me.GridColumn4.FieldName = "A_SendDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "送貨數量"
        Me.GridColumn5.FieldName = "A_Qty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'A_Check
        '
        Me.A_Check.Caption = "驗收"
        Me.A_Check.FieldName = "A_Check"
        Me.A_Check.Name = "A_Check"
        Me.A_Check.Visible = True
        Me.A_Check.VisibleIndex = 6
        Me.A_Check.Width = 60
        '
        'A_AccountCheck
        '
        Me.A_AccountCheck.Caption = "會計部審核"
        Me.A_AccountCheck.FieldName = "A_AccountCheck"
        Me.A_AccountCheck.Name = "A_AccountCheck"
        Me.A_AccountCheck.Visible = True
        Me.A_AccountCheck.VisibleIndex = 7
        '
        'A_PayCheck
        '
        Me.A_PayCheck.Caption = "付款確認"
        Me.A_PayCheck.FieldName = "A_PayCheck"
        Me.A_PayCheck.Name = "A_PayCheck"
        Me.A_PayCheck.Visible = True
        Me.A_PayCheck.VisibleIndex = 8
        Me.A_PayCheck.Width = 68
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(510, 146)
        Me.XtraTabPage2.Text = "退貨記錄"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl2.Location = New System.Drawing.Point(1, 0)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(508, 146)
        Me.GridControl2.TabIndex = 168
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
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
        'GridColumn6
        '
        Me.GridColumn6.Caption = "物料編碼"
        Me.GridColumn6.FieldName = "M_Code"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 150
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "物料名稱"
        Me.GridColumn7.FieldName = "M_Name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "驗收單號"
        Me.GridColumn8.FieldName = "A_AcceptanceNO"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "退貨單號"
        Me.GridColumn9.FieldName = "R_RetrocedeNO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "退貨日期"
        Me.GridColumn10.FieldName = "R_ReturnDate"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "退貨數量"
        Me.GridColumn11.FieldName = "R_Qty"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "退貨審核"
        Me.GridColumn12.FieldName = "R_Check"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "會計部審核"
        Me.GridColumn13.FieldName = "R_AccountCheck"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(510, 146)
        Me.XtraTabPage3.Text = "更改單記錄"
        '
        'GridControl3
        '
        Me.GridControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl3.Location = New System.Drawing.Point(-1, 0)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit3})
        Me.GridControl3.Size = New System.Drawing.Size(509, 146)
        Me.GridControl3.TabIndex = 169
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_ChangeNO, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.C_NoSendQty, Me.C_Price, Me.C_Date, Me.ActionName, Me.C_Check, Me.C_Reason})
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView4.OptionsFilter.AllowFilterEditor = False
        Me.GridView4.OptionsFilter.AllowMRUFilterList = False
        Me.GridView4.OptionsMenu.EnableColumnMenu = False
        Me.GridView4.OptionsMenu.EnableFooterMenu = False
        Me.GridView4.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'C_ChangeNO
        '
        Me.C_ChangeNO.Caption = "更改單號"
        Me.C_ChangeNO.FieldName = "C_ChangeNO"
        Me.C_ChangeNO.Name = "C_ChangeNO"
        Me.C_ChangeNO.Visible = True
        Me.C_ChangeNO.VisibleIndex = 0
        Me.C_ChangeNO.Width = 90
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "採購單號"
        Me.GridColumn14.FieldName = "PM_NO"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 90
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "物料編碼"
        Me.GridColumn15.FieldName = "M_Code"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 2
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "物料名稱"
        Me.GridColumn16.FieldName = "M_Name"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "物料規格"
        Me.GridColumn17.FieldName = "M_Gauge"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        '
        'C_NoSendQty
        '
        Me.C_NoSendQty.Caption = "更改後未交數量"
        Me.C_NoSendQty.FieldName = "C_NoSendQty"
        Me.C_NoSendQty.Name = "C_NoSendQty"
        Me.C_NoSendQty.Visible = True
        Me.C_NoSendQty.VisibleIndex = 5
        Me.C_NoSendQty.Width = 100
        '
        'C_Price
        '
        Me.C_Price.Caption = "單價"
        Me.C_Price.FieldName = "C_Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.Visible = True
        Me.C_Price.VisibleIndex = 6
        Me.C_Price.Width = 65
        '
        'C_Date
        '
        Me.C_Date.Caption = "更改日期"
        Me.C_Date.FieldName = "C_Date"
        Me.C_Date.Name = "C_Date"
        Me.C_Date.Visible = True
        Me.C_Date.VisibleIndex = 7
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 9
        Me.ActionName.Width = 65
        '
        'C_Check
        '
        Me.C_Check.Caption = "審核"
        Me.C_Check.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.C_Check.FieldName = "C_Check"
        Me.C_Check.Name = "C_Check"
        Me.C_Check.Visible = True
        Me.C_Check.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'C_Reason
        '
        Me.C_Reason.Caption = "更改原因"
        Me.C_Reason.FieldName = "C_Reason"
        Me.C_Reason.Name = "C_Reason"
        Me.C_Reason.Visible = True
        Me.C_Reason.VisibleIndex = 8
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'frmPurchaseYBMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 470)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPurchaseYBMain"
        Me.Text = "採購管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popQuotation.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_PurchaseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_PurchaseType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_AccountCheckType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_AccCheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_PayCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C_ChangeNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents popQuotation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPurchaseNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchaseEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchaseDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseRead As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPurchaseCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchaseAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPurchaseRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchaseSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPurchaseSend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 發送信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsgLookPur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsgCheckPur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopMsgAccCheckPur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPurchaseFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchasePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchasePrintEng As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C_Reason As DevExpress.XtraGrid.Columns.GridColumn
End Class
