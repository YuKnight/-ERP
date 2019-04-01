Imports LFERP.Library.Orders


Public Class frmWareOutBatchID

    Private Sub frmWareOutBatchID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = ""
        TextEdit1.Focus()
    End Sub

    Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Check()
        End If
    End Sub
    Sub Check()
        Dim oi As List(Of OrdersBomInfo)
        Dim oc As New OrdersBomController
        oi = oc.OrdersBom_GetList(Nothing, TextEdit1.Text, Nothing, Nothing)
        If oi.Count = 0 Then
            MsgBox("不存在此批次，請重新輸入！")
            TextEdit1.Focus()
            TextEdit1.Text = Nothing
        Else
            tempValue2 = TextEdit1.Text
            Me.Close()
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Check()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class