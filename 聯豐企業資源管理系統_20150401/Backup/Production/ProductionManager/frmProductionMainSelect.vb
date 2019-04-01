Public Class frmProductionMainSelect

    '@ 2012/1/6 添加加載時選中RadioButton1
    '@ 2012/1/6 添加加載時焦點落在TextEdit1控件上
    Private Sub frmProductionMainSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")
        RadioButton1.Checked = True
        TextEdit1.Select()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'If RadioButton1.Checked = False And RadioButton2.Checked = False Then
        '    MsgBox("請選擇查詢方式!")
        '    Exit Sub
        'End If
        If RadioButton1.Checked = True Then
            If TextEdit1.Text = "" Then
                MsgBox("天數不能為空!")
                Exit Sub
            End If
            tempValue = TextEdit1.Text
            tempValue2 = Format(Now, "yyyy/MM/dd")
            tempValue3 = "指定天數"

        ElseIf RadioButton2.Checked = True Then

            If DateEdit1.Text = "" Or DateEdit2.Text = "" Then
                MsgBox("日期不能為空!")
                Exit Sub
            End If
            tempValue = DateEdit1.Text
            tempValue2 = DateEdit2.Text
            tempValue3 = "日期範圍"

        End If

        Me.Close()
    End Sub

    '@ 2012/1/6 添加賦空值
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        Me.Close()
    End Sub

    '@ 2012/1/5修改為用正則表達式判斷輸入的是否為數字
    Private Sub TextEdit1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyUp
        If TextEdit1.Text <> "" Then
            Dim m As New System.Text.RegularExpressions.Regex("^[1-9]+\d*$")
            If m.IsMatch(TextEdit1.Text) Then

            Else

                TextEdit1.Text = Nothing
                Exit Sub
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextEdit1.Enabled = True
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextEdit1.Enabled = False
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            DateEdit1.Focus()
        End If
    End Sub

End Class