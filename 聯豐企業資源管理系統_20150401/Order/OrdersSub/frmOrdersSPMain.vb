Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.SystemManager
Imports LFERP.Library.Purchase.Purchase

Public Class frmOrdersSPMain

    Private Sub frmOrdersSPMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopRefresh_Click(Nothing, Nothing)        '@ 2012/9/20 修改 調用刷新過程
        LoadPowerUser()
    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderSubEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderSubDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PopPJUpdate.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderSubCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300205")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrdersSubModifyNoSendQty.Enabled = True
        End If
    End Sub
    Private Sub popOrderSubEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderSubEdit.Click
        On Error Resume Next

        Dim osi As New OrdersSubInfo
        Dim osc As New OrdersSubController
        osi = osc.OrdersSub_Get(GridView1.GetFocusedRowCellValue("OS_BatchID").ToString)
        If osi.OS_Check = True Then
            MsgBox("此批次已被審核,不允許更改！")
            Exit Sub
        Else
            Edit = True
            If GridView1.RowCount = 0 Then Exit Sub
            Dim fr As frmOrdersSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOrdersSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempCode = GridView1.GetFocusedRowCellValue("OS_Type").ToString
            tempValue2 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
            fr = New frmOrdersSub
            fr.MdiParent = MDIMain
            fr.Show()

        End If
    End Sub

    Private Sub popOrderSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderSubDel.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim osi1 As New OrdersSubInfo
        Dim osc1 As New OrdersSubController
        osi1 = osc1.OrdersSub_Get(GridView1.GetFocusedRowCellValue("OS_BatchID").ToString)
        If osi1.OS_Check = True Then
            MsgBox("此批次已被審核,不允許更改！")
            Exit Sub
        Else
            Dim psi As List(Of PurchaseMainInfo)
            Dim psc As New PurchaseMainController
            psi = psc.PurchaseSub_GetBatchList(Nothing, Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString)
            If psi.Count > 0 Then
                MsgBox("已存在此批次的採購記錄，不允許刪除", , "提示")
                Exit Sub
            Else
                If MsgBox("批次 " & GridView1.GetFocusedRowCellValue("OS_BatchID").ToString & " 相關的生產表,物料清單,生產表項目內容將被刪除.您確定嗎？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub


                Dim osc As New OrdersSubController
                Dim osi As New OrdersSubInfo
                osi.OS_BatchID = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
                osc.OrdersSub_Del(osi)
                Dim odc As New OrdersDetailController
                Dim odi As New OrdersDetailInfo
                odi.OS_BatchID = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
                odc.OrdersDetail_OSBatchID_Del(odi)
                Dim obc As New OrdersBomController
                Dim obi As New OrdersBomInfo
                obi.OS_BatchID = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
                obc.OrdersBom_Del(obi)
                Dim otdc As New OrdersTempDetailController
                Dim otdi As New OrdersTempDetailInfo
                otdi.OS_BatchID = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
                otdc.OrdersTempDetail_OSBatchID_Del(otdi)

                PopRefresh_Click(Nothing, Nothing)        '@ 2012/9/20 修改 調用刷新過程
            End If
        End If
    End Sub

    Private Sub PopPJUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopPJUpdate.Click
        Dim Myfrm As New frmOrdersSubPJ
        Myfrm.ShowDialog()
    End Sub

    Private Sub popOrderSubCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderSubCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmOrdersSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrdersSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempCode = "Check"
        tempValue2 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        fr = New frmOrdersSub
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub popOrdersSubView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrdersSubView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmOrdersSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrdersSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempCode = "PreView"
        tempValue2 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        fr = New frmOrdersSub
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub popOrderSubSe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderSubSe.Click
        Dim osc As New OrdersSubController
        Dim myfrm As New frmOutWardsFind          '@ 2012/9/12 改為調用frmOutWardsFind模塊
        myfrm.Text = "批次資料--查詢"
        myfrm.ShowDialog()
        If myfrm.isClickbtnOK = True Then
            Grid1.DataSource = osc.OrdersSub_GetList3(Nothing, tempValue2, tempValue6, "配件批次", Nothing, Nothing, tempValue, tempValue3, tempValue5, tempValue4, tempValue8, tempValue9, tempValue7)
        End If
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
        tempValue9 = ""
    End Sub

    Private Sub PopOrderSubPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopOrderSubPrint.Click
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

     

        PreviewRPT(ds, "rptOrdersBom", " 測試報表", True, False)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing
    End Sub

    Private Sub popOrdersTempDeail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrdersTempDeail.Click
        '臨時單
        On Error Resume Next
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim mcProduct As New OrdersTempDetailController
        Dim mcProductBom As New OrdersTempDetailInfo
        Dim osc As New OrdersSubController
        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "OrdersTempDetail", mcProduct.OrdersTempDetail_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString))
        PreviewRPT(ds, "rptOrdersTempDetail", " 測試報表", True, False)
        ltc = Nothing
    End Sub
    ''' <summary>
    ''' 刷新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' popOrderSubDel_Click()
    ''' frmOrdersSPMain_Load()
    Private Sub PopRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopRefresh.Click
        Dim osc As New OrdersSubController

        Grid1.DataSource = osc.OrdersSub_GetList1(Nothing, Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing)             '@ 2012/9/20 修改 限制只顯示500條記錄

    End Sub
    '物料清單--QC（此報表僅用於QC部Q貨）
    Private Sub popOrdersQCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrdersQCPrint.Click
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

    Private Sub popOrdersSubModifyNoSendQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrdersSubModifyNoSendQty.Click
        Dim fr As New frmOrderSubModifyNoSendQty
        If GridView1.GetFocusedRowCellValue(OS_NoSendQty) <= 0 Then
            MsgBox("已完全送貨的批次，不能修改未交數！", 64, "提示")
            Exit Sub
        End If
        fr.txtOS_BatchID.Text = GridView1.GetFocusedRowCellValue(OS_BatchID)
        fr.strOM_ID = GridView1.GetFocusedRowCellValue(OM_ID)
        fr.strOS_Type = "配件批次"
        fr.ShowDialog()
    End Sub
End Class