<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerFeedback
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序

    '可以使用 Windows Form 設計工具进行修改。

    '请不要使用程式碼編輯器进行修改。

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewVerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdAddFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LSCtrlfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 21)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "客户反馈意见管理"
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 32)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1068, 533)
        Me.Grid1.TabIndex = 83
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.AddNewVerToolStripMenuItem, Me.cmdCheck, Me.cmdAddFile, Me.ToolStripSeparator1, Me.cmdDel, Me.ToolStripSeparator2, Me.RefToolStripMenuItem1, Me.LSCtrlfToolStripMenuItem, Me.FindToolStripMenuItem1, Me.ToolStripSeparator3, Me.cmdPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(183, 242)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(182, 22)
        Me.cmdAdd.Text = "增加(&A)"
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(182, 22)
        Me.cmdEdit.Text = "修改(&E)"
        '
        'AddNewVerToolStripMenuItem
        '
        Me.AddNewVerToolStripMenuItem.Enabled = False
        Me.AddNewVerToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.AddNewVerToolStripMenuItem.Name = "AddNewVerToolStripMenuItem"
        Me.AddNewVerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AddNewVerToolStripMenuItem.Text = "增加新版本"
        Me.AddNewVerToolStripMenuItem.Visible = False
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(182, 22)
        Me.cmdCheck.Text = "样版确认"
        '
        'cmdAddFile
        '
        Me.cmdAddFile.Enabled = False
        Me.cmdAddFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.cmdAddFile.Name = "cmdAddFile"
        Me.cmdAddFile.Size = New System.Drawing.Size(182, 22)
        Me.cmdAddFile.Text = "添加附件..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(182, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'RefToolStripMenuItem1
        '
        Me.RefToolStripMenuItem1.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.RefToolStripMenuItem1.Name = "RefToolStripMenuItem1"
        Me.RefToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.RefToolStripMenuItem1.Text = "刷新(&R)"
        '
        'LSCtrlfToolStripMenuItem
        '
        Me.LSCtrlfToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.LSCtrlfToolStripMenuItem.Name = "LSCtrlfToolStripMenuItem"
        Me.LSCtrlfToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.LSCtrlfToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LSCtrlfToolStripMenuItem.Text = "查看(&W)"
        '
        'FindToolStripMenuItem1
        '
        Me.FindToolStripMenuItem1.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
        Me.FindToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.FindToolStripMenuItem1.Text = "查询(&F)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(179, 6)
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.cmdPrint.Size = New System.Drawing.Size(182, 22)
        Me.cmdPrint.Text = "列印(&P)        "
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn5, Me.GridColumn14, Me.SO_OrderQty, Me.SP_Qty, Me.M_Name, Me.GridColumn13, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "日期"
        Me.GridColumn4.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "SC_Adddate"
        Me.GridColumn4.GroupFormat.FormatString = "d"
        Me.GridColumn4.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "订单编号"
        Me.GridColumn1.FieldName = "SO_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "版本号"
        Me.GridColumn5.FieldName = "SC_Edition"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 60
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "产品编号"
        Me.GridColumn14.FieldName = "PM_M_Code"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        '
        'SO_OrderQty
        '
        Me.SO_OrderQty.Caption = "订单数量"
        Me.SO_OrderQty.FieldName = "SO_OrderQty"
        Me.SO_OrderQty.Name = "SO_OrderQty"
        Me.SO_OrderQty.OptionsColumn.ReadOnly = True
        Me.SO_OrderQty.Visible = True
        Me.SO_OrderQty.VisibleIndex = 6
        '
        'SP_Qty
        '
        Me.SP_Qty.Caption = "寄送数量"
        Me.SP_Qty.FieldName = "SP_Qty"
        Me.SP_Qty.Name = "SP_Qty"
        Me.SP_Qty.OptionsColumn.ReadOnly = True
        Me.SP_Qty.Visible = True
        Me.SP_Qty.VisibleIndex = 7
        '
        'M_Name
        '
        Me.M_Name.Caption = "配件名称"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 5
        Me.M_Name.Width = 100
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "产品类別"
        Me.GridColumn13.FieldName = "M_Code"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "客戶名称"
        Me.GridColumn2.FieldName = "SC_customerid"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 92
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "客戶名称"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "客戶PO"
        Me.GridColumn6.FieldName = "SO_CusterPO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "规格描述"
        Me.GridColumn7.FieldName = "SO_Gauge"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "反馈內容"
        Me.GridColumn8.FieldName = "SC_Description"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 147
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "处理方式"
        Me.GridColumn9.FieldName = "SC_Process"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 147
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "图片"
        Me.GridColumn10.FieldName = "SC_Picture"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "样版确认"
        Me.GridColumn11.FieldName = "SC_Confirmation"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        Me.GridColumn11.Width = 112
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "AutoID"
        Me.GridColumn12.FieldName = "AutoID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1068, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'frmCustomerFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 565)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCustomerFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "客户反馈意见管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAddFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LSCtrlfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
End Class
