<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPiecePersonnel
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
        Me.LabCaption = New System.Windows.Forms.Label
        Me.TxtPer_NO = New DevExpress.XtraEditors.TextEdit
        Me.LabPer_NO = New System.Windows.Forms.Label
        Me.TxtPer_Name = New DevExpress.XtraEditors.TextEdit
        Me.LabPer_Name = New System.Windows.Forms.Label
        Me.LabG_NO = New System.Windows.Forms.Label
        Me.GluG_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MemoPer_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.LabG_Remark = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.LabDepID1 = New System.Windows.Forms.Label
        Me.LabPer_DayPrice = New System.Windows.Forms.Label
        Me.txtPer_DayPrice = New DevExpress.XtraEditors.TextEdit
        Me.CaoTypeLabel = New System.Windows.Forms.Label
        Me.LabAutoID = New System.Windows.Forms.Label
        Me.txtDepID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboPer_Class = New DevExpress.XtraEditors.ComboBoxEdit
        Me.luePer_PayType = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFacID = New System.Windows.Forms.Label
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserDep_Fac = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.TxtPer_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoPer_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPer_DayPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePer_PayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.ForeColor = System.Drawing.Color.Navy
        Me.LabCaption.Location = New System.Drawing.Point(10, 10)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(153, 21)
        Me.LabCaption.TabIndex = 264
        Me.LabCaption.Text = "員工名單-新增"
        '
        'TxtPer_NO
        '
        Me.TxtPer_NO.EditValue = ""
        Me.TxtPer_NO.Location = New System.Drawing.Point(73, 20)
        Me.TxtPer_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtPer_NO.Name = "TxtPer_NO"
        Me.TxtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.TxtPer_NO.Size = New System.Drawing.Size(90, 25)
        Me.TxtPer_NO.TabIndex = 1
        '
        'LabPer_NO
        '
        Me.LabPer_NO.AutoSize = True
        Me.LabPer_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPer_NO.Location = New System.Drawing.Point(14, 24)
        Me.LabPer_NO.Name = "LabPer_NO"
        Me.LabPer_NO.Size = New System.Drawing.Size(56, 15)
        Me.LabPer_NO.TabIndex = 0
        Me.LabPer_NO.Text = "工號(&I):"
        '
        'TxtPer_Name
        '
        Me.TxtPer_Name.EditValue = ""
        Me.TxtPer_Name.Location = New System.Drawing.Point(229, 20)
        Me.TxtPer_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtPer_Name.Name = "TxtPer_Name"
        Me.TxtPer_Name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPer_Name.Properties.Appearance.Options.UseFont = True
        Me.TxtPer_Name.Properties.ReadOnly = True
        Me.TxtPer_Name.Size = New System.Drawing.Size(84, 25)
        Me.TxtPer_Name.TabIndex = 3
        Me.TxtPer_Name.TabStop = False
        '
        'LabPer_Name
        '
        Me.LabPer_Name.AutoSize = True
        Me.LabPer_Name.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPer_Name.Location = New System.Drawing.Point(166, 25)
        Me.LabPer_Name.Name = "LabPer_Name"
        Me.LabPer_Name.Size = New System.Drawing.Size(61, 15)
        Me.LabPer_Name.TabIndex = 2
        Me.LabPer_Name.Text = "姓名(&N):"
        '
        'LabG_NO
        '
        Me.LabG_NO.AutoSize = True
        Me.LabG_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_NO.Location = New System.Drawing.Point(10, 133)
        Me.LabG_NO.Name = "LabG_NO"
        Me.LabG_NO.Size = New System.Drawing.Size(60, 15)
        Me.LabG_NO.TabIndex = 8
        Me.LabG_NO.Text = "組別(&B):"
        '
        'GluG_NO
        '
        Me.GluG_NO.EditValue = ""
        Me.GluG_NO.Location = New System.Drawing.Point(73, 129)
        Me.GluG_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.GluG_NO.Name = "GluG_NO"
        Me.GluG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluG_NO.Properties.Appearance.Options.UseFont = True
        Me.GluG_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluG_NO.Properties.NullText = ""
        Me.GluG_NO.Properties.View = Me.GridView1
        Me.GluG_NO.Size = New System.Drawing.Size(90, 24)
        Me.GluG_NO.TabIndex = 9
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
        'MemoPer_Remark
        '
        Me.MemoPer_Remark.Location = New System.Drawing.Point(73, 202)
        Me.MemoPer_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.MemoPer_Remark.Name = "MemoPer_Remark"
        Me.MemoPer_Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoPer_Remark.Properties.Appearance.Options.UseFont = True
        Me.MemoPer_Remark.Size = New System.Drawing.Size(240, 50)
        Me.MemoPer_Remark.TabIndex = 15
        '
        'LabG_Remark
        '
        Me.LabG_Remark.AutoSize = True
        Me.LabG_Remark.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_Remark.Location = New System.Drawing.Point(10, 206)
        Me.LabG_Remark.Name = "LabG_Remark"
        Me.LabG_Remark.Size = New System.Drawing.Size(60, 15)
        Me.LabG_Remark.TabIndex = 14
        Me.LabG_Remark.Text = "備注(&R):"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(233, 21)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(140, 21)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "確認(&S)"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Location = New System.Drawing.Point(12, 21)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 28)
        Me.cmdAdd.TabIndex = 17
        Me.cmdAdd.Text = "增加(&A)"
        '
        'LabDepID1
        '
        Me.LabDepID1.AutoSize = True
        Me.LabDepID1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabDepID1.Location = New System.Drawing.Point(9, 97)
        Me.LabDepID1.Name = "LabDepID1"
        Me.LabDepID1.Size = New System.Drawing.Size(61, 15)
        Me.LabDepID1.TabIndex = 6
        Me.LabDepID1.Text = "部門(&D):"
        '
        'LabPer_DayPrice
        '
        Me.LabPer_DayPrice.AutoSize = True
        Me.LabPer_DayPrice.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPer_DayPrice.Location = New System.Drawing.Point(11, 170)
        Me.LabPer_DayPrice.Name = "LabPer_DayPrice"
        Me.LabPer_DayPrice.Size = New System.Drawing.Size(59, 15)
        Me.LabPer_DayPrice.TabIndex = 12
        Me.LabPer_DayPrice.Text = "日薪(&P):"
        '
        'txtPer_DayPrice
        '
        Me.txtPer_DayPrice.Location = New System.Drawing.Point(73, 165)
        Me.txtPer_DayPrice.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPer_DayPrice.Name = "txtPer_DayPrice"
        Me.txtPer_DayPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer_DayPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPer_DayPrice.Size = New System.Drawing.Size(240, 25)
        Me.txtPer_DayPrice.TabIndex = 13
        '
        'CaoTypeLabel
        '
        Me.CaoTypeLabel.AutoSize = True
        Me.CaoTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaoTypeLabel.Location = New System.Drawing.Point(38, 30)
        Me.CaoTypeLabel.Name = "CaoTypeLabel"
        Me.CaoTypeLabel.Size = New System.Drawing.Size(53, 12)
        Me.CaoTypeLabel.TabIndex = 265
        Me.CaoTypeLabel.Text = "操作類型"
        Me.CaoTypeLabel.Visible = False
        '
        'LabAutoID
        '
        Me.LabAutoID.AutoSize = True
        Me.LabAutoID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabAutoID.Location = New System.Drawing.Point(94, 30)
        Me.LabAutoID.Name = "LabAutoID"
        Me.LabAutoID.Size = New System.Drawing.Size(40, 12)
        Me.LabAutoID.TabIndex = 266
        Me.LabAutoID.Text = "AutoID"
        Me.LabAutoID.Visible = False
        '
        'txtDepID
        '
        Me.txtDepID.Location = New System.Drawing.Point(73, 93)
        Me.txtDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDepID.Name = "txtDepID"
        Me.txtDepID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtDepID.Properties.Appearance.Options.UseFont = True
        Me.txtDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDepID.Properties.NullText = ""
        Me.txtDepID.Properties.View = Me.GridLookUpEdit1View
        Me.txtDepID.Size = New System.Drawing.Size(240, 24)
        Me.txtDepID.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.UserDep_Fac, Me.DepID, Me.FacName, Me.DepName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PicCaption
        '
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(4, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(325, 36)
        Me.PicCaption.TabIndex = 263
        Me.PicCaption.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPer_Class)
        Me.GroupBox1.Controls.Add(Me.luePer_PayType)
        Me.GroupBox1.Controls.Add(Me.GluG_NO)
        Me.GroupBox1.Controls.Add(Me.MemoPer_Remark)
        Me.GroupBox1.Controls.Add(Me.txtPer_DayPrice)
        Me.GroupBox1.Controls.Add(Me.txtDepID)
        Me.GroupBox1.Controls.Add(Me.TxtPer_NO)
        Me.GroupBox1.Controls.Add(Me.TxtPer_Name)
        Me.GroupBox1.Controls.Add(Me.LabPer_Name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabG_NO)
        Me.GroupBox1.Controls.Add(Me.LabPer_DayPrice)
        Me.GroupBox1.Controls.Add(Me.LabPer_NO)
        Me.GroupBox1.Controls.Add(Me.LabG_Remark)
        Me.GroupBox1.Controls.Add(Me.LabDepID1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboPer_Class
        '
        Me.cboPer_Class.Location = New System.Drawing.Point(229, 129)
        Me.cboPer_Class.Name = "cboPer_Class"
        Me.cboPer_Class.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPer_Class.Properties.Appearance.Options.UseFont = True
        Me.cboPer_Class.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPer_Class.Properties.Items.AddRange(New Object() {"A", "B"})
        Me.cboPer_Class.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPer_Class.Size = New System.Drawing.Size(83, 24)
        Me.cboPer_Class.TabIndex = 11
        '
        'luePer_PayType
        '
        Me.luePer_PayType.Location = New System.Drawing.Point(73, 57)
        Me.luePer_PayType.Margin = New System.Windows.Forms.Padding(6)
        Me.luePer_PayType.Name = "luePer_PayType"
        Me.luePer_PayType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luePer_PayType.Properties.Appearance.Options.UseFont = True
        Me.luePer_PayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePer_PayType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Per_PayType", "", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark")})
        Me.luePer_PayType.Properties.DropDownRows = 3
        Me.luePer_PayType.Properties.NullText = "計件"
        Me.luePer_PayType.Properties.ShowFooter = False
        Me.luePer_PayType.Properties.ShowHeader = False
        Me.luePer_PayType.Properties.ShowLines = False
        Me.luePer_PayType.Size = New System.Drawing.Size(90, 24)
        Me.luePer_PayType.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "班制(&E):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "類型(&T):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 64)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'txtFacID
        '
        Me.txtFacID.AutoSize = True
        Me.txtFacID.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtFacID.Location = New System.Drawing.Point(140, 30)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.Size = New System.Drawing.Size(45, 12)
        Me.txtFacID.TabIndex = 2
        Me.txtFacID.Text = "txtFacID"
        Me.txtFacID.Visible = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "組別編號"
        Me.GridColumn1.FieldName = "G_NO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "組別名稱"
        Me.GridColumn2.FieldName = "G_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'UserDep_Fac
        '
        Me.UserDep_Fac.Caption = "GridColumn6"
        Me.UserDep_Fac.FieldName = "UserDep_Fac"
        Me.UserDep_Fac.Name = "UserDep_Fac"
        '
        'DepID
        '
        Me.DepID.Caption = "部門代號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 0
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.FieldName = "G_FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 1
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "G_DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 2
        '
        'ProductionPiecePersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(334, 377)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabAutoID)
        Me.Controls.Add(Me.CaoTypeLabel)
        Me.Controls.Add(Me.txtFacID)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PicCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductionPiecePersonnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "員工名單-新增"
        CType(Me.TxtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoPer_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_DayPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePer_PayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPer_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabPer_NO As System.Windows.Forms.Label
    Friend WithEvents TxtPer_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabPer_Name As System.Windows.Forms.Label
    Friend WithEvents LabG_NO As System.Windows.Forms.Label
    Friend WithEvents GluG_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoPer_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabG_Remark As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabDepID1 As System.Windows.Forms.Label
    Friend WithEvents LabPer_DayPrice As System.Windows.Forms.Label
    Friend WithEvents txtPer_DayPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CaoTypeLabel As System.Windows.Forms.Label
    Friend WithEvents LabAutoID As System.Windows.Forms.Label
    Friend WithEvents txtDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDep_Fac As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents luePer_PayType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFacID As System.Windows.Forms.Label
    Friend WithEvents cboPer_Class As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
