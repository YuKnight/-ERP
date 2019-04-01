Imports LFERP.Library.ProductionSchedule
Imports LFERP.SystemManager
Imports LFERP.DataSetting

Public Class frmProductionScheduleMain

    Dim psc As New ProductionScheduleControl

    Private Sub frmProductionScheduleMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim strID As String
        'strID = InUserID

        'Dim upi As List(Of UserPowerInfo)
        'Dim upc As New UserPowerControl

        'upi = upc.UserPower_GetList(strID, Nothing, Nothing, Nothing)
        'If upi.Count = 0 Then
        '    Exit Sub
        'Else

        '    If upi(0).UserRank = "管理" Then '管理權限可以看到所有的生產計劃
        '        Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    Else   '生產部--統計均只能看見本生產部得生產計劃(默認只能讓辦公室文員看見)
        '        Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Mid(upi(0).DepID, 1, 1), Nothing, Nothing, Nothing, Nothing, Nothing)
        '    End If

        'End If

        '@ 2012/8/10 修改為調用刷新過程
        cmsProductionRef_Click(Nothing, Nothing)

        PowerUser()
    End Sub

    Sub PowerUser() '設置權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsProductionAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsProductionEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsProductionDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsProductionCheck.Enabled = True
        End If
    End Sub

    '新增生產計劃
    Private Sub cmsProductionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionSchedule
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionSchedule Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "生產計劃"
        fr = New frmProductionSchedule
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    '修改指定生產計劃
    Private Sub cmsProductionEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionScheduleInfo)
        pi = psc.ProductionSchedule_GetList(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).PS_Check = True Then
            MsgBox("此生產計劃已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionSchedule
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionSchedule Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "生產計劃"
            tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString
            fr = New frmProductionSchedule
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    '刪除指定生產計劃
    Private Sub cmsProductionDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionScheduleInfo)
        pi = psc.ProductionSchedule_GetList(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi(0).PS_Check = True Then
            MsgBox("此生產計劃已被審核,不允許刪除")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("PS_NO").ToString & "的生產計劃嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If psc.ProductionSchedule_Delete(GridView1.GetFocusedRowCellValue("PS_NO").ToString, Nothing) = True Then
                    MsgBox("刪除當前生產計劃成功!")

                    '@ 2012/8/10 修改為調用刷新過程
                    cmsProductionRef_Click(Nothing, Nothing)
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If

                'Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                'Dim strID As String
                'strID = InUserID

                'Dim upi As List(Of UserPowerInfo)
                'Dim upc As New UserPowerControl

                'upi = upc.UserPower_GetList(strID, Nothing, Nothing, Nothing)
                'If upi.Count = 0 Then
                '    Exit Sub
                'Else

                '    'If upi(0).UserRank = "生產部" Then
                '    If upi(0).UserRank = "管理" Then
                '        Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                '    Else
                '        Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Mid(upi(0).DepID, 1, 1), Nothing, Nothing, Nothing, Nothing, Nothing)
                '    End If

                'End If

            End If
        End If
    End Sub

    '查詢生產計劃
    Private Sub cmsProductionSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionSelect.Click
        On Error Resume Next

        Dim frm As New frmProductionScheduleFind
        frm.ShowDialog()

        If tempValue8 = Nothing Then Exit Sub

        'Dim upi As List(Of UserPowerInfo)
        'Dim upc As New UserPowerControl

        'upi = upc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)
        'If upi.Count = 0 Then
        '    Exit Sub
        'Else
        '    'If upi(0).UserRank = "生產部" Then
        '    If upi(0).UserRank = "管理" Then
        '        Grid.DataSource = psc.ProductionSchedule_GetList(tempValue, tempValue2, tempValue7, tempValue3, tempValue4, tempValue5, tempValue6, Nothing)
        '    Else
        '        Grid.DataSource = psc.ProductionSchedule_GetList(tempValue, tempValue2, Mid(upi(0).DepID, 1, 1), tempValue3, tempValue4, tempValue5, tempValue6, Nothing)
        '    End If
        'End If

        '@ 2012/8/10 修改
        Grid.DataSource = psc.ProductionSchedule_GetList(tempValue, tempValue2, tempValue7, tempValue3, tempValue4, tempValue5, tempValue6, Nothing)

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
    End Sub

    '查看選定生產計劃
    Private Sub cmsProductionView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
       
        Dim fr As frmProductionSchedule
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionSchedule Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString
        fr = New frmProductionSchedule
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    '刷新操作
    '此過程被以下過程調用：
    'frmProductionScheduleMain_Load()
    'cmsProductionDel_Click()
    Private Sub cmsProductionRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionRef.Click
        'Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        'Dim strID As String
        'strID = InUserID

        'Dim upi As List(Of UserPowerInfo)
        'Dim upc As New UserPowerControl

        'upi = upc.UserPower_GetList(strID, Nothing, Nothing, Nothing)
        'If upi.Count = 0 Then
        '    Exit Sub
        'Else

        ' If upi(0).UserRank = "生產部" Then

        '@ 2012/8/10 修改
        If strInUserRank = "管理" Then         '管理權限可以看到所有的生產計劃
            Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), DateAdd(DateInterval.Day, 7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing)
        Else     '生產部--統計均只能看見本生產部得生產計劃(默認只能讓辦公室文員看見)
            Grid.DataSource = psc.ProductionSchedule_GetList(Nothing, Nothing, strInFacID, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), DateAdd(DateInterval.Day, 7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing)
        End If

        'End If

    End Sub

    '審核選定生產計劃--以便實施
    Private Sub cmsProductionCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmProductionSchedule
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionSchedule Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "Check"
        tempValue3 = GridView1.GetFocusedRowCellValue("PS_NO").ToString
        fr = New frmProductionSchedule
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        Dim frm As New frmProductionSchedule1
        frm.ShowDialog()
    End Sub

    '跟蹤原材料使用狀況
    Private Sub cmsProductionMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionMaterial.Click
        Dim frm As New frmProductionMaterial
        frm.ShowDialog()

    End Sub

End Class