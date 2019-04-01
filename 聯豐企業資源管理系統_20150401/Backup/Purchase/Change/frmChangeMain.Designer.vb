<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeMain
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popChange = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popChangeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangePurchaseAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeMsg = New System.Windows.Forms.ToolStripMenuItem
        Me.popMsgView = New System.Windows.Forms.ToolStripMenuItem
        Me.popMsgCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_ChangeNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.C_Reason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popChange.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popChange
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(711, 467)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popChange
        '
        Me.popChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popChangeAdd, Me.popChangePurchaseAdd, Me.popChangeEdit, Me.popChangeDel, Me.popChangeView, Me.ToolStripSeparator1, Me.popChangeCheck, Me.ToolStripSeparator3, Me.popChangeMsg, Me.popChangeRef, Me.popChangeFile, Me.ToolStripSeparator2, Me.popChangeSeek, Me.popChangePrint})
        Me.popChange.Name = "popAcceptance"
        Me.popChange.Size = New System.Drawing.Size(191, 264)
        '
        'popChangeAdd
        '
        Me.popChangeAdd.Enabled = False
        Me.popChangeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popChangeAdd.Name = "popChangeAdd"
        Me.popChangeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popChangeAdd.Size = New System.Drawing.Size(190, 22)
        Me.popChangeAdd.Text = "暫改未交數(&T)..."
        '
        'popChangePurchaseAdd
        '
        Me.popChangePurchaseAdd.Enabled = False
        Me.popChangePurchaseAdd.Name = "popChangePurchaseAdd"
        Me.popChangePurchaseAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popChangePurchaseAdd.Size = New System.Drawing.Size(190, 22)
        Me.popChangePurchaseAdd.Text = "暫改採購數(&S)..."
        '
        'popChangeEdit
        '
        Me.popChangeEdit.Enabled = False
        Me.popChangeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popChangeEdit.Name = "popChangeEdit"
        Me.popChangeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popChangeEdit.Size = New System.Drawing.Size(190, 22)
        Me.popChangeEdit.Text = "修改(&E)..."
        '
        'popChangeDel
        '
        Me.popChangeDel.Enabled = False
        Me.popChangeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popChangeDel.Name = "popChangeDel"
        Me.popChangeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popChangeDel.Size = New System.Drawing.Size(190, 22)
        Me.popChangeDel.Text = "刪除(&D)"
        '
        'popChangeView
        '
        Me.popChangeView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popChangeView.Name = "popChangeView"
        Me.popChangeView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popChangeView.Size = New System.Drawing.Size(190, 22)
        Me.popChangeView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'popChangeCheck
        '
        Me.popChangeCheck.Enabled = False
        Me.popChangeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popChangeCheck.Name = "popChangeCheck"
        Me.popChangeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popChangeCheck.Size = New System.Drawing.Size(190, 22)
        Me.popChangeCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(187, 6)
        '
        'popChangeMsg
        '
        Me.popChangeMsg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popMsgView, Me.popMsgCheck})
        Me.popChangeMsg.Name = "popChangeMsg"
        Me.popChangeMsg.Size = New System.Drawing.Size(190, 22)
        Me.popChangeMsg.Text = "發送消息(&I)"
        '
        'popMsgView
        '
        Me.popMsgView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popMsgView.Name = "popMsgView"
        Me.popMsgView.Size = New System.Drawing.Size(152, 22)
        Me.popMsgView.Text = "查看(&W)..."
        '
        'popMsgCheck
        '
        Me.popMsgCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popMsgCheck.Name = "popMsgCheck"
        Me.popMsgCheck.Size = New System.Drawing.Size(152, 22)
        Me.popMsgCheck.Text = "審核(&C)..."
        '
        'popChangeRef
        '
        Me.popChangeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popChangeRef.Name = "popChangeRef"
        Me.popChangeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popChangeRef.Size = New System.Drawing.Size(190, 22)
        Me.popChangeRef.Text = "刷新(&R)"
        '
        'popChangeFile
        '
        Me.popChangeFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popChangeFile.Name = "popChangeFile"
        Me.popChangeFile.Size = New System.Drawing.Size(190, 22)
        Me.popChangeFile.Text = "附加文件(&B)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'popChangeSeek
        '
        Me.popChangeSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popChangeSeek.Name = "popChangeSeek"
        Me.popChangeSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popChangeSeek.Size = New System.Drawing.Size(190, 22)
        Me.popChangeSeek.Text = "查詢(&F)..."
        '
        'popChangePrint
        '
        Me.popChangePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popChangePrint.Name = "popChangePrint"
        Me.popChangePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popChangePrint.Size = New System.Drawing.Size(190, 22)
        Me.popChangePrint.Text = "更改單(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_ChangeNO, Me.PM_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.C_NoSendQty, Me.C_Price, Me.C_Date, Me.ActionName, Me.C_Check, Me.C_Reason, Me.PM_Qty})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'C_ChangeNO
        '
        Me.C_ChangeNO.Caption = "更改單號"
        Me.C_ChangeNO.FieldName = "C_ChangeNO"
        Me.C_ChangeNO.Name = "C_ChangeNO"
        Me.C_ChangeNO.Visible = True
        Me.C_ChangeNO.VisibleIndex = 0
        Me.C_ChangeNO.Width = 90
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 1
        Me.PM_NO.Width = 90
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        '
        'C_NoSendQty
        '
        Me.C_NoSendQty.Caption = "更改後未交數量"
        Me.C_NoSendQty.FieldName = "C_NoSendQty"
        Me.C_NoSendQty.Name = "C_NoSendQty"
        Me.C_NoSendQty.Visible = True
        Me.C_NoSendQty.VisibleIndex = 6
        Me.C_NoSendQty.Width = 100
        '
        'C_Price
        '
        Me.C_Price.Caption = "單價"
        Me.C_Price.FieldName = "C_Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.Visible = True
        Me.C_Price.VisibleIndex = 7
        Me.C_Price.Width = 65
        '
        'C_Date
        '
        Me.C_Date.Caption = "更改日期"
        Me.C_Date.FieldName = "C_Date"
        Me.C_Date.Name = "C_Date"
        Me.C_Date.Visible = True
        Me.C_Date.VisibleIndex = 9
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 10
        Me.ActionName.Width = 65
        '
        'C_Check
        '
        Me.C_Check.Caption = "審核"
        Me.C_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.C_Check.FieldName = "C_Check"
        Me.C_Check.Name = "C_Check"
        Me.C_Check.Visible = True
        Me.C_Check.VisibleIndex = 11
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'C_Reason
        '
        Me.C_Reason.Caption = "更改原因"
        Me.C_Reason.FieldName = "C_Reason"
        Me.C_Reason.Name = "C_Reason"
        Me.C_Reason.Visible = True
        Me.C_Reason.VisibleIndex = 8
        '
        'PM_Qty
        '
        Me.PM_Qty.Caption = "更改前數量"
        Me.PM_Qty.FieldName = "PM_Qty"
        Me.PM_Qty.Name = "PM_Qty"
        Me.PM_Qty.Visible = True
        Me.PM_Qty.VisibleIndex = 5
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(706, 36)
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "更改單管理"
        '
        'frmChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "frmChangeMain"
        Me.Text = "更改單管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popChange.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C_ChangeNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents popChange As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popChangeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangeView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popChangeCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popChangeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangeFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popChangeSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C_Reason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popChangeMsg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMsgView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMsgCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popChangePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PM_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popChangePurchaseAdd As System.Windows.Forms.ToolStripMenuItem
End Class
