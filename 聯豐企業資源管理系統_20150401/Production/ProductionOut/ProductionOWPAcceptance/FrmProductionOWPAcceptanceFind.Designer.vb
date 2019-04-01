<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductionOWPAcceptanceFind
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
        Me.gluSupplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSend_NO = New DevExpress.XtraEditors.TextEdit
        Me.txtO_NO = New DevExpress.XtraEditors.TextEdit
        Me.txtA_AcceptanceNO = New DevExpress.XtraEditors.TextEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.EditA_SendDateE = New DevExpress.XtraEditors.DateEdit
        Me.EditA_SendDateS = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblA_AcceptanceNO = New System.Windows.Forms.Label
        Me.LblO_NO = New System.Windows.Forms.Label
        Me.LblSend_NO = New System.Windows.Forms.Label
        Me.LblS_Supplier = New System.Windows.Forms.Label
        Me.PM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GlookP_Name = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lbl_M_PM_Code = New System.Windows.Forms.Label
        Me.GluType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LblPM_Type = New System.Windows.Forms.Label
        Me.LblProcess = New System.Windows.Forms.Label
        Me.LblTime = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSend_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtO_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtA_AcceptanceNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditA_SendDateE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditA_SendDateS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlookP_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gluSupplier
        '
        Me.gluSupplier.EditValue = ""
        Me.gluSupplier.Location = New System.Drawing.Point(102, 106)
        Me.gluSupplier.Name = "gluSupplier"
        Me.gluSupplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSupplier.Properties.Appearance.Options.UseFont = True
        Me.gluSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSupplier.Properties.NullText = ""
        Me.gluSupplier.Properties.PopupFormWidth = 200
        Me.gluSupplier.Properties.View = Me.GridLookUpEdit1View
        Me.gluSupplier.Size = New System.Drawing.Size(150, 22)
        Me.gluSupplier.TabIndex = 8
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "供應商編號"
        Me.GridColumn6.FieldName = "S_Supplier"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 180
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "供應商名稱"
        Me.GridColumn7.FieldName = "S_SupplierName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 218
        '
        'txtSend_NO
        '
        Me.txtSend_NO.EnterMoveNextControl = True
        Me.txtSend_NO.Location = New System.Drawing.Point(102, 78)
        Me.txtSend_NO.Name = "txtSend_NO"
        Me.txtSend_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSend_NO.Properties.Appearance.Options.UseFont = True
        Me.txtSend_NO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSend_NO.Size = New System.Drawing.Size(150, 22)
        Me.txtSend_NO.TabIndex = 6
        '
        'txtO_NO
        '
        Me.txtO_NO.EnterMoveNextControl = True
        Me.txtO_NO.Location = New System.Drawing.Point(102, 50)
        Me.txtO_NO.Name = "txtO_NO"
        Me.txtO_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtO_NO.Properties.Appearance.Options.UseFont = True
        Me.txtO_NO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtO_NO.Size = New System.Drawing.Size(150, 22)
        Me.txtO_NO.TabIndex = 4
        '
        'txtA_AcceptanceNO
        '
        Me.txtA_AcceptanceNO.EnterMoveNextControl = True
        Me.txtA_AcceptanceNO.Location = New System.Drawing.Point(102, 22)
        Me.txtA_AcceptanceNO.Name = "txtA_AcceptanceNO"
        Me.txtA_AcceptanceNO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtA_AcceptanceNO.Properties.Appearance.Options.UseFont = True
        Me.txtA_AcceptanceNO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtA_AcceptanceNO.Size = New System.Drawing.Size(150, 22)
        Me.txtA_AcceptanceNO.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSave.Location = New System.Drawing.Point(42, 296)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "查詢(&F)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(163, 296)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "取消(&C)"
        '
        'EditA_SendDateE
        '
        Me.EditA_SendDateE.EditValue = Nothing
        Me.EditA_SendDateE.Location = New System.Drawing.Point(132, 246)
        Me.EditA_SendDateE.Name = "EditA_SendDateE"
        Me.EditA_SendDateE.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EditA_SendDateE.Properties.Appearance.Options.UseFont = True
        Me.EditA_SendDateE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditA_SendDateE.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.EditA_SendDateE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EditA_SendDateE.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.EditA_SendDateE.Size = New System.Drawing.Size(120, 22)
        Me.EditA_SendDateE.TabIndex = 17
        '
        'EditA_SendDateS
        '
        Me.EditA_SendDateS.EditValue = Nothing
        Me.EditA_SendDateS.Location = New System.Drawing.Point(132, 218)
        Me.EditA_SendDateS.Name = "EditA_SendDateS"
        Me.EditA_SendDateS.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EditA_SendDateS.Properties.Appearance.Options.UseFont = True
        Me.EditA_SendDateS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditA_SendDateS.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.EditA_SendDateS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EditA_SendDateS.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.EditA_SendDateS.Size = New System.Drawing.Size(120, 22)
        Me.EditA_SendDateS.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "從"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "到"
        '
        'LblA_AcceptanceNO
        '
        Me.LblA_AcceptanceNO.AutoSize = True
        Me.LblA_AcceptanceNO.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblA_AcceptanceNO.Location = New System.Drawing.Point(19, 25)
        Me.LblA_AcceptanceNO.Name = "LblA_AcceptanceNO"
        Me.LblA_AcceptanceNO.Size = New System.Drawing.Size(84, 13)
        Me.LblA_AcceptanceNO.TabIndex = 1
        Me.LblA_AcceptanceNO.Text = "驗收單號(&I)："
        '
        'LblO_NO
        '
        Me.LblO_NO.AutoSize = True
        Me.LblO_NO.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblO_NO.Location = New System.Drawing.Point(11, 54)
        Me.LblO_NO.Name = "LblO_NO"
        Me.LblO_NO.Size = New System.Drawing.Size(92, 13)
        Me.LblO_NO.TabIndex = 3
        Me.LblO_NO.Text = "外發單號(&W)："
        '
        'LblSend_NO
        '
        Me.LblSend_NO.AutoSize = True
        Me.LblSend_NO.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblSend_NO.Location = New System.Drawing.Point(16, 82)
        Me.LblSend_NO.Name = "LblSend_NO"
        Me.LblSend_NO.Size = New System.Drawing.Size(87, 13)
        Me.LblSend_NO.TabIndex = 5
        Me.LblSend_NO.Text = "送貨單號(&S)："
        '
        'LblS_Supplier
        '
        Me.LblS_Supplier.AutoSize = True
        Me.LblS_Supplier.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblS_Supplier.Location = New System.Drawing.Point(17, 110)
        Me.LblS_Supplier.Name = "LblS_Supplier"
        Me.LblS_Supplier.Size = New System.Drawing.Size(86, 13)
        Me.LblS_Supplier.TabIndex = 7
        Me.LblS_Supplier.Text = "供  應  商(&P)："
        '
        'PM_M_Code
        '
        Me.PM_M_Code.EditValue = ""
        Me.PM_M_Code.Location = New System.Drawing.Point(102, 134)
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.PM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PM_M_Code.Properties.NullText = ""
        Me.PM_M_Code.Properties.PopupFormWidth = 200
        Me.PM_M_Code.Properties.View = Me.GridView3
        Me.PM_M_Code.Size = New System.Drawing.Size(150, 22)
        Me.PM_M_Code.TabIndex = 10
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.PM_JiYu})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品編號"
        Me.GridColumn2.FieldName = "PM_M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GlookP_Name
        '
        Me.GlookP_Name.EditValue = ""
        Me.GlookP_Name.Location = New System.Drawing.Point(102, 190)
        Me.GlookP_Name.Name = "GlookP_Name"
        Me.GlookP_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GlookP_Name.Properties.Appearance.Options.UseFont = True
        Me.GlookP_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GlookP_Name.Properties.NullText = ""
        Me.GlookP_Name.Properties.PopupFormWidth = 200
        Me.GlookP_Name.Properties.View = Me.GridView1
        Me.GlookP_Name.Size = New System.Drawing.Size(150, 22)
        Me.GlookP_Name.TabIndex = 14
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.PS_Name})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序單號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 0
        '
        'Lbl_M_PM_Code
        '
        Me.Lbl_M_PM_Code.AutoSize = True
        Me.Lbl_M_PM_Code.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_M_PM_Code.Location = New System.Drawing.Point(12, 138)
        Me.Lbl_M_PM_Code.Name = "Lbl_M_PM_Code"
        Me.Lbl_M_PM_Code.Size = New System.Drawing.Size(91, 13)
        Me.Lbl_M_PM_Code.TabIndex = 9
        Me.Lbl_M_PM_Code.Text = "產品編碼(&M)："
        '
        'GluType
        '
        Me.GluType.EditValue = ""
        Me.GluType.Location = New System.Drawing.Point(102, 162)
        Me.GluType.Name = "GluType"
        Me.GluType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluType.Properties.Appearance.Options.UseFont = True
        Me.GluType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluType.Properties.NullText = ""
        Me.GluType.Properties.PopupFormWidth = 200
        Me.GluType.Properties.View = Me.GridView2
        Me.GluType.Size = New System.Drawing.Size(150, 22)
        Me.GluType.TabIndex = 12
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "類型"
        Me.GridColumn1.FieldName = "PM_Type"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'LblPM_Type
        '
        Me.LblPM_Type.AutoSize = True
        Me.LblPM_Type.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPM_Type.Location = New System.Drawing.Point(14, 166)
        Me.LblPM_Type.Name = "LblPM_Type"
        Me.LblPM_Type.Size = New System.Drawing.Size(89, 13)
        Me.LblPM_Type.TabIndex = 11
        Me.LblPM_Type.Text = "配件名稱(&N)："
        '
        'LblProcess
        '
        Me.LblProcess.AutoSize = True
        Me.LblProcess.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblProcess.Location = New System.Drawing.Point(14, 194)
        Me.LblProcess.Name = "LblProcess"
        Me.LblProcess.Size = New System.Drawing.Size(89, 13)
        Me.LblProcess.TabIndex = 13
        Me.LblProcess.Text = "完工工序(&D)："
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTime.Location = New System.Drawing.Point(16, 222)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(87, 13)
        Me.LblTime.TabIndex = 15
        Me.LblTime.Text = "驗收時間(&T)："
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Lbl_M_PM_Code)
        Me.GroupBox1.Controls.Add(Me.LblTime)
        Me.GroupBox1.Controls.Add(Me.txtA_AcceptanceNO)
        Me.GroupBox1.Controls.Add(Me.PM_M_Code)
        Me.GroupBox1.Controls.Add(Me.txtO_NO)
        Me.GroupBox1.Controls.Add(Me.GlookP_Name)
        Me.GroupBox1.Controls.Add(Me.txtSend_NO)
        Me.GroupBox1.Controls.Add(Me.gluSupplier)
        Me.GroupBox1.Controls.Add(Me.GluType)
        Me.GroupBox1.Controls.Add(Me.EditA_SendDateS)
        Me.GroupBox1.Controls.Add(Me.LblPM_Type)
        Me.GroupBox1.Controls.Add(Me.EditA_SendDateE)
        Me.GroupBox1.Controls.Add(Me.LblProcess)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblS_Supplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblSend_NO)
        Me.GroupBox1.Controls.Add(Me.LblA_AcceptanceNO)
        Me.GroupBox1.Controls.Add(Me.LblO_NO)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 280)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.cmdExit)
        Me.PanelControl1.Controls.Add(Me.cmdSave)
        Me.PanelControl1.Location = New System.Drawing.Point(2, -2)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Size = New System.Drawing.Size(285, 333)
        Me.PanelControl1.TabIndex = 216
        Me.PanelControl1.Text = "PanelControl1"
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        '
        'FrmProductionOWPAcceptanceFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(289, 333)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProductionOWPAcceptanceFind"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "外發驗收單查詢"
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSend_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtO_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtA_AcceptanceNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditA_SendDateE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditA_SendDateS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlookP_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gluSupplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSend_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtO_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtA_AcceptanceNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditA_SendDateE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EditA_SendDateS As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblA_AcceptanceNO As System.Windows.Forms.Label
    Friend WithEvents LblO_NO As System.Windows.Forms.Label
    Friend WithEvents LblSend_NO As System.Windows.Forms.Label
    Friend WithEvents LblS_Supplier As System.Windows.Forms.Label
    Friend WithEvents PM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GlookP_Name As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lbl_M_PM_Code As System.Windows.Forms.Label
    Friend WithEvents GluType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblPM_Type As System.Windows.Forms.Label
    Friend WithEvents LblProcess As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
