<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliersOldRecord
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Associate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Tel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Phone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Fax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Web = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_TypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Currency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Rank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_ReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_EditUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmsRef = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(210, 42)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(590, 518)
        Me.Grid1.TabIndex = 168
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsFind, Me.cmsRef})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 70)
        '
        'cmsFind
        '
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmsFind.Size = New System.Drawing.Size(178, 22)
        Me.cmsFind.Text = "查詢(&F)..."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName, Me.S_Associate, Me.S_Tel, Me.S_Phone, Me.S_Fax, Me.GridColumn1, Me.S_Address, Me.S_Web, Me.S_TypeName, Me.S_Currency, Me.S_Rank, Me.S_Check, Me.S_ReCheck, Me.S_Action, Me.S_AddDate, Me.S_EditDate, Me.S_EditUser, Me.S_CheckDate, Me.S_CheckAction})
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
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商代號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        Me.S_SupplierName.Width = 135
        '
        'S_Associate
        '
        Me.S_Associate.Caption = "聯系人1"
        Me.S_Associate.FieldName = "S_Associate"
        Me.S_Associate.Name = "S_Associate"
        Me.S_Associate.Visible = True
        Me.S_Associate.VisibleIndex = 2
        Me.S_Associate.Width = 89
        '
        'S_Tel
        '
        Me.S_Tel.Caption = "聯系電話1"
        Me.S_Tel.FieldName = "S_Tel"
        Me.S_Tel.Name = "S_Tel"
        Me.S_Tel.Visible = True
        Me.S_Tel.VisibleIndex = 3
        Me.S_Tel.Width = 89
        '
        'S_Phone
        '
        Me.S_Phone.Caption = "手機1"
        Me.S_Phone.FieldName = "S_Phone"
        Me.S_Phone.Name = "S_Phone"
        Me.S_Phone.Visible = True
        Me.S_Phone.VisibleIndex = 4
        Me.S_Phone.Width = 93
        '
        'S_Fax
        '
        Me.S_Fax.Caption = "傳真1"
        Me.S_Fax.FieldName = "S_Fax"
        Me.S_Fax.Name = "S_Fax"
        Me.S_Fax.Visible = True
        Me.S_Fax.VisibleIndex = 5
        Me.S_Fax.Width = 117
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Email--1"
        Me.GridColumn1.FieldName = "S_Email"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 121
        '
        'S_Address
        '
        Me.S_Address.Caption = "地址1"
        Me.S_Address.FieldName = "S_Address"
        Me.S_Address.Name = "S_Address"
        Me.S_Address.Visible = True
        Me.S_Address.VisibleIndex = 7
        Me.S_Address.Width = 201
        '
        'S_Web
        '
        Me.S_Web.Caption = "網站"
        Me.S_Web.FieldName = "S_Web"
        Me.S_Web.Name = "S_Web"
        Me.S_Web.Visible = True
        Me.S_Web.VisibleIndex = 8
        '
        'S_TypeName
        '
        Me.S_TypeName.Caption = "供應商類型"
        Me.S_TypeName.FieldName = "S_TypeName"
        Me.S_TypeName.Name = "S_TypeName"
        Me.S_TypeName.Visible = True
        Me.S_TypeName.VisibleIndex = 9
        Me.S_TypeName.Width = 122
        '
        'S_Currency
        '
        Me.S_Currency.Caption = "幣別"
        Me.S_Currency.FieldName = "S_Currency"
        Me.S_Currency.Name = "S_Currency"
        Me.S_Currency.Visible = True
        Me.S_Currency.VisibleIndex = 10
        Me.S_Currency.Width = 47
        '
        'S_Rank
        '
        Me.S_Rank.Caption = "信用等級"
        Me.S_Rank.FieldName = "S_Rank"
        Me.S_Rank.Name = "S_Rank"
        Me.S_Rank.Visible = True
        Me.S_Rank.VisibleIndex = 11
        Me.S_Rank.Width = 63
        '
        'S_Check
        '
        Me.S_Check.Caption = "審核"
        Me.S_Check.FieldName = "S_Check"
        Me.S_Check.Name = "S_Check"
        Me.S_Check.Visible = True
        Me.S_Check.VisibleIndex = 12
        Me.S_Check.Width = 60
        '
        'S_ReCheck
        '
        Me.S_ReCheck.Caption = "終審"
        Me.S_ReCheck.FieldName = "S_ReCheck"
        Me.S_ReCheck.Name = "S_ReCheck"
        Me.S_ReCheck.Visible = True
        Me.S_ReCheck.VisibleIndex = 13
        Me.S_ReCheck.Width = 60
        '
        'S_Action
        '
        Me.S_Action.Caption = "操作員"
        Me.S_Action.FieldName = "S_Action"
        Me.S_Action.Name = "S_Action"
        Me.S_Action.Visible = True
        Me.S_Action.VisibleIndex = 14
        Me.S_Action.Width = 60
        '
        'S_AddDate
        '
        Me.S_AddDate.Caption = "新增日期"
        Me.S_AddDate.FieldName = "S_AddDate"
        Me.S_AddDate.Name = "S_AddDate"
        Me.S_AddDate.Visible = True
        Me.S_AddDate.VisibleIndex = 15
        '
        'S_EditDate
        '
        Me.S_EditDate.Caption = "修改日期"
        Me.S_EditDate.FieldName = "S_EditDate"
        Me.S_EditDate.Name = "S_EditDate"
        Me.S_EditDate.Visible = True
        Me.S_EditDate.VisibleIndex = 16
        '
        'S_EditUser
        '
        Me.S_EditUser.Caption = "修改人"
        Me.S_EditUser.FieldName = "S_EditUser"
        Me.S_EditUser.Name = "S_EditUser"
        Me.S_EditUser.Visible = True
        Me.S_EditUser.VisibleIndex = 17
        '
        'S_CheckDate
        '
        Me.S_CheckDate.Caption = "審核日期"
        Me.S_CheckDate.FieldName = "S_CheckDate"
        Me.S_CheckDate.Name = "S_CheckDate"
        Me.S_CheckDate.Visible = True
        Me.S_CheckDate.VisibleIndex = 18
        '
        'S_CheckAction
        '
        Me.S_CheckAction.Caption = "審核人"
        Me.S_CheckAction.FieldName = "S_CheckAction"
        Me.S_CheckAction.Name = "S_CheckAction"
        Me.S_CheckAction.Visible = True
        Me.S_CheckAction.VisibleIndex = 19
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn4, Me.TreeListColumn6})
        Me.TreeList1.KeyFieldName = "S_TypeID"
        Me.TreeList1.Location = New System.Drawing.Point(3, 42)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "S_TypePID"
        Me.TreeList1.Size = New System.Drawing.Size(203, 518)
        Me.TreeList1.TabIndex = 167
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "供應商類型"
        Me.TreeListColumn4.FieldName = "S_TypeName"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.ReadOnly = True
        Me.TreeListColumn4.VisibleIndex = 0
        Me.TreeListColumn4.Width = 129
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "代號"
        Me.TreeListColumn6.FieldName = "S_TypeID"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.OptionsColumn.ReadOnly = True
        Me.TreeListColumn6.VisibleIndex = 1
        Me.TreeListColumn6.Width = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(11, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "供應商修改前資料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 36)
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'cmsRef
        '
        Me.cmsRef.Name = "cmsRef"
        Me.cmsRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmsRef.Size = New System.Drawing.Size(178, 22)
        Me.cmsRef.Text = "刷新(&R)"
        '
        'frmSuppliersOldRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 563)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSuppliersOldRecord"
        Me.Text = "供應商修改前資料"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Associate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Tel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Phone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Web As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_TypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Currency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_ReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S_EditUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsRef As System.Windows.Forms.ToolStripMenuItem
End Class
