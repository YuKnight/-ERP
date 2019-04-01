<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionFieldMain
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
        Me.FieldMainStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FieldMainSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.FieldMainStatusPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.cmsTransfer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsTransferInOut = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.cmdPeiBu = New System.Windows.Forms.Button
        Me.cmdShengChan = New System.Windows.Forms.Button
        Me.cmdZhuangPei = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FieldMainStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTransfer.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(857, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "現場生產管理--生產部"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.FieldMainStrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 64)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(857, 210)
        Me.Grid1.TabIndex = 3
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'FieldMainStrip
        '
        Me.FieldMainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldMainSelect, Me.FieldMainStatusPrint})
        Me.FieldMainStrip.Name = "FieldMainStrip"
        Me.FieldMainStrip.Size = New System.Drawing.Size(189, 48)
        '
        'FieldMainSelect
        '
        Me.FieldMainSelect.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.FieldMainSelect.Name = "FieldMainSelect"
        Me.FieldMainSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FieldMainSelect.Size = New System.Drawing.Size(188, 22)
        Me.FieldMainSelect.Text = "查詢(&F)..."
        '
        'FieldMainStatusPrint
        '
        Me.FieldMainStatusPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.FieldMainStatusPrint.Name = "FieldMainStatusPrint"
        Me.FieldMainStatusPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FieldMainStatusPrint.Size = New System.Drawing.Size(188, 22)
        Me.FieldMainStatusPrint.Text = "生產流程表(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn22, Me.GridColumn3, Me.GridColumn8, Me.GridColumn6})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "工藝類型"
        Me.GridColumn1.FieldName = "Pro_Type"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品編號"
        Me.GridColumn2.FieldName = "PM_M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "類型"
        Me.GridColumn7.FieldName = "PM_Type"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "計劃生產量"
        Me.GridColumn22.FieldName = "PS_DayNumber"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn3.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.Caption = "完成量"
        Me.GridColumn3.FieldName = "PS_ActualNumber"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "生產部們"
        Me.GridColumn8.FieldName = "PS_Dep"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "生產部"
        Me.GridColumn6.FieldName = "FacName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid2.ContextMenuStrip = Me.cmsTransfer
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Location = New System.Drawing.Point(0, 278)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(857, 182)
        Me.Grid2.TabIndex = 4
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'cmsTransfer
        '
        Me.cmsTransfer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsTransferInOut})
        Me.cmsTransfer.Name = "cmsTransfer"
        Me.cmsTransfer.Size = New System.Drawing.Size(201, 26)
        '
        'cmsTransferInOut
        '
        Me.cmsTransferInOut.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmsTransferInOut.Name = "cmsTransferInOut"
        Me.cmsTransferInOut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmsTransferInOut.Size = New System.Drawing.Size(200, 22)
        Me.cmsTransferInOut.Text = "物料收發記錄(&P)..."
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn24, Me.GridColumn4, Me.GridColumn5, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn25, Me.GridColumn23, Me.GridColumn26, Me.GridColumn27})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowRowSizing = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "部門"
        Me.GridColumn9.FieldName = "DepName"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 120
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "工序編號"
        Me.GridColumn10.FieldName = "Pro_NO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 50
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "工序名稱"
        Me.GridColumn11.FieldName = "PS_Name"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 83
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "收料"
        Me.GridColumn12.FieldName = "ShouLiao"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 61
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "加存"
        Me.GridColumn13.FieldName = "JiaCun"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 45
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "正常發出"
        Me.GridColumn14.FieldName = "FaLiao"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "完工"
        Me.GridColumn24.FieldName = "ChuHuo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 5
        Me.GridColumn24.Width = 45
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "返修發出"
        Me.GridColumn4.FieldName = "FanXiuOut"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "損壞"
        Me.GridColumn5.FieldName = "SunHuai"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 46
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "留辦"
        Me.GridColumn15.FieldName = "LiuBan"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        Me.GridColumn15.Width = 46
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "丟失"
        Me.GridColumn16.FieldName = "DiuShi"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 11
        Me.GridColumn16.Width = 46
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "不良"
        Me.GridColumn17.FieldName = "BuNiang"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 12
        Me.GridColumn17.Width = 46
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "存貨"
        Me.GridColumn18.FieldName = "CunHuo"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 13
        Me.GridColumn18.Width = 46
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "返修收入"
        Me.GridColumn19.FieldName = "FanXiuIn"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 14
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "取存"
        Me.GridColumn20.FieldName = "QuCun"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 15
        Me.GridColumn20.Width = 47
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "存倉"
        Me.GridColumn21.FieldName = "CunCang"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 16
        Me.GridColumn21.Width = 80
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn25.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn25.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn25.Caption = "結餘數"
        Me.GridColumn25.FieldName = "RemainQty"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 17
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "部門ID"
        Me.GridColumn23.FieldName = "FP_OutDep"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "外發發出"
        Me.GridColumn26.FieldName = "WaiFaOut"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 7
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "外發收入"
        Me.GridColumn27.FieldName = "WaiFaIn"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(857, 27)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'cmdPeiBu
        '
        Me.cmdPeiBu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPeiBu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPeiBu.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdPeiBu.Location = New System.Drawing.Point(3, 37)
        Me.cmdPeiBu.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdPeiBu.Name = "cmdPeiBu"
        Me.cmdPeiBu.Size = New System.Drawing.Size(90, 24)
        Me.cmdPeiBu.TabIndex = 0
        Me.cmdPeiBu.Text = "胚部工藝(&P)"
        Me.cmdPeiBu.UseVisualStyleBackColor = False
        '
        'cmdShengChan
        '
        Me.cmdShengChan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdShengChan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdShengChan.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdShengChan.Location = New System.Drawing.Point(113, 37)
        Me.cmdShengChan.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdShengChan.Name = "cmdShengChan"
        Me.cmdShengChan.Size = New System.Drawing.Size(90, 24)
        Me.cmdShengChan.TabIndex = 1
        Me.cmdShengChan.Text = "生產工藝(&S)"
        Me.cmdShengChan.UseVisualStyleBackColor = False
        '
        'cmdZhuangPei
        '
        Me.cmdZhuangPei.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdZhuangPei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdZhuangPei.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdZhuangPei.Location = New System.Drawing.Point(223, 37)
        Me.cmdZhuangPei.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdZhuangPei.Name = "cmdZhuangPei"
        Me.cmdZhuangPei.Size = New System.Drawing.Size(90, 24)
        Me.cmdZhuangPei.TabIndex = 2
        Me.cmdZhuangPei.Text = "裝配工藝(&Z)"
        Me.cmdZhuangPei.UseVisualStyleBackColor = False
        '
        'frmProductionFieldMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 461)
        Me.Controls.Add(Me.cmdPeiBu)
        Me.Controls.Add(Me.cmdZhuangPei)
        Me.Controls.Add(Me.cmdShengChan)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionFieldMain"
        Me.Text = "現場生產進度"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldMainStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTransfer.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FieldMainStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FieldMainSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FieldMainStatusPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPeiBu As System.Windows.Forms.Button
    Friend WithEvents cmdShengChan As System.Windows.Forms.Button
    Friend WithEvents cmdZhuangPei As System.Windows.Forms.Button
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsTransfer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsTransferInOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
End Class
