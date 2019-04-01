<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayWGAdjustMain
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
        Me.IN_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OUT_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IN_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OUT_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OUT_G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IN_G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OUT_DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ad_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IN_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ad_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Amount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ad_YYMM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserIDName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IN_FacName
        '
        Me.IN_FacName.Caption = "轉入廠別"
        Me.IN_FacName.FieldName = "IN_FacName"
        Me.IN_FacName.Name = "IN_FacName"
        Me.IN_FacName.OptionsColumn.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(828, 34)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'OUT_G_Name
        '
        Me.OUT_G_Name.Caption = "轉出組別"
        Me.OUT_G_Name.FieldName = "OUT_G_Name"
        Me.OUT_G_Name.Name = "OUT_G_Name"
        Me.OUT_G_Name.OptionsColumn.ReadOnly = True
        Me.OUT_G_Name.Visible = True
        Me.OUT_G_Name.VisibleIndex = 2
        '
        'IN_DepName
        '
        Me.IN_DepName.Caption = "轉入部門"
        Me.IN_DepName.FieldName = "IN_DepName"
        Me.IN_DepName.Name = "IN_DepName"
        Me.IN_DepName.OptionsColumn.ReadOnly = True
        Me.IN_DepName.Visible = True
        Me.IN_DepName.VisibleIndex = 6
        '
        'OUT_FacName
        '
        Me.OUT_FacName.Caption = "轉出廠別"
        Me.OUT_FacName.FieldName = "OUT_FacName"
        Me.OUT_FacName.Name = "OUT_FacName"
        Me.OUT_FacName.OptionsColumn.ReadOnly = True
        '
        'OUT_G_NO
        '
        Me.OUT_G_NO.Caption = "轉出組別編號"
        Me.OUT_G_NO.FieldName = "OUT_G_NO"
        Me.OUT_G_NO.Name = "OUT_G_NO"
        Me.OUT_G_NO.OptionsColumn.ReadOnly = True
        Me.OUT_G_NO.Visible = True
        Me.OUT_G_NO.VisibleIndex = 1
        Me.OUT_G_NO.Width = 100
        '
        'IN_G_NO
        '
        Me.IN_G_NO.Caption = "轉入組別編號"
        Me.IN_G_NO.FieldName = "IN_G_NO"
        Me.IN_G_NO.Name = "IN_G_NO"
        Me.IN_G_NO.OptionsColumn.ReadOnly = True
        Me.IN_G_NO.Visible = True
        Me.IN_G_NO.VisibleIndex = 4
        Me.IN_G_NO.Width = 100
        '
        'OUT_DepName
        '
        Me.OUT_DepName.Caption = "轉出部門"
        Me.OUT_DepName.FieldName = "OUT_DepName"
        Me.OUT_DepName.Name = "OUT_DepName"
        Me.OUT_DepName.OptionsColumn.ReadOnly = True
        Me.OUT_DepName.Visible = True
        Me.OUT_DepName.VisibleIndex = 3
        '
        'Ad_CheckDate
        '
        Me.Ad_CheckDate.Caption = "審核時間"
        Me.Ad_CheckDate.FieldName = "Ad_CheckDate"
        Me.Ad_CheckDate.Name = "Ad_CheckDate"
        Me.Ad_CheckDate.OptionsColumn.ReadOnly = True
        Me.Ad_CheckDate.Visible = True
        Me.Ad_CheckDate.VisibleIndex = 11
        Me.Ad_CheckDate.Width = 85
        '
        'IN_G_Name
        '
        Me.IN_G_Name.Caption = "轉入組別"
        Me.IN_G_Name.FieldName = "IN_G_Name"
        Me.IN_G_Name.Name = "IN_G_Name"
        Me.IN_G_Name.OptionsColumn.ReadOnly = True
        Me.IN_G_Name.Visible = True
        Me.IN_G_Name.VisibleIndex = 5
        '
        'Ad_Check
        '
        Me.Ad_Check.Caption = "審核"
        Me.Ad_Check.FieldName = "Ad_Check"
        Me.Ad_Check.Name = "Ad_Check"
        Me.Ad_Check.OptionsColumn.ReadOnly = True
        Me.Ad_Check.Visible = True
        Me.Ad_Check.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Amount
        '
        Me.Amount.Caption = "金額"
        Me.Amount.FieldName = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.OptionsColumn.ReadOnly = True
        Me.Amount.Visible = True
        Me.Amount.VisibleIndex = 7
        '
        'AddDate
        '
        Me.AddDate.Caption = "操作時間"
        Me.AddDate.FieldName = "AddDate"
        Me.AddDate.Name = "AddDate"
        Me.AddDate.OptionsColumn.ReadOnly = True
        Me.AddDate.Visible = True
        Me.AddDate.VisibleIndex = 9
        Me.AddDate.Width = 85
        '
        'Ad_YYMM
        '
        Me.Ad_YYMM.Caption = "調整月份"
        Me.Ad_YYMM.FieldName = "Ad_YYMM"
        Me.Ad_YYMM.Name = "Ad_YYMM"
        Me.Ad_YYMM.OptionsColumn.ReadOnly = True
        Me.Ad_YYMM.Visible = True
        Me.Ad_YYMM.VisibleIndex = 0
        '
        'AddUserIDName
        '
        Me.AddUserIDName.Caption = "操作員"
        Me.AddUserIDName.FieldName = "AddUserIDName"
        Me.AddUserIDName.Name = "AddUserIDName"
        Me.AddUserIDName.OptionsColumn.ReadOnly = True
        Me.AddUserIDName.Visible = True
        Me.AddUserIDName.VisibleIndex = 8
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(162, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(162, 22)
        Me.cmdAdd.Text = "新增(&A)..."
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(162, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdCheck, Me.ToolStripSeparator5, Me.cmdRef, Me.ToolStripSeparator6, Me.cmdView, Me.cmdQuery})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(163, 176)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(162, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(162, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(162, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(162, 22)
        Me.cmdQuery.Text = "查詢(&F)..."
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 37)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.Grid.Size = New System.Drawing.Size(828, 393)
        Me.Grid.TabIndex = 11
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Ad_YYMM, Me.OUT_FacName, Me.OUT_DepName, Me.OUT_G_NO, Me.OUT_G_Name, Me.IN_FacName, Me.IN_DepName, Me.IN_G_NO, Me.IN_G_Name, Me.Amount, Me.AddUserIDName, Me.AddDate, Me.Ad_Check, Me.Ad_CheckDate})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "組別薪金調整"
        '
        'frmProductionPiecePayWGAdjustMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 432)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionPiecePayWGAdjustMain"
        Me.Text = "組別薪金調整"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IN_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OUT_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IN_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OUT_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OUT_G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IN_G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OUT_DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ad_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IN_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ad_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ad_YYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUserIDName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
