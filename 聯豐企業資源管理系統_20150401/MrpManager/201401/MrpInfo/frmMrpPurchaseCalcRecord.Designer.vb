<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpPurchaseCalcRecord
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.grid4 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.MRP_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Ware_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CalcType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NeedBeginDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NeedEndDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ForecastID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MRPType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Source = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.NeedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MRPQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.InventoryQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.InTransitQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Inspection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.NoCollar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RetreatQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RelatedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.CreateUserName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CreateDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.AutoID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MP_OrderMin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid4
        '
        Me.grid4.EmbeddedNavigator.Name = ""
        Me.grid4.Location = New System.Drawing.Point(0, 0)
        Me.grid4.MainView = Me.GridView1
        Me.grid4.Name = "grid4"
        Me.grid4.Size = New System.Drawing.Size(400, 200)
        Me.grid4.TabIndex = 0
        Me.grid4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grid4
        Me.GridView1.Name = "GridView1"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 51)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(790, 589)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5, Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.AutoID, Me.MRP_ID, Me.Ware_ID, Me.MRPType, Me.CalcType, Me.NeedBeginDate, Me.NeedEndDate, Me.ForecastID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.Source, Me.M_Unit, Me.NeedQty, Me.MRPQty, Me.InventoryQty, Me.InTransitQty, Me.Inspection, Me.NoCollar, Me.RetreatQty, Me.RelatedQty, Me.CreateUserName, Me.CreateDate})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsNavigation.UseTabKey = False
        Me.BandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BandedGridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand5
        '
        Me.GridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand5.Caption = "運算單信息"
        Me.GridBand5.Columns.Add(Me.MRP_ID)
        Me.GridBand5.Columns.Add(Me.Ware_ID)
        Me.GridBand5.Columns.Add(Me.CalcType)
        Me.GridBand5.Columns.Add(Me.NeedBeginDate)
        Me.GridBand5.Columns.Add(Me.NeedEndDate)
        Me.GridBand5.Columns.Add(Me.ForecastID)
        Me.GridBand5.Columns.Add(Me.MRPType)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 589
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "運算單號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.Visible = True
        Me.MRP_ID.Width = 87
        '
        'Ware_ID
        '
        Me.Ware_ID.Caption = "庫存單號"
        Me.Ware_ID.FieldName = "Ware_ID"
        Me.Ware_ID.Name = "Ware_ID"
        Me.Ware_ID.Visible = True
        Me.Ware_ID.Width = 89
        '
        'CalcType
        '
        Me.CalcType.Caption = "運算條件"
        Me.CalcType.FieldName = "CalcType"
        Me.CalcType.Name = "CalcType"
        Me.CalcType.Visible = True
        '
        'NeedBeginDate
        '
        Me.NeedBeginDate.Caption = "訂單開始日期"
        Me.NeedBeginDate.FieldName = "NeedBeginDate"
        Me.NeedBeginDate.Name = "NeedBeginDate"
        Me.NeedBeginDate.Visible = True
        Me.NeedBeginDate.Width = 95
        '
        'NeedEndDate
        '
        Me.NeedEndDate.Caption = "訂單結束日期"
        Me.NeedEndDate.FieldName = "NeedEndDate"
        Me.NeedEndDate.Name = "NeedEndDate"
        Me.NeedEndDate.Visible = True
        Me.NeedEndDate.Width = 93
        '
        'ForecastID
        '
        Me.ForecastID.Caption = "預測單號"
        Me.ForecastID.FieldName = "ForecastID"
        Me.ForecastID.Name = "ForecastID"
        Me.ForecastID.Visible = True
        '
        'MRPType
        '
        Me.MRPType.Caption = "運算類型"
        Me.MRPType.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MRPType.FieldName = "MRPType"
        Me.MRPType.Name = "MRPType"
        Me.MRPType.Visible = True
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "物料"
        Me.GridBand1.Columns.Add(Me.M_Code)
        Me.GridBand1.Columns.Add(Me.M_Name)
        Me.GridBand1.Columns.Add(Me.M_Gauge)
        Me.GridBand1.Columns.Add(Me.Source)
        Me.GridBand1.Columns.Add(Me.M_Unit)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.RowCount = 2
        Me.GridBand1.Width = 445
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.Width = 133
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.Width = 85
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.Width = 100
        '
        'Source
        '
        Me.Source.Caption = "來源碼"
        Me.Source.FieldName = "Source"
        Me.Source.Name = "Source"
        Me.Source.Visible = True
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.Width = 52
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "MRP數量"
        Me.GridBand2.Columns.Add(Me.NeedQty)
        Me.GridBand2.Columns.Add(Me.MRPQty)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 92
        '
        'NeedQty
        '
        Me.NeedQty.Caption = "總需求量"
        Me.NeedQty.DisplayFormat.FormatString = "#,###0.######"
        Me.NeedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NeedQty.FieldName = "NeedQty"
        Me.NeedQty.Name = "NeedQty"
        Me.NeedQty.Width = 76
        '
        'MRPQty
        '
        Me.MRPQty.Caption = "實際需求數量"
        Me.MRPQty.DisplayFormat.FormatString = "#,###0.######"
        Me.MRPQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MRPQty.FieldName = "MRPQty"
        Me.MRPQty.Name = "MRPQty"
        Me.MRPQty.Visible = True
        Me.MRPQty.Width = 92
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "庫存相關數量"
        Me.GridBand3.Columns.Add(Me.InventoryQty)
        Me.GridBand3.Columns.Add(Me.InTransitQty)
        Me.GridBand3.Columns.Add(Me.Inspection)
        Me.GridBand3.Columns.Add(Me.NoCollar)
        Me.GridBand3.Columns.Add(Me.RetreatQty)
        Me.GridBand3.Columns.Add(Me.RelatedQty)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 409
        '
        'InventoryQty
        '
        Me.InventoryQty.Caption = "庫存數量"
        Me.InventoryQty.DisplayFormat.FormatString = "#,###0.######"
        Me.InventoryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.InventoryQty.FieldName = "InventoryQty"
        Me.InventoryQty.Name = "InventoryQty"
        Me.InventoryQty.Visible = True
        Me.InventoryQty.Width = 70
        '
        'InTransitQty
        '
        Me.InTransitQty.Caption = "在途數量"
        Me.InTransitQty.DisplayFormat.FormatString = "#,###0.######"
        Me.InTransitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.InTransitQty.FieldName = "InTransitQty"
        Me.InTransitQty.Name = "InTransitQty"
        Me.InTransitQty.Visible = True
        Me.InTransitQty.Width = 68
        '
        'Inspection
        '
        Me.Inspection.Caption = "待驗量"
        Me.Inspection.DisplayFormat.FormatString = "#,###0.######"
        Me.Inspection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Inspection.FieldName = "Inspection"
        Me.Inspection.Name = "Inspection"
        Me.Inspection.Visible = True
        Me.Inspection.Width = 57
        '
        'NoCollar
        '
        Me.NoCollar.Caption = "生產未領"
        Me.NoCollar.DisplayFormat.FormatString = "#,###0.######"
        Me.NoCollar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NoCollar.FieldName = "NoCollar"
        Me.NoCollar.Name = "NoCollar"
        Me.NoCollar.Visible = True
        Me.NoCollar.Width = 70
        '
        'RetreatQty
        '
        Me.RetreatQty.Caption = "退貨數量"
        Me.RetreatQty.DisplayFormat.FormatString = "#,###0.######"
        Me.RetreatQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RetreatQty.FieldName = "RetreatQty"
        Me.RetreatQty.Name = "RetreatQty"
        Me.RetreatQty.Visible = True
        Me.RetreatQty.Width = 69
        '
        'RelatedQty
        '
        Me.RelatedQty.Caption = "相關數量"
        Me.RelatedQty.DisplayFormat.FormatString = "#,###0.######"
        Me.RelatedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RelatedQty.FieldName = "RelatedQty"
        Me.RelatedQty.Name = "RelatedQty"
        Me.RelatedQty.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand4.Caption = "創建信息"
        Me.GridBand4.Columns.Add(Me.CreateUserName)
        Me.GridBand4.Columns.Add(Me.CreateDate)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 150
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "創建人員"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.Visible = True
        '
        'CreateDate
        '
        Me.CreateDate.Caption = "創建時間"
        Me.CreateDate.FieldName = "CreateDate"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.Visible = True
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'MP_OrderMax
        '
        Me.MP_OrderMax.Caption = "最大定購量"
        Me.MP_OrderMax.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_OrderMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_OrderMax.FieldName = "MP_OrderMax"
        Me.MP_OrderMax.Name = "MP_OrderMax"
        Me.MP_OrderMax.Visible = True
        Me.MP_OrderMax.Width = 82
        '
        'MP_OrderMin
        '
        Me.MP_OrderMin.Caption = "最小定購量"
        Me.MP_OrderMin.DisplayFormat.FormatString = "#,###0.######"
        Me.MP_OrderMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MP_OrderMin.FieldName = "MP_OrderMin"
        Me.MP_OrderMin.Name = "MP_OrderMin"
        Me.MP_OrderMin.Visible = True
        Me.MP_OrderMin.Width = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 45)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 21)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "MRP運算請購歷史記錄"
        '
        'frmMrpPurchaseCalcRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 640)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmMrpPurchaseCalcRecord"
        Me.Text = "MRP運算請購歷史記錄"
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Source As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents NeedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MRPQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents InventoryQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents InTransitQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Inspection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NoCollar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RetreatQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RelatedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents MP_OrderMax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MP_OrderMin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Ware_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MRPType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CalcType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NeedBeginDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NeedEndDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ForecastID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents CreateDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
