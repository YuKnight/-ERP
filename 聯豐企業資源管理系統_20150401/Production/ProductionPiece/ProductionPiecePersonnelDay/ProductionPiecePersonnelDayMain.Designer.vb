<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionPiecePersonnelDayMain
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
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_DPT_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_DPT_PID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_G_NO_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Class = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_PayType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Resign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popPiecePersonnel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPiecePersonnelAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popPiecePersonnelEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popPiecePersonnelDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popPiecePersonnelView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popPiecePersonnelRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popPiecePersonnelSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.popPiecePersonnelPrint = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popPiecePersonnel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 21)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "計件-員工-每日名單"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(1, 3)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(803, 36)
        Me.PicCaption.TabIndex = 264
        Me.PicCaption.TabStop = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Per_Num, Me.Per_NO, Me.Per_Name, Me.Per_DPT_ID, Me.Per_DPT_PID, Me.Per_G_NO_Name, Me.Per_Class, Me.Per_PayType, Me.Per_Resign, Me.G_Date, Me.G_Action, Me.G_NO, Me.DepID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.AllowFocus = False
        '
        'Per_Num
        '
        Me.Per_Num.Caption = "編號"
        Me.Per_Num.FieldName = "Per_Num"
        Me.Per_Num.Name = "Per_Num"
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "廠証編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.OptionsColumn.AllowEdit = False
        Me.Per_NO.OptionsColumn.AllowFocus = False
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.AllowEdit = False
        Me.Per_Name.OptionsColumn.AllowFocus = False
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        '
        'Per_DPT_ID
        '
        Me.Per_DPT_ID.Caption = "部門"
        Me.Per_DPT_ID.FieldName = "Per_DepName"
        Me.Per_DPT_ID.Name = "Per_DPT_ID"
        Me.Per_DPT_ID.OptionsColumn.AllowEdit = False
        Me.Per_DPT_ID.OptionsColumn.AllowFocus = False
        Me.Per_DPT_ID.Visible = True
        Me.Per_DPT_ID.VisibleIndex = 2
        '
        'Per_DPT_PID
        '
        Me.Per_DPT_PID.Caption = "廠別"
        Me.Per_DPT_PID.FieldName = "Per_FacName"
        Me.Per_DPT_PID.Name = "Per_DPT_PID"
        Me.Per_DPT_PID.OptionsColumn.AllowEdit = False
        Me.Per_DPT_PID.OptionsColumn.AllowFocus = False
        Me.Per_DPT_PID.Visible = True
        Me.Per_DPT_PID.VisibleIndex = 3
        '
        'Per_G_NO_Name
        '
        Me.Per_G_NO_Name.Caption = "組別"
        Me.Per_G_NO_Name.FieldName = "Per_G_Name"
        Me.Per_G_NO_Name.Name = "Per_G_NO_Name"
        Me.Per_G_NO_Name.OptionsColumn.AllowEdit = False
        Me.Per_G_NO_Name.OptionsColumn.AllowFocus = False
        Me.Per_G_NO_Name.Visible = True
        Me.Per_G_NO_Name.VisibleIndex = 4
        '
        'Per_Class
        '
        Me.Per_Class.Caption = "班制"
        Me.Per_Class.FieldName = "Per_Class"
        Me.Per_Class.Name = "Per_Class"
        Me.Per_Class.OptionsColumn.AllowEdit = False
        Me.Per_Class.OptionsColumn.AllowFocus = False
        Me.Per_Class.Visible = True
        Me.Per_Class.VisibleIndex = 5
        '
        'Per_PayType
        '
        Me.Per_PayType.Caption = "薪金類型"
        Me.Per_PayType.FieldName = "Per_PayType"
        Me.Per_PayType.Name = "Per_PayType"
        Me.Per_PayType.OptionsColumn.AllowEdit = False
        Me.Per_PayType.OptionsColumn.AllowFocus = False
        Me.Per_PayType.Visible = True
        Me.Per_PayType.VisibleIndex = 6
        '
        'Per_Resign
        '
        Me.Per_Resign.Caption = "辭工否"
        Me.Per_Resign.FieldName = "Per_Resign"
        Me.Per_Resign.Name = "Per_Resign"
        Me.Per_Resign.OptionsColumn.AllowEdit = False
        Me.Per_Resign.OptionsColumn.AllowFocus = False
        '
        'G_Date
        '
        Me.G_Date.Caption = "計件日期"
        Me.G_Date.FieldName = "Per_Date"
        Me.G_Date.Name = "G_Date"
        Me.G_Date.OptionsColumn.AllowEdit = False
        Me.G_Date.OptionsColumn.AllowFocus = False
        Me.G_Date.Visible = True
        Me.G_Date.VisibleIndex = 7
        '
        'G_Action
        '
        Me.G_Action.Caption = "操作員"
        Me.G_Action.FieldName = "Per_ActionName"
        Me.G_Action.Name = "G_Action"
        Me.G_Action.OptionsColumn.AllowEdit = False
        Me.G_Action.OptionsColumn.AllowFocus = False
        Me.G_Action.Visible = True
        Me.G_Action.VisibleIndex = 8
        '
        'G_NO
        '
        Me.G_NO.Caption = "組別"
        Me.G_NO.FieldName = "G_NO"
        Me.G_NO.Name = "G_NO"
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popPiecePersonnel
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(1, 42)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 408)
        Me.Grid1.TabIndex = 266
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popPiecePersonnel
        '
        Me.popPiecePersonnel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPiecePersonnelAdd, Me.popPiecePersonnelEdit, Me.popPiecePersonnelDel, Me.popPiecePersonnelView, Me.ToolStripSeparator1, Me.popPiecePersonnelRef, Me.ToolStripSeparator2, Me.popPiecePersonnelSeek, Me.ToolStripMenuItem1, Me.popPiecePersonnelPrint})
        Me.popPiecePersonnel.Name = "popAcceptance"
        Me.popPiecePersonnel.Size = New System.Drawing.Size(257, 176)
        '
        'popPiecePersonnelAdd
        '
        Me.popPiecePersonnelAdd.Enabled = False
        Me.popPiecePersonnelAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPiecePersonnelAdd.Name = "popPiecePersonnelAdd"
        Me.popPiecePersonnelAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPiecePersonnelAdd.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelAdd.Text = "增加(&A)..."
        '
        'popPiecePersonnelEdit
        '
        Me.popPiecePersonnelEdit.Enabled = False
        Me.popPiecePersonnelEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popPiecePersonnelEdit.Name = "popPiecePersonnelEdit"
        Me.popPiecePersonnelEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popPiecePersonnelEdit.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelEdit.Text = "修改(&E)..."
        '
        'popPiecePersonnelDel
        '
        Me.popPiecePersonnelDel.Enabled = False
        Me.popPiecePersonnelDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popPiecePersonnelDel.Name = "popPiecePersonnelDel"
        Me.popPiecePersonnelDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPiecePersonnelDel.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelDel.Text = "刪除(&D)"
        '
        'popPiecePersonnelView
        '
        Me.popPiecePersonnelView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popPiecePersonnelView.Name = "popPiecePersonnelView"
        Me.popPiecePersonnelView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popPiecePersonnelView.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'popPiecePersonnelRef
        '
        Me.popPiecePersonnelRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popPiecePersonnelRef.Name = "popPiecePersonnelRef"
        Me.popPiecePersonnelRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popPiecePersonnelRef.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(253, 6)
        '
        'popPiecePersonnelSeek
        '
        Me.popPiecePersonnelSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popPiecePersonnelSeek.Name = "popPiecePersonnelSeek"
        Me.popPiecePersonnelSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popPiecePersonnelSeek.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelSeek.Text = "查詢(&F)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(253, 6)
        '
        'popPiecePersonnelPrint
        '
        Me.popPiecePersonnelPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popPiecePersonnelPrint.Name = "popPiecePersonnelPrint"
        Me.popPiecePersonnelPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popPiecePersonnelPrint.Size = New System.Drawing.Size(256, 22)
        Me.popPiecePersonnelPrint.Text = "個人計件名單打印(&P)"
        '
        'ProductionPiecePersonnelDayMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 453)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "ProductionPiecePersonnelDayMain"
        Me.Text = "計件員工日記錄"
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popPiecePersonnel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_DPT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_DPT_PID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_G_NO_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_PayType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Resign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents popPiecePersonnel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPiecePersonnelAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPiecePersonnelEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPiecePersonnelDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPiecePersonnelView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPiecePersonnelRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPiecePersonnelSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Per_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPiecePersonnelPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Class As DevExpress.XtraGrid.Columns.GridColumn
End Class
