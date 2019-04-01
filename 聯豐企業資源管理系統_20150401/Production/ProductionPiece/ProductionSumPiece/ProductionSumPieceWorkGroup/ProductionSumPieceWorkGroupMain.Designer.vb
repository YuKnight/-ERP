<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionSumPieceWorkGroupMain
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
        Me.popSumWorkGroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popSumWorkGroupAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumWorkGroupEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumWorkGrouplDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumWorkGroupView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumWorkGroupRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumWorkGroupSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumWorkGroupPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumWorkGroupCollectPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumWorkGroupCollectPrintList = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.GNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GP_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_NameS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PP_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Labtitle = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSumWorkGroup.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popSumWorkGroup
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(-1, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 418)
        Me.Grid1.TabIndex = 271
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popSumWorkGroup
        '
        Me.popSumWorkGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popSumWorkGroupAdd, Me.popSumWorkGroupEdit, Me.popSumWorkGrouplDel, Me.popSumWorkGroupView, Me.ToolStripSeparator1, Me.popSumWorkGroupRef, Me.ToolStripSeparator2, Me.popSumWorkGroupSeek, Me.ToolStripMenuItem1, Me.popSumWorkGroupPrint, Me.popSumWorkGroupCollectPrint, Me.ToolStripMenuItem2, Me.popSumWorkGroupCollectPrintList, Me.ToolStripMenuItem3, Me.ExpotExcelToolStripMenuItem, Me.ToolStripMenuItem4, Me.GNOToolStripMenuItem})
        Me.popSumWorkGroup.Name = "popAcceptance"
        Me.popSumWorkGroup.Size = New System.Drawing.Size(230, 282)
        Me.popSumWorkGroup.Text = "承包計件匯總表(&C)"
        '
        'popSumWorkGroupAdd
        '
        Me.popSumWorkGroupAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popSumWorkGroupAdd.Name = "popSumWorkGroupAdd"
        Me.popSumWorkGroupAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popSumWorkGroupAdd.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupAdd.Text = "增加(&A)..."
        '
        'popSumWorkGroupEdit
        '
        Me.popSumWorkGroupEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popSumWorkGroupEdit.Name = "popSumWorkGroupEdit"
        Me.popSumWorkGroupEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popSumWorkGroupEdit.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupEdit.Text = "修改(&E)..."
        '
        'popSumWorkGrouplDel
        '
        Me.popSumWorkGrouplDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popSumWorkGrouplDel.Name = "popSumWorkGrouplDel"
        Me.popSumWorkGrouplDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popSumWorkGrouplDel.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGrouplDel.Text = "刪除(&D)"
        '
        'popSumWorkGroupView
        '
        Me.popSumWorkGroupView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popSumWorkGroupView.Name = "popSumWorkGroupView"
        Me.popSumWorkGroupView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popSumWorkGroupView.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'popSumWorkGroupRef
        '
        Me.popSumWorkGroupRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popSumWorkGroupRef.Name = "popSumWorkGroupRef"
        Me.popSumWorkGroupRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popSumWorkGroupRef.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(226, 6)
        '
        'popSumWorkGroupSeek
        '
        Me.popSumWorkGroupSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popSumWorkGroupSeek.Name = "popSumWorkGroupSeek"
        Me.popSumWorkGroupSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popSumWorkGroupSeek.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupSeek.Text = "查詢(&F)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 6)
        '
        'popSumWorkGroupPrint
        '
        Me.popSumWorkGroupPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popSumWorkGroupPrint.Name = "popSumWorkGroupPrint"
        Me.popSumWorkGroupPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popSumWorkGroupPrint.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupPrint.Text = "承包計件表(&P)"
        '
        'popSumWorkGroupCollectPrint
        '
        Me.popSumWorkGroupCollectPrint.Name = "popSumWorkGroupCollectPrint"
        Me.popSumWorkGroupCollectPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popSumWorkGroupCollectPrint.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupCollectPrint.Text = "承包計件匯總表(&C)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(226, 6)
        '
        'popSumWorkGroupCollectPrintList
        '
        Me.popSumWorkGroupCollectPrintList.Name = "popSumWorkGroupCollectPrintList"
        Me.popSumWorkGroupCollectPrintList.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.popSumWorkGroupCollectPrintList.Size = New System.Drawing.Size(229, 22)
        Me.popSumWorkGroupCollectPrintList.Text = "承包計件匯總表清單(&L)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(226, 6)
        '
        'ExpotExcelToolStripMenuItem
        '
        Me.ExpotExcelToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem.Name = "ExpotExcelToolStripMenuItem"
        Me.ExpotExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ExpotExcelToolStripMenuItem.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(226, 6)
        '
        'GNOToolStripMenuItem
        '
        Me.GNOToolStripMenuItem.Name = "GNOToolStripMenuItem"
        Me.GNOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.GNOToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.GNOToolStripMenuItem.Text = "導入組別計件(&I)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PP_NO, Me.Per_NO, Me.GP_G_Name, Me.DepID, Me.PT_FacName, Me.PM_M_Code, Me.PM_Type, Me.PS_Name, Me.PS_NameS, Me.PP_Qty, Me.PP_Date, Me.PP_G_Name, Me.DepID1})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PP_NO
        '
        Me.PP_NO.Caption = "計件單號"
        Me.PP_NO.FieldName = "GP_NO"
        Me.PP_NO.Name = "PP_NO"
        Me.PP_NO.OptionsColumn.AllowEdit = False
        Me.PP_NO.OptionsColumn.AllowFocus = False
        Me.PP_NO.SummaryItem.DisplayFormat = "記錄數：{0}"
        Me.PP_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.PP_NO.Visible = True
        Me.PP_NO.VisibleIndex = 0
        Me.PP_NO.Width = 105
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "組別編號"
        Me.Per_NO.FieldName = "G_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.OptionsColumn.AllowEdit = False
        Me.Per_NO.OptionsColumn.AllowFocus = False
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 1
        Me.Per_NO.Width = 80
        '
        'GP_G_Name
        '
        Me.GP_G_Name.Caption = "組別"
        Me.GP_G_Name.FieldName = "GP_G_Name"
        Me.GP_G_Name.Name = "GP_G_Name"
        Me.GP_G_Name.OptionsColumn.AllowEdit = False
        Me.GP_G_Name.OptionsColumn.AllowFocus = False
        Me.GP_G_Name.Visible = True
        Me.GP_G_Name.VisibleIndex = 2
        Me.GP_G_Name.Width = 60
        '
        'DepID
        '
        Me.DepID.Caption = "部門"
        Me.DepID.FieldName = "GP_DepName"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.AllowEdit = False
        Me.DepID.OptionsColumn.AllowFocus = False
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 3
        Me.DepID.Width = 59
        '
        'PT_FacName
        '
        Me.PT_FacName.Caption = "廠別"
        Me.PT_FacName.FieldName = "GP_FacName"
        Me.PT_FacName.Name = "PT_FacName"
        Me.PT_FacName.OptionsColumn.AllowEdit = False
        Me.PT_FacName.OptionsColumn.AllowFocus = False
        Me.PT_FacName.Visible = True
        Me.PT_FacName.VisibleIndex = 4
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.AllowEdit = False
        Me.PM_M_Code.OptionsColumn.AllowFocus = False
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 5
        Me.PM_M_Code.Width = 90
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.AllowEdit = False
        Me.PM_Type.OptionsColumn.AllowFocus = False
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 6
        Me.PM_Type.Width = 90
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "大工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.AllowEdit = False
        Me.PS_Name.OptionsColumn.AllowFocus = False
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 7
        Me.PS_Name.Width = 80
        '
        'PS_NameS
        '
        Me.PS_NameS.Caption = "小工序名稱"
        Me.PS_NameS.FieldName = "PS_NameS"
        Me.PS_NameS.Name = "PS_NameS"
        Me.PS_NameS.OptionsColumn.AllowEdit = False
        Me.PS_NameS.OptionsColumn.AllowFocus = False
        Me.PS_NameS.Visible = True
        Me.PS_NameS.VisibleIndex = 8
        Me.PS_NameS.Width = 80
        '
        'PP_Qty
        '
        Me.PP_Qty.Caption = "數量"
        Me.PP_Qty.FieldName = "GP_Qty"
        Me.PP_Qty.Name = "PP_Qty"
        Me.PP_Qty.OptionsColumn.AllowEdit = False
        Me.PP_Qty.OptionsColumn.AllowFocus = False
        Me.PP_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PP_Qty.Visible = True
        Me.PP_Qty.VisibleIndex = 9
        Me.PP_Qty.Width = 50
        '
        'PP_Date
        '
        Me.PP_Date.Caption = "計件時間"
        Me.PP_Date.FieldName = "GP_Date"
        Me.PP_Date.Name = "PP_Date"
        Me.PP_Date.OptionsColumn.AllowEdit = False
        Me.PP_Date.OptionsColumn.AllowFocus = False
        Me.PP_Date.Visible = True
        Me.PP_Date.VisibleIndex = 10
        Me.PP_Date.Width = 70
        '
        'PP_G_Name
        '
        Me.PP_G_Name.Caption = "操作員"
        Me.PP_G_Name.FieldName = "GP_ActionName"
        Me.PP_G_Name.Name = "PP_G_Name"
        Me.PP_G_Name.OptionsColumn.AllowEdit = False
        Me.PP_G_Name.OptionsColumn.AllowFocus = False
        Me.PP_G_Name.Visible = True
        Me.PP_G_Name.VisibleIndex = 11
        Me.PP_G_Name.Width = 70
        '
        'DepID1
        '
        Me.DepID1.Caption = "部門"
        Me.DepID1.FieldName = "DepID"
        Me.DepID1.Name = "DepID1"
        '
        'Labtitle
        '
        Me.Labtitle.AutoSize = True
        Me.Labtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Labtitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labtitle.ForeColor = System.Drawing.Color.Navy
        Me.Labtitle.Location = New System.Drawing.Point(4, 7)
        Me.Labtitle.Name = "Labtitle"
        Me.Labtitle.Size = New System.Drawing.Size(142, 21)
        Me.Labtitle.TabIndex = 270
        Me.Labtitle.Text = "組別計件管理"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(0, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(803, 36)
        Me.PicCaption.TabIndex = 269
        Me.PicCaption.TabStop = False
        '
        'ProductionSumPieceWorkGroupMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 457)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Labtitle)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "ProductionSumPieceWorkGroupMain"
        Me.Text = "組別計件管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSumWorkGroup.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GP_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NameS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Labtitle As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents popSumWorkGroup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popSumWorkGroupAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGrouplDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupCollectPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupCollectPrintList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GNOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
