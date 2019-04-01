Imports LFERP.Library.Purchase.Purchase
Public Class FrmAcceptanceSelect

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If txtPM_NO.Text = "" Then

        Else
            txtPM_NO.Enabled = False
            Dim psc As New PurchaseMainController
          
            DataGridView1.AutoGenerateColumns = False

            If psc.PurchaseMain_Getlist(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing).Count = 0 Then
                MsgBox("當前採購單不存在或未審核,不允許開驗收單!", 60, "提示")
                txtPM_NO.Enabled = True
                txtPM_NO.Text = ""
                txtPM_NO.Select()
                Exit Sub
            End If

            DataGridView1.DataSource = psc.PurchaseMain_Getlist(txtPM_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        End If

    End Sub

    Private Sub FrmAcceptanceSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.RowHeadersWidth = 15

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = ""
        Dim i, n As Integer
        n = 0
        For i = 0 To DataGridView1.RowCount - 1
         
            If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = DataGridView1.Rows(i).Cells("PS_NO").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("PS_NO").Value.ToString
                    n = n + 1
                End If
            End If

        Next
        If tempValue = "" Then
            MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        ' tempValue = DataGridView1.CurrentRow.Cells("PS_NO").Value.ToString
        RefreshT = True



        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()
    End Sub

    Private Sub txtPM_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPM_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
    End Sub
End Class