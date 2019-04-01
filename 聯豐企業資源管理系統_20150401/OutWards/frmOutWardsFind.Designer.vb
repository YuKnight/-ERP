<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutWardsFind
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dteOW_DateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dteOW_DateBegin = New DevExpress.XtraEditors.DateEdit
        Me.cboOW_Check = New DevExpress.XtraEditors.ComboBoxEdit
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gluOM_CusterID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.C_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_EngName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_ChsName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtOM_CusterPO = New DevExpress.XtraEditors.TextEdit
        Me.txtOM_CusterNO = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_BatchID = New DevExpress.XtraEditors.TextEdit
        Me.txtOW_NO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dteOW_DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteOW_DateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOW_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluOM_CusterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOM_CusterPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOM_CusterNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOW_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.Controls.Add(Me.cmdCancel)
        Me.PanelControl1.Controls.Add(Me.cmdFind)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Location = New System.Drawing.Point(2, -7)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Size = New System.Drawing.Size(284, 338)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(159, 300)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "取消(&C)"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdFind.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdFind.Appearance.Options.UseFont = True
        Me.cmdFind.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdFind.Location = New System.Drawing.Point(43, 300)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(80, 28)
        Me.cmdFind.TabIndex = 1
        Me.cmdFind.Text = "查詢(&F)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dteOW_DateEnd)
        Me.GroupBox1.Controls.Add(Me.dteOW_DateBegin)
        Me.GroupBox1.Controls.Add(Me.cboOW_Check)
        Me.GroupBox1.Controls.Add(Me.gluPM_M_Code)
        Me.GroupBox1.Controls.Add(Me.gluOM_CusterID)
        Me.GroupBox1.Controls.Add(Me.txtOM_CusterPO)
        Me.GroupBox1.Controls.Add(Me.txtOM_CusterNO)
        Me.GroupBox1.Controls.Add(Me.txtOS_BatchID)
        Me.GroupBox1.Controls.Add(Me.txtOW_NO)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'dteOW_DateEnd
        '
        Me.dteOW_DateEnd.EditValue = Nothing
        Me.dteOW_DateEnd.Location = New System.Drawing.Point(130, 243)
        Me.dteOW_DateEnd.Name = "dteOW_DateEnd"
        Me.dteOW_DateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteOW_DateEnd.Properties.Appearance.Options.UseFont = True
        Me.dteOW_DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteOW_DateEnd.Size = New System.Drawing.Size(120, 22)
        Me.dteOW_DateEnd.TabIndex = 16
        '
        'dteOW_DateBegin
        '
        Me.dteOW_DateBegin.EditValue = Nothing
        Me.dteOW_DateBegin.Location = New System.Drawing.Point(130, 215)
        Me.dteOW_DateBegin.Name = "dteOW_DateBegin"
        Me.dteOW_DateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteOW_DateBegin.Properties.Appearance.Options.UseFont = True
        Me.dteOW_DateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteOW_DateBegin.Size = New System.Drawing.Size(120, 22)
        Me.dteOW_DateBegin.TabIndex = 15
        '
        'cboOW_Check
        '
        Me.cboOW_Check.EditValue = "全部"
        Me.cboOW_Check.Location = New System.Drawing.Point(100, 187)
        Me.cboOW_Check.Name = "cboOW_Check"
        Me.cboOW_Check.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOW_Check.Properties.Appearance.Options.UseFont = True
        Me.cboOW_Check.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOW_Check.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cboOW_Check.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOW_Check.Size = New System.Drawing.Size(150, 22)
        Me.cboOW_Check.TabIndex = 13
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.Location = New System.Drawing.Point(100, 103)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 200
        Me.gluPM_M_Code.Properties.View = Me.GridView1
        Me.gluPM_M_Code.Size = New System.Drawing.Size(150, 22)
        Me.gluPM_M_Code.TabIndex = 7
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_Code, Me.PM_JiYu})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 0
        Me.PM_M_Code.Width = 225
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = strJIYU
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 1
        Me.PM_JiYu.Width = 156
        '
        'gluOM_CusterID
        '
        Me.gluOM_CusterID.Location = New System.Drawing.Point(100, 47)
        Me.gluOM_CusterID.Name = "gluOM_CusterID"
        Me.gluOM_CusterID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluOM_CusterID.Properties.Appearance.Options.UseFont = True
        Me.gluOM_CusterID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluOM_CusterID.Properties.NullText = ""
        Me.gluOM_CusterID.Properties.View = Me.GridLookUpEdit1View
        Me.gluOM_CusterID.Size = New System.Drawing.Size(150, 22)
        Me.gluOM_CusterID.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.C_CusterID, Me.C_EngName, Me.C_ChsName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowColumnMoving = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'C_CusterID
        '
        Me.C_CusterID.Caption = "客戶代號"
        Me.C_CusterID.FieldName = "C_CusterID"
        Me.C_CusterID.Name = "C_CusterID"
        Me.C_CusterID.Visible = True
        Me.C_CusterID.VisibleIndex = 0
        '
        'C_EngName
        '
        Me.C_EngName.Caption = "英文名"
        Me.C_EngName.FieldName = "C_EngName"
        Me.C_EngName.Name = "C_EngName"
        Me.C_EngName.Visible = True
        Me.C_EngName.VisibleIndex = 1
        '
        'C_ChsName
        '
        Me.C_ChsName.Caption = "中文名"
        Me.C_ChsName.FieldName = "C_ChsName"
        Me.C_ChsName.Name = "C_ChsName"
        Me.C_ChsName.Visible = True
        Me.C_ChsName.VisibleIndex = 2
        '
        'txtOM_CusterPO
        '
        Me.txtOM_CusterPO.Location = New System.Drawing.Point(100, 159)
        Me.txtOM_CusterPO.Name = "txtOM_CusterPO"
        Me.txtOM_CusterPO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOM_CusterPO.Properties.Appearance.Options.UseFont = True
        Me.txtOM_CusterPO.Size = New System.Drawing.Size(150, 22)
        Me.txtOM_CusterPO.TabIndex = 11
        '
        'txtOM_CusterNO
        '
        Me.txtOM_CusterNO.Location = New System.Drawing.Point(100, 131)
        Me.txtOM_CusterNO.Name = "txtOM_CusterNO"
        Me.txtOM_CusterNO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOM_CusterNO.Properties.Appearance.Options.UseFont = True
        Me.txtOM_CusterNO.Size = New System.Drawing.Size(150, 22)
        Me.txtOM_CusterNO.TabIndex = 9
        '
        'txtOS_BatchID
        '
        Me.txtOS_BatchID.Location = New System.Drawing.Point(100, 75)
        Me.txtOS_BatchID.Name = "txtOS_BatchID"
        Me.txtOS_BatchID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_BatchID.Properties.Appearance.Options.UseFont = True
        Me.txtOS_BatchID.Size = New System.Drawing.Size(150, 22)
        Me.txtOS_BatchID.TabIndex = 5
        '
        'txtOW_NO
        '
        Me.txtOW_NO.Location = New System.Drawing.Point(100, 19)
        Me.txtOW_NO.Name = "txtOW_NO"
        Me.txtOW_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOW_NO.Properties.Appearance.Options.UseFont = True
        Me.txtOW_NO.Size = New System.Drawing.Size(150, 22)
        Me.txtOW_NO.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(14, 135)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "客戶編號(&N)："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(104, 247)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "到"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(104, 220)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "從"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(16, 220)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "送貨日期(&E)："
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(14, 190)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "審核狀態(&K)："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(17, 163)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "客戶&PO NO.："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(14, 51)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "客戶代號(&D)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "產品編號(&M)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "批次編號(&L)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "送貨單號(&I)："
        '
        'frmOutWardsFind
        '
        Me.AcceptButton = Me.cmdFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(288, 333)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOutWardsFind"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "送貨--查詢"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dteOW_DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteOW_DateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOW_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluOM_CusterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOM_CusterPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOM_CusterNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOW_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOM_CusterNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOS_BatchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOW_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOM_CusterPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gluOM_CusterID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_EngName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_ChsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboOW_Check As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dteOW_DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteOW_DateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
End Class
