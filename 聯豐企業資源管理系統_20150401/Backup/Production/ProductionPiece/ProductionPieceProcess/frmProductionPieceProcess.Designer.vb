<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPieceProcess
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
        Me.lblTittle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPP_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.dtePP_ActionDate = New DevExpress.XtraEditors.DateEdit
        Me.gluPM_Type = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboPro_Type = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtPP_ActionUser = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtPP_ID = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuInsert = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_N_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_PName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DPT_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.PP_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PP_PriceCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_Factor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PP_FactorCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PP_Explain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PP_BeginUseDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.PP_EndUseDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RemnantDays = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_BeginUse = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.chkPP_Check = New DevExpress.XtraEditors.CheckEdit
        Me.btnAllUse = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelCheckID = New System.Windows.Forms.Label
        Me.lblPP_CheckDate = New System.Windows.Forms.Label
        Me.lblPP_CheckUserName = New System.Windows.Forms.Label
        Me.lblCheckDate = New DevExpress.XtraEditors.LabelControl
        Me.lblCheckName = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabPP_PriceCheckDate = New System.Windows.Forms.Label
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabPP_PriceCheckUserID = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPP_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePP_ActionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPro_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPP_ActionUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPP_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPP_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTittle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(10, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(186, 21)
        Me.lblTittle.TabIndex = 7
        Me.lblTittle.Text = "計件工藝單--新增"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(936, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtPP_Remark)
        Me.GroupBox1.Controls.Add(Me.dtePP_ActionDate)
        Me.GroupBox1.Controls.Add(Me.gluPM_Type)
        Me.GroupBox1.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.cboPro_Type)
        Me.GroupBox1.Controls.Add(Me.txtPP_ActionUser)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPP_Remark
        '
        Me.txtPP_Remark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPP_Remark.Location = New System.Drawing.Point(100, 91)
        Me.txtPP_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPP_Remark.Name = "txtPP_Remark"
        Me.txtPP_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPP_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtPP_Remark.Size = New System.Drawing.Size(825, 41)
        Me.txtPP_Remark.TabIndex = 11
        '
        'dtePP_ActionDate
        '
        Me.dtePP_ActionDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtePP_ActionDate.EditValue = Nothing
        Me.dtePP_ActionDate.Location = New System.Drawing.Point(527, 55)
        Me.dtePP_ActionDate.Margin = New System.Windows.Forms.Padding(6)
        Me.dtePP_ActionDate.Name = "dtePP_ActionDate"
        Me.dtePP_ActionDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePP_ActionDate.Properties.Appearance.Options.UseFont = True
        Me.dtePP_ActionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePP_ActionDate.Size = New System.Drawing.Size(150, 24)
        Me.dtePP_ActionDate.TabIndex = 9
        '
        'gluPM_Type
        '
        Me.gluPM_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gluPM_Type.Location = New System.Drawing.Point(776, 19)
        Me.gluPM_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.gluPM_Type.Name = "gluPM_Type"
        Me.gluPM_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluPM_Type.Properties.Appearance.Options.UseFont = True
        Me.gluPM_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_Type.Properties.NullText = ""
        Me.gluPM_Type.Properties.View = Me.GridView1
        Me.gluPM_Type.Size = New System.Drawing.Size(150, 24)
        Me.gluPM_Type.TabIndex = 5
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.PM_Type})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "GridColumn1"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 0
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gluPM_M_Code.Location = New System.Drawing.Point(527, 19)
        Me.gluPM_M_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.View = Me.GridLookUpEdit1View
        Me.gluPM_M_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluPM_M_Code.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code, Me.JiYu})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        '
        'JiYu
        '
        Me.JiYu.Caption = strJIYU
        Me.JiYu.FieldName = "PM_JiYu"
        Me.JiYu.Name = "JiYu"
        Me.JiYu.Visible = True
        Me.JiYu.VisibleIndex = 1
        '
        'cboPro_Type
        '
        Me.cboPro_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPro_Type.Location = New System.Drawing.Point(100, 19)
        Me.cboPro_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.cboPro_Type.Name = "cboPro_Type"
        Me.cboPro_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPro_Type.Properties.Appearance.Options.UseFont = True
        Me.cboPro_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPro_Type.Properties.Items.AddRange(New Object() {"生產加工", "裝配出貨", "胚部加工", "品質檢查"})
        Me.cboPro_Type.Properties.NullText = "生產加工"
        Me.cboPro_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPro_Type.Size = New System.Drawing.Size(325, 24)
        Me.cboPro_Type.TabIndex = 1
        '
        'txtPP_ActionUser
        '
        Me.txtPP_ActionUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPP_ActionUser.Location = New System.Drawing.Point(100, 55)
        Me.txtPP_ActionUser.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPP_ActionUser.Name = "txtPP_ActionUser"
        Me.txtPP_ActionUser.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPP_ActionUser.Properties.Appearance.Options.UseFont = True
        Me.txtPP_ActionUser.Size = New System.Drawing.Size(325, 24)
        Me.txtPP_ActionUser.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(41, 93)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "備注(&R):"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(437, 60)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "建立日期(&D):"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(25, 60)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 15)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "操作人(&U):"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(686, 24)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "配件名稱(&N):"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(434, 24)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "產品編號(&M):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 24)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "工藝類型(&T):"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseBackColor = True
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(694, 12)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "工藝單號(&I):"
        '
        'txtPP_ID
        '
        Me.txtPP_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPP_ID.Location = New System.Drawing.Point(779, 7)
        Me.txtPP_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPP_ID.Name = "txtPP_ID"
        Me.txtPP_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPP_ID.Properties.Appearance.Options.UseFont = True
        Me.txtPP_ID.Properties.ReadOnly = True
        Me.txtPP_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtPP_ID.TabIndex = 18
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 185)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(939, 282)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PopupContainerControl1)
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(930, 250)
        Me.XtraTabPage1.Text = "計件工藝"
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.Grid1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(6, 71)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(187, 209)
        Me.PopupContainerControl1.TabIndex = 1
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView3
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(187, 209)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepID, Me.DepName})
        Me.GridView3.GridControl = Me.Grid1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 0
        Me.DepID.Width = 70
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 1
        Me.DepName.Width = 96
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(2, 3)
        Me.Grid.MainView = Me.GridView2
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemLookUpEdit5})
        Me.Grid.Size = New System.Drawing.Size(926, 244)
        Me.Grid.TabIndex = 12
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdd, Me.MenuInsert, Me.MenuDel})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(148, 70)
        '
        'MenuAdd
        '
        Me.MenuAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.MenuAdd.Name = "MenuAdd"
        Me.MenuAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuAdd.Size = New System.Drawing.Size(147, 22)
        Me.MenuAdd.Text = "添加(&A)"
        '
        'MenuInsert
        '
        Me.MenuInsert.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.MenuInsert.Name = "MenuInsert"
        Me.MenuInsert.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.MenuInsert.Size = New System.Drawing.Size(147, 22)
        Me.MenuInsert.Text = "插入(&T)"
        '
        'MenuDel
        '
        Me.MenuDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.MenuDel.Name = "MenuDel"
        Me.MenuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuDel.Size = New System.Drawing.Size(147, 22)
        Me.MenuDel.Text = "刪除(&D)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.PP_Num, Me.PS_NO, Me.PS_Name, Me.PP_N_Name, Me.DPT_PName, Me.DPT_ID, Me.DPT_Name, Me.PP_Price, Me.PP_PriceCheck, Me.PP_Factor, Me.PP_FactorCheck, Me.PP_Type, Me.PP_Explain, Me.PP_BeginUseDate, Me.PP_EndUseDate, Me.RemnantDays, Me.PP_BeginUse})
        Me.GridView2.GridControl = Me.Grid
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'PP_Num
        '
        Me.PP_Num.AppearanceCell.Options.UseTextOptions = True
        Me.PP_Num.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PP_Num.Caption = "次序"
        Me.PP_Num.FieldName = "PP_Num"
        Me.PP_Num.Name = "PP_Num"
        Me.PP_Num.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_Num.OptionsColumn.ReadOnly = True
        Me.PP_Num.Width = 45
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "大工序名稱"
        Me.PS_NO.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PS_NO.OptionsColumn.ReadOnly = True
        Me.PS_NO.Visible = True
        Me.PS_NO.VisibleIndex = 0
        Me.PS_NO.Width = 85
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PS_NO", "工序編號", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PS_Name", "大工序名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "大工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.Width = 80
        '
        'PP_N_Name
        '
        Me.PP_N_Name.Caption = "小工序名稱"
        Me.PP_N_Name.FieldName = "PP_N_Name"
        Me.PP_N_Name.Name = "PP_N_Name"
        Me.PP_N_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_N_Name.Visible = True
        Me.PP_N_Name.VisibleIndex = 1
        Me.PP_N_Name.Width = 80
        '
        'DPT_PName
        '
        Me.DPT_PName.Caption = "廠別名稱"
        Me.DPT_PName.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.DPT_PName.FieldName = "DPT_PName"
        Me.DPT_PName.Name = "DPT_PName"
        Me.DPT_PName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DPT_PName.Visible = True
        Me.DPT_PName.VisibleIndex = 2
        Me.DPT_PName.Width = 80
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "編號", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'DPT_ID
        '
        Me.DPT_ID.Caption = "部門編號"
        Me.DPT_ID.FieldName = "DPT_ID"
        Me.DPT_ID.Name = "DPT_ID"
        Me.DPT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'DPT_Name
        '
        Me.DPT_Name.Caption = "部門名稱"
        Me.DPT_Name.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.DPT_Name.FieldName = "DPT_Name"
        Me.DPT_Name.Name = "DPT_Name"
        Me.DPT_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DPT_Name.Visible = True
        Me.DPT_Name.VisibleIndex = 3
        Me.DPT_Name.Width = 70
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl1
        '
        'PP_Price
        '
        Me.PP_Price.Caption = "工價"
        Me.PP_Price.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.PP_Price.FieldName = "PP_Price"
        Me.PP_Price.Name = "PP_Price"
        Me.PP_Price.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_Price.Visible = True
        Me.PP_Price.VisibleIndex = 4
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'PP_PriceCheck
        '
        Me.PP_PriceCheck.Caption = "工價審核"
        Me.PP_PriceCheck.FieldName = "PP_PriceCheck"
        Me.PP_PriceCheck.Name = "PP_PriceCheck"
        Me.PP_PriceCheck.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_PriceCheck.Visible = True
        Me.PP_PriceCheck.VisibleIndex = 5
        '
        'PP_Factor
        '
        Me.PP_Factor.AppearanceCell.Options.UseTextOptions = True
        Me.PP_Factor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PP_Factor.Caption = "承包系數"
        Me.PP_Factor.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.PP_Factor.FieldName = "PP_Factor"
        Me.PP_Factor.Name = "PP_Factor"
        Me.PP_Factor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_Factor.Visible = True
        Me.PP_Factor.VisibleIndex = 6
        Me.PP_Factor.Width = 70
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'PP_FactorCheck
        '
        Me.PP_FactorCheck.Caption = "系數審核"
        Me.PP_FactorCheck.FieldName = "PP_FactorCheck"
        Me.PP_FactorCheck.Name = "PP_FactorCheck"
        Me.PP_FactorCheck.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_FactorCheck.Visible = True
        Me.PP_FactorCheck.VisibleIndex = 7
        '
        'PP_Type
        '
        Me.PP_Type.Caption = "類型"
        Me.PP_Type.ColumnEdit = Me.RepositoryItemComboBox1
        Me.PP_Type.FieldName = "PP_Type"
        Me.PP_Type.Name = "PP_Type"
        Me.PP_Type.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_Type.Visible = True
        Me.PP_Type.VisibleIndex = 8
        Me.PP_Type.Width = 50
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"大貨", "返修"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'PP_Explain
        '
        Me.PP_Explain.Caption = "說明"
        Me.PP_Explain.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.PP_Explain.FieldName = "PP_Explain"
        Me.PP_Explain.Name = "PP_Explain"
        Me.PP_Explain.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_Explain.Visible = True
        Me.PP_Explain.VisibleIndex = 9
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'PP_BeginUseDate
        '
        Me.PP_BeginUseDate.Caption = "啟用日期"
        Me.PP_BeginUseDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.PP_BeginUseDate.FieldName = "PP_BeginUseDate"
        Me.PP_BeginUseDate.Name = "PP_BeginUseDate"
        Me.PP_BeginUseDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_BeginUseDate.Visible = True
        Me.PP_BeginUseDate.VisibleIndex = 10
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'PP_EndUseDate
        '
        Me.PP_EndUseDate.Caption = "結束日期"
        Me.PP_EndUseDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.PP_EndUseDate.FieldName = "PP_EndUseDate"
        Me.PP_EndUseDate.Name = "PP_EndUseDate"
        Me.PP_EndUseDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_EndUseDate.Visible = True
        Me.PP_EndUseDate.VisibleIndex = 11
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RemnantDays
        '
        Me.RemnantDays.AppearanceCell.Options.UseTextOptions = True
        Me.RemnantDays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RemnantDays.Caption = "剩余天數"
        Me.RemnantDays.FieldName = "RemnantDays"
        Me.RemnantDays.Name = "RemnantDays"
        Me.RemnantDays.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.RemnantDays.OptionsColumn.ReadOnly = True
        Me.RemnantDays.Visible = True
        Me.RemnantDays.VisibleIndex = 12
        Me.RemnantDays.Width = 70
        '
        'PP_BeginUse
        '
        Me.PP_BeginUse.Caption = "啟用"
        Me.PP_BeginUse.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.PP_BeginUse.FieldName = "PP_BeginUse"
        Me.PP_BeginUse.Name = "PP_BeginUse"
        Me.PP_BeginUse.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PP_BeginUse.OptionsColumn.ReadOnly = True
        Me.PP_BeginUse.Width = 50
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PS_NO", "工序編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PS_Name", "工序名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnOK.Location = New System.Drawing.Point(773, 489)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 15
        Me.btnOK.Text = "確定(&O)"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(859, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "取消(&C)"
        '
        'chkPP_Check
        '
        Me.chkPP_Check.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPP_Check.Location = New System.Drawing.Point(460, 489)
        Me.chkPP_Check.Name = "chkPP_Check"
        Me.chkPP_Check.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPP_Check.Properties.Appearance.Options.UseFont = True
        Me.chkPP_Check.Properties.Caption = "審核確認(&K)"
        Me.chkPP_Check.Size = New System.Drawing.Size(109, 20)
        Me.chkPP_Check.TabIndex = 14
        Me.chkPP_Check.Visible = False
        '
        'btnAllUse
        '
        Me.btnAllUse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAllUse.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAllUse.Appearance.Options.UseFont = True
        Me.btnAllUse.Location = New System.Drawing.Point(364, 484)
        Me.btnAllUse.Name = "btnAllUse"
        Me.btnAllUse.Size = New System.Drawing.Size(90, 28)
        Me.btnAllUse.TabIndex = 13
        Me.btnAllUse.Text = "全部啟用(&A)"
        Me.btnAllUse.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LabelCheckID)
        Me.Panel1.Controls.Add(Me.lblPP_CheckDate)
        Me.Panel1.Controls.Add(Me.lblPP_CheckUserName)
        Me.Panel1.Controls.Add(Me.lblCheckDate)
        Me.Panel1.Controls.Add(Me.lblCheckName)
        Me.Panel1.Location = New System.Drawing.Point(569, 473)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 49)
        Me.Panel1.TabIndex = 25
        '
        'LabelCheckID
        '
        Me.LabelCheckID.AutoSize = True
        Me.LabelCheckID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCheckID.Location = New System.Drawing.Point(6, 20)
        Me.LabelCheckID.Name = "LabelCheckID"
        Me.LabelCheckID.Size = New System.Drawing.Size(39, 13)
        Me.LabelCheckID.TabIndex = 29
        Me.LabelCheckID.Text = "Label1"
        Me.LabelCheckID.Visible = False
        '
        'lblPP_CheckDate
        '
        Me.lblPP_CheckDate.AutoSize = True
        Me.lblPP_CheckDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPP_CheckDate.Location = New System.Drawing.Point(71, 31)
        Me.lblPP_CheckDate.Name = "lblPP_CheckDate"
        Me.lblPP_CheckDate.Size = New System.Drawing.Size(39, 13)
        Me.lblPP_CheckDate.TabIndex = 28
        Me.lblPP_CheckDate.Text = "Label1"
        Me.lblPP_CheckDate.Visible = False
        '
        'lblPP_CheckUserName
        '
        Me.lblPP_CheckUserName.AutoSize = True
        Me.lblPP_CheckUserName.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPP_CheckUserName.Location = New System.Drawing.Point(71, 6)
        Me.lblPP_CheckUserName.Name = "lblPP_CheckUserName"
        Me.lblPP_CheckUserName.Size = New System.Drawing.Size(39, 13)
        Me.lblPP_CheckUserName.TabIndex = 27
        Me.lblPP_CheckUserName.Text = "Label1"
        Me.lblPP_CheckUserName.Visible = False
        '
        'lblCheckDate
        '
        Me.lblCheckDate.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Appearance.Options.UseFont = True
        Me.lblCheckDate.Location = New System.Drawing.Point(3, 31)
        Me.lblCheckDate.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(55, 13)
        Me.lblCheckDate.TabIndex = 26
        Me.lblCheckDate.Text = "審核日期:"
        Me.lblCheckDate.Visible = False
        '
        'lblCheckName
        '
        Me.lblCheckName.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckName.Appearance.Options.UseFont = True
        Me.lblCheckName.Location = New System.Drawing.Point(3, 6)
        Me.lblCheckName.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.lblCheckName.Name = "lblCheckName"
        Me.lblCheckName.Size = New System.Drawing.Size(42, 13)
        Me.lblCheckName.TabIndex = 25
        Me.lblCheckName.Text = "審核人:"
        Me.lblCheckName.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.LabelControl7)
        Me.Panel2.Controls.Add(Me.LabPP_PriceCheckDate)
        Me.Panel2.Controls.Add(Me.LabelControl9)
        Me.Panel2.Controls.Add(Me.LabPP_PriceCheckUserID)
        Me.Panel2.Location = New System.Drawing.Point(3, 473)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 48)
        Me.Panel2.TabIndex = 34
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "審核日期:"
        Me.LabelControl7.Visible = False
        '
        'LabPP_PriceCheckDate
        '
        Me.LabPP_PriceCheckDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabPP_PriceCheckDate.AutoSize = True
        Me.LabPP_PriceCheckDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPP_PriceCheckDate.Location = New System.Drawing.Point(76, 28)
        Me.LabPP_PriceCheckDate.Name = "LabPP_PriceCheckDate"
        Me.LabPP_PriceCheckDate.Size = New System.Drawing.Size(39, 13)
        Me.LabPP_PriceCheckDate.TabIndex = 32
        Me.LabPP_PriceCheckDate.Text = "Label1"
        Me.LabPP_PriceCheckDate.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(5, 4)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl9.TabIndex = 29
        Me.LabelControl9.Text = "工價審核人:"
        Me.LabelControl9.Visible = False
        '
        'LabPP_PriceCheckUserID
        '
        Me.LabPP_PriceCheckUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabPP_PriceCheckUserID.AutoSize = True
        Me.LabPP_PriceCheckUserID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPP_PriceCheckUserID.Location = New System.Drawing.Point(76, 5)
        Me.LabPP_PriceCheckUserID.Name = "LabPP_PriceCheckUserID"
        Me.LabPP_PriceCheckUserID.Size = New System.Drawing.Size(39, 13)
        Me.LabPP_PriceCheckUserID.TabIndex = 31
        Me.LabPP_PriceCheckUserID.Text = "Label1"
        Me.LabPP_PriceCheckUserID.Visible = False
        '
        'frmProductionPieceProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(943, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtPP_ID)
        Me.Controls.Add(Me.btnAllUse)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.chkPP_Check)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionPieceProcess"
        Me.Text = "計件工藝單--新增"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPP_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePP_ActionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPro_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPP_ActionUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPP_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPP_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTittle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPP_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboPro_Type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPP_ActionUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gluPM_Type As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtePP_ActionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPP_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_N_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_PName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Explain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_BeginUseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PP_Factor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_EndUseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PP_BeginUse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RemnantDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPP_Check As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAllUse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPP_CheckDate As System.Windows.Forms.Label
    Friend WithEvents lblPP_CheckUserName As System.Windows.Forms.Label
    Friend WithEvents lblCheckDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCheckName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabPP_PriceCheckDate As System.Windows.Forms.Label
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabPP_PriceCheckUserID As System.Windows.Forms.Label
    Friend WithEvents PP_PriceCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_FactorCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelCheckID As System.Windows.Forms.Label
End Class
