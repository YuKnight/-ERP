Imports CrystalDecisions.Shared
Imports LFERP.Library.MrpManager.MrpInfo
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.MrpSetting
Imports LFERP.Library.MrpManager.MrpForecastOrder
Imports LFERP.Library.MrpManager.MrpWareHouseInfo
Imports LFERP.Library.MrpManager.MrpPurchaseRecord
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports System.Threading
Imports System.Linq
Imports System.Linq.Enumerable

Public Class frmMrpInfo

#Region "字段屬性"
    Dim ds As New DataSet
    Dim mc As New MrpInfoController
    Dim MRPBill_DelAutoID As String = ""            '記錄產品明細表被刪除的AutoID
    Dim MRPOrderBill_DelAutoID As String = ""       '記錄訂單明細表被刪除的AutoID
    Dim MRPPurchase_DelAutoID As String = ""        '記錄建議請購表被刪除的AutoID
    Dim MRPAction As Boolean = False                '標記是否點擊過獲取訂單信息按鈕
    Dim bMRPGetPurchase As Boolean = False          '標記是否點擊過生成請購建議按鈕
    Dim tempbo As Boolean = False                   'CheckEdit_CheckedChanged事件中引用
    Dim boCheck As Boolean = False                  '用來判斷審核狀態是否有改變
    Private tempMrpID As String = ""
    Private _EditItem As String
    Private _MRPID As String
    Dim mri As New MrpCalcRecordInfo
    Dim msc As New MrpSettingController
    Dim mwc As New MrpWareHouseInfoController
    Dim mmcc As New MrpMaterialCodeController
    Dim mfc As New MrpForecastOrderController
    Dim mbc As New MrpDestBillsController
    Dim mobc As New MrpOrderDestBillsController
    Dim mpc As New MrpPurchaseController

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property

    Property MRPID() As String '屬性
        Get
            Return _MRPID
        End Get
        Set(ByVal value As String)
            _MRPID = value
        End Set
    End Property

#End Region

#Region "創建臨時表"
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("MRPDestBills")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("MRP_ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("Source", GetType(String))
            .Columns.Add("MRPQty", GetType(Decimal))
            .Columns.Add("MP_InventoryQty", GetType(Decimal))
        End With

        With ds.Tables.Add("MRPOrderDestBills")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("MRP_ID", GetType(String))
            .Columns.Add("OD_ID", GetType(String))
            .Columns.Add("MOB_ForecastID", GetType(String))
            .Columns.Add("MOB_NeedDate", GetType(Date))
            .Columns.Add("customerName", GetType(String))
            .Columns.Add("MRPQty", GetType(Decimal))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("Source", GetType(String))
        End With

        With ds.Tables.Add("MRPPurchase")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("MRP_ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("Source", GetType(String))
            .Columns.Add("MP_NeedQty", GetType(Decimal))
            .Columns.Add("MP_MRPQty", GetType(Decimal))
            .Columns.Add("MP_InventoryQty", GetType(Decimal))
            .Columns.Add("MP_InTransitQty", GetType(Decimal))
            .Columns.Add("MP_Inspection", GetType(Decimal))
            .Columns.Add("MP_NoCollar", GetType(Decimal))
            .Columns.Add("MP_RetreatQty", GetType(Decimal))
            .Columns.Add("MP_RelatedQty", GetType(Decimal))
            .Columns.Add("MP_SecInv", GetType(Decimal))
            .Columns.Add("MP_LowLimit", GetType(Decimal))
            .Columns.Add("MP_BatchQty", GetType(Decimal))
            .Columns.Add("MP_BatFixEconomy", GetType(Decimal))
            .Columns.Add("MP_OrderMax", GetType(Decimal))
            .Columns.Add("MP_OrderMin", GetType(Decimal))
            .Columns.Add("MP_NeedDate", GetType(Date))
        End With

        With ds.Tables.Add("MRPIndReq")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("MRP_ID", GetType(String))
            .Columns.Add("PID", GetType(String))
            .Columns.Add("ID", GetType(String))
            .Columns.Add("sonsNum", GetType(Int16))
            .Columns.Add("ForecastID", GetType(String))
            .Columns.Add("NeedDate", GetType(Date))
            .Columns.Add("InvalidDate", GetType(Date))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("NeedQty", GetType(Decimal))
            .Columns.Add("Source", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
        End With

        grid1.DataSource = ds.Tables("MRPDestBills")
        grid2.DataSource = ds.Tables("MRPOrderDestBills")
        grid3.DataSource = ds.Tables("MRPPurchase")
        'TreeList1.DataSource = ds.Tables("MRPIndReq")
    End Sub
#End Region

#Region "填充臨時表"
    Sub FillTable(ByVal tableName As String, ByVal infoList As Object)
        Try
            Dim row As DataRow
            Dim i As Integer
            Select Case tableName
                Case "MRPDestBills"
                    Dim mbi As New List(Of MrpDestBillsInfo)
                    mbi = infoList
                    For i = 0 To mbi.Count - 1
                        row = ds.Tables("MRPDestBills").NewRow
                        row("AutoID") = mbi(i).AutoID
                        row("MRP_ID") = mbi(i).MRP_ID
                        row("M_Code") = mbi(i).M_Code
                        row("M_Name") = mbi(i).M_Name
                        row("M_Gauge") = mbi(i).M_Gauge
                        row("M_Unit") = mbi(i).M_Unit
                        row("Source") = mbi(i).Source
                        row("MRPQty") = mbi(i).MB_MRPQty
                        row("MP_InventoryQty") = mbi(i).MP_InventoryQty
                        ds.Tables("MRPDestBills").Rows.Add(row)
                    Next
                Case "MRPOrderDestBills"
                    Dim mobi As New List(Of MRPOrderDestBillsInfo)
                    mobi = infoList
                    For i = 0 To mobi.Count - 1
                        row = ds.Tables("MRPOrderDestBills").NewRow
                        row("AutoID") = mobi(i).AutoID
                        row("MRP_ID") = mobi(i).MRP_ID
                        row("OD_ID") = mobi(i).OD_ID
                        row("MOB_ForecastID") = mobi(i).MOB_ForecastID
                        row("MOB_NeedDate") = mobi(i).MOB_NeedDate
                        row("customerName") = mobi(i).customerName
                        row("MRPQty") = mobi(i).MOB_MRPQty
                        row("M_Code") = mobi(i).M_Code
                        row("M_Name") = mobi(i).M_Name
                        row("M_Gauge") = mobi(i).M_Gauge
                        row("M_Unit") = mobi(i).M_Unit
                        row("Source") = mobi(i).Source
                        ds.Tables("MRPOrderDestBills").Rows.Add(row)
                    Next
                Case "MRPPurchase"
                    Dim mpi As New List(Of MrpPurchaseInfo)
                    mpi = infoList
                    For i = 0 To mpi.Count - 1
                        row = ds.Tables("MRPPurchase").NewRow
                        row("AutoID") = mpi(i).AutoID
                        row("MRP_ID") = mpi(i).MRP_ID
                        row("M_Code") = mpi(i).M_Code
                        row("M_Name") = mpi(i).M_Name
                        row("M_Gauge") = mpi(i).M_Gauge
                        row("M_Unit") = mpi(i).M_Unit
                        row("Source") = mpi(i).Source
                        row("MP_NeedQty") = mpi(i).MP_NeedQty
                        row("MP_MRPQty") = mpi(i).MP_MRPQty
                        row("MP_InventoryQty") = mpi(i).MP_InventoryQty
                        row("MP_InTransitQty") = mpi(i).MP_InTransitQty
                        row("MP_Inspection") = mpi(i).MP_Inspection
                        row("MP_NoCollar") = mpi(i).MP_NoCollar
                        row("MP_RetreatQty") = mpi(i).MP_RetreatQty
                        row("MP_RelatedQty") = mpi(i).MP_RelatedQty
                        row("MP_SecInv") = mpi(i).MP_SecInv
                        row("MP_LowLimit") = mpi(i).MP_LowLimit
                        row("MP_BatchQty") = mpi(i).MP_BatchQty
                        row("MP_BatFixEconomy") = mpi(i).MP_BatFixEconomy
                        row("MP_OrderMax") = mpi(i).MP_OrderMax
                        row("MP_OrderMin") = mpi(i).MP_OrderMin
                        row("MP_NeedDate") = mpi(i).MP_NeedDate
                        ds.Tables("MRPPurchase").Rows.Add(row)
                    Next
                Case "MRPIndReq"
                    Dim mii As New List(Of MrpIndReqInfo)
                    mii = infoList
                    For i = 0 To mii.Count - 1
                        row = ds.Tables("MRPIndReq").NewRow
                        row("AutoID") = mii(i).AutoID
                        row("MRP_ID") = mii(i).MRP_ID
                        row("PID") = mii(i).PID
                        row("ID") = mii(i).ID
                        row("sonsNum") = mii(i).sonsNum
                        row("ForecastID") = mii(i).ForecastID
                        row("NeedDate") = mii(i).NeedDate
                        row("InvalidDate") = mii(i).InvalidDate
                        row("M_Code") = mii(i).M_Code
                        row("NeedQty") = mii(i).NeedQty
                        row("Source") = mii(i).Source
                        row("M_Name") = mii(i).M_Name
                        row("M_Gauge") = mii(i).M_Gauge
                        row("M_Unit") = mii(i).M_Unit
                        ds.Tables("MRPIndReq").Rows.Add(row)
                    Next
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FillTable方法出錯")
        End Try
    End Sub
#End Region

#Region "窗體加載事件"

#Region "窗體加載"
    Private Sub frmMRP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToLookUpEdit()
        CreateTables()
        chkDate.Checked = True
        pceForecastID.Properties.PopupControl = Nothing
        Select Case EditItem
            Case EditEnumType.ADD
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.ADD)
                Me.Text = lblTitle.Text
                txtMRP_ID.EditValue = "自動編號"
                xtpCheck.PageVisible = False
                dteCreateDate.EditValue = Format(Now(), "yyyy/MM/dd")
                SetControlEnable(True, True)
            Case EditEnumType.EDIT
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.EDIT)
                Me.Text = lblTitle.Text
                xtpCheck.PageVisible = False
                chkDate.Enabled = False
                chkForecastID.Enabled = False
                SetControlEnable(True, True)
                LoadData(MRPID)
            Case EditEnumType.VIEW
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.VIEW)
                Me.Text = lblTitle.Text
                SetControlEnable(False, False)
                LoadData(MRPID)
            Case EditEnumType.CHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.CHECK)
                Me.Text = lblTitle.Text
                XtraTabControl1.SelectedTabPage = xtpCheck
                SetControlEnable(False, True)
                LoadData(MRPID)
        End Select
        TreeList1.ExpandAll()
    End Sub
