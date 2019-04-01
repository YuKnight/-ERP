<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplyPurchaseMain
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
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdHandle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_Applyreason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyPersonName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyDptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_CheckWare = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.AP_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_CheckType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ReCheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ReCheckType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_QTY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.Size = New System.Drawing.Size(794, 34)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "申購單管理"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.MenuStrip
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 35)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(794, 292)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDel, Me.ToolStripSeparator1, Me.cmdHandle, Me.ToolStripSeparator3, Me.cmdCheck, Me.cmdReCheck, Me.ToolStripSeparator5, Me.cmdRef, Me.ToolStripSeparator6, Me.cmdView, Me.cmdQuery})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(191, 226)
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.OutlineSettings
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(190, 22)
        Me.cmdAdd.Text = "新增(&A)..."
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(190, 22)
        Me.cmdEdit.Text = "修改(&E)..."
        '
        'cmdDel
        '
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(190, 22)
        Me.cmdDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'cmdHandle
        '
        Me.cmdHandle.Enabled = False
        Me.cmdHandle.Image = Global.LFERP.My.Resources.Resources.AdvancedFileProperties
        Me.cmdHandle.Name = "cmdHandle"
        Me.cmdHandle.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.cmdHandle.Size = New System.Drawing.Size(190, 22)
        Me.cmdHandle.Text = "申購單處理(&Z)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(187, 6)
        '
        'cmdCheck
        '
        Me.cmdCheck.Enabled = False
        Me.cmdCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.cmdCheck.Size = New System.Drawing.Size(190, 22)
        Me.cmdCheck.Text = "審核(&G)..."
        '
        'cmdReCheck
        '
        Me.cmdReCheck.Enabled = False
        Me.cmdReCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.cmdReCheck.Name = "cmdReCheck"
        Me.cmdReCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmdReCheck.Size = New System.Drawing.Size(190, 22)
        Me.cmdReCheck.Text = "復核(&E)..."
        Me.cmdReCheck.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(187, 6)
        '
        'cmdRef
        '
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(190, 22)
        Me.cmdRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(187, 6)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.cmdView.Size = New System.Drawing.Size(190, 22)
        Me.cmdView.Text = "查看(&W)..."
        '
        'cmdQuery
        '
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(190, 22)
        Me.cmdQuery.Text = "查詢(&F)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AP_ID, Me.AP_M_Code, Me.AP_M_Name, Me.AP_M_Gauge, Me.AP_Qty, Me.AP_M_Unit, Me.AP_ApplyDate, Me.AP_Applyreason, Me.AP_ApplyPersonName, Me.AP_ApplyDptName, Me.AP_CheckWare, Me.AP_Check, Me.AP_CheckDate, Me.AP_CheckType, Me.AP_ReCheck, Me.AP_ReCheckDate, Me.AP_ReCheckType})
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
        'AP_ID
        '
        Me.AP_ID.Caption = "申購單號"
        Me.AP_ID.FieldName = "AP_ID"
        Me.AP_ID.Name = "AP_ID"
        Me.AP_ID.Visible = True
        Me.AP_ID.VisibleIndex = 0
        Me.AP_ID.Width = 80
        '
        'AP_M_Code
        '
        Me.AP_M_Code.Caption = "物料編碼"
        Me.AP_M_Code.FieldName = "AP_M_Code"
        Me.AP_M_Code.Name = "AP_M_Code"
        Me.AP_M_Code.Visible = True
        Me.AP_M_Code.VisibleIndex = 1
        Me.AP_M_Code.Width = 100
        '
        'AP_M_Name
        '
        Me.AP_M_Name.Caption = "物料名稱"
        Me.AP_M_Name.FieldName = "AP_M_Name"
        Me.AP_M_Name.Name = "AP_M_Name"
        Me.AP_M_Name.Visible = True
        Me.AP_M_Name.VisibleIndex = 2
        Me.AP_M_Name.Width = 60
        '
        'AP_M_Gauge
        '
        Me.AP_M_Gauge.Caption = "規格"
        Me.AP_M_Gauge.FieldName = "AP_M_Gauge"
        Me.AP_M_Gauge.Name = "AP_M_Gauge"
        Me.AP_M_Gauge.Visible = True
        Me.AP_M_Gauge.VisibleIndex = 3
        '
        'AP_Qty
        '
        Me.AP_Qty.Caption = "申購數量"
        Me.AP_Qty.FieldName = "AP_Qty"
        Me.AP_Qty.Name = "AP_Qty"
        Me.AP_Qty.Visible = True
        Me.AP_Qty.VisibleIndex = 4
        Me.AP_Qty.Width = 60
        '
        'AP_M_Unit
        '
        Me.AP_M_Unit.Caption = "單位"
        Me.AP_M_Unit.FieldName = "AP_M_Unit"
        Me.AP_M_Unit.Name = "AP_M_Unit"
        Me.AP_M_Unit.Visible = True
        Me.AP_M_Unit.VisibleIndex = 5
        Me.AP_M_Unit.Width = 50
        '
        'AP_ApplyDate
        '
        Me.AP_ApplyDate.Caption = "申購日期"
        Me.AP_ApplyDate.FieldName = "AP_ApplyDate"
        Me.AP_ApplyDate.Name = "AP_ApplyDate"
        Me.AP_ApplyDate.Visible = True
        Me.AP_ApplyDate.VisibleIndex = 6
        '
        'AP_Applyreason
        '
        Me.AP_Applyreason.Caption = "申購原因"
        Me.AP_Applyreason.FieldName = "AP_Applyreason"
        Me.AP_Applyreason.Name = "AP_Applyreason"
        Me.AP_Applyreason.Visible = True
        Me.AP_Applyreason.VisibleIndex = 7
        Me.AP_Applyreason.Width = 70
        '
        'AP_ApplyPersonName
        '
        Me.AP_ApplyPersonName.Caption = "申購人"
        Me.AP_ApplyPersonName.FieldName = "AP_ApplyPersonName"
        Me.AP_ApplyPersonName.Name = "AP_ApplyPersonName"
        Me.AP_ApplyPersonName.Visible = True
        Me.AP_ApplyPersonName.VisibleIndex = 8
        Me.AP_ApplyPersonName.Width = 50
        '
        'AP_ApplyDptName
        '
        Me.AP_ApplyDptName.Caption = "申購部門"
        Me.AP_ApplyDptName.FieldName = "AP_ApplyDptName"
        Me.AP_ApplyDptName.Name = "AP_ApplyDptName"
        Me.AP_ApplyDptName.Visible = True
        Me.AP_ApplyDptName.VisibleIndex = 9
        Me.AP_ApplyDptName.Width = 60
        '
        'AP_CheckWare
        '
        Me.AP_CheckWare.Caption = "可採購"
        Me.AP_CheckWare.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.AP_CheckWare.FieldName = "AP_CheckWare"
        Me.AP_CheckWare.Name = "AP_CheckWare"
        Me.AP_CheckWare.Visible = True
        Me.AP_CheckWare.VisibleIndex = 10
        Me.AP_CheckWare.Width = 50
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'AP_Check
        '
        Me.AP_Check.Caption = "審核"
        Me.AP_Check.FieldName = "AP_Check"
        Me.AP_Check.Name = "AP_Check"
        Me.AP_Check.Visible = True
        Me.AP_Check.VisibleIndex = 11
        Me.AP_Check.Width = 50
        '
        'AP_CheckDate
        '
        Me.AP_CheckDate.Caption = "審核日期"
        Me.AP_CheckDate.FieldName = "AP_CheckDate"
        Me.AP_CheckDate.Name = "AP_CheckDate"
        '
        'AP_CheckType
        '
        Me.AP_CheckType.Caption = "審核類型"
        Me.AP_CheckType.FieldName = "AP_CheckType"
        Me.AP_CheckType.Name = "AP_CheckType"
        '
        'AP_ReCheck
        '
        Me.AP_ReCheck.Caption = "復核"
        Me.AP_ReCheck.FieldName = "AP_ReCheck"
        Me.AP_ReCheck.Name = "AP_ReCheck"
        Me.AP_ReCheck.Width = 50
        '
        'AP_ReCheckDate
        '
        Me.AP_ReCheckDate.Caption = "復核日期"
        Me.AP_ReCheckDate.FieldName = "AP_ReCheckDate"
        Me.AP_ReCheckDate.Name = "AP_ReCheckDate"
        '
        'AP_ReCheckType
        '
        Me.AP_ReCheckType.Caption = "復核類型"
        Me.AP_ReCheckType.FieldName = "AP_ReCheckType"
        Me.AP_ReCheckType.Name = "AP_ReCheckType"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 336)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(797, 154)
        Me.XtraTabControl1.TabIndex = 166
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(788, 122)
        Me.XtraTabPage1.Text = "採購記錄"
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Location = New System.Drawing.Point(0, 1)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(788, 120)
        Me.Grid2.TabIndex = 0
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_NO, Me.M_Code, Me.M_Name, Me.PS_QTY, Me.PS_NoSendQty, Me.PS_SendDate})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 0
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 2
        '
        'PS_QTY
        '
        Me.PS_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.PS_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.PS_QTY.Caption = "採購數量"
        Me.PS_QTY.FieldName = "PS_QTY"
        Me.PS_QTY.Name = "PS_QTY"
        Me.PS_QTY.Visible = True
        Me.PS_QTY.VisibleIndex = 3
        '
        'PS_NoSendQty
        '
        Me.PS_NoSendQty.AppearanceCell.Options.UseTextOptions = True
        Me.PS_NoSendQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.PS_NoSendQty.Caption = "未交數量"
        Me.PS_NoSendQty.FieldName = "PS_NoSendQty"
        Me.PS_NoSendQty.Name = "PS_NoSendQty"
        Me.PS_NoSendQty.Visible = True
        Me.PS_NoSendQty.VisibleIndex = 4
        '
        'PS_SendDate
        '
        Me.PS_SendDate.Caption = "交貨日期"
        Me.PS_SendDate.FieldName = "PS_SendDate"
        Me.PS_SendDate.Name = "PS_SendDate"
        Me.PS_SendDate.Visible = True
        Me.PS_SendDate.VisibleIndex = 5
        '
        'frmApplyPurchaseMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 488)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmApplyPurchaseMain"
        Me.Text = "申購單管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_Applyreason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyPersonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_CheckType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ReCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ReCheckType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AP_CheckWare As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdHandle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyDptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_SendDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
