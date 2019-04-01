<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductionOWPAcceptanceMain
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popProceAcceptance = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popProceAcceptanceAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popProceAcceptanceEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popProceAcceptanceDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popProceAcceptanceView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popProceAcceptanceCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.popProceAcceptanceAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popProceAcceptanceRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popProceAcceptanceSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popProceAcceptancePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.O_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ASend_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_OK_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_QQ_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_TC_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_QT_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_PS_Name_Next = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AccCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_CheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_UpdateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_OW_Do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popProceAcceptance.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popProceAcceptance
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(1, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(779, 409)
        Me.Grid1.TabIndex = 169
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popProceAcceptance
        '
        Me.popProceAcceptance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popProceAcceptanceAdd, Me.popProceAcceptanceEdit, Me.popProceAcceptanceDel, Me.popProceAcceptanceView, Me.ToolStripSeparator1, Me.popProceAcceptanceCheck, Me.QuitMenuItem, Me.popProceAcceptanceAccCheck, Me.ToolStripSeparator3, Me.popProceAcceptanceRef, Me.ToolStripSeparator2, Me.popProceAcceptanceSeek, Me.popProceAcceptancePrint})
        Me.popProceAcceptance.Name = "popAcceptance"
        Me.popProceAcceptance.Size = New System.Drawing.Size(205, 242)
        '
        'popProceAcceptanceAdd
        '
        Me.popProceAcceptanceAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popProceAcceptanceAdd.Name = "popProceAcceptanceAdd"
        Me.popProceAcceptanceAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popProceAcceptanceAdd.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceAdd.Text = "暫收(&A)..."
        '
        'popProceAcceptanceEdit
        '
        Me.popProceAcceptanceEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popProceAcceptanceEdit.Name = "popProceAcceptanceEdit"
        Me.popProceAcceptanceEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popProceAcceptanceEdit.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceEdit.Text = "修改(&E)..."
        '
        'popProceAcceptanceDel
        '
        Me.popProceAcceptanceDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popProceAcceptanceDel.Name = "popProceAcceptanceDel"
        Me.popProceAcceptanceDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popProceAcceptanceDel.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceDel.Text = "刪除(&D)"
        '
        'popProceAcceptanceView
        '
        Me.popProceAcceptanceView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popProceAcceptanceView.Name = "popProceAcceptanceView"
        Me.popProceAcceptanceView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popProceAcceptanceView.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'popProceAcceptanceCheck
        '
        Me.popProceAcceptanceCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popProceAcceptanceCheck.Name = "popProceAcceptanceCheck"
        Me.popProceAcceptanceCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popProceAcceptanceCheck.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceCheck.Text = "審核(&G)..."
        '
        'QuitMenuItem
        '
        Me.QuitMenuItem.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.QuitMenuItem.Name = "QuitMenuItem"
        Me.QuitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.QuitMenuItem.Text = "取消審核(Q) "
        '
        'popProceAcceptanceAccCheck
        '
        Me.popProceAcceptanceAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popProceAcceptanceAccCheck.Name = "popProceAcceptanceAccCheck"
        Me.popProceAcceptanceAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popProceAcceptanceAccCheck.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceAccCheck.Text = "復核(&S)..."
        Me.popProceAcceptanceAccCheck.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(201, 6)
        '
        'popProceAcceptanceRef
        '
        Me.popProceAcceptanceRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popProceAcceptanceRef.Name = "popProceAcceptanceRef"
        Me.popProceAcceptanceRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popProceAcceptanceRef.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(201, 6)
        '
        'popProceAcceptanceSeek
        '
        Me.popProceAcceptanceSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popProceAcceptanceSeek.Name = "popProceAcceptanceSeek"
        Me.popProceAcceptanceSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popProceAcceptanceSeek.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptanceSeek.Text = "查詢(&F)..."
        '
        'popProceAcceptancePrint
        '
        Me.popProceAcceptancePrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popProceAcceptancePrint.Name = "popProceAcceptancePrint"
        Me.popProceAcceptancePrint.Size = New System.Drawing.Size(204, 22)
        Me.popProceAcceptancePrint.Text = "送貨詳細表(&B)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.A_AcceptanceNO, Me.O_NO, Me.ASend_NO, Me.M_Code, Me.PM_M_Code, Me.PM_JiYu, Me.PM_Type, Me.A_OK_Qty, Me.A_QQ_Qty, Me.A_TC_Qty, Me.A_QT_Qty, Me.A_PS_Name, Me.A_PS_Name_Next, Me.A_SupplierName, Me.A_Detail, Me.A_Check, Me.A_AccCheck, Me.A_ActionName, Me.A_CheckActionName, Me.A_SendDate, Me.A_UpdateDate, Me.A_OW_Do})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
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
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Width = 80
        '
        'O_NO
        '
        Me.O_NO.Caption = "外發單號"
        Me.O_NO.FieldName = "O_NO"
        Me.O_NO.Name = "O_NO"
        Me.O_NO.Visible = True
        Me.O_NO.VisibleIndex = 0
        Me.O_NO.Width = 79
        '
        'ASend_NO
        '
        Me.ASend_NO.Caption = "送貨單號"
        Me.ASend_NO.FieldName = "ASend_NO"
        Me.ASend_NO.Name = "ASend_NO"
        Me.ASend_NO.Visible = True
        Me.ASend_NO.VisibleIndex = 1
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Width = 125
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品名稱"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 2
        Me.PM_M_Code.Width = 79
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.OptionsColumn.AllowEdit = False
        Me.PM_JiYu.OptionsColumn.AllowFocus = False
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 3
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 4
        '
        'A_OK_Qty
        '
        Me.A_OK_Qty.Caption = "OK數"
        Me.A_OK_Qty.FieldName = "A_OK_Qty"
        Me.A_OK_Qty.Name = "A_OK_Qty"
        Me.A_OK_Qty.OptionsColumn.AllowEdit = False
        Me.A_OK_Qty.OptionsColumn.AllowFocus = False
        Me.A_OK_Qty.Visible = True
        Me.A_OK_Qty.VisibleIndex = 7
        Me.A_OK_Qty.Width = 60
        '
        'A_QQ_Qty
        '
        Me.A_QQ_Qty.Caption = "前Q數"
        Me.A_QQ_Qty.FieldName = "A_QQ_Qty"
        Me.A_QQ_Qty.Name = "A_QQ_Qty"
        Me.A_QQ_Qty.OptionsColumn.AllowEdit = False
        Me.A_QQ_Qty.OptionsColumn.AllowFocus = False
        Me.A_QQ_Qty.Visible = True
        Me.A_QQ_Qty.VisibleIndex = 8
        Me.A_QQ_Qty.Width = 65
        '
        'A_TC_Qty
        '
        Me.A_TC_Qty.Caption = "退次數"
        Me.A_TC_Qty.FieldName = "A_TC_Qty"
        Me.A_TC_Qty.Name = "A_TC_Qty"
        Me.A_TC_Qty.OptionsColumn.AllowEdit = False
        Me.A_TC_Qty.OptionsColumn.AllowFocus = False
        Me.A_TC_Qty.Visible = True
        Me.A_TC_Qty.VisibleIndex = 9
        Me.A_TC_Qty.Width = 65
        '
        'A_QT_Qty
        '
        Me.A_QT_Qty.Caption = "其它數"
        Me.A_QT_Qty.FieldName = "A_QT_Qty"
        Me.A_QT_Qty.Name = "A_QT_Qty"
        Me.A_QT_Qty.OptionsColumn.AllowEdit = False
        Me.A_QT_Qty.OptionsColumn.AllowFocus = False
        Me.A_QT_Qty.Visible = True
        Me.A_QT_Qty.VisibleIndex = 10
        Me.A_QT_Qty.Width = 65
        '
        'A_PS_Name
        '
        Me.A_PS_Name.Caption = "外發工序"
        Me.A_PS_Name.FieldName = "A_PS_Name"
        Me.A_PS_Name.Name = "A_PS_Name"
        '
        'A_PS_Name_Next
        '
        Me.A_PS_Name_Next.Caption = "完成工序"
        Me.A_PS_Name_Next.FieldName = "A_PS_Name_Next"
        Me.A_PS_Name_Next.Name = "A_PS_Name_Next"
        '
        'A_SupplierName
        '
        Me.A_SupplierName.Caption = "供應商名"
        Me.A_SupplierName.FieldName = "A_SupplierName"
        Me.A_SupplierName.Name = "A_SupplierName"
        Me.A_SupplierName.Visible = True
        Me.A_SupplierName.VisibleIndex = 5
        '
        'A_Detail
        '
        Me.A_Detail.AppearanceCell.Options.UseTextOptions = True
        Me.A_Detail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A_Detail.AppearanceHeader.Options.UseTextOptions = True
        Me.A_Detail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A_Detail.Caption = "狀態"
        Me.A_Detail.FieldName = "A_Detail"
        Me.A_Detail.Name = "A_Detail"
        Me.A_Detail.Width = 55
        '
        'A_Check
        '
        Me.A_Check.AppearanceHeader.Options.UseTextOptions = True
        Me.A_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A_Check.Caption = "審核"
        Me.A_Check.FieldName = "A_Check"
        Me.A_Check.Name = "A_Check"
        Me.A_Check.Visible = True
        Me.A_Check.VisibleIndex = 6
        Me.A_Check.Width = 55
        '
        'A_AccCheck
        '
        Me.A_AccCheck.AppearanceHeader.Options.UseTextOptions = True
        Me.A_AccCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A_AccCheck.Caption = "審核"
        Me.A_AccCheck.FieldName = "A_AccCheck"
        Me.A_AccCheck.Name = "A_AccCheck"
        Me.A_AccCheck.Width = 55
        '
        'A_ActionName
        '
        Me.A_ActionName.Caption = "暫收人"
        Me.A_ActionName.FieldName = "A_ActionName"
        Me.A_ActionName.Name = "A_ActionName"
        Me.A_ActionName.Visible = True
        Me.A_ActionName.VisibleIndex = 12
        Me.A_ActionName.Width = 65
        '
        'A_CheckActionName
        '
        Me.A_CheckActionName.Caption = "審核人"
        Me.A_CheckActionName.FieldName = "A_CheckActionName"
        Me.A_CheckActionName.Name = "A_CheckActionName"
        Me.A_CheckActionName.Visible = True
        Me.A_CheckActionName.VisibleIndex = 13
        Me.A_CheckActionName.Width = 65
        '
        'A_SendDate
        '
        Me.A_SendDate.Caption = "暫收日期"
        Me.A_SendDate.FieldName = "A_SendDate"
        Me.A_SendDate.Name = "A_SendDate"
        Me.A_SendDate.Visible = True
        Me.A_SendDate.VisibleIndex = 11
        '
        'A_UpdateDate
        '
        Me.A_UpdateDate.Caption = "修改日期"
        Me.A_UpdateDate.FieldName = "A_UpdateDate"
        Me.A_UpdateDate.Name = "A_UpdateDate"
        Me.A_UpdateDate.Visible = True
        Me.A_UpdateDate.VisibleIndex = 14
        '
        'A_OW_Do
        '
        Me.A_OW_Do.Caption = "加工要求"
        Me.A_OW_Do.FieldName = "A_OW_Do"
        Me.A_OW_Do.Name = "A_OW_Do"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "外發驗收管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(779, 36)
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'FrmProductionOWPAcceptanceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 449)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmProductionOWPAcceptanceMain"
        Me.Text = "驗收管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popProceAcceptance.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents O_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AccCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_UpdateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popProceAcceptance As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popProceAcceptanceAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProceAcceptanceEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProceAcceptanceDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProceAcceptanceView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProceAcceptanceCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProceAcceptanceAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProceAcceptanceRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popProceAcceptanceSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popProceAcceptancePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents A_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_CheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_PS_Name_Next As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QuitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents A_OW_Do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASend_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_OK_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_QQ_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_TC_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_QT_Qty As DevExpress.XtraGrid.Columns.GridColumn
End Class
