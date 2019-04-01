Imports LFERP.Library.OutWards
Imports LFERP.SystemManager

Public Class frmOutWardsMain

    Dim owc As New OutWardsController
    Dim isLFUser As Boolean

    ''' <summary>
    ''' 單擊右鍵菜單“新增”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim fr As New frmOutWards
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刷新”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用
    ''' frmOutWardsMain_Load()
    ''' cmsDel_Click()
    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        GridControl1.DataSource = owc.OutWards_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), Nothing)
    End Sub
    ''' <summary>
    ''' 窗體加載
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmOutWardsMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsAdd.Enabled = True
                cmsOutWardsAdd.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsEdit.Enabled = True
                cmsOutWardsEdit.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsDel.Enabled = True
                cmsOutWardsDelete.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsCheck.Enabled = True
                cmsOutWardsCheck.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800207")  '@ 2013/3/26 添加
        If pmwiL.Count > 0 Then    '聯豐或磨刀部用
            If pmwiL.Item(0).PMWS_Value = "是" Then
                GridControl1.ContextMenuStrip = cmsTrip
                cmsRef_Click(Nothing, Nothing)        '調用刷新過程
                isLFUser = True
            Else '米亞用
                GridControl1.ContextMenuStrip = cmsMG
                OM_CusterID.FieldName = "OC_CustomerID"
                OM_CusterNO.FieldName = "OC_CustomerNO"
                OM_CusterPO.FieldName = "OC_CustomerPO"
                cmsOutWardsRef_Click(Nothing, Nothing)        '調用刷新過程
                isLFUser = False
            End If
        Else
            GridControl1.ContextMenuStrip = cmsMG
            OM_CusterID.FieldName = "OC_CustomerID"
            OM_CusterNO.FieldName = "OC_CustomerNO"
            OM_CusterPO.FieldName = "OC_CustomerPO"
            cmsOutWardsRef_Click(Nothing, Nothing)        '調用刷新過程
            isLFUser = False
        End If

    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“修改”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim owi As List(Of OutWardsInfo)

        owi = owc.OutWards_GetList(GridView1.GetFocusedRowCellValue("OW_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi.Count > 0 Then
            If owi(0).OW_Check = False Then
                Dim fr As New frmOutWards
                fr.lblTittle.Text = "送貨--修改"
                fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("此送貨單已審核，不允許修改！", 64, "提示")
            End If
        Else
            MsgBox("數據庫中不存在此送貨單號，請檢查是否已被刪除！", 64, "提示")
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“查看”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsPreView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOutWards
        fr.lblTittle.Text = "送貨--查看"
        fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“審核”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOutWards
        fr.lblTittle.Text = "送貨--審核"
        fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim owi As List(Of OutWardsInfo)

        owi = owc.OutWards_GetList(GridView1.GetFocusedRowCellValue("OW_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi.Count > 0 Then
            If owi(0).OW_Check = False Then
                If MsgBox("確定要刪除送貨單號為：" & GridView1.GetFocusedRowCellValue("OW_NO").ToString & "  的所有記錄嗎？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Ok Then
                    If owc.OutWards_Delete(Nothing, GridView1.GetFocusedRowCellValue("OW_NO").ToString) = True Then
                        MsgBox("記錄刪除成功！", 64, "提示")
                        cmsRef_Click(Nothing, Nothing)             '調用刷新過程
                    Else
                        MsgBox("記錄刪除失敗！", 64, "提示")
                    End If
                End If
            Else
                MsgBox("此送貨單已審核，不允許刪除！", 64, "提示")
            End If
        Else
            MsgBox("數據庫中不存在此送貨單號，請檢查是否已被刪除！", 64, "提示")
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“查詢”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click
        Dim fr As New frmOutWardsFind

        fr.ShowDialog()

        If fr.isClickbtnOK = True Then        '只有單擊查詢窗體中的查詢按鈕才進行查詢
            GridControl1.DataSource = owc.OutWards_GetList(tempValue, tempValue2, tempValue3, tempValue4, tempValue5, Nothing, Nothing, tempValue6, Nothing, tempValue7, tempValue8, tempValue9)
        End If

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

    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click, cmsDaoJuPrint.Click, cmsOutWardsPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strNO As String
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim owi As List(Of OutWardsInfo)
        Dim strReportName As String

        strNO = GridView1.GetFocusedRowCellValue("OW_NO").ToString

        ds.Tables.Clear()
        If isLFUser = True Then   '聯豐用
            owi = owc.OutWards_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            strReportName = "rptOutWards"
        Else
            owi = owc.OutWards_GetList1(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            strReportName = "rptOutWards2"
        End If

        If owi.Count = 0 Then Exit Sub

        ltc.CollToDataSet(ds, "OutWards", owi)

        If owi(0).OW_Check = True Then
            If sender.name = "cmsPrint" Or sender.name = "cmsOutWardsPrint" Then
                PreviewRPT(ds, strReportName, "送貨單", True, True)
            ElseIf sender.name = "cmsDaoJuPrint" Then
                PreviewRPT1(ds, "rptOutWards1", "送貨單", UserName, "", True, True)
            End If
        Else
            If sender.name = "cmsPrint" Or sender.name = "cmsOutWardsPrint" Then
                PreviewRPT(ds, strReportName, "送貨單", False, False)
            ElseIf sender.name = "cmsDaoJuPrint" Then
                PreviewRPT1(ds, "rptOutWards1", "送貨單", UserName, "", False, False)
            End If

        End If

        ltc = Nothing
    End Sub

    Private Sub cmsOutWardsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsAdd.Click
        Dim fr As New frmOutWardsT
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsOutWardsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim owi As List(Of OutWardsInfo)

        owi = owc.OutWards_GetList(GridView1.GetFocusedRowCellValue("OW_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi.Count > 0 Then
            If owi(0).OW_Check = False Then
                Dim fr As New frmOutWardsT
                fr.lblTittle.Text = "送貨--修改"
                fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("此送貨單已審核，不允許修改！", 64, "提示")
            End If
        Else
            MsgBox("數據庫中不存在此送貨單號，請檢查是否已被刪除！", 64, "提示")
        End If
    End Sub

    Private Sub cmsOutWardsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsDelete.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim owi As List(Of OutWardsInfo)

        owi = owc.OutWards_GetList(GridView1.GetFocusedRowCellValue("OW_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi.Count > 0 Then
            If owi(0).OW_Check = False Then
                If MsgBox("確定要刪除送貨單號為：" & GridView1.GetFocusedRowCellValue("OW_NO").ToString & "  的所有記錄嗎？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Ok Then
                    If owc.OutWards_Delete(Nothing, GridView1.GetFocusedRowCellValue("OW_NO").ToString) = True Then
                        MsgBox("記錄刪除成功！", 64, "提示")
                        cmsOutWardsRef_Click(Nothing, Nothing)             '調用刷新過程
                    Else
                        MsgBox("記錄刪除失敗！", 64, "提示")
                    End If
                End If
            Else
                MsgBox("此送貨單已審核，不允許刪除！", 64, "提示")
            End If
        Else
            MsgBox("數據庫中不存在此送貨單號，請檢查是否已被刪除！", 64, "提示")
        End If
    End Sub

    Private Sub cmsOutWardsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOutWardsT
        fr.lblTittle.Text = "送貨--審核"
        fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsOutWardsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsView.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOutWardsT
        fr.lblTittle.Text = "送貨--查看"
        fr.txtOW_NO.Text = GridView1.GetFocusedRowCellValue("OW_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsOutWardsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsFind.Click
        Dim fr As New frmOutWardsFind
        tempValue10 = "MG"
        fr.ShowDialog()

        If fr.isClickbtnOK = True Then        '只有單擊查詢窗體中的查詢按鈕才進行查詢
            GridControl1.DataSource = owc.OutWards_GetList1(tempValue, tempValue2, tempValue3, tempValue4, tempValue5, Nothing, Nothing, tempValue6, Nothing, tempValue7, Nothing, tempValue8, tempValue9)
        End If

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

    Private Sub cmsOutWardsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutWardsRef.Click
        GridControl1.DataSource = owc.OutWards_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), Nothing)
    End Sub


    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim FiledNameStr As String
        FiledNameStr = "OW_NO,OS_BatchID,OM_ID,OM_CusterID,OM_CusterNO,OM_CusterPO,PM_M_Code,M_Name,M_Gauge,M_Unit,PM_Type,OW_Qty,OS_Sprace,OW_Sprace,OW_Date,OW_Check"
        GridViewCopyMulitRow(GridView1, FiledNameStr, "ALL")
    End Sub


    Private Sub ToolStripSonHuoColl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSonHuoColl.Click
        frmOutWardsColl.ShowDialog()
        frmOutWardsColl.Dispose()
    End Sub

    Private Sub ToolStripPOColl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripPOColl.Click
        FrmOrderCollect.ShowDialog()
        FrmOrderCollect.Dispose()
    End Sub
End Class