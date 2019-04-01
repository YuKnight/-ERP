<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeBorrow
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.popWareWB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.CaptionLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabSX = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtB_Type = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBPer_ID = New DevExpress.XtraEditors.TextEdit
        Me.DateB_Date = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.sk = New DevExpress.XtraEditors.SimpleButton
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.labBPer_Name = New System.Windows.Forms.Label
        Me.LabMsg = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.B_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.B_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.B_EndQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.txtB_NO = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.LabType = New System.Windows.Forms.Label
        Me.LabPerNO = New System.Windows.Forms.Label
        Me.ButtonTest = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareWB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtB_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBPer_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateB_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtB_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(540, 460)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 30)
        Me.cmdSave.TabIndex = 201
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(672, 460)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 30)
        Me.cmdExit.TabIndex = 202
        Me.cmdExit.Text = "取消(&C)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(775, 36)
        Me.PictureBox1.TabIndex = 198
        Me.PictureBox1.TabStop = False
        '
        'popWareWB
        '
        Me.popWareWB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareOutAdd, Me.popWareOutDel})
        Me.popWareWB.Name = "popWareInput"
        Me.popWareWB.Size = New System.Drawing.Size(157, 48)
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(156, 22)
        Me.popWareOutAdd.Text = "新增(&A)..."
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(156, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaptionLabel.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaptionLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaptionLabel.Location = New System.Drawing.Point(4, 10)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(106, 24)
        Me.CaptionLabel.TabIndex = 199
        Me.CaptionLabel.Text = "分倉領刀"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabSX)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtB_Type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBPer_ID)
        Me.GroupBox1.Controls.Add(Me.DateB_Date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.sk)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.labBPer_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 87)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        '
        'LabSX
        '
        Me.LabSX.AutoSize = True
        Me.LabSX.BackColor = System.Drawing.Color.Transparent
        Me.LabSX.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabSX.ForeColor = System.Drawing.Color.Black
        Me.LabSX.Location = New System.Drawing.Point(336, 57)
        Me.LabSX.Name = "LabSX"
        Me.LabSX.Size = New System.Drawing.Size(28, 15)
        Me.LabSX.TabIndex = 187
        Me.LabSX.Text = "***"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(254, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "領刀上限:"
        '
        'txtB_Type
        '
        Me.txtB_Type.Enabled = False
        Me.txtB_Type.Location = New System.Drawing.Point(104, 52)
        Me.txtB_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.txtB_Type.Name = "txtB_Type"
        Me.txtB_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtB_Type.Properties.Appearance.Options.UseFont = True
        Me.txtB_Type.Size = New System.Drawing.Size(118, 24)
        Me.txtB_Type.TabIndex = 185
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "發刀屬性:"
        '
        'txtBPer_ID
        '
        Me.txtBPer_ID.Enabled = False
        Me.txtBPer_ID.Location = New System.Drawing.Point(545, 20)
        Me.txtBPer_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBPer_ID.Name = "txtBPer_ID"
        Me.txtBPer_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtBPer_ID.Properties.Appearance.Options.UseFont = True
        Me.txtBPer_ID.Size = New System.Drawing.Size(120, 24)
        Me.txtBPer_ID.TabIndex = 5
        '
        'DateB_Date
        '
        Me.DateB_Date.EditValue = Nothing
        Me.DateB_Date.Location = New System.Drawing.Point(331, 20)
        Me.DateB_Date.Margin = New System.Windows.Forms.Padding(6)
        Me.DateB_Date.Name = "DateB_Date"
        Me.DateB_Date.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateB_Date.Properties.Appearance.Options.UseFont = True
        Me.DateB_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateB_Date.Size = New System.Drawing.Size(120, 24)
        Me.DateB_Date.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(460, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "借刀人(&N):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(235, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "借刀日期(&E):"
        '
        'sk
        '
        Me.sk.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sk.Appearance.Options.UseFont = True
        Me.sk.Location = New System.Drawing.Point(712, 16)
        Me.sk.Name = "sk"
        Me.sk.Size = New System.Drawing.Size(56, 28)
        Me.sk.TabIndex = 6
        Me.sk.Text = "刷卡(&S)"
        '
        'txtWH
        '
        Me.txtWH.Location = New System.Drawing.Point(104, 20)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(120, 24)
        Me.txtWH.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "倉      庫(&W):"
        '
        'labBPer_Name
        '
        Me.labBPer_Name.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labBPer_Name.ForeColor = System.Drawing.SystemColors.Desktop
        Me.labBPer_Name.Location = New System.Drawing.Point(583, 50)
        Me.labBPer_Name.Name = "labBPer_Name"
        Me.labBPer_Name.Size = New System.Drawing.Size(82, 17)
        Me.labBPer_Name.TabIndex = 183
        '
        'LabMsg
        '
        Me.LabMsg.AutoSize = True
        Me.LabMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabMsg.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabMsg.ForeColor = System.Drawing.Color.Navy
        Me.LabMsg.Location = New System.Drawing.Point(4, 7)
        Me.LabMsg.Name = "LabMsg"
        Me.LabMsg.Size = New System.Drawing.Size(106, 24)
        Me.LabMsg.TabIndex = 204
        Me.LabMsg.Text = "借刀登記"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popWareWB
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 129)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit2})
        Me.Grid1.Size = New System.Drawing.Size(774, 323)
        Me.Grid1.TabIndex = 205
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.B_Num, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.B_Qty, Me.B_EndQty, Me.B_Remark})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'B_Num
        '
        Me.B_Num.Caption = "流水號"
        Me.B_Num.FieldName = "B_Num"
        Me.B_Num.Name = "B_Num"
        Me.B_Num.OptionsColumn.ReadOnly = True
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 125
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 135
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 135
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'B_Qty
        '
        Me.B_Qty.Caption = "借刀數量"
        Me.B_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.B_Qty.FieldName = "B_Qty"
        Me.B_Qty.Name = "B_Qty"
        Me.B_Qty.Visible = True
        Me.B_Qty.VisibleIndex = 3
        Me.B_Qty.Width = 90
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'B_EndQty
        '
        Me.B_EndQty.Caption = "當前庫存"
        Me.B_EndQty.FieldName = "B_EndQty"
        Me.B_EndQty.Name = "B_EndQty"
        Me.B_EndQty.OptionsColumn.ReadOnly = True
        Me.B_EndQty.Visible = True
        Me.B_EndQty.VisibleIndex = 4
        Me.B_EndQty.Width = 100
        '
        'B_Remark
        '
        Me.B_Remark.Caption = "備注"
        Me.B_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.B_Remark.FieldName = "B_Remark"
        Me.B_Remark.Name = "B_Remark"
        Me.B_Remark.Visible = True
        Me.B_Remark.VisibleIndex = 5
        Me.B_Remark.Width = 141
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'txtB_NO
        '
        Me.txtB_NO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtB_NO.Location = New System.Drawing.Point(659, 7)
        Me.txtB_NO.Name = "txtB_NO"
        Me.txtB_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtB_NO.Properties.Appearance.Options.UseFont = True
        Me.txtB_NO.Properties.ReadOnly = True
        Me.txtB_NO.Size = New System.Drawing.Size(104, 22)
        Me.txtB_NO.TabIndex = 207
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(610, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 206
        Me.Label20.Text = "單號："
        '
        'LabType
        '
        Me.LabType.AutoSize = True
        Me.LabType.BackColor = System.Drawing.Color.Transparent
        Me.LabType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabType.ForeColor = System.Drawing.Color.Black
        Me.LabType.Location = New System.Drawing.Point(235, 10)
        Me.LabType.Name = "LabType"
        Me.LabType.Size = New System.Drawing.Size(28, 15)
        Me.LabType.TabIndex = 208
        Me.LabType.Text = "***"
        Me.LabType.Visible = False
        '
        'LabPerNO
        '
        Me.LabPerNO.AutoSize = True
        Me.LabPerNO.Location = New System.Drawing.Point(302, 10)
        Me.LabPerNO.Name = "LabPerNO"
        Me.LabPerNO.Size = New System.Drawing.Size(31, 12)
        Me.LabPerNO.TabIndex = 209
        Me.LabPerNO.Text = "Label"
        Me.LabPerNO.Visible = False
        '
        'ButtonTest
        '
        Me.ButtonTest.Location = New System.Drawing.Point(8, 460)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(62, 30)
        Me.ButtonTest.TabIndex = 210
        Me.ButtonTest.Text = "測試LCD"
        '
        'frmKnifeBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(775, 497)
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.LabPerNO)
        Me.Controls.Add(Me.txtB_NO)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LabType)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.LabMsg)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmKnifeBorrow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "借刀登記"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareWB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtB_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBPer_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateB_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtB_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popWareWB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBPer_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateB_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents labBPer_Name As System.Windows.Forms.Label
    Friend WithEvents LabMsg As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents B_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_EndQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtB_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtB_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabSX As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents LabType As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents LabPerNO As System.Windows.Forms.Label
    Friend WithEvents ButtonTest As DevExpress.XtraEditors.SimpleButton
End Class
