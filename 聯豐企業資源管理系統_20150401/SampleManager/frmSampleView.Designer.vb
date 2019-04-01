<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleView
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具进行修改。
    '请不要使用程式碼編輯器进行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbeCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.lbl_Check = New System.Windows.Forms.Label
        Me.chk_ID = New System.Windows.Forms.Label
        Me.lbl_CusterID = New System.Windows.Forms.Label
        Me.lbl_M_Code = New System.Windows.Forms.Label
        Me.lbl_PM_M_Code = New System.Windows.Forms.Label
        Me.lbl_SO_ID = New System.Windows.Forms.Label
        Me.gluM_Code = New DevExpress.XtraEditors.PopupContainerEdit
        Me.gluCuster = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluSO_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_DateType = New System.Windows.Forms.Label
        Me.cboDateType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.dateStratDate = New DevExpress.XtraEditors.DateEdit
        Me.dateEndDate = New DevExpress.XtraEditors.DateEdit
        Me.lbl_EndDate = New System.Windows.Forms.Label
        Me.lbl_StratDate = New System.Windows.Forms.Label
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cbeCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cboDateType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 32)
        Me.Panel2.TabIndex = 128
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(5, 5)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(98, 21)
        Me.lbl_Title.TabIndex = 89
        Me.lbl_Title.Text = "样办查询"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 311)
        Me.Panel1.TabIndex = 129
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(193, 281)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(73, 281)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "查询(&F)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbeCheck)
        Me.GroupBox3.Controls.Add(Me.PopupContainerControl1)
        Me.GroupBox3.Controls.Add(Me.lbl_Check)
        Me.GroupBox3.Controls.Add(Me.chk_ID)
        Me.GroupBox3.Controls.Add(Me.lbl_CusterID)
        Me.GroupBox3.Controls.Add(Me.lbl_M_Code)
        Me.GroupBox3.Controls.Add(Me.lbl_PM_M_Code)
        Me.GroupBox3.Controls.Add(Me.lbl_SO_ID)
        Me.GroupBox3.Controls.Add(Me.gluM_Code)
        Me.GroupBox3.Controls.Add(Me.gluCuster)
        Me.GroupBox3.Controls.Add(Me.glu_ID)
        Me.GroupBox3.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox3.Controls.Add(Me.gluSO_ID)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 308)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "查询條件"
        '
        'cbeCheck
        '
        Me.cbeCheck.EditValue = "ALL"
        Me.cbeCheck.Location = New System.Drawing.Point(132, 149)
        Me.cbeCheck.Name = "cbeCheck"
        Me.cbeCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbeCheck.Properties.Appearance.Options.UseFont = True
        Me.cbeCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeCheck.Properties.Items.AddRange(New Object() {"ALL", "审核", "沒审核"})
        Me.cbeCheck.Size = New System.Drawing.Size(66, 25)
        Me.cbeCheck.TabIndex = 11
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.TreeList1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(188, 240)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(151, 153)
        Me.PopupContainerControl1.TabIndex = 150
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.KeyFieldName = "M_KEY"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "M_PID"
        Me.TreeList1.Size = New System.Drawing.Size(151, 153)
        Me.TreeList1.TabIndex = 144
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "物料名称"
        Me.TreeListColumn1.FieldName = "M_Name"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "物料编码"
        Me.TreeListColumn2.FieldName = "M_Code"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        '
        'lbl_Check
        '
        Me.lbl_Check.AutoSize = True
        Me.lbl_Check.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Check.ForeColor = System.Drawing.Color.Red
        Me.lbl_Check.Location = New System.Drawing.Point(31, 155)
        Me.lbl_Check.Name = "lbl_Check"
        Me.lbl_Check.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Check.TabIndex = 10
        Me.lbl_Check.Text = "审核类型(&F)："
        '
        'chk_ID
        '
        Me.chk_ID.AutoSize = True
        Me.chk_ID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chk_ID.Location = New System.Drawing.Point(31, 127)
        Me.chk_ID.Name = "chk_ID"
        Me.chk_ID.Size = New System.Drawing.Size(88, 13)
        Me.chk_ID.TabIndex = 8
        Me.chk_ID.Text = "         单号(&E)："
        '
        'lbl_CusterID
        '
        Me.lbl_CusterID.AutoSize = True
        Me.lbl_CusterID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_CusterID.Location = New System.Drawing.Point(29, 101)
        Me.lbl_CusterID.Name = "lbl_CusterID"
        Me.lbl_CusterID.Size = New System.Drawing.Size(89, 13)
        Me.lbl_CusterID.TabIndex = 6
        Me.lbl_CusterID.Text = "客戶名称(&D)："
        '
        'lbl_M_Code
        '
        Me.lbl_M_Code.AutoSize = True
        Me.lbl_M_Code.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_M_Code.Location = New System.Drawing.Point(30, 74)
        Me.lbl_M_Code.Name = "lbl_M_Code"
        Me.lbl_M_Code.Size = New System.Drawing.Size(88, 13)
        Me.lbl_M_Code.TabIndex = 4
        Me.lbl_M_Code.Text = "配件名称(&C)："
        '
        'lbl_PM_M_Code
        '
        Me.lbl_PM_M_Code.AutoSize = True
        Me.lbl_PM_M_Code.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_PM_M_Code.Location = New System.Drawing.Point(30, 46)
        Me.lbl_PM_M_Code.Name = "lbl_PM_M_Code"
        Me.lbl_PM_M_Code.Size = New System.Drawing.Size(88, 13)
        Me.lbl_PM_M_Code.TabIndex = 2
        Me.lbl_PM_M_Code.Text = "产品编号(&B)："
        '
        'lbl_SO_ID
        '
        Me.lbl_SO_ID.AutoSize = True
        Me.lbl_SO_ID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_SO_ID.Location = New System.Drawing.Point(16, 19)
        Me.lbl_SO_ID.Name = "lbl_SO_ID"
        Me.lbl_SO_ID.Size = New System.Drawing.Size(102, 13)
        Me.lbl_SO_ID.TabIndex = 0
        Me.lbl_SO_ID.Text = "样办订单号(&A)："
        '
        'gluM_Code
        '
        Me.gluM_Code.Location = New System.Drawing.Point(132, 68)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.PopupControl = Me.PopupContainerControl1
        Me.gluM_Code.Size = New System.Drawing.Size(196, 24)
        Me.gluM_Code.TabIndex = 5
        '
        'gluCuster
        '
        Me.gluCuster.EditValue = ""
        Me.gluCuster.EnterMoveNextControl = True
        Me.gluCuster.Location = New System.Drawing.Point(132, 95)
        Me.gluCuster.Name = "gluCuster"
        Me.gluCuster.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluCuster.Properties.Appearance.Options.UseFont = True
        Me.gluCuster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluCuster.Properties.NullText = ""
        Me.gluCuster.Properties.View = Me.GridLookUpEdit1View
        Me.gluCuster.Size = New System.Drawing.Size(196, 24)
        Me.gluCuster.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "客戶代号"
        Me.GridColumn6.FieldName = "C_CusterID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "英文名"
        Me.GridColumn7.FieldName = "C_EngName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "中文名"
        Me.GridColumn3.FieldName = "C_ChsName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'glu_ID
        '
        Me.glu_ID.Location = New System.Drawing.Point(132, 122)
        Me.glu_ID.Name = "glu_ID"
        Me.glu_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_ID.Properties.Appearance.Options.UseFont = True
        Me.glu_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_ID.Properties.NullText = ""
        Me.glu_ID.Properties.View = Me.GridView2
        Me.glu_ID.Size = New System.Drawing.Size(196, 24)
        Me.glu_ID.TabIndex = 9
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SP_ID, Me.SO_ID})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'SP_ID
        '
        Me.SP_ID.Caption = "排期单号"
        Me.SP_ID.FieldName = "SP_ID"
        Me.SP_ID.Name = "SP_ID"
        Me.SP_ID.Visible = True
        Me.SP_ID.VisibleIndex = 0
        '
        'SO_ID
        '
        Me.SO_ID.Caption = "样办订单号"
        Me.SO_ID.FieldName = "SO_ID"
        Me.SO_ID.Name = "SO_ID"
        Me.SO_ID.Visible = True
        Me.SO_ID.VisibleIndex = 1
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(132, 41)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.View = Me.GridView1
        Me.gluPM_M_Code.Size = New System.Drawing.Size(196, 24)
        Me.gluPM_M_Code.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "产品编号"
        Me.GridColumn1.FieldName = "PM_M_Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "样办单号"
        Me.GridColumn2.FieldName = "SO_SampleID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'gluSO_ID
        '
        Me.gluSO_ID.EditValue = ""
        Me.gluSO_ID.Location = New System.Drawing.Point(132, 14)
        Me.gluSO_ID.Name = "gluSO_ID"
        Me.gluSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSO_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSO_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSO_ID.Properties.NullText = ""
        Me.gluSO_ID.Properties.View = Me.GridView3
        Me.gluSO_ID.Size = New System.Drawing.Size(196, 24)
        Me.gluSO_ID.TabIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn22, Me.GridColumn23})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "样办单号"
        Me.GridColumn5.FieldName = "SO_SampleID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 408
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "样办订单号"
        Me.GridColumn22.FieldName = "SO_ID"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        Me.GridColumn22.Width = 509
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "版本号"
        Me.GridColumn23.FieldName = "SS_Edition"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        Me.GridColumn23.Width = 306
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_DateType)
        Me.GroupBox2.Controls.Add(Me.cboDateType)
        Me.GroupBox2.Controls.Add(Me.dateStratDate)
        Me.GroupBox2.Controls.Add(Me.dateEndDate)
        Me.GroupBox2.Controls.Add(Me.lbl_EndDate)
        Me.GroupBox2.Controls.Add(Me.lbl_StratDate)
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 95)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "日期范围(&D)"
        '
        'lbl_DateType
        '
        Me.lbl_DateType.AutoSize = True
        Me.lbl_DateType.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_DateType.Location = New System.Drawing.Point(51, 21)
        Me.lbl_DateType.Name = "lbl_DateType"
        Me.lbl_DateType.Size = New System.Drawing.Size(114, 13)
        Me.lbl_DateType.TabIndex = 0
        Me.lbl_DateType.Text = "日期类型选择(&B)："
        '
        'cboDateType
        '
        Me.cboDateType.EditValue = "新增日期"
        Me.cboDateType.Location = New System.Drawing.Point(169, 15)
        Me.cboDateType.Name = "cboDateType"
        Me.cboDateType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateType.Properties.Appearance.Options.UseFont = True
        Me.cboDateType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDateType.Size = New System.Drawing.Size(150, 25)
        Me.cboDateType.TabIndex = 1
        '
        'dateStratDate
        '
        Me.dateStratDate.EditValue = Nothing
        Me.dateStratDate.Location = New System.Drawing.Point(169, 43)
        Me.dateStratDate.Name = "dateStratDate"
        Me.dateStratDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateStratDate.Properties.Appearance.Options.UseFont = True
        Me.dateStratDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateStratDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateStratDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateStratDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateStratDate.Size = New System.Drawing.Size(150, 22)
        Me.dateStratDate.TabIndex = 3
        '
        'dateEndDate
        '
        Me.dateEndDate.EditValue = Nothing
        Me.dateEndDate.Location = New System.Drawing.Point(169, 68)
        Me.dateEndDate.Name = "dateEndDate"
        Me.dateEndDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateEndDate.Properties.Appearance.Options.UseFont = True
        Me.dateEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEndDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateEndDate.Size = New System.Drawing.Size(150, 22)
        Me.dateEndDate.TabIndex = 5
        '
        'lbl_EndDate
        '
        Me.lbl_EndDate.AutoSize = True
        Me.lbl_EndDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_EndDate.Location = New System.Drawing.Point(104, 73)
        Me.lbl_EndDate.Name = "lbl_EndDate"
        Me.lbl_EndDate.Size = New System.Drawing.Size(61, 13)
        Me.lbl_EndDate.TabIndex = 4
        Me.lbl_EndDate.Text = "结束(&E)："
        '
        'lbl_StratDate
        '
        Me.lbl_StratDate.AutoSize = True
        Me.lbl_StratDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_StratDate.Location = New System.Drawing.Point(103, 47)
        Me.lbl_StratDate.Name = "lbl_StratDate"
        Me.lbl_StratDate.Size = New System.Drawing.Size(62, 13)
        Me.lbl_StratDate.TabIndex = 2
        Me.lbl_StratDate.Text = "起始(&B)："
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "样办单号"
        Me.GridColumn4.FieldName = "SO_SampleID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'frmSampleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(350, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSampleView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "样办查询"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cbeCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cboDateType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dateStratDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dateEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbl_EndDate As System.Windows.Forms.Label
    Friend WithEvents lbl_StratDate As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gluSO_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glu_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluCuster As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_DateType As System.Windows.Forms.Label
    Friend WithEvents cboDateType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lbl_SO_ID As System.Windows.Forms.Label
    Friend WithEvents lbl_PM_M_Code As System.Windows.Forms.Label
    Friend WithEvents lbl_M_Code As System.Windows.Forms.Label
    Friend WithEvents lbl_CusterID As System.Windows.Forms.Label
    Friend WithEvents chk_ID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbeCheck As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_Check As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
