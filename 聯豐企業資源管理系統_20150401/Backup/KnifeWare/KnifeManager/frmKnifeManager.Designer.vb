<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnifeManager
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
        Dim WI_SReQty As DevExpress.XtraGrid.Columns.GridColumn
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("紫色鑼刀")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("其它鑼刀")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("鑼刀", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.0")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.0")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.0")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("紫色鑼刀", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.tv2 = New System.Windows.Forms.TreeView
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.PictureBoxKnife = New System.Windows.Forms.PictureBox
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.GridAllInvent = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CompanyID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SQty4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SReQty4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.采購單號2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.采購數量2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.未回數量2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridMyInvent = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.WH_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_SQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridUserKnife = New DevExpress.XtraGrid.GridControl
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FacName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DepName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOReturn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Grid6 = New DevExpress.XtraGrid.GridControl
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.部門6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.單號6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.數量6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.已發6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Grid5 = New DevExpress.XtraGrid.GridControl
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.部門5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.數量5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.天數5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.Grid9 = New DevExpress.XtraGrid.GridControl
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.采購單號8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.單價8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.幣別8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.品牌8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.Grid8 = New DevExpress.XtraGrid.GridControl
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.月份8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.用量8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Grid7 = New DevExpress.XtraGrid.GridControl
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.產品編號7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.工藝7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.在用量7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridInvent = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.M_Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.M_Gauge = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WI_Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabGuiGe = New System.Windows.Forms.Label
        Me.LabM_Name = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ButtonFind = New DevExpress.XtraEditors.SimpleButton
        Me.txtM_Code = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.LabMsg = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        WI_SReQty = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PictureBoxKnife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridAllInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMyInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridUserKnife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.Grid9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WI_SReQty
        '
        WI_SReQty.Caption = "待處理"
        WI_SReQty.FieldName = "WI_SReQty"
        WI_SReQty.Name = "WI_SReQty"
        WI_SReQty.SummaryItem.DisplayFormat = "合計:{0}"
        WI_SReQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        WI_SReQty.Visible = True
        WI_SReQty.VisibleIndex = 2
        WI_SReQty.Width = 90
        '
        'tv1
        '
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "紫色鑼刀"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "其它鑼刀"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "鑼刀"
        Me.tv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.tv1.Size = New System.Drawing.Size(181, 363)
        Me.tv1.TabIndex = 0
        '
        'tv2
        '
        Me.tv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv2.Location = New System.Drawing.Point(0, 0)
        Me.tv2.Name = "tv2"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "4.0"
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "5.0"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "6.0"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "紫色鑼刀"
        Me.tv2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.tv2.Size = New System.Drawing.Size(181, 254)
        Me.tv2.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabControl1.Location = New System.Drawing.Point(185, 407)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(464, 253)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PictureBoxKnife)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(455, 221)
        Me.XtraTabPage1.Text = "草圖"
        '
        'PictureBoxKnife
        '
        Me.PictureBoxKnife.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxKnife.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxKnife.Name = "PictureBoxKnife"
        Me.PictureBoxKnife.Size = New System.Drawing.Size(449, 213)
        Me.PictureBoxKnife.TabIndex = 0
        Me.PictureBoxKnife.TabStop = False
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.XtraTabControl2.Location = New System.Drawing.Point(657, 136)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(320, 524)
        Me.XtraTabControl2.TabIndex = 4
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Label3)
        Me.XtraTabPage2.Controls.Add(Me.GridAllInvent)
        Me.XtraTabPage2.Controls.Add(Me.Label2)
        Me.XtraTabPage2.Controls.Add(Me.Grid2)
        Me.XtraTabPage2.Controls.Add(Me.Label1)
        Me.XtraTabPage2.Controls.Add(Me.GridMyInvent)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(311, 492)
        Me.XtraTabPage2.Text = "基本情況"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "各廠庫存"
        '
        'GridAllInvent
        '
        Me.GridAllInvent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridAllInvent.EmbeddedNavigator.Name = ""
        Me.GridAllInvent.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridAllInvent.Location = New System.Drawing.Point(6, 351)
        Me.GridAllInvent.MainView = Me.GridView4
        Me.GridAllInvent.Name = "GridAllInvent"
        Me.GridAllInvent.Size = New System.Drawing.Size(307, 143)
        Me.GridAllInvent.TabIndex = 4
        Me.GridAllInvent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CompanyID, Me.WI_SQty4, Me.WI_SReQty4})
        Me.GridView4.GridControl = Me.GridAllInvent
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'CompanyID
        '
        Me.CompanyID.Caption = "公司"
        Me.CompanyID.FieldName = "CompanyID"
        Me.CompanyID.Name = "CompanyID"
        Me.CompanyID.Visible = True
        Me.CompanyID.VisibleIndex = 0
        Me.CompanyID.Width = 90
        '
        'WI_SQty4
        '
        Me.WI_SQty4.Caption = "成品刀(新刀)"
        Me.WI_SQty4.FieldName = "WI_SQty"
        Me.WI_SQty4.Name = "WI_SQty4"
        Me.WI_SQty4.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_SQty4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SQty4.Visible = True
        Me.WI_SQty4.VisibleIndex = 1
        Me.WI_SQty4.Width = 90
        '
        'WI_SReQty4
        '
        Me.WI_SReQty4.Caption = "待處理"
        Me.WI_SReQty4.FieldName = "WI_SReQty"
        Me.WI_SReQty4.Name = "WI_SReQty4"
        Me.WI_SReQty4.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_SReQty4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SReQty4.Visible = True
        Me.WI_SReQty4.VisibleIndex = 2
        Me.WI_SReQty4.Width = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "本廠采購進度"
        '
        'Grid2
        '
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(4, 185)
        Me.Grid2.MainView = Me.GridView3
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(306, 146)
        Me.Grid2.TabIndex = 2
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.采購單號2, Me.采購數量2, Me.未回數量2})
        Me.GridView3.GridControl = Me.Grid2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        '采購單號2
        '
        Me.采購單號2.Caption = "采購單號"
        Me.采購單號2.FieldName = "采購單號"
        Me.采購單號2.Name = "采購單號2"
        Me.采購單號2.Visible = True
        Me.采購單號2.VisibleIndex = 0
        Me.采購單號2.Width = 90
        '
        '采購數量2
        '
        Me.采購數量2.Caption = "采購數量"
        Me.采購數量2.FieldName = "采購數量"
        Me.采購數量2.Name = "采購數量2"
        Me.采購數量2.SummaryItem.DisplayFormat = "合計:{0}"
        Me.采購數量2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.采購數量2.Width = 90
        '
        '未回數量2
        '
        Me.未回數量2.Caption = "未回數量"
        Me.未回數量2.FieldName = "未回數量"
        Me.未回數量2.Name = "未回數量2"
        Me.未回數量2.SummaryItem.DisplayFormat = "合計:{0}"
        Me.未回數量2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.未回數量2.Visible = True
        Me.未回數量2.VisibleIndex = 1
        Me.未回數量2.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "本廠庫存"
        '
        'GridMyInvent
        '
        Me.GridMyInvent.EmbeddedNavigator.Name = ""
        Me.GridMyInvent.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridMyInvent.Location = New System.Drawing.Point(3, 22)
        Me.GridMyInvent.MainView = Me.GridView2
        Me.GridMyInvent.Name = "GridMyInvent"
        Me.GridMyInvent.Size = New System.Drawing.Size(307, 142)
        Me.GridMyInvent.TabIndex = 0
        Me.GridMyInvent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WH_Name, Me.WI_SQty, WI_SReQty})
        Me.GridView2.GridControl = Me.GridMyInvent
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'WH_Name
        '
        Me.WH_Name.Caption = "倉庫"
        Me.WH_Name.FieldName = "WH_Name"
        Me.WH_Name.Name = "WH_Name"
        Me.WH_Name.Visible = True
        Me.WH_Name.VisibleIndex = 0
        Me.WH_Name.Width = 90
        '
        'WI_SQty
        '
        Me.WI_SQty.Caption = "數量(新刀)"
        Me.WI_SQty.FieldName = "WI_SQty"
        Me.WI_SQty.Name = "WI_SQty"
        Me.WI_SQty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_SQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_SQty.Visible = True
        Me.WI_SQty.VisibleIndex = 1
        Me.WI_SQty.Width = 90
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Label4)
        Me.XtraTabPage3.Controls.Add(Me.GridUserKnife)
        Me.XtraTabPage3.Controls.Add(Me.Label6)
        Me.XtraTabPage3.Controls.Add(Me.Grid6)
        Me.XtraTabPage3.Controls.Add(Me.Label5)
        Me.XtraTabPage3.Controls.Add(Me.Grid5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageVisible = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(311, 492)
        Me.XtraTabPage3.Text = "車間狀況"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "刀具使用部門"
        '
        'GridUserKnife
        '
        Me.GridUserKnife.EmbeddedNavigator.Name = ""
        Me.GridUserKnife.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridUserKnife.Location = New System.Drawing.Point(2, 26)
        Me.GridUserKnife.MainView = Me.GridView5
        Me.GridUserKnife.Name = "GridUserKnife"
        Me.GridUserKnife.Size = New System.Drawing.Size(309, 158)
        Me.GridUserKnife.TabIndex = 8
        Me.GridUserKnife.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FacName, Me.DepName, Me.NOReturn})
        Me.GridView5.GridControl = Me.GridUserKnife
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'FacName
        '
        Me.FacName.Caption = "廠別"
        Me.FacName.FieldName = "FacName"
        Me.FacName.Name = "FacName"
        Me.FacName.Visible = True
        Me.FacName.VisibleIndex = 0
        '
        'DepName
        '
        Me.DepName.Caption = "部門"
        Me.DepName.FieldName = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.Visible = True
        Me.DepName.VisibleIndex = 1
        '
        'NOReturn
        '
        Me.NOReturn.Caption = "在用量"
        Me.NOReturn.FieldName = "NOReturn"
        Me.NOReturn.Name = "NOReturn"
        Me.NOReturn.SummaryItem.DisplayFormat = "合計:{0}"
        Me.NOReturn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.NOReturn.Visible = True
        Me.NOReturn.VisibleIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "申領用量(最近一周)"
        '
        'Grid6
        '
        Me.Grid6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid6.EmbeddedNavigator.Name = ""
        Me.Grid6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid6.Location = New System.Drawing.Point(2, 387)
        Me.Grid6.MainView = Me.GridView7
        Me.Grid6.Name = "Grid6"
        Me.Grid6.Size = New System.Drawing.Size(309, 124)
        Me.Grid6.TabIndex = 6
        Me.Grid6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.部門6, Me.單號6, Me.數量6, Me.已發6})
        Me.GridView7.GridControl = Me.Grid6
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        '部門6
        '
        Me.部門6.Caption = "部門"
        Me.部門6.FieldName = "部門"
        Me.部門6.Name = "部門6"
        Me.部門6.Visible = True
        Me.部門6.VisibleIndex = 0
        '
        '單號6
        '
        Me.單號6.Caption = "單號"
        Me.單號6.FieldName = "單號"
        Me.單號6.Name = "單號6"
        Me.單號6.Visible = True
        Me.單號6.VisibleIndex = 1
        '
        '數量6
        '
        Me.數量6.Caption = "數量"
        Me.數量6.FieldName = "數量"
        Me.數量6.Name = "數量6"
        Me.數量6.SummaryItem.DisplayFormat = "合計:{0}"
        Me.數量6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.數量6.Visible = True
        Me.數量6.VisibleIndex = 2
        '
        '已發6
        '
        Me.已發6.Caption = "已發"
        Me.已發6.FieldName = "已發"
        Me.已發6.Name = "已發6"
        Me.已發6.SummaryItem.DisplayFormat = "合計:{0}"
        Me.已發6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.已發6.Visible = True
        Me.已發6.VisibleIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "定期未還前10名"
        '
        'Grid5
        '
        Me.Grid5.EmbeddedNavigator.Name = ""
        Me.Grid5.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid5.Location = New System.Drawing.Point(2, 210)
        Me.Grid5.MainView = Me.GridView6
        Me.Grid5.Name = "Grid5"
        Me.Grid5.Size = New System.Drawing.Size(309, 152)
        Me.Grid5.TabIndex = 4
        Me.Grid5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.部門5, Me.數量5, Me.天數5})
        Me.GridView6.GridControl = Me.Grid5
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        '部門5
        '
        Me.部門5.Caption = "部門"
        Me.部門5.FieldName = "部門"
        Me.部門5.Name = "部門5"
        Me.部門5.Visible = True
        Me.部門5.VisibleIndex = 0
        '
        '數量5
        '
        Me.數量5.Caption = "數量"
        Me.數量5.FieldName = "數量"
        Me.數量5.Name = "數量5"
        Me.數量5.SummaryItem.DisplayFormat = "合計:{0}"
        Me.數量5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.數量5.Visible = True
        Me.數量5.VisibleIndex = 1
        '
        '天數5
        '
        Me.天數5.Caption = "天數"
        Me.天數5.FieldName = "天數"
        Me.天數5.Name = "天數5"
        Me.天數5.Visible = True
        Me.天數5.VisibleIndex = 2
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Label9)
        Me.XtraTabPage4.Controls.Add(Me.Grid9)
        Me.XtraTabPage4.Controls.Add(Me.Label8)
        Me.XtraTabPage4.Controls.Add(Me.Grid8)
        Me.XtraTabPage4.Controls.Add(Me.Label7)
        Me.XtraTabPage4.Controls.Add(Me.Grid7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.PageVisible = False
        Me.XtraTabPage4.Size = New System.Drawing.Size(311, 492)
        Me.XtraTabPage4.Text = "分析狀況"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "成本(最近10次單價波動)"
        '
        'Grid9
        '
        Me.Grid9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid9.EmbeddedNavigator.Name = ""
        Me.Grid9.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid9.Location = New System.Drawing.Point(6, 372)
        Me.Grid9.MainView = Me.GridView10
        Me.Grid9.Name = "Grid9"
        Me.Grid9.Size = New System.Drawing.Size(303, 137)
        Me.Grid9.TabIndex = 8
        Me.Grid9.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.采購單號8, Me.單價8, Me.幣別8, Me.品牌8})
        Me.GridView10.GridControl = Me.Grid9
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsView.ColumnAutoWidth = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        '采購單號8
        '
        Me.采購單號8.Caption = "采購單號"
        Me.采購單號8.FieldName = "采購單號"
        Me.采購單號8.Name = "采購單號8"
        Me.采購單號8.Visible = True
        Me.采購單號8.VisibleIndex = 0
        Me.采購單號8.Width = 90
        '
        '單價8
        '
        Me.單價8.Caption = "單價"
        Me.單價8.FieldName = "單價"
        Me.單價8.Name = "單價8"
        Me.單價8.Visible = True
        Me.單價8.VisibleIndex = 1
        Me.單價8.Width = 55
        '
        '幣別8
        '
        Me.幣別8.Caption = "幣別"
        Me.幣別8.FieldName = "幣別"
        Me.幣別8.Name = "幣別8"
        Me.幣別8.Visible = True
        Me.幣別8.VisibleIndex = 2
        Me.幣別8.Width = 55
        '
        '品牌8
        '
        Me.品牌8.Caption = "品牌"
        Me.品牌8.FieldName = "品牌"
        Me.品牌8.Name = "品牌8"
        Me.品牌8.Visible = True
        Me.品牌8.VisibleIndex = 3
        Me.品牌8.Width = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "最近三個月用量"
        '
        'Grid8
        '
        Me.Grid8.EmbeddedNavigator.Name = ""
        Me.Grid8.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid8.Location = New System.Drawing.Point(3, 199)
        Me.Grid8.MainView = Me.GridView9
        Me.Grid8.Name = "Grid8"
        Me.Grid8.Size = New System.Drawing.Size(308, 146)
        Me.Grid8.TabIndex = 6
        Me.Grid8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.月份8, Me.用量8})
        Me.GridView9.GridControl = Me.Grid8
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        '月份8
        '
        Me.月份8.Caption = "月份"
        Me.月份8.FieldName = "月份"
        Me.月份8.Name = "月份8"
        Me.月份8.Visible = True
        Me.月份8.VisibleIndex = 0
        '
        '用量8
        '
        Me.用量8.Caption = "用量"
        Me.用量8.FieldName = "用量"
        Me.用量8.Name = "用量8"
        Me.用量8.SummaryItem.DisplayFormat = "合計:{0}"
        Me.用量8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.用量8.Visible = True
        Me.用量8.VisibleIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "在加工產品"
        '
        'Grid7
        '
        Me.Grid7.EmbeddedNavigator.Name = ""
        Me.Grid7.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid7.Location = New System.Drawing.Point(2, 22)
        Me.Grid7.MainView = Me.GridView8
        Me.Grid7.Name = "Grid7"
        Me.Grid7.Size = New System.Drawing.Size(309, 151)
        Me.Grid7.TabIndex = 4
        Me.Grid7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.產品編號7, Me.工藝7, Me.在用量7})
        Me.GridView8.GridControl = Me.Grid7
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsView.ColumnAutoWidth = False
        Me.GridView8.OptionsView.ShowFooter = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        '產品編號7
        '
        Me.產品編號7.Caption = "產品編號"
        Me.產品編號7.FieldName = "產品編號"
        Me.產品編號7.Name = "產品編號7"
        Me.產品編號7.Visible = True
        Me.產品編號7.VisibleIndex = 0
        Me.產品編號7.Width = 90
        '
        '工藝7
        '
        Me.工藝7.Caption = "工藝"
        Me.工藝7.FieldName = "工藝"
        Me.工藝7.Name = "工藝7"
        Me.工藝7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.工藝7.Visible = True
        Me.工藝7.VisibleIndex = 1
        Me.工藝7.Width = 90
        '
        '在用量7
        '
        Me.在用量7.Caption = "在用量"
        Me.在用量7.FieldName = "在用量"
        Me.在用量7.Name = "在用量7"
        Me.在用量7.SummaryItem.DisplayFormat = "合計:{0}"
        Me.在用量7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.在用量7.Visible = True
        Me.在用量7.VisibleIndex = 2
        Me.在用量7.Width = 90
        '
        'GridInvent
        '
        Me.GridInvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridInvent.EmbeddedNavigator.Name = ""
        Me.GridInvent.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridInvent.Location = New System.Drawing.Point(185, 38)
        Me.GridInvent.MainView = Me.GridView1
        Me.GridInvent.Name = "GridInvent"
        Me.GridInvent.Size = New System.Drawing.Size(467, 363)
        Me.GridInvent.TabIndex = 5
        Me.GridInvent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.M_Code, Me.M_Name, Me.M_Gauge, Me.WI_Qty})
        Me.GridView1.GridControl = Me.GridInvent
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'M_Code
        '
        Me.M_Code.Caption = "刀具編號"
        Me.M_Code.FieldName = "M_Code"
        Me.M_Code.Name = "M_Code"
        Me.M_Code.Visible = True
        Me.M_Code.VisibleIndex = 0
        Me.M_Code.Width = 90
        '
        'M_Name
        '
        Me.M_Name.Caption = "名稱"
        Me.M_Name.FieldName = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = True
        Me.M_Name.VisibleIndex = 1
        Me.M_Name.Width = 70
        '
        'M_Gauge
        '
        Me.M_Gauge.Caption = "規格"
        Me.M_Gauge.FieldName = "M_Gauge"
        Me.M_Gauge.Name = "M_Gauge"
        Me.M_Gauge.Visible = True
        Me.M_Gauge.VisibleIndex = 2
        Me.M_Gauge.Width = 200
        '
        'WI_Qty
        '
        Me.WI_Qty.Caption = "庫存"
        Me.WI_Qty.FieldName = "Qty"
        Me.WI_Qty.Name = "WI_Qty"
        Me.WI_Qty.SummaryItem.DisplayFormat = "合計:{0}"
        Me.WI_Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.WI_Qty.Visible = True
        Me.WI_Qty.VisibleIndex = 3
        Me.WI_Qty.Width = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabGuiGe)
        Me.GroupBox1.Controls.Add(Me.LabM_Name)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ButtonFind)
        Me.GroupBox1.Controls.Add(Me.txtM_Code)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(657, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 95)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'LabGuiGe
        '
        Me.LabGuiGe.AutoSize = True
        Me.LabGuiGe.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabGuiGe.Location = New System.Drawing.Point(77, 63)
        Me.LabGuiGe.Name = "LabGuiGe"
        Me.LabGuiGe.Size = New System.Drawing.Size(70, 19)
        Me.LabGuiGe.TabIndex = 8
        Me.LabGuiGe.Text = "名       稱:"
        '
        'LabM_Name
        '
        Me.LabM_Name.AutoSize = True
        Me.LabM_Name.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabM_Name.Location = New System.Drawing.Point(77, 40)
        Me.LabM_Name.Name = "LabM_Name"
        Me.LabM_Name.Size = New System.Drawing.Size(70, 19)
        Me.LabM_Name.TabIndex = 7
        Me.LabM_Name.Text = "名       稱:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "規       格:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "名       稱:"
        '
        'ButtonFind
        '
        Me.ButtonFind.Appearance.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFind.Appearance.Options.UseFont = True
        Me.ButtonFind.Location = New System.Drawing.Point(241, 11)
        Me.ButtonFind.Name = "ButtonFind"
        Me.ButtonFind.Size = New System.Drawing.Size(52, 25)
        Me.ButtonFind.TabIndex = 4
        Me.ButtonFind.Text = "查 詢"
        '
        'txtM_Code
        '
        Me.txtM_Code.Location = New System.Drawing.Point(74, 12)
        Me.txtM_Code.Name = "txtM_Code"
        Me.txtM_Code.Properties.Appearance.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtM_Code.Properties.Appearance.Options.UseFont = True
        Me.txtM_Code.Size = New System.Drawing.Size(159, 26)
        Me.txtM_Code.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "刀具編號:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tv2)
        Me.SplitContainer1.Size = New System.Drawing.Size(181, 621)
        Me.SplitContainer1.SplitterDistance = 363
        Me.SplitContainer1.TabIndex = 7
        '
        'LabMsg
        '
        Me.LabMsg.AutoSize = True
        Me.LabMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabMsg.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabMsg.ForeColor = System.Drawing.Color.Navy
        Me.LabMsg.Location = New System.Drawing.Point(6, 6)
        Me.LabMsg.Name = "LabMsg"
        Me.LabMsg.Size = New System.Drawing.Size(178, 24)
        Me.LabMsg.TabIndex = 206
        Me.LabMsg.Text = "刀具信息一覽表"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(973, 36)
        Me.PictureBox2.TabIndex = 205
        Me.PictureBox2.TabStop = False
        '
        'frmKnifeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 661)
        Me.Controls.Add(Me.LabMsg)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridInvent)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmKnifeManager"
        Me.Text = "刀具信息一覽表"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PictureBoxKnife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GridAllInvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMyInvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.GridUserKnife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.Grid9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtM_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents tv2 As System.Windows.Forms.TreeView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureBoxKnife As System.Windows.Forms.PictureBox
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridMyInvent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WH_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 采購單號2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 采購數量2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 未回數量2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridAllInvent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompanyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SQty4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_SReQty4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grid5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 部門5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 數量5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 天數5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Grid6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 部門6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 單號6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 數量6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 已發6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Grid7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 產品編號7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 工藝7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 在用量7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Grid8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 月份8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 用量8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Grid9 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridUserKnife As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents 采購單號8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 單價8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 幣別8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents 品牌8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridInvent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Gauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WI_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtM_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ButtonFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabGuiGe As System.Windows.Forms.Label
    Friend WithEvents LabM_Name As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LabMsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FacName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOReturn As DevExpress.XtraGrid.Columns.GridColumn

End Class
