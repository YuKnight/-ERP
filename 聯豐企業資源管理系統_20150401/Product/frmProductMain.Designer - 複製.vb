<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.popProductMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popProductMainAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popProductMainEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popProductMainDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popProductMainCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.popProductMainReplace = New System.Windows.Forms.ToolStripMenuItem
        Me.popProductMainUpdate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popProductMainView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popProductMainFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popProductMainCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popProductMainSe = New System.Windows.Forms.ToolStripMenuItem
        Me.popProductMainPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolPrintBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Rank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Type3ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_IsEnabled = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Prod_CheckName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popProductMain.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "產品資料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(848, 36)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'popProductMain
        '
        Me.popProductMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popProductMainAdd, Me.popProductMainEdit, Me.popProductMainDel, Me.ToolStripSeparator1, Me.popProductMainCopy, Me.popProductMainReplace, Me.popProductMainUpdate, Me.ToolStripSeparator4, Me.popProductMainView, Me.ToolStripSeparator5, Me.popProductMainFile, Me.ToolStripSeparator3, Me.popProductMainCheck, Me.ToolStripCheck, Me.ToolStripSeparator2, Me.popProductMainSe, Me.popProductMainPrint, Me.ToolPrintBarCode, Me.ToolStripMenuItem1, Me.ToolStripCopy})
        Me.popProductMain.Name = "popProductMain"
        Me.popProductMain.Size = New System.Drawing.Size(178, 348)
        '
        'popProductMainAdd
        '
        Me.popProductMainAdd.Enabled = False
        Me.popProductMainAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popProductMainAdd.Name = "popProductMainAdd"
        Me.popProductMainAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popProductMainAdd.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainAdd.Text = "新增(&A)..."
        '
        'popProductMainEdit
        '
        Me.popProductMainEdit.Enabled = False
        Me.popProductMainEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popProductMainEdit.Name = "popProductMainEdit"
        Me.popProductMainEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popProductMainEdit.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainEdit.Text = "修改(&E)..."
        '
        'popProductMainDel
        '
        Me.popProductMainDel.Enabled = False
        Me.popProductMainDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popProductMainDel.Name = "popProductMainDel"
        Me.popProductMainDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popProductMainDel.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'popProductMainCopy
        '
        Me.popProductMainCopy.Enabled = False
        Me.popProductMainCopy.Image = Global.LFERP.My.Resources.Resources.SmartArtRightToLeft
        Me.popProductMainCopy.Name = "popProductMainCopy"
        Me.popProductMainCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popProductMainCopy.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainCopy.Text = "復制(&C)..."
        '
        'popProductMainReplace
        '
        Me.popProductMainReplace.Enabled = False
        Me.popProductMainReplace.Name = "popProductMainReplace"
        Me.popProductMainReplace.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainReplace.Text = "更新配件(&U)..."
        '
        'popProductMainUpdate
        '
        Me.popProductMainUpdate.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popProductMainUpdate.Name = "popProductMainUpdate"
        Me.popProductMainUpdate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popProductMainUpdate.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainUpdate.Text = "刷新(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(174, 6)
        '
        'popProductMainView
        '
        Me.popProductMainView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popProductMainView.Name = "popProductMainView"
        Me.popProductMainView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popProductMainView.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainView.Text = "查看(&W)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(174, 6)
        '
        'popProductMainFile
        '
        Me.popProductMainFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popProductMainFile.Name = "popProductMainFile"
        Me.popProductMainFile.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainFile.Text = "附加文件(&B)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(174, 6)
        '
        'popProductMainCheck
        '
        Me.popProductMainCheck.Enabled = False
        Me.popProductMainCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popProductMainCheck.Name = "popProductMainCheck"
        Me.popProductMainCheck.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainCheck.Text = "核對資料(&K)..."
        '
        'ToolStripCheck
        '
        Me.ToolStripCheck.Enabled = False
        Me.ToolStripCheck.Name = "ToolStripCheck"
        Me.ToolStripCheck.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripCheck.Text = "審核(&G)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'popProductMainSe
        '
        Me.popProductMainSe.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popProductMainSe.Name = "popProductMainSe"
        Me.popProductMainSe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popProductMainSe.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainSe.Text = "查詢(&F)..."
        '
        'popProductMainPrint
        '
        Me.popProductMainPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popProductMainPrint.Name = "popProductMainPrint"
        Me.popProductMainPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popProductMainPrint.Size = New System.Drawing.Size(177, 22)
        Me.popProductMainPrint.Text = "列印(&P)..."
        '
        'ToolPrintBarCode
        '
        Me.ToolPrintBarCode.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.ToolPrintBarCode.Name = "ToolPrintBarCode"
        Me.ToolPrintBarCode.Size = New System.Drawing.Size(177, 22)
        Me.ToolPrintBarCode.Text = "列印刀具條碼"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'ToolStripCopy
        '
        Me.ToolStripCopy.Name = "ToolStripCopy"
        Me.ToolStripCopy.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripCopy.Text = "復制全部"
        '
        'tv1
        '
        Me.tv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.FullRowSelect = True
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(2, 43)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(187, 474)
        Me.tv1.TabIndex = 34
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popProductMain
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(193, 43)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(659, 474)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code, Me.PM_CusterID, Me.PM_CusterNO, Me.M_Gauge, Me.PM_JiYu, Me.PM_Rank, Me.PM_Remark, Me.PM_AddDate, Me.PM_EditDate, Me.PM_Action, Me.PM_ActionName, Me.Type3ID, Me.M_IsEnabled, Me.Prod_CheckName})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        Me.PM_M_Code.Width = 100
        '
        'PM_CusterID
        '
        Me.PM_CusterID.Caption = "客戶代號"
        Me.PM_CusterID.FieldName = "PM_CusterID"
        Me.PM_CusterID.Name = "PM_CusterID"
        Me.PM_CusterID.OptionsColumn.ReadOnly = True
        Me.PM_CusterID.Visible = True
        Me.PM_CusterID.VisibleIndex = 1
        Me.PM_CusterID.Width = 65
        '
        'PM_CusterNO
        '
        Me.PM_CusterNO.Caption = "客戶編號"
        Me.PM_CusterNO.FieldName = "PM_CusterNO"
        Me.PM_CusterNO.Name = "PM_CusterNO"
        Me.PM_CusterNO.OptionsColumn.ReadOnly = True
        Me.PM_CusterNO.Visible = True
        Me.PM_CusterNO.VisibleIndex = 2
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "產品規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "別名"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.ReadOnly = True
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 4
        '
        'PM_Rank
        '
        Me.PM_Rank.Caption = "等級"
        Me.PM_Rank.FieldName = "PM_Rank"
        Me.PM_Rank.Name = "PM_Rank"
        Me.PM_Rank.OptionsColumn.ReadOnly = True
        Me.PM_Rank.Visible = True
        Me.PM_Rank.VisibleIndex = 5
        Me.PM_Rank.Width = 60
        '
        'PM_Remark
        '
        Me.PM_Remark.Caption = "備注"
        Me.PM_Remark.FieldName = "PM_Remark"
        Me.PM_Remark.Name = "PM_Remark"
        Me.PM_Remark.OptionsColumn.ReadOnly = True
        Me.PM_Remark.Visible = True
        Me.PM_Remark.VisibleIndex = 6
        '
        'PM_AddDate
        '
        Me.PM_AddDate.Caption = "建立日期"
        Me.PM_AddDate.FieldName = "PM_AddDate"
        Me.PM_AddDate.Name = "PM_AddDate"
        Me.PM_AddDate.OptionsColumn.ReadOnly = True
        Me.PM_AddDate.Visible = True
        Me.PM_AddDate.VisibleIndex = 7
        '
        'PM_EditDate
        '
        Me.PM_EditDate.Caption = "最後修改日期"
        Me.PM_EditDate.FieldName = "PM_EditDate"
        Me.PM_EditDate.Name = "PM_EditDate"
        Me.PM_EditDate.OptionsColumn.ReadOnly = True
        Me.PM_EditDate.Visible = True
        Me.PM_EditDate.VisibleIndex = 8
        Me.PM_EditDate.Width = 85
        '
        'PM_Action
        '
        Me.PM_Action.Caption = "操作員"
        Me.PM_Action.FieldName = "PM_Action"
        Me.PM_Action.Name = "PM_Action"
        Me.PM_Action.OptionsColumn.ReadOnly = True
        Me.PM_Action.Width = 60
        '
        'PM_ActionName
        '
        Me.PM_ActionName.Caption = "操作員"
        Me.PM_ActionName.FieldName = "PM_ActionName"
        Me.PM_ActionName.Name = "PM_ActionName"
        Me.PM_ActionName.OptionsColumn.ReadOnly = True
        Me.PM_ActionName.Visible = True
        Me.PM_ActionName.VisibleIndex = 9
        '
        'Type3ID
        '
        Me.Type3ID.Caption = "Type3ID"
        Me.Type3ID.FieldName = "Type3ID"
        Me.Type3ID.Name = "Type3ID"
        Me.Type3ID.OptionsColumn.ReadOnly = True
        '
        'M_IsEnabled
        '
        Me.M_IsEnabled.Caption = "審核"
        Me.M_IsEnabled.FieldName = "M_IsEnabled"
        Me.M_IsEnabled.Name = "M_IsEnabled"
        Me.M_IsEnabled.OptionsColumn.ReadOnly = True
        Me.M_IsEnabled.Visible = True
        Me.M_IsEnabled.VisibleIndex = 10
        Me.M_IsEnabled.Width = 50
        '
        'Prod_CheckName
        '
        Me.Prod_CheckName.Caption = "審核人"
        Me.Prod_CheckName.FieldName = "Prod_CheckName"
        Me.Prod_CheckName.Name = "Prod_CheckName"
        Me.Prod_CheckName.OptionsColumn.ReadOnly = True
        Me.Prod_CheckName.Visible = True
        Me.Prod_CheckName.VisibleIndex = 11
        '
        'frmProductMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 524)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.tv1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmProductMain"
        Me.Text = "產品資料"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popProductMain.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popProductMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popProductMainAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProductMainEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProductMainDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProductMainCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProductMainUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProductMainCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProductMainPrint As System.Windows.Forms.ToolStripMenuItem

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents popProductMainFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProductMainSe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popProductMainView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProductMainReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolPrintBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Type3ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_IsEnabled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Prod_CheckName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PM_Remark As DevExpress.XtraGrid.Columns.GridColumn
End Class
