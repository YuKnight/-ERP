<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetrocedeMain
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
        Me.popRetrocede = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popRetrocedeAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popRetrocedeCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popRetrocedeSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popRetrocedePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popRetrocedeNotAllPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popRetrocedeFile = New System.Windows.Forms.ToolStripMenuItem
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.R_RetrocedeNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_ReturnType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_ReturnDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.R_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popRetrocede.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "退貨管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 36)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'popRetrocede
        '
        Me.popRetrocede.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popRetrocedeAdd, Me.popRetrocedeEdit, Me.popRetrocedeDel, Me.popRetrocedeView, Me.ToolStripSeparator1, Me.popRetrocedeCheck, Me.popRetrocedeAccCheck, Me.ToolStripSeparator3, Me.popRetrocedeSeek, Me.popRetrocedeRef, Me.ToolStripSeparator2, Me.popRetrocedePrint, Me.popRetrocedeNotAllPrint, Me.ToolStripSeparator4, Me.popRetrocedeFile})
        Me.popRetrocede.Name = "popAcceptance"
        Me.popRetrocede.Size = New System.Drawing.Size(265, 270)
        '
        'popRetrocedeAdd
        '
        Me.popRetrocedeAdd.Enabled = False
        Me.popRetrocedeAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popRetrocedeAdd.Name = "popRetrocedeAdd"
        Me.popRetrocedeAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popRetrocedeAdd.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeAdd.Text = "暫退(&T)..."
        '
        'popRetrocedeEdit
        '
        Me.popRetrocedeEdit.Enabled = False
        Me.popRetrocedeEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popRetrocedeEdit.Name = "popRetrocedeEdit"
        Me.popRetrocedeEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popRetrocedeEdit.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeEdit.Text = "修改(&E)..."
        '
        'popRetrocedeDel
        '
        Me.popRetrocedeDel.Enabled = False
        Me.popRetrocedeDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popRetrocedeDel.Name = "popRetrocedeDel"
        Me.popRetrocedeDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popRetrocedeDel.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeDel.Text = "刪除(&D)"
        '
        'popRetrocedeView
        '
        Me.popRetrocedeView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popRetrocedeView.Name = "popRetrocedeView"
        Me.popRetrocedeView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popRetrocedeView.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(261, 6)
        '
        'popRetrocedeCheck
        '
        Me.popRetrocedeCheck.Enabled = False
        Me.popRetrocedeCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popRetrocedeCheck.Name = "popRetrocedeCheck"
        Me.popRetrocedeCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popRetrocedeCheck.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeCheck.Text = "退貨審核(&G)..."
        '
        'popRetrocedeAccCheck
        '
        Me.popRetrocedeAccCheck.Enabled = False
        Me.popRetrocedeAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popRetrocedeAccCheck.Name = "popRetrocedeAccCheck"
        Me.popRetrocedeAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popRetrocedeAccCheck.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeAccCheck.Text = "會計部審核(&S)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(261, 6)
        '
        'popRetrocedeSeek
        '
        Me.popRetrocedeSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popRetrocedeSeek.Name = "popRetrocedeSeek"
        Me.popRetrocedeSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popRetrocedeSeek.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeSeek.Text = "查詢(&F)..."
        '
        'popRetrocedeRef
        '
        Me.popRetrocedeRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popRetrocedeRef.Name = "popRetrocedeRef"
        Me.popRetrocedeRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popRetrocedeRef.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(261, 6)
        '
        'popRetrocedePrint
        '
        Me.popRetrocedePrint.Enabled = False
        Me.popRetrocedePrint.Name = "popRetrocedePrint"
        Me.popRetrocedePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popRetrocedePrint.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedePrint.Text = "列印當前退貨單(&P)..."
        '
        'popRetrocedeNotAllPrint
        '
        Me.popRetrocedeNotAllPrint.Name = "popRetrocedeNotAllPrint"
        Me.popRetrocedeNotAllPrint.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeNotAllPrint.Text = "所有未完成退貨清單(&J)..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(261, 6)
        '
        'popRetrocedeFile
        '
        Me.popRetrocedeFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popRetrocedeFile.Name = "popRetrocedeFile"
        Me.popRetrocedeFile.Size = New System.Drawing.Size(264, 22)
        Me.popRetrocedeFile.Text = "附加文件(&B)..."
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popRetrocede
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 40)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(736, 499)
        Me.Grid1.TabIndex = 164
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.R_RetrocedeNO, Me.S_Supplier, Me.CO_ID, Me.A_AcceptanceNO, Me.PM_NO, Me.A_SendNo, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.OS_BatchID, Me.R_ReturnType, Me.R_Qty, Me.S_SupplierName, Me.R_ReturnDate, Me.R_Action, Me.R_Check, Me.R_AccountCheck})
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
        'R_RetrocedeNO
        '
        Me.R_RetrocedeNO.Caption = "退貨單號"
        Me.R_RetrocedeNO.FieldName = "R_RetrocedeNO"
        Me.R_RetrocedeNO.Name = "R_RetrocedeNO"
        Me.R_RetrocedeNO.Visible = True
        Me.R_RetrocedeNO.VisibleIndex = 0
        Me.R_RetrocedeNO.Width = 80
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商代號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司代號"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        '
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Visible = True
        Me.A_AcceptanceNO.VisibleIndex = 1
        Me.A_AcceptanceNO.Width = 80
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 2
        Me.PM_NO.Width = 85
        '
        'A_SendNo
        '
        Me.A_SendNo.Caption = "送貨單號"
        Me.A_SendNo.FieldName = "A_SendNo"
        Me.A_SendNo.Name = "A_SendNo"
        Me.A_SendNo.Visible = True
        Me.A_SendNo.VisibleIndex = 3
        Me.A_SendNo.Width = 70
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 4
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 5
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 6
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 7
        Me.OS_BatchID.Width = 60
        '
        'R_ReturnType
        '
        Me.R_ReturnType.Caption = "退貨類型"
        Me.R_ReturnType.FieldName = "R_ReturnType"
        Me.R_ReturnType.Name = "R_ReturnType"
        Me.R_ReturnType.Visible = True
        Me.R_ReturnType.VisibleIndex = 8
        Me.R_ReturnType.Width = 70
        '
        'R_Qty
        '
        Me.R_Qty.Caption = "退貨數量"
        Me.R_Qty.FieldName = "R_Qty"
        Me.R_Qty.Name = "R_Qty"
        Me.R_Qty.Visible = True
        Me.R_Qty.VisibleIndex = 9
        Me.R_Qty.Width = 60
        '
        'R_ReturnDate
        '
        Me.R_ReturnDate.Caption = "退貨日期"
        Me.R_ReturnDate.FieldName = "R_ReturnDate"
        Me.R_ReturnDate.Name = "R_ReturnDate"
        Me.R_ReturnDate.Visible = True
        Me.R_ReturnDate.VisibleIndex = 11
        Me.R_ReturnDate.Width = 80
        '
        'R_Action
        '
        Me.R_Action.Caption = "操作員"
        Me.R_Action.FieldName = "R_Action"
        Me.R_Action.Name = "R_Action"
        Me.R_Action.Visible = True
        Me.R_Action.VisibleIndex = 12
        Me.R_Action.Width = 60
        '
        'R_Check
        '
        Me.R_Check.Caption = "退貨審核"
        Me.R_Check.FieldName = "R_Check"
        Me.R_Check.Name = "R_Check"
        Me.R_Check.Visible = True
        Me.R_Check.VisibleIndex = 13
        Me.R_Check.Width = 60
        '
        'R_AccountCheck
        '
        Me.R_AccountCheck.Caption = "會計部審核"
        Me.R_AccountCheck.FieldName = "R_AccountCheck"
        Me.R_AccountCheck.Name = "R_AccountCheck"
        Me.R_AccountCheck.Visible = True
        Me.R_AccountCheck.VisibleIndex = 14
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 10
        '
        'frmRetrocedeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 544)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "frmRetrocedeMain"
        Me.Text = "退貨管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popRetrocede.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popRetrocede As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popRetrocedeAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedeDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popRetrocedeCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popRetrocedeRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedeFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popRetrocedeSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedeAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents R_RetrocedeNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_ReturnType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_ReturnDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popRetrocedeView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRetrocedeNotAllPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
End Class
