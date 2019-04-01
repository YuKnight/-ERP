Imports LFERP.Library.ProductionFieldChange
Imports LFERP.SystemManager
Imports LFERP.Library.ProductionDPTWareInventory


Public Class frmProductionFieldChangeMain

    Dim pc As New ProductionFieldChangeControl

    Private Sub frmProductionFieldChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid.DataSource = pc.ProductionFieldChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        UserPower()

    End Sub

    Sub UserPower() '設置權限

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8804201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                ChangeAdd.Enabled = True
                ChangeReAdd.Enabled = True
            End If
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8804202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ChangeEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8804203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ChangeDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8804204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ChangeCheck.Enabled = True
        End If

    End Sub

    Private Sub ChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAdd.Click

        On Error Resume Next
        Edit = False

        Dim fr As frmProductionFieldChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "Change"
        fr = New frmProductionFieldChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub
    Private Sub ChangeReAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeReAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionFieldChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "ChangeReQty"
        fr = New frmProductionFieldChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    Private Sub ChangeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeEdit.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionFieldChangeInfo)
        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PC_NO").ToString
        pi = pc.ProductionFieldChange_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi.Count = 0 Then Exit Sub

        If pi(0).PC_Check = True Then
            MsgBox("此更改單已審核,不允許再修改!")
            Exit Sub
        Else
            Edit = True

            Dim fr As frmProductionFieldChange
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldChange Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            If pi(0).PC_Qty <> 0 Then
                tempValue2 = "Change"
            ElseIf pi(0).PC_ReQty <> 0 Then
                tempValue2 = "ChangeReQty"
            End If
            tempValue3 = strNO
            fr = New frmProductionFieldChange
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub ChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionFieldChangeInfo)
        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PC_NO").ToString
        pi = pc.ProductionFieldChange_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi.Count = 0 Then Exit Sub

        If pi(0).PC_Check = True Then
            MsgBox("此單已審核不允許再刪除!")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & strNO & "的更改單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pc.ProductionFieldChange_Delete(Nothing, strNO) = True Then
                    MsgBox("刪除當前更改單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pc.ProductionFieldChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub ChangePreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePreView.Click
        If GridView1.RowCount = 0 Then Exit Sub
        On Error Resume Next

        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PC_NO").ToString

        Dim fr As frmProductionFieldChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = strNO
        fr = New frmProductionFieldChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ChangeRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeRef.Click
        Grid.DataSource = pc.ProductionFieldChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub ChangeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionFieldChangeInfo)
        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PC_NO").ToString
        pi = pc.ProductionFieldChange_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi.Count = 0 Then Exit Sub

        If pi(0).PC_Check = True Then
            MsgBox("此更改單已審核,不允許再次操作!")
            Exit Sub
        Else

            Dim fr As frmProductionFieldChange
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldChange Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            If pi(0).PC_Qty <> 0 Then
                tempValue2 = "Check"
            ElseIf pi(0).PC_ReQty <> 0 Then
                tempValue2 = "ReCheck"
            End If
            'tempValue2 = "Check"
            tempValue3 = strNO
            fr = New frmProductionFieldChange
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub ChangePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PC_NO").ToString

        Dim ds As New DataSet
        ds.Tables.Clear()

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        Dim pfi As List(Of ProductionFieldChangeInfo)
        Dim dic As New ProductionDPTWareInventoryControl

        pfi = pc.ProductionFieldChange_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pfi.Count = 0 Then Exit Sub

        ltc.CollToDataSet(ds, "ProductionFieldChange", pc.ProductionFieldChange_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "ProductionDPTWareInventory", dic.ProductionDPTWareInventory_GetList(pfi(0).DepID, pfi(0).Pro_NO, Nothing))

        If pfi(0).PC_Check = True Then
            PreviewRPT(ds, "rptProductionChange", "生產更改單", True, True)
        Else
            PreviewRPT(ds, "rptProductionChange", "生產更改單", True, False)

        End If

        ltc = Nothing
        ltc1 = Nothing

    End Sub

   
End Class