<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompany
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
        Me.pPhoto = New System.Windows.Forms.PictureBox
        Me.LabCO_ID = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtCO_ChsName = New DevExpress.XtraEditors.TextEdit
        Me.labCO_ChsName = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_EngName = New DevExpress.XtraEditors.TextEdit
        Me.labCO_EngName = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_ChsAddress = New DevExpress.XtraEditors.TextEdit
        Me.labCO_ChsAddress = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_EngAddress = New DevExpress.XtraEditors.TextEdit
        Me.labCO_EngAddress = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_ChsTel = New DevExpress.XtraEditors.TextEdit
        Me.LabCO_ChsTel = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_EngTel = New DevExpress.XtraEditors.TextEdit
        Me.LabCO_EngTel = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_ChsFax = New DevExpress.XtraEditors.TextEdit
        Me.LabCO_ChsFax = New DevExpress.XtraEditors.LabelControl
        Me.txtCO_EngFax = New DevExpress.XtraEditors.TextEdit
        Me.labCO_EngFax = New DevExpress.XtraEditors.LabelControl
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ConStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStrip = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabCaption = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.ButtonLoad = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.BottonClr = New DevExpress.XtraEditors.SimpleButton
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ChsName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_EngName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ChsAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_EngAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ChsTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_EngTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_ChsFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO_EngFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPhoto
        '
        Me.pPhoto.BackColor = System.Drawing.Color.Transparent
        Me.pPhoto.Location = New System.Drawing.Point(3, 5)
        Me.pPhoto.Name = "pPhoto"
        Me.pPhoto.Size = New System.Drawing.Size(382, 274)
        Me.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pPhoto.TabIndex = 50
        Me.pPhoto.TabStop = False
        '
        'LabCO_ID
        '
        Me.LabCO_ID.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCO_ID.Appearance.Options.UseFont = True
        Me.LabCO_ID.Location = New System.Drawing.Point(6, 21)
        Me.LabCO_ID.Name = "LabCO_ID"
        Me.LabCO_ID.Size = New System.Drawing.Size(65, 18)
        Me.LabCO_ID.TabIndex = 1
        Me.LabCO_ID.Text = "公司代號:"
        '
        'txtCO_ID
        '
        Me.txtCO_ID.Location = New System.Drawing.Point(77, 18)
        Me.txtCO_ID.Name = "txtCO_ID"
        Me.txtCO_ID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ID.Size = New System.Drawing.Size(115, 25)
        Me.txtCO_ID.TabIndex = 2
        '
        'txtCO_ChsName
        '
        Me.txtCO_ChsName.Location = New System.Drawing.Point(77, 55)
        Me.txtCO_ChsName.Name = "txtCO_ChsName"
        Me.txtCO_ChsName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_ChsName.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ChsName.Size = New System.Drawing.Size(300, 25)
        Me.txtCO_ChsName.TabIndex = 4
        '
        'labCO_ChsName
        '
        Me.labCO_ChsName.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCO_ChsName.Appearance.Options.UseFont = True
        Me.labCO_ChsName.Location = New System.Drawing.Point(6, 58)
        Me.labCO_ChsName.Name = "labCO_ChsName"
        Me.labCO_ChsName.Size = New System.Drawing.Size(65, 18)
        Me.labCO_ChsName.TabIndex = 3
        Me.labCO_ChsName.Text = "中文名稱:"
        '
        'txtCO_EngName
        '
        Me.txtCO_EngName.EditValue = ""
        Me.txtCO_EngName.Location = New System.Drawing.Point(77, 92)
        Me.txtCO_EngName.Name = "txtCO_EngName"
        Me.txtCO_EngName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_EngName.Properties.Appearance.Options.UseFont = True
        Me.txtCO_EngName.Size = New System.Drawing.Size(300, 25)
        Me.txtCO_EngName.TabIndex = 6
        '
        'labCO_EngName
        '
        Me.labCO_EngName.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCO_EngName.Appearance.Options.UseFont = True
        Me.labCO_EngName.Location = New System.Drawing.Point(6, 95)
        Me.labCO_EngName.Name = "labCO_EngName"
        Me.labCO_EngName.Size = New System.Drawing.Size(65, 18)
        Me.labCO_EngName.TabIndex = 5
        Me.labCO_EngName.Text = "英文名稱:"
        '
        'txtCO_ChsAddress
        '
        Me.txtCO_ChsAddress.EditValue = ""
        Me.txtCO_ChsAddress.Location = New System.Drawing.Point(77, 129)
        Me.txtCO_ChsAddress.Name = "txtCO_ChsAddress"
        Me.txtCO_ChsAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_ChsAddress.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ChsAddress.Size = New System.Drawing.Size(300, 25)
        Me.txtCO_ChsAddress.TabIndex = 8
        '
        'labCO_ChsAddress
        '
        Me.labCO_ChsAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCO_ChsAddress.Appearance.Options.UseFont = True
        Me.labCO_ChsAddress.Location = New System.Drawing.Point(6, 132)
        Me.labCO_ChsAddress.Name = "labCO_ChsAddress"
        Me.labCO_ChsAddress.Size = New System.Drawing.Size(65, 18)
        Me.labCO_ChsAddress.TabIndex = 7
        Me.labCO_ChsAddress.Text = "中文地址:"
        '
        'txtCO_EngAddress
        '
        Me.txtCO_EngAddress.EditValue = ""
        Me.txtCO_EngAddress.Location = New System.Drawing.Point(77, 166)
        Me.txtCO_EngAddress.Name = "txtCO_EngAddress"
        Me.txtCO_EngAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_EngAddress.Properties.Appearance.Options.UseFont = True
        Me.txtCO_EngAddress.Size = New System.Drawing.Size(300, 25)
        Me.txtCO_EngAddress.TabIndex = 10
        '
        'labCO_EngAddress
        '
        Me.labCO_EngAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCO_EngAddress.Appearance.Options.UseFont = True
        Me.labCO_EngAddress.Location = New System.Drawing.Point(6, 169)
        Me.labCO_EngAddress.Name = "labCO_EngAddress"
        Me.labCO_EngAddress.Size = New System.Drawing.Size(65, 18)
        Me.labCO_EngAddress.TabIndex = 9
        Me.labCO_EngAddress.Text = "英文地址:"
        '
        'txtCO_ChsTel
        '
        Me.txtCO_ChsTel.EditValue = ""
        Me.txtCO_ChsTel.Location = New System.Drawing.Point(77, 205)
        Me.txtCO_ChsTel.Name = "txtCO_ChsTel"
        Me.txtCO_ChsTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_ChsTel.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ChsTel.Size = New System.Drawing.Size(115, 25)
        Me.txtCO_ChsTel.TabIndex = 12
        '
        'LabCO_ChsTel
        '
        Me.LabCO_ChsTel.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCO_ChsTel.Appearance.Options.UseFont = True
        Me.LabCO_ChsTel.Location = New System.Drawing.Point(6, 206)
        Me.LabCO_ChsTel.Name = "LabCO_ChsTel"
        Me.LabCO_ChsTel.Size = New System.Drawing.Size(65, 18)
        Me.LabCO_ChsTel.TabIndex = 11
        Me.LabCO_ChsTel.Text = "中文電話:"
        '
        'txtCO_EngTel
        '
        Me.txtCO_EngTel.EditValue = ""
        Me.txtCO_EngTel.Location = New System.Drawing.Point(262, 205)
        Me.txtCO_EngTel.Name = "txtCO_EngTel"
        Me.txtCO_EngTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_EngTel.Properties.Appearance.Options.UseFont = True
        Me.txtCO_EngTel.Size = New System.Drawing.Size(115, 25)
        Me.txtCO_EngTel.TabIndex = 67
        '
        'LabCO_EngTel
        '
        Me.LabCO_EngTel.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCO_EngTel.Appearance.Options.UseFont = True
        Me.LabCO_EngTel.Location = New System.Drawing.Point(195, 206)
        Me.LabCO_EngTel.Name = "LabCO_EngTel"
        Me.LabCO_EngTel.Size = New System.Drawing.Size(65, 18)
        Me.LabCO_EngTel.TabIndex = 13
        Me.LabCO_EngTel.Text = "英文電話:"
        '
        'txtCO_ChsFax
        '
        Me.txtCO_ChsFax.EditValue = ""
        Me.txtCO_ChsFax.Location = New System.Drawing.Point(77, 243)
        Me.txtCO_ChsFax.Name = "txtCO_ChsFax"
        Me.txtCO_ChsFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_ChsFax.Properties.Appearance.Options.UseFont = True
        Me.txtCO_ChsFax.Size = New System.Drawing.Size(115, 25)
        Me.txtCO_ChsFax.TabIndex = 15
        '
        'LabCO_ChsFax
        '
        Me.LabCO_ChsFax.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCO_ChsFax.Appearance.Options.UseFont = True
        Me.LabCO_ChsFax.Location = New System.Drawing.Point(6, 247)
        Me.LabCO_ChsFax.Name = "LabCO_ChsFax"
        Me.LabCO_ChsFax.Size = New System.Drawing.Size(65, 18)
        Me.LabCO_ChsFax.TabIndex = 14
        Me.LabCO_ChsFax.Text = "中文傳真:"
        '
        'txtCO_EngFax
        '
        Me.txtCO_EngFax.EditValue = ""
        Me.txtCO_EngFax.Location = New System.Drawing.Point(262, 243)
        Me.txtCO_EngFax.Name = "txtCO_EngFax"
        Me.txtCO_EngFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCO_EngFax.Properties.Appearance.Options.UseFont = True
        Me.txtCO_EngFax.Size = New System.Drawing.Size(115, 25)
        Me.txtCO_EngFax.TabIndex = 17
        '
        'labCO_EngFax
        '
        Me.labCO_EngFax.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCO_EngFax.Appearance.Options.UseFont = True
        Me.labCO_EngFax.Location = New System.Drawing.Point(193, 246)
        Me.labCO_EngFax.Name = "labCO_EngFax"
        Me.labCO_EngFax.Size = New System.Drawing.Size(65, 18)
        Me.labCO_EngFax.TabIndex = 16
        Me.labCO_EngFax.Text = "英文傳真:"
        '
        'GB1
        '
        Me.GB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB1.Controls.Add(Me.LabCO_ID)
        Me.GB1.Controls.Add(Me.txtCO_ID)
        Me.GB1.Controls.Add(Me.txtCO_EngFax)
        Me.GB1.Controls.Add(Me.txtCO_ChsName)
        Me.GB1.Controls.Add(Me.LabCO_ChsFax)
        Me.GB1.Controls.Add(Me.labCO_ChsName)
        Me.GB1.Controls.Add(Me.txtCO_ChsFax)
        Me.GB1.Controls.Add(Me.txtCO_EngName)
        Me.GB1.Controls.Add(Me.labCO_EngName)
        Me.GB1.Controls.Add(Me.txtCO_EngTel)
        Me.GB1.Controls.Add(Me.txtCO_ChsAddress)
        Me.GB1.Controls.Add(Me.LabCO_ChsTel)
        Me.GB1.Controls.Add(Me.labCO_ChsAddress)
        Me.GB1.Controls.Add(Me.txtCO_ChsTel)
        Me.GB1.Controls.Add(Me.txtCO_EngAddress)
        Me.GB1.Controls.Add(Me.labCO_EngAddress)
        Me.GB1.Controls.Add(Me.labCO_EngFax)
        Me.GB1.Controls.Add(Me.LabCO_EngTel)
        Me.GB1.Location = New System.Drawing.Point(3, -3)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(389, 312)
        Me.GB1.TabIndex = 73
        Me.GB1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ConStrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 39)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(140, 344)
        Me.Grid1.TabIndex = 75
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ConStrip
        '
        Me.ConStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStrip})
        Me.ConStrip.Name = "ConStrip"
        Me.ConStrip.Size = New System.Drawing.Size(157, 26)
        '
        'DelToolStrip
        '
        Me.DelToolStrip.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DelToolStrip.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.DelToolStrip.Name = "DelToolStrip"
        Me.DelToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DelToolStrip.Size = New System.Drawing.Size(156, 22)
        Me.DelToolStrip.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CO_ID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司代號"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        Me.CO_ID.OptionsColumn.AllowEdit = False
        Me.CO_ID.OptionsColumn.AllowFocus = False
        Me.CO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CO_ID.Visible = True
        Me.CO_ID.VisibleIndex = 0
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.ForeColor = System.Drawing.Color.Navy
        Me.LabCaption.Location = New System.Drawing.Point(8, 8)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(98, 21)
        Me.LabCaption.TabIndex = 321
        Me.LabCaption.Text = "公司信息"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(2, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(538, 36)
        Me.PicCaption.TabIndex = 320
        Me.PicCaption.TabStop = False
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonLoad.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad.Appearance.Options.UseFont = True
        Me.ButtonLoad.Location = New System.Drawing.Point(3, 282)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(74, 27)
        Me.ButtonLoad.TabIndex = 19
        Me.ButtonLoad.Text = "載入logo"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(448, 389)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(326, 389)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "確認(&S)"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(140, 39)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(402, 344)
        Me.XtraTabControl1.TabIndex = 327
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GB1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(393, 312)
        Me.XtraTabPage1.Text = "公司資料"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.BottonClr)
        Me.XtraTabPage2.Controls.Add(Me.pPhoto)
        Me.XtraTabPage2.Controls.Add(Me.ButtonLoad)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(393, 312)
        Me.XtraTabPage2.Text = "公司LOGO"
        '
        'BottonClr
        '
        Me.BottonClr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BottonClr.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottonClr.Appearance.Options.UseFont = True
        Me.BottonClr.Location = New System.Drawing.Point(83, 282)
        Me.BottonClr.Name = "BottonClr"
        Me.BottonClr.Size = New System.Drawing.Size(74, 27)
        Me.BottonClr.TabIndex = 20
        Me.BottonClr.Text = "清除圖片"
        '
        'FrmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(541, 425)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PicCaption)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "公司信息操作"
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ChsName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_EngName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ChsAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_EngAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ChsTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_EngTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_ChsFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO_EngFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents LabCO_ID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCO_ChsName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labCO_ChsName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_EngName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labCO_EngName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_ChsAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labCO_ChsAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_EngAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labCO_EngAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_ChsTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabCO_ChsTel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_EngTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabCO_EngTel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_ChsFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabCO_ChsFax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO_EngFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labCO_EngFax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ConStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BottonClr As DevExpress.XtraEditors.SimpleButton
End Class
