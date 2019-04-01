<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPieceWorkGroupMain
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popPieceWorkGroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPieceWorkGroupAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popPieceWorkGroupEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popPieceWorkGroupDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popPieceWorkGroupView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popPieceWorkGroupRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popPieceWorkGroupSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Manager = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_FacID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_Date = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popPieceWorkGroup.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "計件名單-組別"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(0, 3)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(803, 36)
        Me.PicCaption.TabIndex = 259
        Me.PicCaption.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popPieceWorkGroup
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 40)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 421)
        Me.Grid1.TabIndex = 261
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popPieceWorkGroup
        '
        Me.popPieceWorkGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPieceWorkGroupAdd, Me.popPieceWorkGroupEdit, Me.popPieceWorkGroupDel, Me.popPieceWorkGroupView, Me.ToolStripSeparator3, Me.popPieceWorkGroupRef, Me.ToolStripSeparator2, Me.popPieceWorkGroupSeek})
        Me.popPieceWorkGroup.Name = "popAcceptance"
        Me.popPieceWorkGroup.Size = New System.Drawing.Size(189, 148)
        '
        'popPieceWorkGroupAdd
        '
        Me.popPieceWorkGroupAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPieceWorkGroupAdd.Name = "popPieceWorkGroupAdd"
        Me.popPieceWorkGroupAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupAdd.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupAdd.Text = "增加(&A)..."
        '
        'popPieceWorkGroupEdit
        '
        Me.popPieceWorkGroupEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popPieceWorkGroupEdit.Name = "popPieceWorkGroupEdit"
        Me.popPieceWorkGroupEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupEdit.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupEdit.Text = "修改(&E)..."
        '
        'popPieceWorkGroupDel
        '
        Me.popPieceWorkGroupDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popPieceWorkGroupDel.Name = "popPieceWorkGroupDel"
        Me.popPieceWorkGroupDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupDel.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupDel.Text = "刪除(&D)"
        '
        'popPieceWorkGroupView
        '
        Me.popPieceWorkGroupView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popPieceWorkGroupView.Name = "popPieceWorkGroupView"
        Me.popPieceWorkGroupView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupView.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupView.Text = "查看(&W)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'popPieceWorkGroupRef
        '
        Me.popPieceWorkGroupRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popPieceWorkGroupRef.Name = "popPieceWorkGroupRef"
        Me.popPieceWorkGroupRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupRef.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'popPieceWorkGroupSeek
        '
        Me.popPieceWorkGroupSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popPieceWorkGroupSeek.Name = "popPieceWorkGroupSeek"
        Me.popPieceWorkGroupSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popPieceWorkGroupSeek.Size = New System.Drawing.Size(188, 22)
        Me.popPieceWorkGroupSeek.Text = "查詢(&F)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.G_NO, Me.G_Name, Me.G_Manager, Me.G_FacID, Me.G_DepID, Me.G_ActionName, Me.G_Date})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'G_NO
        '
        Me.G_NO.Caption = "組別編號"
        Me.G_NO.FieldName = "G_NO"
        Me.G_NO.Name = "G_NO"
        Me.G_NO.OptionsColumn.AllowEdit = False
        Me.G_NO.Visible = True
        Me.G_NO.VisibleIndex = 0
        '
        'G_Name
        '
        Me.G_Name.Caption = "組別名稱"
        Me.G_Name.FieldName = "G_Name"
        Me.G_Name.Name = "G_Name"
        Me.G_Name.OptionsColumn.AllowEdit = False
        Me.G_Name.Visible = True
        Me.G_Name.VisibleIndex = 1
        '
        'G_Manager
        '
        Me.G_Manager.Caption = "負責人"
        Me.G_Manager.FieldName = "G_Manager"
        Me.G_Manager.Name = "G_Manager"
        Me.G_Manager.OptionsColumn.AllowEdit = False
        Me.G_Manager.Visible = True
        Me.G_Manager.VisibleIndex = 2
        '
        'G_FacID
        '
        Me.G_FacID.Caption = "廠別"
        Me.G_FacID.FieldName = "G_FacName"
        Me.G_FacID.Name = "G_FacID"
        Me.G_FacID.OptionsColumn.AllowEdit = False
        Me.G_FacID.Visible = True
        Me.G_FacID.VisibleIndex = 3
        '
        'G_DepID
        '
        Me.G_DepID.Caption = "部門"
        Me.G_DepID.FieldName = "G_DepName"
        Me.G_DepID.Name = "G_DepID"
        Me.G_DepID.OptionsColumn.AllowEdit = False
        Me.G_DepID.Visible = True
        Me.G_DepID.VisibleIndex = 4
        Me.G_DepID.Width = 85
        '
        'G_ActionName
        '
        Me.G_ActionName.Caption = "操作員"
        Me.G_ActionName.FieldName = "G_ActionName"
        Me.G_ActionName.Name = "G_ActionName"
        Me.G_ActionName.OptionsColumn.AllowEdit = False
        Me.G_ActionName.Visible = True
        Me.G_ActionName.VisibleIndex = 5
        '
        'G_Date
        '
        Me.G_Date.Caption = "建立時間"
        Me.G_Date.FieldName = "G_Date"
        Me.G_Date.Name = "G_Date"
        Me.G_Date.OptionsColumn.AllowEdit = False
        Me.G_Date.Visible = True
        Me.G_Date.VisibleIndex = 6
        '
        'frmProductionPieceWorkGroupMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 464)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "frmProductionPieceWorkGroupMain"
        Me.Text = "組別名單"
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popPieceWorkGroup.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Manager As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_FacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popPieceWorkGroup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPieceWorkGroupAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPieceWorkGroupEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPieceWorkGroupDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPieceWorkGroupView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPieceWorkGroupRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPieceWorkGroupSeek As System.Windows.Forms.ToolStripMenuItem
End Class
