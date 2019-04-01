Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.SystemManager
Imports LFERP.Library.Outward


Public Class frmBatchDetailMain

    Dim ds As New DataSet

    Private Sub frmBatchDetailMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim osc As New OrdersSubController
        Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True) 正式啟用后將採取審核
        LoadPowerUser()
    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCode.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popLFPrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCodePrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPJPCPrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCodeQCPrint.Enabled = True
        End If
    End Sub
    Private Sub popBatchQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchQuery.Click
        Dim osc As New OrdersSubController
        Dim myfrm As New frmOrderSubSe
        myfrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing)
            Case "2"
                Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)
            Case "3"
                Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing)

            Case "4"
                Grid1.DataSource = osc.OrdersSub_GetList(Nothing, tempValue2, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "5"
                Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, tempValue2, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub popBatchRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchRef.Click
        Dim osc As New OrdersSubController
        'Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)
        Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub popCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCode.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        'If GridView1.GetFocusedRowCellValue("OS_Check") = True Then
        '    Dim fr As frmBatchCode
        '    For Each fr In MDIMain.MdiChildren
        '        If TypeOf fr Is frmBatchCode Then
        '            fr.Activate()
        '            Exit Sub
        '        End If
        '    Next
        '    tempValue3 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        '    fr = New frmBatchCode
        '    fr.MdiParent = MDIMain
        '    fr.Show()
        'Else
        '    MsgBox("此批次還未被審核，不允許查看詳細信息")
        '    Exit Sub
        'End If
        Dim fr As frmBatchCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBatchCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue3 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        fr = New frmBatchCode
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '產品資料報表
    Private Sub popLFPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popLFPrint.Click
        '測試報表用
        On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("OS_Type").ToString = "大貨批次" Then
            If GridView1.GetFocusedRowCellValue("OS_Check") = True Then
                Dim ltc As New CollectionToDataSet
                Dim ltc1 As New CollectionToDataSet
                Dim mcProduct As New ProductController
                Dim mcProductBom As New ProductBomController
                ds.Tables.Clear()
                ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(GridView1.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(ds, "Prod_Mounting_New", mcProductBom.ProductBom_GetList(GridView1.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing))

                PreviewRPT(ds, "rptProductBom", " 產品資料--" & GridView1.GetFocusedRowCellValue("PM_M_Code").ToString, True, False)
                ltc = Nothing
                ltc1 = Nothing
            Else
                MsgBox("此批次還未被審核，不允許導入錶殼資料報表")
                Exit Sub
            End If
        Else
            MsgBox("此時為配件批次，無錶殼資料！")
        End If


    End Sub
    '批次+物料等報表
    Private Sub popCodePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodePrint.Click
        '測試報表用
        On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        'If GridView1.GetFocusedRowCellValue("OS_Check") = True Then
        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet

        Dim mcProduct As New ProductController
        Dim otdc As New OrdersTempDetailController
        Dim osc As New OrdersSubController
        Dim obc As New OrdersBomController
        Dim odc As New OrdersDetailController
        Dim omc As New OrdersMainController
        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(GridView1.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "OrdersTempDetail", otdc.OrdersTempDetail_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString))
        ltc2.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)) '正式使用時OS_Check=True
        ltc3.CollToDataSet(ds, "OrdersBom", obc.OrdersBom_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing)) '正式使用時OB_AccountCheck=True
        ltc4.CollToDataSet(ds, "OrdersDetail", odc.OrdersDetail_GetList(GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing))
        ltc5.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString))



        PreviewRPT(ds, "rptOrdersBom", " 測試報表", True, False)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing
        'Else
        'MsgBox("此批次還未被審核，不允許導入物料清單報表")
        'Exit Sub
        'End If
       
    End Sub
    '配件批次交貨進度表
    Private Sub popPJPCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPJPCPrint.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim frmpc As New frmPCPrintSelect
        frmpc.ShowDialog()

    End Sub
    '物料清單--QC部門專用（僅用作QC部Q貨）
    Private Sub popCodeQCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodeQCPrint.Click
        '測試報表用
        On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet

        Dim mcProduct As New ProductController
        Dim otdc As New OrdersTempDetailController
        Dim osc As New OrdersSubController
        Dim obc As New OrdersBomController
        Dim odc As New OrdersDetailController
        Dim omc As New OrdersMainController
        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(GridView1.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "OrdersTempDetail", otdc.OrdersTempDetail_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString))
        ltc2.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "OrdersBom", obc.OrdersBom_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing))
        ltc4.CollToDataSet(ds, "OrdersDetail", odc.OrdersDetail_GetList(GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing))
        ltc5.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString))

        PreviewRPT(ds, "rptOrdersBomQC", " 測試報表", True, False)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing
    End Sub
    '外發加工詳細列表
    Private Sub OutwardDetailPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutwardDetailPrint.Click
        On Error Resume Next
        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet

        Dim sfc As New OutwardController
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim osc As New LFERP.Library.Orders.OrdersSubController
        Dim oac As New OutwardAcceptance.OutwardAcceptanceControl

        Dim strA As String

        strA = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString

        ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptOutwardBatchAll", "批次加工詳細列表", True, True)

        ltc = Nothing
        ltc3 = Nothing

    End Sub
    '外發加工供應商送貨詳細列表
    Private Sub DeliveryDetailPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryDetailPrint.Click
        On Error Resume Next
        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet

        Dim sfc As New OutwardController
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim osc As New LFERP.Library.Orders.OrdersSubController
        Dim oac As New OutwardAcceptance.OutwardAcceptanceControl

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        ds.Tables.Clear()

        ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc4.CollToDataSet(ds, "OutwardAcceptance", oac.OutwardAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strA, Nothing, Nothing))

        PreviewRPT(ds, "rptOutwardDeliveryDetail", "供應商送貨詳細列表", True, True)

        ltc = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
    End Sub
    '外發加工完成狀況一覽表
    Private Sub OutwardCompletePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutwardCompletePrint.Click
        On Error Resume Next
        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet

        Dim sfc As New OutwardController
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim osc As New LFERP.Library.Orders.OrdersSubController
        Dim oac As New OutwardAcceptance.OutwardAcceptanceControl

        Dim strA As String

        strA = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString

        ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strA, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc4.CollToDataSet(ds, "OutwardAcceptance", oac.OutwardAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strA, Nothing, Nothing))

        PreviewRPT(ds, "rptOutwardBatchComplete", "外發加工完成狀況一覽表", True, True)

        ltc = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
    End Sub
End Class