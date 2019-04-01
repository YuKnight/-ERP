<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionLoadPiecePersonnel
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
        Me.LabelPer_no = New DevExpress.XtraEditors.LabelControl
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.TextEditPerNO = New DevExpress.XtraEditors.TextEdit
        Me.SBgb = New DevExpress.XtraEditors.SimpleButton
        Me.lueDepID = New DevExpress.XtraEditors.LookUpEdit
        Me.lueFacID = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelDEP = New DevExpress.XtraEditors.LabelControl
        Me.LabelFac = New DevExpress.XtraEditors.LabelControl
        CType(Me.TextEditPerNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPer_no
        '
        Me.LabelPer_no.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPer_no.Appearance.Options.UseFont = True
        Me.LabelPer_no.Location = New System.Drawing.Point(4, 12)
        Me.LabelPer_no.Name = "LabelPer_no"
        Me.LabelPer_no.Size = New System.Drawing.Size(29, 13)
        Me.LabelPer_no.TabIndex = 0
        Me.LabelPer_no.Text = "工號:"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdSave.Location = New System.Drawing.Point(71, 113)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 24)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(154, 113)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 24)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "取消(&C)"
        '
        'TextEditPerNO
        '
        Me.TextEditPerNO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEditPerNO.Location = New System.Drawing.Point(38, 8)
        Me.TextEditPerNO.Name = "TextEditPerNO"
        Me.TextEditPerNO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditPerNO.Properties.Appearance.Options.UseFont = True
        Me.TextEditPerNO.Size = New System.Drawing.Size(187, 22)
        Me.TextEditPerNO.TabIndex = 1
        '
        'SBgb
        '
        Me.SBgb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SBgb.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SBgb.Appearance.Options.UseFont = True
        Me.SBgb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SBgb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SBgb.Enabled = False
        Me.SBgb.Location = New System.Drawing.Point(1, 0)
        Me.SBgb.Name = "SBgb"
        Me.SBgb.Size = New System.Drawing.Size(227, 150)
        Me.SBgb.TabIndex = 4
        Me.SBgb.TabStop = False
        '
        'lueDepID
        '
        Me.lueDepID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueDepID.Location = New System.Drawing.Point(38, 73)
        Me.lueDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueDepID.Name = "lueDepID"
        Me.lueDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lueDepID.Properties.Appearance.Options.UseFont = True
        Me.lueDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepID", "部門編號", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "部門名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueDepID.Properties.NullText = ""
        Me.lueDepID.Size = New System.Drawing.Size(187, 22)
        Me.lueDepID.TabIndex = 5
        '
        'lueFacID
        '
        Me.lueFacID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueFacID.Location = New System.Drawing.Point(38, 39)
        Me.lueFacID.Margin = New System.Windows.Forms.Padding(6)
        Me.lueFacID.Name = "lueFacID"
        Me.lueFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lueFacID.Properties.Appearance.Options.UseFont = True
        Me.lueFacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFacID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacName", "廠別名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueFacID.Properties.NullText = ""
        Me.lueFacID.Size = New System.Drawing.Size(187, 22)
        Me.lueFacID.TabIndex = 3
        '
        'LabelDEP
        '
        Me.LabelDEP.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelDEP.Appearance.Options.UseFont = True
        Me.LabelDEP.Location = New System.Drawing.Point(4, 79)
        Me.LabelDEP.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelDEP.Name = "LabelDEP"
        Me.LabelDEP.Size = New System.Drawing.Size(29, 13)
        Me.LabelDEP.TabIndex = 4
        Me.LabelDEP.Text = "部門:"
        '
        'LabelFac
        '
        Me.LabelFac.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelFac.Appearance.Options.UseFont = True
        Me.LabelFac.Location = New System.Drawing.Point(4, 44)
        Me.LabelFac.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.LabelFac.Name = "LabelFac"
        Me.LabelFac.Size = New System.Drawing.Size(29, 13)
        Me.LabelFac.TabIndex = 2
        Me.LabelFac.Text = "廠別:"
        '
        'frmProductionLoadPiecePersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(229, 153)
        Me.Controls.Add(Me.lueDepID)
        Me.Controls.Add(Me.lueFacID)
        Me.Controls.Add(Me.LabelDEP)
        Me.Controls.Add(Me.LabelFac)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.TextEditPerNO)
        Me.Controls.Add(Me.LabelPer_no)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.SBgb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionLoadPiecePersonnel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "載入員工編號"
        CType(Me.TextEditPerNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPer_no As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEditPerNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SBgb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueDepID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFacID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelDEP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelFac As DevExpress.XtraEditors.LabelControl
End Class
