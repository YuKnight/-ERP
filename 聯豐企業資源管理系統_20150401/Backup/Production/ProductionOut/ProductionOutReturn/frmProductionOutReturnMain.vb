Imports LFERP.Library.ProductionOutProcess
Imports LFERP.Library.ProductionOWPAcceptance
Imports LFERP.SystemManager

Public Class frmProductionOutReturnMain
    Dim poc As New ProductionOutProcessControl

    Private Sub frmProductionOutProcessMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmsRef_Click(Nothing, Nothing)      '調用刷新過程

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88150301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88150302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88150303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88150304")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88150305")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedeToolStripMenu.Enabled = True
        End If

    End Sub

    '單擊右鍵菜單“刷新”
    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        Grid1.DataSource = poc.ProductionOutProcess_GetList(Nothing, Nothing, "外發返修", Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")), Nothing)
        Grid1_Click(Nothing, Nothing)
    End Sub

    '單擊右鍵菜單“新增”
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim frmPOPAdd As New frmProductionOutProcess

        frmPOPAdd.lblTittle.Text = "外發返修單--新增"
        frmPOPAdd.strPO_Type = "外發返修"
        frmPOPAdd.MdiParent = MDIMain
        frmPOPAdd.WindowState = FormWindowState.Maximized
        frmPOPAdd.Show()
    End Sub

    '單擊右鍵菜單“修改”
    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim poi As List(Of ProductionOutProcessInfo)
        poi = poc.ProductionOutProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PO_ID"), "外發返修", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If poi(0).PO_Check = True Then      '判斷外發返修單是否已審核
            MsgBox("此外發返修單已審核，不允許修改!", 64, "提示")
            Exit Sub
        End If

        Dim frmPOPModify As New frmProductionOutProcess
        frmPOPModify.lblTittle.Text = "外發返修單--修改"
        frmPOPModify.strPO_Type = "外發返修"
        frmPOPModify.MdiParent = MDIMain
        frmPOPModify.WindowState = FormWindowState.Maximized
        frmPOPModify.txtPO_ID.Text = GridView1.GetFocusedRowCellValue("PO_ID").ToString
        frmPOPModify.Show()
    End Sub

    '單擊右鍵菜單“查看”
    Private Sub cmsPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim frmPOPView As New frmProductionOutProcess
        frmPOPView.lblTittle.Text = "外發返修單--查看"
        frmPOPView.strPO_Type = "外發返修"
        frmPOPView.MdiParent = MDIMain
        frmPOPView.WindowState = FormWindowState.Maximized
        frmPOPView.txtPO_ID.Text = GridView1.GetFocusedRowCellValue("PO_ID").ToString
        frmPOPView.Show()
    End Sub

    '單擊右鍵菜單“審核”
    Private Sub cmsCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim poi As List(Of ProductionOutProcessInfo)
        poi = poc.ProductionOutProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PO_ID"), "外發返修", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If poi(0).PO_Check = True Then      '判斷外發返修單是否已審核
            MsgBox("此外發返修單已審核，不需再審核!", 64, "提示")
            Exit Sub
        End If

        Dim frmPOPCheck As New frmProductionOutProcess
        frmPOPCheck.lblTittle.Text = "外發返修單--審核"
        frmPOPCheck.strPO_Type = "外發返修"
        frmPOPCheck.MdiParent = MDIMain
        frmPOPCheck.WindowState = FormWindowState.Maximized
        frmPOPCheck.txtPO_ID.Text = GridView1.GetFocusedRowCellValue("PO_ID").ToString
        frmPOPCheck.Show()
    End Sub

    '單擊右鍵菜單“刪除”
    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim poi As List(Of ProductionOutProcessInfo)
        poi = poc.ProductionOutProcess_GetList(Nothing, GridView1.GetFocusedRowCellValue("PO_ID"), "外發返修", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If poi.Count > 0 Then       '判斷數據庫中是否存在此申購單號
            If poi(0).PO_Check = False Then      '判斷外發返修單是否已審核
                If MsgBox("確定要刪除外發返修單號為：" & GridView1.GetFocusedRowCellValue("PO_ID") & " 的記錄嗎？", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "提示") = MsgBoxResult.Ok Then
                    If poc.ProductionOutProcess_Delete(Nothing, GridView1.GetFocusedRowCellValue("PO_ID")) = True Then
                        MsgBox("記錄刪除成功!", 64, "提示")
                        cmsRef_Click(Nothing, Nothing)
                    Else
                        MsgBox("記錄刪除失敗!", 64, "提示")
                    End If
                End If
            Else
                MsgBox("此外發返修單已審核，不允許刪除!", 64, "提示")
            End If
        Else
            MsgBox("此記錄數據庫不存在!", 64, "提示")
        End If
    End Sub

    '單擊Grid1,在Grid2中顯示選中外發單的驗收信息
    '此過程被以下過程調用：
    'cmsRef_Click()
    'Grid1_KeyUp()
    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim ac As New ProductionOWPAcceptanceControl
        Grid2.DataSource = ac.ProductionOWPAcceptance_GetList(Nothing, Nothing, GridView1.GetFocusedRowCellValue("PO_ID"), Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("PS_NO"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        Dim acc As New ProductionOutProcessControl
        Grid3.DataSource = acc.ProductionOutRetrocede_GetList(Nothing, GridView1.GetFocusedRowCellValue("AutoID"))

    End Sub

    '按向下或向上方向鍵時，調用單擊Grid1事件過程,在Grid2中顯示選中外發單的驗收信息
    Private Sub Grid1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid1.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            Grid1_Click(Nothing, Nothing)
        End If
    End Sub

    '單擊Grid2中右鍵菜單 “查看”，顯示查看窗體，查看驗收單信息
    Private Sub popViewAcceptance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popViewAcceptance.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As FrmProductionOWPAcceptance

        MTypeName = "OWPView"
        fr = New FrmProductionOWPAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        tempValue2 = GridView2.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        fr.Show()
    End Sub

    '單擊右鍵菜單“查詢”
    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click

        Dim frmPOPFind As New frmProductionOutProcessFind
        frmPOPFind.strPo_Type = "外發返修"
        frmPOPFind.ShowDialog()
        If frmPOPFind.isClickcmdFind = True Then
            Grid1.DataSource = poc.ProductionOutProcess_GetList(Nothing, tempValue, "外發返修", tempValue2, tempValue3, tempValue4, tempValue5, tempValue6, tempValue7, Nothing)
            tempValue = ""
            tempValue2 = ""
            tempValue3 = ""
            tempValue4 = ""
            tempValue5 = ""
            tempValue6 = ""
            tempValue7 = ""
        End If
    End Sub

    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click
        Dim ds As New DataSet

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim suc As New LFERP.SystemManager.SystemUser.SystemUserController
        Dim sui As List(Of LFERP.SystemManager.SystemUser.SystemUserInfo)
        Dim strCompany As String

        sui = suc.SystemUser_GetList(InUserID, Nothing, Nothing)
        strCompany = Mid(sui(0).DPT_ID, 1, 4)

        ds.Tables.Clear()

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("PO_ID").ToString

        ltc.CollToDataSet(ds, "ProductionOutProcess", poc.ProductionOutProcess_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))

        ds.Tables("ProductionOutProcess").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("ProductionOutProcess").Rows.Count - 1
            ds.Tables("ProductionOutProcess").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPT(ds, "rptProductionOutProcess1", "外發加工單", True, True)

        ltc = Nothing
        ltc1 = Nothing

    End Sub

    Private Sub RetrocedeToolStripMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeToolStripMenu.Click
        '判斷外發加工單是否已有驗收記錄
        Dim ac As New ProductionOWPAcceptanceControl
        Dim al As New List(Of ProductionOWPAcceptanceInfo)



        al = ac.ProductionOWPAcceptance_GetList(GridView1.GetFocusedRowCellValue("AutoID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If al.Count = 0 Then
        Else
            MsgBox("此外發單已有驗收記錄,不能更改數量!", 64, "提示")
            Exit Sub
        End If

        tempValue = GridView1.GetFocusedRowCellValue("AutoID")
        tempValue2 = "返修"


        frmProductionOutRetrocede.ShowDialog()
        frmProductionOutRetrocede.Dispose()
    End Sub
End Class