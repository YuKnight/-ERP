<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplyPurchase
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdAddNoCode = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rbeM_Code = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.AP_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.AP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.AP_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_CheckWare = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.MCodeText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.rceCheckWare = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.apCheckAction = New System.Windows.Forms.Label
        Me.apCheckdate = New System.Windows.Forms.Label
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.apRecheckAction = New System.Windows.Forms.Label
        Me.apRecheckdate = New System.Windows.Forms.Label
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtapID = New DevExpress.XtraEditors.TextEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtApplyPersonName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtapDate = New DevExpress.XtraEditors.DateEdit
        Me.txtapDpt = New DevExpress.XtraEditors.ButtonEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtapReason = New DevExpress.XtraEditors.MemoEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeM_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rceCheckWare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtApplyPersonName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapDpt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(694, 37)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "申購單"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 145)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(697, 278)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid1)
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(688, 246)
        Me.XtraTabPage1.Text = "物料明細"
        '
        'Grid1
        '
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(19, 44)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(171, 118)
        Me.Grid1.TabIndex = 10
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.Grid1.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WH_AllName, Me.GridColumn1})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'WH_AllName
        '
        Me.WH_AllName.Caption = "倉庫名稱"
        Me.WH_AllName.FieldName = "WH_AllName"
        Me.WH_AllName.Name = "WH_AllName"
        Me.WH_AllName.OptionsColumn.ReadOnly = True
        Me.WH_AllName.Visible = True
        Me.WH_AllName.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "庫存數量"
        Me.GridColumn1.FieldName = "WI_Qty"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RemarkItemMemoExEdit1, Me.QtyItemCalcEdit, Me.RepositoryItemCheckEdit1, Me.RepositoryItemButtonEdit2, Me.MCodeText, Me.RepositoryItemTextEdit2, Me.RepositoryItemButtonEdit3, Me.rbeM_Code, Me.rceCheckWare, Me.RepositoryItemCheckEdit2})
        Me.Grid.Size = New System.Drawing.Size(688, 246)
        Me.Grid.TabIndex = 9
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdAddNoCode, Me.ToolStripSeparator1, Me.cmdDel})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(190, 76)
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(189, 22)
        Me.cmdAdd.Text = "新增(&A)..."
        '
        'cmdAddNoCode
        '
        Me.cmdAddNoCode.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAddNoCode.Name = "cmdAddNoCode"
        Me.cmdAddNoCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdAddNoCode.Size = New System.Drawing.Size(189, 22)
        Me.cmdAddNoCode.Text = "新增(無編碼)(&E)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'cmdDel
        '
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(189, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AP_Num, Me.AP_M_Code, Me.AP_M_Name, Me.AP_M_Gauge, Me.AP_Qty, Me.AP_M_Unit, Me.WI_Qty, Me.AP_ApplyID, Me.AP_CheckWare})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AP_Num
        '
        Me.AP_Num.Caption = "GridColumn1"
        Me.AP_Num.FieldName = "AP_Num"
        Me.AP_Num.Name = "AP_Num"
        '
        'AP_M_Code
        '
        Me.AP_M_Code.Caption = "物料編碼"
        Me.AP_M_Code.ColumnEdit = Me.rbeM_Code
        Me.AP_M_Code.FieldName = "AP_M_Code"
        Me.AP_M_Code.Name = "AP_M_Code"
        Me.AP_M_Code.OptionsColumn.ReadOnly = True
        Me.AP_M_Code.Visible = True
        Me.AP_M_Code.VisibleIndex = 0
        Me.AP_M_Code.Width = 150
        '
        'rbeM_Code
        '
        Me.rbeM_Code.AutoHeight = False
        Me.rbeM_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.rbeM_Code.Name = "rbeM_Code"
        '
        'AP_M_Name
        '
        Me.AP_M_Name.Caption = "物料名稱"
        Me.AP_M_Name.FieldName = "AP_M_Name"
        Me.AP_M_Name.Name = "AP_M_Name"
        Me.AP_M_Name.OptionsColumn.ReadOnly = True
        Me.AP_M_Name.Visible = True
        Me.AP_M_Name.VisibleIndex = 1
        '
        'AP_M_Gauge
        '
        Me.AP_M_Gauge.Caption = "規格"
        Me.AP_M_Gauge.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.AP_M_Gauge.FieldName = "AP_M_Gauge"
        Me.AP_M_Gauge.Name = "AP_M_Gauge"
        Me.AP_M_Gauge.OptionsColumn.ReadOnly = True
        Me.AP_M_Gauge.Visible = True
        Me.AP_M_Gauge.VisibleIndex = 2
        Me.AP_M_Gauge.Width = 150
        '
        'RemarkItemMemoExEdit1
        '
        Me.RemarkItemMemoExEdit1.AutoHeight = False
        Me.RemarkItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkItemMemoExEdit1.Name = "RemarkItemMemoExEdit1"
        Me.RemarkItemMemoExEdit1.ShowIcon = False
        '
        'AP_Qty
        '
        Me.AP_Qty.Caption = "申購數量"
        Me.AP_Qty.ColumnEdit = Me.QtyItemCalcEdit
        Me.AP_Qty.FieldName = "AP_Qty"
        Me.AP_Qty.Name = "AP_Qty"
        Me.AP_Qty.Visible = True
        Me.AP_Qty.VisibleIndex = 3
        Me.AP_Qty.Width = 60
        '
        'QtyItemCalcEdit
        '
        Me.QtyItemCalcEdit.AutoHeight = False
        Me.QtyItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyItemCalcEdit.Name = "QtyItemCalcEdit"
        '
        'AP_M_Unit
        '
        Me.AP_M_Unit.Caption = "單位"
        Me.AP_M_Unit.FieldName = "AP_M_Unit"
        Me.AP_M_Unit.Name = "AP_M_Unit"
        Me.AP_M_Unit.OptionsColumn.ReadOnly = True
        Me.AP_M_Unit.Visible = True
        Me.AP_M_Unit.VisibleIndex = 4
        Me.AP_M_Unit.Width = 40
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存數量"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.OptionsColumn.ReadOnly = True
        '
        'AP_ApplyID
        '
        Me.AP_ApplyID.Caption = "備注"
        Me.AP_ApplyID.FieldName = "AP_ApplyID"
        Me.AP_ApplyID.Name = "AP_ApplyID"
        Me.AP_ApplyID.Visible = True
        Me.AP_ApplyID.VisibleIndex = 5
        Me.AP_ApplyID.Width = 100
        '
        'AP_CheckWare
        '
        Me.AP_CheckWare.Caption = "可採購"
        Me.AP_CheckWare.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.AP_CheckWare.FieldName = "AP_CheckWare"
        Me.AP_CheckWare.Name = "AP_CheckWare"
        Me.AP_CheckWare.Visible = True
        Me.AP_CheckWare.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'MCodeText
        '
        Me.MCodeText.AutoHeight = False
        Me.MCodeText.Name = "MCodeText"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        '
        'rceCheckWare
        '
        Me.rceCheckWare.AutoHeight = False
        Me.rceCheckWare.Name = "rceCheckWare"
        Me.rceCheckWare.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.apCheckAction)
        Me.XtraTabPage2.Controls.Add(Me.apCheckdate)
        Me.XtraTabPage2.Controls.Add(Me.MemoEdit2)
        Me.XtraTabPage2.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.Label11)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(688, 246)
        Me.XtraTabPage2.Text = "審核"
        '
        'apCheckAction
        '
        Me.apCheckAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apCheckAction.AutoSize = True
        Me.apCheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.apCheckAction.Location = New System.Drawing.Point(348, 23)
        Me.apCheckAction.Name = "apCheckAction"
        Me.apCheckAction.Size = New System.Drawing.Size(52, 15)
        Me.apCheckAction.TabIndex = 9
        Me.apCheckAction.Text = "審核人"
        '
        'apCheckdate
        '
        Me.apCheckdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apCheckdate.AutoSize = True
        Me.apCheckdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.apCheckdate.Location = New System.Drawing.Point(507, 23)
        Me.apCheckdate.Name = "apCheckdate"
        Me.apCheckdate.Size = New System.Drawing.Size(67, 15)
        Me.apCheckdate.TabIndex = 8
        Me.apCheckdate.Text = "審核日期"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit2.Location = New System.Drawing.Point(119, 88)
        Me.MemoEdit2.Margin = New System.Windows.Forms.Padding(6)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MemoEdit2.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit2.Size = New System.Drawing.Size(455, 90)
        Me.MemoEdit2.TabIndex = 17
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(119, 52)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"確認無誤", "待復", "無效"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(168, 24)
        Me.ComboBoxEdit1.TabIndex = 15
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(119, 21)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "確認"
        Me.CheckEdit1.Size = New System.Drawing.Size(93, 20)
        Me.CheckEdit1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "備        註(&R)："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "審核類型(&T)："
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(269, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "審  核  人："
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(430, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "審核日期："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "審       核(&K)："
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.apRecheckAction)
        Me.XtraTabPage3.Controls.Add(Me.apRecheckdate)
        Me.XtraTabPage3.Controls.Add(Me.MemoEdit3)
        Me.XtraTabPage3.Controls.Add(Me.ComboBoxEdit2)
        Me.XtraTabPage3.Controls.Add(Me.CheckEdit2)
        Me.XtraTabPage3.Controls.Add(Me.Label16)
        Me.XtraTabPage3.Controls.Add(Me.Label15)
        Me.XtraTabPage3.Controls.Add(Me.Label14)
        Me.XtraTabPage3.Controls.Add(Me.Label13)
        Me.XtraTabPage3.Controls.Add(Me.Label12)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageVisible = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(688, 246)
        Me.XtraTabPage3.Text = "復核"
        '
        'apRecheckAction
        '
        Me.apRecheckAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apRecheckAction.AutoSize = True
        Me.apRecheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.apRecheckAction.Location = New System.Drawing.Point(341, 23)
        Me.apRecheckAction.Name = "apRecheckAction"
        Me.apRecheckAction.Size = New System.Drawing.Size(52, 15)
        Me.apRecheckAction.TabIndex = 9
        Me.apRecheckAction.Text = "復核人"
        '
        'apRecheckdate
        '
        Me.apRecheckdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apRecheckdate.AutoSize = True
        Me.apRecheckdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.apRecheckdate.Location = New System.Drawing.Point(497, 23)
        Me.apRecheckdate.Name = "apRecheckdate"
        Me.apRecheckdate.Size = New System.Drawing.Size(67, 15)
        Me.apRecheckdate.TabIndex = 8
        Me.apRecheckdate.Text = "復核日期"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit3.EditValue = ""
        Me.MemoEdit3.Location = New System.Drawing.Point(118, 88)
        Me.MemoEdit3.Margin = New System.Windows.Forms.Padding(6)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MemoEdit3.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit3.Size = New System.Drawing.Size(446, 92)
        Me.MemoEdit3.TabIndex = 23
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(118, 52)
        Me.ComboBoxEdit2.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"確認無誤", "無效"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(167, 24)
        Me.ComboBoxEdit2.TabIndex = 21
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(118, 21)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Caption = "確認"
        Me.CheckEdit2.Size = New System.Drawing.Size(92, 20)
        Me.CheckEdit2.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 15)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "備        註(&R)："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 15)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "復核類型(&P)："
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(264, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "復  核  人："
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(421, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "復核日期："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "復       核(&K)："
        '
        'txtapID
        '
        Me.txtapID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtapID.Enabled = False
        Me.txtapID.Location = New System.Drawing.Point(561, 7)
        Me.txtapID.Name = "txtapID"
        Me.txtapID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtapID.Properties.Appearance.Options.UseFont = True
        Me.txtapID.Size = New System.Drawing.Size(120, 24)
        Me.txtapID.TabIndex = 0
        Me.txtapID.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(498, 429)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(601, 429)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 25
        Me.cmdExit.Text = "取消(&C)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "申購單號:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(112, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtApplyPersonName)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtapDate)
        Me.GroupBox1.Controls.Add(Me.txtapDpt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtapReason)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 102)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtApplyPersonName
        '
        Me.txtApplyPersonName.Location = New System.Drawing.Point(322, 15)
        Me.txtApplyPersonName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtApplyPersonName.Name = "txtApplyPersonName"
        Me.txtApplyPersonName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtApplyPersonName.Properties.Appearance.Options.UseFont = True
        Me.txtApplyPersonName.Size = New System.Drawing.Size(120, 24)
        Me.txtApplyPersonName.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(246, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 15)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "申購人(&A):"
        '
        'txtapDate
        '
        Me.txtapDate.EditValue = Nothing
        Me.txtapDate.Location = New System.Drawing.Point(560, 15)
        Me.txtapDate.Margin = New System.Windows.Forms.Padding(6)
        Me.txtapDate.Name = "txtapDate"
        Me.txtapDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtapDate.Properties.Appearance.Options.UseFont = True
        Me.txtapDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtapDate.Size = New System.Drawing.Size(120, 24)
        Me.txtapDate.TabIndex = 5
        '
        'txtapDpt
        '
        Me.txtapDpt.Location = New System.Drawing.Point(104, 15)
        Me.txtapDpt.Margin = New System.Windows.Forms.Padding(6)
        Me.txtapDpt.Name = "txtapDpt"
        Me.txtapDpt.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtapDpt.Properties.Appearance.Options.UseFont = True
        Me.txtapDpt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtapDpt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtapDpt.Size = New System.Drawing.Size(120, 24)
        Me.txtapDpt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "申購部門(&D):"
        '
        'txtapReason
        '
        Me.txtapReason.Location = New System.Drawing.Point(104, 51)
        Me.txtapReason.Margin = New System.Windows.Forms.Padding(6)
        Me.txtapReason.Name = "txtapReason"
        Me.txtapReason.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtapReason.Properties.Appearance.Options.UseFont = True
        Me.txtapReason.Size = New System.Drawing.Size(576, 39)
        Me.txtapReason.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "申購原因(&S):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "申購日期(&E):"
        '
        'frmApplyPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(696, 465)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtapID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmApplyPurchase"
        Me.Text = "申購單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeM_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rceCheckWare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtApplyPersonName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapDpt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AP_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MCodeText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents AP_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents AP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents AP_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtapID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents apCheckAction As System.Windows.Forms.Label
    Friend WithEvents apCheckdate As System.Windows.Forms.Label
    Friend WithEvents apRecheckAction As System.Windows.Forms.Label
    Friend WithEvents apRecheckdate As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AP_ApplyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AP_CheckWare As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmdAddNoCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbeM_Code As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rceCheckWare As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApplyPersonName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtapDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtapDpt As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtapReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
