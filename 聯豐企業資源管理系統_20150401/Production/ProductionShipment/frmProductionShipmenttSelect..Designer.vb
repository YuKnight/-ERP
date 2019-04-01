<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionShipmenttSelect
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckEditc = New DevExpress.XtraEditors.CheckEdit
        Me.GridLookUpEditc = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComboBoxEditD = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CheckEditD = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEditB = New DevExpress.XtraEditors.CheckEdit
        Me.PM_M_CodeB = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComboBoxEditE = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GridLookUpEditF = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DateEditE = New DevExpress.XtraEditors.DateEdit
        Me.ComboBoxEditG = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TextEditA = New DevExpress.XtraEditors.TextEdit
        Me.CheckEditG = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEditF = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEditE = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEditA = New DevExpress.XtraEditors.CheckEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PM_M_CodeB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "查詢"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 34)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'CheckEditc
        '
        Me.CheckEditc.Location = New System.Drawing.Point(3, 120)
        Me.CheckEditc.Name = "CheckEditc"
        Me.CheckEditc.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditc.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditc.Properties.Appearance.Options.UseFont = True
        Me.CheckEditc.Properties.Caption = "名  稱"
        Me.CheckEditc.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditc.TabIndex = 61
        '
        'GridLookUpEditc
        '
        Me.GridLookUpEditc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLookUpEditc.EditValue = ""
        Me.GridLookUpEditc.Location = New System.Drawing.Point(117, 119)
        Me.GridLookUpEditc.Margin = New System.Windows.Forms.Padding(6)
        Me.GridLookUpEditc.Name = "GridLookUpEditc"
        Me.GridLookUpEditc.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpEditc.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEditc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEditc.Properties.NullText = ""
        Me.GridLookUpEditc.Properties.View = Me.GridView1
        Me.GridLookUpEditc.Size = New System.Drawing.Size(191, 24)
        Me.GridLookUpEditc.TabIndex = 60
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'ComboBoxEditD
        '
        Me.ComboBoxEditD.Location = New System.Drawing.Point(117, 153)
        Me.ComboBoxEditD.Name = "ComboBoxEditD"
        Me.ComboBoxEditD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditD.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditD.Properties.Items.AddRange(New Object() {"正常", "返修"})
        Me.ComboBoxEditD.Size = New System.Drawing.Size(191, 22)
        Me.ComboBoxEditD.TabIndex = 59
        '
        'CheckEditD
        '
        Me.CheckEditD.Location = New System.Drawing.Point(3, 152)
        Me.CheckEditD.Name = "CheckEditD"
        Me.CheckEditD.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditD.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditD.Properties.Appearance.Options.UseFont = True
        Me.CheckEditD.Properties.Caption = "出貨類型"
        Me.CheckEditD.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditD.TabIndex = 58
        '
        'CheckEditB
        '
        Me.CheckEditB.Location = New System.Drawing.Point(3, 84)
        Me.CheckEditB.Name = "CheckEditB"
        Me.CheckEditB.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditB.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditB.Properties.Appearance.Options.UseFont = True
        Me.CheckEditB.Properties.Caption = "產品編號 "
        Me.CheckEditB.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditB.TabIndex = 57
        '
        'PM_M_CodeB
        '
        Me.PM_M_CodeB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PM_M_CodeB.EditValue = ""
        Me.PM_M_CodeB.Location = New System.Drawing.Point(117, 83)
        Me.PM_M_CodeB.Margin = New System.Windows.Forms.Padding(6)
        Me.PM_M_CodeB.Name = "PM_M_CodeB"
        Me.PM_M_CodeB.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PM_M_CodeB.Properties.Appearance.Options.UseFont = True
        Me.PM_M_CodeB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PM_M_CodeB.Properties.NullText = ""
        Me.PM_M_CodeB.Properties.View = Me.GridView3
        Me.PM_M_CodeB.Size = New System.Drawing.Size(191, 24)
        Me.PM_M_CodeB.TabIndex = 56
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'ComboBoxEditE
        '
        Me.ComboBoxEditE.Location = New System.Drawing.Point(117, 189)
        Me.ComboBoxEditE.Name = "ComboBoxEditE"
        Me.ComboBoxEditE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditE.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditE.Properties.Items.AddRange(New Object() {"=", ">=", "<=", ">", "<"})
        Me.ComboBoxEditE.Size = New System.Drawing.Size(69, 22)
        Me.ComboBoxEditE.TabIndex = 55
        '
        'GridLookUpEditF
        '
        Me.GridLookUpEditF.EditValue = ""
        Me.GridLookUpEditF.Location = New System.Drawing.Point(117, 224)
        Me.GridLookUpEditF.Name = "GridLookUpEditF"
        Me.GridLookUpEditF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLookUpEditF.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEditF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEditF.Properties.NullText = ""
        Me.GridLookUpEditF.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEditF.Size = New System.Drawing.Size(191, 22)
        Me.GridLookUpEditF.TabIndex = 54
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'DateEditE
        '
        Me.DateEditE.EditValue = Nothing
        Me.DateEditE.Location = New System.Drawing.Point(187, 188)
        Me.DateEditE.Name = "DateEditE"
        Me.DateEditE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditE.Properties.Appearance.Options.UseFont = True
        Me.DateEditE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditE.Size = New System.Drawing.Size(121, 22)
        Me.DateEditE.TabIndex = 53
        '
        'ComboBoxEditG
        '
        Me.ComboBoxEditG.Location = New System.Drawing.Point(117, 257)
        Me.ComboBoxEditG.Name = "ComboBoxEditG"
        Me.ComboBoxEditG.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditG.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditG.Properties.Items.AddRange(New Object() {"已審核", "未審核"})
        Me.ComboBoxEditG.Size = New System.Drawing.Size(191, 22)
        Me.ComboBoxEditG.TabIndex = 52
        '
        'TextEditA
        '
        Me.TextEditA.Location = New System.Drawing.Point(117, 52)
        Me.TextEditA.Name = "TextEditA"
        Me.TextEditA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditA.Properties.Appearance.Options.UseFont = True
        Me.TextEditA.Size = New System.Drawing.Size(191, 22)
        Me.TextEditA.TabIndex = 51
        '
        'CheckEditG
        '
        Me.CheckEditG.Location = New System.Drawing.Point(3, 258)
        Me.CheckEditG.Name = "CheckEditG"
        Me.CheckEditG.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditG.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditG.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditG.Properties.Appearance.Options.UseFont = True
        Me.CheckEditG.Properties.Caption = "審核"
        Me.CheckEditG.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditG.TabIndex = 50
        '
        'CheckEditF
        '
        Me.CheckEditF.Location = New System.Drawing.Point(3, 225)
        Me.CheckEditF.Name = "CheckEditF"
        Me.CheckEditF.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditF.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditF.Properties.Appearance.Options.UseFont = True
        Me.CheckEditF.Properties.Caption = "操作員"
        Me.CheckEditF.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditF.TabIndex = 49
        '
        'CheckEditE
        '
        Me.CheckEditE.Location = New System.Drawing.Point(3, 188)
        Me.CheckEditE.Name = "CheckEditE"
        Me.CheckEditE.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditE.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditE.Properties.Appearance.Options.UseFont = True
        Me.CheckEditE.Properties.Caption = "送貨日期"
        Me.CheckEditE.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditE.TabIndex = 48
        '
        'CheckEditA
        '
        Me.CheckEditA.Location = New System.Drawing.Point(3, 52)
        Me.CheckEditA.Name = "CheckEditA"
        Me.CheckEditA.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CheckEditA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditA.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEditA.Properties.Appearance.Options.UseFont = True
        Me.CheckEditA.Properties.Caption = "送貨單號"
        Me.CheckEditA.Size = New System.Drawing.Size(92, 21)
        Me.CheckEditA.TabIndex = 47
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(187, 301)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 30)
        Me.cmdExit.TabIndex = 46
        Me.cmdExit.Text = "取消"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(46, 301)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 30)
        Me.cmdSave.TabIndex = 45
        Me.cmdSave.Text = "確定"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "名稱"
        Me.GridColumn4.FieldName = "PS_M_Name"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "產品編號"
        Me.GridColumn3.FieldName = "PM_M_Code"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "工號"
        Me.GridColumn1.FieldName = "U_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "姓名"
        Me.GridColumn2.FieldName = "U_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'frmProductionShipmenttSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 344)
        Me.Controls.Add(Me.CheckEditc)
        Me.Controls.Add(Me.GridLookUpEditc)
        Me.Controls.Add(Me.ComboBoxEditD)
        Me.Controls.Add(Me.CheckEditD)
        Me.Controls.Add(Me.CheckEditB)
        Me.Controls.Add(Me.PM_M_CodeB)
        Me.Controls.Add(Me.ComboBoxEditE)
        Me.Controls.Add(Me.GridLookUpEditF)
        Me.Controls.Add(Me.DateEditE)
        Me.Controls.Add(Me.ComboBoxEditG)
        Me.Controls.Add(Me.TextEditA)
        Me.Controls.Add(Me.CheckEditG)
        Me.Controls.Add(Me.CheckEditF)
        Me.Controls.Add(Me.CheckEditE)
        Me.Controls.Add(Me.CheckEditA)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "frmProductionShipmenttSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "送貨單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PM_M_CodeB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckEditc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridLookUpEditc As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEditD As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEditD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PM_M_CodeB As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEditE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridLookUpEditF As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEditE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComboBoxEditG As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEditA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEditG As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
