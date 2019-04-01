<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdersSubNeedFind
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
        Me.dteON_AddDateEnd = New DevExpress.XtraEditors.DateEdit
        Me.dteON_AddDateBegin = New DevExpress.XtraEditors.DateEdit
        Me.cboON_OperationDptCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboON_SalesDptCheck = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboON_PurchaseState = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboM_CodeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.txtON_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_BatchID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dteON_AddDateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteON_AddDateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboON_OperationDptCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboON_SalesDptCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboON_PurchaseState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboM_CodeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtON_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Location = New System.Drawing.Point(2, -3)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Size = New System.Drawing.Size(294, 369)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Text = "PanelControl1"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.cmdCancel.Location = New System.Drawing.Point(164, 331)
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
        Me.cmdFind.Location = New System.Drawing.Point(48, 331)
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
        Me.GroupBox1.Controls.Add(Me.dteON_AddDateEnd)
        Me.GroupBox1.Controls.Add(Me.dteON_AddDateBegin)
        Me.GroupBox1.Controls.Add(Me.cboON_OperationDptCheck)
        Me.GroupBox1.Controls.Add(Me.cboON_SalesDptCheck)
        Me.GroupBox1.Controls.Add(Me.cboON_PurchaseState)
        Me.GroupBox1.Controls.Add(Me.cboM_CodeType)
        Me.GroupBox1.Controls.Add(Me.txtM_Name)
        Me.GroupBox1.Controls.Add(Me.txtON_ID)
        Me.GroupBox1.Controls.Add(Me.txtM_Code)
        Me.GroupBox1.Controls.Add(Me.txtOS_BatchID)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 307)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢條件"
        '
        'dteON_AddDateEnd
        '
        Me.dteON_AddDateEnd.EditValue = Nothing
        Me.dteON_AddDateEnd.Location = New System.Drawing.Point(141, 271)
        Me.dteON_AddDateEnd.Name = "dteON_AddDateEnd"
        Me.dteON_AddDateEnd.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteON_AddDateEnd.Properties.Appearance.Options.UseFont = True
        Me.dteON_AddDateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteON_AddDateEnd.Size = New System.Drawing.Size(120, 22)
        Me.dteON_AddDateEnd.TabIndex = 18
        '
        'dteON_AddDateBegin
        '
        Me.dteON_AddDateBegin.EditValue = Nothing
        Me.dteON_AddDateBegin.Location = New System.Drawing.Point(141, 243)
        Me.dteON_AddDateBegin.Name = "dteON_AddDateBegin"
        Me.dteON_AddDateBegin.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteON_AddDateBegin.Properties.Appearance.Options.UseFont = True
        Me.dteON_AddDateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteON_AddDateBegin.Size = New System.Drawing.Size(120, 22)
        Me.dteON_AddDateBegin.TabIndex = 17
        '
        'cboON_OperationDptCheck
        '
        Me.cboON_OperationDptCheck.EditValue = "全部"
        Me.cboON_OperationDptCheck.Location = New System.Drawing.Point(111, 215)
        Me.cboON_OperationDptCheck.Name = "cboON_OperationDptCheck"
        Me.cboON_OperationDptCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboON_OperationDptCheck.Properties.Appearance.Options.UseFont = True
        Me.cboON_OperationDptCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboON_OperationDptCheck.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cboON_OperationDptCheck.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboON_OperationDptCheck.Size = New System.Drawing.Size(150, 22)
        Me.cboON_OperationDptCheck.TabIndex = 15
        '
        'cboON_SalesDptCheck
        '
        Me.cboON_SalesDptCheck.EditValue = "全部"
        Me.cboON_SalesDptCheck.Location = New System.Drawing.Point(111, 187)
        Me.cboON_SalesDptCheck.Name = "cboON_SalesDptCheck"
        Me.cboON_SalesDptCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboON_SalesDptCheck.Properties.Appearance.Options.UseFont = True
        Me.cboON_SalesDptCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboON_SalesDptCheck.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cboON_SalesDptCheck.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboON_SalesDptCheck.Size = New System.Drawing.Size(150, 22)
        Me.cboON_SalesDptCheck.TabIndex = 13
        '
        'cboON_PurchaseState
        '
        Me.cboON_PurchaseState.EditValue = "全部"
        Me.cboON_PurchaseState.Location = New System.Drawing.Point(111, 159)
        Me.cboON_PurchaseState.Name = "cboON_PurchaseState"
        Me.cboON_PurchaseState.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboON_PurchaseState.Properties.Appearance.Options.UseFont = True
        Me.cboON_PurchaseState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboON_PurchaseState.Properties.Items.AddRange(New Object() {"全部", "處理中", "採購中", "完成"})
        Me.cboON_PurchaseState.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboON_PurchaseState.Size = New System.Drawing.Size(150, 22)
        Me.cboON_PurchaseState.TabIndex = 11
        '
        'cboM_CodeType
        '
        Me.cboM_CodeType.EditValue = "全部"
        Me.cboM_CodeType.Location = New System.Drawing.Point(111, 131)
        Me.cboM_CodeType.Name = "cboM_CodeType"
        Me.cboM_CodeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboM_CodeType.Properties.Appearance.Options.UseFont = True
        Me.cboM_CodeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboM_CodeType.Properties.Items.AddRange(New Object() {"全部", "原材料", "輔助材料"})
        Me.cboM_CodeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboM_CodeType.Size = New System.Drawing.Size(150, 22)
        Me.cboM_CodeType.TabIndex = 9
        '
        'txtM_Name
        '
        Me.txtM_Name.Location = New System.Drawing.Point(111, 103)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Size = New System.Drawing.Size(150, 22)
        Me.txtM_Name.TabIndex = 7
        '
        'txtON_ID
        '
        Me.txtON_ID.Location = New System.Drawing.Point(111, 20)
        Me.txtON_ID.Name = "txtON_ID"
        Me.txtON_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtON_ID.Properties.Appearance.Options.UseFont = True
        Me.txtON_ID.Size = New System.Drawing.Size(150, 22)
        Me.txtON_ID.TabIndex = 1
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(111, 75)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Code.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code.Size = New System.Drawing.Size(150, 22)
        Me.txtM_Code.TabIndex = 5
        '
        'txtOS_BatchID
        '
        Me.txtOS_BatchID.Location = New System.Drawing.Point(111, 47)
        Me.txtOS_BatchID.Name = "txtOS_BatchID"
        Me.txtOS_BatchID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_BatchID.Properties.Appearance.Options.UseFont = True
        Me.txtOS_BatchID.Size = New System.Drawing.Size(150, 22)
        Me.txtOS_BatchID.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(25, 107)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "物料名稱(&N)："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(115, 275)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "到"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(115, 248)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "從"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(27, 248)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "建立日期(&E)："
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(12, 218)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl11.TabIndex = 14
        Me.LabelControl11.Text = "營運部審核(&G)："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(26, 163)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "採購狀態(&B)："
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 190)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "營業部審核(&K)："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(27, 134)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "配件類型(&T)："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(23, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "物料編碼(&M)："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(27, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "批次編號(&L)："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(30, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "需求單號(&I)："
        '
        'frmOrdersSubNeedFind
        '
        Me.AcceptButton = Me.cmdFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(298, 368)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrdersSubNeedFind"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "批次需求單查詢"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dteON_AddDateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteON_AddDateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboON_OperationDptCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboON_SalesDptCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboON_PurchaseState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboM_CodeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtON_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOS_BatchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtON_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteON_AddDateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteON_AddDateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboON_PurchaseState As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboM_CodeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboON_OperationDptCheck As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboON_SalesDptCheck As DevExpress.XtraEditors.ComboBoxEdit
End Class
