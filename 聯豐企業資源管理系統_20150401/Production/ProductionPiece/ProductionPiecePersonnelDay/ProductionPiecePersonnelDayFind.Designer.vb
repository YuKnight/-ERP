<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPiecePersonnelDayFind
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
        Me.LabCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.End_Date = New DevExpress.XtraEditors.DateEdit
        Me.Start_Date = New DevExpress.XtraEditors.DateEdit
        Me.luePer_PayType = New DevExpress.XtraEditors.LookUpEdit
        Me.lueG_NO = New DevExpress.XtraEditors.LookUpEdit
        Me.gluDepID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPer_Name = New DevExpress.XtraEditors.TextEdit
        Me.txtPer_NO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePer_PayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabCaption
        '
        Me.LabCaption.AutoSize = True
        Me.LabCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabCaption.Location = New System.Drawing.Point(13, 7)
        Me.LabCaption.Name = "LabCaption"
        Me.LabCaption.Size = New System.Drawing.Size(186, 21)
        Me.LabCaption.TabIndex = 41
        Me.LabCaption.Text = "每日人員名單查詢"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(7, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 31)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.End_Date)
        Me.GroupBox1.Controls.Add(Me.Start_Date)
        Me.GroupBox1.Controls.Add(Me.luePer_PayType)
        Me.GroupBox1.Controls.Add(Me.lueG_NO)
        Me.GroupBox1.Controls.Add(Me.gluDepID)
        Me.GroupBox1.Controls.Add(Me.lueFacID)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.txtPer_Name)
        Me.GroupBox1.Controls.Add(Me.txtPer_NO)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 293)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'End_Date
        '
        Me.End_Date.EditValue = Nothing
        Me.End_Date.Location = New System.Drawing.Point(131, 256)
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Date.Properties.Appearance.Options.UseFont = True
        Me.End_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.End_Date.Size = New System.Drawing.Size(150, 25)
        Me.End_Date.TabIndex = 14
        '
        'Start_Date
        '
        Me.Start_Date.EditValue = Nothing
        Me.Start_Date.Location = New System.Drawing.Point(131, 222)
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Date.Properties.Appearance.Options.UseFont = True
        Me.Start_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Start_Date.Size = New System.Drawing.Size(150, 25)
        Me.Start_Date.TabIndex = 13
        '
        'luePer_PayType
        '
        Me.luePer_PayType.Location = New System.Drawing.Point(100, 189)
        Me.luePer_PayType.Margin = New System.Windows.Forms.Padding(6)
        Me.luePer_PayType.Name = "luePer_PayType"
        Me.luePer_PayType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luePer_PayType.Properties.Appearance.Options.UseFont = True
        Me.luePer_PayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePer_PayType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Per_PayType", "", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark")})
        Me.luePer_PayType.Properties.DropDownRows = 3
        Me.luePer_PayType.Properties.NullText = ""
        Me.luePer_PayType.Properties.ShowFooter = False
        Me.luePer_PayType.Properties.ShowHeader = False
        Me.luePer_PayType.Properties.ShowLines = False
        Me.luePer_PayType.Size = New System.Drawing.Size(180, 24)
        Me.luePer_PayType.TabIndex = 11
        '
        'lueG_NO
        '
        Me.lueG_NO.Location = New System.Drawing.Point(100, 156)
        Me.lueG_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.lueG_NO.Name = "lueG_NO"
        Me.lueG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueG_NO.Properties.Appearance.Options.UseFont = True
        Me.lueG_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueG_NO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("G_NO", "組別編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("G_Name", "組別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueG_NO.Properties.NullText = ""
        Me.lueG_NO.Size = New System.Drawing.Size(180, 24)
        Me.lueG_NO.TabIndex = 9
        '
        'gluDepID
        '
        Me.gluDepID.Location = New System.Drawing.Point(100, 123)
        Me.gluDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.gluDepID.Name = "gluDepID"
        Me.gluDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluDepID.Properties.Appearance.Options.UseFont = True
        Me.gluDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluDepID.Properties.NullText = ""
        Me.gluDepID.Properties.View = Me.GridLookUpEdit1View
        Me.gluDepID.Size = New System.Drawing.Size(180, 24)
        Me.gluDepID.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepID, Me.DepName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 0
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 1
        '
        'lueFacID
        '
        Me.lueFacID.Location = New System.Drawing.Point(100, 90)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "編號", 8), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(180, 24)
        Me.lueFacID.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(113, 263)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl10.TabIndex = 11
        Me.LabelControl10.Text = "到"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(110, 225)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "從"
        '
        'txtPer_Name
        '
        Me.txtPer_Name.Location = New System.Drawing.Point(100, 57)
        Me.txtPer_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPer_Name.Name = "txtPer_Name"
        Me.txtPer_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer_Name.Properties.Appearance.Options.UseFont = True
        Me.txtPer_Name.Size = New System.Drawing.Size(180, 24)
        Me.txtPer_Name.TabIndex = 3
        '
        'txtPer_NO
        '
        Me.txtPer_NO.Location = New System.Drawing.Point(100, 24)
        Me.txtPer_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPer_NO.Name = "txtPer_NO"
        Me.txtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPer_NO.Size = New System.Drawing.Size(180, 24)
        Me.txtPer_NO.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(12, 225)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "建立日期(&D):"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(12, 192)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "薪金類型(&T):"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 159)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "組別名稱(&G):"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 126)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "部門名稱(&P):"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "廠別名稱(&S):"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "員工姓名(&N):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 27)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "廠證編號(&I):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 62)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(173, 21)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(34, 21)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "查詢(&F)"
        '
        'ProductionPiecePersonnelDayFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(306, 405)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabCaption)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductionPiecePersonnelDayFind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "每日人員名單查詢"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePer_PayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents luePer_PayType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueG_NO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gluDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPer_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPer_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents End_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Start_Date As DevExpress.XtraEditors.DateEdit
End Class
