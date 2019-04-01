<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceptanceGather
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dteA_SendDateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dteA_SendDateBegin = New DevExpress.XtraEditors.DateEdit
        Me.gluS_Supplier = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.S_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.S_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cboA_AccountCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboA_PayCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dteA_SendDateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteA_SendDateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluS_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cboA_AccountCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboA_PayCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboA_PayCheck)
        Me.GroupBox1.Controls.Add(Me.cboA_AccountCheck)
        Me.GroupBox1.Controls.Add(Me.dteA_SendDateEnd)
        Me.GroupBox1.Controls.Add(Me.dteA_SendDateBegin)
        Me.GroupBox1.Controls.Add(Me.gluS_Supplier)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "匯總條件"
        '
        'dteA_SendDateEnd
        '
        Me.dteA_SendDateEnd.EditValue = Nothing
        Me.dteA_SendDateEnd.Location = New System.Drawing.Point(154, 171)
        Me.dteA_SendDateEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.dteA_SendDateEnd.Name = "dteA_SendDateEnd"
        Me.dteA_SendDateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteA_SendDateEnd.Properties.Appearance.Options.UseFont = True
        Me.dteA_SendDateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteA_SendDateEnd.Size = New System.Drawing.Size(150, 24)
        Me.dteA_SendDateEnd.TabIndex = 8
        '
        'dteA_SendDateBegin
        '
        Me.dteA_SendDateBegin.EditValue = Nothing
        Me.dteA_SendDateBegin.Location = New System.Drawing.Point(154, 135)
        Me.dteA_SendDateBegin.Margin = New System.Windows.Forms.Padding(6)
        Me.dteA_SendDateBegin.Name = "dteA_SendDateBegin"
        Me.dteA_SendDateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteA_SendDateBegin.Properties.Appearance.Options.UseFont = True
        Me.dteA_SendDateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteA_SendDateBegin.Size = New System.Drawing.Size(150, 24)
        Me.dteA_SendDateBegin.TabIndex = 7
        '
        'gluS_Supplier
        '
        Me.gluS_Supplier.Location = New System.Drawing.Point(124, 27)
        Me.gluS_Supplier.Margin = New System.Windows.Forms.Padding(6)
        Me.gluS_Supplier.Name = "gluS_Supplier"
        Me.gluS_Supplier.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluS_Supplier.Properties.Appearance.Options.UseFont = True
        Me.gluS_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluS_Supplier.Properties.NullText = ""
        Me.gluS_Supplier.Properties.View = Me.GridLookUpEdit1View
        Me.gluS_Supplier.Size = New System.Drawing.Size(180, 24)
        Me.gluS_Supplier.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.S_Supplier, Me.S_SupplierName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'S_Supplier
        '
        Me.S_Supplier.Caption = "供應商編號"
        Me.S_Supplier.FieldName = "S_Supplier"
        Me.S_Supplier.Name = "S_Supplier"
        Me.S_Supplier.OptionsColumn.ReadOnly = True
        Me.S_Supplier.Visible = True
        Me.S_Supplier.VisibleIndex = 0
        '
        'S_SupplierName
        '
        Me.S_SupplierName.Caption = "供應商名稱"
        Me.S_SupplierName.FieldName = "S_SupplierName"
        Me.S_SupplierName.Name = "S_SupplierName"
        Me.S_SupplierName.OptionsColumn.ReadOnly = True
        Me.S_SupplierName.Visible = True
        Me.S_SupplierName.VisibleIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(30, 140)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 15)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "送貨日期(&D)： 從"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(129, 176)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(15, 15)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "到"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "供應商名稱(&P)："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnOK)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(186, 21)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Location = New System.Drawing.Point(56, 21)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "確定(&O)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(29, 68)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "審核狀態(&K)："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(29, 104)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "付款確認(&Y)："
        '
        'cboA_AccountCheck
        '
        Me.cboA_AccountCheck.EditValue = "全部"
        Me.cboA_AccountCheck.Location = New System.Drawing.Point(124, 63)
        Me.cboA_AccountCheck.Margin = New System.Windows.Forms.Padding(6)
        Me.cboA_AccountCheck.Name = "cboA_AccountCheck"
        Me.cboA_AccountCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboA_AccountCheck.Properties.Appearance.Options.UseFont = True
        Me.cboA_AccountCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboA_AccountCheck.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cboA_AccountCheck.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboA_AccountCheck.Size = New System.Drawing.Size(180, 24)
        Me.cboA_AccountCheck.TabIndex = 3
        '
        'cboA_PayCheck
        '
        Me.cboA_PayCheck.EditValue = "全部"
        Me.cboA_PayCheck.Location = New System.Drawing.Point(124, 99)
        Me.cboA_PayCheck.Margin = New System.Windows.Forms.Padding(6)
        Me.cboA_PayCheck.Name = "cboA_PayCheck"
        Me.cboA_PayCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboA_PayCheck.Properties.Appearance.Options.UseFont = True
        Me.cboA_PayCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboA_PayCheck.Properties.Items.AddRange(New Object() {"全部", "已確認", "未確認"})
        Me.cboA_PayCheck.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboA_PayCheck.Size = New System.Drawing.Size(180, 24)
        Me.cboA_PayCheck.TabIndex = 5
        '
        'frmAcceptanceGather
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(345, 299)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcceptanceGather"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "驗收記錄匯總"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dteA_SendDateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteA_SendDateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluS_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.cboA_AccountCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboA_PayCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteA_SendDateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteA_SendDateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gluS_Supplier As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents S_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboA_PayCheck As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboA_AccountCheck As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
