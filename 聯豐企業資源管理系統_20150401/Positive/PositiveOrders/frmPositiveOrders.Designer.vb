<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPositiveOrders
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtP_OM_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtOrderComplate = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtOrdersStart = New DevExpress.XtraEditors.DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtP_OMRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.gluCuster = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtP_OM_CusterPO = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtP_OM_AddAction = New DevExpress.XtraEditors.TextEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.pnlSchedule = New System.Windows.Forms.Panel
        Me.dgPositiveOrders = New DevExpress.XtraGrid.GridControl
        Me.popOrder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPositiveOrdersAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popPositiveOrdersDel = New System.Windows.Forms.ToolStripMenuItem
        Me.dgvPositiveOrders = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.P_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rGrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.r_PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Type3Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PartNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ResCalQty = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.P_OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.P_SalesPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.P_ProductPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.P_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.P_OM_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCalcEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.pnlCheck = New System.Windows.Forms.Panel
        Me.lblCheckDateTime = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.lblCheckAction = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.chkCheck = New DevExpress.XtraEditors.CheckEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtOrderComplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdersStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtP_OMRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtP_OM_CusterPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtP_OM_AddAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.pnlSchedule.SuspendLayout()
        CType(Me.dgPositiveOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popOrder.SuspendLayout()
        CType(Me.dgvPositiveOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResCalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.pnlCheck.SuspendLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "陽極訂單信息"
        '
        'txtP_OM_ID
        '
        Me.txtP_OM_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtP_OM_ID.Enabled = False
        Me.txtP_OM_ID.Location = New System.Drawing.Point(820, 6)
        Me.txtP_OM_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtP_OM_ID.Name = "txtP_OM_ID"
        Me.txtP_OM_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtP_OM_ID.Properties.Appearance.Options.UseFont = True
        Me.txtP_OM_ID.Properties.ReadOnly = True
        Me.txtP_OM_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtP_OM_ID.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(734, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "訂單編號(&I):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtOrderComplate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtOrdersStart)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtP_OMRemark)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.gluCuster)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtP_OM_CusterPO)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(979, 136)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'dtOrderComplate
        '
        Me.dtOrderComplate.EditValue = Nothing
        Me.dtOrderComplate.Location = New System.Drawing.Point(820, 15)
        Me.dtOrderComplate.Margin = New System.Windows.Forms.Padding(6)
        Me.dtOrderComplate.Name = "dtOrderComplate"
        Me.dtOrderComplate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtOrderComplate.Properties.Appearance.Options.UseFont = True
        Me.dtOrderComplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrderComplate.Size = New System.Drawing.Size(150, 24)
        Me.dtOrderComplate.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(743, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "交貨日期:"
        '
        'dtOrdersStart
        '
        Me.dtOrdersStart.EditValue = Nothing
        Me.dtOrdersStart.Location = New System.Drawing.Point(564, 15)
        Me.dtOrdersStart.Margin = New System.Windows.Forms.Padding(6)
        Me.dtOrdersStart.Name = "dtOrdersStart"
        Me.dtOrdersStart.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtOrdersStart.Properties.Appearance.Options.UseFont = True
        Me.dtOrdersStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrdersStart.Size = New System.Drawing.Size(150, 24)
        Me.dtOrdersStart.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(484, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "訂單日期:"
        '
        'txtP_OMRemark
        '
        Me.txtP_OMRemark.Location = New System.Drawing.Point(80, 48)
        Me.txtP_OMRemark.Name = "txtP_OMRemark"
        Me.txtP_OMRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtP_OMRemark.Properties.Appearance.Options.UseFont = True
        Me.txtP_OMRemark.Size = New System.Drawing.Size(889, 55)
        Me.txtP_OMRemark.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "備註:"
        '
        'gluCuster
        '
        Me.gluCuster.EditValue = ""
        Me.gluCuster.EnterMoveNextControl = True
        Me.gluCuster.Location = New System.Drawing.Point(80, 13)
        Me.gluCuster.Margin = New System.Windows.Forms.Padding(6)
        Me.gluCuster.Name = "gluCuster"
        Me.gluCuster.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluCuster.Properties.Appearance.Options.UseFont = True
        Me.gluCuster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluCuster.Properties.NullText = ""
        Me.gluCuster.Properties.View = Me.GridLookUpEdit1View
        Me.gluCuster.Size = New System.Drawing.Size(150, 24)
        Me.gluCuster.TabIndex = 22
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_CusterID, Me.GridColumn3, Me.GridColumn11})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'C_CusterID
        '
        Me.C_CusterID.Caption = "客戶代號"
        Me.C_CusterID.FieldName = "C_CusterID"
        Me.C_CusterID.Name = "C_CusterID"
        Me.C_CusterID.Visible = True
        Me.C_CusterID.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "英文名"
        Me.GridColumn3.FieldName = "C_EngName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "中文名"
        Me.GridColumn11.FieldName = "C_ChsName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "客戶代號:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(248, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "客戶&PO:"
        '
        'txtP_OM_CusterPO
        '
        Me.txtP_OM_CusterPO.Location = New System.Drawing.Point(310, 13)
        Me.txtP_OM_CusterPO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtP_OM_CusterPO.Name = "txtP_OM_CusterPO"
        Me.txtP_OM_CusterPO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtP_OM_CusterPO.Properties.Appearance.Options.UseFont = True
        Me.txtP_OM_CusterPO.Size = New System.Drawing.Size(150, 24)
        Me.txtP_OM_CusterPO.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "操作人："
        '
        'txtP_OM_AddAction
        '
        Me.txtP_OM_AddAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtP_OM_AddAction.Enabled = False
        Me.txtP_OM_AddAction.Location = New System.Drawing.Point(76, 495)
        Me.txtP_OM_AddAction.Margin = New System.Windows.Forms.Padding(6)
        Me.txtP_OM_AddAction.Name = "txtP_OM_AddAction"
        Me.txtP_OM_AddAction.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtP_OM_AddAction.Properties.Appearance.Options.UseFont = True
        Me.txtP_OM_AddAction.Size = New System.Drawing.Size(150, 24)
        Me.txtP_OM_AddAction.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(979, 36)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 202)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(977, 275)
        Me.XtraTabControl1.TabIndex = 43
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.pnlSchedule)
        Me.XtraTabPage1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(968, 243)
        Me.XtraTabPage1.Text = "訂單明細"
        '
        'pnlSchedule
        '
        Me.pnlSchedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSchedule.Controls.Add(Me.dgPositiveOrders)
        Me.pnlSchedule.Location = New System.Drawing.Point(6, 3)
        Me.pnlSchedule.Name = "pnlSchedule"
        Me.pnlSchedule.Size = New System.Drawing.Size(957, 237)
        Me.pnlSchedule.TabIndex = 19
        '
        'dgPositiveOrders
        '
        Me.dgPositiveOrders.ContextMenuStrip = Me.popOrder
        Me.dgPositiveOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPositiveOrders.EmbeddedNavigator.Name = ""
        Me.dgPositiveOrders.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.dgPositiveOrders.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgPositiveOrders.Location = New System.Drawing.Point(0, 0)
        Me.dgPositiveOrders.MainView = Me.dgvPositiveOrders
        Me.dgPositiveOrders.Name = "dgPositiveOrders"
        Me.dgPositiveOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.rGrid, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemCalcEdit4, Me.RepositoryItemCalcEdit5, Me.RepositoryItemCalcEdit6, Me.RepositoryItemCalcEdit7, Me.ResCalQty})
        Me.dgPositiveOrders.Size = New System.Drawing.Size(957, 237)
        Me.dgPositiveOrders.TabIndex = 43
        Me.dgPositiveOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvPositiveOrders})
        '
        'popOrder
        '
        Me.popOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPositiveOrdersAdd, Me.popPositiveOrdersDel})
        Me.popOrder.Name = "popOrderMain"
        Me.popOrder.Size = New System.Drawing.Size(148, 48)
        '
        'popPositiveOrdersAdd
        '
        Me.popPositiveOrdersAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPositiveOrdersAdd.Name = "popPositiveOrdersAdd"
        Me.popPositiveOrdersAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPositiveOrdersAdd.Size = New System.Drawing.Size(147, 22)
        Me.popPositiveOrdersAdd.Text = "新增(&A)"
        '
        'popPositiveOrdersDel
        '
        Me.popPositiveOrdersDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popPositiveOrdersDel.Name = "popPositiveOrdersDel"
        Me.popPositiveOrdersDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPositiveOrdersDel.Size = New System.Drawing.Size(147, 22)
        Me.popPositiveOrdersDel.Text = "刪除(&D)"
        '
        'dgvPositiveOrders
        '
        Me.dgvPositiveOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.P_M_Code, Me.PartNumber, Me.Qty, Me.P_OM_ID, Me.NoSendQty, Me.P_SalesPrice, Me.P_ProductPrice, Me.P_Remark, Me.P_OM_Num})
        Me.dgvPositiveOrders.GridControl = Me.dgPositiveOrders
        Me.dgvPositiveOrders.Name = "dgvPositiveOrders"
        Me.dgvPositiveOrders.OptionsFilter.AllowColumnMRUFilterList = False
        Me.dgvPositiveOrders.OptionsFilter.AllowFilterEditor = False
        Me.dgvPositiveOrders.OptionsFilter.AllowMRUFilterList = False
        Me.dgvPositiveOrders.OptionsNavigation.AutoFocusNewRow = True
        Me.dgvPositiveOrders.OptionsNavigation.UseTabKey = False
        Me.dgvPositiveOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgvPositiveOrders.OptionsView.ColumnAutoWidth = False
        Me.dgvPositiveOrders.OptionsView.ShowGroupPanel = False
        '
        'P_M_Code
        '
        Me.P_M_Code.Caption = "產品編號"
        Me.P_M_Code.ColumnEdit = Me.rGrid
        Me.P_M_Code.FieldName = "P_M_Code"
        Me.P_M_Code.Name = "P_M_Code"
        Me.P_M_Code.Visible = True
        Me.P_M_Code.VisibleIndex = 0
        Me.P_M_Code.Width = 100
        '
        'rGrid
        '
        Me.rGrid.AutoHeight = False
        Me.rGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rGrid.Name = "rGrid"
        Me.rGrid.NullText = ""
        Me.rGrid.PopupFormWidth = 500
        Me.rGrid.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.r_PM_M_Code, Me.GridColumn2, Me.PM_CusterNO, Me.M_Gauge, Me.Type3Name})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'r_PM_M_Code
        '
        Me.r_PM_M_Code.Caption = "產品編號"
        Me.r_PM_M_Code.FieldName = "PM_M_Code"
        Me.r_PM_M_Code.Name = "r_PM_M_Code"
        Me.r_PM_M_Code.Visible = True
        Me.r_PM_M_Code.VisibleIndex = 0
        Me.r_PM_M_Code.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品類別"
        Me.GridColumn2.FieldName = "PM_JiYu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'PM_CusterNO
        '
        Me.PM_CusterNO.Caption = "客戶編號"
        Me.PM_CusterNO.FieldName = "PM_CusterNO"
        Me.PM_CusterNO.Name = "PM_CusterNO"
        Me.PM_CusterNO.Visible = True
        Me.PM_CusterNO.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'Type3Name
        '
        Me.Type3Name.Caption = "名稱"
        Me.Type3Name.FieldName = "Type3Name"
        Me.Type3Name.Name = "Type3Name"
        Me.Type3Name.Visible = True
        Me.Type3Name.VisibleIndex = 4
        '
        'PartNumber
        '
        Me.PartNumber.Caption = "料號"
        Me.PartNumber.FieldName = "PartNumber"
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Visible = True
        Me.PartNumber.VisibleIndex = 1
        Me.PartNumber.Width = 120
        '
        'Qty
        '
        Me.Qty.Caption = "訂單數量"
        Me.Qty.ColumnEdit = Me.ResCalQty
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        '
        'ResCalQty
        '
        Me.ResCalQty.AutoHeight = False
        Me.ResCalQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ResCalQty.Mask.EditMask = "n0"
        Me.ResCalQty.Name = "ResCalQty"
        '
        'P_OM_ID
        '
        Me.P_OM_ID.Caption = "訂單編號"
        Me.P_OM_ID.FieldName = "P_OM_ID"
        Me.P_OM_ID.Name = "P_OM_ID"
        '
        'NoSendQty
        '
        Me.NoSendQty.Caption = "未交數量"
        Me.NoSendQty.ColumnEdit = Me.RepositoryItemCalcEdit4
        Me.NoSendQty.FieldName = "NoSendQty"
        Me.NoSendQty.Name = "NoSendQty"
        Me.NoSendQty.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'P_SalesPrice
        '
        Me.P_SalesPrice.AppearanceCell.Options.UseTextOptions = True
        Me.P_SalesPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.P_SalesPrice.Caption = "銷售單價"
        Me.P_SalesPrice.ColumnEdit = Me.RepositoryItemCalcEdit5
        Me.P_SalesPrice.FieldName = "P_SalesPrice"
        Me.P_SalesPrice.Name = "P_SalesPrice"
        '
        'RepositoryItemCalcEdit5
        '
        Me.RepositoryItemCalcEdit5.AutoHeight = False
        Me.RepositoryItemCalcEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit5.Name = "RepositoryItemCalcEdit5"
        '
        'P_ProductPrice
        '
        Me.P_ProductPrice.AppearanceCell.Options.UseTextOptions = True
        Me.P_ProductPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.P_ProductPrice.Caption = "成本價"
        Me.P_ProductPrice.ColumnEdit = Me.RepositoryItemCalcEdit6
        Me.P_ProductPrice.FieldName = "P_ProductPrice"
        Me.P_ProductPrice.Name = "P_ProductPrice"
        '
        'RepositoryItemCalcEdit6
        '
        Me.RepositoryItemCalcEdit6.AutoHeight = False
        Me.RepositoryItemCalcEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit6.Name = "RepositoryItemCalcEdit6"
        '
        'P_Remark
        '
        Me.P_Remark.Caption = "備註"
        Me.P_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.P_Remark.FieldName = "P_Remark"
        Me.P_Remark.Name = "P_Remark"
        Me.P_Remark.Visible = True
        Me.P_Remark.VisibleIndex = 3
        Me.P_Remark.Width = 150
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'P_OM_Num
        '
        Me.P_OM_Num.Caption = "訂單流水號"
        Me.P_OM_Num.FieldName = "P_OM_Num"
        Me.P_OM_Num.Name = "P_OM_Num"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.DisplayFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit2.EditFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit2.Mask.EditMask = "f"
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'RepositoryItemCalcEdit7
        '
        Me.RepositoryItemCalcEdit7.AutoHeight = False
        Me.RepositoryItemCalcEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit7.Name = "RepositoryItemCalcEdit7"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.pnlCheck)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(968, 243)
        Me.XtraTabPage2.Text = "審核信息"
        '
        'pnlCheck
        '
        Me.pnlCheck.Controls.Add(Me.lblCheckDateTime)
        Me.pnlCheck.Controls.Add(Me.Label16)
        Me.pnlCheck.Controls.Add(Me.txtCheckRemark)
        Me.pnlCheck.Controls.Add(Me.lblCheckAction)
        Me.pnlCheck.Controls.Add(Me.Label60)
        Me.pnlCheck.Controls.Add(Me.Label59)
        Me.pnlCheck.Controls.Add(Me.Label58)
        Me.pnlCheck.Controls.Add(Me.chkCheck)
        Me.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCheck.Location = New System.Drawing.Point(0, 0)
        Me.pnlCheck.Name = "pnlCheck"
        Me.pnlCheck.Size = New System.Drawing.Size(968, 243)
        Me.pnlCheck.TabIndex = 8
        '
        'lblCheckDateTime
        '
        Me.lblCheckDateTime.AutoSize = True
        Me.lblCheckDateTime.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDateTime.Location = New System.Drawing.Point(469, 30)
        Me.lblCheckDateTime.Name = "lblCheckDateTime"
        Me.lblCheckDateTime.Size = New System.Drawing.Size(67, 15)
        Me.lblCheckDateTime.TabIndex = 15
        Me.lblCheckDateTime.Text = "審核時間"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(394, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "審核時間："
        '
        'txtCheckRemark
        '
        Me.txtCheckRemark.Location = New System.Drawing.Point(147, 73)
        Me.txtCheckRemark.Name = "txtCheckRemark"
        Me.txtCheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCheckRemark.Properties.Appearance.Options.UseFont = True
        Me.txtCheckRemark.Size = New System.Drawing.Size(619, 154)
        Me.txtCheckRemark.TabIndex = 12
        '
        'lblCheckAction
        '
        Me.lblCheckAction.AutoSize = True
        Me.lblCheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckAction.Location = New System.Drawing.Point(304, 30)
        Me.lblCheckAction.Name = "lblCheckAction"
        Me.lblCheckAction.Size = New System.Drawing.Size(52, 15)
        Me.lblCheckAction.TabIndex = 13
        Me.lblCheckAction.Text = "審核員"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label60.Location = New System.Drawing.Point(76, 73)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(71, 15)
        Me.Label60.TabIndex = 11
        Me.Label60.Text = "備註(&R)："
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label59.Location = New System.Drawing.Point(244, 30)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(67, 15)
        Me.Label59.TabIndex = 9
        Me.Label59.Text = "審核人："
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label58.Location = New System.Drawing.Point(75, 30)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(72, 15)
        Me.Label58.TabIndex = 8
        Me.Label58.Text = "審核(&K)："
        '
        'chkCheck
        '
        Me.chkCheck.Location = New System.Drawing.Point(147, 28)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkCheck.Properties.Appearance.Options.UseFont = True
        Me.chkCheck.Properties.Caption = "確認"
        Me.chkCheck.Size = New System.Drawing.Size(89, 20)
        Me.chkCheck.TabIndex = 10
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(889, 491)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 45
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(788, 491)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 44
        Me.cmdSave.Text = "確定(&O)"
        '
        'frmPositiveOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 534)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtP_OM_ID)
        Me.Controls.Add(Me.txtP_OM_AddAction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPositiveOrders"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPositiveOrders"
        CType(Me.txtP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtOrderComplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdersStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtP_OMRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtP_OM_CusterPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtP_OM_AddAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.pnlSchedule.ResumeLayout(False)
        CType(Me.dgPositiveOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popOrder.ResumeLayout(False)
        CType(Me.dgvPositiveOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResCalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.pnlCheck.ResumeLayout(False)
        Me.pnlCheck.PerformLayout()
        CType(Me.txtCheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtP_OM_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtP_OM_CusterPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtP_OM_AddAction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlSchedule As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlCheck As System.Windows.Forms.Panel
    Friend WithEvents lblCheckDateTime As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblCheckAction As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents chkCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgPositiveOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvPositiveOrders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents P_OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents P_SalesPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_ProductPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rGrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents r_PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type3Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents P_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popOrder As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPositiveOrdersAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPositiveOrdersDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P_OM_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluCuster As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtP_OMRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtOrdersStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCalcEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResCalQty As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents dtOrderComplate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
