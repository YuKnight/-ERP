<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderCustomer
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboOC_CustomerID = New DevExpress.XtraEditors.ComboBoxEdit
        Me.dteOC_PODate = New DevExpress.XtraEditors.DateEdit
        Me.txtOC_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.gluM_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOC_Spare = New DevExpress.XtraEditors.TextEdit
        Me.txtOC_Index = New DevExpress.XtraEditors.TextEdit
        Me.txtOC_CustomerNo = New DevExpress.XtraEditors.TextEdit
        Me.txtOC_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtOC_CustomerPO = New DevExpress.XtraEditors.TextEdit
        Me.txtOC_ID = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.PI_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboOC_CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteOC_PODate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_Spare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_Index.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_CustomerNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_CustomerPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(530, 37)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(187, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "客戶訂單資料-新增"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboOC_CustomerID)
        Me.GroupBox1.Controls.Add(Me.dteOC_PODate)
        Me.GroupBox1.Controls.Add(Me.txtOC_Remark)
        Me.GroupBox1.Controls.Add(Me.gluM_Code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOC_Spare)
        Me.GroupBox1.Controls.Add(Me.txtOC_Index)
        Me.GroupBox1.Controls.Add(Me.txtOC_CustomerNo)
        Me.GroupBox1.Controls.Add(Me.txtOC_Qty)
        Me.GroupBox1.Controls.Add(Me.txtOC_CustomerPO)
        Me.GroupBox1.Controls.Add(Me.txtOC_ID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboOC_CustomerID
        '
        Me.cboOC_CustomerID.Location = New System.Drawing.Point(361, 59)
        Me.cboOC_CustomerID.Margin = New System.Windows.Forms.Padding(6)
        Me.cboOC_CustomerID.Name = "cboOC_CustomerID"
        Me.cboOC_CustomerID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOC_CustomerID.Properties.Appearance.Options.UseFont = True
        Me.cboOC_CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOC_CustomerID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOC_CustomerID.Size = New System.Drawing.Size(150, 24)
        Me.cboOC_CustomerID.TabIndex = 7
        '
        'dteOC_PODate
        '
        Me.dteOC_PODate.EditValue = Nothing
        Me.dteOC_PODate.Location = New System.Drawing.Point(102, 167)
        Me.dteOC_PODate.Margin = New System.Windows.Forms.Padding(6)
        Me.dteOC_PODate.Name = "dteOC_PODate"
        Me.dteOC_PODate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteOC_PODate.Properties.Appearance.Options.UseFont = True
        Me.dteOC_PODate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteOC_PODate.Size = New System.Drawing.Size(150, 24)
        Me.dteOC_PODate.TabIndex = 17
        '
        'txtOC_Remark
        '
        Me.txtOC_Remark.Location = New System.Drawing.Point(102, 203)
        Me.txtOC_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_Remark.Name = "txtOC_Remark"
        Me.txtOC_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOC_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtOC_Remark.Size = New System.Drawing.Size(409, 58)
        Me.txtOC_Remark.TabIndex = 21
        '
        'gluM_Code
        '
        Me.gluM_Code.Location = New System.Drawing.Point(102, 59)
        Me.gluM_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.gluM_Code.Name = "gluM_Code"
        Me.gluM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluM_Code.Properties.Appearance.Options.UseFont = True
        Me.gluM_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluM_Code.Properties.NullText = ""
        Me.gluM_Code.Properties.View = Me.GridView4
        Me.gluM_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluM_Code.TabIndex = 5
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PI_M_Name, Me.M_Code})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "備       注(&R):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 15)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "配件名稱(&T):"
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(361, 23)
        Me.gluPM_M_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.View = Me.GridView1
        Me.gluPM_M_Code.Size = New System.Drawing.Size(150, 24)
        Me.gluPM_M_Code.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn6})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(273, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "產品編號(&I):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(268, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "客戶代號(&N):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "訂單編號(&B):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(262, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "士         啤(&G):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(264, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "流   水   號(&J):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(265, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "客戶編號(&M):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "訂單數量(&L):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PO日  期(&E):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "客       戶&PO:"
        '
        'txtOC_Spare
        '
        Me.txtOC_Spare.EditValue = "0"
        Me.txtOC_Spare.Location = New System.Drawing.Point(361, 131)
        Me.txtOC_Spare.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_Spare.Name = "txtOC_Spare"
        Me.txtOC_Spare.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_Spare.Properties.Appearance.Options.UseFont = True
        Me.txtOC_Spare.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtOC_Spare.Properties.Mask.EditMask = "[0][.]\d{4}"
        Me.txtOC_Spare.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtOC_Spare.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_Spare.TabIndex = 15
        '
        'txtOC_Index
        '
        Me.txtOC_Index.Location = New System.Drawing.Point(361, 167)
        Me.txtOC_Index.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_Index.Name = "txtOC_Index"
        Me.txtOC_Index.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_Index.Properties.Appearance.Options.UseFont = True
        Me.txtOC_Index.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_Index.TabIndex = 19
        '
        'txtOC_CustomerNo
        '
        Me.txtOC_CustomerNo.Location = New System.Drawing.Point(361, 96)
        Me.txtOC_CustomerNo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_CustomerNo.Name = "txtOC_CustomerNo"
        Me.txtOC_CustomerNo.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_CustomerNo.Properties.Appearance.Options.UseFont = True
        Me.txtOC_CustomerNo.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_CustomerNo.TabIndex = 11
        '
        'txtOC_Qty
        '
        Me.txtOC_Qty.Location = New System.Drawing.Point(102, 131)
        Me.txtOC_Qty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_Qty.Name = "txtOC_Qty"
        Me.txtOC_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtOC_Qty.Properties.Mask.EditMask = "[1-9]\d*"
        Me.txtOC_Qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtOC_Qty.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_Qty.TabIndex = 13
        '
        'txtOC_CustomerPO
        '
        Me.txtOC_CustomerPO.Location = New System.Drawing.Point(102, 95)
        Me.txtOC_CustomerPO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_CustomerPO.Name = "txtOC_CustomerPO"
        Me.txtOC_CustomerPO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_CustomerPO.Properties.Appearance.Options.UseFont = True
        Me.txtOC_CustomerPO.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_CustomerPO.TabIndex = 9
        '
        'txtOC_ID
        '
        Me.txtOC_ID.Location = New System.Drawing.Point(102, 23)
        Me.txtOC_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOC_ID.Name = "txtOC_ID"
        Me.txtOC_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOC_ID.Properties.Appearance.Options.UseFont = True
        Me.txtOC_ID.Size = New System.Drawing.Size(150, 24)
        Me.txtOC_ID.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Controls.Add(Me.GroupBox1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 37)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(530, 332)
        Me.PanelControl2.TabIndex = 0
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(433, 291)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.btnSave.Location = New System.Drawing.Point(332, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "保存(&S)"
        '
        'PI_M_Name
        '
        Me.PI_M_Name.Caption = "配件名稱"
        Me.PI_M_Name.FieldName = "M_Name"
        Me.PI_M_Name.Name = "PI_M_Name"
        Me.PI_M_Name.Visible = True
        Me.PI_M_Name.VisibleIndex = 0
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "產品編號"
        Me.GridColumn7.FieldName = "PM_M_Code"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 220
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = strJIYU
        Me.GridColumn6.FieldName = "PM_JiYu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 178
        '
        'frmOrderCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(530, 369)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrderCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "客戶訂單資料-新增"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboOC_CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteOC_PODate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_Spare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_Index.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_CustomerNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_CustomerPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOC_CustomerPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOC_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gluM_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PI_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOC_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOC_CustomerNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOC_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOC_Index As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteOC_PODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboOC_CustomerID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOC_Spare As DevExpress.XtraEditors.TextEdit
End Class
