Imports LFERP.SystemManager.SystemUser
Public Class FrmUserChange
    Public uu As New SystemUserController
    Public us As New SystemUserInfo
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub FrmUserChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = tempValue
        tempValue = ""

        txtuserid.EditValue = InUserID
        loadedit(txtuserid.EditValue)
        Select Case Label1.Text
            Case "更改密碼"
                txtusername.Enabled = False
            Case "更改名稱"
                txtuserpsw.Enabled = False
        End Select

    End Sub
    Function loadedit(ByVal uid As String) As Boolean
        us = uu.SystemUser_Get(uid)
        If us Is Nothing Then
            loadedit = False
            Exit Function
        End If
        txtusername.EditValue = us.U_Name
        txtuserpsw.EditValue = us.U_PassWord

        loadedit = True
    End Function


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        us.U_ID = txtuserid.EditValue
        us.U_Name = txtusername.EditValue
        us.U_PassWord = txtuserpsw.EditValue

        Select Case Label1.Text
            Case "更改密碼"

                If uu.SystemUser_UpdatePsw(us) = True Then
                    MsgBox("修改成功")

                End If
            Case "更改名稱"
                If uu.SystemUser_UpdateName(us) = True Then
                    MsgBox("修改成功")
                End If

        End Select


        Me.Close()
    End Sub
End Class
