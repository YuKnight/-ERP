<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
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
        Me.CBSendType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtQuoID = New DevExpress.XtraEditors.TextEdit
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuChange = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PurchaseChangeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseChangeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.PM_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.C_Price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PM_PurchaseQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PM_Qty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.C_Qty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.C_NoSendQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.S_Supplier = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.M_Gauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.C_Reason = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.IndexNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemCalcEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.CBEdit4 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CheckAction = New System.Windows.Forms.Label
        Me.CheckDate = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GridFile = New System.Windows.Forms.DataGridView
        Me.F_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_OldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.popFileShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popFileShowOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.CBSendType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuoID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuChange.SuspendLayout()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.CBEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popFileShow.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBSendType
        '
        Me.CBSendType.EnterMoveNextControl = True
        Me.CBSendType.Location = New System.Drawing.Point(93, 54)
        Me.CBSendType.Name = "CBSendType"
        Me.CBSendType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSendType.Properties.Appearance.Options.UseFont = True
        Me.CBSendType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBSendType.Properties.Items.AddRange(New Object() {"採購單"})
        Me.CBSendType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBSendType.Size = New System.Drawing.Size(139, 24)
        Me.CBSendType.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(604, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "暫收人:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(549, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "操作人："
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(358, 54)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(131, 22)
        Me.DateEdit1.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(269, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "更改日期(&D)："
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(6, 59)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "更改類型(&T)："
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(790, 36)
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "更改單"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(578, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 198
        Me.Label20.Text = "更改單號:"
        '
        'txtQuoID
        '
        Me.txtQuoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuoID.Location = New System.Drawing.Point(651, 9)
        Me.txtQuoID.Name = "txtQuoID"
        Me.txtQuoID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtQuoID.Properties.Appearance.Options.UseFont = True
        Me.txtQuoID.Size = New System.Drawing.Size(131, 22)
        Me.txtQuoID.TabIndex = 199
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.MenuChange
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(3, 3)
        Me.Grid.MainView = Me.AdvBandedGridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCalcEdit3, Me.RepositoryItemComboBox1, Me.RepositoryItemCalcEdit4, Me.RepositoryItemCalcEdit5, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCalcEdit2})
        Me.Grid.Size = New System.Drawing.Size(784, 258)
        Me.Grid.TabIndex = 200
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1, Me.GridView1})
        '
        'MenuChange
        '
        Me.MenuChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseChangeAdd, Me.PurchaseChangeDel})
        Me.MenuChange.Name = "MenuChange"
        Me.MenuChange.Size = New System.Drawing.Size(157, 48)
        '
        'PurchaseChangeAdd
        '
        Me.PurchaseChangeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.PurchaseChangeAdd.Name = "PurchaseChangeAdd"
        Me.PurchaseChangeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.PurchaseChangeAdd.Size = New System.Drawing.Size(156, 22)
        Me.PurchaseChangeAdd.Text = "添加(&A)..."
        '
        'PurchaseChangeDel
        '
        Me.PurchaseChangeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.PurchaseChangeDel.Name = "PurchaseChangeDel"
        Me.PurchaseChangeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.PurchaseChangeDel.Size = New System.Drawing.Size(156, 22)
        Me.PurchaseChangeDel.Text = "刪除(&D)"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.M_Unit, Me.C_NoSendQty, Me.C_Price, Me.IndexNO, Me.PM_NO, Me.C_Reason, Me.PM_Qty, Me.PM_PurchaseQty, Me.S_Supplier, Me.C_Qty})
        Me.AdvBandedGridView1.GridControl = Me.Grid
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsCustomization.AllowColumnMoving = False
        Me.AdvBandedGridView1.OptionsCustomization.AllowFilter = False
        Me.AdvBandedGridView1.OptionsCustomization.AllowSort = False
        Me.AdvBandedGridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.AdvBandedGridView1.OptionsFilter.AllowFilterEditor = False
        Me.AdvBandedGridView1.OptionsFilter.AllowMRUFilterList = False
        Me.AdvBandedGridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "基本信息"
        Me.GridBand1.Columns.Add(Me.PM_NO)
        Me.GridBand1.Columns.Add(Me.M_Code)
        Me.GridBand1.Columns.Add(Me.M_Name)
        Me.GridBand1.Columns.Add(Me.M_Unit)
        Me.GridBand1.Columns.Add(Me.C_Price)
        Me.GridBand1.Columns.Add(Me.PM_PurchaseQty)
        Me.GridBand1.Columns.Add(Me.PM_Qty)
        Me.GridBand1.Columns.Add(Me.C_Qty)
        Me.GridBand1.Columns.Add(Me.C_NoSendQty)
        Me.GridBand1.Columns.Add(Me.S_Supplier)
        Me.GridBand1.Columns.Add(Me.M_Gauge)
        Me.GridBand1.Columns.Add(Me.C_Reason)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 745
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.Width = 125
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.Width = 45
        '
        'C_Price
        '
        Me.C_Price.Caption = "單價"
        Me.C_Price.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.C_Price.FieldName = "C_Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.OptionsColumn.AllowEdit = False
        Me.C_Price.Visible = True
        Me.C_Price.Width = 60
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "f"
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'PM_PurchaseQty
        '
        Me.PM_PurchaseQty.Caption = "更改前採購數"
        Me.PM_PurchaseQty.FieldName = "PM_PurchaseQty"
        Me.PM_PurchaseQty.Name = "PM_PurchaseQty"
        Me.PM_PurchaseQty.OptionsColumn.ReadOnly = True
        Me.PM_PurchaseQty.Visible = True
        Me.PM_PurchaseQty.Width = 85
        '
        'PM_Qty
        '
        Me.PM_Qty.Caption = "更改前未交數"
        Me.PM_Qty.FieldName = "PM_Qty"
        Me.PM_Qty.Name = "PM_Qty"
        Me.PM_Qty.OptionsColumn.ReadOnly = True
        Me.PM_Qty.Visible = True
        Me.PM_Qty.Width = 85
        '
        'C_Qty
        '
        Me.C_Qty.Caption = "更改後採購數"
        Me.C_Qty.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.C_Qty.FieldName = "C_Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.Visible = True
        Me.C_Qty.Width = 85
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'C_NoSendQty
        '
        Me.C_NoSendQty.Caption = "更改後未交數"
        Me.C_NoSendQty.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.C_NoSendQty.FieldName = "C_NoSendQty"
        Me.C_NoSendQty.Name = "C_NoSendQty"
        Me.C_NoSendQty.Visible = True
        Me.C_NoSendQty.Width = 85
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商"
        Me.S_Supplier.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.OptionsColumn.AllowEdit = False
        Me.S_Supplier.RowIndex = 1
        Me.S_Supplier.Visible = True
        Me.S_Supplier.Width = 100
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("S_Supplier", "供應商編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("S_SupplierName", "供應商名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.RowIndex = 1
        Me.M_Gauge.Visible = True
        Me.M_Gauge.Width = 305
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'C_Reason
        '
        Me.C_Reason.Caption = "更改原因"
        Me.C_Reason.FieldName = "C_Reason"
        Me.C_Reason.Name = "C_Reason"
        Me.C_Reason.RowIndex = 1
        Me.C_Reason.Visible = True
        Me.C_Reason.Width = 340
        '
        'IndexNO
        '
        Me.IndexNO.Caption = "更改單流水號"
        Me.IndexNO.FieldName = "IndexNO"
        Me.IndexNO.Name = "IndexNO"
        Me.IndexNO.Visible = True
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"1天", "7天", "15天", "30天", "45天", "60天", "90天"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'RepositoryItemCalcEdit5
        '
        Me.RepositoryItemCalcEdit5.AutoHeight = False
        Me.RepositoryItemCalcEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit5.Name = "RepositoryItemCalcEdit5"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn1, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn10, Me.GridColumn13, Me.GridColumn9, Me.GridColumn24})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料編碼"
        Me.GridColumn2.FieldName = "M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 129
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料名稱"
        Me.GridColumn3.FieldName = "M_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 73
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "規格"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn1.FieldName = "M_Gauge"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 111
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "數量"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.GridColumn4.FieldName = "Q_Qty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 52
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "單位"
        Me.GridColumn5.FieldName = "M_Unit"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 43
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "單價"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn8.FieldName = "Q_Price"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 45
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "申請單號"
        Me.GridColumn10.FieldName = "PN_NO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 130
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "備註"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn13.FieldName = "Q_Depict"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 87
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "供應商編號"
        Me.GridColumn9.FieldName = "Q_SupplierNo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "交貨期限"
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn24.FieldName = "Q_RetrDate"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 9
        Me.GridColumn24.Width = 97
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 154)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(790, 296)
        Me.XtraTabControl1.TabIndex = 201
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.XtraTabControl1.TabStop = False
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(781, 264)
        Me.XtraTabPage1.Text = "物料明細"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.CBEdit4)
        Me.XtraTabPage2.Controls.Add(Me.CheckAction)
        Me.XtraTabPage2.Controls.Add(Me.CheckDate)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label2)
        Me.XtraTabPage2.Controls.Add(Me.Label6)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.CheckRemark)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(781, 264)
        Me.XtraTabPage2.Text = "審核"
        '
        'CBEdit4
        '
        Me.CBEdit4.Location = New System.Drawing.Point(100, 49)
        Me.CBEdit4.Name = "CBEdit4"
        Me.CBEdit4.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CBEdit4.Properties.Appearance.Options.UseFont = True
        Me.CBEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBEdit4.Properties.Items.AddRange(New Object() {"確認無誤", "無效"})
        Me.CBEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBEdit4.Size = New System.Drawing.Size(181, 24)
        Me.CBEdit4.TabIndex = 9
        '
        'CheckAction
        '
        Me.CheckAction.AutoSize = True
        Me.CheckAction.BackColor = System.Drawing.Color.Transparent
        Me.CheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckAction.ForeColor = System.Drawing.Color.Black
        Me.CheckAction.Location = New System.Drawing.Point(505, 52)
        Me.CheckAction.Name = "CheckAction"
        Me.CheckAction.Size = New System.Drawing.Size(56, 15)
        Me.CheckAction.TabIndex = 87
        Me.CheckAction.Text = "審核員:"
        '
        'CheckDate
        '
        Me.CheckDate.AutoSize = True
        Me.CheckDate.BackColor = System.Drawing.Color.Transparent
        Me.CheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckDate.ForeColor = System.Drawing.Color.Black
        Me.CheckDate.Location = New System.Drawing.Point(505, 20)
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Size = New System.Drawing.Size(71, 15)
        Me.CheckDate.TabIndex = 86
        Me.CheckDate.Text = "審核日期:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(100, 19)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "確認審核"
        Me.CheckEdit1.Size = New System.Drawing.Size(92, 21)
        Me.CheckEdit1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(432, 20)
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
        Me.Label8.Location = New System.Drawing.Point(447, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "審核員:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "備註(&L):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "審核類型(&Y):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(36, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "審核(&K):"
        '
        'CheckRemark
        '
        Me.CheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckRemark.Location = New System.Drawing.Point(100, 86)
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckRemark.Properties.Appearance.Options.UseFont = True
        Me.CheckRemark.Size = New System.Drawing.Size(533, 127)
        Me.CheckRemark.TabIndex = 11
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridFile)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(781, 264)
        Me.XtraTabPage3.Text = "查看附檔"
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
        Me.GridFile.Size = New System.Drawing.Size(781, 264)
        Me.GridFile.TabIndex = 12
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
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(552, 456)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(101, 27)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(684, 456)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(101, 27)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "取消(&C)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(143, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "備注(&R)："
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.Location = New System.Drawing.Point(93, 92)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(696, 50)
        Me.MemoEdit1.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(186, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 208
        Me.Label12.Text = "更改類別"
        Me.Label12.Visible = False
        '
        'frmChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 494)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Controls.Add(Me.txtQuoID)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CBSendType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmChange"
        CType(Me.CBSendType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuoID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuChange.ResumeLayout(False)
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.CBEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popFileShow.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBSendType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtQuoID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents C_NoSendQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents C_Price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CBEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckAction As System.Windows.Forms.Label
    Friend WithEvents CheckDate As System.Windows.Forms.Label
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuChange As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PurchaseChangeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseChangeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IndexNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents C_Reason As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PM_Qty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PM_PurchaseQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridFile As System.Windows.Forms.DataGridView
    Friend WithEvents F_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popFileShow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popFileShowOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents C_Qty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
