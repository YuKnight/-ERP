Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.SystemManager

Public Class frmPJBatchMain

    Private Sub frmPJBatchMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim osc As New OrdersSubController
        Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)
        LoadPowerUser()
        Me.Text = "批次狀況--配件"
    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCode.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popLFPrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCodePrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPJPCPrint.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "11010205")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popCodeQCPrint.Enabled = True
        End If
    End Sub
    '配件批次查詢
    Private Sub popBatchQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchQuery.Click
        Dim osc As New OrdersSubController
        Dim myfrm As New frmOrderSubSe
        myfrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing)
            Case "2"
                Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)
            Case "3"
                Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing)

            Case "4"
                Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, tempValue2, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "5"
                Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, tempValue2, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub
    '刷新操作
    Private Sub popBatchRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchRef.Click
        Dim osc As New OrdersSubController
        Grid1.DataSource = osc.OrdersSub_GetList2(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)
    End Sub
    '查看詳細物料
    Private Sub popCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCode.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("OS_Check") = True Then
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
        Else
            MsgBox("此批次還未被審核，不允許查看詳細信息")
            Exit Sub
        End If
    End Sub
    '打印錶殼資料
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
    '打印物料清單
    Private Sub popCodePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodePrint.Click
        '測試報表用
        On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("OS_Check") = True Then
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
            ltc2.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True))
            ltc3.CollToDataSet(ds, "OrdersBom", obc.OrdersBom_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, True, Nothing))
            ltc4.CollToDataSet(ds, "OrdersDetail", odc.OrdersDetail_GetList(GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing))
            ltc5.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString))

            PreviewRPT(ds, "rptOrdersBom", " 測試報表", True, False)
            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
        Else
            MsgBox("此批次還未被審核，不允許導入物料清單報表")
            Exit Sub
        End If
    End Sub
    'QC專用物料清單
    Private Sub popCodeQCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodeQCPrint.Click
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
    '批次交貨進度表查詢
    Private Sub popPJPCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPJPCPrint.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim frmpc As New frmPCPrintSelect
        frmpc.ShowDialog()

    End Sub
End Class