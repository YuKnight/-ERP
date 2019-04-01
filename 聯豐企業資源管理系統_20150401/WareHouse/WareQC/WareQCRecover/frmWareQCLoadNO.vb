Imports LFERP.Library.WareHouse.WareQCSend

Public Class frmWareQCLoadNO

    Private Sub frmWareQCLoadNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.RowHeadersWidth = 15
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtPM_NO.Text = "" Or Len(txtPM_NO.Text) <> 11 Then
            MsgBox("請填入正確的抽檢發出單號！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            txtPM_NO.Enabled = False
            Dim wqc As New WareQCSendController

            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = wqc.WareQCSend_GetList(txtPM_NO.Text, Nothing, Nothing, Nothing, True, Nothing, Nothing)

        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = ""
        Dim i, n As Integer
        n = 0
        For i = 0 To DataGridView1.RowCount - 1

            If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = DataGridView1.Rows(i).Cells("AutoID").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("AutoID").Value.ToString
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

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtPM_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPM_NO.EditValueChanged

    End Sub

    Private Sub txtPM_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPM_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
    End Sub
End Class