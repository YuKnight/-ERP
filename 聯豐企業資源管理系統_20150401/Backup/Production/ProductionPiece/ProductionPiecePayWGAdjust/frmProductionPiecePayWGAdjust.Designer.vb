<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayWGAdjust
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
        Me.labCheckName = New DevExpress.XtraEditors.LabelControl
        Me.Ad_Check = New System.Windows.Forms.CheckBox
        Me.LabAutoID = New System.Windows.Forms.Label
        Me.LabelCap = New System.Windows.Forms.Label
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.txtAd_Reason = New DevExpress.XtraEditors.MemoEdit
        Me.LabRemark = New DevExpress.XtraEditors.LabelControl
        Me.GluIN_G_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtAd_YYMM = New DevExpress.XtraEditors.TimeEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GluOUT_G_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabG_NO = New DevExpress.XtraEditors.LabelControl
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GB1.SuspendLayout()
        CType(Me.txtAd_Reason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluIN_G_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAd_YYMM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluOUT_G_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labCheckName
        '
        Me.labCheckName.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCheckName.Appearance.Options.UseFont = True
        Me.labCheckName.Location = New System.Drawing.Point(66, 279)
        Me.labCheckName.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.labCheckName.Name = "labCheckName"
        Me.labCheckName.Size = New System.Drawing.Size(49, 15)
        Me.labCheckName.TabIndex = 230
        Me.labCheckName.Text = "審核人:"
        '
        'Ad_Check
        '
        Me.Ad_Check.AutoSize = True
        Me.Ad_Check.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Ad_Check.Location = New System.Drawing.Point(7, 277)
        Me.Ad_Check.Name = "Ad_Check"
        Me.Ad_Check.Size = New System.Drawing.Size(56, 19)
        Me.Ad_Check.TabIndex = 229
        Me.Ad_Check.Text = "審核"
        Me.Ad_Check.UseVisualStyleBackColor = True
        '
        'LabAutoID
        '
        Me.LabAutoID.AutoSize = True
        Me.LabAutoID.Location = New System.Drawing.Point(178, 14)
        Me.LabAutoID.Name = "LabAutoID"
        Me.LabAutoID.Size = New System.Drawing.Size(37, 12)
        Me.LabAutoID.TabIndex = 233
        Me.LabAutoID.Text = "Label1"
        '
        'LabelCap
        '
        Me.LabelCap.AutoSize = True
        Me.LabelCap.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelCap.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCap.Location = New System.Drawing.Point(8, 5)
        Me.LabelCap.Name = "LabelCap"
        Me.LabelCap.Size = New System.Drawing.Size(142, 21)
        Me.LabelCap.TabIndex = 228
        Me.LabelCap.Text = "組別薪金調整"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.txtAd_Reason)
        Me.GB1.Controls.Add(Me.LabRemark)
        Me.GB1.Controls.Add(Me.GluIN_G_NO)
        Me.GB1.Controls.Add(Me.txtAd_YYMM)
        Me.GB1.Controls.Add(Me.LabelControl1)
        Me.GB1.Controls.Add(Me.txtAmount)
        Me.GB1.Controls.Add(Me.LabelControl3)
        Me.GB1.Controls.Add(Me.GluOUT_G_NO)
        Me.GB1.Controls.Add(Me.LabelControl2)
        Me.GB1.Controls.Add(Me.LabG_NO)
        Me.GB1.Location = New System.Drawing.Point(3, 32)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(343, 226)
        Me.GB1.TabIndex = 226
        Me.GB1.TabStop = False
        '
        'txtAd_Reason
        '
        Me.txtAd_Reason.Location = New System.Drawing.Point(86, 120)
        Me.txtAd_Reason.Name = "txtAd_Reason"
        Me.txtAd_Reason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAd_Reason.Properties.Appearance.Options.UseFont = True
        Me.txtAd_Reason.Size = New System.Drawing.Size(252, 99)
        Me.txtAd_Reason.TabIndex = 10
        '
        'LabRemark
        '
        Me.LabRemark.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRemark.Appearance.Options.UseFont = True
        Me.LabRemark.Location = New System.Drawing.Point(29, 121)
        Me.LabRemark.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabRemark.Name = "LabRemark"
        Me.LabRemark.Size = New System.Drawing.Size(53, 15)
        Me.LabRemark.TabIndex = 9
        Me.LabRemark.Text = "備注(&R):"
        '
        'GluIN_G_NO
        '
        Me.GluIN_G_NO.EditValue = ""
        Me.GluIN_G_NO.Location = New System.Drawing.Point(87, 48)
        Me.GluIN_G_NO.Name = "GluIN_G_NO"
        Me.GluIN_G_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluIN_G_NO.Properties.Appearance.Options.UseFont = True
        Me.GluIN_G_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluIN_G_NO.Properties.NullText = ""
        Me.GluIN_G_NO.Properties.View = Me.GridView1
        Me.GluIN_G_NO.Size = New System.Drawing.Size(254, 24)
        Me.GluIN_G_NO.TabIndex = 4
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'txtAd_YYMM
        '
        Me.txtAd_YYMM.EditValue = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.txtAd_YYMM.Location = New System.Drawing.Point(87, 84)
        Me.txtAd_YYMM.Name = "txtAd_YYMM"
        Me.txtAd_YYMM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAd_YYMM.Properties.Appearance.Options.UseFont = True
        Me.txtAd_YYMM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtAd_YYMM.Properties.Mask.EditMask = "y"
        Me.txtAd_YYMM.Size = New System.Drawing.Size(96, 24)
        Me.txtAd_YYMM.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 87)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 15)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "月份(&M):"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(248, 84)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Mask.EditMask = "d"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Size = New System.Drawing.Size(90, 25)
        Me.txtAmount.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(186, 89)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "金額(元):"
        '
        'GluOUT_G_NO
        '
        Me.GluOUT_G_NO.EditValue = ""
        Me.GluOUT_G_NO.Location = New System.Drawing.Point(87, 12)
        Me.GluOUT_G_NO.Name = "GluOUT_G_NO"
        Me.GluOUT_G_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluOUT_G_NO.Properties.Appearance.Options.UseFont = True
        Me.GluOUT_G_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluOUT_G_NO.Properties.NullText = ""
        Me.GluOUT_G_NO.Properties.View = Me.GridView5
        Me.GluOUT_G_NO.Size = New System.Drawing.Size(254, 24)
        Me.GluOUT_G_NO.TabIndex = 2
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.G_DepName, Me.G_FacName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(4, 53)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "轉入組別(&I):"
        '
        'LabG_NO
        '
        Me.LabG_NO.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabG_NO.Appearance.Options.UseFont = True
        Me.LabG_NO.Location = New System.Drawing.Point(4, 19)
        Me.LabG_NO.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabG_NO.Name = "LabG_NO"
        Me.LabG_NO.Size = New System.Drawing.Size(84, 15)
        Me.LabG_NO.TabIndex = 1
        Me.LabG_NO.Text = "轉出組別(&O):"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(266, 271)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 232
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(180, 271)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 231
        Me.cmdSave.Text = "確認(&S)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 34)
        Me.PictureBox1.TabIndex = 227
        Me.PictureBox1.TabStop = False
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
        'GridColumn3
        '
        Me.GridColumn3.Caption = "部門"
        Me.GridColumn3.FieldName = "G_DepName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "廠別"
        Me.GridColumn4.FieldName = "G_FacName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "組別編號"
        Me.GridColumn9.FieldName = "G_NO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "組別名稱"
        Me.GridColumn10.FieldName = "G_Name"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        '
        'G_DepName
        '
        Me.G_DepName.Caption = "部門"
        Me.G_DepName.FieldName = "G_DepName"
        Me.G_DepName.Name = "G_DepName"
        Me.G_DepName.Visible = True
        Me.G_DepName.VisibleIndex = 2
        '
        'G_FacName
        '
        Me.G_FacName.Caption = "廠別"
        Me.G_FacName.FieldName = "G_FacName"
        Me.G_FacName.Name = "G_FacName"
        Me.G_FacName.Visible = True
        Me.G_FacName.VisibleIndex = 3
        '
        'frmProductionPiecePayWGAdjust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(347, 303)
        Me.Controls.Add(Me.labCheckName)
        Me.Controls.Add(Me.Ad_Check)
        Me.Controls.Add(Me.LabAutoID)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelCap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionPiecePayWGAdjust"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "組別薪金調整"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.txtAd_Reason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluIN_G_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAd_YYMM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluOUT_G_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labCheckName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Ad_Check As System.Windows.Forms.CheckBox
    Friend WithEvents LabAutoID As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelCap As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAd_Reason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabRemark As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GluIN_G_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAd_YYMM As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GluOUT_G_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabG_NO As DevExpress.XtraEditors.LabelControl
End Class
