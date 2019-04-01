Imports LFERP.Library.ProductionKaiLiaoReturn
Imports LFERP.SystemManager
Imports LFERP.DataSetting


Public Class frmProductionKaiLiaoReturnMain
    Dim strDPT As String ''只顯示本廠別

    Private Sub frmProductionKaiLiaoReturnMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ui As New List(Of UserPowerInfo)
        Dim uc As New UserPowerControl
        ui = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        If ui.Count = 0 Then
            Exit Sub
        Else
            If ui(0).UserRank = "管理" Then
                strDPT = Nothing
            Else
                strDPT = Mid(ui(0).DepID, 1, 1)
            End If
        End If

        PowerUser()
        cmsProductionRef_Click(Nothing, Nothing)
    End Sub

    Private Sub cmsProductionRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionRef.Click
        

        Dim rc As New ProductionKaiLiaoReturnControl
        Me.Grid.DataSource = rc.ProductionKaiLiaoReturn_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing)
    End Sub

    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionAdd.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionEdit.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionDel.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionCheck.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802005")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionPrint.Enabled = True
            End If
        End If
        
    End Sub

    Private Sub cmsProductionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionAdd.Click
        ''新增
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionKaiLiaoReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiaoReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionKaiLiaoReturn
        fr.EditItem = "Add"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionEdit.Click
        ''修改
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As New List(Of ProductionKaiLiaoReturnInfo)
        Dim pkc As New ProductionKaiLiaoReturnControl
        pi = pkc.ProductionKaiLiaoReturn_GetList(Nothing, GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).R_ActQty > 0 Then
            MsgBox("此退料單已進行退料操作,不允許修改!")
            Exit Sub
        End If

        If pi(0).RCheck = True Then
            MsgBox("此退料單已被審核,不允許修改!")
            Exit Sub
        Else
            Dim fr As frmProductionKaiLiaoReturn
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionKaiLiaoReturn Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionKaiLiaoReturn
            fr.EditItem = "Update"
            fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmsProductionDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As New List(Of ProductionKaiLiaoReturnInfo)
        Dim pkc As New ProductionKaiLiaoReturnControl
        pi = pkc.ProductionKaiLiaoReturn_GetList(Nothing, GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).R_ActQty > 0 Then
            MsgBox("此退料單已進行退料操作,不允許刪除!")
            Exit Sub
        End If

        If pi(0).RCheck = True Then
            MsgBox("此退料單已被審核,不允許刪除!")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("R_NO").ToString & "的退料單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pkc.ProductionKaiLiaoReturn_Delete(Nothing, GridView1.GetFocusedRowCellValue("R_NO").ToString) = True Then
                    MsgBox("刪除當前開料單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If

                cmsProductionRef_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub cmsProductionView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmProductionKaiLiaoReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiaoReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionKaiLiaoReturn
        fr.EditItem = "View"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub



    Private Sub cmsProductionCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionCheck.Click
        ''修改
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As New List(Of ProductionKaiLiaoReturnInfo)
        Dim pkc As New ProductionKaiLiaoReturnControl
        pi = pkc.ProductionKaiLiaoReturn_GetList(Nothing, GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).R_ActQty > 0 Then
            MsgBox("此退料單已進行退料操作,不允許審核!")
            Exit Sub
        End If

        Dim fr As frmProductionKaiLiaoReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiaoReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionKaiLiaoReturn
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub cmsProductionPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionPrint.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim pi As New List(Of ProductionKaiLiaoReturnInfo)
        Dim pkc As New ProductionKaiLiaoReturnControl
        Dim ltc As New CollectionToDataSet
        Dim dsPrint As New DataSet
        pi = pkc.ProductionKaiLiaoReturn_GetList(Nothing, GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi.Count <= 0 Then
            MsgBox("退料數據不存在")
            Exit Sub
        End If

        ltc.CollToDataSet(dsPrint, "ProductionKaiLiaoReturn", pi)
        PreviewRPTDialog(dsPrint, "rptProductionKaiLiaoReturn", "退料單", True, True)
        ltc = Nothing
    End Sub

    Private Sub cmsProductionSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionSelect.Click
        Dim rcc As New ProductionKaiLiaoReturnControl
        frmProductionKaiLiaoReturnSeek.ShowDialog()

        If tempValue = Nothing Then
            Exit Sub
        End If

        Me.Grid.DataSource = rcc.ProductionKaiLiaoReturn_GetList(Nothing, tempValue2, Nothing, tempValue3, tempValue4, tempValue6, tempValue7, tempValue5, Nothing, strDPT, Nothing, Nothing, Nothing)

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing

    End Sub
End Class