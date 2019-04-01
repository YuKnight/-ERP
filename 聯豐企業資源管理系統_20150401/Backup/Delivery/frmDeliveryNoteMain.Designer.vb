<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveryNoteMain
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.cmsDelivery = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeliveryAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.DeliveryRef = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryView = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliverySelect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeliveryCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryAccCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DN_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_Charge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_Invoice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_Return = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DN_AccCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDelivery.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.cmsDelivery
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 36)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(600, 380)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmsDelivery
        '
        Me.cmsDelivery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeliveryAdd, Me.DeliveryEdit, Me.DeliveryDel, Me.ToolStripSeparator2, Me.DeliveryRef, Me.DeliveryView, Me.DeliverySelect, Me.ToolStripSeparator1, Me.DeliveryCheck, Me.DeliveryAccCheck})
        Me.cmsDelivery.Name = "cmsDelivery"
        Me.cmsDelivery.Size = New System.Drawing.Size(95, 192)
        '
        'DeliveryAdd
        '
        Me.DeliveryAdd.Enabled = False
        Me.DeliveryAdd.Name = "DeliveryAdd"
        Me.DeliveryAdd.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryAdd.Text = "新增"
        '
        'DeliveryEdit
        '
        Me.DeliveryEdit.Enabled = False
        Me.DeliveryEdit.Name = "DeliveryEdit"
        Me.DeliveryEdit.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryEdit.Text = "修改"
        '
        'DeliveryDel
        '
        Me.DeliveryDel.Enabled = False
        Me.DeliveryDel.Name = "DeliveryDel"
        Me.DeliveryDel.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryDel.Text = "刪除"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(91, 6)
        '
        'DeliveryRef
        '
        Me.DeliveryRef.Name = "DeliveryRef"
        Me.DeliveryRef.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryRef.Text = "刷新"
        '
        'DeliveryView
        '
        Me.DeliveryView.Name = "DeliveryView"
        Me.DeliveryView.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryView.Text = "查看"
        '
        'DeliverySelect
        '
        Me.DeliverySelect.Name = "DeliverySelect"
        Me.DeliverySelect.Size = New System.Drawing.Size(94, 22)
        Me.DeliverySelect.Text = "查詢"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(91, 6)
        '
        'DeliveryCheck
        '
        Me.DeliveryCheck.Enabled = False
        Me.DeliveryCheck.Name = "DeliveryCheck"
        Me.DeliveryCheck.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryCheck.Text = "審核"
        '
        'DeliveryAccCheck
        '
        Me.DeliveryAccCheck.Enabled = False
        Me.DeliveryAccCheck.Name = "DeliveryAccCheck"
        Me.DeliveryAccCheck.Size = New System.Drawing.Size(94, 22)
        Me.DeliveryAccCheck.Text = "復核"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DN_ID, Me.WH_ID, Me.DN_CusterNO, Me.DN_Type, Me.DN_Charge, Me.DN_Invoice, Me.DN_Return, Me.ActionName, Me.DN_Check, Me.DN_AccCheck})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'DN_ID
        '
        Me.DN_ID.Caption = "送貨單號"
        Me.DN_ID.FieldName = "DN_ID"
        Me.DN_ID.Name = "DN_ID"
        Me.DN_ID.Visible = True
        Me.DN_ID.VisibleIndex = 0
        Me.DN_ID.Width = 64
        '
        'WH_ID
        '
        Me.WH_ID.Caption = "倉庫編號"
        Me.WH_ID.FieldName = "WH_ID"
        Me.WH_ID.Name = "WH_ID"
        Me.WH_ID.Visible = True
        Me.WH_ID.VisibleIndex = 1
        Me.WH_ID.Width = 63
        '
        'DN_CusterNO
        '
        Me.DN_CusterNO.Caption = "客戶代號"
        Me.DN_CusterNO.FieldName = "DN_CusterNO"
        Me.DN_CusterNO.Name = "DN_CusterNO"
        Me.DN_CusterNO.Visible = True
        Me.DN_CusterNO.VisibleIndex = 2
        Me.DN_CusterNO.Width = 65
        '
        'DN_Type
        '
        Me.DN_Type.Caption = "送貨類型"
        Me.DN_Type.FieldName = "DN_Type"
        Me.DN_Type.Name = "DN_Type"
        Me.DN_Type.Visible = True
        Me.DN_Type.VisibleIndex = 3
        Me.DN_Type.Width = 61
        '
        'DN_Charge
        '
        Me.DN_Charge.Caption = "收費類型"
        Me.DN_Charge.FieldName = "DN_Charge"
        Me.DN_Charge.Name = "DN_Charge"
        Me.DN_Charge.Visible = True
        Me.DN_Charge.VisibleIndex = 4
        Me.DN_Charge.Width = 62
        '
        'DN_Invoice
        '
        Me.DN_Invoice.Caption = "發票"
        Me.DN_Invoice.FieldName = "DN_Invoice"
        Me.DN_Invoice.Name = "DN_Invoice"
        Me.DN_Invoice.Visible = True
        Me.DN_Invoice.VisibleIndex = 5
        Me.DN_Invoice.Width = 36
        '
        'DN_Return
        '
        Me.DN_Return.Caption = "退貨"
        Me.DN_Return.FieldName = "DN_Return"
        Me.DN_Return.Name = "DN_Return"
        Me.DN_Return.Visible = True
        Me.DN_Return.VisibleIndex = 6
        Me.DN_Return.Width = 36
        '
        'ActionName
        '
        Me.ActionName.Caption = "操作員"
        Me.ActionName.FieldName = "ActionName"
        Me.ActionName.Name = "ActionName"
        Me.ActionName.Visible = True
        Me.ActionName.VisibleIndex = 7
        Me.ActionName.Width = 52
        '
        'DN_Check
        '
        Me.DN_Check.Caption = "審核"
        Me.DN_Check.FieldName = "DN_Check"
        Me.DN_Check.Name = "DN_Check"
        Me.DN_Check.Visible = True
        Me.DN_Check.VisibleIndex = 8
        Me.DN_Check.Width = 40
        '
        'DN_AccCheck
        '
        Me.DN_AccCheck.Caption = "復核"
        Me.DN_AccCheck.FieldName = "DN_AccCheck"
        Me.DN_AccCheck.Name = "DN_AccCheck"
        Me.DN_AccCheck.Visible = True
        Me.DN_AccCheck.VisibleIndex = 9
        Me.DN_AccCheck.Width = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 36)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "送貨管理"
        '
        'frmDeliveryNoteMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "frmDeliveryNoteMain"
        Me.Text = "送貨管理"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDelivery.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DN_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_Charge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_Invoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_Return As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DN_AccCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsDelivery As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeliveryAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeliveryView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliverySelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeliveryCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryAccCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryRef As System.Windows.Forms.ToolStripMenuItem
End Class
