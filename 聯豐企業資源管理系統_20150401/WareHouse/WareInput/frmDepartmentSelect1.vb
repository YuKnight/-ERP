Imports LFERP.DataSetting
Public Class frmDepartmentSelect1
    Dim dpm As New DepartmentControler

    Dim tempStr As String
    Public DptID, DptName, UpDptName As String

    Private Sub frmDepartmentSelect1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim i, j As Integer

        tempStr = tempValue
        tempValue = ""

        Dim ltc As New CollectionToDataSet
        ds.Tables.Clear()

        Dim arr2 As New ArrayList


        Dim n As Integer
        Dim arr(n) As String
        arr = Split(tempStr, ",")
        n = Len(Replace(tempStr, ",", "," & "*")) - Len(tempStr)

        For i = 0 To n
            If Len(arr(i)) = 8 Then
                arr2.Add(Mid(arr(i), 1, 2))
                arr2.Add(Mid(arr(i), 1, 4))
                arr2.Add(Mid(arr(i), 1, 6))
                arr2.Add(arr(i))
            End If
        Next

        ltc.CollToDataSet(ds, "DPT", dpm.Department_GetList(Nothing, Nothing, Nothing))
        ltc = Nothing

        Dim II As Integer

        If ds.Tables("DPT").Rows.Count > 0 Then

            For i = 0 To ds.Tables("DPT").Rows.Count - 1
                Dim LS As String = ""
                For j = 0 To arr2.Count - 1
                    If ds.Tables("DPT").Rows(i - II)("DPT_ID") = arr2(j) Then
                        LS = "Y"
                        GoTo AA
                    End If
                Next

                If LS = "" Then
                    ds.Tables("DPT").Rows.RemoveAt(i - II)
                    II = II + 1
                End If
AA:
            Next
        End If

        Me.TreeList1.DataSource = ds.Tables("DPT")
        TreeList1.ExpandAll()
    End Sub

    Private Sub TreeList1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.Click
        '列出詳細
        If TreeList1.Nodes.Count <= 0 Then Exit Sub
        Dim strA As String
        strA = TreeList1.FocusedNode.Item("DPT_ID").ToString()
        Me.Label1.Text = strA

        DptID = TreeList1.FocusedNode.Item("DPT_ID").ToString()
        DptName = TreeList1.FocusedNode.Item("DPT_Name").ToString()

    End Sub

    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        '列出詳細
        If TreeList1.Nodes.Count <= 0 Then Exit Sub
        Dim strA As String
        strA = TreeList1.FocusedNode.Item("DPT_ID").ToString()
        If Len(strA) = 8 Then
        Else
            Exit Sub
        End If

        DptID = TreeList1.FocusedNode.Item("DPT_ID").ToString()
        DptName = TreeList1.FocusedNode.Item("DPT_Name").ToString()
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If TreeList1.Nodes.Count <= 0 Then Exit Sub

        If Len(Me.Label1.Text) = 8 Then
        Else
            MsgBox("請選擇部門!")
            Exit Sub
        End If

        DptID = TreeList1.FocusedNode.Item("DPT_ID").ToString()
        DptName = TreeList1.FocusedNode.Item("DPT_Name").ToString()
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        DptID = ""
        DptName = ""
        UpDptName = ""
        Me.Close()
    End Sub
End Class