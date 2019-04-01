Imports LFERP.Library.ProductionApply
Imports LFERP.SystemManager

Public Class frmProductionApplyMain
    Dim pac As New ProductionApplyControl

    Private Sub frmProductionApplyMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmdRef_Click(Nothing, Nothing)

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881404")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If
    
    End Sub

    '單擊右鍵菜單“刷新”
    '此過程被以下過程調用
    'frmProductionApplyMain_Load()
    'cmdDel_Click()
    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Grid.DataSource = pac.ProductionApply_GetList1()
    End Sub

    '單擊右鍵菜單“新增”
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmProductionApply.MdiParent = MDIMain
        frmProductionApply.WindowState = FormWindowState.Maximized
        frmProductionApply.Show()
    End Sub

    '單擊右鍵菜單“修改”
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pai As List(Of ProductionApplyInfo)
        pai = pac.ProductionApply_GetList(GridView1.GetFocusedRowCellValue("PA_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pai(0).PA_Check = True Then      '判斷申購單是否已審核
            MsgBox("此申購單已審核，不允許修改", 64, "提示")
            Exit Sub
        End If

        Dim frmPAModify As New frmProductionApply
        frmPAModify.lblTitle.Text = "申購單--修改"
        frmPAModify.MdiParent = MDIMain
        frmPAModify.WindowState = FormWindowState.Maximized
        frmPAModify.txtPA_ID.Text = GridView1.GetFocusedRowCellValue("PA_ID").ToString
        frmPAModify.Show()
    End Sub

    '單擊右鍵菜單“刪除”
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pai As List(Of ProductionApplyInfo)
        pai = pac.ProductionApply_GetList(GridView1.GetFocusedRowCellValue("PA_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pai.Count > 0 Then       '判斷數據庫中是否存在此申購單號
            If pai(0).PA_Check = False Then      '判斷申購單是否已審核
                If MsgBox("確定要刪除申購單號為：" & GridView1.GetFocusedRowCellValue("PA_ID") & " 的記錄嗎？", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "提示") = MsgBoxResult.Ok Then
                    If pac.ProductionApply_Delete(Nothing, GridView1.GetFocusedRowCellValue("PA_ID")) = True Then
                        MsgBox("記錄刪除成功!", 64, "提示")
                        cmdRef_Click(Nothing, Nothing)
                    Else
                        MsgBox("記錄刪除失敗!", 64, "提示")
                    End If
                End If
            Else
                MsgBox("此申購單已審核，不允許刪除!", 64, "提示")
            End If
        Else
            MsgBox("此記錄數據庫不存在!", 64, "提示")
        End If

    End Sub

    '單擊右鍵菜單“查看”
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        If GridView1.RowCount = 0 Then Exit Sub
      
        Dim frmPAView As New frmProductionApply
        frmPAView.lblTitle.Text = "申購單--查看"
        frmPAView.MdiParent = MDIMain
        frmPAView.WindowState = FormWindowState.Maximized
        frmPAView.txtPA_ID.Text = GridView1.GetFocusedRowCellValue("PA_ID").ToString
        frmPAView.Show()
    End Sub

    '單擊右鍵菜單“審核”
    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pai As List(Of ProductionApplyInfo)
        pai = pac.ProductionApply_GetList(GridView1.GetFocusedRowCellValue("PA_ID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pai(0).PA_Check = True Then      '判斷申購單是否已審核
            MsgBox("此申購單已審核，不需再審核!", 64, "提示")
            Exit Sub
        End If

        Dim frmPACheck As New frmProductionApply
        frmPACheck.lblTitle.Text = "申購單--審核"
        frmPACheck.MdiParent = MDIMain
        frmPACheck.WindowState = FormWindowState.Maximized
        frmPACheck.txtPA_ID.Text = GridView1.GetFocusedRowCellValue("PA_ID").ToString
        frmPACheck.Show()
    End Sub

    '單擊右鍵菜單“查詢”
    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim frm As New frmProductionApplyFind
        frm.ShowDialog()
        If frm.isClickcmdOK = True Then     '只有單擊查詢按鈕，並且輸入無誤的情況下，才執行查詢
            Grid.DataSource = pac.ProductionApply_GetList(tempValue, tempValue2, tempValue3, tempValue4, tempValue5, tempValue6, tempValue7, tempValue8)
        End If
        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strNO As String
        strNO = GridView1.GetFocusedRowCellValue("PA_ID").ToString

        Dim ds As New DataSet
        ds.Tables.Clear()

        Dim ltc As New CollectionToDataSet

        Dim pai As List(Of ProductionApplyInfo)

        pai = pac.ProductionApply_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pai.Count = 0 Then Exit Sub

        ltc.CollToDataSet(ds, "ProductionApply", pac.ProductionApply_GetList(strNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        If pai(0).PA_Check = True Then
            PreviewRPT(ds, "rptProductionApply", "申購單", True, True)
        Else
            PreviewRPT(ds, "rptProductionApply", "申購單", True, False)

        End If

        ltc = Nothing
    End Sub
End Class