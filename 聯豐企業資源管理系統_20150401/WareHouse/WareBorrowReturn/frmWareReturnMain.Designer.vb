<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareReturnMain
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
        Me.CaptionLabel = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.WareReturnContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripReturnAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripReturnAddR = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripReturnFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripReturnView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripReturnRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripReturnPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RR_PerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WB_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.TreeView1 = New System.Windows.Forms.TreeView
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WareReturnContext.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CaptionLabel.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaptionLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaptionLabel.Location = New System.Drawing.Point(7, 8)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(106, 24)
        Me.CaptionLabel.TabIndex = 173
        Me.CaptionLabel.Text = "還刀作業"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(811, 36)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.WareReturnContext
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(130, 39)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1})
        Me.Grid1.Size = New System.Drawing.Size(683, 380)
        Me.Grid1.TabIndex = 174
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'WareReturnContext
        '
        Me.WareReturnContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripReturnAdd, Me.ToolStripReturnAddR, Me.ToolStripSeparator3, Me.ToolStripReturnFind, Me.ToolStripReturnView, Me.ToolStripSeparator2, Me.ToolStripReturnRefresh, Me.ToolStripMenuItem1, Me.ToolStripReturnPrint, Me.ToolStripMenuItem2, Me.ExportToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CopyALLToolStripMenuItem})
        Me.WareReturnContext.Name = "WareBorrowContext"
        Me.WareReturnContext.Size = New System.Drawing.Size(160, 226)
        '
        'ToolStripReturnAdd
        '
        Me.ToolStripReturnAdd.Enabled = False
        Me.ToolStripReturnAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripReturnAdd.Name = "ToolStripReturnAdd"
        Me.ToolStripReturnAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ToolStripReturnAdd.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnAdd.Text = "還刀(&A)"
        '
        'ToolStripReturnAddR
        '
        Me.ToolStripReturnAddR.Enabled = False
        Me.ToolStripReturnAddR.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripReturnAddR.Name = "ToolStripReturnAddR"
        Me.ToolStripReturnAddR.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToolStripReturnAddR.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnAddR.Text = "代還刀(&B)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(156, 6)
        '
        'ToolStripReturnFind
        '
        Me.ToolStripReturnFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.ToolStripReturnFind.Name = "ToolStripReturnFind"
        Me.ToolStripReturnFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ToolStripReturnFind.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnFind.Text = "查詢(&F)"
        '
        'ToolStripReturnView
        '
        Me.ToolStripReturnView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.ToolStripReturnView.Name = "ToolStripReturnView"
        Me.ToolStripReturnView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripReturnView.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnView.Text = "查看(&W)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(156, 6)
        '
        'ToolStripReturnRefresh
        '
        Me.ToolStripReturnRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ToolStripReturnRefresh.Name = "ToolStripReturnRefresh"
        Me.ToolStripReturnRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripReturnRefresh.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnRefresh.Text = "刷新(&R)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'ToolStripReturnPrint
        '
        Me.ToolStripReturnPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ToolStripReturnPrint.Name = "ToolStripReturnPrint"
        Me.ToolStripReturnPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripReturnPrint.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripReturnPrint.Text = "還刀單(&P)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExportToolStripMenuItem.Text = "導出Excel"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CopyToolStripMenuItem.Text = "復制(&C)"
        '
        'CopyALLToolStripMenuItem
        '
        Me.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem"
        Me.CopyALLToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CopyALLToolStripMenuItem.Text = "復制全部"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.WB_NUM, Me.WB_NO, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.Qty, Me.WB_Action, Me.RR_PerName, Me.WH_Name, Me.DPT_Name, Me.WB_Date, Me.WB_ActionName})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'WB_NUM
        '
        Me.WB_NUM.Caption = "還刀流水號"
        Me.WB_NUM.FieldName = "WB_NUM"
        Me.WB_NUM.Name = "WB_NUM"
        Me.WB_NUM.OptionsColumn.ReadOnly = True
        '
        'WB_NO
        '
        Me.WB_NO.Caption = "還刀單號"
        Me.WB_NO.FieldName = "WB_NO"
        Me.WB_NO.Name = "WB_NO"
        Me.WB_NO.OptionsColumn.ReadOnly = True
        Me.WB_NO.Visible = True
        Me.WB_NO.VisibleIndex = 0
        Me.WB_NO.Width = 120
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 140
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        Me.M_Name.Width = 90
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 90
        '
        'Qty
        '
        Me.Qty.Caption = "歸還數量"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.ReadOnly = True
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 4
        '
        'WB_Action
        '
        Me.WB_Action.Caption = "還刀人"
        Me.WB_Action.FieldName = "WB_PerName"
        Me.WB_Action.Name = "WB_Action"
        Me.WB_Action.OptionsColumn.ReadOnly = True
        Me.WB_Action.Visible = True
        Me.WB_Action.VisibleIndex = 5
        '
        'RR_PerName
        '
        Me.RR_PerName.Caption = "代還人"
        Me.RR_PerName.FieldName = "RR_PerName"
        Me.RR_PerName.Name = "RR_PerName"
        Me.RR_PerName.OptionsColumn.ReadOnly = True
        Me.RR_PerName.Visible = True
        Me.RR_PerName.VisibleIndex = 6
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "倉庫名稱"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.OptionsColumn.ReadOnly = True
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 7
        '
        'DPT_Name
        '
        Me.DPT_Name.Caption = "部門"
        Me.DPT_Name.FieldName = "DPT_Name"
        Me.DPT_Name.Name = "DPT_Name"
        Me.DPT_Name.Visible = True
        Me.DPT_Name.VisibleIndex = 8
        '
        'WB_Date
        '
        Me.WB_Date.Caption = "還刀日期"
        Me.WB_Date.FieldName = "WB_Date"
        Me.WB_Date.Name = "WB_Date"
        Me.WB_Date.OptionsColumn.ReadOnly = True
        Me.WB_Date.Visible = True
        Me.WB_Date.VisibleIndex = 9
        '
        'WB_ActionName
        '
        Me.WB_ActionName.Caption = "操作人"
        Me.WB_ActionName.FieldName = "WB_ActionName"
        Me.WB_ActionName.Name = "WB_ActionName"
        Me.WB_ActionName.OptionsColumn.ReadOnly = True
        Me.WB_ActionName.Visible = True
        Me.WB_ActionName.VisibleIndex = 10
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(2, 39)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(125, 380)
        Me.TreeView1.TabIndex = 172
        '
        'frmWareReturnMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 425)
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmWareReturnMain"
        Me.Text = "還刀作業"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WareReturnContext.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents WareReturnContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripReturnAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripReturnAddR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripReturnFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripReturnView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripReturnRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RR_PerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WB_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripReturnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DPT_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
