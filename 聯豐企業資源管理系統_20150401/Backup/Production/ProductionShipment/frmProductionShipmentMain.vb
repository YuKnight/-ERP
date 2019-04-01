Imports LFERP.SystemManager
Imports LFERP.Library.ProductionShipment
Public Class frmProductionShipmentMain

    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionShipmentSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionShipmentSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "出貨單"
        tempValue3 = ""
        fr = New frmProductionShipmentSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ShipmentWareOutMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pc As New ProductionShipmentControl
        Grid.DataSource = pc.ProductionShipment_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, Nothing, ">=", Nothing, Nothing)
        PowerUser()
    End Sub

    Private Sub popShipmentWareOutflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutflesh.Click
        Dim pc As New ProductionShipmentControl
        Grid.DataSource = pc.ProductionShipment_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, Nothing, ">=", Nothing, Nothing)

    End Sub

    Private Sub popShipmentWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionShipmentInfo)
        Dim pc As New ProductionShipmentControl

        pi = pc.ProductionShipment_GetList(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi(0).PS_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("PS_NO").ToString & "的出貨單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pc.ProductionShipment_Delete(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing) = True Then
                    MsgBox("刪除當前出貨單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pc.ProductionShipment_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, Nothing, ">=", Nothing, Nothing)
                ''顯示最近7天的裝配出貨單號
            End If
        End If
    End Sub



    Private Sub popShipmentWareOutCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionShipmentSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionShipmentSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "Check"
        tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString   '審核
        fr = New frmProductionShipmentSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popShipmentWareOutEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub ''修改，若已審核就不能修改
        Dim pi As List(Of ProductionShipmentInfo)
        Dim pc As New ProductionShipmentControl
        pi = pc.ProductionShipment_GetList(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).PS_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionShipmentSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionShipmentSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "出貨單"
            tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString
            fr = New frmProductionShipmentSub
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub popShipmentWareOutView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionShipmentSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionShipmentSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString   ''查看，不顯示確定按鈕
        fr = New frmProductionShipmentSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popShipmentWareOutSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutSeek.Click
        Dim sfc As New ProductionShipmentControl

        Dim frm As New frmProductionShipmenttSelect   ''查詢
        frm.ShowDialog()

        If tempValue2 <> "" Or tempValue3 <> "" Or tempValue4 <> "" Or tempValue5 <> "" Or tempValue6 <> "" Or tempValue7 <> "" Or tempValue8 <> "" Or tempValue9 <> "" Then
            Grid.DataSource = sfc.ProductionShipment_GetList(tempValue2, tempValue7, Nothing, Nothing, tempValue8, tempValue4, Nothing, tempValue6, tempValue3, tempValue5, tempValue9)
        End If

        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
        tempValue9 = ""
    End Sub


    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        popShipmentWareOutAdd.Enabled = False
        popShipmentWareOutEdit.Enabled = False
        popShipmentWareOutDel.Enabled = False

        popShipmentWareOutView.Enabled = False
        popShipmentWareOutCheck.Enabled = False
        popShipmentWareOutflesh.Enabled = False

        popShipmentWareOutSeek.Enabled = False
        popShipmentWareOutReport.Enabled = False


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881401")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881402")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881403")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881404")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutView.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881405")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881406")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutflesh.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881407")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutSeek.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881408")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popShipmentWareOutReport.Enabled = True
        End If

    End Sub


    Private Sub popShipmentWareOutReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popShipmentWareOutReport.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub ''打印
        Dim Str As String

        Str = GridView1.GetFocusedRowCellValue("PS_NO").ToString

        Dim ltc As New CollectionToDataSet
        Dim pc As New ProductionShipmentControl
        Dim pi As New ProductionShipmentInfo

        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "ProductionShipment", pc.ProductionShipment_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "ProductionShipment", "裝配出貨單", True, True)

        ltc = Nothing
    End Sub
End Class