#End Region

#Region "把物料基本信息加載到LookUpEdit控件中"
    Private Sub LoadDataToLookUpEdit()
        Dim list As New List(Of MrpMaterialCodeInfo)
        If EditItem = EditEnumType.ADD Then
            list = mmcc.MrpMaterialCode_GetList(Nothing, Nothing, "True", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Else
            list = mmcc.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If

        GridMaterial1.DataSource = list
        GridMaterial2.DataSource = list
        GridMaterial3.DataSource = list
        'GridViewMaterial3.ActiveFilterString = "MC_Source like '原%'"
        chklbForecastID.DataSource = mfc.MrpForecastOrder_GetDataTable()
    End Sub

#End Region

#Region "CheckEdit_CheckedChanged"
    Private Sub CheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForecastID.CheckedChanged, chkDate.CheckedChanged
        If tempbo = True Then
            Exit Sub
        End If
        Select Case sender.Name
            Case "chkDate"
                dteNeedBeginDate.Enabled = True
                dteNeedEndDate.Enabled = True
                pceForecastID.Properties.PopupControl = Nothing
                pceForecastID.EditValue = Nothing
                chkDate.Checked = True
                tempbo = True
                chkForecastID.Checked = False
                tempbo = False
                lblDescrip.Text = "按訂單交期運算"
            Case "chkForecastID"
                dteNeedBeginDate.Enabled = False
                dteNeedEndDate.Enabled = False
                dteNeedBeginDate.EditValue = Nothing
                dteNeedEndDate.EditValue = Nothing
                pceForecastID.Properties.PopupControl = pccForecastID
                chkForecastID.Checked = True
                tempbo = True
                chkDate.Checked = False
                tempbo = False
                lblDescrip.Text = "按預測訂單運算"
        End Select
    End Sub
#End Region

#End Region

#Region "加載數據"
    Dim threadIndReq As Thread
    Delegate Sub DelegateSetDataSource(ByVal dataSource As Object, ByVal control As Object)
    Delegate Sub DelegateSetPictureBox()
    Private Sub LoadData(ByVal MRPID As String)
        Dim objInfo As List(Of MRPInfoInfo)
        Try
            '-----------------MRP運算記錄表-----------------------
            objInfo = mc.MrpInfo_GetList(MRPID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                Exit Sub
            End If
            If objInfo(0).MI_CalcType = 1 Then
                chkDate.Checked = True
                dteNeedBeginDate.EditValue = objInfo(0).MI_NeedBeginDate
                dteNeedEndDate.EditValue = objInfo(0).MI_NeedEndDate
                pceForecastID.EditValue = Nothing
            Else
                chkForecastID.Checked = True
                dteNeedBeginDate.EditValue = Nothing
                dteNeedEndDate.EditValue = Nothing
                pceForecastID.EditValue = objInfo(0).MI_ForecastID
            End If
            'tempMrpID = MRPID
            txtMRP_ID.EditValue = MRPID
            lblWareID.Text = objInfo(0).MI_WareID
            btnMrp.Tag = objInfo(0).MI_MRPDate
            dteCreateDate.EditValue = objInfo(0).MI_CreateDate

            txtCreateUserName.Text = objInfo(0).MI_CreateUserName
            txtRemarks.Text = objInfo(0).MI_Remarks
            If (objInfo(0).MI_MRPType = "0") Then
                cboMRPType.SelectedIndex = 0
            Else
                cboMRPType.SelectedIndex = 1
            End If
            txtlogtxt.EditValue = objInfo(0).MI_LogTxt

            boCheck = objInfo(0).MI_CheckBit
            If objInfo(0).MI_CheckBit = True Then
                chkCheck.Checked = True
                lblCheckUser.Text += objInfo(0).MI_CheckUserName
                lblCheckDate.Text += IIf(objInfo(0).MI_CheckDate = Nothing, "", Format(CDate(objInfo(0).MI_CheckDate), "yyyy/MM/dd"))
                txtCheckRemark.Text = objInfo(0).MI_CheckRemark
            ElseIf EditItem = EditEnumType.CHECK Then
                lblCheckUser.Text += InUser
                lblCheckDate.Text += Format(Now, "yyyy/MM/dd")
            End If

            '-----------------MRP產品明細表-----------------------
            Dim mbi As New List(Of MrpDestBillsInfo)
            Dim mbc As New MrpDestBillsController
            mbi = mbc.MrpDestBills_GetList(MRPID)
            If mbi.Count > 0 Then
                FillTable("MRPDestBills", mbi)
            End If

            '-----------------MRP訂單物料明細表--------------------
            Dim mobi As New List(Of MrpOrderDestBillsInfo)
            Dim mobc As New MrpOrderDestBillsController
            mobi = mobc.MRPOrderDestBills_GetList(MRPID)
            If mobi.Count > 0 Then
                FillTable("MRPOrderDestBills", mobi)
            End If

            '-----------------MRP請購建議表--------------------------
            Dim mpi As New List(Of MrpPurchaseInfo)
            Dim mpc As New MrpPurchaseController
            mpi = mpc.MrpPurchase_GetList(MRPID)
            If mpi.Count > 0 Then
                FillTable("MRPPurchase", mpi)
            End If

            pbIndreq.Visible = True
            pbIndreq.BringToFront()
            If threadIndReq Is Nothing = False Then
                threadIndReq.Abort()
            End If
            threadIndReq = New Thread(AddressOf LoadIndReq)
            threadIndReq.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadData方法出錯")
        End Try
    End Sub

    Private Sub LoadIndReq()
        Try
            '-----------------MRP獨立需求--------------------------
            Dim mii As New List(Of MrpIndReqInfo)
            Dim mic As New MrpIndReqController
            mii = mic.MrpIndReq_GetList(MRPID)
            If mii.Count > 0 Then
                FillTable("MRPIndReq", mii)
            End If
            Dim s As New DelegateSetDataSource(AddressOf SetControlDataSource)
            Dim p As New DelegateSetPictureBox(AddressOf SetPictureBox)
            Me.Invoke(s, ds.Tables("MRPIndReq"), TreeList1)
            pbIndreq.Invoke(p)
            threadIndReq.Abort()
        Catch ex As Exception
            If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadIndReq方法出錯")
            End If
        End Try
    End Sub

    Private Sub SetControlDataSource(ByVal dataSource As Object, ByVal control As Object)
        Try
            control.DataSource = dataSource
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SetControlDataSource方法出錯")
        End Try
    End Sub

    Private Sub SetPictureBox()
        Try
            pbIndreq.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SetPictureBox方法出錯")
        End Try
    End Sub
#End Region

#Region "設置各控件的Enable屬性"
    Private Sub SetControlEnable(ByVal a As Boolean, ByVal b As Boolean)
        dteNeedBeginDate.Enabled = a
        dteNeedEndDate.Enabled = a
        cboMRPType.Enabled = a
        pceForecastID.Enabled = a
        txtRemarks.Enabled = a
        chkDate.Enabled = a
        chkForecastID.Enabled = a
        btnSave.Enabled = b
        btnMrp.Enabled = a
        btnInsertWareHouse.Enabled = a
        btnGetPurchase.Enabled = a
        chkCheck.Enabled = b
        txtCheckRemark.Enabled = b
        'lblCheckUser.Visible = IIf(a Or b, False, True)
        'lblCheckDate.Visible = IIf(a Or b, False, True)
        GridView2.OptionsBehavior.Editable = a
        GridView3.OptionsBehavior.Editable = a
        BandedGridView1.OptionsBehavior.Editable = a

        If a = False Then
            grid1.ContextMenuStrip = Nothing
            grid2.ContextMenuStrip = Nothing
            grid3.ContextMenuStrip = Nothing
        End If
    End Sub
#End Region

#Region "獲取MRP運算單流水號"
    Private Function GetMRP_ID() As String
        Dim ndate, id As String
        ndate = "MI" + Format(Now(), "yyMM")
        id = mc.MrpInfo_GetID()
        If id Is Nothing Then
            GetMRP_ID = ndate + "0001"
        Else
            GetMRP_ID = ndate + Mid((CInt(Mid(id, 7)) + 10001), 2)
        End If
    End Function
#End Region

#Region "右擊菜單事件"
    Private Sub cms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBillAdd.Click, cmdBillDel.Click, cmsOrderBillAdd.Click, cmsOrderBillDel.Click, cmsPurchaseAdd.Click, cmsPurchaseDel.Click, cmsPurchasePrint.Click
        Select Case sender.Name
            Case "cmsBillAdd"
                Dim row As DataRow
                row = ds.Tables("MRPDestBills").NewRow
                row("MRPQty") = 0
                row("AutoID") = 0
                ds.Tables("MRPDestBills").Rows.Add(row)
                GridView2.FocusedRowHandle = GridView2.RowCount - 1
            Case "cmdBillDel"
                If (GridView2.GetFocusedRowCellValue("AutoID").ToString <> "0") Then
                    MRPBill_DelAutoID += GridView2.GetFocusedRowCellValue("AutoID").ToString + ","
                End If
                ds.Tables("MRPDestBills").Rows.RemoveAt(GridView2.FocusedRowHandle)

            Case "cmsOrderBillAdd"
                Dim row As DataRow
                row = ds.Tables("MRPOrderDestBills").NewRow
                row("MRPQty") = 0
                row("AutoID") = 0
                row("MOB_NeedDate") = Format(Now, "yyyy/MM/dd")
                ds.Tables("MRPOrderDestBills").Rows.Add(row)
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
            Case "cmsOrderBillDel"
                If (GridView3.GetFocusedRowCellValue("AutoID").ToString <> "0") Then
                    MRPOrderBill_DelAutoID += GridView3.GetFocusedRowCellValue("AutoID").ToString + ","
                End If
                ds.Tables("MRPOrderDestBills").Rows.RemoveAt(GridView3.FocusedRowHandle)

            Case "cmsPurchaseAdd"
                Dim row As DataRow
                row = ds.Tables("MRPPurchase").NewRow
                row("AutoID") = 0
                row("MP_NeedDate") = Now
                row("MP_NeedQty") = 0
                row("MP_MRPQty") = 0
                row("MP_InventoryQty") = 0
                row("MP_InTransitQty") = 0
                row("MP_Inspection") = 0
                row("MP_NoCollar") = 0
                row("MP_RetreatQty") = 0
                row("MP_RelatedQty") = 0
                row("MP_SecInv") = 0
                row("MP_LowLimit") = 0
                row("MP_BatchQty") = 0
                row("MP_BatFixEconomy") = 0
                row("MP_OrderMax") = 0
                row("MP_OrderMin") = 0
                ds.Tables("MRPPurchase").Rows.Add(row)
                BandedGridView1.FocusedRowHandle = BandedGridView1.RowCount - 1
            Case "cmsPurchaseDel"
                If (BandedGridView1.GetFocusedRowCellValue("AutoID").ToString <> "0") Then
                    MRPPurchase_DelAutoID += BandedGridView1.GetFocusedRowCellValue("AutoID").ToString + ","
                End If
                ds.Tables("MRPPurchase").Rows.RemoveAt(BandedGridView1.FocusedRowHandle)
                SetRightMenuEnable(sender)
        End Select
    End Sub

    Private Sub grid_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid1.MouseDown, grid2.MouseDown, grid3.MouseDown
        If e.Button() = Windows.Forms.MouseButtons.Right Then
            SetRightMenuEnable(sender)
        End If
    End Sub
    Private Sub SetRightMenuEnable(ByVal sender As Object)
        Select Case sender.name
            Case "grid1"
                If GridView2.RowCount < 1 Then
                    cmsBill.Items("cmdBillDel").Enabled = False
                Else
                    cmsBill.Items("cmdBillDel").Enabled = True
                End If
            Case "grid2"
                If GridView3.RowCount < 1 Then
                    cmsOrderBill.Items("cmsOrderBillDel").Enabled = False
                Else
                    cmsOrderBill.Items("cmsOrderBillDel").Enabled = True
                End If
            Case "grid3"
                If BandedGridView1.RowCount < 1 Then
                    cmsPurchase.Items("cmsPurchaseDel").Enabled = False
                Else
                    cmsPurchase.Items("cmsPurchaseDel").Enabled = True
                End If
        End Select
    End Sub

#End Region

#Region "選擇物料編碼時帶出物料名稱等信息"
    Private Sub GridViewMateria_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewMaterial1.DoubleClick, GridViewMaterial2.DoubleClick, GridViewMaterial3.DoubleClick
        Dim gridView, gridViewParent As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim popc As New DevExpress.XtraEditors.PopupContainerControl
        Dim tableName As String = ""
        Dim M_Code, M_Name, M_Gauge, M_Unit, Source As String
        gridView = sender
        M_Code = gridView.GetFocusedRowCellValue("M_Code").ToString
        M_Name = gridView.GetFocusedRowCellValue("M_Name").ToString
        M_Gauge = gridView.GetFocusedRowCellValue("M_Gauge").ToString
        M_Unit = gridView.GetFocusedRowCellValue("M_Unit").ToString
        Source = gridView.GetFocusedRowCellValue("MC_Source").ToString
        Select Case sender.Name
            Case "GridViewMaterial1"
                tableName = "MRPDestBills"
                gridViewParent = GridView2
                popc = PopupContainerControl1
            Case "GridViewMaterial2"
                tableName = "MRPOrderDestBills"
                gridViewParent = GridView3
                popc = PopupContainerControl2
            Case "GridViewMaterial3"
                tableName = "MRPPurchase"
                gridViewParent = BandedGridView1
                popc = PopupContainerControl3
        End Select

        ds.Tables(tableName).Rows(gridViewParent.FocusedRowHandle)("M_Code") = M_Code
        ds.Tables(tableName).Rows(gridViewParent.FocusedRowHandle)("M_Name") = M_Name
        ds.Tables(tableName).Rows(gridViewParent.FocusedRowHandle)("M_Gauge") = M_Gauge
        ds.Tables(tableName).Rows(gridViewParent.FocusedRowHandle)("M_Unit") = M_Unit
        ds.Tables(tableName).Rows(gridViewParent.FocusedRowHandle)("Source") = Source
        popc.OwnerEdit.ClosePopup()
        btnSave.Focus()
    End Sub
#End Region

#Region "Mrp運算"

#Region "獲取訂單信息"
    Private Sub btnMrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMrp.Click
        If CheckHaveSetting() = False Then
            Exit Sub
        End If
        If CheckSave(btnMrp) = False Then
            Exit Sub
        End If

        If MRP_AuditingResult() = False Then
            xtpAuditing.PageVisible = True
            XtraTabControl1.SelectedTabPage = xtpAuditing
            MsgBox("請先處理稽核頁面處未處理的記錄", MsgBoxStyle.Information, "提示")
            Exit Sub
        Else
            xtpAuditing.PageVisible = False
        End If

        prb.Visible = True                '顯示進度條
        prb.Position = 0
        txtlogtxt.Visible = False

        btnMrp.Tag = Now.ToString("yyyy/MM/dd")        'MRP運算日期
        MRPAction = True

        Dim msi As New MrpSettingInfo
        Dim msc As New MrpSettingController
        msi = msc.MrpSetting_GetList(InUserID)(0)

        Dim mc As New MrpInfoController
        mc.MRP_ID = txtMRP_ID.EditValue
        mc.userID = InUserID
        Dim tempTable As New DataTable

        '----------------產品明細表--------------------
        mc.dt = ds.Tables("MRPDestBills")
        If chkDate.Checked Then
            mc.GetBills(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing)
        ElseIf chkForecastID.Checked Then
            mc.GetBills(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString)
        End If

        prb.PerformStep()
        Application.DoEvents()

        '----------------訂單物料明細----------------
        mc.dt = ds.Tables("MRPOrderDestBills")
        If chkDate.Checked Then
            mc.GetOrderBills(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing)
        ElseIf chkForecastID.Checked Then
            mc.GetOrderBills(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString)
        End If

        '-------------獨立需求----------------------
        mc.dt = ds.Tables("MRPIndReq")
        If chkDate.Checked Then
            mc.GetIndReq(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing)
        ElseIf chkForecastID.Checked Then
            mc.GetIndReq(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString)
        End If
        TreeList1.DataSource = ds.Tables("MRPIndReq")
        TreeList1.ExpandAll()
        prb.PerformStep()
        Application.DoEvents()
        pnlDeclare.Visible = True
        btnInsertWareHouse.Focus()
    End Sub
#End Region

#Region "轉庫存記錄"
    Private Sub btnInsertWareHouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertWareHouse.Click
        If CheckSave(btnInsertWareHouse) = False Then
            Exit Sub
        End If
        If ds.Tables("MRPOrderDestBills").DefaultView.Count < 1 Then
            MsgBox("訂單物料明細中不存在資料，無法轉存。" + vbCrLf + " (請檢查Bom表和參數設置或該預測訂單是否已運算過)", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        GridView2.OptionsBehavior.Editable = False   '產品明細
        GridView3.OptionsBehavior.Editable = False   '訂單物料明細

        Dim tb As New DataTable
        Dim msi As New MrpSettingInfo
        msi = msc.MrpSetting_GetList(InUserID)(0)
        If chkDate.Checked Then
            tb = mc.Mrp_GetMrpInfoWareHouse(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing)
        ElseIf chkForecastID.Checked Then
            tb = mc.Mrp_GetMrpInfoWareHouse(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString)
        End If

        Dim mlist As New List(Of MrpWareHouseInfoEntryInfo)
        For i As Integer = 0 To tb.Rows.Count - 1
            Dim mi As New MrpWareHouseInfoEntryInfo
            mi.M_Code = tb.Rows(i)("Code")
            mi.M_Name = IIf(IsDBNull(tb.Rows(i)("M_Name")), Nothing, tb.Rows(i)("M_Name"))
            mi.M_Gauge = IIf(IsDBNull(tb.Rows(i)("M_Gauge")), Nothing, tb.Rows(i)("M_Gauge"))
            mi.M_Unit = IIf(IsDBNull(tb.Rows(i)("M_Unit")), Nothing, tb.Rows(i)("M_Unit"))
            mi.Source = IIf(IsDBNull(tb.Rows(i)("Source")), Nothing, tb.Rows(i)("Source"))
            mi.SourceID = IIf(IsDBNull(tb.Rows(i)("SourceID")), Nothing, tb.Rows(i)("SourceID"))
            mi.MP_InventoryQty = mwc.GetWareHouseInventory(tb.Rows(i)("Code"))
            mlist.Add(mi)
        Next


        If Len(tempMrpID) = 36 Then
            mwc.MrpWareHouseInfo_DeleteByMRPID(tempMrpID)
        End If

        Dim fr As New frmMrpWareHouseInfoAdd
        fr.EditItem = EditEnumType.ADD
        fr.DataList = mlist
        If EditItem = EditEnumType.ADD Then
            fr.MrpID = "temp"
        Else
            fr.MrpID = MRPID
        End If
        tempMrpID = System.Guid.NewGuid.ToString
        fr.lblMRP_ID.Tag = tempMrpID
        fr.MdiParent = MDIMain
        fr.Show()
        btnGetPurchase.Focus()
    End Sub
#End Region

#Region "生成請購建議"
    Private Sub btnGetPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPurchase.Click
        If CheckSave(btnGetPurchase) = False Then
            Exit Sub
        End If
        Dim mwc As New MrpWareHouseInfoController
        If mwc.MrpWareHouseInfo_WareIDExists(lblWareID.Text) = False Then
            MsgBox("庫存記錄表中不存在與之對應的庫存記錄，請先轉存為記錄", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If
        If mc.Mrp_WareIDAuditing(lblWareID.Text) = False Then
            MsgBox("請先審核對應此運算單號的庫存記錄", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        pnlDeclare.Visible = False
        bMRPGetPurchase = True
        Dim tempTable As New DataTable
        Dim beginDateTime, endDateTime As DateTime
        Dim logString, usedTime As String
        beginDateTime = Now

        Dim msi As New MrpSettingInfo
        Dim msc As New MrpSettingController
        msi = msc.MrpSetting_GetList(InUserID)(0)

        mc.dt = ds.Tables("MRPPurchase")
        If chkDate.Checked Then
            mc.GetPurchaseMaterial(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing, lblWareID.Text)
        ElseIf chkForecastID.Checked Then
            mc.GetPurchaseMaterial(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString, lblWareID.Text)
        End If

        endDateTime = Now
        logString = "開始時間:" + beginDateTime.ToString("yyyy/MM/dd HH:mm:ss")
        logString += ";結束時間:" + endDateTime.ToString("yyyy/MM/dd HH:mm:ss")
        usedTime = endDateTime.Subtract(beginDateTime).TotalMinutes.ToString
        txtlogtxt.EditValue = logString + ";總耗時:" + usedTime.Remove(usedTime.LastIndexOf(".") + 3) + "分鐘"

        For i As Integer = 0 To 2
            prb.PerformStep()
            Application.DoEvents()
        Next
        prb.Visible = False
        txtlogtxt.Visible = True
        mri.MrpCalcBeginDate = beginDateTime
        mri.MrpCalcEndDate = endDateTime
        mri.UsedTime = usedTime.Remove(usedTime.LastIndexOf(".") + 3)
        mri.MrpCalcDateTime = Now
        XtraTabControl1.SelectedTabPage = xtpPurchase

    End Sub
#End Region

#Region "Mrp運算稽核"

    Private Function MRP_AuditingResult() As Boolean
        GetGridAuditingDataSource()
        If viewAuditingType.RowCount < 1 Then
            Return True
        ElseIf viewAuditingType.RowCount = 1 And viewAuditingType.GetDataRow(0)("AuditingType").ToString = "A" And viewAuditingType.GetDataRow(0)("IsIgnore").Equals(True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub GetGridAuditingDataSource()
        Dim dsAuditing As New DataSet
        Dim mc As New MrpInfoController
        Dim msi As New MrpSettingInfo
        Dim msc As New MrpSettingController
        msi = msc.MrpSetting_GetList(InUserID)(0)

        If chkDate.Checked Then
            dsAuditing = mc.Mrp_GetComputingAuditing(dteNeedBeginDate.EditValue, dteNeedEndDate.EditValue, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, Nothing)
        ElseIf chkForecastID.Checked Then
            dsAuditing = mc.Mrp_GetComputingAuditing(Nothing, Nothing, msi.mrpInfoForecastCheckType, msi.mrpInfoForecastCancellation, pceForecastID.EditValue.ToString)
        End If

        For i As Integer = 0 To viewAuditingType.RowCount - 1
            If viewAuditingType.GetDataRow(i)("AuditingType").ToString = "A" And viewAuditingType.GetDataRow(i)("IsIgnore").Equals(True) Then
                For n As Integer = 0 To dsAuditing.Tables(0).Rows.Count - 1
                    If dsAuditing.Tables(0).Rows(n)("AuditingType").ToString = "A" Then
                        dsAuditing.Tables(0).Rows(n)("IsIgnore") = True
                        Exit For
                    End If
                Next
            End If
        Next

        SetGridAuditing(dsAuditing.Tables(0))
        GridAuditingType.DataSource = dsAuditing.Tables(0)
        'gridAuditingDetail.DataSource = Nothing
        gridAuditingDetail.DataSource = dsAuditing.Tables(1)
        'viewAuditingType_FocusedRowChanged(Nothing, Nothing)
    End Sub

    Private Sub SetGridAuditing(ByVal dt As DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1
            Select Case dt.Rows(i)("AuditingType").ToString
                Case "A"
                    dt.Rows(i)("AuditingTypeName") = "預測訂單---未審核"
                Case "B"
                    dt.Rows(i)("AuditingTypeName") = "物料編號表-未審核"
                Case "C"
                    dt.Rows(i)("AuditingTypeName") = "Bom表主檔-未審核"
                Case "D"
                    dt.Rows(i)("AuditingTypeName") = "Bom表----失效過期"
                Case "E"
                    dt.Rows(i)("AuditingTypeName") = "Bom表中----不存在"
            End Select
        Next
    End Sub

    Private Sub viewAuditingType_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles viewAuditingType.FocusedRowChanged
        If viewAuditingType.GetFocusedRowCellValue("AuditingType") Is Nothing = False Then
            Dim str As String = viewAuditingType.GetDataRow(e.FocusedRowHandle).ItemArray(0)
            viewAuditingDetail.ActiveFilterString = "AuditingType like '" + str + "%'"
            If viewAuditingType.GetFocusedRowCellValue("AuditingType").ToString <> "A" Then
                viewAuditingType.Columns("IsIgnore").OptionsColumn.AllowEdit = False
            Else
                viewAuditingType.Columns("IsIgnore").OptionsColumn.AllowEdit = True
            End If
            SetGridAuditingDetailCaption(viewAuditingType.GetDataRow(e.FocusedRowHandle))
        End If
    End Sub

    Private Sub SetGridAuditingDetailCaption(ByVal row As DataRow)
        Select Case row("AuditingType").ToString
            Case "A"
                viewAuditingDetail.Columns("AuditingNO").Caption = "預測單號"
            Case "B"
                viewAuditingDetail.Columns("AuditingNO").Caption = "物料編碼"
            Case "C"
                viewAuditingDetail.Columns("AuditingNO").Caption = "產品編碼"
            Case "D"
                viewAuditingDetail.Columns("AuditingNO").Caption = "物料編碼"
            Case "E"
                viewAuditingDetail.Columns("AuditingNO").Caption = "產品編碼"
        End Select
    End Sub

    Private Sub viewAuditingType_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles viewAuditingType.CustomDrawCell, viewAuditingDetail.CustomDrawCell
        If sender.name = "viewAuditingType" And viewAuditingType.GetDataRow(e.RowHandle) Is Nothing = False Then
            If viewAuditingType.GetDataRow(e.RowHandle)("AuditingType").Equals("A") And e.Column.Name = "IsIgnore" Then
                e.Appearance.BackColor = Color.Green
            ElseIf e.Column.Name = "IsIgnore" Then
                e.Appearance.BackColor = Color.FromArgb(240, 240, 240)
            End If
        End If

        If sender.name = "viewAuditingDetail" Then
            Select Case e.CellValue.ToString
                Case "MrpForecastOrder"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "TableName", "預測訂單管理")
                Case "ForecastID"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "FieldName", "預測訂單單號")
                Case "MrpMaterialCode"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "TableName", "物料編碼表")
                Case "M_Code"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "FieldName", "物料編碼")
                Case "Bom_M"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "TableName", "Bom產品結構")
                Case "ParentGroup"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "FieldName", "物料編碼")
                Case "E"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "Descript", "不存在")
                Case "D"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "Descript", "失效-過期")
                Case "A"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "Descript", "未審核")
                Case "B"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "Descript", "未審核")
                Case "C"
                    viewAuditingDetail.SetRowCellValue(e.RowHandle, "Descript", "未審核")
            End Select
        End If
    End Sub

    'Private Sub linkAuditingNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linkAuditingNO.Click
    '    Try
    '        Dim type As String = viewAuditingDetail.GetFocusedRowCellValue("AuditingType")
    '        Dim sn As String = viewAuditingDetail.GetFocusedRowCellValue("AuditingNO")
    '        Select Case type
    '            Case "A"
    '                Dim fr As New frmMrpForecastOrder
    '                fr.StrForecastID = sn
    '                fr.Type = EditEnumType.CHECK
    '                fr.MdiParent = MDIMain
    '                fr.Show()
    '            Case "B"
    '                Dim fr As New frmMrpMaterialCode
    '                fr.MdiParent = MDIMain
    '                fr.EditItem = EditEnumType.CHECK
    '                fr.EditValue = sn
    '                fr.Show()
    '            Case "C"
    '                Dim fr As New frmBom
    '                fr.MdiParent = MDIMain
    '                fr.EditItem = EditEnumType.CHECK
    '                fr.BomMCode = sn
    '                fr.Show()
    '            Case "D"
    '                Dim mbc As New Bom_MController
    '                If mbc.Bom_M_IsChecked(sn).Equals(True) Then
    '                    MsgBox("Bom產品結構:" + sn + "已審核，無法修改", MsgBoxStyle.Information, "提示")
    '                    Exit Select
    '                End If
    '                Dim fr As New frmBom
    '                fr.MdiParent = MDIMain
    '                fr.EditItem = EditEnumType.EDIT
    '                fr.BomMCode = sn
    '                fr.Show()
    '            Case "E"
    '                Dim fr As New frmBom
    '                fr.MdiParent = MDIMain
    '                fr.EditItem = EditEnumType.ADD
    '                fr.gluM_Code.EditValue = sn
    '                fr.Show()
    '        End Select
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "linkAuditingNO_Click方法出錯")
    '    End Try
    'End Sub

    Private Sub cmsAuditingRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAuditingRefresh.Click
        MRP_AuditingResult()
    End Sub
