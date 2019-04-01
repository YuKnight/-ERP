<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareQualityMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.popWQ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWQAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWQEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popWQDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWQRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popWQView = New System.Windows.Forms.ToolStripMenuItem
        Me.popWQFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWQAddFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popWQPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WQ_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyDptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQ_Description = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQ_UserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Opinion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_UserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ACC_Opinion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWQ.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(806, 36)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "物料品質反饋"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.popWQ
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 37)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(806, 506)
        Me.Grid.TabIndex = 37
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWQ
        '
        Me.popWQ.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWQAdd, Me.popWQEdit, Me.popWQDelete, Me.ToolStripSeparator1, Me.popWQRef, Me.popWQView, Me.popWQFind, Me.ToolStripSeparator2, Me.popWQAddFile, Me.popWQPrint})
        Me.popWQ.Name = "popWQ"
        Me.popWQ.Size = New System.Drawing.Size(189, 214)
        '
        'popWQAdd
        '
        Me.popWQAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWQAdd.Name = "popWQAdd"
        Me.popWQAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWQAdd.Size = New System.Drawing.Size(188, 22)
        Me.popWQAdd.Text = "添加(&A)..."
        '
        'popWQEdit
        '
        Me.popWQEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWQEdit.Name = "popWQEdit"
        Me.popWQEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWQEdit.Size = New System.Drawing.Size(188, 22)
        Me.popWQEdit.Text = "修改(&E)..."
        '
        'popWQDelete
        '
        Me.popWQDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWQDelete.Name = "popWQDelete"
        Me.popWQDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWQDelete.Size = New System.Drawing.Size(188, 22)
        Me.popWQDelete.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'popWQRef
        '
        Me.popWQRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popWQRef.Name = "popWQRef"
        Me.popWQRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popWQRef.Size = New System.Drawing.Size(188, 22)
        Me.popWQRef.Text = "刷新(&R)"
        '
        'popWQView
        '
        Me.popWQView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWQView.Name = "popWQView"
        Me.popWQView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWQView.Size = New System.Drawing.Size(188, 22)
        Me.popWQView.Text = "查看(&W)..."
        '
        'popWQFind
        '
        Me.popWQFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWQFind.Name = "popWQFind"
        Me.popWQFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWQFind.Size = New System.Drawing.Size(188, 22)
        Me.popWQFind.Text = "查詢(&F)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'popWQAddFile
        '
        Me.popWQAddFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popWQAddFile.Name = "popWQAddFile"
        Me.popWQAddFile.Size = New System.Drawing.Size(188, 22)
        Me.popWQAddFile.Text = "附加文件(&B)..."
        '
        'popWQPrint
        '
        Me.popWQPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWQPrint.Name = "popWQPrint"
        Me.popWQPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWQPrint.Size = New System.Drawing.Size(188, 22)
        Me.popWQPrint.Text = "打印(&P)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WQ_Code, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.AP_ApplyDptName, Me.WO_ID, Me.WO_Qty, Me.M_Unit, Me.WQ_Description, Me.WQ_UserName, Me.PS_Opinion, Me.PS_UserName, Me.ACC_Opinion, Me.AddUser, Me.AddDate})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.SmartVertScrollBar = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'WQ_Code
        '
        Me.WQ_Code.Caption = "反饋單編號"
        Me.WQ_Code.FieldName = "WQ_Code"
        Me.WQ_Code.Name = "WQ_Code"
        Me.WQ_Code.OptionsColumn.ReadOnly = True
        Me.WQ_Code.Visible = True
        Me.WQ_Code.VisibleIndex = 0
        Me.WQ_Code.Width = 80
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Width = 97
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 76
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 98
        '
        'AP_ApplyDptName
        '
        Me.AP_ApplyDptName.Caption = "反饋部門"
        Me.AP_ApplyDptName.FieldName = "AP_ApplyDptName"
        Me.AP_ApplyDptName.Name = "AP_ApplyDptName"
        Me.AP_ApplyDptName.OptionsColumn.ReadOnly = True
        Me.AP_ApplyDptName.Visible = True
        Me.AP_ApplyDptName.VisibleIndex = 3
        Me.AP_ApplyDptName.Width = 77
        '
        'WO_ID
        '
        Me.WO_ID.Caption = "物料發出單號"
        Me.WO_ID.FieldName = "WO_ID"
        Me.WO_ID.Name = "WO_ID"
        Me.WO_ID.OptionsColumn.ReadOnly = True
        Me.WO_ID.Visible = True
        Me.WO_ID.VisibleIndex = 4
        Me.WO_ID.Width = 100
        '
        'WO_Qty
        '
        Me.WO_Qty.Caption = "發出數量"
        Me.WO_Qty.FieldName = "WO_Qty"
        Me.WO_Qty.Name = "WO_Qty"
        Me.WO_Qty.OptionsColumn.ReadOnly = True
        Me.WO_Qty.Visible = True
        Me.WO_Qty.VisibleIndex = 5
        Me.WO_Qty.Width = 60
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 6
        Me.M_Unit.Width = 41
        '
        'WQ_Description
        '
        Me.WQ_Description.Caption = "品質問題描述"
        Me.WQ_Description.FieldName = "WQ_Description"
        Me.WQ_Description.Name = "WQ_Description"
        Me.WQ_Description.OptionsColumn.ReadOnly = True
        Me.WQ_Description.Visible = True
        Me.WQ_Description.VisibleIndex = 7
        Me.WQ_Description.Width = 93
        '
        'WQ_UserName
        '
        Me.WQ_UserName.Caption = "反饋人"
        Me.WQ_UserName.FieldName = "WQ_UserName"
        Me.WQ_UserName.Name = "WQ_UserName"
        Me.WQ_UserName.OptionsColumn.ReadOnly = True
        Me.WQ_UserName.Visible = True
        Me.WQ_UserName.VisibleIndex = 8
        Me.WQ_UserName.Width = 56
        '
        'PS_Opinion
        '
        Me.PS_Opinion.Caption = "採購部意見"
        Me.PS_Opinion.FieldName = "PS_Opinion"
        Me.PS_Opinion.Name = "PS_Opinion"
        Me.PS_Opinion.OptionsColumn.ReadOnly = True
        Me.PS_Opinion.Width = 48
        '
        'PS_UserName
        '
        Me.PS_UserName.Caption = "採購員"
        Me.PS_UserName.FieldName = "PS_UserName"
        Me.PS_UserName.Name = "PS_UserName"
        Me.PS_UserName.OptionsColumn.ReadOnly = True
        Me.PS_UserName.Width = 48
        '
        'ACC_Opinion
        '
        Me.ACC_Opinion.Caption = "審計部意見"
        Me.ACC_Opinion.FieldName = "ACC_Opinion"
        Me.ACC_Opinion.Name = "ACC_Opinion"
        Me.ACC_Opinion.OptionsColumn.ReadOnly = True
        Me.ACC_Opinion.Width = 48
        '
        'AddUser
        '
        Me.AddUser.Caption = "添加人"
        Me.AddUser.FieldName = "AddUser"
        Me.AddUser.Name = "AddUser"
        Me.AddUser.OptionsColumn.ReadOnly = True
        Me.AddUser.Width = 48
        '
        'AddDate
        '
        Me.AddDate.Caption = "添加日期"
        Me.AddDate.FieldName = "AddDate"
        Me.AddDate.Name = "AddDate"
        Me.AddDate.OptionsColumn.ReadOnly = True
        Me.AddDate.Visible = True
        Me.AddDate.VisibleIndex = 9
        Me.AddDate.Width = 72
        '
        'frmWareQualityMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 544)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareQualityMain"
        Me.Text = "物料品質反饋"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWQ.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WQ_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyDptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQ_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQ_UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Opinion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ACC_Opinion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWQ As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWQAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWQEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWQDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWQView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWQFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popWQPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWQRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWQAddFile As System.Windows.Forms.ToolStripMenuItem
End Class
