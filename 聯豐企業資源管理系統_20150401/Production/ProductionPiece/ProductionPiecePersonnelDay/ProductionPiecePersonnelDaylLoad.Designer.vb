<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPiecePersonnelDaylLoad
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
        Me.cmdSelALL = New DevExpress.XtraEditors.SimpleButton
        Me.cmdQselectALL = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.LabFac = New System.Windows.Forms.Label
        Me.LabDepID = New System.Windows.Forms.Label
        Me.xteatab = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.cmdLoadB = New DevExpress.XtraEditors.SimpleButton
        Me.GluG_NOB = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GluG_NOD = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabG_NO = New System.Windows.Forms.Label
        Me.Per_DateEdit = New DevExpress.XtraEditors.DateEdit
        Me.cmdLoadD = New DevExpress.XtraEditors.SimpleButton
        Me.txtPer_DateEdit = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GoIn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.xteatab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xteatab.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GluG_NOB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GluG_NOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Per_DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSelALL
        '
        Me.cmdSelALL.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelALL.Appearance.Options.UseFont = True
        Me.cmdSelALL.Location = New System.Drawing.Point(7, 439)
        Me.cmdSelALL.Name = "cmdSelALL"
        Me.cmdSelALL.Size = New System.Drawing.Size(100, 28)
        Me.cmdSelALL.TabIndex = 280
        Me.cmdSelALL.Text = "全選(&A)"
        '
        'cmdQselectALL
        '
        Me.cmdQselectALL.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQselectALL.Appearance.Options.UseFont = True
        Me.cmdQselectALL.Location = New System.Drawing.Point(115, 439)
        Me.cmdQselectALL.Name = "cmdQselectALL"
        Me.cmdQselectALL.Size = New System.Drawing.Size(100, 28)
        Me.cmdQselectALL.TabIndex = 281
        Me.cmdQselectALL.Text = "取消全選(&Q)"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(497, 439)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 283
        Me.cmdExit.Text = "退出(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(401, 439)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 282
        Me.cmdSave.Text = "確認(&S)"
        '
        'LabFac
        '
        Me.LabFac.AutoSize = True
        Me.LabFac.Location = New System.Drawing.Point(176, 13)
        Me.LabFac.Name = "LabFac"
        Me.LabFac.Size = New System.Drawing.Size(39, 12)
        Me.LabFac.TabIndex = 294
        Me.LabFac.Text = "LabFac"
        Me.LabFac.Visible = False
        '
        'LabDepID
        '
        Me.LabDepID.AutoSize = True
        Me.LabDepID.Location = New System.Drawing.Point(221, 13)
        Me.LabDepID.Name = "LabDepID"
        Me.LabDepID.Size = New System.Drawing.Size(54, 12)
        Me.LabDepID.TabIndex = 295
        Me.LabDepID.Text = "LabDepID"
        Me.LabDepID.Visible = False
        '
        'xteatab
        '
        Me.xteatab.Location = New System.Drawing.Point(4, 44)
        Me.xteatab.Name = "xteatab"
        Me.xteatab.SelectedTabPage = Me.XtraTabPage1
        Me.xteatab.Size = New System.Drawing.Size(587, 114)
        Me.xteatab.TabIndex = 296
        Me.xteatab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.cmdLoadB)
        Me.XtraTabPage1.Controls.Add(Me.GluG_NOB)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(578, 82)
        Me.XtraTabPage1.Text = "初使名單導入"
        '
        'cmdLoadB
        '
        Me.cmdLoadB.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadB.Appearance.Options.UseFont = True
        Me.cmdLoadB.Location = New System.Drawing.Point(495, 10)
        Me.cmdLoadB.Name = "cmdLoadB"
        Me.cmdLoadB.Size = New System.Drawing.Size(80, 28)
        Me.cmdLoadB.TabIndex = 301
        Me.cmdLoadB.Text = "載入(&L)"
        '
        'GluG_NOB
        '
        Me.GluG_NOB.EditValue = ""
        Me.GluG_NOB.Location = New System.Drawing.Point(100, 10)
        Me.GluG_NOB.Name = "GluG_NOB"
        Me.GluG_NOB.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluG_NOB.Properties.Appearance.Options.UseFont = True
        Me.GluG_NOB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluG_NOB.Properties.NullText = ""
        Me.GluG_NOB.Properties.View = Me.GridView1
        Me.GluG_NOB.Size = New System.Drawing.Size(393, 24)
        Me.GluG_NOB.TabIndex = 300
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "組別編號"
        Me.GridColumn1.FieldName = "G_NO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "組別名稱"
        Me.GridColumn2.FieldName = "G_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "組別名稱(&B):"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GluG_NOD)
        Me.XtraTabPage2.Controls.Add(Me.LabG_NO)
        Me.XtraTabPage2.Controls.Add(Me.Per_DateEdit)
        Me.XtraTabPage2.Controls.Add(Me.cmdLoadD)
        Me.XtraTabPage2.Controls.Add(Me.txtPer_DateEdit)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(578, 82)
        Me.XtraTabPage2.Text = "指定日期導入"
        '
        'GluG_NOD
        '
        Me.GluG_NOD.EditValue = ""
        Me.GluG_NOD.Location = New System.Drawing.Point(100, 10)
        Me.GluG_NOD.Name = "GluG_NOD"
        Me.GluG_NOD.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GluG_NOD.Properties.Appearance.Options.UseFont = True
        Me.GluG_NOD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GluG_NOD.Properties.NullText = ""
        Me.GluG_NOD.Properties.View = Me.GridView3
        Me.GluG_NOD.Size = New System.Drawing.Size(393, 24)
        Me.GluG_NOD.TabIndex = 298
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "組別編號"
        Me.GridColumn3.FieldName = "G_NO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "組別名稱"
        Me.GridColumn4.FieldName = "G_Name"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'LabG_NO
        '
        Me.LabG_NO.AutoSize = True
        Me.LabG_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabG_NO.Location = New System.Drawing.Point(1, 14)
        Me.LabG_NO.Name = "LabG_NO"
        Me.LabG_NO.Size = New System.Drawing.Size(90, 15)
        Me.LabG_NO.TabIndex = 297
        Me.LabG_NO.Text = "組別名稱(&B):"
        '
        'Per_DateEdit
        '
        Me.Per_DateEdit.EditValue = Nothing
        Me.Per_DateEdit.Location = New System.Drawing.Point(101, 45)
        Me.Per_DateEdit.Name = "Per_DateEdit"
        Me.Per_DateEdit.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Per_DateEdit.Properties.Appearance.Options.UseFont = True
        Me.Per_DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Per_DateEdit.Size = New System.Drawing.Size(393, 24)
        Me.Per_DateEdit.TabIndex = 296
        '
        'cmdLoadD
        '
        Me.cmdLoadD.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadD.Appearance.Options.UseFont = True
        Me.cmdLoadD.Location = New System.Drawing.Point(495, 10)
        Me.cmdLoadD.Name = "cmdLoadD"
        Me.cmdLoadD.Size = New System.Drawing.Size(80, 28)
        Me.cmdLoadD.TabIndex = 295
        Me.cmdLoadD.Text = "載入(&L)"
        '
        'txtPer_DateEdit
        '
        Me.txtPer_DateEdit.AutoSize = True
        Me.txtPer_DateEdit.BackColor = System.Drawing.Color.Transparent
        Me.txtPer_DateEdit.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPer_DateEdit.ForeColor = System.Drawing.Color.Black
        Me.txtPer_DateEdit.Location = New System.Drawing.Point(2, 48)
        Me.txtPer_DateEdit.Name = "txtPer_DateEdit"
        Me.txtPer_DateEdit.Size = New System.Drawing.Size(91, 15)
        Me.txtPer_DateEdit.TabIndex = 294
        Me.txtPer_DateEdit.Text = "計件日期(&D):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 299
        Me.Label1.Text = "員工名單導入"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(2, 2)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(587, 36)
        Me.PicCaption.TabIndex = 298
        Me.PicCaption.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 158)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(587, 259)
        Me.Grid1.TabIndex = 298
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GoIn, Me.AutoID, Me.Per_NO, Me.Per_Name, Me.Per_Date, Me.Per_ActionName})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GoIn
        '
        Me.GoIn.Caption = "加入"
        Me.GoIn.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GoIn.FieldName = "GoIn"
        Me.GoIn.Name = "GoIn"
        Me.GoIn.Visible = True
        Me.GoIn.VisibleIndex = 0
        Me.GoIn.Width = 68
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.Visible = True
        Me.AutoID.VisibleIndex = 1
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "廠証編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 2
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 3
        Me.Per_Name.Width = 81
        '
        'Per_Date
        '
        Me.Per_Date.Caption = "建立時間"
        Me.Per_Date.FieldName = "Per_Date"
        Me.Per_Date.Name = "Per_Date"
        Me.Per_Date.Visible = True
        Me.Per_Date.VisibleIndex = 4
        Me.Per_Date.Width = 81
        '
        'Per_ActionName
        '
        Me.Per_ActionName.Caption = "操作員"
        Me.Per_ActionName.FieldName = "Per_ActionName"
        Me.Per_ActionName.Name = "Per_ActionName"
        Me.Per_ActionName.Visible = True
        Me.Per_ActionName.VisibleIndex = 5
        Me.Per_ActionName.Width = 92
        '
        'ProductionPiecePersonnelDaylLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(589, 483)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xteatab)
        Me.Controls.Add(Me.LabDepID)
        Me.Controls.Add(Me.LabFac)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdQselectALL)
        Me.Controls.Add(Me.cmdSelALL)
        Me.Controls.Add(Me.PicCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductionPiecePersonnelDaylLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "導入計件人員基本信息"
        CType(Me.xteatab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xteatab.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.GluG_NOB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GluG_NOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Per_DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSelALL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdQselectALL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabFac As System.Windows.Forms.Label
    Friend WithEvents LabDepID As System.Windows.Forms.Label
    Friend WithEvents xteatab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GluG_NOD As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabG_NO As System.Windows.Forms.Label
    Friend WithEvents Per_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdLoadD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPer_DateEdit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GoIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdLoadB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GluG_NOB As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
End Class
