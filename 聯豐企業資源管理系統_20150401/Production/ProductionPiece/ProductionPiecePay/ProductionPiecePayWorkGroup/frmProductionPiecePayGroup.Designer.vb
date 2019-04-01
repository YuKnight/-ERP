<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionPiecePayGroup
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
        Me.DatePY_YYMM = New DevExpress.XtraEditors.DateEdit
        Me.LabelPY_YYMM = New DevExpress.XtraEditors.LabelControl
        Me.LabelCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gb3 = New System.Windows.Forms.GroupBox
        Me.txtG_Name = New DevExpress.XtraEditors.TextEdit
        Me.labG_NO = New DevExpress.XtraEditors.LabelControl
        Me.LabG_Name = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtG_NO = New DevExpress.XtraEditors.TextEdit
        Me.txtFacID = New DevExpress.XtraEditors.TextEdit
        Me.txtDepID = New DevExpress.XtraEditors.TextEdit
        Me.txtPY_PieceAllSum = New DevExpress.XtraEditors.TextEdit
        Me.TxtPY_TimeAllSum = New DevExpress.XtraEditors.TextEdit
        Me.TxtPY_CompensateSum = New DevExpress.XtraEditors.TextEdit
        Me.txtPY_SubtractSum = New DevExpress.XtraEditors.TextEdit
        Me.TxtPY_CompleteSum = New DevExpress.XtraEditors.TextEdit
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.txtG_NO_InSum = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.LabPY_CompleteSum1 = New System.Windows.Forms.Label
        Me.LabelPY_PieceAllSum1 = New System.Windows.Forms.Label
        Me.LabelPY_TimeAllSum1 = New System.Windows.Forms.Label
        Me.LabPY_CompensateSum1 = New System.Windows.Forms.Label
        Me.txtG_NO_OUTSum = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.LabPY_SubtractSum1 = New System.Windows.Forms.Label
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.txtPY_Remark = New DevExpress.XtraEditors.TextEdit
        Me.txtPY_PieceSum = New DevExpress.XtraEditors.TextEdit
        Me.LabPY_PieceSum = New DevExpress.XtraEditors.LabelControl
        Me.txtPY_BonusSum = New DevExpress.XtraEditors.TextEdit
        Me.LabPY_BonusSum = New DevExpress.XtraEditors.LabelControl
        Me.TxtPY_TimeSum = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabPY_TimeSum = New DevExpress.XtraEditors.LabelControl
        Me.LabelPY_UseSum = New DevExpress.XtraEditors.LabelControl
        Me.TxtPY_UseSum = New DevExpress.XtraEditors.TextEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PLUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_FormulaID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PYS_WorkWGDay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_DayPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_OnDutyDays = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_UsualOverTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_HolidayOVerTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_Proportion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_Bonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PYS_AllHours = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_MeritedHours = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_TimePay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_PiecePay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Per_PayType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_MeritedPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PYS_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.SButtonSum = New DevExpress.XtraEditors.SimpleButton
        Me.ButtonDetail = New DevExpress.XtraEditors.SimpleButton
        Me.chkPY_Check = New DevExpress.XtraEditors.CheckEdit
        Me.LabPY_ID = New DevExpress.XtraEditors.LabelControl
        Me.GB4 = New System.Windows.Forms.GroupBox
        Me.txtMeritedPaySum = New DevExpress.XtraEditors.TextEdit
        Me.labMeritedPaySum = New DevExpress.XtraEditors.LabelControl
        Me.txtBonusSum = New DevExpress.XtraEditors.TextEdit
        Me.labBonus = New DevExpress.XtraEditors.LabelControl
        Me.txtPiecePaySum = New DevExpress.XtraEditors.TextEdit
        Me.labPiecePaySum = New DevExpress.XtraEditors.LabelControl
        Me.txtMeritedHoursSum = New DevExpress.XtraEditors.TextEdit
        Me.labMeritedHoursSum = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DatePY_YYMM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb3.SuspendLayout()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPY_PieceAllSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPY_TimeAllSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPY_CompensateSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPY_SubtractSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPY_CompleteSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        CType(Me.txtG_NO_InSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtG_NO_OUTSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB2.SuspendLayout()
        CType(Me.txtPY_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPY_PieceSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPY_BonusSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPY_TimeSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPY_UseSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPY_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB4.SuspendLayout()
        CType(Me.txtMeritedPaySum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBonusSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPiecePaySum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMeritedHoursSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatePY_YYMM
        '
        Me.DatePY_YYMM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePY_YYMM.EditValue = Nothing
        Me.DatePY_YYMM.Enabled = False
        Me.DatePY_YYMM.Location = New System.Drawing.Point(691, 6)
        Me.DatePY_YYMM.Name = "DatePY_YYMM"
        Me.DatePY_YYMM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePY_YYMM.Properties.Appearance.Options.UseFont = True
        Me.DatePY_YYMM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DatePY_YYMM.Properties.DisplayFormat.FormatString = "yyyy年MM月"
        Me.DatePY_YYMM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DatePY_YYMM.Properties.Mask.BeepOnError = True
        Me.DatePY_YYMM.Properties.Mask.EditMask = "y"
        Me.DatePY_YYMM.Size = New System.Drawing.Size(111, 25)
        Me.DatePY_YYMM.TabIndex = 47
        '
        'LabelPY_YYMM
        '
        Me.LabelPY_YYMM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPY_YYMM.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelPY_YYMM.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPY_YYMM.Appearance.Options.UseBackColor = True
        Me.LabelPY_YYMM.Appearance.Options.UseFont = True
        Me.LabelPY_YYMM.Location = New System.Drawing.Point(642, 12)
        Me.LabelPY_YYMM.Name = "LabelPY_YYMM"
        Me.LabelPY_YYMM.Size = New System.Drawing.Size(45, 15)
        Me.LabelPY_YYMM.TabIndex = 46
        Me.LabelPY_YYMM.Text = "年月："
        '
        'LabelCaption
        '
        Me.LabelCaption.AutoSize = True
        Me.LabelCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelCaption.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCaption.Location = New System.Drawing.Point(8, 8)
        Me.LabelCaption.Name = "LabelCaption"
        Me.LabelCaption.Size = New System.Drawing.Size(197, 21)
        Me.LabelCaption.TabIndex = 45
        Me.LabelCaption.Text = "承包計件薪金-修改"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 34)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'gb3
        '
        Me.gb3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb3.Controls.Add(Me.txtG_Name)
        Me.gb3.Controls.Add(Me.labG_NO)
        Me.gb3.Controls.Add(Me.LabG_Name)
        Me.gb3.Controls.Add(Me.LabelControl4)
        Me.gb3.Controls.Add(Me.LabelControl5)
        Me.gb3.Controls.Add(Me.txtG_NO)
        Me.gb3.Controls.Add(Me.txtFacID)
        Me.gb3.Controls.Add(Me.txtDepID)
        Me.gb3.Location = New System.Drawing.Point(3, 35)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(806, 48)
        Me.gb3.TabIndex = 48
        Me.gb3.TabStop = False
        '
        'txtG_Name
        '
        Me.txtG_Name.EditValue = "G_Name"
        Me.txtG_Name.Location = New System.Drawing.Point(213, 18)
        Me.txtG_Name.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtG_Name.Name = "txtG_Name"
        Me.txtG_Name.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtG_Name.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG_Name.Properties.Appearance.Options.UseBackColor = True
        Me.txtG_Name.Properties.Appearance.Options.UseFont = True
        Me.txtG_Name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtG_Name.Properties.ReadOnly = True
        Me.txtG_Name.Size = New System.Drawing.Size(89, 22)
        Me.txtG_Name.TabIndex = 35
        '
        'labG_NO
        '
        Me.labG_NO.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labG_NO.Appearance.Options.UseFont = True
        Me.labG_NO.Location = New System.Drawing.Point(6, 21)
        Me.labG_NO.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.labG_NO.Name = "labG_NO"
        Me.labG_NO.Size = New System.Drawing.Size(75, 15)
        Me.labG_NO.TabIndex = 27
        Me.labG_NO.Text = "組別編號："
        '
        'LabG_Name
        '
        Me.LabG_Name.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabG_Name.Appearance.Options.UseFont = True
        Me.LabG_Name.Location = New System.Drawing.Point(175, 21)
        Me.LabG_Name.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabG_Name.Name = "LabG_Name"
        Me.LabG_Name.Size = New System.Drawing.Size(34, 15)
        Me.LabG_Name.TabIndex = 29
        Me.LabG_Name.Text = "名稱:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(308, 21)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "廠別名稱："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(496, 21)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl5.TabIndex = 33
        Me.LabelControl5.Text = "部門名稱："
        '
        'txtG_NO
        '
        Me.txtG_NO.EditValue = "G_NO"
        Me.txtG_NO.Location = New System.Drawing.Point(80, 18)
        Me.txtG_NO.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtG_NO.Name = "txtG_NO"
        Me.txtG_NO.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtG_NO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG_NO.Properties.Appearance.Options.UseBackColor = True
        Me.txtG_NO.Properties.Appearance.Options.UseFont = True
        Me.txtG_NO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtG_NO.Properties.ReadOnly = True
        Me.txtG_NO.Size = New System.Drawing.Size(89, 22)
        Me.txtG_NO.TabIndex = 28
        '
        'txtFacID
        '
        Me.txtFacID.EditValue = "FacID"
        Me.txtFacID.Location = New System.Drawing.Point(383, 19)
        Me.txtFacID.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtFacID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacID.Properties.Appearance.Options.UseBackColor = True
        Me.txtFacID.Properties.Appearance.Options.UseFont = True
        Me.txtFacID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtFacID.Properties.ReadOnly = True
        Me.txtFacID.Size = New System.Drawing.Size(107, 22)
        Me.txtFacID.TabIndex = 32
        '
        'txtDepID
        '
        Me.txtDepID.EditValue = "Per_NO"
        Me.txtDepID.Location = New System.Drawing.Point(571, 19)
        Me.txtDepID.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtDepID.Name = "txtDepID"
        Me.txtDepID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepID.Properties.Appearance.Options.UseBackColor = True
        Me.txtDepID.Properties.Appearance.Options.UseFont = True
        Me.txtDepID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDepID.Properties.ReadOnly = True
        Me.txtDepID.Size = New System.Drawing.Size(91, 22)
        Me.txtDepID.TabIndex = 34
        '
        'txtPY_PieceAllSum
        '
        Me.txtPY_PieceAllSum.Location = New System.Drawing.Point(72, 11)
        Me.txtPY_PieceAllSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtPY_PieceAllSum.Name = "txtPY_PieceAllSum"
        Me.txtPY_PieceAllSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPY_PieceAllSum.Properties.Appearance.Options.UseFont = True
        Me.txtPY_PieceAllSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_PieceAllSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_PieceAllSum.Properties.Mask.EditMask = "f2"
        Me.txtPY_PieceAllSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPY_PieceAllSum.Size = New System.Drawing.Size(80, 24)
        Me.txtPY_PieceAllSum.TabIndex = 50
        '
        'TxtPY_TimeAllSum
        '
        Me.TxtPY_TimeAllSum.Location = New System.Drawing.Point(247, 12)
        Me.TxtPY_TimeAllSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.TxtPY_TimeAllSum.Name = "TxtPY_TimeAllSum"
        Me.TxtPY_TimeAllSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPY_TimeAllSum.Properties.Appearance.Options.UseFont = True
        Me.TxtPY_TimeAllSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_TimeAllSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_TimeAllSum.Properties.Mask.EditMask = "f2"
        Me.TxtPY_TimeAllSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPY_TimeAllSum.Size = New System.Drawing.Size(80, 24)
        Me.TxtPY_TimeAllSum.TabIndex = 52
        '
        'TxtPY_CompensateSum
        '
        Me.TxtPY_CompensateSum.Location = New System.Drawing.Point(394, 11)
        Me.TxtPY_CompensateSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.TxtPY_CompensateSum.Name = "TxtPY_CompensateSum"
        Me.TxtPY_CompensateSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPY_CompensateSum.Properties.Appearance.Options.UseFont = True
        Me.TxtPY_CompensateSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_CompensateSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_CompensateSum.Properties.Mask.EditMask = "f2"
        Me.TxtPY_CompensateSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPY_CompensateSum.Size = New System.Drawing.Size(80, 24)
        Me.TxtPY_CompensateSum.TabIndex = 54
        '
        'txtPY_SubtractSum
        '
        Me.txtPY_SubtractSum.Location = New System.Drawing.Point(71, 41)
        Me.txtPY_SubtractSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtPY_SubtractSum.Name = "txtPY_SubtractSum"
        Me.txtPY_SubtractSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPY_SubtractSum.Properties.Appearance.Options.UseFont = True
        Me.txtPY_SubtractSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_SubtractSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_SubtractSum.Properties.Mask.EditMask = "f2"
        Me.txtPY_SubtractSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPY_SubtractSum.Size = New System.Drawing.Size(80, 24)
        Me.txtPY_SubtractSum.TabIndex = 56
        '
        'TxtPY_CompleteSum
        '
        Me.TxtPY_CompleteSum.Enabled = False
        Me.TxtPY_CompleteSum.Location = New System.Drawing.Point(714, 12)
        Me.TxtPY_CompleteSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.TxtPY_CompleteSum.Name = "TxtPY_CompleteSum"
        Me.TxtPY_CompleteSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPY_CompleteSum.Properties.Appearance.Options.UseFont = True
        Me.TxtPY_CompleteSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_CompleteSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_CompleteSum.Properties.Mask.EditMask = "f2"
        Me.TxtPY_CompleteSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPY_CompleteSum.Size = New System.Drawing.Size(80, 24)
        Me.TxtPY_CompleteSum.TabIndex = 58
        '
        'GB1
        '
        Me.GB1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB1.Controls.Add(Me.txtG_NO_InSum)
        Me.GB1.Controls.Add(Me.Label2)
        Me.GB1.Controls.Add(Me.LabPY_CompleteSum1)
        Me.GB1.Controls.Add(Me.LabelPY_PieceAllSum1)
        Me.GB1.Controls.Add(Me.TxtPY_CompleteSum)
        Me.GB1.Controls.Add(Me.txtPY_PieceAllSum)
        Me.GB1.Controls.Add(Me.TxtPY_TimeAllSum)
        Me.GB1.Controls.Add(Me.TxtPY_CompensateSum)
        Me.GB1.Controls.Add(Me.LabelPY_TimeAllSum1)
        Me.GB1.Controls.Add(Me.LabPY_CompensateSum1)
        Me.GB1.Location = New System.Drawing.Point(3, 79)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(806, 44)
        Me.GB1.TabIndex = 59
        Me.GB1.TabStop = False
        '
        'txtG_NO_InSum
        '
        Me.txtG_NO_InSum.Location = New System.Drawing.Point(546, 13)
        Me.txtG_NO_InSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtG_NO_InSum.Name = "txtG_NO_InSum"
        Me.txtG_NO_InSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtG_NO_InSum.Properties.Appearance.Options.UseFont = True
        Me.txtG_NO_InSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtG_NO_InSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtG_NO_InSum.Properties.Mask.EditMask = "f2"
        Me.txtG_NO_InSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtG_NO_InSum.Properties.ReadOnly = True
        Me.txtG_NO_InSum.Size = New System.Drawing.Size(80, 24)
        Me.txtG_NO_InSum.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "+ 轉入："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabPY_CompleteSum1
        '
        Me.LabPY_CompleteSum1.AutoSize = True
        Me.LabPY_CompleteSum1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPY_CompleteSum1.Location = New System.Drawing.Point(632, 15)
        Me.LabPY_CompleteSum1.Name = "LabPY_CompleteSum1"
        Me.LabPY_CompleteSum1.Size = New System.Drawing.Size(79, 15)
        Me.LabPY_CompleteSum1.TabIndex = 63
        Me.LabPY_CompleteSum1.Text = "= 完成額："
        Me.LabPY_CompleteSum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPY_PieceAllSum1
        '
        Me.LabelPY_PieceAllSum1.AutoSize = True
        Me.LabelPY_PieceAllSum1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPY_PieceAllSum1.Location = New System.Drawing.Point(5, 15)
        Me.LabelPY_PieceAllSum1.Name = "LabelPY_PieceAllSum1"
        Me.LabelPY_PieceAllSum1.Size = New System.Drawing.Size(52, 15)
        Me.LabelPY_PieceAllSum1.TabIndex = 59
        Me.LabelPY_PieceAllSum1.Text = "計件："
        Me.LabelPY_PieceAllSum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPY_TimeAllSum1
        '
        Me.LabelPY_TimeAllSum1.AutoSize = True
        Me.LabelPY_TimeAllSum1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPY_TimeAllSum1.Location = New System.Drawing.Point(154, 15)
        Me.LabelPY_TimeAllSum1.Name = "LabelPY_TimeAllSum1"
        Me.LabelPY_TimeAllSum1.Size = New System.Drawing.Size(98, 15)
        Me.LabelPY_TimeAllSum1.TabIndex = 60
        Me.LabelPY_TimeAllSum1.Text = "+  計時總額："
        Me.LabelPY_TimeAllSum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabPY_CompensateSum1
        '
        Me.LabPY_CompensateSum1.AutoSize = True
        Me.LabPY_CompensateSum1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPY_CompensateSum1.Location = New System.Drawing.Point(330, 17)
        Me.LabPY_CompensateSum1.Name = "LabPY_CompensateSum1"
        Me.LabPY_CompensateSum1.Size = New System.Drawing.Size(68, 15)
        Me.LabPY_CompensateSum1.TabIndex = 61
        Me.LabPY_CompensateSum1.Text = "+  應補："
        Me.LabPY_CompensateSum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtG_NO_OUTSum
        '
        Me.txtG_NO_OUTSum.Location = New System.Drawing.Point(247, 42)
        Me.txtG_NO_OUTSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtG_NO_OUTSum.Name = "txtG_NO_OUTSum"
        Me.txtG_NO_OUTSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtG_NO_OUTSum.Properties.Appearance.Options.UseFont = True
        Me.txtG_NO_OUTSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtG_NO_OUTSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtG_NO_OUTSum.Properties.Mask.EditMask = "f2"
        Me.txtG_NO_OUTSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtG_NO_OUTSum.Properties.ReadOnly = True
        Me.txtG_NO_OUTSum.Size = New System.Drawing.Size(80, 24)
        Me.txtG_NO_OUTSum.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "轉出："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabPY_SubtractSum1
        '
        Me.LabPY_SubtractSum1.AutoSize = True
        Me.LabPY_SubtractSum1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabPY_SubtractSum1.Location = New System.Drawing.Point(15, 44)
        Me.LabPY_SubtractSum1.Name = "LabPY_SubtractSum1"
        Me.LabPY_SubtractSum1.Size = New System.Drawing.Size(52, 15)
        Me.LabPY_SubtractSum1.TabIndex = 62
        Me.LabPY_SubtractSum1.Text = "應扣："
        Me.LabPY_SubtractSum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GB2
        '
        Me.GB2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB2.Controls.Add(Me.txtG_NO_OUTSum)
        Me.GB2.Controls.Add(Me.txtPY_Remark)
        Me.GB2.Controls.Add(Me.txtPY_PieceSum)
        Me.GB2.Controls.Add(Me.Label3)
        Me.GB2.Controls.Add(Me.LabPY_PieceSum)
        Me.GB2.Controls.Add(Me.txtPY_BonusSum)
        Me.GB2.Controls.Add(Me.LabPY_BonusSum)
        Me.GB2.Controls.Add(Me.txtPY_SubtractSum)
        Me.GB2.Controls.Add(Me.TxtPY_TimeSum)
        Me.GB2.Controls.Add(Me.LabelControl13)
        Me.GB2.Controls.Add(Me.LabPY_TimeSum)
        Me.GB2.Controls.Add(Me.LabelPY_UseSum)
        Me.GB2.Controls.Add(Me.TxtPY_UseSum)
        Me.GB2.Controls.Add(Me.LabPY_SubtractSum1)
        Me.GB2.Location = New System.Drawing.Point(3, 123)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(806, 102)
        Me.GB2.TabIndex = 60
        Me.GB2.TabStop = False
        '
        'txtPY_Remark
        '
        Me.txtPY_Remark.Location = New System.Drawing.Point(71, 70)
        Me.txtPY_Remark.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtPY_Remark.Name = "txtPY_Remark"
        Me.txtPY_Remark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPY_Remark.Properties.Appearance.Options.UseFont = True
        Me.txtPY_Remark.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_Remark.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_Remark.Properties.Mask.EditMask = "n0"
        Me.txtPY_Remark.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPY_Remark.Size = New System.Drawing.Size(579, 24)
        Me.txtPY_Remark.TabIndex = 66
        '
        'txtPY_PieceSum
        '
        Me.txtPY_PieceSum.Enabled = False
        Me.txtPY_PieceSum.Location = New System.Drawing.Point(717, 35)
        Me.txtPY_PieceSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtPY_PieceSum.Name = "txtPY_PieceSum"
        Me.txtPY_PieceSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPY_PieceSum.Properties.Appearance.Options.UseFont = True
        Me.txtPY_PieceSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_PieceSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_PieceSum.Size = New System.Drawing.Size(80, 24)
        Me.txtPY_PieceSum.TabIndex = 65
        '
        'LabPY_PieceSum
        '
        Me.LabPY_PieceSum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPY_PieceSum.Appearance.Options.UseFont = True
        Me.LabPY_PieceSum.Location = New System.Drawing.Point(651, 41)
        Me.LabPY_PieceSum.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabPY_PieceSum.Name = "LabPY_PieceSum"
        Me.LabPY_PieceSum.Size = New System.Drawing.Size(60, 15)
        Me.LabPY_PieceSum.TabIndex = 64
        Me.LabPY_PieceSum.Text = "計件額："
        '
        'txtPY_BonusSum
        '
        Me.txtPY_BonusSum.Enabled = False
        Me.txtPY_BonusSum.Location = New System.Drawing.Point(394, 13)
        Me.txtPY_BonusSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.txtPY_BonusSum.Name = "txtPY_BonusSum"
        Me.txtPY_BonusSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPY_BonusSum.Properties.Appearance.Options.UseFont = True
        Me.txtPY_BonusSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_BonusSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPY_BonusSum.Size = New System.Drawing.Size(80, 24)
        Me.txtPY_BonusSum.TabIndex = 63
        '
        'LabPY_BonusSum
        '
        Me.LabPY_BonusSum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPY_BonusSum.Appearance.Options.UseFont = True
        Me.LabPY_BonusSum.Location = New System.Drawing.Point(346, 19)
        Me.LabPY_BonusSum.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabPY_BonusSum.Name = "LabPY_BonusSum"
        Me.LabPY_BonusSum.Size = New System.Drawing.Size(45, 15)
        Me.LabPY_BonusSum.TabIndex = 62
        Me.LabPY_BonusSum.Text = "獎金："
        '
        'TxtPY_TimeSum
        '
        Me.TxtPY_TimeSum.Enabled = False
        Me.TxtPY_TimeSum.Location = New System.Drawing.Point(247, 13)
        Me.TxtPY_TimeSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.TxtPY_TimeSum.Name = "TxtPY_TimeSum"
        Me.TxtPY_TimeSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPY_TimeSum.Properties.Appearance.Options.UseFont = True
        Me.TxtPY_TimeSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_TimeSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_TimeSum.Size = New System.Drawing.Size(80, 24)
        Me.TxtPY_TimeSum.TabIndex = 61
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(17, 76)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(45, 15)
        Me.LabelControl13.TabIndex = 59
        Me.LabelControl13.Text = "備注："
        '
        'LabPY_TimeSum
        '
        Me.LabPY_TimeSum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPY_TimeSum.Appearance.Options.UseFont = True
        Me.LabPY_TimeSum.Location = New System.Drawing.Point(170, 17)
        Me.LabPY_TimeSum.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabPY_TimeSum.Name = "LabPY_TimeSum"
        Me.LabPY_TimeSum.Size = New System.Drawing.Size(75, 15)
        Me.LabPY_TimeSum.TabIndex = 53
        Me.LabPY_TimeSum.Text = "計時工資："
        '
        'LabelPY_UseSum
        '
        Me.LabelPY_UseSum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPY_UseSum.Appearance.Options.UseFont = True
        Me.LabelPY_UseSum.Location = New System.Drawing.Point(5, 19)
        Me.LabelPY_UseSum.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabelPY_UseSum.Name = "LabelPY_UseSum"
        Me.LabelPY_UseSum.Size = New System.Drawing.Size(60, 15)
        Me.LabelPY_UseSum.TabIndex = 51
        Me.LabelPY_UseSum.Text = "耗用額："
        '
        'TxtPY_UseSum
        '
        Me.TxtPY_UseSum.Location = New System.Drawing.Point(72, 13)
        Me.TxtPY_UseSum.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.TxtPY_UseSum.Name = "TxtPY_UseSum"
        Me.TxtPY_UseSum.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPY_UseSum.Properties.Appearance.Options.UseFont = True
        Me.TxtPY_UseSum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_UseSum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPY_UseSum.Properties.Mask.EditMask = "f2"
        Me.TxtPY_UseSum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPY_UseSum.Size = New System.Drawing.Size(80, 24)
        Me.TxtPY_UseSum.TabIndex = 52
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(3, 228)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemCalcEdit4, Me.RepositoryItemCalcEdit5, Me.RepositoryItemCalcEdit6, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCalcEdit7})
        Me.Grid1.Size = New System.Drawing.Size(806, 264)
        Me.Grid1.TabIndex = 61
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.ToolStripSeparator1, Me.PLUSToolStripMenuItem, Me.ToolStripMenuItem1, Me.RToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 82)
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources._24
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ADDToolStripMenuItem.Text = "上班天數加1(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'PLUSToolStripMenuItem
        '
        Me.PLUSToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources._21
        Me.PLUSToolStripMenuItem.Name = "PLUSToolStripMenuItem"
        Me.PLUSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PLUSToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PLUSToolStripMenuItem.Text = "上班天數減1(&P)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 6)
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.Image = Global.LFERP.My.Resources.Resources.Recurrence
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RToolStripMenuItem.Text = "還原上班天數(&R)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.Per_NO, Me.Per_Name, Me.PYS_FormulaID, Me.PYS_WorkWGDay, Me.Per_DayPrice, Me.PYS_OnDutyDays, Me.PYS_UsualOverTime, Me.PYS_HolidayOVerTime, Me.PYS_Proportion, Me.PYS_Bonus, Me.PYS_AllHours, Me.PYS_MeritedHours, Me.PYS_TimePay, Me.PYS_PiecePay, Me.Per_PayType, Me.PYS_MeritedPay, Me.PYS_Remark})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AutoID
        '
        Me.AutoID.Caption = "自編號"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.AllowSize = False
        Me.AutoID.Width = 80
        '
        'Per_NO
        '
        Me.Per_NO.Caption = "員工編號"
        Me.Per_NO.FieldName = "Per_NO"
        Me.Per_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Per_NO.Name = "Per_NO"
        Me.Per_NO.OptionsColumn.AllowEdit = False
        Me.Per_NO.OptionsColumn.AllowSize = False
        Me.Per_NO.SummaryItem.DisplayFormat = "共:{0} 人"
        Me.Per_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.Per_NO.Visible = True
        Me.Per_NO.VisibleIndex = 0
        Me.Per_NO.Width = 85
        '
        'Per_Name
        '
        Me.Per_Name.Caption = "員工姓名"
        Me.Per_Name.FieldName = "Per_Name"
        Me.Per_Name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Per_Name.Name = "Per_Name"
        Me.Per_Name.OptionsColumn.AllowEdit = False
        Me.Per_Name.OptionsColumn.AllowSize = False
        Me.Per_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Per_Name.Visible = True
        Me.Per_Name.VisibleIndex = 1
        Me.Per_Name.Width = 85
        '
        'PYS_FormulaID
        '
        Me.PYS_FormulaID.Caption = "計算公式"
        Me.PYS_FormulaID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.PYS_FormulaID.FieldName = "PYS_FormulaID"
        Me.PYS_FormulaID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.PYS_FormulaID.Name = "PYS_FormulaID"
        Me.PYS_FormulaID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_FormulaID.Visible = True
        Me.PYS_FormulaID.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormulaName", "工式編號", 100), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Formula", "工式名稱", 500)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'PYS_WorkWGDay
        '
        Me.PYS_WorkWGDay.Caption = "本組天數"
        Me.PYS_WorkWGDay.FieldName = "PYS_WorkWGDay"
        Me.PYS_WorkWGDay.Name = "PYS_WorkWGDay"
        Me.PYS_WorkWGDay.OptionsColumn.AllowEdit = False
        Me.PYS_WorkWGDay.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_WorkWGDay.Visible = True
        Me.PYS_WorkWGDay.VisibleIndex = 3
        Me.PYS_WorkWGDay.Width = 70
        '
        'Per_DayPrice
        '
        Me.Per_DayPrice.Caption = "日薪"
        Me.Per_DayPrice.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.Per_DayPrice.FieldName = "Per_DayPrice"
        Me.Per_DayPrice.Name = "Per_DayPrice"
        Me.Per_DayPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Per_DayPrice.Visible = True
        Me.Per_DayPrice.VisibleIndex = 5
        Me.Per_DayPrice.Width = 55
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'PYS_OnDutyDays
        '
        Me.PYS_OnDutyDays.Caption = "上班天數"
        Me.PYS_OnDutyDays.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.PYS_OnDutyDays.FieldName = "PYS_OnDutyDays"
        Me.PYS_OnDutyDays.Name = "PYS_OnDutyDays"
        Me.PYS_OnDutyDays.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_OnDutyDays.Visible = True
        Me.PYS_OnDutyDays.VisibleIndex = 6
        Me.PYS_OnDutyDays.Width = 85
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'PYS_UsualOverTime
        '
        Me.PYS_UsualOverTime.Caption = "平日加班"
        Me.PYS_UsualOverTime.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.PYS_UsualOverTime.FieldName = "PYS_UsualOverTime"
        Me.PYS_UsualOverTime.Name = "PYS_UsualOverTime"
        Me.PYS_UsualOverTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_UsualOverTime.Visible = True
        Me.PYS_UsualOverTime.VisibleIndex = 7
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'PYS_HolidayOVerTime
        '
        Me.PYS_HolidayOVerTime.Caption = "假日加班"
        Me.PYS_HolidayOVerTime.ColumnEdit = Me.RepositoryItemCalcEdit7
        Me.PYS_HolidayOVerTime.FieldName = "PYS_HolidayOVerTime"
        Me.PYS_HolidayOVerTime.Name = "PYS_HolidayOVerTime"
        Me.PYS_HolidayOVerTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_HolidayOVerTime.Visible = True
        Me.PYS_HolidayOVerTime.VisibleIndex = 8
        Me.PYS_HolidayOVerTime.Width = 85
        '
        'RepositoryItemCalcEdit7
        '
        Me.RepositoryItemCalcEdit7.AutoHeight = False
        Me.RepositoryItemCalcEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit7.Name = "RepositoryItemCalcEdit7"
        '
        'PYS_Proportion
        '
        Me.PYS_Proportion.Caption = "工時比例"
        Me.PYS_Proportion.ColumnEdit = Me.RepositoryItemCalcEdit5
        Me.PYS_Proportion.FieldName = "PYS_Proportion"
        Me.PYS_Proportion.Name = "PYS_Proportion"
        Me.PYS_Proportion.Visible = True
        Me.PYS_Proportion.VisibleIndex = 9
        Me.PYS_Proportion.Width = 85
        '
        'RepositoryItemCalcEdit5
        '
        Me.RepositoryItemCalcEdit5.AutoHeight = False
        Me.RepositoryItemCalcEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit5.Name = "RepositoryItemCalcEdit5"
        '
        'PYS_Bonus
        '
        Me.PYS_Bonus.Caption = "獎金"
        Me.PYS_Bonus.ColumnEdit = Me.RepositoryItemCalcEdit6
        Me.PYS_Bonus.FieldName = "PYS_Bonus"
        Me.PYS_Bonus.Name = "PYS_Bonus"
        Me.PYS_Bonus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_Bonus.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PYS_Bonus.Visible = True
        Me.PYS_Bonus.VisibleIndex = 10
        Me.PYS_Bonus.Width = 65
        '
        'RepositoryItemCalcEdit6
        '
        Me.RepositoryItemCalcEdit6.AutoHeight = False
        Me.RepositoryItemCalcEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit6.Name = "RepositoryItemCalcEdit6"
        '
        'PYS_AllHours
        '
        Me.PYS_AllHours.Caption = "總工時"
        Me.PYS_AllHours.FieldName = "PYS_AllHours"
        Me.PYS_AllHours.Name = "PYS_AllHours"
        Me.PYS_AllHours.OptionsColumn.AllowEdit = False
        Me.PYS_AllHours.OptionsColumn.AllowFocus = False
        Me.PYS_AllHours.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_AllHours.Visible = True
        Me.PYS_AllHours.VisibleIndex = 11
        '
        'PYS_MeritedHours
        '
        Me.PYS_MeritedHours.Caption = "應計工時"
        Me.PYS_MeritedHours.FieldName = "PYS_MeritedHours"
        Me.PYS_MeritedHours.Name = "PYS_MeritedHours"
        Me.PYS_MeritedHours.OptionsColumn.AllowEdit = False
        Me.PYS_MeritedHours.OptionsColumn.AllowFocus = False
        Me.PYS_MeritedHours.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PYS_MeritedHours.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PYS_MeritedHours.Visible = True
        Me.PYS_MeritedHours.VisibleIndex = 12
        Me.PYS_MeritedHours.Width = 85
        '
        'PYS_TimePay
        '
        Me.PYS_TimePay.Caption = "計時工資"
        Me.PYS_TimePay.FieldName = "PYS_TimePay"
        Me.PYS_TimePay.Name = "PYS_TimePay"
        Me.PYS_TimePay.OptionsColumn.AllowEdit = False
        Me.PYS_TimePay.OptionsColumn.AllowFocus = False
        Me.PYS_TimePay.Visible = True
        Me.PYS_TimePay.VisibleIndex = 13
        Me.PYS_TimePay.Width = 85
        '
        'PYS_PiecePay
        '
        Me.PYS_PiecePay.Caption = "計件工資"
        Me.PYS_PiecePay.FieldName = "PYS_PiecePay"
        Me.PYS_PiecePay.Name = "PYS_PiecePay"
        Me.PYS_PiecePay.OptionsColumn.AllowEdit = False
        Me.PYS_PiecePay.OptionsColumn.AllowFocus = False
        Me.PYS_PiecePay.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PYS_PiecePay.SummaryItem.Tag = "DSA"
        Me.PYS_PiecePay.Visible = True
        Me.PYS_PiecePay.VisibleIndex = 14
        Me.PYS_PiecePay.Width = 85
        '
        'Per_PayType
        '
        Me.Per_PayType.Caption = "薪金類型"
        Me.Per_PayType.FieldName = "Per_PayType"
        Me.Per_PayType.Name = "Per_PayType"
        Me.Per_PayType.OptionsColumn.AllowEdit = False
        Me.Per_PayType.OptionsColumn.AllowFocus = False
        Me.Per_PayType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Per_PayType.Visible = True
        Me.Per_PayType.VisibleIndex = 4
        Me.Per_PayType.Width = 70
        '
        'PYS_MeritedPay
        '
        Me.PYS_MeritedPay.Caption = "應得工資"
        Me.PYS_MeritedPay.FieldName = "PYS_MeritedPay"
        Me.PYS_MeritedPay.Name = "PYS_MeritedPay"
        Me.PYS_MeritedPay.OptionsColumn.AllowEdit = False
        Me.PYS_MeritedPay.OptionsColumn.AllowFocus = False
        Me.PYS_MeritedPay.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PYS_MeritedPay.Visible = True
        Me.PYS_MeritedPay.VisibleIndex = 15
        Me.PYS_MeritedPay.Width = 85
        '
        'PYS_Remark
        '
        Me.PYS_Remark.Caption = "備注"
        Me.PYS_Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.PYS_Remark.FieldName = "PYS_Remark"
        Me.PYS_Remark.Name = "PYS_Remark"
        Me.PYS_Remark.Visible = True
        Me.PYS_Remark.VisibleIndex = 16
        Me.PYS_Remark.Width = 65
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LFERP.My.Resources.Resources.SharingRequestDeny
        Me.btnCancel.Location = New System.Drawing.Point(725, 547)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = Global.LFERP.My.Resources.Resources.SharingRequestAllow
        Me.btnOK.Location = New System.Drawing.Point(626, 547)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 62
        Me.btnOK.Text = "確定(&O)"
        '
        'SButtonSum
        '
        Me.SButtonSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SButtonSum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SButtonSum.Appearance.Options.UseFont = True
        Me.SButtonSum.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.SButtonSum.Location = New System.Drawing.Point(526, 547)
        Me.SButtonSum.Name = "SButtonSum"
        Me.SButtonSum.Size = New System.Drawing.Size(80, 28)
        Me.SButtonSum.TabIndex = 64
        Me.SButtonSum.Text = "計算(&Q)"
        '
        'ButtonDetail
        '
        Me.ButtonDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDetail.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDetail.Appearance.Options.UseFont = True
        Me.ButtonDetail.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.ButtonDetail.Location = New System.Drawing.Point(412, 547)
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.Size = New System.Drawing.Size(80, 28)
        Me.ButtonDetail.TabIndex = 65
        Me.ButtonDetail.Text = "詳細(&D)"
        '
        'chkPY_Check
        '
        Me.chkPY_Check.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkPY_Check.Location = New System.Drawing.Point(12, 555)
        Me.chkPY_Check.Name = "chkPY_Check"
        Me.chkPY_Check.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.chkPY_Check.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPY_Check.Properties.Appearance.Options.UseBackColor = True
        Me.chkPY_Check.Properties.Appearance.Options.UseFont = True
        Me.chkPY_Check.Properties.Caption = "審核(&K)"
        Me.chkPY_Check.Size = New System.Drawing.Size(83, 20)
        Me.chkPY_Check.TabIndex = 66
        '
        'LabPY_ID
        '
        Me.LabPY_ID.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPY_ID.Appearance.Options.UseFont = True
        Me.LabPY_ID.Location = New System.Drawing.Point(397, 12)
        Me.LabPY_ID.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LabPY_ID.Name = "LabPY_ID"
        Me.LabPY_ID.Size = New System.Drawing.Size(30, 15)
        Me.LabPY_ID.TabIndex = 67
        Me.LabPY_ID.Text = "編號"
        Me.LabPY_ID.Visible = False
        '
        'GB4
        '
        Me.GB4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB4.Controls.Add(Me.txtMeritedPaySum)
        Me.GB4.Controls.Add(Me.labMeritedPaySum)
        Me.GB4.Controls.Add(Me.txtBonusSum)
        Me.GB4.Controls.Add(Me.labBonus)
        Me.GB4.Controls.Add(Me.txtPiecePaySum)
        Me.GB4.Controls.Add(Me.labPiecePaySum)
        Me.GB4.Controls.Add(Me.txtMeritedHoursSum)
        Me.GB4.Controls.Add(Me.labMeritedHoursSum)
        Me.GB4.Controls.Add(Me.Label1)
        Me.GB4.Location = New System.Drawing.Point(6, 490)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(800, 48)
        Me.GB4.TabIndex = 68
        Me.GB4.TabStop = False
        '
        'txtMeritedPaySum
        '
        Me.txtMeritedPaySum.Enabled = False
        Me.txtMeritedPaySum.Location = New System.Drawing.Point(578, 14)
        Me.txtMeritedPaySum.Name = "txtMeritedPaySum"
        Me.txtMeritedPaySum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeritedPaySum.Properties.Appearance.Options.UseFont = True
        Me.txtMeritedPaySum.Size = New System.Drawing.Size(75, 25)
        Me.txtMeritedPaySum.TabIndex = 8
        '
        'labMeritedPaySum
        '
        Me.labMeritedPaySum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labMeritedPaySum.Appearance.Options.UseFont = True
        Me.labMeritedPaySum.Location = New System.Drawing.Point(502, 20)
        Me.labMeritedPaySum.Name = "labMeritedPaySum"
        Me.labMeritedPaySum.Size = New System.Drawing.Size(64, 15)
        Me.labMeritedPaySum.TabIndex = 7
        Me.labMeritedPaySum.Text = "應得工資:"
        '
        'txtBonusSum
        '
        Me.txtBonusSum.Enabled = False
        Me.txtBonusSum.Location = New System.Drawing.Point(410, 14)
        Me.txtBonusSum.Name = "txtBonusSum"
        Me.txtBonusSum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonusSum.Properties.Appearance.Options.UseFont = True
        Me.txtBonusSum.Size = New System.Drawing.Size(75, 25)
        Me.txtBonusSum.TabIndex = 6
        '
        'labBonus
        '
        Me.labBonus.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labBonus.Appearance.Options.UseFont = True
        Me.labBonus.Location = New System.Drawing.Point(365, 20)
        Me.labBonus.Name = "labBonus"
        Me.labBonus.Size = New System.Drawing.Size(34, 15)
        Me.labBonus.TabIndex = 5
        Me.labBonus.Text = "獎金:"
        '
        'txtPiecePaySum
        '
        Me.txtPiecePaySum.Enabled = False
        Me.txtPiecePaySum.Location = New System.Drawing.Point(274, 15)
        Me.txtPiecePaySum.Name = "txtPiecePaySum"
        Me.txtPiecePaySum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiecePaySum.Properties.Appearance.Options.UseFont = True
        Me.txtPiecePaySum.Size = New System.Drawing.Size(75, 25)
        Me.txtPiecePaySum.TabIndex = 4
        '
        'labPiecePaySum
        '
        Me.labPiecePaySum.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labPiecePaySum.Appearance.Options.UseFont = True
        Me.labPiecePaySum.Location = New System.Drawing.Point(207, 20)
        Me.labPiecePaySum.Name = "labPiecePaySum"
        Me.labPiecePaySum.Size = New System.Drawing.Size(64, 15)
        Me.labPiecePaySum.TabIndex = 3
        Me.labPiecePaySum.Text = "計件工資:"
        '
        'txtMeritedHoursSum
        '
        Me.txtMeritedHoursSum.Enabled = False
        Me.txtMeritedHoursSum.Location = New System.Drawing.Point(122, 14)
        Me.txtMeritedHoursSum.Name = "txtMeritedHoursSum"
        Me.txtMeritedHoursSum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeritedHoursSum.Properties.Appearance.Options.UseFont = True
        Me.txtMeritedHoursSum.Size = New System.Drawing.Size(75, 25)
        Me.txtMeritedHoursSum.TabIndex = 2
        '
        'labMeritedHoursSum
        '
        Me.labMeritedHoursSum.AutoSize = True
        Me.labMeritedHoursSum.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labMeritedHoursSum.Location = New System.Drawing.Point(54, 20)
        Me.labMeritedHoursSum.Name = "labMeritedHoursSum"
        Me.labMeritedHoursSum.Size = New System.Drawing.Size(71, 15)
        Me.labMeritedHoursSum.TabIndex = 1
        Me.labMeritedHoursSum.Text = "應計工時:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "合計:"
        '
        'frmProductionPiecePayGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(812, 585)
        Me.Controls.Add(Me.LabPY_ID)
        Me.Controls.Add(Me.chkPY_Check)
        Me.Controls.Add(Me.ButtonDetail)
        Me.Controls.Add(Me.SButtonSum)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.DatePY_YYMM)
        Me.Controls.Add(Me.LabelPY_YYMM)
        Me.Controls.Add(Me.LabelCaption)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gb3)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.GB2)
        Me.Name = "frmProductionPiecePayGroup"
        Me.Text = "承包計件薪金"
        CType(Me.DatePY_YYMM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        CType(Me.txtG_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPY_PieceAllSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPY_TimeAllSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPY_CompensateSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPY_SubtractSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPY_CompleteSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.txtG_NO_InSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtG_NO_OUTSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        CType(Me.txtPY_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPY_PieceSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPY_BonusSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPY_TimeSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPY_UseSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPY_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB4.ResumeLayout(False)
        Me.GB4.PerformLayout()
        CType(Me.txtMeritedPaySum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBonusSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPiecePaySum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMeritedHoursSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatePY_YYMM As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelPY_YYMM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents labG_NO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabG_Name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtG_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFacID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPY_PieceAllSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPY_TimeAllSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPY_CompensateSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPY_SubtractSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPY_CompleteSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabPY_TimeSum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelPY_UseSum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPY_UseSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Per_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_FormulaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_OnDutyDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_UsualOverTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_HolidayOVerTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_Proportion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_Bonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_AllHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_MeritedHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_TimePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_PiecePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_MeritedPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SButtonSum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkPY_Check As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPY_PieceSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabPY_PieceSum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPY_BonusSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabPY_BonusSum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPY_TimeSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PYS_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabPY_ID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtG_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPY_Remark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Per_DayPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PYS_WorkWGDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Per_PayType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GB4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMeritedHoursSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labMeritedHoursSum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labBonus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPiecePaySum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labPiecePaySum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMeritedPaySum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labMeritedPaySum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBonusSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabPY_CompleteSum1 As System.Windows.Forms.Label
    Friend WithEvents LabPY_SubtractSum1 As System.Windows.Forms.Label
    Friend WithEvents LabPY_CompensateSum1 As System.Windows.Forms.Label
    Friend WithEvents LabelPY_TimeAllSum1 As System.Windows.Forms.Label
    Friend WithEvents LabelPY_PieceAllSum1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCalcEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ADDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PLUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtG_NO_OUTSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtG_NO_InSum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
