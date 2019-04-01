<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutwardChangeMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popChange = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popChangeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OC_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.O_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popChange.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(747, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "外發更改單"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popChange
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 37)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(747, 458)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popChange
        '
        Me.popChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popChangeAdd, Me.popChangeEdit, Me.popChangeDel, Me.popChangeView, Me.ToolStripSeparator1, Me.popChangeCheck, Me.ToolStripSeparator3, Me.popChangeRef, Me.popChangeFile, Me.ToolStripSeparator2, Me.popChangeSeek, Me.popChangePrint})
        Me.popChange.Name = "popAcceptance"
        Me.popChange.Size = New System.Drawing.Size(163, 242)
        '
        'popChangeAdd
        '
        Me.popChangeAdd.Image = Global.LFERP.My.Resources.Resources.SignatureLineInsertMenu
        Me.popChangeAdd.Name = "popChangeAdd"
        Me.popChangeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popChangeAdd.Size = New System.Drawing.Size(162, 22)
        Me.popChangeAdd.Text = "暫改(&T)..."
        '
        'popChangeEdit
        '
        Me.popChangeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popChangeEdit.Name = "popChangeEdit"
        Me.popChangeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popChangeEdit.Size = New System.Drawing.Size(162, 22)
        Me.popChangeEdit.Text = "修改(&E)..."
        '
        'popChangeDel
        '
        Me.popChangeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popChangeDel.Name = "popChangeDel"
        Me.popChangeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popChangeDel.Size = New System.Drawing.Size(162, 22)
        Me.popChangeDel.Text = "刪除(&D)"
        '
        'popChangeView
        '
        Me.popChangeView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popChangeView.Name = "popChangeView"
        Me.popChangeView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popChangeView.Size = New System.Drawing.Size(162, 22)
        Me.popChangeView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'popChangeCheck
        '
        Me.popChangeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popChangeCheck.Name = "popChangeCheck"
        Me.popChangeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popChangeCheck.Size = New System.Drawing.Size(162, 22)
        Me.popChangeCheck.Text = "審核(&G)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(159, 6)
        '
        'popChangeRef
        '
        Me.popChangeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popChangeRef.Name = "popChangeRef"
        Me.popChangeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popChangeRef.Size = New System.Drawing.Size(162, 22)
        Me.popChangeRef.Text = "刷新(&R)"
        '
        'popChangeFile
        '
        Me.popChangeFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popChangeFile.Name = "popChangeFile"
        Me.popChangeFile.Size = New System.Drawing.Size(162, 22)
        Me.popChangeFile.Text = "附加文件(&B)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'popChangeSeek
        '
        Me.popChangeSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popChangeSeek.Name = "popChangeSeek"
        Me.popChangeSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popChangeSeek.Size = New System.Drawing.Size(162, 22)
        Me.popChangeSeek.Text = "查詢(&F)..."
        '
        'popChangePrint
        '
        Me.popChangePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popChangePrint.Name = "popChangePrint"
        Me.popChangePrint.Size = New System.Drawing.Size(162, 22)
        Me.popChangePrint.Text = "更改單(&M)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OC_NO, Me.O_NO, Me.OS_BatchID, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'OC_NO
        '
        Me.OC_NO.Caption = "更改單號"
        Me.OC_NO.FieldName = "OC_NO"
        Me.OC_NO.Name = "OC_NO"
        Me.OC_NO.Visible = True
        Me.OC_NO.VisibleIndex = 0
        Me.OC_NO.Width = 84
        '
        'O_NO
        '
        Me.O_NO.Caption = "外發單號"
        Me.O_NO.FieldName = "O_NO"
        Me.O_NO.Name = "O_NO"
        Me.O_NO.Visible = True
        Me.O_NO.VisibleIndex = 1
        Me.O_NO.Width = 85
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "外發批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 2
        Me.OS_BatchID.Width = 76
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "聯豐編號"
        Me.GridColumn4.FieldName = "PM_M_Code"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 67
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "物料編碼"
        Me.GridColumn5.FieldName = "M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 73
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "物料名稱"
        Me.GridColumn6.FieldName = "M_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 77
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "物料規格"
        Me.GridColumn7.FieldName = "M_Gauge"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 74
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "外發數量"
        Me.GridColumn8.FieldName = "OS_Qty"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 74
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "外發未交數"
        Me.GridColumn9.FieldName = "OS_NoSendQty"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 76
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "更改後數量"
        Me.GridColumn10.FieldName = "OC_Qty"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 83
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "操作員"
        Me.GridColumn11.FieldName = "ActionName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        Me.GridColumn11.Width = 60
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "審核"
        Me.GridColumn12.FieldName = "OC_Check"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 9
        Me.GridColumn12.Width = 37
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "審核員"
        Me.GridColumn13.FieldName = "CheckActionName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 39
        '
        'frmOutwardChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 496)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOutwardChangeMain"
        Me.Text = "外發更改單"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popChange.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents O_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents popChangePrint As System.Windows.Forms.ToolStripMenuItem
End Class
