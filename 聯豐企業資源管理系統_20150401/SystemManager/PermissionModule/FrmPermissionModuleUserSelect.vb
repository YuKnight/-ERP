Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse
Imports LFERP.Library.ProductionWareHouse

Public Class FrmPermissionModuleUserSelect
    Dim ds As New DataSet
    Private Sub FrmPermissionModuleUserSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = tempValue2 & "   " & tempValue
        CreateTable()
        LoadModule()
        If tempValue3 <> "" Then
            LoadModuleUser()
        End If
    End Sub
    Sub LoadModule()
        Select Case tempValue2
            Case "510308"
                LoadWareHouseA()
            Case "510501"
                LoadWareHouseA()
            Case "510601"
                LoadWareHouseA()
            Case "50100201" '還刀
                LoadWareHouseA()
            Case "500306"
                LoadWareHouse()
            Case "500105"
                LoadWareHouse()
            Case "500205"
                LoadWareHouse()
            Case "500401"
                LoadWareHouse()
            Case "50080101"
                LoadWareHouse()
            Case "50080201"
                LoadWareHouse()
            Case "880206"
                LoadWareHouse()
            Case "500701"
                LoadWareHouse()
            Case "700106"
                LoadWareHouse()
            Case "50080301"
                LoadWareHouse()
            Case "50080401"
                LoadWareHouse()
            Case "50080501"
                LoadWareHouse()
            Case "800206"
                LoadWareHouse()
            Case "500601"
                LoadWareHouse()
            Case "50080601"
                LoadWareHouse()
            Case "50080701"
                LoadWareHouse()
            Case "50080801"
                LoadWareHouse()
            Case "50080901"
                LoadWareHouse()
            Case "505007"
                LoadWareHouse()
            Case "880501"
                LoadWareHouse()
            Case "880606"
                LoadWareHouse()
            Case "880705"
                LoadWareHouseA()
            Case "880708"
                LoadWareHouseA()
            Case "880709"
                LoadWareHouseA()
            Case "880710"
                LoadWareHouseA()
            Case "880806"
                LoadWareHouseA()
            Case "880807"
                LoadWareHouseA()
            Case "880906"
                LoadWareHouseA()
            Case "880907"
                LoadWareHouseA()
            Case "881005"
                LoadWareHouseA()
            Case "881008"
                LoadWareHouseA()
            Case "881009"
                LoadWareHouseA()
            Case "881010"
                LoadWareHouseA()
            Case "88030101"
                LoadWareHouseA()
            Case "881409"
                LoadWareHouse()
            Case "50081201"
                LoadWareHouse()
            Case "50081301"
                LoadWareHouse()
            Case "50100101"
                LoadWareHouse()
            Case "50100201"
                LoadWareHouse()
            Case Else
                '需要載入的不是倉庫時
                Dim i, n As Integer
                Dim pmsc As New PermissionModuleSubController
                Dim pmsiL As New List(Of PermissionModuleSubInfo)
                pmsiL = pmsc.PermissionModuleSub_GetList(Nothing, tempValue2)

                Dim arr(n) As String
                arr = Split(pmsiL.Item(0).PMS_ValueList, ",")
                n = Len(Replace(pmsiL.Item(0).PMS_ValueList, ",", "," & "*")) - Len(pmsiL.Item(0).PMS_ValueList)

                For i = 0 To n
                    Dim row As DataRow = ds.Tables("Select").NewRow
                    row("Name") = arr(i)
                    row("TorF") = False
                    ds.Tables("Select").Rows.Add(row)

                    Select Case pmsiL.Item(0).PMS_Type
                        Case "單項選擇"
                            GridUser.Columns.Item("TF").HeaderText = "單項選擇"
                        Case "多項選擇"
                            GridUser.Columns.Item("TF").HeaderText = "多項選擇"
                    End Select
                Next
        End Select
        '----------------------------------------------------------------------------------------
        ''載入此模塊權限列表
        'If tempValue2 = "500306" Or tempValue2 = "500105" Or tempValue2 = "500205" Or tempValue2 = "500401" Or tempValue2 = "50080101" Or tempValue2 = "50080201" Or tempValue2 = "880206" Or tempValue2 = "500701" Or tempValue2 = "700106" Or tempValue2 = "50080301" Or tempValue2 = "50080401" Or tempValue2 = "50080501" Or tempValue2 = "800206" Or tempValue2 = "500601" Or tempValue2 = "50080601" Or tempValue2 = "50080701" Or tempValue2 = "50080801" Or tempValue2 = "50080901" Or tempValue2 = "505007" Or tempValue2 = "880501" Or tempValue2 = "880606" Or tempValue2 = "880806" Or tempValue2 = "880906" Or tempValue2 = "880705" Or tempValue2 = "881409" Or tempValue2 = "50081201" Or tempValue2 = "50081301" Or tempValue2 = "50100101" Or tempValue2 = "50100201" Then
        '    '需要載入倉庫時
        '    Dim i As Integer
        '    Dim pmsc As New WareHouseController
        '    Dim pmsiL As New List(Of WareHouseInfo)
        '    pmsiL = pmsc.WareHouse_GetList(Nothing)

        '    For i = 0 To pmsiL.Count - 1
        '        If Len(pmsiL.Item(i).WH_ID.ToString) = 3 Then
        '            Dim row As DataRow = ds.Tables("Select").NewRow
        '            row("Name") = pmsiL.Item(i).WH_ID.ToString
        '            row("TorF") = False
        '            ds.Tables("Select").Rows.Add(row)
        '        End If

        '        GridUser.Columns.Item("TF").HeaderText = "多項選擇"
        '    Next

        '    'ElseIf tempValue2 = "880606" Then   '對應生產倉庫
        '    '    Dim i As Integer
        '    '    Dim pc As New ProductionWareHouseControl
        '    '    Dim pci As List(Of ProductionWareHouseInfo)
        '    '    pci = pc.ProductionWareHouse_GetList(Nothing)

        '    '    For i = 0 To pci.Count - 1
        '    '        If Len(pci(i).PH_ID) = 3 Then
        '    '            Dim row As DataRow = ds.Tables("Select").NewRow
        '    '            row("Name") = pci(i).PH_ID
        '    '            row("TorF") = False
        '    '            ds.Tables("Select").Rows.Add(row)
        '    '        End If

        '    '        GridUser.Columns.Item("TF").HeaderText = "多項選擇"
        '    '    Next

        'Else
        '    '需要載入的不是倉庫時
        '    Dim i, n As Integer
        '    Dim pmsc As New PermissionModuleSubController
        '    Dim pmsiL As New List(Of PermissionModuleSubInfo)
        '    pmsiL = pmsc.PermissionModuleSub_GetList(Nothing, tempValue2)

        '    Dim arr(n) As String
        '    arr = Split(pmsiL.Item(0).PMS_ValueList, ",")
        '    n = Len(Replace(pmsiL.Item(0).PMS_ValueList, ",", "," & "*")) - Len(pmsiL.Item(0).PMS_ValueList)

        '    For i = 0 To n

        '        Dim row As DataRow = ds.Tables("Select").NewRow
        '        row("Name") = arr(i)
        '        row("TorF") = False
        '        ds.Tables("Select").Rows.Add(row)

        '        Select Case pmsiL.Item(0).PMS_Type
        '            Case "單項選擇"
        '                GridUser.Columns.Item("TF").HeaderText = "單項選擇"
        '            Case "多項選擇"
        '                GridUser.Columns.Item("TF").HeaderText = "多項選擇"
        '        End Select

        '    Next
        'End If
    End Sub
    Sub LoadWareHouse()
        '需要載入倉庫時
        Dim i As Integer
        Dim pmsc As New WareHouseController
        Dim pmsiL As New List(Of WareHouseInfo)
        pmsiL = pmsc.WareHouse_GetList(Nothing)

        For i = 0 To pmsiL.Count - 1
            If Len(pmsiL.Item(i).WH_ID.ToString) = 3 Then
                Dim row As DataRow = ds.Tables("Select").NewRow
                row("Name") = pmsiL.Item(i).WH_ID.ToString
                row("TorF") = False
                ds.Tables("Select").Rows.Add(row)
            End If
            GridUser.Columns.Item("TF").HeaderText = "多項選擇"
        Next
    End Sub
    Sub LoadWareHouseA()
        '需要載入倉庫時
        Dim i As Integer
        Dim pmsc As New WareHouseController
        Dim pmsiL As New List(Of WareHouseInfo)
        pmsiL = pmsc.WareHouse_GetList(Nothing)

        For i = 0 To pmsiL.Count - 1
            If Len(pmsiL.Item(i).WH_ID.ToString) = 5 Then
                Dim row As DataRow = ds.Tables("Select").NewRow
                row("Name") = pmsiL.Item(i).WH_ID.ToString
                row("TorF") = False
                ds.Tables("Select").Rows.Add(row)
            End If
            GridUser.Columns.Item("TF").HeaderText = "多項選擇"
        Next
    End Sub
    Sub LoadModuleUser()
        '此用戶原來已有權限,載入
        Dim i, n, m As Integer
        Dim arr(i) As String
        arr = Split(tempValue3, ",")
        n = Len(Replace(tempValue3, ",", "," & "*")) - Len(tempValue3)
        For i = 0 To n
            For m = 0 To ds.Tables("Select").Rows.Count - 1
                If arr(i) = ds.Tables("Select").Rows(m)("Name").ToString Then ds.Tables("Select").Rows(m)("TorF") = True
            Next
        Next
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Select")
            .Columns.Add("TorF", GetType(Boolean))
            .Columns.Add("Name", GetType(String))

        End With
        '綁定表格
        GridUser.DataSource = ds.Tables("Select")
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Check() = False Then
            MsgBox("此為單項選擇")
            Exit Sub
        End If

        Dim i, n As Integer
        n = 0
        tempValue3 = ""
        For i = 0 To ds.Tables("Select").Rows.Count - 1
            If ds.Tables("Select").Rows(i)("TorF") = True Then
                If n = 0 Then
                    tempValue3 = ds.Tables("Select").Rows(i)("Name")
                    n = n + 1
                Else
                    tempValue3 = tempValue3 & "," & ds.Tables("Select").Rows(i)("Name")
                End If

            End If
        Next
        Me.Close()
    End Sub
    Function Check() As Boolean
        Check = True
        If GridUser.Columns.Item("TF").HeaderText = "單項選擇" Then
            Dim i, n As Integer
            n = 0
            For i = 0 To ds.Tables("Select").Rows.Count - 1
                If ds.Tables("Select").Rows(i)("TorF") = True Then
                    n = n + 1
                End If

                If n = 2 Then
                    Check = False
                    Exit Function
                End If
            Next
        End If
    End Function

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class