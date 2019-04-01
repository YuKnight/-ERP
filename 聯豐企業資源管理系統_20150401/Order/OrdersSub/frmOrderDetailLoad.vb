Imports LFERP.Library.Orders

Public Class frmOrderDetailLoad

    Private Sub frmOrderDetailLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = tempValue4
        Label2.Text = tempValue5
        tempValue4 = ""
        tempValue5 = ""
        Dim ode As New OrdersDetailController
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ode.OrdersDetail_GetElectorPlate(Label1.Text, Nothing, Label2.Text)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = ""
        'Dim i, n As Integer
        'n = 0
        'For i = 0 To DataGridView1.RowCount - 1

        '    If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
        '        If n = 0 Then
        '            tempValue = DataGridView1.Rows(i).Cells("OD_ID").Value.ToString

        '            n = n + 1
        '        Else
        '            tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("OD_ID").Value.ToString
        '            n = n + 1
        '        End If
        '    End If

        'Next
        tempValue = DataGridView1.CurrentRow.Cells("OS_BatchID").Value.ToString

        If tempValue = "" Then
            MsgBox("請選擇需要導入的資料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        RefreshT = True

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        Dim ode As New OrdersDetailController
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ode.OrdersDetail_GetElectorPlate(Nothing, BatchID.Text, Label2.Text)
    End Sub

   
End Class