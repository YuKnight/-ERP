Imports LFERP.Library.ProductionException

Public Class frmException

    Dim ec As New ProductionExceptionControl

    Private Sub frmException_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelControl1.Visible = True
        PanelControl2.Visible = False
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim ei As New ProductionExceptionInfo

        ei.PE_CardID = TextEdit1.Text
        ei.PE_CardName = TextEdit2.Text
        ei.PE_Date = Now
        ei.PE_User = InUserID
        ei.PE_Remark = MemoEdit1.Text
        If TextEdit1.Text.Trim = "" Or TextEdit2.Text.Trim = "" Then
            MsgBox("工號，姓名不能為空！")
            Exit Sub
        End If
        If ec.ProductionException_Add(ei) = True Then
            tempValue = ei.PE_CardID & "-" & ei.PE_CardName
        End If

        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub


    Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit1.KeyPress

        If e.KeyChar = Chr(13) Then

            TextEdit2.Text = GetName(TextEdit1.Text)
            TextEdit2.Enabled = False
            MemoEdit1.Focus()

        End If

    End Sub

    '權限用戶登陸
    Private Sub SimpleButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim ei As List(Of ProductionExceptionInfo)

        ei = ec.ProductionExceptionUser_GetList(TextEdit3.Text, TextEdit4.Text)

        If ei.Count > 0 Then
            PanelControl1.Visible = False
            PanelControl2.Visible = True

            TextEdit1.Focus()
        Else
            PanelControl1.Visible = True
            PanelControl2.Visible = False
            MsgBox("當前用戶不存在此權限或密碼錯誤，請重新輸入！")
            TextEdit4.Text = ""
            TextEdit4.Focus()

            Exit Sub
        End If
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub MemoEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MemoEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextEdit3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit3.KeyPress
        If e.KeyChar = Chr(13) Then

            Label6.Text = GetName(TextEdit3.Text)
            Label6.Visible = True
            TextEdit4.Focus()
        End If
    End Sub


    Private Sub TextEdit4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit4.KeyPress
        If e.KeyChar = Chr(13) Then

            SimpleButton3_Click(Nothing, Nothing)

        End If
    End Sub

End Class