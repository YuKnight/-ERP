Imports LFERP.DataSetting

Public Class frmCurrency
    Dim cc As New CurrencyControler

    Private Sub frmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshStripMenuItem_Click(Nothing, Nothing)
    End Sub


    Private Sub RefreshStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshStripMenuItem.Click
        Grid1.DataSource = cc.ExChangeRate_GetList(Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub YearAddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearAddToolStripMenuItem.Click
        tempValue = "YearAdd"
        Dim fr As New frmCurrencyAdd
        fr.ShowDialog()
        fr.Dispose()

    End Sub

    Private Sub MonthAddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthAddToolStripMenuItem.Click
        tempValue = "MonthAdd"
        Dim fr As New frmCurrencyAdd
        fr.ShowDialog()
        fr.Dispose()
    End Sub

    Private Sub ModifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifToolStripMenuItem.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        tempValue = "Edit"
        tempValue2 = GridView1.GetFocusedRowCellValue("AutoID").ToString   '通過唯一的ID來導出相應的年月，幣別以及匯率信息
        Dim fr As New frmCurrencyAdd
        fr.ShowDialog()
        fr.Dispose()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then Exit Sub

        If MsgBox("確定要刪除名稱為： '" & GridView1.GetFocusedRowCellValue("StrYM").ToString & "' 的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If cc.ExChangeRate_Delete(GridView1.GetFocusedRowCellValue("AutoID").ToString) = True Then
                MsgBox("刪除當前選定行匯率信息成功！", 60, "提示")
                Grid1.DataSource = cc.ExChangeRate_GetList(Nothing, Nothing, Nothing, Nothing)
            Else
                MsgBox("刪除當前選定行匯率失敗，請檢查原因！", 60, "提示")
                Exit Sub

            End If
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        frmCurrFind.ShowDialog()
        If tempValue2 <> Nothing Then
            Grid1.DataSource = cc.ExChangeRate_GetList(Nothing, tempValue2, tempValue3, Nothing)
        End If
        frmCurrFind.Dispose()

    End Sub
End Class