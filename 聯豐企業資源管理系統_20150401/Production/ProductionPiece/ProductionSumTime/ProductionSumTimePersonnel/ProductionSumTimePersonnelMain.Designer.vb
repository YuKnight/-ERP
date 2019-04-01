<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionSumTimePersonnelMain
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
        Me.PopSumPersonnelPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelCollectPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExpotExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.PerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PT_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_BeginTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_EndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PT_G_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepID1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSumPersonnel.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labtitle
        '
        Me.Labtitle.AutoSize = True
        Me.Labtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Labtitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labtitle.ForeColor = System.Drawing.Color.Navy
        Me.Labtitle.Location = New System.Drawing.Point(7, 7)
        Me.Labtitle.Name = "Labtitle"
        Me.Labtitle.Size = New System.Drawing.Size(142, 21)
        Me.Labtitle.TabIndex = 264
        Me.Labtitle.Text = "員工計時統計"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(1, 0)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(803, 36)
        Me.PicCaption.TabIndex = 263
        Me.PicCaption.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.popSumPersonnel
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 38)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(804, 418)
        Me.Grid1.TabIndex = 265
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popSumPersonnel
        '
        Me.popSumPersonnel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popSumPersonnelAdd, Me.popSumPersonnelEdit, Me.popSumPersonnelDel, Me.popSumPersonnelView, Me.ToolStripSeparator1, Me.popSumPersonnelRef, Me.ToolStripSeparator2, Me.popSumPersonnelSeek, Me.ToolStripMenuItem1, Me.PopSumPersonnelPrint, Me.popSumPersonnelCollectPrint, Me.ToolStripMenuItem2, Me.ExpotExcelToolStripMenuItem, Me.ToolStripMenuItem3, Me.PerToolStripMenuItem, Me.ToolStripMenuItem4, Me.SettingToolStripMenuItem})
        Me.popSumPersonnel.Name = "popAcceptance"
        Me.popSumPersonnel.Size = New System.Drawing.Size(188, 282)
        Me.popSumPersonnel.Text = "員工計件匯總(&C)"
        '
        'popSumPersonnelAdd
        '
        Me.popSumPersonnelAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popSumPersonnelAdd.Name = "popSumPersonnelAdd"
        Me.popSumPersonnelAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popSumPersonnelAdd.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelAdd.Text = "增加(&A)..."
        '
        'popSumPersonnelEdit
        '
        Me.popSumPersonnelEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popSumPersonnelEdit.Name = "popSumPersonnelEdit"
        Me.popSumPersonnelEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popSumPersonnelEdit.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelEdit.Text = "修改(&E)..."
        '
        'popSumPersonnelDel
        '
        Me.popSumPersonnelDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popSumPersonnelDel.Name = "popSumPersonnelDel"
        Me.popSumPersonnelDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popSumPersonnelDel.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelDel.Text = "刪除(&D)"
        '
        'popSumPersonnelView
        '
        Me.popSumPersonnelView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popSumPersonnelView.Name = "popSumPersonnelView"
        Me.popSumPersonnelView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popSumPersonnelView.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelView.Text = "查看(&W)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'popSumPersonnelRef
        '
        Me.popSumPersonnelRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.popSumPersonnelRef.Name = "popSumPersonnelRef"
        Me.popSumPersonnelRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.popSumPersonnelRef.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelRef.Text = "刷新(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(184, 6)
        '
        'popSumPersonnelSeek
        '
        Me.popSumPersonnelSeek.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popSumPersonnelSeek.Name = "popSumPersonnelSeek"
        Me.popSumPersonnelSeek.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popSumPersonnelSeek.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelSeek.Text = "查詢(&F)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 6)
        '
        'PopSumPersonnelPrint
        '
        Me.PopSumPersonnelPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.PopSumPersonnelPrint.Name = "PopSumPersonnelPrint"
        Me.PopSumPersonnelPrint.Size = New System.Drawing.Size(187, 22)
        Me.PopSumPersonnelPrint.Text = "員工計件表(&P)"
        '
        'popSumPersonnelCollectPrint
        '
        Me.popSumPersonnelCollectPrint.Name = "popSumPersonnelCollectPrint"
        Me.popSumPersonnelCollectPrint.Size = New System.Drawing.Size(187, 22)
        Me.popSumPersonnelCollectPrint.Text = "員工計件匯總(&C)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 6)
        '
        'ExpotExcelToolStripMenuItem
        '
        Me.ExpotExcelToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.SmartArtLayoutGallery
        Me.ExpotExcelToolStripMenuItem.Name = "ExpotExcelToolStripMenuItem"
        Me.ExpotExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ExpotExcelToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ExpotExcelToolStripMenuItem.Text = "導出Excel(&U)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 6)
        '
        'PerToolStripMenuItem
        '
        Me.PerToolStripMenuItem.Name = "PerToolStripMenuItem"
        Me.PerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.PerToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PerToolStripMenuItem.Text = "導入個人計時(&I)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(184, 6)
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SettingToolStripMenuItem.Text = "計時時長設置(&F)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PT_NO, Me.Per_NO, Me.Per_Name, Me.DepID, Me.PT_FacName, Me.PT_BeginTime, Me.PT_EndTime, Me.PT_Total, Me.PT_Date, Me.PT_G_Name, Me.DepID1})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PT_NO
        '
        Me.PT_NO.Caption = "計時單號"
        Me.PT_NO.FieldName = "PT_NO"
        Me.PT_NO.Name = "PT_NO"
        Me.PT_NO.OptionsColumn.AllowEdit = False
        Me.PT_NO.OptionsColumn.AllowFocus = False
        Me.PT_NO.SummaryItem.DisplayFormat = "記錄數：{0}"
        Me.PT_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.PT_NO.Visible = True
        Me.PT_NO.VisibleIndex = 0
        Me.PT_NO.Width = 100
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
        Me.Per_Name.FieldName = "PT_Per_Name"
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.AllowEdit = False
        Me.Per_Name.OptionsColumn.AllowFocus = False
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 2
        '
        'DepID
        '
        Me.DepID.Caption = "部門"
        Me.DepID.FieldName = "PT_DepName"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.AllowEdit = False
        Me.DepID.OptionsColumn.AllowFocus = False
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 3
        '
        'PT_FacName
        '
        Me.PT_FacName.Caption = "廠別"
        Me.PT_FacName.FieldName = "PT_FacName"
        Me.PT_FacName.Name = "PT_FacName"
        Me.PT_FacName.OptionsColumn.AllowEdit = False
        Me.PT_FacName.OptionsColumn.AllowFocus = False
        Me.PT_FacName.Visible = True
        Me.PT_FacName.VisibleIndex = 4
        '
        'PT_BeginTime
        '
        Me.PT_BeginTime.Caption = "開始時間"
        Me.PT_BeginTime.FieldName = "PT_BeginTime"
        Me.PT_BeginTime.Name = "PT_BeginTime"
        Me.PT_BeginTime.OptionsColumn.AllowEdit = False
        Me.PT_BeginTime.OptionsColumn.AllowFocus = False
        Me.PT_BeginTime.Visible = True
        Me.PT_BeginTime.VisibleIndex = 5
        '
        'PT_EndTime
        '
        Me.PT_EndTime.Caption = "結束時間"
        Me.PT_EndTime.FieldName = "PT_EndTime"
        Me.PT_EndTime.Name = "PT_EndTime"
        Me.PT_EndTime.OptionsColumn.AllowEdit = False
        Me.PT_EndTime.OptionsColumn.AllowFocus = False
        Me.PT_EndTime.Visible = True
        Me.PT_EndTime.VisibleIndex = 6
        '
        'PT_Total
        '
        Me.PT_Total.Caption = "合計時長"
        Me.PT_Total.FieldName = "PT_Total"
        Me.PT_Total.Name = "PT_Total"
        Me.PT_Total.OptionsColumn.AllowEdit = False
        Me.PT_Total.OptionsColumn.AllowFocus = False
        Me.PT_Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PT_Total.Visible = True
        Me.PT_Total.VisibleIndex = 7
        '
        'PT_Date
        '
        Me.PT_Date.Caption = "記錄日期"
        Me.PT_Date.FieldName = "PT_Date"
        Me.PT_Date.Name = "PT_Date"
        Me.PT_Date.OptionsColumn.AllowEdit = False
        Me.PT_Date.OptionsColumn.AllowFocus = False
        Me.PT_Date.Visible = True
        Me.PT_Date.VisibleIndex = 8
        '
        'PT_G_Name
        '
        Me.PT_G_Name.Caption = "操作員"
        Me.PT_G_Name.FieldName = "PT_ActionName"
        Me.PT_G_Name.Name = "PT_G_Name"
        Me.PT_G_Name.OptionsColumn.AllowEdit = False
        Me.PT_G_Name.OptionsColumn.AllowFocus = False
        Me.PT_G_Name.Visible = True
        Me.PT_G_Name.VisibleIndex = 9
        '
        'DepID1
        '
        Me.DepID1.Caption = "部門"
        Me.DepID1.FieldName = "DepID"
        Me.DepID1.Name = "DepID1"
        '
        'ProductionSumTimePersonnelMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 456)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Labtitle)
        Me.Controls.Add(Me.PicCaption)
        Me.Name = "ProductionSumTimePersonnelMain"
        Me.Text = "員工個人計時統計"
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSumPersonnel.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labtitle As System.Windows.Forms.Label
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_BeginTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_EndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT_G_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popSumPersonnel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popSumPersonnelAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumPersonnelRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popSumPersonnelSeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopSumPersonnelPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelCollectPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpotExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
