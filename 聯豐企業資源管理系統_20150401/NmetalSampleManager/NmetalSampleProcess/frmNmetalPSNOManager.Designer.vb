<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalPSNOManager
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.gluSE_OutD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lbl_Type = New System.Windows.Forms.Label
        Me.cbo_ProType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lbl_ProType = New System.Windows.Forms.Label
        Me.glu_Type = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Type3ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_PM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GoIn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbl_PM_M_Code = New System.Windows.Forms.Label
        Me.lbl_DepName = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.gluSE_OutD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_ProType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(6, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(186, 21)
        Me.Lbl_Title.TabIndex = 85
        Me.Lbl_Title.Text = "工艺类型管理列表"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 32)
        Me.Panel2.TabIndex = 133
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(483, 514)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(81, 29)
        Me.cmdExit.TabIndex = 136
        Me.cmdExit.Text = "取消"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(376, 514)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(83, 29)
        Me.cmdSave.TabIndex = 135
        Me.cmdSave.Text = "保存"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 38)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(582, 466)
        Me.XtraTabControl1.TabIndex = 137
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.gluSE_OutD_ID)
        Me.XtraTabPage3.Controls.Add(Me.lbl_Type)
        Me.XtraTabPage3.Controls.Add(Me.cbo_ProType)
        Me.XtraTabPage3.Controls.Add(Me.lbl_ProType)
        Me.XtraTabPage3.Controls.Add(Me.glu_Type)
        Me.XtraTabPage3.Controls.Add(Me.glu_PM_M_Code)
        Me.XtraTabPage3.Controls.Add(Me.Grid1)
        Me.XtraTabPage3.Controls.Add(Me.Label15)
        Me.XtraTabPage3.Controls.Add(Me.lbl_PM_M_Code)
        Me.XtraTabPage3.Controls.Add(Me.lbl_DepName)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(573, 434)
        Me.XtraTabPage3.Text = "工序信息"
        '
        'gluSE_OutD_ID
        '
        Me.gluSE_OutD_ID.EditValue = ""
        Me.gluSE_OutD_ID.Location = New System.Drawing.Point(90, 8)
        Me.gluSE_OutD_ID.Name = "gluSE_OutD_ID"
        Me.gluSE_OutD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSE_OutD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSE_OutD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSE_OutD_ID.Properties.DisplayMember = "DepName"
        Me.gluSE_OutD_ID.Properties.NullText = ""
        Me.gluSE_OutD_ID.Properties.PopupFormWidth = 150
        Me.gluSE_OutD_ID.Properties.ValueMember = "DepID"
        Me.gluSE_OutD_ID.Properties.View = Me.GridView1
        Me.gluSE_OutD_ID.Size = New System.Drawing.Size(182, 24)
        Me.gluSE_OutD_ID.TabIndex = 33
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "部门编号"
        Me.GridColumn1.FieldName = "DepID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "部门"
        Me.GridColumn2.FieldName = "DepName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 60
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(313, 45)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Type.TabIndex = 32
        Me.lbl_Type.Text = "类    型:"
        '
        'cbo_ProType
        '
        Me.cbo_ProType.EditValue = "生產加工"
        Me.cbo_ProType.Enabled = False
        Me.cbo_ProType.Location = New System.Drawing.Point(379, 8)
        Me.cbo_ProType.Margin = New System.Windows.Forms.Padding(8)
        Me.cbo_ProType.Name = "cbo_ProType"
        Me.cbo_ProType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbo_ProType.Properties.Appearance.Options.UseFont = True
        Me.cbo_ProType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_ProType.Properties.Items.AddRange(New Object() {"生產加工", "胚部加工", "裝配出貨"})
        Me.cbo_ProType.Properties.ReadOnly = True
        Me.cbo_ProType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbo_ProType.Size = New System.Drawing.Size(182, 24)
        Me.cbo_ProType.TabIndex = 31
        '
        'lbl_ProType
        '
        Me.lbl_ProType.AutoSize = True
        Me.lbl_ProType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_ProType.Location = New System.Drawing.Point(299, 12)
        Me.lbl_ProType.Name = "lbl_ProType"
        Me.lbl_ProType.Size = New System.Drawing.Size(71, 15)
        Me.lbl_ProType.TabIndex = 30
        Me.lbl_ProType.Text = "工艺类型:"
        '
        'glu_Type
        '
        Me.glu_Type.EditValue = ""
        Me.glu_Type.Location = New System.Drawing.Point(379, 41)
        Me.glu_Type.Margin = New System.Windows.Forms.Padding(8)
        Me.glu_Type.Name = "glu_Type"
        Me.glu_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_Type.Properties.Appearance.Options.UseFont = True
        Me.glu_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_Type.Properties.NullText = ""
        Me.glu_Type.Properties.View = Me.GridView7
        Me.glu_Type.Size = New System.Drawing.Size(182, 24)
        Me.glu_Type.TabIndex = 29
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Type3ID})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'Type3ID
        '
        Me.Type3ID.Caption = "类型"
        Me.Type3ID.FieldName = "Type3ID"
        Me.Type3ID.Name = "Type3ID"
        Me.Type3ID.Visible = True
        Me.Type3ID.VisibleIndex = 0
        '
        'glu_PM_M_Code
        '
        Me.glu_PM_M_Code.EditValue = ""
        Me.glu_PM_M_Code.Location = New System.Drawing.Point(90, 41)
        Me.glu_PM_M_Code.Margin = New System.Windows.Forms.Padding(8)
        Me.glu_PM_M_Code.Name = "glu_PM_M_Code"
        Me.glu_PM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.glu_PM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PM_M_Code.Properties.NullText = ""
        Me.glu_PM_M_Code.Properties.View = Me.GridView3
        Me.glu_PM_M_Code.Size = New System.Drawing.Size(182, 24)
        Me.glu_PM_M_Code.TabIndex = 28
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(90, 76)
        Me.Grid1.MainView = Me.GridView4
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4})
        Me.Grid1.Size = New System.Drawing.Size(465, 355)
        Me.Grid1.TabIndex = 26
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.GoIn, Me.PS_Name, Me.AutoID})
        Me.GridView4.GridControl = Me.Grid1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序编号"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'GoIn
        '
        Me.GoIn.Caption = "加入"
        Me.GoIn.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.GoIn.FieldName = "GoIn"
        Me.GoIn.Name = "GoIn"
        Me.GoIn.Visible = True
        Me.GoIn.VisibleIndex = 1
        Me.GoIn.Width = 105
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名称"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 0
        Me.PS_Name.Width = 339
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "工序名称："
        '
        'lbl_PM_M_Code
        '
        Me.lbl_PM_M_Code.AutoSize = True
        Me.lbl_PM_M_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_PM_M_Code.Location = New System.Drawing.Point(8, 45)
        Me.lbl_PM_M_Code.Name = "lbl_PM_M_Code"
        Me.lbl_PM_M_Code.Size = New System.Drawing.Size(82, 15)
        Me.lbl_PM_M_Code.TabIndex = 23
        Me.lbl_PM_M_Code.Text = "产品编号："
        '
        'lbl_DepName
        '
        Me.lbl_DepName.AutoSize = True
        Me.lbl_DepName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_DepName.Location = New System.Drawing.Point(8, 12)
        Me.lbl_DepName.Name = "lbl_DepName"
        Me.lbl_DepName.Size = New System.Drawing.Size(82, 15)
        Me.lbl_DepName.TabIndex = 22
        Me.lbl_DepName.Text = "部门信息："
        '
        'frmNmetalPSNOManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmNmetalPSNOManager"
        Me.Text = "工艺类型管理"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.gluSE_OutD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_ProType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gluSE_OutD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_Type As System.Windows.Forms.Label
    Friend WithEvents cbo_ProType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_ProType As System.Windows.Forms.Label
    Friend WithEvents glu_Type As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Type3ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glu_PM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GoIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_PM_M_Code As System.Windows.Forms.Label
    Friend WithEvents lbl_DepName As System.Windows.Forms.Label
End Class
