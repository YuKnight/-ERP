<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchDetailMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.PopBatchMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popBatchQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.popBatchRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popCode = New System.Windows.Forms.ToolStripMenuItem
        Me.popLFPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popCodePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popCodeQCPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popPJPCPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.OutwardCompletePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.OutwardDetailPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryDetailPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Sprace = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_SpraceQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_NoOutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_MakeDetail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Fac = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Plate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_ToHK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AccountRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopBatchMenu.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(665, 34)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "批次狀況-大貨"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.PopBatchMenu
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 34)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(665, 517)
        Me.Grid1.TabIndex = 168
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PopBatchMenu
        '
        Me.PopBatchMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popBatchQuery, Me.popBatchRef, Me.popCode, Me.popLFPrint, Me.ToolStripSeparator1, Me.popCodePrint, Me.popCodeQCPrint, Me.popPJPCPrint, Me.OutwardCompletePrint, Me.OutwardDetailPrint, Me.DeliveryDetailPrint})
        Me.PopBatchMenu.Name = "PopBatchMenu"
        Me.PopBatchMenu.Size = New System.Drawing.Size(211, 252)
        '
        'popBatchQuery
        '
        Me.popBatchQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popBatchQuery.Name = "popBatchQuery"
        Me.popBatchQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popBatchQuery.Size = New System.Drawing.Size(210, 22)
        Me.popBatchQuery.Text = "查詢(&F)..."
        '
        'popBatchRef
        '
        Me.popBatchRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popBatchRef.Name = "popBatchRef"
        Me.popBatchRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popBatchRef.Size = New System.Drawing.Size(210, 22)
        Me.popBatchRef.Text = "刷新(&R)"
        '
        'popCode
        '
        Me.popCode.Enabled = False
        Me.popCode.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popCode.Name = "popCode"
        Me.popCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popCode.Size = New System.Drawing.Size(210, 22)
        Me.popCode.Text = "查看物料信息(&W)..."
        '
        'popLFPrint
        '
        Me.popLFPrint.Enabled = False
        Me.popLFPrint.Image = Global.LFERP.My.Resources.Resources.AdvancedFileProperties
        Me.popLFPrint.Name = "popLFPrint"
        Me.popLFPrint.Size = New System.Drawing.Size(210, 22)
        Me.popLFPrint.Text = "錶殼資料(&B)..."
        '
        'popCodePrint
        '
        Me.popCodePrint.Enabled = False
        Me.popCodePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popCodePrint.Name = "popCodePrint"
        Me.popCodePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popCodePrint.Size = New System.Drawing.Size(210, 22)
        Me.popCodePrint.Text = "物料清單(&P)..."
        '
        'popCodeQCPrint
        '
        Me.popCodeQCPrint.Enabled = False
        Me.popCodeQCPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popCodeQCPrint.Name = "popCodeQCPrint"
        Me.popCodeQCPrint.Size = New System.Drawing.Size(210, 22)
        Me.popCodeQCPrint.Text = "物料清單-QC專用(&Q)..."
        '
        'popPJPCPrint
        '
        Me.popPJPCPrint.Enabled = False
        Me.popPJPCPrint.Name = "popPJPCPrint"
        Me.popPJPCPrint.Size = New System.Drawing.Size(202, 22)
        Me.popPJPCPrint.Text = "批次交貨進度表(&J)..."
        '
        'OutwardCompletePrint
        '
        Me.OutwardCompletePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.OutwardCompletePrint.Name = "OutwardCompletePrint"
        Me.OutwardCompletePrint.Size = New System.Drawing.Size(210, 22)
        Me.OutwardCompletePrint.Text = "外發完成狀況一覽表(&L)..."
        '
        'OutwardDetailPrint
        '
        Me.OutwardDetailPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.OutwardDetailPrint.Name = "OutwardDetailPrint"
        Me.OutwardDetailPrint.Size = New System.Drawing.Size(210, 22)
        Me.OutwardDetailPrint.Text = "加工詳細列表(&O)..."
        '
        'DeliveryDetailPrint
        '
        Me.DeliveryDetailPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.DeliveryDetailPrint.Name = "DeliveryDetailPrint"
        Me.DeliveryDetailPrint.Size = New System.Drawing.Size(210, 22)
        Me.DeliveryDetailPrint.Text = "送貨詳細列表(&S)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OM_ID, Me.OM_No, Me.OM_CusterID, Me.OM_CusterPO, Me.OS_BatchID, Me.PM_M_Code, Me.OS_Qty, Me.OM_CusterNo, Me.PM_JiYu, Me.OS_Sprace, Me.OS_SpraceQty, Me.OS_NoSendQty, Me.OS_NoOutQty, Me.OS_SendDate, Me.OS_CheckDate, Me.OS_Price, Me.OS_Type, Me.OS_MakeDetail, Me.OS_Fac, Me.OS_Plate, Me.OS_ToHK, Me.OS_AccountCheck, Me.OS_AccountAction, Me.OS_AccountRemark, Me.OS_Check, Me.OS_CheckAction, Me.OS_CheckRemark, Me.OS_Remark, Me.OS_AddDate, Me.OS_EditDate})
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
        'OM_ID
        '
        Me.OM_ID.Caption = "訂單流水號"
        Me.OM_ID.FieldName = "OM_ID"
        Me.OM_ID.Name = "OM_ID"
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
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        Me.OM_CusterID.Visible = True
        Me.OM_CusterID.VisibleIndex = 5
        '
        'OM_CusterPO
        '
        Me.OM_CusterPO.Caption = "客戶PO"
        Me.OM_CusterPO.FieldName = "OM_CusterPO"
        Me.OM_CusterPO.Name = "OM_CusterPO"
        Me.OM_CusterPO.Visible = True
        Me.OM_CusterPO.VisibleIndex = 1
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "生產批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 2
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "本廠編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 3
        '
        'OS_Qty
        '
        Me.OS_Qty.Caption = "生產數量"
        Me.OS_Qty.FieldName = "OS_Qty"
        Me.OS_Qty.Name = "OS_Qty"
        Me.OS_Qty.Visible = True
        Me.OS_Qty.VisibleIndex = 7
        Me.OS_Qty.Width = 70
        '
        'OM_CusterNo
        '
        Me.OM_CusterNo.Caption = "客戶編號"
        Me.OM_CusterNo.FieldName = "OM_CusterNo"
        Me.OM_CusterNo.Name = "OM_CusterNo"
        Me.OM_CusterNo.Visible = True
        Me.OM_CusterNo.VisibleIndex = 6
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 4
        Me.PM_JiYu.Width = 50
        '
        'OS_Sprace
        '
        Me.OS_Sprace.Caption = "士啤"
        Me.OS_Sprace.FieldName = "OS_Sprace"
        Me.OS_Sprace.Name = "OS_Sprace"
        '
        'OS_SpraceQty
        '
        Me.OS_SpraceQty.Caption = "連士啤數量"
        Me.OS_SpraceQty.FieldName = "OS_SpraceQty"
        Me.OS_SpraceQty.Name = "OS_SpraceQty"
        '
        'OS_NoSendQty
        '
        Me.OS_NoSendQty.Caption = "未交數"
        Me.OS_NoSendQty.FieldName = "OS_NoSendQty"
        Me.OS_NoSendQty.Name = "OS_NoSendQty"
        Me.OS_NoSendQty.Visible = True
        Me.OS_NoSendQty.VisibleIndex = 8
        Me.OS_NoSendQty.Width = 60
        '
        'OS_NoOutQty
        '
        Me.OS_NoOutQty.Caption = "未出廠數"
        Me.OS_NoOutQty.FieldName = "OS_NoOutQty"
        Me.OS_NoOutQty.Name = "OS_NoOutQty"
        Me.OS_NoOutQty.Visible = True
        Me.OS_NoOutQty.VisibleIndex = 9
        Me.OS_NoOutQty.Width = 70
        '
        'OS_SendDate
        '
        Me.OS_SendDate.Caption = "交貨日期"
        Me.OS_SendDate.FieldName = "OS_SendDate"
        Me.OS_SendDate.Name = "OS_SendDate"
        Me.OS_SendDate.Visible = True
        Me.OS_SendDate.VisibleIndex = 11
        Me.OS_SendDate.Width = 90
        '
        'OS_CheckDate
        '
        Me.OS_CheckDate.Caption = "驗貨日期"
        Me.OS_CheckDate.FieldName = "OS_CheckDate"
        Me.OS_CheckDate.Name = "OS_CheckDate"
        Me.OS_CheckDate.Visible = True
        Me.OS_CheckDate.VisibleIndex = 12
        Me.OS_CheckDate.Width = 90
        '
        'OS_Price
        '
        Me.OS_Price.Caption = "單價"
        Me.OS_Price.FieldName = "OS_Price"
        Me.OS_Price.Name = "OS_Price"
        '
        'OS_Type
        '
        Me.OS_Type.Caption = "類型"
        Me.OS_Type.FieldName = "OS_Type"
        Me.OS_Type.Name = "OS_Type"
        Me.OS_Type.Width = 45
        '
        'OS_MakeDetail
        '
        Me.OS_MakeDetail.Caption = "完成狀況"
        Me.OS_MakeDetail.FieldName = "OS_MakeDetail"
        Me.OS_MakeDetail.Name = "OS_MakeDetail"
        Me.OS_MakeDetail.Visible = True
        Me.OS_MakeDetail.VisibleIndex = 13
        '
        'OS_Fac
        '
        Me.OS_Fac.Caption = "生產部門"
        Me.OS_Fac.FieldName = "OS_Fac"
        Me.OS_Fac.Name = "OS_Fac"
        Me.OS_Fac.Visible = True
        Me.OS_Fac.VisibleIndex = 14
        '
        'OS_Plate
        '
        Me.OS_Plate.Caption = "電鍍"
        Me.OS_Plate.FieldName = "OS_Plate"
        Me.OS_Plate.Name = "OS_Plate"
        Me.OS_Plate.Visible = True
        Me.OS_Plate.VisibleIndex = 16
        '
        'OS_ToHK
        '
        Me.OS_ToHK.Caption = "送香港"
        Me.OS_ToHK.FieldName = "OS_ToHK"
        Me.OS_ToHK.Name = "OS_ToHK"
        '
        'OS_AccountCheck
        '
        Me.OS_AccountCheck.Caption = "會計部審核"
        Me.OS_AccountCheck.FieldName = "OS_AccountCheck"
        Me.OS_AccountCheck.Name = "OS_AccountCheck"
        '
        'OS_AccountAction
        '
        Me.OS_AccountAction.Caption = "會計部審核員"
        Me.OS_AccountAction.FieldName = "OS_AccountAction"
        Me.OS_AccountAction.Name = "OS_AccountAction"
        '
        'OS_AccountRemark
        '
        Me.OS_AccountRemark.Caption = "會計部備註"
        Me.OS_AccountRemark.FieldName = "OS_AccountRemark"
        Me.OS_AccountRemark.Name = "OS_AccountRemark"
        '
        'OS_Check
        '
        Me.OS_Check.Caption = "審核"
        Me.OS_Check.FieldName = "OS_Check"
        Me.OS_Check.Name = "OS_Check"
        Me.OS_Check.Visible = True
        Me.OS_Check.VisibleIndex = 10
        Me.OS_Check.Width = 45
        '
        'OS_CheckAction
        '
        Me.OS_CheckAction.Caption = "審核員"
        Me.OS_CheckAction.FieldName = "OS_CheckAction"
        Me.OS_CheckAction.Name = "OS_CheckAction"
        '
        'OS_CheckRemark
        '
        Me.OS_CheckRemark.Caption = "審核備註"
        Me.OS_CheckRemark.FieldName = "OS_CheckRemark"
        Me.OS_CheckRemark.Name = "OS_CheckRemark"
        '
        'OS_Remark
        '
        Me.OS_Remark.Caption = "備註"
        Me.OS_Remark.FieldName = "OS_Remark"
        Me.OS_Remark.Name = "OS_Remark"
        '
        'OS_AddDate
        '
        Me.OS_AddDate.Caption = "建立日期"
        Me.OS_AddDate.FieldName = "OS_AddDate"
        Me.OS_AddDate.Name = "OS_AddDate"
        Me.OS_AddDate.Visible = True
        Me.OS_AddDate.VisibleIndex = 15
        Me.OS_AddDate.Width = 90
        '
        'OS_EditDate
        '
        Me.OS_EditDate.Caption = "修改日期"
        Me.OS_EditDate.FieldName = "OS_EditDate"
        Me.OS_EditDate.Name = "OS_EditDate"
        Me.OS_EditDate.Visible = True
        Me.OS_EditDate.VisibleIndex = 17
        Me.OS_EditDate.Width = 90
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'frmBatchDetailMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 549)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmBatchDetailMain"
        Me.Text = "批次狀態信息"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopBatchMenu.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Sprace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_SpraceQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_NoOutQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_MakeDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Fac As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Plate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_ToHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AccountRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopBatchMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popBatchQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popBatchRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popLFPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popCodePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPJPCPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popCodeQCPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutwardDetailPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryDetailPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutwardCompletePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
