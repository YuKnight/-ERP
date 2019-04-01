<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpMpsBatchAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMrpMpsBatchAdd))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.clcPlanQty = New DevExpress.XtraEditors.CalcEdit
        Me.clcBatchAddQty = New DevExpress.XtraEditors.CalcEdit
        Me.dteBeginDate = New DevExpress.XtraEditors.DateEdit
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.clcPlanQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clcBatchAddQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteBeginDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "起始日期："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(14, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "計劃數量："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "添加行數："
        '
        'clcPlanQty
        '
        Me.clcPlanQty.Location = New System.Drawing.Point(87, 44)
        Me.clcPlanQty.Name = "clcPlanQty"
        Me.clcPlanQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.clcPlanQty.Properties.Appearance.Options.UseFont = True
        Me.clcPlanQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.clcPlanQty.Size = New System.Drawing.Size(150, 24)
        Me.clcPlanQty.TabIndex = 3
        '
        'clcBatchAddQty
        '
        Me.clcBatchAddQty.Location = New System.Drawing.Point(87, 72)
        Me.clcBatchAddQty.Name = "clcBatchAddQty"
        Me.clcBatchAddQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.clcBatchAddQty.Properties.Appearance.Options.UseFont = True
        Me.clcBatchAddQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.clcBatchAddQty.Properties.Mask.EditMask = "[1-9]\d{0,2}"
        Me.clcBatchAddQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.clcBatchAddQty.Size = New System.Drawing.Size(150, 24)
        Me.clcBatchAddQty.TabIndex = 5
        '
        'dteBeginDate
        '
        Me.dteBeginDate.EditValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteBeginDate.Location = New System.Drawing.Point(87, 16)
        Me.dteBeginDate.Name = "dteBeginDate"
        Me.dteBeginDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteBeginDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.dteBeginDate.Properties.Appearance.Options.UseFont = True
        Me.dteBeginDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteBeginDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.dteBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteBeginDate.Properties.EditFormat.FormatString = "yyyy/MM/dd"
        Me.dteBeginDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteBeginDate.Properties.MaxValue = New Date(5000, 1, 1, 0, 0, 0, 0)
        Me.dteBeginDate.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteBeginDate.Size = New System.Drawing.Size(150, 24)
        Me.dteBeginDate.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(145, 114)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(59, 114)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 28)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "確定(&O)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dteBeginDate)
        Me.GroupBox1.Controls.Add(Me.clcPlanQty)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.clcBatchAddQty)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 106)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'frmMrpMpsBatchAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 146)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMrpMpsBatchAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "批量添加"
        CType(Me.clcPlanQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clcBatchAddQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteBeginDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents clcPlanQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents clcBatchAddQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents dteBeginDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
