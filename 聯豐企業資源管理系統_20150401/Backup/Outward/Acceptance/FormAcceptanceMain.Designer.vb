<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcceptanceMain
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popAcceptance = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popAcceptanceAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptanceAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popAcceptanceSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.popAcceptancePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.A_AcceptanceNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepotNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_AccCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.A_UpdateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popAcceptance.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "外發驗收管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(706, 36)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popAcceptance
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(2, 36)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(711, 467)
        Me.Grid1.TabIndex = 165
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popAcceptance
        '
        Me.popAcceptance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popAcceptanceAdd, Me.popAcceptanceEdit, Me.popAcceptanceDel, Me.popAcceptanceView, Me.ToolStripSeparator1, Me.popAcceptanceCheck, Me.popAcceptanceAccCheck, Me.ToolStripSeparator3, Me.popAcceptanceRef, Me.ToolStripSeparator2, Me.popAcceptanceSeek, Me.popAcceptancePrint})
        Me.popAcceptance.Name = "popAcceptance"
        Me.popAcceptance.Size = New System.Drawing.Size(181, 242)
        '
        'popAcceptanceAdd
        '
        Me.popAcceptanceAdd.Enabled = False
        Me.popAcceptanceAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popAcceptanceAdd.Name = "popAcceptanceAdd"
        Me.popAcceptanceAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.popAcceptanceAdd.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceAdd.Text = "暫收(&T)..."
        '
        'popAcceptanceEdit
        '
        Me.popAcceptanceEdit.Enabled = False
        Me.popAcceptanceEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popAcceptanceEdit.Name = "popAcceptanceEdit"
        Me.popAcceptanceEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popAcceptanceEdit.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceEdit.Text = "修改(&E)..."
        '
        'popAcceptanceDel
        '
        Me.popAcceptanceDel.Enabled = False
        Me.popAcceptanceDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popAcceptanceDel.Name = "popAcceptanceDel"
        Me.popAcceptanceDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popAcceptanceDel.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceDel.Text = "刪除(&D)"
        '
        'popAcceptanceView
        '
        Me.popAcceptanceView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popAcceptanceView.Name = "popAcceptanceView"
        Me.popAcceptanceView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popAcceptanceView.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'popAcceptanceCheck
        '
        Me.popAcceptanceCheck.Enabled = False
        Me.popAcceptanceCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popAcceptanceCheck.Name = "popAcceptanceCheck"
        Me.popAcceptanceCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.popAcceptanceCheck.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceCheck.Text = "驗收審核(&G)..."
        '
        'popAcceptanceAccCheck
        '
        Me.popAcceptanceAccCheck.Enabled = False
        Me.popAcceptanceAccCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popAcceptanceAccCheck.Name = "popAcceptanceAccCheck"
        Me.popAcceptanceAccCheck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.popAcceptanceAccCheck.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceAccCheck.Text = "復核(&S)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'popAcceptanceRef
        '
        Me.popAcceptanceRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popAcceptanceRef.Name = "popAcceptanceRef"
        Me.popAcceptanceRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popAcceptanceRef.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'popAcceptanceSeek
        '
        Me.popAcceptanceSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popAcceptanceSeek.Name = "popAcceptanceSeek"
        Me.popAcceptanceSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popAcceptanceSeek.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptanceSeek.Text = "查詢(&F)..."
        '
        'popAcceptancePrint
        '
        Me.popAcceptancePrint.Name = "popAcceptancePrint"
        Me.popAcceptancePrint.Size = New System.Drawing.Size(180, 22)
        Me.popAcceptancePrint.Text = "送貨詳細表(&B)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.A_AcceptanceNO, Me.PM_NO, Me.M_Code, Me.M_Name, Me.DepotNO, Me.A_SendNO, Me.A_Qty, Me.A_Check, Me.A_AccCheck, Me.A_Detail, Me.OS_BatchID, Me.A_SendType, Me.A_SendDate, Me.A_UpdateDate, Me.S_SupplierName, Me.M_Gauge})
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
        Me.A_AcceptanceNO.Width = 80
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "外發單號"
        Me.PM_NO.FieldName = "O_NO"
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
        'DepotNO
        '
        Me.DepotNO.Caption = "倉庫代號"
        Me.DepotNO.FieldName = "WH_ID"
        Me.DepotNO.Name = "DepotNO"
        Me.DepotNO.Visible = True
        Me.DepotNO.VisibleIndex = 4
        Me.DepotNO.Width = 60
        '
        'A_SendNO
        '
        Me.A_SendNO.Caption = "送貨單號"
        Me.A_SendNO.FieldName = "A_SendNO"
        Me.A_SendNO.Name = "A_SendNO"
        Me.A_SendNO.Visible = True
        Me.A_SendNO.VisibleIndex = 7
        '
        'A_Qty
        '
        Me.A_Qty.Caption = "送貨數量"
        Me.A_Qty.FieldName = "A_Qty"
        Me.A_Qty.Name = "A_Qty"
        Me.A_Qty.Visible = True
        Me.A_Qty.VisibleIndex = 8
        Me.A_Qty.Width = 60
        '
        'A_Check
        '
        Me.A_Check.Caption = "驗收"
        Me.A_Check.FieldName = "A_Check"
        Me.A_Check.Name = "A_Check"
        Me.A_Check.Visible = True
        Me.A_Check.VisibleIndex = 11
        Me.A_Check.Width = 60
        '
        'A_AccCheck
        '
        Me.A_AccCheck.Caption = "審核"
        Me.A_AccCheck.FieldName = "A_AccCheck"
        Me.A_AccCheck.Name = "A_AccCheck"
        Me.A_AccCheck.Visible = True
        Me.A_AccCheck.VisibleIndex = 12
        Me.A_AccCheck.Width = 45
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
        'A_SendType
        '
        Me.A_SendType.Caption = "送貨類型"
        Me.A_SendType.FieldName = "A_SendType"
        Me.A_SendType.Name = "A_SendType"
        Me.A_SendType.Visible = True
        Me.A_SendType.VisibleIndex = 6
        '
        'A_SendDate
        '
        Me.A_SendDate.Caption = "送貨日期"
        Me.A_SendDate.FieldName = "A_SendDate"
        Me.A_SendDate.Name = "A_SendDate"
        Me.A_SendDate.Visible = True
        Me.A_SendDate.VisibleIndex = 13
        '
        'A_UpdateDate
        '
        Me.A_UpdateDate.Caption = "修改日期"
        Me.A_UpdateDate.FieldName = "A_UpdateDate"
        Me.A_UpdateDate.Name = "A_UpdateDate"
        Me.A_UpdateDate.Visible = True
        Me.A_UpdateDate.VisibleIndex = 14
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 10
        Me.S_SupplierName.Width = 100
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 3
        '
        'FormAcceptanceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 503)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormAcceptanceMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "驗收管理"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popAcceptance.ResumeLayout(False)
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
    Friend WithEvents A_SendNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_AccCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents A_UpdateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popAcceptance As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popAcceptanceAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popAcceptanceCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptanceAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popAcceptanceRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popAcceptanceSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popAcceptancePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
End Class
