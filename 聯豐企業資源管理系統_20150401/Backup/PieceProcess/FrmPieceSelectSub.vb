Imports LFERP.Library.PieceProcess.PersonnelControl
Public Class FrmPieceSelectSub
    Dim ds As New DataSet
    Dim TempStr As String
    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl

    Private Sub FrmPieceSelectSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim piL As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        Dim Row As DataRow
        Createtable()
        piL = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        For i As Integer = 0 To piL.Count - 1
            Row = ds.Tables("DepFacName").NewRow
            Row("Choose") = False
            Row("DepNO") = piL(i).DepID
            Row("DepName") = piL(i).DepName
            Row("FacName") = piL(i).FacName
            ds.Tables("DepFacName").Rows.Add(Row)
        Next

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub Createtable()
        With ds.Tables.Add("DepFacName") '部門廠別表

            .Columns.Add("Choose", GetType(Boolean))
            .Columns.Add("DepNO", GetType(String))
            .Columns.Add("DepName", GetType(String))
            .Columns.Add("FacName", GetType(String))

        End With
        With ds.Tables.Add("FacName") '廠別表

            .Columns.Add("Choose", GetType(Boolean))
            .Columns.Add("FacNO", GetType(String))
            .Columns.Add("FacName", GetType(String))

        End With
        Grid.DataSource = ds.Tables("DepFacName")
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        For i As Integer = 0 To ds.Tables("DepFacName").Rows.Count - 1
            ds.Tables("DepFacName").Rows(i)("Choose") = True
        Next
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        For i As Integer = 0 To ds.Tables("DepFacName").Rows.Count - 1
            ds.Tables("DepFacName").Rows(i)("Choose") = False
        Next
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        TempStr = ""
        For i As Integer = 0 To ds.Tables("DepFacName").Rows.Count - 1
            If ds.Tables("DepFacName").Rows(i)("Choose") Then
                If TempStr = "" Then
                    TempStr = "'" & ds.Tables("DepFacName").Rows(i)("DepNO") & "'"
                Else
                    TempStr = TempStr & ",'" & ds.Tables("DepFacName").Rows(i)("DepNO") & "'"
                End If

            End If
        Next
        If TempStr = "" Then
            MsgBox("你沒有選擇過項目﹐請選擇后操作!", , "提示")
            Exit Sub
        End If
        tempValue = " DepNO IN (" & TempStr & ")"
        Me.Close()
    End Sub
End Class