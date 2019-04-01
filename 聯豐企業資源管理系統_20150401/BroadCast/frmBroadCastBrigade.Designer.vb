<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadCastBrigade
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
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem
        Me.gridBroadCastBrigade = New DevExpress.XtraGrid.GridControl
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.M_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Message = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.RepositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemImageEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemImageEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBroadCastBrigade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 36)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NavBarControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridBroadCastBrigade)
        Me.SplitContainer1.Size = New System.Drawing.Size(617, 466)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 38
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.Size = New System.Drawing.Size(73, 466)
        Me.NavBarControl1.TabIndex = 1
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = ""
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "刷新數據"
        Me.NavBarItem1.LargeImage = Global.LFERP.My.Resources.Resources.SmartArtChangeColorsGallery
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "發送信息"
        Me.NavBarItem2.LargeImage = Global.LFERP.My.Resources.Resources.SharingOpenMailFolder
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'gridBroadCastBrigade
        '
        Me.gridBroadCastBrigade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridBroadCastBrigade.EmbeddedNavigator.Name = ""
        Me.gridBroadCastBrigade.Location = New System.Drawing.Point(0, 0)
        Me.gridBroadCastBrigade.MainView = Me.gridView1
        Me.gridBroadCastBrigade.Name = "gridBroadCastBrigade"
        Me.gridBroadCastBrigade.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemImageEdit1, Me.RepositoryItemImageComboBox4, Me.RepositoryItemSpinEdit1, Me.RepositoryItemPictureEdit1, Me.RepositoryItemPictureEdit2, Me.RepositoryItemImageEdit2, Me.RepositoryItemPictureEdit3, Me.RepositoryItemImageEdit3, Me.RepositoryItemPictureEdit4})
        Me.gridBroadCastBrigade.Size = New System.Drawing.Size(540, 466)
        Me.gridBroadCastBrigade.TabIndex = 39
        Me.gridBroadCastBrigade.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.M_Type, Me.M_Date, Me.M_Time, Me.M_Out, Me.M_Message, Me.AutoID, Me.M_Status})
        Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 421, 208, 175)
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "0"
        Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gridView1.GridControl = Me.gridBroadCastBrigade
        Me.gridView1.GroupFormat = ""
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView1.OptionsBehavior.Editable = False
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowFilter = False
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.OptionsView.ShowIndicator = False
        Me.gridView1.OptionsView.ShowVertLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemPictureEdit4
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.MinWidth = 15
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 15
        '
        'RepositoryItemPictureEdit4
        '
        Me.RepositoryItemPictureEdit4.Name = "RepositoryItemPictureEdit4"
        '
        'M_Type
        '
        Me.M_Type.Caption = "状态"
        Me.M_Type.FieldName = "M_Type"
        Me.M_Type.Name = "M_Type"
        Me.M_Type.Visible = True
        Me.M_Type.VisibleIndex = 1
        Me.M_Type.Width = 25
        '
        'M_Date
        '
        Me.M_Date.Caption = "發送日期"
        Me.M_Date.FieldName = "M_Date"
        Me.M_Date.Name = "M_Date"
        Me.M_Date.Visible = True
        Me.M_Date.VisibleIndex = 2
        Me.M_Date.Width = 52
        '
        'M_Time
        '
        Me.M_Time.Caption = "發送时间"
        Me.M_Time.FieldName = "M_Time"
        Me.M_Time.Name = "M_Time"
        Me.M_Time.Visible = True
        Me.M_Time.VisibleIndex = 3
        Me.M_Time.Width = 43
        '
        'M_Out
        '
        Me.M_Out.Caption = "发送人"
        Me.M_Out.FieldName = "M_Out"
        Me.M_Out.Name = "M_Out"
        Me.M_Out.Visible = True
        Me.M_Out.VisibleIndex = 4
        Me.M_Out.Width = 35
        '
        'M_Message
        '
        Me.M_Message.Caption = "消息內容"
        Me.M_Message.FieldName = "M_Message"
        Me.M_Message.Name = "M_Message"
        Me.M_Message.Visible = True
        Me.M_Message.VisibleIndex = 5
        Me.M_Message.Width = 400
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'M_Status
        '
        Me.M_Status.Caption = "M_Status"
        Me.M_Status.FieldName = "M_Status"
        Me.M_Status.Name = "M_Status"
        '
        'repositoryItemDateEdit1
        '
        Me.repositoryItemDateEdit1.AutoHeight = False
        Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "g"
        Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repositoryItemDateEdit1.Mask.EditMask = "g"
        Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
        '
        'repositoryItemImageComboBox1
        '
        Me.repositoryItemImageComboBox1.AutoHeight = False
        Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", "0", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", "1", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", "2", 1)})
        Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
        '
        'repositoryItemImageComboBox2
        '
        Me.repositoryItemImageComboBox2.AutoHeight = False
        Me.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", "0", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", "1", 2)})
        Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
        '
        'repositoryItemImageComboBox3
        '
        Me.repositoryItemImageComboBox3.AutoHeight = False
        Me.repositoryItemImageComboBox3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Attachment", "1", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 1, -1)})
        Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        Me.RepositoryItemImageEdit1.ShowIcon = False
        '
        'RepositoryItemImageComboBox4
        '
        Me.RepositoryItemImageComboBox4.AutoHeight = False
        Me.RepositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox4.Name = "RepositoryItemImageComboBox4"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'RepositoryItemImageEdit2
        '
        Me.RepositoryItemImageEdit2.AutoHeight = False
        Me.RepositoryItemImageEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit2.Name = "RepositoryItemImageEdit2"
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'RepositoryItemImageEdit3
        '
        Me.RepositoryItemImageEdit3.AutoHeight = False
        Me.RepositoryItemImageEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit3.Name = "RepositoryItemImageEdit3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "廣播系統"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'frmBroadCastBrigade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmBroadCastBrigade"
        Me.Text = "廣播系統"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBroadCastBrigade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents gridBroadCastBrigade As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents M_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Message As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RepositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemImageEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemImageEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents M_Status As DevExpress.XtraGrid.Columns.GridColumn
End Class
