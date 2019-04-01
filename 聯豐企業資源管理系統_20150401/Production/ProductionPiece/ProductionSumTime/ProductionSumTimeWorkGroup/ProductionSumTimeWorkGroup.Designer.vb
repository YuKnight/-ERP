<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionSumTimeWorkGroup
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
        Me.EndTimeEdit = New System.Windows.Forms.MaskedTextBox
        Me.StartTimeEdit = New System.Windows.Forms.MaskedTextBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.LabTotal1 = New System.Windows.Forms.Label
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabTotal = New System.Windows.Forms.Label
        Me.MemoGT_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.LabPT_Remark = New System.Windows.Forms.Label
        Me.LabEnd = New System.Windows.Forms.Label
        Me.LabStart = New System.Windows.Forms.Label
        Me.txtPer_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabPer_NO = New System.Windows.Forms.Label
        Me.GT_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.LabCaption = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.GluG_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabG_NO = New System.Windows.Forms.Label
        Me.LabGT_NO = New System.Windows.Forms.Label
        Me.CaoTypeLabel = New System.Windows.Forms.Label
        Me.labDepID = New System.Windows.Forms.Label
        Me.labFacID = New System.Windows.Forms.Label
        Me.GridLookSampType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SampID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SampName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoGT_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GT_DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookSampType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EndTimeEdit
        '
        Me.EndTimeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndTimeEdit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndTimeEdit.Location = New System.Drawing.Point(224, 114)
        Me.EndTimeEdit.Mask = "90:00"
        Me.EndTimeEdit.Name = "EndTimeEdit"
        Me.EndTimeEdit.Size = New System.Drawing.Size(90, 27)
        Me.EndTimeEdit.TabIndex = 9
        Me.EndTimeEdit.Text = "0000"
        Me.EndTimeEdit.ValidatingType = GetType(Date)
        '
        'StartTimeEdit
        '
        Me.StartTimeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartTimeEdit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartTimeEdit.Location = New System.Drawing.Point(61, 114)
        Me.StartTimeEdit.Mask = "90:00"
        Me.StartTimeEdit.Name = "StartTimeEdit"
        Me.StartTimeEdit.Size = New System.Drawing.Size(90, 27)
        Me.StartTimeEdit.TabIndex = 7
        Me.StartTimeEdit.Text = "0000"
        Me.StartTimeEdit.ValidatingType = GetType(Date)
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(234, 257)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 18
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(140, 257)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "確認(&S)"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Location = New System.Drawing.Point(3, 257)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 28)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "增加(&A)"
        '
        'LabTotal1
        '
        Me.LabTotal1.AutoSize = True
        Me.LabTotal1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabTotal1.Location = New System.Drawing.Point(127, 159)
        Me.LabTotal1.Name = "LabTotal1"
        Me.LabTotal1.Size = New System.Drawing.Size(41, 13)
        Me.LabTotal1.TabIndex = 294
        Me.LabTotal1.Text = "(小時)"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(62, 151)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Size = New System.Drawing.Size(65, 25)
        Me.txtTotal.TabIndex = 11
        '
        'LabTotal
        '
        Me.LabTotal.AutoSize = True
        Me.LabTotal.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabTotal.Location = New System.Drawing.Point(0, 152)
        Me.LabTotal.Name = "LabTotal"
        Me.LabTotal.Size = New System.Drawing.Size(59, 15)
        Me.LabTotal.TabIndex = 10
        Me.LabTotal.Text = "合計(&P):"
        '
        'MemoGT_Remark
        '
        Me.MemoGT_Remark.Location = New System.Drawing.Point(62, 186)
        Me.MemoGT_Remark.Name = "MemoGT_Remark"
        Me.MemoGT_Remark.Size = New System.Drawing.Size(252, 56)
        Me.MemoGT_Remark.TabIndex = 15
        '
        'LabPT_Remark
        '
        Me.LabPT_Remark.AutoSize = True
        Me.LabPT_Remark.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPT_Remark.Location = New System.Drawing.Point(0, 190)
        Me.LabPT_Remark.Name = "LabPT_Remark"
        Me.LabPT_Remark.Size = New System.Drawing.Size(60, 15)
        Me.LabPT_Remark.TabIndex = 14
        Me.LabPT_Remark.Text = "備注(&R):"
        '
        'LabEnd
        '
        Me.LabEnd.AutoSize = True
        Me.LabEnd.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabEnd.Location = New System.Drawing.Point(160, 120)
        Me.LabEnd.Name = "LabEnd"
        Me.LabEnd.Size = New System.Drawing.Size(60, 15)
        Me.LabEnd.TabIndex = 8
        Me.LabEnd.Text = "結束(&E):"
        '
        'LabStart
        '
        Me.LabStart.AutoSize = True
        Me.LabStart.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabStart.Location = New System.Drawing.Point(0, 118)
        Me.LabStart.Name = "LabStart"
        Me.LabStart.Size = New System.Drawing.Size(60, 15)
        Me.LabStart.TabIndex = 6
        Me.LabStart.Text = "開始(&B):"
        '
        'txtPer_NO
        '
        Me.txtPer_NO.Location = New System.Drawing.Point(61, 80)
        Me.txtPer_NO.Name = "txtPer_NO"
        Me.txtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPer_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPer_NO.Properties.NullText = ""
        Me.txtPer_NO.Properties.View = Me.GridLookUpEdit1View
        Me.txtPer_NO.Size = New System.Drawing.Size(254, 24)
        Me.txtPer_NO.TabIndex = 5
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Per_NO, Me.Per_Name, Me.Per_DepName, Me.DepID, Me.Per_FacName, Me.FacID})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "廠証編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        Me.Per_NO.Width = 96
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        Me.Per_Name.Width = 65
        '
        'Per_DepName
        '
        Me.Per_DepName.Caption = "部門名稱"
        Me.Per_DepName.FieldName = "Per_DepName"
        Me.Per_DepName.Name = "Per_DepName"
        Me.Per_DepName.Visible = True
        Me.Per_DepName.VisibleIndex = 3
        Me.Per_DepName.Width = 108
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Width = 189
        '
        'Per_FacName
        '
        Me.Per_FacName.Caption = "廠別名稱"
        Me.Per_FacName.FieldName = "Per_FacName"
        Me.Per_FacName.Name = "Per_FacName"
        Me.Per_FacName.Visible = True
        Me.Per_FacName.VisibleIndex = 2
        Me.Per_FacName.Width = 112
        '
        'FacID
        '
        Me.FacID.Caption = "廠別編號"
        Me.FacID.FieldName = "FacID"
        Me.FacID.Name = "FacID"
        '
        'LabPer_NO
        '
        Me.LabPer_NO.AutoSize = True
        Me.LabPer_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPer_NO.Location = New System.Drawing.Point(0, 84)
        Me.LabPer_NO.Name = "LabPer_NO"
        Me.LabPer_NO.Size = New System.Drawing.Size(56, 15)
        Me.LabPer_NO.TabIndex = 4
        Me.LabPer_NO.Text = "員工(&I):"
        '
        'GT_DateEdit
        '
        Me.GT_DateEdit.EditValue = Nothing
        Me.GT_DateEdit.Location = New System.Drawing.Point(168, 8)
        Me.GT_DateEdit.Name = "GT_DateEdit"
        Me.GT_DateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GT_DateEdit.Properties.Appearance.Options.UseFont = True
        Me.GT_DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GT_DateEdit.Size = New System.Drawing.Size(144, 25)
        Me.GT_DateEdit.TabIndex = 1
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.ForeColor = System.Drawing.Color.Navy
        Me.LabCaption.Location = New System.Drawing.Point(3, 10)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(153, 21)
        Me.LabCaption.TabIndex = 293
        Me.LabCaption.Text = "組別計時-統計"
        '
        'PicCaption
        '
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(0, 2)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(315, 36)
        Me.PicCaption.TabIndex = 295
        Me.PicCaption.TabStop = False
        '
        'GluG_NO
        '
        Me.GluG_NO.EditValue = ""
        Me.GluG_NO.Location = New System.Drawing.Point(62, 46)
        Me.GluG_NO.Name = "GluG_NO"
        Me.GluG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluG_NO.Properties.Appearance.Options.UseFont = True
        Me.GluG_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluG_NO.Properties.NullText = ""
        Me.GluG_NO.Properties.View = Me.GridView1
        Me.GluG_NO.Size = New System.Drawing.Size(254, 24)
        Me.GluG_NO.TabIndex = 3
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
        'LabG_NO
        '
        Me.LabG_NO.AutoSize = True
        Me.LabG_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_NO.Location = New System.Drawing.Point(1, 50)
        Me.LabG_NO.Name = "LabG_NO"
        Me.LabG_NO.Size = New System.Drawing.Size(61, 15)
        Me.LabG_NO.TabIndex = 2
        Me.LabG_NO.Text = "組別(&G):"
        '
        'LabGT_NO
        '
        Me.LabGT_NO.AutoSize = True
        Me.LabGT_NO.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabGT_NO.Location = New System.Drawing.Point(69, 31)
        Me.LabGT_NO.Name = "LabGT_NO"
        Me.LabGT_NO.Size = New System.Drawing.Size(58, 12)
        Me.LabGT_NO.TabIndex = 301
        Me.LabGT_NO.Text = "LabPT_NO"
        Me.LabGT_NO.Visible = False
        '
        'CaoTypeLabel
        '
        Me.CaoTypeLabel.AutoSize = True
        Me.CaoTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaoTypeLabel.Location = New System.Drawing.Point(10, 31)
        Me.CaoTypeLabel.Name = "CaoTypeLabel"
        Me.CaoTypeLabel.Size = New System.Drawing.Size(53, 12)
        Me.CaoTypeLabel.TabIndex = 299
        Me.CaoTypeLabel.Text = "操作類型"
        Me.CaoTypeLabel.Visible = False
        '
        'labDepID
        '
        Me.labDepID.AutoSize = True
        Me.labDepID.Location = New System.Drawing.Point(185, 31)
        Me.labDepID.Name = "labDepID"
        Me.labDepID.Size = New System.Drawing.Size(50, 12)
        Me.labDepID.TabIndex = 305
        Me.labDepID.Text = "labDepID"
        Me.labDepID.Visible = False
        '
        'labFacID
        '
        Me.labFacID.AutoSize = True
        Me.labFacID.Location = New System.Drawing.Point(128, 31)
        Me.labFacID.Name = "labFacID"
        Me.labFacID.Size = New System.Drawing.Size(47, 12)
        Me.labFacID.TabIndex = 304
        Me.labFacID.Text = "labFacID"
        Me.labFacID.Visible = False
        '
        'GridLookSampType
        '
        Me.GridLookSampType.Location = New System.Drawing.Point(222, 154)
        Me.GridLookSampType.Margin = New System.Windows.Forms.Padding(6)
        Me.GridLookSampType.Name = "GridLookSampType"
        Me.GridLookSampType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLookSampType.Properties.Appearance.Options.UseFont = True
        Me.GridLookSampType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookSampType.Properties.NullText = ""
        Me.GridLookSampType.Properties.View = Me.GridView5
        Me.GridLookSampType.Size = New System.Drawing.Size(93, 24)
        Me.GridLookSampType.TabIndex = 13
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SampID, Me.SampName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'SampID
        '
        Me.SampID.Caption = "編號"
        Me.SampID.FieldName = "SampID"
        Me.SampID.Name = "SampID"
        Me.SampID.Visible = True
        Me.SampID.VisibleIndex = 0
        '
        'SampName
        '
        Me.SampName.Caption = "類型"
        Me.SampName.FieldName = "SampName"
        Me.SampName.Name = "SampName"
        Me.SampName.Visible = True
        Me.SampName.VisibleIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "類型:"
        '
        'ProductionSumTimeWorkGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(315, 291)
        Me.Controls.Add(Me.GridLookSampType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labDepID)
        Me.Controls.Add(Me.labFacID)
        Me.Controls.Add(Me.LabGT_NO)
        Me.Controls.Add(Me.CaoTypeLabel)
        Me.Controls.Add(Me.GluG_NO)
        Me.Controls.Add(Me.LabG_NO)
        Me.Controls.Add(Me.EndTimeEdit)
        Me.Controls.Add(Me.StartTimeEdit)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.LabTotal1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.LabTotal)
        Me.Controls.Add(Me.MemoGT_Remark)
        Me.Controls.Add(Me.LabPT_Remark)
        Me.Controls.Add(Me.LabEnd)
        Me.Controls.Add(Me.LabStart)
        Me.Controls.Add(Me.txtPer_NO)
        Me.Controls.Add(Me.LabPer_NO)
        Me.Controls.Add(Me.GT_DateEdit)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PicCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductionSumTimeWorkGroup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "組別計時"
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoGT_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GT_DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookSampType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EndTimeEdit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents StartTimeEdit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabTotal1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabTotal As System.Windows.Forms.Label
    Friend WithEvents MemoGT_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabPT_Remark As System.Windows.Forms.Label
    Friend WithEvents LabEnd As System.Windows.Forms.Label
    Friend WithEvents LabStart As System.Windows.Forms.Label
    Friend WithEvents txtPer_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabPer_NO As System.Windows.Forms.Label
    Friend WithEvents GT_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents GluG_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabG_NO As System.Windows.Forms.Label
    Friend WithEvents LabGT_NO As System.Windows.Forms.Label
    Friend WithEvents CaoTypeLabel As System.Windows.Forms.Label
    Friend WithEvents labDepID As System.Windows.Forms.Label
    Friend WithEvents labFacID As System.Windows.Forms.Label
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookSampType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
