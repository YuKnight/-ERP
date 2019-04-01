Imports lferp.Library.ProductionPiecePersonnelDay
Imports LFERP.Library.ProductionSumPiecePersonnel
Imports LFERP.Library.ProductionSumPieceWorkGroup
Imports LFERP.Library.ProductionSumTimePersonnel
Imports LFERP.Library.ProductionSumTimeWorkGroup
Imports LFERP.SystemManager.SystemUser

Public Class ProductionPiecePersonnelDayMain

    Private Sub popPiecePersonnelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelAdd.Click
        On Error Resume Next

        Dim fr As ProductionPiecePersonnelDaySub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionPiecePersonnelDaySub Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = Nothing
        MTypeName = "PD_add"

        fr = New ProductionPiecePersonnelDaySub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub


    Private Sub popPiecePersonnelRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelRef.Click
        Dim pdc As New ProductionPiecePersonnelDayControl
        Grid1.DataSource = pdc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Format(Now, "yyyy/MM/dd"), Nothing, Nothing, Format(Now, "yyyy/MM/dd"), Nothing)
    End Sub

    Private Sub ProductionPiecePersonnelDayMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        popPiecePersonnelRef_Click(Nothing, Nothing)

        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160401")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160402")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160403")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelDel.Enabled = True
        End If
    End Sub

    Private Sub popPiecePersonnelDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelDel.Click
        ''刪除數據
        Dim pdc As New ProductionPiecePersonnelDayControl
        Dim pdi As New ProductionPiecePersonnelDayInfo
        Dim strA, strB As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strDate1, strDep1, strPer_NO1, strG_NO1 As String

        strDate1 = GridView1.GetFocusedRowCellValue("Per_Date").ToString
        strDep1 = GridView1.GetFocusedRowCellValue("DepID").ToString
        strPer_NO1 = GridView1.GetFocusedRowCellValue("Per_NO").ToString
        strG_NO1 = GridView1.GetFocusedRowCellValue("G_NO").ToString

        If Check_Delete(strDate1, strDep1, strPer_NO1, strG_NO1, "不能刪除,  ") = False Then Exit Sub

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString
        strB = GridView1.GetFocusedRowCellValue("Per_Name").ToString

        If MsgBox("你確定刪除員工姓名為:  '" & strB & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If pdc.ProductionPiecePersonnelDay_Delete(strA) = True Then
                MsgBox("刪除成功")
                popPiecePersonnelRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("刪除失敗")
            End If
        End If
    End Sub


    ''' <summary>
    ''' 當個人編號在個人計件，個人計時中存在時不能刪除 ,組別編號存的於組別計件，組別計時中時不能刪除
    ''' </summary>
    ''' <param name="strDate"></param>
    ''' <param name="strDep"></param>
    ''' <param name="strPer_NO"></param>
    ''' <param name="strG_NO"></param>
    ''' <param name="MsgStr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Check_Delete(ByVal strDate As String, ByVal strDep As String, ByVal strPer_NO As String, ByVal strG_NO As String, ByVal MsgStr As String) As Boolean


        Check_Delete = True

        If strG_NO = "無" Then
            ''檢查指定日期，部門，個人編號是否已進行，個人計件，個人計時，（無組別）
            Dim dec As New ProductionSumPiecePersonnelControl
            Dim dcil As New List(Of ProductionSumPiecePersonnelInfo)

            dcil = dec.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, strPer_NO, Nothing, strDep, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDate, Nothing, strDate, Nothing)

            If dcil.Count > 0 Then
                MsgBox(MsgStr & "此員工編號當天已進行個人計件操作")
                Check_Delete = False
                Exit Function
            End If

            Dim dec1 As New ProductionSumTimePersonnelControl
            Dim dcil1 As New List(Of ProductionSumTimePersonnelInfo)

            dcil1 = dec1.ProductionSumTimePersonnel_GetList(Nothing, strPer_NO, Nothing, strDep, Nothing, strDate, Nothing, strDate, Nothing, Nothing, Nothing)

            If dcil1.Count > 0 Then
                MsgBox(MsgStr & "此員工編號當天已進行個人計時操作")
                Check_Delete = False
                Exit Function
            End If

        Else
            ''檢查指定日期，部門，組別編號是否已進行，組別計件，組別計時，（有組別）

            Dim dec As New ProductionSumPieceWorkGroupControl
            Dim dcil As New List(Of ProductionSumPieceWorkGroupInfo)

            dcil = dec.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strG_NO, strDep, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDate, Nothing, strDate, Nothing)

            If dcil.Count > 0 Then
                MsgBox(MsgStr & "此組別編號當天已存在於組別計件")
                Check_Delete = False
                Exit Function
            End If

            Dim dec1 As New ProductionSumTimeWorkGroupControl
            Dim dcil1 As New List(Of ProductionSumTimeWorkGroupInfo)

            dcil1 = dec1.ProductionSumTimeWorkGroup_GetList(Nothing, strPer_NO, strG_NO, strDep, Nothing, strDate, Nothing, strDate, Nothing, Nothing)

            If dcil1.Count > 0 Then
                MsgBox(MsgStr & "此員工編號,在本組當天已進行組別計時操作")
                Check_Delete = False
                Exit Function
            End If

        End If
    End Function

    Private Sub popPiecePersonnelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelEdit.Click
        On Error Resume Next
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If


        Dim strDate1, strDep1, strPer_NO1, strG_NO1 As String

        strDate1 = GridView1.GetFocusedRowCellValue("Per_Date").ToString
        strDep1 = GridView1.GetFocusedRowCellValue("DepID").ToString
        strPer_NO1 = GridView1.GetFocusedRowCellValue("Per_NO").ToString
        strG_NO1 = GridView1.GetFocusedRowCellValue("G_NO").ToString

        If Check_Delete(strDate1, strDep1, strPer_NO1, strG_NO1, "不能修改,") = False Then Exit Sub


        Dim fr As ProductionPiecePersonnelDaySub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionPiecePersonnelDaySub Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = GridView1.GetFocusedRowCellValue("Per_Num").ToString
        MTypeName = "PD_edit"

        fr = New ProductionPiecePersonnelDaySub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popPiecePersonnelView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelView.Click
        On Error Resume Next

        Dim fr As ProductionPiecePersonnelDaySub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionPiecePersonnelDaySub Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = GridView1.GetFocusedRowCellValue("Per_Num").ToString
        MTypeName = "PD_view"

        fr = New ProductionPiecePersonnelDaySub
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popPiecePersonnelSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelSeek.Click
        Dim PC As New ProductionPiecePersonnelDayControl

        ProductionPiecePersonnelDayFind.ShowDialog()

        If tempValue = "F" Then
            Grid1.DataSource = PC.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, tempValue2, tempValue3, tempValue6, tempValue5, tempValue4, tempValue7, tempValue8, Nothing, Nothing, tempValue9, Nothing)
        End If

        ProductionPiecePersonnelDayFind.Dispose()

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
        tempValue9 = Nothing



    End Sub

    Private Sub popPiecePersonnelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelPrint.Click
        tempValue = "D"
        rptProductionPiecePersonnel.ShowDialog()
        rptProductionPiecePersonnel.Dispose()

    End Sub
End Class