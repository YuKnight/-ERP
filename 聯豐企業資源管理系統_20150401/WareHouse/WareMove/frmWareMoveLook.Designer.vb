<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareMoveLook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWareMoveLook))
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPM_NO = New DevExpress.XtraEditors.TextEdit
        Me.DG = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PN_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPT_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Depict = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(278, 48)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(80, 25)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "確認(&O)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 36)
        Me.PictureBox1.TabIndex = 173
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "採購單-查看"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "採購單號(&I)："
        '
        'txtPM_NO
        '
        Me.txtPM_NO.Location = New System.Drawing.Point(92, 50)
        Me.txtPM_NO.Name = "txtPM_NO"
        Me.txtPM_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPM_NO.Properties.Appearance.Options.UseFont = True
        Me.txtPM_NO.Size = New System.Drawing.Size(180, 22)
        Me.txtPM_NO.TabIndex = 1
        '
        'DG
        '
        Me.DG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG.EmbeddedNavigator.Name = ""
        Me.DG.Location = New System.Drawing.Point(1, 79)
        Me.DG.MainView = Me.GridView1
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(728, 396)
        Me.DG.TabIndex = 3
        Me.DG.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_NO, Me.M_Code, Me.PN_NO, Me.M_Name, Me.M_Gauge, Me.PS_Qty, Me.DPT_ID, Me.U_ID, Me.PS_Depict})
        Me.GridView1.GridControl = Me.DG
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PM_NO
        '
        Me.PM_NO.Caption = "採購單號"
        Me.PM_NO.FieldName = "PM_NO"
        Me.PM_NO.Name = "PM_NO"
        Me.PM_NO.Visible = True
        Me.PM_NO.VisibleIndex = 0
        Me.PM_NO.Width = 78
        '
        'M_Code
        '
        Me.M_Code.Caption = "物料編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 1
        Me.M_Code.Width = 102
        '
        'PN_NO
        '
        Me.PN_NO.Caption = "申購單號"
        Me.PN_NO.FieldName = "PN_NO"
        Me.PN_NO.Name = "PN_NO"
        Me.PN_NO.Visible = True
        Me.PN_NO.VisibleIndex = 2
        Me.PN_NO.Width = 74
        '
        'M_Name
        '
        Me.M_Name.Caption = "物料名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 3
        Me.M_Name.Width = 74
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "物料規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 4
        Me.M_Gauge.Width = 74
        '
        'PS_Qty
        '
        Me.PS_Qty.Caption = "採購數量"
        Me.PS_Qty.FieldName = "PS_QTY"
        Me.PS_Qty.Name = "PS_Qty"
        Me.PS_Qty.Visible = True
        Me.PS_Qty.VisibleIndex = 5
        Me.PS_Qty.Width = 69
        '
        'DPT_ID
        '
        Me.DPT_ID.Caption = "申請部門"
        Me.DPT_ID.FieldName = "DPT_ID"
        Me.DPT_ID.Name = "DPT_ID"
        Me.DPT_ID.Visible = True
        Me.DPT_ID.VisibleIndex = 6
        '
        'U_ID
        '
        Me.U_ID.Caption = "申請人"
        Me.U_ID.FieldName = "U_ID"
        Me.U_ID.Name = "U_ID"
        Me.U_ID.Visible = True
        Me.U_ID.VisibleIndex = 7
        Me.U_ID.Width = 58
        '
        'PS_Depict
        '
        Me.PS_Depict.Caption = "要求描述"
        Me.PS_Depict.FieldName = "PS_Depict"
        Me.PS_Depict.Name = "PS_Depict"
        Me.PS_Depict.Visible = True
        Me.PS_Depict.VisibleIndex = 8
        Me.PS_Depict.Width = 103
        '
        'frmWareMoveLook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 478)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.txtPM_NO)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWareMoveLook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "採購單-查看"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPM_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DG As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Depict As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PN_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Qty As DevExpress.XtraGrid.Columns.GridColumn
End Class
