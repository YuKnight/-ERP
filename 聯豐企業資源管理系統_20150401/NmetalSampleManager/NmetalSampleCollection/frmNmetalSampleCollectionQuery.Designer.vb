<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleCollectionQuery
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.chkD_ID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.ppcD_ID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkD_IDAll = New DevExpress.XtraEditors.CheckEdit
        Me.gluD_ID = New DevExpress.XtraEditors.PopupContainerEdit
        Me.lblD_ID = New System.Windows.Forms.Label
        Me.gluStatusType = New DevExpress.XtraEditors.PopupContainerEdit
        Me.pccStatusType = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkStatusType = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.chkPaceType = New DevExpress.XtraEditors.CheckEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Dateenddate = New DevExpress.XtraEditors.DateEdit
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton
        Me.dateAddDate = New DevExpress.XtraEditors.DateEdit
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppcD_ID.SuspendLayout()
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluStatusType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccStatusType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccStatusType.SuspendLayout()
        CType(Me.chkStatusType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPaceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dateenddate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "条码查询"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 33)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(112, 43)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "SO_SampleID"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 200
        Me.gluPM_M_Code.Properties.ValueMember = "SO_SampleID"
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(180, 24)
        Me.gluPM_M_Code.TabIndex = 50
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn5})
        Me.GridView8.DetailHeight = 110
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.Location = New System.Drawing.Point(12, 47)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(96, 16)
        Me.lblPM_M_Code.TabIndex = 49
        Me.lblPM_M_Code.Text = "样办单号(&C):"
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
        Me.chkD_ID.Location = New System.Drawing.Point(2, 26)
        Me.chkD_ID.Name = "chkD_ID"
        Me.chkD_ID.Size = New System.Drawing.Size(105, 135)
        Me.chkD_ID.TabIndex = 0
        Me.chkD_ID.ValueMember = "DepID"
        '
        'ppcD_ID
        '
        Me.ppcD_ID.Controls.Add(Me.chkD_ID)
        Me.ppcD_ID.Controls.Add(Me.chkD_IDAll)
        Me.ppcD_ID.Location = New System.Drawing.Point(28, 275)
        Me.ppcD_ID.Name = "ppcD_ID"
        Me.ppcD_ID.Size = New System.Drawing.Size(108, 163)
        Me.ppcD_ID.TabIndex = 248
        Me.ppcD_ID.Text = "PopupContainerControl4"
        '
        'chkD_IDAll
        '
        Me.chkD_IDAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkD_IDAll.Location = New System.Drawing.Point(4, 3)
        Me.chkD_IDAll.Name = "chkD_IDAll"
        Me.chkD_IDAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.chkD_IDAll.Properties.Appearance.Options.UseFont = True
        Me.chkD_IDAll.Properties.Caption = "全选<部门>"
        Me.chkD_IDAll.Size = New System.Drawing.Size(102, 23)
        Me.chkD_IDAll.TabIndex = 29
        '
        'gluD_ID
        '
        Me.gluD_ID.Location = New System.Drawing.Point(112, 77)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluD_ID.Properties.PopupControl = Me.ppcD_ID
        Me.gluD_ID.Size = New System.Drawing.Size(180, 24)
        Me.gluD_ID.TabIndex = 250
        '
        'lblD_ID
        '
        Me.lblD_ID.AutoSize = True
        Me.lblD_ID.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblD_ID.Location = New System.Drawing.Point(43, 81)
        Me.lblD_ID.Name = "lblD_ID"
        Me.lblD_ID.Size = New System.Drawing.Size(65, 16)
        Me.lblD_ID.TabIndex = 249
        Me.lblD_ID.Text = "部门(&D):"
        '
        'gluStatusType
        '
        Me.gluStatusType.Location = New System.Drawing.Point(112, 115)
        Me.gluStatusType.Name = "gluStatusType"
        Me.gluStatusType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluStatusType.Properties.Appearance.Options.UseFont = True
        Me.gluStatusType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluStatusType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluStatusType.Properties.PopupControl = Me.pccStatusType
        Me.gluStatusType.Size = New System.Drawing.Size(180, 24)
        Me.gluStatusType.TabIndex = 252
        '
        'pccStatusType
        '
        Me.pccStatusType.Controls.Add(Me.chkStatusType)
        Me.pccStatusType.Controls.Add(Me.chkPaceType)
        Me.pccStatusType.Location = New System.Drawing.Point(160, 275)
        Me.pccStatusType.Name = "pccStatusType"
        Me.pccStatusType.Size = New System.Drawing.Size(107, 163)
        Me.pccStatusType.TabIndex = 260
        Me.pccStatusType.Text = "PopupContainerControl4"
        '
        'chkStatusType
        '
        Me.chkStatusType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStatusType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkStatusType.CheckOnClick = True
        Me.chkStatusType.DisplayMember = "StatusTypeName"
        Me.chkStatusType.HotTrackItems = True
        Me.chkStatusType.Location = New System.Drawing.Point(0, 26)
        Me.chkStatusType.Name = "chkStatusType"
        Me.chkStatusType.Size = New System.Drawing.Size(106, 135)
        Me.chkStatusType.TabIndex = 0
        Me.chkStatusType.ValueMember = "StatusType"
        '
        'chkPaceType
        '
        Me.chkPaceType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPaceType.Location = New System.Drawing.Point(2, 1)
        Me.chkPaceType.Name = "chkPaceType"
        Me.chkPaceType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.chkPaceType.Properties.Appearance.Options.UseFont = True
        Me.chkPaceType.Properties.Caption = "全选<状态>"
        Me.chkPaceType.Size = New System.Drawing.Size(104, 23)
        Me.chkPaceType.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 251
        Me.Label2.Text = "状态(&Z):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "起始日期(&Q):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "结束日期(&J):"
        '
        'Dateenddate
        '
        Me.Dateenddate.EditValue = New Date(2014, 7, 31, 0, 0, 0, 0)
        Me.Dateenddate.Location = New System.Drawing.Point(112, 192)
        Me.Dateenddate.Name = "Dateenddate"
        Me.Dateenddate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Dateenddate.Properties.Appearance.Options.UseFont = True
        Me.Dateenddate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dateenddate.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.Dateenddate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Dateenddate.Size = New System.Drawing.Size(180, 24)
        Me.Dateenddate.TabIndex = 257
        '
        'btn_exit
        '
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btn_exit.Location = New System.Drawing.Point(204, 231)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(80, 29)
        Me.btn_exit.TabIndex = 259
        Me.btn_exit.Text = "取消(&E)"
        '
        'btn_print
        '
        Me.btn_print.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.btn_print.Location = New System.Drawing.Point(27, 231)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(80, 29)
        Me.btn_print.TabIndex = 258
        Me.btn_print.Text = "预览(&P)"
        '
        'dateAddDate
        '
        Me.dateAddDate.EditValue = New Date(2014, 7, 1, 0, 0, 0, 0)
        Me.dateAddDate.Location = New System.Drawing.Point(112, 154)
        Me.dateAddDate.Name = "dateAddDate"
        Me.dateAddDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dateAddDate.Properties.Appearance.Options.UseFont = True
        Me.dateAddDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateAddDate.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.dateAddDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateAddDate.Size = New System.Drawing.Size(180, 24)
        Me.dateAddDate.TabIndex = 261
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "样办单号"
        Me.GridColumn6.FieldName = "SO_SampleID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "产品编号"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 100
        '
        'frmNmetalSampleCollectionQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 265)
        Me.Controls.Add(Me.dateAddDate)
        Me.Controls.Add(Me.pccStatusType)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dateenddate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gluStatusType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gluD_ID)
        Me.Controls.Add(Me.lblD_ID)
        Me.Controls.Add(Me.ppcD_ID)
        Me.Controls.Add(Me.gluPM_M_Code)
        Me.Controls.Add(Me.lblPM_M_Code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNmetalSampleCollectionQuery"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "条码查询"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppcD_ID.ResumeLayout(False)
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluStatusType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccStatusType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccStatusType.ResumeLayout(False)
        CType(Me.chkStatusType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPaceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dateenddate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateAddDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents chkD_ID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ppcD_ID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkD_IDAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents lblD_ID As System.Windows.Forms.Label
    Friend WithEvents gluStatusType As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dateenddate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pccStatusType As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkStatusType As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkPaceType As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dateAddDate As DevExpress.XtraEditors.DateEdit
End Class
