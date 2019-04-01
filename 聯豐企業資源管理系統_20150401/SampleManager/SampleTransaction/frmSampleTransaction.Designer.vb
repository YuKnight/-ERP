<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleTransaction
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
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLook = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gridSampleTransaction = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TR_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SP_IDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.gridSampleTransactionSub = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TR_IDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusTypeNameSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusTypeSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_IDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtySub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserIDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserNameSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDateSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckBitSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckDateSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserIDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckUserNameSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckRemarkSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_CodeSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.cmsMenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridSampleTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSampleTransactionSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.Lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1034, 32)
        Me.Panel2.TabIndex = 127
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
        Me.Lbl_Title.Text = "成品状态管理"
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.ToolStripSeparator1, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator2, Me.cmdQuery, Me.cmdLook, Me.cmdRef, Me.ToolStripSeparator3, Me.cmdCheck, Me.cmdPrint})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(179, 220)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(178, 22)
        Me.cmdAdd.Text = "新增(&A)        Ctrl+A"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(178, 22)
        Me.cmdEdit.Text = "修改(&W)      Ctrl+P"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(178, 22)
        Me.cmdDel.Text = "刪除(&W)      Ctrl+P"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(178, 22)
        Me.cmdQuery.Text = "查詢(&W)      Ctrl+P"
        '
        'cmdLook
        '
        Me.cmdLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdLook.Name = "cmdLook"
        Me.cmdLook.Size = New System.Drawing.Size(178, 22)
        Me.cmdLook.Text = "查看(&W)      Ctrl+P"
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.Size = New System.Drawing.Size(178, 22)
        Me.cmdRef.Text = "刷新(&R)        Ctrl+R"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(175, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(178, 22)
        Me.cmdCheck.Text = "审核(&G)        Ctrl+G"
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(178, 22)
        Me.cmdPrint.Text = "打印(&P)        Ctrl+P"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 703)
        Me.Panel1.TabIndex = 128
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridSampleTransaction)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridSampleTransactionSub)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 703)
        Me.SplitContainer1.SplitterDistance = 234
        Me.SplitContainer1.TabIndex = 6
        '
        'gridSampleTransaction
        '
        Me.gridSampleTransaction.ContextMenuStrip = Me.cmsMenuStrip
        Me.gridSampleTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridSampleTransaction.EmbeddedNavigator.Name = ""
        Me.gridSampleTransaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gridSampleTransaction.Location = New System.Drawing.Point(0, 0)
        Me.gridSampleTransaction.MainView = Me.GridView3
        Me.gridSampleTransaction.Name = "gridSampleTransaction"
        Me.gridSampleTransaction.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemButtonEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.gridSampleTransaction.Size = New System.Drawing.Size(1034, 234)
        Me.gridSampleTransaction.TabIndex = 7
        Me.gridSampleTransaction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TR_ID, Me.StatusTypeName, Me.StatusType, Me.AddUserID, Me.AddUserName, Me.AddDate, Me.CheckBit, Me.CheckDate, Me.CheckUserID, Me.CheckUserName, Me.AutoID, Me.SP_IDSub})
        Me.GridView3.GridControl = Me.gridSampleTransaction
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'TR_ID
        '
        Me.TR_ID.Caption = "状态单号"
        Me.TR_ID.FieldName = "TR_ID"
        Me.TR_ID.Name = "TR_ID"
        Me.TR_ID.OptionsColumn.ReadOnly = True
        Me.TR_ID.Visible = True
        Me.TR_ID.VisibleIndex = 0
        Me.TR_ID.Width = 119
        '
        'StatusTypeName
        '
        Me.StatusTypeName.Caption = "类型"
        Me.StatusTypeName.FieldName = "StatusTypeName"
        Me.StatusTypeName.Name = "StatusTypeName"
        Me.StatusTypeName.OptionsColumn.ReadOnly = True
        Me.StatusTypeName.Visible = True
        Me.StatusTypeName.VisibleIndex = 1
        '
        'StatusType
        '
        Me.StatusType.Caption = "類型"
        Me.StatusType.FieldName = "StatusType"
        Me.StatusType.Name = "StatusType"
        Me.StatusType.OptionsColumn.ReadOnly = True
        Me.StatusType.Width = 70
        '
        'AddUserID
        '
        Me.AddUserID.Caption = "操作人員"
        Me.AddUserID.FieldName = "AddUserID"
        Me.AddUserID.Name = "AddUserID"
        Me.AddUserID.OptionsColumn.ReadOnly = True
        Me.AddUserID.Width = 145
        '
        'AddUserName
        '
        Me.AddUserName.Caption = "操作人員"
        Me.AddUserName.FieldName = "AddUserName"
        Me.AddUserName.Name = "AddUserName"
        Me.AddUserName.OptionsColumn.ReadOnly = True
        Me.AddUserName.Visible = True
        Me.AddUserName.VisibleIndex = 2
        '
        'AddDate
        '
        Me.AddDate.Caption = "操作日期"
        Me.AddDate.FieldName = "AddDate"
        Me.AddDate.Name = "AddDate"
        Me.AddDate.OptionsColumn.ReadOnly = True
        Me.AddDate.Visible = True
        Me.AddDate.VisibleIndex = 3
        Me.AddDate.Width = 110
        '
        'CheckBit
        '
        Me.CheckBit.Caption = "审核"
        Me.CheckBit.FieldName = "CheckBit"
        Me.CheckBit.Name = "CheckBit"
        Me.CheckBit.OptionsColumn.ReadOnly = True
        Me.CheckBit.Visible = True
        Me.CheckBit.VisibleIndex = 4
        Me.CheckBit.Width = 49
        '
        'CheckDate
        '
        Me.CheckDate.Caption = "審核時間"
        Me.CheckDate.FieldName = "CheckDate"
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.OptionsColumn.ReadOnly = True
        '
        'CheckUserID
        '
        Me.CheckUserID.Caption = "審核人員"
        Me.CheckUserID.FieldName = "CheckUserID"
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.OptionsColumn.ReadOnly = True
        Me.CheckUserID.Width = 154
        '
        'CheckUserName
        '
        Me.CheckUserName.Caption = "审核人员"
        Me.CheckUserName.FieldName = "CheckUserName"
        Me.CheckUserName.Name = "CheckUserName"
        Me.CheckUserName.OptionsColumn.ReadOnly = True
        Me.CheckUserName.Visible = True
        Me.CheckUserName.VisibleIndex = 5
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'SP_IDSub
        '
        Me.SP_IDSub.Caption = "寄送單號"
        Me.SP_IDSub.FieldName = "SP_ID"
        Me.SP_IDSub.Name = "SP_IDSub"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'gridSampleTransactionSub
        '
        Me.gridSampleTransactionSub.ContextMenuStrip = Me.cmsMenuStrip
        Me.gridSampleTransactionSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridSampleTransactionSub.EmbeddedNavigator.Name = ""
        Me.gridSampleTransactionSub.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gridSampleTransactionSub.Location = New System.Drawing.Point(0, 0)
        Me.gridSampleTransactionSub.MainView = Me.GridView1
        Me.gridSampleTransactionSub.Name = "gridSampleTransactionSub"
        Me.gridSampleTransactionSub.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit2})
        Me.gridSampleTransactionSub.Size = New System.Drawing.Size(1034, 465)
        Me.gridSampleTransactionSub.TabIndex = 7
        Me.gridSampleTransactionSub.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TR_IDSub, Me.StatusTypeNameSub, Me.StatusTypeSub, Me.Code_IDSub, Me.QtySub, Me.RemarkSub, Me.AddUserIDSub, Me.AddUserNameSub, Me.AddDateSub, Me.CheckBitSub, Me.CheckDateSub, Me.CheckUserIDSub, Me.CheckUserNameSub, Me.CheckRemarkSub, Me.PM_M_CodeSub, Me.SP_ID, Me.AutoIDSub})
        Me.GridView1.GridControl = Me.gridSampleTransactionSub
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'TR_IDSub
        '
        Me.TR_IDSub.Caption = "狀態單號"
        Me.TR_IDSub.FieldName = "TR_ID"
        Me.TR_IDSub.Name = "TR_IDSub"
        Me.TR_IDSub.OptionsColumn.ReadOnly = True
        Me.TR_IDSub.Width = 119
        '
        'StatusTypeNameSub
        '
        Me.StatusTypeNameSub.Caption = "類型"
        Me.StatusTypeNameSub.FieldName = "StatusTypeName"
        Me.StatusTypeNameSub.Name = "StatusTypeNameSub"
        Me.StatusTypeNameSub.OptionsColumn.ReadOnly = True
        '
        'StatusTypeSub
        '
        Me.StatusTypeSub.Caption = "類型"
        Me.StatusTypeSub.FieldName = "StatusType"
        Me.StatusTypeSub.Name = "StatusTypeSub"
        Me.StatusTypeSub.OptionsColumn.ReadOnly = True
        Me.StatusTypeSub.Width = 70
        '
        'Code_IDSub
        '
        Me.Code_IDSub.Caption = "条码"
        Me.Code_IDSub.FieldName = "Code_ID"
        Me.Code_IDSub.Name = "Code_IDSub"
        Me.Code_IDSub.OptionsColumn.ReadOnly = True
        Me.Code_IDSub.Visible = True
        Me.Code_IDSub.VisibleIndex = 0
        Me.Code_IDSub.Width = 147
        '
        'QtySub
        '
        Me.QtySub.Caption = "数量"
        Me.QtySub.FieldName = "Qty"
        Me.QtySub.Name = "QtySub"
        Me.QtySub.OptionsColumn.ReadOnly = True
        Me.QtySub.Visible = True
        Me.QtySub.VisibleIndex = 1
        '
        'RemarkSub
        '
        Me.RemarkSub.Caption = "备注"
        Me.RemarkSub.FieldName = "Remark"
        Me.RemarkSub.Name = "RemarkSub"
        Me.RemarkSub.OptionsColumn.ReadOnly = True
        Me.RemarkSub.Visible = True
        Me.RemarkSub.VisibleIndex = 2
        Me.RemarkSub.Width = 149
        '
        'AddUserIDSub
        '
        Me.AddUserIDSub.Caption = "操作人員"
        Me.AddUserIDSub.FieldName = "AddUserID"
        Me.AddUserIDSub.Name = "AddUserIDSub"
        Me.AddUserIDSub.OptionsColumn.ReadOnly = True
        Me.AddUserIDSub.Width = 145
        '
        'AddUserNameSub
        '
        Me.AddUserNameSub.Caption = "操作人員"
        Me.AddUserNameSub.FieldName = "AddUserName"
        Me.AddUserNameSub.Name = "AddUserNameSub"
        Me.AddUserNameSub.OptionsColumn.ReadOnly = True
        Me.AddUserNameSub.Visible = True
        Me.AddUserNameSub.VisibleIndex = 3
        '
        'AddDateSub
        '
        Me.AddDateSub.Caption = "操作日期"
        Me.AddDateSub.FieldName = "AddDate"
        Me.AddDateSub.Name = "AddDateSub"
        Me.AddDateSub.OptionsColumn.ReadOnly = True
        Me.AddDateSub.Visible = True
        Me.AddDateSub.VisibleIndex = 4
        Me.AddDateSub.Width = 110
        '
        'CheckBitSub
        '
        Me.CheckBitSub.Caption = "审核"
        Me.CheckBitSub.FieldName = "CheckBit"
        Me.CheckBitSub.Name = "CheckBitSub"
        Me.CheckBitSub.OptionsColumn.ReadOnly = True
        Me.CheckBitSub.Visible = True
        Me.CheckBitSub.VisibleIndex = 5
        Me.CheckBitSub.Width = 49
        '
        'CheckDateSub
        '
        Me.CheckDateSub.Caption = "審核時間"
        Me.CheckDateSub.FieldName = "CheckDate"
        Me.CheckDateSub.Name = "CheckDateSub"
        Me.CheckDateSub.OptionsColumn.ReadOnly = True
        '
        'CheckUserIDSub
        '
        Me.CheckUserIDSub.Caption = "審核人員"
        Me.CheckUserIDSub.FieldName = "CheckUserID"
        Me.CheckUserIDSub.Name = "CheckUserIDSub"
        Me.CheckUserIDSub.OptionsColumn.ReadOnly = True
        Me.CheckUserIDSub.Width = 154
        '
        'CheckUserNameSub
        '
        Me.CheckUserNameSub.Caption = "审核人员"
        Me.CheckUserNameSub.FieldName = "CheckUserName"
        Me.CheckUserNameSub.Name = "CheckUserNameSub"
        Me.CheckUserNameSub.OptionsColumn.ReadOnly = True
        Me.CheckUserNameSub.Visible = True
        Me.CheckUserNameSub.VisibleIndex = 7
        '
        'CheckRemarkSub
        '
        Me.CheckRemarkSub.Caption = "审核备注"
        Me.CheckRemarkSub.FieldName = "CheckRemark"
        Me.CheckRemarkSub.Name = "CheckRemarkSub"
        Me.CheckRemarkSub.OptionsColumn.ReadOnly = True
        Me.CheckRemarkSub.Visible = True
        Me.CheckRemarkSub.VisibleIndex = 6
        '
        'PM_M_CodeSub
        '
        Me.PM_M_CodeSub.Caption = "產品編號"
        Me.PM_M_CodeSub.FieldName = "PM_M_Code"
        Me.PM_M_CodeSub.Name = "PM_M_CodeSub"
        Me.PM_M_CodeSub.OptionsColumn.ReadOnly = True
        '
        'SP_ID
        '
        Me.SP_ID.Caption = "寄送單號"
        Me.SP_ID.FieldName = "SP_ID"
        Me.SP_ID.Name = "SP_ID"
        Me.SP_ID.OptionsColumn.ReadOnly = True
        '
        'AutoIDSub
        '
        Me.AutoIDSub.Caption = "AutoID"
        Me.AutoIDSub.FieldName = "AutoID"
        Me.AutoIDSub.Name = "AutoIDSub"
        Me.AutoIDSub.OptionsColumn.ReadOnly = True
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
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'frmSampleTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 735)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "frmSampleTransaction"
        Me.Text = "成品状态管理"
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.cmsMenuStrip.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridSampleTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSampleTransactionSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdoIsEnabled As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdoAccountCheck As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gridSampleTransaction As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents gridSampleTransactionSub As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TR_IDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTypeNameSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTypeSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_IDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtySub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUserIDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUserNameSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDateSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBitSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckDateSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserIDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckUserNameSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckRemarkSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_CodeSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoIDSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SP_IDSub As DevExpress.XtraGrid.Columns.GridColumn
End Class
