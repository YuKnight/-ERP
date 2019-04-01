<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareChaiControl
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_LCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_SCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Ratio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtM_LCode = New DevExpress.XtraEditors.TextEdit
        Me.txtM_SCode = New DevExpress.XtraEditors.TextEdit
        Me.txtS_Action = New DevExpress.XtraEditors.TextEdit
        Me.cmdSelect = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.cboS_Type = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_LCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_SCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtS_Action.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboS_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(1, 183)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(727, 364)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_ID, Me.M_LCode, Me.M_SCode, Me.S_Type, Me.GridColumn2, Me.GridColumn3, Me.S_Qty, Me.S_Ratio, Me.S_AddDate, Me.S_Action, Me.M_Name, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'S_ID
        '
        Me.S_ID.Caption = "單號"
        Me.S_ID.FieldName = "S_ID"
        Me.S_ID.Name = "S_ID"
        Me.S_ID.OptionsColumn.ReadOnly = True
        Me.S_ID.Visible = True
        Me.S_ID.VisibleIndex = 0
        '
        'M_LCode
        '
        Me.M_LCode.Caption = "主物料"
        Me.M_LCode.FieldName = "M_LCode"
        Me.M_LCode.Name = "M_LCode"
        Me.M_LCode.OptionsColumn.ReadOnly = True
        Me.M_LCode.Visible = True
        Me.M_LCode.VisibleIndex = 1
        Me.M_LCode.Width = 100
        '
        'M_SCode
        '
        Me.M_SCode.Caption = "子物料"
        Me.M_SCode.FieldName = "M_SCode"
        Me.M_SCode.Name = "M_SCode"
        Me.M_SCode.Visible = True
        Me.M_SCode.VisibleIndex = 2
        Me.M_SCode.Width = 100
        '
        'S_Type
        '
        Me.S_Type.Caption = "類型"
        Me.S_Type.FieldName = "S_Type"
        Me.S_Type.Name = "S_Type"
        Me.S_Type.OptionsColumn.ReadOnly = True
        Me.S_Type.Visible = True
        Me.S_Type.VisibleIndex = 4
        Me.S_Type.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "主物料單位"
        Me.GridColumn2.FieldName = "Unit1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 85
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "子物料單位"
        Me.GridColumn3.FieldName = "Unit2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        Me.GridColumn3.Width = 85
        '
        'S_Qty
        '
        Me.S_Qty.Caption = "數量"
        Me.S_Qty.FieldName = "S_Qty"
        Me.S_Qty.Name = "S_Qty"
        Me.S_Qty.OptionsColumn.ReadOnly = True
        Me.S_Qty.Visible = True
        Me.S_Qty.VisibleIndex = 6
        Me.S_Qty.Width = 50
        '
        'S_Ratio
        '
        Me.S_Ratio.Caption = "比例"
        Me.S_Ratio.FieldName = "S_Ratio"
        Me.S_Ratio.Name = "S_Ratio"
        Me.S_Ratio.OptionsColumn.ReadOnly = True
        Me.S_Ratio.Visible = True
        Me.S_Ratio.VisibleIndex = 8
        Me.S_Ratio.Width = 50
        '
        'S_AddDate
        '
        Me.S_AddDate.Caption = "日期"
        Me.S_AddDate.FieldName = "S_AddDate"
        Me.S_AddDate.Name = "S_AddDate"
        Me.S_AddDate.OptionsColumn.ReadOnly = True
        Me.S_AddDate.Visible = True
        Me.S_AddDate.VisibleIndex = 10
        '
        'S_Action
        '
        Me.S_Action.Caption = "操作員"
        Me.S_Action.FieldName = "S_Action"
        Me.S_Action.Name = "S_Action"
        Me.S_Action.OptionsColumn.ReadOnly = True
        Me.S_Action.Visible = True
        Me.S_Action.VisibleIndex = 11
        Me.S_Action.Width = 65
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 70
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "變更數量"
        Me.GridColumn1.FieldName = "S_Qty1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Width = 70
        '
        'txtM_LCode
        '
        Me.txtM_LCode.Location = New System.Drawing.Point(123, 23)
        Me.txtM_LCode.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtM_LCode.Name = "txtM_LCode"
        Me.txtM_LCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_LCode.Properties.Appearance.Options.UseFont = True
        Me.txtM_LCode.Size = New System.Drawing.Size(180, 24)
        Me.txtM_LCode.TabIndex = 1
        '
        'txtM_SCode
        '
        Me.txtM_SCode.Location = New System.Drawing.Point(428, 24)
        Me.txtM_SCode.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtM_SCode.Name = "txtM_SCode"
        Me.txtM_SCode.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_SCode.Properties.Appearance.Options.UseFont = True
        Me.txtM_SCode.Size = New System.Drawing.Size(180, 24)
        Me.txtM_SCode.TabIndex = 3
        '
        'txtS_Action
        '
        Me.txtS_Action.Location = New System.Drawing.Point(123, 95)
        Me.txtS_Action.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtS_Action.Name = "txtS_Action"
        Me.txtS_Action.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS_Action.Properties.Appearance.Options.UseFont = True
        Me.txtS_Action.Size = New System.Drawing.Size(180, 24)
        Me.txtS_Action.TabIndex = 9
        '
        'cmdSelect
        '
        Me.cmdSelect.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelect.Appearance.Options.UseFont = True
        Me.cmdSelect.Location = New System.Drawing.Point(625, 91)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(80, 28)
        Me.cmdSelect.TabIndex = 10
        Me.cmdSelect.Text = "查詢"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 28)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(113, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "主物料編碼(&M)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(320, 28)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "子物料編碼(&S)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(35, 99)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 15)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "操 作 員(&U)："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(28, 62)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "物料名稱(&N)："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(364, 64)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "類型(&T)："
        '
        'txtM_Name
        '
        Me.txtM_Name.Location = New System.Drawing.Point(123, 59)
        Me.txtM_Name.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Size = New System.Drawing.Size(180, 24)
        Me.txtM_Name.TabIndex = 5
        '
        'cboS_Type
        '
        Me.cboS_Type.Location = New System.Drawing.Point(428, 60)
        Me.cboS_Type.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.cboS_Type.Name = "cboS_Type"
        Me.cboS_Type.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_Type.Properties.Appearance.Options.UseFont = True
        Me.cboS_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboS_Type.Properties.Items.AddRange(New Object() {"拆分", "拆合"})
        Me.cboS_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboS_Type.Size = New System.Drawing.Size(180, 24)
        Me.cboS_Type.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtM_SCode)
        Me.GroupBox1.Controls.Add(Me.cboS_Type)
        Me.GroupBox1.Controls.Add(Me.txtM_LCode)
        Me.GroupBox1.Controls.Add(Me.txtM_Name)
        Me.GroupBox1.Controls.Add(Me.txtS_Action)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.cmdSelect)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(3, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(230, 21)
        Me.Label27.TabIndex = 217
        Me.Label27.Text = "物料拆分拆合記錄查詢"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(727, 36)
        Me.PictureBox1.TabIndex = 216
        Me.PictureBox1.TabStop = False
        '
        'frmWareChaiControl
        '
        Me.AcceptButton = Me.cmdSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 547)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmWareChaiControl"
        Me.Text = "物料拆分拆合記錄查詢"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_LCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_SCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtS_Action.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboS_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_LCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_SCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Ratio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtM_LCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtM_SCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtS_Action As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSelect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboS_Type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
