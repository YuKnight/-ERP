Imports LFERP.Library.ProductionRetrocede

Public Class frmLoadRetrocede

    Dim StrINWare As String
    Dim StrOutWare As String

    Dim prc As New ProductionRetrocedeControl

    '@ 2012/1/6 添加加載時焦點落在txtNO控件上
    Private Sub frmLoadRetrocede_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim StrStartDate As String
        Dim StrEndDate As String

        StrStartDate = Format(Now, "yyyy/MM") & "/01"
        StrEndDate = Format(Now, "yyyy/MM/dd")

        StrINWare = "'" & tempValue2 & "'"
        StrOutWare = "'" & tempValue3 & "'"
        tempValue2 = Nothing
        tempValue3 = Nothing

        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 12
        Grid.DataSource = prc.ProductionRetrocede_GetList2(Nothing, Nothing, Nothing, StrOutWare, StrINWare, Nothing, Nothing, Nothing, True, True, "1", StrStartDate, StrEndDate)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAll.Click
        Grid.AutoGenerateColumns = False
        Grid.DataSource = prc.ProductionRetrocede_GetList2(Nothing, Nothing, Nothing, StrOutWare, StrINWare, Nothing, Nothing, Nothing, True, True, "1", Nothing, Nothing)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        RefreshT = False
        Me.Close()
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        tempValue = ""
        Dim i, n As Integer
        n = 0
        For i = 0 To Grid.RowCount - 1

            If Grid.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = Grid.Rows(i).Cells("IndexNO").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & Grid.Rows(i).Cells("IndexNO").Value.ToString
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

End Class