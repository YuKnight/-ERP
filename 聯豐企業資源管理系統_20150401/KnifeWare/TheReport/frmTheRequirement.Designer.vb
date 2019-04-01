<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheRequirement
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.dtMonth = New DevExpress.XtraEditors.DateEdit
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.okButton = New DevExpress.XtraEditors.SimpleButton
        Me.lblEndTime = New DevExpress.XtraEditors.LabelControl
        Me.gridTeam = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.canButton = New DevExpress.XtraEditors.SimpleButton
        Me.gridEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.gridEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gridEdit4 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dtEditStart = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dtEditEnd = New DevExpress.XtraEditors.DateEdit
        Me.lblMonth = New DevExpress.XtraEditors.LabelControl
        Me.lblStartTime = New DevExpress.XtraEditors.LabelControl
        Me.cbEdit = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.gridEdit3 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTeam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEditStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEditEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.dtMonth)
        Me.GroupControl1.Controls.Add(Me.txtM_Code)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.okButton)
        Me.GroupControl1.Controls.Add(Me.lblEndTime)
        Me.GroupControl1.Controls.Add(Me.gridTeam)
        Me.GroupControl1.Controls.Add(Me.canButton)
        Me.GroupControl1.Controls.Add(Me.gridEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.gridEdit1)
        Me.GroupControl1.Controls.Add(Me.gridEdit4)
        Me.GroupControl1.Controls.Add(Me.dtEditStart)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.dtEditEnd)
        Me.GroupControl1.Controls.Add(Me.lblMonth)
        Me.GroupControl1.Controls.Add(Me.lblStartTime)
        Me.GroupControl1.Controls.Add(Me.cbEdit)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.gridEdit3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(337, 201)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "篩選"
        '
        'dtMonth
        '
        Me.dtMonth.EditValue = Nothing
        Me.dtMonth.Enabled = False
        Me.dtMonth.Location = New System.Drawing.Point(37, 131)
        Me.dtMonth.Name = "dtMonth"
        Me.dtMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtMonth.Properties.DisplayFormat.FormatString = "yyyy-MM"
        Me.dtMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtMonth.Properties.EditFormat.FormatString = "yyyy-MM"
        Me.dtMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtMonth.Properties.Mask.EditMask = "yyyy-MM"
        Me.dtMonth.Size = New System.Drawing.Size(126, 21)
        Me.dtMonth.TabIndex = 19
        '
        'txtM_Code
        '
        Me.txtM_Code.Enabled = False
        Me.txtM_Code.Location = New System.Drawing.Point(37, 50)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Size = New System.Drawing.Size(126, 21)
        Me.txtM_Code.TabIndex = 18
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Location = New System.Drawing.Point(8, 52)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "編碼:"
        '
        'okButton
        '
        Me.okButton.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Appearance.Options.UseFont = True
        Me.okButton.Location = New System.Drawing.Point(198, 162)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(52, 26)
        Me.okButton.TabIndex = 7
        Me.okButton.Text = "確定"
        '
        'lblEndTime
        '
        Me.lblEndTime.Location = New System.Drawing.Point(173, 107)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(28, 14)
        Me.lblEndTime.TabIndex = 16
        Me.lblEndTime.Text = "截止:"
        '
        'gridTeam
        '
        Me.gridTeam.Enabled = False
        Me.gridTeam.Location = New System.Drawing.Point(204, 132)
        Me.gridTeam.Name = "gridTeam"
        Me.gridTeam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridTeam.Properties.NullText = ""
        Me.gridTeam.Properties.View = Me.GridView4
        Me.gridTeam.Size = New System.Drawing.Size(125, 21)
        Me.gridTeam.TabIndex = 2
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.G_NO, Me.G_Name})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'canButton
        '
        Me.canButton.Location = New System.Drawing.Point(267, 163)
        Me.canButton.Name = "canButton"
        Me.canButton.Size = New System.Drawing.Size(52, 26)
        Me.canButton.TabIndex = 8
        Me.canButton.Text = "取消"
        '
        'gridEdit2
        '
        Me.gridEdit2.Enabled = False
        Me.gridEdit2.Location = New System.Drawing.Point(37, 158)
        Me.gridEdit2.Name = "gridEdit2"
        Me.gridEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridEdit2.Properties.NullText = ""
        Me.gridEdit2.Properties.View = Me.GridView3
        Me.gridEdit2.Size = New System.Drawing.Size(126, 21)
        Me.gridEdit2.TabIndex = 0
        Me.gridEdit2.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Per_ID, Me.Per_Name})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Location = New System.Drawing.Point(175, 135)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "組別:"
        '
        'gridEdit1
        '
        Me.gridEdit1.Enabled = False
        Me.gridEdit1.Location = New System.Drawing.Point(37, 23)
        Me.gridEdit1.Name = "gridEdit1"
        Me.gridEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridEdit1.Properties.NullText = ""
        Me.gridEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.gridEdit1.Size = New System.Drawing.Size(126, 21)
        Me.gridEdit1.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WH_Name, Me.WH_ID})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gridEdit4
        '
        Me.gridEdit4.Enabled = False
        Me.gridEdit4.Location = New System.Drawing.Point(37, 77)
        Me.gridEdit4.Name = "gridEdit4"
        Me.gridEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridEdit4.Properties.NullText = ""
        Me.gridEdit4.Properties.View = Me.GridView2
        Me.gridEdit4.Size = New System.Drawing.Size(293, 21)
        Me.gridEdit4.TabIndex = 2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Gauge})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'dtEditStart
        '
        Me.dtEditStart.EditValue = Nothing
        Me.dtEditStart.Enabled = False
        Me.dtEditStart.Location = New System.Drawing.Point(37, 104)
        Me.dtEditStart.Name = "dtEditStart"
        Me.dtEditStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEditStart.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dtEditStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEditStart.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.dtEditStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEditStart.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dtEditStart.Size = New System.Drawing.Size(126, 21)
        Me.dtEditStart.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(174, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "名稱:"
        '
        'dtEditEnd
        '
        Me.dtEditEnd.EditValue = Nothing
        Me.dtEditEnd.Enabled = False
        Me.dtEditEnd.Location = New System.Drawing.Point(204, 104)
        Me.dtEditEnd.Name = "dtEditEnd"
        Me.dtEditEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEditEnd.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dtEditEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEditEnd.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.dtEditEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEditEnd.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.dtEditEnd.Size = New System.Drawing.Size(126, 21)
        Me.dtEditEnd.TabIndex = 5
        '
        'lblMonth
        '
        Me.lblMonth.Location = New System.Drawing.Point(6, 135)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(28, 14)
        Me.lblMonth.TabIndex = 11
        Me.lblMonth.Text = "月份:"
        '
        'lblStartTime
        '
        Me.lblStartTime.Location = New System.Drawing.Point(7, 107)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(28, 14)
        Me.lblStartTime.TabIndex = 11
        Me.lblStartTime.Text = "起始:"
        '
        'cbEdit
        '
        Me.cbEdit.Enabled = False
        Me.cbEdit.Location = New System.Drawing.Point(204, 24)
        Me.cbEdit.Name = "cbEdit"
        Me.cbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEdit.Properties.Items.AddRange(New Object() {"新刀", "待處理", "所有刀具", "待處理換新"})
        Me.cbEdit.Size = New System.Drawing.Size(126, 21)
        Me.cbEdit.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(174, 27)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "類型:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "倉庫:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "規格:"
        '
        'gridEdit3
        '
        Me.gridEdit3.Enabled = False
        Me.gridEdit3.Location = New System.Drawing.Point(204, 51)
        Me.gridEdit3.Name = "gridEdit3"
        Me.gridEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridEdit3.Properties.NullText = ""
        Me.gridEdit3.Properties.View = Me.GridView1
        Me.gridEdit3.Size = New System.Drawing.Size(126, 21)
        Me.gridEdit3.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Name})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 161)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "工號:"
        Me.LabelControl2.Visible = False
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
        'Per_ID
        '
        Me.Per_ID.Caption = "工號"
        Me.Per_ID.FieldName = "Per_ID"
        Me.Per_ID.Name = "Per_ID"
        Me.Per_ID.Visible = True
        Me.Per_ID.VisibleIndex = 0
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "名字"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "名稱"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 0
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "代號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 1
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 0
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 0
        '
        'frmTheRequirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 201)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheRequirement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "列印條件"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTeam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEditStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEditEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtMonth As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents okButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEndTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridTeam As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents canButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Per_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridEdit4 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtEditStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtEditEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMonth As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStartTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
