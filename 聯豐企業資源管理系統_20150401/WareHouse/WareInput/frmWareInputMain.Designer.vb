<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareInputMain
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
        Dim WIP_AddDate As DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.twWare = New System.Windows.Forms.TreeView
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popWareInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popWareInputAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputAddBarCode = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyRemarkTool = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInputCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popWareInputReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputView = New System.Windows.Forms.ToolStripMenuItem
        Me.popwareinputflesh = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popwareInputLoadFile = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareInputPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WIP_NUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_AllName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WIP_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.COPYall = New System.Windows.Forms.ToolStripMenuItem
        WIP_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareInput.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WIP_AddDate
        '
        WIP_AddDate.Caption = "入庫日期"
        WIP_AddDate.FieldName = "WIP_AddDate"
        WIP_AddDate.Name = "WIP_AddDate"
        WIP_AddDate.Visible = True
        WIP_AddDate.VisibleIndex = 5
        WIP_AddDate.Width = 80
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.twWare)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(745, 460)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 40
        '
        'twWare
        '
        Me.twWare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twWare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twWare.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.twWare.FullRowSelect = True
        Me.twWare.HideSelection = False
        Me.twWare.Location = New System.Drawing.Point(0, 0)
        Me.twWare.Name = "twWare"
        Me.twWare.Size = New System.Drawing.Size(125, 460)
        Me.twWare.TabIndex = 41
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popWareInput
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(616, 460)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'popWareInput
        '
        Me.popWareInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popWareInputAdd, Me.popWareInputAddBarCode, Me.popWareInputEdit, Me.ModifyRemarkTool, Me.popWareInputDel, Me.ToolStripSeparator1, Me.popWareInputCheck, Me.ToolStripSeparator2, Me.popWareInputReCheck, Me.popWareInputView, Me.popwareinputflesh, Me.popWareInputSeek, Me.ToolStripSeparator3, Me.popwareInputLoadFile, Me.popWareInputPrint, Me.ExportStripMenuItem, Me.COPYToolStripMenuItem, Me.COPYall})
        Me.popWareInput.Name = "popWareInput"
        Me.popWareInput.Size = New System.Drawing.Size(196, 374)
        '
        'popWareInputAdd
        '
        Me.popWareInputAdd.Enabled = False
        Me.popWareInputAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareInputAdd.Name = "popWareInputAdd"
        Me.popWareInputAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareInputAdd.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputAdd.Text = "新增(&A)..."
        '
        'popWareInputAddBarCode
        '
        Me.popWareInputAddBarCode.Enabled = False
        Me.popWareInputAddBarCode.Name = "popWareInputAddBarCode"
        Me.popWareInputAddBarCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.popWareInputAddBarCode.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputAddBarCode.Text = "新增(條碼掃描)(&J)"
        '
        'popWareInputEdit
        '
        Me.popWareInputEdit.Enabled = False
        Me.popWareInputEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popWareInputEdit.Name = "popWareInputEdit"
        Me.popWareInputEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popWareInputEdit.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputEdit.Text = "修改(&E)..."
        '
        'ModifyRemarkTool
        '
        Me.ModifyRemarkTool.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ModifyRemarkTool.Name = "ModifyRemarkTool"
        Me.ModifyRemarkTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ModifyRemarkTool.Size = New System.Drawing.Size(195, 22)
        Me.ModifyRemarkTool.Text = "修改備注(&K)"
        '
        'popWareInputDel
        '
        Me.popWareInputDel.Enabled = False
        Me.popWareInputDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareInputDel.Name = "popWareInputDel"
        Me.popWareInputDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareInputDel.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'popWareInputCheck
        '
        Me.popWareInputCheck.Enabled = False
        Me.popWareInputCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareInputCheck.Name = "popWareInputCheck"
        Me.popWareInputCheck.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputCheck.Text = "取消審核"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'popWareInputReCheck
        '
        Me.popWareInputReCheck.Enabled = False
        Me.popWareInputReCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popWareInputReCheck.Name = "popWareInputReCheck"
        Me.popWareInputReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popWareInputReCheck.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputReCheck.Text = "復核(&G)..."
        '
        'popWareInputView
        '
        Me.popWareInputView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popWareInputView.Name = "popWareInputView"
        Me.popWareInputView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popWareInputView.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputView.Text = "查看(&W)..."
        '
        'popwareinputflesh
        '
        Me.popwareinputflesh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popwareinputflesh.Name = "popwareinputflesh"
        Me.popwareinputflesh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popwareinputflesh.Size = New System.Drawing.Size(195, 22)
        Me.popwareinputflesh.Text = "刷新(&R)"
        '
        'popWareInputSeek
        '
        Me.popWareInputSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popWareInputSeek.Name = "popWareInputSeek"
        Me.popWareInputSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popWareInputSeek.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputSeek.Text = "查詢(&F)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'popwareInputLoadFile
        '
        Me.popwareInputLoadFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popwareInputLoadFile.Name = "popwareInputLoadFile"
        Me.popwareInputLoadFile.Size = New System.Drawing.Size(195, 22)
        Me.popwareInputLoadFile.Text = "附加文件(&B)..."
        '
        'popWareInputPrint
        '
        Me.popWareInputPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popWareInputPrint.Name = "popWareInputPrint"
        Me.popWareInputPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popWareInputPrint.Size = New System.Drawing.Size(195, 22)
        Me.popWareInputPrint.Text = "入庫單(&P)..."
        '
        'ExportStripMenuItem
        '
        Me.ExportStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExportStripMenuItem.Name = "ExportStripMenuItem"
        Me.ExportStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExportStripMenuItem.Text = "導出(&U)..."
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.COPYToolStripMenuItem.Text = "復制(&C)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WIP_NUM, Me.WIP_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WIP_Qty, Me.M_Unit, Me.WH_AllName, Me.WIP_Remark, Me.OS_BatchID, Me.WIP_ActionName, Me.WIP_Check, WIP_AddDate, Me.WIP_CheckRemark, Me.GridColumn1})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
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
        'WIP_NUM
        '
        Me.WIP_NUM.Caption = "唯一編號"
        Me.WIP_NUM.FieldName = "WIP_NUM"
        Me.WIP_NUM.Name = "WIP_NUM"
        '
        'WIP_ID
        '
        Me.WIP_ID.Caption = "入庫單號"
        Me.WIP_ID.FieldName = "WIP_ID"
        Me.WIP_ID.Name = "WIP_ID"
        Me.WIP_ID.Visible = True
        Me.WIP_ID.VisibleIndex = 0
        Me.WIP_ID.Width = 90
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 125
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
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        Me.M_Gauge.Width = 100
        '
        'WIP_Qty
        '
        Me.WIP_Qty.Caption = "入庫數量"
        Me.WIP_Qty.FieldName = "WIP_Qty"
        Me.WIP_Qty.Name = "WIP_Qty"
        Me.WIP_Qty.Visible = True
        Me.WIP_Qty.VisibleIndex = 4
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 6
        '
        'WH_AllName
        '
        Me.WH_AllName.Caption = "倉庫名稱"
        Me.WH_AllName.FieldName = "WH_AllName"
        Me.WH_AllName.Name = "WH_AllName"
        Me.WH_AllName.Visible = True
        Me.WH_AllName.VisibleIndex = 7
        '
        'WIP_Remark
        '
        Me.WIP_Remark.Caption = "備註"
        Me.WIP_Remark.FieldName = "WIP_Remark"
        Me.WIP_Remark.Name = "WIP_Remark"
        Me.WIP_Remark.Visible = True
        Me.WIP_Remark.VisibleIndex = 8
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        '
        'WIP_ActionName
        '
        Me.WIP_ActionName.Caption = "操作員"
        Me.WIP_ActionName.FieldName = "WIP_ActionName"
        Me.WIP_ActionName.Name = "WIP_ActionName"
        Me.WIP_ActionName.Visible = True
        Me.WIP_ActionName.VisibleIndex = 9
        '
        'WIP_Check
        '
        Me.WIP_Check.Caption = "審核"
        Me.WIP_Check.FieldName = "WIP_Check"
        Me.WIP_Check.Name = "WIP_Check"
        Me.WIP_Check.Width = 50
        '
        'WIP_CheckRemark
        '
        Me.WIP_CheckRemark.Caption = "審核備注"
        Me.WIP_CheckRemark.FieldName = "WIP_CheckRemark"
        Me.WIP_CheckRemark.Name = "WIP_CheckRemark"
        Me.WIP_CheckRemark.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "復核"
        Me.GridColumn1.FieldName = "WIP_ReCheck"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "入庫作業"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(745, 36)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'COPYall
        '
        Me.COPYall.Name = "COPYall"
        Me.COPYall.Size = New System.Drawing.Size(195, 22)
        Me.COPYall.Text = "全部復制"
        '
        'frmWareInputMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 505)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareInputMain"
        Me.Text = "入庫作業"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareInput.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents twWare As System.Windows.Forms.TreeView
    Friend WithEvents popWareInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popWareInputAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WIP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WIP_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popwareinputflesh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popwareInputLoadFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareInputReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WIP_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WH_AllName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popWareInputAddBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRemarkTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYall As System.Windows.Forms.ToolStripMenuItem
End Class
