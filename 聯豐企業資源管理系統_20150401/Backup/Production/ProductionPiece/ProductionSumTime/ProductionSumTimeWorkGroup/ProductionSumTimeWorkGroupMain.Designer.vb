<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionSumTimeWorkGroupMain
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
        Me.Labtitle = New System.Windows.Forms.Label
        Me.PicCaption = New System.Windows.Forms.PictureBox
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
        Me.PopSumWorkGroupPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumWorkGroupCollectPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.GNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GT_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GT_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_BeginTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_EndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.G_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSumWorkGroup.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labtitle
        '
        Me.Labtitle.AutoSize = True
        Me.Labtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Labtitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labtitle.ForeColor = System.Drawing.Color.Navy
        Me.Labtitle.Location = New System.Drawing.Point(6, 8)
        Me.Labtitle.Name = "Labtitle"
        Me.Labtitle.Size = New System.Drawing.Size(142, 21)
        Me.Labtitle.TabIndex = 266
        Me.Labtitle.Text = "組別計時統計"
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
        Me.PicCaption.TabIndex = 265
        Me.PicCaption.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popSumWorkGroup
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(-1, 39)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 418)
        Me.Grid1.TabIndex = 267
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popSumWorkGroup
        '
        Me.popSumWorkGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popSumWorkGroupAdd, Me.popSumWorkGroupEdit, Me.popSumWorkGrouplDel, Me.popSumWorkGroupView, Me.ToolStripSeparator1, Me.popSumWorkGroupRef, Me.ToolStripSeparator2, Me.popSumWorkGroupSeek, Me.ToolStripMenuItem1, Me.PopSumWorkGroupPrint, Me.popSumWorkGroupCollectPrint, Me.ToolStripMenuItem2, Me.ExpotExcelToolStripMenuItem, Me.ToolStripMenuItem3, Me.GNOToolStripMenuItem})
        Me.popSumWorkGroup.Name = "popAcceptance"
        Me.popSumWorkGroup.Size = New System.Drawing.Size(208, 254)
        '
        'popSumWorkGroupAdd
        '
        Me.popSumWorkGroupAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popSumWorkGroupAdd.Name = "popSumWorkGroupAdd"
        Me.popSumWorkGroupAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popSumWorkGroupAdd.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupAdd.Text = "增加(&A)..."
        '
        'popSumWorkGroupEdit
        '
        Me.popSumWorkGroupEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popSumWorkGroupEdit.Name = "popSumWorkGroupEdit"
        Me.popSumWorkGroupEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popSumWorkGroupEdit.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupEdit.Text = "修改(&E)..."
        '
        'popSumWorkGrouplDel
        '
        Me.popSumWorkGrouplDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popSumWorkGrouplDel.Name = "popSumWorkGrouplDel"
        Me.popSumWorkGrouplDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popSumWorkGrouplDel.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGrouplDel.Text = "刪除(&D)"
        '
        'popSumWorkGroupView
        '
        Me.popSumWorkGroupView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popSumWorkGroupView.Name = "popSumWorkGroupView"
        Me.popSumWorkGroupView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popSumWorkGroupView.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'popSumWorkGroupRef
        '
        Me.popSumWorkGroupRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popSumWorkGroupRef.Name = "popSumWorkGroupRef"
        Me.popSumWorkGroupRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popSumWorkGroupRef.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'popSumWorkGroupSeek
        '
        Me.popSumWorkGroupSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popSumWorkGroupSeek.Name = "popSumWorkGroupSeek"
        Me.popSumWorkGroupSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popSumWorkGroupSeek.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupSeek.Text = "查詢(&F)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(204, 6)
        '
        'PopSumWorkGroupPrint
        '
        Me.PopSumWorkGroupPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.PopSumWorkGroupPrint.Name = "PopSumWorkGroupPrint"
        Me.PopSumWorkGroupPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PopSumWorkGroupPrint.Size = New System.Drawing.Size(207, 22)
        Me.PopSumWorkGroupPrint.Text = "承包計件表(&P)"
        '
        'popSumWorkGroupCollectPrint
        '
        Me.popSumWorkGroupCollectPrint.Name = "popSumWorkGroupCollectPrint"
        Me.popSumWorkGroupCollectPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popSumWorkGroupCollectPrint.Size = New System.Drawing.Size(207, 22)
        Me.popSumWorkGroupCollectPrint.Text = "承包計件匯總表(&C)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(204, 6)
        '
        'ExpotExcelToolStripMenuItem
        '
        Me.ExpotExcelToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem.Name = "ExpotExcelToolStripMenuItem"
        Me.ExpotExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExpotExcelToolStripMenuItem.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(204, 6)
        '
        'GNOToolStripMenuItem
        '
        Me.GNOToolStripMenuItem.Name = "GNOToolStripMenuItem"
        Me.GNOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.GNOToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.GNOToolStripMenuItem.Text = "導入組別計時(&I)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GT_NO, Me.Per_NO, Me.Per_Name, Me.GT_G_Name, Me.DepID, Me.PT_FacName, Me.PT_BeginTime, Me.PT_EndTime, Me.PT_Total, Me.PT_Date, Me.PT_G_Name, Me.G_NO, Me.DepID1})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GT_NO
        '
        Me.GT_NO.Caption = "計時單號"
        Me.GT_NO.FieldName = "GT_NO"
        Me.GT_NO.Name = "GT_NO"
        Me.GT_NO.OptionsColumn.AllowEdit = False
        Me.GT_NO.OptionsColumn.AllowFocus = False
        Me.GT_NO.SummaryItem.DisplayFormat = "記錄數：{0}"
        Me.GT_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GT_NO.Visible = True
        Me.GT_NO.VisibleIndex = 0
        Me.GT_NO.Width = 100
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
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "姓名"
        Me.Per_Name.FieldName = "GT_Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.AllowEdit = False
        Me.Per_Name.OptionsColumn.AllowFocus = False
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 2
        Me.Per_Name.Width = 68
        '
        'GT_G_Name
        '
        Me.GT_G_Name.Caption = "組別"
        Me.GT_G_Name.FieldName = "GT_G_Name"
        Me.GT_G_Name.Name = "GT_G_Name"
        Me.GT_G_Name.OptionsColumn.AllowEdit = False
        Me.GT_G_Name.OptionsColumn.AllowFocus = False
        Me.GT_G_Name.Visible = True
        Me.GT_G_Name.VisibleIndex = 3
        Me.GT_G_Name.Width = 68
        '
        'DepID
        '
        Me.DepID.Caption = "部門"
        Me.DepID.FieldName = "GT_DepName"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.AllowEdit = False
        Me.DepID.OptionsColumn.AllowFocus = False
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 5
        Me.DepID.Width = 68
        '
        'PT_FacName
        '
        Me.PT_FacName.Caption = "廠別"
        Me.PT_FacName.FieldName = "GT_FacName"
        Me.PT_FacName.Name = "PT_FacName"
        Me.PT_FacName.OptionsColumn.AllowEdit = False
        Me.PT_FacName.OptionsColumn.AllowFocus = False
        Me.PT_FacName.Visible = True
        Me.PT_FacName.VisibleIndex = 6
        Me.PT_FacName.Width = 68
        '
        'PT_BeginTime
        '
        Me.PT_BeginTime.Caption = "開始時間"
        Me.PT_BeginTime.FieldName = "GT_BeginTime"
        Me.PT_BeginTime.Name = "PT_BeginTime"
        Me.PT_BeginTime.OptionsColumn.AllowEdit = False
        Me.PT_BeginTime.OptionsColumn.AllowFocus = False
        Me.PT_BeginTime.Visible = True
        Me.PT_BeginTime.VisibleIndex = 7
        '
        'PT_EndTime
        '
        Me.PT_EndTime.Caption = "結束時間"
        Me.PT_EndTime.FieldName = "GT_EndTime"
        Me.PT_EndTime.Name = "PT_EndTime"
        Me.PT_EndTime.OptionsColumn.AllowEdit = False
        Me.PT_EndTime.OptionsColumn.AllowFocus = False
        Me.PT_EndTime.Visible = True
        Me.PT_EndTime.VisibleIndex = 8
        '
        'PT_Total
        '
        Me.PT_Total.Caption = "合計時長"
        Me.PT_Total.FieldName = "GT_Total"
        Me.PT_Total.Name = "PT_Total"
        Me.PT_Total.OptionsColumn.AllowEdit = False
        Me.PT_Total.OptionsColumn.AllowFocus = False
        Me.PT_Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PT_Total.Visible = True
        Me.PT_Total.VisibleIndex = 9
        '
        'PT_Date
        '
        Me.PT_Date.Caption = "記錄日期"
        Me.PT_Date.FieldName = "GT_Date"
        Me.PT_Date.Name = "PT_Date"
        Me.PT_Date.OptionsColumn.AllowEdit = False
        Me.PT_Date.OptionsColumn.AllowFocus = False
        Me.PT_Date.Visible = True
        Me.PT_Date.VisibleIndex = 10
        '
        'PT_G_Name
        '
        Me.PT_G_Name.Caption = "操作員"
        Me.PT_G_Name.FieldName = "GT_ActionName"
        Me.PT_G_Name.Name = "PT_G_Name"
        Me.PT_G_Name.OptionsColumn.AllowEdit = False
        Me.PT_G_Name.OptionsColumn.AllowFocus = False
        Me.PT_G_Name.Visible = True
        Me.PT_G_Name.VisibleIndex = 11
        Me.PT_G_Name.Width = 65
        '
        'G_NO
        '
        Me.G_NO.Caption = "組別編號"
        Me.G_NO.FieldName = "G_NO"
        Me.G_NO.Name = "G_NO"
        Me.G_NO.OptionsColumn.AllowEdit = False
        Me.G_NO.OptionsColumn.AllowFocus = False
        Me.G_NO.Visible = True
        Me.G_NO.VisibleIndex = 4
        '
        'DepID1
        '
        Me.DepID1.Caption = "部門"
        Me.DepID1.FieldName = "DepID"
        Me.DepID1.Name = "DepID1"
        '
        'ProductionSumTimeWorkGroupMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 459)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Labtitle)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "ProductionSumTimeWorkGroupMain"
        Me.Text = "組別計時統計"
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSumWorkGroup.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labtitle As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_BeginTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_EndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popSumWorkGroup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popSumWorkGroupAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGrouplDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumWorkGroupSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GT_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopSumWorkGroupPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumWorkGroupCollectPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents G_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GNOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
