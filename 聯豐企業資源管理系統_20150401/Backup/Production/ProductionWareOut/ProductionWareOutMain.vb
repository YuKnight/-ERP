Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.Production.ProuctionWareOut

Public Class ProductionWareOutMain

    Private Sub popWareMoveOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As ProductionWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "出貨單"
        tempValue3 = ""
        fr = New ProductionWareOutSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub popWareMoveEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionWareOutInfo)
        Dim pc As New ProductionWareOutControl
        pi = pc.ProductionWareOut_GetList(GridView1.GetFocusedRowCellValue("PWO_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).PWO_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As ProductionWareOutSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is ProductionWareOutSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "出貨單"
            tempValue3 = GridView1.GetFocusedRowCellValue("PWO_NO").ToString
            fr = New ProductionWareOutSub
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub popWareMoveDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionWareOutInfo)
        Dim pc As New ProductionWareOutControl
        pi = pc.ProductionWareOut_GetList(GridView1.GetFocusedRowCellValue("PWO_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi(0).PWO_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("PWO_NO").ToString & "的出貨單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pc.ProductionWareOut_Delete(GridView1.GetFocusedRowCellValue("PWO_NO").ToString, Nothing) = True Then
                    MsgBox("刪除當前出貨單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pc.ProductionWareOut_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub popWareOutView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As ProductionWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("PWO_NO").ToString
        fr = New ProductionWareOutSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popWareOutflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutflesh.Click
        Dim pc As New ProductionWareOutControl
        Grid.DataSource = pc.ProductionWareOut_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub popWareOutSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutSeek.Click
        ProductionWareOutSelect.ShowDialog()
        Dim pc As New ProductionWareOutControl
        If tempValue <> Nothing Then
            Grid.DataSource = pc.ProductionWareOut_GetList(tempValue4, Nothing, tempValue3, Nothing, tempValue5, Nothing, Nothing, tempValue6, tempValue7, tempValue2, tempValue8)
        End If
        ProductionWareOutSelect.Dispose()


        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
    End Sub

    Private Sub popWareOutReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutReport.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        Dim Str As String

        Str = GridView1.GetFocusedRowCellValue("PWO_NO").ToString

        Dim ltc As New CollectionToDataSet
        Dim pc As New ProductionWareOutControl
        Dim pi As New ProductionWareOutInfo

        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "ProductionWareOut", pc.ProductionWareOut_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ds.Tables("ProductionWareOut").Columns.Add("PWO_ID", GetType(Integer))
        Dim i As Long
        For i = 0 To ds.Tables("ProductionWareOut").Rows.Count - 1
            ds.Tables("ProductionWareOut").Rows(i)("PWO_ID") = i + 1
        Next

        PreviewRPT(ds, "ProductionWareOut", "成品出庫單", True, True)

        ltc = Nothing
    End Sub

    Private Sub popWareOutCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As ProductionWareOutSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "Check"
        tempValue3 = GridView1.GetFocusedRowCellValue("PWO_NO").ToString
        fr = New ProductionWareOutSub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ProductionWareOutMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next
        Dim pc As New ProductionWareOutControl
        Grid.DataSource = pc.ProductionWareOut_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        PowerUser()
    End Sub
    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880701")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880702")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880703")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880704")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutCheck.Enabled = True
        End If

        'popWareOutSeek.Enabled = False
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880706")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutSeek.Enabled = True
        'End If

    End Sub


End Class