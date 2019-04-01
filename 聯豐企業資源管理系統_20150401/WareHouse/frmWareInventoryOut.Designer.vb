<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareInventoryOut
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.bteM_Code = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.pceM_Type = New DevExpress.XtraEditors.PopupContainerEdit
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.bteWH_ID = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsExportExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.bandCompany = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.bandWH_Name = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bandDate = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.bandWO_Qty1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bandWO_Qty2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bandWO_Qty3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty3 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bteM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pceM_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.bteWH_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(176, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "物料出庫數據匯總"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(934, 37)
        Me.PanelControl1.TabIndex = 3
        Me.PanelControl1.Text = "PanelControl1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.bteM_Code)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.pceM_Type)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.bteWH_ID)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 57)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Location = New System.Drawing.Point(788, 17)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "確定"
        '
        'bteM_Code
        '
        Me.bteM_Code.Location = New System.Drawing.Point(623, 21)
        Me.bteM_Code.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.bteM_Code.Name = "bteM_Code"
        Me.bteM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteM_Code.Properties.Appearance.Options.UseFont = True
        Me.bteM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bteM_Code.Size = New System.Drawing.Size(150, 24)
        Me.bteM_Code.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(525, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 15)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "物料編碼(&M)："
        '
        'pceM_Type
        '
        Me.pceM_Type.Location = New System.Drawing.Point(361, 21)
        Me.pceM_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.pceM_Type.Name = "pceM_Type"
        Me.pceM_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pceM_Type.Properties.Appearance.Options.UseFont = True
        Me.pceM_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceM_Type.Properties.PopupControl = Me.PopupContainerControl1
        Me.pceM_Type.Size = New System.Drawing.Size(150, 24)
        Me.pceM_Type.TabIndex = 5
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.tv1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(327, 214)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(184, 232)
        Me.PopupContainerControl1.TabIndex = 200
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'tv1
        '
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(184, 232)
        Me.tv1.TabIndex = 197
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(267, 25)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "物料類型(&T)："
        '
        'bteWH_ID
        '
        Me.bteWH_ID.Location = New System.Drawing.Point(105, 21)
        Me.bteWH_ID.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.bteWH_ID.Name = "bteWH_ID"
        Me.bteWH_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteWH_ID.Properties.Appearance.Options.UseFont = True
        Me.bteWH_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bteWH_ID.Properties.ReadOnly = True
        Me.bteWH_ID.Size = New System.Drawing.Size(150, 24)
        Me.bteWH_ID.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(10, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "倉庫名稱(&N)："
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 94)
        Me.GridControl1.MainView = Me.AdvBandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(934, 364)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1, Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsExportExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 26)
        '
        'cmsExportExcel
        '
        Me.cmsExportExcel.Name = "cmsExportExcel"
        Me.cmsExportExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmsExportExcel.Size = New System.Drawing.Size(179, 22)
        Me.cmsExportExcel.Text = "導出Excel(&T）"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandCompany})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.bandWO_Qty1, Me.bandWO_Qty2, Me.bandWO_Qty3})
        Me.AdvBandedGridView1.GridControl = Me.GridControl1
        Me.AdvBandedGridView1.IndicatorWidth = 45
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsCustomization.AllowColumnMoving = False
        Me.AdvBandedGridView1.OptionsNavigation.UseTabKey = False
        Me.AdvBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'bandCompany
        '
        Me.bandCompany.AppearanceHeader.Font = New System.Drawing.Font("新細明體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bandCompany.AppearanceHeader.Options.UseFont = True
        Me.bandCompany.Caption = "米亞精密金屬科技(東莞)有限公司"
        Me.bandCompany.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.bandCompany.Name = "bandCompany"
        Me.bandCompany.RowCount = 2
        Me.bandCompany.Width = 910
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridBand2.AppearanceHeader.Options.UseFont = True
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "物料出庫數據匯總表"
        Me.GridBand2.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandWH_Name, Me.bandDate})
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.RowCount = 2
        Me.GridBand2.Width = 910
        '
        'bandWH_Name
        '
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn1)
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn2)
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn3)
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn4)
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn5)
        Me.bandWH_Name.Columns.Add(Me.BandedGridColumn6)
        Me.bandWH_Name.Name = "bandWH_Name"
        Me.bandWH_Name.Width = 685
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "物料編碼"
        Me.BandedGridColumn1.FieldName = "M_Code"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 130
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "物料名稱"
        Me.BandedGridColumn2.FieldName = "M_Name"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 100
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "物料規格"
        Me.BandedGridColumn3.FieldName = "M_Gauge"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 250
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "當前庫存"
        Me.BandedGridColumn4.FieldName = "WI_Qty"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn4.Visible = True
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.Caption = "單位"
        Me.BandedGridColumn5.FieldName = "M_Unit"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.Width = 55
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "安全庫存"
        Me.BandedGridColumn6.FieldName = "WI_SafeQty"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn6.Visible = True
        '
        'bandDate
        '
        Me.bandDate.AppearanceHeader.Options.UseTextOptions = True
        Me.bandDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.bandDate.Caption = "gridBand3"
        Me.bandDate.Columns.Add(Me.bandWO_Qty1)
        Me.bandDate.Columns.Add(Me.bandWO_Qty2)
        Me.bandDate.Columns.Add(Me.bandWO_Qty3)
        Me.bandDate.Name = "bandDate"
        Me.bandDate.Width = 225
        '
        'bandWO_Qty1
        '
        Me.bandWO_Qty1.Caption = "1"
        Me.bandWO_Qty1.FieldName = "WO_Qty1"
        Me.bandWO_Qty1.Name = "bandWO_Qty1"
        Me.bandWO_Qty1.OptionsColumn.ReadOnly = True
        Me.bandWO_Qty1.Visible = True
        '
        'bandWO_Qty2
        '
        Me.bandWO_Qty2.Caption = "2"
        Me.bandWO_Qty2.FieldName = "WO_Qty2"
        Me.bandWO_Qty2.Name = "bandWO_Qty2"
        Me.bandWO_Qty2.OptionsColumn.ReadOnly = True
        Me.bandWO_Qty2.Visible = True
        '
        'bandWO_Qty3
        '
        Me.bandWO_Qty3.Caption = "3"
        Me.bandWO_Qty3.FieldName = "WO_Qty3"
        Me.bandWO_Qty3.Name = "bandWO_Qty3"
        Me.bandWO_Qty3.OptionsColumn.ReadOnly = True
        Me.bandWO_Qty3.Visible = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WI_Qty, Me.M_Unit, Me.WI_SafeQty, Me.WO_Qty1, Me.WO_Qty2, Me.WO_Qty3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
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
        'WI_Qty
        '
        Me.WI_Qty.Caption = "當前庫存"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 3
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 4
        '
        'WI_SafeQty
        '
        Me.WI_SafeQty.Caption = "安全庫存"
        Me.WI_SafeQty.Name = "WI_SafeQty"
        Me.WI_SafeQty.OptionsColumn.ReadOnly = True
        Me.WI_SafeQty.Visible = True
        Me.WI_SafeQty.VisibleIndex = 5
        '
        'WO_Qty1
        '
        Me.WO_Qty1.FieldName = "WO_Qty1"
        Me.WO_Qty1.Name = "WO_Qty1"
        Me.WO_Qty1.OptionsColumn.ReadOnly = True
        Me.WO_Qty1.Visible = True
        Me.WO_Qty1.VisibleIndex = 6
        '
        'WO_Qty2
        '
        Me.WO_Qty2.FieldName = "WO_Qty2"
        Me.WO_Qty2.Name = "WO_Qty2"
        Me.WO_Qty2.OptionsColumn.ReadOnly = True
        Me.WO_Qty2.Visible = True
        Me.WO_Qty2.VisibleIndex = 7
        '
        'WO_Qty3
        '
        Me.WO_Qty3.FieldName = "WO_Qty3"
        Me.WO_Qty3.Name = "WO_Qty3"
        Me.WO_Qty3.OptionsColumn.ReadOnly = True
        Me.WO_Qty3.Visible = True
        Me.WO_Qty3.VisibleIndex = 8
        '
        'frmWareInventoryOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 458)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmWareInventoryOut"
        Me.Text = "frmWareInventoryOut"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bteM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pceM_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.bteWH_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Qty2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Qty3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bandWO_Qty1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bandWO_Qty2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bandWO_Qty3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bandCompany As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandWH_Name As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandDate As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bteWH_ID As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pceM_Type As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bteM_Code As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsExportExcel As System.Windows.Forms.ToolStripMenuItem
End Class
