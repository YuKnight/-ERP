<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPieceWorkGroup
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
        Me.lblTittle = New System.Windows.Forms.Label
        Me.LabG_NO = New System.Windows.Forms.Label
        Me.TxtG_NO = New DevExpress.XtraEditors.TextEdit
        Me.LabG_Name = New System.Windows.Forms.Label
        Me.txtG_Name = New DevExpress.XtraEditors.TextEdit
        Me.LabDepID = New System.Windows.Forms.Label
        Me.labG_Manager = New System.Windows.Forms.Label
        Me.txtG_Manager = New DevExpress.XtraEditors.TextEdit
        Me.LabG_Remark = New System.Windows.Forms.Label
        Me.MemoG_Remark = New DevExpress.XtraEditors.MemoEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.CaoTypeLabel = New System.Windows.Forms.Label
        Me.txtDepID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UserDep_Fac = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.labFacID = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.TxtG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_Manager.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoG_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTittle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTittle.ForeColor = System.Drawing.Color.Navy
        Me.lblTittle.Location = New System.Drawing.Point(12, 9)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(120, 21)
        Me.lblTittle.TabIndex = 14
        Me.lblTittle.Text = "組別--新增"
        '
        'LabG_NO
        '
        Me.LabG_NO.AutoSize = True
        Me.LabG_NO.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabG_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_NO.Location = New System.Drawing.Point(195, 11)
        Me.LabG_NO.Name = "LabG_NO"
        Me.LabG_NO.Size = New System.Drawing.Size(41, 15)
        Me.LabG_NO.TabIndex = 1
        Me.LabG_NO.Text = "編號:"
        '
        'TxtG_NO
        '
        Me.TxtG_NO.Location = New System.Drawing.Point(238, 8)
        Me.TxtG_NO.Name = "TxtG_NO"
        Me.TxtG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtG_NO.Properties.Appearance.Options.UseFont = True
        Me.TxtG_NO.Size = New System.Drawing.Size(91, 24)
        Me.TxtG_NO.TabIndex = 2
        '
        'LabG_Name
        '
        Me.LabG_Name.AutoSize = True
        Me.LabG_Name.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_Name.Location = New System.Drawing.Point(11, 57)
        Me.LabG_Name.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabG_Name.Name = "LabG_Name"
        Me.LabG_Name.Size = New System.Drawing.Size(91, 15)
        Me.LabG_Name.TabIndex = 5
        Me.LabG_Name.Text = "組別名稱(&N):"
        '
        'txtG_Name
        '
        Me.txtG_Name.Location = New System.Drawing.Point(104, 54)
        Me.txtG_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtG_Name.Name = "txtG_Name"
        Me.txtG_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtG_Name.Properties.Appearance.Options.UseFont = True
        Me.txtG_Name.Size = New System.Drawing.Size(220, 24)
        Me.txtG_Name.TabIndex = 6
        '
        'LabDepID
        '
        Me.LabDepID.AutoSize = True
        Me.LabDepID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabDepID.Location = New System.Drawing.Point(41, 21)
        Me.LabDepID.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabDepID.Name = "LabDepID"
        Me.LabDepID.Size = New System.Drawing.Size(61, 15)
        Me.LabDepID.TabIndex = 3
        Me.LabDepID.Text = "部門(&D):"
        '
        'labG_Manager
        '
        Me.labG_Manager.AutoSize = True
        Me.labG_Manager.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labG_Manager.Location = New System.Drawing.Point(28, 93)
        Me.labG_Manager.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.labG_Manager.Name = "labG_Manager"
        Me.labG_Manager.Size = New System.Drawing.Size(74, 15)
        Me.labG_Manager.TabIndex = 7
        Me.labG_Manager.Text = "負責人(&P):"
        '
        'txtG_Manager
        '
        Me.txtG_Manager.Location = New System.Drawing.Point(104, 90)
        Me.txtG_Manager.Margin = New System.Windows.Forms.Padding(6)
        Me.txtG_Manager.Name = "txtG_Manager"
        Me.txtG_Manager.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtG_Manager.Properties.Appearance.Options.UseFont = True
        Me.txtG_Manager.Size = New System.Drawing.Size(220, 24)
        Me.txtG_Manager.TabIndex = 8
        '
        'LabG_Remark
        '
        Me.LabG_Remark.AutoSize = True
        Me.LabG_Remark.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_Remark.Location = New System.Drawing.Point(42, 128)
        Me.LabG_Remark.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabG_Remark.Name = "LabG_Remark"
        Me.LabG_Remark.Size = New System.Drawing.Size(60, 15)
        Me.LabG_Remark.TabIndex = 9
        Me.LabG_Remark.Text = "備注(&R):"
        '
        'MemoG_Remark
        '
        Me.MemoG_Remark.Location = New System.Drawing.Point(104, 126)
        Me.MemoG_Remark.Margin = New System.Windows.Forms.Padding(6)
        Me.MemoG_Remark.Name = "MemoG_Remark"
        Me.MemoG_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MemoG_Remark.Properties.Appearance.Options.UseFont = True
        Me.MemoG_Remark.Size = New System.Drawing.Size(220, 56)
        Me.MemoG_Remark.TabIndex = 10
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(145, 21)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "確認(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(244, 21)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "退出(&C)"
        '
        'PicCaption
        '
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(5, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(336, 36)
        Me.PicCaption.TabIndex = 261
        Me.PicCaption.TabStop = False
        '
        'CaoTypeLabel
        '
        Me.CaoTypeLabel.AutoSize = True
        Me.CaoTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaoTypeLabel.Location = New System.Drawing.Point(12, 30)
        Me.CaoTypeLabel.Name = "CaoTypeLabel"
        Me.CaoTypeLabel.Size = New System.Drawing.Size(53, 12)
        Me.CaoTypeLabel.TabIndex = 15
        Me.CaoTypeLabel.Text = "操作類型"
        Me.CaoTypeLabel.Visible = False
        '
        'txtDepID
        '
        Me.txtDepID.Enabled = False
        Me.txtDepID.Location = New System.Drawing.Point(104, 18)
        Me.txtDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDepID.Name = "txtDepID"
        Me.txtDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepID.Properties.Appearance.Options.UseFont = True
        Me.txtDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDepID.Properties.NullText = ""
        Me.txtDepID.Properties.View = Me.GridLookUpEdit1View
        Me.txtDepID.Size = New System.Drawing.Size(220, 24)
        Me.txtDepID.TabIndex = 4
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.UserDep_Fac, Me.DepID, Me.FacName, Me.DepName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'UserDep_Fac
        '
        Me.UserDep_Fac.Caption = "GridColumn6"
        Me.UserDep_Fac.FieldName = "UserDep_Fac"
        Me.UserDep_Fac.Name = "UserDep_Fac"
        '
        'DepID
        '
        Me.DepID.Caption = "部門代號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 0
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.FieldName = "G_FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 1
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "G_DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Location = New System.Drawing.Point(11, 21)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 28)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "增加(&A)"
        '
        'labFacID
        '
        Me.labFacID.AutoSize = True
        Me.labFacID.Location = New System.Drawing.Point(123, 20)
        Me.labFacID.Name = "labFacID"
        Me.labFacID.Size = New System.Drawing.Size(33, 12)
        Me.labFacID.TabIndex = 263
        Me.labFacID.Text = "FacID"
        Me.labFacID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDepID)
        Me.GroupBox1.Controls.Add(Me.LabG_Name)
        Me.GroupBox1.Controls.Add(Me.txtG_Name)
        Me.GroupBox1.Controls.Add(Me.LabDepID)
        Me.GroupBox1.Controls.Add(Me.labG_Manager)
        Me.GroupBox1.Controls.Add(Me.txtG_Manager)
        Me.GroupBox1.Controls.Add(Me.LabG_Remark)
        Me.GroupBox1.Controls.Add(Me.MemoG_Remark)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 196)
        Me.GroupBox1.TabIndex = 264
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 62)
        Me.GroupBox2.TabIndex = 265
        Me.GroupBox2.TabStop = False
        '
        'frmProductionPieceWorkGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(346, 309)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labFacID)
        Me.Controls.Add(Me.CaoTypeLabel)
        Me.Controls.Add(Me.TxtG_NO)
        Me.Controls.Add(Me.LabG_NO)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.PicCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductionPieceWorkGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "組別"
        CType(Me.TxtG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_Manager.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoG_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTittle As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents LabG_NO As System.Windows.Forms.Label
    Friend WithEvents TxtG_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabG_Name As System.Windows.Forms.Label
    Friend WithEvents txtG_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabDepID As System.Windows.Forms.Label
    Friend WithEvents labG_Manager As System.Windows.Forms.Label
    Friend WithEvents txtG_Manager As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabG_Remark As System.Windows.Forms.Label
    Friend WithEvents MemoG_Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CaoTypeLabel As System.Windows.Forms.Label
    Friend WithEvents txtDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UserDep_Fac As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labFacID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