#End Region

#Region "檢查用戶是否有設置MRP參數設置"
    Private Function CheckHaveSetting() As Boolean
        Dim msi As New List(Of MrpSettingInfo)
        Dim msc As New MrpSettingController
        msi = msc.MrpSetting_GetList(InUserID)
        If msi.Count > 0 Then
            CheckHaveSetting = True
        Else
            MsgBox("請設置MRP相關參數設置", MsgBoxStyle.Information, "提示")
            CheckHaveSetting = False
        End If
    End Function
#End Region

#End Region

#Region "保存、退出事件"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (CheckSave(btnSave) = False) Then
            Exit Sub
        End If
        SaveData()
    End Sub

#Region "保存數據"
    Private Sub SaveData()
        Select Case EditItem
            Case EditEnumType.ADD
                SaveDataSub(EditEnumType.ADD)
                Me.Close()
            Case EditEnumType.EDIT
                SaveDataSub(EditEnumType.EDIT)
                Me.Close()
            Case EditEnumType.CHECK
                If BandedGridView1.RowCount > 0 Then
                    Dim mi As New MrpInfoInfo
                    Dim mc As New MrpInfoController
                    If chkCheck.Checked = True Then
                        mi.PR_ID = TransferToPurchase()
                        UpdateMrpForecastEntry()
                    End If
                    mi.MRP_ID = txtMRP_ID.EditValue
                    mi.MI_CheckBit = chkCheck.Checked
                    mi.MI_CheckUserID = InUserID
                    mi.MI_CheckRemark = txtCheckRemark.Text
                    If mc.MrpInfo_UpdateCheck(mi) = True Then
                        MsgBox("保存成功", MsgBoxStyle.Information, "提示")
                    Else
                        MsgBox("保存失敗", MsgBoxStyle.Information, "提示")
                    End If
                    Me.Close()
                Else
                    MsgBox("請購建議中不存在數據,無須審核", MsgBoxStyle.Information, "提示")
                End If
        End Select
    End Sub

    Private Sub SaveDataSub(ByVal editItem As String)

        SaveMrpInfo(editItem)
        SaveMrpDestBill(editItem)
        SaveMrpOrderDestBill(editItem)
        SavePurchaseCalcRecord()
        SaveMrpPurchase(editItem)
        SaveMrpIndReq(editItem)

        '----------------保存運算記錄表----------------
        If MRPAction = True Then
            Dim mrc As New MrpCalcRecordController
            mri.Mrp_ID = txtMRP_ID.EditValue
            mri.CreateUserID = InUserID
            mri.ProductNum = ds.Tables("MRPDestBills").Rows.Count
            mri.PurchaseNum = ds.Tables("MRPPurchase").Rows.Count
            mrc.MrpCalcRecord_Add(mri)
        End If

        '---------------MRP轉庫存后修改庫存記錄表中的MRP_ID
        Dim mwc As New MrpWareHouseInfoController
        If tempMrpID.Length = 36 Then
            mwc.MrpWareHouseInfo_updateMRPID(tempMrpID, txtMRP_ID.EditValue.ToString)
        End If
    End Sub

