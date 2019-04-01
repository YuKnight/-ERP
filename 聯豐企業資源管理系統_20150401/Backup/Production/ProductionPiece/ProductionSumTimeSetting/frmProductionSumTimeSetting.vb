Imports LFERP.Library.ProductionSumTimeSetting

Public Class frmProductionSumTimeSetting
    Dim ds As New DataSet

    Private Sub ProductionSumTimeSettingMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabActionName.Text = ""
        LabModifyDate.Text = ""
        CreateTable()


        LoadData()


    End Sub

    Sub LoadData()
        Dim PCC As New ProductionSumTimeSettingControl
        Dim Pil As New List(Of ProductionSumTimeSettingInfo)

        Pil = PCC.ProductionSumTimeSetting_GetList(Nothing, Nothing, Nothing)

        If Pil.Count > 0 Then
        Else
            Exit Sub
        End If

        Dim i As Integer


        For i = 0 To Pil.Count - 1

            Dim row As DataRow
            row = ds.Tables("ProSumTimeSetting").NewRow

            row("AutoID") = Pil(i).AutoID
            row("StartTime") = Pil(i).StartTime
            row("EndTime") = Pil(i).EndTime
            row("TotalTime") = Pil(i).TotalTime

            LabActionName.Text = Pil(i).ActionName
            LabModifyDate.Text = Pil(i).ModifyDate

            ds.Tables("ProSumTimeSetting").Rows.Add(row)
        Next

    End Sub


    Function CheckData() As Boolean
        CheckData = True

        If ds.Tables("ProSumTimeSetting").Rows.Count <= 0 Then
            MsgBox("無數據保存,請加入數據!")
            CheckData = False
            Exit Function
        End If

        Dim i As Integer

        For i = 0 To ds.Tables("ProSumTimeSetting").Rows.Count - 1
            If ds.Tables("ProSumTimeSetting").Rows(i)("StartTime") Is DBNull.Value Then
                MsgBox("開始時間不能為空!")
                CheckData = False
                Exit Function
            ElseIf Len(ds.Tables("ProSumTimeSetting").Rows(i)("StartTime")) <> 5 Then
                MsgBox("開始時間長度不正確!")
                CheckData = False
                Exit Function
            End If

            If ds.Tables("ProSumTimeSetting").Rows(i)("EndTime") Is DBNull.Value Then
                MsgBox("結束時間不能為空!")
                CheckData = False
                Exit Function
            ElseIf Len(ds.Tables("ProSumTimeSetting").Rows(i)("EndTime")) <> 5 Then
                MsgBox("結束時間知長度不正確!")
                CheckData = False
                Exit Function
            End If

            If ds.Tables("ProSumTimeSetting").Rows(i)("TotalTime") Is DBNull.Value Then

                MsgBox("合計時長不能為空!")
                CheckData = False
                Exit Function
            End If
        Next

        Dim j As Integer
        For j = 0 To ds.Tables("ProSumTimeSetting").Rows.Count - 1
            If ds.Tables("ProSumTimeSetting").Rows(j)("AutoID") Is DBNull.Value = True Then
                Dim PCC As New ProductionSumTimeSettingControl
                Dim Pil As New List(Of ProductionSumTimeSettingInfo)

                Pil = PCC.ProductionSumTimeSetting_GetList(Nothing, ds.Tables("ProSumTimeSetting").Rows(j)("StartTime"), ds.Tables("ProSumTimeSetting").Rows(j)("EndTime"))

                If Pil.Count > 0 Then
                    MsgBox("已存在相同時間段記錄!")
                    CheckData = False
                    Exit Function
                End If

            End If
        Next




    End Function



    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("ProSumTimeSetting")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("StartTime", GetType(String))
            .Columns.Add("EndTime", GetType(String))
            .Columns.Add("TotalTime", GetType(Double))
        End With


        With ds.Tables.Add("ProDelSetting")
            .Columns.Add("AutoID", GetType(String))
        End With

        Me.Grid1.DataSource = ds.Tables("ProSumTimeSetting")

    End Sub


    Sub SaveData()
        '更新刪除的記錄
        Dim poc As New ProductionSumTimeSettingControl
        If ds.Tables("ProDelSetting").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("ProDelSetting").Rows.Count - 1
                If Not IsDBNull(ds.Tables("ProDelSetting").Rows(m)("AutoID")) Then
                    poc.ProductionSumTimeSetting_Delete(ds.Tables("ProDelSetting").Rows(m)("AutoID").ToString)
                End If
            Next m
        End If


        Dim i As Integer
        For i = 0 To ds.Tables("ProSumTimeSetting").Rows.Count - 1

            Dim pi As New ProductionSumTimeSettingInfo
            Dim pc As New ProductionSumTimeSettingControl

            pi.StartTime = ds.Tables("ProSumTimeSetting").Rows(i)("StartTime").ToString
            pi.EndTime = ds.Tables("ProSumTimeSetting").Rows(i)("EndTime").ToString
            pi.TotalTime = ds.Tables("ProSumTimeSetting").Rows(i)("TotalTime")

            pi.ActionID = InUserID
            pi.ModifyDate = Format(Now, "yyyy-MM-dd HH:mm:ss")

            If ds.Tables("ProSumTimeSetting").Rows(i)("AutoID") Is DBNull.Value = True Then

                If pc.ProductionSumTimeSetting_Add(pi) = False Then
                    MsgBox("保存失敗!")
                    Exit Sub
                End If
            Else
                pi.AutoID = ds.Tables("ProSumTimeSetting").Rows(i)("AutoID").ToString

                If pc.ProductionSumTimeSetting_Update(pi) = False Then
                    MsgBox("保存失敗!")
                    Exit Sub
                End If
            End If
        Next


        MsgBox("保存成功!")
        Me.Close()
    End Sub



    Private Sub popSumPersonnelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelAdd.Click
        Dim row As DataRow
        row = ds.Tables("ProSumTimeSetting").NewRow

        row("AutoID") = Nothing
        row("StartTime") = "00:00"
        row("EndTime") = "00:00"
        row("TotalTime") = 0

        ds.Tables("ProSumTimeSetting").Rows.Add(row)
    End Sub

    Private Sub popSumPersonnelDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popSumPersonnelDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("ProDelSetting").NewRow

            row("AutoID") = ds.Tables("ProSumTimeSetting").Rows(GridView1.FocusedRowHandle)("AutoID")

            ds.Tables("ProDelSetting").Rows.Add(row)
        End If
        ds.Tables("ProSumTimeSetting").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = True Then
        Else
            Exit Sub
        End If

        SaveData()

    End Sub
End Class