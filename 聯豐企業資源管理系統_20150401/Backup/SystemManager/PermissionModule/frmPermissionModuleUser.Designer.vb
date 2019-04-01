<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissionModuleUser
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.repositoryItemColorEdit = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.ds = New System.Data.DataSet
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gridEditorName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gridEditorValue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.repositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.repositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.repositoryItemTimeEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.repositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.repositoryItemImageComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.repositoryItemMRUEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.repositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repositoryItemPictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.repositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.repositoryItemRadioGroup = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.repositoryItemHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.repositoryItemPopupContainerEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.repositoryItemImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.repositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.repositoryItemProgressBar = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.repositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.repositoryItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.repositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.cmdSaveSub = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.U_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_DPT_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.cmdCopy = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.UpdateButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemMRUEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemRadioGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn2, Me.TreeListColumn1, Me.TreeListColumn3})
        Me.TreeList1.KeyFieldName = "PM_ID"
        Me.TreeList1.Location = New System.Drawing.Point(353, 41)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsSelection.InvertSelection = True
        Me.TreeList1.OptionsSelection.MultiSelect = True
        Me.TreeList1.OptionsSelection.UseIndicatorForSelection = True
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowRoot = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.ParentFieldName = "PM_PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.TreeList1.Size = New System.Drawing.Size(239, 414)
        Me.TreeList1.TabIndex = 2
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "項目名稱"
        Me.TreeListColumn2.FieldName = "PM_Name"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowSort = False
        Me.TreeListColumn2.OptionsColumn.ReadOnly = True
        Me.TreeListColumn2.VisibleIndex = 0
        Me.TreeListColumn2.Width = 177
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "權限"
        Me.TreeListColumn1.ColumnEdit = Me.repositoryItemColorEdit
        Me.TreeListColumn1.FieldName = "PMU_Value"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowSort = False
        Me.TreeListColumn1.VisibleIndex = 1
        Me.TreeListColumn1.Width = 38
        '
        'repositoryItemColorEdit
        '
        Me.repositoryItemColorEdit.AutoHeight = False
        Me.repositoryItemColorEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemColorEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemColorEdit.Name = "repositoryItemColorEdit"
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "項目ID"
        Me.TreeListColumn3.FieldName = "PM_ID"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.VisibleIndex = 2
        Me.TreeListColumn3.Width = 20
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "用戶權限管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 36)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(300, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(109, 27)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "保存(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(438, 16)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(96, 27)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "取消(&C)"
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(28, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 25)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "全選(&A)"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(130, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 25)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "全部取消(&N)"
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl1.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gridControl1.Location = New System.Drawing.Point(594, 41)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit, Me.repositoryItemButtonEdit, Me.repositoryItemSpinEdit, Me.repositoryItemTimeEdit, Me.repositoryItemComboBox, Me.repositoryItemImageComboBox, Me.repositoryItemMRUEdit, Me.repositoryItemCheckEdit, Me.repositoryItemPictureEdit, Me.repositoryItemMemoEdit, Me.repositoryItemRadioGroup, Me.repositoryItemHyperLinkEdit, Me.repositoryItemPopupContainerEdit, Me.repositoryItemImageEdit, Me.repositoryItemMemoExEdit, Me.repositoryItemProgressBar, Me.repositoryItemDateEdit, Me.repositoryItemCalcEdit, Me.repositoryItemColorEdit, Me.repositoryItemLookUpEdit, Me.RepositoryItemTrackBar1})
        Me.gridControl1.Size = New System.Drawing.Size(174, 353)
        Me.gridControl1.TabIndex = 3
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridEditorName, Me.gridEditorValue, Me.GridColumn2, Me.GridColumn6})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowFilter = False
        Me.gridView1.OptionsCustomization.AllowSort = False
        Me.gridView1.OptionsPrint.AutoWidth = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.RowAutoHeight = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.OptionsView.ShowIndicator = False
        Me.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'gridEditorName
        '
        Me.gridEditorName.Caption = "權限名稱"
        Me.gridEditorName.FieldName = "Name"
        Me.gridEditorName.Name = "gridEditorName"
        Me.gridEditorName.OptionsColumn.AllowEdit = False
        Me.gridEditorName.OptionsColumn.AllowFocus = False
        Me.gridEditorName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridEditorName.OptionsColumn.ReadOnly = True
        Me.gridEditorName.OptionsFilter.AllowAutoFilter = False
        Me.gridEditorName.OptionsFilter.AllowFilter = False
        Me.gridEditorName.Visible = True
        Me.gridEditorName.VisibleIndex = 0
        Me.gridEditorName.Width = 100
        '
        'gridEditorValue
        '
        Me.gridEditorValue.Caption = "權限"
        Me.gridEditorValue.FieldName = "Value"
        Me.gridEditorValue.Name = "gridEditorValue"
        Me.gridEditorValue.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridEditorValue.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridEditorValue.OptionsFilter.AllowAutoFilter = False
        Me.gridEditorValue.OptionsFilter.AllowFilter = False
        Me.gridEditorValue.Visible = True
        Me.gridEditorValue.VisibleIndex = 1
        Me.gridEditorValue.Width = 70
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "權限編號"
        Me.GridColumn2.FieldName = "ID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "備註"
        Me.GridColumn6.FieldName = "Remark"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'repositoryItemTextEdit
        '
        Me.repositoryItemTextEdit.AutoHeight = False
        Me.repositoryItemTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemTextEdit.Name = "repositoryItemTextEdit"
        '
        'repositoryItemButtonEdit
        '
        Me.repositoryItemButtonEdit.AutoHeight = False
        Me.repositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit"
        '
        'repositoryItemSpinEdit
        '
        Me.repositoryItemSpinEdit.AutoHeight = False
        Me.repositoryItemSpinEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit"
        '
        'repositoryItemTimeEdit
        '
        Me.repositoryItemTimeEdit.AutoHeight = False
        Me.repositoryItemTimeEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemTimeEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemTimeEdit.Name = "repositoryItemTimeEdit"
        '
        'repositoryItemComboBox
        '
        Me.repositoryItemComboBox.AutoHeight = False
        Me.repositoryItemComboBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemComboBox.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territories", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China, People\'\'s Republic of", "Christmas Island", "Cocos Islands", "Columbia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Cote D\'\'ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "France, Metropolitan", "French Guiana", "French Polynesia", "French Southern Territories", "FYROM", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Island And Mcdonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic Peoples Republic of", "Korea, Republic of", "Kuwait", "Kyrgyzstan", "Lao Peoples Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and The Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and Sandwich Islands", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and JanMayen", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Wallis And Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe", "Guernsey", "Malaga", "Denmark", "Jersey"})
        Me.repositoryItemComboBox.Name = "repositoryItemComboBox"
        '
        'repositoryItemImageComboBox
        '
        Me.repositoryItemImageComboBox.AutoHeight = False
        Me.repositoryItemImageComboBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemImageComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemImageComboBox.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("MasterCard", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("AmEx", 4, 3)})
        Me.repositoryItemImageComboBox.Name = "repositoryItemImageComboBox"
        '
        'repositoryItemMRUEdit
        '
        Me.repositoryItemMRUEdit.AutoHeight = False
        Me.repositoryItemMRUEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemMRUEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemMRUEdit.Items.AddRange(New Object() {"Green", "Blue", "Black", "White"})
        Me.repositoryItemMRUEdit.Name = "repositoryItemMRUEdit"
        '
        'repositoryItemCheckEdit
        '
        Me.repositoryItemCheckEdit.AutoHeight = False
        Me.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit"
        '
        'repositoryItemPictureEdit
        '
        Me.repositoryItemPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit"
        '
        'repositoryItemMemoEdit
        '
        Me.repositoryItemMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit"
        '
        'repositoryItemRadioGroup
        '
        Me.repositoryItemRadioGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemRadioGroup.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Male"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Female")})
        Me.repositoryItemRadioGroup.Name = "repositoryItemRadioGroup"
        '
        'repositoryItemHyperLinkEdit
        '
        Me.repositoryItemHyperLinkEdit.AutoHeight = False
        Me.repositoryItemHyperLinkEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemHyperLinkEdit.Name = "repositoryItemHyperLinkEdit"
        '
        'repositoryItemPopupContainerEdit
        '
        Me.repositoryItemPopupContainerEdit.AutoHeight = False
        Me.repositoryItemPopupContainerEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemPopupContainerEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemPopupContainerEdit.CloseOnOuterMouseClick = False
        Me.repositoryItemPopupContainerEdit.Name = "repositoryItemPopupContainerEdit"
        '
        'repositoryItemImageEdit
        '
        Me.repositoryItemImageEdit.AutoHeight = False
        Me.repositoryItemImageEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemImageEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemImageEdit.Name = "repositoryItemImageEdit"
        Me.repositoryItemImageEdit.PopupStartSize = New System.Drawing.Size(250, 300)
        '
        'repositoryItemMemoExEdit
        '
        Me.repositoryItemMemoExEdit.AutoHeight = False
        Me.repositoryItemMemoExEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit"
        Me.repositoryItemMemoExEdit.PopupStartSize = New System.Drawing.Size(250, 150)
        '
        'repositoryItemProgressBar
        '
        Me.repositoryItemProgressBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemProgressBar.Name = "repositoryItemProgressBar"
        '
        'repositoryItemDateEdit
        '
        Me.repositoryItemDateEdit.AutoHeight = False
        Me.repositoryItemDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemDateEdit.Name = "repositoryItemDateEdit"
        '
        'repositoryItemCalcEdit
        '
        Me.repositoryItemCalcEdit.AutoHeight = False
        Me.repositoryItemCalcEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit"
        '
        'repositoryItemLookUpEdit
        '
        Me.repositoryItemLookUpEdit.AutoHeight = False
        Me.repositoryItemLookUpEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnName", "Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnDepartment", "Department", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.repositoryItemLookUpEdit.DisplayMember = "clnName"
        Me.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit"
        Me.repositoryItemLookUpEdit.PopupWidth = 290
        Me.repositoryItemLookUpEdit.ValueMember = "clnId"
        '
        'RepositoryItemTrackBar1
        '
        Me.RepositoryItemTrackBar1.Name = "RepositoryItemTrackBar1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.Location = New System.Drawing.Point(594, 397)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(174, 58)
        Me.MemoEdit1.TabIndex = 4
        '
        'cmdSaveSub
        '
        Me.cmdSaveSub.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSaveSub.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSaveSub.Appearance.Options.UseFont = True
        Me.cmdSaveSub.Location = New System.Drawing.Point(117, 13)
        Me.cmdSaveSub.Name = "cmdSaveSub"
        Me.cmdSaveSub.Size = New System.Drawing.Size(53, 25)
        Me.cmdSaveSub.TabIndex = 13
        Me.cmdSaveSub.Text = "保存(&B)"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.EmbeddedNavigator.Name = ""
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl2.Location = New System.Drawing.Point(192, 41)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemMRUEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemImageEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemColorEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTrackBar2})
        Me.GridControl2.Size = New System.Drawing.Size(159, 414)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.U_ID, Me.U_Name, Me.U_DPT_Name})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsPrint.AutoWidth = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'U_ID
        '
        Me.U_ID.Caption = "工號"
        Me.U_ID.FieldName = "U_ID"
        Me.U_ID.Name = "U_ID"
        Me.U_ID.Visible = True
        Me.U_ID.VisibleIndex = 0
        Me.U_ID.Width = 65
        '
        'U_Name
        '
        Me.U_Name.Caption = "用戶名"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 1
        Me.U_Name.Width = 74
        '
        'U_DPT_Name
        '
        Me.U_DPT_Name.Caption = "部門"
        Me.U_DPT_Name.FieldName = "U_DPT_Name"
        Me.U_DPT_Name.Name = "U_DPT_Name"
        Me.U_DPT_Name.Width = 70
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territories", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China, People\'\'s Republic of", "Christmas Island", "Cocos Islands", "Columbia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Cote D\'\'ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "France, Metropolitan", "French Guiana", "French Polynesia", "French Southern Territories", "FYROM", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Island And Mcdonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic Peoples Republic of", "Korea, Republic of", "Kuwait", "Kyrgyzstan", "Lao Peoples Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and The Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and Sandwich Islands", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and JanMayen", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Wallis And Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe", "Guernsey", "Malaga", "Denmark", "Jersey"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("MasterCard", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("AmEx", 4, 3)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemMRUEdit1
        '
        Me.RepositoryItemMRUEdit1.AutoHeight = False
        Me.RepositoryItemMRUEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemMRUEdit1.Items.AddRange(New Object() {"White", "Black", "Blue", "Green"})
        Me.RepositoryItemMRUEdit1.Name = "RepositoryItemMRUEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Male"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Female")})
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.CloseOnOuterMouseClick = False
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        Me.RepositoryItemImageEdit1.PopupStartSize = New System.Drawing.Size(250, 300)
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.PopupStartSize = New System.Drawing.Size(250, 150)
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnName", "Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnDepartment", "Department", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "clnName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.PopupWidth = 290
        Me.RepositoryItemLookUpEdit1.ValueMember = "clnId"
        '
        'RepositoryItemTrackBar2
        '
        Me.RepositoryItemTrackBar2.Name = "RepositoryItemTrackBar2"
        '
        'cmdCopy
        '
        Me.cmdCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCopy.Location = New System.Drawing.Point(39, 12)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(82, 25)
        Me.cmdCopy.TabIndex = 6
        Me.cmdCopy.Text = "復製權限(&P)"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(5, 13)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(53, 25)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "全選(&E)"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(61, 13)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(53, 25)
        Me.SimpleButton6.TabIndex = 12
        Me.SimpleButton6.Text = "取消(&L)"
        '
        'TreeList2
        '
        Me.TreeList2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6})
        Me.TreeList2.CustomizationFormBounds = New System.Drawing.Rectangle(806, 465, 208, 175)
        Me.TreeList2.KeyFieldName = "DPT_ID"
        Me.TreeList2.Location = New System.Drawing.Point(2, 41)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.OptionsBehavior.Editable = False
        Me.TreeList2.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeList2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.TreeList2.OptionsView.ShowHorzLines = False
        Me.TreeList2.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList2.OptionsView.ShowIndicator = False
        Me.TreeList2.OptionsView.ShowVertLines = False
        Me.TreeList2.ParentFieldName = "DPT_PID"
        Me.TreeList2.Size = New System.Drawing.Size(188, 508)
        Me.TreeList2.TabIndex = 0
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "部門編號"
        Me.TreeListColumn4.FieldName = "DPT_ID"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "部門名稱"
        Me.TreeListColumn5.FieldName = "DPT_Name"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.VisibleIndex = 0
        Me.TreeListColumn5.Width = 126
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "部門父ID"
        Me.TreeListColumn6.FieldName = "DPT_PID"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.Width = 126
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdCopy)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 456)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 43)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Controls.Add(Me.SimpleButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 456)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 43)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.SimpleButton3)
        Me.GroupBox3.Controls.Add(Me.cmdSaveSub)
        Me.GroupBox3.Controls.Add(Me.SimpleButton6)
        Me.GroupBox3.Location = New System.Drawing.Point(594, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 43)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.UpdateButton)
        Me.GroupBox4.Controls.Add(Me.cmdSave)
        Me.GroupBox4.Controls.Add(Me.cmdExit)
        Me.GroupBox4.Location = New System.Drawing.Point(192, 499)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(578, 50)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(16, 18)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(78, 26)
        Me.UpdateButton.TabIndex = 17
        Me.UpdateButton.Text = "更新版本"
        '
        'frmPermissionModuleUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 554)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeList1)
        Me.Name = "frmPermissionModuleUser"
        Me.Text = "用戶權限管理"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemMRUEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemRadioGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gridEditorName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gridEditorValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Private WithEvents repositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents repositoryItemTimeEdit As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Private WithEvents repositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents repositoryItemImageComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents repositoryItemMRUEdit As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Private WithEvents repositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents repositoryItemPictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Private WithEvents repositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents repositoryItemRadioGroup As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Private WithEvents repositoryItemHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents repositoryItemPopupContainerEdit As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Private WithEvents repositoryItemImageEdit As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Private WithEvents repositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Private WithEvents repositoryItemProgressBar As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents repositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents repositoryItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents repositoryItemColorEdit As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Private WithEvents repositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdSaveSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents U_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_DPT_Name As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Private WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Private WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Private WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Private WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Private WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Private WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Private WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Private WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Private WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTrackBar2 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents cmdCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateButton As DevExpress.XtraEditors.SimpleButton
End Class
