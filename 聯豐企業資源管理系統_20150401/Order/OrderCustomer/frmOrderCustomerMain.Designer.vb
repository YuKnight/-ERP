<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderCustomerMain
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsModify = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OC_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_CustomerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_CustomerPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_CustomerNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_PODate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_AddUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OC_Index = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(132, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "客戶訂單資料"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(777, 37)
        Me.PanelControl1.TabIndex = 3
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(777, 527)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsModify, Me.cmsDelete, Me.cmsRefresh, Me.ToolStripSeparator1, Me.cmsView, Me.cmsFind})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 142)
        '
        'cmsAdd
        '
        Me.cmsAdd.Enabled = False
        Me.cmsAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsAdd.Size = New System.Drawing.Size(180, 22)
        Me.cmsAdd.Text = "新增(&A)..."
        '
        'cmsModify
        '
        Me.cmsModify.Enabled = False
        Me.cmsModify.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmsModify.Name = "cmsModify"
        Me.cmsModify.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmsModify.Size = New System.Drawing.Size(180, 22)
        Me.cmsModify.Text = "修改(&E)..."
        '
        'cmsDelete
        '
        Me.cmsDelete.Enabled = False
        Me.cmsDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsDelete.Size = New System.Drawing.Size(180, 22)
        Me.cmsDelete.Text = "刪除(&D)"
        '
        'cmsRefresh
        '
        Me.cmsRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmsRefresh.Name = "cmsRefresh"
        Me.cmsRefresh.Size = New System.Drawing.Size(180, 22)
        Me.cmsRefresh.Text = "刷新(&R)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'cmsView
        '
        Me.cmsView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmsView.Name = "cmsView"
        Me.cmsView.Size = New System.Drawing.Size(180, 22)
        Me.cmsView.Text = "查看(&V)..."
        '
        'cmsFind
        '
        Me.cmsFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.Size = New System.Drawing.Size(180, 22)
        Me.cmsFind.Text = "查詢(&F)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OC_ID, Me.PM_M_Code, Me.M_Code, Me.M_Name, Me.OC_CustomerID, Me.OC_CustomerPO, Me.OC_CustomerNo, Me.OC_PODate, Me.OC_Qty, Me.OC_NoSendQty, Me.AutoID, Me.OC_AddUser, Me.OC_Index})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'OC_ID
        '
        Me.OC_ID.Caption = "訂單編號"
        Me.OC_ID.FieldName = "OC_ID"
        Me.OC_ID.Name = "OC_ID"
        Me.OC_ID.OptionsColumn.ReadOnly = True
        Me.OC_ID.SummaryItem.DisplayFormat = "記錄數：{0}"
        Me.OC_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.OC_ID.Visible = True
        Me.OC_ID.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        '
        'M_Name
        '
        Me.M_Name.Caption = "配件名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'OC_CustomerID
        '
        Me.OC_CustomerID.Caption = "客戶代號"
        Me.OC_CustomerID.FieldName = "OC_CustomerID"
        Me.OC_CustomerID.Name = "OC_CustomerID"
        Me.OC_CustomerID.OptionsColumn.ReadOnly = True
        Me.OC_CustomerID.Visible = True
        Me.OC_CustomerID.VisibleIndex = 3
        '
        'OC_CustomerPO
        '
        Me.OC_CustomerPO.Caption = "客戶PO"
        Me.OC_CustomerPO.FieldName = "OC_CustomerPO"
        Me.OC_CustomerPO.Name = "OC_CustomerPO"
        Me.OC_CustomerPO.OptionsColumn.ReadOnly = True
        Me.OC_CustomerPO.Visible = True
        Me.OC_CustomerPO.VisibleIndex = 4
        '
        'OC_CustomerNo
        '
        Me.OC_CustomerNo.Caption = "客戶編號"
        Me.OC_CustomerNo.FieldName = "OC_CustomerNo"
        Me.OC_CustomerNo.Name = "OC_CustomerNo"
        Me.OC_CustomerNo.OptionsColumn.ReadOnly = True
        Me.OC_CustomerNo.Visible = True
        Me.OC_CustomerNo.VisibleIndex = 5
        '
        'OC_PODate
        '
        Me.OC_PODate.Caption = "PO日期"
        Me.OC_PODate.FieldName = "OC_PODate"
        Me.OC_PODate.Name = "OC_PODate"
        Me.OC_PODate.OptionsColumn.ReadOnly = True
        Me.OC_PODate.Visible = True
        Me.OC_PODate.VisibleIndex = 6
        '
        'OC_Qty
        '
        Me.OC_Qty.Caption = "數量"
        Me.OC_Qty.FieldName = "OC_Qty"
        Me.OC_Qty.Name = "OC_Qty"
        Me.OC_Qty.OptionsColumn.ReadOnly = True
        Me.OC_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.OC_Qty.Visible = True
        Me.OC_Qty.VisibleIndex = 7
        '
        'OC_NoSendQty
        '
        Me.OC_NoSendQty.Caption = "未交數量"
        Me.OC_NoSendQty.FieldName = "OC_NoSendQty"
        Me.OC_NoSendQty.Name = "OC_NoSendQty"
        Me.OC_NoSendQty.OptionsColumn.ReadOnly = True
        Me.OC_NoSendQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.OC_NoSendQty.Visible = True
        Me.OC_NoSendQty.VisibleIndex = 8
        '
        'AutoID
        '
        Me.AutoID.Caption = "流水號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'OC_AddUser
        '
        Me.OC_AddUser.Caption = "添加人"
        Me.OC_AddUser.FieldName = "OC_AddUser"
        Me.OC_AddUser.Name = "OC_AddUser"
        Me.OC_AddUser.OptionsColumn.ReadOnly = True
        Me.OC_AddUser.Visible = True
        Me.OC_AddUser.VisibleIndex = 9
        '
        'OC_Index
        '
        Me.OC_Index.Caption = "訂單流水號"
        Me.OC_Index.FieldName = "OC_Index"
        Me.OC_Index.Name = "OC_Index"
        '
        'frmOrderCustomerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 564)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmOrderCustomerMain"
        Me.Text = "客戶訂單資料"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_CustomerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_CustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_CustomerPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsModify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OC_PODate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_AddUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC_Index As DevExpress.XtraGrid.Columns.GridColumn
End Class
