Imports LFERP.Library.Orders
Public Class frmOrdersSubNeedMain
    Dim onc As New OrdersSubNeedController

    Private Sub frmOrdersSubNeedMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmsRef_Click(Nothing, Nothing)
    End Sub

    Private Sub cmsExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsExport.Click
        If GridView1.RowCount = 0 Then Exit Sub
        'ExportGridToXls()

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridView1.BestFitColumns()

            GridControl1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        Dim oni As List(Of OrdersSubNeedInfo)
        oni = onc.OrdersSubNeed_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridControl1.DataSource = oni
    End Sub

    Private Sub cmsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsView.Click
        Dim fr As New frmOrdersSubNeed

        fr.txtON_ID.Text = GridView1.GetFocusedRowCellValue(ON_ID)

        fr.lblTittle.Text = "批次需求單-查看"
        fr.ShowDialog()
    End Sub

    Private Sub cmsSalesDptCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsSalesDptCheck.Click
        Dim fr As New frmOrdersSubNeed
        Dim oni As List(Of OrdersSubNeedInfo)

        oni = onc.OrdersSubNeed_GetList(Nothing, GridView1.GetFocusedRowCellValue(ON_ID), Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        If oni.Count > 0 Then
            MsgBox("此需求單已審核，不需再審核!", 64, "提示")
            Exit Sub
        End If

        fr.txtON_ID.Text = GridView1.GetFocusedRowCellValue(ON_ID)

        fr.lblTittle.Text = "批次需求單-營業部審核"
        fr.ShowDialog()
    End Sub

    Private Sub cmsOperationDptCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOperationDptCheck.Click
        Dim fr As New frmOrdersSubNeed

        fr.txtON_ID.Text = GridView1.GetFocusedRowCellValue(ON_ID)

        fr.lblTittle.Text = "批次需求單-營運部審核"
        fr.ShowDialog()
    End Sub

    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        Try
            Dim oni As List(Of OrdersSubNeedInfo)
            oni = onc.OrdersSubNeed_GetList(Nothing, GridView1.GetFocusedRowCellValue(ON_ID), Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, "True", Nothing)
            If oni.Count > 0 Then
                MsgBox("此需求單已存在審核記錄，不能再刪除!", 64, "提示")
                Exit Sub
            End If

            If MsgBox("確定要刪除需求單號為：" & GridView1.GetFocusedRowCellValue(ON_ID) & " 的記錄嗎？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Ok Then
                If onc.OrdersSubNeed_Delete(GridView1.GetFocusedRowCellValue(ON_ID), Nothing) = True Then
                    MsgBox("需求單號為：" & GridView1.GetFocusedRowCellValue(ON_ID) & " 的記錄已成功刪除", 64, "提示")
                    cmsRef_Click(Nothing, Nothing)
                Else
                    MsgBox("刪除失敗!", 64, "提示")
                End If
            End If
        Catch ex As Exception
            MsgBox("刪除失敗!" & vbCrLf & ex.Message, 64, "提示")
        End Try
    End Sub

    Private Sub cmsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsFind.Click
        Dim fr As New frmOrdersSubNeedFind

        fr.ShowDialog()
        If fr.isClickcmdFind = True Then
            GridControl1.DataSource = onc.OrdersSubNeed_GetList(Nothing, tempValue, tempValue2, tempValue3, tempValue4, "W0301", tempValue5, tempValue6, tempValue9, tempValue10, tempValue7, tempValue8)
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
        tempValue10 = Nothing

    End Sub

    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strON_ID As String
        strON_ID = GridView1.GetFocusedRowCellValue("ON_ID").ToString

        Dim ds As New DataSet
        ds.Tables.Clear()

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim oni As List(Of OrdersSubNeedInfo)

        oni = onc.OrdersSubNeed_GetList(Nothing, strON_ID, Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If oni.Count = 0 Then Exit Sub

        ltc.CollToDataSet(ds, "OrdersSubNeed", oni)
        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strInCompany, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptOrdersSubNeed", "批次需求單", True, True)

        ltc = Nothing
        ltc1 = Nothing
    End Sub
End Class