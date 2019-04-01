<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectFile
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_NewNumber = New DevExpress.XtraEditors.TextEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReplace = New DevExpress.XtraEditors.SimpleButton
        Me.GC_ProjectInfo = New DevExpress.XtraGrid.GridControl
        Me.GVW_ProjectInfo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CBX_CheckAll = New System.Windows.Forms.CheckBox
        Me.GC_UserInfo = New DevExpress.XtraGrid.GridControl
        Me.GVW_UserInfo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.IsCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Verold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ver = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtPKID = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pPhoto = New System.Windows.Forms.PictureBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdDelPhoto = New System.Windows.Forms.Button
        Me.cmdOpenPhoto = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NewNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_ProjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVW_ProjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_UserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVW_UserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtPKID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(759, 40)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "自動更新設置"
        '
        'txt_NewNumber
        '
        Me.txt_NewNumber.EditValue = ""
        Me.txt_NewNumber.Location = New System.Drawing.Point(68, 8)
        Me.txt_NewNumber.Name = "txt_NewNumber"
        Me.txt_NewNumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_NewNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NewNumber.Size = New System.Drawing.Size(80, 22)
        Me.txt_NewNumber.TabIndex = 172
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(669, 519)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(76, 28)
        Me.cmdExit.TabIndex = 174
        Me.cmdExit.Text = "退出(&X)"
        '
        'cmdReplace
        '
        Me.cmdReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReplace.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdReplace.Location = New System.Drawing.Point(576, 519)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(76, 28)
        Me.cmdReplace.TabIndex = 173
        Me.cmdReplace.Text = "更新(&U)"
        '
        'GC_ProjectInfo
        '
        Me.GC_ProjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_ProjectInfo.EmbeddedNavigator.Name = ""
        Me.GC_ProjectInfo.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.GC_ProjectInfo.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC_ProjectInfo.Location = New System.Drawing.Point(0, 0)
        Me.GC_ProjectInfo.MainView = Me.GVW_ProjectInfo
        Me.GC_ProjectInfo.Name = "GC_ProjectInfo"
        Me.GC_ProjectInfo.Size = New System.Drawing.Size(267, 469)
        Me.GC_ProjectInfo.TabIndex = 178
        Me.GC_ProjectInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVW_ProjectInfo})
        '
        'GVW_ProjectInfo
        '
        Me.GVW_ProjectInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_Name, Me.PM_ID})
        Me.GVW_ProjectInfo.GridControl = Me.GC_ProjectInfo
        Me.GVW_ProjectInfo.GroupPanelText = "項目編號："
        Me.GVW_ProjectInfo.Name = "GVW_ProjectInfo"
        Me.GVW_ProjectInfo.OptionsCustomization.AllowColumnMoving = False
        Me.GVW_ProjectInfo.OptionsCustomization.AllowFilter = False
        Me.GVW_ProjectInfo.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GVW_ProjectInfo.OptionsFilter.AllowFilterEditor = False
        Me.GVW_ProjectInfo.OptionsFilter.AllowMRUFilterList = False
        Me.GVW_ProjectInfo.OptionsMenu.EnableColumnMenu = False
        Me.GVW_ProjectInfo.OptionsMenu.EnableFooterMenu = False
        Me.GVW_ProjectInfo.OptionsMenu.EnableGroupPanelMenu = False
        Me.GVW_ProjectInfo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVW_ProjectInfo.OptionsView.ColumnAutoWidth = False
        Me.GVW_ProjectInfo.OptionsView.ShowFooter = True
        Me.GVW_ProjectInfo.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.PM_ID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'PM_Name
        '
        Me.PM_Name.Caption = "項目名稱"
        Me.PM_Name.FieldName = "PM_Name"
        Me.PM_Name.Name = "PM_Name"
        Me.PM_Name.OptionsColumn.AllowEdit = False
        Me.PM_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PM_Name.OptionsColumn.ReadOnly = True
        Me.PM_Name.SummaryItem.DisplayFormat = "合計:{0}"
        Me.PM_Name.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.PM_Name.Visible = True
        Me.PM_Name.VisibleIndex = 0
        Me.PM_Name.Width = 107
        '
        'PM_ID
        '
        Me.PM_ID.Caption = "項目編號"
        Me.PM_ID.FieldName = "PM_ID"
        Me.PM_ID.Name = "PM_ID"
        Me.PM_ID.OptionsColumn.AllowEdit = False
        Me.PM_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.PM_ID.OptionsColumn.ReadOnly = True
        Me.PM_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.PM_ID.Visible = True
        Me.PM_ID.VisibleIndex = 1
        Me.PM_ID.Width = 128
        '
        'CBX_CheckAll
        '
        Me.CBX_CheckAll.AutoSize = True
        Me.CBX_CheckAll.Location = New System.Drawing.Point(50, 40)
        Me.CBX_CheckAll.Name = "CBX_CheckAll"
        Me.CBX_CheckAll.Size = New System.Drawing.Size(15, 14)
        Me.CBX_CheckAll.TabIndex = 177
        Me.CBX_CheckAll.UseVisualStyleBackColor = True
        '
        'GC_UserInfo
        '
        Me.GC_UserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_UserInfo.EmbeddedNavigator.Name = ""
        Me.GC_UserInfo.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GC_UserInfo.Location = New System.Drawing.Point(0, 0)
        Me.GC_UserInfo.MainView = Me.GVW_UserInfo
        Me.GC_UserInfo.Name = "GC_UserInfo"
        Me.GC_UserInfo.Size = New System.Drawing.Size(488, 469)
        Me.GC_UserInfo.TabIndex = 166
        Me.GC_UserInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVW_UserInfo})
        '
        'GVW_UserInfo
        '
        Me.GVW_UserInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IsCheck, Me.U_Name, Me.U_ID, Me.Verold, Me.Ver})
        Me.GVW_UserInfo.GridControl = Me.GC_UserInfo
        Me.GVW_UserInfo.GroupPanelText = "新版本號："
        Me.GVW_UserInfo.Name = "GVW_UserInfo"
        Me.GVW_UserInfo.OptionsCustomization.AllowColumnMoving = False
        Me.GVW_UserInfo.OptionsCustomization.AllowFilter = False
        Me.GVW_UserInfo.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GVW_UserInfo.OptionsFilter.AllowFilterEditor = False
        Me.GVW_UserInfo.OptionsFilter.AllowMRUFilterList = False
        Me.GVW_UserInfo.OptionsMenu.EnableColumnMenu = False
        Me.GVW_UserInfo.OptionsMenu.EnableFooterMenu = False
        Me.GVW_UserInfo.OptionsMenu.EnableGroupPanelMenu = False
        Me.GVW_UserInfo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVW_UserInfo.OptionsView.ColumnAutoWidth = False
        Me.GVW_UserInfo.OptionsView.RowAutoHeight = True
        Me.GVW_UserInfo.OptionsView.ShowFooter = True
        Me.GVW_UserInfo.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.U_ID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'IsCheck
        '
        Me.IsCheck.Caption = "全選"
        Me.IsCheck.FieldName = "IsCheck"
        Me.IsCheck.Name = "IsCheck"
        Me.IsCheck.OptionsColumn.AllowMove = False
        Me.IsCheck.OptionsColumn.AllowSize = False
        Me.IsCheck.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.IsCheck.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.IsCheck.Visible = True
        Me.IsCheck.VisibleIndex = 0
        Me.IsCheck.Width = 49
        '
        'U_Name
        '
        Me.U_Name.Caption = "人員姓名"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.OptionsColumn.AllowEdit = False
        Me.U_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.U_Name.OptionsColumn.ReadOnly = True
        Me.U_Name.OptionsFilter.AllowAutoFilter = False
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 4
        '
        'U_ID
        '
        Me.U_ID.Caption = "人員工號"
        Me.U_ID.FieldName = "U_ID"
        Me.U_ID.Name = "U_ID"
        Me.U_ID.OptionsColumn.AllowEdit = False
        Me.U_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.U_ID.OptionsColumn.ReadOnly = True
        Me.U_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.U_ID.SummaryItem.DisplayFormat = "合計:{0}"
        Me.U_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.U_ID.Visible = True
        Me.U_ID.VisibleIndex = 3
        Me.U_ID.Width = 87
        '
        'Verold
        '
        Me.Verold.Caption = "原版本號"
        Me.Verold.FieldName = "Verold"
        Me.Verold.Name = "Verold"
        Me.Verold.OptionsColumn.AllowEdit = False
        Me.Verold.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.Verold.OptionsColumn.ReadOnly = True
        Me.Verold.Visible = True
        Me.Verold.VisibleIndex = 2
        Me.Verold.Width = 77
        '
        'Ver
        '
        Me.Ver.Caption = "新版本號"
        Me.Ver.FieldName = "Ver"
        Me.Ver.Name = "Ver"
        Me.Ver.OptionsColumn.AllowEdit = False
        Me.Ver.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Ver.OptionsColumn.ReadOnly = True
        Me.Ver.Visible = True
        Me.Ver.VisibleIndex = 1
        Me.Ver.Width = 78
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 47)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPKID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GC_ProjectInfo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_NewNumber)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBX_CheckAll)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GC_UserInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(759, 469)
        Me.SplitContainer1.SplitterDistance = 267
        Me.SplitContainer1.TabIndex = 177
        '
        'txtPKID
        '
        Me.txtPKID.Location = New System.Drawing.Point(123, 8)
        Me.txtPKID.Name = "txtPKID"
        Me.txtPKID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPKID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPKID.Properties.Appearance.Options.UseBackColor = True
        Me.txtPKID.Properties.Appearance.Options.UseFont = True
        Me.txtPKID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPKID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPKID.Size = New System.Drawing.Size(131, 22)
        Me.txtPKID.TabIndex = 178
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pPhoto)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 421)
        Me.Panel1.TabIndex = 55
        '
        'pPhoto
        '
        Me.pPhoto.BackColor = System.Drawing.Color.Transparent
        Me.pPhoto.Location = New System.Drawing.Point(0, 0)
        Me.pPhoto.Name = "pPhoto"
        Me.pPhoto.Size = New System.Drawing.Size(558, 330)
        Me.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pPhoto.TabIndex = 0
        Me.pPhoto.TabStop = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(686, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 15)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "註意:"
        '
        'cmdDelPhoto
        '
        Me.cmdDelPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelPhoto.Location = New System.Drawing.Point(113, 432)
        Me.cmdDelPhoto.Name = "cmdDelPhoto"
        Me.cmdDelPhoto.Size = New System.Drawing.Size(87, 29)
        Me.cmdDelPhoto.TabIndex = 31
        Me.cmdDelPhoto.Text = "刪除圖片(&D)"
        Me.cmdDelPhoto.UseVisualStyleBackColor = True
        '
        'cmdOpenPhoto
        '
        Me.cmdOpenPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOpenPhoto.Location = New System.Drawing.Point(3, 432)
        Me.cmdOpenPhoto.Name = "cmdOpenPhoto"
        Me.cmdOpenPhoto.Size = New System.Drawing.Size(87, 29)
        Me.cmdOpenPhoto.TabIndex = 30
        Me.cmdOpenPhoto.Text = "打開圖片(&O)"
        Me.cmdOpenPhoto.UseVisualStyleBackColor = True
        '
        'frmProjectFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(762, 551)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReplace)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProjectFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "自動更新設置(按用戶)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NewNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_ProjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVW_ProjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_UserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVW_UserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtPKID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReplace As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC_UserInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVW_UserInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Verold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CBX_CheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents GC_ProjectInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVW_ProjectInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents pPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdDelPhoto As System.Windows.Forms.Button
    Friend WithEvents cmdOpenPhoto As System.Windows.Forms.Button
    Friend WithEvents txtPKID As DevExpress.XtraEditors.TextEdit
    Public WithEvents txt_NewNumber As DevExpress.XtraEditors.TextEdit
End Class
