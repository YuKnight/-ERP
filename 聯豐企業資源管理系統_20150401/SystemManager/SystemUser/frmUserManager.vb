Imports LFERP.SystemManager


Public Class frmUserManager
    Dim mcs As New PermissionModule
    Dim uls As New SystemUser.SystemUserController

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Edit = False

        frmUseradd.CheckEdit1.Checked = False
        frmUseradd.Height = 460
       
        frmUseradd.ShowDialog()

        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub frmUserManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click

        If GridView1.RowCount = 0 Then
            frmUseradd.CheckEdit1.Checked = False
            frmUseradd.Height = 460
        Else
            frmUseradd.CheckEdit1.Checked = True
            frmUseradd.Height = 332
        End If

        Edit = True
        tempValue = GridView2.GetFocusedRowCellValue("U_ID").ToString

        frmUseradd.ShowDialog()
        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        If MsgBox("確認刪除工號為'" & GridView2.GetFocusedRowCellValue("U_ID").ToString & "'的用戶？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If uls.SystemUser_Delete(GridView2.GetFocusedRowCellValue("U_ID").ToString) = True Then
                uls.UserPower_Del(GridView2.GetFocusedRowCellValue("U_ID").ToString, Nothing)
                MsgBox("刪除成功")
            Else
                MsgBox("刪除失敗")
            End If
            Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
        End If

    End Sub

   
    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        GridControl1.DataSource = uls.UserPower_GetList(GridView2.GetFocusedRowCellValue("U_ID").ToString, Nothing, Nothing, Nothing)
    End Sub

    Private Sub SelectMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectMenuItem.Click
        Dim fr As New frmUserSelect
        fr.ShowDialog()
        Grid1.DataSource = uls.SystemUser_GetList(tempValue, Nothing, Nothing)
        tempValue = ""
    End Sub

    Private Sub ReflashMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReflashMenuItem.Click
        Grid1.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
        GridControl1.DataSource = uls.UserPower_GetList(GridView2.GetFocusedRowCellValue("U_ID").ToString, Nothing, Nothing, Nothing)
    End Sub
End Class