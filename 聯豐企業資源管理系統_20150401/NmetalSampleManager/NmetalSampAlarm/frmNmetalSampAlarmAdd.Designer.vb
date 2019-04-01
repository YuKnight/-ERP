<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampAlarmAdd
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton
        Me.lblSE_ID = New System.Windows.Forms.Label
        Me.txtSE_ID = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOccurAddress = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOccurReason = New DevExpress.XtraEditors.ComboBoxEdit
        Me.gluD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProcessResult = New DevExpress.XtraEditors.MemoEdit
        Me.txtSE_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_InCardID = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_InD_Dep = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_OutCardID = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_OutD_Dep = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_AddDate = New DevExpress.XtraEditors.TextEdit
        Me.txtSE_AddUserName = New DevExpress.XtraEditors.TextEdit
        Me.txtPM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.lblProcessResult = New System.Windows.Forms.Label
        Me.lblSE_OutCardID = New System.Windows.Forms.Label
        Me.lblSE_AddDate = New System.Windows.Forms.Label
        Me.lblSE_OutD_Dep = New System.Windows.Forms.Label
        Me.lblSO_SampleID = New System.Windows.Forms.Label
        Me.lblSE_Qty = New System.Windows.Forms.Label
        Me.lblSE_InCardID = New System.Windows.Forms.Label
        Me.txt_SO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.lblSE_AddUserName = New System.Windows.Forms.Label
        Me.lblSE_InD_Dep = New System.Windows.Forms.Label
        Me.gbCheck = New System.Windows.Forms.GroupBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblCheckDate = New DevExpress.XtraEditors.LabelControl
        Me.ce_IsCheck = New DevExpress.XtraEditors.CheckEdit
        Me.lblCheckUser = New DevExpress.XtraEditors.LabelControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDutyUserID = New DevExpress.XtraEditors.TextEdit
        Me.ControlDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOccurAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOccurReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_InCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_InD_Dep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_OutCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_OutD_Dep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_AddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSE_AddUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCheck.SuspendLayout()
        CType(Me.ce_IsCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDutyUserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 21)
        Me.lblTitle.TabIndex = 86
        Me.lblTitle.Text = "报警信息服务"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.SimpleButton1.Location = New System.Drawing.Point(468, 392)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(68, 27)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "取消(&E)"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.SaveButton.Location = New System.Drawing.Point(394, 391)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(69, 29)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "确认(&S)"
        '
        'lblSE_ID
        '
        Me.lblSE_ID.AutoSize = True
        Me.lblSE_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSE_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_ID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_ID.Location = New System.Drawing.Point(291, 7)
        Me.lblSE_ID.Name = "lblSE_ID"
        Me.lblSE_ID.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_ID.TabIndex = 0
        Me.lblSE_ID.Text = "收发单号:"
        '
        'txtSE_ID
        '
        Me.txtSE_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_ID.Enabled = False
        Me.txtSE_ID.Location = New System.Drawing.Point(365, 3)
        Me.txtSE_ID.Name = "txtSE_ID"
        Me.txtSE_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSE_ID.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_ID.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDutyUserID)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtOccurAddress)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtOccurReason)
        Me.GroupBox3.Controls.Add(Me.gluD_ID)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtProcessResult)
        Me.GroupBox3.Controls.Add(Me.txtSE_Qty)
        Me.GroupBox3.Controls.Add(Me.txtSE_InCardID)
        Me.GroupBox3.Controls.Add(Me.txtSE_InD_Dep)
        Me.GroupBox3.Controls.Add(Me.txtSE_OutCardID)
        Me.GroupBox3.Controls.Add(Me.txtSE_OutD_Dep)
        Me.GroupBox3.Controls.Add(Me.txtSE_AddDate)
        Me.GroupBox3.Controls.Add(Me.txtSE_AddUserName)
        Me.GroupBox3.Controls.Add(Me.txtPM_M_Code)
        Me.GroupBox3.Controls.Add(Me.lblProcessResult)
        Me.GroupBox3.Controls.Add(Me.lblSE_OutCardID)
        Me.GroupBox3.Controls.Add(Me.lblSE_AddDate)
        Me.GroupBox3.Controls.Add(Me.lblSE_OutD_Dep)
        Me.GroupBox3.Controls.Add(Me.lblSO_SampleID)
        Me.GroupBox3.Controls.Add(Me.lblSE_Qty)
        Me.GroupBox3.Controls.Add(Me.lblSE_InCardID)
        Me.GroupBox3.Controls.Add(Me.txt_SO_SampleID)
        Me.GroupBox3.Controls.Add(Me.lblPM_M_Code)
        Me.GroupBox3.Controls.Add(Me.lblSE_AddUserName)
        Me.GroupBox3.Controls.Add(Me.lblSE_InD_Dep)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(4, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 350)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "基本数据"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(97, 300)
        Me.txtRemark.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Size = New System.Drawing.Size(430, 46)
        Me.txtRemark.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "备        注(&B):"
        '
        'txtOccurAddress
        '
        Me.txtOccurAddress.EditValue = ""
        Me.txtOccurAddress.Location = New System.Drawing.Point(97, 197)
        Me.txtOccurAddress.Name = "txtOccurAddress"
        Me.txtOccurAddress.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccurAddress.Properties.Appearance.Options.UseFont = True
        Me.txtOccurAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOccurAddress.Size = New System.Drawing.Size(430, 24)
        Me.txtOccurAddress.TabIndex = 23
        Me.txtOccurAddress.ToolTip = "可以手动新增发生地点"
        Me.txtOccurAddress.ToolTipTitle = "地点"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "发生地点(&D):"
        '
        'txtOccurReason
        '
        Me.txtOccurReason.EditValue = ""
        Me.txtOccurReason.Location = New System.Drawing.Point(97, 224)
        Me.txtOccurReason.Name = "txtOccurReason"
        Me.txtOccurReason.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccurReason.Properties.Appearance.Options.UseFont = True
        Me.txtOccurReason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOccurReason.Properties.Items.AddRange(New Object() {"1.条码枪读条码太慢", "2.司机去吃饭", "3.发料部门产品没到收料部门", "4.借出的产品找不到", "5.条码丢失", "6.第三方盘点"})
        Me.txtOccurReason.Size = New System.Drawing.Size(430, 24)
        Me.txtOccurReason.TabIndex = 25
        Me.txtOccurReason.ToolTip = "可以手动新增发生原因"
        Me.txtOccurReason.ToolTipTitle = "标题"
        '
        'gluD_ID
        '
        Me.gluD_ID.EditValue = ""
        Me.gluD_ID.Location = New System.Drawing.Point(97, 143)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayMember = "DepName"
        Me.gluD_ID.Properties.NullText = ""
        Me.gluD_ID.Properties.PopupFormWidth = 180
        Me.gluD_ID.Properties.ValueMember = "ControlDep"
        Me.gluD_ID.Properties.View = Me.GridView4
        Me.gluD_ID.Size = New System.Drawing.Size(166, 24)
        Me.gluD_ID.TabIndex = 19
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ControlDep, Me.DepName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "发生原因(&N):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "责任部门:"
        '
        'txtProcessResult
        '
        Me.txtProcessResult.Location = New System.Drawing.Point(97, 251)
        Me.txtProcessResult.Margin = New System.Windows.Forms.Padding(6)
        Me.txtProcessResult.Name = "txtProcessResult"
        Me.txtProcessResult.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtProcessResult.Properties.Appearance.Options.UseFont = True
        Me.txtProcessResult.Size = New System.Drawing.Size(430, 46)
        Me.txtProcessResult.TabIndex = 27
        '
        'txtSE_Qty
        '
        Me.txtSE_Qty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_Qty.Enabled = False
        Me.txtSE_Qty.Location = New System.Drawing.Point(97, 117)
        Me.txtSE_Qty.Name = "txtSE_Qty"
        Me.txtSE_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtSE_Qty.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_Qty.TabIndex = 17
        '
        'txtSE_InCardID
        '
        Me.txtSE_InCardID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_InCardID.Enabled = False
        Me.txtSE_InCardID.Location = New System.Drawing.Point(361, 91)
        Me.txtSE_InCardID.Name = "txtSE_InCardID"
        Me.txtSE_InCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_InCardID.Properties.Appearance.Options.UseFont = True
        Me.txtSE_InCardID.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_InCardID.TabIndex = 15
        '
        'txtSE_InD_Dep
        '
        Me.txtSE_InD_Dep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_InD_Dep.Enabled = False
        Me.txtSE_InD_Dep.Location = New System.Drawing.Point(361, 65)
        Me.txtSE_InD_Dep.Name = "txtSE_InD_Dep"
        Me.txtSE_InD_Dep.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_InD_Dep.Properties.Appearance.Options.UseFont = True
        Me.txtSE_InD_Dep.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_InD_Dep.TabIndex = 11
        '
        'txtSE_OutCardID
        '
        Me.txtSE_OutCardID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_OutCardID.Enabled = False
        Me.txtSE_OutCardID.Location = New System.Drawing.Point(97, 91)
        Me.txtSE_OutCardID.Name = "txtSE_OutCardID"
        Me.txtSE_OutCardID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_OutCardID.Properties.Appearance.Options.UseFont = True
        Me.txtSE_OutCardID.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_OutCardID.TabIndex = 13
        '
        'txtSE_OutD_Dep
        '
        Me.txtSE_OutD_Dep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_OutD_Dep.Enabled = False
        Me.txtSE_OutD_Dep.Location = New System.Drawing.Point(97, 65)
        Me.txtSE_OutD_Dep.Name = "txtSE_OutD_Dep"
        Me.txtSE_OutD_Dep.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_OutD_Dep.Properties.Appearance.Options.UseFont = True
        Me.txtSE_OutD_Dep.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_OutD_Dep.TabIndex = 9
        '
        'txtSE_AddDate
        '
        Me.txtSE_AddDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_AddDate.Enabled = False
        Me.txtSE_AddDate.Location = New System.Drawing.Point(361, 39)
        Me.txtSE_AddDate.Name = "txtSE_AddDate"
        Me.txtSE_AddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_AddDate.Properties.Appearance.Options.UseFont = True
        Me.txtSE_AddDate.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_AddDate.TabIndex = 7
        '
        'txtSE_AddUserName
        '
        Me.txtSE_AddUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSE_AddUserName.Enabled = False
        Me.txtSE_AddUserName.Location = New System.Drawing.Point(361, 13)
        Me.txtSE_AddUserName.Name = "txtSE_AddUserName"
        Me.txtSE_AddUserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSE_AddUserName.Properties.Appearance.Options.UseFont = True
        Me.txtSE_AddUserName.Size = New System.Drawing.Size(166, 24)
        Me.txtSE_AddUserName.TabIndex = 3
        '
        'txtPM_M_Code
        '
        Me.txtPM_M_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPM_M_Code.Enabled = False
        Me.txtPM_M_Code.Location = New System.Drawing.Point(97, 39)
        Me.txtPM_M_Code.Name = "txtPM_M_Code"
        Me.txtPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_M_Code.Size = New System.Drawing.Size(166, 24)
        Me.txtPM_M_Code.TabIndex = 5
        '
        'lblProcessResult
        '
        Me.lblProcessResult.AutoSize = True
        Me.lblProcessResult.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessResult.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblProcessResult.ForeColor = System.Drawing.Color.Black
        Me.lblProcessResult.Location = New System.Drawing.Point(6, 251)
        Me.lblProcessResult.Name = "lblProcessResult"
        Me.lblProcessResult.Size = New System.Drawing.Size(90, 15)
        Me.lblProcessResult.TabIndex = 26
        Me.lblProcessResult.Text = "解决对策(&C):"
        '
        'lblSE_OutCardID
        '
        Me.lblSE_OutCardID.AutoSize = True
        Me.lblSE_OutCardID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_OutCardID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_OutCardID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_OutCardID.Location = New System.Drawing.Point(10, 96)
        Me.lblSE_OutCardID.Name = "lblSE_OutCardID"
        Me.lblSE_OutCardID.Size = New System.Drawing.Size(86, 15)
        Me.lblSE_OutCardID.TabIndex = 12
        Me.lblSE_OutCardID.Text = "发料刷卡人:"
        '
        'lblSE_AddDate
        '
        Me.lblSE_AddDate.AutoSize = True
        Me.lblSE_AddDate.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_AddDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_AddDate.ForeColor = System.Drawing.Color.Black
        Me.lblSE_AddDate.Location = New System.Drawing.Point(278, 44)
        Me.lblSE_AddDate.Name = "lblSE_AddDate"
        Me.lblSE_AddDate.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_AddDate.TabIndex = 6
        Me.lblSE_AddDate.Text = "报警时间:"
        '
        'lblSE_OutD_Dep
        '
        Me.lblSE_OutD_Dep.AutoSize = True
        Me.lblSE_OutD_Dep.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_OutD_Dep.ForeColor = System.Drawing.Color.Black
        Me.lblSE_OutD_Dep.Location = New System.Drawing.Point(25, 70)
        Me.lblSE_OutD_Dep.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.lblSE_OutD_Dep.Name = "lblSE_OutD_Dep"
        Me.lblSE_OutD_Dep.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_OutD_Dep.TabIndex = 8
        Me.lblSE_OutD_Dep.Text = "发料部门:"
        '
        'lblSO_SampleID
        '
        Me.lblSO_SampleID.AutoSize = True
        Me.lblSO_SampleID.BackColor = System.Drawing.Color.Transparent
        Me.lblSO_SampleID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSO_SampleID.ForeColor = System.Drawing.Color.Black
        Me.lblSO_SampleID.Location = New System.Drawing.Point(25, 18)
        Me.lblSO_SampleID.Name = "lblSO_SampleID"
        Me.lblSO_SampleID.Size = New System.Drawing.Size(71, 15)
        Me.lblSO_SampleID.TabIndex = 0
        Me.lblSO_SampleID.Text = "样办单号:"
        '
        'lblSE_Qty
        '
        Me.lblSE_Qty.AutoSize = True
        Me.lblSE_Qty.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_Qty.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_Qty.ForeColor = System.Drawing.Color.Black
        Me.lblSE_Qty.Location = New System.Drawing.Point(23, 122)
        Me.lblSE_Qty.Name = "lblSE_Qty"
        Me.lblSE_Qty.Size = New System.Drawing.Size(73, 15)
        Me.lblSE_Qty.TabIndex = 16
        Me.lblSE_Qty.Text = "数        量:"
        '
        'lblSE_InCardID
        '
        Me.lblSE_InCardID.AutoSize = True
        Me.lblSE_InCardID.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_InCardID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_InCardID.ForeColor = System.Drawing.Color.Black
        Me.lblSE_InCardID.Location = New System.Drawing.Point(263, 96)
        Me.lblSE_InCardID.Name = "lblSE_InCardID"
        Me.lblSE_InCardID.Size = New System.Drawing.Size(86, 15)
        Me.lblSE_InCardID.TabIndex = 14
        Me.lblSE_InCardID.Text = "收料刷卡人:"
        '
        'txt_SO_SampleID
        '
        Me.txt_SO_SampleID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SO_SampleID.Enabled = False
        Me.txt_SO_SampleID.Location = New System.Drawing.Point(97, 13)
        Me.txt_SO_SampleID.Name = "txt_SO_SampleID"
        Me.txt_SO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_SO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txt_SO_SampleID.Size = New System.Drawing.Size(166, 24)
        Me.txt_SO_SampleID.TabIndex = 1
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.ForeColor = System.Drawing.Color.Black
        Me.lblPM_M_Code.Location = New System.Drawing.Point(25, 44)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(71, 15)
        Me.lblPM_M_Code.TabIndex = 4
        Me.lblPM_M_Code.Text = "产品编号:"
        '
        'lblSE_AddUserName
        '
        Me.lblSE_AddUserName.AutoSize = True
        Me.lblSE_AddUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblSE_AddUserName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_AddUserName.ForeColor = System.Drawing.Color.Black
        Me.lblSE_AddUserName.Location = New System.Drawing.Point(278, 18)
        Me.lblSE_AddUserName.Name = "lblSE_AddUserName"
        Me.lblSE_AddUserName.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_AddUserName.TabIndex = 2
        Me.lblSE_AddUserName.Text = "新增用户:"
        '
        'lblSE_InD_Dep
        '
        Me.lblSE_InD_Dep.AutoSize = True
        Me.lblSE_InD_Dep.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSE_InD_Dep.ForeColor = System.Drawing.Color.Black
        Me.lblSE_InD_Dep.Location = New System.Drawing.Point(278, 70)
        Me.lblSE_InD_Dep.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.lblSE_InD_Dep.Name = "lblSE_InD_Dep"
        Me.lblSE_InD_Dep.Size = New System.Drawing.Size(71, 15)
        Me.lblSE_InD_Dep.TabIndex = 10
        Me.lblSE_InD_Dep.Text = "收料部门:"
        '
        'gbCheck
        '
        Me.gbCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbCheck.Controls.Add(Me.LabelControl2)
        Me.gbCheck.Controls.Add(Me.LabelControl1)
        Me.gbCheck.Controls.Add(Me.lblCheckDate)
        Me.gbCheck.Controls.Add(Me.ce_IsCheck)
        Me.gbCheck.Controls.Add(Me.lblCheckUser)
        Me.gbCheck.Location = New System.Drawing.Point(5, 382)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(381, 44)
        Me.gbCheck.TabIndex = 99
        Me.gbCheck.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(270, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 15)
        Me.LabelControl2.TabIndex = 225
        Me.LabelControl2.Text = "日期:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(136, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl1.TabIndex = 224
        Me.LabelControl1.Text = "审核人员:"
        '
        'lblCheckDate
        '
        Me.lblCheckDate.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckDate.Appearance.Options.UseFont = True
        Me.lblCheckDate.Location = New System.Drawing.Point(223, 18)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(34, 15)
        Me.lblCheckDate.TabIndex = 223
        Me.lblCheckDate.Text = "日期:"
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
        Me.ce_IsCheck.Properties.Caption = "处理"
        Me.ce_IsCheck.Size = New System.Drawing.Size(57, 20)
        Me.ce_IsCheck.TabIndex = 1
        '
        'lblCheckUser
        '
        Me.lblCheckUser.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.lblCheckUser.Appearance.Options.UseFont = True
        Me.lblCheckUser.Location = New System.Drawing.Point(65, 18)
        Me.lblCheckUser.Name = "lblCheckUser"
        Me.lblCheckUser.Size = New System.Drawing.Size(64, 15)
        Me.lblCheckUser.TabIndex = 222
        Me.lblCheckUser.Text = "处理人员:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "责  任  人:"
        '
        'txtDutyUserID
        '
        Me.txtDutyUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDutyUserID.Location = New System.Drawing.Point(97, 170)
        Me.txtDutyUserID.Name = "txtDutyUserID"
        Me.txtDutyUserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtDutyUserID.Properties.Appearance.Options.UseFont = True
        Me.txtDutyUserID.Size = New System.Drawing.Size(166, 24)
        Me.txtDutyUserID.TabIndex = 21
        '
        'ControlDep
        '
        Me.ControlDep.Caption = "部门编号"
        Me.ControlDep.FieldName = "ControlDep"
        Me.ControlDep.Name = "ControlDep"
        '
        'DepName
        '
        Me.DepName.Caption = "部门名称"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 0
        '
        'frmSampAlarmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton1
        Me.ClientSize = New System.Drawing.Size(542, 434)
        Me.Controls.Add(Me.gbCheck)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtSE_ID)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.lblSE_ID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampAlarmAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "报警信息服务"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOccurAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOccurReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_InCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_InD_Dep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_OutCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_OutD_Dep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_AddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSE_AddUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        CType(Me.ce_IsCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDutyUserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSE_ID As System.Windows.Forms.Label
    Friend WithEvents txtSE_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSO_SampleID As System.Windows.Forms.Label
    Friend WithEvents lblSE_Qty As System.Windows.Forms.Label
    Friend WithEvents lblSE_InCardID As System.Windows.Forms.Label
    Friend WithEvents txt_SO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents lblSE_AddUserName As System.Windows.Forms.Label
    Friend WithEvents lblSE_InD_Dep As System.Windows.Forms.Label
    Friend WithEvents lblProcessResult As System.Windows.Forms.Label
    Friend WithEvents lblSE_OutCardID As System.Windows.Forms.Label
    Friend WithEvents lblSE_AddDate As System.Windows.Forms.Label
    Friend WithEvents lblSE_OutD_Dep As System.Windows.Forms.Label
    Friend WithEvents txtSE_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_InCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_InD_Dep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_OutCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_OutD_Dep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_AddDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSE_AddUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessResult As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gbCheck As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCheckDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ce_IsCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCheckUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ControlDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOccurReason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOccurAddress As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDutyUserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
