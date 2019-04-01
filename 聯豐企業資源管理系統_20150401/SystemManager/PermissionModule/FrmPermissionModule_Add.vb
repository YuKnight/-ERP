Imports LFERP.SystemManager
Public Class FrmPermissionModule_Add
    Dim Sqlstr As String


    Private Sub FrmPermissionModule_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Edit
            Case False


            Case True

                TextEdit1.Enabled = False


        End Select
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Select Case Edit
            Case False
                SaveDataNew()

            Case True
                SaveDataEdit()

        End Select
        Me.Close()
    End Sub


    Sub SaveDataNew()
        Dim ms As New PermissionInfo
        Dim mt As New PermissionController
        ms.PM_ID = TextEdit1.Text
        ms.PM_Name = TextEdit2.Text
        ms.PM_PID = TextEdit3.Text
        ms.PM_Level = TextEdit4.Text
        ms.PM_Sub = TextEdit5.Text
        ms.PM_Image = TextEdit6.Text
        ms.PM_SelectImage = TextEdit7.Text
        If mt.PermissionModule_Add(ms) = True Then
            MsgBox("記錄已保存", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            tempValue = "RE"
        Else
            MsgBox("失敗,請檢查數據", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If
     
    End Sub

    Sub SaveDataEdit()
        Dim ms As New PermissionInfo
        Dim mt As New PermissionController
        ms.PM_ID = TextEdit1.Text
        ms.PM_Name = TextEdit2.Text
        ms.PM_PID = TextEdit3.Text
        ms.PM_Level = TextEdit4.Text
        ms.PM_Sub = TextEdit5.Text
        ms.PM_Image = TextEdit6.Text
        ms.PM_SelectImage = TextEdit7.Text
        If mt.PermissionModule_Update(ms) = True Then
            MsgBox("記錄已保存", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            tempValue = "RE"
        Else
            MsgBox("失敗,請檢查數據", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If
 
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class