<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MrpReportSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MrpReportSelect))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.xtcTable = New DevExpress.XtraTab.XtraTabControl
        Me.xtpMrpForecastOrder = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_FO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cb_Check_FO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label44 = New System.Windows.Forms.Label
        Me.glu_ForecastID_FO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.de_EndDate_FO = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.de_StartDate_FO = New DevExpress.XtraEditors.DateEdit
        Me.glu_MO_CusterID_FO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MO_CusterID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MO_CusterName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpMrpBom = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cb_IsCheck_BOM = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.glu_M_Code_BOM = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.de_endDate_BOM = New DevExpress.XtraEditors.DateEdit
        Me.de_startDate_BOM = New DevExpress.XtraEditors.DateEdit
        Me.cb_Select_BOM = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtpMrpWareHouse = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_WH = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cb_Ischeck_WH = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblWare_ID = New System.Windows.Forms.Label
        Me.de_EndDate_WH = New DevExpress.XtraEditors.DateEdit
        Me.lblMRP_ID = New System.Windows.Forms.Label
        Me.de_BeginDate_WH = New DevExpress.XtraEditors.DateEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblISMrp = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.gul_MRPID__WH = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MRP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_Ware_ID_WH = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.xtpMrpMaterialCode = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_MC = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cb_CheckBit_MC = New DevExpress.XtraEditors.ComboBoxEdit
        Me.de_BeginDate_MC = New DevExpress.XtraEditors.DateEdit
        Me.lblM_Code = New System.Windows.Forms.Label
        Me.de_EndDate_MC = New DevExpress.XtraEditors.DateEdit
        Me.glu_M_Code_MC = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.glu_S_Supplier_MC = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtpMrpInfo = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_MI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cb_IsCheck_MI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.glu_MI_MRPType_MI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.glu_MRP_ID_MI = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_MI_CalcType_MI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.de_BeginDate_MI = New DevExpress.XtraEditors.DateEdit
        Me.de_EndDate_MI = New DevExpress.XtraEditors.DateEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.xtpMrpPurchaseRecord = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_PR = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.glu_Department_PR = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.glu_MrpPurchaseID_PR = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_Mrp_ID_PR = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.de_BeginDate_PR = New DevExpress.XtraEditors.DateEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.de_EndDate_PR = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_IsCheck_PR = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cb_IsUrgent_PR = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.cb_IsPurchase_PR = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.xtpMrpPurchaseOrder = New DevExpress.XtraTab.XtraTabPage
        Me.Label35 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.glu_SupplierID_PO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.glu_PO_PO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glu_PR_PO = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.de_BeginDate_PO = New DevExpress.XtraEditors.DateEdit
        Me.Label40 = New System.Windows.Forms.Label
        Me.de_EndDate_PO = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cb_ReCheckBit_PO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cb_IsUrgency_PO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cb_IsCheck_PO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.cb_Select_PO = New DevExpress.XtraEditors.ComboBoxEdit
        Me.xtpMps = New DevExpress.XtraTab.XtraTabPage
        Me.cb_Select_MM = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.glu_M_Code_MM = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cb_IsCheck_MM = New DevExpress.XtraEditors.ComboBoxEdit
        Me.glu_MOID_MM = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.de_StarDate_MM = New DevExpress.XtraEditors.DateEdit
        Me.de_EndDate_MM = New DevExpress.XtraEditors.DateEdit
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Lbl_Title = New System.Windows.Forms.Label
        Me.M_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTable.SuspendLayout()
        Me.xtpMrpForecastOrder.SuspendLayout()
        CType(Me.cb_Select_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.cb_Check_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_ForecastID_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_StartDate_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MO_CusterID_FO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpBom.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.cb_IsCheck_BOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_M_Code_BOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_endDate_BOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_startDate_BOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Select_BOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpWareHouse.SuspendLayout()
        CType(Me.cb_Select_WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.cb_Ischeck_WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_BeginDate_WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gul_MRPID__WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_Ware_ID_WH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpMaterialCode.SuspendLayout()
        CType(Me.cb_Select_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.cb_CheckBit_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_BeginDate_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_M_Code_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_S_Supplier_MC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpInfo.SuspendLayout()
        CType(Me.cb_Select_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.cb_IsCheck_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MI_MRPType_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MRP_ID_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MI_CalcType_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_BeginDate_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpPurchaseRecord.SuspendLayout()
        CType(Me.cb_Select_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.glu_Department_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MrpPurchaseID_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_Mrp_ID_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_BeginDate_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cb_IsCheck_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_IsUrgent_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_IsPurchase_PR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMrpPurchaseOrder.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.glu_SupplierID_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_PO_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_PR_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_BeginDate_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cb_ReCheckBit_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_IsUrgency_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_IsCheck_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Select_PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMps.SuspendLayout()
        CType(Me.cb_Select_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.glu_M_Code_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_IsCheck_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glu_MOID_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_StarDate_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_EndDate_MM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 32)
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.xtcTable)
        Me.Panel1.Controls.Add(Me.Lbl_Title)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 311)
        Me.Panel1.TabIndex = 197
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(237, 280)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 28)
        Me.cmdExit.TabIndex = 200
        Me.cmdExit.Text = "取消(&R)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Image = Global.LFERP.My.Resources.Resources.PrintDialogAccess
        Me.cmdPrint.Location = New System.Drawing.Point(151, 280)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 28)
        Me.cmdPrint.TabIndex = 199
        Me.cmdPrint.Text = "列印(&P)"
        '
        'xtcTable
        '
        Me.xtcTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcTable.Location = New System.Drawing.Point(3, 38)
        Me.xtcTable.Name = "xtcTable"
        Me.xtcTable.SelectedTabPage = Me.xtpMrpForecastOrder
        Me.xtcTable.Size = New System.Drawing.Size(466, 241)
        Me.xtcTable.TabIndex = 0
        Me.xtcTable.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpMrpForecastOrder, Me.xtpMrpBom, Me.xtpMrpWareHouse, Me.xtpMrpMaterialCode, Me.xtpMrpInfo, Me.xtpMrpPurchaseRecord, Me.xtpMrpPurchaseOrder, Me.xtpMps})
        Me.xtcTable.Text = " "
        '
        'xtpMrpForecastOrder
        '
        Me.xtpMrpForecastOrder.Controls.Add(Me.cb_Select_FO)
        Me.xtpMrpForecastOrder.Controls.Add(Me.Label11)
        Me.xtpMrpForecastOrder.Controls.Add(Me.GroupBox5)
        Me.xtpMrpForecastOrder.Name = "xtpMrpForecastOrder"
        Me.xtpMrpForecastOrder.PageVisible = False
        Me.xtpMrpForecastOrder.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpForecastOrder.Text = "預測訂單"
        '
        'cb_Select_FO
        '
        Me.cb_Select_FO.EditValue = "預測訂單號"
        Me.cb_Select_FO.Location = New System.Drawing.Point(214, 9)
        Me.cb_Select_FO.Name = "cb_Select_FO"
        Me.cb_Select_FO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_FO.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_FO.Properties.Items.AddRange(New Object() {"預測訂單號", "客戶編號", "起止時間", "是否審核"})
        Me.cb_Select_FO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_FO.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_FO.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(101, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "查詢條件（&Q)："
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cb_Check_FO)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.glu_ForecastID_FO)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.de_EndDate_FO)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.de_StartDate_FO)
        Me.GroupBox5.Controls.Add(Me.glu_MO_CusterID_FO)
        Me.GroupBox5.Location = New System.Drawing.Point(90, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(277, 164)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'cb_Check_FO
        '
        Me.cb_Check_FO.AllowDrop = True
        Me.cb_Check_FO.EditValue = "全部"
        Me.cb_Check_FO.Enabled = False
        Me.cb_Check_FO.Location = New System.Drawing.Point(123, 133)
        Me.cb_Check_FO.Name = "cb_Check_FO"
        Me.cb_Check_FO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Check_FO.Properties.Appearance.Options.UseFont = True
        Me.cb_Check_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Check_FO.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_Check_FO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Check_FO.Size = New System.Drawing.Size(144, 24)
        Me.cb_Check_FO.TabIndex = 9
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(28, 138)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(89, 15)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "是否審核(&F):"
        '
        'glu_ForecastID_FO
        '
        Me.glu_ForecastID_FO.Enabled = False
        Me.glu_ForecastID_FO.Location = New System.Drawing.Point(124, 13)
        Me.glu_ForecastID_FO.Name = "glu_ForecastID_FO"
        Me.glu_ForecastID_FO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_ForecastID_FO.Properties.Appearance.Options.UseFont = True
        Me.glu_ForecastID_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_ForecastID_FO.Properties.DisplayMember = "SO_CusterID"
        Me.glu_ForecastID_FO.Properties.NullText = ""
        Me.glu_ForecastID_FO.Properties.View = Me.GridView1
        Me.glu_ForecastID_FO.Size = New System.Drawing.Size(144, 24)
        Me.glu_ForecastID_FO.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView1.DetailHeight = 360
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "訂單編號"
        Me.GridColumn1.FieldName = "ForecastID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "預測訂單號(&E)："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客戶編號(&R)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "起始時間(&S)："
        '
        'de_EndDate_FO
        '
        Me.de_EndDate_FO.EditValue = Nothing
        Me.de_EndDate_FO.Enabled = False
        Me.de_EndDate_FO.Location = New System.Drawing.Point(124, 103)
        Me.de_EndDate_FO.Name = "de_EndDate_FO"
        Me.de_EndDate_FO.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_EndDate_FO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.de_EndDate_FO.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_FO.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.de_EndDate_FO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.de_EndDate_FO.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_FO.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "截止日期(&D)："
        '
        'de_StartDate_FO
        '
        Me.de_StartDate_FO.EditValue = Nothing
        Me.de_StartDate_FO.Enabled = False
        Me.de_StartDate_FO.Location = New System.Drawing.Point(124, 73)
        Me.de_StartDate_FO.Name = "de_StartDate_FO"
        Me.de_StartDate_FO.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_StartDate_FO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.de_StartDate_FO.Properties.Appearance.Options.UseFont = True
        Me.de_StartDate_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_StartDate_FO.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.de_StartDate_FO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.de_StartDate_FO.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_StartDate_FO.Size = New System.Drawing.Size(144, 24)
        Me.de_StartDate_FO.TabIndex = 5
        '
        'glu_MO_CusterID_FO
        '
        Me.glu_MO_CusterID_FO.Enabled = False
        Me.glu_MO_CusterID_FO.Location = New System.Drawing.Point(124, 43)
        Me.glu_MO_CusterID_FO.Name = "glu_MO_CusterID_FO"
        Me.glu_MO_CusterID_FO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_MO_CusterID_FO.Properties.Appearance.Options.UseFont = True
        Me.glu_MO_CusterID_FO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MO_CusterID_FO.Properties.DisplayMember = "SO_CusterID"
        Me.glu_MO_CusterID_FO.Properties.NullText = ""
        Me.glu_MO_CusterID_FO.Properties.View = Me.GridView2
        Me.glu_MO_CusterID_FO.Size = New System.Drawing.Size(144, 24)
        Me.glu_MO_CusterID_FO.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MO_CusterID, Me.MO_CusterName})
        Me.GridView2.DetailHeight = 360
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.MO_CusterID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'MO_CusterID
        '
        Me.MO_CusterID.Caption = "客戶編號"
        Me.MO_CusterID.FieldName = "MO_CusterID"
        Me.MO_CusterID.Name = "MO_CusterID"
        Me.MO_CusterID.Visible = True
        Me.MO_CusterID.VisibleIndex = 1
        '
        'MO_CusterName
        '
        Me.MO_CusterName.Caption = "客戶名稱"
        Me.MO_CusterName.FieldName = "MO_CusterName"
        Me.MO_CusterName.Name = "MO_CusterName"
        Me.MO_CusterName.Visible = True
        Me.MO_CusterName.VisibleIndex = 0
        '
        'xtpMrpBom
        '
        Me.xtpMrpBom.Controls.Add(Me.GroupBox6)
        Me.xtpMrpBom.Controls.Add(Me.cb_Select_BOM)
        Me.xtpMrpBom.Controls.Add(Me.Label6)
        Me.xtpMrpBom.Name = "xtpMrpBom"
        Me.xtpMrpBom.PageVisible = False
        Me.xtpMrpBom.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpBom.Text = "Bom表"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cb_IsCheck_BOM)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.glu_M_Code_BOM)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.de_endDate_BOM)
        Me.GroupBox6.Controls.Add(Me.de_startDate_BOM)
        Me.GroupBox6.Location = New System.Drawing.Point(98, 39)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(260, 134)
        Me.GroupBox6.TabIndex = 137
        Me.GroupBox6.TabStop = False
        '
        'cb_IsCheck_BOM
        '
        Me.cb_IsCheck_BOM.AllowDrop = True
        Me.cb_IsCheck_BOM.EditValue = "全部"
        Me.cb_IsCheck_BOM.Enabled = False
        Me.cb_IsCheck_BOM.Location = New System.Drawing.Point(108, 42)
        Me.cb_IsCheck_BOM.Name = "cb_IsCheck_BOM"
        Me.cb_IsCheck_BOM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsCheck_BOM.Properties.Appearance.Options.UseFont = True
        Me.cb_IsCheck_BOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsCheck_BOM.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_IsCheck_BOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsCheck_BOM.Size = New System.Drawing.Size(144, 24)
        Me.cb_IsCheck_BOM.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "產品編號(&E)："
        '
        'glu_M_Code_BOM
        '
        Me.glu_M_Code_BOM.AllowDrop = True
        Me.glu_M_Code_BOM.Enabled = False
        Me.glu_M_Code_BOM.Location = New System.Drawing.Point(108, 13)
        Me.glu_M_Code_BOM.Name = "glu_M_Code_BOM"
        Me.glu_M_Code_BOM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_M_Code_BOM.Properties.Appearance.Options.UseFont = True
        Me.glu_M_Code_BOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_M_Code_BOM.Properties.NullText = ""
        Me.glu_M_Code_BOM.Properties.View = Me.GridView3
        Me.glu_M_Code_BOM.Size = New System.Drawing.Size(144, 24)
        Me.glu_M_Code_BOM.TabIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "產品編碼"
        Me.GridColumn2.FieldName = "M_Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "名稱"
        Me.GridColumn3.FieldName = "M_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "是否審核(&A)："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "截止日期(&D)："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "起始日期(&S)："
        '
        'de_endDate_BOM
        '
        Me.de_endDate_BOM.EditValue = Nothing
        Me.de_endDate_BOM.Enabled = False
        Me.de_endDate_BOM.Location = New System.Drawing.Point(108, 104)
        Me.de_endDate_BOM.Name = "de_endDate_BOM"
        Me.de_endDate_BOM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_endDate_BOM.Properties.Appearance.Options.UseFont = True
        Me.de_endDate_BOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_endDate_BOM.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_endDate_BOM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_endDate_BOM.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_endDate_BOM.Size = New System.Drawing.Size(144, 24)
        Me.de_endDate_BOM.TabIndex = 7
        '
        'de_startDate_BOM
        '
        Me.de_startDate_BOM.EditValue = Nothing
        Me.de_startDate_BOM.Enabled = False
        Me.de_startDate_BOM.Location = New System.Drawing.Point(108, 72)
        Me.de_startDate_BOM.Name = "de_startDate_BOM"
        Me.de_startDate_BOM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_startDate_BOM.Properties.Appearance.Options.UseFont = True
        Me.de_startDate_BOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_startDate_BOM.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_startDate_BOM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_startDate_BOM.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_startDate_BOM.Size = New System.Drawing.Size(144, 24)
        Me.de_startDate_BOM.TabIndex = 5
        '
        'cb_Select_BOM
        '
        Me.cb_Select_BOM.EditValue = "產品編碼"
        Me.cb_Select_BOM.Location = New System.Drawing.Point(206, 8)
        Me.cb_Select_BOM.Name = "cb_Select_BOM"
        Me.cb_Select_BOM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_BOM.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_BOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_BOM.Properties.Items.AddRange(New Object() {"產品編碼", "是否審核", "起止日期"})
        Me.cb_Select_BOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_BOM.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_BOM.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(103, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "查詢條件(&Q)："
        '
        'xtpMrpWareHouse
        '
        Me.xtpMrpWareHouse.Controls.Add(Me.cb_Select_WH)
        Me.xtpMrpWareHouse.Controls.Add(Me.GroupBox7)
        Me.xtpMrpWareHouse.Controls.Add(Me.Label10)
        Me.xtpMrpWareHouse.Name = "xtpMrpWareHouse"
        Me.xtpMrpWareHouse.PageVisible = False
        Me.xtpMrpWareHouse.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpWareHouse.Text = "庫存"
        '
        'cb_Select_WH
        '
        Me.cb_Select_WH.EditValue = "庫存單號"
        Me.cb_Select_WH.Location = New System.Drawing.Point(197, 7)
        Me.cb_Select_WH.Name = "cb_Select_WH"
        Me.cb_Select_WH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_WH.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_WH.Properties.Items.AddRange(New Object() {"庫存單號", "運算單號", "是否審核", "起始日期"})
        Me.cb_Select_WH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_WH.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_WH.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cb_Ischeck_WH)
        Me.GroupBox7.Controls.Add(Me.lblWare_ID)
        Me.GroupBox7.Controls.Add(Me.de_EndDate_WH)
        Me.GroupBox7.Controls.Add(Me.lblMRP_ID)
        Me.GroupBox7.Controls.Add(Me.de_BeginDate_WH)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.lblISMrp)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.gul_MRPID__WH)
        Me.GroupBox7.Controls.Add(Me.glu_Ware_ID_WH)
        Me.GroupBox7.Location = New System.Drawing.Point(104, 30)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(248, 166)
        Me.GroupBox7.TabIndex = 147
        Me.GroupBox7.TabStop = False
        '
        'cb_Ischeck_WH
        '
        Me.cb_Ischeck_WH.AllowDrop = True
        Me.cb_Ischeck_WH.EditValue = "全部"
        Me.cb_Ischeck_WH.Enabled = False
        Me.cb_Ischeck_WH.Location = New System.Drawing.Point(93, 73)
        Me.cb_Ischeck_WH.Name = "cb_Ischeck_WH"
        Me.cb_Ischeck_WH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Ischeck_WH.Properties.Appearance.Options.UseFont = True
        Me.cb_Ischeck_WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Ischeck_WH.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_Ischeck_WH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Ischeck_WH.Size = New System.Drawing.Size(144, 24)
        Me.cb_Ischeck_WH.TabIndex = 5
        '
        'lblWare_ID
        '
        Me.lblWare_ID.AutoSize = True
        Me.lblWare_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblWare_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWare_ID.ForeColor = System.Drawing.Color.Black
        Me.lblWare_ID.Location = New System.Drawing.Point(3, 18)
        Me.lblWare_ID.Name = "lblWare_ID"
        Me.lblWare_ID.Size = New System.Drawing.Size(90, 15)
        Me.lblWare_ID.TabIndex = 0
        Me.lblWare_ID.Text = "庫存單號(&E):"
        '
        'de_EndDate_WH
        '
        Me.de_EndDate_WH.EditValue = Nothing
        Me.de_EndDate_WH.Enabled = False
        Me.de_EndDate_WH.Location = New System.Drawing.Point(93, 134)
        Me.de_EndDate_WH.Name = "de_EndDate_WH"
        Me.de_EndDate_WH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_EndDate_WH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.de_EndDate_WH.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_WH.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.de_EndDate_WH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.de_EndDate_WH.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_WH.TabIndex = 9
        '
        'lblMRP_ID
        '
        Me.lblMRP_ID.AutoSize = True
        Me.lblMRP_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblMRP_ID.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMRP_ID.ForeColor = System.Drawing.Color.Black
        Me.lblMRP_ID.Location = New System.Drawing.Point(2, 47)
        Me.lblMRP_ID.Name = "lblMRP_ID"
        Me.lblMRP_ID.Size = New System.Drawing.Size(91, 15)
        Me.lblMRP_ID.TabIndex = 2
        Me.lblMRP_ID.Text = "运算單號(&A):"
        '
        'de_BeginDate_WH
        '
        Me.de_BeginDate_WH.EditValue = Nothing
        Me.de_BeginDate_WH.Enabled = False
        Me.de_BeginDate_WH.Location = New System.Drawing.Point(93, 103)
        Me.de_BeginDate_WH.Name = "de_BeginDate_WH"
        Me.de_BeginDate_WH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_BeginDate_WH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.de_BeginDate_WH.Properties.Appearance.Options.UseFont = True
        Me.de_BeginDate_WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_BeginDate_WH.Properties.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.de_BeginDate_WH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.de_BeginDate_WH.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_BeginDate_WH.Size = New System.Drawing.Size(144, 24)
        Me.de_BeginDate_WH.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(2, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "截止日期(&D):"
        '
        'lblISMrp
        '
        Me.lblISMrp.AutoSize = True
        Me.lblISMrp.BackColor = System.Drawing.Color.Transparent
        Me.lblISMrp.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblISMrp.ForeColor = System.Drawing.Color.Black
        Me.lblISMrp.Location = New System.Drawing.Point(4, 76)
        Me.lblISMrp.Name = "lblISMrp"
        Me.lblISMrp.Size = New System.Drawing.Size(89, 15)
        Me.lblISMrp.TabIndex = 4
        Me.lblISMrp.Text = "是否審核(&S):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "起始時間(&B):"
        '
        'gul_MRPID__WH
        '
        Me.gul_MRPID__WH.Enabled = False
        Me.gul_MRPID__WH.Location = New System.Drawing.Point(93, 43)
        Me.gul_MRPID__WH.Name = "gul_MRPID__WH"
        Me.gul_MRPID__WH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gul_MRPID__WH.Properties.Appearance.Options.UseFont = True
        Me.gul_MRPID__WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gul_MRPID__WH.Properties.DisplayMember = "SO_CusterID"
        Me.gul_MRPID__WH.Properties.NullText = ""
        Me.gul_MRPID__WH.Properties.View = Me.GridView4
        Me.gul_MRPID__WH.Size = New System.Drawing.Size(144, 24)
        Me.gul_MRPID__WH.TabIndex = 3
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MRP_ID})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.MRP_ID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'MRP_ID
        '
        Me.MRP_ID.Caption = "运算編號"
        Me.MRP_ID.FieldName = "MRP_ID"
        Me.MRP_ID.Name = "MRP_ID"
        Me.MRP_ID.ToolTip = "计划运算编码"
        Me.MRP_ID.Visible = True
        Me.MRP_ID.VisibleIndex = 0
        Me.MRP_ID.Width = 25
        '
        'glu_Ware_ID_WH
        '
        Me.glu_Ware_ID_WH.Enabled = False
        Me.glu_Ware_ID_WH.Location = New System.Drawing.Point(93, 14)
        Me.glu_Ware_ID_WH.Name = "glu_Ware_ID_WH"
        Me.glu_Ware_ID_WH.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_Ware_ID_WH.Properties.Appearance.Options.UseFont = True
        Me.glu_Ware_ID_WH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_Ware_ID_WH.Properties.DisplayMember = "SO_CusterID"
        Me.glu_Ware_ID_WH.Properties.NullText = ""
        Me.glu_Ware_ID_WH.Properties.View = Me.GridView6
        Me.glu_Ware_ID_WH.Size = New System.Drawing.Size(144, 24)
        Me.glu_Ware_ID_WH.TabIndex = 1
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "庫存單號"
        Me.GridColumn6.FieldName = "Ware_ID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(106, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "查詢條件(&Q):"
        '
        'xtpMrpMaterialCode
        '
        Me.xtpMrpMaterialCode.Controls.Add(Me.cb_Select_MC)
        Me.xtpMrpMaterialCode.Controls.Add(Me.GroupBox8)
        Me.xtpMrpMaterialCode.Controls.Add(Me.Label14)
        Me.xtpMrpMaterialCode.Name = "xtpMrpMaterialCode"
        Me.xtpMrpMaterialCode.PageVisible = False
        Me.xtpMrpMaterialCode.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpMaterialCode.Text = "物料編碼"
        '
        'cb_Select_MC
        '
        Me.cb_Select_MC.EditValue = "產品編號"
        Me.cb_Select_MC.Location = New System.Drawing.Point(203, 13)
        Me.cb_Select_MC.Name = "cb_Select_MC"
        Me.cb_Select_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_MC.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_MC.Properties.Items.AddRange(New Object() {"產品編號", "供應商編號", "是否審核", "起止日期"})
        Me.cb_Select_MC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_MC.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_MC.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cb_CheckBit_MC)
        Me.GroupBox8.Controls.Add(Me.de_BeginDate_MC)
        Me.GroupBox8.Controls.Add(Me.lblM_Code)
        Me.GroupBox8.Controls.Add(Me.de_EndDate_MC)
        Me.GroupBox8.Controls.Add(Me.glu_M_Code_MC)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.glu_S_Supplier_MC)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Location = New System.Drawing.Point(97, 36)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(262, 167)
        Me.GroupBox8.TabIndex = 283
        Me.GroupBox8.TabStop = False
        '
        'cb_CheckBit_MC
        '
        Me.cb_CheckBit_MC.AllowDrop = True
        Me.cb_CheckBit_MC.EditValue = "全部"
        Me.cb_CheckBit_MC.Enabled = False
        Me.cb_CheckBit_MC.Location = New System.Drawing.Point(106, 76)
        Me.cb_CheckBit_MC.Name = "cb_CheckBit_MC"
        Me.cb_CheckBit_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_CheckBit_MC.Properties.Appearance.Options.UseFont = True
        Me.cb_CheckBit_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_CheckBit_MC.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_CheckBit_MC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_CheckBit_MC.Size = New System.Drawing.Size(144, 24)
        Me.cb_CheckBit_MC.TabIndex = 5
        '
        'de_BeginDate_MC
        '
        Me.de_BeginDate_MC.EditValue = Nothing
        Me.de_BeginDate_MC.Enabled = False
        Me.de_BeginDate_MC.Location = New System.Drawing.Point(106, 103)
        Me.de_BeginDate_MC.Name = "de_BeginDate_MC"
        Me.de_BeginDate_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_BeginDate_MC.Properties.Appearance.Options.UseFont = True
        Me.de_BeginDate_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_BeginDate_MC.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_BeginDate_MC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_BeginDate_MC.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_BeginDate_MC.Size = New System.Drawing.Size(144, 24)
        Me.de_BeginDate_MC.TabIndex = 7
        '
        'lblM_Code
        '
        Me.lblM_Code.AutoSize = True
        Me.lblM_Code.BackColor = System.Drawing.Color.Transparent
        Me.lblM_Code.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblM_Code.ForeColor = System.Drawing.Color.Black
        Me.lblM_Code.Location = New System.Drawing.Point(11, 19)
        Me.lblM_Code.Name = "lblM_Code"
        Me.lblM_Code.Size = New System.Drawing.Size(90, 15)
        Me.lblM_Code.TabIndex = 0
        Me.lblM_Code.Text = "產品编號(&E):"
        '
        'de_EndDate_MC
        '
        Me.de_EndDate_MC.EditValue = Nothing
        Me.de_EndDate_MC.Enabled = False
        Me.de_EndDate_MC.Location = New System.Drawing.Point(106, 135)
        Me.de_EndDate_MC.Name = "de_EndDate_MC"
        Me.de_EndDate_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_EndDate_MC.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_MC.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_EndDate_MC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_EndDate_MC.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_EndDate_MC.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_MC.TabIndex = 9
        '
        'glu_M_Code_MC
        '
        Me.glu_M_Code_MC.Enabled = False
        Me.glu_M_Code_MC.Location = New System.Drawing.Point(106, 14)
        Me.glu_M_Code_MC.Name = "glu_M_Code_MC"
        Me.glu_M_Code_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_M_Code_MC.Properties.Appearance.Options.UseFont = True
        Me.glu_M_Code_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_M_Code_MC.Properties.DisplayMember = "M_Code"
        Me.glu_M_Code_MC.Properties.NullText = ""
        Me.glu_M_Code_MC.Properties.PopupFormWidth = 380
        Me.glu_M_Code_MC.Properties.ValueMember = "M_Code"
        Me.glu_M_Code_MC.Properties.View = Me.GridView5
        Me.glu_M_Code_MC.Size = New System.Drawing.Size(144, 24)
        Me.glu_M_Code_MC.TabIndex = 1
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.M_Code, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'M_Code
        '
        Me.M_Code.Caption = "產品編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.ToolTip = "產品編號"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 550
        '
        'M_Name
        '
        Me.M_Name.Caption = "產品名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 436
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 15)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "起始日期(&B):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "供應商(&A):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 15)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "截止日期(&D):"
        '
        'glu_S_Supplier_MC
        '
        Me.glu_S_Supplier_MC.Enabled = False
        Me.glu_S_Supplier_MC.Location = New System.Drawing.Point(106, 46)
        Me.glu_S_Supplier_MC.Name = "glu_S_Supplier_MC"
        Me.glu_S_Supplier_MC.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_S_Supplier_MC.Properties.Appearance.Options.UseFont = True
        Me.glu_S_Supplier_MC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_S_Supplier_MC.Properties.DisplayMember = "S_SupplierName"
        Me.glu_S_Supplier_MC.Properties.NullText = ""
        Me.glu_S_Supplier_MC.Properties.ValueMember = "S_Supplier"
        Me.glu_S_Supplier_MC.Properties.View = Me.GridView9
        Me.glu_S_Supplier_MC.Size = New System.Drawing.Size(144, 24)
        Me.glu_S_Supplier_MC.TabIndex = 3
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowAutoFilterRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "供應商編號"
        Me.GridColumn4.FieldName = "S_Supplier"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.ToolTip = "倉庫ID"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 451
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "供應商名稱"
        Me.GridColumn5.FieldName = "S_SupplierName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 755
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(42, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "審核(&S):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(107, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "查詢條件(&Q):"
        '
        'xtpMrpInfo
        '
        Me.xtpMrpInfo.Controls.Add(Me.cb_Select_MI)
        Me.xtpMrpInfo.Controls.Add(Me.GroupBox9)
        Me.xtpMrpInfo.Controls.Add(Me.Label21)
        Me.xtpMrpInfo.Name = "xtpMrpInfo"
        Me.xtpMrpInfo.PageVisible = False
        Me.xtpMrpInfo.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpInfo.Text = "物料需求運算"
        '
        'cb_Select_MI
        '
        Me.cb_Select_MI.EditValue = "運算單號"
        Me.cb_Select_MI.Location = New System.Drawing.Point(203, 2)
        Me.cb_Select_MI.Name = "cb_Select_MI"
        Me.cb_Select_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_MI.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_MI.Properties.Items.AddRange(New Object() {"運算單號", "運算條件", "運算類型", "是否審核", "起止日期"})
        Me.cb_Select_MI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_MI.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_MI.TabIndex = 1
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cb_IsCheck_MI)
        Me.GroupBox9.Controls.Add(Me.glu_MI_MRPType_MI)
        Me.GroupBox9.Controls.Add(Me.glu_MRP_ID_MI)
        Me.GroupBox9.Controls.Add(Me.glu_MI_CalcType_MI)
        Me.GroupBox9.Controls.Add(Me.de_BeginDate_MI)
        Me.GroupBox9.Controls.Add(Me.de_EndDate_MI)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Location = New System.Drawing.Point(103, 25)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(251, 181)
        Me.GroupBox9.TabIndex = 299
        Me.GroupBox9.TabStop = False
        '
        'cb_IsCheck_MI
        '
        Me.cb_IsCheck_MI.AllowDrop = True
        Me.cb_IsCheck_MI.EditValue = "全部"
        Me.cb_IsCheck_MI.Enabled = False
        Me.cb_IsCheck_MI.Location = New System.Drawing.Point(100, 100)
        Me.cb_IsCheck_MI.Name = "cb_IsCheck_MI"
        Me.cb_IsCheck_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsCheck_MI.Properties.Appearance.Options.UseFont = True
        Me.cb_IsCheck_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsCheck_MI.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_IsCheck_MI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsCheck_MI.Size = New System.Drawing.Size(144, 24)
        Me.cb_IsCheck_MI.TabIndex = 7
        '
        'glu_MI_MRPType_MI
        '
        Me.glu_MI_MRPType_MI.Enabled = False
        Me.glu_MI_MRPType_MI.Location = New System.Drawing.Point(100, 73)
        Me.glu_MI_MRPType_MI.Name = "glu_MI_MRPType_MI"
        Me.glu_MI_MRPType_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glu_MI_MRPType_MI.Properties.Appearance.Options.UseFont = True
        Me.glu_MI_MRPType_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MI_MRPType_MI.Properties.Items.AddRange(New Object() {"正式", "模擬"})
        Me.glu_MI_MRPType_MI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.glu_MI_MRPType_MI.Size = New System.Drawing.Size(144, 24)
        Me.glu_MI_MRPType_MI.TabIndex = 5
        '
        'glu_MRP_ID_MI
        '
        Me.glu_MRP_ID_MI.Enabled = False
        Me.glu_MRP_ID_MI.Location = New System.Drawing.Point(100, 13)
        Me.glu_MRP_ID_MI.Name = "glu_MRP_ID_MI"
        Me.glu_MRP_ID_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_MRP_ID_MI.Properties.Appearance.Options.UseFont = True
        Me.glu_MRP_ID_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MRP_ID_MI.Properties.DisplayMember = "M_Code"
        Me.glu_MRP_ID_MI.Properties.NullText = ""
        Me.glu_MRP_ID_MI.Properties.PopupFormWidth = 380
        Me.glu_MRP_ID_MI.Properties.ValueMember = "M_Code"
        Me.glu_MRP_ID_MI.Properties.View = Me.GridView8
        Me.glu_MRP_ID_MI.Size = New System.Drawing.Size(144, 24)
        Me.glu_MRP_ID_MI.TabIndex = 1
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "運算單號"
        Me.GridColumn9.FieldName = "MRP_ID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'glu_MI_CalcType_MI
        '
        Me.glu_MI_CalcType_MI.Enabled = False
        Me.glu_MI_CalcType_MI.Location = New System.Drawing.Point(100, 43)
        Me.glu_MI_CalcType_MI.Name = "glu_MI_CalcType_MI"
        Me.glu_MI_CalcType_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glu_MI_CalcType_MI.Properties.Appearance.Options.UseFont = True
        Me.glu_MI_CalcType_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MI_CalcType_MI.Properties.Items.AddRange(New Object() {"按需求日期", "按需求單號"})
        Me.glu_MI_CalcType_MI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.glu_MI_CalcType_MI.Size = New System.Drawing.Size(144, 24)
        Me.glu_MI_CalcType_MI.TabIndex = 3
        '
        'de_BeginDate_MI
        '
        Me.de_BeginDate_MI.EditValue = Nothing
        Me.de_BeginDate_MI.Enabled = False
        Me.de_BeginDate_MI.Location = New System.Drawing.Point(100, 125)
        Me.de_BeginDate_MI.Name = "de_BeginDate_MI"
        Me.de_BeginDate_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_BeginDate_MI.Properties.Appearance.Options.UseFont = True
        Me.de_BeginDate_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_BeginDate_MI.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_BeginDate_MI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_BeginDate_MI.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_BeginDate_MI.Size = New System.Drawing.Size(144, 24)
        Me.de_BeginDate_MI.TabIndex = 9
        '
        'de_EndDate_MI
        '
        Me.de_EndDate_MI.EditValue = Nothing
        Me.de_EndDate_MI.Enabled = False
        Me.de_EndDate_MI.Location = New System.Drawing.Point(100, 154)
        Me.de_EndDate_MI.Name = "de_EndDate_MI"
        Me.de_EndDate_MI.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_EndDate_MI.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_MI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_MI.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_EndDate_MI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_EndDate_MI.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_EndDate_MI.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_MI.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 15)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "運算單號(&E):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(5, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "運算條件(&A):"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(6, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "運算類型(&B):"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.Location = New System.Drawing.Point(36, 103)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 15)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "審核(&C):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 15)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "截止日期(&D):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 15)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "起始日期(&S):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(109, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "查詢條件(&Q):"
        '
        'xtpMrpPurchaseRecord
        '
        Me.xtpMrpPurchaseRecord.Controls.Add(Me.cb_Select_PR)
        Me.xtpMrpPurchaseRecord.Controls.Add(Me.Label29)
        Me.xtpMrpPurchaseRecord.Controls.Add(Me.GroupBox2)
        Me.xtpMrpPurchaseRecord.Controls.Add(Me.GroupBox1)
        Me.xtpMrpPurchaseRecord.Name = "xtpMrpPurchaseRecord"
        Me.xtpMrpPurchaseRecord.PageVisible = False
        Me.xtpMrpPurchaseRecord.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpPurchaseRecord.Text = "請購申請"
        '
        'cb_Select_PR
        '
        Me.cb_Select_PR.EditValue = "請購單號"
        Me.cb_Select_PR.Location = New System.Drawing.Point(112, 11)
        Me.cb_Select_PR.Name = "cb_Select_PR"
        Me.cb_Select_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_PR.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_PR.Properties.Items.AddRange(New Object() {"請購單號", "運算單號", "請購部門", "起止日期", "是否請購", "是否緊急", "是否審核"})
        Me.cb_Select_PR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_PR.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_PR.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(16, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(91, 15)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "查詢條件(&Q):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.glu_Department_PR)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.glu_MrpPurchaseID_PR)
        Me.GroupBox2.Controls.Add(Me.glu_Mrp_ID_PR)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.de_BeginDate_PR)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.de_EndDate_PR)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 161)
        Me.GroupBox2.TabIndex = 322
        Me.GroupBox2.TabStop = False
        '
        'glu_Department_PR
        '
        Me.glu_Department_PR.Enabled = False
        Me.glu_Department_PR.Location = New System.Drawing.Point(106, 72)
        Me.glu_Department_PR.Name = "glu_Department_PR"
        Me.glu_Department_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_Department_PR.Properties.Appearance.Options.UseFont = True
        Me.glu_Department_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_Department_PR.Properties.DisplayMember = "SO_CusterID"
        Me.glu_Department_PR.Properties.NullText = ""
        Me.glu_Department_PR.Properties.PopupFormWidth = 250
        Me.glu_Department_PR.Properties.View = Me.GridView15
        Me.glu_Department_PR.Size = New System.Drawing.Size(144, 24)
        Me.glu_Department_PR.TabIndex = 5
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.GridColumn29})
        Me.GridView15.DetailHeight = 100
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowAutoFilterRow = True
        Me.GridView15.OptionsView.ShowGroupPanel = False
        Me.GridView15.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn28, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "部門編號"
        Me.GridColumn28.FieldName = "DPT_ID"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "部門名稱"
        Me.GridColumn29.FieldName = "DPT_Name"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(11, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(90, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "請購單號(&E):"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(12, 76)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 15)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "請購部門(&S):"
        '
        'glu_MrpPurchaseID_PR
        '
        Me.glu_MrpPurchaseID_PR.Enabled = False
        Me.glu_MrpPurchaseID_PR.Location = New System.Drawing.Point(106, 13)
        Me.glu_MrpPurchaseID_PR.Name = "glu_MrpPurchaseID_PR"
        Me.glu_MrpPurchaseID_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_MrpPurchaseID_PR.Properties.Appearance.Options.UseFont = True
        Me.glu_MrpPurchaseID_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MrpPurchaseID_PR.Properties.DisplayMember = "M_Code"
        Me.glu_MrpPurchaseID_PR.Properties.NullText = ""
        Me.glu_MrpPurchaseID_PR.Properties.PopupFormWidth = 380
        Me.glu_MrpPurchaseID_PR.Properties.ValueMember = "M_Code"
        Me.glu_MrpPurchaseID_PR.Properties.View = Me.GridView7
        Me.glu_MrpPurchaseID_PR.Size = New System.Drawing.Size(144, 24)
        Me.glu_MrpPurchaseID_PR.TabIndex = 1
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "請購單號"
        Me.GridColumn7.FieldName = "MrpPurchaseID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'glu_Mrp_ID_PR
        '
        Me.glu_Mrp_ID_PR.Enabled = False
        Me.glu_Mrp_ID_PR.Location = New System.Drawing.Point(106, 42)
        Me.glu_Mrp_ID_PR.Name = "glu_Mrp_ID_PR"
        Me.glu_Mrp_ID_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_Mrp_ID_PR.Properties.Appearance.Options.UseFont = True
        Me.glu_Mrp_ID_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_Mrp_ID_PR.Properties.DisplayMember = "M_Code"
        Me.glu_Mrp_ID_PR.Properties.NullText = ""
        Me.glu_Mrp_ID_PR.Properties.PopupFormWidth = 380
        Me.glu_Mrp_ID_PR.Properties.ValueMember = "M_Code"
        Me.glu_Mrp_ID_PR.Properties.View = Me.GridView10
        Me.glu_Mrp_ID_PR.Size = New System.Drawing.Size(144, 24)
        Me.glu_Mrp_ID_PR.TabIndex = 3
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowAutoFilterRow = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "運算單號"
        Me.GridColumn8.FieldName = "MRP_ID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(10, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 15)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "運算單號(&A):"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 134)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 15)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "截止日期(&F):"
        '
        'de_BeginDate_PR
        '
        Me.de_BeginDate_PR.EditValue = Nothing
        Me.de_BeginDate_PR.Enabled = False
        Me.de_BeginDate_PR.Location = New System.Drawing.Point(106, 100)
        Me.de_BeginDate_PR.Name = "de_BeginDate_PR"
        Me.de_BeginDate_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_BeginDate_PR.Properties.Appearance.Options.UseFont = True
        Me.de_BeginDate_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_BeginDate_PR.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_BeginDate_PR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_BeginDate_PR.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_BeginDate_PR.Size = New System.Drawing.Size(144, 24)
        Me.de_BeginDate_PR.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 105)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 15)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "起始日期(&D):"
        '
        'de_EndDate_PR
        '
        Me.de_EndDate_PR.EditValue = Nothing
        Me.de_EndDate_PR.Enabled = False
        Me.de_EndDate_PR.Location = New System.Drawing.Point(106, 129)
        Me.de_EndDate_PR.Name = "de_EndDate_PR"
        Me.de_EndDate_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_EndDate_PR.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_PR.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_EndDate_PR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_EndDate_PR.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_EndDate_PR.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_PR.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_IsCheck_PR)
        Me.GroupBox1.Controls.Add(Me.cb_IsUrgent_PR)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.cb_IsPurchase_PR)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Location = New System.Drawing.Point(269, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 91)
        Me.GroupBox1.TabIndex = 321
        Me.GroupBox1.TabStop = False
        '
        'cb_IsCheck_PR
        '
        Me.cb_IsCheck_PR.AllowDrop = True
        Me.cb_IsCheck_PR.EditValue = "全部"
        Me.cb_IsCheck_PR.Enabled = False
        Me.cb_IsCheck_PR.Location = New System.Drawing.Point(75, 67)
        Me.cb_IsCheck_PR.Name = "cb_IsCheck_PR"
        Me.cb_IsCheck_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsCheck_PR.Properties.Appearance.Options.UseFont = True
        Me.cb_IsCheck_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsCheck_PR.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_IsCheck_PR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsCheck_PR.Size = New System.Drawing.Size(91, 24)
        Me.cb_IsCheck_PR.TabIndex = 5
        '
        'cb_IsUrgent_PR
        '
        Me.cb_IsUrgent_PR.AllowDrop = True
        Me.cb_IsUrgent_PR.EditValue = "全部"
        Me.cb_IsUrgent_PR.Enabled = False
        Me.cb_IsUrgent_PR.Location = New System.Drawing.Point(75, 37)
        Me.cb_IsUrgent_PR.Name = "cb_IsUrgent_PR"
        Me.cb_IsUrgent_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsUrgent_PR.Properties.Appearance.Options.UseFont = True
        Me.cb_IsUrgent_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsUrgent_PR.Properties.Items.AddRange(New Object() {"全部", "緊急", "一般"})
        Me.cb_IsUrgent_PR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsUrgent_PR.Size = New System.Drawing.Size(91, 24)
        Me.cb_IsUrgent_PR.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label30.Location = New System.Drawing.Point(9, 12)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 15)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "請購(&Z):"
        '
        'cb_IsPurchase_PR
        '
        Me.cb_IsPurchase_PR.AllowDrop = True
        Me.cb_IsPurchase_PR.EditValue = "全部"
        Me.cb_IsPurchase_PR.Enabled = False
        Me.cb_IsPurchase_PR.Location = New System.Drawing.Point(75, 10)
        Me.cb_IsPurchase_PR.Name = "cb_IsPurchase_PR"
        Me.cb_IsPurchase_PR.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsPurchase_PR.Properties.Appearance.Options.UseFont = True
        Me.cb_IsPurchase_PR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsPurchase_PR.Properties.Items.AddRange(New Object() {"全部", "已請購", "未請購"})
        Me.cb_IsPurchase_PR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsPurchase_PR.Size = New System.Drawing.Size(91, 24)
        Me.cb_IsPurchase_PR.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label33.Location = New System.Drawing.Point(9, 70)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 15)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "審核(&C):"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label26.Location = New System.Drawing.Point(9, 41)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 15)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "緊急(&X):"
        '
        'xtpMrpPurchaseOrder
        '
        Me.xtpMrpPurchaseOrder.Controls.Add(Me.Label35)
        Me.xtpMrpPurchaseOrder.Controls.Add(Me.GroupBox3)
        Me.xtpMrpPurchaseOrder.Controls.Add(Me.GroupBox4)
        Me.xtpMrpPurchaseOrder.Controls.Add(Me.cb_Select_PO)
        Me.xtpMrpPurchaseOrder.Name = "xtpMrpPurchaseOrder"
        Me.xtpMrpPurchaseOrder.PageVisible = False
        Me.xtpMrpPurchaseOrder.Size = New System.Drawing.Size(457, 209)
        Me.xtpMrpPurchaseOrder.Text = "採購單"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(30, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(91, 15)
        Me.Label35.TabIndex = 323
        Me.Label35.Text = "查詢條件(&Q):"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.glu_SupplierID_PO)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.glu_PO_PO)
        Me.GroupBox3.Controls.Add(Me.glu_PR_PO)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.de_BeginDate_PO)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.de_EndDate_PO)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 161)
        Me.GroupBox3.TabIndex = 326
        Me.GroupBox3.TabStop = False
        '
        'glu_SupplierID_PO
        '
        Me.glu_SupplierID_PO.EditValue = ""
        Me.glu_SupplierID_PO.Enabled = False
        Me.glu_SupplierID_PO.Location = New System.Drawing.Point(119, 70)
        Me.glu_SupplierID_PO.Name = "glu_SupplierID_PO"
        Me.glu_SupplierID_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_SupplierID_PO.Properties.Appearance.Options.UseFont = True
        Me.glu_SupplierID_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_SupplierID_PO.Properties.DisplayMember = "M_Code"
        Me.glu_SupplierID_PO.Properties.NullText = ""
        Me.glu_SupplierID_PO.Properties.PopupFormWidth = 380
        Me.glu_SupplierID_PO.Properties.ValueMember = "M_Code"
        Me.glu_SupplierID_PO.Properties.View = Me.GridView12
        Me.glu_SupplierID_PO.Size = New System.Drawing.Size(144, 24)
        Me.glu_SupplierID_PO.TabIndex = 319
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn18})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowAutoFilterRow = True
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn17, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "供應商編號"
        Me.GridColumn17.FieldName = "S_Supplier"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "供應商名稱"
        Me.GridColumn18.FieldName = "S_SupplierName"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(26, 17)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(90, 15)
        Me.Label36.TabIndex = 300
        Me.Label36.Text = "採購單號(&E):"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(12, 75)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 15)
        Me.Label37.TabIndex = 320
        Me.Label37.Text = "供應商編號(&S):"
        '
        'glu_PO_PO
        '
        Me.glu_PO_PO.Enabled = False
        Me.glu_PO_PO.Location = New System.Drawing.Point(119, 12)
        Me.glu_PO_PO.Name = "glu_PO_PO"
        Me.glu_PO_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PO_PO.Properties.Appearance.Options.UseFont = True
        Me.glu_PO_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PO_PO.Properties.DisplayMember = "M_Code"
        Me.glu_PO_PO.Properties.NullText = ""
        Me.glu_PO_PO.Properties.PopupFormWidth = 380
        Me.glu_PO_PO.Properties.ValueMember = "M_Code"
        Me.glu_PO_PO.Properties.View = Me.GridView13
        Me.glu_PO_PO.Size = New System.Drawing.Size(144, 24)
        Me.glu_PO_PO.TabIndex = 299
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowAutoFilterRow = True
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn16, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "採購單號"
        Me.GridColumn16.FieldName = "PO"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'glu_PR_PO
        '
        Me.glu_PR_PO.Enabled = False
        Me.glu_PR_PO.Location = New System.Drawing.Point(119, 41)
        Me.glu_PR_PO.Name = "glu_PR_PO"
        Me.glu_PR_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_PR_PO.Properties.Appearance.Options.UseFont = True
        Me.glu_PR_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_PR_PO.Properties.DisplayMember = "M_Code"
        Me.glu_PR_PO.Properties.NullText = ""
        Me.glu_PR_PO.Properties.PopupFormWidth = 380
        Me.glu_PR_PO.Properties.ValueMember = "M_Code"
        Me.glu_PR_PO.Properties.View = Me.GridView14
        Me.glu_PR_PO.Size = New System.Drawing.Size(144, 24)
        Me.glu_PR_PO.TabIndex = 313
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowAutoFilterRow = True
        Me.GridView14.OptionsView.ShowGroupPanel = False
        Me.GridView14.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn11, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "請購單號"
        Me.GridColumn11.FieldName = "MrpPurchaseID"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(25, 46)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(91, 15)
        Me.Label38.TabIndex = 314
        Me.Label38.Text = "請購單號(&A):"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label39.Location = New System.Drawing.Point(27, 133)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(89, 15)
        Me.Label39.TabIndex = 309
        Me.Label39.Text = "截止日期(&F):"
        '
        'de_BeginDate_PO
        '
        Me.de_BeginDate_PO.EditValue = Nothing
        Me.de_BeginDate_PO.Enabled = False
        Me.de_BeginDate_PO.Location = New System.Drawing.Point(119, 99)
        Me.de_BeginDate_PO.Name = "de_BeginDate_PO"
        Me.de_BeginDate_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_BeginDate_PO.Properties.Appearance.Options.UseFont = True
        Me.de_BeginDate_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_BeginDate_PO.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_BeginDate_PO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_BeginDate_PO.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_BeginDate_PO.Size = New System.Drawing.Size(144, 24)
        Me.de_BeginDate_PO.TabIndex = 306
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label40.Location = New System.Drawing.Point(25, 104)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(91, 15)
        Me.Label40.TabIndex = 308
        Me.Label40.Text = "起始日期(&D):"
        '
        'de_EndDate_PO
        '
        Me.de_EndDate_PO.EditValue = Nothing
        Me.de_EndDate_PO.Enabled = False
        Me.de_EndDate_PO.Location = New System.Drawing.Point(119, 128)
        Me.de_EndDate_PO.Name = "de_EndDate_PO"
        Me.de_EndDate_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_EndDate_PO.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_PO.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_EndDate_PO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_EndDate_PO.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_EndDate_PO.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_PO.TabIndex = 307
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_ReCheckBit_PO)
        Me.GroupBox4.Controls.Add(Me.cb_IsUrgency_PO)
        Me.GroupBox4.Controls.Add(Me.cb_IsCheck_PO)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Location = New System.Drawing.Point(280, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(171, 103)
        Me.GroupBox4.TabIndex = 325
        Me.GroupBox4.TabStop = False
        '
        'cb_ReCheckBit_PO
        '
        Me.cb_ReCheckBit_PO.AllowDrop = True
        Me.cb_ReCheckBit_PO.EditValue = "全部"
        Me.cb_ReCheckBit_PO.Enabled = False
        Me.cb_ReCheckBit_PO.Location = New System.Drawing.Point(69, 70)
        Me.cb_ReCheckBit_PO.Name = "cb_ReCheckBit_PO"
        Me.cb_ReCheckBit_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ReCheckBit_PO.Properties.Appearance.Options.UseFont = True
        Me.cb_ReCheckBit_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_ReCheckBit_PO.Properties.Items.AddRange(New Object() {"全部", "已複核", "未複核"})
        Me.cb_ReCheckBit_PO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_ReCheckBit_PO.Size = New System.Drawing.Size(91, 24)
        Me.cb_ReCheckBit_PO.TabIndex = 327
        '
        'cb_IsUrgency_PO
        '
        Me.cb_IsUrgency_PO.AllowDrop = True
        Me.cb_IsUrgency_PO.EditValue = "全部"
        Me.cb_IsUrgency_PO.Enabled = False
        Me.cb_IsUrgency_PO.Location = New System.Drawing.Point(69, 41)
        Me.cb_IsUrgency_PO.Name = "cb_IsUrgency_PO"
        Me.cb_IsUrgency_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsUrgency_PO.Properties.Appearance.Options.UseFont = True
        Me.cb_IsUrgency_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsUrgency_PO.Properties.Items.AddRange(New Object() {"全部", "緊急", "一般"})
        Me.cb_IsUrgency_PO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsUrgency_PO.Size = New System.Drawing.Size(91, 24)
        Me.cb_IsUrgency_PO.TabIndex = 328
        '
        'cb_IsCheck_PO
        '
        Me.cb_IsCheck_PO.AllowDrop = True
        Me.cb_IsCheck_PO.EditValue = "全部"
        Me.cb_IsCheck_PO.Enabled = False
        Me.cb_IsCheck_PO.Location = New System.Drawing.Point(69, 14)
        Me.cb_IsCheck_PO.Name = "cb_IsCheck_PO"
        Me.cb_IsCheck_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsCheck_PO.Properties.Appearance.Options.UseFont = True
        Me.cb_IsCheck_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsCheck_PO.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_IsCheck_PO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsCheck_PO.Size = New System.Drawing.Size(91, 24)
        Me.cb_IsCheck_PO.TabIndex = 329
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label41.Location = New System.Drawing.Point(10, 75)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 15)
        Me.Label41.TabIndex = 302
        Me.Label41.Text = "複核(&Z):"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label43.Location = New System.Drawing.Point(9, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(61, 15)
        Me.Label43.TabIndex = 315
        Me.Label43.Text = "緊急(&X):"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label42.Location = New System.Drawing.Point(10, 17)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(60, 15)
        Me.Label42.TabIndex = 317
        Me.Label42.Text = "審核(&C):"
        '
        'cb_Select_PO
        '
        Me.cb_Select_PO.EditValue = "採購單號"
        Me.cb_Select_PO.Location = New System.Drawing.Point(126, 11)
        Me.cb_Select_PO.Name = "cb_Select_PO"
        Me.cb_Select_PO.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_PO.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_PO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_PO.Properties.Items.AddRange(New Object() {"採購單號", "請購單號", "供應商編號", "起止日期", "是否審核", "是否緊急", "是否複核"})
        Me.cb_Select_PO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_PO.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_PO.TabIndex = 324
        '
        'xtpMps
        '
        Me.xtpMps.Controls.Add(Me.cb_Select_MM)
        Me.xtpMps.Controls.Add(Me.GroupBox10)
        Me.xtpMps.Controls.Add(Me.Label57)
        Me.xtpMps.Name = "xtpMps"
        Me.xtpMps.PageVisible = False
        Me.xtpMps.Size = New System.Drawing.Size(457, 209)
        Me.xtpMps.Text = "生產主計劃"
        '
        'cb_Select_MM
        '
        Me.cb_Select_MM.EditValue = "生產單號"
        Me.cb_Select_MM.Location = New System.Drawing.Point(204, 9)
        Me.cb_Select_MM.Name = "cb_Select_MM"
        Me.cb_Select_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Select_MM.Properties.Appearance.Options.UseFont = True
        Me.cb_Select_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_Select_MM.Properties.Items.AddRange(New Object() {"生產單號", "產品編號", "是否審核", "起止日期"})
        Me.cb_Select_MM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_Select_MM.Size = New System.Drawing.Size(144, 24)
        Me.cb_Select_MM.TabIndex = 301
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.glu_M_Code_MM)
        Me.GroupBox10.Controls.Add(Me.cb_IsCheck_MM)
        Me.GroupBox10.Controls.Add(Me.glu_MOID_MM)
        Me.GroupBox10.Controls.Add(Me.de_StarDate_MM)
        Me.GroupBox10.Controls.Add(Me.de_EndDate_MM)
        Me.GroupBox10.Controls.Add(Me.Label51)
        Me.GroupBox10.Controls.Add(Me.Label52)
        Me.GroupBox10.Controls.Add(Me.Label54)
        Me.GroupBox10.Controls.Add(Me.Label55)
        Me.GroupBox10.Controls.Add(Me.Label56)
        Me.GroupBox10.Location = New System.Drawing.Point(104, 35)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(251, 167)
        Me.GroupBox10.TabIndex = 302
        Me.GroupBox10.TabStop = False
        '
        'glu_M_Code_MM
        '
        Me.glu_M_Code_MM.Enabled = False
        Me.glu_M_Code_MM.Location = New System.Drawing.Point(99, 40)
        Me.glu_M_Code_MM.Name = "glu_M_Code_MM"
        Me.glu_M_Code_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_M_Code_MM.Properties.Appearance.Options.UseFont = True
        Me.glu_M_Code_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_M_Code_MM.Properties.DisplayMember = "M_Code"
        Me.glu_M_Code_MM.Properties.NullText = ""
        Me.glu_M_Code_MM.Properties.PopupFormWidth = 380
        Me.glu_M_Code_MM.Properties.ValueMember = "M_Code"
        Me.glu_M_Code_MM.Properties.View = Me.GridView17
        Me.glu_M_Code_MM.Size = New System.Drawing.Size(144, 24)
        Me.glu_M_Code_MM.TabIndex = 12
        '
        'GridView17
        '
        Me.GridView17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15})
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowAutoFilterRow = True
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "產品編號"
        Me.GridColumn14.FieldName = "M_Code"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "產品名稱"
        Me.GridColumn15.FieldName = "M_Name"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        '
        'cb_IsCheck_MM
        '
        Me.cb_IsCheck_MM.AllowDrop = True
        Me.cb_IsCheck_MM.EditValue = "全部"
        Me.cb_IsCheck_MM.Enabled = False
        Me.cb_IsCheck_MM.Location = New System.Drawing.Point(100, 67)
        Me.cb_IsCheck_MM.Name = "cb_IsCheck_MM"
        Me.cb_IsCheck_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_IsCheck_MM.Properties.Appearance.Options.UseFont = True
        Me.cb_IsCheck_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_IsCheck_MM.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.cb_IsCheck_MM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cb_IsCheck_MM.Size = New System.Drawing.Size(144, 24)
        Me.cb_IsCheck_MM.TabIndex = 7
        '
        'glu_MOID_MM
        '
        Me.glu_MOID_MM.Enabled = False
        Me.glu_MOID_MM.Location = New System.Drawing.Point(100, 13)
        Me.glu_MOID_MM.Name = "glu_MOID_MM"
        Me.glu_MOID_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.glu_MOID_MM.Properties.Appearance.Options.UseFont = True
        Me.glu_MOID_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glu_MOID_MM.Properties.DisplayMember = "M_Code"
        Me.glu_MOID_MM.Properties.NullText = ""
        Me.glu_MOID_MM.Properties.PopupFormWidth = 380
        Me.glu_MOID_MM.Properties.ValueMember = "M_Code"
        Me.glu_MOID_MM.Properties.View = Me.GridView16
        Me.glu_MOID_MM.Size = New System.Drawing.Size(144, 24)
        Me.glu_MOID_MM.TabIndex = 1
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13})
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowAutoFilterRow = True
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "生產計劃編號"
        Me.GridColumn13.FieldName = "MO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'de_StarDate_MM
        '
        Me.de_StarDate_MM.EditValue = Nothing
        Me.de_StarDate_MM.Enabled = False
        Me.de_StarDate_MM.Location = New System.Drawing.Point(100, 94)
        Me.de_StarDate_MM.Name = "de_StarDate_MM"
        Me.de_StarDate_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_StarDate_MM.Properties.Appearance.Options.UseFont = True
        Me.de_StarDate_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_StarDate_MM.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_StarDate_MM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_StarDate_MM.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_StarDate_MM.Size = New System.Drawing.Size(144, 24)
        Me.de_StarDate_MM.TabIndex = 9
        '
        'de_EndDate_MM
        '
        Me.de_EndDate_MM.EditValue = Nothing
        Me.de_EndDate_MM.Enabled = False
        Me.de_EndDate_MM.Location = New System.Drawing.Point(100, 121)
        Me.de_EndDate_MM.Name = "de_EndDate_MM"
        Me.de_EndDate_MM.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.de_EndDate_MM.Properties.Appearance.Options.UseFont = True
        Me.de_EndDate_MM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_EndDate_MM.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.de_EndDate_MM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.de_EndDate_MM.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.de_EndDate_MM.Size = New System.Drawing.Size(144, 24)
        Me.de_EndDate_MM.TabIndex = 11
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(6, 18)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(90, 15)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "生產單號(&E):"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(5, 45)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(91, 15)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "產品編號(&A):"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label54.Location = New System.Drawing.Point(36, 72)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 15)
        Me.Label54.TabIndex = 6
        Me.Label54.Text = "審核(&C):"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label55.Location = New System.Drawing.Point(5, 126)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(91, 15)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "截止日期(&D):"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label56.Location = New System.Drawing.Point(7, 99)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(89, 15)
        Me.Label56.TabIndex = 8
        Me.Label56.Text = "起始日期(&S):"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(110, 12)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(91, 15)
        Me.Label57.TabIndex = 300
        Me.Label57.Text = "查詢條件(&Q):"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_Title.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(4, 6)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(131, 21)
        Me.Lbl_Title.TabIndex = 197
        Me.Lbl_Title.Text = "MRP報表列印"
        '
        'M_Unit
        '
        Me.M_Unit.Caption = "產品單位"
        Me.M_Unit.FieldName = "M_Unit"
        Me.M_Unit.Name = "M_Unit"
        Me.M_Unit.Visible = True
        Me.M_Unit.VisibleIndex = 2
        Me.M_Unit.Width = 220
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code1, Me.M_Name1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'M_Code1
        '
        Me.M_Code1.Caption = "產品編碼"
        Me.M_Code1.FieldName = "M_Code"
        Me.M_Code1.Name = "M_Code1"
        Me.M_Code1.Visible = True
        Me.M_Code1.VisibleIndex = 0
        '
        'M_Name1
        '
        Me.M_Name1.Caption = "名稱"
        Me.M_Name1.FieldName = "M_Name"
        Me.M_Name1.Name = "M_Name1"
        Me.M_Name1.Visible = True
        Me.M_Name1.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "請購單號"
        Me.GridColumn10.FieldName = "MrpPurchaseID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.AllowDrop = True
        Me.ComboBoxEdit2.EditValue = "全部"
        Me.ComboBoxEdit2.Enabled = False
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(100, 100)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"全部", "已審核", "未審核"})
        Me.ComboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(144, 24)
        Me.ComboBoxEdit2.TabIndex = 7
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.Enabled = False
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(100, 73)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit3.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.Items.AddRange(New Object() {"正式", "模擬"})
        Me.ComboBoxEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(144, 24)
        Me.ComboBoxEdit3.TabIndex = 5
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Enabled = False
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(100, 13)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridLookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DisplayMember = "M_Code"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFormWidth = 380
        Me.GridLookUpEdit1.Properties.ValueMember = "M_Code"
        Me.GridLookUpEdit1.Properties.View = Me.GridView11
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(144, 24)
        Me.GridLookUpEdit1.TabIndex = 1
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowAutoFilterRow = True
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "運算單號"
        Me.GridColumn12.FieldName = "MRP_ID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.Enabled = False
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(100, 43)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit4.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit4.Properties.Items.AddRange(New Object() {"按需求日期", "按需求單號"})
        Me.ComboBoxEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(144, 24)
        Me.ComboBoxEdit4.TabIndex = 3
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(100, 125)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.DateEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEdit1.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateEdit1.Size = New System.Drawing.Size(144, 24)
        Me.DateEdit1.TabIndex = 9
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Enabled = False
        Me.DateEdit2.Location = New System.Drawing.Point(100, 154)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateEdit2.Properties.Appearance.Options.UseFont = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.Mask.EditMask = "yyyy/MM/dd"
        Me.DateEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEdit2.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateEdit2.Size = New System.Drawing.Size(144, 24)
        Me.DateEdit2.TabIndex = 11
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(6, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(90, 15)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "運算單號(&E):"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(5, 47)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(91, 15)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "運算條件(&A):"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(6, 76)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(90, 15)
        Me.Label47.TabIndex = 4
        Me.Label47.Text = "運算類型(&B):"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label48.Location = New System.Drawing.Point(36, 103)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 15)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "審核(&C):"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label49.Location = New System.Drawing.Point(5, 159)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 15)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "截止日期(&D):"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label50.Location = New System.Drawing.Point(7, 130)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(89, 15)
        Me.Label50.TabIndex = 8
        Me.Label50.Text = "起始日期(&S):"
        '
        'MrpReportSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 311)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MrpReportSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP報表列印"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.xtcTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTable.ResumeLayout(False)
        Me.xtpMrpForecastOrder.ResumeLayout(False)
        Me.xtpMrpForecastOrder.PerformLayout()
        CType(Me.cb_Select_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.cb_Check_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_ForecastID_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_StartDate_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MO_CusterID_FO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpBom.ResumeLayout(False)
        Me.xtpMrpBom.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.cb_IsCheck_BOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_M_Code_BOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_endDate_BOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_startDate_BOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Select_BOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpWareHouse.ResumeLayout(False)
        Me.xtpMrpWareHouse.PerformLayout()
        CType(Me.cb_Select_WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.cb_Ischeck_WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_BeginDate_WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gul_MRPID__WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_Ware_ID_WH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpMaterialCode.ResumeLayout(False)
        Me.xtpMrpMaterialCode.PerformLayout()
        CType(Me.cb_Select_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.cb_CheckBit_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_BeginDate_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_M_Code_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_S_Supplier_MC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpInfo.ResumeLayout(False)
        Me.xtpMrpInfo.PerformLayout()
        CType(Me.cb_Select_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.cb_IsCheck_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MI_MRPType_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MRP_ID_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MI_CalcType_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_BeginDate_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpPurchaseRecord.ResumeLayout(False)
        Me.xtpMrpPurchaseRecord.PerformLayout()
        CType(Me.cb_Select_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.glu_Department_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MrpPurchaseID_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_Mrp_ID_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_BeginDate_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cb_IsCheck_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_IsUrgent_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_IsPurchase_PR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMrpPurchaseOrder.ResumeLayout(False)
        Me.xtpMrpPurchaseOrder.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.glu_SupplierID_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_PO_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_PR_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_BeginDate_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cb_ReCheckBit_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_IsUrgency_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_IsCheck_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Select_PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMps.ResumeLayout(False)
        Me.xtpMps.PerformLayout()
        CType(Me.cb_Select_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.glu_M_Code_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_IsCheck_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glu_MOID_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_StarDate_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_EndDate_MM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents xtcTable As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpMrpForecastOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpBom As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpWareHouse As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpMaterialCode As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpPurchaseRecord As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMrpPurchaseOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents glu_MO_CusterID_FO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MO_CusterID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_CusterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents de_StartDate_FO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_EndDate_FO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_FO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents glu_ForecastID_FO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glu_M_Code_BOM As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents de_startDate_BOM As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_endDate_BOM As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_BOM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_WH As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gul_MRPID__WH As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MRP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblISMrp As System.Windows.Forms.Label
    Friend WithEvents lblWare_ID As System.Windows.Forms.Label
    Friend WithEvents lblMRP_ID As System.Windows.Forms.Label
    Friend WithEvents glu_M_Code_MC As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblM_Code As System.Windows.Forms.Label
    Friend WithEvents glu_S_Supplier_MC As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_MC As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents glu_Ware_ID_WH As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents de_EndDate_WH As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_BeginDate_WH As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents de_BeginDate_MC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_EndDate_MC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents de_BeginDate_MI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_EndDate_MI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_MI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents glu_MRP_ID_MI As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents glu_MI_MRPType_MI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents glu_MI_CalcType_MI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents glu_Mrp_ID_PR As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents de_BeginDate_PR As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_EndDate_PR As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_PR As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents glu_MrpPurchaseID_PR As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents glu_SupplierID_PO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents glu_PO_PO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents glu_PR_PO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents de_BeginDate_PO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents de_EndDate_PO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cb_Select_PO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents glu_Department_PR As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Check_FO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cb_IsCheck_BOM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_Ischeck_WH As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_CheckBit_MC As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsCheck_MI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsPurchase_PR As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsCheck_PR As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsUrgent_PR As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_ReCheckBit_PO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsUrgency_PO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_IsCheck_PO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents xtpMps As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cb_Select_MM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_IsCheck_MM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents glu_MOID_MM As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents de_StarDate_MM As DevExpress.XtraEditors.DateEdit
    Friend WithEvents de_EndDate_MM As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents glu_M_Code_MM As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class
