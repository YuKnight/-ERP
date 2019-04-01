<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhiteUserSelect
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
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.txt_UserID = New DevExpress.XtraEditors.TextEdit
        Me.cmdSelect = New DevExpress.XtraEditors.SimpleButton
        Me.CheckUserID = New DevExpress.XtraEditors.CheckEdit
        Me.CheckWare = New DevExpress.XtraEditors.CheckEdit
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.PopupContainerEditWare = New DevExpress.XtraEditors.PopupContainerEdit
        Me.txt_UserName = New DevExpress.XtraEditors.TextEdit
        Me.CheckUserName = New DevExpress.XtraEditors.CheckEdit
        Me.CheckFacName = New DevExpress.XtraEditors.CheckEdit
        Me.CheckDepName = New DevExpress.XtraEditors.CheckEdit
        Me.CheckWMax = New DevExpress.XtraEditors.CheckEdit
        Me.EditFacName = New DevExpress.XtraEditors.LookUpEdit
        Me.EditDepName = New DevExpress.XtraEditors.LookUpEdit
        Me.EditWMax = New DevExpress.XtraEditors.CalcEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblMain = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.txt_UserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckUserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckWare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerEditWare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckFacName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckWMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditFacName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditWMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.tv1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(291, 121)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(120, 166)
        Me.PopupContainerControl1.TabIndex = 97
        Me.PopupContainerControl1.Text = "PopupContainerControl1"
        '
        'tv1
        '
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(120, 166)
        Me.tv1.TabIndex = 24
        '
        'txt_UserID
        '
        Me.txt_UserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_UserID.Location = New System.Drawing.Point(68, 14)
        Me.txt_UserID.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_UserID.Properties.Appearance.Options.UseFont = True
        Me.txt_UserID.Size = New System.Drawing.Size(120, 22)
        Me.txt_UserID.TabIndex = 0
        '
        'cmdSelect
        '
        Me.cmdSelect.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSelect.Appearance.Options.UseFont = True
        Me.cmdSelect.Location = New System.Drawing.Point(74, 158)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(50, 22)
        Me.cmdSelect.TabIndex = 3
        Me.cmdSelect.Text = "查詢"
        '
        'CheckUserID
        '
        Me.CheckUserID.EditValue = True
        Me.CheckUserID.Location = New System.Drawing.Point(4, 16)
        Me.CheckUserID.Name = "CheckUserID"
        Me.CheckUserID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckUserID.Properties.Appearance.Options.UseFont = True
        Me.CheckUserID.Properties.Caption = "工號："
        Me.CheckUserID.Size = New System.Drawing.Size(61, 20)
        Me.CheckUserID.TabIndex = 5
        '
        'CheckWare
        '
        Me.CheckWare.Location = New System.Drawing.Point(4, 107)
        Me.CheckWare.Name = "CheckWare"
        Me.CheckWare.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckWare.Properties.Appearance.Options.UseFont = True
        Me.CheckWare.Properties.Caption = "倉庫："
        Me.CheckWare.Size = New System.Drawing.Size(61, 20)
        Me.CheckWare.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(137, 158)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(50, 22)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "取消"
        '
        'PopupContainerEditWare
        '
        Me.PopupContainerEditWare.Location = New System.Drawing.Point(68, 104)
        Me.PopupContainerEditWare.Name = "PopupContainerEditWare"
        Me.PopupContainerEditWare.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PopupContainerEditWare.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerEditWare.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEditWare.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEditWare.Size = New System.Drawing.Size(120, 24)
        Me.PopupContainerEditWare.TabIndex = 2
        '
        'txt_UserName
        '
        Me.txt_UserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_UserName.Location = New System.Drawing.Point(68, 37)
        Me.txt_UserName.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_UserName.Properties.Appearance.Options.UseFont = True
        Me.txt_UserName.Size = New System.Drawing.Size(120, 22)
        Me.txt_UserName.TabIndex = 98
        '
        'CheckUserName
        '
        Me.CheckUserName.Location = New System.Drawing.Point(4, 39)
        Me.CheckUserName.Name = "CheckUserName"
        Me.CheckUserName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckUserName.Properties.Appearance.Options.UseFont = True
        Me.CheckUserName.Properties.Caption = "姓名："
        Me.CheckUserName.Size = New System.Drawing.Size(61, 20)
        Me.CheckUserName.TabIndex = 99
        '
        'CheckFacName
        '
        Me.CheckFacName.Location = New System.Drawing.Point(4, 61)
        Me.CheckFacName.Name = "CheckFacName"
        Me.CheckFacName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckFacName.Properties.Appearance.Options.UseFont = True
        Me.CheckFacName.Properties.Caption = "廠別："
        Me.CheckFacName.Size = New System.Drawing.Size(61, 20)
        Me.CheckFacName.TabIndex = 100
        '
        'CheckDepName
        '
        Me.CheckDepName.Location = New System.Drawing.Point(4, 84)
        Me.CheckDepName.Name = "CheckDepName"
        Me.CheckDepName.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckDepName.Properties.Appearance.Options.UseFont = True
        Me.CheckDepName.Properties.Caption = "部門："
        Me.CheckDepName.Size = New System.Drawing.Size(61, 20)
        Me.CheckDepName.TabIndex = 102
        '
        'CheckWMax
        '
        Me.CheckWMax.Location = New System.Drawing.Point(4, 132)
        Me.CheckWMax.Name = "CheckWMax"
        Me.CheckWMax.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckWMax.Properties.Appearance.Options.UseFont = True
        Me.CheckWMax.Properties.Caption = "上限："
        Me.CheckWMax.Size = New System.Drawing.Size(61, 20)
        Me.CheckWMax.TabIndex = 104
        '
        'EditFacName
        '
        Me.EditFacName.Location = New System.Drawing.Point(68, 60)
        Me.EditFacName.Name = "EditFacName"
        Me.EditFacName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditFacName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fac_name", "廠別", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.EditFacName.Properties.NullText = ""
        Me.EditFacName.Size = New System.Drawing.Size(120, 21)
        Me.EditFacName.TabIndex = 106
        '
        'EditDepName
        '
        Me.EditDepName.Location = New System.Drawing.Point(68, 82)
        Me.EditDepName.Name = "EditDepName"
        Me.EditDepName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditDepName.Properties.NullText = ""
        Me.EditDepName.Size = New System.Drawing.Size(120, 21)
        Me.EditDepName.TabIndex = 107
        '
        'EditWMax
        '
        Me.EditWMax.Location = New System.Drawing.Point(88, 129)
        Me.EditWMax.Name = "EditWMax"
        Me.EditWMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditWMax.Properties.Mask.EditMask = "d"
        Me.EditWMax.Size = New System.Drawing.Size(100, 21)
        Me.EditWMax.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = ">="
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckUserID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_UserID)
        Me.GroupBox1.Controls.Add(Me.EditWMax)
        Me.GroupBox1.Controls.Add(Me.cmdSelect)
        Me.GroupBox1.Controls.Add(Me.EditDepName)
        Me.GroupBox1.Controls.Add(Me.CheckWare)
        Me.GroupBox1.Controls.Add(Me.EditFacName)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.CheckWMax)
        Me.GroupBox1.Controls.Add(Me.PopupContainerEditWare)
        Me.GroupBox1.Controls.Add(Me.CheckDepName)
        Me.GroupBox1.Controls.Add(Me.txt_UserName)
        Me.GroupBox1.Controls.Add(Me.CheckFacName)
        Me.GroupBox1.Controls.Add(Me.CheckUserName)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 192)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMain.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Navy
        Me.lblMain.Location = New System.Drawing.Point(2, 7)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(88, 16)
        Me.lblMain.TabIndex = 110
        Me.lblMain.Text = "白名單查詢"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 29)
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'frmWhiteUserSelect
        '
        Me.AcceptButton = Me.cmdSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(199, 227)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWhiteUserSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "白名單查詢"
        Me.TopMost = True
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.txt_UserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckUserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckWare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerEditWare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckFacName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckWMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditFacName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditWMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents txt_UserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSelect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckUserID As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckWare As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupContainerEditWare As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents txt_UserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckUserName As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckFacName As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckDepName As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckWMax As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EditFacName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EditDepName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EditWMax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
