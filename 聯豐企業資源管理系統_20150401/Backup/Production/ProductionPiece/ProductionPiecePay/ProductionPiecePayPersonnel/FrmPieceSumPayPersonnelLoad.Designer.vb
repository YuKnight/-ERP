<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPieceSumPayPersonnelLoad
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioModle1 = New System.Windows.Forms.RadioButton
        Me.lueDepID = New DevExpress.XtraEditors.LookUpEdit
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioModle = New System.Windows.Forms.RadioButton
        Me.LabPer_NO = New DevExpress.XtraEditors.LabelControl
        Me.txtPer_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEditPer = New DevExpress.XtraEditors.CheckEdit
        Me.Date_YYMM = New DevExpress.XtraEditors.TimeEdit
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cboPer_Class = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabPerClass = New System.Windows.Forms.Label
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditPer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_YYMM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "生成數據"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cboPer_Class)
        Me.GroupBox2.Controls.Add(Me.LabPerClass)
        Me.GroupBox2.Controls.Add(Me.RadioModle1)
        Me.GroupBox2.Controls.Add(Me.lueDepID)
        Me.GroupBox2.Controls.Add(Me.lueFacID)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 104)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        '
        'RadioModle1
        '
        Me.RadioModle1.AutoSize = True
        Me.RadioModle1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioModle1.Location = New System.Drawing.Point(9, 0)
        Me.RadioModle1.Name = "RadioModle1"
        Me.RadioModle1.Size = New System.Drawing.Size(70, 19)
        Me.RadioModle1.TabIndex = 4
        Me.RadioModle1.TabStop = True
        Me.RadioModle1.Text = "樣式二"
        Me.RadioModle1.UseVisualStyleBackColor = True
        '
        'lueDepID
        '
        Me.lueDepID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueDepID.Location = New System.Drawing.Point(95, 47)
        Me.lueDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueDepID.Name = "lueDepID"
        Me.lueDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueDepID.Properties.Appearance.Options.UseFont = True
        Me.lueDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueDepID.Properties.NullText = ""
        Me.lueDepID.Size = New System.Drawing.Size(215, 24)
        Me.lueDepID.TabIndex = 8
        '
        'lueFacID
        '
        Me.lueFacID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueFacID.Location = New System.Drawing.Point(95, 19)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(215, 24)
        Me.lueFacID.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(10, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "部門名稱(&P):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "廠別名稱(&D):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioModle)
        Me.GroupBox1.Controls.Add(Me.LabPer_NO)
        Me.GroupBox1.Controls.Add(Me.txtPer_NO)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 53)
        Me.GroupBox1.TabIndex = 208
        Me.GroupBox1.TabStop = False
        '
        'RadioModle
        '
        Me.RadioModle.AutoSize = True
        Me.RadioModle.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioModle.Location = New System.Drawing.Point(9, 0)
        Me.RadioModle.Name = "RadioModle"
        Me.RadioModle.Size = New System.Drawing.Size(70, 19)
        Me.RadioModle.TabIndex = 1
        Me.RadioModle.TabStop = True
        Me.RadioModle.Text = "樣式一"
        Me.RadioModle.UseVisualStyleBackColor = True
        '
        'LabPer_NO
        '
        Me.LabPer_NO.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPer_NO.Appearance.Options.UseFont = True
        Me.LabPer_NO.Location = New System.Drawing.Point(6, 21)
        Me.LabPer_NO.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabPer_NO.Name = "LabPer_NO"
        Me.LabPer_NO.Size = New System.Drawing.Size(79, 15)
        Me.LabPer_NO.TabIndex = 2
        Me.LabPer_NO.Text = "員工編號(&I):"
        '
        'txtPer_NO
        '
        Me.txtPer_NO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPer_NO.Location = New System.Drawing.Point(98, 16)
        Me.txtPer_NO.Name = "txtPer_NO"
        Me.txtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPer_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPer_NO.Properties.NullText = ""
        Me.txtPer_NO.Properties.View = Me.GridLookUpEdit1View
        Me.txtPer_NO.Size = New System.Drawing.Size(215, 24)
        Me.txtPer_NO.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Per_NO, Me.Per_Name, Me.G_DepName, Me.DepID, Me.FacID, Me.G_FacName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(232, 231)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(132, 231)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "確定(&O)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 39)
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(172, 13)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 15)
        Me.LabelControl5.TabIndex = 214
        Me.LabelControl5.Text = "年月:"
        '
        'CheckEditPer
        '
        Me.CheckEditPer.Location = New System.Drawing.Point(2, 236)
        Me.CheckEditPer.Name = "CheckEditPer"
        Me.CheckEditPer.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditPer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditPer.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEditPer.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditPer.Properties.Appearance.Options.UseFont = True
        Me.CheckEditPer.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEditPer.Properties.Caption = "刪除審核"
        Me.CheckEditPer.Size = New System.Drawing.Size(89, 23)
        Me.CheckEditPer.TabIndex = 224
        '
        'Date_YYMM
        '
        Me.Date_YYMM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_YYMM.EditValue = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.Date_YYMM.Location = New System.Drawing.Point(214, 8)
        Me.Date_YYMM.Name = "Date_YYMM"
        Me.Date_YYMM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_YYMM.Properties.Appearance.Options.UseFont = True
        Me.Date_YYMM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Date_YYMM.Properties.Mask.EditMask = "y"
        Me.Date_YYMM.Size = New System.Drawing.Size(100, 24)
        Me.Date_YYMM.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 215)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(312, 11)
        Me.ProgressBar1.TabIndex = 227
        Me.ProgressBar1.Visible = False
        '
        'cboPer_Class
        '
        Me.cboPer_Class.EditValue = "全部"
        Me.cboPer_Class.Location = New System.Drawing.Point(95, 73)
        Me.cboPer_Class.Name = "cboPer_Class"
        Me.cboPer_Class.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPer_Class.Properties.Appearance.Options.UseFont = True
        Me.cboPer_Class.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPer_Class.Properties.Items.AddRange(New Object() {"白班", "夜班", "全部"})
        Me.cboPer_Class.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPer_Class.Size = New System.Drawing.Size(212, 24)
        Me.cboPer_Class.TabIndex = 28
        '
        'LabPerClass
        '
        Me.LabPerClass.AutoSize = True
        Me.LabPerClass.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPerClass.Location = New System.Drawing.Point(35, 77)
        Me.LabPerClass.Name = "LabPerClass"
        Me.LabPerClass.Size = New System.Drawing.Size(60, 15)
        Me.LabPerClass.TabIndex = 27
        Me.LabPerClass.Text = "班制(&E):"
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "工號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        Me.Per_NO.Width = 80
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        Me.Per_Name.Width = 99
        '
        'G_DepName
        '
        Me.G_DepName.Caption = "部門"
        Me.G_DepName.FieldName = "Per_DepName"
        Me.G_DepName.Name = "G_DepName"
        Me.G_DepName.Visible = True
        Me.G_DepName.VisibleIndex = 2
        Me.G_DepName.Width = 99
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        '
        'FacID
        '
        Me.FacID.Caption = "廠別"
        Me.FacID.FieldName = "FacID"
        Me.FacID.Name = "FacID"
        '
        'G_FacName
        '
        Me.G_FacName.Caption = "廠別"
        Me.G_FacName.FieldName = "Per_FacName"
        Me.G_FacName.Name = "G_FacName"
        Me.G_FacName.Visible = True
        Me.G_FacName.VisibleIndex = 3
        Me.G_FacName.Width = 103
        '
        'FrmPieceSumPayPersonnelLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(321, 264)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Date_YYMM)
        Me.Controls.Add(Me.CheckEditPer)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPieceSumPayPersonnelLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "個人匯總信息"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditPer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_YYMM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioModle1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioModle As System.Windows.Forms.RadioButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDepID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabPer_NO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPer_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEditPer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Date_YYMM As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cboPer_Class As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabPerClass As System.Windows.Forms.Label
End Class
