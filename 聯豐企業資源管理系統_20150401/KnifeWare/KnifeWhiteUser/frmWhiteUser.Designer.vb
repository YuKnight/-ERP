<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhiteUser
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddpopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditpopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindpopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshpopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripQuitBit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripQuitBitNO = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.DeletepopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllUpdatepopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WhiteUserpopMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.W_UserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.W_UserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WMax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.W_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QuitBit = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popMenuItem.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "白名單設置"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(844, 36)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(843, 385)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 46
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(103, 385)
        Me.TreeView1.TabIndex = 45
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popMenuItem
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(736, 385)
        Me.Grid1.TabIndex = 169
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popMenuItem
        '
        Me.popMenuItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddpopMenuItem, Me.EditpopMenuItem, Me.FindpopMenuItem, Me.RefreshpopMenuItem, Me.ToolStripSeparator1, Me.ToolStripQuitBit, Me.ToolStripQuitBitNO, Me.ToolStripSeparator, Me.DeletepopMenuItem, Me.AllUpdatepopMenuItem, Me.WhiteUserpopMenuItem})
        Me.popMenuItem.Name = "popMenuItem"
        Me.popMenuItem.Size = New System.Drawing.Size(196, 236)
        '
        'AddpopMenuItem
        '
        Me.AddpopMenuItem.Enabled = False
        Me.AddpopMenuItem.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.AddpopMenuItem.Name = "AddpopMenuItem"
        Me.AddpopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddpopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AddpopMenuItem.Text = "新增(&A)"
        '
        'EditpopMenuItem
        '
        Me.EditpopMenuItem.Enabled = False
        Me.EditpopMenuItem.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.EditpopMenuItem.Name = "EditpopMenuItem"
        Me.EditpopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditpopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EditpopMenuItem.Text = "修改(&E)"
        '
        'FindpopMenuItem
        '
        Me.FindpopMenuItem.Enabled = False
        Me.FindpopMenuItem.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.FindpopMenuItem.Name = "FindpopMenuItem"
        Me.FindpopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindpopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindpopMenuItem.Text = "查詢(&F)"
        '
        'RefreshpopMenuItem
        '
        Me.RefreshpopMenuItem.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.RefreshpopMenuItem.Name = "RefreshpopMenuItem"
        Me.RefreshpopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshpopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RefreshpopMenuItem.Text = "刷新(&R)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'ToolStripQuitBit
        '
        Me.ToolStripQuitBit.Enabled = False
        Me.ToolStripQuitBit.Image = Global.LFERP.My.Resources.Resources.SmartArtPromote
        Me.ToolStripQuitBit.Name = "ToolStripQuitBit"
        Me.ToolStripQuitBit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ToolStripQuitBit.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripQuitBit.Text = "辭工(&M)"
        '
        'ToolStripQuitBitNO
        '
        Me.ToolStripQuitBitNO.Enabled = False
        Me.ToolStripQuitBitNO.Image = Global.LFERP.My.Resources.Resources.SmartArtDemote
        Me.ToolStripQuitBitNO.Name = "ToolStripQuitBitNO"
        Me.ToolStripQuitBitNO.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripQuitBitNO.Text = "辭工還原(&D)"
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        Me.ToolStripSeparator.Size = New System.Drawing.Size(192, 6)
        '
        'DeletepopMenuItem
        '
        Me.DeletepopMenuItem.Enabled = False
        Me.DeletepopMenuItem.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.DeletepopMenuItem.Name = "DeletepopMenuItem"
        Me.DeletepopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeletepopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DeletepopMenuItem.Text = "刪除(&D)"
        '
        'AllUpdatepopMenuItem
        '
        Me.AllUpdatepopMenuItem.Enabled = False
        Me.AllUpdatepopMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.AllUpdatepopMenuItem.Name = "AllUpdatepopMenuItem"
        Me.AllUpdatepopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AllUpdatepopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AllUpdatepopMenuItem.Text = "信息批量更新(&B)"
        '
        'WhiteUserpopMenuItem
        '
        Me.WhiteUserpopMenuItem.Enabled = False
        Me.WhiteUserpopMenuItem.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.WhiteUserpopMenuItem.Name = "WhiteUserpopMenuItem"
        Me.WhiteUserpopMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.WhiteUserpopMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.WhiteUserpopMenuItem.Text = "導出白名單(&U)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.W_UserID, Me.W_UserName, Me.FacName, Me.DepName, Me.WH_Name, Me.WMax, Me.W_Remark, Me.DPT_ID, Me.WH_ID, Me.WType, Me.GNO, Me.AutoID, Me.QuitBit})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'W_UserID
        '
        Me.W_UserID.Caption = "工號"
        Me.W_UserID.FieldName = "W_UserID"
        Me.W_UserID.Name = "W_UserID"
        Me.W_UserID.OptionsColumn.AllowEdit = False
        Me.W_UserID.OptionsColumn.ReadOnly = True
        Me.W_UserID.SummaryItem.DisplayFormat = "合計:{0}人"
        Me.W_UserID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.W_UserID.Visible = True
        Me.W_UserID.VisibleIndex = 0
        '
        'W_UserName
        '
        Me.W_UserName.Caption = "姓名"
        Me.W_UserName.FieldName = "W_UserName"
        Me.W_UserName.Name = "W_UserName"
        Me.W_UserName.OptionsColumn.AllowEdit = False
        Me.W_UserName.Visible = True
        Me.W_UserName.VisibleIndex = 1
        Me.W_UserName.Width = 60
        '
        'FacName
        '
        Me.FacName.Caption = "廠別"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.OptionsColumn.AllowEdit = False
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 2
        '
        'DepName
        '
        Me.DepName.Caption = "部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.OptionsColumn.AllowEdit = False
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 3
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "倉庫名稱"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.OptionsColumn.AllowEdit = False
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 4
        '
        'WMax
        '
        Me.WMax.Caption = "可領上限"
        Me.WMax.FieldName = "WMax"
        Me.WMax.Name = "WMax"
        Me.WMax.OptionsColumn.AllowEdit = False
        Me.WMax.Visible = True
        Me.WMax.VisibleIndex = 5
        Me.WMax.Width = 70
        '
        'W_Remark
        '
        Me.W_Remark.Caption = "備註"
        Me.W_Remark.FieldName = "W_Remark"
        Me.W_Remark.Name = "W_Remark"
        Me.W_Remark.OptionsColumn.AllowEdit = False
        Me.W_Remark.OptionsColumn.ReadOnly = True
        Me.W_Remark.Visible = True
        Me.W_Remark.VisibleIndex = 7
        Me.W_Remark.Width = 100
        '
        'DPT_ID
        '
        Me.DPT_ID.Caption = "部門編號"
        Me.DPT_ID.FieldName = "DPT_ID"
        Me.DPT_ID.Name = "DPT_ID"
        Me.DPT_ID.OptionsColumn.AllowEdit = False
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.OptionsColumn.AllowEdit = False
        '
        'WType
        '
        Me.WType.Caption = "倉庫類型"
        Me.WType.CustomizationCaption = "WType"
        Me.WType.Name = "WType"
        Me.WType.OptionsColumn.AllowEdit = False
        '
        'GNO
        '
        Me.GNO.Caption = "組別"
        Me.GNO.FieldName = "GNO"
        Me.GNO.Name = "GNO"
        Me.GNO.OptionsColumn.AllowEdit = False
        Me.GNO.Visible = True
        Me.GNO.VisibleIndex = 6
        Me.GNO.Width = 85
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'QuitBit
        '
        Me.QuitBit.Caption = "辭工否"
        Me.QuitBit.FieldName = "QuitBit"
        Me.QuitBit.Name = "QuitBit"
        Me.QuitBit.OptionsColumn.ReadOnly = True
        Me.QuitBit.Visible = True
        Me.QuitBit.VisibleIndex = 8
        '
        'frmWhiteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 425)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWhiteUser"
        Me.Text = "白名單設置"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popMenuItem.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents W_UserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents W_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents W_UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popMenuItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddpopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditpopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletepopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindpopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshpopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllUpdatepopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WhiteUserpopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripQuitBit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripQuitBitNO As System.Windows.Forms.ToolStripMenuItem
End Class
