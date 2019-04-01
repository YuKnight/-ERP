<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPieceWorkGroupFind
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
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.dteG_DateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dteG_DateBegin = New DevExpress.XtraEditors.DateEdit
        Me.txtG_Name = New DevExpress.XtraEditors.TextEdit
        Me.lueDepID = New DevExpress.XtraEditors.LookUpEdit
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.txtG_Manager = New DevExpress.XtraEditors.TextEdit
        Me.txtG_NO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.dteG_DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteG_DateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_Manager.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.dteG_DateEnd)
        Me.GroupBox1.Controls.Add(Me.dteG_DateBegin)
        Me.GroupBox1.Controls.Add(Me.txtG_Name)
        Me.GroupBox1.Controls.Add(Me.lueDepID)
        Me.GroupBox1.Controls.Add(Me.lueFacID)
        Me.GroupBox1.Controls.Add(Me.txtG_Manager)
        Me.GroupBox1.Controls.Add(Me.txtG_NO)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(109, 243)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "到"
        '
        'dteG_DateEnd
        '
        Me.dteG_DateEnd.EditValue = Nothing
        Me.dteG_DateEnd.Location = New System.Drawing.Point(133, 240)
        Me.dteG_DateEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.dteG_DateEnd.Name = "dteG_DateEnd"
        Me.dteG_DateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteG_DateEnd.Properties.Appearance.Options.UseFont = True
        Me.dteG_DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteG_DateEnd.Size = New System.Drawing.Size(120, 24)
        Me.dteG_DateEnd.TabIndex = 13
        '
        'dteG_DateBegin
        '
        Me.dteG_DateBegin.EditValue = Nothing
        Me.dteG_DateBegin.Location = New System.Drawing.Point(133, 204)
        Me.dteG_DateBegin.Margin = New System.Windows.Forms.Padding(6)
        Me.dteG_DateBegin.Name = "dteG_DateBegin"
        Me.dteG_DateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteG_DateBegin.Properties.Appearance.Options.UseFont = True
        Me.dteG_DateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteG_DateBegin.Size = New System.Drawing.Size(120, 24)
        Me.dteG_DateBegin.TabIndex = 12
        '
        'txtG_Name
        '
        Me.txtG_Name.Location = New System.Drawing.Point(103, 60)
        Me.txtG_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtG_Name.Name = "txtG_Name"
        Me.txtG_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG_Name.Properties.Appearance.Options.UseFont = True
        Me.txtG_Name.Size = New System.Drawing.Size(150, 24)
        Me.txtG_Name.TabIndex = 11
        '
        'lueDepID
        '
        Me.lueDepID.Location = New System.Drawing.Point(103, 168)
        Me.lueDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueDepID.Name = "lueDepID"
        Me.lueDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueDepID.Properties.Appearance.Options.UseFont = True
        Me.lueDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueDepID.Properties.NullText = ""
        Me.lueDepID.Size = New System.Drawing.Size(150, 24)
        Me.lueDepID.TabIndex = 10
        '
        'lueFacID
        '
        Me.lueFacID.Location = New System.Drawing.Point(103, 132)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(150, 24)
        Me.lueFacID.TabIndex = 9
        '
        'txtG_Manager
        '
        Me.txtG_Manager.Location = New System.Drawing.Point(103, 96)
        Me.txtG_Manager.Margin = New System.Windows.Forms.Padding(6)
        Me.txtG_Manager.Name = "txtG_Manager"
        Me.txtG_Manager.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG_Manager.Properties.Appearance.Options.UseFont = True
        Me.txtG_Manager.Size = New System.Drawing.Size(150, 24)
        Me.txtG_Manager.TabIndex = 8
        '
        'txtG_NO
        '
        Me.txtG_NO.Location = New System.Drawing.Point(103, 24)
        Me.txtG_NO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtG_NO.Name = "txtG_NO"
        Me.txtG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG_NO.Properties.Appearance.Options.UseFont = True
        Me.txtG_NO.Size = New System.Drawing.Size(150, 24)
        Me.txtG_NO.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(109, 207)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "從"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(14, 207)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "建立日期(&E):"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(13, 171)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "部門名稱(&D):"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(15, 135)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "廠別名稱(&S):"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "負  責  人(&U):"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 63)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "組別名稱(&N):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 27)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "組別編號(&I):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(147, 20)
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
        Me.btnFind.Location = New System.Drawing.Point(42, 20)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(80, 28)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "查詢(&F)"
        '
        'frmProductionPieceWorkGroupFind
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(276, 353)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionPieceWorkGroupFind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "組別名單--查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dteG_DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteG_DateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_Manager.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtG_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDepID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtG_Manager As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtG_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteG_DateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteG_DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
End Class
