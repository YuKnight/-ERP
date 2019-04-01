<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSamplePaceInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSamplePaceInsert))
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.LabSE_NO = New System.Windows.Forms.Label
        Me.txtCardID = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dateAddDate = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.lblM_Code = New System.Windows.Forms.Label
        Me.gluSO_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSS_Edition = New DevExpress.XtraEditors.TextEdit
        Me.lblSO_ID = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.gluType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblType = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddFile = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDelSub = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCheckDate = New System.Windows.Forms.Label
        Me.lblCheckName = New System.Windows.Forms.Label
        Me.LabCheckDate = New System.Windows.Forms.Label
        Me.LabAction = New System.Windows.Forms.Label
        Me.CheckA = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.gluSE_InD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluInPS_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblInPS_NO = New System.Windows.Forms.Label
        Me.lblSE_InD_ID = New System.Windows.Forms.Label
        Me.lblQtyIn = New System.Windows.Forms.Label
        Me.lbl_QtyIn = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWeighing = New DevExpress.XtraEditors.TextEdit
        Me.lblWeighing = New System.Windows.Forms.Label
        Me.gluOutPS_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluSE_OutD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblQtyOut = New System.Windows.Forms.Label
        Me.lbl_QtyOut = New System.Windows.Forms.Label
        Me.lblOutPS_NO = New System.Windows.Forms.Label
        Me.lblSE_OutD_ID = New System.Windows.Forms.Label
        Me.cmdAutoCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtSE_Remark = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtClientBarcode = New DevExpress.XtraEditors.TextEdit
        Me.lblClientBarcode = New System.Windows.Forms.Label
        Me.cboCodeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCode = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SPID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_AddDateSub = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkA = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtTime = New DevExpress.XtraEditors.SpinEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.txtOutInQty = New DevExpress.XtraEditors.TextEdit
        Me.lblSE_BarCodeType = New System.Windows.Forms.Label
        Me.cobSE_BarCodeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtSealCode_ID = New DevExpress.XtraEditors.TextEdit
        Me.lblSealCode_ID = New System.Windows.Forms.Label
        Me.txtPK_CodeID = New DevExpress.XtraEditors.TextEdit
        Me.lblPK_CodeID = New System.Windows.Forms.Label
        Me.gluReason = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblReason = New System.Windows.Forms.Label
        Me.txtMaterialType = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.gluLoan = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2.SuspendLayout()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_Edition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CheckA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gluSE_InD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluInPS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtWeighing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluOutPS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSE_OutD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOutInQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cobSE_BarCodeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSealCode_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPK_CodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluLoan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(3, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(98, 21)
        Me.Lbl_Title.TabIndex = 85
        Me.Lbl_Title.Text = "样办收发"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.LabSE_NO)
        Me.Panel2.Controls.Add(Me.txtCardID)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.Lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 32)
        Me.Panel2.TabIndex = 129
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(552, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(61, 23)
        Me.SimpleButton2.TabIndex = 248
        Me.SimpleButton2.Text = "异常处理"
        '
        'LabSE_NO
        '
        Me.LabSE_NO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabSE_NO.AutoSize = True
        Me.LabSE_NO.BackColor = System.Drawing.Color.Transparent
        Me.LabSE_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabSE_NO.ForeColor = System.Drawing.Color.Black
        Me.LabSE_NO.Location = New System.Drawing.Point(970, 9)
        Me.LabSE_NO.Name = "LabSE_NO"
        Me.LabSE_NO.Size = New System.Drawing.Size(67, 15)
        Me.LabSE_NO.TabIndex = 90
        Me.LabSE_NO.Text = "自动编号"
        '
        'txtCardID
        '
        Me.txtCardID.EditValue = ""
        Me.txtCardID.Enabled = False
        Me.txtCardID.Location = New System.Drawing.Point(337, 5)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCardID.Properties.Appearance.Options.UseFont = True
        Me.txtCardID.Size = New System.Drawing.Size(212, 22)
        Me.txtCardID.TabIndex = 247
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(919, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 15)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "单号:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(285, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(46, 23)
        Me.SimpleButton1.TabIndex = 246
        Me.SimpleButton1.Text = "刷卡"
        '
        'gluM_Code
        '
        Me.gluM_Code.EditValue = ""
        Me.gluM_Code.Location = New System.Drawing.Point(332, 32)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.DisplayMember = "Type3ID"
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.ValueMember = "Type3ID"
        Me.gluM_Code.Properties.View = Me.GridView3
        Me.gluM_Code.Size = New System.Drawing.Size(155, 24)
        Me.gluM_Code.TabIndex = 11
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "產品類型"
        Me.GridColumn8.FieldName = "Type3ID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "AutoID"
        Me.GridColumn9.FieldName = "AutoID"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'dateAddDate
        '
        Me.dateAddDate.EditValue = Nothing
        Me.dateAddDate.Enabled = False
        Me.dateAddDate.Location = New System.Drawing.Point(968, 4)
        Me.dateAddDate.Name = "dateAddDate"
        Me.dateAddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateAddDate.Properties.Appearance.Options.UseFont = True
        Me.dateAddDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateAddDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateAddDate.Size = New System.Drawing.Size(113, 24)
        Me.dateAddDate.TabIndex = 135
        Me.dateAddDate.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(924, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "建立日期:"
        Me.Label3.Visible = False
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(89, 32)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(152, 24)
        Me.gluPM_M_Code.TabIndex = 9
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "产品编号"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "产品名称"
        Me.GridColumn6.FieldName = "pm_m_name"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblPM_M_Code.CausesValidation = False
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.ForeColor = System.Drawing.Color.Black
        Me.lblPM_M_Code.Location = New System.Drawing.Point(1, 37)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(90, 15)
        Me.lblPM_M_Code.TabIndex = 8
        Me.lblPM_M_Code.Text = "产品编号(&C):"
        '
        'lblM_Code
        '
        Me.lblM_Code.AutoSize = True
        Me.lblM_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblM_Code.CausesValidation = False
        Me.lblM_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblM_Code.ForeColor = System.Drawing.Color.Black
        Me.lblM_Code.Location = New System.Drawing.Point(241, 37)
        Me.lblM_Code.Name = "lblM_Code"
        Me.lblM_Code.Size = New System.Drawing.Size(91, 15)
        Me.lblM_Code.TabIndex = 10
        Me.lblM_Code.Text = "产品类型(&N):"
        '
        'gluSO_ID
        '
        Me.gluSO_ID.EditValue = ""
        Me.gluSO_ID.Location = New System.Drawing.Point(89, 4)
        Me.gluSO_ID.Name = "gluSO_ID"
        Me.gluSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSO_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSO_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSO_ID.Properties.DisplayMember = "SO_ID"
        Me.gluSO_ID.Properties.NullText = ""
        Me.gluSO_ID.Properties.PopupFormWidth = 428
        Me.gluSO_ID.Properties.ValueMember = "SO_ID"
        Me.gluSO_ID.Properties.View = Me.GridView7
        Me.gluSO_ID.Size = New System.Drawing.Size(152, 24)
        Me.gluSO_ID.TabIndex = 1
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn29, Me.GridColumn17, Me.GridColumn30, Me.GridColumn3, Me.GridColumn4, Me.AutoID})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "样办单号"
        Me.GridColumn29.FieldName = "SO_SampleID"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 0
        Me.GridColumn29.Width = 232
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "产品编号"
        Me.GridColumn17.FieldName = "PM_M_Code"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 333
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "材料"
        Me.GridColumn30.FieldName = "MaterialTypeName"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 2
        Me.GridColumn30.Width = 364
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "订单编号"
        Me.GridColumn3.FieldName = "SO_ID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 294
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "版本号"
        Me.GridColumn4.FieldName = "SS_Edition"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 185
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(924, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "版  本  号(&B):"
        Me.Label9.Visible = False
        '
        'txtSS_Edition
        '
        Me.txtSS_Edition.Enabled = False
        Me.txtSS_Edition.Location = New System.Drawing.Point(984, 61)
        Me.txtSS_Edition.Name = "txtSS_Edition"
        Me.txtSS_Edition.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSS_Edition.Properties.Appearance.Options.UseFont = True
        Me.txtSS_Edition.Size = New System.Drawing.Size(82, 24)
        Me.txtSS_Edition.TabIndex = 3
        Me.txtSS_Edition.Visible = False
        '
        'lblSO_ID
        '
        Me.lblSO_ID.AutoSize = True
        Me.lblSO_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSO_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSO_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSO_ID.Location = New System.Drawing.Point(1, 9)
        Me.lblSO_ID.Name = "lblSO_ID"
        Me.lblSO_ID.Size = New System.Drawing.Size(91, 15)
        Me.lblSO_ID.TabIndex = 0
        Me.lblSO_ID.Text = "订单编号(&H):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(740, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 15)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "数      量："
        '
        'gluType
        '
        Me.gluType.EditValue = ""
        Me.gluType.Location = New System.Drawing.Point(573, 32)
        Me.gluType.Name = "gluType"
        Me.gluType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluType.Properties.Appearance.Options.UseFont = True
        Me.gluType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluType.Properties.DisplayMember = "SE_TypeName"
        Me.gluType.Properties.NullText = ""
        Me.gluType.Properties.PopupFormWidth = 150
        Me.gluType.Properties.ValueMember = "SE_Type"
        Me.gluType.Properties.View = Me.GridView4
        Me.gluType.Size = New System.Drawing.Size(162, 24)
        Me.gluType.TabIndex = 13
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "类型编号"
        Me.GridColumn11.FieldName = "SE_Type"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 50
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "类型"
        Me.GridColumn12.FieldName = "SE_TypeName"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 60
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(487, 37)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(87, 15)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "类       型(&S):"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddFile, Me.cmdDelSub})
        Me.ContextMenuStrip1.Name = "cmsMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 48)
        '
        'cmdAddFile
        '
        Me.cmdAddFile.AutoSize = False
        Me.cmdAddFile.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAddFile.Image = CType(resources.GetObject("cmdAddFile.Image"), System.Drawing.Image)
        Me.cmdAddFile.Name = "cmdAddFile"
        Me.cmdAddFile.Size = New System.Drawing.Size(152, 22)
        Me.cmdAddFile.Text = "轉入盤點文件(&F)"
        Me.cmdAddFile.Visible = False
        '
        'cmdDelSub
        '
        Me.cmdDelSub.Image = CType(resources.GetObject("cmdDelSub.Image"), System.Drawing.Image)
        Me.cmdDelSub.Name = "cmdDelSub"
        Me.cmdDelSub.Size = New System.Drawing.Size(169, 22)
        Me.cmdDelSub.Text = "刪除(&D)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(962, 10)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(84, 27)
        Me.cmdExit.TabIndex = 143
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(854, 10)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(84, 27)
        Me.cmdSave.TabIndex = 142
        Me.cmdSave.Text = "确认(&S)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblCheckDate)
        Me.Panel1.Controls.Add(Me.lblCheckName)
        Me.Panel1.Controls.Add(Me.LabCheckDate)
        Me.Panel1.Controls.Add(Me.LabAction)
        Me.Panel1.Controls.Add(Me.CheckA)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 38)
        Me.Panel1.TabIndex = 172
        Me.Panel1.Visible = False
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(350, 11)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(71, 15)
        Me.lblCheckDate.TabIndex = 7
        Me.lblCheckDate.Text = "审核日期:"
        '
        'lblCheckName
        '
        Me.lblCheckName.AutoSize = True
        Me.lblCheckName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCheckName.Location = New System.Drawing.Point(179, 11)
        Me.lblCheckName.Name = "lblCheckName"
        Me.lblCheckName.Size = New System.Drawing.Size(56, 15)
        Me.lblCheckName.TabIndex = 6
        Me.lblCheckName.Text = "审核人:"
        '
        'LabCheckDate
        '
        Me.LabCheckDate.AutoSize = True
        Me.LabCheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCheckDate.Location = New System.Drawing.Point(271, 11)
        Me.LabCheckDate.Name = "LabCheckDate"
        Me.LabCheckDate.Size = New System.Drawing.Size(71, 15)
        Me.LabCheckDate.TabIndex = 5
        Me.LabCheckDate.Text = "审核日期:"
        '
        'LabAction
        '
        Me.LabAction.AutoSize = True
        Me.LabAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabAction.Location = New System.Drawing.Point(122, 11)
        Me.LabAction.Name = "LabAction"
        Me.LabAction.Size = New System.Drawing.Size(56, 15)
        Me.LabAction.TabIndex = 4
        Me.LabAction.Text = "审核人:"
        '
        'CheckA
        '
        Me.CheckA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckA.EditValue = True
        Me.CheckA.Location = New System.Drawing.Point(16, 7)
        Me.CheckA.Name = "CheckA"
        Me.CheckA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckA.Properties.Appearance.Options.UseFont = True
        Me.CheckA.Properties.Caption = "审核订单"
        Me.CheckA.Size = New System.Drawing.Size(88, 23)
        Me.CheckA.TabIndex = 3
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(622, 13)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "确认收货(&V)"
        Me.CheckEdit1.Size = New System.Drawing.Size(107, 20)
        Me.CheckEdit1.TabIndex = 173
        Me.CheckEdit1.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 124)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1076, 182)
        Me.XtraTabControl1.TabIndex = 13
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.TabStop = False
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox3)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1067, 150)
        Me.XtraTabPage1.Text = "基本收发"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.gluSE_InD_ID)
        Me.GroupBox3.Controls.Add(Me.gluInPS_NO)
        Me.GroupBox3.Controls.Add(Me.lblInPS_NO)
        Me.GroupBox3.Controls.Add(Me.lblSE_InD_ID)
        Me.GroupBox3.Controls.Add(Me.lblQtyIn)
        Me.GroupBox3.Controls.Add(Me.lbl_QtyIn)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1067, 74)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "收料"
        '
        'gluSE_InD_ID
        '
        Me.gluSE_InD_ID.EditValue = ""
        Me.gluSE_InD_ID.Location = New System.Drawing.Point(113, 15)
        Me.gluSE_InD_ID.Name = "gluSE_InD_ID"
        Me.gluSE_InD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSE_InD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSE_InD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSE_InD_ID.Properties.DisplayMember = "DepName"
        Me.gluSE_InD_ID.Properties.NullText = ""
        Me.gluSE_InD_ID.Properties.PopupFormWidth = 150
        Me.gluSE_InD_ID.Properties.ValueMember = "DepID"
        Me.gluSE_InD_ID.Properties.View = Me.GridView6
        Me.gluSE_InD_ID.Size = New System.Drawing.Size(171, 24)
        Me.gluSE_InD_ID.TabIndex = 1
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "部门编号"
        Me.GridColumn15.FieldName = "DepID"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 50
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "部门"
        Me.GridColumn16.FieldName = "DepName"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        Me.GridColumn16.Width = 60
        '
        'gluInPS_NO
        '
        Me.gluInPS_NO.EditValue = ""
        Me.gluInPS_NO.Location = New System.Drawing.Point(113, 44)
        Me.gluInPS_NO.Name = "gluInPS_NO"
        Me.gluInPS_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluInPS_NO.Properties.Appearance.Options.UseFont = True
        Me.gluInPS_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluInPS_NO.Properties.DisplayMember = "PS_NoName"
        Me.gluInPS_NO.Properties.NullText = ""
        Me.gluInPS_NO.Properties.PopupFormWidth = 280
        Me.gluInPS_NO.Properties.ValueMember = "PS_NO"
        Me.gluInPS_NO.Properties.View = Me.GridView2
        Me.gluInPS_NO.Size = New System.Drawing.Size(171, 24)
        Me.gluInPS_NO.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn34, Me.GridColumn7, Me.GridColumn10, Me.GridColumn38})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "序号"
        Me.GridColumn34.FieldName = "PS_Num"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 0
        Me.GridColumn34.Width = 177
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "工艺编号"
        Me.GridColumn7.FieldName = "PS_NO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 50
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "工艺名称"
        Me.GridColumn10.FieldName = "PS_Name"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 607
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "注意事項"
        Me.GridColumn38.FieldName = "PS_Remark"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 2
        Me.GridColumn38.Width = 321
        '
        'lblInPS_NO
        '
        Me.lblInPS_NO.AutoSize = True
        Me.lblInPS_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblInPS_NO.ForeColor = System.Drawing.Color.Black
        Me.lblInPS_NO.Location = New System.Drawing.Point(11, 49)
        Me.lblInPS_NO.Name = "lblInPS_NO"
        Me.lblInPS_NO.Size = New System.Drawing.Size(102, 15)
        Me.lblInPS_NO.TabIndex = 2
        Me.lblInPS_NO.Text = "收料工序(&X)："
        '
        'lblSE_InD_ID
        '
        Me.lblSE_InD_ID.AutoSize = True
        Me.lblSE_InD_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_InD_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_InD_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_InD_ID.Location = New System.Drawing.Point(11, 20)
        Me.lblSE_InD_ID.Name = "lblSE_InD_ID"
        Me.lblSE_InD_ID.Size = New System.Drawing.Size(101, 15)
        Me.lblSE_InD_ID.TabIndex = 0
        Me.lblSE_InD_ID.Text = "收料部门(&Z)："
        '
        'lblQtyIn
        '
        Me.lblQtyIn.AutoSize = True
        Me.lblQtyIn.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblQtyIn.ForeColor = System.Drawing.Color.Black
        Me.lblQtyIn.Location = New System.Drawing.Point(369, 49)
        Me.lblQtyIn.Name = "lblQtyIn"
        Me.lblQtyIn.Size = New System.Drawing.Size(14, 15)
        Me.lblQtyIn.TabIndex = 149
        Me.lblQtyIn.Text = "0"
        '
        'lbl_QtyIn
        '
        Me.lbl_QtyIn.AutoSize = True
        Me.lbl_QtyIn.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_QtyIn.ForeColor = System.Drawing.Color.Black
        Me.lbl_QtyIn.Location = New System.Drawing.Point(287, 49)
        Me.lbl_QtyIn.Name = "lbl_QtyIn"
        Me.lbl_QtyIn.Size = New System.Drawing.Size(82, 15)
        Me.lbl_QtyIn.TabIndex = 148
        Me.lbl_QtyIn.Text = "库存数量："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtWeighing)
        Me.GroupBox2.Controls.Add(Me.lblWeighing)
        Me.GroupBox2.Controls.Add(Me.gluOutPS_NO)
        Me.GroupBox2.Controls.Add(Me.gluSE_OutD_ID)
        Me.GroupBox2.Controls.Add(Me.lblQtyOut)
        Me.GroupBox2.Controls.Add(Me.lbl_QtyOut)
        Me.GroupBox2.Controls.Add(Me.lblOutPS_NO)
        Me.GroupBox2.Controls.Add(Me.lblSE_OutD_ID)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1067, 76)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "发料 "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(463, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "g"
        '
        'txtWeighing
        '
        Me.txtWeighing.EditValue = "0"
        Me.txtWeighing.Location = New System.Drawing.Point(373, 13)
        Me.txtWeighing.Name = "txtWeighing"
        Me.txtWeighing.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWeighing.Properties.Appearance.Options.UseFont = True
        Me.txtWeighing.Properties.DisplayFormat.FormatString = "########0.00"
        Me.txtWeighing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWeighing.Properties.Mask.EditMask = "######0.00"
        Me.txtWeighing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtWeighing.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtWeighing.Size = New System.Drawing.Size(84, 24)
        Me.txtWeighing.TabIndex = 22
        '
        'lblWeighing
        '
        Me.lblWeighing.AutoSize = True
        Me.lblWeighing.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWeighing.ForeColor = System.Drawing.Color.Black
        Me.lblWeighing.Location = New System.Drawing.Point(289, 18)
        Me.lblWeighing.Name = "lblWeighing"
        Me.lblWeighing.Size = New System.Drawing.Size(80, 15)
        Me.lblWeighing.TabIndex = 10
        Me.lblWeighing.Text = "重       量："
        '
        'gluOutPS_NO
        '
        Me.gluOutPS_NO.EditValue = ""
        Me.gluOutPS_NO.Location = New System.Drawing.Point(111, 44)
        Me.gluOutPS_NO.Name = "gluOutPS_NO"
        Me.gluOutPS_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluOutPS_NO.Properties.Appearance.Options.UseFont = True
        Me.gluOutPS_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluOutPS_NO.Properties.DisplayMember = "PS_NoName"
        Me.gluOutPS_NO.Properties.ImmediatePopup = True
        Me.gluOutPS_NO.Properties.NullText = ""
        Me.gluOutPS_NO.Properties.PopupFormWidth = 280
        Me.gluOutPS_NO.Properties.ValueMember = "PS_NO"
        Me.gluOutPS_NO.Properties.View = Me.GridView5
        Me.gluOutPS_NO.Size = New System.Drawing.Size(170, 24)
        Me.gluOutPS_NO.TabIndex = 3
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn33, Me.GridColumn13, Me.GridColumn14, Me.GridColumn35, Me.GridColumn37})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "序号"
        Me.GridColumn33.FieldName = "PS_Num"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 0
        Me.GridColumn33.Width = 195
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "工艺编号"
        Me.GridColumn13.FieldName = "PS_NO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 50
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "工艺名称"
        Me.GridColumn14.FieldName = "PS_Name"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 508
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "工艺编号名称"
        Me.GridColumn35.FieldName = "PS_NoName"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "注意事項"
        Me.GridColumn37.FieldName = "PS_Remark"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 2
        Me.GridColumn37.Width = 402
        '
        'gluSE_OutD_ID
        '
        Me.gluSE_OutD_ID.EditValue = ""
        Me.gluSE_OutD_ID.Location = New System.Drawing.Point(111, 13)
        Me.gluSE_OutD_ID.Name = "gluSE_OutD_ID"
        Me.gluSE_OutD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSE_OutD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluSE_OutD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSE_OutD_ID.Properties.DisplayMember = "DepName"
        Me.gluSE_OutD_ID.Properties.NullText = ""
        Me.gluSE_OutD_ID.Properties.PopupFormWidth = 150
        Me.gluSE_OutD_ID.Properties.ValueMember = "DepID"
        Me.gluSE_OutD_ID.Properties.View = Me.GridView1
        Me.gluSE_OutD_ID.Size = New System.Drawing.Size(170, 24)
        Me.gluSE_OutD_ID.TabIndex = 1
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
        'lblQtyOut
        '
        Me.lblQtyOut.AutoSize = True
        Me.lblQtyOut.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblQtyOut.ForeColor = System.Drawing.Color.Black
        Me.lblQtyOut.Location = New System.Drawing.Point(369, 49)
        Me.lblQtyOut.Name = "lblQtyOut"
        Me.lblQtyOut.Size = New System.Drawing.Size(14, 15)
        Me.lblQtyOut.TabIndex = 9
        Me.lblQtyOut.Text = "0"
        '
        'lbl_QtyOut
        '
        Me.lbl_QtyOut.AutoSize = True
        Me.lbl_QtyOut.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_QtyOut.ForeColor = System.Drawing.Color.Black
        Me.lbl_QtyOut.Location = New System.Drawing.Point(287, 49)
        Me.lbl_QtyOut.Name = "lbl_QtyOut"
        Me.lbl_QtyOut.Size = New System.Drawing.Size(82, 15)
        Me.lbl_QtyOut.TabIndex = 8
        Me.lbl_QtyOut.Text = "库存数量："
        '
        'lblOutPS_NO
        '
        Me.lblOutPS_NO.AutoSize = True
        Me.lblOutPS_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutPS_NO.ForeColor = System.Drawing.Color.Black
        Me.lblOutPS_NO.Location = New System.Drawing.Point(10, 49)
        Me.lblOutPS_NO.Name = "lblOutPS_NO"
        Me.lblOutPS_NO.Size = New System.Drawing.Size(100, 15)
        Me.lblOutPS_NO.TabIndex = 2
        Me.lblOutPS_NO.Text = "发料工序(&F)："
        '
        'lblSE_OutD_ID
        '
        Me.lblSE_OutD_ID.AutoSize = True
        Me.lblSE_OutD_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_OutD_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_OutD_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_OutD_ID.Location = New System.Drawing.Point(9, 18)
        Me.lblSE_OutD_ID.Name = "lblSE_OutD_ID"
        Me.lblSE_OutD_ID.Size = New System.Drawing.Size(101, 15)
        Me.lblSE_OutD_ID.TabIndex = 0
        Me.lblSE_OutD_ID.Text = "发料部门(&E)："
        '
        'cmdAutoCode
        '
        Me.cmdAutoCode.Enabled = False
        Me.cmdAutoCode.Location = New System.Drawing.Point(325, 10)
        Me.cmdAutoCode.Name = "cmdAutoCode"
        Me.cmdAutoCode.Size = New System.Drawing.Size(92, 23)
        Me.cmdAutoCode.TabIndex = 249
        Me.cmdAutoCode.Text = "可扫描条码输入"
        '
        'txtSE_Remark
        '
        Me.txtSE_Remark.Location = New System.Drawing.Point(332, 61)
        Me.txtSE_Remark.Name = "txtSE_Remark"
        Me.txtSE_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtSE_Remark.Size = New System.Drawing.Size(403, 24)
        Me.txtSE_Remark.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(244, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "备      注(&M):"
        '
        'txtClientBarcode
        '
        Me.txtClientBarcode.Location = New System.Drawing.Point(590, 8)
        Me.txtClientBarcode.Name = "txtClientBarcode"
        Me.txtClientBarcode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtClientBarcode.Size = New System.Drawing.Size(206, 26)
        Me.txtClientBarcode.TabIndex = 225
        Me.txtClientBarcode.Visible = False
        '
        'lblClientBarcode
        '
        Me.lblClientBarcode.AutoSize = True
        Me.lblClientBarcode.BackColor = System.Drawing.Color.Transparent
        Me.lblClientBarcode.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblClientBarcode.ForeColor = System.Drawing.Color.Black
        Me.lblClientBarcode.Location = New System.Drawing.Point(516, 14)
        Me.lblClientBarcode.Name = "lblClientBarcode"
        Me.lblClientBarcode.Size = New System.Drawing.Size(71, 15)
        Me.lblClientBarcode.TabIndex = 226
        Me.lblClientBarcode.Text = "客户条码:"
        Me.lblClientBarcode.Visible = False
        '
        'cboCodeType
        '
        Me.cboCodeType.EditValue = "条码录入"
        Me.cboCodeType.Location = New System.Drawing.Point(14, 9)
        Me.cboCodeType.Name = "cboCodeType"
        Me.cboCodeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodeType.Properties.Appearance.Options.UseFont = True
        Me.cboCodeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodeType.Properties.Items.AddRange(New Object() {"条码录入", "条码关联"})
        Me.cboCodeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCodeType.Size = New System.Drawing.Size(86, 24)
        Me.cboCodeType.TabIndex = 131
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Red
        Me.lblCode.Location = New System.Drawing.Point(420, 14)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(15, 15)
        Me.lblCode.TabIndex = 224
        Me.lblCode.Text = "  "
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 41)
        Me.Grid1.MainView = Me.GridView9
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RemarkA})
        Me.Grid1.Size = New System.Drawing.Size(1076, 307)
        Me.Grid1.TabIndex = 223
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SPID, Me.Code_ID, Me.ClientBarcode, Me.QtyA, Me.SE_AddDateSub, Me.InCheck, Me.InCheckDate, Me.GridColumn32, Me.AutoIDA})
        Me.GridView9.GridControl = Me.Grid1
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsCustomization.AllowColumnMoving = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView9.OptionsFilter.AllowFilterEditor = False
        Me.GridView9.OptionsFilter.AllowMRUFilterList = False
        Me.GridView9.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView9.OptionsView.ColumnAutoWidth = False
        Me.GridView9.OptionsView.RowAutoHeight = True
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'SPID
        '
        Me.SPID.Caption = "单号"
        Me.SPID.FieldName = "SPID"
        Me.SPID.Name = "SPID"
        Me.SPID.OptionsColumn.ReadOnly = True
        Me.SPID.Width = 90
        '
        'Code_ID
        '
        Me.Code_ID.Caption = "条码"
        Me.Code_ID.FieldName = "Code_ID"
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.OptionsColumn.ReadOnly = True
        Me.Code_ID.SummaryItem.DisplayFormat = "总数量"
        Me.Code_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.Code_ID.Visible = True
        Me.Code_ID.VisibleIndex = 0
        Me.Code_ID.Width = 145
        '
        'ClientBarcode
        '
        Me.ClientBarcode.Caption = "客户条码"
        Me.ClientBarcode.FieldName = "ClientBarcode"
        Me.ClientBarcode.Name = "ClientBarcode"
        Me.ClientBarcode.OptionsColumn.ReadOnly = True
        Me.ClientBarcode.Visible = True
        Me.ClientBarcode.VisibleIndex = 1
        Me.ClientBarcode.Width = 151
        '
        'QtyA
        '
        Me.QtyA.Caption = "数量"
        Me.QtyA.FieldName = "Qty"
        Me.QtyA.Name = "QtyA"
        Me.QtyA.OptionsColumn.ReadOnly = True
        Me.QtyA.SummaryItem.DisplayFormat = "{0}"
        Me.QtyA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QtyA.Visible = True
        Me.QtyA.VisibleIndex = 2
        Me.QtyA.Width = 44
        '
        'SE_AddDateSub
        '
        Me.SE_AddDateSub.Caption = "发料时间"
        Me.SE_AddDateSub.FieldName = "SE_AddDate"
        Me.SE_AddDateSub.Name = "SE_AddDateSub"
        Me.SE_AddDateSub.OptionsColumn.ReadOnly = True
        Me.SE_AddDateSub.Visible = True
        Me.SE_AddDateSub.VisibleIndex = 3
        Me.SE_AddDateSub.Width = 168
        '
        'InCheck
        '
        Me.InCheck.Caption = "收料确认"
        Me.InCheck.FieldName = "InCheck"
        Me.InCheck.Name = "InCheck"
        Me.InCheck.OptionsColumn.ReadOnly = True
        Me.InCheck.Visible = True
        Me.InCheck.VisibleIndex = 4
        Me.InCheck.Width = 63
        '
        'InCheckDate
        '
        Me.InCheckDate.Caption = "收料时间"
        Me.InCheckDate.FieldName = "InCheckDate"
        Me.InCheckDate.Name = "InCheckDate"
        Me.InCheckDate.OptionsColumn.ReadOnly = True
        Me.InCheckDate.SummaryItem.DisplayFormat = "{0}"
        Me.InCheckDate.SummaryItem.FieldName = "InCheckQty"
        Me.InCheckDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.InCheckDate.Visible = True
        Me.InCheckDate.VisibleIndex = 5
        Me.InCheckDate.Width = 161
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "确认数量"
        Me.GridColumn32.FieldName = "InCheckQty"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'AutoIDA
        '
        Me.AutoIDA.Caption = "AutoID"
        Me.AutoIDA.FieldName = "AutoID"
        Me.AutoIDA.Name = "AutoIDA"
        Me.AutoIDA.OptionsColumn.ReadOnly = True
        '
        'RemarkA
        '
        Me.RemarkA.AutoHeight = False
        Me.RemarkA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkA.Name = "RemarkA"
        Me.RemarkA.ShowIcon = False
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(116, 8)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Code.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code.Size = New System.Drawing.Size(206, 26)
        Me.txtM_Code.TabIndex = 220
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTime)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Controls.Add(Me.txtOutInQty)
        Me.Panel3.Controls.Add(Me.lblSE_BarCodeType)
        Me.Panel3.Controls.Add(Me.cobSE_BarCodeType)
        Me.Panel3.Controls.Add(Me.gluSO_ID)
        Me.Panel3.Controls.Add(Me.txtSealCode_ID)
        Me.Panel3.Controls.Add(Me.lblSealCode_ID)
        Me.Panel3.Controls.Add(Me.txtPK_CodeID)
        Me.Panel3.Controls.Add(Me.lblPK_CodeID)
        Me.Panel3.Controls.Add(Me.gluReason)
        Me.Panel3.Controls.Add(Me.lblReason)
        Me.Panel3.Controls.Add(Me.txtSE_Remark)
        Me.Panel3.Controls.Add(Me.txtSS_Edition)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.gluM_Code)
        Me.Panel3.Controls.Add(Me.gluPM_M_Code)
        Me.Panel3.Controls.Add(Me.txtMaterialType)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.gluLoan)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblSO_ID)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.gluType)
        Me.Panel3.Controls.Add(Me.lblM_Code)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblPM_M_Code)
        Me.Panel3.Controls.Add(Me.dateAddDate)
        Me.Panel3.Controls.Add(Me.lblType)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1076, 92)
        Me.Panel3.TabIndex = 0
        '
        'txtTime
        '
        Me.txtTime.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTime.Location = New System.Drawing.Point(999, 33)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtTime.Properties.Appearance.Options.UseFont = True
        Me.txtTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTime.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txtTime.Size = New System.Drawing.Size(41, 24)
        Me.txtTime.TabIndex = 10
        Me.txtTime.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(1044, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 15)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "天"
        Me.Label23.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(926, 37)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(71, 15)
        Me.lblTime.TabIndex = 138
        Me.lblTime.Text = "借出天数:"
        Me.lblTime.Visible = False
        '
        'txtOutInQty
        '
        Me.txtOutInQty.EditValue = "0"
        Me.txtOutInQty.Enabled = False
        Me.txtOutInQty.Location = New System.Drawing.Point(812, 61)
        Me.txtOutInQty.Name = "txtOutInQty"
        Me.txtOutInQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOutInQty.Properties.Appearance.Options.UseFont = True
        Me.txtOutInQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOutInQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOutInQty.Properties.Mask.EditMask = "d"
        Me.txtOutInQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOutInQty.Size = New System.Drawing.Size(113, 24)
        Me.txtOutInQty.TabIndex = 21
        '
        'lblSE_BarCodeType
        '
        Me.lblSE_BarCodeType.AutoSize = True
        Me.lblSE_BarCodeType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_BarCodeType.ForeColor = System.Drawing.Color.Black
        Me.lblSE_BarCodeType.Location = New System.Drawing.Point(739, 9)
        Me.lblSE_BarCodeType.Name = "lblSE_BarCodeType"
        Me.lblSE_BarCodeType.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_BarCodeType.TabIndex = 6
        Me.lblSE_BarCodeType.Text = "条码方式:"
        '
        'cobSE_BarCodeType
        '
        Me.cobSE_BarCodeType.EditValue = "手动采集"
        Me.cobSE_BarCodeType.Location = New System.Drawing.Point(812, 4)
        Me.cobSE_BarCodeType.Name = "cobSE_BarCodeType"
        Me.cobSE_BarCodeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobSE_BarCodeType.Properties.Appearance.Options.UseFont = True
        Me.cobSE_BarCodeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cobSE_BarCodeType.Properties.Items.AddRange(New Object() {"手动采集", "自动采集"})
        Me.cobSE_BarCodeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cobSE_BarCodeType.Size = New System.Drawing.Size(113, 24)
        Me.cobSE_BarCodeType.TabIndex = 7
        '
        'txtSealCode_ID
        '
        Me.txtSealCode_ID.Enabled = False
        Me.txtSealCode_ID.Location = New System.Drawing.Point(332, 4)
        Me.txtSealCode_ID.Name = "txtSealCode_ID"
        Me.txtSealCode_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSealCode_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSealCode_ID.Size = New System.Drawing.Size(155, 24)
        Me.txtSealCode_ID.TabIndex = 3
        '
        'lblSealCode_ID
        '
        Me.lblSealCode_ID.AutoSize = True
        Me.lblSealCode_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblSealCode_ID.CausesValidation = False
        Me.lblSealCode_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSealCode_ID.ForeColor = System.Drawing.Color.Red
        Me.lblSealCode_ID.Location = New System.Drawing.Point(244, 9)
        Me.lblSealCode_ID.Name = "lblSealCode_ID"
        Me.lblSealCode_ID.Size = New System.Drawing.Size(88, 15)
        Me.lblSealCode_ID.TabIndex = 2
        Me.lblSealCode_ID.Text = "封       条(&B):"
        '
        'txtPK_CodeID
        '
        Me.txtPK_CodeID.Enabled = False
        Me.txtPK_CodeID.Location = New System.Drawing.Point(573, 4)
        Me.txtPK_CodeID.Name = "txtPK_CodeID"
        Me.txtPK_CodeID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPK_CodeID.Properties.Appearance.Options.UseFont = True
        Me.txtPK_CodeID.Size = New System.Drawing.Size(162, 24)
        Me.txtPK_CodeID.TabIndex = 5
        '
        'lblPK_CodeID
        '
        Me.lblPK_CodeID.AutoSize = True
        Me.lblPK_CodeID.BackColor = System.Drawing.Color.Transparent
        Me.lblPK_CodeID.CausesValidation = False
        Me.lblPK_CodeID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPK_CodeID.ForeColor = System.Drawing.Color.Black
        Me.lblPK_CodeID.Location = New System.Drawing.Point(485, 9)
        Me.lblPK_CodeID.Name = "lblPK_CodeID"
        Me.lblPK_CodeID.Size = New System.Drawing.Size(89, 15)
        Me.lblPK_CodeID.TabIndex = 4
        Me.lblPK_CodeID.Text = "装箱条码(&P):"
        '
        'gluReason
        '
        Me.gluReason.EditValue = ""
        Me.gluReason.Location = New System.Drawing.Point(812, 32)
        Me.gluReason.Name = "gluReason"
        Me.gluReason.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluReason.Properties.Appearance.Options.UseFont = True
        Me.gluReason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluReason.Properties.Items.AddRange(New Object() {"研磨", "阳极", "测试", "项目", "工程"})
        Me.gluReason.Size = New System.Drawing.Size(113, 24)
        Me.gluReason.TabIndex = 15
        Me.gluReason.Visible = False
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblReason.ForeColor = System.Drawing.Color.Black
        Me.lblReason.Location = New System.Drawing.Point(739, 36)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(71, 15)
        Me.lblReason.TabIndex = 14
        Me.lblReason.Text = "借出理由:"
        Me.lblReason.Visible = False
        '
        'txtMaterialType
        '
        Me.txtMaterialType.Enabled = False
        Me.txtMaterialType.Location = New System.Drawing.Point(89, 61)
        Me.txtMaterialType.Name = "txtMaterialType"
        Me.txtMaterialType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMaterialType.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialType.Size = New System.Drawing.Size(152, 24)
        Me.txtMaterialType.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "材       料(&T):"
        '
        'gluLoan
        '
        Me.gluLoan.EditValue = ""
        Me.gluLoan.Location = New System.Drawing.Point(812, 32)
        Me.gluLoan.Name = "gluLoan"
        Me.gluLoan.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluLoan.Properties.Appearance.Options.UseFont = True
        Me.gluLoan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluLoan.Properties.NullText = ""
        Me.gluLoan.Properties.PopupFormWidth = 580
        Me.gluLoan.Properties.View = Me.GridView10
        Me.gluLoan.Size = New System.Drawing.Size(113, 24)
        Me.gluLoan.TabIndex = 137
        Me.gluLoan.Visible = False
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn26, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn27, Me.GridColumn28})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowAutoFilterRow = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.OptionsView.ShowIndicator = False
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "样办单号"
        Me.GridColumn31.FieldName = "SO_SampleID"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 0
        Me.GridColumn31.Width = 148
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "單號"
        Me.GridColumn26.FieldName = "SE_ID"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 1
        Me.GridColumn26.Width = 189
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "借出部門編號"
        Me.GridColumn18.FieldName = "SE_OutD_ID"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "借出部門"
        Me.GridColumn19.FieldName = "SE_OutD_Dep"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 162
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "借出工序編號"
        Me.GridColumn20.FieldName = "SE_OutPS_NO"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "借出工藝"
        Me.GridColumn21.FieldName = "SE_OutPS_Name"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 3
        Me.GridColumn21.Width = 161
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "還入部門編號"
        Me.GridColumn22.FieldName = "SE_InD_ID"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "還入部門"
        Me.GridColumn23.FieldName = "SE_InD_Dep"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 4
        Me.GridColumn23.Width = 163
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "還入工序編號"
        Me.GridColumn24.FieldName = "SE_InPS_NO"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "還入工序"
        Me.GridColumn25.FieldName = "SE_InPS_Name"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 5
        Me.GridColumn25.Width = 160
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "借出人員"
        Me.GridColumn27.FieldName = "SE_OutCardID"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 6
        Me.GridColumn27.Width = 131
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "數量"
        Me.GridColumn28.FieldName = "BarCodeCount"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 7
        Me.GridColumn28.Width = 109
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(738, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "借出单号:"
        Me.Label4.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Grid1)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 306)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1076, 348)
        Me.Panel4.TabIndex = 176
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtClientBarcode)
        Me.Panel6.Controls.Add(Me.lblClientBarcode)
        Me.Panel6.Controls.Add(Me.cmdAutoCode)
        Me.Panel6.Controls.Add(Me.cboCodeType)
        Me.Panel6.Controls.Add(Me.txtM_Code)
        Me.Panel6.Controls.Add(Me.lblCode)
        Me.Panel6.Controls.Add(Me.Label32)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1076, 41)
        Me.Panel6.TabIndex = 227
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(95, 14)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(22, 15)
        Me.Label32.TabIndex = 219
        Me.Label32.Text = "："
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdAdd)
        Me.Panel5.Controls.Add(Me.cmdSave)
        Me.Panel5.Controls.Add(Me.cmdExit)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.CheckEdit1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 654)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1076, 47)
        Me.Panel5.TabIndex = 177
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(746, 10)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(84, 27)
        Me.cmdAdd.TabIndex = 174
        Me.cmdAdd.Text = "新增(&A)"
        Me.cmdAdd.Visible = False
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "工艺序号名称"
        Me.GridColumn36.FieldName = "PS_NoName"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'frmSamplePaceInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 701)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSamplePaceInsert"
        Me.Text = "样办收发"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_Edition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CheckA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gluSE_InD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluInPS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtWeighing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluOutPS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSE_OutD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOutInQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cobSE_BarCodeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSealCode_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPK_CodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluLoan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dateAddDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents lblM_Code As System.Windows.Forms.Label
    Friend WithEvents gluSO_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSS_Edition As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSO_ID As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents gluType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabCheckDate As System.Windows.Forms.Label
    Friend WithEvents LabAction As System.Windows.Forms.Label
    Friend WithEvents CheckA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabSE_NO As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtClientBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblClientBarcode As System.Windows.Forms.Label
    Friend WithEvents cboCodeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SPID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClientBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_AddDateSub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkA As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gluOutPS_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluSE_OutD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblQtyOut As System.Windows.Forms.Label
    Friend WithEvents lbl_QtyOut As System.Windows.Forms.Label
    Friend WithEvents lblOutPS_NO As System.Windows.Forms.Label
    Friend WithEvents lblSE_OutD_ID As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gluSE_InD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluInPS_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblInPS_NO As System.Windows.Forms.Label
    Friend WithEvents lblSE_InD_ID As System.Windows.Forms.Label
    Friend WithEvents lblQtyIn As System.Windows.Forms.Label
    Friend WithEvents lbl_QtyIn As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluLoan As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSE_Remark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMaterialType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCheckDate As System.Windows.Forms.Label
    Friend WithEvents lblCheckName As System.Windows.Forms.Label
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluReason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPK_CodeID As System.Windows.Forms.Label
    Friend WithEvents txtPK_CodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSealCode_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSealCode_ID As System.Windows.Forms.Label
    Friend WithEvents lblSE_BarCodeType As System.Windows.Forms.Label
    Friend WithEvents cobSE_BarCodeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtOutInQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAutoCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTime As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblWeighing As System.Windows.Forms.Label
    Friend WithEvents txtWeighing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