#Region "審核時把請購建議轉至請購申請"
    Private Function TransferToPurchase() As String
        Dim MrpPInfo As New MrpPurchaseRecordInfo
        Dim MrpPCon As New MrpPurchaseRecordController
        Dim MrpPEInfo As New MrpPurchaseRecordEntryInfo
        Dim MrpPECon As New MrpPurchaseRecordEntryController
        Dim strPR As String = MrpPCon.MrpPurchaseRecord_GetNewMrpID
        MrpPInfo.MPP_CreateUserID = InUserID
        MrpPInfo.MRP_ID = txtMRP_ID.Text
        MrpPInfo.MrpPurchaseID = strPR
        MrpPCon.MrpPurchaseRecord_Add(MrpPInfo)
        For i As Integer = 0 To BandedGridView1.RowCount - 1
            MrpPEInfo.MRP_ID = BandedGridView1.GetRow(i)("MRP_ID").ToString
            MrpPEInfo.MrpPurchaseID = strPR
            MrpPEInfo.M_Code = BandedGridView1.GetRow(i)("M_Code").ToString
            MrpPEInfo.MPI_NeedQty = CDec(BandedGridView1.GetRow(i)("MP_MRPQty"))
            MrpPEInfo.MPI_NeedDate = CDate(BandedGridView1.GetRow(i)("MP_NeedDate"))
            MrpPEInfo.MPI_CreateUserID = InUserID
            If MrpPECon.MrpPurchaseRecordEntry_Add(MrpPEInfo) = False Then
                MsgBox("部分請購建議轉至采購申請時失敗", MsgBoxStyle.Information, "提示")
            End If
        Next
        Return strPR
    End Function

    Private Sub UpdateMrpForecastEntry()
        Dim mfc As New MrpForecastOrderEntryController
        Dim ForecastID As String = String.Empty
        Dim NeedDate As Date
        For i As Integer = 0 To GridView3.RowCount - 1
            If ForecastID <> GridView3.GetDataRow(i)("MOB_ForecastID").ToString Or NeedDate.CompareTo(CDate(GridView3.GetDataRow(i)("MOB_NeedDate"))) <> 0 Then
                ForecastID = GridView3.GetDataRow(i)("MOB_ForecastID").ToString
                NeedDate = CDate(GridView3.GetDataRow(i)("MOB_NeedDate"))
                mfc.MrpForecastOrderEntry_UpdateMrpOperation(ForecastID, NeedDate)
            End If
        Next
    End Sub

