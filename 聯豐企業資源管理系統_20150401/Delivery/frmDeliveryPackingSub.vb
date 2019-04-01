Imports LFERP.Library.Delivery

Public Class frmDeliveryPackingSub

    Dim ds As New DataSet

    Private Sub frmDeliveryPackingSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = tempValue4
        Label3.Text = tempValue2
        tempValue2 = ""
        tempValue4 = ""
        CreateTable()
        Select Case Label2.Text

            Case "送貨單"
                LoadData(Label3.Text)
                DeliveryPackingSubAdd.Enabled = True
                DeliveryPackingSubDel.Enabled = True
                cmdSave.Visible = True

            Case Else
                LoadData(Label3.Text)
                DeliveryPackingSubAdd.Enabled = False
                DeliveryPackingSubDel.Enabled = False
                cmdSave.Visible = False

        End Select
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("DeliveryPackingSub")

            .Columns.Add("IndexNum", GetType(Integer))
            .Columns.Add("DNS_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("DS_Qty", GetType(Double))
            .Columns.Add("DS_SP", GetType(Double))

        End With
        With ds.Tables.Add("DelDeliveryPackingSub")
            .Columns.Add("DNS_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
        End With

        GridControl1.DataSource = ds.Tables("DeliveryPackingSub")

    End Sub

    Sub LoadData(ByVal DNS_NO As String)

        Dim dc As New DeliveryControl
        Dim di As New List(Of DeliveryInfo)

        Try
            di = dc.DeliveryPackingSub_GetList(DNS_NO, Nothing)
            If di Is Nothing Then Exit Sub
            Dim i As Integer
            Dim row As DataRow
            ds.Tables("DeliveryPackingSub").Clear()
            For i = 0 To di.Count - 1

                row = ds.Tables("DeliveryPackingSub").NewRow

                row("IndexNum") = di(i).IndexNum
                row("DNS_NO") = di(i).DNS_NO
                row("M_Code") = di(i).M_Code
                row("M_Name") = di(i).M_Name
                row("M_Gauge") = di(i).M_Gauge
                row("DS_Qty") = di(i).DS_Qty
                row("DS_SP") = di(i).DS_SP

                ds.Tables("DeliveryPackingSub").Rows.Add(row)

            Next

        Catch ex As Exception

        End Try

    End Sub

    Sub DataNew()
        Dim dc As New DeliveryControl
        Dim di As New DeliveryInfo

        Dim i As Integer
        For i = 0 To ds.Tables("DeliveryPackingSub").Rows.Count - 1

            If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")) Then
                'di.DNS_NO = Nothing
                MsgBox("送貨項目編號不能為空！")
                Exit Sub
            Else
                di.DNS_NO = ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")
            End If
            If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")) Then
                MsgBox("物料編碼不能未空!")
                Exit Sub
            Else
                di.M_Code = ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")
            End If
            If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")) Then
                di.DS_Qty = 0
            Else
                di.DS_Qty = ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")
            End If
            If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")) Then
                di.DS_SP = 0
            Else
                di.DS_SP = ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")
            End If
            If dc.DeliveryPackingSub_Add(di) = False Then
                MsgBox("添加失敗，請檢查原因！")
                Exit Sub
            End If

        Next
        Me.Close()
    End Sub

    Sub DataEdit()
        Dim dc As New DeliveryControl
        Dim di As New DeliveryInfo

        Dim i As Integer
        For i = 0 To ds.Tables("DeliveryPackingSub").Rows.Count - 1

            If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("IndexNum")) Then

                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")) Then

                    MsgBox("送貨項目編號不能為空！")
                    Exit Sub
                Else
                    di.DNS_NO = ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")) Then
                    MsgBox("物料編碼不能未空!")
                    Exit Sub
                Else
                    di.M_Code = ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")) Then
                    di.DS_Qty = 0
                Else
                    di.DS_Qty = ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")) Then
                    di.DS_SP = 0
                Else
                    di.DS_SP = ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")
                End If
                If dc.DeliveryPackingSub_Add(di) = False Then
                    MsgBox("添加失敗，請檢查原因！")
                    Exit Sub
                End If
            ElseIf Not IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("IndexNum")) Then

                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")) Then

                    MsgBox("送貨項目編號不能為空！")
                    Exit Sub
                Else
                    di.DNS_NO = ds.Tables("DeliveryPackingSub").Rows(i)("DNS_NO")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")) Then
                    MsgBox("物料編碼不能未空!")
                    Exit Sub
                Else
                    di.M_Code = ds.Tables("DeliveryPackingSub").Rows(i)("M_Code")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")) Then
                    di.DS_Qty = 0
                Else
                    di.DS_Qty = ds.Tables("DeliveryPackingSub").Rows(i)("DS_Qty")
                End If
                If IsDBNull(ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")) Then
                    di.DS_SP = 0
                Else
                    di.DS_SP = ds.Tables("DeliveryPackingSub").Rows(i)("DS_SP")
                End If
                If dc.DeliveryPackingSub_Update(di) = False Then
                    MsgBox("修改失敗，請檢查原因！")
                    Exit Sub
                End If
            End If

        Next
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If EditSub = True Then
            DataNew()
        Else
            DataEdit()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub DeliveryPackingSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPackingSubAdd.Click

    End Sub

    Private Sub DeliveryPackingSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPackingSubDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")
        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelDeliveryPackingSub").NewRow
            row("DNS_NO") = Label3.Text
            row("M_Code") = DelTemp
            ds.Tables("DelDeliveryPackingSub").Rows.Add(row)
        End If
        ds.Tables("DeliveryPackingSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

End Class