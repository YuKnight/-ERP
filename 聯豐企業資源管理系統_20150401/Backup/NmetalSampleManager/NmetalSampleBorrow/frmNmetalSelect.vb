Imports LFERP.Library.NmetalSampleManager.NmetalSampleBorrow
Public Class frmNmetalSelect

#Region "字段屬性"
    Dim src As New NmetalSampleRepayController
    Dim sbc As New NmetalSampleBorrowController
    Dim ds As New DataSet
    Private _EditItem As String

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
#End Region

#Region "創建、填充臨時表"
    Sub CreateTables()
        Dim dt As New DataTable
        With dt
            .Columns.Add("FieldName", GetType(String))
            .Columns.Add("Type", GetType(String))
            .Columns.Add("Category", GetType(String))
        End With
        dt.Rows.Add("OutD_ID", "String", "借出部门")
        dt.Rows.Add("InD_ID", "String", "借入部门")
        dt.Rows.Add("CheckBit", "Boolean", "审核")
        dt.Rows.Add("CreateDate", "Date", "创建日期")
        dt.Rows.Add("PM_M_Code", "String", "物料编码")
        If EditItem = "Repay" Then
            dt.Rows.Add("InCardID", "String", "刷卡人员")
            dt.Rows.Add("RepayDate", "Date", "还回日期")
        Else
            dt.Rows.Add("OutCardID", "String", "刷卡人员")
            dt.Rows.Add("BorrowDate", "Date", "借出日期")
        End If
        GridControl1.DataSource = dt

        With ds.Tables.Add("SelectTbDel")
            .Columns.Add("DelConditon", GetType(String))
            .Columns.Add("DelDisplay", GetType(String))
        End With
        GridControl2.DataSource = ds.Tables("SelectTbDel")
    End Sub


#End Region

    Private Sub frmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lodata()
        CreateTables()
    End Sub

    Private Sub Lodata()
        If EditItem = "Repay" Then
            lblID.Text = "请选择还回单号："
            viewID.Columns(0).Caption = "还回单号"
            viewID.Columns(0).FieldName = "RepayID"
            gueID.Properties.DataSource = src.NmetalSampleRepay_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False)
            gueID.Properties.DisplayMember = "RepayID"
            gueID.Properties.ValueMember = "RepayID"

        Else
            lblID.Text = "请选择借出单号："
            viewID.Columns(0).Caption = "借出单号"
            viewID.Columns(0).FieldName = "BorrowID"
            gueID.Properties.DataSource = sbc.NmetalSampleBorrow_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False)
            gueID.Properties.DisplayMember = "BorrowID"
            gueID.Properties.ValueMember = "BorrowID"
        End If
    End Sub

#Region "通過類型不同自動條件選擇"
    Private Sub GridView1_FocusedRowChanged_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        On Error Resume Next
        If GridView1.GetFocusedRowCellValue("Type") = "Date" Then
            XtraTabControl2.SelectedTabPageIndex = 1
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = True
            XtraTabControl2.TabPages(2).PageEnabled = False
            XtraTabControl2.TabPages(3).PageEnabled = False
            'ElseIf GridView1.GetFocusedRowCellValue("Type") = "數字" Then
            '    XtraTabControl2.SelectedTabPageIndex = 2
            '    XtraTabControl2.TabPages(0).PageEnabled = False
            '    XtraTabControl2.TabPages(1).PageEnabled = False
            '    XtraTabControl2.TabPages(2).PageEnabled = True
            '    XtraTabControl2.TabPages(3).PageEnabled = False
        ElseIf GridView1.GetFocusedRowCellValue("Type") = "String" Then
            XtraTabControl2.SelectedTabPageIndex = 0
            XtraTabControl2.TabPages(0).PageEnabled = True
            XtraTabControl2.TabPages(1).PageEnabled = False
            XtraTabControl2.TabPages(2).PageEnabled = False
            XtraTabControl2.TabPages(3).PageEnabled = False
        Else
            XtraTabControl2.SelectedTabPageIndex = 3
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = False
            XtraTabControl2.TabPages(2).PageEnabled = False
            XtraTabControl2.TabPages(3).PageEnabled = True
        End If
    End Sub
#End Region

