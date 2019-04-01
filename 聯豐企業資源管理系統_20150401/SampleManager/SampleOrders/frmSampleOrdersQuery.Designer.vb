<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleOrdersQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleOrdersQuery))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MC_OrderMan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_QtyMin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_LowLimit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_SecInv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Source = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_MRPCon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModifyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_OrderRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MC_WareHouseRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit27 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit40 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit38 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit39 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMRUEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemMemoEdit28 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoExEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit41 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gluD_ID = New DevExpress.XtraEditors.PopupContainerEdit
        Me.ppcD_ID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkD_ID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.txtPM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.gluMaterialType = New DevExpress.XtraEditors.PopupContainerEdit
        Me.pccMaterialType = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkMaterialType = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.cmdExcel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppcD_ID.SuspendLayout()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluMaterialType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccMaterialType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccMaterialType.SuspendLayout()
        CType(Me.chkMaterialType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "材料(&B)："
        '
        'Grid
        '
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView5
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(400, 200)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.Grid
        Me.GridView5.Name = "GridView5"
        '
        'MC_OrderMan
        '
        Me.MC_OrderMan.Caption = "採購負責人"
        Me.MC_OrderMan.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.MC_OrderMan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.MC_OrderMan.FieldName = "MC_OrderMan"
        Me.MC_OrderMan.Name = "MC_OrderMan"
        Me.MC_OrderMan.OptionsColumn.AllowEdit = False
        Me.MC_OrderMan.Width = 71
        '
        'MC_QtyMax
        '
        Me.MC_QtyMax.Caption = "最大訂購量"
        Me.MC_QtyMax.FieldName = "MC_QtyMax"
        Me.MC_QtyMax.Name = "MC_QtyMax"
        Me.MC_QtyMax.OptionsColumn.AllowEdit = False
        Me.MC_QtyMax.Visible = True
        Me.MC_QtyMax.VisibleIndex = 6
        Me.MC_QtyMax.Width = 72
        '
        'MC_QtyMin
        '
        Me.MC_QtyMin.Caption = "最小訂購量"
        Me.MC_QtyMin.FieldName = "MC_QtyMin"
        Me.MC_QtyMin.Name = "MC_QtyMin"
        Me.MC_QtyMin.Visible = True
        Me.MC_QtyMin.VisibleIndex = 7
        Me.MC_QtyMin.Width = 70
        '
        'MC_LowLimit
        '
        Me.MC_LowLimit.Caption = "最低存量"
        Me.MC_LowLimit.FieldName = "MC_LowLimit"
        Me.MC_LowLimit.Name = "MC_LowLimit"
        Me.MC_LowLimit.Width = 68
        '
        'MC_SecInv
        '
        Me.MC_SecInv.Caption = "安全庫存"
        Me.MC_SecInv.FieldName = "MC_SecInv"
        Me.MC_SecInv.Name = "MC_SecInv"
        Me.MC_SecInv.Visible = True
        Me.MC_SecInv.VisibleIndex = 8
        Me.MC_SecInv.Width = 74
        '
        'MC_WH_Name
        '
        Me.MC_WH_Name.Caption = "入庫倉庫"
        Me.MC_WH_Name.FieldName = "MC_WH_Name"
        Me.MC_WH_Name.Name = "MC_WH_Name"
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "MC_Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        Me.Source.VisibleIndex = 9
        Me.Source.Width = 90
        '
        'MC_MRPCon
        '
        Me.MC_MRPCon.Caption = "合併需求"
        Me.MC_MRPCon.FieldName = "MC_MRPCon"
        Me.MC_MRPCon.Name = "MC_MRPCon"
        Me.MC_MRPCon.Visible = True
        Me.MC_MRPCon.VisibleIndex = 10
        Me.MC_MRPCon.Width = 59
        '
        'MC_WH_ID
        '
        Me.MC_WH_ID.Caption = "入庫倉庫"
        Me.MC_WH_ID.FieldName = "MC_WH_ID"
        Me.MC_WH_ID.Name = "MC_WH_ID"
        Me.MC_WH_ID.Width = 116
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人"
        Me.CheckUserID.FieldName = "CheckUserID"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.Visible = True
        Me.CheckUserID.VisibleIndex = 12
        Me.CheckUserID.Width = 84
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "審核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.AllowEdit = False
        Me.CheckBit.Tag = False
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 11
        Me.CheckBit.Width = 35
        '
        'CheckRemark
        '
        Me.CheckRemark.Caption = "審核備註"
        Me.CheckRemark.FieldName = "CheckRemark"
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.OptionsColumn.AllowEdit = False
        Me.CheckRemark.Width = 141
        '
        'CreateUserID
        '
        Me.CreateUserID.Caption = "創建人"
        Me.CreateUserID.FieldName = "CreateUserID"
        Me.CreateUserID.Name = "CreateUserID"
        Me.CreateUserID.OptionsColumn.AllowEdit = False
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建日期"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.OptionsColumn.AllowEdit = False
        '
        'ModifyUserID
        '
        Me.ModifyUserID.Caption = "修改人"
        Me.ModifyUserID.FieldName = "ModifyUserID"
        Me.ModifyUserID.Name = "ModifyUserID"
        Me.ModifyUserID.OptionsColumn.AllowEdit = False
        '
        'ModifyDate
        '
        Me.ModifyDate.Caption = "修改日期"
        Me.ModifyDate.FieldName = "ModifyDate"
        Me.ModifyDate.Name = "ModifyDate"
        Me.ModifyDate.OptionsColumn.AllowEdit = False
        '
        'MC_Remark
        '
        Me.MC_Remark.Caption = "備註"
        Me.MC_Remark.FieldName = "MC_Remark"
        Me.MC_Remark.Name = "MC_Remark"
        Me.MC_Remark.Visible = True
        Me.MC_Remark.VisibleIndex = 13
        Me.MC_Remark.Width = 149
        '
        'MC_OrderRemark
        '
        Me.MC_OrderRemark.Caption = "訂購備註"
        Me.MC_OrderRemark.FieldName = "MC_OrderRemark"
        Me.MC_OrderRemark.Name = "MC_OrderRemark"
        '
        'MC_WareHouseRemark
        '
        Me.MC_WareHouseRemark.Caption = "庫存備註"
        Me.MC_WareHouseRemark.FieldName = "MC_WareHouseRemark"
        Me.MC_WareHouseRemark.Name = "MC_WareHouseRemark"
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit27, Me.RepositoryItemButtonEdit14, Me.RepositoryItemCalcEdit15, Me.RepositoryItemTextEdit14, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit13, Me.RepositoryItemDateEdit40, Me.RepositoryItemDateEdit38, Me.RepositoryItemDateEdit39, Me.RepositoryItemMRUEdit13, Me.RepositoryItemMemoEdit28, Me.RepositoryItemMemoExEdit15, Me.RepositoryItemDateEdit41, Me.RepositoryItemTimeEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(961, 377)
        Me.GridControl1.TabIndex = 239
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn8, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsPrint.AutoWidth = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "样办单号"
        Me.GridColumn7.FieldName = "SO_SampleID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 108
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "产品编号"
        Me.GridColumn1.FieldName = "PM_M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 182
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "材料"
        Me.GridColumn8.FieldName = "MaterialTypeName"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "工序编号"
        Me.GridColumn2.FieldName = "PS_NO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 205
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "工序"
        Me.GridColumn3.FieldName = "PS_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "部门编号"
        Me.GridColumn4.FieldName = "D_ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "部门"
        Me.GridColumn5.FieldName = "D_Dep"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "库存数量"
        Me.GridColumn6.FieldName = "SWI_Qty"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "合计{0}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'RepositoryItemMemoEdit27
        '
        Me.RepositoryItemMemoEdit27.Name = "RepositoryItemMemoEdit27"
        '
        'RepositoryItemButtonEdit14
        '
        Me.RepositoryItemButtonEdit14.AutoHeight = False
        Me.RepositoryItemButtonEdit14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit14.Name = "RepositoryItemButtonEdit14"
        '
        'RepositoryItemCalcEdit15
        '
        Me.RepositoryItemCalcEdit15.AutoHeight = False
        Me.RepositoryItemCalcEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit15.Name = "RepositoryItemCalcEdit15"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit13
        '
        Me.RepositoryItemCheckEdit13.AutoHeight = False
        Me.RepositoryItemCheckEdit13.Name = "RepositoryItemCheckEdit13"
        Me.RepositoryItemCheckEdit13.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemDateEdit40
        '
        Me.RepositoryItemDateEdit40.AutoHeight = False
        Me.RepositoryItemDateEdit40.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit40.Mask.EditMask = ""
        Me.RepositoryItemDateEdit40.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit40.Name = "RepositoryItemDateEdit40"
        '
        'RepositoryItemDateEdit38
        '
        Me.RepositoryItemDateEdit38.AutoHeight = False
        Me.RepositoryItemDateEdit38.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit38.Name = "RepositoryItemDateEdit38"
        '
        'RepositoryItemDateEdit39
        '
        Me.RepositoryItemDateEdit39.AutoHeight = False
        Me.RepositoryItemDateEdit39.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit39.Name = "RepositoryItemDateEdit39"
        '
        'RepositoryItemMRUEdit13
        '
        Me.RepositoryItemMRUEdit13.AutoHeight = False
        Me.RepositoryItemMRUEdit13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit13.Name = "RepositoryItemMRUEdit13"
        '
        'RepositoryItemMemoEdit28
        '
        Me.RepositoryItemMemoEdit28.Name = "RepositoryItemMemoEdit28"
        '
        'RepositoryItemMemoExEdit15
        '
        Me.RepositoryItemMemoExEdit15.AutoHeight = False
        Me.RepositoryItemMemoExEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit15.Name = "RepositoryItemMemoExEdit15"
        Me.RepositoryItemMemoExEdit15.ShowIcon = False
        '
        'RepositoryItemDateEdit41
        '
        Me.RepositoryItemDateEdit41.AutoHeight = False
        Me.RepositoryItemDateEdit41.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit41.Name = "RepositoryItemDateEdit41"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "備註"
        Me.GridColumn23.FieldName = "MC_Remark"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 13
        Me.GridColumn23.Width = 149
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "訂購備註"
        Me.GridColumn24.FieldName = "MC_OrderRemark"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "庫存備註"
        Me.GridColumn25.FieldName = "MC_WareHouseRemark"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "AutoID"
        Me.GridColumn26.FieldName = "AutoID"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluD_ID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckEdit4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckEdit3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSO_SampleID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckEdit2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPM_M_Code)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluMaterialType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdExcel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ppcD_ID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pccMaterialType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 449)
        Me.SplitContainer1.SplitterDistance = 68
        Me.SplitContainer1.TabIndex = 240
        '
        'gluD_ID
        '
        Me.gluD_ID.Location = New System.Drawing.Point(421, 9)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluD_ID.Properties.PopupControl = Me.ppcD_ID
        Me.gluD_ID.Size = New System.Drawing.Size(241, 24)
        Me.gluD_ID.TabIndex = 251
        '
        'ppcD_ID
        '
        Me.ppcD_ID.Controls.Add(Me.chkD_ID)
        Me.ppcD_ID.Controls.Add(Me.CheckEdit5)
        Me.ppcD_ID.Location = New System.Drawing.Point(397, 83)
        Me.ppcD_ID.Name = "ppcD_ID"
        Me.ppcD_ID.Size = New System.Drawing.Size(200, 218)
        Me.ppcD_ID.TabIndex = 245
        Me.ppcD_ID.Text = "PopupContainerControl4"
        '
        'chkD_ID
        '
        Me.chkD_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkD_ID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkD_ID.CheckOnClick = True
        Me.chkD_ID.DisplayMember = "DepName"
        Me.chkD_ID.HotTrackItems = True
        Me.chkD_ID.Location = New System.Drawing.Point(0, 25)
        Me.chkD_ID.Name = "chkD_ID"
        Me.chkD_ID.Size = New System.Drawing.Size(200, 191)
        Me.chkD_ID.TabIndex = 0
        Me.chkD_ID.ValueMember = "DepID"
        '
        'CheckEdit5
        '
        Me.CheckEdit5.Location = New System.Drawing.Point(2, 2)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit5.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit5.Properties.Caption = "全选部门"
        Me.CheckEdit5.Size = New System.Drawing.Size(83, 23)
        Me.CheckEdit5.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "部门(&H)："
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(5, 38)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit4.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit4.Properties.Caption = "样办单号(&S)："
        Me.CheckEdit4.Size = New System.Drawing.Size(116, 23)
        Me.CheckEdit4.TabIndex = 249
        '
        'CheckEdit3
        '
        Me.CheckEdit3.EditValue = True
        Me.CheckEdit3.Location = New System.Drawing.Point(5, 10)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit3.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit3.Properties.Caption = "产品编号(&E)："
        Me.CheckEdit3.Size = New System.Drawing.Size(116, 23)
        Me.CheckEdit3.TabIndex = 248
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.Location = New System.Drawing.Point(127, 37)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(219, 24)
        Me.txtSO_SampleID.TabIndex = 247
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(669, 10)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Caption = "选择工序"
        Me.CheckEdit2.Size = New System.Drawing.Size(83, 23)
        Me.CheckEdit2.TabIndex = 245
        '
        'txtPM_M_Code
        '
        Me.txtPM_M_Code.Location = New System.Drawing.Point(127, 9)
        Me.txtPM_M_Code.Name = "txtPM_M_Code"
        Me.txtPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_M_Code.Size = New System.Drawing.Size(219, 24)
        Me.txtPM_M_Code.TabIndex = 244
        '
        'gluMaterialType
        '
        Me.gluMaterialType.Location = New System.Drawing.Point(421, 37)
        Me.gluMaterialType.Name = "gluMaterialType"
        Me.gluMaterialType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluMaterialType.Properties.Appearance.Options.UseFont = True
        Me.gluMaterialType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluMaterialType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluMaterialType.Properties.PopupControl = Me.pccMaterialType
        Me.gluMaterialType.Size = New System.Drawing.Size(241, 24)
        Me.gluMaterialType.TabIndex = 243
        '
        'pccMaterialType
        '
        Me.pccMaterialType.Controls.Add(Me.chkMaterialType)
        Me.pccMaterialType.Controls.Add(Me.CheckEdit1)
        Me.pccMaterialType.Location = New System.Drawing.Point(173, 85)
        Me.pccMaterialType.Name = "pccMaterialType"
        Me.pccMaterialType.Size = New System.Drawing.Size(200, 218)
        Me.pccMaterialType.TabIndex = 244
        Me.pccMaterialType.Text = "PopupContainerControl4"
        '
        'chkMaterialType
        '
        Me.chkMaterialType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMaterialType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkMaterialType.CheckOnClick = True
        Me.chkMaterialType.DisplayMember = "TName"
        Me.chkMaterialType.HotTrackItems = True
        Me.chkMaterialType.Location = New System.Drawing.Point(0, 25)
        Me.chkMaterialType.Name = "chkMaterialType"
        Me.chkMaterialType.Size = New System.Drawing.Size(200, 191)
        Me.chkMaterialType.TabIndex = 0
        Me.chkMaterialType.ValueMember = "TID"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(2, 2)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "全选材料"
        Me.CheckEdit1.Size = New System.Drawing.Size(83, 23)
        Me.CheckEdit1.TabIndex = 29
        '
        'cmdExcel
        '
        Me.cmdExcel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExcel.Appearance.Options.UseFont = True
        Me.cmdExcel.Image = CType(resources.GetObject("cmdExcel.Image"), System.Drawing.Image)
        Me.cmdExcel.Location = New System.Drawing.Point(753, 37)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(80, 24)
        Me.cmdExcel.TabIndex = 242
        Me.cmdExcel.Text = "Excel(&N)"
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSearch.Location = New System.Drawing.Point(667, 37)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(80, 24)
        Me.cmdSearch.TabIndex = 242
        Me.cmdSearch.Text = "查询(&F)"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(142, 21)
        Me.Lbl_Title.TabIndex = 85
        Me.Lbl_Title.Text = "产品库存查询"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 32)
        Me.Panel2.TabIndex = 241
        '
        'frmSampleOrdersQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 477)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSampleOrdersQuery"
        Me.Text = "产品库存查询"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppcD_ID.ResumeLayout(False)
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluMaterialType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccMaterialType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccMaterialType.ResumeLayout(False)
        CType(Me.chkMaterialType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents MC_OrderMan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_QtyMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_QtyMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_LowLimit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_SecInv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_MRPCon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_OrderRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MC_WareHouseRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit27 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit40 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit38 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit39 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMRUEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents RepositoryItemMemoEdit28 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit41 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluMaterialType As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents pccMaterialType As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkMaterialType As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ppcD_ID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkD_ID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
