<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.popPurchase = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPurchaseAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popApplyAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchaseDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popPurchaseCode = New System.Windows.Forms.ToolStripMenuItem
        Me.popPurchasefujian = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.S_SupplierNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Q_QuoID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.QuoIDbutton = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.GridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.subaccount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.PN_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.AP_Num = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Q_StandardPack = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Q_MOQ = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.QuoIDLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Q_QuoID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_SupplierNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.CBEdit4 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CheckAction = New System.Windows.Forms.Label
        Me.CheckDate = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.ACheckType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ACAction = New System.Windows.Forms.Label
        Me.ACdate = New System.Windows.Forms.Label
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.lueCurrency = New DevExpress.XtraEditors.LookUpEdit
        Me.gluSupplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPMID = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.gluCompany = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.TarriffEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtRebate = New DevExpress.XtraEditors.CalcEdit
        Me.cboName = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popPurchase.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoIDbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoIDLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.CBEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.ACheckType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popFileShow.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPMID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarriffEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRebate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "采購單"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(746, 36)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(513, 490)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(101, 27)
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(646, 490)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(101, 27)
        Me.cmdExit.TabIndex = 35
        Me.cmdExit.Text = "取消(&C)"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 181)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(743, 309)
        Me.XtraTabControl1.TabIndex = 89
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(734, 277)
        Me.XtraTabPage1.Text = "物料明細"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.popPurchase
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemMemoExEdit1, Me.QuoIDLookUpEdit1, Me.GridLookUpEdit1, Me.QuoIDbutton})
        Me.Grid.Size = New System.Drawing.Size(734, 277)
        Me.Grid.TabIndex = 70
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popPurchase
        '
        Me.popPurchase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPurchaseAdd, Me.popApplyAdd, Me.popPurchaseDel, Me.ToolStripSeparator1, Me.popPurchaseCode, Me.popPurchasefujian})
        Me.popPurchase.Name = "popQuotation"
        Me.popPurchase.Size = New System.Drawing.Size(191, 120)
        '
        'popPurchaseAdd
        '
        Me.popPurchaseAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPurchaseAdd.Name = "popPurchaseAdd"
        Me.popPurchaseAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPurchaseAdd.Size = New System.Drawing.Size(190, 22)
        Me.popPurchaseAdd.Text = "添加(&A)..."
        '
        'popApplyAdd
        '
        Me.popApplyAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.popApplyAdd.Name = "popApplyAdd"
        Me.popApplyAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popApplyAdd.Size = New System.Drawing.Size(190, 22)
        Me.popApplyAdd.Text = "添加申購單(&T)..."
        '
        'popPurchaseDel
        '
        Me.popPurchaseDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popPurchaseDel.Name = "popPurchaseDel"
        Me.popPurchaseDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPurchaseDel.Size = New System.Drawing.Size(190, 22)
        Me.popPurchaseDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'popPurchaseCode
        '
        Me.popPurchaseCode.Image = Global.LFERP.My.Resources.Resources.AdvancedFileProperties
        Me.popPurchaseCode.Name = "popPurchaseCode"
        Me.popPurchaseCode.Size = New System.Drawing.Size(190, 22)
        Me.popPurchaseCode.Text = "當前物料信息(&M)..."
        '
        'popPurchasefujian
        '
        Me.popPurchasefujian.Image = Global.LFERP.My.Resources.Resources._123
        Me.popPurchasefujian.Name = "popPurchasefujian"
        Me.popPurchasefujian.Size = New System.Drawing.Size(190, 22)
        Me.popPurchasefujian.Text = "當前物料附件(&Q)..."
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2, Me.GridBand3, Me.GridBand4})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.AP_Num, Me.M_Code, Me.GridColumn3, Me.GridColumn1, Me.GridColumn10, Me.PM_M_Code, Me.Q_QuoID, Me.S_SupplierNo, Me.GridColumn8, Me.GridColumn4, Me.GridColumn5, Me.GridColumn13, Me.GridColumn11, Me.PN_NO, Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.subaccount, Me.Q_StandardPack, Me.Q_MOQ})
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
        'GridBand2
        '
        Me.GridBand2.Caption = "物料信息"
        Me.GridBand2.Columns.Add(Me.M_Code)
        Me.GridBand2.Columns.Add(Me.GridColumn3)
        Me.GridBand2.Columns.Add(Me.GridColumn1)
        Me.GridBand2.Columns.Add(Me.GridColumn10)
        Me.GridBand2.Columns.Add(Me.PM_M_Code)
        Me.GridBand2.Columns.Add(Me.S_SupplierNo)
        Me.GridBand2.Columns.Add(Me.GridColumn5)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.OptionsBand.AllowMove = False
        Me.GridBand2.OptionsBand.AllowSize = False
        Me.GridBand2.Width = 406
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.Width = 123
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料名稱"
        Me.GridColumn3.FieldName = "M_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.Width = 93
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "規格"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn1.FieldName = "M_Gauge"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 190
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "批次編號"
        Me.GridColumn10.FieldName = "OS_BatchID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.RowIndex = 1
        Me.GridColumn10.Visible = True
        Me.GridColumn10.Width = 106
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.RowIndex = 1
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.Width = 80
        '
        'S_SupplierNo
        '
        Me.S_SupplierNo.Caption = "供應商編號"
        Me.S_SupplierNo.FieldName = "S_SupplierNo"
        Me.S_SupplierNo.Name = "S_SupplierNo"
        Me.S_SupplierNo.OptionsColumn.ReadOnly = True
        Me.S_SupplierNo.RowIndex = 1
        Me.S_SupplierNo.Visible = True
        Me.S_SupplierNo.Width = 122
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "單位"
        Me.GridColumn5.FieldName = "M_Unit"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.RowIndex = 1
        Me.GridColumn5.Visible = True
        Me.GridColumn5.Width = 40
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "採購資料"
        Me.GridBand3.Columns.Add(Me.Q_QuoID)
        Me.GridBand3.Columns.Add(Me.GridColumn8)
        Me.GridBand3.Columns.Add(Me.GridColumn4)
        Me.GridBand3.Columns.Add(Me.subaccount)
        Me.GridBand3.Columns.Add(Me.GridColumn11)
        Me.GridBand3.Columns.Add(Me.GridColumn13)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.OptionsBand.AllowMove = False
        Me.GridBand3.OptionsBand.AllowSize = False
        Me.GridBand3.Width = 341
        '
        'Q_QuoID
        '
        Me.Q_QuoID.Caption = "報價單號"
        Me.Q_QuoID.ColumnEdit = Me.QuoIDbutton
        Me.Q_QuoID.FieldName = "Q_QuoID"
        Me.Q_QuoID.Name = "Q_QuoID"
        Me.Q_QuoID.Visible = True
        Me.Q_QuoID.Width = 126
        '
        'QuoIDbutton
        '
        Me.QuoIDbutton.AutoHeight = False
        Me.QuoIDbutton.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.QuoIDbutton.Name = "QuoIDbutton"
        Me.QuoIDbutton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "單價"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn8.FieldName = "PS_Price"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.Width = 80
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "采購數量"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn4.FieldName = "PS_Qty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.Width = 60
        '
        'subaccount
        '
        Me.subaccount.Caption = "小計"
        Me.subaccount.FieldName = "subaccount"
        Me.subaccount.Name = "subaccount"
        Me.subaccount.OptionsColumn.ReadOnly = True
        Me.subaccount.Visible = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "交貨日期"
        Me.GridColumn11.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn11.FieldName = "PS_SendDate"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.RowIndex = 1
        Me.GridColumn11.Visible = True
        Me.GridColumn11.Width = 78
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "要求描述"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn13.FieldName = "PS_Depict"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.RowIndex = 1
        Me.GridColumn13.Visible = True
        Me.GridColumn13.Width = 131
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "附加資料"
        Me.GridBand4.Columns.Add(Me.PN_NO)
        Me.GridBand4.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand4.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand4.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.OptionsBand.AllowMove = False
        Me.GridBand4.OptionsBand.AllowSize = False
        Me.GridBand4.Width = 149
        '
        'PN_NO
        '
        Me.PN_NO.Caption = "申購單號"
        Me.PN_NO.FieldName = "PN_NO"
        Me.PN_NO.Name = "PN_NO"
        Me.PN_NO.Visible = True
        Me.PN_NO.Width = 79
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "申購人"
        Me.BandedGridColumn2.FieldName = "U_ID"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 70
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "申購部門"
        Me.BandedGridColumn1.FieldName = "DPT_ID"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.RowIndex = 1
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 79
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "申購用途"
        Me.BandedGridColumn3.FieldName = "PS_NeedPurchaseUse"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.RowIndex = 1
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 70
        '
        'AP_Num
        '
        Me.AP_Num.Caption = "申購單物料"
        Me.AP_Num.FieldName = "AP_Num"
        Me.AP_Num.Name = "AP_Num"
        '
        'Q_StandardPack
        '
        Me.Q_StandardPack.Caption = "最小包裝"
        Me.Q_StandardPack.FieldName = "Q_StandardPack"
        Me.Q_StandardPack.Name = "Q_StandardPack"
        '
        'Q_MOQ
        '
        Me.Q_MOQ.Caption = "最小訂購"
        Me.Q_MOQ.FieldName = "Q_MOQ"
        Me.Q_MOQ.Name = "Q_MOQ"
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
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"採購中", "送貨中", "完成"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'QuoIDLookUpEdit1
        '
        Me.QuoIDLookUpEdit1.AutoHeight = False
        Me.QuoIDLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuoIDLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Q_QuoID", "報價單", 60), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Q_SupplierNo", "供應商編號", 30), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Q_Price", "單價", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.QuoIDLookUpEdit1.Name = "QuoIDLookUpEdit1"
        Me.QuoIDLookUpEdit1.NullText = ""
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.AutoHeight = False
        Me.GridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.DisplayMember = "Q_QuoID"
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.NullText = ""
        Me.GridLookUpEdit1.ValueMember = "Q_QuoID"
        Me.GridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Q_QuoID1, Me.Q_SupplierNo, Me.Q_Price})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Q_QuoID1
        '
        Me.Q_QuoID1.Caption = "報價單"
        Me.Q_QuoID1.FieldName = "Q_QuoID"
        Me.Q_QuoID1.Name = "Q_QuoID1"
        Me.Q_QuoID1.Visible = True
        Me.Q_QuoID1.VisibleIndex = 0
        Me.Q_QuoID1.Width = 40
        '
        'Q_SupplierNo
        '
        Me.Q_SupplierNo.Caption = "供應商編號"
        Me.Q_SupplierNo.FieldName = "Q_SupplierNo"
        Me.Q_SupplierNo.Name = "Q_SupplierNo"
        Me.Q_SupplierNo.Visible = True
        Me.Q_SupplierNo.VisibleIndex = 1
        Me.Q_SupplierNo.Width = 40
        '
        'Q_Price
        '
        Me.Q_Price.Caption = "單價"
        Me.Q_Price.FieldName = "Q_Price"
        Me.Q_Price.Name = "Q_Price"
        Me.Q_Price.Visible = True
        Me.Q_Price.VisibleIndex = 2
        Me.Q_Price.Width = 20
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.CBEdit4)
        Me.XtraTabPage2.Controls.Add(Me.CheckAction)
        Me.XtraTabPage2.Controls.Add(Me.CheckDate)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Controls.Add(Me.Label6)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.CheckRemark)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(734, 277)
        Me.XtraTabPage2.Text = "部門審核"
        '
        'CBEdit4
        '
        Me.CBEdit4.Location = New System.Drawing.Point(97, 45)
        Me.CBEdit4.Name = "CBEdit4"
        Me.CBEdit4.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CBEdit4.Properties.Appearance.Options.UseFont = True
        Me.CBEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBEdit4.Properties.Items.AddRange(New Object() {"確認無誤", "待覆", "無效"})
        Me.CBEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBEdit4.Size = New System.Drawing.Size(179, 24)
        Me.CBEdit4.TabIndex = 25
        '
        'CheckAction
        '
        Me.CheckAction.AutoSize = True
        Me.CheckAction.BackColor = System.Drawing.Color.Transparent
        Me.CheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckAction.ForeColor = System.Drawing.Color.Black
        Me.CheckAction.Location = New System.Drawing.Point(603, 54)
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
        Me.CheckDate.Location = New System.Drawing.Point(605, 22)
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Size = New System.Drawing.Size(71, 15)
        Me.CheckDate.TabIndex = 86
        Me.CheckDate.Text = "審核日期:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(95, 18)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "確認"
        Me.CheckEdit1.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit1.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(528, 22)
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
        Me.Label8.Location = New System.Drawing.Point(529, 54)
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
        Me.Label7.Location = New System.Drawing.Point(36, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "備註(&Z):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "審核類型(&T):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "審核(&K):"
        '
        'CheckRemark
        '
        Me.CheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckRemark.Location = New System.Drawing.Point(97, 77)
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckRemark.Properties.Appearance.Options.UseFont = True
        Me.CheckRemark.Size = New System.Drawing.Size(631, 127)
        Me.CheckRemark.TabIndex = 27
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ACheckType)
        Me.XtraTabPage3.Controls.Add(Me.ACAction)
        Me.XtraTabPage3.Controls.Add(Me.ACdate)
        Me.XtraTabPage3.Controls.Add(Me.CheckEdit2)
        Me.XtraTabPage3.Controls.Add(Me.Label12)
        Me.XtraTabPage3.Controls.Add(Me.Label13)
        Me.XtraTabPage3.Controls.Add(Me.Label14)
        Me.XtraTabPage3.Controls.Add(Me.Label15)
        Me.XtraTabPage3.Controls.Add(Me.Label16)
        Me.XtraTabPage3.Controls.Add(Me.MemoEdit2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(734, 277)
        Me.XtraTabPage3.Text = "會計部審核"
        '
        'ACheckType
        '
        Me.ACheckType.Location = New System.Drawing.Point(98, 45)
        Me.ACheckType.Name = "ACheckType"
        Me.ACheckType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ACheckType.Properties.Appearance.Options.UseFont = True
        Me.ACheckType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ACheckType.Properties.Items.AddRange(New Object() {"確認無誤", "待覆", "無效"})
        Me.ACheckType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ACheckType.Size = New System.Drawing.Size(181, 24)
        Me.ACheckType.TabIndex = 31
        '
        'ACAction
        '
        Me.ACAction.AutoSize = True
        Me.ACAction.BackColor = System.Drawing.Color.Transparent
        Me.ACAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ACAction.ForeColor = System.Drawing.Color.Black
        Me.ACAction.Location = New System.Drawing.Point(603, 54)
        Me.ACAction.Name = "ACAction"
        Me.ACAction.Size = New System.Drawing.Size(71, 15)
        Me.ACAction.TabIndex = 95
        Me.ACAction.Text = "審核日期:"
        '
        'ACdate
        '
        Me.ACdate.AutoSize = True
        Me.ACdate.BackColor = System.Drawing.Color.Transparent
        Me.ACdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ACdate.ForeColor = System.Drawing.Color.Black
        Me.ACdate.Location = New System.Drawing.Point(605, 22)
        Me.ACdate.Name = "ACdate"
        Me.ACdate.Size = New System.Drawing.Size(71, 15)
        Me.ACdate.TabIndex = 94
        Me.ACdate.Text = "審核日期:"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(96, 18)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "資料是否無誤"
        Me.CheckEdit2.Size = New System.Drawing.Size(99, 19)
        Me.CheckEdit2.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(528, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "審核日期:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(529, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "審核員:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(36, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "備註(&Z):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "審核類型(&T):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(35, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "審核(&K):"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit2.Location = New System.Drawing.Point(98, 77)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MemoEdit2.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit2.Size = New System.Drawing.Size(630, 127)
        Me.MemoEdit2.TabIndex = 33
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridFile)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(734, 277)
        Me.XtraTabPage4.Text = "查看附件"
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
        Me.GridFile.Size = New System.Drawing.Size(734, 277)
        Me.GridFile.TabIndex = 83
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "公司(&Y):"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(301, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "聯系人(&N):"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(376, 44)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(157, 24)
        Me.DateEdit1.TabIndex = 3
        '
        'lueCurrency
        '
        Me.lueCurrency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueCurrency.Location = New System.Drawing.Point(631, 72)
        Me.lueCurrency.Name = "lueCurrency"
        Me.lueCurrency.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueCurrency.Properties.Appearance.Options.UseFont = True
        Me.lueCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("C_ID", "貨幣編號", 17), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("C_Name", "貨幣名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueCurrency.Properties.DisplayMember = "C_ID"
        Me.lueCurrency.Properties.NullText = ""
        Me.lueCurrency.Properties.ValueMember = "C_ID"
        Me.lueCurrency.Size = New System.Drawing.Size(116, 24)
        Me.lueCurrency.TabIndex = 11
        '
        'gluSupplier
        '
        Me.gluSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gluSupplier.EditValue = ""
        Me.gluSupplier.Location = New System.Drawing.Point(95, 72)
        Me.gluSupplier.Name = "gluSupplier"
        Me.gluSupplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluSupplier.Properties.Appearance.Options.UseFont = True
        Me.gluSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSupplier.Properties.NullText = ""
        Me.gluSupplier.Properties.View = Me.GridLookUpEdit1View
        Me.gluSupplier.Size = New System.Drawing.Size(183, 24)
        Me.gluSupplier.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.EditValue = ""
        Me.txtRemark.Location = New System.Drawing.Point(95, 138)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Size = New System.Drawing.Size(438, 37)
        Me.txtRemark.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(544, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "折扣金額(&J):"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(286, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "采購日期(&D):"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(570, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "幣別(&B):"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(462, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "0"
        '
        'txtPMID
        '
        Me.txtPMID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPMID.Enabled = False
        Me.txtPMID.Location = New System.Drawing.Point(620, 8)
        Me.txtPMID.Name = "txtPMID"
        Me.txtPMID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPMID.Properties.Appearance.Options.UseFont = True
        Me.txtPMID.Properties.ReadOnly = True
        Me.txtPMID.Size = New System.Drawing.Size(121, 24)
        Me.txtPMID.TabIndex = 110
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(415, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "版本:"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(543, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "采購單號:"
        '
        'gluCompany
        '
        Me.gluCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gluCompany.EditValue = ""
        Me.gluCompany.Location = New System.Drawing.Point(95, 44)
        Me.gluCompany.Name = "gluCompany"
        Me.gluCompany.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluCompany.Properties.Appearance.Options.UseFont = True
        Me.gluCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluCompany.Properties.NullText = ""
        Me.gluCompany.Properties.View = Me.GridView3
        Me.gluCompany.Size = New System.Drawing.Size(183, 24)
        Me.gluCompany.TabIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn22, Me.GridColumn23})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "公司代號"
        Me.GridColumn22.FieldName = "CO_ID"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 0
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "公司名稱"
        Me.GridColumn23.FieldName = "CO_ChsName"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(20, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 15)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "供應商(&P):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(0, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 15)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "付款方式(&M):"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(286, 105)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "送貨方式(&O):"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(539, 105)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 15)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "采購類型(&X):"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(95, 101)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"30天月結", "60天月結", "90天月結", "貨到付款", "貨到一周后付款", "預付款", "30 days A.M.S", "60 days A.M.S", "90 days A.M.S", "COD", "Pay in advance"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(183, 24)
        Me.ComboBoxEdit1.TabIndex = 13
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(376, 101)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"送貨上門", "貨到香港碼頭", "指定裝運港交貨", "自取", "Door To Door", "CIF HongKong", "FOB"})
        Me.ComboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(157, 24)
        Me.ComboBoxEdit2.TabIndex = 15
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(631, 101)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit3.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.Items.AddRange(New Object() {"物料", "大貨批次", "樣辦", "配件批次"})
        Me.ComboBoxEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(116, 24)
        Me.ComboBoxEdit3.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(318, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 15)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "類型"
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label25.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(570, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "稅率(&L):"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        '
        'TarriffEdit
        '
        Me.TarriffEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TarriffEdit.Location = New System.Drawing.Point(631, 42)
        Me.TarriffEdit.Name = "TarriffEdit"
        Me.TarriffEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TarriffEdit.Properties.Appearance.Options.UseFont = True
        Me.TarriffEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TarriffEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tarriff_Value", "稅率值", 17), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tarriff_Name", "稅率名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.TarriffEdit.Properties.DisplayMember = "Tarriff_Value"
        Me.TarriffEdit.Properties.NullText = ""
        Me.TarriffEdit.Properties.ValueMember = "Tarriff_Value"
        Me.TarriffEdit.Size = New System.Drawing.Size(116, 24)
        Me.TarriffEdit.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label26.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(381, 494)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 15)
        Me.Label26.TabIndex = 124
        Me.Label26.Text = "總計:"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label27.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(428, 494)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 15)
        Me.Label27.TabIndex = 126
        Me.Label27.Text = "0"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(124, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 12)
        Me.Label28.TabIndex = 127
        Me.Label28.Text = "採購方式"
        Me.Label28.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(204, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 12)
        Me.Label29.TabIndex = 128
        Me.Label29.Text = "詳細採購類型"
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(31, 140)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 15)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "備註(&R):"
        '
        'TxtRebate
        '
        Me.TxtRebate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRebate.Location = New System.Drawing.Point(631, 138)
        Me.TxtRebate.Name = "TxtRebate"
        Me.TxtRebate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRebate.Size = New System.Drawing.Size(116, 21)
        Me.TxtRebate.TabIndex = 21
        '
        'cboName
        '
        Me.cboName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboName.Location = New System.Drawing.Point(376, 72)
        Me.cboName.Name = "cboName"
        Me.cboName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.Properties.Appearance.Options.UseFont = True
        Me.cboName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboName.Size = New System.Drawing.Size(157, 24)
        Me.cboName.TabIndex = 9
        '
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 518)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.TxtRebate)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TarriffEdit)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.ComboBoxEdit3)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.ComboBoxEdit2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtPMID)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gluCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lueCurrency)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gluSupplier)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label30)
        Me.Name = "frmPurchase"
        Me.ShowIcon = False
        Me.Text = "采購單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popPurchase.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoIDbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoIDLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.CBEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.ACheckType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popFileShow.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPMID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarriffEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRebate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueCurrency As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gluSupplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPMID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gluCompany As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents popPurchase As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPurchaseAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchaseDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents QuoIDLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents Q_QuoID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_SupplierNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CheckAction As System.Windows.Forms.Label
    Friend WithEvents CheckDate As System.Windows.Forms.Label
    Friend WithEvents ACAction As System.Windows.Forms.Label
    Friend WithEvents ACdate As System.Windows.Forms.Label
    Friend WithEvents CBEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ACheckType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents QuoIDbutton As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Q_QuoID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents S_SupplierNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PN_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TarriffEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridFile As System.Windows.Forms.DataGridView
    Friend WithEvents F_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popFileShow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popFileShowOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subaccount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Q_StandardPack As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Q_MOQ As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents popPurchaseCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPurchasefujian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtRebate As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents popApplyAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AP_Num As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboName As DevExpress.XtraEditors.ComboBoxEdit
End Class
