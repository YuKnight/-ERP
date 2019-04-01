Imports LFERP.Library.ProductionSumPiecePersonnel
Imports LFERP.SystemManager.SystemUser

Public Class ProductionSumPiecePersonnelMain
    Private Sub ProductionSumPiecePersonnelMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PowerUser()
        popSumPersonnelRef_Click(Nothing, Nothing)
    End Sub
    Sub PowerUser()
        popSumPersonnelAdd.Enabled = False
        popSumPersonnelEdit.Enabled = False
        popSumPersonnelDel.Enabled = False

        popSumPersonnelPrint.Enabled = False
        popSumPersonnelCollectPrint.Enabled = False

        ExpotExcelToolStripMenuItem.Enabled = False

        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160501")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popSumPersonnelAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160502")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popSumPersonnelEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160503")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popSumPersonnelDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160504")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popSumPersonnelPrint.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160505")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popSumPersonnelCollectPrint.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160506")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ExpotExcelToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub popSumPersonnelRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelRef.Click
        ''載入數據
        Dim pcc As New ProductionSumPiecePersonnelControl
        Grid1.DataSource = pcc.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, Format(Now, "yyyy/MM/dd"), Nothing)

    End Sub

    Private Sub popSumPersonnelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelAdd.Click
        MTypeName = "PPAdd"
        ProductionSumPiecePersonnel.ShowDialog()
        ProductionSumPiecePersonnel.Dispose()
    End Sub


    Private Sub popSumPersonnelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        ''-------------------------------------------------------------------------
        Dim pdc As New LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelContol
        Dim pdcl As New List(Of LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelInfo)
        Dim strDate As String
        Dim strPer_NO As String

        strDate = GridView1.GetFocusedRowCellValue("PP_Date").ToString
        strPer_NO = GridView1.GetFocusedRowCellValue("Per_NO").ToString

        pdcl = pdc.ProductionPiecePayPersonnel_GetList(Nothing, strPer_NO, Nothing, Format(CDate(strDate), "yyyy/MM"), Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pdcl.Count > 0 Then   ''有記錄
            MsgBox("不能修改," & "此員工" & Format(CDate(strDate), "yyyy/MM") & "的計件工資已審核!")
            Exit Sub
        End If

        ''---------------------------------------------------------------------------
        Dim DepID As String

        DepID = GridView1.GetFocusedRowCellValue("DepID").ToString

        Dim pcA As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
        Dim plA As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
        plA = pcA.ProductionSumLock_GetList(Nothing, Nothing, DepID, Format(CDate(strDate), "yyyy/MM"))

        If plA.Count > 0 Then
            If plA(0).LockCheck = True Then
                MsgBox("當前部門記錄已鎖定不能修改!")
                Exit Sub
            End If
        End If
        ''---------------------------------------------------------------------------




        MTypeName = "PPEdit" ''修改
        tempValue2 = GridView1.GetFocusedRowCellValue("PP_NO")
        ProductionSumPiecePersonnel.ShowDialog()
        ProductionSumPiecePersonnel.Dispose()
    End Sub

    Private Sub popSumPersonnelView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelView.Click
        If GridView1.RowCount <= 0 Then Exit Sub
        MTypeName = "PPView" ''查看
        tempValue2 = GridView1.GetFocusedRowCellValue("PP_NO").ToString
        ProductionSumPiecePersonnel.ShowDialog()
        ProductionSumPiecePersonnel.Dispose()
    End Sub

    Private Sub popSumPersonnelDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelDel.Click
        ''刪除數據
      

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        ''-------------------------------------------------------------------------
        Dim pdc As New LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelContol
        Dim pdcl As New List(Of LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelInfo)
        Dim strDate As String
        Dim strPer_NO As String

        strDate = GridView1.GetFocusedRowCellValue("PP_Date").ToString
        strPer_NO = GridView1.GetFocusedRowCellValue("Per_NO").ToString

        pdcl = pdc.ProductionPiecePayPersonnel_GetList(Nothing, strPer_NO, Nothing, Format(CDate(strDate), "yyyy/MM"), Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pdcl.Count > 0 Then   ''有記錄
            MsgBox("不能刪除," & "此員工" & Format(CDate(strDate), "yyyy/MM") & "的計件工資已審核!")
            Exit Sub
        End If
        ''---------------------------------------------------------------------------
        Dim DepID As String

        DepID = GridView1.GetFocusedRowCellValue("DepID").ToString

        Dim pcA As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
        Dim plA As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
        plA = pcA.ProductionSumLock_GetList(Nothing, Nothing, DepID, Format(CDate(strDate), "yyyy/MM"))

        If plA.Count > 0 Then
            If plA(0).LockCheck = True Then
                MsgBox("當前部門記錄已鎖定不能刪除!")
                Exit Sub
            End If
        End If
        ''---------------------------------------------------------------------------

        Dim Pc As New ProductionSumPiecePersonnelControl
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("PP_NO")

        If MsgBox("你確定刪除計件單號為:  '" & strA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Pc.ProductionSumPiecePersonnel_Delete(strA) = True Then
                MsgBox("刪除成功")
                'popSumPersonnelRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("刪除失敗")
            End If
        End If
    End Sub

    Private Sub popSumPersonnelSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelSeek.Click
        'Dim mc As New ProductionSumPiecePersonnelControl
        'Dim myfrm As New ProductionSumPieceFind
        'tempValue = "P"
        'myfrm.ShowDialog()

        'If tempValue = "F" Then
        '    Grid1.DataSource = mc.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, tempValue2, Nothing, tempValue9, tempValue8, tempValue3, tempValue4, tempValue5, Nothing, Nothing, tempValue6, Nothing, tempValue7, Nothing)
        'End If

        'ProductionSumPieceFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        'tempValue8 = Nothing
        'tempValue9 = Nothing
        tempValue = "個人計件統計"
        ProductionPieceSelectAll.ShowDialog()

        Dim pcc As New ProductionSumPiecePersonnelControl



        Select Case tempValue
            Case "0" '自定義
                Dim PPS As New LFERP.Library.ProductionPiece_Select.ProductionPiece_SelectControl
                Grid1.DataSource = PPS.ProductionSumPiecePersonnel_GetListSelect("個人計件統計", tempValue2)
            Case "1" '固定模式
                If tempValue3 = "廠証編號" Then
                    Grid1.DataSource = pcc.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, tempValue2, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue4, Nothing, tempValue5, Nothing)

                ElseIf tempValue3 = "產品編號" Then
                    Grid1.DataSource = pcc.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, tempValue4, Nothing, tempValue5, Nothing)
                End If

            Case "2" '廠別 部門

                Grid1.DataSource = pcc.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue4, Nothing, tempValue5, Nothing)

        End Select


        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing


        ProductionPieceSelectAll.Dispose()
    End Sub


    Private Sub popSumPersonnelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelPrint.Click
        'Dim strA As String
        'If GridView1.RowCount > 0 Then
        '    strA = GridView1.GetFocusedRowCellValue("Per_NO")
        '    tempValue2 = strA
        'End If

        'tempValue = "P_PT"  ''員工記件計時表

        'rptProductionSumPieceTime.ShowDialog()
        'rptProductionSumPieceTime.Dispose()
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人計件統計列印"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()

    End Sub

    Private Sub popSumPersonnelCollectPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelCollectPrint.Click
        'Dim strA As String
        'If GridView1.RowCount > 0 Then
        '    strA = GridView1.GetFocusedRowCellValue("Per_NO")
        '    tempValue2 = strA
        'End If

        'tempValue = "P_PTC"  ''員工記件計時表

        'rptProductionSumPieceTime.ShowDialog()
        'rptProductionSumPieceTime.Dispose()  ''popSumWorkGroupCollectPrint

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人計件統計列印匯總"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub


    Private Sub PopSumPersonnelCollectPrintList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopSumPersonnelCollectPrintList.Click
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人計件統計列印匯總清單"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ExpotExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpotExcelToolStripMenuItem.Click
        tempValue = "個人計件"
        frmProductionSumPieceExportExcel.ShowDialog()
        frmProductionSumPieceExportExcel.Dispose()

    End Sub

    Private Sub PerNOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerNOToolStripMenuItem.Click
        tempValue2 = "個人計件"

        Dim fr As New Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionSumPieceLoadExcel Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionSumPieceLoadExcel


        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
End Class