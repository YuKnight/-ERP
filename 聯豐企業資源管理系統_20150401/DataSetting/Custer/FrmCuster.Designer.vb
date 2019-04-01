<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuster
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
        Me.cmdcontext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCopyAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExportl = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.View = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_EngName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_ChsName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Link = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Adder4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Department = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SendSignedItem = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.C_Email = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmdcontext.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendSignedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(938, 36)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "客戶資料"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.cmdcontext
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(3, 39)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SendSignedItem})
        Me.Grid1.Size = New System.Drawing.Size(935, 345)
        Me.Grid1.TabIndex = 79
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmdcontext
        '
        Me.cmdcontext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdCopy, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdCopyAll, Me.cmdExportl, Me.ToolStripSeparator2, Me.cmdRef, Me.View})
        Me.cmdcontext.Name = "ContextMenuStrip1"
        Me.cmdcontext.Size = New System.Drawing.Size(193, 192)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(192, 22)
        Me.cmdAdd.Text = "新增(&A)          Ctrl+A"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(192, 22)
        Me.cmdEdit.Text = "修改(&E)          Ctrl+E"
        '
        'cmdCopy
        '
        Me.cmdCopy.Enabled = False
        Me.cmdCopy.Image = Global.LFERP.My.Resources.Resources.SmartArtEditIn2D
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(192, 22)
        Me.cmdCopy.Text = "複製(&C)          Ctrl+C"
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(192, 22)
        Me.cmdDel.Text = "刪除(&D)          Ctrl+D"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'cmdCopyAll
        '
        Me.cmdCopyAll.Enabled = False
        Me.cmdCopyAll.Image = Global.LFERP.My.Resources.Resources.SmartArtOrganizationChartRightHanging
        Me.cmdCopyAll.Name = "cmdCopyAll"
        Me.cmdCopyAll.Size = New System.Drawing.Size(192, 22)
        Me.cmdCopyAll.Text = "全部複製(&All)    Ctrl+L"
        '
        'cmdExportl
        '
        Me.cmdExportl.Enabled = False
        Me.cmdExportl.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExportl.Name = "cmdExportl"
        Me.cmdExportl.Size = New System.Drawing.Size(192, 22)
        Me.cmdExportl.Text = "導出(&O)         Ctrl+O"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.Size = New System.Drawing.Size(192, 22)
        Me.cmdRef.Text = "刷新(&R)          Ctrl+R"
        '
        'View
        '
        Me.View.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(192, 22)
        Me.View.Text = "查看(&R)          Ctrl+R"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_CusterID, Me.C_EngName, Me.C_ChsName, Me.C_Link, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.C_Adder4, Me.C_Department, Me.C_Email})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'C_CusterID
        '
        Me.C_CusterID.Caption = "客戶代號"
        Me.C_CusterID.FieldName = "C_CusterID"
        Me.C_CusterID.Name = "C_CusterID"
        Me.C_CusterID.Visible = True
        Me.C_CusterID.VisibleIndex = 0
        '
        'C_EngName
        '
        Me.C_EngName.Caption = "英文名"
        Me.C_EngName.FieldName = "C_EngName"
        Me.C_EngName.Name = "C_EngName"
        Me.C_EngName.Visible = True
        Me.C_EngName.VisibleIndex = 1
        '
        'C_ChsName
        '
        Me.C_ChsName.Caption = "中文名"
        Me.C_ChsName.FieldName = "C_ChsName"
        Me.C_ChsName.Name = "C_ChsName"
        Me.C_ChsName.Visible = True
        Me.C_ChsName.VisibleIndex = 2
        '
        'C_Link
        '
        Me.C_Link.Caption = "聯系人"
        Me.C_Link.FieldName = "C_Link"
        Me.C_Link.Name = "C_Link"
        Me.C_Link.Visible = True
        Me.C_Link.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "聯系電話"
        Me.GridColumn5.FieldName = "C_LinkTel"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "傳真號碼"
        Me.GridColumn6.FieldName = "C_Fax"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "建交日期"
        Me.GridColumn7.FieldName = "C_AddDate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "地址"
        Me.GridColumn8.FieldName = "C_Adder1"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "城市"
        Me.GridColumn9.FieldName = "C_Adder2"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "國家"
        Me.GridColumn10.FieldName = "C_Adder3"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'C_Adder4
        '
        Me.C_Adder4.Caption = "客戶地址4"
        Me.C_Adder4.FieldName = "C_Adder4"
        Me.C_Adder4.Name = "C_Adder4"
        '
        'C_Department
        '
        Me.C_Department.Caption = "部門"
        Me.C_Department.FieldName = "C_Department"
        Me.C_Department.Name = "C_Department"
        Me.C_Department.Visible = True
        Me.C_Department.VisibleIndex = 10
        '
        'SendSignedItem
        '
        Me.SendSignedItem.AutoHeight = False
        Me.SendSignedItem.Name = "SendSignedItem"
        '
        'C_Email
        '
        Me.C_Email.Caption = "邮箱地址"
        Me.C_Email.FieldName = "C_Email"
        Me.C_Email.Name = "C_Email"
        Me.C_Email.Visible = True
        Me.C_Email.VisibleIndex = 11
        '
        'FrmCuster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 384)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmCuster"
        Me.Text = "FrmCuster"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmdcontext.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendSignedItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SendSignedItem As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents C_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_EngName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_ChsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Link As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Adder4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdcontext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopyAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExportl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents C_Email As DevExpress.XtraGrid.Columns.GridColumn
End Class
