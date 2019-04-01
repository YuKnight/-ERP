Imports LFERP.Library.Orders
Imports LFERP.Library.OutWards
Imports LFERP.SystemManager

Public Class frmOrderCustomerMain
    Dim occ As New OrderCustomerController
    Dim owc As New OutWardsController

    Private Sub frmOrderCustomerMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "3001101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "3001102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsModify.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "3001103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsDelete.Enabled = True
        End If

        cmsRefresh_Click(Nothing, Nothing)
    End Sub

    '刷新
    Private Sub cmsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRefresh.Click
        GridControl1.DataSource = occ.OrderCustomer_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, Nothing, Nothing)
    End Sub

    '新增
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim fr As New frmOrderCustomer

        fr.lblTittle.Text = "客戶訂單資料-新增"
        'fr.MdiParent = MDIMain
        fr.ShowDialog()
    End Sub

    '修改
    Private Sub cmsModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsModify.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOrderCustomer
        fr.strAutoID = GridView1.GetFocusedRowCellValue(AutoID)
        fr.lblTittle.Text = "客戶訂單資料-修改"
        'fr.MdiParent = MDIMain
        fr.ShowDialog()
    End Sub

    '查看
    Private Sub cmsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsView.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim fr As New frmOrderCustomer

        Dim owi As List(Of OutWardsInfo)
        owi = owc.OutWards_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("AutoID").ToString, Nothing, Nothing)
        If owi.Count > 0 Then
            MsgBox("此訂單已存在出貨記錄，不允許再修改！", 64, "提示")
            Exit Sub
        End If

        fr.strAutoID = GridView1.GetFocusedRowCellValue(AutoID)
        fr.lblTittle.Text = "客戶訂單資料-查看"
        'fr.MdiParent = MDIMain
        fr.ShowDialog()
    End Sub

    '刪除
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim owi As List(Of OutWardsInfo)
        owi = owc.OutWards_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("AutoID").ToString, Nothing, Nothing)
        If owi.Count <= 0 Then
            If MsgBox("確定要刪除選中的記錄嗎？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提示") = MsgBoxResult.Ok Then
                If occ.OrderCustomer_Delete(GridView1.GetFocusedRowCellValue("AutoID").ToString) = True Then
                    MsgBox("記錄刪除成功！", 64, "提示")
                    cmsRefresh_Click(Nothing, Nothing)             '調用刷新過程
                Else
                    MsgBox("記錄刪除失敗！", 64, "提示")
                End If
            End If
        Else
            MsgBox("此訂單已存在出貨記錄，不允許刪除！", 64, "提示")
        End If
    End Sub

    '查詢
    Private Sub cmsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsFind.Click
        Dim fr As New frmOrderCustomerFind
        fr.ShowDialog()

        If fr.isClickbtnFind = True Then
            GridControl1.DataSource = occ.OrderCustomer_GetList(Nothing, tempValue, tempValue2, tempValue3, tempValue6, tempValue4, tempValue5, tempValue7, tempValue8, Nothing, Nothing, Nothing)
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

End Class