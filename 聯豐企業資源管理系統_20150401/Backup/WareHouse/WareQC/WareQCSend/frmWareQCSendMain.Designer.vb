<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareQCSendMain
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
        Me.WaraQCSend = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QCSendAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.QCSendEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.QCSendDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.QCSendRef = New System.Windows.Forms.ToolStripMenuItem
        Me.QCSendView = New System.Windows.Forms.ToolStripMenuItem
        Me.QCSendQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.QCSendCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WQS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQS_NotRecoverQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQS_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQS_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQS_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WaraQCSend.SuspendLayout()
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
        Me.PictureBox1.Size = New System.Drawing.Size(517, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "抽檢發出作業"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.WaraQCSend
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 36)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(517, 369)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'WaraQCSend
        '
        Me.WaraQCSend.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WaraQCSend.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QCSendAdd, Me.QCSendEdit, Me.QCSendDel, Me.ToolStripSeparator1, Me.QCSendRef, Me.QCSendView, Me.QCSendQuery, Me.ToolStripSeparator2, Me.QCSendCheck})
        Me.WaraQCSend.Name = "WaraQCSend"
        Me.WaraQCSend.Size = New System.Drawing.Size(174, 170)
        '
        'QCSendAdd
        '
        Me.QCSendAdd.Enabled = False
        Me.QCSendAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.QCSendAdd.Name = "QCSendAdd"
        Me.QCSendAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.QCSendAdd.Size = New System.Drawing.Size(167, 22)
        Me.QCSendAdd.Text = "新增(&A)..."
        '
        'QCSendEdit
        '
        Me.QCSendEdit.Enabled = False
        Me.QCSendEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.QCSendEdit.Name = "QCSendEdit"
        Me.QCSendEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.QCSendEdit.Size = New System.Drawing.Size(167, 22)
        Me.QCSendEdit.Text = "修改(&E)..."
        '
        'QCSendDel
        '
        Me.QCSendDel.Enabled = False
        Me.QCSendDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.QCSendDel.Name = "QCSendDel"
        Me.QCSendDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.QCSendDel.Size = New System.Drawing.Size(167, 22)
        Me.QCSendDel.Text = "删除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'QCSendRef
        '
        Me.QCSendRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.QCSendRef.Name = "QCSendRef"
        Me.QCSendRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.QCSendRef.Size = New System.Drawing.Size(173, 22)
        Me.QCSendRef.Text = "刷新(&R)"
        '
        'QCSendView
        '
        Me.QCSendView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.QCSendView.Name = "QCSendView"
        Me.QCSendView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.QCSendView.Size = New System.Drawing.Size(173, 22)
        Me.QCSendView.Text = "查看(&W)..."
        '
        'QCSendQuery
        '
        Me.QCSendQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.QCSendQuery.Name = "QCSendQuery"
        Me.QCSendQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.QCSendQuery.Size = New System.Drawing.Size(173, 22)
        Me.QCSendQuery.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'QCSendCheck
        '
        Me.QCSendCheck.Enabled = False
        Me.QCSendCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.QCSendCheck.Name = "QCSendCheck"
        Me.QCSendCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.QCSendCheck.Size = New System.Drawing.Size(173, 22)
        Me.QCSendCheck.Text = "審核(&G)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WQS_NO, Me.M_Code, Me.A_AcceptanceNO, Me.WQS_Qty, Me.WQS_NotRecoverQty, Me.WH_ID, Me.WQS_Date, Me.UserName, Me.WQS_Check, Me.WQS_Remark, Me.M_Name, Me.M_Gauge})
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
        Me.WQS_NO.VisibleIndex = 0
        Me.WQS_NO.Width = 99
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 127
        '
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Visible = True
        Me.A_AcceptanceNO.VisibleIndex = 4
        Me.A_AcceptanceNO.Width = 85
        '
        'WQS_Qty
        '
        Me.WQS_Qty.Caption = "抽檢數量"
        Me.WQS_Qty.FieldName = "WQS_Qty"
        Me.WQS_Qty.Name = "WQS_Qty"
        Me.WQS_Qty.Visible = True
        Me.WQS_Qty.VisibleIndex = 5
        '
        'WQS_NotRecoverQty
        '
        Me.WQS_NotRecoverQty.Caption = "未歸還數"
        Me.WQS_NotRecoverQty.FieldName = "WQS_NotRecoverQty"
        Me.WQS_NotRecoverQty.Name = "WQS_NotRecoverQty"
        Me.WQS_NotRecoverQty.Visible = True
        Me.WQS_NotRecoverQty.VisibleIndex = 6
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 7
        '
        'WQS_Date
        '
        Me.WQS_Date.Caption = "發出日期"
        Me.WQS_Date.FieldName = "WQS_Date"
        Me.WQS_Date.Name = "WQS_Date"
        Me.WQS_Date.Visible = True
        Me.WQS_Date.VisibleIndex = 8
        '
        'UserName
        '
        Me.UserName.Caption = "操作員"
        Me.UserName.FieldName = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.Visible = True
        Me.UserName.VisibleIndex = 10
        '
        'WQS_Check
        '
        Me.WQS_Check.Caption = "審核"
        Me.WQS_Check.FieldName = "WQS_Check"
        Me.WQS_Check.Name = "WQS_Check"
        Me.WQS_Check.Visible = True
        Me.WQS_Check.VisibleIndex = 9
        '
        'WQS_Remark
        '
        Me.WQS_Remark.Caption = "備註"
        Me.WQS_Remark.FieldName = "WQS_Remark"
        Me.WQS_Remark.Name = "WQS_Remark"
        Me.WQS_Remark.Visible = True
        Me.WQS_Remark.VisibleIndex = 11
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'frmWareQCSendMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 406)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareQCSendMain"
        Me.Text = "QC抽檢管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WaraQCSend.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WQS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQS_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQS_NotRecoverQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQS_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQS_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQS_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WaraQCSend As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QCSendAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QCSendEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QCSendDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QCSendView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QCSendQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QCSendCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QCSendRef As System.Windows.Forms.ToolStripMenuItem
End Class
