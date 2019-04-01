Public Class frmMessageReminding

    Private Sub frmMessageReminding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim w As Integer, h As Integer
        w = Screen.PrimaryScreen.Bounds.Width
        h = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(w - Me.Width, h - Me.Height - 30)
        Label2.Text = "您有" & tempValue & "條新的消息，請及時查看！"
        tempValue = ""

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub



    Private Sub GroupControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupControl1.MouseUp

        Dim fr As New Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageMain Then
                fr.Activate()
                Me.Close()
                Exit Sub

            End If
        Next
        fr = New frmMessageMain
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

        Me.Close()

    End Sub






    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseUp
        Dim fr As New Form

        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageMain Then
                fr.Activate()
                Me.Close()
                Exit Sub

            End If
        Next

        fr = New frmMessageMain
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

        Me.Close()
    End Sub
End Class