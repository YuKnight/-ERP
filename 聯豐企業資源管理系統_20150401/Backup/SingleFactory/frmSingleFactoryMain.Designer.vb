<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingleFactoryMain
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
        Me.SingleFactory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SFAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.SFEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.SFDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SFRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SFView = New System.Windows.Forms.ToolStripMenuItem
        Me.SFQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SFCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.SFPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SF_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P_Detail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_Address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_CheckAction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SF_CheckRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SingleFactory.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ContextMenuStrip = Me.SingleFactory
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(1, 36)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(684, 378)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SingleFactory
        '
        Me.SingleFactory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SFAdd, Me.SFEdit, Me.SFDel, Me.ToolStripSeparator1, Me.SFRef, Me.ToolStripSeparator3, Me.SFView, Me.SFQuery, Me.ToolStripSeparator2, Me.SFCheck, Me.SFPrint})
        Me.SingleFactory.Name = "SingleFactory"
        Me.SingleFactory.Size = New System.Drawing.Size(107, 198)
        '
        'SFAdd
        '
        Me.SFAdd.Enabled = False
        Me.SFAdd.Name = "SFAdd"
        Me.SFAdd.Size = New System.Drawing.Size(106, 22)
        Me.SFAdd.Text = "新增"
        '
        'SFEdit
        '
        Me.SFEdit.Enabled = False
        Me.SFEdit.Name = "SFEdit"
        Me.SFEdit.Size = New System.Drawing.Size(106, 22)
        Me.SFEdit.Text = "修改"
        '
        'SFDel
        '
        Me.SFDel.Enabled = False
        Me.SFDel.Name = "SFDel"
        Me.SFDel.Size = New System.Drawing.Size(106, 22)
        Me.SFDel.Text = "刪除"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(103, 6)
        '
        'SFRef
        '
        Me.SFRef.Name = "SFRef"
        Me.SFRef.Size = New System.Drawing.Size(106, 22)
        Me.SFRef.Text = "刷新"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(103, 6)
        '
        'SFView
        '
        Me.SFView.Name = "SFView"
        Me.SFView.Size = New System.Drawing.Size(106, 22)
        Me.SFView.Text = "查看"
        '
        'SFQuery
        '
        Me.SFQuery.Name = "SFQuery"
        Me.SFQuery.Size = New System.Drawing.Size(106, 22)
        Me.SFQuery.Text = "查詢"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(103, 6)
        '
        'SFCheck
        '
        Me.SFCheck.Enabled = False
        Me.SFCheck.Name = "SFCheck"
        Me.SFCheck.Size = New System.Drawing.Size(106, 22)
        Me.SFCheck.Text = "審核"
        '
        'SFPrint
        '
        Me.SFPrint.Name = "SFPrint"
        Me.SFPrint.Size = New System.Drawing.Size(106, 22)
        Me.SFPrint.Text = "出廠單"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SF_ID, Me.P_NO, Me.P_Detail, Me.SF_Address, Me.SF_Date, Me.SF_Action, Me.SF_Check, Me.SF_CheckAction, Me.SF_CheckRemark})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SF_ID
        '
        Me.SF_ID.Caption = "出廠單號"
        Me.SF_ID.FieldName = "SF_ID"
        Me.SF_ID.Name = "SF_ID"
        Me.SF_ID.Visible = True
        Me.SF_ID.VisibleIndex = 0
        Me.SF_ID.Width = 85
        '
        'P_NO
        '
        Me.P_NO.Caption = "裝箱編號"
        Me.P_NO.FieldName = "P_NO"
        Me.P_NO.Name = "P_NO"
        Me.P_NO.Visible = True
        Me.P_NO.VisibleIndex = 1
        Me.P_NO.Width = 78
        '
        'P_Detail
        '
        Me.P_Detail.Caption = "裝箱內容"
        Me.P_Detail.FieldName = "P_Detail"
        Me.P_Detail.Name = "P_Detail"
        Me.P_Detail.Visible = True
        Me.P_Detail.VisibleIndex = 2
        Me.P_Detail.Width = 96
        '
        'SF_Address
        '
        Me.SF_Address.Caption = "出廠地點"
        Me.SF_Address.FieldName = "SF_Address"
        Me.SF_Address.Name = "SF_Address"
        Me.SF_Address.Visible = True
        Me.SF_Address.VisibleIndex = 3
        Me.SF_Address.Width = 94
        '
        'SF_Date
        '
        Me.SF_Date.Caption = "出廠日期"
        Me.SF_Date.FieldName = "SF_Date"
        Me.SF_Date.Name = "SF_Date"
        Me.SF_Date.Visible = True
        Me.SF_Date.VisibleIndex = 4
        Me.SF_Date.Width = 79
        '
        'SF_Action
        '
        Me.SF_Action.Caption = "操作員"
        Me.SF_Action.FieldName = "SF_ActionName"
        Me.SF_Action.Name = "SF_Action"
        Me.SF_Action.Visible = True
        Me.SF_Action.VisibleIndex = 5
        Me.SF_Action.Width = 61
        '
        'SF_Check
        '
        Me.SF_Check.Caption = "審核"
        Me.SF_Check.FieldName = "SF_Check"
        Me.SF_Check.Name = "SF_Check"
        Me.SF_Check.Visible = True
        Me.SF_Check.VisibleIndex = 6
        Me.SF_Check.Width = 46
        '
        'SF_CheckAction
        '
        Me.SF_CheckAction.Caption = "審核員"
        Me.SF_CheckAction.FieldName = "SF_CheckActionName"
        Me.SF_CheckAction.Name = "SF_CheckAction"
        Me.SF_CheckAction.Visible = True
        Me.SF_CheckAction.VisibleIndex = 7
        Me.SF_CheckAction.Width = 54
        '
        'SF_CheckRemark
        '
        Me.SF_CheckRemark.Caption = "審核備註"
        Me.SF_CheckRemark.FieldName = "SF_CheckRemark"
        Me.SF_CheckRemark.Name = "SF_CheckRemark"
        Me.SF_CheckRemark.Visible = True
        Me.SF_CheckRemark.VisibleIndex = 8
        Me.SF_CheckRemark.Width = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 33)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "出廠管理"
        '
        'frmSingleFactoryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 416)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "frmSingleFactoryMain"
        Me.Text = "出廠管理"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SingleFactory.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SF_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_CheckAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SF_CheckRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SingleFactory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SFAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SFView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SFCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
