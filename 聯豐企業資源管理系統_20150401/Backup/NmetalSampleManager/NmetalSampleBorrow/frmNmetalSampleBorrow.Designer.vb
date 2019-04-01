<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleBorrow
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbCheck = New System.Windows.Forms.GroupBox
        Me.lblCheckDate = New DevExpress.XtraEditors.LabelControl
        Me.ce_IsCheck = New DevExpress.XtraEditors.CheckEdit
        Me.lblCheckUser = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtCardID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_Borrow_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtSO_ID = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcolSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolMaterialTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.caeAvailableQty = New DevExpress.XtraEditors.CalcEdit
        Me.txtMaterialTypeID = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dteRepayDate = New DevExpress.XtraEditors.DateEdit
        Me.txt_BorrowID = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.gluD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.gluPS_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcolPS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcolPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.gbCheck.SuspendLayout()
        CType(Me.ce_IsCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_Borrow_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caeAvailableQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteRepayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BorrowID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbCheck)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.txtCardID)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 400)
        Me.Panel1.TabIndex = 0
        '
        'gbCheck
        '
        Me.gbCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbCheck.Controls.Add(Me.lblCheckDate)
        Me.gbCheck.Controls.Add(Me.ce_IsCheck)
        Me.gbCheck.Controls.Add(Me.lblCheckUser)
        Me.gbCheck.Location = New System.Drawing.Point(3, 352)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(351, 44)
        Me.gbCheck.TabIndex = 0
        Me.gbCheck.TabStop = False
        '
        'lblCheckDate
        '
        Me.lblCheckDate.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckDate.Appearance.Options.UseFont = True
        Me.lblCheckDate.Location = New System.Drawing.Point(202, 21)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(75, 15)
        Me.lblCheckDate.TabIndex = 223
        Me.lblCheckDate.Text = "审核日期："
        '
        'ce_IsCheck
        '
        Me.ce_IsCheck.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ce_IsCheck.Location = New System.Drawing.Point(6, 16)
        Me.ce_IsCheck.Name = "ce_IsCheck"
        Me.ce_IsCheck.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.ce_IsCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ce_IsCheck.Properties.Appearance.Options.UseBackColor = True
        Me.ce_IsCheck.Properties.Appearance.Options.UseFont = True
        Me.ce_IsCheck.Properties.Caption = "审核"
        Me.ce_IsCheck.Size = New System.Drawing.Size(57, 20)
        Me.ce_IsCheck.TabIndex = 1
        '
        'lblCheckUser
        '
        Me.lblCheckUser.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckUser.Appearance.Options.UseFont = True
        Me.lblCheckUser.Location = New System.Drawing.Point(65, 18)
        Me.lblCheckUser.Name = "lblCheckUser"
        Me.lblCheckUser.Size = New System.Drawing.Size(75, 15)
        Me.lblCheckUser.TabIndex = 222
        Me.lblCheckUser.Text = "审核人员："
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(465, 6)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton2.TabIndex = 251
        Me.SimpleButton2.Text = "异常处理"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(446, 365)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(359, 365)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "确定(&O)"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(192, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton1.TabIndex = 249
        Me.SimpleButton1.Text = "刷卡(&K)"
        '
        'txtCardID
        '
        Me.txtCardID.EditValue = ""
        Me.txtCardID.Enabled = False
        Me.txtCardID.Location = New System.Drawing.Point(254, 6)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCardID.Properties.Appearance.Options.UseFont = True
        Me.txtCardID.Size = New System.Drawing.Size(207, 22)
        Me.txtCardID.TabIndex = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txt_Remark)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 331)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_Borrow_Qty)
        Me.GroupBox3.Controls.Add(Me.txtSO_ID)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.caeAvailableQty)
        Me.GroupBox3.Controls.Add(Me.txtMaterialTypeID)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dteRepayDate)
        Me.GroupBox3.Controls.Add(Me.txt_BorrowID)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtSO_SampleID)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.gluD_ID)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.gluPS_NO)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(4, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 163)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "领料基本数据"
        '
        'txt_Borrow_Qty
        '
        Me.txt_Borrow_Qty.EditValue = "0"
        Me.txt_Borrow_Qty.Location = New System.Drawing.Point(94, 133)
        Me.txt_Borrow_Qty.Name = "txt_Borrow_Qty"
        Me.txt_Borrow_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txt_Borrow_Qty.Properties.Appearance.Options.UseFont = True
        Me.txt_Borrow_Qty.Size = New System.Drawing.Size(172, 24)
        Me.txt_Borrow_Qty.TabIndex = 17
        '
        'txtSO_ID
        '
        Me.txtSO_ID.EditValue = ""
        Me.txtSO_ID.Enabled = False
        Me.txtSO_ID.Location = New System.Drawing.Point(342, 75)
        Me.txtSO_ID.Name = "txtSO_ID"
        Me.txtSO_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtSO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_ID.Size = New System.Drawing.Size(172, 24)
        Me.txtSO_ID.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(268, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "订单编号:"
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.Location = New System.Drawing.Point(94, 75)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 380
        Me.gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.View = Me.GridView1
        Me.gluPM_M_Code.Size = New System.Drawing.Size(172, 24)
        Me.gluPM_M_Code.TabIndex = 9
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolSO_SampleID, Me.gcolPM_M_Code, Me.gcolMaterialTypeName, Me.gcolSO_ID})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(268, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "可领数量:"
        '
        'caeAvailableQty
        '
        Me.caeAvailableQty.Enabled = False
        Me.caeAvailableQty.Location = New System.Drawing.Point(342, 131)
        Me.caeAvailableQty.Name = "caeAvailableQty"
        Me.caeAvailableQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.caeAvailableQty.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.caeAvailableQty.Properties.Appearance.Options.UseFont = True
        Me.caeAvailableQty.Properties.Appearance.Options.UseForeColor = True
        Me.caeAvailableQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.caeAvailableQty.Size = New System.Drawing.Size(172, 24)
        Me.caeAvailableQty.TabIndex = 19
        '
        'txtMaterialTypeID
        '
        Me.txtMaterialTypeID.EditValue = ""
        Me.txtMaterialTypeID.Enabled = False
        Me.txtMaterialTypeID.Location = New System.Drawing.Point(342, 103)
        Me.txtMaterialTypeID.Name = "txtMaterialTypeID"
        Me.txtMaterialTypeID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtMaterialTypeID.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialTypeID.Size = New System.Drawing.Size(172, 24)
        Me.txtMaterialTypeID.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(270, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "材       料:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "领料单号(&A):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "领料数量(&G):"
        '
        'dteRepayDate
        '
        Me.dteRepayDate.EditValue = Nothing
        Me.dteRepayDate.Enabled = False
        Me.dteRepayDate.Location = New System.Drawing.Point(342, 13)
        Me.dteRepayDate.Margin = New System.Windows.Forms.Padding(6)
        Me.dteRepayDate.Name = "dteRepayDate"
        Me.dteRepayDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteRepayDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dteRepayDate.Properties.Appearance.Options.UseFont = True
        Me.dteRepayDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteRepayDate.Properties.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.dteRepayDate.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteRepayDate.Size = New System.Drawing.Size(172, 24)
        Me.dteRepayDate.TabIndex = 3
        '
        'txt_BorrowID
        '
        Me.txt_BorrowID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BorrowID.Enabled = False
        Me.txt_BorrowID.Location = New System.Drawing.Point(94, 13)
        Me.txt_BorrowID.Name = "txt_BorrowID"
        Me.txt_BorrowID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_BorrowID.Properties.Appearance.Options.UseFont = True
        Me.txt_BorrowID.Size = New System.Drawing.Size(172, 24)
        Me.txt_BorrowID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(268, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "领料日期:"
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.EditValue = ""
        Me.txtSO_SampleID.Enabled = False
        Me.txtSO_SampleID.Location = New System.Drawing.Point(342, 46)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(172, 24)
        Me.txtSO_SampleID.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "部        门(&E):"
        '
        'gluD_ID
        '
        Me.gluD_ID.EditValue = ""
        Me.gluD_ID.Location = New System.Drawing.Point(94, 46)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayMember = "DepName"
        Me.gluD_ID.Properties.NullText = ""
        Me.gluD_ID.Properties.PopupFormWidth = 180
        Me.gluD_ID.Properties.ValueMember = "DepID"
        Me.gluD_ID.Properties.View = Me.GridView4
        Me.gluD_ID.Size = New System.Drawing.Size(172, 24)
        Me.gluD_ID.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(268, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "样办单号:"
        '
        'gluPS_NO
        '
        Me.gluPS_NO.Location = New System.Drawing.Point(94, 103)
        Me.gluPS_NO.Name = "gluPS_NO"
        Me.gluPS_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPS_NO.Properties.Appearance.Options.UseFont = True
        Me.gluPS_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPS_NO.Properties.DisplayMember = "PS_Name"
        Me.gluPS_NO.Properties.NullText = ""
        Me.gluPS_NO.Properties.PopupFormWidth = 180
        Me.gluPS_NO.Properties.ValueMember = "PS_NO"
        Me.gluPS_NO.Properties.View = Me.GridView2
        Me.gluPS_NO.Size = New System.Drawing.Size(172, 24)
        Me.gluPS_NO.TabIndex = 13
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolPS_NO, Me.gcolPS_Name})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1, 108)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "工        序(&S):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(3, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "产品编号(&F):"
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(98, 181)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_Remark.Properties.Appearance.Options.UseFont = True
        Me.txt_Remark.Size = New System.Drawing.Size(421, 135)
        Me.txt_Remark.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "备注(&M):"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 6)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 21)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "生产领料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmSampleBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 400)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampleBorrow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生产领料"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        CType(Me.ce_IsCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_Borrow_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caeAvailableQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteRepayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BorrowID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ce_IsCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbCheck As System.Windows.Forms.GroupBox
    Friend WithEvents lblCheckDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCheckUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaterialTypeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dteRepayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_BorrowID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gluPS_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolPS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents caeAvailableQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolMaterialTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Borrow_Qty As DevExpress.XtraEditors.TextEdit
End Class
