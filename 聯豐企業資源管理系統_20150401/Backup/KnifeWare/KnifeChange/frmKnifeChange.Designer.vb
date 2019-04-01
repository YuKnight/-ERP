<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnifeChange))
        Me.LabMsg = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popChange = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripBorrowReturn = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.BQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOReturn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CBegin_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.CEnd_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.CReMark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridLookChangeType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ChangeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChangeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateC_Date = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.txtCH_Num = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.ButtonLoadBnum1 = New DevExpress.XtraEditors.SimpleButton
        Me.TextBrrow = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.ButtonLoadBnum2 = New DevExpress.XtraEditors.SimpleButton
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtM_Code = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPerNO2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.ButtonM_CodeA = New DevExpress.XtraEditors.SimpleButton
        Me.TxtM_CodeA = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.ButtonChangeAdd = New DevExpress.XtraEditors.SimpleButton
        Me.TxtM_Code4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPerNO4 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popChange.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridLookChangeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateC_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCH_Num.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabMsg
        '
        Me.LabMsg.AutoSize = True
        Me.LabMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabMsg.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabMsg.ForeColor = System.Drawing.Color.Navy
        Me.LabMsg.Location = New System.Drawing.Point(4, 4)
        Me.LabMsg.Name = "LabMsg"
        Me.LabMsg.Size = New System.Drawing.Size(82, 24)
        Me.LabMsg.TabIndex = 206
        Me.LabMsg.Text = "更改單"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 33)
        Me.PictureBox1.TabIndex = 205
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popChange
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(1, 177)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemMemoExEdit4})
        Me.Grid1.Size = New System.Drawing.Size(940, 269)
        Me.Grid1.TabIndex = 207
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popChange
        '
        Me.popChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.ToolStripBorrowReturn, Me.popWareOutDel})
        Me.popChange.Name = "popWareInput"
        Me.popChange.Size = New System.Drawing.Size(172, 70)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Image = CType(resources.GetObject("popWareOutAdd.Image"), System.Drawing.Image)
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(171, 22)
        Me.popWareOutAdd.Text = "新增編碼(&A)"
        '
        'ToolStripBorrowReturn
        '
        Me.ToolStripBorrowReturn.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.ToolStripBorrowReturn.Name = "ToolStripBorrowReturn"
        Me.ToolStripBorrowReturn.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripBorrowReturn.Text = "新增領刀單"
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(171, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.B_Num, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.BQty, Me.RQty, Me.NOReturn, Me.CBegin_Qty, Me.CEnd_Qty, Me.CReMark})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'B_Num
        '
        Me.B_Num.Caption = "借刀單號"
        Me.B_Num.FieldName = "B_Num"
        Me.B_Num.Name = "B_Num"
        Me.B_Num.OptionsColumn.ReadOnly = True
        Me.B_Num.Visible = True
        Me.B_Num.VisibleIndex = 0
        Me.B_Num.Width = 85
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        Me.M_Name.Width = 90
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit4
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 150
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'BQty
        '
        Me.BQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BQty.AppearanceCell.Options.UseBackColor = True
        Me.BQty.Caption = "領刀數"
        Me.BQty.FieldName = "BQty"
        Me.BQty.Name = "BQty"
        Me.BQty.OptionsColumn.ReadOnly = True
        Me.BQty.SummaryItem.DisplayFormat = "共:{0}"
        Me.BQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.BQty.Visible = True
        Me.BQty.VisibleIndex = 4
        '
        'RQty
        '
        Me.RQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RQty.AppearanceCell.Options.UseBackColor = True
        Me.RQty.Caption = "還刀數"
        Me.RQty.FieldName = "RQty"
        Me.RQty.Name = "RQty"
        Me.RQty.OptionsColumn.ReadOnly = True
        Me.RQty.SummaryItem.DisplayFormat = "共:{0}"
        Me.RQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.RQty.Visible = True
        Me.RQty.VisibleIndex = 5
        '
        'NOReturn
        '
        Me.NOReturn.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOReturn.AppearanceCell.Options.UseBackColor = True
        Me.NOReturn.Caption = "未還數"
        Me.NOReturn.FieldName = "NOReturn"
        Me.NOReturn.Name = "NOReturn"
        Me.NOReturn.OptionsColumn.ReadOnly = True
        Me.NOReturn.SummaryItem.DisplayFormat = "共:{0}"
        Me.NOReturn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.NOReturn.Visible = True
        Me.NOReturn.VisibleIndex = 6
        '
        'CBegin_Qty
        '
        Me.CBegin_Qty.Caption = "更改前數"
        Me.CBegin_Qty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.CBegin_Qty.FieldName = "CBegin_Qty"
        Me.CBegin_Qty.Name = "CBegin_Qty"
        Me.CBegin_Qty.OptionsColumn.ReadOnly = True
        Me.CBegin_Qty.Visible = True
        Me.CBegin_Qty.VisibleIndex = 7
        Me.CBegin_Qty.Width = 70
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'CEnd_Qty
        '
        Me.CEnd_Qty.Caption = "更改后數"
        Me.CEnd_Qty.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.CEnd_Qty.FieldName = "CEnd_Qty"
        Me.CEnd_Qty.Name = "CEnd_Qty"
        Me.CEnd_Qty.Visible = True
        Me.CEnd_Qty.VisibleIndex = 8
        Me.CEnd_Qty.Width = 70
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'CReMark
        '
        Me.CReMark.Caption = "備注"
        Me.CReMark.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.CReMark.FieldName = "CReMark"
        Me.CReMark.Name = "CReMark"
        Me.CReMark.Visible = True
        Me.CReMark.VisibleIndex = 9
        Me.CReMark.Width = 120
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GridLookChangeType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateC_Date)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 48)
        Me.GroupBox1.TabIndex = 208
        Me.GroupBox1.TabStop = False
        '
        'GridLookChangeType
        '
        Me.GridLookChangeType.EditValue = ""
        Me.GridLookChangeType.Location = New System.Drawing.Point(291, 14)
        Me.GridLookChangeType.Name = "GridLookChangeType"
        Me.GridLookChangeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLookChangeType.Properties.Appearance.Options.UseFont = True
        Me.GridLookChangeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookChangeType.Properties.NullText = ""
        Me.GridLookChangeType.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookChangeType.Size = New System.Drawing.Size(124, 26)
        Me.GridLookChangeType.TabIndex = 19
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ChangeID, Me.ChangeName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ChangeID
        '
        Me.ChangeID.Caption = "ChangeID"
        Me.ChangeID.FieldName = "ChangeID"
        Me.ChangeID.Name = "ChangeID"
        Me.ChangeID.Visible = True
        Me.ChangeID.VisibleIndex = 0
        '
        'ChangeName
        '
        Me.ChangeName.Caption = "類型"
        Me.ChangeName.FieldName = "ChangeName"
        Me.ChangeName.Name = "ChangeName"
        Me.ChangeName.Visible = True
        Me.ChangeName.VisibleIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(195, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "更改類型(&E):"
        '
        'DateC_Date
        '
        Me.DateC_Date.EditValue = Nothing
        Me.DateC_Date.Enabled = False
        Me.DateC_Date.Location = New System.Drawing.Point(533, 15)
        Me.DateC_Date.Margin = New System.Windows.Forms.Padding(6)
        Me.DateC_Date.Name = "DateC_Date"
        Me.DateC_Date.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateC_Date.Properties.Appearance.Options.UseFont = True
        Me.DateC_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateC_Date.Size = New System.Drawing.Size(165, 24)
        Me.DateC_Date.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(434, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "更改時間(&T):"
        '
        'txtWH
        '
        Me.txtWH.Location = New System.Drawing.Point(72, 15)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(114, 24)
        Me.txtWH.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(5, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 15)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "倉庫(&W):"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(703, 452)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 30)
        Me.cmdSave.TabIndex = 209
        Me.cmdSave.Text = "保存(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(847, 452)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 30)
        Me.cmdExit.TabIndex = 210
        Me.cmdExit.Text = "取消(&C)"
        '
        'txtCH_Num
        '
        Me.txtCH_Num.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCH_Num.Location = New System.Drawing.Point(828, 4)
        Me.txtCH_Num.Name = "txtCH_Num"
        Me.txtCH_Num.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCH_Num.Properties.Appearance.Options.UseFont = True
        Me.txtCH_Num.Properties.ReadOnly = True
        Me.txtCH_Num.Size = New System.Drawing.Size(104, 22)
        Me.txtCH_Num.TabIndex = 212
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(760, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 211
        Me.Label20.Text = "更改單號:"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 82)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(942, 96)
        Me.XtraTabControl1.TabIndex = 213
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.ButtonLoadBnum1)
        Me.XtraTabPage1.Controls.Add(Me.TextBrrow)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(933, 64)
        Me.XtraTabPage1.Text = "樣式1"
        '
        'ButtonLoadBnum1
        '
        Me.ButtonLoadBnum1.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonLoadBnum1.Appearance.Options.UseFont = True
        Me.ButtonLoadBnum1.Location = New System.Drawing.Point(833, 18)
        Me.ButtonLoadBnum1.Name = "ButtonLoadBnum1"
        Me.ButtonLoadBnum1.Size = New System.Drawing.Size(84, 28)
        Me.ButtonLoadBnum1.TabIndex = 2
        Me.ButtonLoadBnum1.Text = "加入"
        '
        'TextBrrow
        '
        Me.TextBrrow.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBrrow.Location = New System.Drawing.Point(111, 17)
        Me.TextBrrow.Name = "TextBrrow"
        Me.TextBrrow.Size = New System.Drawing.Size(180, 27)
        Me.TextBrrow.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "領刀流水號:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ButtonLoadBnum2)
        Me.XtraTabPage2.Controls.Add(Me.txtQty)
        Me.XtraTabPage2.Controls.Add(Me.Label4)
        Me.XtraTabPage2.Controls.Add(Me.txtM_Code)
        Me.XtraTabPage2.Controls.Add(Me.Label3)
        Me.XtraTabPage2.Controls.Add(Me.txtPerNO2)
        Me.XtraTabPage2.Controls.Add(Me.Label5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(933, 64)
        Me.XtraTabPage2.Text = "樣式2"
        '
        'ButtonLoadBnum2
        '
        Me.ButtonLoadBnum2.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonLoadBnum2.Appearance.Options.UseFont = True
        Me.ButtonLoadBnum2.Location = New System.Drawing.Point(824, 17)
        Me.ButtonLoadBnum2.Name = "ButtonLoadBnum2"
        Me.ButtonLoadBnum2.Size = New System.Drawing.Size(84, 28)
        Me.ButtonLoadBnum2.TabIndex = 8
        Me.ButtonLoadBnum2.Text = "加入"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtQty.Location = New System.Drawing.Point(460, 16)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(77, 27)
        Me.txtQty.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "數量:"
        '
        'txtM_Code
        '
        Me.txtM_Code.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Code.Location = New System.Drawing.Point(229, 16)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Size = New System.Drawing.Size(180, 27)
        Me.txtM_Code.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "刀具編碼:"
        '
        'txtPerNO2
        '
        Me.txtPerNO2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPerNO2.Location = New System.Drawing.Point(53, 16)
        Me.txtPerNO2.Name = "txtPerNO2"
        Me.txtPerNO2.Size = New System.Drawing.Size(102, 27)
        Me.txtPerNO2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "工號:"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ButtonM_CodeA)
        Me.XtraTabPage3.Controls.Add(Me.TxtM_CodeA)
        Me.XtraTabPage3.Controls.Add(Me.Label6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(933, 64)
        Me.XtraTabPage3.Text = "刀具編碼"
        '
        'ButtonM_CodeA
        '
        Me.ButtonM_CodeA.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonM_CodeA.Appearance.Options.UseFont = True
        Me.ButtonM_CodeA.Location = New System.Drawing.Point(832, 16)
        Me.ButtonM_CodeA.Name = "ButtonM_CodeA"
        Me.ButtonM_CodeA.Size = New System.Drawing.Size(84, 28)
        Me.ButtonM_CodeA.TabIndex = 9
        Me.ButtonM_CodeA.Text = "加入"
        '
        'TxtM_CodeA
        '
        Me.TxtM_CodeA.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtM_CodeA.Location = New System.Drawing.Point(84, 20)
        Me.TxtM_CodeA.Name = "TxtM_CodeA"
        Me.TxtM_CodeA.Size = New System.Drawing.Size(180, 27)
        Me.TxtM_CodeA.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "刀具編碼:"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.ButtonChangeAdd)
        Me.XtraTabPage4.Controls.Add(Me.TxtM_Code4)
        Me.XtraTabPage4.Controls.Add(Me.Label7)
        Me.XtraTabPage4.Controls.Add(Me.txtPerNO4)
        Me.XtraTabPage4.Controls.Add(Me.Label8)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(933, 64)
        Me.XtraTabPage4.Text = "領刀單增加"
        '
        'ButtonChangeAdd
        '
        Me.ButtonChangeAdd.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonChangeAdd.Appearance.Options.UseFont = True
        Me.ButtonChangeAdd.Location = New System.Drawing.Point(844, 18)
        Me.ButtonChangeAdd.Name = "ButtonChangeAdd"
        Me.ButtonChangeAdd.Size = New System.Drawing.Size(84, 28)
        Me.ButtonChangeAdd.TabIndex = 13
        Me.ButtonChangeAdd.Text = "加入"
        '
        'TxtM_Code4
        '
        Me.TxtM_Code4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtM_Code4.Location = New System.Drawing.Point(241, 17)
        Me.TxtM_Code4.Name = "TxtM_Code4"
        Me.TxtM_Code4.Size = New System.Drawing.Size(180, 27)
        Me.TxtM_Code4.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "刀具編碼:"
        '
        'txtPerNO4
        '
        Me.txtPerNO4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPerNO4.Location = New System.Drawing.Point(51, 17)
        Me.txtPerNO4.Name = "txtPerNO4"
        Me.txtPerNO4.Size = New System.Drawing.Size(102, 27)
        Me.txtPerNO4.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "工號:"
        '
        'frmKnifeChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(944, 489)
        Me.Controls.Add(Me.txtCH_Num)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.LabMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKnifeChange"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "更改單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popChange.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridLookChangeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateC_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCH_Num.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateC_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCH_Num As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GridLookChangeType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CBegin_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CEnd_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CReMark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ChangeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChangeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popChange As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripBorrowReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ButtonLoadBnum1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBrrow As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ButtonLoadBnum2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtM_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPerNO2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ButtonM_CodeA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtM_CodeA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ButtonChangeAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtM_Code4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPerNO4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOReturn As DevExpress.XtraGrid.Columns.GridColumn
End Class
