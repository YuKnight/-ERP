<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSubModifyNoSendQty
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
        Me.lblTittle = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOM_CusterNo = New DevExpress.XtraEditors.TextEdit
        Me.txtOM_CusterID = New DevExpress.XtraEditors.TextEdit
        Me.txtM_Name = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_Qty = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_SendDate = New DevExpress.XtraEditors.TextEdit
        Me.txtPM_M_Code = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_BatchID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtOS_NoSendQty = New DevExpress.XtraEditors.TextEdit
        Me.txtOS_NoOutQty = New DevExpress.XtraEditors.TextEdit
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOM_CusterNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOM_CusterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_SendDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtOS_NoSendQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOS_NoOutQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTittle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(654, 37)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'lblTittle
        '
        Me.lblTittle.Appearance.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Appearance.Options.UseFont = True
        Me.lblTittle.Location = New System.Drawing.Point(12, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(154, 21)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "修改批次未交數"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txtOS_NoOutQty)
        Me.GroupBox1.Controls.Add(Me.txtOS_NoSendQty)
        Me.GroupBox1.Controls.Add(Me.txtOS_BatchID)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtOM_CusterNo
        '
        Me.txtOM_CusterNo.Enabled = False
        Me.txtOM_CusterNo.Location = New System.Drawing.Point(298, 18)
        Me.txtOM_CusterNo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOM_CusterNo.Name = "txtOM_CusterNo"
        Me.txtOM_CusterNo.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOM_CusterNo.Properties.Appearance.Options.UseFont = True
        Me.txtOM_CusterNo.Size = New System.Drawing.Size(120, 24)
        Me.txtOM_CusterNo.TabIndex = 6
        '
        'txtOM_CusterID
        '
        Me.txtOM_CusterID.Enabled = False
        Me.txtOM_CusterID.Location = New System.Drawing.Point(88, 18)
        Me.txtOM_CusterID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOM_CusterID.Name = "txtOM_CusterID"
        Me.txtOM_CusterID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOM_CusterID.Properties.Appearance.Options.UseFont = True
        Me.txtOM_CusterID.Size = New System.Drawing.Size(120, 24)
        Me.txtOM_CusterID.TabIndex = 6
        '
        'txtM_Name
        '
        Me.txtM_Name.Enabled = False
        Me.txtM_Name.Location = New System.Drawing.Point(298, 54)
        Me.txtM_Name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtM_Name.Name = "txtM_Name"
        Me.txtM_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM_Name.Properties.Appearance.Options.UseFont = True
        Me.txtM_Name.Size = New System.Drawing.Size(120, 24)
        Me.txtM_Name.TabIndex = 6
        '
        'txtOS_Qty
        '
        Me.txtOS_Qty.Enabled = False
        Me.txtOS_Qty.Location = New System.Drawing.Point(522, 54)
        Me.txtOS_Qty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOS_Qty.Name = "txtOS_Qty"
        Me.txtOS_Qty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_Qty.Properties.Appearance.Options.UseFont = True
        Me.txtOS_Qty.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_Qty.TabIndex = 6
        '
        'txtOS_SendDate
        '
        Me.txtOS_SendDate.Enabled = False
        Me.txtOS_SendDate.Location = New System.Drawing.Point(522, 18)
        Me.txtOS_SendDate.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOS_SendDate.Name = "txtOS_SendDate"
        Me.txtOS_SendDate.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_SendDate.Properties.Appearance.Options.UseFont = True
        Me.txtOS_SendDate.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_SendDate.TabIndex = 6
        '
        'txtPM_M_Code
        '
        Me.txtPM_M_Code.Enabled = False
        Me.txtPM_M_Code.Location = New System.Drawing.Point(88, 54)
        Me.txtPM_M_Code.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPM_M_Code.Name = "txtPM_M_Code"
        Me.txtPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.txtPM_M_Code.Size = New System.Drawing.Size(120, 24)
        Me.txtPM_M_Code.TabIndex = 6
        '
        'txtOS_BatchID
        '
        Me.txtOS_BatchID.Enabled = False
        Me.txtOS_BatchID.Location = New System.Drawing.Point(89, 15)
        Me.txtOS_BatchID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOS_BatchID.Name = "txtOS_BatchID"
        Me.txtOS_BatchID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_BatchID.Properties.Appearance.Options.UseFont = True
        Me.txtOS_BatchID.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_BatchID.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(445, 58)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "交貨數量："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(445, 23)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "交貨日期："
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(220, 58)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "配件名稱："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 58)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "產品編號："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(220, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "客戶編號："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "客戶代號："
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "批次編號："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOM_CusterNo)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Controls.Add(Me.txtOM_CusterID)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.txtM_Name)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.txtOS_Qty)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.txtOS_SendDate)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.txtPM_M_Code)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 91)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(220, 20)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "未交數量："
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(430, 20)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 15)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "未出廠數量："
        '
        'txtOS_NoSendQty
        '
        Me.txtOS_NoSendQty.EditValue = "0"
        Me.txtOS_NoSendQty.Location = New System.Drawing.Point(298, 15)
        Me.txtOS_NoSendQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOS_NoSendQty.Name = "txtOS_NoSendQty"
        Me.txtOS_NoSendQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_NoSendQty.Properties.Appearance.Options.UseFont = True
        Me.txtOS_NoSendQty.Properties.Mask.EditMask = "d0"
        Me.txtOS_NoSendQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOS_NoSendQty.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_NoSendQty.TabIndex = 3
        '
        'txtOS_NoOutQty
        '
        Me.txtOS_NoOutQty.EditValue = "0"
        Me.txtOS_NoOutQty.Enabled = False
        Me.txtOS_NoOutQty.Location = New System.Drawing.Point(522, 15)
        Me.txtOS_NoOutQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOS_NoOutQty.Name = "txtOS_NoOutQty"
        Me.txtOS_NoOutQty.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS_NoOutQty.Properties.Appearance.Options.UseFont = True
        Me.txtOS_NoOutQty.Size = New System.Drawing.Size(120, 24)
        Me.txtOS_NoOutQty.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnOK.Location = New System.Drawing.Point(433, 184)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "確定(&O)"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(536, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消(&C)"
        '
        'frmOrderSubModifyNoSendQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(654, 219)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrderSubModifyNoSendQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "修改批次未交數"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtOM_CusterNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOM_CusterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_SendDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_BatchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtOS_NoSendQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOS_NoOutQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTittle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOS_BatchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOM_CusterNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOM_CusterID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPM_M_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtM_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOS_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOS_SendDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOS_NoOutQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOS_NoSendQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
