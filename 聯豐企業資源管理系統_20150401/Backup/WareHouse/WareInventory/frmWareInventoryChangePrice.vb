Imports LFERP.Library.Material

Public Class frmWareInventoryChangePrice

    Dim ds As New DataSet

    Private Sub frmWareInventoryChangePrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateMaterialCode()
        txtName.Select()
    End Sub

    Sub CreateMaterialCode()
        ds.Tables.Clear()
        With ds.Tables.Add("MaterialPrice")

            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_Price", GetType(String))
            .Columns.Add("M_Currency", GetType(String))

        End With
        Grid.DataSource = ds.Tables("MaterialPrice")
    End Sub

    Sub LoadMaterialCodeData()

        Dim mi As List(Of MaterialInfo)
        Dim mc As New MaterialController
        Dim strCode, strName, strGauge As String

        If CheckEdit4.Checked = True Then
            If Len(txtCode.Text.Trim) = 0 Then
                MsgBox("沒有輸入物料編碼,請輸入!", , "提示")
                Exit Sub
            Else
                strCode = txtCode.Text
            End If
        Else
            strCode = Nothing
        End If
        If CheckEdit6.Checked = True Then
            If Len(txtName.Text.Trim) = 0 Then
                MsgBox("沒有輸入物料名稱,請輸入!", , "提示")
                Exit Sub
            Else
                strName = txtName.Text
            End If
        Else
            strName = Nothing
        End If
        If CheckEdit2.Checked = True Then
            If Len(txtGauge.Text.Trim) = 0 Then
                MsgBox("沒有輸入物料規格,請輸入!", , "提示")
                Exit Sub
            Else
                strGauge = txtGauge.Text
            End If
        Else
            strGauge = Nothing
        End If

        mi = mc.MaterialPrice_GetList(strCode, strName, strGauge)

        If mi.Count = 0 Then

            MsgBox("無當前查詢條件信息記錄!請重新輸入")
            txtName.Text = Nothing
            txtCode.Text = Nothing
            txtGauge.Text = Nothing

            txtName.Focus()

            Exit Sub

        End If
        ds.Tables("MaterialPrice").Clear()

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To mi.Count - 1
            row = ds.Tables("MaterialPrice").NewRow

            row("M_Code") = mi(i).M_Code
            row("M_Name") = mi(i).M_Name
            row("M_Gauge") = mi(i).M_Gauge
            row("M_Unit") = mi(i).M_Unit
            row("M_Price") = mi(i).M_Price
            row("M_Currency") = mi(i).M_Currency

            ds.Tables("MaterialPrice").Rows.Add(row)
        Next

    End Sub
    Private Sub cmdSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeek.Click
        LoadMaterialCodeData()
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSeek_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtGauge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGauge.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSeek_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSeek_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        Dim mi As New MaterialInfo
        Dim mc As New MaterialController

        For i = 0 To ds.Tables("MaterialPrice").Rows.Count - 1

            If CSng(ds.Tables("MaterialPrice").Rows(i)("M_Price")) < 0 Then
                MsgBox("請確認物料單價不能為負數！")
                Exit Sub
            End If

        Next

        If MsgBox("確定需要變更列表框中的物料單價嗎？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            For i = 0 To ds.Tables("MaterialPrice").Rows.Count - 1

                mi.M_Code = ds.Tables("MaterialPrice").Rows(i)("M_Code")

                mi.M_Price = ds.Tables("MaterialPrice").Rows(i)("M_Price")
                mi.M_Currency = ds.Tables("MaterialPrice").Rows(i)("M_Currency")

                mc.MaterialPrice_Update(mi)
            Next
        Else
            Exit Sub
        End If
        MsgBox("修改單價信息完成!")
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub CheckEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit4.CheckedChanged, CheckEdit2.CheckedChanged, CheckEdit6.CheckedChanged
        Select Case sender.name
            Case "CheckEdit4"
                If CheckEdit4.Checked = True Then
                    txtCode.Focus()
                    txtCode.SelectAll()
                End If
            Case "CheckEdit6"
                If CheckEdit6.Checked = True Then
                    txtName.Focus()
                    txtName.SelectAll()
                End If
            Case "CheckEdit2"
                If CheckEdit2.Checked = True Then
                    txtGauge.Focus()
                    txtGauge.SelectAll()
                End If
        End Select
    End Sub
End Class