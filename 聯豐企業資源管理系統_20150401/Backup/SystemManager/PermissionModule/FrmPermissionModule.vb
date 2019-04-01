Imports LFERP.SystemManager
Public Class FrmPermissionModule

  
    Private Sub FrmPermissionModule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim mt As New PermissionController

        TreeList1.DataSource = mt.PermissionModule_GetList(Nothing, Nothing, Nothing)

    End Sub



   
    Private Sub popAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAdd.Click
        Dim mt As New PermissionController
        Edit = False
        Dim MyFrm As New FrmPermissionModule_Add
        MyFrm.ShowDialog()

        If tempValue = "RE" Then
            TreeList1.DataSource = mt.PermissionModule_GetList(Nothing, Nothing, Nothing)
            tempValue = ""
        End If
    End Sub

    Private Sub PopEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopEdit.Click
        Dim mt As New PermissionController
        Edit = True
        'tempValue = TreeList1.FocusedNode.Item("PM_ID")
        FrmPermissionModule_Add.TextEdit1.Text = TreeList1.FocusedNode.Item("PM_ID").ToString
        FrmPermissionModule_Add.TextEdit2.Text = TreeList1.FocusedNode.Item("PM_Name").ToString
        FrmPermissionModule_Add.TextEdit3.Text = TreeList1.FocusedNode.Item("PM_PID").ToString
        FrmPermissionModule_Add.TextEdit4.Text = TreeList1.FocusedNode.Item("PM_Level").ToString
        FrmPermissionModule_Add.TextEdit5.Text = TreeList1.FocusedNode.Item("PM_Sub").ToString
        FrmPermissionModule_Add.TextEdit6.Text = TreeList1.FocusedNode.Item("PM_Image").ToString
        FrmPermissionModule_Add.TextEdit7.Text = TreeList1.FocusedNode.Item("PM_SelectImage").ToString
        FrmPermissionModule_Add.ShowDialog()

        If tempValue = "RE" Then
            TreeList1.DataSource = mt.PermissionModule_GetList(Nothing, Nothing, Nothing)
            tempValue = ""
        End If

    End Sub

    Private Sub popDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popDel.Click
        If MsgBox("確定要刪除項目ID為： '" & TreeList1.FocusedNode.Item("PM_ID").ToString & "' 的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim ms As New PermissionInfo
            Dim mt As New PermissionController
            ms.PM_ID = TreeList1.FocusedNode.Item("PM_ID").ToString
            If mt.PermissionModule_Delete(ms) = True Then
                MsgBox("已刪除!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                TreeList1.DataSource = mt.PermissionModule_GetList(Nothing, Nothing, Nothing)
            Else
                MsgBox("刪除失敗!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            End If
        End If

    End Sub
End Class