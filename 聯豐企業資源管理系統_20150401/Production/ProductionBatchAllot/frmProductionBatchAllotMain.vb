' =============================================
' Author:		<wwq>
' Create date: <2013/4/23>
' Description:	<派工單管理>
' =============================================

Imports LFERP.Library.ProductionBatchAllot
Imports LFERP.SystemManager

Public Class frmProductionBatchAllotMain
    Dim pac As New ProductionBatchAllotControl
    Dim ds As New DataSet

    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim fr As New frmProductionBatchAllot
        fr.lblTittle.Text = "生產派工單-新增"
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        Dim ltc As New CollectionToDataSet
        Dim pai As New List(Of ProductionBatchAllotInfo)

        ds.Tables.Clear()
        pai = pac.ProductionBatchAllot_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -15, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, Nothing)
        ltc.CollToDataSet(ds, "ProductionBatchAllot", pai)
        GridControl1.DataSource = pai
        ltc = Nothing
    End Sub

    Private Sub frmProductionBatchAllotMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8801101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsAdd.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8801102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsEdit.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8801103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsDel.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8801104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsCheck.Enabled = True
            End If
        End If

        cmsRef_Click(Nothing, Nothing)

    End Sub

    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        Dim strPBA_ID As String
        Dim fr As New frmProductionBatchAllot

        If GridView1.RowCount <= 0 Then Exit Sub

        strPBA_ID = GridView1.GetFocusedRowCellValue("PBA_ID").ToString

        If pac.ProductionBatchAllot_GetList(strPBA_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True").Count > 0 Then
            MsgBox("該派工單已存在審核記錄，不能再修改！", 64, "提示")
            Exit Sub
        End If

        fr.lblTittle.Text = "生產派工單-修改"
        fr.txtPBA_ID.Text = strPBA_ID
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        Dim strPBA_ID As String
        Dim fr As New frmProductionBatchAllot

        If GridView1.RowCount <= 0 Then Exit Sub

        strPBA_ID = GridView1.GetFocusedRowCellValue("PBA_ID").ToString

        If pac.ProductionBatchAllot_GetList(strPBA_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True").Count > 0 Then
            MsgBox("該派工單已存在審核記錄，不能刪除！", 64, "提示")
            Exit Sub
        End If

        If MsgBox("確定要刪除派工單號為：" & strPBA_ID & " 的記錄嗎？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Cancel Then Exit Sub

        If pac.ProductionBatchAllot_Delete(Nothing, strPBA_ID) = True Then
            MsgBox("派工單：" & strPBA_ID & " 刪除成功！", 64, "提示")
            cmsRef_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCheck.Click
        Dim strPBA_ID As String
        Dim fr As New frmProductionBatchAllot

        If GridView1.RowCount <= 0 Then Exit Sub

        strPBA_ID = GridView1.GetFocusedRowCellValue("PBA_ID").ToString

        'If pac.ProductionBatchAllot_GetList(strPBA_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True").Count > 0 Then
        '    MsgBox("該派工單已存在審核記錄，不能再修改！", 64, "提示")
        '    Exit Sub
        'End If

        fr.lblTittle.Text = "生產派工單-審核"
        fr.txtPBA_ID.Text = strPBA_ID
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        Dim strPBA_ID As String
        Dim fr As New frmProductionBatchAllot

        If GridView1.RowCount <= 0 Then Exit Sub

        strPBA_ID = GridView1.GetFocusedRowCellValue("PBA_ID").ToString

        fr.lblTittle.Text = "生產派工單-查看"
        fr.txtPBA_ID.Text = strPBA_ID
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click
        Dim fr As New frmProductionBatchAllotFind
        Dim ltc As New CollectionToDataSet
        Dim pai As New List(Of ProductionBatchAllotInfo)

        fr.ShowDialog()
        If fr.isClickbtnFind = True Then
            ds.Tables.Clear()
            pai = pac.ProductionBatchAllot_GetList(tempValue, tempValue2, tempValue5, tempValue3, tempValue4, tempValue7, tempValue8, tempValue6)
            ltc.CollToDataSet(ds, "ProductionBatchAllot", pai)
            GridControl1.DataSource = pai
            ltc = Nothing
        End If

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    Private Sub cmsPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc1 As New CollectionToDataSet
        Dim mcCompany As New LFERP.DataSetting.CompanyControler

        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strInCompany, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptProductionBatchAllot", "派工單", True, True)
        ltc1 = Nothing
    End Sub
End Class