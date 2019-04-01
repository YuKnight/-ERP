Imports LFERP.Library.Production.ProductionOutWard


Public Class frmProductionOutWardMain

    Dim poc As New ProductionOutWardControl

    '@ 2012/2/21 修改 只顯示當前15天內記錄
    Private Sub frmProductionOutWardMain1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "發料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        Grid2.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "收料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))

        cmsInAdd.Visible = False   '默認選擇為外發
        cmsOutAdd.Visible = True

        UserPower()
    End Sub
    '在剛操作階段權限設置為完全權限
    Sub UserPower() '設置權限()

    End Sub

    Private Sub cmsInAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsInAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionOutWard
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionOutWard Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionOutWard
        tempValue = "OutWard"
        tempValue2 = "收料"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionOutWard
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionOutWard Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionOutWard
        tempValue = "OutWard"
        tempValue2 = "發料"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click


        Dim strID As String
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If GridView1.RowCount = 0 Then Exit Sub
            strID = GridView1.GetFocusedRowCellValue("OW_ID").ToString
        Else
            If GridView2.RowCount = 0 Then Exit Sub
            strID = GridView2.GetFocusedRowCellValue("OW_ID").ToString
        End If

        Dim poi As List(Of ProductionOutWardInfo)
        poi = poc.ProductionOutWard_GetList(strID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If poi.Count = 0 Then
            Exit Sub
        Else
            If poi(0).OW_Check = True Then
                MsgBox("此單已審核,不允許修改!")
                Exit Sub
            Else
                On Error Resume Next
                Edit = True
                Dim fr As frmProductionOutWard
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmProductionOutWard Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                fr = New frmProductionOutWard
                tempValue = "OutWard"
                tempValue2 = poi(0).OW_Detail
                tempValue3 = strID
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            End If
        End If
    End Sub

    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        Dim strID As String
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If GridView1.RowCount = 0 Then Exit Sub
            strID = GridView1.GetFocusedRowCellValue("OW_ID").ToString
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If GridView2.RowCount = 0 Then Exit Sub
            strID = GridView2.GetFocusedRowCellValue("OW_ID").ToString
        End If

        Dim poi As List(Of ProductionOutWardInfo)
        poi = poc.ProductionOutWard_GetList(strID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If poi.Count = 0 Then
            Exit Sub
        Else
            If poi(0).OW_Check = True Then
                MsgBox("此單已審核,不允許修改!")
                Exit Sub
            Else
                If MsgBox("你確定刪除物料收發單號為  '" & strID & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If poc.ProductionOutWard_Delete(strID, Nothing) = True Then
                        MsgBox("刪除成功!")
                        If XtraTabControl1.SelectedTabPageIndex = 0 Then    '@ 2012/2/21 修改 只顯示當前15天內記錄
                            Grid.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "發料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                            Grid2.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "收料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                        End If

                    Else
                        MsgBox("刪除此單號信息失敗,請檢查原因!")
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmsPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        On Error Resume Next

        Dim strID As String
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If GridView1.RowCount = 0 Then Exit Sub
            strID = GridView1.GetFocusedRowCellValue("OW_ID").ToString
        Else
            If GridView2.RowCount = 0 Then Exit Sub
            strID = GridView2.GetFocusedRowCellValue("OW_ID").ToString
        End If
        Dim poi As List(Of ProductionOutWardInfo)
        poi = poc.ProductionOutWard_GetList(strID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If poi.Count = 0 Then
            Exit Sub
        End If
        Dim fr As frmProductionOutWard
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionOutWard Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionOutWard
        tempValue = "PreView"
        tempValue2 = poi(0).OW_Detail
        tempValue3 = strID
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    '外發單查詢信息
    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click

        Dim frm As New frmProductionOutWardSelect
        frm.ShowDialog()
        If frm.isClickcmdSave = True Then
            If XtraTabControl1.SelectedTabPageIndex = 0 Then
                Grid.DataSource = poc.ProductionOutWard_GetList(tempValue, tempValue2, tempValue3, "發料", tempValue4, tempValue6, tempValue5, tempValue7, tempValue8, tempValue9, tempValue10, tempCode)
            ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                Grid2.DataSource = poc.ProductionOutWard_GetList(tempValue, tempValue2, tempValue3, "收料", tempValue4, tempValue6, tempValue5, tempValue7, tempValue8, tempValue9, tempValue10, tempCode)
            End If
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
        tempValue10 = ""
        tempCode = ""
    End Sub

    '@ 2012/2/21 修改 只顯示當前15天內記錄
    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Grid.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "發料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Grid2.DataSource = poc.ProductionOutWard_GetList(Nothing, Nothing, Nothing, "收料", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If

    End Sub

    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click

        Dim strA As String = ""

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If GridView1.RowCount = 0 Then Exit Sub
            strA = GridView1.GetFocusedRowCellValue("OW_ID").ToString
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If GridView2.RowCount = 0 Then Exit Sub
            strA = GridView2.GetFocusedRowCellValue("OW_ID").ToString
        End If

        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim pfc As New ProductionOutWardControl    '物料收發信息
        ds.Tables.Clear()

        Dim pfi As List(Of ProductionOutWardInfo)

        pfi = pfc.ProductionOutWard_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pfi.Count = 0 Then
            MsgBox("不存在當前單號記錄,請檢查!")
            Exit Sub
        End If
        ltc.CollToDataSet(ds, "ProductionOutWard", pfc.ProductionOutWard_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        If pfi(0).OW_Detail = "發料" Then
            PreviewRPT(ds, "rptProductionOutWard", "內部外發單", True, True)
        ElseIf pfi(0).OW_Detail = "收料" Then
            PreviewRPT(ds, "rptProductionOutWard1", "內部送貨單", True, True)
        End If

        ltc = Nothing

    End Sub

    Private Sub cmsPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrintAll.Click

    End Sub

    Private Sub cmsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCheck.Click
        Dim strID As String = ""
        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            If GridView1.RowCount = 0 Then Exit Sub
            strID = GridView1.GetFocusedRowCellValue("OW_ID").ToString
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then

            If GridView2.RowCount = 0 Then Exit Sub
            strID = GridView2.GetFocusedRowCellValue("OW_ID").ToString
        End If

        Dim poi As List(Of ProductionOutWardInfo)
        poi = poc.ProductionOutWard_GetList(strID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If poi.Count = 0 Then
            Exit Sub
        Else
            'If poi(0).OW_Check = True Then
            '    MsgBox("此單已審核,不允許再次審核操作!")
            '    Exit Sub
            'Else
            On Error Resume Next

            Dim fr As frmProductionOutWard
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionOutWard Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionOutWard
            tempValue = "Check"
            tempValue2 = poi(0).OW_Detail
            tempValue3 = strID
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
            'End If
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            cmsInAdd.Visible = False
            cmsOutAdd.Visible = True
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            cmsInAdd.Visible = True
            cmsOutAdd.Visible = False
        End If

    End Sub


End Class