<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeSetting
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
        Me.components = New System.ComponentModel.Container
        Me.ButtonWhite = New DevExpress.XtraEditors.SimpleButton
        Me.ButtonMCodeGroup = New DevExpress.XtraEditors.SimpleButton
        Me.my_tabpage = New System.Windows.Forms.TabControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuInventory = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem00 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem01 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem02 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem03 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuMonth = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem04 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem05 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem08 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuRecord = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuOther = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonReport = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonWhite
        '
        Me.ButtonWhite.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonWhite.Appearance.Options.UseFont = True
        Me.ButtonWhite.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ButtonWhite.Enabled = False
        Me.ButtonWhite.Location = New System.Drawing.Point(13, 9)
        Me.ButtonWhite.Name = "ButtonWhite"
        Me.ButtonWhite.Size = New System.Drawing.Size(80, 25)
        Me.ButtonWhite.TabIndex = 209
        Me.ButtonWhite.Text = "白名單"
        '
        'ButtonMCodeGroup
        '
        Me.ButtonMCodeGroup.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMCodeGroup.Appearance.Options.UseFont = True
        Me.ButtonMCodeGroup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ButtonMCodeGroup.Enabled = False
        Me.ButtonMCodeGroup.Location = New System.Drawing.Point(125, 9)
        Me.ButtonMCodeGroup.Name = "ButtonMCodeGroup"
        Me.ButtonMCodeGroup.Size = New System.Drawing.Size(80, 25)
        Me.ButtonMCodeGroup.TabIndex = 210
        Me.ButtonMCodeGroup.Text = "刀具分組"
        '
        'my_tabpage
        '
        Me.my_tabpage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_tabpage.ItemSize = New System.Drawing.Size(0, 1)
        Me.my_tabpage.Location = New System.Drawing.Point(1, 36)
        Me.my_tabpage.Name = "my_tabpage"
        Me.my_tabpage.SelectedIndex = 0
        Me.my_tabpage.Size = New System.Drawing.Size(733, 404)
        Me.my_tabpage.TabIndex = 211
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuInventory, Me.MenuMonth, Me.MenuRecord, Me.MenuOther})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 92)
        '
        'MenuInventory
        '
        Me.MenuInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem00, Me.ToolStripMenuItem01, Me.ToolStripMenuItem02, Me.ToolStripMenuItem03})
        Me.MenuInventory.Name = "MenuInventory"
        Me.MenuInventory.Size = New System.Drawing.Size(124, 22)
        Me.MenuInventory.Text = "庫存"
        '
        'ToolStripMenuItem00
        '
        Me.ToolStripMenuItem00.Name = "ToolStripMenuItem00"
        Me.ToolStripMenuItem00.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem00.Tag = "ScatterInventory"
        Me.ToolStripMenuItem00.Text = "盤點以往庫存"
        '
        'ToolStripMenuItem01
        '
        Me.ToolStripMenuItem01.Name = "ToolStripMenuItem01"
        Me.ToolStripMenuItem01.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem01.Tag = "KnifeInventory"
        Me.ToolStripMenuItem01.Text = "倉庫庫存"
        '
        'ToolStripMenuItem02
        '
        Me.ToolStripMenuItem02.Name = "ToolStripMenuItem02"
        Me.ToolStripMenuItem02.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem02.Tag = "TechnicianInventory"
        Me.ToolStripMenuItem02.Text = "技術員庫存"
        '
        'ToolStripMenuItem03
        '
        Me.ToolStripMenuItem03.Name = "ToolStripMenuItem03"
        Me.ToolStripMenuItem03.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem03.Tag = "KnifeCheck"
        Me.ToolStripMenuItem03.Text = "刀具盤點表"
        '
        'MenuMonth
        '
        Me.MenuMonth.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem04, Me.ToolStripMenuItem05, Me.ToolStripMenuItem08})
        Me.MenuMonth.Name = "MenuMonth"
        Me.MenuMonth.Size = New System.Drawing.Size(124, 22)
        Me.MenuMonth.Text = "月報表"
        '
        'ToolStripMenuItem04
        '
        Me.ToolStripMenuItem04.Name = "ToolStripMenuItem04"
        Me.ToolStripMenuItem04.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem04.Tag = "MonthUseKnifeMoney"
        Me.ToolStripMenuItem04.Text = "每月刀具領用金額匯總"
        '
        'ToolStripMenuItem05
        '
        Me.ToolStripMenuItem05.Name = "ToolStripMenuItem05"
        Me.ToolStripMenuItem05.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem05.Tag = "KnifeUseCondition"
        Me.ToolStripMenuItem05.Text = "每月刀具領用狀況"
        '
        'ToolStripMenuItem08
        '
        Me.ToolStripMenuItem08.Name = "ToolStripMenuItem08"
        Me.ToolStripMenuItem08.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem08.Tag = "KnifeReturnRecord"
        Me.ToolStripMenuItem08.Text = "回收記錄一覽表"
        '
        'MenuRecord
        '
        Me.MenuRecord.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem13})
        Me.MenuRecord.Name = "MenuRecord"
        Me.MenuRecord.Size = New System.Drawing.Size(124, 22)
        Me.MenuRecord.Text = "操作記錄"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem12.Tag = "KnifeBorrow"
        Me.ToolStripMenuItem12.Text = "刀具領取記錄"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem13.Tag = "KnifeReturn"
        Me.ToolStripMenuItem13.Text = "刀具歸還記錄"
        '
        'MenuOther
        '
        Me.MenuOther.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18, Me.ToolStripMenuItem19, Me.ToolStripMenuItem20})
        Me.MenuOther.Name = "MenuOther"
        Me.MenuOther.Size = New System.Drawing.Size(124, 22)
        Me.MenuOther.Text = "其它"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem14.Tag = "InventoryKnifeMoney"
        Me.ToolStripMenuItem14.Text = "在庫物料單價表"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem15.Tag = "UseKnifeScatter"
        Me.ToolStripMenuItem15.Text = "在用刀具分佈一覽"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem16.Tag = "UseKnifeQty"
        Me.ToolStripMenuItem16.Text = "在用刀具數量統計"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem17.Tag = "SomeoneNoReturn"
        Me.ToolStripMenuItem17.Text = "人員欠刀情況"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem18.Tag = "KnifeUse"
        Me.ToolStripMenuItem18.Text = "刀具耗用表"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem19.Tag = "StaffKnifeMoney"
        Me.ToolStripMenuItem19.Text = "員工領刀金額"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem20.Tag = "TimeNoReturn"
        Me.ToolStripMenuItem20.Text = "逾期未結刀具表"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ButtonReport)
        Me.Panel1.Controls.Add(Me.ButtonWhite)
        Me.Panel1.Controls.Add(Me.ButtonMCodeGroup)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 41)
        Me.Panel1.TabIndex = 212
        '
        'ButtonReport
        '
        Me.ButtonReport.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReport.Appearance.Options.UseFont = True
        Me.ButtonReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ButtonReport.Enabled = False
        Me.ButtonReport.Location = New System.Drawing.Point(241, 9)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(80, 25)
        Me.ButtonReport.TabIndex = 212
        Me.ButtonReport.Text = "報表匯總"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 38)
        Me.PictureBox1.TabIndex = 213
        Me.PictureBox1.TabStop = False
        '
        'frmKnifeSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 439)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.my_tabpage)
        Me.Name = "frmKnifeSetting"
        Me.Text = "刀具系統參數"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonWhite As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonMCodeGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents my_tabpage As System.Windows.Forms.TabControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuMonth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem00 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem03 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem04 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem05 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem08 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuRecord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOther As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
