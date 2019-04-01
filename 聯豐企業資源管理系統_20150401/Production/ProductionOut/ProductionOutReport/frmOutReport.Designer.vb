<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutReport
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
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.Lbl_M_PM_Code = New System.Windows.Forms.Label
        Me.PM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GlookP_Name = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GluType = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Type3ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LblPM_Type = New System.Windows.Forms.Label
        Me.LblProcess = New System.Windows.Forms.Label
        Me.gluSupplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LalSupplier = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateEditS = New DevExpress.XtraEditors.DateEdit
        Me.DateEditE = New DevExpress.XtraEditors.DateEdit
        Me.LblCaptionType = New System.Windows.Forms.Label
        Me.LblCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GB2.SuspendLayout()
        Me.GB1.SuspendLayout()
        CType(Me.PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlookP_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GluType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.cmdExit)
        Me.GB2.Controls.Add(Me.cmdSave)
        Me.GB2.Location = New System.Drawing.Point(3, 283)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(300, 57)
        Me.GB2.TabIndex = 117
        Me.GB2.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(175, 18)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(55, 18)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "確定(&O)"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.Lbl_M_PM_Code)
        Me.GB1.Controls.Add(Me.PM_M_Code)
        Me.GB1.Controls.Add(Me.GlookP_Name)
        Me.GB1.Controls.Add(Me.GluType)
        Me.GB1.Controls.Add(Me.LblPM_Type)
        Me.GB1.Controls.Add(Me.LblProcess)
        Me.GB1.Controls.Add(Me.gluSupplier)
        Me.GB1.Controls.Add(Me.LalSupplier)
        Me.GB1.Controls.Add(Me.Label7)
        Me.GB1.Controls.Add(Me.LblDate)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.DateEditS)
        Me.GB1.Controls.Add(Me.DateEditE)
        Me.GB1.Location = New System.Drawing.Point(3, 38)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(302, 244)
        Me.GB1.TabIndex = 116
        Me.GB1.TabStop = False
        '
        'Lbl_M_PM_Code
        '
        Me.Lbl_M_PM_Code.AutoSize = True
        Me.Lbl_M_PM_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_M_PM_Code.Location = New System.Drawing.Point(7, 59)
        Me.Lbl_M_PM_Code.Name = "Lbl_M_PM_Code"
        Me.Lbl_M_PM_Code.Size = New System.Drawing.Size(94, 15)
        Me.Lbl_M_PM_Code.TabIndex = 147
        Me.Lbl_M_PM_Code.Text = "產品編碼(&M):"
        '
        'PM_M_Code
        '
        Me.PM_M_Code.EditValue = ""
        Me.PM_M_Code.Location = New System.Drawing.Point(115, 56)
        Me.PM_M_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.PM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PM_M_Code.Properties.NullText = ""
        Me.PM_M_Code.Properties.View = Me.GridView3
        Me.PM_M_Code.Size = New System.Drawing.Size(180, 24)
        Me.PM_M_Code.TabIndex = 148
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.PM_JiYu})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品編號"
        Me.GridColumn2.FieldName = "PM_M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        '
        'GlookP_Name
        '
        Me.GlookP_Name.EditValue = ""
        Me.GlookP_Name.Location = New System.Drawing.Point(115, 130)
        Me.GlookP_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.GlookP_Name.Name = "GlookP_Name"
        Me.GlookP_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GlookP_Name.Properties.Appearance.Options.UseFont = True
        Me.GlookP_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GlookP_Name.Properties.NullText = ""
        Me.GlookP_Name.Properties.View = Me.GridView1
        Me.GlookP_Name.Size = New System.Drawing.Size(180, 24)
        Me.GlookP_Name.TabIndex = 152
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PS_NO, Me.PS_Name})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序單號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 0
        '
        'GluType
        '
        Me.GluType.EditValue = ""
        Me.GluType.Location = New System.Drawing.Point(115, 93)
        Me.GluType.Margin = New System.Windows.Forms.Padding(6)
        Me.GluType.Name = "GluType"
        Me.GluType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluType.Properties.Appearance.Options.UseFont = True
        Me.GluType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluType.Properties.NullText = ""
        Me.GluType.Properties.View = Me.GridView2
        Me.GluType.Size = New System.Drawing.Size(180, 24)
        Me.GluType.TabIndex = 150
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Type3ID})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'Type3ID
        '
        Me.Type3ID.Caption = "類型"
        Me.Type3ID.FieldName = "Type3ID"
        Me.Type3ID.Name = "Type3ID"
        Me.Type3ID.Visible = True
        Me.Type3ID.VisibleIndex = 0
        '
        'LblPM_Type
        '
        Me.LblPM_Type.AutoSize = True
        Me.LblPM_Type.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPM_Type.Location = New System.Drawing.Point(7, 96)
        Me.LblPM_Type.Name = "LblPM_Type"
        Me.LblPM_Type.Size = New System.Drawing.Size(91, 15)
        Me.LblPM_Type.TabIndex = 149
        Me.LblPM_Type.Text = "配件名稱(&N):"
        '
        'LblProcess
        '
        Me.LblProcess.AutoSize = True
        Me.LblProcess.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblProcess.Location = New System.Drawing.Point(7, 133)
        Me.LblProcess.Name = "LblProcess"
        Me.LblProcess.Size = New System.Drawing.Size(91, 15)
        Me.LblProcess.TabIndex = 151
        Me.LblProcess.Text = "完工工序(&D):"
        '
        'gluSupplier
        '
        Me.gluSupplier.EditValue = ""
        Me.gluSupplier.Location = New System.Drawing.Point(115, 19)
        Me.gluSupplier.Name = "gluSupplier"
        Me.gluSupplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluSupplier.Properties.Appearance.Options.UseFont = True
        Me.gluSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluSupplier.Properties.NullText = ""
        Me.gluSupplier.Properties.View = Me.GridLookUpEdit1View
        Me.gluSupplier.Size = New System.Drawing.Size(180, 24)
        Me.gluSupplier.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        '
        'LalSupplier
        '
        Me.LalSupplier.AutoSize = True
        Me.LalSupplier.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LalSupplier.Location = New System.Drawing.Point(7, 25)
        Me.LalSupplier.Name = "LalSupplier"
        Me.LalSupplier.Size = New System.Drawing.Size(74, 15)
        Me.LalSupplier.TabIndex = 0
        Me.LalSupplier.Text = "供應商(&P):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "到"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblDate.Location = New System.Drawing.Point(7, 169)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(91, 15)
        Me.LblDate.TabIndex = 4
        Me.LblDate.Text = "外發日期(&D):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 15)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "從"
        '
        'DateEditS
        '
        Me.DateEditS.EditValue = Nothing
        Me.DateEditS.Location = New System.Drawing.Point(145, 166)
        Me.DateEditS.Margin = New System.Windows.Forms.Padding(6)
        Me.DateEditS.Name = "DateEditS"
        Me.DateEditS.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEditS.Properties.Appearance.Options.UseFont = True
        Me.DateEditS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditS.Size = New System.Drawing.Size(150, 24)
        Me.DateEditS.TabIndex = 5
        '
        'DateEditE
        '
        Me.DateEditE.EditValue = Nothing
        Me.DateEditE.Location = New System.Drawing.Point(145, 201)
        Me.DateEditE.Margin = New System.Windows.Forms.Padding(6)
        Me.DateEditE.Name = "DateEditE"
        Me.DateEditE.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEditE.Properties.Appearance.Options.UseFont = True
        Me.DateEditE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditE.Size = New System.Drawing.Size(150, 24)
        Me.DateEditE.TabIndex = 6
        '
        'LblCaptionType
        '
        Me.LblCaptionType.AutoSize = True
        Me.LblCaptionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblCaptionType.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblCaptionType.Location = New System.Drawing.Point(227, 14)
        Me.LblCaptionType.Name = "LblCaptionType"
        Me.LblCaptionType.Size = New System.Drawing.Size(67, 15)
        Me.LblCaptionType.TabIndex = 115
        Me.LblCaptionType.Text = "報表類型"
        Me.LblCaptionType.Visible = False
        '
        'LblCaption
        '
        Me.LblCaption.AutoSize = True
        Me.LblCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblCaption.Location = New System.Drawing.Point(7, 8)
        Me.LblCaption.Name = "LblCaption"
        Me.LblCaption.Size = New System.Drawing.Size(98, 21)
        Me.LblCaption.TabIndex = 114
        Me.LblCaption.Text = "外發報表"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 36)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'frmOutReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(308, 344)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.LblCaptionType)
        Me.Controls.Add(Me.LblCaption)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOutReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "外發加工報表"
        Me.GB2.ResumeLayout(False)
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.PM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlookP_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GluType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents gluSupplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LalSupplier As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateEditS As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LblCaptionType As System.Windows.Forms.Label
    Friend WithEvents LblCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_M_PM_Code As System.Windows.Forms.Label
    Friend WithEvents PM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GlookP_Name As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GluType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Type3ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblPM_Type As System.Windows.Forms.Label
    Friend WithEvents LblProcess As System.Windows.Forms.Label
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
