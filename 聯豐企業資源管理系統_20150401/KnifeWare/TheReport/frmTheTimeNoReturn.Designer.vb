<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheTimeNoReturn
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
        Me.txtMore = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtTheDay = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.okButton = New DevExpress.XtraEditors.SimpleButton
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.RadMore = New System.Windows.Forms.RadioButton
        Me.RadPerNO = New System.Windows.Forms.RadioButton
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.RadTeam = New System.Windows.Forms.RadioButton
        Me.gridTeam = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtPerNO = New DevExpress.XtraEditors.TextEdit
        Me.canButton = New DevExpress.XtraEditors.SimpleButton
        Me.G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.txtMore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTheDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTeam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMore
        '
        Me.txtMore.Location = New System.Drawing.Point(51, 31)
        Me.txtMore.Name = "txtMore"
        Me.txtMore.Properties.Mask.EditMask = "(999)000-0000"
        Me.txtMore.Size = New System.Drawing.Size(258, 21)
        Me.txtMore.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 14)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "逾期未還天數:"
        '
        'txtTheDay
        '
        Me.txtTheDay.Location = New System.Drawing.Point(83, 68)
        Me.txtTheDay.Name = "txtTheDay"
        Me.txtTheDay.Properties.Mask.EditMask = "(999)000-0000"
        Me.txtTheDay.Size = New System.Drawing.Size(69, 21)
        Me.txtTheDay.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(114, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(196, 14)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "多選可輸入多個工號,中間以點號區分"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(202, 71)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(40, 20)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "確定"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(-5, 53)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(326, 11)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "                                                                                 " & _
            "                          "
        '
        'RadMore
        '
        Me.RadMore.AutoSize = True
        Me.RadMore.Location = New System.Drawing.Point(4, 34)
        Me.RadMore.Name = "RadMore"
        Me.RadMore.Size = New System.Drawing.Size(47, 16)
        Me.RadMore.TabIndex = 11
        Me.RadMore.Text = "多選"
        Me.RadMore.UseVisualStyleBackColor = True
        '
        'RadPerNO
        '
        Me.RadPerNO.AutoSize = True
        Me.RadPerNO.Checked = True
        Me.RadPerNO.Location = New System.Drawing.Point(4, 10)
        Me.RadPerNO.Name = "RadPerNO"
        Me.RadPerNO.Size = New System.Drawing.Size(47, 16)
        Me.RadPerNO.TabIndex = 8
        Me.RadPerNO.TabStop = True
        Me.RadPerNO.Text = "工號"
        Me.RadPerNO.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Location = New System.Drawing.Point(135, 10)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(47, 16)
        Me.RadAll.TabIndex = 9
        Me.RadAll.Text = "全部"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'RadTeam
        '
        Me.RadTeam.AutoSize = True
        Me.RadTeam.Location = New System.Drawing.Point(190, 10)
        Me.RadTeam.Name = "RadTeam"
        Me.RadTeam.Size = New System.Drawing.Size(47, 16)
        Me.RadTeam.TabIndex = 10
        Me.RadTeam.Text = "組別"
        Me.RadTeam.UseVisualStyleBackColor = True
        '
        'gridTeam
        '
        Me.gridTeam.Location = New System.Drawing.Point(235, 7)
        Me.gridTeam.Name = "gridTeam"
        Me.gridTeam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridTeam.Properties.NullText = ""
        Me.gridTeam.Properties.View = Me.GridLookUpEdit1View
        Me.gridTeam.Size = New System.Drawing.Size(74, 21)
        Me.gridTeam.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.G_NO, Me.G_Name})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtPerNO
        '
        Me.txtPerNO.Location = New System.Drawing.Point(51, 7)
        Me.txtPerNO.Name = "txtPerNO"
        Me.txtPerNO.Properties.Mask.EditMask = "(999)000-0000"
        Me.txtPerNO.Size = New System.Drawing.Size(70, 21)
        Me.txtPerNO.TabIndex = 0
        '
        'canButton
        '
        Me.canButton.Location = New System.Drawing.Point(261, 71)
        Me.canButton.Name = "canButton"
        Me.canButton.Size = New System.Drawing.Size(40, 20)
        Me.canButton.TabIndex = 12
        Me.canButton.Text = "取消"
        '
        'G_NO
        '
        Me.G_NO.Caption = "組別"
        Me.G_NO.FieldName = "G_NO"
        Me.G_NO.Name = "G_NO"
        Me.G_NO.Visible = True
        Me.G_NO.VisibleIndex = 0
        '
        'G_Name
        '
        Me.G_Name.Caption = "組名"
        Me.G_Name.FieldName = "G_Name"
        Me.G_Name.Name = "G_Name"
        Me.G_Name.Visible = True
        Me.G_Name.VisibleIndex = 1
        '
        'frmTheTimeNoReturn
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 117)
        Me.Controls.Add(Me.canButton)
        Me.Controls.Add(Me.txtPerNO)
        Me.Controls.Add(Me.gridTeam)
        Me.Controls.Add(Me.RadTeam)
        Me.Controls.Add(Me.RadAll)
        Me.Controls.Add(Me.RadPerNO)
        Me.Controls.Add(Me.RadMore)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtTheDay)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtMore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheTimeNoReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "逾期未還"
        CType(Me.txtMore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTheDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTeam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMore As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTheDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents okButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RadMore As System.Windows.Forms.RadioButton
    Friend WithEvents RadPerNO As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadTeam As System.Windows.Forms.RadioButton
    Friend WithEvents gridTeam As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPerNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents canButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Name As DevExpress.XtraGrid.Columns.GridColumn
End Class
