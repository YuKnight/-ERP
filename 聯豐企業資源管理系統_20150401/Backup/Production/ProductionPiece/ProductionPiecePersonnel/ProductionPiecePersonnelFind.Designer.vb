<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPiecePersonnelFind
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbPer_All = New System.Windows.Forms.RadioButton
        Me.rdbPer_Resign = New System.Windows.Forms.RadioButton
        Me.rdbPer_NOResign = New System.Windows.Forms.RadioButton
        Me.dtePer_DateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dtePer_DateStart = New DevExpress.XtraEditors.DateEdit
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
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtePer_DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePer_DateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbPer_All)
        Me.GroupBox1.Controls.Add(Me.rdbPer_Resign)
        Me.GroupBox1.Controls.Add(Me.rdbPer_NOResign)
        Me.GroupBox1.Controls.Add(Me.dtePer_DateEnd)
        Me.GroupBox1.Controls.Add(Me.dtePer_DateStart)
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'rdbPer_All
        '
        Me.rdbPer_All.AutoSize = True
        Me.rdbPer_All.Location = New System.Drawing.Point(180, 313)
        Me.rdbPer_All.Margin = New System.Windows.Forms.Padding(6)
        Me.rdbPer_All.Name = "rdbPer_All"
        Me.rdbPer_All.Size = New System.Drawing.Size(75, 19)
        Me.rdbPer_All.TabIndex = 17
        Me.rdbPer_All.Text = "全部(&A)"
        Me.rdbPer_All.UseVisualStyleBackColor = True
        '
        'rdbPer_Resign
        '
        Me.rdbPer_Resign.AutoSize = True
        Me.rdbPer_Resign.Location = New System.Drawing.Point(103, 313)
        Me.rdbPer_Resign.Margin = New System.Windows.Forms.Padding(6)
        Me.rdbPer_Resign.Name = "rdbPer_Resign"
        Me.rdbPer_Resign.Size = New System.Drawing.Size(74, 19)
        Me.rdbPer_Resign.TabIndex = 16
        Me.rdbPer_Resign.Text = "辭工(&R)"
        Me.rdbPer_Resign.UseVisualStyleBackColor = True
        '
        'rdbPer_NOResign
        '
        Me.rdbPer_NOResign.AutoSize = True
        Me.rdbPer_NOResign.Checked = True
        Me.rdbPer_NOResign.Location = New System.Drawing.Point(11, 313)
        Me.rdbPer_NOResign.Margin = New System.Windows.Forms.Padding(6)
        Me.rdbPer_NOResign.Name = "rdbPer_NOResign"
        Me.rdbPer_NOResign.Size = New System.Drawing.Size(89, 19)
        Me.rdbPer_NOResign.TabIndex = 15
        Me.rdbPer_NOResign.TabStop = True
        Me.rdbPer_NOResign.Text = "未辭工(&L)"
        Me.rdbPer_NOResign.UseVisualStyleBackColor = True
        '
        'dtePer_DateEnd
        '
        Me.dtePer_DateEnd.EditValue = Nothing
        Me.dtePer_DateEnd.Location = New System.Drawing.Point(131, 277)
        Me.dtePer_DateEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.dtePer_DateEnd.Name = "dtePer_DateEnd"
        Me.dtePer_DateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePer_DateEnd.Properties.Appearance.Options.UseFont = True
        Me.dtePer_DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePer_DateEnd.Size = New System.Drawing.Size(120, 24)
        Me.dtePer_DateEnd.TabIndex = 14
        '
        'dtePer_DateStart
        '
        Me.dtePer_DateStart.EditValue = Nothing
        Me.dtePer_DateStart.Location = New System.Drawing.Point(131, 241)
        Me.dtePer_DateStart.Margin = New System.Windows.Forms.Padding(6)
        Me.dtePer_DateStart.Name = "dtePer_DateStart"
        Me.dtePer_DateStart.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePer_DateStart.Properties.Appearance.Options.UseFont = True
        Me.dtePer_DateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePer_DateStart.Size = New System.Drawing.Size(120, 24)
        Me.dtePer_DateStart.TabIndex = 13
        '
        'luePer_PayType
        '
        Me.luePer_PayType.Location = New System.Drawing.Point(101, 205)
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
        Me.luePer_PayType.Size = New System.Drawing.Size(150, 24)
        Me.luePer_PayType.TabIndex = 11
        '
        'lueG_NO
        '
        Me.lueG_NO.Location = New System.Drawing.Point(101, 169)
        Me.lueG_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.lueG_NO.Name = "lueG_NO"
        Me.lueG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueG_NO.Properties.Appearance.Options.UseFont = True
        Me.lueG_NO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueG_NO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("G_NO", "組別編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("G_Name", "組別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueG_NO.Properties.NullText = ""
        Me.lueG_NO.Size = New System.Drawing.Size(150, 24)
        Me.lueG_NO.TabIndex = 9
        '
        'gluDepID
        '
        Me.gluDepID.Location = New System.Drawing.Point(101, 133)
        Me.gluDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.gluDepID.Name = "gluDepID"
        Me.gluDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluDepID.Properties.Appearance.Options.UseFont = True
        Me.gluDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluDepID.Properties.NullText = ""
        Me.gluDepID.Properties.View = Me.GridLookUpEdit1View
        Me.gluDepID.Size = New System.Drawing.Size(150, 24)
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
        Me.lueFacID.Location = New System.Drawing.Point(101, 97)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "編號", 8), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(150, 24)
        Me.lueFacID.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(110, 280)
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
        Me.LabelControl9.Location = New System.Drawing.Point(110, 244)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "從"
        '
        'txtPer_Name
        '
        Me.txtPer_Name.Location = New System.Drawing.Point(101, 61)
        Me.txtPer_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPer_Name.Name = "txtPer_Name"
        Me.txtPer_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer_Name.Properties.Appearance.Options.UseFont = True
        Me.txtPer_Name.Size = New System.Drawing.Size(150, 24)
        Me.txtPer_Name.TabIndex = 3
        '
        'txtPer_NO
        '
        Me.txtPer_NO.Location = New System.Drawing.Point(101, 25)
        Me.txtPer_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPer_NO.Name = "txtPer_NO"
        Me.txtPer_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPer_NO.Size = New System.Drawing.Size(150, 24)
        Me.txtPer_NO.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(11, 244)
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
        Me.LabelControl6.Location = New System.Drawing.Point(12, 208)
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
        Me.LabelControl5.Location = New System.Drawing.Point(11, 172)
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
        Me.LabelControl4.Location = New System.Drawing.Point(13, 136)
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
        Me.LabelControl3.Location = New System.Drawing.Point(13, 100)
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
        Me.LabelControl2.Location = New System.Drawing.Point(11, 64)
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
        Me.LabelControl1.Location = New System.Drawing.Point(16, 28)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "廠證編號(&I):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(149, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.btnFind.Location = New System.Drawing.Point(37, 19)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(80, 28)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "查詢(&F)"
        '
        'ProductionPiecePersonnelFind
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(274, 420)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductionPiecePersonnelFind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "員工名單-查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtePer_DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePer_DateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePer_PayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPer_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPer_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gluDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtePer_DateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents luePer_PayType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueG_NO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtePer_DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rdbPer_All As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPer_Resign As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPer_NOResign As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
End Class
