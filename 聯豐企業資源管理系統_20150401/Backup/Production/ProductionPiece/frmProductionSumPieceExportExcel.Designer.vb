<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionSumPieceExportExcel
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
        Me.cobType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.End_Date = New DevExpress.XtraEditors.DateEdit
        Me.Start_Date = New DevExpress.XtraEditors.DateEdit
        Me.lueDepID = New DevExpress.XtraEditors.LookUpEdit
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ComboBoxReg = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabReg = New System.Windows.Forms.Label
        Me.cboPer_Class = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabPerClass = New System.Windows.Forms.Label
        CType(Me.cobType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxReg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cobType
        '
        Me.cobType.EditValue = "個人計件"
        Me.cobType.Location = New System.Drawing.Point(92, 211)
        Me.cobType.Name = "cobType"
        Me.cobType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobType.Properties.Appearance.Options.UseFont = True
        Me.cobType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cobType.Properties.Items.AddRange(New Object() {"個人計件", "個人計時", "組別計件", "組別計時"})
        Me.cobType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cobType.Size = New System.Drawing.Size(212, 24)
        Me.cobType.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(1, 214)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "導出類型(&T):"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(3, 174)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "結束日期(&E):"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(3, 134)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "開始日期(&B):"
        '
        'End_Date
        '
        Me.End_Date.EditValue = Nothing
        Me.End_Date.Location = New System.Drawing.Point(92, 167)
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Date.Properties.Appearance.Options.UseFont = True
        Me.End_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.End_Date.Size = New System.Drawing.Size(212, 25)
        Me.End_Date.TabIndex = 8
        '
        'Start_Date
        '
        Me.Start_Date.EditValue = Nothing
        Me.Start_Date.Location = New System.Drawing.Point(91, 128)
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Date.Properties.Appearance.Options.UseFont = True
        Me.Start_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Start_Date.Size = New System.Drawing.Size(213, 25)
        Me.Start_Date.TabIndex = 6
        '
        'lueDepID
        '
        Me.lueDepID.Location = New System.Drawing.Point(91, 90)
        Me.lueDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueDepID.Name = "lueDepID"
        Me.lueDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueDepID.Properties.Appearance.Options.UseFont = True
        Me.lueDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueDepID.Properties.NullText = ""
        Me.lueDepID.Size = New System.Drawing.Size(213, 24)
        Me.lueDepID.TabIndex = 4
        '
        'lueFacID
        '
        Me.lueFacID.Location = New System.Drawing.Point(91, 52)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(213, 24)
        Me.lueFacID.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(3, 94)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "部門名稱(&P):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "廠別名稱(&D):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "計件系統資料導出"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 36)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(182, 290)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Location = New System.Drawing.Point(39, 290)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 28)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "導出(&S)"
        '
        'ComboBoxReg
        '
        Me.ComboBoxReg.Location = New System.Drawing.Point(71, 252)
        Me.ComboBoxReg.Name = "ComboBoxReg"
        Me.ComboBoxReg.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxReg.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxReg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxReg.Properties.Items.AddRange(New Object() {"辭工", "在職", "全部"})
        Me.ComboBoxReg.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxReg.Size = New System.Drawing.Size(83, 24)
        Me.ComboBoxReg.TabIndex = 64
        '
        'LabReg
        '
        Me.LabReg.AutoSize = True
        Me.LabReg.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabReg.Location = New System.Drawing.Point(12, 257)
        Me.LabReg.Name = "LabReg"
        Me.LabReg.Size = New System.Drawing.Size(61, 15)
        Me.LabReg.TabIndex = 63
        Me.LabReg.Text = "狀態(&A):"
        '
        'cboPer_Class
        '
        Me.cboPer_Class.Location = New System.Drawing.Point(223, 252)
        Me.cboPer_Class.Name = "cboPer_Class"
        Me.cboPer_Class.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPer_Class.Properties.Appearance.Options.UseFont = True
        Me.cboPer_Class.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPer_Class.Properties.Items.AddRange(New Object() {"白班", "夜班", "全部"})
        Me.cboPer_Class.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPer_Class.Size = New System.Drawing.Size(80, 24)
        Me.cboPer_Class.TabIndex = 62
        '
        'LabPerClass
        '
        Me.LabPerClass.AutoSize = True
        Me.LabPerClass.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPerClass.Location = New System.Drawing.Point(160, 257)
        Me.LabPerClass.Name = "LabPerClass"
        Me.LabPerClass.Size = New System.Drawing.Size(60, 15)
        Me.LabPerClass.TabIndex = 61
        Me.LabPerClass.Text = "班制(&E):"
        '
        'frmProductionSumPieceExportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(306, 327)
        Me.Controls.Add(Me.ComboBoxReg)
        Me.Controls.Add(Me.LabReg)
        Me.Controls.Add(Me.cboPer_Class)
        Me.Controls.Add(Me.LabPerClass)
        Me.Controls.Add(Me.cobType)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.End_Date)
        Me.Controls.Add(Me.Start_Date)
        Me.Controls.Add(Me.lueDepID)
        Me.Controls.Add(Me.lueFacID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductionSumPieceExportExcel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "計件系統資料導出"
        CType(Me.cobType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxReg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPer_Class.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cobType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents End_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Start_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueDepID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBoxReg As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabReg As System.Windows.Forms.Label
    Friend WithEvents cboPer_Class As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabPerClass As System.Windows.Forms.Label
End Class