#End Region

#Region "保存MRP運算記錄表"
    Private Sub SaveMrpInfo(ByVal editItem As String)
        Try
            '-----------------MRP運算記錄表-------------------------
            Dim mi As New MrpInfoInfo
            Dim mc As New MrpInfoController
            If chkDate.Checked Then
                mi.MI_NeedBeginDate = dteNeedBeginDate.EditValue
                mi.MI_NeedEndDate = dteNeedEndDate.EditValue
                mi.MI_ForecastID = Nothing
            Else
                mi.MI_NeedBeginDate = Nothing
                mi.MI_NeedEndDate = Nothing
                mi.MI_ForecastID = pceForecastID.EditValue
            End If
            mi.MI_CalcType = IIf(chkDate.Checked, 1, 0)          '1為按日期運算,0為按訂單號運算
            mi.MI_MRPType = cboMRPType.SelectedIndex
            mi.MI_MRPDate = btnMrp.Tag
            mi.MI_LogTxt = txtlogtxt.EditValue
            mi.MI_Remarks = txtRemarks.Text
            If Len(tempMrpID) = 36 Then
                lblWareID.Text = mc.GetMrpWareHouseID(tempMrpID)
            End If
            mi.MI_WareID = lblWareID.Text
            If editItem = EditEnumType.ADD Then
                txtMRP_ID.EditValue = GetMRP_ID()
                If Len(txtMRP_ID.EditValue) = 0 Then
                    MsgBox("生成單號出錯，無法保存", MsgBoxStyle.Information)
                    Exit Sub
                End If
                mi.MRP_ID = txtMRP_ID.EditValue
                mi.MI_CreateUserID = InUserID
                mc.MrpInfo_Add(mi)
            End If
            If editItem = EditEnumType.EDIT Then
                mi.MRP_ID = txtMRP_ID.EditValue
                mi.MI_ModifyUserID = InUserID
                mc.MrpInfo_Update(mi)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpInfo方法出錯")
        End Try
    End Sub
