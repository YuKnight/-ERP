<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareChangeMain
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
        Me.popChangeReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangeFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popChangeSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popChangePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_ChangeNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popChange.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.Size = New System.Drawing.Size(866, 36)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "倉庫更改單管理"
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
        Me.Grid1.Size = New System.Drawing.Size(866, 493)
        Me.Grid1.TabIndex = 166
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popChange
        '
        Me.popChange.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popChangeAdd, Me.popChangeEdit, Me.popChangeDel, Me.popChangeView, Me.ToolStripSeparator1, Me.popChangeCheck, Me.popChangeReCheck, Me.ToolStripSeparator3, Me.popChangeRef, Me.popChangeFile, Me.ToolStripSeparator2, Me.popChangeSeek, Me.popChangePrint})
        Me.popChange.Name = "popAcceptance"
        Me.popChange.Size = New System.Drawing.Size(181, 264)
        '
        'popChangeAdd
        '
        Me.popChangeAdd.Enabled = False
        Me.popChangeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popChangeAdd.Name = "popChangeAdd"
        Me.popChangeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popChangeAdd.Size = New System.Drawing.Size(180, 22)
        Me.popChangeAdd.Text = "暫改庫存數"
        '
        'popChangeEdit
        '
        Me.popChangeEdit.Enabled = False
        Me.popChangeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popChangeEdit.Name = "popChangeEdit"
        Me.popChangeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popChangeEdit.Size = New System.Drawing.Size(180, 22)
        Me.popChangeEdit.Text = "修改"
        '
        'popChangeDel
        '
        Me.popChangeDel.Enabled = False
        Me.popChangeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popChangeDel.Name = "popChangeDel"
        Me.popChangeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popChangeDel.Size = New System.Drawing.Size(180, 22)
        Me.popChangeDel.Text = "刪除"
        '
        'popChangeView
        '
        Me.popChangeView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popChangeView.Name = "popChangeView"
        Me.popChangeView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.popChangeView.Size = New System.Drawing.Size(180, 22)
        Me.popChangeView.Text = "查看"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'popChangeCheck
        '
        Me.popChangeCheck.Enabled = False
        Me.popChangeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popChangeCheck.Name = "popChangeCheck"
        Me.popChangeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popChangeCheck.Size = New System.Drawing.Size(180, 22)
        Me.popChangeCheck.Text = "審核"
        '
        'popChangeReCheck
        '
        Me.popChangeReCheck.Enabled = False
        Me.popChangeReCheck.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popChangeReCheck.Name = "popChangeReCheck"
        Me.popChangeReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popChangeReCheck.Size = New System.Drawing.Size(180, 22)
        Me.popChangeReCheck.Text = "復核"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'popChangeRef
        '
        Me.popChangeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popChangeRef.Name = "popChangeRef"
        Me.popChangeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popChangeRef.Size = New System.Drawing.Size(180, 22)
        Me.popChangeRef.Text = "刷新"
        '
        'popChangeFile
        '
        Me.popChangeFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popChangeFile.Name = "popChangeFile"
        Me.popChangeFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popChangeFile.Size = New System.Drawing.Size(180, 22)
        Me.popChangeFile.Text = "附加文件"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'popChangeSeek
        '
        Me.popChangeSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popChangeSeek.Name = "popChangeSeek"
        Me.popChangeSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.popChangeSeek.Size = New System.Drawing.Size(180, 22)
        Me.popChangeSeek.Text = "查詢"
        '
        'popChangePrint
        '
        Me.popChangePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popChangePrint.Name = "popChangePrint"
        Me.popChangePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popChangePrint.Size = New System.Drawing.Size(180, 22)
        Me.popChangePrint.Text = "更改單"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_ChangeNO, Me.WH_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.GridColumn1, Me.C_Qty, Me.C_Date, Me.ActionName, Me.C_Check, Me.CheckActionName, Me.C_ReCheck})
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
        Me.C_ChangeNO.Width = 85
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫名稱"
        Me.WH_ID.FieldName = "WH_Name"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 1
        Me.WH_ID.Width = 80
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 115
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "更改前數量"
        Me.GridColumn1.FieldName = "WI_Qty"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'C_Qty
        '
        Me.C_Qty.Caption = "更改后數量"
        Me.C_Qty.FieldName = "C_Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.Visible = True
        Me.C_Qty.VisibleIndex = 6
        '
        'C_Date
        '
        Me.C_Date.Caption = "更改日期"
        Me.C_Date.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.C_Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.C_Date.FieldName = "C_Date"
        Me.C_Date.GroupFormat.FormatString = "yyyy/MM/dd HH:mm:ss"
        Me.C_Date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.C_Date.Name = "C_Date"
        Me.C_Date.Visible = True
        Me.C_Date.VisibleIndex = 7
        Me.C_Date.Width = 99
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 8
        Me.ActionName.Width = 65
        '
        'C_Check
        '
        Me.C_Check.Caption = "審核"
        Me.C_Check.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.C_Check.FieldName = "C_Check"
        Me.C_Check.Name = "C_Check"
        Me.C_Check.Visible = True
        Me.C_Check.VisibleIndex = 9
        Me.C_Check.Width = 50
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'CheckActionName
        '
        Me.CheckActionName.Caption = "審核員"
        Me.CheckActionName.FieldName = "CheckActionName"
        Me.CheckActionName.Name = "CheckActionName"
        Me.CheckActionName.Visible = True
        Me.CheckActionName.VisibleIndex = 10
        Me.CheckActionName.Width = 65
        '
        'C_ReCheck
        '
        Me.C_ReCheck.Caption = "復核"
        Me.C_ReCheck.FieldName = "C_ReCheck"
        Me.C_ReCheck.Name = "C_ReCheck"
        Me.C_ReCheck.Visible = True
        Me.C_ReCheck.VisibleIndex = 11
        Me.C_ReCheck.Width = 60
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'frmWareChangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 531)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareChangeMain"
        Me.Text = "倉庫更改單管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popChange.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C_ChangeNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents C_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents popChangeReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
