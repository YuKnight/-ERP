<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleOrdersBack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNmetalSampleOrdersBack))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSO_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Code_Type = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSO_SampleID = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colcPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcM_Code_Type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcSO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.cmdExcel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSB_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSE_TypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCode_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSB_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSB_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "样办订单退回查询"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.txtSO_ID)
        Me.Panel1.Controls.Add(Me.txtM_Code_Type)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSO_SampleID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.gluPM_M_Code)
        Me.Panel1.Controls.Add(Me.lblPM_M_Code)
        Me.Panel1.Controls.Add(Me.cmdExcel)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 74)
        Me.Panel1.TabIndex = 88
        '
        'txtSO_ID
        '
        Me.txtSO_ID.Enabled = False
        Me.txtSO_ID.Location = New System.Drawing.Point(394, 10)
        Me.txtSO_ID.Name = "txtSO_ID"
        Me.txtSO_ID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSO_ID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_ID.Properties.ReadOnly = True
        Me.txtSO_ID.Size = New System.Drawing.Size(192, 24)
        Me.txtSO_ID.TabIndex = 258
        '
        'txtM_Code_Type
        '
        Me.txtM_Code_Type.Enabled = False
        Me.txtM_Code_Type.Location = New System.Drawing.Point(394, 39)
        Me.txtM_Code_Type.Name = "txtM_Code_Type"
        Me.txtM_Code_Type.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtM_Code_Type.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code_Type.Properties.ReadOnly = True
        Me.txtM_Code_Type.Size = New System.Drawing.Size(192, 24)
        Me.txtM_Code_Type.TabIndex = 257
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 256
        Me.Label3.Text = "材料编号(&D):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 255
        Me.Label4.Text = "订单编号(&C):"
        '
        'txtSO_SampleID
        '
        Me.txtSO_SampleID.Enabled = False
        Me.txtSO_SampleID.Location = New System.Drawing.Point(102, 39)
        Me.txtSO_SampleID.Name = "txtSO_SampleID"
        Me.txtSO_SampleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSO_SampleID.Properties.Appearance.Options.UseFont = True
        Me.txtSO_SampleID.Properties.ReadOnly = True
        Me.txtSO_SampleID.Size = New System.Drawing.Size(192, 24)
        Me.txtSO_SampleID.TabIndex = 254
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "样办单号(&D):"
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(102, 10)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 480
        Me.gluPM_M_Code.Properties.ValueMember = "SO_ID"
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(192, 24)
        Me.gluPM_M_Code.TabIndex = 252
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcPM_M_Code, Me.colcSO_SampleID, Me.colcM_Code_Type, Me.colcSO_ID})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colcPM_M_Code
        '
        Me.colcPM_M_Code.Caption = "产品编号"
        Me.colcPM_M_Code.FieldName = "PM_M_Code"
        Me.colcPM_M_Code.Name = "colcPM_M_Code"
        Me.colcPM_M_Code.Visible = True
        Me.colcPM_M_Code.VisibleIndex = 0
        '
        'colcSO_SampleID
        '
        Me.colcSO_SampleID.Caption = "样办单号"
        Me.colcSO_SampleID.FieldName = "SO_SampleID"
        Me.colcSO_SampleID.Name = "colcSO_SampleID"
        Me.colcSO_SampleID.Visible = True
        Me.colcSO_SampleID.VisibleIndex = 1
        '
        'colcM_Code_Type
        '
        Me.colcM_Code_Type.Caption = "产品类别"
        Me.colcM_Code_Type.FieldName = "M_Code_Type"
        Me.colcM_Code_Type.Name = "colcM_Code_Type"
        Me.colcM_Code_Type.Visible = True
        Me.colcM_Code_Type.VisibleIndex = 2
        '
        'colcSO_ID
        '
        Me.colcSO_ID.Caption = "订单编号"
        Me.colcSO_ID.FieldName = "SO_ID"
        Me.colcSO_ID.Name = "colcSO_ID"
        Me.colcSO_ID.Visible = True
        Me.colcSO_ID.VisibleIndex = 3
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.Location = New System.Drawing.Point(5, 14)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(96, 16)
        Me.lblPM_M_Code.TabIndex = 251
        Me.lblPM_M_Code.Text = "产品编号(&C):"
        '
        'cmdExcel
        '
        Me.cmdExcel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExcel.Appearance.Options.UseFont = True
        Me.cmdExcel.Image = CType(resources.GetObject("cmdExcel.Image"), System.Drawing.Image)
        Me.cmdExcel.Location = New System.Drawing.Point(687, 39)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(80, 24)
        Me.cmdExcel.TabIndex = 250
        Me.cmdExcel.Text = "Excel(&N)"
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSearch.Location = New System.Drawing.Point(601, 39)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(80, 24)
        Me.cmdSearch.TabIndex = 249
        Me.cmdSearch.Text = "查询(&F)"
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 106)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(825, 569)
        Me.Grid1.TabIndex = 89
        Me.Grid1.TabStop = False
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSB_ID, Me.colSE_TypeName, Me.colCode_ID, Me.colSB_Qty, Me.colD_Dep, Me.colPS_Name, Me.colSB_Remark, Me.colPM_M_Code, Me.colSO_SampleID})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSB_ID
        '
        Me.colSB_ID.Caption = "退回单号"
        Me.colSB_ID.FieldName = "SB_ID"
        Me.colSB_ID.Name = "colSB_ID"
        Me.colSB_ID.Visible = True
        Me.colSB_ID.VisibleIndex = 0
        Me.colSB_ID.Width = 78
        '
        'colSE_TypeName
        '
        Me.colSE_TypeName.Caption = "退回类型"
        Me.colSE_TypeName.FieldName = "SE_TypeName"
        Me.colSE_TypeName.Name = "colSE_TypeName"
        Me.colSE_TypeName.Visible = True
        Me.colSE_TypeName.VisibleIndex = 1
        '
        'colCode_ID
        '
        Me.colCode_ID.Caption = "条码"
        Me.colCode_ID.FieldName = "Code_ID"
        Me.colCode_ID.Name = "colCode_ID"
        Me.colCode_ID.Visible = True
        Me.colCode_ID.VisibleIndex = 2
        Me.colCode_ID.Width = 177
        '
        'colSB_Qty
        '
        Me.colSB_Qty.Caption = "数量"
        Me.colSB_Qty.FieldName = "SB_Qty"
        Me.colSB_Qty.Name = "colSB_Qty"
        Me.colSB_Qty.Visible = True
        Me.colSB_Qty.VisibleIndex = 5
        Me.colSB_Qty.Width = 48
        '
        'colD_Dep
        '
        Me.colD_Dep.Caption = "部门"
        Me.colD_Dep.FieldName = "D_Dep"
        Me.colD_Dep.Name = "colD_Dep"
        Me.colD_Dep.Visible = True
        Me.colD_Dep.VisibleIndex = 6
        '
        'colPS_Name
        '
        Me.colPS_Name.Caption = "工序"
        Me.colPS_Name.FieldName = "PS_Name"
        Me.colPS_Name.Name = "colPS_Name"
        Me.colPS_Name.Visible = True
        Me.colPS_Name.VisibleIndex = 7
        '
        'colSB_Remark
        '
        Me.colSB_Remark.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colSB_Remark.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colSB_Remark.AppearanceCell.Options.UseBackColor = True
        Me.colSB_Remark.AppearanceCell.Options.UseForeColor = True
        Me.colSB_Remark.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colSB_Remark.AppearanceHeader.Options.UseForeColor = True
        Me.colSB_Remark.Caption = "备注"
        Me.colSB_Remark.FieldName = "SB_Remark"
        Me.colSB_Remark.Name = "colSB_Remark"
        Me.colSB_Remark.Visible = True
        Me.colSB_Remark.VisibleIndex = 8
        Me.colSB_Remark.Width = 120
        '
        'colPM_M_Code
        '
        Me.colPM_M_Code.Caption = "产品编号"
        Me.colPM_M_Code.FieldName = "PM_M_Code"
        Me.colPM_M_Code.Name = "colPM_M_Code"
        Me.colPM_M_Code.Visible = True
        Me.colPM_M_Code.VisibleIndex = 3
        Me.colPM_M_Code.Width = 103
        '
        'colSO_SampleID
        '
        Me.colSO_SampleID.Caption = "样办单号"
        Me.colSO_SampleID.FieldName = "SO_SampleID"
        Me.colSO_SampleID.Name = "colSO_SampleID"
        Me.colSO_SampleID.Visible = True
        Me.colSO_SampleID.VisibleIndex = 4
        Me.colSO_SampleID.Width = 111
        '
        'frmSampleOrdersBack
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(825, 675)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSampleOrdersBack"
        Me.Text = "样办订单退回查询"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtSO_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SampleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSO_SampleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcM_Code_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcSO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents cmdExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSB_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_TypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSB_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSB_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtM_Code_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSO_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colPM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
End Class