#End Region

#Region "保存MRP產品明細表"
    Private Sub SaveMrpDestBill(ByVal editItem As String)
        Try
            If editItem = EditEnumType.EDIT Then
                Dim array1 As String()
                If String.IsNullOrEmpty(MRPBill_DelAutoID) = False Then
                    array1 = MRPBill_DelAutoID.Split(",")
                    For x As Int16 = 0 To array1.Length - 2
                        mbc.MrpDestBills_Delete(array1(x), Nothing)
                    Next
                End If
            End If
            '-----------------MRP產品明細表--------------------------
            If ds.Tables("MRPDestBills").Rows.Count > 0 Then
                Dim mbi As New MrpDestBillsInfo
                Dim i As Integer
                If MRPAction = True Then
                    mbc.MrpDestBills_Delete(Nothing, txtMRP_ID.EditValue)
                End If
                For i = 0 To ds.Tables("MRPDestBills").Rows.Count - 1
                    mbi.AutoID = ds.Tables("MRPDestBills").Rows(i)("AutoID").ToString
                    mbi.MRP_ID = txtMRP_ID.EditValue
                    mbi.M_Code = ds.Tables("MRPDestBills").Rows(i)("M_Code").ToString
                    mbi.MB_MRPQty = ds.Tables("MRPDestBills").Rows(i)("MRPQty")
                    If editItem = EditEnumType.ADD Or MRPAction = True Then                 '增加
                        mbi.MB_CreateUserID = InUserID
                        mbc.MrpDestBills_Add(mbi)

                    ElseIf editItem = EditEnumType.EDIT Then                        '修改
                        mbi.MB_ModifyUserID = InUserID
                        If mbi.AutoID = 0 Then
                            mbc.MrpDestBills_Add(mbi)
                        Else
                            mbc.MrpDestBills_Update(mbi)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpDestBill方法出錯")
        End Try
    End Sub
#End Region

