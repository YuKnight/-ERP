<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNmetalSampleCollection
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清单。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要项
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具进行修改。
    '请不要使用程式碼編輯器进行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label22 = New System.Windows.Forms.Label
        Me.rdoIsEnabled = New DevExpress.XtraEditors.RadioGroup
        Me.rdoAccountCheck = New DevExpress.XtraEditors.RadioGroup
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txt_NumberNo = New DevExpress.XtraEditors.TextEdit
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.cmsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdExcelA = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRef = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdInventoryDrep = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdInv = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_DepQuery = New System.Windows.Forms.ToolStripMenuItem
        Me.tsm_leiyin = New System.Windows.Forms.ToolStripMenuItem
        Me.gridSampleCollection = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Code_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StatusTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_SampleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.D_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarcodeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BitAuto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_reportbtn = New System.Windows.Forms.Button
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.gluStatusType = New DevExpress.XtraEditors.PopupContainerEdit
        Me.pccStatusType = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkStatusType = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.chkPaceType = New DevExpress.XtraEditors.CheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.gluPM_M_Code = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblPM_M_Code = New System.Windows.Forms.Label
        Me.gluD_ID = New DevExpress.XtraEditors.PopupContainerEdit
        Me.ppcD_ID = New DevExpress.XtraEditors.PopupContainerControl
        Me.chkD_ID = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.chkD_IDAll = New DevExpress.XtraEditors.CheckEdit
        Me.lblD_ID = New System.Windows.Forms.Label
        Me.GridBarCode = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdExcelB = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SE_OutD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Code_ID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_OutPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_OutTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_InD_Dep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_InPS_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_InTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_InCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_InCheckActionName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit27 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemButtonEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemCalcEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCheckEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemDateEdit40 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit38 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit39 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemMRUEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
        Me.RepositoryItemMemoEdit28 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemMemoExEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemDateEdit41 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_NumberNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuStrip.SuspendLayout()
        CType(Me.gridSampleCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gluStatusType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccStatusType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccStatusType.SuspendLayout()
        CType(Me.chkStatusType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPaceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppcD_ID.SuspendLayout()
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(34, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 15)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "是否启用(&J):"
        '
        'rdoIsEnabled
        '
        Me.rdoIsEnabled.EditValue = True
        Me.rdoIsEnabled.Location = New System.Drawing.Point(125, 123)
        Me.rdoIsEnabled.Name = "rdoIsEnabled"
        Me.rdoIsEnabled.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIsEnabled.Properties.Appearance.Options.UseFont = True
        Me.rdoIsEnabled.Properties.Columns = 2
        Me.rdoIsEnabled.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "启用"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "停用")})
        Me.rdoIsEnabled.Size = New System.Drawing.Size(181, 30)
        Me.rdoIsEnabled.TabIndex = 33
        '
        'rdoAccountCheck
        '
        Me.rdoAccountCheck.EditValue = False
        Me.rdoAccountCheck.Location = New System.Drawing.Point(125, 71)
        Me.rdoAccountCheck.Name = "rdoAccountCheck"
        Me.rdoAccountCheck.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAccountCheck.Properties.Appearance.Options.UseFont = True
        Me.rdoAccountCheck.Properties.Columns = 2
        Me.rdoAccountCheck.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "已审核"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "未审核")})
        Me.rdoAccountCheck.Size = New System.Drawing.Size(181, 30)
        Me.rdoAccountCheck.TabIndex = 31
        '
        'txtPrice
        '
        Me.txtPrice.EditValue = "0"
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(125, 25)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPrice.Size = New System.Drawing.Size(181, 24)
        Me.txtPrice.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(61, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "单价(&P):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "会计部审核(&K):"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_NumberNo)
        Me.Panel2.Controls.Add(Me.Lbl_Title)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1031, 32)
        Me.Panel2.TabIndex = 127
        '
        'txt_NumberNo
        '
        Me.txt_NumberNo.EditValue = "KC140700007"
        Me.txt_NumberNo.Location = New System.Drawing.Point(869, 2)
        Me.txt_NumberNo.Name = "txt_NumberNo"
        Me.txt_NumberNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_NumberNo.Properties.Appearance.Options.UseFont = True
        Me.txt_NumberNo.Size = New System.Drawing.Size(121, 24)
        Me.txt_NumberNo.TabIndex = 249
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(142, 21)
        Me.Lbl_Title.TabIndex = 85
        Me.Lbl_Title.Text = "条码采集管理"
        '
        'cmsMenuStrip
        '
        Me.cmsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdAdd, Me.cmdDel, Me.ToolStripSeparator3, Me.cmdExcelA, Me.cmdRef, Me.ToolStripSeparator2, Me.cmdQuery, Me.cmdInventoryDrep, Me.cmdInv, Me.tsm_DepQuery, Me.tsm_leiyin})
        Me.cmsMenuStrip.Name = "cmsMenuStrip"
        Me.cmsMenuStrip.Size = New System.Drawing.Size(217, 250)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = False
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdAdd.Image = Global.LFERP.My.Resources.Resources.BarcodeInsert
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(202, 28)
        Me.cmdAdd.Text = "采集条码(&N)"
        '
        'cmdDel
        '
        Me.cmdDel.AutoSize = False
        Me.cmdDel.Enabled = False
        Me.cmdDel.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.cmdDel.Size = New System.Drawing.Size(202, 28)
        Me.cmdDel.Text = "删除条码(&D)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(213, 6)
        '
        'cmdExcelA
        '
        Me.cmdExcelA.AutoSize = False
        Me.cmdExcelA.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExcelA.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExcelA.Name = "cmdExcelA"
        Me.cmdExcelA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdExcelA.Size = New System.Drawing.Size(202, 28)
        Me.cmdExcelA.Text = "Excel(&E)"
        '
        'cmdRef
        '
        Me.cmdRef.AutoSize = False
        Me.cmdRef.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdRef.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.cmdRef.Name = "cmdRef"
        Me.cmdRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.cmdRef.Size = New System.Drawing.Size(202, 28)
        Me.cmdRef.Text = "刷新数据(&R)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(213, 6)
        '
        'cmdQuery
        '
        Me.cmdQuery.AutoSize = False
        Me.cmdQuery.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdQuery.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.cmdQuery.Size = New System.Drawing.Size(202, 28)
        Me.cmdQuery.Text = "查詢(&Q)"
        '
        'cmdInventoryDrep
        '
        Me.cmdInventoryDrep.Enabled = False
        Me.cmdInventoryDrep.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.cmdInventoryDrep.Name = "cmdInventoryDrep"
        Me.cmdInventoryDrep.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.cmdInventoryDrep.Size = New System.Drawing.Size(216, 22)
        Me.cmdInventoryDrep.Text = "條碼部門狀態調整"
        '
        'cmdInv
        '
        Me.cmdInv.Enabled = False
        Me.cmdInv.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.cmdInv.Name = "cmdInv"
        Me.cmdInv.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmdInv.Size = New System.Drawing.Size(216, 22)
        Me.cmdInv.Text = "条码调整"
        '
        'tsm_DepQuery
        '
        Me.tsm_DepQuery.Name = "tsm_DepQuery"
        Me.tsm_DepQuery.Size = New System.Drawing.Size(216, 22)
        Me.tsm_DepQuery.Text = "部门查看"
        '
        'tsm_leiyin
        '
        Me.tsm_leiyin.Name = "tsm_leiyin"
        Me.tsm_leiyin.Size = New System.Drawing.Size(216, 22)
        Me.tsm_leiyin.Text = "列印"
        '
        'gridSampleCollection
        '
        Me.gridSampleCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSampleCollection.ContextMenuStrip = Me.cmsMenuStrip
        Me.gridSampleCollection.EmbeddedNavigator.Name = ""
        Me.gridSampleCollection.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gridSampleCollection.Location = New System.Drawing.Point(0, 36)
        Me.gridSampleCollection.MainView = Me.GridView3
        Me.gridSampleCollection.Name = "gridSampleCollection"
        Me.gridSampleCollection.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemButtonEdit2, Me.RepositoryItemCalcEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.gridSampleCollection.Size = New System.Drawing.Size(1031, 311)
        Me.gridSampleCollection.TabIndex = 5
        Me.gridSampleCollection.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Code_ID, Me.StatusType, Me.StatusTypeName, Me.PM_M_Code, Me.ClientBarcode, Me.SO_SampleID, Me.D_Dep, Me.BarcodeType, Me.BitAuto, Me.Remark, Me.AddUserID, Me.AddUserName, Me.Qty, Me.AddDate, Me.AutoID})
        Me.GridView3.GridControl = Me.gridSampleCollection
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'Code_ID
        '
        Me.Code_ID.Caption = "条码编号"
        Me.Code_ID.FieldName = "Code_ID"
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.OptionsColumn.ReadOnly = True
        Me.Code_ID.Visible = True
        Me.Code_ID.VisibleIndex = 0
        Me.Code_ID.Width = 149
        '
        'StatusType
        '
        Me.StatusType.Caption = "狀態"
        Me.StatusType.FieldName = "StatusType"
        Me.StatusType.Name = "StatusType"
        Me.StatusType.OptionsColumn.ReadOnly = True
        Me.StatusType.Width = 57
        '
        'StatusTypeName
        '
        Me.StatusTypeName.Caption = "状态"
        Me.StatusTypeName.FieldName = "StatusTypeName"
        Me.StatusTypeName.Name = "StatusTypeName"
        Me.StatusTypeName.OptionsColumn.ReadOnly = True
        Me.StatusTypeName.SummaryItem.DisplayFormat = "合計:"
        Me.StatusTypeName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.StatusTypeName.Visible = True
        Me.StatusTypeName.VisibleIndex = 1
        Me.StatusTypeName.Width = 54
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "产品编号"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.OptionsColumn.ReadOnly = True
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 3
        Me.PM_M_Code.Width = 97
        '
        'ClientBarcode
        '
        Me.ClientBarcode.Caption = "客戶条码"
        Me.ClientBarcode.FieldName = "ClientBarcode"
        Me.ClientBarcode.Name = "ClientBarcode"
        Me.ClientBarcode.OptionsColumn.ReadOnly = True
        Me.ClientBarcode.Visible = True
        Me.ClientBarcode.VisibleIndex = 5
        Me.ClientBarcode.Width = 143
        '
        'SO_SampleID
        '
        Me.SO_SampleID.Caption = "样办单号"
        Me.SO_SampleID.FieldName = "SO_SampleID"
        Me.SO_SampleID.Name = "SO_SampleID"
        Me.SO_SampleID.Visible = True
        Me.SO_SampleID.VisibleIndex = 4
        '
        'D_Dep
        '
        Me.D_Dep.Caption = "部門"
        Me.D_Dep.FieldName = "D_Dep"
        Me.D_Dep.Name = "D_Dep"
        Me.D_Dep.Visible = True
        Me.D_Dep.VisibleIndex = 6
        '
        'BarcodeType
        '
        Me.BarcodeType.Caption = "条码类型"
        Me.BarcodeType.FieldName = "BarcodeType"
        Me.BarcodeType.Name = "BarcodeType"
        Me.BarcodeType.Visible = True
        Me.BarcodeType.VisibleIndex = 7
        '
        'BitAuto
        '
        Me.BitAuto.Caption = "自动"
        Me.BitAuto.FieldName = "BitAuto"
        Me.BitAuto.Name = "BitAuto"
        Me.BitAuto.Visible = True
        Me.BitAuto.VisibleIndex = 10
        Me.BitAuto.Width = 45
        '
        'Remark
        '
        Me.Remark.Caption = "备注"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.OptionsColumn.ReadOnly = True
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 11
        Me.Remark.Width = 60
        '
        'AddUserID
        '
        Me.AddUserID.Caption = "採集人員"
        Me.AddUserID.FieldName = "AddUserID"
        Me.AddUserID.Name = "AddUserID"
        Me.AddUserID.OptionsColumn.ReadOnly = True
        Me.AddUserID.Width = 145
        '
        'AddUserName
        '
        Me.AddUserName.Caption = "采集人员"
        Me.AddUserName.FieldName = "AddUserName"
        Me.AddUserName.Name = "AddUserName"
        Me.AddUserName.OptionsColumn.ReadOnly = True
        Me.AddUserName.Visible = True
        Me.AddUserName.VisibleIndex = 9
        '
        'Qty
        '
        Me.Qty.Caption = "数量"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.ReadOnly = True
        Me.Qty.SummaryItem.DisplayFormat = "{0}"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 47
        '
        'AddDate
        '
        Me.AddDate.Caption = "采集日期"
        Me.AddDate.FieldName = "AddDate"
        Me.AddDate.Name = "AddDate"
        Me.AddDate.OptionsColumn.ReadOnly = True
        Me.AddDate.Visible = True
        Me.AddDate.VisibleIndex = 8
        Me.AddDate.Width = 83
        '
        'AutoID
        '
        Me.AutoID.Caption = "AutoID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_reportbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluStatusType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pccStatusType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluPM_M_Code)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPM_M_Code)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gluD_ID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblD_ID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridSampleCollection)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridBarCode)
        Me.SplitContainer1.Size = New System.Drawing.Size(1031, 509)
        Me.SplitContainer1.SplitterDistance = 347
        Me.SplitContainer1.TabIndex = 128
        '
        'btn_reportbtn
        '
        Me.btn_reportbtn.Location = New System.Drawing.Point(897, 6)
        Me.btn_reportbtn.Name = "btn_reportbtn"
        Me.btn_reportbtn.Size = New System.Drawing.Size(103, 23)
        Me.btn_reportbtn.TabIndex = 250
        Me.btn_reportbtn.Text = "刀具报表一览"
        Me.btn_reportbtn.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.cmdSearch.Location = New System.Drawing.Point(790, 6)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(82, 24)
        Me.cmdSearch.TabIndex = 248
        Me.cmdSearch.Text = "查询(&Q)"
        '
        'gluStatusType
        '
        Me.gluStatusType.Location = New System.Drawing.Point(602, 6)
        Me.gluStatusType.Name = "gluStatusType"
        Me.gluStatusType.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluStatusType.Properties.Appearance.Options.UseFont = True
        Me.gluStatusType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluStatusType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluStatusType.Properties.PopupControl = Me.pccStatusType
        Me.gluStatusType.Size = New System.Drawing.Size(180, 24)
        Me.gluStatusType.TabIndex = 247
        '
        'pccStatusType
        '
        Me.pccStatusType.Controls.Add(Me.chkStatusType)
        Me.pccStatusType.Controls.Add(Me.chkPaceType)
        Me.pccStatusType.Location = New System.Drawing.Point(73, 126)
        Me.pccStatusType.Name = "pccStatusType"
        Me.pccStatusType.Size = New System.Drawing.Size(200, 218)
        Me.pccStatusType.TabIndex = 246
        Me.pccStatusType.Text = "PopupContainerControl4"
        '
        'chkStatusType
        '
        Me.chkStatusType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStatusType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkStatusType.CheckOnClick = True
        Me.chkStatusType.DisplayMember = "StatusTypeName"
        Me.chkStatusType.HotTrackItems = True
        Me.chkStatusType.Location = New System.Drawing.Point(0, 25)
        Me.chkStatusType.Name = "chkStatusType"
        Me.chkStatusType.Size = New System.Drawing.Size(200, 191)
        Me.chkStatusType.TabIndex = 0
        Me.chkStatusType.ValueMember = "StatusType"
        '
        'chkPaceType
        '
        Me.chkPaceType.Location = New System.Drawing.Point(2, 2)
        Me.chkPaceType.Name = "chkPaceType"
        Me.chkPaceType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.chkPaceType.Properties.Appearance.Options.UseFont = True
        Me.chkPaceType.Properties.Caption = "全选<状态>"
        Me.chkPaceType.Size = New System.Drawing.Size(115, 23)
        Me.chkPaceType.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(527, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "状态(&Z):"
        '
        'gluPM_M_Code
        '
        Me.gluPM_M_Code.EditValue = ""
        Me.gluPM_M_Code.Location = New System.Drawing.Point(341, 6)
        Me.gluPM_M_Code.Name = "gluPM_M_Code"
        Me.gluPM_M_Code.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gluPM_M_Code.Properties.Appearance.Options.UseFont = True
        Me.gluPM_M_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluPM_M_Code.Properties.DisplayMember = "SO_SampleID"
        Me.gluPM_M_Code.Properties.NullText = ""
        Me.gluPM_M_Code.Properties.PopupFormWidth = 480
        Me.gluPM_M_Code.Properties.ValueMember = "SO_SampleID"
        Me.gluPM_M_Code.Properties.View = Me.GridView8
        Me.gluPM_M_Code.Size = New System.Drawing.Size(180, 24)
        Me.gluPM_M_Code.TabIndex = 9
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn5})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "样办单号"
        Me.GridColumn6.FieldName = "SO_SampleID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 304
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "产品编号"
        Me.GridColumn5.FieldName = "PM_M_Code"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 276
        '
        'lblPM_M_Code
        '
        Me.lblPM_M_Code.AutoSize = True
        Me.lblPM_M_Code.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPM_M_Code.Location = New System.Drawing.Point(243, 10)
        Me.lblPM_M_Code.Name = "lblPM_M_Code"
        Me.lblPM_M_Code.Size = New System.Drawing.Size(96, 16)
        Me.lblPM_M_Code.TabIndex = 8
        Me.lblPM_M_Code.Text = "样办单号(&C):"
        '
        'gluD_ID
        '
        Me.gluD_ID.Location = New System.Drawing.Point(73, 6)
        Me.gluD_ID.Name = "gluD_ID"
        Me.gluD_ID.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!)
        Me.gluD_ID.Properties.Appearance.Options.UseFont = True
        Me.gluD_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluD_ID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gluD_ID.Properties.PopupControl = Me.ppcD_ID
        Me.gluD_ID.Size = New System.Drawing.Size(164, 24)
        Me.gluD_ID.TabIndex = 7
        '
        'ppcD_ID
        '
        Me.ppcD_ID.Controls.Add(Me.chkD_ID)
        Me.ppcD_ID.Controls.Add(Me.chkD_IDAll)
        Me.ppcD_ID.Location = New System.Drawing.Point(325, 157)
        Me.ppcD_ID.Name = "ppcD_ID"
        Me.ppcD_ID.Size = New System.Drawing.Size(200, 218)
        Me.ppcD_ID.TabIndex = 247
        Me.ppcD_ID.Text = "PopupContainerControl4"
        '
        'chkD_ID
        '
        Me.chkD_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkD_ID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkD_ID.CheckOnClick = True
        Me.chkD_ID.DisplayMember = "DepName"
        Me.chkD_ID.HotTrackItems = True
        Me.chkD_ID.Location = New System.Drawing.Point(0, 25)
        Me.chkD_ID.Name = "chkD_ID"
        Me.chkD_ID.Size = New System.Drawing.Size(200, 191)
        Me.chkD_ID.TabIndex = 0
        Me.chkD_ID.ValueMember = "DepID"
        '
        'chkD_IDAll
        '
        Me.chkD_IDAll.Location = New System.Drawing.Point(2, 2)
        Me.chkD_IDAll.Name = "chkD_IDAll"
        Me.chkD_IDAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.chkD_IDAll.Properties.Appearance.Options.UseFont = True
        Me.chkD_IDAll.Properties.Caption = "全选<部门>"
        Me.chkD_IDAll.Size = New System.Drawing.Size(106, 23)
        Me.chkD_IDAll.TabIndex = 29
        '
        'lblD_ID
        '
        Me.lblD_ID.AutoSize = True
        Me.lblD_ID.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblD_ID.Location = New System.Drawing.Point(8, 10)
        Me.lblD_ID.Name = "lblD_ID"
        Me.lblD_ID.Size = New System.Drawing.Size(65, 16)
        Me.lblD_ID.TabIndex = 6
        Me.lblD_ID.Text = "部门(&D):"
        '
        'GridBarCode
        '
        Me.GridBarCode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridBarCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarCode.EmbeddedNavigator.Name = ""
        Me.GridBarCode.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridBarCode.Location = New System.Drawing.Point(0, 0)
        Me.GridBarCode.MainView = Me.GridView2
        Me.GridBarCode.Name = "GridBarCode"
        Me.GridBarCode.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit27, Me.RepositoryItemButtonEdit14, Me.RepositoryItemCalcEdit15, Me.RepositoryItemTextEdit14, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemCheckEdit13, Me.RepositoryItemDateEdit40, Me.RepositoryItemDateEdit38, Me.RepositoryItemDateEdit39, Me.RepositoryItemMRUEdit13, Me.RepositoryItemMemoEdit28, Me.RepositoryItemMemoExEdit15, Me.RepositoryItemDateEdit41, Me.RepositoryItemTimeEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridBarCode.Size = New System.Drawing.Size(1031, 158)
        Me.GridBarCode.TabIndex = 240
        Me.GridBarCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExcelB})
        Me.ContextMenuStrip1.Name = "cmsMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 32)
        '
        'cmdExcelB
        '
        Me.cmdExcelB.AutoSize = False
        Me.cmdExcelB.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExcelB.Image = Global.LFERP.My.Resources.Resources.PivotExportToExcel
        Me.cmdExcelB.Name = "cmdExcelB"
        Me.cmdExcelB.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdExcelB.Size = New System.Drawing.Size(202, 28)
        Me.cmdExcelB.Text = "Excel(&E)"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SE_OutD_Dep, Me.Code_ID1, Me.GridColumn3, Me.SE_OutPS_Name, Me.SE_OutTime, Me.GridColumn1, Me.SE_InD_Dep, Me.SE_InPS_Name, Me.SE_InTime, Me.GridColumn2, Me.SE_InCheck, Me.SE_InCheckActionName, Me.SE_ID})
        Me.GridView2.GridControl = Me.GridBarCode
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsPrint.AutoWidth = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SE_OutD_Dep
        '
        Me.SE_OutD_Dep.Caption = "发料部门"
        Me.SE_OutD_Dep.FieldName = "SE_OutD_Dep"
        Me.SE_OutD_Dep.Name = "SE_OutD_Dep"
        Me.SE_OutD_Dep.Visible = True
        Me.SE_OutD_Dep.VisibleIndex = 1
        Me.SE_OutD_Dep.Width = 74
        '
        'Code_ID1
        '
        Me.Code_ID1.Caption = "样办单号"
        Me.Code_ID1.FieldName = "SO_SampleID"
        Me.Code_ID1.Name = "Code_ID1"
        Me.Code_ID1.OptionsColumn.AllowEdit = False
        Me.Code_ID1.Visible = True
        Me.Code_ID1.VisibleIndex = 0
        Me.Code_ID1.Width = 116
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "收发类型"
        Me.GridColumn3.FieldName = "SE_TypeName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'SE_OutPS_Name
        '
        Me.SE_OutPS_Name.Caption = "发料工序"
        Me.SE_OutPS_Name.FieldName = "SE_OutPS_Name"
        Me.SE_OutPS_Name.Name = "SE_OutPS_Name"
        Me.SE_OutPS_Name.Visible = True
        Me.SE_OutPS_Name.VisibleIndex = 3
        Me.SE_OutPS_Name.Width = 71
        '
        'SE_OutTime
        '
        Me.SE_OutTime.Caption = "发料时间"
        Me.SE_OutTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.SE_OutTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SE_OutTime.FieldName = "SE_OutTime"
        Me.SE_OutTime.GroupFormat.FormatString = "d"
        Me.SE_OutTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SE_OutTime.Name = "SE_OutTime"
        Me.SE_OutTime.Visible = True
        Me.SE_OutTime.VisibleIndex = 4
        Me.SE_OutTime.Width = 144
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "发料人员"
        Me.GridColumn1.FieldName = "SE_OutCardIDName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'SE_InD_Dep
        '
        Me.SE_InD_Dep.Caption = "收料部门"
        Me.SE_InD_Dep.FieldName = "SE_InD_Dep"
        Me.SE_InD_Dep.Name = "SE_InD_Dep"
        Me.SE_InD_Dep.Visible = True
        Me.SE_InD_Dep.VisibleIndex = 6
        '
        'SE_InPS_Name
        '
        Me.SE_InPS_Name.Caption = "收料工序"
        Me.SE_InPS_Name.FieldName = "SE_InPS_Name"
        Me.SE_InPS_Name.Name = "SE_InPS_Name"
        Me.SE_InPS_Name.Visible = True
        Me.SE_InPS_Name.VisibleIndex = 7
        Me.SE_InPS_Name.Width = 74
        '
        'SE_InTime
        '
        Me.SE_InTime.Caption = "收料时间"
        Me.SE_InTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.SE_InTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SE_InTime.FieldName = "SE_InTime"
        Me.SE_InTime.GroupFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.SE_InTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SE_InTime.Name = "SE_InTime"
        Me.SE_InTime.Visible = True
        Me.SE_InTime.VisibleIndex = 8
        Me.SE_InTime.Width = 139
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "收料人员"
        Me.GridColumn2.FieldName = "SE_InCardIDName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        '
        'SE_InCheck
        '
        Me.SE_InCheck.Caption = "审核"
        Me.SE_InCheck.FieldName = "SE_InCheck"
        Me.SE_InCheck.Name = "SE_InCheck"
        Me.SE_InCheck.Visible = True
        Me.SE_InCheck.VisibleIndex = 10
        Me.SE_InCheck.Width = 35
        '
        'SE_InCheckActionName
        '
        Me.SE_InCheckActionName.Caption = "审核人"
        Me.SE_InCheckActionName.FieldName = "SE_InCheckActionName"
        Me.SE_InCheckActionName.Name = "SE_InCheckActionName"
        Me.SE_InCheckActionName.Visible = True
        Me.SE_InCheckActionName.VisibleIndex = 11
        Me.SE_InCheckActionName.Width = 100
        '
        'SE_ID
        '
        Me.SE_ID.Caption = "单号"
        Me.SE_ID.FieldName = "SE_ID"
        Me.SE_ID.Name = "SE_ID"
        Me.SE_ID.Visible = True
        Me.SE_ID.VisibleIndex = 12
        Me.SE_ID.Width = 100
        '
        'RepositoryItemMemoEdit27
        '
        Me.RepositoryItemMemoEdit27.Name = "RepositoryItemMemoEdit27"
        '
        'RepositoryItemButtonEdit14
        '
        Me.RepositoryItemButtonEdit14.AutoHeight = False
        Me.RepositoryItemButtonEdit14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit14.Name = "RepositoryItemButtonEdit14"
        '
        'RepositoryItemCalcEdit15
        '
        Me.RepositoryItemCalcEdit15.AutoHeight = False
        Me.RepositoryItemCalcEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit15.Name = "RepositoryItemCalcEdit15"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit13
        '
        Me.RepositoryItemCheckEdit13.AutoHeight = False
        Me.RepositoryItemCheckEdit13.Name = "RepositoryItemCheckEdit13"
        Me.RepositoryItemCheckEdit13.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemDateEdit40
        '
        Me.RepositoryItemDateEdit40.AutoHeight = False
        Me.RepositoryItemDateEdit40.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit40.Mask.EditMask = ""
        Me.RepositoryItemDateEdit40.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit40.Name = "RepositoryItemDateEdit40"
        '
        'RepositoryItemDateEdit38
        '
        Me.RepositoryItemDateEdit38.AutoHeight = False
        Me.RepositoryItemDateEdit38.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit38.Name = "RepositoryItemDateEdit38"
        '
        'RepositoryItemDateEdit39
        '
        Me.RepositoryItemDateEdit39.AutoHeight = False
        Me.RepositoryItemDateEdit39.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit39.Name = "RepositoryItemDateEdit39"
        '
        'RepositoryItemMRUEdit13
        '
        Me.RepositoryItemMRUEdit13.AutoHeight = False
        Me.RepositoryItemMRUEdit13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit13.Name = "RepositoryItemMRUEdit13"
        '
        'RepositoryItemMemoEdit28
        '
        Me.RepositoryItemMemoEdit28.Name = "RepositoryItemMemoEdit28"
        '
        'RepositoryItemMemoExEdit15
        '
        Me.RepositoryItemMemoExEdit15.AutoHeight = False
        Me.RepositoryItemMemoExEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit15.Name = "RepositoryItemMemoExEdit15"
        Me.RepositoryItemMemoExEdit15.ShowIcon = False
        '
        'RepositoryItemDateEdit41
        '
        Me.RepositoryItemDateEdit41.AutoHeight = False
        Me.RepositoryItemDateEdit41.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit41.Name = "RepositoryItemDateEdit41"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'frmNmetalSampleCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 541)
        Me.Controls.Add(Me.ppcD_ID)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "frmNmetalSampleCollection"
        Me.Text = "条码采集管理"
        CType(Me.rdoIsEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoAccountCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_NumberNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuStrip.ResumeLayout(False)
        CType(Me.gridSampleCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gluStatusType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccStatusType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccStatusType.ResumeLayout(False)
        CType(Me.chkStatusType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPaceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluPM_M_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppcD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppcD_ID.ResumeLayout(False)
        CType(Me.chkD_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkD_IDAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdoIsEnabled As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdoAccountCheck As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmsMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gridSampleCollection As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StatusType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents AddUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents AddUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarcodeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExcelA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdExcelB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridBarCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SE_OutD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_OutPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_OutTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_InD_Dep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_InPS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_InTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_InCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SE_InCheckActionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit27 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCalcEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit40 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit38 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit39 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMRUEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents RepositoryItemMemoEdit28 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit41 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdInventoryDrep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SO_SampleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdInv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BitAuto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gluD_ID As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents lblD_ID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gluPM_M_Code As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPM_M_Code As System.Windows.Forms.Label
    Friend WithEvents ppcD_ID As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkD_ID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkD_IDAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pccStatusType As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents chkStatusType As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkPaceType As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gluStatusType As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tsm_DepQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_leiyin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_NumberNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_reportbtn As System.Windows.Forms.Button
End Class
