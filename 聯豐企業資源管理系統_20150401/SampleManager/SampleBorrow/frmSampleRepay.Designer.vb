<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleRepay
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
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtRepayID = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.LabRRPer_ID1 = New System.Windows.Forms.Label
        Me.txtRRPer_ID = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkCheck = New DevExpress.XtraEditors.CheckEdit
        Me.gbCheck = New System.Windows.Forms.GroupBox
        Me.lblCheckDate = New DevExpress.XtraEditors.LabelControl
        Me.lblCheckUser = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.caeRepayQty = New DevExpress.XtraEditors.TextEdit
        Me.txtMaterialTypeID = New DevExpress.XtraEditors.TextEdit
        Me.gluD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPS_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcolPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcolSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolMaterialTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSO_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.caeQty = New DevExpress.XtraEditors.CalcEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.dteRepayDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtCardID = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtRepayID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRRPer_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCheck.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.caeRepayQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteRepayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(1, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "还料单号(&D):"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(4, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(106, 24)
        Me.lblTitle.TabIndex = 215
        Me.lblTitle.Text = "生产还料"
        '
        'txtRepayID
        '
        Me.txtRepayID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRepayID.Enabled = False
        Me.txtRepayID.Location = New System.Drawing.Point(90, 13)
        Me.txtRepayID.Name = "txtRepayID"
        Me.txtRepayID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtRepayID.Properties.Appearance.Options.UseFont = True
        Me.txtRepayID.Size = New System.Drawing.Size(169, 24)
        Me.txtRepayID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(2, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "还料数量(&R):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "产品编号(&E):"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(93, 171)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(415, 125)
        Me.txtRemarks.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "备       注(&M):"
        '
        'LabRRPer_ID1
        '
        Me.LabRRPer_ID1.AutoSize = True
        Me.LabRRPer_ID1.BackColor = System.Drawing.Color.Transparent
        Me.LabRRPer_ID1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabRRPer_ID1.ForeColor = System.Drawing.Color.Black
        Me.LabRRPer_ID1.Location = New System.Drawing.Point(-1, 47)
        Me.LabRRPer_ID1.Name = "LabRRPer_ID1"
        Me.LabRRPer_ID1.Size = New System.Drawing.Size(92, 15)
        Me.LabRRPer_ID1.TabIndex = 2
        Me.LabRRPer_ID1.Text = "部        门(&B):"
        '
        'txtRRPer_ID
        '
        Me.txtRRPer_ID.Enabled = False
        Me.txtRRPer_ID.Location = New System.Drawing.Point(516, 6)
        Me.txtRRPer_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRRPer_ID.Name = "txtRRPer_ID"
        Me.txtRRPer_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRRPer_ID.Properties.Appearance.Options.UseFont = True
        Me.txtRRPer_ID.Size = New System.Drawing.Size(98, 24)
        Me.txtRRPer_ID.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(266, 6)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(98, 24)
        Me.TextEdit1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(176, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "創建人員(&U):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(417, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "創建日期(&C):"
        '
        'chkCheck
        '
        Me.chkCheck.Location = New System.Drawing.Point(5, 16)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.chkCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.chkCheck.Properties.Appearance.Options.UseBackColor = True
        Me.chkCheck.Properties.Appearance.Options.UseFont = True
        Me.chkCheck.Properties.Caption = "审核"
        Me.chkCheck.Size = New System.Drawing.Size(63, 20)
        Me.chkCheck.TabIndex = 0
        '
        'gbCheck
        '
        Me.gbCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbCheck.Controls.Add(Me.lblCheckDate)
        Me.gbCheck.Controls.Add(Me.lblCheckUser)
        Me.gbCheck.Controls.Add(Me.chkCheck)
        Me.gbCheck.Location = New System.Drawing.Point(3, 339)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(302, 44)
        Me.gbCheck.TabIndex = 222
        Me.gbCheck.TabStop = False
        '
        'lblCheckDate
        '
        Me.lblCheckDate.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckDate.Appearance.Options.UseFont = True
        Me.lblCheckDate.Location = New System.Drawing.Point(179, 19)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(75, 15)
        Me.lblCheckDate.TabIndex = 2
        Me.lblCheckDate.Text = "审核日期："
        '
        'lblCheckUser
        '
        Me.lblCheckUser.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckUser.Appearance.Options.UseFont = True
        Me.lblCheckUser.Location = New System.Drawing.Point(96, 19)
        Me.lblCheckUser.Name = "lblCheckUser"
        Me.lblCheckUser.Size = New System.Drawing.Size(75, 15)
        Me.lblCheckUser.TabIndex = 1
        Me.lblCheckUser.Text = "审核人员："
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(432, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 27)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消&C)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnSave.Location = New System.Drawing.Point(349, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "确定(&O)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 36)
        Me.PictureBox1.TabIndex = 214
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(3, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 301)
        Me.Panel1.TabIndex = 223
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.caeRepayQty)
        Me.GroupBox1.Controls.Add(Me.txtMaterialTypeID)
        Me.GroupBox1.Controls.Add(Me.gluD_ID)
        Me.GroupBox1.Controls.Add(Me.gluPS_NO)
        Me.GroupBox1.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.txtSO_ID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRepayID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.caeQty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dteRepayDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSO_SampleID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LabRRPer_ID1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "还料基本数据"
        '
        'caeRepayQty
        '
        Me.caeRepayQty.EditValue = "0"
        Me.caeRepayQty.Location = New System.Drawing.Point(90, 127)
        Me.caeRepayQty.Name = "caeRepayQty"
        Me.caeRepayQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.caeRepayQty.Properties.Appearance.Options.UseFont = True
        Me.caeRepayQty.Properties.DisplayFormat.FormatString = "999,999,999"
        Me.caeRepayQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.caeRepayQty.Properties.EditFormat.FormatString = "999,999,999"
        Me.caeRepayQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.caeRepayQty.Size = New System.Drawing.Size(169, 24)
        Me.caeRepayQty.TabIndex = 27
        '
        'txtMaterialTypeID
        '
        Me.txtMaterialTypeID.EditValue = ""
        Me.txtMaterialTypeID.Enabled = False
        Me.txtMaterialTypeID.Location = New System.Drawing.Point(336, 98)
        Me.txtMaterialTypeID.Name = "txtMaterialTypeID"
        Me.txtMaterialTypeID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtMaterialTypeID.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialTypeID.Size = New System.Drawing.Size(169, 24)
        Me.txtMaterialTypeID.TabIndex = 26
        '
        'gluD_ID
        '
        Me.gluD_ID.EditValue = ""
        Me.gluD_ID.Location = New System.Drawing.Point(90, 41)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayMember = "DepName"
        Me.gluD_ID.Properties.NullText = ""
        Me.gluD_ID.Properties.PopupFormWidth = 180
        Me.gluD_ID.Properties.ValueMember = "DepID"
        Me.gluD_ID.Properties.View = Me.GridView4
        Me.gluD_ID.Size = New System.Drawing.Size(169, 24)
        Me.gluD_ID.TabIndex = 25
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "部門編號"
        Me.GridColumn3.FieldName = "DepID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 90
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "部門名稱"
        Me.GridColumn4.FieldName = "DepName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 120
        '
        'gluPS_NO
        '
        Me.gluPS_NO.Location = New System.Drawing.Point(90, 98)
        Me.gluPS_NO.Name = "gluPS_NO"
        Me.gluPS_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPS_NO.Properties.Appearance.Options.UseFont = True
        Me.gluPS_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPS_NO.Properties.DisplayMember = "PS_Name"
        Me.gluPS_NO.Properties.NullText = ""
        Me.gluPS_NO.Properties.PopupFormWidth = 180
        Me.gluPS_NO.Properties.ValueMember = "PS_NO"
        Me.gluPS_NO.Properties.View = Me.GridView1
        Me.gluPS_NO.Size = New System.Drawing.Size(169, 24)
        Me.gluPS_NO.TabIndex = 24
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolPS_NO, Me.gcolPS_Name})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcolPS_NO
        '
        Me.gcolPS_NO.Caption = "編號"
        Me.gcolPS_NO.FieldName = "PS_NO"
        Me.gcolPS_NO.Name = "gcolPS_NO"
        '
        'gcolPS_Name
        '
        Me.gcolPS_Name.Caption = "名稱"
        Me.gcolPS_Name.FieldName = "PS_Name"
        Me.gcolPS_Name.Name = "gcolPS_Name"
        Me.gcolPS_Name.Visible = True
        Me.gcolPS_Name.VisibleIndex = 0
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.Location = New System.Drawing.Point(90, 70)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 380
        Me.gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.View = Me.GridView2
        Me.gluPM_M_Code.Size = New System.Drawing.Size(169, 24)
        Me.gluPM_M_Code.TabIndex = 23
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolSO_SampleID, Me.gcolPM_M_Code, Me.gcolMaterialTypeName, Me.gcolSO_ID})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'gcolSO_SampleID
        '
        Me.gcolSO_SampleID.Caption = "样办单号"
        Me.gcolSO_SampleID.FieldName = "SO_SampleID"
        Me.gcolSO_SampleID.Name = "gcolSO_SampleID"
        Me.gcolSO_SampleID.Visible = True
        Me.gcolSO_SampleID.VisibleIndex = 0
        '
        'gcolPM_M_Code
        '
        Me.gcolPM_M_Code.Caption = "产品編號"
        Me.gcolPM_M_Code.FieldName = "PM_M_Code"
        Me.gcolPM_M_Code.Name = "gcolPM_M_Code"
        Me.gcolPM_M_Code.Visible = True
        Me.gcolPM_M_Code.VisibleIndex = 1
        '
        'gcolMaterialTypeName
        '
        Me.gcolMaterialTypeName.Caption = "材料"
        Me.gcolMaterialTypeName.FieldName = "MaterialTypeName"
        Me.gcolMaterialTypeName.Name = "gcolMaterialTypeName"
        Me.gcolMaterialTypeName.Visible = True
        Me.gcolMaterialTypeName.VisibleIndex = 2
        '
        'gcolSO_ID
        '
        Me.gcolSO_ID.Caption = "订单编号"
        Me.gcolSO_ID.FieldName = "SO_ID"
        Me.gcolSO_ID.Name = "gcolSO_ID"
        Me.gcolSO_ID.Visible = True
        Me.gcolSO_ID.VisibleIndex = 3
        '
        'txtSO_ID
        '
        Me.txtSO_ID.EditValue = ""
        Me.txtSO_ID.Enabled = False
        Me.txtSO_ID.Location = New System.Drawing.Point(336, 70)
        Me.txtSO_ID.Name = "txtSO_ID"
        Me.txtSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtSO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_ID.Size = New System.Drawing.Size(169, 24)
        Me.txtSO_ID.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(264, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "订单编号:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(265, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "末还数量:"
        '
        'caeQty
        '
        Me.caeQty.Enabled = False
        Me.caeQty.Location = New System.Drawing.Point(336, 125)
        Me.caeQty.Name = "caeQty"
        Me.caeQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.caeQty.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.caeQty.Properties.Appearance.Options.UseFont = True
        Me.caeQty.Properties.Appearance.Options.UseForeColor = True
        Me.caeQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeQty.Size = New System.Drawing.Size(169, 24)
        Me.caeQty.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "工        序(&S):"
        '
        'dteRepayDate
        '
        Me.dteRepayDate.EditValue = Nothing
        Me.dteRepayDate.Enabled = False
        Me.dteRepayDate.Location = New System.Drawing.Point(336, 14)
        Me.dteRepayDate.Margin = New System.Windows.Forms.Padding(6)
        Me.dteRepayDate.Name = "dteRepayDate"
        Me.dteRepayDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteRepayDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dteRepayDate.Properties.Appearance.Options.UseFont = True
        Me.dteRepayDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteRepayDate.Properties.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.dteRepayDate.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteRepayDate.Size = New System.Drawing.Size(169, 24)
        Me.dteRepayDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(264, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "还料日期:"
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.EditValue = ""
        Me.txtSO_SampleID.Enabled = False
        Me.txtSO_SampleID.Location = New System.Drawing.Point(336, 44)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(169, 22)
        Me.txtSO_SampleID.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(264, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "样办单号:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(264, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "材        料:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(461, 6)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton2.TabIndex = 254
        Me.SimpleButton2.Text = "异常处理"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(188, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton1.TabIndex = 252
        Me.SimpleButton1.Text = "刷卡(&K)"
        '
        'txtCardID
        '
        Me.txtCardID.EditValue = ""
        Me.txtCardID.Enabled = False
        Me.txtCardID.Location = New System.Drawing.Point(250, 6)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCardID.Properties.Appearance.Options.UseFont = True
        Me.txtCardID.Size = New System.Drawing.Size(207, 22)
        Me.txtCardID.TabIndex = 253
        '
        'frmSampleRepay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 390)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtCardID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbCheck)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRRPer_ID)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmSampleRepay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生产还料"
        CType(Me.txtRepayID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRRPer_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.caeRepayQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteRepayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRepayID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRRPer_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabRRPer_ID1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gbCheck As System.Windows.Forms.GroupBox
    Friend WithEvents lblCheckUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCheckDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents caeQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dteRepayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolMaterialTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluPS_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMaterialTypeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents caeRepayQty As DevExpress.XtraEditors.TextEdit
End Class
