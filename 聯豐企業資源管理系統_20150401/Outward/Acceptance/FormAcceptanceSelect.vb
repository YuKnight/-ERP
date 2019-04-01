
Imports LFERP.Library.Outward
Public Class FormAcceptanceSelect

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        If txtPM_NO.Text = "" Then

        Else
            txtPM_NO.Enabled = False
            Dim psc As New OutwardController
            Dim psi As New List(Of OutwardInfo)
            psi = psc.OutwardMain_GetList(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If psi(0).O_Check = True Then
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = psc.OutwardMain_GetList(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next
        tempValue = ""
        If txtPM_NO.Text = "" Then
            tempValue5 = ""
        Else
            tempValue5 = txtPM_NO.Text
        End If
        Dim i, n As Integer
        n = 0

        For i = 0 To DataGridView1.RowCount - 1

            If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = DataGridView1.Rows(i).Cells("O_NOsub").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("O_NOsub").Value.ToString
                    n = n + 1
                End If
            End If

        Next
        If tempValue = "" Then
            MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        RefreshT = True
        Me.Close()

    End Sub

    Private Sub FormAcceptanceSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.RowHeadersWidth = 15
    End Sub
End Class