#Region "保存MRP訂單物料明細表"
    Private Sub SaveMrpOrderDestBill(ByVal editItem As String)
        Try
            If editItem = EditEnumType.EDIT Then
                Dim array2 As String()
                If String.IsNullOrEmpty(MRPOrderBill_DelAutoID) = False Then
                    array2 = MRPOrderBill_DelAutoID.Split(",")
                    For y As Int16 = 0 To array2.Length - 2
                        mobc.MRPOrderDestBills_Delete(array2(y), Nothing)
                    Next
                End If
            End If
            '-----------------MRP訂單物料明細表----------------------
            If ds.Tables("MRPOrderDestBills").DefaultView.ToTable.Rows.Count > 0 Then
                Dim mobi As New MrpOrderDestBillsInfo
                Dim j As Integer
                If MRPAction = True Then
                    mobc.MRPOrderDestBills_Delete(Nothing, txtMRP_ID.EditValue)
                End If
                Dim table As New DataTable
                table = ds.Tables("MRPOrderDestBills").DefaultView.ToTable
                For j = 0 To table.Rows.Count - 1
                    mobi.AutoID = table.Rows(j)("AutoID").ToString
                    mobi.MRP_ID = txtMRP_ID.EditValue
                    mobi.OD_ID = table.Rows(j)("OD_ID").ToString
                    mobi.MOB_ForecastID = table.Rows(j)("MOB_ForecastID").ToString
                    mobi.MOB_NeedDate = table.Rows(j)("MOB_NeedDate")
                    mobi.M_Code = table.Rows(j)("M_Code").ToString
                    mobi.MOB_MRPQty = table.Rows(j)("MRPQty").ToString
                    If editItem = EditEnumType.ADD Or MRPAction = True Then
                        mobi.MOB_CreateUserID = InUserID
                        mobc.MRPOrderDestBills_Add(mobi)

                    ElseIf editItem = EditEnumType.EDIT Then
                        mobi.MOB_ModifyUserID = InUserID
                        If mobi.AutoID = 0 Then
                            mobc.MRPOrderDestBills_Add(mobi)
                        Else
                            mobc.MRPOrderDestBills_Update(mobi)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpOrderDestBill方法出錯")
        End Try
    End Sub
#End Region

#Region "保存MRP運算請購建議到請購記錄表中"
#Region "獲取流水號"
    Private Function GetPurchaseCalcRecord_ID() As String
        Dim mc As New MrpPurchaseCalcRecordController
        Dim ndate, id As String
        ndate = "CR" + Format(Now(), "yyMM")
        id = mc.MrpPurchaseCalcRecord_GetID()
        If id Is Nothing Then
            GetPurchaseCalcRecord_ID = ndate + "0001"
        Else
            GetPurchaseCalcRecord_ID = ndate + Mid((CInt(Mid(id, 7)) + 10001), 2)
        End If
    End Function
#End Region

    Private Sub SavePurchaseCalcRecord()
        Try
            Dim mpcri As New MrpPurchaseCalcRecordInfo
            Dim mpcrc As New MrpPurchaseCalcRecordController
            If ds.Tables("MRPPurchase").Rows.Count > 0 Then
                For x As Integer = 0 To ds.Tables("MRPPurchase").Rows.Count - 1
                    mpcri.SN = GetPurchaseCalcRecord_ID()
                    mpcri.MRP_ID = txtMRP_ID.EditValue
                    mpcri.MRPType = cboMRPType.SelectedIndex
                    If chkDate.Checked Then
                        mpcri.NeedBeginDate = dteNeedBeginDate.EditValue
                        mpcri.NeedEndDate = dteNeedEndDate.EditValue
                        mpcri.ForecastID = Nothing
                    Else
                        mpcri.NeedBeginDate = Nothing
                        mpcri.NeedEndDate = Nothing
                        mpcri.ForecastID = pceForecastID.EditValue
                    End If
                    mpcri.CalcType = IIf(chkDate.Checked, 1, 0)
                    mpcri.Ware_ID = lblWareID.Text
                    mpcri.CreateUserID = InUserID
                    With ds.Tables("MRPPurchase")
                        mpcri.M_Code = .Rows(x)("M_Code").ToString
                        mpcri.NeedQty = CDec(.Rows(x)("MP_NeedQty"))
                        mpcri.MRPQty = CDec(.Rows(x)("MP_MRPQty"))
                        mpcri.InventoryQty = CDec(.Rows(x)("MP_InventoryQty"))
                        mpcri.InTransitQty = CDec(.Rows(x)("MP_InTransitQty"))
                        mpcri.Inspection = CDec(.Rows(x)("MP_Inspection"))
                        mpcri.NoCollar = CDec(.Rows(x)("MP_NoCollar"))
                        mpcri.RetreatQty = CDec(.Rows(x)("MP_RetreatQty"))
                        mpcri.RelatedQty = CDec(.Rows(x)("MP_RelatedQty"))
                    End With
                    mpcrc.MrpPurchaseCalcRecord_Add(mpcri)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SavePurchaseCalcRecord")
        End Try
    End Sub
#End Region

#Region "保存MRP請購建議表"
    Private Sub SaveMrpPurchase(ByVal editItem As String)
        Try
            If editItem = EditEnumType.EDIT Then
                Dim array3 As String()
                If String.IsNullOrEmpty(MRPPurchase_DelAutoID) = False Then
                    array3 = MRPPurchase_DelAutoID.Split(",")
                    For z As Int16 = 0 To array3.Length - 2
                        mpc.MrpPurchase_Delete(array3(z), Nothing)
                    Next
                End If
            End If
            '-----------------MRP請購建議表--------------------------
            If ds.Tables("MRPPurchase").Rows.Count > 0 Then
                Dim mpi As New MrpPurchaseInfo
                Dim n As Integer
                If bMRPGetPurchase = True Then
                    mpc.MrpPurchase_Delete(Nothing, txtMRP_ID.EditValue)
                End If
                Dim table As New DataTable
                table = ds.Tables("MRPPurchase")
                For n = 0 To table.Rows.Count - 1
                    mpi.AutoID = table.Rows(n)("AutoID").ToString
                    mpi.MRP_ID = txtMRP_ID.EditValue
                    mpi.M_Code = table.Rows(n)("M_Code").ToString
                    mpi.MP_NeedQty = CDec(table.Rows(n)("MP_NeedQty"))
                    mpi.MP_MRPQty = CDec(table.Rows(n)("MP_MRPQty"))
                    mpi.MP_InventoryQty = CDec(table.Rows(n)("MP_InventoryQty"))
                    mpi.MP_InTransitQty = CDec(table.Rows(n)("MP_InTransitQty"))
                    mpi.MP_Inspection = CDec(table.Rows(n)("MP_Inspection"))
                    mpi.MP_NoCollar = CDec(table.Rows(n)("MP_NoCollar"))
                    mpi.MP_RetreatQty = CDec(table.Rows(n)("MP_RetreatQty"))
                    mpi.MP_RelatedQty = CDec(table.Rows(n)("MP_RelatedQty"))
                    mpi.MP_SecInv = CDec(table.Rows(n)("MP_SecInv"))
                    mpi.MP_LowLimit = CDec(table.Rows(n)("MP_LowLimit"))
                    mpi.MP_BatchQty = CDec(table.Rows(n)("MP_BatchQty"))
                    mpi.MP_BatFixEconomy = CDec(table.Rows(n)("MP_BatFixEconomy"))
                    mpi.MP_OrderMax = CDec(table.Rows(n)("MP_OrderMax"))
                    mpi.MP_OrderMin = CDec(table.Rows(n)("MP_OrderMin"))
                    mpi.MP_NeedDate = CDate(table.Rows(n)("MP_NeedDate"))
                    If editItem = EditEnumType.ADD Or MRPAction = True Then
                        mpi.MP_CreateUserID = InUserID
                        mpc.MrpPurchase_Add(mpi)
                    ElseIf editItem = EditEnumType.EDIT Then
                        mpi.MP_ModifyUserID = InUserID
                        If mpi.AutoID = 0 Then
                            mpc.MrpPurchase_Add(mpi)
                        Else
                            mpc.MrpPurchase_Update(mpi)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpPurchase方法出錯")
        End Try
    End Sub
#End Region

