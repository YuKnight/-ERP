Imports LFERP.Library.WareHouse.WareHouseSplit

Public Class frmWareChaiControl

    Dim ds As New DataSet

    Private Sub frmWareChaiControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CreateTable()

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("WareSplit")
            .Columns.Add("S_ID", GetType(String))
            .Columns.Add("M_LCode", GetType(String))
            .Columns.Add("M_SCode", GetType(String))
            .Columns.Add("S_Type", GetType(String))
            .Columns.Add("S_Qty", GetType(Double))

            .Columns.Add("S_Ratio", GetType(String))
            .Columns.Add("S_AddDate", GetType(Date))
            .Columns.Add("S_Action", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("Unit1", GetType(String))

            .Columns.Add("Unit2", GetType(String))
            .Columns.Add("S_Qty1", GetType(Double))

        End With

        GridControl1.DataSource = ds.Tables("WareSplit")

    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click

        Dim strM_LCode, strM_SCode, strM_Name, strS_Type, strS_Action As String

        If Len(txtM_LCode.Text.Trim) = 0 Then
            strM_LCode = Nothing
        Else
            strM_LCode = txtM_LCode.Text
        End If

        If Len(txtM_SCode.Text.Trim) = 0 Then
            strM_SCode = Nothing
        Else
            strM_SCode = txtM_SCode.Text
        End If

        If Len(txtM_Name.Text.Trim) = 0 Then
            strM_Name = Nothing
        Else
            strM_Name = txtM_Name.Text
        End If

        If Len(cboS_Type.Text.Trim) = 0 Then
            strS_Type = Nothing
        Else
            strS_Type = cboS_Type.Text
        End If
        If Len(txtS_Action.Text.Trim) = 0 Then
            strS_Action = Nothing
        Else
            strS_Action = txtS_Action.Text
        End If

        'Dim wsi As List(Of WareHouseSplitInfo)
        Dim wsc As New WareHouseSplitControl
        GridControl1.DataSource = wsc.WareHouseSplit_GetList(Nothing, strM_LCode, strM_SCode, strM_Name, strS_Type, strS_Action)

        'If wsi.Count = 0 Then
        '    MsgBox("無此查詢條件拆合記錄")
        '    ds.Tables("WareSplit").Clear()
        '    Exit Sub
        'End If

        'ds.Tables("WareSplit").Clear()
        'Dim i As Integer
        'For i = 0 To wsi.Count - 1
        '    Dim row As DataRow

        '    row = ds.Tables("WareSplit").NewRow

        '    row("M_LCode") = wsi(i).M_LCode
        '    row("M_SCode") = wsi(i).M_SCode
        '    row("S_Type") = wsi(i).S_Type
        '    row("S_Qty") = wsi(i).S_Qty
        '    row("S_Ratio") = wsi(i).S_Ratio
        '    row("S_AddDate") = wsi(i).S_AddDate
        '    row("S_Action") = wsi(i).S_Action
        '    row("M_Name") = wsi(i).M_Name
        '    row("S_Qty1") = CInt(wsi(i).S_Qty * CSng(wsi(i).S_Ratio))
        '    row("Unit1") = wsi(i).Unit1
        '    row("Unit2") = wsi(i).Unit2

        '    ds.Tables("WareSplit").Rows.Add(row)
        'Next

    End Sub

    'Private Sub TextEdit3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit3.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        cmdSelect_Click(Nothing, Nothing)
    '    End If
    'End Sub

    'Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit1.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        cmdSelect_Click(Nothing, Nothing)
    '    End If
    'End Sub

    'Private Sub TextEdit2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit2.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        cmdSelect_Click(Nothing, Nothing)
    '    End If
    'End Sub
End Class