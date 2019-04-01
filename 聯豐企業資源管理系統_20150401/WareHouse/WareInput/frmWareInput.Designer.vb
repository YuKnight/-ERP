<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareInput
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.txtWIPID = New DevExpress.XtraEditors.TextEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.popWareInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripBatchLoad = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputBatchAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputBarAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MCodeText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.WIP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.WareInvent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ButtonEdit2 = New DevExpress.XtraEditors.ButtonEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.CheckAction = New System.Windows.Forms.Label
        Me.CheckDate = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.RecheckAction = New System.Windows.Forms.Label
        Me.RecheckDate = New System.Windows.Forms.Label
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.RecheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridFile = New System.Windows.Forms.DataGridView
        Me.F_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_OldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.popFileShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popFileShowOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnRefCard = New DevExpress.XtraEditors.SimpleButton
        Me.txtCardID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelMsg = New DevExpress.XtraEditors.LabelControl
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtRC_NO = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWIPID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareInput.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popFileShow.SuspendLayout()
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRC_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWH
        '
        Me.txtWH.Location = New System.Drawing.Point(99, 19)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(120, 22)
        Me.txtWH.TabIndex = 1
        '
        'txtWIPID
        '
        Me.txtWIPID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWIPID.Location = New System.Drawing.Point(725, 9)
        Me.txtWIPID.Name = "txtWIPID"
        Me.txtWIPID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWIPID.Properties.Appearance.Options.UseFont = True
        Me.txtWIPID.Properties.ReadOnly = True
        Me.txtWIPID.Size = New System.Drawing.Size(121, 22)
        Me.txtWIPID.TabIndex = 154
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(99, 53)
        Me.DateEdit1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(120, 22)
        Me.DateEdit1.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "入庫日期(&E)："
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(13, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "倉       庫(&W)："
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(657, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "入庫單號："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "入庫單"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(855, 36)
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'cmdBarCode
        '
        Me.cmdBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBarCode.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdBarCode.Appearance.Options.UseFont = True
        Me.cmdBarCode.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.cmdBarCode.Location = New System.Drawing.Point(4, 504)
        Me.cmdBarCode.Name = "cmdBarCode"
        Me.cmdBarCode.Size = New System.Drawing.Size(99, 25)
        Me.cmdBarCode.TabIndex = 18
        Me.cmdBarCode.Text = "打印條碼(&P)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(685, 504)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(780, 504)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "取消(&C)"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.popWareInput
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RemarkItemMemoExEdit1, Me.QtyItemCalcEdit, Me.RepositoryItemCheckEdit1, Me.RepositoryItemButtonEdit2, Me.MCodeText, Me.RepositoryItemTextEdit2})
        Me.Grid.Size = New System.Drawing.Size(840, 333)
        Me.Grid.TabIndex = 160
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareInput
        '
        Me.popWareInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBatchLoad, Me.popWareInputAdd, Me.popWareInputBatchAdd, Me.popWareInputDel, Me.popWareInputBarAdd})
        Me.popWareInput.Name = "popWareInput"
        Me.popWareInput.Size = New System.Drawing.Size(179, 114)
        '
        'ToolStripBatchLoad
        '
        Me.ToolStripBatchLoad.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripBatchLoad.Name = "ToolStripBatchLoad"
        Me.ToolStripBatchLoad.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToolStripBatchLoad.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripBatchLoad.Text = "批量新增(&B)"
        '
        'popWareInputAdd
        '
        Me.popWareInputAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareInputAdd.Name = "popWareInputAdd"
        Me.popWareInputAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareInputAdd.Size = New System.Drawing.Size(178, 22)
        Me.popWareInputAdd.Text = "新增(&A)..."
        '
        'popWareInputBatchAdd
        '
        Me.popWareInputBatchAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.popWareInputBatchAdd.Name = "popWareInputBatchAdd"
        Me.popWareInputBatchAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.popWareInputBatchAdd.Size = New System.Drawing.Size(178, 22)
        Me.popWareInputBatchAdd.Text = "批次導入(&L)..."
        Me.popWareInputBatchAdd.Visible = False
        '
        'popWareInputDel
        '
        Me.popWareInputDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareInputDel.Name = "popWareInputDel"
        Me.popWareInputDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareInputDel.Size = New System.Drawing.Size(178, 22)
        Me.popWareInputDel.Text = "刪除(&D)"
        '
        'popWareInputBarAdd
        '
        Me.popWareInputBarAdd.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.popWareInputBarAdd.Name = "popWareInputBarAdd"
        Me.popWareInputBarAdd.Size = New System.Drawing.Size(178, 22)
        Me.popWareInputBarAdd.Text = "掃描條碼(&S)..."
        Me.popWareInputBarAdd.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WIP_Qty, Me.WareInvent, Me.M_Unit, Me.WIP_Remark, Me.OS_BatchID, Me.GridColumn1, Me.PM_M_Code})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.ColumnEdit = Me.MCodeText
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 125
        '
        'MCodeText
        '
        Me.MCodeText.AutoHeight = False
        Me.MCodeText.Name = "MCodeText"
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 73
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 150
        '
        'RemarkItemMemoExEdit1
        '
        Me.RemarkItemMemoExEdit1.AutoHeight = False
        Me.RemarkItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkItemMemoExEdit1.Name = "RemarkItemMemoExEdit1"
        Me.RemarkItemMemoExEdit1.ShowIcon = False
        '
        'WIP_Qty
        '
        Me.WIP_Qty.Caption = "數量"
        Me.WIP_Qty.ColumnEdit = Me.QtyItemCalcEdit
        Me.WIP_Qty.FieldName = "WIP_Qty"
        Me.WIP_Qty.Name = "WIP_Qty"
        Me.WIP_Qty.ToolTip = "按Enter鍵，焦點回到物料編碼輸入框。"
        Me.WIP_Qty.Visible = True
        Me.WIP_Qty.VisibleIndex = 5
        Me.WIP_Qty.Width = 60
        '
        'QtyItemCalcEdit
        '
        Me.QtyItemCalcEdit.AutoHeight = False
        Me.QtyItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyItemCalcEdit.Name = "QtyItemCalcEdit"
        '
        'WareInvent
        '
        Me.WareInvent.Caption = "庫存"
        Me.WareInvent.FieldName = "WareInvent"
        Me.WareInvent.Name = "WareInvent"
        Me.WareInvent.OptionsColumn.ReadOnly = True
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 4
        Me.M_Unit.Width = 45
        '
        'WIP_Remark
        '
        Me.WIP_Remark.Caption = "備註"
        Me.WIP_Remark.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.WIP_Remark.FieldName = "WIP_Remark"
        Me.WIP_Remark.Name = "WIP_Remark"
        Me.WIP_Remark.Visible = True
        Me.WIP_Remark.VisibleIndex = 6
        Me.WIP_Remark.Width = 130
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 3
        Me.OS_BatchID.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "WIP_NUM"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ButtonEdit2
        '
        Me.ButtonEdit2.Location = New System.Drawing.Point(322, 19)
        Me.ButtonEdit2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.ButtonEdit2.Name = "ButtonEdit2"
        Me.ButtonEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit2.Properties.Appearance.Options.UseFont = True
        Me.ButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ButtonEdit2.Size = New System.Drawing.Size(120, 22)
        Me.ButtonEdit2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(233, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "部         門(&D)："
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 138)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(849, 365)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(840, 333)
        Me.XtraTabPage1.Text = "物料明細"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.CheckAction)
        Me.XtraTabPage2.Controls.Add(Me.CheckDate)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.CheckRemark)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(763, 333)
        Me.XtraTabPage2.Text = "審核"
        '
        'CheckAction
        '
        Me.CheckAction.AutoSize = True
        Me.CheckAction.BackColor = System.Drawing.Color.Transparent
        Me.CheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckAction.ForeColor = System.Drawing.Color.Black
        Me.CheckAction.Location = New System.Drawing.Point(307, 27)
        Me.CheckAction.Name = "CheckAction"
        Me.CheckAction.Size = New System.Drawing.Size(71, 15)
        Me.CheckAction.TabIndex = 87
        Me.CheckAction.Text = "審核日期:"
        '
        'CheckDate
        '
        Me.CheckDate.AutoSize = True
        Me.CheckDate.BackColor = System.Drawing.Color.Transparent
        Me.CheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckDate.ForeColor = System.Drawing.Color.Black
        Me.CheckDate.Location = New System.Drawing.Point(506, 27)
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Size = New System.Drawing.Size(71, 15)
        Me.CheckDate.TabIndex = 86
        Me.CheckDate.Text = "審核日期:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(83, 25)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "確認審核"
        Me.CheckEdit1.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(432, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "審核日期:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(248, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "審核員:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "備註(&R):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "審核(&K):"
        '
        'CheckRemark
        '
        Me.CheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckRemark.Location = New System.Drawing.Point(83, 67)
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckRemark.Properties.Appearance.Options.UseFont = True
        Me.CheckRemark.Size = New System.Drawing.Size(561, 161)
        Me.CheckRemark.TabIndex = 12
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.RecheckAction)
        Me.XtraTabPage3.Controls.Add(Me.RecheckDate)
        Me.XtraTabPage3.Controls.Add(Me.CheckEdit2)
        Me.XtraTabPage3.Controls.Add(Me.Label6)
        Me.XtraTabPage3.Controls.Add(Me.Label12)
        Me.XtraTabPage3.Controls.Add(Me.Label13)
        Me.XtraTabPage3.Controls.Add(Me.Label14)
        Me.XtraTabPage3.Controls.Add(Me.RecheckRemark)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(763, 333)
        Me.XtraTabPage3.Text = "復核信息"
        '
        'RecheckAction
        '
        Me.RecheckAction.AutoSize = True
        Me.RecheckAction.BackColor = System.Drawing.Color.Transparent
        Me.RecheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RecheckAction.ForeColor = System.Drawing.Color.Black
        Me.RecheckAction.Location = New System.Drawing.Point(310, 28)
        Me.RecheckAction.Name = "RecheckAction"
        Me.RecheckAction.Size = New System.Drawing.Size(52, 15)
        Me.RecheckAction.TabIndex = 95
        Me.RecheckAction.Text = "復核員"
        '
        'RecheckDate
        '
        Me.RecheckDate.AutoSize = True
        Me.RecheckDate.BackColor = System.Drawing.Color.Transparent
        Me.RecheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RecheckDate.ForeColor = System.Drawing.Color.Black
        Me.RecheckDate.Location = New System.Drawing.Point(488, 27)
        Me.RecheckDate.Name = "RecheckDate"
        Me.RecheckDate.Size = New System.Drawing.Size(67, 15)
        Me.RecheckDate.TabIndex = 94
        Me.RecheckDate.Text = "復核日期"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(81, 27)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "確認復核"
        Me.CheckEdit2.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(413, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "復核日期:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(248, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "復核員:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "備註(&R):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "復核(&K):"
        '
        'RecheckRemark
        '
        Me.RecheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecheckRemark.Location = New System.Drawing.Point(81, 63)
        Me.RecheckRemark.Name = "RecheckRemark"
        Me.RecheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RecheckRemark.Properties.Appearance.Options.UseFont = True
        Me.RecheckRemark.Size = New System.Drawing.Size(563, 161)
        Me.RecheckRemark.TabIndex = 16
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridFile)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(763, 333)
        Me.XtraTabPage4.Text = "附檔信息"
        '
        'GridFile
        '
        Me.GridFile.AllowUserToAddRows = False
        Me.GridFile.AllowUserToDeleteRows = False
        Me.GridFile.AllowUserToResizeRows = False
        Me.GridFile.BackgroundColor = System.Drawing.Color.White
        Me.GridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F_No, Me.F_OldName, Me.F_Name, Me.F_Detail, Me.F_AddDate, Me.F_Action})
        Me.GridFile.ContextMenuStrip = Me.popFileShow
        Me.GridFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridFile.EnableHeadersVisualStyles = False
        Me.GridFile.GridColor = System.Drawing.Color.Silver
        Me.GridFile.Location = New System.Drawing.Point(0, 0)
        Me.GridFile.MultiSelect = False
        Me.GridFile.Name = "GridFile"
        Me.GridFile.ReadOnly = True
        Me.GridFile.RowTemplate.Height = 24
        Me.GridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridFile.Size = New System.Drawing.Size(763, 333)
        Me.GridFile.TabIndex = 17
        '
        'F_No
        '
        Me.F_No.DataPropertyName = "F_No"
        Me.F_No.HeaderText = "文件編號"
        Me.F_No.Name = "F_No"
        Me.F_No.ReadOnly = True
        '
        'F_OldName
        '
        Me.F_OldName.DataPropertyName = "F_OldName"
        Me.F_OldName.HeaderText = "文件名"
        Me.F_OldName.Name = "F_OldName"
        Me.F_OldName.ReadOnly = True
        '
        'F_Name
        '
        Me.F_Name.DataPropertyName = "F_Name"
        Me.F_Name.HeaderText = "文件名稱"
        Me.F_Name.Name = "F_Name"
        Me.F_Name.ReadOnly = True
        '
        'F_Detail
        '
        Me.F_Detail.DataPropertyName = "F_Detail"
        Me.F_Detail.HeaderText = "文件內容"
        Me.F_Detail.Name = "F_Detail"
        Me.F_Detail.ReadOnly = True
        Me.F_Detail.Width = 300
        '
        'F_AddDate
        '
        Me.F_AddDate.DataPropertyName = "F_AddDate"
        Me.F_AddDate.HeaderText = "上傳日期"
        Me.F_AddDate.Name = "F_AddDate"
        Me.F_AddDate.ReadOnly = True
        '
        'F_Action
        '
        Me.F_Action.DataPropertyName = "F_Action"
        Me.F_Action.HeaderText = "操作員"
        Me.F_Action.Name = "F_Action"
        Me.F_Action.ReadOnly = True
        Me.F_Action.Width = 80
        '
        'popFileShow
        '
        Me.popFileShow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popFileShowOpen})
        Me.popFileShow.Name = "popFileShow"
        Me.popFileShow.Size = New System.Drawing.Size(157, 26)
        '
        'popFileShowOpen
        '
        Me.popFileShowOpen.Image = Global.LFERP.My.Resources.Resources.folder_documents_blue_icon
        Me.popFileShowOpen.Name = "popFileShowOpen"
        Me.popFileShowOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.popFileShowOpen.Size = New System.Drawing.Size(156, 22)
        Me.popFileShowOpen.Text = "打開(&O)..."
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(285, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "類型"
        Me.Label3.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Location = New System.Drawing.Point(582, 504)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 25)
        Me.cmdPrint.TabIndex = 19
        Me.cmdPrint.Text = "入庫單(&I)"
        Me.cmdPrint.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "類型(&T)："
        '
        'cbType
        '
        Me.cbType.Location = New System.Drawing.Point(508, 20)
        Me.cbType.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.cbType.Name = "cbType"
        Me.cbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbType.Properties.Items.AddRange(New Object() {"正常", "退貨", "生產退料"})
        Me.cbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbType.Size = New System.Drawing.Size(120, 21)
        Me.cbType.TabIndex = 5
        '
        'btnRefCard
        '
        Me.btnRefCard.Location = New System.Drawing.Point(232, 6)
        Me.btnRefCard.Name = "btnRefCard"
        Me.btnRefCard.Size = New System.Drawing.Size(55, 24)
        Me.btnRefCard.TabIndex = 165
        Me.btnRefCard.Text = "刷卡(&L)"
        '
        'txtCardID
        '
        Me.txtCardID.Location = New System.Drawing.Point(293, 7)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardID.Properties.Appearance.Options.UseFont = True
        Me.txtCardID.Properties.ReadOnly = True
        Me.txtCardID.Size = New System.Drawing.Size(143, 22)
        Me.txtCardID.TabIndex = 166
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtRC_NO)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LabelMsg)
        Me.GroupBox1.Controls.Add(Me.txtM_Code)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.DateEdit1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 90)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        '
        'LabelMsg
        '
        Me.LabelMsg.Location = New System.Drawing.Point(616, 56)
        Me.LabelMsg.Name = "LabelMsg"
        Me.LabelMsg.Size = New System.Drawing.Size(21, 14)
        Me.LabelMsg.TabIndex = 195
        Me.LabelMsg.Text = "***"
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(322, 53)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Size = New System.Drawing.Size(180, 21)
        ToolTipTitleItem2.Text = "提示"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "焦點在物料編碼框輸入中：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下Home鍵，焦點移到表格焦點行數量單元格中；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下PageUp鍵，表格中焦點行數量加一；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下PageDown鍵，表格中焦點行" & _
            "數量減一；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下向上的方向鍵，表格中焦點行上移一行，並且焦點落在數量單元格中；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下向下的方向鍵，表格中焦點行下移一行，並且焦點落在數量單元格中。"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtM_Code.SuperTip = SuperToolTip2
        Me.txtM_Code.TabIndex = 9
        Me.txtM_Code.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(506, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl1.TabIndex = 194
        Me.LabelControl1.Text = "(可掃描條碼輸入)"
        Me.LabelControl1.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(232, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "物料編碼(&M)："
        Me.Label24.Visible = False
        '
        'txtRC_NO
        '
        Me.txtRC_NO.Location = New System.Drawing.Point(704, 19)
        Me.txtRC_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRC_NO.Name = "txtRC_NO"
        Me.txtRC_NO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRC_NO.Properties.Appearance.Options.UseFont = True
        Me.txtRC_NO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRC_NO.Size = New System.Drawing.Size(120, 22)
        Me.txtRC_NO.TabIndex = 197
        Me.txtRC_NO.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(638, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 196
        Me.Label16.Text = "退料單號:"
        Me.Label16.Visible = False
        '
        'frmWareInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(858, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCardID)
        Me.Controls.Add(Me.btnRefCard)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdBarCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtWIPID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareInput"
        Me.ShowIcon = False
        Me.Text = "入庫單"
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWIPID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareInput.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popFileShow.ResumeLayout(False)
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRC_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtWIPID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents WIP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ButtonEdit2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInputAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputBarAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckAction As System.Windows.Forms.Label
    Friend WithEvents CheckDate As System.Windows.Forms.Label
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MCodeText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents popFileShow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popFileShowOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputBatchAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents RecheckAction As System.Windows.Forms.Label
    Friend WithEvents RecheckDate As System.Windows.Forms.Label
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RecheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridFile As System.Windows.Forms.DataGridView
    Friend WithEvents F_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WareInvent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripBatchLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRC_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
