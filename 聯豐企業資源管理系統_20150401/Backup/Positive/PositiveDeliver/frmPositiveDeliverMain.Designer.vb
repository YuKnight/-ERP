<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPositiveDeliverMain
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
        Me.dgPositiveDeliver = New DevExpress.XtraGrid.GridControl
        Me.popPositiveDeliverMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popPositiveDeliverAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popPositiveDeliverMainEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.popPositiveDeliverMainDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popPositiveDeliverMainView = New System.Windows.Forms.ToolStripMenuItem
        Me.PopPositiveDeliverMainRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popPositiveDeliverMainCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popPositiveDeliverMainPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.dgvPositiveDeliver = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_OM_CusterNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PartNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_OM_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_TypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.popPositiveDeliverMainQuery = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPositiveDeliver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popPositiveDeliverMain.SuspendLayout()
        CType(Me.dgvPositiveDeliver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1036, 36)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "陽極送貨信息"
        '
        'dgPositiveDeliver
        '
        Me.dgPositiveDeliver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPositiveDeliver.ContextMenuStrip = Me.popPositiveDeliverMain
        Me.dgPositiveDeliver.EmbeddedNavigator.Name = ""
        Me.dgPositiveDeliver.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dgPositiveDeliver.Location = New System.Drawing.Point(3, 40)
        Me.dgPositiveDeliver.MainView = Me.dgvPositiveDeliver
        Me.dgPositiveDeliver.Name = "dgPositiveDeliver"
        Me.dgPositiveDeliver.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemDateEdit5, Me.RepositoryItemCalcEdit1})
        Me.dgPositiveDeliver.Size = New System.Drawing.Size(1037, 459)
        Me.dgPositiveDeliver.TabIndex = 169
        Me.dgPositiveDeliver.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvPositiveDeliver})
        '
        'popPositiveDeliverMain
        '
        Me.popPositiveDeliverMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popPositiveDeliverAdd, Me.popPositiveDeliverMainEdit, Me.ToolStripSeparator7, Me.popPositiveDeliverMainDel, Me.ToolStripSeparator4, Me.popPositiveDeliverMainView, Me.PopPositiveDeliverMainRefresh, Me.ToolStripSeparator5, Me.popPositiveDeliverMainQuery, Me.popPositiveDeliverMainCheck, Me.popPositiveDeliverMainPrint})
        Me.popPositiveDeliverMain.Name = "popOrderMain"
        Me.popPositiveDeliverMain.Size = New System.Drawing.Size(163, 220)
        '
        'popPositiveDeliverAdd
        '
        Me.popPositiveDeliverAdd.Enabled = False
        Me.popPositiveDeliverAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popPositiveDeliverAdd.Name = "popPositiveDeliverAdd"
        Me.popPositiveDeliverAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popPositiveDeliverAdd.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverAdd.Text = "新增(&A)..."
        '
        'popPositiveDeliverMainEdit
        '
        Me.popPositiveDeliverMainEdit.Enabled = False
        Me.popPositiveDeliverMainEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popPositiveDeliverMainEdit.Name = "popPositiveDeliverMainEdit"
        Me.popPositiveDeliverMainEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popPositiveDeliverMainEdit.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainEdit.Text = "修改(&E)..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(159, 6)
        '
        'popPositiveDeliverMainDel
        '
        Me.popPositiveDeliverMainDel.Enabled = False
        Me.popPositiveDeliverMainDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popPositiveDeliverMainDel.Name = "popPositiveDeliverMainDel"
        Me.popPositiveDeliverMainDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popPositiveDeliverMainDel.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'popPositiveDeliverMainView
        '
        Me.popPositiveDeliverMainView.Enabled = False
        Me.popPositiveDeliverMainView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popPositiveDeliverMainView.Name = "popPositiveDeliverMainView"
        Me.popPositiveDeliverMainView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popPositiveDeliverMainView.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainView.Text = "查看(&W)..."
        '
        'PopPositiveDeliverMainRefresh
        '
        Me.PopPositiveDeliverMainRefresh.Enabled = False
        Me.PopPositiveDeliverMainRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.PopPositiveDeliverMainRefresh.Name = "PopPositiveDeliverMainRefresh"
        Me.PopPositiveDeliverMainRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.PopPositiveDeliverMainRefresh.Size = New System.Drawing.Size(162, 22)
        Me.PopPositiveDeliverMainRefresh.Text = "刷新(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'popPositiveDeliverMainCheck
        '
        Me.popPositiveDeliverMainCheck.Enabled = False
        Me.popPositiveDeliverMainCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popPositiveDeliverMainCheck.Name = "popPositiveDeliverMainCheck"
        Me.popPositiveDeliverMainCheck.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainCheck.Text = "審核(&C)"
        '
        'popPositiveDeliverMainPrint
        '
        Me.popPositiveDeliverMainPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popPositiveDeliverMainPrint.Name = "popPositiveDeliverMainPrint"
        Me.popPositiveDeliverMainPrint.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainPrint.Text = "列印送貨單(&S)"
        '
        'dgvPositiveDeliver
        '
        Me.dgvPositiveDeliver.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.D_NO, Me.P_M_Code, Me.P_OM_CusterNo, Me.P_OM_CusterPO, Me.PartNumber, Me.P_OM_Num, Me.D_TypeName, Me.Qty, Me.ActionName, Me.D_AddDate, Me.D_Check, Me.CheckActionName, Me.D_CheckDate})
        Me.dgvPositiveDeliver.GridControl = Me.dgPositiveDeliver
        Me.dgvPositiveDeliver.Name = "dgvPositiveDeliver"
        Me.dgvPositiveDeliver.OptionsBehavior.AutoSelectAllInEditor = False
        Me.dgvPositiveDeliver.OptionsBehavior.Editable = False
        Me.dgvPositiveDeliver.OptionsCustomization.AllowColumnMoving = False
        Me.dgvPositiveDeliver.OptionsFilter.AllowColumnMRUFilterList = False
        Me.dgvPositiveDeliver.OptionsFilter.AllowFilterEditor = False
        Me.dgvPositiveDeliver.OptionsFilter.AllowMRUFilterList = False
        Me.dgvPositiveDeliver.OptionsMenu.EnableColumnMenu = False
        Me.dgvPositiveDeliver.OptionsMenu.EnableFooterMenu = False
        Me.dgvPositiveDeliver.OptionsMenu.EnableGroupPanelMenu = False
        Me.dgvPositiveDeliver.OptionsNavigation.UseTabKey = False
        Me.dgvPositiveDeliver.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgvPositiveDeliver.OptionsView.ColumnAutoWidth = False
        Me.dgvPositiveDeliver.OptionsView.RowAutoHeight = True
        Me.dgvPositiveDeliver.OptionsView.ShowFooter = True
        Me.dgvPositiveDeliver.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.Width = 100
        '
        'D_NO
        '
        Me.D_NO.Caption = "送貨單號"
        Me.D_NO.FieldName = "D_NO"
        Me.D_NO.Name = "D_NO"
        Me.D_NO.Visible = True
        Me.D_NO.VisibleIndex = 0
        Me.D_NO.Width = 100
        '
        'P_M_Code
        '
        Me.P_M_Code.Caption = "產品編號"
        Me.P_M_Code.FieldName = "P_M_Code"
        Me.P_M_Code.Name = "P_M_Code"
        Me.P_M_Code.Visible = True
        Me.P_M_Code.VisibleIndex = 1
        Me.P_M_Code.Width = 140
        '
        'P_OM_CusterNo
        '
        Me.P_OM_CusterNo.Caption = "客戶代號"
        Me.P_OM_CusterNo.FieldName = "P_OM_CusterNo"
        Me.P_OM_CusterNo.Name = "P_OM_CusterNo"
        Me.P_OM_CusterNo.Visible = True
        Me.P_OM_CusterNo.VisibleIndex = 2
        Me.P_OM_CusterNo.Width = 100
        '
        'P_OM_CusterPO
        '
        Me.P_OM_CusterPO.Caption = "客戶PO"
        Me.P_OM_CusterPO.FieldName = "P_OM_CusterPO"
        Me.P_OM_CusterPO.Name = "P_OM_CusterPO"
        Me.P_OM_CusterPO.Visible = True
        Me.P_OM_CusterPO.VisibleIndex = 3
        Me.P_OM_CusterPO.Width = 100
        '
        'PartNumber
        '
        Me.PartNumber.Caption = "料號"
        Me.PartNumber.FieldName = "PartNumber"
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Visible = True
        Me.PartNumber.VisibleIndex = 4
        Me.PartNumber.Width = 100
        '
        'P_OM_Num
        '
        Me.P_OM_Num.Caption = "訂單流水號"
        Me.P_OM_Num.FieldName = "P_OM_Num"
        Me.P_OM_Num.Name = "P_OM_Num"
        Me.P_OM_Num.Width = 100
        '
        'D_TypeName
        '
        Me.D_TypeName.Caption = "送貨類型"
        Me.D_TypeName.FieldName = "D_TypeName"
        Me.D_TypeName.Name = "D_TypeName"
        Me.D_TypeName.Visible = True
        Me.D_TypeName.VisibleIndex = 5
        Me.D_TypeName.Width = 100
        '
        'Qty
        '
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "送貨數量"
        Me.Qty.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 6
        Me.Qty.Width = 100
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作人"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 7
        Me.ActionName.Width = 100
        '
        'D_AddDate
        '
        Me.D_AddDate.Caption = "增加日期"
        Me.D_AddDate.FieldName = "D_AddDate"
        Me.D_AddDate.Name = "D_AddDate"
        Me.D_AddDate.Visible = True
        Me.D_AddDate.VisibleIndex = 8
        Me.D_AddDate.Width = 100
        '
        'D_Check
        '
        Me.D_Check.AppearanceHeader.Options.UseTextOptions = True
        Me.D_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.D_Check.Caption = "審核"
        Me.D_Check.FieldName = "D_Check"
        Me.D_Check.Name = "D_Check"
        Me.D_Check.Visible = True
        Me.D_Check.VisibleIndex = 9
        Me.D_Check.Width = 100
        '
        'CheckActionName
        '
        Me.CheckActionName.AppearanceCell.Options.UseTextOptions = True
        Me.CheckActionName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CheckActionName.AppearanceHeader.Options.UseTextOptions = True
        Me.CheckActionName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CheckActionName.Caption = "審核人"
        Me.CheckActionName.FieldName = "CheckActionName"
        Me.CheckActionName.Name = "CheckActionName"
        Me.CheckActionName.Visible = True
        Me.CheckActionName.VisibleIndex = 10
        '
        'D_CheckDate
        '
        Me.D_CheckDate.Caption = "審核日期"
        Me.D_CheckDate.FieldName = "D_CheckDate"
        Me.D_CheckDate.Name = "D_CheckDate"
        Me.D_CheckDate.Visible = True
        Me.D_CheckDate.VisibleIndex = 11
        Me.D_CheckDate.Width = 100
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        Me.RepositoryItemDateEdit5.ReadOnly = True
        Me.RepositoryItemDateEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'popPositiveDeliverMainQuery
        '
        Me.popPositiveDeliverMainQuery.Enabled = False
        Me.popPositiveDeliverMainQuery.Image = Global.LFERP.My.Resources.Resources.search_32
        Me.popPositiveDeliverMainQuery.Name = "popPositiveDeliverMainQuery"
        Me.popPositiveDeliverMainQuery.Size = New System.Drawing.Size(162, 22)
        Me.popPositiveDeliverMainQuery.Text = "查詢(&Q)"
        '
        'frmPositiveDeliverMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 524)
        Me.ContextMenuStrip = Me.popPositiveDeliverMain
        Me.Controls.Add(Me.dgPositiveDeliver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPositiveDeliverMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "陽極送貨信息"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPositiveDeliver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popPositiveDeliverMain.ResumeLayout(False)
        CType(Me.dgvPositiveDeliver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgPositiveDeliver As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvPositiveDeliver As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_OM_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_TypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents P_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_OM_CusterNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popPositiveDeliverMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popPositiveDeliverAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPositiveDeliverMainEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPositiveDeliverMainDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPositiveDeliverMainView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopPositiveDeliverMainRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popPositiveDeliverMainCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popPositiveDeliverMainPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popPositiveDeliverMainQuery As System.Windows.Forms.ToolStripMenuItem
End Class
