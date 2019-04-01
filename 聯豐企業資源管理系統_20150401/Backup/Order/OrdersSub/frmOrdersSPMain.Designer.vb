<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdersSPMain
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
        Me.OS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_NoOutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_MakeDetail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_SpraceQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Sprace = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_ToHK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Plate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Fac = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PopRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrdersSubView = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderSubCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderSubSe = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderSubDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderSubEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderSub = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.PopPJUpdate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrdersSubModifyNoSendQty = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.PopOrderSubPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrdersTempDeail = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrdersQCPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.OM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.popOrderSub.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OS_CheckDate
        '
        Me.OS_CheckDate.Caption = "驗貨日期"
        Me.OS_CheckDate.FieldName = "OS_CheckDate"
        Me.OS_CheckDate.Name = "OS_CheckDate"
        Me.OS_CheckDate.Visible = True
        Me.OS_CheckDate.VisibleIndex = 14
        '
        'OS_SendDate
        '
        Me.OS_SendDate.Caption = "交貨日期"
        Me.OS_SendDate.FieldName = "OS_SendDate"
        Me.OS_SendDate.Name = "OS_SendDate"
        Me.OS_SendDate.Visible = True
        Me.OS_SendDate.VisibleIndex = 13
        '
        'OS_NoOutQty
        '
        Me.OS_NoOutQty.Caption = "未出廠數"
        Me.OS_NoOutQty.FieldName = "OS_NoOutQty"
        Me.OS_NoOutQty.Name = "OS_NoOutQty"
        Me.OS_NoOutQty.Visible = True
        Me.OS_NoOutQty.VisibleIndex = 11
        '
        'OS_MakeDetail
        '
        Me.OS_MakeDetail.Caption = "完成狀況"
        Me.OS_MakeDetail.FieldName = "OS_MakeDetail"
        Me.OS_MakeDetail.Name = "OS_MakeDetail"
        Me.OS_MakeDetail.Visible = True
        Me.OS_MakeDetail.VisibleIndex = 15
        '
        'OS_Type
        '
        Me.OS_Type.Caption = "類型"
        Me.OS_Type.FieldName = "OS_Type"
        Me.OS_Type.Name = "OS_Type"
        Me.OS_Type.Visible = True
        Me.OS_Type.VisibleIndex = 12
        Me.OS_Type.Width = 55
        '
        'OS_Price
        '
        Me.OS_Price.Caption = "單價"
        Me.OS_Price.FieldName = "OS_Price"
        Me.OS_Price.Name = "OS_Price"
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 4
        '
        'OM_CusterNo
        '
        Me.OM_CusterNo.Caption = "客戶編號"
        Me.OM_CusterNo.FieldName = "OM_CusterNo"
        Me.OM_CusterNo.Name = "OM_CusterNo"
        Me.OM_CusterNo.Visible = True
        Me.OM_CusterNo.VisibleIndex = 8
        '
        'OS_Qty
        '
        Me.OS_Qty.Caption = "生產數量"
        Me.OS_Qty.FieldName = "OS_Qty"
        Me.OS_Qty.Name = "OS_Qty"
        Me.OS_Qty.Visible = True
        Me.OS_Qty.VisibleIndex = 9
        '
        'OS_NoSendQty
        '
        Me.OS_NoSendQty.Caption = "未交數"
        Me.OS_NoSendQty.FieldName = "OS_NoSendQty"
        Me.OS_NoSendQty.Name = "OS_NoSendQty"
        Me.OS_NoSendQty.Visible = True
        Me.OS_NoSendQty.VisibleIndex = 10
        Me.OS_NoSendQty.Width = 65
        '
        'OS_SpraceQty
        '
        Me.OS_SpraceQty.Caption = "連士啤數量"
        Me.OS_SpraceQty.FieldName = "OS_SpraceQty"
        Me.OS_SpraceQty.Name = "OS_SpraceQty"
        '
        'OS_Sprace
        '
        Me.OS_Sprace.Caption = "士啤"
        Me.OS_Sprace.FieldName = "OS_Sprace"
        Me.OS_Sprace.Name = "OS_Sprace"
        Me.OS_Sprace.Width = 55
        '
        'OS_CheckRemark
        '
        Me.OS_CheckRemark.Caption = "審核備註"
        Me.OS_CheckRemark.FieldName = "OS_CheckRemark"
        Me.OS_CheckRemark.Name = "OS_CheckRemark"
        '
        'OS_CheckAction
        '
        Me.OS_CheckAction.Caption = "審核員"
        Me.OS_CheckAction.FieldName = "OS_CheckAction"
        Me.OS_CheckAction.Name = "OS_CheckAction"
        '
        'OS_Check
        '
        Me.OS_Check.Caption = "審核"
        Me.OS_Check.FieldName = "OS_Check"
        Me.OS_Check.Name = "OS_Check"
        Me.OS_Check.Visible = True
        Me.OS_Check.VisibleIndex = 18
        Me.OS_Check.Width = 55
        '
        'OS_EditDate
        '
        Me.OS_EditDate.Caption = "修改日期"
        Me.OS_EditDate.FieldName = "OS_EditDate"
        Me.OS_EditDate.Name = "OS_EditDate"
        Me.OS_EditDate.Visible = True
        Me.OS_EditDate.VisibleIndex = 20
        Me.OS_EditDate.Width = 85
        '
        'OS_AddDate
        '
        Me.OS_AddDate.Caption = "建立日期"
        Me.OS_AddDate.FieldName = "OS_AddDate"
        Me.OS_AddDate.Name = "OS_AddDate"
        Me.OS_AddDate.Visible = True
        Me.OS_AddDate.VisibleIndex = 19
        Me.OS_AddDate.Width = 85
        '
        'OS_Remark
        '
        Me.OS_Remark.Caption = "備註"
        Me.OS_Remark.FieldName = "OS_Remark"
        Me.OS_Remark.Name = "OS_Remark"
        '
        'OS_ToHK
        '
        Me.OS_ToHK.Caption = "送香港"
        Me.OS_ToHK.FieldName = "OS_ToHK"
        Me.OS_ToHK.Name = "OS_ToHK"
        '
        'OS_Plate
        '
        Me.OS_Plate.Caption = "電鍍"
        Me.OS_Plate.FieldName = "OS_Plate"
        Me.OS_Plate.Name = "OS_Plate"
        Me.OS_Plate.Visible = True
        Me.OS_Plate.VisibleIndex = 17
        Me.OS_Plate.Width = 55
        '
        'OS_Fac
        '
        Me.OS_Fac.Caption = "生產部門"
        Me.OS_Fac.FieldName = "OS_Fac"
        Me.OS_Fac.Name = "OS_Fac"
        '
        'OS_AccountRemark
        '
        Me.OS_AccountRemark.Caption = "會計部備註"
        Me.OS_AccountRemark.FieldName = "OS_AccountRemark"
        Me.OS_AccountRemark.Name = "OS_AccountRemark"
        '
        'OS_AccountAction
        '
        Me.OS_AccountAction.Caption = "會計部審核員"
        Me.OS_AccountAction.FieldName = "OS_AccountAction"
        Me.OS_AccountAction.Name = "OS_AccountAction"
        '
        'OS_AccountCheck
        '
        Me.OS_AccountCheck.Caption = "會計部審核"
        Me.OS_AccountCheck.FieldName = "OS_AccountCheck"
        Me.OS_AccountCheck.Name = "OS_AccountCheck"
        '
        'PopRefresh
        '
        Me.PopRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.PopRefresh.Name = "PopRefresh"
        Me.PopRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.PopRefresh.Size = New System.Drawing.Size(238, 22)
        Me.PopRefresh.Text = "刷新(&R)"
        '
        'popOrdersSubView
        '
        Me.popOrdersSubView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popOrdersSubView.Name = "popOrdersSubView"
        Me.popOrdersSubView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popOrdersSubView.Size = New System.Drawing.Size(238, 22)
        Me.popOrdersSubView.Text = "查看(&W)..."
        '
        'popOrderSubCheck
        '
        Me.popOrderSubCheck.Enabled = False
        Me.popOrderSubCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popOrderSubCheck.Name = "popOrderSubCheck"
        Me.popOrderSubCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popOrderSubCheck.Size = New System.Drawing.Size(238, 22)
        Me.popOrderSubCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(235, 6)
        '
        'popOrderSubSe
        '
        Me.popOrderSubSe.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popOrderSubSe.Name = "popOrderSubSe"
        Me.popOrderSubSe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popOrderSubSe.Size = New System.Drawing.Size(238, 22)
        Me.popOrderSubSe.Text = "查詢(&F)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'popOrderSubDel
        '
        Me.popOrderSubDel.Enabled = False
        Me.popOrderSubDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popOrderSubDel.Name = "popOrderSubDel"
        Me.popOrderSubDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popOrderSubDel.Size = New System.Drawing.Size(238, 22)
        Me.popOrderSubDel.Text = "刪除(&D)"
        '
        'popOrderSubEdit
        '
        Me.popOrderSubEdit.Enabled = False
        Me.popOrderSubEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popOrderSubEdit.Name = "popOrderSubEdit"
        Me.popOrderSubEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popOrderSubEdit.Size = New System.Drawing.Size(238, 22)
        Me.popOrderSubEdit.Text = "修改(&E)..."
        '
        'popOrderSub
        '
        Me.popOrderSub.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popOrderSubEdit, Me.popOrderSubDel, Me.ToolStripSeparator4, Me.PopPJUpdate, Me.ToolStripSeparator5, Me.popOrderSubCheck, Me.popOrdersSubView, Me.PopRefresh, Me.ToolStripSeparator1, Me.popOrderSubSe, Me.ToolStripSeparator2, Me.popOrdersSubModifyNoSendQty, Me.ToolStripSeparator3, Me.PopOrderSubPrint, Me.popOrdersTempDeail, Me.popOrdersQCPrint})
        Me.popOrderSub.Name = "popOrderMain"
        Me.popOrderSub.Size = New System.Drawing.Size(239, 298)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(235, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'PopPJUpdate
        '
        Me.PopPJUpdate.Enabled = False
        Me.PopPJUpdate.Name = "PopPJUpdate"
        Me.PopPJUpdate.Size = New System.Drawing.Size(238, 22)
        Me.PopPJUpdate.Text = "更新配件(&U)..."
        Me.PopPJUpdate.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(235, 6)
        '
        'popOrdersSubModifyNoSendQty
        '
        Me.popOrdersSubModifyNoSendQty.Enabled = False
        Me.popOrdersSubModifyNoSendQty.Name = "popOrdersSubModifyNoSendQty"
        Me.popOrdersSubModifyNoSendQty.Size = New System.Drawing.Size(238, 22)
        Me.popOrdersSubModifyNoSendQty.Text = "調整未交數(&J)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(235, 6)
        '
        'PopOrderSubPrint
        '
        Me.PopOrderSubPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.PopOrderSubPrint.Name = "PopOrderSubPrint"
        Me.PopOrderSubPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PopOrderSubPrint.Size = New System.Drawing.Size(238, 22)
        Me.PopOrderSubPrint.Text = "打印物料清單(&P)..."
        '
        'popOrdersTempDeail
        '
        Me.popOrdersTempDeail.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popOrdersTempDeail.Name = "popOrdersTempDeail"
        Me.popOrdersTempDeail.Size = New System.Drawing.Size(238, 22)
        Me.popOrdersTempDeail.Text = "打印臨時單(&T)..."
        Me.popOrdersTempDeail.Visible = False
        '
        'popOrdersQCPrint
        '
        Me.popOrdersQCPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popOrdersQCPrint.Name = "popOrdersQCPrint"
        Me.popOrdersQCPrint.Size = New System.Drawing.Size(238, 22)
        Me.popOrdersQCPrint.Text = "物料清單-QC專用(&Q)..."
        Me.popOrdersQCPrint.Visible = False
        '
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        Me.OM_CusterID.Visible = True
        Me.OM_CusterID.VisibleIndex = 7
        '
        'OM_No
        '
        Me.OM_No.Caption = "訂單編號"
        Me.OM_No.FieldName = "OM_No"
        Me.OM_No.Name = "OM_No"
        Me.OM_No.Visible = True
        Me.OM_No.VisibleIndex = 0
        Me.OM_No.Width = 90
        '
        'OM_ID
        '
        Me.OM_ID.Caption = "訂單流水號"
        Me.OM_ID.FieldName = "OM_ID"
        Me.OM_ID.Name = "OM_ID"
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "本廠編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 3
        Me.PM_M_Code.Width = 100
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "生產批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 2
        '
        'OM_CusterPO
        '
        Me.OM_CusterPO.Caption = "客戶PO"
        Me.OM_CusterPO.FieldName = "OM_CusterPO"
        Me.OM_CusterPO.Name = "OM_CusterPO"
        Me.OM_CusterPO.Visible = True
        Me.OM_CusterPO.VisibleIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "批次生產資料-配件"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popOrderSub
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 40)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(673, 381)
        Me.Grid1.TabIndex = 170
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OM_ID, Me.OM_No, Me.OM_CusterID, Me.OM_CusterPO, Me.OS_BatchID, Me.PM_M_Code, Me.M_Name1, Me.OS_Qty, Me.OM_CusterNo, Me.PM_JiYu, Me.OS_Sprace, Me.OS_SpraceQty, Me.OS_NoSendQty, Me.OS_NoOutQty, Me.OS_SendDate, Me.OS_CheckDate, Me.OS_Price, Me.OS_Type, Me.OS_MakeDetail, Me.FacName, Me.OS_Fac, Me.OS_Plate, Me.OS_ToHK, Me.OS_AccountCheck, Me.OS_AccountAction, Me.OS_AccountRemark, Me.OS_Check, Me.OS_CheckAction, Me.OS_CheckRemark, Me.OS_Remark, Me.OS_AddDate, Me.OS_EditDate, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_BatchID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Name1
        '
        Me.M_Name1.Caption = "配件名稱"
        Me.M_Name1.FieldName = "M_Name"
        Me.M_Name1.Name = "M_Name1"
        '
        'FacName
        '
        Me.FacName.Caption = "生產部門"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 16
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 21
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 6
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 22
        '
        'M_BatchID
        '
        Me.M_BatchID.Caption = "大貨批次"
        Me.M_BatchID.FieldName = "M_BatchID"
        Me.M_BatchID.Name = "M_BatchID"
        Me.M_BatchID.Visible = True
        Me.M_BatchID.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 36)
        Me.PictureBox1.TabIndex = 168
        Me.PictureBox1.TabStop = False
        '
        'frmOrdersSPMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 420)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOrdersSPMain"
        Me.Text = "批次生產資料"
        Me.popOrderSub.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_NoOutQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_MakeDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_SpraceQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Sprace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_ToHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Plate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Fac As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrdersSubView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderSubCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popOrderSubSe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popOrderSubDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderSubEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderSub As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopPJUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopOrderSubPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrdersTempDeail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents popOrdersQCPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popOrdersSubModifyNoSendQty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
