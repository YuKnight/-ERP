<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptProductionSumPieceTime
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
        Me.GroupFind1 = New System.Windows.Forms.GroupBox
        Me.txtPer_NO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Labenddate = New DevExpress.XtraEditors.LabelControl
        Me.lueDepID = New DevExpress.XtraEditors.LookUpEdit
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.Labdepid = New DevExpress.XtraEditors.LabelControl
        Me.labFacid = New DevExpress.XtraEditors.LabelControl
        Me.End_Date = New DevExpress.XtraEditors.DateEdit
        Me.Start_Date = New DevExpress.XtraEditors.DateEdit
        Me.LabPP_DateEdit = New DevExpress.XtraEditors.LabelControl
        Me.LabPer_NO = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.LabCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupFind1.SuspendLayout()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupFind1
        '
        Me.GroupFind1.Controls.Add(Me.txtPer_NO)
        Me.GroupFind1.Controls.Add(Me.Labenddate)
        Me.GroupFind1.Controls.Add(Me.lueDepID)
        Me.GroupFind1.Controls.Add(Me.lueFacID)
        Me.GroupFind1.Controls.Add(Me.Labdepid)
        Me.GroupFind1.Controls.Add(Me.labFacid)
        Me.GroupFind1.Controls.Add(Me.End_Date)
        Me.GroupFind1.Controls.Add(Me.Start_Date)
        Me.GroupFind1.Controls.Add(Me.LabPP_DateEdit)
        Me.GroupFind1.Controls.Add(Me.LabPer_NO)
        Me.GroupFind1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupFind1.Location = New System.Drawing.Point(3, 32)
        Me.GroupFind1.Name = "GroupFind1"
        Me.GroupFind1.Size = New System.Drawing.Size(281, 185)
        Me.GroupFind1.TabIndex = 14
        Me.GroupFind1.TabStop = False
        '
        'txtPer_NO
        '
        Me.txtPer_NO.Location = New System.Drawing.Point(96, 81)
        Me.txtPer_NO.Name = "txtPer_NO"
        Me.txtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPer_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPer_NO.Properties.NullText = ""
        Me.txtPer_NO.Properties.View = Me.GridLookUpEdit1View
        Me.txtPer_NO.Size = New System.Drawing.Size(180, 24)
        Me.txtPer_NO.TabIndex = 6
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Per_NO, Me.Per_Name})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Labenddate
        '
        Me.Labenddate.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labenddate.Appearance.Options.UseFont = True
        Me.Labenddate.Location = New System.Drawing.Point(10, 150)
        Me.Labenddate.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Labenddate.Name = "Labenddate"
        Me.Labenddate.Size = New System.Drawing.Size(83, 15)
        Me.Labenddate.TabIndex = 9
        Me.Labenddate.Text = "結束日期(&E):"
        '
        'lueDepID
        '
        Me.lueDepID.Location = New System.Drawing.Point(96, 48)
        Me.lueDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueDepID.Name = "lueDepID"
        Me.lueDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueDepID.Properties.Appearance.Options.UseFont = True
        Me.lueDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueDepID.Properties.NullText = ""
        Me.lueDepID.Size = New System.Drawing.Size(180, 24)
        Me.lueDepID.TabIndex = 4
        '
        'lueFacID
        '
        Me.lueFacID.Location = New System.Drawing.Point(96, 16)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(180, 24)
        Me.lueFacID.TabIndex = 2
        '
        'Labdepid
        '
        Me.Labdepid.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labdepid.Appearance.Options.UseFont = True
        Me.Labdepid.Location = New System.Drawing.Point(9, 51)
        Me.Labdepid.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Labdepid.Name = "Labdepid"
        Me.Labdepid.Size = New System.Drawing.Size(84, 15)
        Me.Labdepid.TabIndex = 3
        Me.Labdepid.Text = "部門名稱(&D):"
        '
        'labFacid
        '
        Me.labFacid.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFacid.Appearance.Options.UseFont = True
        Me.labFacid.Location = New System.Drawing.Point(10, 18)
        Me.labFacid.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.labFacid.Name = "labFacid"
        Me.labFacid.Size = New System.Drawing.Size(82, 15)
        Me.labFacid.TabIndex = 1
        Me.labFacid.Text = "廠別名稱(&S):"
        '
        'End_Date
        '
        Me.End_Date.EditValue = Nothing
        Me.End_Date.Location = New System.Drawing.Point(96, 145)
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Date.Properties.Appearance.Options.UseFont = True
        Me.End_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.End_Date.Size = New System.Drawing.Size(180, 25)
        Me.End_Date.TabIndex = 10
        '
        'Start_Date
        '
        Me.Start_Date.EditValue = Nothing
        Me.Start_Date.Location = New System.Drawing.Point(96, 112)
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Date.Properties.Appearance.Options.UseFont = True
        Me.Start_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Start_Date.Size = New System.Drawing.Size(180, 25)
        Me.Start_Date.TabIndex = 8
        '
        'LabPP_DateEdit
        '
        Me.LabPP_DateEdit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPP_DateEdit.Appearance.Options.UseFont = True
        Me.LabPP_DateEdit.Location = New System.Drawing.Point(9, 117)
        Me.LabPP_DateEdit.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabPP_DateEdit.Name = "LabPP_DateEdit"
        Me.LabPP_DateEdit.Size = New System.Drawing.Size(83, 15)
        Me.LabPP_DateEdit.TabIndex = 7
        Me.LabPP_DateEdit.Text = "開始日期(&B):"
        '
        'LabPer_NO
        '
        Me.LabPer_NO.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPer_NO.Appearance.Options.UseFont = True
        Me.LabPer_NO.Location = New System.Drawing.Point(9, 84)
        Me.LabPer_NO.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabPer_NO.Name = "LabPer_NO"
        Me.LabPer_NO.Size = New System.Drawing.Size(79, 15)
        Me.LabPer_NO.TabIndex = 5
        Me.LabPer_NO.Text = "員工編號(&I):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 62)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(169, 21)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdSave.Location = New System.Drawing.Point(30, 21)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "打印(&P)"
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.Location = New System.Drawing.Point(5, 4)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(241, 21)
        Me.LabCaption.TabIndex = 41
        Me.LabCaption.Text = "員工計時計件表/匯總表"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 31)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "廠証編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        '
        'rptProductionSumPieceTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(287, 286)
        Me.Controls.Add(Me.GroupFind1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "rptProductionSumPieceTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "員工計時計件表/匯總表"
        Me.GroupFind1.ResumeLayout(False)
        Me.GroupFind1.PerformLayout()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupFind1 As System.Windows.Forms.GroupBox
    Friend WithEvents End_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Start_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabPP_DateEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabPer_NO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Labenddate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDepID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Labdepid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labFacid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPer_NO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
End Class
