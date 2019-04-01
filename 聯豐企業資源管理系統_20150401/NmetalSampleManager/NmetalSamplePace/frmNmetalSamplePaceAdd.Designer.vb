<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSamplePaceAdd
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
        Me.components = New System.ComponentModel.Container
        Me.Label22 = New System.Windows.Forms.Label
        Me.rdoIsEnabled = New DevExpress.XtraEditors.RadioGroup
        Me.rdoAccountCheck = New DevExpress.XtraEditors.RadioGroup
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabSE_NO = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabCheckDate = New System.Windows.Forms.Label
        Me.LabAction = New System.Windows.Forms.Label
        Me.CheckA = New DevExpress.XtraEditors.CheckEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dateAddDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gluSO_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSS_Edition = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.gridSampleSace = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO_Sub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_PaceDescribe_Sub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.State = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbState = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PS_Name_Sub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_OutInType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.SE_EndQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID_Sub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SE_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SPIDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.SO_IDItem = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SS_Edition = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboCodeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCode = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddFile = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDelSub = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SPID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddDateSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkA = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label32 = New System.Windows.Forms.Label
        Me.PS_NO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_PaceDescribe1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CheckA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_Edition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.gridSampleSace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SO_IDItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(34, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 15)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "是否启用(&J):"
        '
        'rdoIsEnabled
        '
        Me.rdoIsEnabled.EditValue = True
        Me.rdoIsEnabled.Location = New System.Drawing.Point(125, 123)
        Me.rdoIsEnabled.Name = "rdoIsEnabled"
        Me.rdoIsEnabled.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIsEnabled.Properties.Appearance.Options.UseFont = True
        Me.rdoIsEnabled.Properties.Columns = 2
        Me.rdoIsEnabled.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "启用"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "停用")})
        Me.rdoIsEnabled.Size = New System.Drawing.Size(181, 30)
        Me.rdoIsEnabled.TabIndex = 33
        '
        'rdoAccountCheck
        '
        Me.rdoAccountCheck.EditValue = False
        Me.rdoAccountCheck.Location = New System.Drawing.Point(125, 71)
        Me.rdoAccountCheck.Name = "rdoAccountCheck"
        Me.rdoAccountCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAccountCheck.Properties.Appearance.Options.UseFont = True
        Me.rdoAccountCheck.Properties.Columns = 2
        Me.rdoAccountCheck.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "已审核"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "未审核")})
        Me.rdoAccountCheck.Size = New System.Drawing.Size(181, 30)
        Me.rdoAccountCheck.TabIndex = 31
        '
        'txtPrice
        '
        Me.txtPrice.EditValue = "0"
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(125, 25)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPrice.Size = New System.Drawing.Size(181, 24)
        Me.txtPrice.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(61, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "单价(&P):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "会计部审核(&K):"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabSE_NO)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 32)
        Me.Panel2.TabIndex = 127
        '
        'LabSE_NO
        '
        Me.LabSE_NO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabSE_NO.AutoSize = True
        Me.LabSE_NO.BackColor = System.Drawing.Color.Transparent
        Me.LabSE_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabSE_NO.ForeColor = System.Drawing.Color.Black
        Me.LabSE_NO.Location = New System.Drawing.Point(705, 9)
        Me.LabSE_NO.Name = "LabSE_NO"
        Me.LabSE_NO.Size = New System.Drawing.Size(67, 15)
        Me.LabSE_NO.TabIndex = 88
        Me.LabSE_NO.Text = "自动编号"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(654, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "单号:"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(3, 5)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(98, 21)
        Me.lbl_Title.TabIndex = 86
        Me.lbl_Title.Text = "样办进度"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.cmdExit)
        Me.Panel3.Controls.Add(Me.cmdSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 673)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(821, 62)
        Me.Panel3.TabIndex = 130
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LabCheckDate)
        Me.Panel1.Controls.Add(Me.LabAction)
        Me.Panel1.Controls.Add(Me.CheckA)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 38)
        Me.Panel1.TabIndex = 171
        Me.Panel1.Visible = False
        '
        'LabCheckDate
        '
        Me.LabCheckDate.AutoSize = True
        Me.LabCheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCheckDate.Location = New System.Drawing.Point(235, 11)
        Me.LabCheckDate.Name = "LabCheckDate"
        Me.LabCheckDate.Size = New System.Drawing.Size(71, 15)
        Me.LabCheckDate.TabIndex = 5
        Me.LabCheckDate.Text = "审核日期:"
        '
        'LabAction
        '
        Me.LabAction.AutoSize = True
        Me.LabAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabAction.Location = New System.Drawing.Point(110, 11)
        Me.LabAction.Name = "LabAction"
        Me.LabAction.Size = New System.Drawing.Size(56, 15)
        Me.LabAction.TabIndex = 4
        Me.LabAction.Text = "审核人:"
        '
        'CheckA
        '
        Me.CheckA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckA.Location = New System.Drawing.Point(16, 7)
        Me.CheckA.Name = "CheckA"
        Me.CheckA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckA.Properties.Appearance.Options.UseFont = True
        Me.CheckA.Properties.Caption = "审核订单"
        Me.CheckA.Size = New System.Drawing.Size(88, 23)
        Me.CheckA.TabIndex = 3
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(708, 23)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(84, 27)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.cmdSave.Location = New System.Drawing.Point(575, 23)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(84, 27)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "确认(&S)"
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmDelete})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(119, 48)
        '
        'tsmNew
        '
        Me.tsmNew.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.Size = New System.Drawing.Size(118, 22)
        Me.tsmNew.Text = "新增(&N)"
        '
        'tsmDelete
        '
        Me.tsmDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(118, 22)
        Me.tsmDelete.Text = "刪除(&D)"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluM_Code)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dateAddDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluPM_M_Code)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluSO_ID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSS_Edition)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(821, 641)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.TabIndex = 0
        '
        'gluM_Code
        '
        Me.gluM_Code.EditValue = ""
        Me.gluM_Code.Location = New System.Drawing.Point(351, 38)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.View = Me.GridView3
        Me.gluM_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluM_Code.TabIndex = 9
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "產品類型"
        Me.GridColumn8.FieldName = "Type3ID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "AutoID"
        Me.GridColumn9.FieldName = "AutoID"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'dateAddDate
        '
        Me.dateAddDate.EditValue = Nothing
        Me.dateAddDate.Location = New System.Drawing.Point(596, 9)
        Me.dateAddDate.Name = "dateAddDate"
        Me.dateAddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateAddDate.Properties.Appearance.Options.UseFont = True
        Me.dateAddDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateAddDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateAddDate.Size = New System.Drawing.Size(133, 24)
        Me.dateAddDate.TabIndex = 5
        Me.dateAddDate.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(506, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "建立日期(&D):"
        Me.Label3.Visible = False
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(103, 38)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluPM_M_Code.TabIndex = 7
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "产品编号"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "产品名称"
        Me.GridColumn6.FieldName = "pm_m_name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "产品编号(&C):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.CausesValidation = False
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(257, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "产品类型(&N):"
        '
        'gluSO_ID
        '
        Me.gluSO_ID.EditValue = ""
        Me.gluSO_ID.Location = New System.Drawing.Point(102, 9)
        Me.gluSO_ID.Name = "gluSO_ID"
        Me.gluSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSO_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSO_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSO_ID.Properties.NullText = ""
        Me.gluSO_ID.Properties.View = Me.GridView7
        Me.gluSO_ID.Size = New System.Drawing.Size(150, 24)
        Me.gluSO_ID.TabIndex = 1
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.AutoID})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "订单编号"
        Me.GridColumn3.FieldName = "SO_ID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "版本号"
        Me.GridColumn4.FieldName = "SS_Edition"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(257, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "版  本  号(&B):"
        '
        'txtSS_Edition
        '
        Me.txtSS_Edition.Enabled = False
        Me.txtSS_Edition.Location = New System.Drawing.Point(351, 9)
        Me.txtSS_Edition.Name = "txtSS_Edition"
        Me.txtSS_Edition.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSS_Edition.Properties.Appearance.Options.UseFont = True
        Me.txtSS_Edition.Size = New System.Drawing.Size(150, 24)
        Me.txtSS_Edition.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(2, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "样办订单号(&I):"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(821, 568)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(812, 536)
        Me.XtraTabPage1.Text = "样办进度"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridSampleSace)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(812, 533)
        Me.SplitContainer2.SplitterDistance = 266
        Me.SplitContainer2.TabIndex = 1
        '
        'gridSampleSace
        '
        Me.gridSampleSace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSampleSace.ContextMenuStrip = Me.cmsMenuStrip
        Me.gridSampleSace.EmbeddedNavigator.Name = ""
        Me.gridSampleSace.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gridSampleSace.Location = New System.Drawing.Point(0, 3)
        Me.gridSampleSace.MainView = Me.GridView1
        Me.gridSampleSace.Name = "gridSampleSace"
        Me.gridSampleSace.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemTextEdit1, Me.SO_IDItem, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoExEdit2, Me.cmbState, Me.RepositoryItemCalcEdit2, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemDateEdit3, Me.RepositoryItemComboBox1})
        Me.gridSampleSace.Size = New System.Drawing.Size(812, 260)
        Me.gridSampleSace.TabIndex = 0
        Me.gridSampleSace.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO_Sub, Me.SE_PaceDescribe_Sub, Me.State, Me.PS_Name_Sub, Me.SE_OutInType, Me.SE_EndQty, Me.AutoID_Sub, Me.SE_AddDate, Me.SE_Type, Me.SPIDSub, Me.SE_Qty})
        Me.GridView1.GridControl = Me.gridSampleSace
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PS_NO_Sub
        '
        Me.PS_NO_Sub.Caption = "工序编号"
        Me.PS_NO_Sub.FieldName = "PS_NO"
        Me.PS_NO_Sub.Name = "PS_NO_Sub"
        Me.PS_NO_Sub.Width = 137
        '
        'SE_PaceDescribe_Sub
        '
        Me.SE_PaceDescribe_Sub.Caption = "工序描述"
        Me.SE_PaceDescribe_Sub.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.SE_PaceDescribe_Sub.FieldName = "SE_PaceDescribe"
        Me.SE_PaceDescribe_Sub.Name = "SE_PaceDescribe_Sub"
        Me.SE_PaceDescribe_Sub.Visible = True
        Me.SE_PaceDescribe_Sub.VisibleIndex = 7
        Me.SE_PaceDescribe_Sub.Width = 342
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'State
        '
        Me.State.Caption = "状态"
        Me.State.ColumnEdit = Me.cmbState
        Me.State.FieldName = "State"
        Me.State.Name = "State"
        Me.State.Visible = True
        Me.State.VisibleIndex = 4
        Me.State.Width = 79
        '
        'cmbState
        '
        Me.cmbState.AutoHeight = False
        Me.cmbState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbState.Items.AddRange(New Object() {"生產中", "已完成"})
        Me.cmbState.Name = "cmbState"
        '
        'PS_Name_Sub
        '
        Me.PS_Name_Sub.Caption = "工序名称"
        Me.PS_Name_Sub.FieldName = "PS_Name"
        Me.PS_Name_Sub.Name = "PS_Name_Sub"
        Me.PS_Name_Sub.OptionsColumn.ReadOnly = True
        Me.PS_Name_Sub.Visible = True
        Me.PS_Name_Sub.VisibleIndex = 0
        Me.PS_Name_Sub.Width = 150
        '
        'SE_OutInType
        '
        Me.SE_OutInType.Caption = "收发类型"
        Me.SE_OutInType.ColumnEdit = Me.RepositoryItemComboBox1
        Me.SE_OutInType.FieldName = "SE_OutInType"
        Me.SE_OutInType.Name = "SE_OutInType"
        Me.SE_OutInType.Visible = True
        Me.SE_OutInType.VisibleIndex = 5
        Me.SE_OutInType.Width = 62
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"收料", "發料"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'SE_EndQty
        '
        Me.SE_EndQty.Caption = "工艺结余数"
        Me.SE_EndQty.FieldName = "SE_EndQty"
        Me.SE_EndQty.Name = "SE_EndQty"
        Me.SE_EndQty.OptionsColumn.ReadOnly = True
        Me.SE_EndQty.Visible = True
        Me.SE_EndQty.VisibleIndex = 6
        '
        'AutoID_Sub
        '
        Me.AutoID_Sub.Caption = "AutoID"
        Me.AutoID_Sub.FieldName = "AutoID"
        Me.AutoID_Sub.Name = "AutoID_Sub"
        '
        'SE_AddDate
        '
        Me.SE_AddDate.Caption = "日期"
        Me.SE_AddDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.SE_AddDate.FieldName = "SE_AddDate"
        Me.SE_AddDate.Name = "SE_AddDate"
        Me.SE_AddDate.Visible = True
        Me.SE_AddDate.VisibleIndex = 1
        Me.SE_AddDate.Width = 100
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'SE_Type
        '
        Me.SE_Type.Caption = "类型"
        Me.SE_Type.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.SE_Type.FieldName = "SE_Type"
        Me.SE_Type.Name = "SE_Type"
        Me.SE_Type.Visible = True
        Me.SE_Type.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SE_Type", "編號", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SE_TypeName", "名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'SPIDSub
        '
        Me.SPIDSub.Caption = "单号"
        Me.SPIDSub.FieldName = "SPID"
        Me.SPIDSub.Name = "SPIDSub"
        Me.SPIDSub.OptionsColumn.ReadOnly = True
        Me.SPIDSub.Width = 90
        '
        'SE_Qty
        '
        Me.SE_Qty.Caption = "数量"
        Me.SE_Qty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.SE_Qty.FieldName = "SE_Qty"
        Me.SE_Qty.Name = "SE_Qty"
        Me.SE_Qty.OptionsColumn.ReadOnly = True
        Me.SE_Qty.SummaryItem.DisplayFormat = "{0}"
        Me.SE_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SE_Qty.Visible = True
        Me.SE_Qty.VisibleIndex = 3
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SO_IDItem
        '
        Me.SO_IDItem.AutoHeight = False
        Me.SO_IDItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SO_IDItem.Name = "SO_IDItem"
        Me.SO_IDItem.NullText = ""
        Me.SO_IDItem.PopupFormWidth = 600
        Me.SO_IDItem.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SO_ID, Me.SS_Edition, Me.SO_OrderQty, Me.SO_CusterID, Me.PM_M_Code, Me.M_Code, Me.AutoID2})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SO_ID
        '
        Me.SO_ID.Caption = "样办订单号"
        Me.SO_ID.FieldName = "SO_ID"
        Me.SO_ID.Name = "SO_ID"
        Me.SO_ID.OptionsColumn.AllowSize = False
        Me.SO_ID.Visible = True
        Me.SO_ID.VisibleIndex = 0
        Me.SO_ID.Width = 100
        '
        'SS_Edition
        '
        Me.SS_Edition.Caption = "版本号"
        Me.SS_Edition.FieldName = "SS_Edition"
        Me.SS_Edition.Name = "SS_Edition"
        Me.SS_Edition.OptionsColumn.AllowSize = False
        Me.SS_Edition.Visible = True
        Me.SS_Edition.VisibleIndex = 1
        Me.SS_Edition.Width = 100
        '
        'SO_OrderQty
        '
        Me.SO_OrderQty.Caption = "样办数量"
        Me.SO_OrderQty.FieldName = "SO_OrderQty"
        Me.SO_OrderQty.Name = "SO_OrderQty"
        Me.SO_OrderQty.OptionsColumn.AllowSize = False
        Me.SO_OrderQty.Visible = True
        Me.SO_OrderQty.VisibleIndex = 2
        Me.SO_OrderQty.Width = 100
        '
        'SO_CusterID
        '
        Me.SO_CusterID.Caption = "客戶代号"
        Me.SO_CusterID.FieldName = "SO_CusterID"
        Me.SO_CusterID.Name = "SO_CusterID"
        Me.SO_CusterID.OptionsColumn.AllowSize = False
        Me.SO_CusterID.Visible = True
        Me.SO_CusterID.VisibleIndex = 3
        Me.SO_CusterID.Width = 100
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.AllowSize = False
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 4
        Me.PM_M_Code.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "配件名称"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.AllowSize = False
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 5
        Me.M_Code.Width = 100
        '
        'AutoID2
        '
        Me.AutoID2.Caption = "AutoID"
        Me.AutoID2.FieldName = "AutoID"
        Me.AutoID2.Name = "AutoID2"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
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
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboCodeType)
        Me.GroupBox1.Controls.Add(Me.lblCode)
        Me.GroupBox1.Controls.Add(Me.Grid1)
        Me.GroupBox1.Controls.Add(Me.txtM_Code)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(586, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(146, 26)
        Me.TextEdit1.TabIndex = 225
        Me.TextEdit1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(518, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "客戶條碼"
        Me.Label2.Visible = False
        '
        'cboCodeType
        '
        Me.cboCodeType.EditValue = "[A]:條碼录入"
        Me.cboCodeType.Location = New System.Drawing.Point(4, 10)
        Me.cboCodeType.Name = "cboCodeType"
        Me.cboCodeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodeType.Properties.Appearance.Options.UseFont = True
        Me.cboCodeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodeType.Properties.Items.AddRange(New Object() {"[A]:條碼录入", "[C]:條碼關連"})
        Me.cboCodeType.Size = New System.Drawing.Size(106, 24)
        Me.cboCodeType.TabIndex = 131
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Red
        Me.lblCode.Location = New System.Drawing.Point(429, 15)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(15, 15)
        Me.lblCode.TabIndex = 224
        Me.lblCode.Text = "  "
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(2, 37)
        Me.Grid1.MainView = Me.GridView9
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RemarkA})
        Me.Grid1.Size = New System.Drawing.Size(810, 226)
        Me.Grid1.TabIndex = 223
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddFile, Me.cmdDelSub})
        Me.ContextMenuStrip1.Name = "cmsMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 48)
        '
        'cmdAddFile
        '
        Me.cmdAddFile.AutoSize = False
        Me.cmdAddFile.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAddFile.Image = Global.LFERP.My.Resources.Resources.SharingOpenMailFolder
        Me.cmdAddFile.Name = "cmdAddFile"
        Me.cmdAddFile.Size = New System.Drawing.Size(152, 22)
        Me.cmdAddFile.Text = "轉入盤點文件(&F)"
        '
        'cmdDelSub
        '
        Me.cmdDelSub.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDelSub.Name = "cmdDelSub"
        Me.cmdDelSub.Size = New System.Drawing.Size(169, 22)
        Me.cmdDelSub.Text = "刪除(&D)"
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SPID, Me.Code_ID, Me.ClientBarcode, Me.QtyA, Me.SE_AddDateSub, Me.AutoIDA})
        Me.GridView9.GridControl = Me.Grid1
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsCustomization.AllowColumnMoving = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView9.OptionsFilter.AllowFilterEditor = False
        Me.GridView9.OptionsFilter.AllowMRUFilterList = False
        Me.GridView9.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView9.OptionsView.ColumnAutoWidth = False
        Me.GridView9.OptionsView.RowAutoHeight = True
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'SPID
        '
        Me.SPID.Caption = "单号"
        Me.SPID.FieldName = "SPID"
        Me.SPID.Name = "SPID"
        Me.SPID.OptionsColumn.ReadOnly = True
        Me.SPID.Width = 90
        '
        'Code_ID
        '
        Me.Code_ID.Caption = "条码"
        Me.Code_ID.FieldName = "Code_ID"
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.OptionsColumn.ReadOnly = True
        Me.Code_ID.SummaryItem.DisplayFormat = "數量:{0}"
        Me.Code_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.Code_ID.Visible = True
        Me.Code_ID.VisibleIndex = 0
        Me.Code_ID.Width = 145
        '
        'ClientBarcode
        '
        Me.ClientBarcode.Caption = "客戶條碼"
        Me.ClientBarcode.FieldName = "ClientBarcode"
        Me.ClientBarcode.Name = "ClientBarcode"
        Me.ClientBarcode.OptionsColumn.ReadOnly = True
        Me.ClientBarcode.Visible = True
        Me.ClientBarcode.VisibleIndex = 1
        Me.ClientBarcode.Width = 151
        '
        'QtyA
        '
        Me.QtyA.Caption = "数量"
        Me.QtyA.FieldName = "Qty"
        Me.QtyA.Name = "QtyA"
        Me.QtyA.OptionsColumn.ReadOnly = True
        Me.QtyA.Visible = True
        Me.QtyA.VisibleIndex = 2
        '
        'SE_AddDateSub
        '
        Me.SE_AddDateSub.Caption = "采集时间"
        Me.SE_AddDateSub.FieldName = "SE_AddDate"
        Me.SE_AddDateSub.Name = "SE_AddDateSub"
        Me.SE_AddDateSub.OptionsColumn.ReadOnly = True
        Me.SE_AddDateSub.Visible = True
        Me.SE_AddDateSub.VisibleIndex = 3
        Me.SE_AddDateSub.Width = 134
        '
        'AutoIDA
        '
        Me.AutoIDA.Caption = "AutoID"
        Me.AutoIDA.FieldName = "AutoID"
        Me.AutoIDA.Name = "AutoIDA"
        Me.AutoIDA.OptionsColumn.ReadOnly = True
        '
        'RemarkA
        '
        Me.RemarkA.AutoHeight = False
        Me.RemarkA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkA.Name = "RemarkA"
        Me.RemarkA.ShowIcon = False
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(183, 9)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Code.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code.Size = New System.Drawing.Size(146, 26)
        Me.txtM_Code.TabIndex = 220
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(332, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl1.TabIndex = 222
        Me.LabelControl1.Text = "(可扫描条码输入)"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(113, 15)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 15)
        Me.Label32.TabIndex = 219
        Me.Label32.Text = "编码(&M):"
        '
        'PS_NO1
        '
        Me.PS_NO1.Caption = "工艺编号"
        Me.PS_NO1.FieldName = "PS_NO"
        Me.PS_NO1.Name = "PS_NO1"
        Me.PS_NO1.OptionsColumn.ReadOnly = True
        Me.PS_NO1.Visible = True
        Me.PS_NO1.VisibleIndex = 0
        Me.PS_NO1.Width = 98
        '
        'PS_Name1
        '
        Me.PS_Name1.Caption = "工艺名称"
        Me.PS_Name1.FieldName = "PS_Name"
        Me.PS_Name1.Name = "PS_Name1"
        Me.PS_Name1.OptionsColumn.ReadOnly = True
        Me.PS_Name1.Visible = True
        Me.PS_Name1.VisibleIndex = 1
        Me.PS_Name1.Width = 148
        '
        'SE_PaceDescribe1
        '
        Me.SE_PaceDescribe1.Caption = "进度描述"
        Me.SE_PaceDescribe1.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.SE_PaceDescribe1.FieldName = "SE_PaceDescribe"
        Me.SE_PaceDescribe1.Name = "SE_PaceDescribe1"
        Me.SE_PaceDescribe1.Visible = True
        Me.SE_PaceDescribe1.VisibleIndex = 2
        Me.SE_PaceDescribe1.Width = 344
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "订单编号"
        Me.GridColumn1.FieldName = "SO_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "版本号"
        Me.GridColumn2.FieldName = "SS_Edition"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSamplePaceAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 735)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSamplePaceAdd"
        Me.Text = "样办进度"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CheckA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_Edition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.gridSampleSace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SO_IDItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdoIsEnabled As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdoAccountCheck As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridSampleSace As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents PS_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SE_PaceDescribe1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents AutoID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SO_IDItem As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SS_Edition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluSO_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSS_Edition As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dateAddDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SE_PaceDescribe_Sub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name_Sub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO_Sub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID_Sub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbState As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SE_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SE_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SE_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabCheckDate As System.Windows.Forms.Label
    Friend WithEvents LabAction As System.Windows.Forms.Label
    Friend WithEvents CheckA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabSE_NO As System.Windows.Forms.Label
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SPID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkA As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents AutoIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdDelSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPIDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_AddDateSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_OutInType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SE_EndQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAddFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ClientBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCodeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
