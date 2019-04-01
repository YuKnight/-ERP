<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPreview
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序

    '可以使用 Windows Form 設計工具進行修改。

    '請不要使用程式碼編輯器進行修改。

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        'Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        'Me.rptDoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.SuspendLayout()
        '
        'crView
        '
        'Me.crView.ActiveViewIndex = -1
        'Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.crView.DisplayGroupTree = False
        'Me.crView.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.crView.Location = New System.Drawing.Point(0, 0)
        'Me.crView.Name = "crView"
        'Me.crView.SelectionFormula = ""
        'Me.crView.ShowGroupTreeButton = False
        'Me.crView.Size = New System.Drawing.Size(383, 305)
        'Me.crView.TabIndex = 0
        'Me.crView.ViewTimeSelectionFormula = ""
        '
        'frmRptPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 305)
        'Me.Controls.Add(Me.crView)
        Me.Name = "frmRptPreview"
        Me.Text = "顯示報表"
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
