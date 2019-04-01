<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.popOrderMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popOrderMainAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderMainEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripModify = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripModifyQ = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainView = New System.Windows.Forms.ToolStripMenuItem
        Me.PopRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainAddMo = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderDH = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderDHAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderDHCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderPJ = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderPJAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderPJCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripChcekA = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderMainCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderMainReCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.popOrderMainSe = New System.Windows.Forms.ToolStripMenuItem
        Me.popOrderMainPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PopOrderCollect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripNOPrice = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OM_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.m_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_JiYu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CusterNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.OM_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.OM_AddDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.OM_EditDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.OM_PoDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.OM_Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_OrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_NoMakeQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_NoSendQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_NoOutQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_OrderSpare = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CurrencyID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_Action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_MakeDetail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_CheckA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_PriceCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_PriceReCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_Check = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_ProductionWeek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OS_CheckDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid6 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PM_M_CodeOld = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PM_M_CodeNew = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChangeType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.U_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.Grid7 = New DevExpress.XtraGrid.GridControl
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OS_BatchIDC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_NOC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_WeightC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_UnitC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BadQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_AddDateC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.C_RemarkC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WH_IDC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OM_IDC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AutoIDC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.popOrderMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'popOrderMain
        '
        Me.popOrderMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popOrderMainAdd, Me.popOrderMainEdit, Me.ToolStripModify, Me.ToolStripModifyQ, Me.ToolStripSeparator7, Me.popOrderMainDel, Me.ToolStripSeparator4, Me.popOrderMainView, Me.PopRefresh, Me.ToolStripSeparator5, Me.popOrderMainAddMo, Me.ToolStripSeparator6, Me.ToolStripChcekA, Me.ToolStripSeparator1, Me.popOrderMainPrice, Me.popOrderMainCheck, Me.popOrderMainReCheck, Me.popOrderCheck, Me.ToolStripSeparator2, Me.popOrderMainFile, Me.ToolStripSeparator3, Me.popOrderMainSe, Me.popOrderMainPrint, Me.ToolStripMenuItem1, Me.PopOrderCollect, Me.ToolStripMenuItem2, Me.ToolStripNOPrice})
        Me.popOrderMain.Name = "popOrderMain"
        Me.popOrderMain.Size = New System.Drawing.Size(163, 454)
        '
        'popOrderMainAdd
        '
        Me.popOrderMainAdd.Enabled = False
        Me.popOrderMainAdd.Image = Global.LFERP.My.Resources.Resources.QueryAppend
        Me.popOrderMainAdd.Name = "popOrderMainAdd"
        Me.popOrderMainAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.popOrderMainAdd.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainAdd.Text = "新增(&A)..."
        '
        'popOrderMainEdit
        '
        Me.popOrderMainEdit.Enabled = False
        Me.popOrderMainEdit.Image = Global.LFERP.My.Resources.Resources.ReviseContents
        Me.popOrderMainEdit.Name = "popOrderMainEdit"
        Me.popOrderMainEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.popOrderMainEdit.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainEdit.Text = "修改(&E)..."
        '
        'ToolStripModify
        '
        Me.ToolStripModify.Name = "ToolStripModify"
        Me.ToolStripModify.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripModify.Text = "修改編碼"
        Me.ToolStripModify.Visible = False
        '
        'ToolStripModifyQ
        '
        Me.ToolStripModifyQ.Name = "ToolStripModifyQ"
        Me.ToolStripModifyQ.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripModifyQ.Text = "調整未交數"
        Me.ToolStripModifyQ.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainDel
        '
        Me.popOrderMainDel.Enabled = False
        Me.popOrderMainDel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popOrderMainDel.Name = "popOrderMainDel"
        Me.popOrderMainDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popOrderMainDel.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainDel.Text = "刪除(&D)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainView
        '
        Me.popOrderMainView.Image = Global.LFERP.My.Resources.Resources.GroupAttendeesMeetingNotSent
        Me.popOrderMainView.Name = "popOrderMainView"
        Me.popOrderMainView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.popOrderMainView.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainView.Text = "查看(&W)..."
        '
        'PopRefresh
        '
        Me.PopRefresh.Image = Global.LFERP.My.Resources.Resources.Repeat
        Me.PopRefresh.Name = "PopRefresh"
        Me.PopRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.PopRefresh.Size = New System.Drawing.Size(162, 22)
        Me.PopRefresh.Text = "刷新(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainAddMo
        '
        Me.popOrderMainAddMo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popOrderDH, Me.popOrderPJ})
        Me.popOrderMainAddMo.Enabled = False
        Me.popOrderMainAddMo.Name = "popOrderMainAddMo"
        Me.popOrderMainAddMo.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainAddMo.Text = "創建批次(&K)"
        '
        'popOrderDH
        '
        Me.popOrderDH.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popOrderDHAdd, Me.popOrderDHCopy})
        Me.popOrderDH.Name = "popOrderDH"
        Me.popOrderDH.Size = New System.Drawing.Size(136, 22)
        Me.popOrderDH.Text = "大貨批次(&M)"
        '
        'popOrderDHAdd
        '
        Me.popOrderDHAdd.Name = "popOrderDHAdd"
        Me.popOrderDHAdd.Size = New System.Drawing.Size(155, 22)
        Me.popOrderDHAdd.Text = "手動創建(&O)..."
        '
        'popOrderDHCopy
        '
        Me.popOrderDHCopy.Name = "popOrderDHCopy"
        Me.popOrderDHCopy.Size = New System.Drawing.Size(155, 22)
        Me.popOrderDHCopy.Text = "導入舊批次(&U)..."
        '
        'popOrderPJ
        '
        Me.popOrderPJ.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popOrderPJAdd, Me.popOrderPJCopy})
        Me.popOrderPJ.Name = "popOrderPJ"
        Me.popOrderPJ.Size = New System.Drawing.Size(136, 22)
        Me.popOrderPJ.Text = "配件批次(&N)"
        '
        'popOrderPJAdd
        '
        Me.popOrderPJAdd.Name = "popOrderPJAdd"
        Me.popOrderPJAdd.Size = New System.Drawing.Size(155, 22)
        Me.popOrderPJAdd.Text = "手動創建(&O)..."
        '
        'popOrderPJCopy
        '
        Me.popOrderPJCopy.Name = "popOrderPJCopy"
        Me.popOrderPJCopy.Size = New System.Drawing.Size(155, 22)
        Me.popOrderPJCopy.Text = "導入舊批次(&U)..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        'ToolStripChcekA
        '
        Me.ToolStripChcekA.Name = "ToolStripChcekA"
        Me.ToolStripChcekA.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripChcekA.Text = "審核(&C)"
        Me.ToolStripChcekA.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainPrice
        '
        Me.popOrderMainPrice.Enabled = False
        Me.popOrderMainPrice.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.popOrderMainPrice.Name = "popOrderMainPrice"
        Me.popOrderMainPrice.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainPrice.Text = "單價錄入"
        '
        'popOrderMainCheck
        '
        Me.popOrderMainCheck.Enabled = False
        Me.popOrderMainCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popOrderMainCheck.Name = "popOrderMainCheck"
        Me.popOrderMainCheck.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainCheck.Text = "單價審核"
        '
        'popOrderMainReCheck
        '
        Me.popOrderMainReCheck.Enabled = False
        Me.popOrderMainReCheck.Image = Global.LFERP.My.Resources.Resources.InviteAttendees
        Me.popOrderMainReCheck.Name = "popOrderMainReCheck"
        Me.popOrderMainReCheck.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainReCheck.Text = "單價鎖定"
        '
        'popOrderCheck
        '
        Me.popOrderCheck.Enabled = False
        Me.popOrderCheck.Name = "popOrderCheck"
        Me.popOrderCheck.Size = New System.Drawing.Size(162, 22)
        Me.popOrderCheck.Text = "訂單鍞定"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainFile
        '
        Me.popOrderMainFile.Image = Global.LFERP.My.Resources.Resources.BlogManageAccounts
        Me.popOrderMainFile.Name = "popOrderMainFile"
        Me.popOrderMainFile.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainFile.Text = "附檔管理(&B)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(159, 6)
        '
        'popOrderMainSe
        '
        Me.popOrderMainSe.Image = Global.LFERP.My.Resources.Resources.ZoomClassic
        Me.popOrderMainSe.Name = "popOrderMainSe"
        Me.popOrderMainSe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.popOrderMainSe.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainSe.Text = "查詢(&F)..."
        '
        'popOrderMainPrint
        '
        Me.popOrderMainPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.popOrderMainPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.popOrderMainPrint.Name = "popOrderMainPrint"
        Me.popOrderMainPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.popOrderMainPrint.Size = New System.Drawing.Size(162, 22)
        Me.popOrderMainPrint.Text = "打印(&P)..."
        Me.popOrderMainPrint.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'PopOrderCollect
        '
        Me.PopOrderCollect.Name = "PopOrderCollect"
        Me.PopOrderCollect.Size = New System.Drawing.Size(162, 22)
        Me.PopOrderCollect.Text = "訂單匯總表"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 6)
        '
        'ToolStripNOPrice
        '
        Me.ToolStripNOPrice.Name = "ToolStripNOPrice"
        Me.ToolStripNOPrice.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripNOPrice.Text = "列印無單價編碼"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "訂單資料"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(765, 36)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.ContextMenuStrip = Me.popOrderMain
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemDateEdit5})
        Me.Grid1.Size = New System.Drawing.Size(766, 326)
        Me.Grid1.TabIndex = 167
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OM_No, Me.PM_M_Code, Me.m_name, Me.PM_JiYu, Me.OM_CusterID, Me.OM_ID, Me.OM_Gauge, Me.OM_CusterPO, Me.OM_CusterNO, Me.OM_SendDate, Me.OM_CheckDate, Me.OM_AddDate, Me.OM_EditDate, Me.OM_PoDate, Me.OM_Remark, Me.OM_OrderQty, Me.WI_Qty, Me.OM_NoMakeQty, Me.OM_NoSendQty, Me.OM_NoOutQty, Me.OM_OrderSpare, Me.OM_CurrencyID, Me.OM_Action, Me.OM_MakeDetail, Me.CO_ID, Me.OM_CheckA, Me.OM_PriceCheck, Me.OM_PriceReCheck, Me.OM_Check})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'OM_No
        '
        Me.OM_No.Caption = "訂單編號"
        Me.OM_No.FieldName = "OM_No"
        Me.OM_No.Name = "OM_No"
        Me.OM_No.OptionsColumn.ReadOnly = True
        Me.OM_No.Visible = True
        Me.OM_No.VisibleIndex = 0
        Me.OM_No.Width = 90
        '
        'PM_M_Code
        '
        Me.PM_M_Code.Caption = "產品編號"
        Me.PM_M_Code.FieldName = "PM_M_Code"
        Me.PM_M_Code.Name = "PM_M_Code"
        Me.PM_M_Code.Visible = True
        Me.PM_M_Code.VisibleIndex = 1
        '
        'm_name
        '
        Me.m_name.Caption = "產品名稱"
        Me.m_name.FieldName = "M_Name"
        Me.m_name.Name = "m_name"
        '
        'PM_JiYu
        '
        Me.PM_JiYu.Caption = "產品類別"
        Me.PM_JiYu.FieldName = "PM_JiYu"
        Me.PM_JiYu.Name = "PM_JiYu"
        Me.PM_JiYu.Visible = True
        Me.PM_JiYu.VisibleIndex = 2
        '
        'OM_CusterID
        '
        Me.OM_CusterID.Caption = "客戶代號"
        Me.OM_CusterID.FieldName = "OM_CusterID"
        Me.OM_CusterID.Name = "OM_CusterID"
        Me.OM_CusterID.OptionsColumn.ReadOnly = True
        Me.OM_CusterID.Visible = True
        Me.OM_CusterID.VisibleIndex = 3
        '
        'OM_ID
        '
        Me.OM_ID.Caption = "訂單流水號"
        Me.OM_ID.FieldName = "OM_ID"
        Me.OM_ID.Name = "OM_ID"
        Me.OM_ID.OptionsColumn.ReadOnly = True
        Me.OM_ID.Width = 85
        '
        'OM_Gauge
        '
        Me.OM_Gauge.Caption = "規格"
        Me.OM_Gauge.FieldName = "M_Gauge"
        Me.OM_Gauge.Name = "OM_Gauge"
        Me.OM_Gauge.OptionsColumn.ReadOnly = True
        Me.OM_Gauge.Visible = True
        Me.OM_Gauge.VisibleIndex = 6
        '
        'OM_CusterPO
        '
        Me.OM_CusterPO.Caption = "客戶PO"
        Me.OM_CusterPO.FieldName = "OM_CusterPO"
        Me.OM_CusterPO.Name = "OM_CusterPO"
        Me.OM_CusterPO.OptionsColumn.ReadOnly = True
        Me.OM_CusterPO.Visible = True
        Me.OM_CusterPO.VisibleIndex = 4
        '
        'OM_CusterNO
        '
        Me.OM_CusterNO.Caption = "客戶編號"
        Me.OM_CusterNO.FieldName = "OM_CusterNO"
        Me.OM_CusterNO.Name = "OM_CusterNO"
        Me.OM_CusterNO.OptionsColumn.ReadOnly = True
        Me.OM_CusterNO.Visible = True
        Me.OM_CusterNO.VisibleIndex = 5
        '
        'OM_SendDate
        '
        Me.OM_SendDate.Caption = "交貨日期"
        Me.OM_SendDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.OM_SendDate.FieldName = "OM_SendDate"
        Me.OM_SendDate.Name = "OM_SendDate"
        Me.OM_SendDate.OptionsColumn.ReadOnly = True
        Me.OM_SendDate.Visible = True
        Me.OM_SendDate.VisibleIndex = 13
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'OM_CheckDate
        '
        Me.OM_CheckDate.Caption = "驗貨日期"
        Me.OM_CheckDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.OM_CheckDate.FieldName = "OM_CheckDate"
        Me.OM_CheckDate.Name = "OM_CheckDate"
        Me.OM_CheckDate.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'OM_AddDate
        '
        Me.OM_AddDate.Caption = "建立日期"
        Me.OM_AddDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.OM_AddDate.FieldName = "OM_AddDate"
        Me.OM_AddDate.Name = "OM_AddDate"
        Me.OM_AddDate.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'OM_EditDate
        '
        Me.OM_EditDate.Caption = "修改日期"
        Me.OM_EditDate.ColumnEdit = Me.RepositoryItemDateEdit4
        Me.OM_EditDate.FieldName = "OM_EditDate"
        Me.OM_EditDate.Name = "OM_EditDate"
        Me.OM_EditDate.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'OM_PoDate
        '
        Me.OM_PoDate.Caption = "PO日期"
        Me.OM_PoDate.ColumnEdit = Me.RepositoryItemDateEdit5
        Me.OM_PoDate.FieldName = "OM_PoDate"
        Me.OM_PoDate.Name = "OM_PoDate"
        Me.OM_PoDate.OptionsColumn.ReadOnly = True
        Me.OM_PoDate.Visible = True
        Me.OM_PoDate.VisibleIndex = 11
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        Me.RepositoryItemDateEdit5.ReadOnly = True
        Me.RepositoryItemDateEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'OM_Remark
        '
        Me.OM_Remark.Caption = "備註"
        Me.OM_Remark.FieldName = "OM_Remark"
        Me.OM_Remark.Name = "OM_Remark"
        Me.OM_Remark.OptionsColumn.ReadOnly = True
        Me.OM_Remark.Visible = True
        Me.OM_Remark.VisibleIndex = 14
        '
        'OM_OrderQty
        '
        Me.OM_OrderQty.Caption = "訂單數量"
        Me.OM_OrderQty.FieldName = "OM_OrderQty"
        Me.OM_OrderQty.Name = "OM_OrderQty"
        Me.OM_OrderQty.OptionsColumn.ReadOnly = True
        Me.OM_OrderQty.Visible = True
        Me.OM_OrderQty.VisibleIndex = 8
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存數"
        Me.WI_Qty.FieldName = "WI_Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 9
        '
        'OM_NoMakeQty
        '
        Me.OM_NoMakeQty.Caption = "未生產數量"
        Me.OM_NoMakeQty.FieldName = "OM_NoMakeQty"
        Me.OM_NoMakeQty.Name = "OM_NoMakeQty"
        Me.OM_NoMakeQty.OptionsColumn.ReadOnly = True
        Me.OM_NoMakeQty.Visible = True
        Me.OM_NoMakeQty.VisibleIndex = 10
        Me.OM_NoMakeQty.Width = 85
        '
        'OM_NoSendQty
        '
        Me.OM_NoSendQty.Caption = "未交數量"
        Me.OM_NoSendQty.FieldName = "OM_NoSendQty"
        Me.OM_NoSendQty.Name = "OM_NoSendQty"
        Me.OM_NoSendQty.OptionsColumn.ReadOnly = True
        Me.OM_NoSendQty.Visible = True
        Me.OM_NoSendQty.VisibleIndex = 7
        '
        'OM_NoOutQty
        '
        Me.OM_NoOutQty.Caption = "未出廠數量"
        Me.OM_NoOutQty.FieldName = "OM_NoOutQty"
        Me.OM_NoOutQty.Name = "OM_NoOutQty"
        Me.OM_NoOutQty.OptionsColumn.ReadOnly = True
        Me.OM_NoOutQty.Width = 85
        '
        'OM_OrderSpare
        '
        Me.OM_OrderSpare.Caption = "士啤"
        Me.OM_OrderSpare.FieldName = "OM_OrderSpare"
        Me.OM_OrderSpare.Name = "OM_OrderSpare"
        Me.OM_OrderSpare.OptionsColumn.ReadOnly = True
        Me.OM_OrderSpare.Visible = True
        Me.OM_OrderSpare.VisibleIndex = 12
        Me.OM_OrderSpare.Width = 55
        '
        'OM_CurrencyID
        '
        Me.OM_CurrencyID.Caption = "貨幣"
        Me.OM_CurrencyID.FieldName = "OM_CurrencyID"
        Me.OM_CurrencyID.Name = "OM_CurrencyID"
        Me.OM_CurrencyID.OptionsColumn.ReadOnly = True
        '
        'OM_Action
        '
        Me.OM_Action.Caption = "操作員"
        Me.OM_Action.FieldName = "OM_Action"
        Me.OM_Action.Name = "OM_Action"
        Me.OM_Action.OptionsColumn.ReadOnly = True
        '
        'OM_MakeDetail
        '
        Me.OM_MakeDetail.Caption = "完成狀況"
        Me.OM_MakeDetail.FieldName = "OM_MakeDetail"
        Me.OM_MakeDetail.Name = "OM_MakeDetail"
        Me.OM_MakeDetail.OptionsColumn.ReadOnly = True
        Me.OM_MakeDetail.Visible = True
        Me.OM_MakeDetail.VisibleIndex = 15
        '
        'CO_ID
        '
        Me.CO_ID.Caption = "公司代號"
        Me.CO_ID.FieldName = "CO_ID"
        Me.CO_ID.Name = "CO_ID"
        Me.CO_ID.OptionsColumn.ReadOnly = True
        '
        'OM_CheckA
        '
        Me.OM_CheckA.Caption = "審核"
        Me.OM_CheckA.FieldName = "OM_CheckA"
        Me.OM_CheckA.Name = "OM_CheckA"
        Me.OM_CheckA.Visible = True
        Me.OM_CheckA.VisibleIndex = 16
        '
        'OM_PriceCheck
        '
        Me.OM_PriceCheck.Caption = "單價審核"
        Me.OM_PriceCheck.FieldName = "OM_PriceCheck"
        Me.OM_PriceCheck.Name = "OM_PriceCheck"
        Me.OM_PriceCheck.Visible = True
        Me.OM_PriceCheck.VisibleIndex = 17
        '
        'OM_PriceReCheck
        '
        Me.OM_PriceReCheck.Caption = "單價鍞定"
        Me.OM_PriceReCheck.FieldName = "OM_PriceReCheck"
        Me.OM_PriceReCheck.Name = "OM_PriceReCheck"
        Me.OM_PriceReCheck.Visible = True
        Me.OM_PriceReCheck.VisibleIndex = 18
        '
        'OM_Check
        '
        Me.OM_Check.Caption = "訂單鍞定"
        Me.OM_Check.FieldName = "OM_Check"
        Me.OM_Check.Name = "OM_Check"
        Me.OM_Check.Visible = True
        Me.OM_Check.VisibleIndex = 19
        '
        'Grid2
        '
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(757, 119)
        Me.Grid2.TabIndex = 168
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn6, Me.OS_ProductionWeek, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.OS_SendDate, Me.OS_CheckDate})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "訂單流水號"
        Me.GridColumn1.FieldName = "OM_ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "生產批次"
        Me.GridColumn2.FieldName = "OS_BatchID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 136
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "產品編號"
        Me.GridColumn7.FieldName = "PM_M_Code"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "產品類型"
        Me.GridColumn6.FieldName = "PM_JiYu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'OS_ProductionWeek
        '
        Me.OS_ProductionWeek.Caption = "生產周"
        Me.OS_ProductionWeek.FieldName = "OS_ProductionWeek"
        Me.OS_ProductionWeek.Name = "OS_ProductionWeek"
        Me.OS_ProductionWeek.Visible = True
        Me.OS_ProductionWeek.VisibleIndex = 4
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "生產數量"
        Me.GridColumn3.FieldName = "OS_Qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.DisplayFormat = "合計:{0}"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "未交數"
        Me.GridColumn4.FieldName = "OS_NoSendQty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.SummaryItem.DisplayFormat = "合計:{0}"
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "未出廠數"
        Me.GridColumn5.FieldName = "OS_NoOutQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.SummaryItem.DisplayFormat = "合計:{0}"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'OS_SendDate
        '
        Me.OS_SendDate.Caption = "送貨日期"
        Me.OS_SendDate.FieldName = "OS_SendDate"
        Me.OS_SendDate.Name = "OS_SendDate"
        Me.OS_SendDate.Visible = True
        Me.OS_SendDate.VisibleIndex = 7
        '
        'OS_CheckDate
        '
        Me.OS_CheckDate.Caption = "驗貨日期"
        Me.OS_CheckDate.FieldName = "OS_CheckDate"
        Me.OS_CheckDate.Name = "OS_CheckDate"
        Me.OS_CheckDate.Visible = True
        Me.OS_CheckDate.VisibleIndex = 8
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(766, 151)
        Me.XtraTabControl1.TabIndex = 169
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(757, 119)
        Me.XtraTabPage1.Text = "生產明細"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Grid3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(757, 119)
        Me.XtraTabPage2.Text = "送貨明細"
        '
        'Grid3
        '
        Me.Grid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid3.EmbeddedNavigator.Name = ""
        Me.Grid3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid3.Location = New System.Drawing.Point(0, 0)
        Me.Grid3.MainView = Me.GridView3
        Me.Grid3.Name = "Grid3"
        Me.Grid3.Size = New System.Drawing.Size(757, 119)
        Me.Grid3.TabIndex = 169
        Me.Grid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14})
        Me.GridView3.GridControl = Me.Grid3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView3.OptionsFilter.AllowFilterEditor = False
        Me.GridView3.OptionsFilter.AllowMRUFilterList = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "批次編號"
        Me.GridColumn13.FieldName = "OS_BatchID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "送貨單號"
        Me.GridColumn8.FieldName = "OW_NO"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 109
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "送貨數量"
        Me.GridColumn9.FieldName = "OW_Qty"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "士啤"
        Me.GridColumn10.FieldName = "OM_OrderSpare"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 55
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "送貨日期"
        Me.GridColumn11.FieldName = "OW_Date"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "備註"
        Me.GridColumn12.FieldName = "OW_Remark"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 223
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "訂單流水號"
        Me.GridColumn14.FieldName = "OM_ID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Grid6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(757, 119)
        Me.XtraTabPage3.Text = "更改單"
        '
        'Grid6
        '
        Me.Grid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid6.EmbeddedNavigator.Name = ""
        Me.Grid6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid6.Location = New System.Drawing.Point(0, 0)
        Me.Grid6.MainView = Me.GridView4
        Me.Grid6.Name = "Grid6"
        Me.Grid6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1})
        Me.Grid6.Size = New System.Drawing.Size(757, 119)
        Me.Grid6.TabIndex = 170
        Me.Grid6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PM_M_CodeOld, Me.PM_M_CodeNew, Me.ChangeType, Me.U_Name, Me.OrderDate, Me.Remark})
        Me.GridView4.GridControl = Me.Grid6
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView4.OptionsFilter.AllowFilterEditor = False
        Me.GridView4.OptionsFilter.AllowMRUFilterList = False
        Me.GridView4.OptionsMenu.EnableColumnMenu = False
        Me.GridView4.OptionsMenu.EnableFooterMenu = False
        Me.GridView4.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView4.OptionsNavigation.UseTabKey = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'PM_M_CodeOld
        '
        Me.PM_M_CodeOld.Caption = "更改前"
        Me.PM_M_CodeOld.FieldName = "PM_M_CodeOld"
        Me.PM_M_CodeOld.Name = "PM_M_CodeOld"
        Me.PM_M_CodeOld.OptionsColumn.ReadOnly = True
        Me.PM_M_CodeOld.Visible = True
        Me.PM_M_CodeOld.VisibleIndex = 0
        Me.PM_M_CodeOld.Width = 100
        '
        'PM_M_CodeNew
        '
        Me.PM_M_CodeNew.Caption = "更改后"
        Me.PM_M_CodeNew.FieldName = "PM_M_CodeNew"
        Me.PM_M_CodeNew.Name = "PM_M_CodeNew"
        Me.PM_M_CodeNew.OptionsColumn.ReadOnly = True
        Me.PM_M_CodeNew.Visible = True
        Me.PM_M_CodeNew.VisibleIndex = 1
        Me.PM_M_CodeNew.Width = 100
        '
        'ChangeType
        '
        Me.ChangeType.Caption = "更改類型"
        Me.ChangeType.FieldName = "ChangeTypeName"
        Me.ChangeType.Name = "ChangeType"
        Me.ChangeType.OptionsColumn.ReadOnly = True
        Me.ChangeType.Visible = True
        Me.ChangeType.VisibleIndex = 2
        Me.ChangeType.Width = 85
        '
        'U_Name
        '
        Me.U_Name.Caption = "更改人"
        Me.U_Name.FieldName = "U_Name"
        Me.U_Name.Name = "U_Name"
        Me.U_Name.OptionsColumn.ReadOnly = True
        Me.U_Name.Visible = True
        Me.U_Name.VisibleIndex = 3
        '
        'OrderDate
        '
        Me.OrderDate.Caption = "更改日期"
        Me.OrderDate.FieldName = "OrderDate"
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.OptionsColumn.ReadOnly = True
        Me.OrderDate.Visible = True
        Me.OrderDate.VisibleIndex = 4
        Me.OrderDate.Width = 100
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Grid7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(757, 119)
        Me.XtraTabPage4.Text = "開料明細"
        '
        'Grid7
        '
        Me.Grid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid7.EmbeddedNavigator.Name = ""
        Me.Grid7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid7.Location = New System.Drawing.Point(0, 0)
        Me.Grid7.MainView = Me.GridView5
        Me.Grid7.Name = "Grid7"
        Me.Grid7.Size = New System.Drawing.Size(757, 119)
        Me.Grid7.TabIndex = 171
        Me.Grid7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OS_BatchIDC, Me.C_NOC, Me.C_WeightC, Me.M_UnitC, Me.BadQty, Me.C_AddDateC, Me.C_RemarkC, Me.WH_IDC, Me.OM_IDC, Me.AutoIDC})
        Me.GridView5.GridControl = Me.Grid7
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowColumnMoving = False
        Me.GridView5.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView5.OptionsFilter.AllowFilterEditor = False
        Me.GridView5.OptionsFilter.AllowMRUFilterList = False
        Me.GridView5.OptionsMenu.EnableColumnMenu = False
        Me.GridView5.OptionsMenu.EnableFooterMenu = False
        Me.GridView5.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView5.OptionsNavigation.UseTabKey = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.RowAutoHeight = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'OS_BatchIDC
        '
        Me.OS_BatchIDC.Caption = "批次編號"
        Me.OS_BatchIDC.FieldName = "OS_BatchID"
        Me.OS_BatchIDC.Name = "OS_BatchIDC"
        Me.OS_BatchIDC.Visible = True
        Me.OS_BatchIDC.VisibleIndex = 0
        '
        'C_NOC
        '
        Me.C_NOC.Caption = "開料單號"
        Me.C_NOC.FieldName = "C_NO"
        Me.C_NOC.Name = "C_NOC"
        Me.C_NOC.Visible = True
        Me.C_NOC.VisibleIndex = 1
        Me.C_NOC.Width = 109
        '
        'C_WeightC
        '
        Me.C_WeightC.Caption = "數量"
        Me.C_WeightC.FieldName = "C_Weight"
        Me.C_WeightC.Name = "C_WeightC"
        Me.C_WeightC.Visible = True
        Me.C_WeightC.VisibleIndex = 2
        '
        'M_UnitC
        '
        Me.M_UnitC.Caption = "單位"
        Me.M_UnitC.FieldName = "M_Unit"
        Me.M_UnitC.Name = "M_UnitC"
        Me.M_UnitC.Visible = True
        Me.M_UnitC.VisibleIndex = 3
        '
        'BadQty
        '
        Me.BadQty.Caption = "不良數"
        Me.BadQty.FieldName = "BadQty"
        Me.BadQty.Name = "BadQty"
        Me.BadQty.Visible = True
        Me.BadQty.VisibleIndex = 4
        '
        'C_AddDateC
        '
        Me.C_AddDateC.Caption = "開料日期"
        Me.C_AddDateC.FieldName = "C_AddDate"
        Me.C_AddDateC.Name = "C_AddDateC"
        Me.C_AddDateC.Visible = True
        Me.C_AddDateC.VisibleIndex = 5
        Me.C_AddDateC.Width = 82
        '
        'C_RemarkC
        '
        Me.C_RemarkC.Caption = "備註"
        Me.C_RemarkC.FieldName = "C_Remark"
        Me.C_RemarkC.Name = "C_RemarkC"
        Me.C_RemarkC.Visible = True
        Me.C_RemarkC.VisibleIndex = 6
        Me.C_RemarkC.Width = 223
        '
        'WH_IDC
        '
        Me.WH_IDC.Caption = "倉庫"
        Me.WH_IDC.FieldName = "WH_PName"
        Me.WH_IDC.Name = "WH_IDC"
        Me.WH_IDC.Visible = True
        Me.WH_IDC.VisibleIndex = 7
        '
        'OM_IDC
        '
        Me.OM_IDC.Caption = "訂單ID"
        Me.OM_IDC.FieldName = "OM_ID"
        Me.OM_IDC.Name = "OM_IDC"
        '
        'AutoIDC
        '
        Me.AutoIDC.Caption = "AutoID"
        Me.AutoIDC.FieldName = "AutoID"
        Me.AutoIDC.Name = "AutoIDC"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(766, 481)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.TabIndex = 170
        '
        'Remark
        '
        Me.Remark.Caption = "備注"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 5
        Me.Remark.Width = 150
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'frmOrderMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 524)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOrderMain"
        Me.Text = "訂單資料"
        Me.popOrderMain.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents popOrderMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popOrderMainAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainAddMo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popOrderMainFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popOrderMainPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainSe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OM_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CusterNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_AddDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_PoDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_OrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_NoMakeQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_NoSendQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_NoOutQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_OrderSpare As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_CurrencyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_Action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_MakeDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popOrderMainView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents popOrderDH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderPJ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderDHAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderDHCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderPJAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderPJCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents popOrderMainPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOrderMainReCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents popOrderCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OM_PriceCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_PriceReCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_CheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_JiYu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OS_ProductionWeek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PopOrderCollect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripModify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PM_M_CodeOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PM_M_CodeNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents U_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents m_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripChcekA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OM_CheckA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripNOPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Grid7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OS_BatchIDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_NOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_WeightC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_UnitC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BadQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_AddDateC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_RemarkC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WH_IDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OM_IDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoIDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChangeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripModifyQ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
