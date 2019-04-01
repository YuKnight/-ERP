<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionBalanceMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStripAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStripPreView = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripRef = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStripCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.B_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Type3ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_ReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "部門結餘變更管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 33)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.MenuStrip
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 35)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(534, 338)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripAdd, Me.MenuStripEdit, Me.MenuStripDel, Me.ToolStripSeparator1, Me.MenuStripPreView, Me.MenuStripRef, Me.MenuStripQuery, Me.ToolStripSeparator2, Me.MenuStripCheck, Me.MenuStripPrint})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(189, 192)
        '
        'MenuStripAdd
        '
        Me.MenuStripAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.MenuStripAdd.Name = "MenuStripAdd"
        Me.MenuStripAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuStripAdd.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripAdd.Text = "新增(&A)..."
        '
        'MenuStripEdit
        '
        Me.MenuStripEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.MenuStripEdit.Name = "MenuStripEdit"
        Me.MenuStripEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenuStripEdit.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripEdit.Text = "修改(&E)..."
        '
        'MenuStripDel
        '
        Me.MenuStripDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.MenuStripDel.Name = "MenuStripDel"
        Me.MenuStripDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuStripDel.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'MenuStripPreView
        '
        Me.MenuStripPreView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.MenuStripPreView.Name = "MenuStripPreView"
        Me.MenuStripPreView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuStripPreView.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripPreView.Text = "查看(&W)..."
        '
        'MenuStripRef
        '
        Me.MenuStripRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.MenuStripRef.Name = "MenuStripRef"
        Me.MenuStripRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuStripRef.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripRef.Text = "刷新(&R)"
        '
        'MenuStripQuery
        '
        Me.MenuStripQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.MenuStripQuery.Name = "MenuStripQuery"
        Me.MenuStripQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MenuStripQuery.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripQuery.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'MenuStripCheck
        '
        Me.MenuStripCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.MenuStripCheck.Name = "MenuStripCheck"
        Me.MenuStripCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.MenuStripCheck.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripCheck.Text = "審核(&G)..."
        '
        'MenuStripPrint
        '
        Me.MenuStripPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.MenuStripPrint.Name = "MenuStripPrint"
        Me.MenuStripPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripPrint.Size = New System.Drawing.Size(188, 22)
        Me.MenuStripPrint.Text = "列印(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.B_ID, Me.DepName, Me.PM_M_Code, Me.Type3ID, Me.PS_Name, Me.WI_Qty, Me.WI_ReQty, Me.ActionName, Me.B_Remark, Me.CheckActionName, Me.B_CheckDate, Me.B_CheckRemark})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'B_ID
        '
        Me.B_ID.Caption = "變更單號"
        Me.B_ID.FieldName = "B_ID"
        Me.B_ID.Name = "B_ID"
        Me.B_ID.Visible = True
        Me.B_ID.VisibleIndex = 0
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 1
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        Me.PM_M_Code.Width = 100
        '
        'Type3ID
        '
        Me.Type3ID.Caption = "類型"
        Me.Type3ID.FieldName = "Type3ID"
        Me.Type3ID.Name = "Type3ID"
        Me.Type3ID.Visible = True
        Me.Type3ID.VisibleIndex = 3
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "變更工序"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 4
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "大貨數量"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 5
        '
        'WI_ReQty
        '
        Me.WI_ReQty.Caption = "返修數量"
        Me.WI_ReQty.FieldName = "WI_ReQty"
        Me.WI_ReQty.Name = "WI_ReQty"
        Me.WI_ReQty.Visible = True
        Me.WI_ReQty.VisibleIndex = 6
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 7
        '
        'B_Remark
        '
        Me.B_Remark.Caption = "變更原因"
        Me.B_Remark.FieldName = "B_Remark"
        Me.B_Remark.Name = "B_Remark"
        '
        'CheckActionName
        '
        Me.CheckActionName.Caption = "審核員"
        Me.CheckActionName.FieldName = "CheckActionName"
        Me.CheckActionName.Name = "CheckActionName"
        Me.CheckActionName.Visible = True
        Me.CheckActionName.VisibleIndex = 8
        '
        'B_CheckDate
        '
        Me.B_CheckDate.Caption = "審核時間"
        Me.B_CheckDate.FieldName = "B_CheckDate"
        Me.B_CheckDate.Name = "B_CheckDate"
        Me.B_CheckDate.Visible = True
        Me.B_CheckDate.VisibleIndex = 9
        '
        'B_CheckRemark
        '
        Me.B_CheckRemark.Caption = "審核備註"
        Me.B_CheckRemark.FieldName = "B_CheckRemark"
        Me.B_CheckRemark.Name = "B_CheckRemark"
        '
        'frmProductionBalanceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 374)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductionBalanceMain"
        Me.Text = "部門結餘變更管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents B_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_ReQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type3ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStripAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripPreView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
