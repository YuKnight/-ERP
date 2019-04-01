Imports LFERP.Library.Outward
Imports LFERP.SystemManager
Imports LFERP.Library.Outward.OutwardAcceptance

Public Class frmOutwardMain

    Dim oi As New OutwardInfo
    Dim oc As New OutwardController

    Private Sub frmOutwardMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        LoadUserPower()
    End Sub

    Public Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "700101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "700102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "700103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "700104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "700105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAccCheck.Enabled = True
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmOutward
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOutward Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "外發加工單"
        tempValue3 = "外發加工"
        tempValue4 = "外發加工作業"
        fr = New frmOutward
        fr.MdiParent = MDIMain
        fr.Show()

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        On Error Resume Next
        Dim owi As List(Of OutwardInfo)
        owi = oc.OutwardMain_GetList(GridView1.GetFocusedRowCellValue("O_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi(0).O_Check = True Or owi(0).O_AccCheck = True Then
            MsgBox("此外發單已審核或復核，不允許修改！")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmOutward
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOutward Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "外發加工單"
            tempValue2 = GridView1.GetFocusedRowCellValue("O_NO").ToString
            tempValue4 = "外發加工作業"
            fr = New frmOutward
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim owi As List(Of OutwardInfo)
        owi = oc.OutwardMain_GetList(GridView1.GetFocusedRowCellValue("O_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If owi(0).O_Check = True Or owi(0).O_AccCheck = True Then
            MsgBox("此外發單已審核或復核，不允許刪除！")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("O_NO").ToString & "的所有外發加工單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.No Then Exit Sub

            If oc.OutwardMain_Delete(GridView1.GetFocusedRowCellValue("O_NO").ToString) = True Then
                If oc.OutwardSub_Delete(GridView1.GetFocusedRowCellValue("O_NO").ToString, Nothing) = True Then
                    MsgBox("已刪除成功！")
                End If
            End If
            Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmOutward
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOutward Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "查看"
        tempValue2 = GridView1.GetFocusedRowCellValue("O_NO").ToString
        tempValue4 = "外發加工作業"
        fr = New frmOutward
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim owi As List(Of OutwardInfo)
        owi = oc.OutwardMain_GetList(GridView1.GetFocusedRowCellValue("O_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi(0).O_AccCheck = True Then
            MsgBox("此單已被復核，不允許再審核！")
        Else
            Dim fr As frmOutward
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOutward Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "審核"
            tempValue2 = GridView1.GetFocusedRowCellValue("O_NO").ToString
            tempValue4 = "外發加工作業"
            fr = New frmOutward
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmdAccCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim owi As List(Of OutwardInfo)
        owi = oc.OutwardMain_GetList(GridView1.GetFocusedRowCellValue("O_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi(0).O_Check = False Then
            MsgBox("此單還未被審核，不允許復核操作！")
        Else
            Dim fr As frmOutward
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOutward Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "復核"
            tempValue2 = GridView1.GetFocusedRowCellValue("O_NO").ToString
            tempValue4 = "外發加工作業"
            fr = New frmOutward
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim myfrm As New frmOutwardSelect
        myfrm.ShowDialog()
        Select Case tempValue

            Case "1"
                Grid1.DataSource = oc.OutwardMain_GetList(tempValue2, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "3"
                Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, tempValue2, tempValue3, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)
            Case "5"
                Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)
            Case "6"
                Grid1.DataSource = oc.OutwardMain_GetList(Nothing, "外發加工", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing)
        End Select
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
    End Sub

    Private Sub Grid1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView1.RowCount = 0 Then Exit Sub

        Dim Str1 As String, Str2 As String, Str3 As String
        Dim oac As New OutwardAcceptanceControl
        'dim oai as new OutwardAcceptanceInfo 
        Str1 = GridView1.GetFocusedRowCellValue("O_NO").ToString
        Str2 = GridView1.GetFocusedRowCellValue("M_Code").ToString
        If GridView1.GetFocusedRowCellValue("OS_BatchID").ToString = "" Then
            Str3 = Nothing
        Else
            Str3 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        End If
        GridControl1.DataSource = oac.OutwardAcceptance_GetList(Nothing, Nothing, Str1, Nothing, Nothing, Nothing, Nothing, Str2, Nothing, Str3, Nothing, Nothing)

    End Sub
    '外發加工單報表
    '2010-11-8修改報表  目前主要針對的是配件外發測試！
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim ds As New DataSet

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
 

        Dim sfc As New OutwardController
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim osc As New LFERP.Library.Orders.OrdersSubController

        ds.Tables.Clear()

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("O_NO").ToString

        If GridView1.GetFocusedRowCellValue("OS_BatchID").ToString = "" Then

            ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, "LF", Nothing, Nothing))
            ltc2.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

            ds.Tables("OutwardMain").Columns.Add("P_ID", GetType(Integer))
            Dim i As Long

            For i = 0 To ds.Tables("OutwardMain").Rows.Count - 1
                ds.Tables("OutwardMain").Rows(i)("P_ID") = i + 1
            Next

            PreviewRPT(ds, "rptOutwardMain-1", "外發加工單", True, True)

            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing

        Else

            ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, "LF", Nothing, Nothing))
            ltc2.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, GridView1.GetFocusedRowCellValue("OS_BatchID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

            ds.Tables("OutwardMain").Columns.Add("P_ID", GetType(Integer))
            Dim i As Long

            For i = 0 To ds.Tables("OutwardMain").Rows.Count - 1
                ds.Tables("OutwardMain").Rows(i)("P_ID") = i + 1
            Next

            PreviewRPT(ds, "rptOutwardMain", "外發加工單", True, True)

            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
        End If

   

    End Sub

End Class