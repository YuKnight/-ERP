<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleStorageSub
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRemarkNew = New DevExpress.XtraEditors.MemoEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSS_ShelveIDNew = New DevExpress.XtraEditors.TextEdit
        Me.txtSS_StorageLocationNew = New DevExpress.XtraEditors.TextEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtD_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ControlDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSS_ShelveID = New DevExpress.XtraEditors.TextEdit
        Me.txtSS_StorageLocation = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Savebutton = New DevExpress.XtraEditors.SimpleButton
        Me.CloseButton = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtRemarkNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_ShelveIDNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_StorageLocationNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_ShelveID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSS_StorageLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 202)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtRemarkNew)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtSS_ShelveIDNew)
        Me.GroupBox2.Controls.Add(Me.txtSS_StorageLocationNew)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 106)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "更改储位"
        '
        'txtRemarkNew
        '
        Me.txtRemarkNew.Location = New System.Drawing.Point(100, 47)
        Me.txtRemarkNew.Name = "txtRemarkNew"
        Me.txtRemarkNew.Properties.MaxLength = 250
        Me.txtRemarkNew.Size = New System.Drawing.Size(398, 53)
        Me.txtRemarkNew.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 51)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 15)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "备        注(&E):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 24)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "货架编号(&Q):"
        '
        'txtSS_ShelveIDNew
        '
        Me.txtSS_ShelveIDNew.Location = New System.Drawing.Point(100, 19)
        Me.txtSS_ShelveIDNew.Name = "txtSS_ShelveIDNew"
        Me.txtSS_ShelveIDNew.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSS_ShelveIDNew.Properties.Appearance.Options.UseFont = True
        Me.txtSS_ShelveIDNew.Properties.MaxLength = 50
        Me.txtSS_ShelveIDNew.Size = New System.Drawing.Size(153, 24)
        Me.txtSS_ShelveIDNew.TabIndex = 1
        '
        'txtSS_StorageLocationNew
        '
        Me.txtSS_StorageLocationNew.Location = New System.Drawing.Point(345, 19)
        Me.txtSS_StorageLocationNew.Name = "txtSS_StorageLocationNew"
        Me.txtSS_StorageLocationNew.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSS_StorageLocationNew.Properties.Appearance.Options.UseFont = True
        Me.txtSS_StorageLocationNew.Properties.MaxLength = 50
        Me.txtSS_StorageLocationNew.Size = New System.Drawing.Size(153, 24)
        Me.txtSS_StorageLocationNew.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(251, 24)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 15)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "区域位置(&W):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtD_ID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSS_ShelveID)
        Me.GroupBox1.Controls.Add(Me.txtSS_StorageLocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(100, 17)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.MaxLength = 50
        Me.txtCode.Size = New System.Drawing.Size(153, 24)
        Me.txtCode.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "条       码(&A):"
        '
        'txtD_ID
        '
        Me.txtD_ID.EditValue = ""
        Me.txtD_ID.Enabled = False
        Me.txtD_ID.Location = New System.Drawing.Point(345, 17)
        Me.txtD_ID.Name = "txtD_ID"
        Me.txtD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtD_ID.Properties.Appearance.Options.UseFont = True
        Me.txtD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtD_ID.Properties.DisplayMember = "SO_CusterID"
        Me.txtD_ID.Properties.MaxLength = 50
        Me.txtD_ID.Properties.NullText = ""
        Me.txtD_ID.Properties.View = Me.GridView4
        Me.txtD_ID.Size = New System.Drawing.Size(153, 24)
        Me.txtD_ID.TabIndex = 13
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ControlDep, Me.DepName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'ControlDep
        '
        Me.ControlDep.Caption = "部门编号"
        Me.ControlDep.FieldName = "ControlDep"
        Me.ControlDep.Name = "ControlDep"
        Me.ControlDep.Visible = True
        Me.ControlDep.VisibleIndex = 0
        '
        'DepName
        '
        Me.DepName.Caption = "部门名称"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(1)
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "部       门(&S):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "货架编号(&D):"
        '
        'txtSS_ShelveID
        '
        Me.txtSS_ShelveID.Enabled = False
        Me.txtSS_ShelveID.Location = New System.Drawing.Point(100, 44)
        Me.txtSS_ShelveID.Name = "txtSS_ShelveID"
        Me.txtSS_ShelveID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSS_ShelveID.Properties.Appearance.Options.UseFont = True
        Me.txtSS_ShelveID.Properties.MaxLength = 50
        Me.txtSS_ShelveID.Size = New System.Drawing.Size(153, 24)
        Me.txtSS_ShelveID.TabIndex = 15
        '
        'txtSS_StorageLocation
        '
        Me.txtSS_StorageLocation.Enabled = False
        Me.txtSS_StorageLocation.Location = New System.Drawing.Point(345, 44)
        Me.txtSS_StorageLocation.Name = "txtSS_StorageLocation"
        Me.txtSS_StorageLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSS_StorageLocation.Properties.Appearance.Options.UseFont = True
        Me.txtSS_StorageLocation.Properties.MaxLength = 50
        Me.txtSS_StorageLocation.Size = New System.Drawing.Size(153, 24)
        Me.txtSS_StorageLocation.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 6, 6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "区域位置(&F):"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 21)
        Me.lblTitle.TabIndex = 84
        Me.lblTitle.Text = "存储位置管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(513, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Savebutton
        '
        Me.Savebutton.Image = Global.LFERP.My.Resources.Resources.SaveAndClose
        Me.Savebutton.Location = New System.Drawing.Point(172, 237)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(75, 32)
        Me.Savebutton.TabIndex = 86
        Me.Savebutton.Text = "确认(&Y)"
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.CloseButton.Location = New System.Drawing.Point(266, 237)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 32)
        Me.CloseButton.TabIndex = 87
        Me.CloseButton.Text = "取消(&N)"
        '
        'frmSampleStorageSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 276)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampleStorageSub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "存储位置管理"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtRemarkNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_ShelveIDNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_StorageLocationNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_ShelveID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSS_StorageLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemarkNew As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSS_ShelveIDNew As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSS_StorageLocationNew As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtD_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ControlDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSS_ShelveID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSS_StorageLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Savebutton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CloseButton As DevExpress.XtraEditors.SimpleButton
End Class
