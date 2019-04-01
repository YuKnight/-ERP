<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionApply
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPA_ID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.betDpt_Name = New DevExpress.XtraEditors.ButtonEdit
        Me.detPA_ApplyDate = New DevExpress.XtraEditors.DateEdit
        Me.txtPA_ApplyReason = New DevExpress.XtraEditors.MemoEdit
        Me.txtPA_ApplyPersonName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PA_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PA_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.txtPA_CheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.cboPA_CheckType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblPA_CheckDate = New DevExpress.XtraEditors.LabelControl
        Me.lblPA_CheckUserName = New DevExpress.XtraEditors.LabelControl
        Me.chkPA_Check = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPA_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.betDpt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detPA_ApplyDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPA_ApplyReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPA_ApplyPersonName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtPA_CheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPA_CheckType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPA_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 21)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "申購單--新增"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(772, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(534, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "申購單號："
        '
        'txtPA_ID
        '
        Me.txtPA_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPA_ID.Location = New System.Drawing.Point(612, 8)
        Me.txtPA_ID.Name = "txtPA_ID"
        Me.txtPA_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPA_ID.Properties.Appearance.Options.UseFont = True
        Me.txtPA_ID.Properties.ReadOnly = True
        Me.txtPA_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtPA_ID.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.betDpt_Name)
        Me.GroupBox1.Controls.Add(Me.detPA_ApplyDate)
        Me.GroupBox1.Controls.Add(Me.txtPA_ApplyReason)
        Me.GroupBox1.Controls.Add(Me.txtPA_ApplyPersonName)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'betDpt_Name
        '
        Me.betDpt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.betDpt_Name.Location = New System.Drawing.Point(107, 17)
        Me.betDpt_Name.Margin = New System.Windows.Forms.Padding(0, 6, 3, 6)
        Me.betDpt_Name.Name = "betDpt_Name"
        Me.betDpt_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.betDpt_Name.Properties.Appearance.Options.UseFont = True
        Me.betDpt_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.betDpt_Name.Properties.ReadOnly = True
        Me.betDpt_Name.Size = New System.Drawing.Size(150, 24)
        Me.betDpt_Name.TabIndex = 1
        '
        'detPA_ApplyDate
        '
        Me.detPA_ApplyDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detPA_ApplyDate.EditValue = Nothing
        Me.detPA_ApplyDate.Location = New System.Drawing.Point(612, 17)
        Me.detPA_ApplyDate.Margin = New System.Windows.Forms.Padding(0, 6, 3, 6)
        Me.detPA_ApplyDate.Name = "detPA_ApplyDate"
        Me.detPA_ApplyDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detPA_ApplyDate.Properties.Appearance.Options.UseFont = True
        Me.detPA_ApplyDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.detPA_ApplyDate.Size = New System.Drawing.Size(150, 24)
        Me.detPA_ApplyDate.TabIndex = 5
        '
        'txtPA_ApplyReason
        '
        Me.txtPA_ApplyReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPA_ApplyReason.Location = New System.Drawing.Point(107, 53)
        Me.txtPA_ApplyReason.Margin = New System.Windows.Forms.Padding(0, 6, 3, 6)
        Me.txtPA_ApplyReason.Name = "txtPA_ApplyReason"
        Me.txtPA_ApplyReason.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPA_ApplyReason.Properties.Appearance.Options.UseFont = True
        Me.txtPA_ApplyReason.Size = New System.Drawing.Size(654, 45)
        Me.txtPA_ApplyReason.TabIndex = 7
        '
        'txtPA_ApplyPersonName
        '
        Me.txtPA_ApplyPersonName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPA_ApplyPersonName.Location = New System.Drawing.Point(353, 17)
        Me.txtPA_ApplyPersonName.Margin = New System.Windows.Forms.Padding(0, 6, 3, 6)
        Me.txtPA_ApplyPersonName.Name = "txtPA_ApplyPersonName"
        Me.txtPA_ApplyPersonName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPA_ApplyPersonName.Properties.Appearance.Options.UseFont = True
        Me.txtPA_ApplyPersonName.Size = New System.Drawing.Size(150, 24)
        Me.txtPA_ApplyPersonName.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(14, 57)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 15)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "申購原因(&S)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(517, 22)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "申購日期(&E)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(273, 21)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "申購人(&A)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "申購部門(&D)："
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 152)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(774, 334)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(765, 302)
        Me.XtraTabPage1.Text = "申購物料明細"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemCalcEdit1})
        Me.Grid.Size = New System.Drawing.Size(765, 302)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popAdd, Me.ToolStripSeparator1, Me.popDel})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(181, 54)
        '
        'popAdd
        '
        Me.popAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.popAdd.Name = "popAdd"
        Me.popAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popAdd.Size = New System.Drawing.Size(180, 22)
        Me.popAdd.Text = "新增(&A)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'popDel
        '
        Me.popDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popDel.Name = "popDel"
        Me.popDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popDel.Size = New System.Drawing.Size(180, 22)
        Me.popDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.PM_M_Code, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.PA_Qty, Me.M_Unit, Me.PA_Remark})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動ID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        Me.PM_M_Code.Width = 110
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 120
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        Me.M_Name.Width = 110
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 140
        '
        'PA_Qty
        '
        Me.PA_Qty.Caption = "申購數量"
        Me.PA_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PA_Qty.FieldName = "PA_Qty"
        Me.PA_Qty.Name = "PA_Qty"
        Me.PA_Qty.Visible = True
        Me.PA_Qty.VisibleIndex = 4
        Me.PA_Qty.Width = 70
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 5
        Me.M_Unit.Width = 45
        '
        'PA_Remark
        '
        Me.PA_Remark.Caption = "備注"
        Me.PA_Remark.FieldName = "PA_Remark"
        Me.PA_Remark.Name = "PA_Remark"
        Me.PA_Remark.Visible = True
        Me.PA_Remark.VisibleIndex = 6
        Me.PA_Remark.Width = 169
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtPA_CheckRemark)
        Me.XtraTabPage2.Controls.Add(Me.cboPA_CheckType)
        Me.XtraTabPage2.Controls.Add(Me.lblPA_CheckDate)
        Me.XtraTabPage2.Controls.Add(Me.lblPA_CheckUserName)
        Me.XtraTabPage2.Controls.Add(Me.chkPA_Check)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(765, 302)
        Me.XtraTabPage2.Text = "審核"
        '
        'txtPA_CheckRemark
        '
        Me.txtPA_CheckRemark.EnterMoveNextControl = True
        Me.txtPA_CheckRemark.Location = New System.Drawing.Point(104, 111)
        Me.txtPA_CheckRemark.Name = "txtPA_CheckRemark"
        Me.txtPA_CheckRemark.Size = New System.Drawing.Size(653, 113)
        Me.txtPA_CheckRemark.TabIndex = 6
        '
        'cboPA_CheckType
        '
        Me.cboPA_CheckType.EditValue = "確認無誤"
        Me.cboPA_CheckType.EnterMoveNextControl = True
        Me.cboPA_CheckType.Location = New System.Drawing.Point(104, 67)
        Me.cboPA_CheckType.Name = "cboPA_CheckType"
        Me.cboPA_CheckType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPA_CheckType.Properties.Appearance.Options.UseFont = True
        Me.cboPA_CheckType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPA_CheckType.Properties.Items.AddRange(New Object() {"確認無誤", "無效"})
        Me.cboPA_CheckType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPA_CheckType.Size = New System.Drawing.Size(150, 24)
        Me.cboPA_CheckType.TabIndex = 4
        '
        'lblPA_CheckDate
        '
        Me.lblPA_CheckDate.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPA_CheckDate.Appearance.Options.UseFont = True
        Me.lblPA_CheckDate.Location = New System.Drawing.Point(544, 32)
        Me.lblPA_CheckDate.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.lblPA_CheckDate.Name = "lblPA_CheckDate"
        Me.lblPA_CheckDate.Size = New System.Drawing.Size(75, 15)
        Me.lblPA_CheckDate.TabIndex = 10
        Me.lblPA_CheckDate.Text = "審核日期："
        '
        'lblPA_CheckUserName
        '
        Me.lblPA_CheckUserName.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPA_CheckUserName.Appearance.Options.UseFont = True
        Me.lblPA_CheckUserName.Location = New System.Drawing.Point(345, 32)
        Me.lblPA_CheckUserName.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.lblPA_CheckUserName.Name = "lblPA_CheckUserName"
        Me.lblPA_CheckUserName.Size = New System.Drawing.Size(60, 15)
        Me.lblPA_CheckUserName.TabIndex = 9
        Me.lblPA_CheckUserName.Text = "審核人："
        '
        'chkPA_Check
        '
        Me.chkPA_Check.Location = New System.Drawing.Point(105, 30)
        Me.chkPA_Check.Name = "chkPA_Check"
        Me.chkPA_Check.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPA_Check.Properties.Appearance.Options.UseFont = True
        Me.chkPA_Check.Properties.Caption = "確認"
        Me.chkPA_Check.Size = New System.Drawing.Size(81, 20)
        Me.chkPA_Check.TabIndex = 2
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(40, 114)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl11.TabIndex = 5
        Me.LabelControl11.Text = "備注(&R)："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(10, 71)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl10.TabIndex = 3
        Me.LabelControl10.Text = "審核類型(&T)："
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(466, 32)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "審核日期："
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(282, 32)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 15)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "審核人："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(39, 32)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 15)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "審核(&K)："
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdOK.Location = New System.Drawing.Point(560, 492)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(80, 28)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "確定(&O)"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(657, 492)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "取消(&C)"
        '
        'frmProductionApply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(773, 530)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPA_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionApply"
        Me.Text = "物料明細"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPA_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.betDpt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detPA_ApplyDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPA_ApplyReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPA_ApplyPersonName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtPA_CheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPA_CheckType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPA_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPA_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPA_ApplyPersonName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents detPA_ApplyDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPA_ApplyReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkPA_Check As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPA_CheckDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPA_CheckUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPA_CheckType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPA_CheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PA_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PA_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents betDpt_Name As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
End Class
