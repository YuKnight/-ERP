<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionSumPiecePersonnelMain
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
        Me.popSumPersonnel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popSumPersonnelAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelDel = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumPersonnelRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumPersonnelSeek = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.popSumPersonnelPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelCollectPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.PopSumPersonnelCollectPrintList = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.PerNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Class = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.popSumPersonnel.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popSumPersonnel
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(-2, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 418)
        Me.Grid1.TabIndex = 268
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popSumPersonnel
        '
        Me.popSumPersonnel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popSumPersonnelAdd, Me.popSumPersonnelEdit, Me.popSumPersonnelDel, Me.popSumPersonnelView, Me.ToolStripSeparator1, Me.popSumPersonnelRef, Me.ToolStripSeparator2, Me.popSumPersonnelSeek, Me.ToolStripMenuItem1, Me.popSumPersonnelPrint, Me.popSumPersonnelCollectPrint, Me.ToolStripMenuItem2, Me.PopSumPersonnelCollectPrintList, Me.ToolStripMenuItem3, Me.ExpotExcelToolStripMenuItem, Me.ToolStripMenuItem4, Me.PerNOToolStripMenuItem})
        Me.popSumPersonnel.Name = "popAcceptance"
        Me.popSumPersonnel.Size = New System.Drawing.Size(218, 282)
        '
        'popSumPersonnelAdd
        '
        Me.popSumPersonnelAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popSumPersonnelAdd.Name = "popSumPersonnelAdd"
        Me.popSumPersonnelAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popSumPersonnelAdd.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelAdd.Text = "增加(&A)..."
        '
        'popSumPersonnelEdit
        '
        Me.popSumPersonnelEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popSumPersonnelEdit.Name = "popSumPersonnelEdit"
        Me.popSumPersonnelEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popSumPersonnelEdit.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelEdit.Text = "修改(&E)..."
        '
        'popSumPersonnelDel
        '
        Me.popSumPersonnelDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popSumPersonnelDel.Name = "popSumPersonnelDel"
        Me.popSumPersonnelDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popSumPersonnelDel.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelDel.Text = "刪除(&D)"
        '
        'popSumPersonnelView
        '
        Me.popSumPersonnelView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popSumPersonnelView.Name = "popSumPersonnelView"
        Me.popSumPersonnelView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popSumPersonnelView.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'popSumPersonnelRef
        '
        Me.popSumPersonnelRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popSumPersonnelRef.Name = "popSumPersonnelRef"
        Me.popSumPersonnelRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popSumPersonnelRef.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(214, 6)
        '
        'popSumPersonnelSeek
        '
        Me.popSumPersonnelSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popSumPersonnelSeek.Name = "popSumPersonnelSeek"
        Me.popSumPersonnelSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popSumPersonnelSeek.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelSeek.Text = "查詢(&F)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(214, 6)
        '
        'popSumPersonnelPrint
        '
        Me.popSumPersonnelPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popSumPersonnelPrint.Name = "popSumPersonnelPrint"
        Me.popSumPersonnelPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popSumPersonnelPrint.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelPrint.Text = "員工計件表(&P)"
        '
        'popSumPersonnelCollectPrint
        '
        Me.popSumPersonnelCollectPrint.Name = "popSumPersonnelCollectPrint"
        Me.popSumPersonnelCollectPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popSumPersonnelCollectPrint.Size = New System.Drawing.Size(217, 22)
        Me.popSumPersonnelCollectPrint.Text = "員工計件匯總(&C)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(214, 6)
        '
        'PopSumPersonnelCollectPrintList
        '
        Me.PopSumPersonnelCollectPrintList.Name = "PopSumPersonnelCollectPrintList"
        Me.PopSumPersonnelCollectPrintList.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.PopSumPersonnelCollectPrintList.Size = New System.Drawing.Size(217, 22)
        Me.PopSumPersonnelCollectPrintList.Text = "員工計件匯總清單(&L)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(214, 6)
        '
        'ExpotExcelToolStripMenuItem
        '
        Me.ExpotExcelToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem.Name = "ExpotExcelToolStripMenuItem"
        Me.ExpotExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ExpotExcelToolStripMenuItem.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(214, 6)
        '
        'PerNOToolStripMenuItem
        '
        Me.PerNOToolStripMenuItem.Name = "PerNOToolStripMenuItem"
        Me.PerNOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.PerNOToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PerNOToolStripMenuItem.Text = "導入個人計(&I)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PP_NO, Me.Per_NO, Me.Per_Name, Me.Per_Class, Me.DepID, Me.PT_FacName, Me.PM_M_Code, Me.PM_Type, Me.PS_Name, Me.PS_NameS, Me.PP_Qty, Me.PP_Date, Me.PP_G_Name, Me.DepID1})
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
        Me.PP_NO.FieldName = "PP_NO"
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
        Me.Per_NO.Caption = "廠証編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.OptionsColumn.AllowEdit = False
        Me.Per_NO.OptionsColumn.AllowFocus = False
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 1
        Me.Per_NO.Width = 69
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "PP_Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.AllowEdit = False
        Me.Per_Name.OptionsColumn.AllowFocus = False
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 2
        Me.Per_Name.Width = 69
        '
        'Per_Class
        '
        Me.Per_Class.Caption = "班制"
        Me.Per_Class.FieldName = "Per_Class"
        Me.Per_Class.Name = "Per_Class"
        Me.Per_Class.OptionsColumn.AllowEdit = False
        Me.Per_Class.OptionsColumn.AllowFocus = False
        Me.Per_Class.Visible = True
        Me.Per_Class.VisibleIndex = 3
        '
        'DepID
        '
        Me.DepID.Caption = "部門"
        Me.DepID.FieldName = "PP_DepName"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.AllowEdit = False
        Me.DepID.OptionsColumn.AllowFocus = False
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 4
        Me.DepID.Width = 69
        '
        'PT_FacName
        '
        Me.PT_FacName.Caption = "廠別"
        Me.PT_FacName.FieldName = "PP_FacName"
        Me.PT_FacName.Name = "PT_FacName"
        Me.PT_FacName.OptionsColumn.AllowEdit = False
        Me.PT_FacName.OptionsColumn.AllowFocus = False
        Me.PT_FacName.Visible = True
        Me.PT_FacName.VisibleIndex = 5
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.AllowEdit = False
        Me.PM_M_Code.OptionsColumn.AllowFocus = False
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 6
        Me.PM_M_Code.Width = 100
        '
        'PM_Type
        '
        Me.PM_Type.Caption = "配件名稱"
        Me.PM_Type.FieldName = "PM_Type"
        Me.PM_Type.Name = "PM_Type"
        Me.PM_Type.OptionsColumn.AllowEdit = False
        Me.PM_Type.OptionsColumn.AllowFocus = False
        Me.PM_Type.Visible = True
        Me.PM_Type.VisibleIndex = 7
        Me.PM_Type.Width = 80
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "大工序名稱"
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.AllowEdit = False
        Me.PS_Name.OptionsColumn.AllowFocus = False
        Me.PS_Name.Visible = True
        Me.PS_Name.VisibleIndex = 8
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
        Me.PS_NameS.VisibleIndex = 9
        Me.PS_NameS.Width = 80
        '
        'PP_Qty
        '
        Me.PP_Qty.Caption = "數量"
        Me.PP_Qty.FieldName = "PP_Qty"
        Me.PP_Qty.Name = "PP_Qty"
        Me.PP_Qty.OptionsColumn.AllowEdit = False
        Me.PP_Qty.OptionsColumn.AllowFocus = False
        Me.PP_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PP_Qty.Visible = True
        Me.PP_Qty.VisibleIndex = 10
        Me.PP_Qty.Width = 69
        '
        'PP_Date
        '
        Me.PP_Date.Caption = "計件日期"
        Me.PP_Date.FieldName = "PP_Date"
        Me.PP_Date.Name = "PP_Date"
        Me.PP_Date.OptionsColumn.AllowEdit = False
        Me.PP_Date.OptionsColumn.AllowFocus = False
        Me.PP_Date.Visible = True
        Me.PP_Date.VisibleIndex = 11
        Me.PP_Date.Width = 69
        '
        'PP_G_Name
        '
        Me.PP_G_Name.Caption = "操作員"
        Me.PP_G_Name.FieldName = "PP_ActionName"
        Me.PP_G_Name.Name = "PP_G_Name"
        Me.PP_G_Name.OptionsColumn.AllowEdit = False
        Me.PP_G_Name.OptionsColumn.AllowFocus = False
        Me.PP_G_Name.Visible = True
        Me.PP_G_Name.VisibleIndex = 12
        Me.PP_G_Name.Width = 72
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
        Me.Labtitle.Location = New System.Drawing.Point(5, 7)
        Me.Labtitle.Name = "Labtitle"
        Me.Labtitle.Size = New System.Drawing.Size(142, 21)
        Me.Labtitle.TabIndex = 267
        Me.Labtitle.Text = "個人計件管理"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(1, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(803, 36)
        Me.PicCaption.TabIndex = 266
        Me.PicCaption.TabStop = False
        '
        'ProductionSumPiecePersonnelMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 455)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Labtitle)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "ProductionSumPiecePersonnelMain"
        Me.Text = "個人計件管理"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSumPersonnel.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Labtitle As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents popSumPersonnel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popSumPersonnelAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumPersonnelRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumPersonnelSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PS_NameS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PP_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumPersonnelPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelCollectPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Per_Class As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopSumPersonnelCollectPrintList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PerNOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
