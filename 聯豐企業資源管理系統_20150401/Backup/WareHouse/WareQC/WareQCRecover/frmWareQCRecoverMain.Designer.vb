<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareQCRecoverMain
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
        Me.WQR_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.WQR_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQR_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.WareQCRecover = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WareQCRecoverAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.WareQCRecoverEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.WareQCRecoverDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.WareQCRecoverRef = New System.Windows.Forms.ToolStripMenuItem
        Me.WareQCRecoverView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.WareQCRecoverQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.WareQCRecoverCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WQS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQR_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQR_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WareQCRecover.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WQR_Date
        '
        Me.WQR_Date.Caption = "歸還日期"
        Me.WQR_Date.FieldName = "WQR_Date"
        Me.WQR_Date.Name = "WQR_Date"
        Me.WQR_Date.Visible = True
        Me.WQR_Date.VisibleIndex = 5
        '
        'UserName
        '
        Me.UserName.Caption = "操作員"
        Me.UserName.FieldName = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.Visible = True
        Me.UserName.VisibleIndex = 7
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 4
        Me.WH_ID.Width = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "抽檢歸還作業"
        '
        'WQR_Remark
        '
        Me.WQR_Remark.Caption = "備註"
        Me.WQR_Remark.FieldName = "WQR_Remark"
        Me.WQR_Remark.Name = "WQR_Remark"
        Me.WQR_Remark.Visible = True
        Me.WQR_Remark.VisibleIndex = 8
        '
        'WQR_Check
        '
        Me.WQR_Check.Caption = "審核"
        Me.WQR_Check.FieldName = "WQR_Check"
        Me.WQR_Check.Name = "WQR_Check"
        Me.WQR_Check.Visible = True
        Me.WQR_Check.VisibleIndex = 6
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.WareQCRecover
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 36)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(495, 376)
        Me.Grid1.TabIndex = 169
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'WareQCRecover
        '
        Me.WareQCRecover.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WareQCRecover.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WareQCRecoverAdd, Me.WareQCRecoverEdit, Me.WareQCRecoverDel, Me.ToolStripSeparator1, Me.WareQCRecoverRef, Me.WareQCRecoverView, Me.ToolStripSeparator2, Me.WareQCRecoverQuery, Me.WareQCRecoverCheck})
        Me.WareQCRecover.Name = "WareQCRecover"
        Me.WareQCRecover.Size = New System.Drawing.Size(174, 170)
        '
        'WareQCRecoverAdd
        '
        Me.WareQCRecoverAdd.Enabled = False
        Me.WareQCRecoverAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.WareQCRecoverAdd.Name = "WareQCRecoverAdd"
        Me.WareQCRecoverAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.WareQCRecoverAdd.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverAdd.Text = "新增(&A)..."
        '
        'WareQCRecoverEdit
        '
        Me.WareQCRecoverEdit.Enabled = False
        Me.WareQCRecoverEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.WareQCRecoverEdit.Name = "WareQCRecoverEdit"
        Me.WareQCRecoverEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.WareQCRecoverEdit.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverEdit.Text = "修改(&E)..."
        '
        'WareQCRecoverDel
        '
        Me.WareQCRecoverDel.Enabled = False
        Me.WareQCRecoverDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.WareQCRecoverDel.Name = "WareQCRecoverDel"
        Me.WareQCRecoverDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.WareQCRecoverDel.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverDel.Text = "刪除(&D)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'WareQCRecoverRef
        '
        Me.WareQCRecoverRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.WareQCRecoverRef.Name = "WareQCRecoverRef"
        Me.WareQCRecoverRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.WareQCRecoverRef.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverRef.Text = "刷新(&R)..."
        '
        'WareQCRecoverView
        '
        Me.WareQCRecoverView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.WareQCRecoverView.Name = "WareQCRecoverView"
        Me.WareQCRecoverView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WareQCRecoverView.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverView.Text = "查看(&W)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'WareQCRecoverQuery
        '
        Me.WareQCRecoverQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.WareQCRecoverQuery.Name = "WareQCRecoverQuery"
        Me.WareQCRecoverQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.WareQCRecoverQuery.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverQuery.Text = "查詢(&F)..."
        '
        'WareQCRecoverCheck
        '
        Me.WareQCRecoverCheck.Enabled = False
        Me.WareQCRecoverCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.WareQCRecoverCheck.Name = "WareQCRecoverCheck"
        Me.WareQCRecoverCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.WareQCRecoverCheck.Size = New System.Drawing.Size(173, 22)
        Me.WareQCRecoverCheck.Text = "審核(&G)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WQS_NO, Me.M_Code, Me.WQR_Qty, Me.WH_ID, Me.WQR_Date, Me.UserName, Me.WQR_Check, Me.WQR_Remark, Me.WQR_NO})
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
        'WQS_NO
        '
        Me.WQS_NO.Caption = "抽檢發出單號"
        Me.WQS_NO.FieldName = "WQS_NO"
        Me.WQS_NO.Name = "WQS_NO"
        Me.WQS_NO.Visible = True
        Me.WQS_NO.VisibleIndex = 1
        Me.WQS_NO.Width = 101
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 125
        '
        'WQR_Qty
        '
        Me.WQR_Qty.Caption = "歸還數量"
        Me.WQR_Qty.FieldName = "WQR_Qty"
        Me.WQR_Qty.Name = "WQR_Qty"
        Me.WQR_Qty.Visible = True
        Me.WQR_Qty.VisibleIndex = 3
        Me.WQR_Qty.Width = 69
        '
        'WQR_NO
        '
        Me.WQR_NO.Caption = "抽檢歸還單號"
        Me.WQR_NO.FieldName = "WQR_NO"
        Me.WQR_NO.Name = "WQR_NO"
        Me.WQR_NO.Visible = True
        Me.WQR_NO.VisibleIndex = 0
        Me.WQR_NO.Width = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 35)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'frmWareQCRecoverMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 412)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareQCRecoverMain"
        Me.Text = "QC抽檢管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WareQCRecover.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WQR_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WQR_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQR_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WQS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQR_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQR_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WareQCRecover As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WareQCRecoverAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareQCRecoverEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareQCRecoverDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareQCRecoverView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareQCRecoverQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareQCRecoverCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WareQCRecoverRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
