<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdersSubNeed
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOS_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_BatchID = New DevExpress.XtraEditors.TextEdit
        Me.txtON_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Weight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_CodeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_UsableQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_PrepareQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_NeedPurchaseQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ON_SalesDptCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ON_OperationDptCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOS_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtON_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(857, 37)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(173, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "批次需求單-新增"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtOS_Qty)
        Me.GroupBox1.Controls.Add(Me.txtOS_BatchID)
        Me.GroupBox1.Controls.Add(Me.txtON_ID)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 56)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtOS_Qty
        '
        Me.txtOS_Qty.Enabled = False
        Me.txtOS_Qty.Location = New System.Drawing.Point(583, 18)
        Me.txtOS_Qty.Name = "txtOS_Qty"
        Me.txtOS_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtOS_Qty.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_Qty.TabIndex = 1
        '
        'txtOS_BatchID
        '
        Me.txtOS_BatchID.Enabled = False
        Me.txtOS_BatchID.Location = New System.Drawing.Point(345, 18)
        Me.txtOS_BatchID.Name = "txtOS_BatchID"
        Me.txtOS_BatchID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_BatchID.Properties.Appearance.Options.UseFont = True
        Me.txtOS_BatchID.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_BatchID.TabIndex = 1
        '
        'txtON_ID
        '
        Me.txtON_ID.Enabled = False
        Me.txtON_ID.Location = New System.Drawing.Point(108, 18)
        Me.txtON_ID.Name = "txtON_ID"
        Me.txtON_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtON_ID.Properties.Appearance.Options.UseFont = True
        Me.txtON_ID.Size = New System.Drawing.Size(120, 24)
        Me.txtON_ID.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 15)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "需求單號(&I)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(483, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "批次數量(&L)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(246, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "批次編號(&P)："
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnOK)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 490)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(857, 50)
        Me.PanelControl2.TabIndex = 7
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(746, 13)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Location = New System.Drawing.Point(646, 13)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "確定(&O)"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 93)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(857, 397)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.M_Weight, Me.ON_NeedQty, Me.M_CodeType, Me.WI_Qty, Me.WI_UsableQty, Me.ON_PrepareQty, Me.ON_NeedPurchaseQty, Me.ON_Remark, Me.ON_SalesDptCheck, Me.ON_OperationDptCheck, Me.AutoID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "拖動列表頭到此處可進行分組"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 3
        Me.M_Unit.Width = 55
        '
        'M_Weight
        '
        Me.M_Weight.AppearanceCell.Options.UseTextOptions = True
        Me.M_Weight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.M_Weight.Caption = "用量"
        Me.M_Weight.FieldName = "M_Weight"
        Me.M_Weight.Name = "M_Weight"
        Me.M_Weight.OptionsColumn.ReadOnly = True
        Me.M_Weight.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.M_Weight.Visible = True
        Me.M_Weight.VisibleIndex = 4
        Me.M_Weight.Width = 55
        '
        'ON_NeedQty
        '
        Me.ON_NeedQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_NeedQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_NeedQty.Caption = "理論需求數"
        Me.ON_NeedQty.FieldName = "ON_NeedQty"
        Me.ON_NeedQty.Name = "ON_NeedQty"
        Me.ON_NeedQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_NeedQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_NeedQty.Visible = True
        Me.ON_NeedQty.VisibleIndex = 5
        Me.ON_NeedQty.Width = 85
        '
        'M_CodeType
        '
        Me.M_CodeType.Caption = "配件類型"
        Me.M_CodeType.FieldName = "M_CodeType"
        Me.M_CodeType.Name = "M_CodeType"
        Me.M_CodeType.OptionsColumn.ReadOnly = True
        Me.M_CodeType.Visible = True
        Me.M_CodeType.VisibleIndex = 6
        '
        'WI_Qty
        '
        Me.WI_Qty.AppearanceCell.Options.UseTextOptions = True
        Me.WI_Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.WI_Qty.Caption = "當前庫存數"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 7
        Me.WI_Qty.Width = 85
        '
        'WI_UsableQty
        '
        Me.WI_UsableQty.AppearanceCell.Options.UseTextOptions = True
        Me.WI_UsableQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.WI_UsableQty.Caption = "可用庫存數"
        Me.WI_UsableQty.FieldName = "WI_UsableQty"
        Me.WI_UsableQty.Name = "WI_UsableQty"
        Me.WI_UsableQty.OptionsColumn.ReadOnly = True
        Me.WI_UsableQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.WI_UsableQty.Visible = True
        Me.WI_UsableQty.VisibleIndex = 8
        Me.WI_UsableQty.Width = 85
        '
        'ON_PrepareQty
        '
        Me.ON_PrepareQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_PrepareQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_PrepareQty.Caption = "可備料數"
        Me.ON_PrepareQty.FieldName = "ON_PrepareQty"
        Me.ON_PrepareQty.Name = "ON_PrepareQty"
        Me.ON_PrepareQty.OptionsColumn.ReadOnly = True
        Me.ON_PrepareQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_PrepareQty.Visible = True
        Me.ON_PrepareQty.VisibleIndex = 9
        '
        'ON_NeedPurchaseQty
        '
        Me.ON_NeedPurchaseQty.AppearanceCell.Options.UseTextOptions = True
        Me.ON_NeedPurchaseQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ON_NeedPurchaseQty.Caption = "需採購數"
        Me.ON_NeedPurchaseQty.FieldName = "ON_NeedPurchaseQty"
        Me.ON_NeedPurchaseQty.Name = "ON_NeedPurchaseQty"
        Me.ON_NeedPurchaseQty.OptionsColumn.ReadOnly = True
        Me.ON_NeedPurchaseQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ON_NeedPurchaseQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ON_NeedPurchaseQty.Visible = True
        Me.ON_NeedPurchaseQty.VisibleIndex = 10
        '
        'ON_Remark
        '
        Me.ON_Remark.Caption = "備注"
        Me.ON_Remark.FieldName = "ON_Remark"
        Me.ON_Remark.Name = "ON_Remark"
        Me.ON_Remark.Visible = True
        Me.ON_Remark.VisibleIndex = 11
        Me.ON_Remark.Width = 100
        '
        'ON_SalesDptCheck
        '
        Me.ON_SalesDptCheck.Caption = "營業部審核"
        Me.ON_SalesDptCheck.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ON_SalesDptCheck.FieldName = "ON_SalesDptCheck"
        Me.ON_SalesDptCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ON_SalesDptCheck.Name = "ON_SalesDptCheck"
        Me.ON_SalesDptCheck.Width = 85
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ON_OperationDptCheck
        '
        Me.ON_OperationDptCheck.Caption = "營運部審核"
        Me.ON_OperationDptCheck.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.ON_OperationDptCheck.FieldName = "ON_OperationDptCheck"
        Me.ON_OperationDptCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ON_OperationDptCheck.Name = "ON_OperationDptCheck"
        Me.ON_OperationDptCheck.Width = 85
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'frmOrdersSubNeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(857, 540)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmOrdersSubNeed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "批次需求單-新增"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtOS_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtON_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOS_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOS_BatchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtON_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_CodeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_PrepareQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_NeedPurchaseQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_SalesDptCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ON_OperationDptCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents WI_UsableQty As DevExpress.XtraGrid.Columns.GridColumn
End Class
