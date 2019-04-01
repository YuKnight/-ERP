<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampInventoryWeightView
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ppcD_ID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkD_ID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.lbl_DepName = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.lbl_OrderNO = New System.Windows.Forms.Label
        Me.lbl_Check = New System.Windows.Forms.Label
        Me.lbl_StratDate = New System.Windows.Forms.Label
        Me.dateEndDate = New DevExpress.XtraEditors.DateEdit
        Me.dateStratDate = New DevExpress.XtraEditors.DateEdit
        Me.cbeCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lbl_EndDate = New System.Windows.Forms.Label
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txt_OrderNO = New DevExpress.XtraEditors.TextEdit
        Me.txt_DepName = New DevExpress.XtraEditors.TextEdit
        Me.Panel2.SuspendLayout()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppcD_ID.SuspendLayout()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OrderNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(5, 5)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(175, 21)
        Me.lbl_Title.TabIndex = 89
        Me.lbl_Title.Text = "盘点作业/更改单"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 32)
        Me.Panel2.TabIndex = 129
        '
        'ppcD_ID
        '
        Me.ppcD_ID.Controls.Add(Me.chkD_ID)
        Me.ppcD_ID.Location = New System.Drawing.Point(56, 309)
        Me.ppcD_ID.Name = "ppcD_ID"
        Me.ppcD_ID.Size = New System.Drawing.Size(108, 160)
        Me.ppcD_ID.TabIndex = 261
        Me.ppcD_ID.Text = "PopupContainerControl4"
        '
        'chkD_ID
        '
        Me.chkD_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkD_ID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkD_ID.CheckOnClick = True
        Me.chkD_ID.DisplayMember = "DepName"
        Me.chkD_ID.HotTrackItems = True
        Me.chkD_ID.Location = New System.Drawing.Point(2, 3)
        Me.chkD_ID.Name = "chkD_ID"
        Me.chkD_ID.Size = New System.Drawing.Size(105, 155)
        Me.chkD_ID.TabIndex = 0
        Me.chkD_ID.ValueMember = "DepID"
        '
        'lbl_DepName
        '
        Me.lbl_DepName.AutoSize = True
        Me.lbl_DepName.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_DepName.Location = New System.Drawing.Point(53, 84)
        Me.lbl_DepName.Name = "lbl_DepName"
        Me.lbl_DepName.Size = New System.Drawing.Size(46, 13)
        Me.lbl_DepName.TabIndex = 2
        Me.lbl_DepName.Text = "部门："
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(190, 231)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 132
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(30, 231)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 131
        Me.cmdSave.Text = "查询(&F)"
        '
        'lbl_OrderNO
        '
        Me.lbl_OrderNO.AutoSize = True
        Me.lbl_OrderNO.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_OrderNO.Location = New System.Drawing.Point(53, 48)
        Me.lbl_OrderNO.Name = "lbl_OrderNO"
        Me.lbl_OrderNO.Size = New System.Drawing.Size(46, 13)
        Me.lbl_OrderNO.TabIndex = 0
        Me.lbl_OrderNO.Text = "单号："
        '
        'lbl_Check
        '
        Me.lbl_Check.AutoSize = True
        Me.lbl_Check.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_Check.ForeColor = System.Drawing.Color.Red
        Me.lbl_Check.Location = New System.Drawing.Point(27, 122)
        Me.lbl_Check.Name = "lbl_Check"
        Me.lbl_Check.Size = New System.Drawing.Size(72, 13)
        Me.lbl_Check.TabIndex = 10
        Me.lbl_Check.Text = "审核类型："
        '
        'lbl_StratDate
        '
        Me.lbl_StratDate.AutoSize = True
        Me.lbl_StratDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_StratDate.Location = New System.Drawing.Point(27, 160)
        Me.lbl_StratDate.Name = "lbl_StratDate"
        Me.lbl_StratDate.Size = New System.Drawing.Size(72, 13)
        Me.lbl_StratDate.TabIndex = 2
        Me.lbl_StratDate.Text = "起始日期："
        '
        'dateEndDate
        '
        Me.dateEndDate.EditValue = Nothing
        Me.dateEndDate.Location = New System.Drawing.Point(100, 191)
        Me.dateEndDate.Name = "dateEndDate"
        Me.dateEndDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateEndDate.Properties.Appearance.Options.UseFont = True
        Me.dateEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEndDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateEndDate.Size = New System.Drawing.Size(150, 24)
        Me.dateEndDate.TabIndex = 5
        '
        'dateStratDate
        '
        Me.dateStratDate.EditValue = Nothing
        Me.dateStratDate.Location = New System.Drawing.Point(100, 155)
        Me.dateStratDate.Name = "dateStratDate"
        Me.dateStratDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateStratDate.Properties.Appearance.Options.UseFont = True
        Me.dateStratDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateStratDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dateStratDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateStratDate.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dateStratDate.Size = New System.Drawing.Size(150, 24)
        Me.dateStratDate.TabIndex = 3
        '
        'cbeCheck
        '
        Me.cbeCheck.EditValue = "ALL"
        Me.cbeCheck.Location = New System.Drawing.Point(100, 116)
        Me.cbeCheck.Name = "cbeCheck"
        Me.cbeCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbeCheck.Properties.Appearance.Options.UseFont = True
        Me.cbeCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeCheck.Properties.Items.AddRange(New Object() {"ALL", "审核", "未审核"})
        Me.cbeCheck.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbeCheck.Size = New System.Drawing.Size(110, 25)
        Me.cbeCheck.TabIndex = 11
        '
        'lbl_EndDate
        '
        Me.lbl_EndDate.AutoSize = True
        Me.lbl_EndDate.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_EndDate.Location = New System.Drawing.Point(27, 196)
        Me.lbl_EndDate.Name = "lbl_EndDate"
        Me.lbl_EndDate.Size = New System.Drawing.Size(72, 13)
        Me.lbl_EndDate.TabIndex = 4
        Me.lbl_EndDate.Text = "结束日期："
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "单号"
        Me.GridColumn1.FieldName = "ChangeNO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'txt_OrderNO
        '
        Me.txt_OrderNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OrderNO.Location = New System.Drawing.Point(100, 43)
        Me.txt_OrderNO.Name = "txt_OrderNO"
        Me.txt_OrderNO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_OrderNO.Properties.Appearance.Options.UseFont = True
        Me.txt_OrderNO.Size = New System.Drawing.Size(150, 24)
        Me.txt_OrderNO.TabIndex = 262
        '
        'txt_DepName
        '
        Me.txt_DepName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DepName.Enabled = False
        Me.txt_DepName.Location = New System.Drawing.Point(100, 79)
        Me.txt_DepName.Name = "txt_DepName"
        Me.txt_DepName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_DepName.Properties.Appearance.Options.UseFont = True
        Me.txt_DepName.Properties.ReadOnly = True
        Me.txt_DepName.Size = New System.Drawing.Size(150, 24)
        Me.txt_DepName.TabIndex = 263
        '
        'frmNmetalSampInventoryWeightView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 268)
        Me.Controls.Add(Me.txt_DepName)
        Me.Controls.Add(Me.txt_OrderNO)
        Me.Controls.Add(Me.lbl_OrderNO)
        Me.Controls.Add(Me.lbl_DepName)
        Me.Controls.Add(Me.ppcD_ID)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lbl_Check)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cbeCheck)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dateStratDate)
        Me.Controls.Add(Me.dateEndDate)
        Me.Controls.Add(Me.lbl_StratDate)
        Me.Controls.Add(Me.lbl_EndDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampInventoryWeightView"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查询"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppcD_ID.ResumeLayout(False)
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateStratDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OrderNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_DepName As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ppcD_ID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkD_ID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lbl_OrderNO As System.Windows.Forms.Label
    Friend WithEvents lbl_Check As System.Windows.Forms.Label
    Friend WithEvents lbl_StratDate As System.Windows.Forms.Label
    Friend WithEvents dateEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dateStratDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbeCheck As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_EndDate As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_OrderNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DepName As DevExpress.XtraEditors.TextEdit
End Class
