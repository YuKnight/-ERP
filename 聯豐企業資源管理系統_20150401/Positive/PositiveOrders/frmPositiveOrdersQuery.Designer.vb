<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPositiveOrdersQuery
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
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gluCuster = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtP_OM_ID = New DevExpress.XtraEditors.TextEdit
        Me.dtPositiveOrdersStart = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridLookPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtPositiveOrdersEnd = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.orderEdit = New DevExpress.XtraEditors.CheckEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.sendEdit = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtD_NO = New DevExpress.XtraEditors.TextEdit
        Me.dtPositiveDeliverStart = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtPositiveDeliverEnd = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPositiveOrdersStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPositiveOrdersEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sendEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtD_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPositiveDeliverStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPositiveDeliverEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(193, 307)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSave.Location = New System.Drawing.Point(34, 305)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "查詢(&F)"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 43)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(322, 256)
        Me.XtraTabControl1.TabIndex = 47
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(313, 224)
        Me.XtraTabPage1.Text = "訂單查詢"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gluCuster)
        Me.GroupBox1.Controls.Add(Me.txtP_OM_ID)
        Me.GroupBox1.Controls.Add(Me.dtPositiveOrdersStart)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GridLookPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.dtPositiveOrdersEnd)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.orderEdit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.sendEdit)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 221)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'gluCuster
        '
        Me.gluCuster.EditValue = ""
        Me.gluCuster.EnterMoveNextControl = True
        Me.gluCuster.Location = New System.Drawing.Point(122, 84)
        Me.gluCuster.Name = "gluCuster"
        Me.gluCuster.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluCuster.Properties.Appearance.Options.UseFont = True
        Me.gluCuster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluCuster.Properties.NullText = ""
        Me.gluCuster.Properties.View = Me.GridLookUpEdit1View
        Me.gluCuster.Size = New System.Drawing.Size(172, 22)
        Me.gluCuster.TabIndex = 16
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "客戶代號"
        Me.GridColumn6.FieldName = "C_CusterID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "英文名"
        Me.GridColumn7.FieldName = "C_EngName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "中文名"
        Me.GridColumn1.FieldName = "C_ChsName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'txtP_OM_ID
        '
        Me.txtP_OM_ID.EnterMoveNextControl = True
        Me.txtP_OM_ID.Location = New System.Drawing.Point(122, 22)
        Me.txtP_OM_ID.Name = "txtP_OM_ID"
        Me.txtP_OM_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtP_OM_ID.Properties.Appearance.Options.UseFont = True
        Me.txtP_OM_ID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtP_OM_ID.Size = New System.Drawing.Size(173, 22)
        Me.txtP_OM_ID.TabIndex = 1
        '
        'dtPositiveOrdersStart
        '
        Me.dtPositiveOrdersStart.EditValue = Nothing
        Me.dtPositiveOrdersStart.Location = New System.Drawing.Point(121, 115)
        Me.dtPositiveOrdersStart.Name = "dtPositiveOrdersStart"
        Me.dtPositiveOrdersStart.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtPositiveOrdersStart.Properties.Appearance.Options.UseFont = True
        Me.dtPositiveOrdersStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPositiveOrdersStart.Size = New System.Drawing.Size(173, 24)
        Me.dtPositiveOrdersStart.TabIndex = 10
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(13, 56)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "產品編號(&L) ："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "到"
        '
        'GridLookPM_M_Code
        '
        Me.GridLookPM_M_Code.EditValue = ""
        Me.GridLookPM_M_Code.EnterMoveNextControl = True
        Me.GridLookPM_M_Code.Location = New System.Drawing.Point(122, 53)
        Me.GridLookPM_M_Code.Name = "GridLookPM_M_Code"
        Me.GridLookPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.GridLookPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookPM_M_Code.Properties.NullText = ""
        Me.GridLookPM_M_Code.Properties.View = Me.GridView1
        Me.GridLookPM_M_Code.Size = New System.Drawing.Size(173, 22)
        Me.GridLookPM_M_Code.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code, Me.PM_JiYu})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品資料"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "產品類型"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        '
        'dtPositiveOrdersEnd
        '
        Me.dtPositiveOrdersEnd.EditValue = Nothing
        Me.dtPositiveOrdersEnd.Location = New System.Drawing.Point(121, 150)
        Me.dtPositiveOrdersEnd.Name = "dtPositiveOrdersEnd"
        Me.dtPositiveOrdersEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtPositiveOrdersEnd.Properties.Appearance.Options.UseFont = True
        Me.dtPositiveOrdersEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPositiveOrdersEnd.Size = New System.Drawing.Size(173, 24)
        Me.dtPositiveOrdersEnd.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 86)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "客戶代號(&N)："
        '
        'orderEdit
        '
        Me.orderEdit.EditValue = True
        Me.orderEdit.Location = New System.Drawing.Point(99, 191)
        Me.orderEdit.Name = "orderEdit"
        Me.orderEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.orderEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.orderEdit.Properties.Appearance.Options.UseBackColor = True
        Me.orderEdit.Properties.Appearance.Options.UseFont = True
        Me.orderEdit.Properties.Caption = "下單日期"
        Me.orderEdit.Size = New System.Drawing.Size(97, 21)
        Me.orderEdit.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "從"
        '
        'sendEdit
        '
        Me.sendEdit.Location = New System.Drawing.Point(198, 191)
        Me.sendEdit.Name = "sendEdit"
        Me.sendEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sendEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sendEdit.Properties.Appearance.Options.UseBackColor = True
        Me.sendEdit.Properties.Appearance.Options.UseFont = True
        Me.sendEdit.Properties.Caption = "交貨日期"
        Me.sendEdit.Size = New System.Drawing.Size(95, 21)
        Me.sendEdit.TabIndex = 13
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(13, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "訂單編號(&I)  ："
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(313, 224)
        Me.XtraTabPage2.Text = "送貨查詢"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtD_NO)
        Me.GroupBox2.Controls.Add(Me.dtPositiveDeliverStart)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GridLookUpEdit2)
        Me.GroupBox2.Controls.Add(Me.dtPositiveDeliverEnd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 221)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtD_NO
        '
        Me.txtD_NO.EnterMoveNextControl = True
        Me.txtD_NO.Location = New System.Drawing.Point(120, 22)
        Me.txtD_NO.Name = "txtD_NO"
        Me.txtD_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtD_NO.Properties.Appearance.Options.UseFont = True
        Me.txtD_NO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtD_NO.Size = New System.Drawing.Size(173, 22)
        Me.txtD_NO.TabIndex = 1
        '
        'dtPositiveDeliverStart
        '
        Me.dtPositiveDeliverStart.EditValue = Nothing
        Me.dtPositiveDeliverStart.Location = New System.Drawing.Point(120, 122)
        Me.dtPositiveDeliverStart.Name = "dtPositiveDeliverStart"
        Me.dtPositiveDeliverStart.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtPositiveDeliverStart.Properties.Appearance.Options.UseFont = True
        Me.dtPositiveDeliverStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPositiveDeliverStart.Size = New System.Drawing.Size(173, 24)
        Me.dtPositiveDeliverStart.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "產品編號(&L) ："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "截至日期     ："
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.EditValue = ""
        Me.GridLookUpEdit2.EnterMoveNextControl = True
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(120, 72)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.View = Me.GridView3
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(173, 22)
        Me.GridLookUpEdit2.TabIndex = 3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn8})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "產品資料"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "產品類型"
        Me.GridColumn8.FieldName = "PM_JiYu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'dtPositiveDeliverEnd
        '
        Me.dtPositiveDeliverEnd.EditValue = Nothing
        Me.dtPositiveDeliverEnd.Location = New System.Drawing.Point(120, 174)
        Me.dtPositiveDeliverEnd.Name = "dtPositiveDeliverEnd"
        Me.dtPositiveDeliverEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dtPositiveDeliverEnd.Properties.Appearance.Options.UseFont = True
        Me.dtPositiveDeliverEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPositiveDeliverEnd.Size = New System.Drawing.Size(173, 24)
        Me.dtPositiveDeliverEnd.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "起始日期     ："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(13, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "送貨單號(&I)  ："
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 36)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 24)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "陽極資料查詢"
        '
        'frmPositiveOrdersQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 353)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPositiveOrdersQuery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "陽極資料查詢"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gluCuster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtP_OM_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPositiveOrdersStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPositiveOrdersEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sendEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtD_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPositiveDeliverStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPositiveDeliverEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtP_OM_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtPositiveOrdersStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridLookPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtPositiveOrdersEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtD_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtPositiveDeliverStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtPositiveDeliverEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gluCuster As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents orderEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sendEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
