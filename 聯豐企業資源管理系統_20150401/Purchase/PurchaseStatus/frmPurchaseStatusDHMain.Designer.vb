<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseStatusDHMain
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
        Me.cmsStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsStatusCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsStatusRef = New System.Windows.Forms.ToolStripMenuItem
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
        Me.OS_ProductAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsStatus.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "采購狀態-大貨"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 36)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.cmsStatus
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(563, 353)
        Me.Grid1.TabIndex = 168
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsStatus
        '
        Me.cmsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsStatusCheck, Me.cmsStatusRef})
        Me.cmsStatus.Name = "cmsStatus"
        Me.cmsStatus.Size = New System.Drawing.Size(181, 70)
        '
        'cmsStatusCheck
        '
        Me.cmsStatusCheck.Enabled = False
        Me.cmsStatusCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmsStatusCheck.Name = "cmsStatusCheck"
        Me.cmsStatusCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmsStatusCheck.Size = New System.Drawing.Size(180, 22)
        Me.cmsStatusCheck.Text = "狀態審核(&G)..."
        '
        'cmsStatusRef
        '
        Me.cmsStatusRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsStatusRef.Name = "cmsStatusRef"
        Me.cmsStatusRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsStatusRef.Size = New System.Drawing.Size(180, 22)
        Me.cmsStatusRef.Text = "刷新(&R)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OM_ID, Me.OM_No, Me.OM_CusterID, Me.OM_CusterPO, Me.OS_BatchID, Me.PM_M_Code, Me.OS_Qty, Me.OM_CusterNo, Me.PM_JiYu, Me.OS_Sprace, Me.OS_SpraceQty, Me.OS_NoSendQty, Me.OS_NoOutQty, Me.OS_SendDate, Me.OS_CheckDate, Me.OS_Price, Me.OS_Type, Me.OS_MakeDetail, Me.OS_Fac, Me.OS_Plate, Me.OS_ToHK, Me.OS_AccountCheck, Me.OS_AccountAction, Me.OS_AccountRemark, Me.OS_Check, Me.OS_CheckAction, Me.OS_CheckRemark, Me.OS_Remark, Me.OS_AddDate, Me.OS_EditDate, Me.OS_ProductAction})
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
        Me.OM_No.Width = 90
        '
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        '
        'OM_CusterPO
        '
        Me.OM_CusterPO.Caption = "客戶PO"
        Me.OM_CusterPO.FieldName = "OM_CusterPO"
        Me.OM_CusterPO.Name = "OM_CusterPO"
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "生產批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "本廠編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'OS_Qty
        '
        Me.OS_Qty.Caption = "生產數量"
        Me.OS_Qty.FieldName = "OS_Qty"
        Me.OS_Qty.Name = "OS_Qty"
        Me.OS_Qty.Visible = True
        Me.OS_Qty.VisibleIndex = 3
        Me.OS_Qty.Width = 70
        '
        'OM_CusterNo
        '
        Me.OM_CusterNo.Caption = "客戶編號"
        Me.OM_CusterNo.FieldName = "OM_CusterNo"
        Me.OM_CusterNo.Name = "OM_CusterNo"
        Me.OM_CusterNo.Visible = True
        Me.OM_CusterNo.VisibleIndex = 2
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
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
        Me.OS_NoSendQty.Width = 60
        '
        'OS_NoOutQty
        '
        Me.OS_NoOutQty.Caption = "未出廠數"
        Me.OS_NoOutQty.FieldName = "OS_NoOutQty"
        Me.OS_NoOutQty.Name = "OS_NoOutQty"
        Me.OS_NoOutQty.Width = 70
        '
        'OS_SendDate
        '
        Me.OS_SendDate.Caption = "交貨日期"
        Me.OS_SendDate.FieldName = "OS_SendDate"
        Me.OS_SendDate.Name = "OS_SendDate"
        Me.OS_SendDate.Visible = True
        Me.OS_SendDate.VisibleIndex = 5
        Me.OS_SendDate.Width = 80
        '
        'OS_CheckDate
        '
        Me.OS_CheckDate.Caption = "驗貨日期"
        Me.OS_CheckDate.FieldName = "OS_CheckDate"
        Me.OS_CheckDate.Name = "OS_CheckDate"
        Me.OS_CheckDate.Visible = True
        Me.OS_CheckDate.VisibleIndex = 6
        Me.OS_CheckDate.Width = 82
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
        Me.OS_Type.Visible = True
        Me.OS_Type.VisibleIndex = 4
        Me.OS_Type.Width = 65
        '
        'OS_MakeDetail
        '
        Me.OS_MakeDetail.Caption = "完成狀況"
        Me.OS_MakeDetail.FieldName = "OS_MakeDetail"
        Me.OS_MakeDetail.Name = "OS_MakeDetail"
        Me.OS_MakeDetail.Width = 60
        '
        'OS_Fac
        '
        Me.OS_Fac.Caption = "生產部門"
        Me.OS_Fac.FieldName = "OS_Fac"
        Me.OS_Fac.Name = "OS_Fac"
        Me.OS_Fac.Width = 60
        '
        'OS_Plate
        '
        Me.OS_Plate.Caption = "電鍍"
        Me.OS_Plate.FieldName = "OS_Plate"
        Me.OS_Plate.Name = "OS_Plate"
        Me.OS_Plate.Width = 40
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
        Me.OS_Check.Caption = "營業部審核"
        Me.OS_Check.FieldName = "OS_Check"
        Me.OS_Check.Name = "OS_Check"
        Me.OS_Check.Visible = True
        Me.OS_Check.VisibleIndex = 7
        Me.OS_Check.Width = 85
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
        '
        'OS_EditDate
        '
        Me.OS_EditDate.Caption = "修改日期"
        Me.OS_EditDate.FieldName = "OS_EditDate"
        Me.OS_EditDate.Name = "OS_EditDate"
        '
        'OS_ProductAction
        '
        Me.OS_ProductAction.Caption = "采購狀態操作員"
        Me.OS_ProductAction.FieldName = "OS_ProductAction"
        Me.OS_ProductAction.Name = "OS_ProductAction"
        Me.OS_ProductAction.Visible = True
        Me.OS_ProductAction.VisibleIndex = 8
        Me.OS_ProductAction.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmPurchaseStatusDHMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 390)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPurchaseStatusDHMain"
        Me.Text = "采購狀態-大貨"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsStatus.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents OS_ProductAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsStatusCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsStatusRef As System.Windows.Forms.ToolStripMenuItem
End Class
