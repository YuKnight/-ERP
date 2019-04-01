Imports LFERP.SystemManager
Imports LFERP.Library.ProductionCombination
Imports LFERP.Library.Production.ProductionRatio

Public Class frmProductionCombinationMain

    Dim pc As New ProductionCombinationControl
    Dim prc As New ProductionRatioControl

    Private Sub frmProductionCombinationMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '工序比例
        MenuStripRef_Click(Nothing, Nothing)    '調用刷新過程
        '組合信息
        Grid.DataSource = pc.ProductionCombination_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")), Nothing)

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuStripAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuStripEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuStripDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuStripCheck.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“新增”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripAdd.Click
        Dim frmAdd As New frmProductionCombinationRatio
        frmAdd.lblTittle.Text = "工序組合比例-新增"
        frmAdd.MdiParent = MDIMain
        frmAdd.WindowState = FormWindowState.Maximized
        frmAdd.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“修改”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripEdit.Click
        If GridView2.RowCount <= 0 Then Exit Sub

        Dim pri As List(Of ProductionRatioInfo)
        pri = prc.ProductionRatio_GetList(Nothing, GridView2.GetFocusedRowCellValue("Pro_NO").ToString, Nothing, Nothing)
        If pri.Count > 0 Then
            If pri(0).PR_Check = True Then
                MsgBox("此工序已審核，不允許修改!", 64, "提示")
                Exit Sub
            End If
        End If

        Dim frmModify As New frmProductionCombinationRatio
        frmModify.lblTittle.Text = "工序組合比例-修改"
        frmModify.strPro_NO = GridView2.GetFocusedRowCellValue("Pro_NO").ToString
        frmModify.MdiParent = MDIMain
        frmModify.WindowState = FormWindowState.Maximized
        frmModify.Show()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripDel.Click
        If GridView2.RowCount <= 0 Then Exit Sub

        Dim pri As List(Of ProductionRatioInfo)
        pri = prc.ProductionRatio_GetList(Nothing, GridView2.GetFocusedRowCellValue("Pro_NO").ToString, Nothing, Nothing)
        If pri.Count > 0 Then
            If pri(0).PR_Check = True Then
                MsgBox("此工序已審核，不允許刪除!", 64, "提示")
                Exit Sub
            End If

            If MsgBox("確定要刪除大工序名稱為：" & GridView2.GetFocusedRowCellValue("PS_Name").ToString & " 的工序嗎", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Ok Then
                If prc.ProductionRatio_Delete(Nothing, GridView2.GetFocusedRowCellValue("Pro_NO").ToString) = True Then
                    MsgBox("記錄刪除完成!", 64, "提示")
                    MenuStripRef_Click(Nothing, Nothing)    '調用刷新過程
                End If
            End If

        End If
    End Sub
    ''' <summary>
    ''' 單擊工序比例右鍵菜單“查看”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripPreView.Click
        If GridView2.RowCount <= 0 Then Exit Sub

        Dim frmView As New frmProductionCombinationRatio
        frmView.lblTittle.Text = "工序組合比例-查看"
        frmView.strPro_NO = GridView2.GetFocusedRowCellValue("Pro_NO").ToString
        frmView.MdiParent = MDIMain
        frmView.WindowState = FormWindowState.Maximized
        frmView.Show()

    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刷新”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' frmProductionCombinationMain_Load()
    ''' MenuStripDel_Click()
    Private Sub MenuStripRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripRef.Click
        GridControl1.DataSource = prc.ProductionRatio_GetList(Nothing, Nothing, Nothing, Nothing)
    End Sub
    ''' <summary>
    ''' 單擊工序比例右鍵菜單“查詢”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripQuery.Click
        Dim frmFind1 As New frmProductionCombinationFind1
        frmFind1.ShowDialog()
        If frmFind1.isClickbtnFind = True Then
            GridControl1.DataSource = prc.ProductionRatio_GetList(Nothing, tempValue, tempValue2, Nothing)
            tempValue = ""
            tempValue2 = ""
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“審核”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuStripCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripCheck.Click
        If GridView2.RowCount <= 0 Then Exit Sub

        Dim frmCheck As New frmProductionCombinationRatio
        frmCheck.lblTittle.Text = "工序組合比例-審核"
        frmCheck.strPro_NO = GridView2.GetFocusedRowCellValue("Pro_NO").ToString
        frmCheck.MdiParent = MDIMain
        frmCheck.WindowState = FormWindowState.Maximized
        frmCheck.Show()

        MenuStripRef_Click(Nothing, Nothing)

    End Sub
    ''' <summary>
    ''' 單擊組合信息右鍵菜單“查詢”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsFind.Click
        Dim frmFind2 As New frmProductionCombinationFind2
        frmFind2.ShowDialog()
        If frmFind2.isClickbtnFind = True Then
            Grid.DataSource = pc.ProductionCombination_GetList(tempValue, tempValue2, tempValue3, tempValue4, tempValue5, tempValue6, tempValue7, tempValue8, tempValue9, Nothing)
            tempValue = ""
            tempValue2 = ""
            tempValue3 = ""
            tempValue4 = ""
            tempValue5 = ""
            tempValue6 = ""
            tempValue7 = ""
            tempValue8 = ""
            tempValue9 = ""
        End If
    End Sub
    ''' <summary>
    ''' 單擊組合信息右鍵菜單“查看”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsView.Click
        If GridView1.RowCount <= 0 Then Exit Sub
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("M_ID").ToString
        Dim frm As New frmProductionCombination
        frm.MdiParent = MDIMain
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
End Class