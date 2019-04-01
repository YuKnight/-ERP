Imports LFERP.Library.ProductionKaiLiao

Public Class frmProductionKaiLiaoReturnLoad

    Dim ds As New DataSet
    Private Sub frmProductionKaiLiaoReturnLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCNO.Select()
        CreateTable()

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("KaiLiao")
            .Columns.Add("GOIN", GetType(Boolean))
            .Columns.Add("IndexNo", GetType(String))

            .Columns.Add("C_NO", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))


            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))  '重量
            .Columns.Add("M_Unit", GetType(String))

            .Columns.Add("C_AddDate", GetType(String))
            .Columns.Add("C_Weight", GetType(Double))
        End With

        Grid.DataSource = ds.Tables("KaiLiao")

    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        If txtCNO.Text = "" Then
            txtCNO.Select()
            MsgBox("請輸入開料單號!")
            Exit Sub
        End If

        LoadData(Me.txtCNO.Text)

    End Sub

    Private Function LoadData(ByVal C_NO As String) As Boolean
        LoadData = True

        ds.Tables("KaiLiao").Clear()

        Dim pi As List(Of ProductionKaiLiaoInfo)
        Dim pc As New ProductionKaiLiaoControl

        pi = pc.ProductionKaiLiao_GetList(C_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Try
            If pi.Count = 0 Then
                MsgBox("無數據存在!")
                LoadData = False
                Exit Function
            Else
                '-----------------------------------------------
                If pi(0).C_Check = False Then
                    MsgBox("此開料單未審核!")
                    Exit Function
                End If

                '------------------------------------------
                Dim i As Integer
                Dim row As DataRow
                For i = 0 To pi.Count - 1
                    row = ds.Tables("KaiLiao").NewRow

                    row("GOIN") = False
                    row("IndexNo") = pi(i).IndexNo
                    row("PM_M_Code") = pi(i).PM_M_Code
                    row("C_NO") = pi(i).C_NO
                    row("Pro_Type") = pi(i).Pro_Type
                    row("PM_Type") = pi(i).PM_Type

                    row("M_Gauge") = pi(i).M_Gauge
                    row("M_Code") = pi(i).M_Code
                    row("M_Name") = pi(i).M_Name
                    row("M_Unit") = pi(i).M_Unit
                    row("C_AddDate") = pi(i).C_AddDate

                    row("C_Weight") = pi(i).C_Weight

                    ds.Tables("KaiLiao").Rows.Add(row)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ds.Tables("KaiLiao").Rows.Count <= 0 Then
            MsgBox("無數據存在！")
            Exit Sub
        End If

        Dim strLS As String = ""
        Dim i As Integer

        For i = 0 To ds.Tables("KaiLiao").Rows.Count - 1
            If ds.Tables("KaiLiao").Rows(i)("GOIN") = True Then
                If strLS = "" Then
                    strLS = ds.Tables("KaiLiao").Rows(i)("IndexNo").ToString
                Else
                    strLS = strLS + "," + ds.Tables("KaiLiao").Rows(i)("IndexNo").ToString
                End If
            End If
        Next

        If strLS = "" Then
            MsgBox("沒有選擇任何數據！")
            Exit Sub
        End If

        tempValue = strLS
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        Me.Close()
    End Sub

    Private Sub txtCNO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonLoad_Click(Nothing, Nothing)
        End If
    End Sub
End Class