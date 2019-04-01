Imports LFERP.Library.Outward.OutwardAcceptance
Public Class FormRetrocedeSelect
    Dim oac As New OutwardAcceptanceControl
    Dim oai As New List(Of OutwardAcceptanceInfo)
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtPM_NO.Text = "" Then Exit Sub
        oai = oac.OutwardAcceptance_GetList(Trim(txtPM_NO.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If oai.Count = 0 Then
            Exit Sub
        Else
            If oai(0).A_Check = True Then
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = oac.OutwardAcceptance_GetList(Trim(txtPM_NO.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Else
                MsgBox("此驗收單還未審核！此時不能退貨")
                Exit Sub
            End If
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = ""
        Dim n As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                End If
            End If
        Next
        If tempValue = "" Then
            MsgBox("請加入物料！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FormRetrocedeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class