#Region "添加条件"
    Private Sub cmdAdd_Char_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Char.Click
        If TextBox1.Text = String.Empty Then
            MsgBox("請輸入要查詢的條件！")
            Return
        Else
            Dim Row As DataRow
            Row = ds.Tables("SelectTbDel").NewRow
            Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " like " + "'%" + TextBox1.Text + "%'" + " "
            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " Like " + "'" + TextBox1.Text + "'"
            Else
                Row("DelDisplay") = Mid(Trim(cboCondition.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " Like " + "'" + TextBox1.Text + "'"
            End If
            ds.Tables("SelectTbDel").Rows.Add(Row)
        End If
    End Sub
    ''' <summary>
    ''' 添加日期類型條件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Date.Click
        Dim Row As DataRow
        Row = ds.Tables("SelectTbDel").NewRow
        Select Case ComboBoxEdit2.SelectedIndex
            Case 0
                Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " DATEDIFF(day,'" + DateEdit1.Text + "'," + GridView1.GetFocusedRowCellValue("FieldName") + ")=0"
            Case 1
                Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " DATEDIFF(day,'" + DateEdit1.Text + "'," + GridView1.GetFocusedRowCellValue("FieldName") + ")>0"
            Case 2
                Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " DATEDIFF(day,'" + DateEdit1.Text + "'," + GridView1.GetFocusedRowCellValue("FieldName") + ")<0"
        End Select
        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(ComboBoxEdit2.Text), 3) + " " + "'" + DateEdit1.Text + "'"
        Else
            Row("DelDisplay") = Mid(Trim(cboCondition.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(ComboBoxEdit2.Text), 3) + " " + "'" + DateEdit1.Text + "'"
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
    End Sub
    ''' <summary>
    ''' 添加數字類型條件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Number_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Number.Click
        Dim Row As DataRow
        Row = ds.Tables("SelectTbDel").NewRow
        Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + "  " + Mid(Trim(cboLogic.Text), 1, 3) + " " + "'" + txtQty.Text.Trim + "'" + " "
        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(cboLogic.Text), 3) + " " + "'" + txtQty.Text.Trim + "'"
        Else
            Row("DelDisplay") = Mid(Trim(cboCondition.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(cboLogic.Text), 3) + " " + "'" + txtQty.Text.Trim + "'"
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
    End Sub
    ''' <summary>
    ''' 添加其他類型條件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Other_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Other.Click
        Dim Row As DataRow
        Row = ds.Tables("SelectTbDel").NewRow
        If ComboBoxEdit1.Text = "是" Then
            Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'True'"
            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " 等於 " + "'" + ComboBoxEdit1.Text + "'"
            Else
                Row("DelDisplay") = Mid(Trim(cboCondition.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " 等於 " + "'" + ComboBoxEdit1.Text + "'"
            End If
            ds.Tables("SelectTbDel").Rows.Add(Row)
        Else
            Row("DelConditon") = " " & Mid(cboCondition.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " != " + "'True'"
            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " 等於 " + "'" + ComboBoxEdit1.Text + "'"
            Else
                Row("DelDisplay") = Mid(Trim(cboCondition.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " 等於 " + "'" + ComboBoxEdit1.Text + "'"
            End If
            ds.Tables("SelectTbDel").Rows.Add(Row)
        End If
    End Sub
#End Region
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView2.RowCount = 0 Then Exit Sub
        Dim i As Integer = ds.Tables("SelectTbDel").Rows.Count - 1
        ds.Tables("SelectTbDel").Rows.RemoveAt(i)
    End Sub


#Region "保存、退出事件"
    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then   '固定樣式查詢
            If gueID.Text <> String.Empty Then
                tempValue = "FixAtion"
                tempValue2 = gueID.Text   '查詢條件--選擇的單號\預測單號....
            Else
                MsgBox("未做任何選擇，請選擇！", MsgBoxStyle.Information, "提示")
                Return
            End If
        Else   '自定義樣式查詢
            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                MsgBox("選擇篩選條件！")
                Return
            End If
            tempValue = "Dynamic"
            tempValue2 = ""
            For i As Integer = 0 To ds.Tables("SelectTbDel").Rows.Count - 1
                tempValue2 = tempValue2 & ds.Tables("SelectTbDel").Rows(i)("DelConditon").ToString   '查詢條件--拼接篩選表中的條件
            Next
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancle.Click
        tempValue = String.Empty
        Me.Close()
    End Sub
#End Region

End Class