<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareQCStatusMain
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
        Me.QCStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popQCStatus = New System.Windows.Forms.ToolStripMenuItem
        Me.popQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.popRef = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AccountCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQC_Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WQC_Action = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QCStatus.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 34)
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
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "抽檢狀態"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.QCStatus
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(1, 35)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(495, 350)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'QCStatus
        '
        Me.QCStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popQCStatus, Me.popQuery, Me.popRef})
        Me.QCStatus.Name = "QCStatus"
        Me.QCStatus.Size = New System.Drawing.Size(179, 92)
        '
        'popQCStatus
        '
        Me.popQCStatus.Image = Global.LFERP.My.Resources.Resources.GroupFormulaAuditing
        Me.popQCStatus.Name = "popQCStatus"
        Me.popQCStatus.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popQCStatus.Size = New System.Drawing.Size(178, 22)
        Me.popQCStatus.Text = "抽檢狀態(&T)..."
        '
        'popQuery
        '
        Me.popQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popQuery.Name = "popQuery"
        Me.popQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popQuery.Size = New System.Drawing.Size(178, 22)
        Me.popQuery.Text = "查詢(&F)..."
        '
        'popRef
        '
        Me.popRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popRef.Name = "popRef"
        Me.popRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popRef.Size = New System.Drawing.Size(178, 22)
        Me.popRef.Text = "刷新(&R)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.A_AcceptanceNO, Me.PM_NO, Me.M_Code, Me.M_Name, Me.DepotNO, Me.A_Qty, Me.A_Check, Me.A_AccountCheck, Me.A_Detail, Me.OS_BatchID, Me.S_SupplierName, Me.WQC_Status, Me.WQC_Action})
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
        'A_AcceptanceNO
        '
        Me.A_AcceptanceNO.Caption = "驗收單號"
        Me.A_AcceptanceNO.FieldName = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Name = "A_AcceptanceNO"
        Me.A_AcceptanceNO.Visible = True
        Me.A_AcceptanceNO.VisibleIndex = 0
        Me.A_AcceptanceNO.Width = 100
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 1
        Me.PM_NO.Width = 100
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 2
        Me.M_Code.Width = 100
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        '
        'DepotNO
        '
        Me.DepotNO.Caption = "倉庫代號"
        Me.DepotNO.FieldName = "DepotNO"
        Me.DepotNO.Name = "DepotNO"
        Me.DepotNO.Visible = True
        Me.DepotNO.VisibleIndex = 4
        '
        'A_Qty
        '
        Me.A_Qty.Caption = "送貨數量"
        Me.A_Qty.FieldName = "A_Qty"
        Me.A_Qty.Name = "A_Qty"
        Me.A_Qty.Visible = True
        Me.A_Qty.VisibleIndex = 6
        '
        'A_Check
        '
        Me.A_Check.Caption = "驗收審核"
        Me.A_Check.FieldName = "A_Check"
        Me.A_Check.Name = "A_Check"
        Me.A_Check.Visible = True
        Me.A_Check.VisibleIndex = 7
        '
        'A_AccountCheck
        '
        Me.A_AccountCheck.Caption = "會計部審核"
        Me.A_AccountCheck.FieldName = "A_AccountCheck"
        Me.A_AccountCheck.Name = "A_AccountCheck"
        Me.A_AccountCheck.Visible = True
        Me.A_AccountCheck.VisibleIndex = 8
        '
        'A_Detail
        '
        Me.A_Detail.Caption = "狀態"
        Me.A_Detail.FieldName = "A_Detail"
        Me.A_Detail.Name = "A_Detail"
        Me.A_Detail.Visible = True
        Me.A_Detail.VisibleIndex = 5
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Visible = True
        Me.OS_BatchID.VisibleIndex = 9
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 10
        '
        'WQC_Status
        '
        Me.WQC_Status.Caption = "QC抽檢狀態"
        Me.WQC_Status.FieldName = "WQC_Status"
        Me.WQC_Status.Name = "WQC_Status"
        Me.WQC_Status.Visible = True
        Me.WQC_Status.VisibleIndex = 11
        '
        'WQC_Action
        '
        Me.WQC_Action.Caption = "QC抽檢狀態操作員"
        Me.WQC_Action.FieldName = "WQC_Action"
        Me.WQC_Action.Name = "WQC_Action"
        Me.WQC_Action.Visible = True
        Me.WQC_Action.VisibleIndex = 12
        Me.WQC_Action.Width = 125
        '
        'frmWareQCStatusMain
        '
        Me.ClientSize = New System.Drawing.Size(496, 385)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareQCStatusMain"
        Me.Text = "frmWareQCStatusMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QCStatus.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents A_AcceptanceNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepotNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AccountCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQC_Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WQC_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QCStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popQCStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popQuery As System.Windows.Forms.ToolStripMenuItem

   
End Class
