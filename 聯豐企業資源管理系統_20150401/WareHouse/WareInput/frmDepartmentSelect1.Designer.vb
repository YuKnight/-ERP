<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartmentSelect1
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
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.DPT_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.DPT_ID = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.DPT_PID = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.DPT_Name, Me.DPT_ID, Me.DPT_PID})
        Me.TreeList1.KeyFieldName = "DPT_ID"
        Me.TreeList1.Location = New System.Drawing.Point(1, -1)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "DPT_PID"
        Me.TreeList1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeList1.Size = New System.Drawing.Size(207, 193)
        Me.TreeList1.TabIndex = 1
        '
        'DPT_Name
        '
        Me.DPT_Name.Caption = "部門名稱"
        Me.DPT_Name.FieldName = "DPT_Name"
        Me.DPT_Name.Name = "DPT_Name"
        Me.DPT_Name.OptionsColumn.AllowEdit = False
        Me.DPT_Name.OptionsColumn.AllowFocus = False
        Me.DPT_Name.OptionsColumn.AllowSort = False
        Me.DPT_Name.OptionsColumn.ReadOnly = True
        Me.DPT_Name.VisibleIndex = 0
        '
        'DPT_ID
        '
        Me.DPT_ID.Caption = "DPT_ID"
        Me.DPT_ID.FieldName = "DPT_ID"
        Me.DPT_ID.Name = "DPT_ID"
        '
        'DPT_PID
        '
        Me.DPT_PID.Caption = "DPT_PID"
        Me.DPT_PID.FieldName = "DPT_PID"
        Me.DPT_PID.Name = "DPT_PID"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(104, 195)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 24)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(12, 195)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "確定(&O)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'frmDepartmentSelect1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(207, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.TreeList1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDepartmentSelect1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "部門選擇"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents DPT_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents DPT_ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents DPT_PID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
