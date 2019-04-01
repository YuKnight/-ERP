<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseApply
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AP_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_P_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_Applyreason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyPersonName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_ApplyDptName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AP_CheckPurchase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdFind)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(482, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(93, 21)
        Me.txtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "物料名稱(&N)："
        '
        'txtCode
        '
        Me.txtCode.EditValue = ""
        Me.txtCode.Location = New System.Drawing.Point(259, 18)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 21)
        Me.txtCode.TabIndex = 3
        Me.txtCode.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "物料編碼(&M)："
        '
        'cmdFind
        '
        Me.cmdFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdFind.Location = New System.Drawing.Point(594, 15)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(79, 26)
        Me.cmdFind.TabIndex = 6
        Me.cmdFind.Text = "查詢(&F)"
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(85, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(86, 21)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "申購單號(&I)："
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdOK.Location = New System.Drawing.Point(522, 357)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(81, 26)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "確定(&O)"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(638, 357)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(81, 26)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "取消(&C)"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(1, 56)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.Grid1.Size = New System.Drawing.Size(750, 296)
        Me.Grid1.TabIndex = 9
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AP_Num, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.AP_M_Gauge, Me.AP_Qty, Me.AP_P_Qty, Me.AP_M_Unit, Me.AP_Applyreason, Me.AP_ApplyPersonName, Me.AP_ApplyDptName, Me.AP_CheckPurchase})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
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
        'AP_Num
        '
        Me.AP_Num.Caption = "AP_Num"
        Me.AP_Num.FieldName = "AP_Num"
        Me.AP_Num.Name = "AP_Num"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "申購單號"
        Me.GridColumn1.FieldName = "AP_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "物料編碼"
        Me.GridColumn2.FieldName = "AP_M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "物料名稱"
        Me.GridColumn3.FieldName = "AP_M_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 60
        '
        'AP_M_Gauge
        '
        Me.AP_M_Gauge.Caption = "規格"
        Me.AP_M_Gauge.FieldName = "AP_M_Gauge"
        Me.AP_M_Gauge.Name = "AP_M_Gauge"
        Me.AP_M_Gauge.OptionsColumn.ReadOnly = True
        Me.AP_M_Gauge.Visible = True
        Me.AP_M_Gauge.VisibleIndex = 3
        '
        'AP_Qty
        '
        Me.AP_Qty.Caption = "申購數量"
        Me.AP_Qty.FieldName = "AP_Qty"
        Me.AP_Qty.Name = "AP_Qty"
        Me.AP_Qty.OptionsColumn.ReadOnly = True
        Me.AP_Qty.Visible = True
        Me.AP_Qty.VisibleIndex = 4
        Me.AP_Qty.Width = 60
        '
        'AP_P_Qty
        '
        Me.AP_P_Qty.Caption = "已採購數量"
        Me.AP_P_Qty.FieldName = "AP_P_Qty"
        Me.AP_P_Qty.Name = "AP_P_Qty"
        Me.AP_P_Qty.OptionsColumn.ReadOnly = True
        Me.AP_P_Qty.Visible = True
        Me.AP_P_Qty.VisibleIndex = 5
        Me.AP_P_Qty.Width = 65
        '
        'AP_M_Unit
        '
        Me.AP_M_Unit.Caption = "單位"
        Me.AP_M_Unit.FieldName = "AP_M_Unit"
        Me.AP_M_Unit.Name = "AP_M_Unit"
        Me.AP_M_Unit.OptionsColumn.ReadOnly = True
        Me.AP_M_Unit.Visible = True
        Me.AP_M_Unit.VisibleIndex = 6
        Me.AP_M_Unit.Width = 50
        '
        'AP_Applyreason
        '
        Me.AP_Applyreason.Caption = "申購原因"
        Me.AP_Applyreason.FieldName = "AP_Applyreason"
        Me.AP_Applyreason.Name = "AP_Applyreason"
        Me.AP_Applyreason.OptionsColumn.ReadOnly = True
        Me.AP_Applyreason.Visible = True
        Me.AP_Applyreason.VisibleIndex = 7
        Me.AP_Applyreason.Width = 70
        '
        'AP_ApplyPersonName
        '
        Me.AP_ApplyPersonName.Caption = "申購人"
        Me.AP_ApplyPersonName.FieldName = "AP_ApplyPersonName"
        Me.AP_ApplyPersonName.Name = "AP_ApplyPersonName"
        Me.AP_ApplyPersonName.OptionsColumn.ReadOnly = True
        Me.AP_ApplyPersonName.Visible = True
        Me.AP_ApplyPersonName.VisibleIndex = 8
        Me.AP_ApplyPersonName.Width = 50
        '
        'AP_ApplyDptName
        '
        Me.AP_ApplyDptName.Caption = "申購部門"
        Me.AP_ApplyDptName.FieldName = "AP_ApplyDptName"
        Me.AP_ApplyDptName.Name = "AP_ApplyDptName"
        Me.AP_ApplyDptName.OptionsColumn.ReadOnly = True
        Me.AP_ApplyDptName.Visible = True
        Me.AP_ApplyDptName.VisibleIndex = 9
        Me.AP_ApplyDptName.Width = 60
        '
        'AP_CheckPurchase
        '
        Me.AP_CheckPurchase.Caption = "採購"
        Me.AP_CheckPurchase.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.AP_CheckPurchase.FieldName = "AP_CheckPurchase"
        Me.AP_CheckPurchase.Name = "AP_CheckPurchase"
        Me.AP_CheckPurchase.Visible = True
        Me.AP_CheckPurchase.VisibleIndex = 10
        Me.AP_CheckPurchase.Width = 50
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmPurchaseApply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(752, 387)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPurchaseApply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "申購單"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_Applyreason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyPersonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_ApplyDptName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents AP_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AP_CheckPurchase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AP_P_Qty As DevExpress.XtraGrid.Columns.GridColumn
End Class
