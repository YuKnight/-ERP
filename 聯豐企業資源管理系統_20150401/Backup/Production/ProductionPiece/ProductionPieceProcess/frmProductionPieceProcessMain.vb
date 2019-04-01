Imports LFERP.Library.ProductionPieceProcess
Imports LFERP.SystemManager

Public Class frmProductionPieceProcessMain
    Dim ppc As New ProductionPieceProcessControl

    Private Sub frmProductionPieceProcessMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdRef_Click(Nothing, Nothing)

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdPrint.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160106")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PP_PriceInputToolStripMenuItem.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PP_PriceCheckToolStripMenuItem.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刷新”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' frmProductionPieceProcessMain_Load()
    ''' cmdDel_Click()
    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        'Grid.DataSource = ppc.ProductionPieceProcess_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -31, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")), Nothing)
        Grid.DataSource = ppc.ProductionPieceProcess_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“新增”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        frmProductionPieceProcess.MdiParent = MDIMain
        frmProductionPieceProcess.WindowState = FormWindowState.Maximized
        frmProductionPieceProcess.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“修改”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim ppi As List(Of ProductionPieceProcessInfo)
        ppi = ppc.ProductionPieceProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PP_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If ppi(0).PP_Check = True Then      '判斷計件工藝單是否已審核
            MsgBox("此計件工藝單已審核，不允許修改!", 64, "提示")
            Exit Sub
        End If

        Dim frmPPPModify As New frmProductionPieceProcess
        frmPPPModify.lblTittle.Text = "計件工藝單--修改"
        frmPPPModify.MdiParent = MDIMain
        frmPPPModify.WindowState = FormWindowState.Maximized
        frmPPPModify.txtPP_ID.Text = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        frmPPPModify.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“審核”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim frmPPPCheck As New frmProductionPieceProcess
        frmPPPCheck.lblTittle.Text = "計件工藝單--審核"
        frmPPPCheck.MdiParent = MDIMain
        frmPPPCheck.WindowState = FormWindowState.Maximized
        frmPPPCheck.txtPP_ID.Text = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        frmPPPCheck.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“查看”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim frmPPPView As New frmProductionPieceProcess
        frmPPPView.lblTittle.Text = "計件工藝單--查看"
        frmPPPView.MdiParent = MDIMain
        frmPPPView.WindowState = FormWindowState.Maximized
        frmPPPView.txtPP_ID.Text = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        frmPPPView.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim ppi As List(Of ProductionPieceProcessInfo)
        ppi = ppc.ProductionPieceProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PP_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If ppi.Count > 0 Then       '判斷數據庫中是否存在此計件工藝單號
            If ppi(0).PP_Check = False Then      '判斷計件工藝單是否已審核
                If MsgBox("確定要刪除計件工藝單號為：" & GridView1.GetFocusedRowCellValue("PP_ID") & " 的記錄嗎？", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "提示") = MsgBoxResult.Ok Then
                    If ppc.ProductionPieceProcess_Delete(Nothing, GridView1.GetFocusedRowCellValue("PP_ID")) = True Then
                        MsgBox("記錄刪除成功!", 64, "提示")
                        cmdRef_Click(Nothing, Nothing)
                    Else
                        MsgBox("記錄刪除失敗!", 64, "提示")
                    End If
                End If

            Else
                MsgBox("此計件工藝單已審核，不允許刪除!", 64, "提示")
            End If
        Else
            MsgBox("此記錄數據庫不存在!", 64, "提示")
        End If

    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“查詢”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        'Dim frmPPPFind As New frmProductionPieceProcessFind

        'frmPPPFind.ShowDialog()
        'If frmPPPFind.isClickbtnFind = True Then
        '    Grid.DataSource = ppc.ProductionPieceProcess_GetList1(tempValue, tempValue2, tempValue3, tempValue4, Nothing, Nothing, Nothing, tempValue5, tempValue6, Nothing)
        '    tempValue = ""
        '    tempValue2 = ""
        '    tempValue3 = ""
        '    tempValue4 = ""
        '    tempValue5 = ""
        '    tempValue6 = ""
        '    tempValue7 = ""
        'End If
        tempValue = "計件工藝"
        ProductionPieceSelectAll.ShowDialog()

        Dim frmPPPFind As New frmProductionPieceProcessFind

        Select Case tempValue
            Case "0" '自定義
                Dim PPS As New LFERP.Library.ProductionPiece_Select.ProductionPiece_SelectControl

                Grid.DataSource = PPS.ProductionPieceProcess_GetListSelect("計件工藝", tempValue2)

            Case "1" '固定模式
                If tempValue3 = "工藝單號" Then
                    Grid.DataSource = ppc.ProductionPieceProcess_GetList1(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue6, tempValue4, tempValue5, strInDepID)
                ElseIf tempValue3 = "產品編號" Then
                    Grid.DataSource = ppc.ProductionPieceProcess_GetList1(Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, tempValue6, tempValue4, tempValue5, strInDepID)
                End If
            Case "2" '廠別 部門
                Grid.DataSource = ppc.ProductionPieceProcess_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue4, tempValue5, tempValue2)

        End Select

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        ProductionPieceSelectAll.Dispose()

    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“列印(工價)”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        On Error Resume Next

        Dim ds As New DataSet

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim strCompany As String

        strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

        ds.Tables.Clear()

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        If ppc.ProductionPieceProcess_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing).Count <= 0 Then
            MsgBox("你所在部門在此計件工藝單中無記錄!", 64, "提示")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "ProductionPieceProcess", ppc.ProductionPieceProcess_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))

        ds.Tables("ProductionPieceProcess").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("ProductionPieceProcess").Rows.Count - 1
            ds.Tables("ProductionPieceProcess").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPT(ds, "rptProductionPieceProcess", "計件工藝單", True, True)

        ltc = Nothing
        ltc1 = Nothing
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“列印”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdPrintNoPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintNoPrice.Click
        Dim ds As New DataSet

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim strCompany As String

        strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

        ds.Tables.Clear()

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("PP_ID").ToString

        ltc.CollToDataSet(ds, "ProductionPieceProcess", ppc.ProductionPieceProcess_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))

        ds.Tables("ProductionPieceProcess").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("ProductionPieceProcess").Rows.Count - 1
            ds.Tables("ProductionPieceProcess").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPT(ds, "rptProductionPieceProcess1", "計件工藝單", True, True)

        ltc = Nothing
        ltc1 = Nothing
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP_PriceInputToolStripMenuItem.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        'Dim ppi As List(Of ProductionPieceProcessInfo)
        'ppi = ppc.ProductionPieceProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PP_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'If ppi(0).PP_PriceCheck = True Then      '判斷計件工藝單是否已審核
        '    MsgBox("此計件工藝單價已審核，不允許錄入!", 64, "提示")
        '    Exit Sub
        'End If

        Dim frmPPPModify As New frmProductionPieceProcess
        frmPPPModify.lblTittle.Text = "計件工藝單--單價錄入"
        frmPPPModify.MdiParent = MDIMain
        frmPPPModify.WindowState = FormWindowState.Maximized
        frmPPPModify.txtPP_ID.Text = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        frmPPPModify.Show()
    End Sub

    Private Sub PP_PriceCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP_PriceCheckToolStripMenuItem.Click
        If GridView1.RowCount <= 0 Then Exit Sub


        'Dim ppi As List(Of ProductionPieceProcessInfo)
        'ppi = ppc.ProductionPieceProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PP_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'If ppi(0).PP_Check = True Then      '判斷計件工藝單是否已審核
        'Else
        '    MsgBox("此計件工藝單未審核,不能對單價審核!", 64, "提示")
        '    Exit Sub
        'End If


        Dim frmPPPCheck As New frmProductionPieceProcess
        frmPPPCheck.lblTittle.Text = "計件工藝單--單價審核"
        frmPPPCheck.MdiParent = MDIMain
        frmPPPCheck.WindowState = FormWindowState.Maximized
        frmPPPCheck.txtPP_ID.Text = GridView1.GetFocusedRowCellValue("PP_ID").ToString
        frmPPPCheck.Show()
    End Sub

    Private Sub ToolStripNOCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNOCheck.Click
       
        tempValue = "列印未審核工價"

        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub
End Class