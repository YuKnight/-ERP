<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeWareOutSub
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtWIPID = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtAPNO = New DevExpress.XtraEditors.TextEdit
        Me.gluDepID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DepID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtOPNO = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ButtonEdit2 = New DevExpress.XtraEditors.ButtonEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sk = New DevExpress.XtraEditors.SimpleButton
        Me.txtWH = New DevExpress.XtraEditors.ButtonEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.popWareInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popApplyAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutBarAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popLoadBatchAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popLoadBatchAllAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popWareOutDel = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AP_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rtxtAP_NO = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.M_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RemarkItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.WO_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.M_SendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SafeQty_Show = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_EndQty_Show = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Enable_Qty_Show = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SReQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WO_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.OS_BatchID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Temp_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.MCodeText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemButtonEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.CheckAction = New System.Windows.Forms.Label
        Me.CheckDate = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckRemark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.txtrecheckaction = New System.Windows.Forms.Label
        Me.txtrecheckdate = New System.Windows.Forms.Label
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtrecheckremark = New DevExpress.XtraEditors.MemoEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridFile = New System.Windows.Forms.DataGridView
        Me.F_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_OldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_AddDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_Action = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.popFileShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popFileShowOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbKnifeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWIPID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluDepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOPNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popWareInput.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtxtAP_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrecheckremark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popFileShow.SuspendLayout()
        CType(Me.cbKnifeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(853, 36)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "刀具出庫單"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(267, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "批次判斷"
        Me.Label6.Visible = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(340, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "新卡機工號"
        Me.Label12.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(421, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "類型"
        Me.Label3.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(464, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "操作員"
        Me.Label15.Visible = False
        '
        'txtWIPID
        '
        Me.txtWIPID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWIPID.Location = New System.Drawing.Point(745, 6)
        Me.txtWIPID.Name = "txtWIPID"
        Me.txtWIPID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtWIPID.Properties.Appearance.Options.UseFont = True
        Me.txtWIPID.Properties.ReadOnly = True
        Me.txtWIPID.Size = New System.Drawing.Size(104, 22)
        Me.txtWIPID.TabIndex = 195
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(677, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 194
        Me.Label20.Text = "出庫單號："
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(293, 78)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Size = New System.Drawing.Size(180, 21)
        ToolTipTitleItem2.Text = "提示"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "焦點在物料編碼輸入框中：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下Home鍵，焦點移到表格焦點行數量單元格中；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下PageUp鍵，表格中焦點行數量加一；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下PageDown鍵，表格中焦點行" & _
            "數量減一；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下向上的方向鍵，表格中焦點行上移一行，並且焦點落在數量單元格中；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下向下的方向鍵，表格中焦點行下移一行，並且焦點落在數量單元格中。"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtM_Code.SuperTip = SuperToolTip2
        Me.txtM_Code.TabIndex = 214
        Me.txtM_Code.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(475, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl1.TabIndex = 216
        Me.LabelControl1.Text = "(可掃描條碼輸入)"
        Me.LabelControl1.Visible = False
        '
        'txtAPNO
        '
        Me.txtAPNO.Location = New System.Drawing.Point(84, 79)
        Me.txtAPNO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAPNO.Name = "txtAPNO"
        Me.txtAPNO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPNO.Properties.Appearance.Options.UseFont = True
        Me.txtAPNO.Size = New System.Drawing.Size(120, 22)
        Me.txtAPNO.TabIndex = 211
        Me.txtAPNO.Visible = False
        '
        'gluDepID
        '
        Me.gluDepID.EditValue = ""
        Me.gluDepID.Location = New System.Drawing.Point(84, 79)
        Me.gluDepID.Margin = New System.Windows.Forms.Padding(6)
        Me.gluDepID.Name = "gluDepID"
        Me.gluDepID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gluDepID.Properties.Appearance.Options.UseFont = True
        Me.gluDepID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluDepID.Properties.NullText = ""
        Me.gluDepID.Properties.View = Me.GridLookUpEdit1View
        Me.gluDepID.Size = New System.Drawing.Size(120, 22)
        Me.gluDepID.TabIndex = 213
        Me.gluDepID.Visible = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DepID, Me.FacName, Me.DepName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowColumnMoving = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'DepID
        '
        Me.DepID.Caption = "部門編號"
        Me.DepID.FieldName = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.OptionsColumn.ReadOnly = True
        Me.DepID.Visible = True
        Me.DepID.VisibleIndex = 0
        '
        'FacName
        '
        Me.FacName.Caption = "廠別名稱"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.OptionsColumn.ReadOnly = True
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 1
        '
        'DepName
        '
        Me.DepName.Caption = "部門名稱"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.OptionsColumn.ReadOnly = True
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 2
        '
        'txtOPNO
        '
        Me.txtOPNO.Location = New System.Drawing.Point(508, 45)
        Me.txtOPNO.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOPNO.Name = "txtOPNO"
        Me.txtOPNO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPNO.Properties.Appearance.Options.UseFont = True
        Me.txtOPNO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOPNO.Size = New System.Drawing.Size(120, 22)
        Me.txtOPNO.TabIndex = 207
        Me.txtOPNO.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(494, 11)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(120, 22)
        Me.TextEdit1.TabIndex = 201
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(84, 45)
        Me.DateEdit1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(120, 22)
        Me.DateEdit1.TabIndex = 210
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(422, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 200
        Me.Label5.Text = "領料人(&N)："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(426, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 206
        Me.Label16.Text = "單        號(&B)："
        Me.Label16.Visible = False
        '
        'ButtonEdit2
        '
        Me.ButtonEdit2.Location = New System.Drawing.Point(293, 11)
        Me.ButtonEdit2.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonEdit2.Name = "ButtonEdit2"
        Me.ButtonEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit2.Properties.Appearance.Options.UseFont = True
        Me.ButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ButtonEdit2.Size = New System.Drawing.Size(120, 22)
        Me.ButtonEdit2.TabIndex = 199
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(630, 84)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(53, 22)
        Me.SimpleButton1.TabIndex = 203
        Me.SimpleButton1.Text = "導入(&L)"
        Me.SimpleButton1.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(207, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 13)
        Me.Label24.TabIndex = 212
        Me.Label24.Text = "物料編碼(&M)："
        Me.Label24.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(1, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 13)
        Me.Label23.TabIndex = 209
        Me.Label23.Text = "收料部門(&Q)："
        Me.Label23.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 208
        Me.Label11.Text = "出庫日期(&E)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(211, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "部        門(&D)："
        '
        'cbType
        '
        Me.cbType.Location = New System.Drawing.Point(721, 45)
        Me.cbType.Margin = New System.Windows.Forms.Padding(6)
        Me.cbType.Name = "cbType"
        Me.cbType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbType.Properties.Appearance.Options.UseFont = True
        Me.cbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbType.Properties.Items.AddRange(New Object() {"正常", "生產開料", "生產出貨", "生產派工單"})
        Me.cbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbType.Size = New System.Drawing.Size(120, 22)
        Me.cbType.TabIndex = 205
        Me.cbType.Visible = False
        '
        'sk
        '
        Me.sk.Location = New System.Drawing.Point(250, 45)
        Me.sk.Name = "sk"
        Me.sk.Size = New System.Drawing.Size(53, 22)
        Me.sk.TabIndex = 202
        Me.sk.Text = "刷卡(&S)"
        '
        'txtWH
        '
        Me.txtWH.Location = New System.Drawing.Point(84, 11)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWH.Properties.Appearance.Options.UseFont = True
        Me.txtWH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtWH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtWH.Size = New System.Drawing.Size(120, 22)
        Me.txtWH.TabIndex = 197
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(638, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 204
        Me.Label14.Text = "類         型(&T)："
        Me.Label14.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 13)
        Me.Label22.TabIndex = 196
        Me.Label22.Text = "倉      庫(&W)："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "申領單號(&T)："
        Me.Label13.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 110)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(853, 297)
        Me.XtraTabControl1.TabIndex = 217
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(844, 265)
        Me.XtraTabPage1.Text = "物料明細"
        '
        'Grid
        '
        Me.Grid.ContextMenuStrip = Me.popWareInput
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RemarkItemMemoExEdit1, Me.QtyItemCalcEdit, Me.RepositoryItemCheckEdit1, Me.RepositoryItemButtonEdit2, Me.MCodeText, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemButtonEdit3, Me.RepositoryItemButtonEdit4, Me.RepositoryItemGridLookUpEdit1, Me.rtxtAP_NO})
        Me.Grid.Size = New System.Drawing.Size(844, 265)
        Me.Grid.TabIndex = 160
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'popWareInput
        '
        Me.popWareInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popApplyAdd, Me.popWareOutAdd, Me.popWareOutBarAdd, Me.popLoadBatchAdd, Me.popLoadBatchAllAdd, Me.popWareOutDel})
        Me.popWareInput.Name = "popWareInput"
        Me.popWareInput.Size = New System.Drawing.Size(203, 136)
        '
        'popApplyAdd
        '
        Me.popApplyAdd.Name = "popApplyAdd"
        Me.popApplyAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.popApplyAdd.Size = New System.Drawing.Size(202, 22)
        Me.popApplyAdd.Text = "導入申領單(&C)..."
        Me.popApplyAdd.Visible = False
        '
        'popWareOutAdd
        '
        Me.popWareOutAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popWareOutAdd.Name = "popWareOutAdd"
        Me.popWareOutAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popWareOutAdd.Size = New System.Drawing.Size(202, 22)
        Me.popWareOutAdd.Text = "新增(&A)..."
        '
        'popWareOutBarAdd
        '
        Me.popWareOutBarAdd.Name = "popWareOutBarAdd"
        Me.popWareOutBarAdd.Size = New System.Drawing.Size(202, 22)
        Me.popWareOutBarAdd.Text = "掃描條碼(&S)..."
        Me.popWareOutBarAdd.Visible = False
        '
        'popLoadBatchAdd
        '
        Me.popLoadBatchAdd.Name = "popLoadBatchAdd"
        Me.popLoadBatchAdd.Size = New System.Drawing.Size(202, 22)
        Me.popLoadBatchAdd.Text = "批次(單物料)導入(&M)..."
        Me.popLoadBatchAdd.Visible = False
        '
        'popLoadBatchAllAdd
        '
        Me.popLoadBatchAllAdd.Name = "popLoadBatchAllAdd"
        Me.popLoadBatchAllAdd.Size = New System.Drawing.Size(202, 22)
        Me.popLoadBatchAllAdd.Text = "批次(所有庫存)導入(&W)..."
        Me.popLoadBatchAllAdd.Visible = False
        '
        'popWareOutDel
        '
        Me.popWareOutDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popWareOutDel.Name = "popWareOutDel"
        Me.popWareOutDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popWareOutDel.Size = New System.Drawing.Size(202, 22)
        Me.popWareOutDel.Text = "刪除(&D)"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AP_NO, Me.M_ID, Me.M_Code, Me.M_Name, Me.M_Gauge, Me.PS_NO, Me.PS_Name, Me.WO_Qty, Me.M_SendQty, Me.C_Qty, Me.M_Unit, Me.WI_SafeQty_Show, Me.WO_EndQty_Show, Me.Enable_Qty_Show, Me.WI_SQty, Me.WI_SReQty, Me.WO_Remark, Me.OS_BatchID, Me.Temp_Code, Me.PM_M_Code})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AP_NO
        '
        Me.AP_NO.Caption = "申領單號"
        Me.AP_NO.ColumnEdit = Me.rtxtAP_NO
        Me.AP_NO.FieldName = "AP_NO"
        Me.AP_NO.Name = "AP_NO"
        Me.AP_NO.Width = 90
        '
        'rtxtAP_NO
        '
        Me.rtxtAP_NO.AutoHeight = False
        Me.rtxtAP_NO.Name = "rtxtAP_NO"
        '
        'M_ID
        '
        Me.M_ID.Caption = "項次"
        Me.M_ID.FieldName = "M_ID"
        Me.M_ID.Name = "M_ID"
        Me.M_ID.OptionsColumn.ReadOnly = True
        Me.M_ID.Width = 46
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編碼"
        Me.M_Code.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.OptionsColumn.ReadOnly = True
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 142
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'M_Name
        '
        Me.M_Name.Caption = "刀具名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.OptionsColumn.AllowEdit = False
        Me.M_Name.OptionsColumn.ReadOnly = True
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 95
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.ColumnEdit = Me.RemarkItemMemoExEdit1
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.OptionsColumn.ReadOnly = True
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 122
        '
        'RemarkItemMemoExEdit1
        '
        Me.RemarkItemMemoExEdit1.AutoHeight = False
        Me.RemarkItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemarkItemMemoExEdit1.Name = "RemarkItemMemoExEdit1"
        Me.RemarkItemMemoExEdit1.ShowIcon = False
        '
        'PS_NO
        '
        Me.PS_NO.Caption = "工序編號"
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        '
        'PS_Name
        '
        Me.PS_Name.Caption = "工序名稱"
        Me.PS_Name.ColumnEdit = Me.RepositoryItemButtonEdit3
        Me.PS_Name.FieldName = "PS_Name"
        Me.PS_Name.Name = "PS_Name"
        Me.PS_Name.OptionsColumn.ReadOnly = True
        Me.PS_Name.Width = 100
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        '
        'WO_Qty
        '
        Me.WO_Qty.Caption = "數量"
        Me.WO_Qty.ColumnEdit = Me.QtyItemCalcEdit
        Me.WO_Qty.FieldName = "WO_Qty"
        Me.WO_Qty.Name = "WO_Qty"
        Me.WO_Qty.ToolTip = "按Enter鍵，焦點回到物料編碼輸入框。"
        Me.WO_Qty.Visible = True
        Me.WO_Qty.VisibleIndex = 3
        Me.WO_Qty.Width = 70
        '
        'QtyItemCalcEdit
        '
        Me.QtyItemCalcEdit.AutoHeight = False
        Me.QtyItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyItemCalcEdit.Mask.EditMask = "n0"
        Me.QtyItemCalcEdit.Name = "QtyItemCalcEdit"
        Me.QtyItemCalcEdit.NullText = "0"
        '
        'M_SendQty
        '
        Me.M_SendQty.Caption = "已發數量"
        Me.M_SendQty.FieldName = "M_SendQty"
        Me.M_SendQty.Name = "M_SendQty"
        Me.M_SendQty.OptionsColumn.ReadOnly = True
        Me.M_SendQty.Width = 65
        '
        'C_Qty
        '
        Me.C_Qty.Caption = "開料數量"
        Me.C_Qty.FieldName = "C_Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.OptionsColumn.ReadOnly = True
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.OptionsColumn.AllowEdit = False
        Me.M_Unit.OptionsColumn.ReadOnly = True
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 4
        Me.M_Unit.Width = 60
        '
        'WI_SafeQty_Show
        '
        Me.WI_SafeQty_Show.Caption = "安全庫存"
        Me.WI_SafeQty_Show.FieldName = "WI_SafeQty_Show"
        Me.WI_SafeQty_Show.Name = "WI_SafeQty_Show"
        Me.WI_SafeQty_Show.OptionsColumn.AllowEdit = False
        Me.WI_SafeQty_Show.OptionsColumn.AllowFocus = False
        Me.WI_SafeQty_Show.Width = 65
        '
        'WO_EndQty_Show
        '
        Me.WO_EndQty_Show.Caption = "結余數"
        Me.WO_EndQty_Show.FieldName = "WO_EndQty_Show"
        Me.WO_EndQty_Show.Name = "WO_EndQty_Show"
        Me.WO_EndQty_Show.OptionsColumn.AllowEdit = False
        Me.WO_EndQty_Show.OptionsColumn.AllowFocus = False
        Me.WO_EndQty_Show.Width = 63
        '
        'Enable_Qty_Show
        '
        Me.Enable_Qty_Show.Caption = "可用庫存"
        Me.Enable_Qty_Show.FieldName = "Enable_Qty_Show"
        Me.Enable_Qty_Show.Name = "Enable_Qty_Show"
        Me.Enable_Qty_Show.OptionsColumn.ReadOnly = True
        Me.Enable_Qty_Show.Visible = True
        Me.Enable_Qty_Show.VisibleIndex = 5
        '
        'WI_SQty
        '
        Me.WI_SQty.Caption = "新刀數量"
        Me.WI_SQty.FieldName = "WI_SQty"
        Me.WI_SQty.Name = "WI_SQty"
        Me.WI_SQty.OptionsColumn.ReadOnly = True
        Me.WI_SQty.Visible = True
        Me.WI_SQty.VisibleIndex = 7
        '
        'WI_SReQty
        '
        Me.WI_SReQty.Caption = "待處理刀數量"
        Me.WI_SReQty.FieldName = "WI_SReQty"
        Me.WI_SReQty.Name = "WI_SReQty"
        Me.WI_SReQty.OptionsColumn.ReadOnly = True
        Me.WI_SReQty.Visible = True
        Me.WI_SReQty.VisibleIndex = 8
        Me.WI_SReQty.Width = 85
        '
        'WO_Remark
        '
        Me.WO_Remark.Caption = "備註"
        Me.WO_Remark.ColumnEdit = Me.RepositoryItemComboBox1
        Me.WO_Remark.FieldName = "WO_Remark"
        Me.WO_Remark.Name = "WO_Remark"
        Me.WO_Remark.Visible = True
        Me.WO_Remark.VisibleIndex = 6
        Me.WO_Remark.Width = 198
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"申領人員寫錯,倉庫發實物"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'OS_BatchID
        '
        Me.OS_BatchID.Caption = "批次編號"
        Me.OS_BatchID.FieldName = "OS_BatchID"
        Me.OS_BatchID.Name = "OS_BatchID"
        Me.OS_BatchID.Width = 100
        '
        'Temp_Code
        '
        Me.Temp_Code.Caption = "臨時編碼"
        Me.Temp_Code.FieldName = "Temp_Code"
        Me.Temp_Code.Name = "Temp_Code"
        Me.Temp_Code.OptionsColumn.ReadOnly = True
        Me.Temp_Code.Width = 92
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'MCodeText
        '
        Me.MCodeText.AutoHeight = False
        Me.MCodeText.Name = "MCodeText"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemButtonEdit4
        '
        Me.RepositoryItemButtonEdit4.AutoHeight = False
        Me.RepositoryItemButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit4.Name = "RepositoryItemButtonEdit4"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.CheckAction)
        Me.XtraTabPage2.Controls.Add(Me.CheckDate)
        Me.XtraTabPage2.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.CheckRemark)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(844, 265)
        Me.XtraTabPage2.Text = "審核信息"
        '
        'CheckAction
        '
        Me.CheckAction.AutoSize = True
        Me.CheckAction.BackColor = System.Drawing.Color.Transparent
        Me.CheckAction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckAction.ForeColor = System.Drawing.Color.Black
        Me.CheckAction.Location = New System.Drawing.Point(366, 36)
        Me.CheckAction.Name = "CheckAction"
        Me.CheckAction.Size = New System.Drawing.Size(71, 15)
        Me.CheckAction.TabIndex = 87
        Me.CheckAction.Text = "審核日期:"
        '
        'CheckDate
        '
        Me.CheckDate.AutoSize = True
        Me.CheckDate.BackColor = System.Drawing.Color.Transparent
        Me.CheckDate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckDate.ForeColor = System.Drawing.Color.Black
        Me.CheckDate.Location = New System.Drawing.Point(564, 36)
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Size = New System.Drawing.Size(71, 15)
        Me.CheckDate.TabIndex = 86
        Me.CheckDate.Text = "審核日期:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(83, 35)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "確認"
        Me.CheckEdit1.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(487, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "審核日期:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(292, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "審核員:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "備註(&R):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "審核(&K):"
        '
        'CheckRemark
        '
        Me.CheckRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckRemark.Location = New System.Drawing.Point(83, 75)
        Me.CheckRemark.Name = "CheckRemark"
        Me.CheckRemark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckRemark.Properties.Appearance.Options.UseFont = True
        Me.CheckRemark.Size = New System.Drawing.Size(644, 161)
        Me.CheckRemark.TabIndex = 20
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.txtrecheckaction)
        Me.XtraTabPage3.Controls.Add(Me.txtrecheckdate)
        Me.XtraTabPage3.Controls.Add(Me.CheckEdit2)
        Me.XtraTabPage3.Controls.Add(Me.Label17)
        Me.XtraTabPage3.Controls.Add(Me.Label18)
        Me.XtraTabPage3.Controls.Add(Me.Label19)
        Me.XtraTabPage3.Controls.Add(Me.Label21)
        Me.XtraTabPage3.Controls.Add(Me.txtrecheckremark)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageVisible = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(844, 265)
        Me.XtraTabPage3.Text = "復核信息"
        '
        'txtrecheckaction
        '
        Me.txtrecheckaction.AutoSize = True
        Me.txtrecheckaction.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckaction.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckaction.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckaction.Location = New System.Drawing.Point(357, 33)
        Me.txtrecheckaction.Name = "txtrecheckaction"
        Me.txtrecheckaction.Size = New System.Drawing.Size(52, 15)
        Me.txtrecheckaction.TabIndex = 95
        Me.txtrecheckaction.Text = "復核員"
        '
        'txtrecheckdate
        '
        Me.txtrecheckdate.AutoSize = True
        Me.txtrecheckdate.BackColor = System.Drawing.Color.Transparent
        Me.txtrecheckdate.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckdate.ForeColor = System.Drawing.Color.Black
        Me.txtrecheckdate.Location = New System.Drawing.Point(559, 33)
        Me.txtrecheckdate.Name = "txtrecheckdate"
        Me.txtrecheckdate.Size = New System.Drawing.Size(67, 15)
        Me.txtrecheckdate.TabIndex = 94
        Me.txtrecheckdate.Text = "復核日期"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(85, 33)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "確認"
        Me.CheckEdit2.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit2.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(485, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 15)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "復核日期:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(296, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 15)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "復核員:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(19, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 15)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "備註(&R):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(18, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 15)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "復核(&K):"
        '
        'txtrecheckremark
        '
        Me.txtrecheckremark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrecheckremark.Location = New System.Drawing.Point(85, 78)
        Me.txtrecheckremark.Name = "txtrecheckremark"
        Me.txtrecheckremark.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtrecheckremark.Properties.Appearance.Options.UseFont = True
        Me.txtrecheckremark.Size = New System.Drawing.Size(644, 161)
        Me.txtrecheckremark.TabIndex = 24
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridFile)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.PageVisible = False
        Me.XtraTabPage4.Size = New System.Drawing.Size(844, 265)
        Me.XtraTabPage4.Text = "附檔信息"
        '
        'GridFile
        '
        Me.GridFile.AllowUserToAddRows = False
        Me.GridFile.AllowUserToDeleteRows = False
        Me.GridFile.AllowUserToResizeRows = False
        Me.GridFile.BackgroundColor = System.Drawing.Color.White
        Me.GridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F_No, Me.F_OldName, Me.F_Name, Me.F_Detail, Me.F_AddDate, Me.F_Action})
        Me.GridFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridFile.EnableHeadersVisualStyles = False
        Me.GridFile.GridColor = System.Drawing.Color.Silver
        Me.GridFile.Location = New System.Drawing.Point(0, 0)
        Me.GridFile.MultiSelect = False
        Me.GridFile.Name = "GridFile"
        Me.GridFile.ReadOnly = True
        Me.GridFile.RowTemplate.Height = 24
        Me.GridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridFile.Size = New System.Drawing.Size(844, 265)
        Me.GridFile.TabIndex = 25
        '
        'F_No
        '
        Me.F_No.DataPropertyName = "F_No"
        Me.F_No.HeaderText = "文件編號"
        Me.F_No.Name = "F_No"
        Me.F_No.ReadOnly = True
        '
        'F_OldName
        '
        Me.F_OldName.DataPropertyName = "F_OldName"
        Me.F_OldName.HeaderText = "文件名"
        Me.F_OldName.Name = "F_OldName"
        Me.F_OldName.ReadOnly = True
        '
        'F_Name
        '
        Me.F_Name.DataPropertyName = "F_Name"
        Me.F_Name.HeaderText = "文件名稱"
        Me.F_Name.Name = "F_Name"
        Me.F_Name.ReadOnly = True
        '
        'F_Detail
        '
        Me.F_Detail.DataPropertyName = "F_Detail"
        Me.F_Detail.HeaderText = "文件內容"
        Me.F_Detail.Name = "F_Detail"
        Me.F_Detail.ReadOnly = True
        Me.F_Detail.Width = 300
        '
        'F_AddDate
        '
        Me.F_AddDate.DataPropertyName = "F_AddDate"
        Me.F_AddDate.HeaderText = "上傳日期"
        Me.F_AddDate.Name = "F_AddDate"
        Me.F_AddDate.ReadOnly = True
        '
        'F_Action
        '
        Me.F_Action.DataPropertyName = "F_Action"
        Me.F_Action.HeaderText = "操作員"
        Me.F_Action.Name = "F_Action"
        Me.F_Action.ReadOnly = True
        Me.F_Action.Width = 80
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(560, 408)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 25)
        Me.cmdPrint.TabIndex = 162
        Me.cmdPrint.Text = "出庫單(&J)"
        Me.cmdPrint.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(674, 408)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 163
        Me.cmdSave.Text = "確定(&O)"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(769, 408)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 164
        Me.cmdExit.Text = "取消(&C)"
        '
        'cmdBarCode
        '
        Me.cmdBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBarCode.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdBarCode.Appearance.Options.UseFont = True
        Me.cmdBarCode.Location = New System.Drawing.Point(5, 408)
        Me.cmdBarCode.Name = "cmdBarCode"
        Me.cmdBarCode.Size = New System.Drawing.Size(96, 25)
        Me.cmdBarCode.TabIndex = 161
        Me.cmdBarCode.Text = "打印條碼(&P)"
        Me.cmdBarCode.Visible = False
        '
        'popFileShow
        '
        Me.popFileShow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popFileShowOpen})
        Me.popFileShow.Name = "popFileShow"
        Me.popFileShow.Size = New System.Drawing.Size(157, 26)
        '
        'popFileShowOpen
        '
        Me.popFileShowOpen.Name = "popFileShowOpen"
        Me.popFileShowOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.popFileShowOpen.Size = New System.Drawing.Size(156, 22)
        Me.popFileShowOpen.Text = "打開(&O)..."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(621, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 13)
        Me.Label25.TabIndex = 218
        Me.Label25.Text = "刀具屬性(&K)："
        '
        'cbKnifeType
        '
        Me.cbKnifeType.Enabled = False
        Me.cbKnifeType.Location = New System.Drawing.Point(716, 12)
        Me.cbKnifeType.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.cbKnifeType.Name = "cbKnifeType"
        Me.cbKnifeType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKnifeType.Properties.Appearance.Options.UseFont = True
        Me.cbKnifeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKnifeType.Properties.Items.AddRange(New Object() {"新刀", "待處理"})
        Me.cbKnifeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKnifeType.Size = New System.Drawing.Size(85, 22)
        Me.cbKnifeType.TabIndex = 219
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.sk)
        Me.GroupBox1.Controls.Add(Me.cbKnifeType)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtM_Code)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.gluDepID)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit2)
        Me.GroupBox1.Controls.Add(Me.txtOPNO)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtAPNO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateEdit1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 113)
        Me.GroupBox1.TabIndex = 220
        Me.GroupBox1.TabStop = False
        '
        'frmKnifeWareOutSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 436)
        Me.Controls.Add(Me.cmdBarCode)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtWIPID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmKnifeWareOutSub"
        Me.Text = "KnifeWareOutSub"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWIPID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluDepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOPNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popWareInput.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtxtAP_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarkItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCodeText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrecheckremark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popFileShow.ResumeLayout(False)
        CType(Me.cbKnifeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtWIPID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAPNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gluDepID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOPNO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ButtonEdit2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWH As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rtxtAP_NO As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents M_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarkItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents WO_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents M_SendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SafeQty_Show As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_EndQty_Show As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WO_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents OS_BatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Temp_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents MCodeText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckAction As System.Windows.Forms.Label
    Friend WithEvents CheckDate As System.Windows.Forms.Label
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtrecheckaction As System.Windows.Forms.Label
    Friend WithEvents txtrecheckdate As System.Windows.Forms.Label
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtrecheckremark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridFile As System.Windows.Forms.DataGridView
    Friend WithEvents F_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_AddDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_Action As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popWareInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popApplyAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutBarAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popLoadBatchAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popLoadBatchAllAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popWareOutDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popFileShow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popFileShowOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbKnifeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Enable_Qty_Show As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WI_SQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SReQty As DevExpress.XtraGrid.Columns.GridColumn
End Class
