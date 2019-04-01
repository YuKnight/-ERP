Public Class FrmPieceSumDay
    Dim ds As New DataSet
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FrmPieceSumDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit2.Text = Now
        DateEdit1.Text = Now
        'CreateTable()
    End Sub
    Private Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("PieceSumDay")

            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("D_AddDate", GetType(String))
            .Columns.Add("D_Qty", GetType(Single))
            .Columns.Add("D_Price", GetType(Single))
            .Columns.Add("D_Check", GetType(Boolean))
            .Columns.Add("D_DateSalary", GetType(Single))
            .Columns.Add("D_NorWork", GetType(Single))
            .Columns.Add("D_OverWork", GetType(Single))
            .Columns.Add("D_SumPiece", GetType(Single))
            .Columns.Add("D_SumTime", GetType(Single))
            .Columns.Add("D_Action", GetType(String))

        End With

        With ds.Tables.Add("PiecePersonnel")
            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("Per_Pay", GetType(String))
            .Columns.Add("Per_PayType", GetType(String))
        End With

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            If Len(TextEdit1.Text) = 0 Then
                MsgBox("沒有輸入數據!", , "提示")
                TextEdit1.Focus()
                Exit Sub
            End If
        End If
        If DateEdit1.Text > DateEdit2.Text Then
            MsgBox("開始日期大于結束日期!", , "提示")
            Exit Sub
        End If
        LoadPersonnel()
        LoadSumDay()
        SaveDate()
    End Sub
    Private Sub LoadPersonnel()
        ds.Tables("PiecePersonnel").Clear()

    End Sub
    Private Sub LoadSumDay()
        ds.Tables("PieceSumDay").Clear()
    End Sub
    Private Sub SaveDate()

    End Sub

End Class