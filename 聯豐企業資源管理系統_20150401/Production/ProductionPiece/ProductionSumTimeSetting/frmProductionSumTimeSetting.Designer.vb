<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionSumTimeSetting
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
        Me.LabModifyDate = New System.Windows.Forms.Label
        Me.LabActionName = New System.Windows.Forms.Label
        Me.LabPer_NO = New System.Windows.Forms.Label
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.Labtitle = New System.Windows.Forms.Label
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.PicCaption = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.popSumPersonnel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popSumPersonnelAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popSumPersonnelDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StartTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSumPersonnel.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabModifyDate
        '
        Me.LabModifyDate.AutoSize = True
        Me.LabModifyDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabModifyDate.Location = New System.Drawing.Point(229, 380)
        Me.LabModifyDate.Name = "LabModifyDate"
        Me.LabModifyDate.Size = New System.Drawing.Size(28, 15)
        Me.LabModifyDate.TabIndex = 282
        Me.LabModifyDate.Text = "***"
        '
        'LabActionName
        '
        Me.LabActionName.AutoSize = True
        Me.LabActionName.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabActionName.Location = New System.Drawing.Point(66, 380)
        Me.LabActionName.Name = "LabActionName"
        Me.LabActionName.Size = New System.Drawing.Size(28, 15)
        Me.LabActionName.TabIndex = 280
        Me.LabActionName.Text = "***"
        '
        'LabPer_NO
        '
        Me.LabPer_NO.AutoSize = True
        Me.LabPer_NO.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPer_NO.Location = New System.Drawing.Point(5, 380)
        Me.LabPer_NO.Name = "LabPer_NO"
        Me.LabPer_NO.Size = New System.Drawing.Size(56, 15)
        Me.LabPer_NO.TabIndex = 279
        Me.LabPer_NO.Text = "操作員:"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(454, 371)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 278
        Me.cmdExit.Text = "退出(&C)"
        '
        'Labtitle
        '
        Me.Labtitle.AutoSize = True
        Me.Labtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Labtitle.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labtitle.ForeColor = System.Drawing.Color.Navy
        Me.Labtitle.Location = New System.Drawing.Point(10, 9)
        Me.Labtitle.Name = "Labtitle"
        Me.Labtitle.Size = New System.Drawing.Size(142, 21)
        Me.Labtitle.TabIndex = 276
        Me.Labtitle.Text = "計時時長設置"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(357, 371)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 28)
        Me.cmdSave.TabIndex = 277
        Me.cmdSave.Text = "保存(&S)"
        '
        'PicCaption
        '
        Me.PicCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PicCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCaption.Location = New System.Drawing.Point(3, 1)
        Me.PicCaption.Name = "PicCaption"
        Me.PicCaption.Size = New System.Drawing.Size(534, 36)
        Me.PicCaption.TabIndex = 275
        Me.PicCaption.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popSumPersonnel
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 40)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.Grid1.Size = New System.Drawing.Size(536, 320)
        Me.Grid1.TabIndex = 274
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popSumPersonnel
        '
        Me.popSumPersonnel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popSumPersonnelAdd, Me.popSumPersonnelDel})
        Me.popSumPersonnel.Name = "popAcceptance"
        Me.popSumPersonnel.Size = New System.Drawing.Size(157, 48)
        Me.popSumPersonnel.Text = "員工計件匯總(&C)"
        '
        'popSumPersonnelAdd
        '
        Me.popSumPersonnelAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popSumPersonnelAdd.Name = "popSumPersonnelAdd"
        Me.popSumPersonnelAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popSumPersonnelAdd.Size = New System.Drawing.Size(156, 22)
        Me.popSumPersonnelAdd.Text = "增加(&A)..."
        '
        'popSumPersonnelDel
        '
        Me.popSumPersonnelDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popSumPersonnelDel.Name = "popSumPersonnelDel"
        Me.popSumPersonnelDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popSumPersonnelDel.Size = New System.Drawing.Size(156, 22)
        Me.popSumPersonnelDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.StartTime, Me.EndTime, Me.TotalTime})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自動編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        '
        'StartTime
        '
        Me.StartTime.Caption = "開始時間"
        Me.StartTime.FieldName = "StartTime"
        Me.StartTime.Name = "StartTime"
        Me.StartTime.Visible = True
        Me.StartTime.VisibleIndex = 0
        '
        'EndTime
        '
        Me.EndTime.Caption = "結束時間"
        Me.EndTime.FieldName = "EndTime"
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Visible = True
        Me.EndTime.VisibleIndex = 1
        '
        'TotalTime
        '
        Me.TotalTime.Caption = "合計時長"
        Me.TotalTime.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.TotalTime.FieldName = "TotalTime"
        Me.TotalTime.Name = "TotalTime"
        Me.TotalTime.Visible = True
        Me.TotalTime.VisibleIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 281
        Me.Label2.Text = "操作時間:"
        '
        'frmProductionSumTimeSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(540, 406)
        Me.Controls.Add(Me.LabModifyDate)
        Me.Controls.Add(Me.LabActionName)
        Me.Controls.Add(Me.LabPer_NO)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Labtitle)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.PicCaption)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionSumTimeSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "計時時長設置"
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSumPersonnel.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabModifyDate As System.Windows.Forms.Label
    Friend WithEvents LabActionName As System.Windows.Forms.Label
    Friend WithEvents LabPer_NO As System.Windows.Forms.Label
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Labtitle As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PicCaption As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents popSumPersonnel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popSumPersonnelAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popSumPersonnelDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
