<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDProductTypeSet
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.cmsProductType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProductTypeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductTypeInsert = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductTypeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsProductTypeUp = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProductTypeDown = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NumberID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.PopupContainerControl2 = New DevExpress.XtraEditors.PopupContainerControl
        Me.gridDept = New DevExpress.XtraGrid.GridControl
        Me.viewDept = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_ProcessName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.D_IsSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Remarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.pceType = New DevExpress.XtraEditors.PopupContainerEdit
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.gridType = New DevExpress.XtraGrid.GridControl
        Me.viewType = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProductType.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl2.SuspendLayout()
        CType(Me.gridDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.gridType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "工藝設置"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 36)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.cmsProductType
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 96)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(568, 305)
        Me.GridControl1.TabIndex = 58
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsProductType
        '
        Me.cmsProductType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProductTypeAdd, Me.cmsProductTypeInsert, Me.cmsProductTypeDel, Me.ToolStripSeparator1, Me.cmsProductTypeUp, Me.cmsProductTypeDown})
        Me.cmsProductType.Name = "pupPDProduct"
        Me.cmsProductType.Size = New System.Drawing.Size(170, 120)
        '
        'cmsProductTypeAdd
        '
        Me.cmsProductTypeAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.cmsProductTypeAdd.Name = "cmsProductTypeAdd"
        Me.cmsProductTypeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmsProductTypeAdd.Size = New System.Drawing.Size(169, 22)
        Me.cmsProductTypeAdd.Text = "新增"
        '
        'cmsProductTypeInsert
        '
        Me.cmsProductTypeInsert.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.cmsProductTypeInsert.Name = "cmsProductTypeInsert"
        Me.cmsProductTypeInsert.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmsProductTypeInsert.Size = New System.Drawing.Size(169, 22)
        Me.cmsProductTypeInsert.Text = "插入"
        '
        'cmsProductTypeDel
        '
        Me.cmsProductTypeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmsProductTypeDel.Name = "cmsProductTypeDel"
        Me.cmsProductTypeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmsProductTypeDel.Size = New System.Drawing.Size(169, 22)
        Me.cmsProductTypeDel.Text = "刪除"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'cmsProductTypeUp
        '
        Me.cmsProductTypeUp.Image = Global.LFERP.My.Resources.Resources._24
        Me.cmsProductTypeUp.Name = "cmsProductTypeUp"
        Me.cmsProductTypeUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.cmsProductTypeUp.Size = New System.Drawing.Size(169, 22)
        Me.cmsProductTypeUp.Text = "上移"
        '
        'cmsProductTypeDown
        '
        Me.cmsProductTypeDown.Image = Global.LFERP.My.Resources.Resources._21
        Me.cmsProductTypeDown.Name = "cmsProductTypeDown"
        Me.cmsProductTypeDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.cmsProductTypeDown.Size = New System.Drawing.Size(169, 22)
        Me.cmsProductTypeDown.Text = "下移"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NumberID, Me.D_ID, Me.D_Dep, Me.D_ProcessName, Me.D_IsSub, Me.Remarks})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'NumberID
        '
        Me.NumberID.Caption = "序號"
        Me.NumberID.FieldName = "NumberID"
        Me.NumberID.Name = "NumberID"
        Me.NumberID.OptionsColumn.ReadOnly = True
        Me.NumberID.Visible = True
        Me.NumberID.VisibleIndex = 0
        Me.NumberID.Width = 69
        '
        'D_ID
        '
        Me.D_ID.Caption = "D_ID"
        Me.D_ID.FieldName = "D_ID"
        Me.D_ID.Name = "D_ID"
        '
        'D_Dep
        '
        Me.D_Dep.Caption = "工藝部門"
        Me.D_Dep.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.D_Dep.FieldName = "D_Dep"
        Me.D_Dep.Name = "D_Dep"
        Me.D_Dep.Visible = True
        Me.D_Dep.VisibleIndex = 1
        Me.D_Dep.Width = 78
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl2
        '
        'PopupContainerControl2
        '
        Me.PopupContainerControl2.Controls.Add(Me.gridDept)
        Me.PopupContainerControl2.Location = New System.Drawing.Point(168, 177)
        Me.PopupContainerControl2.Name = "PopupContainerControl2"
        Me.PopupContainerControl2.Size = New System.Drawing.Size(168, 178)
        Me.PopupContainerControl2.TabIndex = 153
        Me.PopupContainerControl2.Text = "PopupContainerControl2"
        '
        'gridDept
        '
        Me.gridDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDept.EmbeddedNavigator.Name = ""
        Me.gridDept.Location = New System.Drawing.Point(0, 0)
        Me.gridDept.MainView = Me.viewDept
        Me.gridDept.Name = "gridDept"
        Me.gridDept.Size = New System.Drawing.Size(168, 178)
        Me.gridDept.TabIndex = 1
        Me.gridDept.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewDept})
        '
        'viewDept
        '
        Me.viewDept.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.viewDept.GridControl = Me.gridDept
        Me.viewDept.Name = "viewDept"
        Me.viewDept.OptionsBehavior.Editable = False
        Me.viewDept.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "編號"
        Me.GridColumn3.FieldName = "D_ID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 66
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "部門"
        Me.GridColumn4.FieldName = "D_Dep"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 113
        '
        'D_ProcessName
        '
        Me.D_ProcessName.Caption = "工序名稱"
        Me.D_ProcessName.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.D_ProcessName.FieldName = "D_ProcessName"
        Me.D_ProcessName.Name = "D_ProcessName"
        Me.D_ProcessName.Visible = True
        Me.D_ProcessName.VisibleIndex = 2
        Me.D_ProcessName.Width = 162
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'D_IsSub
        '
        Me.D_IsSub.Caption = "D_IsSub"
        Me.D_IsSub.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.D_IsSub.FieldName = "D_IsSub"
        Me.D_IsSub.Name = "D_IsSub"
        Me.D_IsSub.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Remarks
        '
        Me.Remarks.Caption = "註意事項"
        Me.Remarks.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remarks.FieldName = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Visible = True
        Me.Remarks.VisibleIndex = 3
        Me.Remarks.Width = 214
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("D_ID", "編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("D_Dep", "部門", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(492, 416)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(79, 27)
        Me.cmdExit.TabIndex = 60
        Me.cmdExit.Text = "取消(&E)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(406, 416)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 27)
        Me.cmdSave.TabIndex = 59
        Me.cmdSave.Text = "保存(&S)"
        '
        'pceType
        '
        Me.pceType.Location = New System.Drawing.Point(87, 17)
        Me.pceType.Name = "pceType"
        Me.pceType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pceType.Properties.Appearance.Options.UseFont = True
        Me.pceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceType.Properties.PopupControl = Me.PopupContainerControl1
        Me.pceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.pceType.Size = New System.Drawing.Size(135, 24)
        Me.pceType.TabIndex = 151
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.gridType)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(63, 158)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(153, 177)
        Me.PopupContainerControl1.TabIndex = 152
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'gridType
        '
        Me.gridType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridType.EmbeddedNavigator.Name = ""
        Me.gridType.Location = New System.Drawing.Point(0, 0)
        Me.gridType.MainView = Me.viewType
        Me.gridType.Name = "gridType"
        Me.gridType.Size = New System.Drawing.Size(153, 177)
        Me.gridType.TabIndex = 0
        Me.gridType.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewType})
        '
        'viewType
        '
        Me.viewType.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.viewType.GridControl = Me.gridType
        Me.viewType.Name = "viewType"
        Me.viewType.OptionsBehavior.Editable = False
        Me.viewType.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "工藝編號"
        Me.GridColumn1.FieldName = "D_TypeID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 76
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "工藝名稱"
        Me.GridColumn2.FieldName = "D_Type"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 91
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 15)
        Me.Label21.TabIndex = 149
        Me.Label21.Text = "工藝類型:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pceType)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 49)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Label2"
        '
        'frmPDProductTypeSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PopupContainerControl2)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPDProductTypeSet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "工藝設置"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProductType.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl2.ResumeLayout(False)
        CType(Me.gridDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.gridType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumberID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents D_ProcessName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmsProductType As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProductTypeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductTypeInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductTypeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsProductTypeUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProductTypeDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D_IsSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pceType As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents gridType As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PopupContainerControl2 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents gridDept As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewDept As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
