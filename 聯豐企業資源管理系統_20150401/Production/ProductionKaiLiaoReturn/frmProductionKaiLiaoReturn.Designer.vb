<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionKaiLiaoReturn
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
        Me.txtRCNO = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.cmStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsCodeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsCodeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Pro_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.C_Weight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IndexNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RQtyAll = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KaiLiaoAll = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCAllow = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Labaction = New System.Windows.Forms.Label
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GluDep = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit
        Me.txtAction = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.txtCheckAction = New System.Windows.Forms.Label
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtRCNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRCNO
        '
        Me.txtRCNO.AllowDrop = True
        Me.txtRCNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRCNO.Enabled = False
        Me.txtRCNO.Location = New System.Drawing.Point(695, 4)
        Me.txtRCNO.Name = "txtRCNO"
        Me.txtRCNO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRCNO.Properties.Appearance.Options.UseFont = True
        Me.txtRCNO.Size = New System.Drawing.Size(100, 24)
        Me.txtRCNO.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(620, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "退料單號："
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 38)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(798, 435)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Controls.Add(Me.Labaction)
        Me.XtraTabPage1.Controls.Add(Me.txtWH)
        Me.XtraTabPage1.Controls.Add(Me.Label11)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.DateEdit1)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.GluDep)
        Me.XtraTabPage1.Controls.Add(Me.txtRemark)
        Me.XtraTabPage1.Controls.Add(Me.txtAction)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(789, 403)
        Me.XtraTabPage1.Text = "退料明細"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmStrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(3, 140)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemCalcEdit1})
        Me.Grid.Size = New System.Drawing.Size(786, 259)
        Me.Grid.TabIndex = 20
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmStrip
        '
        Me.cmStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsCodeAdd, Me.cmsCodeDel})
        Me.cmStrip.Name = "cmStrip"
        Me.cmStrip.Size = New System.Drawing.Size(157, 48)
        '
        'cmsCodeAdd
        '
        Me.cmsCodeAdd.Name = "cmsCodeAdd"
        Me.cmsCodeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsCodeAdd.Size = New System.Drawing.Size(156, 22)
        Me.cmsCodeAdd.Text = "添加(&A)..."
        '
        'cmsCodeDel
        '
        Me.cmsCodeDel.Name = "cmsCodeDel"
        Me.cmsCodeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsCodeDel.Size = New System.Drawing.Size(156, 22)
        Me.cmsCodeDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Pro_Type, Me.PM_M_Code, Me.PM_Type, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.C_Qty, Me.C_Weight, Me.IndexNo, Me.AutoID, Me.RQtyAll, Me.KaiLiaoAll, Me.RCAllow})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Pro_Type
        '
        Me.Pro_Type.Caption = "工藝類型"
        Me.Pro_Type.FieldName = "Pro_Type"
        Me.Pro_Type.Name = "Pro_Type"
        Me.Pro_Type.OptionsColumn.ReadOnly = True
        Me.Pro_Type.Visible = True
        Me.Pro_Type.VisibleIndex = 0
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        Me.PM_M_Code.Width = 85
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "類別"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.ReadOnly = True
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 2
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowEdit = False
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 3
        Me.M_Code.Width = 119
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 4
        Me.M_Name.Width = 108
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.AllowEdit = False
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 5
        Me.M_Gauge.Width = 145
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 6
        Me.M_Unit.Width = 67
        '
        'C_Qty
        '
        Me.C_Qty.Caption = "領料數量"
        Me.C_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.C_Qty.FieldName = "C_Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'C_Weight
        '
        Me.C_Weight.Caption = "數量"
        Me.C_Weight.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.C_Weight.FieldName = "RQty"
        Me.C_Weight.Name = "C_Weight"
        Me.C_Weight.Visible = True
        Me.C_Weight.VisibleIndex = 7
        Me.C_Weight.Width = 83
        '
        'IndexNo
        '
        Me.IndexNo.Caption = "開料流水號"
        Me.IndexNo.FieldName = "IndexNo"
        Me.IndexNo.Name = "IndexNo"
        Me.IndexNo.OptionsColumn.ReadOnly = True
        '
        'AutoID
        '
        Me.AutoID.Caption = "流水號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'RQtyAll
        '
        Me.RQtyAll.Caption = "已退料數"
        Me.RQtyAll.FieldName = "RQtyAll"
        Me.RQtyAll.Name = "RQtyAll"
        Me.RQtyAll.OptionsColumn.ReadOnly = True
        Me.RQtyAll.Visible = True
        Me.RQtyAll.VisibleIndex = 8
        '
        'KaiLiaoAll
        '
        Me.KaiLiaoAll.Caption = "已開料數"
        Me.KaiLiaoAll.FieldName = "KaiLiaoAll"
        Me.KaiLiaoAll.Name = "KaiLiaoAll"
        Me.KaiLiaoAll.OptionsColumn.ReadOnly = True
        Me.KaiLiaoAll.Visible = True
        Me.KaiLiaoAll.VisibleIndex = 9
        '
        'RCAllow
        '
        Me.RCAllow.Caption = "可退料數"
        Me.RCAllow.FieldName = "RCAllow"
        Me.RCAllow.Name = "RCAllow"
        Me.RCAllow.OptionsColumn.ReadOnly = True
        Me.RCAllow.Visible = True
        Me.RCAllow.VisibleIndex = 10
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"正批", "補料"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Labaction
        '
        Me.Labaction.AutoSize = True
        Me.Labaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labaction.Location = New System.Drawing.Point(337, 11)
        Me.Labaction.Name = "Labaction"
        Me.Labaction.Size = New System.Drawing.Size(28, 15)
        Me.Labaction.TabIndex = 22
        Me.Labaction.Text = "***"
        '
        'txtWH
        '
        Me.txtWH.Location = New System.Drawing.Point(96, 8)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(150, 24)
        Me.txtWH.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "退料倉庫(&W):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "操作人:"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(619, 41)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(150, 24)
        Me.DateEdit1.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(515, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "退料日期(&D):"
        '
        'GluDep
        '
        Me.GluDep.EditValue = ""
        Me.GluDep.Location = New System.Drawing.Point(96, 45)
        Me.GluDep.Margin = New System.Windows.Forms.Padding(6)
        Me.GluDep.Name = "GluDep"
        Me.GluDep.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluDep.Properties.Appearance.Options.UseFont = True
        Me.GluDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluDep.Properties.NullText = ""
        Me.GluDep.Properties.View = Me.GridView2
        Me.GluDep.Size = New System.Drawing.Size(150, 24)
        Me.GluDep.TabIndex = 8
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "部門代號"
        Me.GridColumn1.FieldName = "DepID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "廠別名稱"
        Me.GridColumn2.FieldName = "FacName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "部門名稱"
        Me.GridColumn4.FieldName = "DepName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(96, 78)
        Me.txtRemark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Size = New System.Drawing.Size(679, 53)
        Me.txtRemark.TabIndex = 14
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(357, 43)
        Me.txtAction.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAction.Properties.Appearance.Options.UseFont = True
        Me.txtAction.Size = New System.Drawing.Size(150, 24)
        Me.txtAction.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "備　　註(&R):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(271, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "退料人(&N):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "退料部門(&P):"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtCheckAction)
        Me.XtraTabPage2.Controls.Add(Me.txtCheckRemark)
        Me.XtraTabPage2.Controls.Add(Me.Label60)
        Me.XtraTabPage2.Controls.Add(Me.Label59)
        Me.XtraTabPage2.Controls.Add(Me.Label58)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(789, 403)
        Me.XtraTabPage2.Text = "審核信息"
        '
        'txtCheckAction
        '
        Me.txtCheckAction.AutoSize = True
        Me.txtCheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckAction.Location = New System.Drawing.Point(266, 25)
        Me.txtCheckAction.Name = "txtCheckAction"
        Me.txtCheckAction.Size = New System.Drawing.Size(52, 15)
        Me.txtCheckAction.TabIndex = 9
        Me.txtCheckAction.Text = "審核員"
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckRemark.Location = New System.Drawing.Point(78, 70)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Size = New System.Drawing.Size(701, 107)
        Me.txtCheckRemark.TabIndex = 4
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label60.Location = New System.Drawing.Point(10, 70)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(71, 15)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "備註(&R)："
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label59.Location = New System.Drawing.Point(205, 25)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(67, 15)
        Me.Label59.TabIndex = 6
        Me.Label59.Text = "審核員："
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label58.Location = New System.Drawing.Point(9, 25)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(72, 15)
        Me.Label58.TabIndex = 1
        Me.Label58.Text = "審核(&K)："
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(80, 23)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "確認"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 20)
        Me.CheckEdit1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "倉庫退料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 32)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(708, 480)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(603, 480)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 14
        Me.cmdSave.Text = "確定(&O)"
        '
        'frmProductionKaiLiaoReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 516)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtRCNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionKaiLiaoReturn"
        Me.Text = "退料單"
        CType(Me.txtRCNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRCNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GluDep As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsCodeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCodeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCheckAction As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents C_Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents IndexNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pro_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Labaction As System.Windows.Forms.Label
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RQtyAll As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KaiLiaoAll As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RCAllow As DevExpress.XtraGrid.Columns.GridColumn
End Class
