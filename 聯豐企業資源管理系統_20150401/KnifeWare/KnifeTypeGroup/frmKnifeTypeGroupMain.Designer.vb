<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeTypeGroupMain
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
        Me.LabMsg = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TreeKnifeType = New DevExpress.XtraTreeList.TreeList
        Me.KnifeType = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.KnifePIDName = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.ContextType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemAddNext = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemUpdate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuM_Code = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddM_Code = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDeteleM_Code = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabKnifeID = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeKnifeType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextType.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuM_Code.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabMsg
        '
        Me.LabMsg.AutoSize = True
        Me.LabMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabMsg.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabMsg.ForeColor = System.Drawing.Color.Navy
        Me.LabMsg.Location = New System.Drawing.Point(5, 8)
        Me.LabMsg.Name = "LabMsg"
        Me.LabMsg.Size = New System.Drawing.Size(154, 24)
        Me.LabMsg.TabIndex = 213
        Me.LabMsg.Text = "刀具規格分類"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(733, 36)
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'TreeKnifeType
        '
        Me.TreeKnifeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeKnifeType.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.KnifeType, Me.KnifePIDName})
        Me.TreeKnifeType.ContextMenuStrip = Me.ContextType
        Me.TreeKnifeType.KeyFieldName = "KnifeID"
        Me.TreeKnifeType.Location = New System.Drawing.Point(1, 40)
        Me.TreeKnifeType.Name = "TreeKnifeType"
        Me.TreeKnifeType.ParentFieldName = "KnifePID"
        Me.TreeKnifeType.Size = New System.Drawing.Size(209, 459)
        Me.TreeKnifeType.TabIndex = 214
        '
        'KnifeType
        '
        Me.KnifeType.Caption = "刀具類"
        Me.KnifeType.FieldName = "KnifeType"
        Me.KnifeType.Name = "KnifeType"
        Me.KnifeType.OptionsColumn.AllowEdit = False
        Me.KnifeType.OptionsColumn.AllowFocus = False
        Me.KnifeType.OptionsColumn.ReadOnly = True
        Me.KnifeType.VisibleIndex = 0
        '
        'KnifePIDName
        '
        Me.KnifePIDName.Caption = "KnifePIDName"
        Me.KnifePIDName.FieldName = "KnifePIDName"
        Me.KnifePIDName.Name = "KnifePIDName"
        '
        'ContextType
        '
        Me.ContextType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAdd, Me.ToolStripMenuItemAddNext, Me.ToolStripMenuItemUpdate, Me.ToolStripMenuItemRefresh, Me.ToolStripMenuItem1, Me.ToolStripMenuItemDelete})
        Me.ContextType.Name = "ContextType"
        Me.ContextType.Size = New System.Drawing.Size(147, 120)
        '
        'ToolStripMenuItemAdd
        '
        Me.ToolStripMenuItemAdd.Enabled = False
        Me.ToolStripMenuItemAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd"
        Me.ToolStripMenuItemAdd.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItemAdd.Text = "新增(&A)"
        '
        'ToolStripMenuItemAddNext
        '
        Me.ToolStripMenuItemAddNext.Enabled = False
        Me.ToolStripMenuItemAddNext.Image = Global.LFERP.My.Resources.Resources.SlideBackgroundReset
        Me.ToolStripMenuItemAddNext.Name = "ToolStripMenuItemAddNext"
        Me.ToolStripMenuItemAddNext.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItemAddNext.Text = "新增下一級(&N)"
        '
        'ToolStripMenuItemUpdate
        '
        Me.ToolStripMenuItemUpdate.Enabled = False
        Me.ToolStripMenuItemUpdate.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate"
        Me.ToolStripMenuItemUpdate.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItemUpdate.Text = "修改(&U)"
        '
        'ToolStripMenuItemRefresh
        '
        Me.ToolStripMenuItemRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.ToolStripMenuItemRefresh.Name = "ToolStripMenuItemRefresh"
        Me.ToolStripMenuItemRefresh.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItemRefresh.Text = "刷新(&R)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'ToolStripMenuItemDelete
        '
        Me.ToolStripMenuItemDelete.Enabled = False
        Me.ToolStripMenuItemDelete.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete"
        Me.ToolStripMenuItemDelete.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItemDelete.Text = "刪除(&D)"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuM_Code
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(212, 40)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(521, 458)
        Me.Grid1.TabIndex = 215
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuM_Code
        '
        Me.ContextMenuM_Code.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAddM_Code, Me.ToolStripMenuItem2, Me.ToolStripDeteleM_Code})
        Me.ContextMenuM_Code.Name = "ContextMenuM_Code"
        Me.ContextMenuM_Code.Size = New System.Drawing.Size(134, 54)
        '
        'ToolStripAddM_Code
        '
        Me.ToolStripAddM_Code.Enabled = False
        Me.ToolStripAddM_Code.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.ToolStripAddM_Code.Name = "ToolStripAddM_Code"
        Me.ToolStripAddM_Code.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripAddM_Code.Text = "新增成員(&T)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripDeteleM_Code
        '
        Me.ToolStripDeteleM_Code.Enabled = False
        Me.ToolStripDeteleM_Code.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.ToolStripDeteleM_Code.Name = "ToolStripDeteleM_Code"
        Me.ToolStripDeteleM_Code.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripDeteleM_Code.Text = "刪除成員(&I)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.SummaryItem.DisplayFormat = "共:{0}條記錄"
        Me.M_Code.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        '
        'LabKnifeID
        '
        Me.LabKnifeID.AutoSize = True
        Me.LabKnifeID.Location = New System.Drawing.Point(401, 17)
        Me.LabKnifeID.Name = "LabKnifeID"
        Me.LabKnifeID.Size = New System.Drawing.Size(23, 12)
        Me.LabKnifeID.TabIndex = 216
        Me.LabKnifeID.Text = "***"
        Me.LabKnifeID.Visible = False
        '
        'frmKnifeTypeGroupMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 500)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TreeKnifeType)
        Me.Controls.Add(Me.LabKnifeID)
        Me.Controls.Add(Me.LabMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmKnifeTypeGroupMain"
        Me.Text = "刀具規格分類"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeKnifeType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextType.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuM_Code.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeKnifeType As DevExpress.XtraTreeList.TreeList
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnifeType As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ContextType As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItemAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItemRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAddNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuM_Code As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripAddM_Code As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDeteleM_Code As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabKnifeID As System.Windows.Forms.Label
    Friend WithEvents KnifePIDName As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
