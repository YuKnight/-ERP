
Imports LFERP.Library.ProductionBalance


Public Class frmProductionBalanceMain

    Dim pbc As New ProductionBalanceControl

    Private Sub frmProductionBalanceMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.DataSource = pbc.ProductionBalance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        PowerUser()
    End Sub

    Sub PowerUser()

    End Sub

    Private Sub MenuStripAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionBalance
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionBalance Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "部門變更單"
        fr = New frmProductionBalance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub MenuStripEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionBalanceInfo)
        pi = pbc.ProductionBalance_GetList(GridView1.GetFocusedRowCellValue("B_ID").ToString, Nothing, Nothing, Nothing, Nothing)
        If pi(0).B_Check = True Then
            MsgBox("此單已審核,不允許修改!")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionBalance
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionBalance Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "部門變更單"
            tempValue3 = GridView1.GetFocusedRowCellValue("B_ID").ToString
            fr = New frmProductionBalance
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub MenuStripDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionBalanceInfo)
        pi = pbc.ProductionBalance_GetList(GridView1.GetFocusedRowCellValue("B_ID").ToString, Nothing, Nothing, Nothing, Nothing)
        If pi(0).B_Check = True Then
            MsgBox("此單已審核,不允許刪除!")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("B_ID").ToString & "的開料單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pbc.ProductionBalance_Delete(GridView1.GetFocusedRowCellValue("B_ID").ToString, Nothing) = True Then
                    MsgBox("刪除當前部門數據變更單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pbc.ProductionBalance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub MenuStripPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripPreView.Click
        On Error Resume Next

        Dim fr As frmProductionBalance
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionBalance Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "Preview"
        tempValue3 = GridView1.GetFocusedRowCellValue("B_ID").ToString
        fr = New frmProductionBalance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub MenuStripRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripRef.Click
        Grid.DataSource = pbc.ProductionBalance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub MenuStripQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripQuery.Click

    End Sub

    Private Sub MenuStripCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionBalanceInfo)
        pi = pbc.ProductionBalance_GetList(GridView1.GetFocusedRowCellValue("B_ID").ToString, Nothing, Nothing, Nothing, Nothing)
        If pi(0).B_Check = True Then
            MsgBox("此單已審核,不允許再次操作!")
            Exit Sub
        Else
            Dim fr As frmProductionBalance
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionBalance Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "Check"
            tempValue3 = GridView1.GetFocusedRowCellValue("B_ID").ToString
            fr = New frmProductionBalance
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub MenuStripPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStripPrint.Click

    End Sub
End Class