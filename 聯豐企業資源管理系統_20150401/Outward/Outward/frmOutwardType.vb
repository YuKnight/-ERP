Imports LFERP.Library.Outward.OutwardProjectType
Imports LFERP.Library.Outward
Imports LFERP.Library.Orders

Public Class frmOutwardType

    Dim ds As New DataSet

    Private Sub frmOutwardType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LookUpEdit1.Properties.DisplayMember = "OT_Name"
        LookUpEdit1.Properties.ValueMember = "OT_NO"
        Dim oc As New OutwardController
        CreateTable()

        LookUpEdit1.Properties.DataSource = oc.OutwardType_GetList(Nothing, Nothing)
        LookUpEdit1.EditValue = tempValue4
        Label2.Text = tempValue4
        TextEdit1.Text = tempValue3
        Label7.Text = tempValue3

        Label3.Text = tempValue2
        Label6.Text = tempValue6

        If Len(LookUpEdit1.Text.Trim) <> 0 And Len(TextEdit1.Text.Trim) = 0 Then
            LoadData3(Label3.Text)
        ElseIf Len(LookUpEdit1.Text.Trim) = 0 And Len(TextEdit1.Text.Trim) <> 0 Then
            LoadData2(TextEdit1.Text)
        ElseIf Len(LookUpEdit1.Text.Trim) <> 0 And Len(TextEdit1.Text.Trim) <> 0 Then
            LoadData(TextEdit1.Text, Label3.Text)
        End If

        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue6 = ""

        txtType.EditValue = ""

        MenuAdd.Visible = False
        MenuEdit.Visible = False

    End Sub

    Sub CreateTable()

        ds.Tables.Clear()
        With ds.Tables.Add("OutwardType")
            .Columns.Add("PT_Name", GetType(String))
            .Columns.Add("PT_NO", GetType(String))
            .Columns.Add("PT_Detail", GetType(String))
        End With
        Grid.DataSource = ds.Tables("OutwardType")
    End Sub
    '根據批次編號，以及項目類型導出對應的描述（項目內容）
    Sub LoadData(ByVal OS_BatchID As String, ByVal OT_Name As String)
        Dim dc As New OrdersDetailController
        Dim di As List(Of OrdersDetailInfo)

        di = dc.OrdersDetail_GetList(OS_BatchID, OT_Name)
        If di.Count = 0 Then Exit Sub
        Dim row As DataRow
        ds.Tables("OutwardType").Clear()
        Dim i As Integer
        For i = 0 To di.Count - 1
            row = ds.Tables("OutwardType").NewRow

            row("PT_NO") = di(i).OD_ID
            row("PT_Name") = di(i).OD_Name
            row("PT_Detail") = di(i).OD_Detail

            ds.Tables("OutwardType").Rows.Add(row)
        Next

    End Sub
    Sub LoadData2(ByVal OS_BatchID As String)
        Dim dc As New OrdersDetailController
        Dim di As List(Of OrdersDetailInfo)

        di = dc.OrdersDetail_GetList(OS_BatchID, Nothing)
        If di.Count = 0 Then Exit Sub
        Dim row As DataRow
        ds.Tables("OutwardType").Clear()
        Dim i As Integer
        For i = 0 To di.Count - 1
            row = ds.Tables("OutwardType").NewRow

            row("PT_NO") = di(i).OD_ID
            row("PT_Name") = di(i).OD_Name
            row("PT_Detail") = di(i).OD_Detail

            ds.Tables("OutwardType").Rows.Add(row)
        Next
    End Sub
    Sub LoadData3(ByVal OT_Name As String)
        Dim dc As New OrdersDetailController
        Dim di As List(Of OrdersDetailInfo)

        di = dc.OrdersDetail_GetList(Nothing, OT_Name)
        If di.Count = 0 Then Exit Sub
        Dim row As DataRow
        ds.Tables("OutwardType").Clear()
        Dim i As Integer
        For i = 0 To di.Count - 1
            row = ds.Tables("OutwardType").NewRow

            row("PT_NO") = di(i).OD_ID
            row("PT_Name") = di(i).OD_Name
            row("PT_Detail") = di(i).OD_Detail

            ds.Tables("OutwardType").Rows.Add(row)
        Next
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue6 = Label7.Text
        tempValue7 = Label2.Text
        tempValue8 = Label6.Text
        tempValue5 = txtType.EditValue
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim oti As List(Of OutwardInfo)
        Dim otc As New OutwardController

        oti = otc.OutwardType_GetList(LookUpEdit1.EditValue, Nothing)
        If oti.Count = 0 Then
            Grid.DataSource = Nothing
            Exit Sub
        End If

        If Len(LookUpEdit1.Text.Trim) <> 0 And Len(TextEdit1.Text.Trim) = 0 Then
            LoadData3(oti(0).OT_Name)
        ElseIf Len(LookUpEdit1.Text.Trim) = 0 And Len(TextEdit1.Text.Trim) <> 0 Then
            LoadData2(TextEdit1.Text)
        ElseIf Len(LookUpEdit1.Text.Trim) <> 0 And Len(TextEdit1.Text.Trim) <> 0 Then
            LoadData(TextEdit1.Text, oti(0).OT_Name)
        End If

    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount = 0 Then Exit Sub
        txtType.EditValue = txtType.EditValue & GridView1.GetFocusedRowCellValue("PT_Detail").ToString
    End Sub

End Class