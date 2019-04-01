Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.WareHouse.WareInput
Public Class frmRetrocedeSelect

    Private Sub frmRetrocedeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.RowHeadersWidth = 15
        Label1.Text = tempValue4
        tempValue4 = ""
        Select Case Label1.Text
            Case "調撥作業-中央驗收"
                Label21.Text = "採購/送貨單號(&I)："
                txtPM_NO.Width = 380
                txtPM_NO.Left = 110
            Case Else
                Label21.Text = "驗收單號(&I)："
                txtPM_NO.Width = 405
        End Select

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtPM_NO.Text = "" Then
            MsgBox("請填入正確的單號！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            txtPM_NO.Enabled = False

            If Label1.Text = "調撥作業" Then

                Dim psc As New AcceptanceController

                If psc.Acceptance_GetList(Nothing, txtPM_NO.Text, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count = 0 Then
                    MsgBox("此驗收單號不存在或未完成驗收審核!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = psc.Acceptance_GetList(Nothing, txtPM_NO.Text, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            ElseIf Label1.Text = "退貨作業" Then

                Dim psc As New AcceptanceController

                If psc.Acceptance_GetList(Nothing, txtPM_NO.Text, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count = 0 Then
                    MsgBox("此驗收單號不存在或未完成驗收審核!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If

                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = psc.Acceptance_GetList(Nothing, txtPM_NO.Text, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            ElseIf Label1.Text = "調撥作業-中央驗收" Then

                Dim wic As New WareInputContraller
                If wic.WareInput_GetWareID(txtPM_NO.Text).Count = 0 Then
                    MsgBox(" 此單號不存在!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    txtPM_NO.Enabled = True
                    txtPM_NO.Text = ""
                    Exit Sub
                End If
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = wic.WareInput_GetWareID(txtPM_NO.Text)

            End If

        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'tempValue = DataGridView1.CurrentRow.Cells("A_NO").Value.ToString
        'RefreshT = True
        'Me.Close()
        Select Case Label1.Text
            Case "退貨作業"
                tempValue = ""
                Dim i, n As Integer
                n = 0
                For i = 0 To DataGridView1.RowCount - 1

                    If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                        If n = 0 Then
                            tempValue = DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                            n = n + 1
                        End If
                    End If

                Next
                If tempValue = "" Then
                    MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If
                RefreshT = True
            Case "調撥作業"
                tempValue = ""
                Dim i, n As Integer
                n = 0
                For i = 0 To DataGridView1.RowCount - 1

                    If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                        If n = 0 Then
                            tempValue = DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                            n = n + 1
                        End If
                    End If

                Next
                If tempValue = "" Then
                    MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If
                RefreshT = True
            Case "調撥作業-中央驗收"
                tempValue = ""
                Dim i, n As Integer
                n = 0
                For i = 0 To DataGridView1.RowCount - 1

                    If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                        If n = 0 Then
                            tempValue = DataGridView1.Rows(i).Cells("WIP_NUM").Value.ToString
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("WIP_NUM").Value.ToString
                            n = n + 1
                        End If
                    End If

                Next
                If tempValue = "" Then
                    MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If

                RefreshT = True
            Case "QC抽檢"
                tempValue = ""
                Dim i, n As Integer
                n = 0
                For i = 0 To DataGridView1.RowCount - 1
                    If DataGridView1.Rows(i).Cells("WQC_Status").Value = "需Q" Then
                        If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                            If n = 0 Then
                                tempValue = DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("A_NO").Value.ToString
                                n = n + 1
                            End If
                        End If
                    Else
                        MsgBox("不需Q的物料不允許載入！", , "提示")
                    End If
                Next
                If tempValue = "" Then
                    MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If
                RefreshT = True
        End Select
        'tempValue = ""
        'Dim i, n As Integer
        'n = 0
        'For i = 0 To DataGridView1.RowCount - 1

        '    If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
        '        If n = 0 Then
        '            tempValue = DataGridView1.Rows(i).Cells("A_NO").Value.ToString
        '            n = n + 1
        '        Else
        '            tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("A_NO").Value.ToString
        '            n = n + 1
        '        End If
        '    End If

        'Next
        'If tempValue = "" Then
        '    MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'RefreshT = True



        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtPM_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPM_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            SimpleButton1_Click(Nothing, Nothing)
        End If

    End Sub

End Class