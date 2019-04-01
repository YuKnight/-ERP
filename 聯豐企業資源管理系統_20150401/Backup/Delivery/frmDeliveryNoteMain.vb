Imports LFERP.Library.Delivery
Imports LFERP.SystemManager

Public Class frmDeliveryNoteMain


    Private Sub frmDeliveryNoteMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dc As New DeliveryControl
        Grid.DataSource = dc.DeliveryNote_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        LoadPowerUser()

    End Sub
    '讀取用戶此模塊權限
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then DeliveryAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then DeliveryEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then DeliveryDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then DeliveryCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800205")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then DeliveryAccCheck.Enabled = True
        End If
    End Sub

    '新增送貨單
    Private Sub DeliveryAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmDeliveryNote
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmDeliveryNote Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "送貨單"
        fr = New frmDeliveryNote
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub DeliveryEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim di As List(Of DeliveryInfo)
        Dim dc As New DeliveryControl
        di = dc.DeliveryNote_GetList(GridView1.GetFocusedRowCellValue("DN_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If di.Count = 0 Then Exit Sub
        If di(0).DN_Check = True Then
            MsgBox("此送貨單已被審核，不允許修改！")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmDeliveryNote
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmDeliveryNote Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "送貨單"
            tempValue2 = GridView1.GetFocusedRowCellValue("DN_ID").ToString
            fr = New frmDeliveryNote
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub DeliveryDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim di As List(Of DeliveryInfo)
        Dim dc As New DeliveryControl
        di = dc.DeliveryNote_GetList(GridView1.GetFocusedRowCellValue("DN_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If di.Count = 0 Then
            Exit Sub
        Else
            If di(0).DN_Check = True Then
                MsgBox("此送貨單已被審核過，不允許刪除！")
                Exit Sub
            Else
                If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("DN_ID").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If dc.DeliveryNote_Delete(GridView1.GetFocusedRowCellValue("DN_ID").ToString) = True Then
                        Dim di1 As List(Of DeliveryInfo)
                        di1 = dc.DeliveryPacking_GetList(GridView1.GetFocusedRowCellValue("DN_ID"), Nothing, Nothing, Nothing, Nothing)
                        If di1.Count = 0 Then
                            Exit Sub
                        Else
                            Dim i As Integer
                            For i = 0 To di1.Count - 1
                                dc.DeliveryPacking_Delete(Nothing, di1(i).DNS_NO, Nothing)
                                dc.DeliveryPackingSub_Delete(di1(i).DNS_NO, Nothing)
                            Next
                        End If
                    End If
                    MsgBox("刪除成功！", , "提示")
                    Grid.DataSource = dc.DeliveryNote_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Else
                    MsgBox("刪除操作失敗，請聯繫系統管理員！")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub DeliveryView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmDeliveryNote
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmDeliveryNote Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "PreView"
        tempValue2 = GridView1.GetFocusedRowCellValue("DN_ID").ToString
        fr = New frmDeliveryNote
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub DeliverySelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliverySelect.Click

    End Sub

    Private Sub DeliveryCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim di As List(Of DeliveryInfo)
        Dim dc As New DeliveryControl
        di = dc.DeliveryNote_GetList(GridView1.GetFocusedRowCellValue("DN_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If di.Count = 0 Then Exit Sub
        If di(0).DN_AccCheck = True Then
            MsgBox("此送貨單已被復核，不允許再審核！")
            Exit Sub
        Else
            Dim fr As frmDeliveryNote
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmDeliveryNote Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "Check"
            tempValue2 = GridView1.GetFocusedRowCellValue("DN_ID").ToString
            fr = New frmDeliveryNote
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub DeliveryAccCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryAccCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim di As List(Of DeliveryInfo)
        Dim dc As New DeliveryControl
        di = dc.DeliveryNote_GetList(GridView1.GetFocusedRowCellValue("DN_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If di.Count = 0 Then Exit Sub
        If di(0).DN_Check = False Then
            MsgBox("此送貨單還未被審核，此時不允許復核！")
            Exit Sub
        Else
            Dim fr As frmDeliveryNote
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmDeliveryNote Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "AccCheck"
            tempValue2 = GridView1.GetFocusedRowCellValue("DN_ID").ToString
            fr = New frmDeliveryNote
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub DeliveryRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryRef.Click
        Dim dc As New DeliveryControl
        Grid.DataSource = dc.DeliveryNote_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
End Class