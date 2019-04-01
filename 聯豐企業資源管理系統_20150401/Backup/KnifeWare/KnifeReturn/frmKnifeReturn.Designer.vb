<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeReturn
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
        Me.txtR_NO = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.LabType = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareWB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popReturnAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popReturnDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.R_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.R_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.LabMsg = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRRPer_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabRRPer_ID1 = New System.Windows.Forms.Label
        Me.LabRRPer_Name = New System.Windows.Forms.Label
        Me.txtR_Type = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRPer_ID = New DevExpress.XtraEditors.TextEdit
        Me.DateR_Date = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.sk = New DevExpress.XtraEditors.SimpleButton
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.labRPer_Name = New System.Windows.Forms.Label
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtR_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareWB.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtRRPer_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtR_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRPer_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateR_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtR_NO
        '
        Me.txtR_NO.AllowDrop = True
        Me.txtR_NO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtR_NO.Location = New System.Drawing.Point(713, 6)
        Me.txtR_NO.Name = "txtR_NO"
        Me.txtR_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtR_NO.Properties.Appearance.Options.UseFont = True
        Me.txtR_NO.Properties.ReadOnly = True
        Me.txtR_NO.Size = New System.Drawing.Size(104, 22)
        Me.txtR_NO.TabIndex = 214
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(664, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 213
        Me.Label20.Text = "單號："
        '
        'LabType
        '
        Me.LabType.AutoSize = True
        Me.LabType.BackColor = System.Drawing.Color.Transparent
        Me.LabType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabType.ForeColor = System.Drawing.Color.Black
        Me.LabType.Location = New System.Drawing.Point(374, 9)
        Me.LabType.Name = "LabType"
        Me.LabType.Size = New System.Drawing.Size(28, 15)
        Me.LabType.TabIndex = 215
        Me.LabType.Text = "***"
        Me.LabType.Visible = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popWareWB
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 128)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemMemoExEdit2})
        Me.Grid1.Size = New System.Drawing.Size(836, 345)
        Me.Grid1.TabIndex = 212
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareWB
        '
        Me.popWareWB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popReturnAdd, Me.popReturnDel})
        Me.popWareWB.Name = "popWareInput"
        Me.popWareWB.Size = New System.Drawing.Size(157, 48)
        '
        'popReturnAdd
        '
        Me.popReturnAdd.Name = "popReturnAdd"
        Me.popReturnAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popReturnAdd.Size = New System.Drawing.Size(156, 22)
        Me.popReturnAdd.Text = "新增(&A)..."
        '
        'popReturnDel
        '
        Me.popReturnDel.Name = "popReturnDel"
        Me.popReturnDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popReturnDel.Size = New System.Drawing.Size(156, 22)
        Me.popReturnDel.Text = "刪除(&D)"
        Me.popReturnDel.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.R_Num, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.R_Qty, Me.Remark})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'R_Num
        '
        Me.R_Num.Caption = "流水號"
        Me.R_Num.FieldName = "R_Num"
        Me.R_Num.Name = "R_Num"
        Me.R_Num.OptionsColumn.ReadOnly = True
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
        Me.M_Gauge.Width = 362
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'R_Qty
        '
        Me.R_Qty.Caption = "還刀數"
        Me.R_Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.R_Qty.FieldName = "Qty"
        Me.R_Qty.Name = "R_Qty"
        Me.R_Qty.Visible = True
        Me.R_Qty.VisibleIndex = 3
        Me.R_Qty.Width = 71
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Remark
        '
        Me.Remark.Caption = "備注"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 4
        Me.Remark.Width = 110
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'LabMsg
        '
        Me.LabMsg.AutoSize = True
        Me.LabMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabMsg.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabMsg.ForeColor = System.Drawing.Color.Navy
        Me.LabMsg.Location = New System.Drawing.Point(6, 6)
        Me.LabMsg.Name = "LabMsg"
        Me.LabMsg.Size = New System.Drawing.Size(118, 24)
        Me.LabMsg.TabIndex = 211
        Me.LabMsg.Text = "還刀登記."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(834, 36)
        Me.PictureBox1.TabIndex = 209
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtRRPer_ID)
        Me.GroupBox1.Controls.Add(Me.LabRRPer_ID1)
        Me.GroupBox1.Controls.Add(Me.LabRRPer_Name)
        Me.GroupBox1.Controls.Add(Me.txtR_Type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRPer_ID)
        Me.GroupBox1.Controls.Add(Me.DateR_Date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.sk)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.labRPer_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 87)
        Me.GroupBox1.TabIndex = 210
        Me.GroupBox1.TabStop = False
        '
        'txtRRPer_ID
        '
        Me.txtRRPer_ID.Enabled = False
        Me.txtRRPer_ID.Location = New System.Drawing.Point(522, 22)
        Me.txtRRPer_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRRPer_ID.Name = "txtRRPer_ID"
        Me.txtRRPer_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRRPer_ID.Properties.Appearance.Options.UseFont = True
        Me.txtRRPer_ID.Size = New System.Drawing.Size(98, 24)
        Me.txtRRPer_ID.TabIndex = 187
        '
        'LabRRPer_ID1
        '
        Me.LabRRPer_ID1.AutoSize = True
        Me.LabRRPer_ID1.BackColor = System.Drawing.Color.Transparent
        Me.LabRRPer_ID1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabRRPer_ID1.ForeColor = System.Drawing.Color.Black
        Me.LabRRPer_ID1.Location = New System.Drawing.Point(446, 25)
        Me.LabRRPer_ID1.Name = "LabRRPer_ID1"
        Me.LabRRPer_ID1.Size = New System.Drawing.Size(76, 15)
        Me.LabRRPer_ID1.TabIndex = 186
        Me.LabRRPer_ID1.Text = "刷卡人(&N):"
        '
        'LabRRPer_Name
        '
        Me.LabRRPer_Name.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabRRPer_Name.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabRRPer_Name.Location = New System.Drawing.Point(623, 23)
        Me.LabRRPer_Name.Name = "LabRRPer_Name"
        Me.LabRRPer_Name.Size = New System.Drawing.Size(74, 20)
        Me.LabRRPer_Name.TabIndex = 188
        '
        'txtR_Type
        '
        Me.txtR_Type.Enabled = False
        Me.txtR_Type.Location = New System.Drawing.Point(104, 52)
        Me.txtR_Type.Margin = New System.Windows.Forms.Padding(6)
        Me.txtR_Type.Name = "txtR_Type"
        Me.txtR_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtR_Type.Properties.Appearance.Options.UseFont = True
        Me.txtR_Type.Size = New System.Drawing.Size(118, 24)
        Me.txtR_Type.TabIndex = 185
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
        Me.Label2.Text = "還刀屬性:"
        '
        'txtRPer_ID
        '
        Me.txtRPer_ID.Enabled = False
        Me.txtRPer_ID.Location = New System.Drawing.Point(317, 56)
        Me.txtRPer_ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRPer_ID.Name = "txtRPer_ID"
        Me.txtRPer_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRPer_ID.Properties.Appearance.Options.UseFont = True
        Me.txtRPer_ID.Size = New System.Drawing.Size(120, 24)
        Me.txtRPer_ID.TabIndex = 5
        '
        'DateR_Date
        '
        Me.DateR_Date.EditValue = Nothing
        Me.DateR_Date.Location = New System.Drawing.Point(317, 22)
        Me.DateR_Date.Margin = New System.Windows.Forms.Padding(6)
        Me.DateR_Date.Name = "DateR_Date"
        Me.DateR_Date.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateR_Date.Properties.Appearance.Options.UseFont = True
        Me.DateR_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateR_Date.Size = New System.Drawing.Size(120, 24)
        Me.DateR_Date.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(231, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "還刀人(&N):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(225, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "還刀日期(&E):"
        '
        'sk
        '
        Me.sk.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sk.Appearance.Options.UseFont = True
        Me.sk.Location = New System.Drawing.Point(739, 18)
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
        Me.Label22.Text = "倉   .  庫(&W):"
        '
        'labRPer_Name
        '
        Me.labRPer_Name.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labRPer_Name.ForeColor = System.Drawing.SystemColors.Desktop
        Me.labRPer_Name.Location = New System.Drawing.Point(441, 57)
        Me.labRPer_Name.Name = "labRPer_Name"
        Me.labRPer_Name.Size = New System.Drawing.Size(74, 20)
        Me.labRPer_Name.TabIndex = 183
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Enabled = False
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(608, 482)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 30)
        Me.cmdSave.TabIndex = 216
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(740, 482)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 30)
        Me.cmdExit.TabIndex = 217
        Me.cmdExit.Text = "取消(&C)"
        '
        'frmKnifeReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(838, 517)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtR_NO)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LabType)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.LabMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKnifeReturn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "還刀登記"
        CType(Me.txtR_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareWB.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtRRPer_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtR_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRPer_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateR_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtR_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabType As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents R_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents R_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents LabMsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtR_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRPer_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateR_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents labRPer_Name As System.Windows.Forms.Label
    Friend WithEvents txtRRPer_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabRRPer_ID1 As System.Windows.Forms.Label
    Friend WithEvents LabRRPer_Name As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents popWareWB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popReturnAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popReturnDel As System.Windows.Forms.ToolStripMenuItem
End Class