#Region "保存獨立需求"
    Private Sub SaveMrpIndReq(ByVal editItem As String)
        Try
            '----------------保存獨立需求----------------
            Dim mii As New MrpIndReqInfo
            Dim mic As New MrpIndReqController
            If MRPAction = True Then
                mic.MrpIndReq_Delete(txtMRP_ID.EditValue.ToString)
                Try
                    If TypeOf (TreeList1.DataSource) Is DataTable Then
                        Dim temptb As New DataTable
                        temptb = TreeList1.DataSource
                        For i As Integer = 0 To temptb.Rows.Count - 1
                            mii.MRP_ID = txtMRP_ID.EditValue.ToString
                            mii.PID = temptb.Rows(i)("PID").ToString
                            mii.ID = temptb.Rows(i)("ID").ToString
                            mii.ForecastID = temptb.Rows(i)("ForecastID").ToString
                            mii.M_Code = temptb.Rows(i)("M_Code").ToString
                            mii.M_Name = temptb.Rows(i)("M_Name").ToString
                            mii.M_Gauge = temptb.Rows(i)("M_Gauge").ToString
                            mii.M_Unit = temptb.Rows(i)("M_Unit").ToString
                            mii.Source = temptb.Rows(i)("Source").ToString
                            mii.NeedDate = CDate(temptb.Rows(i)("NeedDate"))
                            If IsDBNull(temptb.Rows(i)("InvalidDate")) Then
                                mii.InvalidDate = Nothing
                            Else
                                mii.InvalidDate = CDate(temptb.Rows(i)("InvalidDate"))
                            End If
                            mii.NeedQty = CDec(temptb.Rows(i)("NeedQty"))
                            mii.sonsNum = temptb.Rows(i)("sonsNum").ToString
                            mii.CreateUserID = InUserID
                            mic.MrpIndReq_Add(mii)
                        Next
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpIndReq方法出錯")
        End Try
    End Sub
#End Region

#Region "保存前檢查輸入數據是否正確"
    Private Function CheckSave(ByVal sender As Object) As Boolean
        Dim bo As Boolean = False
        CheckSave = True
        If chkForecastID.Checked Then
            If pceForecastID.EditValue Is Nothing Then
                MsgBox("請選擇預測訂單號", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf pceForecastID.EditValue.ToString.Length < 2 Then
                MsgBox("請選擇預測訂單號", MsgBoxStyle.Information, "提示")
                bo = True
            End If
        ElseIf chkDate.Checked Then
            If dteNeedBeginDate.EditValue = Nothing Then
                MsgBox("請選擇展望期開始日期", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf dteNeedEndDate.EditValue = Nothing Then
                MsgBox("請選擇展望期結束日期", MsgBoxStyle.Information, "提示")
                bo = True
            ElseIf Date.Compare(CDate(dteNeedBeginDate.EditValue), CDate(dteNeedEndDate.EditValue)) > 0 Then
                MsgBox("展望期開始日期不能晚于結束日期", MsgBoxStyle.Information, "提示")
                bo = True
            End If
        End If

        If sender Is btnSave = False Then
            Exit Function
        End If

        If EditItem = EditEnumType.CHECK And boCheck = chkCheck.Checked Then
            MsgBox("審核狀態沒有變化，無法保存", MsgBoxStyle.Information, "提示")
            bo = True
        End If
        If bo = True Then
            CheckSave = False
            Exit Function
        End If

        Dim msgInfo1, msgInfo2 As String
        msgInfo1 = "無法保存，產品明細中存在產品編碼為空的資料行"
        msgInfo2 = "無法保存，產品明細中存在重復的產品編碼："
        If CheckTableData(ds.Tables("MRPDestBills"), msgInfo1, msgInfo2, xtpDestBills, GridView2) = False Then
            CheckSave = False
            Exit Function
        End If

        msgInfo1 = "無法保存，訂單物料明細中存在產品編碼為空的資料行"
        msgInfo2 = "無法保存，訂單物料明細中存在交貨日期和產品編碼同時重復的資料行，產品編碼："
        If CheckTableData(ds.Tables("MRPOrderDestBills"), msgInfo1, msgInfo2, xtpOrderDestBills, GridView3) = False Then
            CheckSave = False
            Exit Function
        End If

        msgInfo1 = "無法保存，請購建議中存在產品編碼為空的資料行"
        msgInfo2 = "無法保存，請購建議中存在重復的產品編碼："
        CheckSave = CheckTableData(ds.Tables("MrpPurchase"), msgInfo1, msgInfo2, xtpPurchase, BandedGridView1)

    End Function

    Private Function CheckTableData(ByVal dt As DataTable, ByVal msgInfo1 As String, ByVal msgInfo2 As String, ByVal xtp As DevExpress.XtraTab.XtraTabPage, ByVal view As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
        Try
            For i As Integer = 0 To dt.Rows.Count - 1
                If IsDBNull(dt.Rows(i)("M_Code")) Then
                    XtraTabControl1.SelectedTabPage = xtp
                    view.FocusedRowHandle = i
                    MsgBox(msgInfo1, MsgBoxStyle.Information, "提示")
                    Return False
                End If
                If i = dt.Rows.Count Then
                    Exit For
                End If
                For j As Integer = i + 1 To dt.Rows.Count - 1
                    If dt.TableName = "MRPOrderDestBills" Then

                    End If
                    If dt.Rows(i)("M_Code").ToString = dt.Rows(j)("M_Code").ToString Then
                        If dt.TableName = "MRPOrderDestBills" And dt.Rows(i)("MOB_NeedDate").ToString <> dt.Rows(j)("MOB_NeedDate").ToString Then
                            Continue For
                        End If
                        XtraTabControl1.SelectedTabPage = xtp
                        view.FocusedRowHandle = i
                        MsgBox(msgInfo2 + dt.Rows(i)("M_Code").ToString, MsgBoxStyle.Information, "提示")
                        Return False
                    End If
                Next
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
            Return False
        End Try

    End Function

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmMRPInfo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim mwc As New MrpWareHouseInfoController
        mwc.MrpWareHouseInfo_DeleteByMRPID(tempMrpID)
    End Sub

    Private Sub frmMrpInfo_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If btnInsertWareHouse.Tag <> Nothing Then
            lblWareID.Text = ""        '轉庫存記錄后未保存庫存記錄時不清除lblWareID.Text
        ElseIf Len(tempMrpID) = 36 Then
            lblWareID.Text = mc.GetMrpWareHouseID(tempMrpID)
        End If
    End Sub
#End Region

#Region "查看歷史運算記錄"
    Private Sub txtlogtxt_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlogtxt.DoubleClick
        Dim fr As New frmMrpCalcOrder
        fr.ShowDialog()
    End Sub
#End Region

#Region "選擇預測訂單事件"
    Private Sub pceForecastID_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles pceForecastID.QueryResultValue
        Dim str As String = ""
        For i As Integer = 0 To chklbForecastID.ItemCount - 1
            If chklbForecastID.GetItemChecked(i) = True Then
                str += chklbForecastID.GetItemText(i) + ","
            End If
        Next
        If str.Length > 1 Then
            str = str.Remove(str.LastIndexOf(","), 1)
        End If
        e.Value = str
    End Sub
#End Region

#Region "查看庫存記錄表"
    Private Sub lblWareID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWareID.DoubleClick
        If lblWareID.Text.Trim.Length > 2 Then
            Dim fr As New frmMrpWareHouseInfoAdd
            fr.MrpID = txtMRP_ID.EditValue
            fr.EditItem = EditEnumType.CHECK
            fr.EditValue = lblWareID.Text
            fr.MdiParent = MDIMain
            fr.Show()
        End If
    End Sub

    Private Sub lblWareID_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWareID.MouseHover
        If lblWareID.Text.Length > 2 Then
            lblWareID.ForeColor = Color.DarkRed
            lblWareID.Cursor = Cursors.Hand
            Dim tip As New ToolTip
            tip.SetToolTip(lblWareID, "雙擊查看庫存記錄單")
        End If
    End Sub

    Private Sub lblWareID_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWareID.MouseLeave
        lblWareID.ForeColor = Color.Red
        lblWareID.Cursor = Cursors.Default
    End Sub
#End Region

#Region "失效日期為空時，設置其顯示文本為空"
    Private Sub TreeList1_CustomDrawNodeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles TreeList1.CustomDrawNodeCell
        Try
            If e.Column.Name = "InvalidDate" Then
                If IsDBNull(e.CellValue) Then
                    e.CellText = ""
                ElseIf e.CellValue = Nothing Then
                    e.CellText = ""
                ElseIf CDate(e.CellValue) <= Now Then
                    e.Appearance.BackColor = Color.Red
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try
    End Sub
#End Region

#Region "數據值驗證"
    Private Sub RepositoryItemCalcEdit1_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemCalcEdit1.EditValueChanging, RepositoryItemCalcEdit2.EditValueChanging, RepositoryItemCalcEdit3.EditValueChanging
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
        End If
    End Sub
#End Region

End Class
