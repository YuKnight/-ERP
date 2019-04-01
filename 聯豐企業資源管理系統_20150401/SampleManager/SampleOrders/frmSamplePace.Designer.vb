<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSamplePace
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
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLook = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gridSamplePace = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SS_Edition = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.State = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_TypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_OutInType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_PaceDescribe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SPIDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SPID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddDateSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkA = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.cmsMenuStrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridSamplePace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(807, 32)
        Me.Panel2.TabIndex = 127
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(98, 21)
        Me.Lbl_Title.TabIndex = 85
        Me.Lbl_Title.Text = "样办进度"
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.cmdQuery, Me.cmdLook, Me.cmdCheck, Me.cmdRef, Me.cmdPrint})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(173, 180)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(172, 22)
        Me.cmdAdd.Text = "新增(&A)"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(172, 22)
        Me.cmdEdit.Text = "修改(&E)"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(172, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(172, 22)
        Me.cmdQuery.Text = "查询(&F)        Ctrl+F"
        '
        'cmdLook
        '
        Me.cmdLook.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdLook.Name = "cmdLook"
        Me.cmdLook.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdLook.Size = New System.Drawing.Size(172, 22)
        Me.cmdLook.Text = "查看(&W)"
        '
        'cmdCheck
        '
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(172, 22)
        Me.cmdCheck.Text = "审核(&G)"
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(172, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(172, 22)
        Me.cmdPrint.Text = "打印(&P)"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridSamplePace)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(807, 511)
        Me.SplitContainer1.SplitterDistance = 350
        Me.SplitContainer1.TabIndex = 128
        '
        'gridSamplePace
        '
        Me.gridSamplePace.ContextMenuStrip = Me.cmsMenuStrip
        Me.gridSamplePace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridSamplePace.EmbeddedNavigator.Name = ""
        Me.gridSamplePace.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gridSamplePace.Location = New System.Drawing.Point(0, 0)
        Me.gridSamplePace.MainView = Me.GridView3
        Me.gridSamplePace.Name = "gridSamplePace"
        Me.gridSamplePace.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemButtonEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.gridSamplePace.Size = New System.Drawing.Size(807, 350)
        Me.gridSamplePace.TabIndex = 6
        Me.gridSamplePace.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SE_ID, Me.SO_ID, Me.SS_Edition, Me.PM_M_Code, Me.M_Code, Me.PS_NO, Me.PS_Name, Me.State, Me.SE_Qty, Me.SE_TypeName, Me.SE_OutInType, Me.SE_PaceDescribe, Me.SE_AddUserName, Me.SE_AddDate, Me.AutoID, Me.SE_Check, Me.SE_CheckActionName, Me.SPIDA})
        Me.GridView3.GridControl = Me.gridSamplePace
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
        'SE_ID
        '
        Me.SE_ID.Caption = "单号"
        Me.SE_ID.FieldName = "SE_ID"
        Me.SE_ID.Name = "SE_ID"
        Me.SE_ID.OptionsColumn.ReadOnly = True
        Me.SE_ID.Visible = True
        Me.SE_ID.VisibleIndex = 0
        Me.SE_ID.Width = 90
        '
        'SO_ID
        '
        Me.SO_ID.Caption = "样办订单号"
        Me.SO_ID.FieldName = "SO_ID"
        Me.SO_ID.Name = "SO_ID"
        Me.SO_ID.OptionsColumn.ReadOnly = True
        Me.SO_ID.Visible = True
        Me.SO_ID.VisibleIndex = 1
        Me.SO_ID.Width = 91
        '
        'SS_Edition
        '
        Me.SS_Edition.Caption = "版本号"
        Me.SS_Edition.FieldName = "SS_Edition"
        Me.SS_Edition.Name = "SS_Edition"
        Me.SS_Edition.OptionsColumn.ReadOnly = True
        Me.SS_Edition.Visible = True
        Me.SS_Edition.VisibleIndex = 2
        Me.SS_Edition.Width = 61
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 4
        Me.PM_M_Code.Width = 129
        '
        'M_Code
        '
        Me.M_Code.Caption = "产品类型"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 5
        Me.M_Code.Width = 120
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序编号"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.OptionsColumn.ReadOnly = True
        Me.PS_NO.Width = 110
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名称"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 3
        Me.PS_Name.Width = 86
        '
        'State
        '
        Me.State.Caption = "状态"
        Me.State.FieldName = "State"
        Me.State.Name = "State"
        Me.State.Visible = True
        Me.State.VisibleIndex = 6
        Me.State.Width = 56
        '
        'SE_Qty
        '
        Me.SE_Qty.Caption = "數量"
        Me.SE_Qty.FieldName = "SE_Qty"
        Me.SE_Qty.Name = "SE_Qty"
        Me.SE_Qty.Visible = True
        Me.SE_Qty.VisibleIndex = 7
        '
        'SE_TypeName
        '
        Me.SE_TypeName.Caption = "类别"
        Me.SE_TypeName.FieldName = "SE_TypeName"
        Me.SE_TypeName.Name = "SE_TypeName"
        Me.SE_TypeName.Visible = True
        Me.SE_TypeName.VisibleIndex = 8
        '
        'SE_OutInType
        '
        Me.SE_OutInType.Caption = "收发类型"
        Me.SE_OutInType.FieldName = "SE_OutInType"
        Me.SE_OutInType.Name = "SE_OutInType"
        Me.SE_OutInType.Visible = True
        Me.SE_OutInType.VisibleIndex = 9
        '
        'SE_PaceDescribe
        '
        Me.SE_PaceDescribe.Caption = "工序描述"
        Me.SE_PaceDescribe.FieldName = "SE_PaceDescribe"
        Me.SE_PaceDescribe.Name = "SE_PaceDescribe"
        Me.SE_PaceDescribe.OptionsColumn.ReadOnly = True
        Me.SE_PaceDescribe.Width = 154
        '
        'SE_AddUserName
        '
        Me.SE_AddUserName.Caption = "新增人員"
        Me.SE_AddUserName.FieldName = "SE_AddUserName"
        Me.SE_AddUserName.Name = "SE_AddUserName"
        Me.SE_AddUserName.OptionsColumn.ReadOnly = True
        Me.SE_AddUserName.Visible = True
        Me.SE_AddUserName.VisibleIndex = 10
        '
        'SE_AddDate
        '
        Me.SE_AddDate.Caption = "新增日期"
        Me.SE_AddDate.FieldName = "SE_AddDate"
        Me.SE_AddDate.Name = "SE_AddDate"
        Me.SE_AddDate.OptionsColumn.ReadOnly = True
        Me.SE_AddDate.Visible = True
        Me.SE_AddDate.VisibleIndex = 11
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'SE_Check
        '
        Me.SE_Check.Caption = "审核"
        Me.SE_Check.FieldName = "SE_Check"
        Me.SE_Check.Name = "SE_Check"
        Me.SE_Check.OptionsColumn.ReadOnly = True
        Me.SE_Check.Visible = True
        Me.SE_Check.VisibleIndex = 12
        '
        'SE_CheckActionName
        '
        Me.SE_CheckActionName.Caption = "审核人"
        Me.SE_CheckActionName.FieldName = "SE_CheckActionName"
        Me.SE_CheckActionName.Name = "SE_CheckActionName"
        Me.SE_CheckActionName.OptionsColumn.ReadOnly = True
        Me.SE_CheckActionName.Visible = True
        Me.SE_CheckActionName.VisibleIndex = 13
        '
        'SPIDA
        '
        Me.SPIDA.FieldName = "SPID"
        Me.SPIDA.Name = "SPIDA"
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
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView9
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RemarkA})
        Me.Grid1.Size = New System.Drawing.Size(807, 157)
        Me.Grid1.TabIndex = 224
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SPID, Me.Code_ID, Me.ClientBarcode, Me.QtyA, Me.SE_AddDateSub, Me.AutoIDA})
        Me.GridView9.GridControl = Me.Grid1
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsCustomization.AllowColumnMoving = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView9.OptionsFilter.AllowFilterEditor = False
        Me.GridView9.OptionsFilter.AllowMRUFilterList = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
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
        Me.Code_ID.Width = 138
        '
        'ClientBarcode
        '
        Me.ClientBarcode.Caption = "客戶條碼"
        Me.ClientBarcode.FieldName = "ClientBarcode"
        Me.ClientBarcode.Name = "ClientBarcode"
        Me.ClientBarcode.Visible = True
        Me.ClientBarcode.VisibleIndex = 2
        Me.ClientBarcode.Width = 133
        '
        'QtyA
        '
        Me.QtyA.Caption = "数量"
        Me.QtyA.FieldName = "Qty"
        Me.QtyA.Name = "QtyA"
        Me.QtyA.OptionsColumn.ReadOnly = True
        Me.QtyA.Visible = True
        Me.QtyA.VisibleIndex = 1
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
        'frmSamplePace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 543)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "frmSamplePace"
        Me.Text = "样办进度"
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.cmsMenuStrip.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridSamplePace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gridSamplePace As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SS_Edition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_TypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_PaceDescribe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SPID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_AddDateSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkA As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents SPIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClientBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_OutInType As DevExpress.XtraGrid.Columns.GridColumn
End Class
