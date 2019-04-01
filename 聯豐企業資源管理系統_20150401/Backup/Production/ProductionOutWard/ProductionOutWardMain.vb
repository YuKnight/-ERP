Imports LFERP.Library.ProductionField
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionController

Public Class ProductionOutWardMain

    Dim pfc As New Library.ProductionField.ProductionFieldControl
    Dim strDPT As String


    Private Sub ProductionOutWardMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        twWare.ExpandAll()

        Dim fci As List(Of ProductionFieldControlInfo)
        Dim fc As New LFERP.Library.ProductionController.ProductionFieldControl
        fci = fc.ProductionFieldControl_GetList(InUserID, Nothing)

        If fci.Count = 0 Then Exit Sub

        strDPT = fci(0).ControlDep  '唯一外發部 

        'Dim a As New Library.ProductionField.ProductionFieldControl
        'Dim b As New List(Of ProductionFieldInfo)
        'Dim c As New List(Of ProductionFieldInfo)

        'Dim strDPT As String

        'Dim ui As List(Of UserPowerInfo)
        'Dim uc As New UserPowerControl
        'ui = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        'If ui.Count = 0 Then
        '    Exit Sub
        'Else
        '    If ui(0).UserRank = "管理" Then
        '        strDPT = Nothing
        '    ElseIf ui(0).UserRank = "生產部" Then

        '        strDPT = Mid(ui(0).DepID, 1, 1)
        '    Else

        '        strDPT = ui(0).DepID
        '    End If

        'End If



        '    b = a.ProductionField_GetList(Nothing, Nothing, "發料", Nothing, strDPT, Nothing, Nothing, False, Nothing, Nothing, "2")
        '    c = a.ProductionField_GetList(Nothing, Nothing, "收料", Nothing, strDPT, Nothing, Nothing, False, Nothing, Nothing, "2")

        '    If b.Count > 0 Then
        '        twWare.Nodes.Item(1).Nodes.Item(0).Text = "未審核 (" & b.Count & ")"
        '    Else
        '        twWare.Nodes.Item(1).Nodes.Item(0).Text = "未審核"
        '    End If

        '    If c.Count > 0 Then
        '        twWare.Nodes.Item(0).Nodes.Item(0).Text = "未審核 (" & c.Count & ")"
        '    Else
        '        twWare.Nodes.Item(0).Nodes.Item(0).Text = "未審核"
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub twWare_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twWare.AfterSelect
        'Dim strDPT As String

        'Dim ui As List(Of UserPowerInfo)
        'Dim uc As New UserPowerControl
        'ui = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        'If ui.Count = 0 Then
        '    Exit Sub
        'Else
        '    If ui(0).UserRank = "管理" Then
        '        strDPT = Nothing
        '    ElseIf ui(0).UserRank = "生產部" Then

        '        strDPT = Mid(ui(0).DepID, 1, 1)
        '    Else

        '        strDPT = ui(0).DepID
        '    End If

        'End If

        If e.Node.Level = 2 Then
            Select Case Mid(twWare.SelectedNode.Text, 1, 3)

                Case "未審核"
                    If twWare.SelectedNode.Parent.Text = "收入項目" Then
                        Pro_NO.Caption = "收料工序"
                        Pro_NO1.Caption = "發料工序"
                        Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "收料", Nothing, strDPT, Nothing, Nothing, False, Nothing, Nothing, "2", Nothing, Nothing)

                    End If
                    If twWare.SelectedNode.Parent.Text = "發出項目" Then
                        Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "發料", Nothing, strDPT, Nothing, Nothing, False, Nothing, Nothing, "2", Nothing, Nothing)
                        Pro_NO1.Caption = "收料工序"
                        Pro_NO.Caption = "發料工序"
                    End If

                Case "已審核"
                    If twWare.SelectedNode.Parent.Text = "收入項目" Then
                        Pro_NO.Caption = "收料工序"
                        Pro_NO1.Caption = "發料工序"
                        Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "收料", Nothing, strDPT, Nothing, Nothing, True, Nothing, Nothing, "2", Nothing, Nothing)

                    End If
                    If twWare.SelectedNode.Parent.Text = "發出項目" Then
                        Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "發料", Nothing, strDPT, Nothing, Nothing, True, Nothing, Nothing, "2", Nothing, Nothing)
                        Pro_NO1.Caption = "收料工序"
                        Pro_NO.Caption = "發料工序"
                    End If

            End Select
        End If
    End Sub

    Private Sub cmsInAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsInAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionFieldCodeIn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldCodeIn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldCodeIn
        tempValue = "CodeIn"
        tempValue2 = "PT14"
        tempValue5 = strDPT
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutAdd.Click
        On Error Resume Next

        Edit = False

        Dim fr As frmProductionFieldCodeOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldCodeOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldCodeOut
        tempValue = "CodeHouse"
        tempValue2 = "PT14"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pfi1 As List(Of ProductionFieldInfo)
        Dim pfi As List(Of ProductionFieldInfo)

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type")

        pfi1 = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, "收料", Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi1.Count <> 0 Then
            MsgBox("此操作已被確認,不允許更改!")
            Exit Sub
        End If

        pfi = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, strType, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi.Count = 0 Then Exit Sub

        If pfi(0).FP_Detail = "PT14" And strType = "收料" And pfi(0).IW_NO <> "" Then '開料對應PT03,加存對應PT04

            Edit = True
            Dim fr As frmProductionFieldCodeIn
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldCodeIn Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionFieldCodeIn
            tempValue = "CodeIn"
            tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        ElseIf pfi(0).FP_Detail = "PT14" And strType = "發料" Then '大貨對應PT01,返修對應PT02

            If GridView1.GetFocusedRowCellValue("FP_Type").ToString <> "發料" Then
                MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！")
                Exit Sub
            Else

                Dim pfi2 As List(Of ProductionFieldInfo)
                Dim pfc2 As New Library.ProductionField.ProductionFieldControl

                pfi2 = pfc2.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
                If pfi2.Count = 0 Then Exit Sub

                If pfi2.Count = 1 Then
                    Edit = True
                    Dim fr As frmProductionFieldCodeOut
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCodeOut Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCodeOut
                    tempValue = "CodeHouse"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                Else

                    Edit = True
                    Dim fr As frmProductionFieldCode
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCode Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCode
                    tempValue = "CodeOut"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                End If
            End If
         
        End If
    End Sub

    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pfi1 As List(Of ProductionFieldInfo)
        pfi1 = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, "收料", Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi1.Count <> 0 Then
            MsgBox("此操作已被確認,不允許刪除!")
            Exit Sub
        End If

        Dim pfi As List(Of ProductionFieldInfo)

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type").ToString

        pfi = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, strType, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi.Count = 0 Then Exit Sub

        If pfi(0).FP_Detail = "PT14" And strType = "收料" Then

            If MsgBox("你確定刪除物料收發單號為  '" & GridView1.GetFocusedRowCellValue("FP_NO").ToString & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If pfc.ProductionField_Delete(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing) = True Then
                    MsgBox("刪除成功!")
                    Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "收料", Nothing, pfi(0).FP_OutDep, Nothing, False, False, Nothing, Nothing, "2", Nothing, Nothing)
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
            End If

        ElseIf pfi(0).FP_Detail = "PT14" And strType = "發料" Then
          

            If MsgBox("你確定刪除物料收發單號為  '" & GridView1.GetFocusedRowCellValue("FP_NO").ToString & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If pfc.ProductionField_Delete(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing) = True Then
                    MsgBox("刪除成功!")
                    Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, "發料", Nothing, pfi(0).FP_OutDep, Nothing, False, False, Nothing, Nothing, "2", Nothing, Nothing)
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
            End If
     
        End If
    End Sub

    Private Sub cmsPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pfi1 As List(Of ProductionFieldInfo)
        Dim pfi As List(Of ProductionFieldInfo)

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type")

        pfi = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, strType, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi.Count = 0 Then Exit Sub

        If pfi(0).FP_Detail = "PT14" And strType = "收料" And pfi(0).IW_NO <> "" Then '開料對應PT03,加存對應PT04

            Dim fr As frmProductionFieldCodeIn
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldCodeIn Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionFieldCodeIn
            tempValue = "PreView"
            tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        ElseIf pfi(0).FP_Detail = "PT14" And strType = "發料" Then '大貨對應PT01,返修對應PT02

            If GridView1.GetFocusedRowCellValue("FP_Type").ToString <> "發料" Then
                MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！")
                Exit Sub
            Else

                Dim pfi2 As List(Of ProductionFieldInfo)
                Dim pfc2 As New Library.ProductionField.ProductionFieldControl

                pfi2 = pfc2.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
                If pfi2.Count = 0 Then Exit Sub

                If pfi2.Count = 1 Then

                    Dim fr As frmProductionFieldCodeOut
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCodeOut Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCodeOut
                    tempValue = "PreView"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                Else

                    Dim fr As frmProductionFieldCode
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCode Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCode
                    tempValue = "PreView"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                End If
            End If

        End If
    End Sub

    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click
        Dim frm As New frmProductionFieldSelect
        frm.ShowDialog()

        Dim upi As List(Of UserPowerInfo)
        Dim upc As New UserPowerControl
        upi = upc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        'Dim strDep As String

        'If upi.Count = 0 Then
        '    Exit Sub
        'Else
        '    If upi(0).UserRank = "管理" Then
        '        strDep = Nothing
        '    ElseIf upi(0).UserRank = "生產部" Then
        '        strDep = Mid(upi(0).DepID, 1, 1)
        '    Else
        '        strDep = upi(0).DepID
        '    End If

        'End If
        Grid.DataSource = pfc.ProductionField_GetList1(Nothing, tempValue2, tempValue3, tempValue4, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing, tempValue5, tempValue6, Nothing, Nothing)

        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
    End Sub

    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type").ToString

        'Dim upi As List(Of UserPowerInfo)
        'Dim upc As New UserPowerControl
        'upi = upc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        'Dim strDep As String

        'If upi.Count = 0 Then
        '    Exit Sub
        'Else
        '    If upi(0).UserRank = "管理" Then
        '        strDep = Nothing
        '    ElseIf upi(0).UserRank = "生產部" Then
        '        strDep = Mid(upi(0).DepID, 1, 1)
        '    Else
        '        strDep = upi(0).DepID
        '    End If

        'End If
        Grid.DataSource = pfc.ProductionField_GetList(Nothing, Nothing, strType, Nothing, strDPT, Nothing, False, False, Nothing, Nothing, "2", Nothing, Nothing)
    End Sub

    Private Sub cmsInCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsInCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pfi1 As List(Of ProductionFieldInfo)
        Dim pfi As List(Of ProductionFieldInfo)

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type")

        pfi = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, strType, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
        If pfi.Count = 0 Then Exit Sub

        If pfi(0).FP_Detail = "PT14" And strType = "收料" And pfi(0).IW_NO <> "" Then '開料對應PT03,加存對應PT04

            Dim fr As frmProductionFieldCodeIn
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldCodeIn Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionFieldCodeIn
            tempValue = "InCheck"
            tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        ElseIf pfi(0).FP_Detail = "PT14" And strType = "收料" And pfi(0).IW_NO = "" Then

            Dim fr As frmProductionFieldCode
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionFieldCode Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmProductionFieldCode
            tempValue = "InCheck"
            tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        ElseIf pfi(0).FP_Detail = "PT14" And strType = "發料" Then '大貨對應PT01,返修對應PT02

            If GridView1.GetFocusedRowCellValue("FP_Type").ToString <> "發料" Then
                MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！")
                Exit Sub
            Else

                Dim pfi2 As List(Of ProductionFieldInfo)
                Dim pfc2 As New Library.ProductionField.ProductionFieldControl

                pfi2 = pfc2.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)
                If pfi2.Count = 0 Then Exit Sub

                If pfi2.Count = 1 Then

                    Dim fr As frmProductionFieldCodeOut
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCodeOut Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCodeOut
                    tempValue = "InCheck"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                Else

                    Dim fr As frmProductionFieldCode
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmProductionFieldCode Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    fr = New frmProductionFieldCode
                    tempValue = "InCheck"
                    tempValue4 = GridView1.GetFocusedRowCellValue("FP_NO").ToString
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                End If
            End If

        End If
    End Sub

    '列印外發單
    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim pfc As New Library.ProductionField.ProductionFieldControl  '物料收發信息
        ds.Tables.Clear()

        Dim pfi As List(Of ProductionFieldInfo)

        Dim strType As String
        strType = GridView1.GetFocusedRowCellValue("FP_Type")

        pfi = pfc.ProductionField_GetList(GridView1.GetFocusedRowCellValue("FP_NO").ToString, Nothing, strType, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing, Nothing)

        If pfi(0).FP_Detail = "PT14" And strType = "發料" Then
            Dim strA, strB, strC As String

            strA = GridView1.GetFocusedRowCellValue("FP_NO").ToString
            strB = "G101"
            strC = "F101"
            If GridView1.GetFocusedRowCellValue("FP_InDep").ToString <> strB And GridView1.GetFocusedRowCellValue("FP_OutDep").ToString <> strC Then
                Exit Sub
            End If
            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, Nothing, Nothing, Nothing, Nothing))
        End If

        PreviewRPT(ds, "rptProductionOutWard", "外發單", True, True)

        ltc = Nothing

    End Sub

    Private Sub cmsSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsSend.Click
        On Error Resume Next

        Edit = False

        Dim fr As frmProductionFieldCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldCode
        tempValue = "CodeOut"
        tempValue2 = "PT14"
        tempValue5 = strDPT
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    '列印當前外發匯總信息（外發至聯豐以及送回信息，按產品區分）
    Private Sub cmsPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrintAll.Click
        Dim frm As New frmProductionOutWardQuery
        frm.ShowDialog()

    End Sub

End Class