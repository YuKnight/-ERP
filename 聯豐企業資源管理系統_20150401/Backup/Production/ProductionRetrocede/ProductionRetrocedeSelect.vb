Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Public Class ProductionRetrocedeSelect

    Dim ds As New DataSet
    Dim TempA As String, TempB As String
    Dim StrA As String, StrB As String, StrC As String


    Private Sub ProductionRetrocedeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = tempValue  '類型
        TempA = Label2.Text
        Label3.Text = tempValue4  '倉庫編號
        tempValue = ""
        tempValue4 = ""

        If Label2.Text = "生產補退貨單" Then
            ComboBoxEdit1.EditValue = "補退貨單號"
        Else
            ComboBoxEdit1.EditValue = "退貨單號"
        End If

        CreateTable()
        LoadTable()
        LoadPM_M_Code()
        RadioButton1.Checked = True

    End Sub


    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage.Text = "固定樣式" Then
            TextEdit1.Select()
        Else
            TextEdit2.Select()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBoxEdit1.Focus()
        End If
    End Sub

    '保存查詢結果信息
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        '指定當前實際倉庫信息 （目前此模塊主要針對裝配退貨，生產補送貨信息）
        '主要需要用到的倉庫為生產交接倉以及裝配交接倉---均為虛擬
        If Len(TextEdit3.Text) = 3 Then
            MsgBox("請選擇正確的倉庫!")
            Exit Sub

        End If
        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            If RadioButton1.Checked = True Then

                If ComboBoxEdit1.Text = "退貨單號" Or ComboBoxEdit1.Text = "補退貨單號" Then
                    tempValue = 1
                    tempValue2 = TextEdit1.Text
                End If

            End If
        Else
            '使用自定義查詢信息

            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                MsgBox("查詢條件為空,請添加后在確定!", , "提示")
                Exit Sub
            End If
            tempValue = 2
            tempValue2 = ""
            For i As Integer = 0 To ds.Tables("SelectTbDel").Rows.Count - 1
                tempValue2 = tempValue2 & ds.Tables("SelectTbDel").Rows(i)("DelConditon").ToString
            Next


            '暫時屏蔽當前發出倉庫信息  2012/9/5
            'tempValue2 = tempValue2 & " and WH_OutID='" & TextEdit3.Text & "'"
        End If

        Me.Close()
    End Sub

    Sub CreateTable()

        ds.Tables.Clear()

        With ds.Tables.Add("SelectTb")
            .Columns.Add("AutoID", GetType(Integer))
            .Columns.Add("Category", GetType(String))
            .Columns.Add("Type", GetType(String))
            .Columns.Add("FieldName", GetType(String))
        End With

        Grid1.DataSource = ds.Tables("SelectTb")

        With ds.Tables.Add("SelectTbDel")
            .Columns.Add("DelConditon", GetType(String))
            .Columns.Add("DelDisplay", GetType(String))
        End With
        Grid2.DataSource = ds.Tables("SelectTbDel")

    End Sub

    '導入指定模塊中需要查詢的字段信息
    Private Sub LoadTable()

        Dim Row As DataRow
        On Error Resume Next

        If TempA = "裝配退貨單" Then
            StrA = "退貨單號,生產工藝,產品編號,配件名稱,收入倉庫,操作日期,審核"
            StrB = "文字,文字,文字,文字,文字,日期,文字"
            StrC = "R_NO,Pro_Type,PM_M_Code,PM_Type,WH_InID,R_Date,R_Check"
        End If
        If TempA = "生產補退貨單" Then
            StrA = "補退貨單號,退貨單號,生產工藝,產品編號,配件名稱,收入倉庫,操作日期,審核"
            StrB = "文字,文字,文字,文字,文字,文字,日期,文字"
            StrC = "AR_NO,R_NO,Pro_Type,PM_M_Code,PM_Type,WH_InID,AR_Date,AR_Check"
        End If

        Dim StrAarray As Array = Split(StrA, ",")
        Dim StrBarray As Array = Split(StrB, ",")
        Dim StrCarray As Array = Split(StrC, ",")

        For i As Integer = 0 To UBound(StrAarray)

            Row = ds.Tables("SelectTb").NewRow
            Row("AutoID") = i
            Row("Category") = StrAarray(i)
            Row("Type") = StrBarray(i)
            Row("FieldName") = StrCarray(i)
            ds.Tables("SelectTb").Rows.Add(Row)
        Next i
    End Sub

    '載入產品編號信息
    Sub LoadPM_M_Code()

        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub

    '退回當前查詢模塊 
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    '添加新的文字類型的查詢條件
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click

        Dim row As DataRow

        Row = ds.Tables("SelectTbDel").NewRow

        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            If GridView1.GetFocusedRowCellValue("Category") = "生產工藝" Then
                row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Mid(Trim(ComboBoxEdit4.Text), 1, 4) + "'" + " "
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Mid(Trim(ComboBoxEdit4.Text), 1, 4) + "'"
            ElseIf GridView1.GetFocusedRowCellValue("Category") = "產品編號" Then
                row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Trim(PM_M_Code.EditValue) + "'" + " "
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(PM_M_Code.EditValue) + "'"
            ElseIf GridView1.GetFocusedRowCellValue("Category") = "審核" Then
                row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Trim(ComboBoxEdit5.Text) + "'" + " "
                Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(ComboBoxEdit5.Text) + "'"

            End If

        Else
            If GridView1.GetFocusedRowCellValue("Category") = "生產工藝" Then
                row("DelConditon") = " " & Mid(ComboBoxEdit3.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Mid(Trim(ComboBoxEdit4.Text), 1, 4) + " " + "'"
                row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Mid(Trim(ComboBoxEdit4.Text), 1, 4) + "'"
            ElseIf GridView1.GetFocusedRowCellValue("Category") = "產品編號" Then
                row("DelConditon") = " " & Mid(ComboBoxEdit3.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Trim(PM_M_Code.EditValue) + " " + "'"
                row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(PM_M_Code.EditValue) + "'"
            ElseIf GridView1.GetFocusedRowCellValue("Category") = "審核" Then
                row("DelConditon") = " " & Mid(ComboBoxEdit3.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Trim(ComboBoxEdit5.Text) + " " + "'"
                row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(ComboBoxEdit5.Text) + "'"
 
            End If
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
        TempB = ""
    End Sub

    '添加新的查詢條件信息
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If TextEdit2.Text = "" Then
            MsgBox("數據為空,不能添加!")
            Exit Sub
        End If
        Dim Row As DataRow
        Row = ds.Tables("SelectTbDel").NewRow
        If GridView1.GetFocusedRowCellValue("Category") = "物料名稱" Or GridView1.GetFocusedRowCellValue("Category") = "物料規格" Or GridView1.GetFocusedRowCellValue("Category") = "物料類型" Then
            Row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " like " + "'%" + Trim(TextEdit2.Text) + "%'" + " "
        Else
            Row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + Trim(TextEdit2.Text) + "'" + " "
        End If

        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(TextEdit2.Text) + "'"
        Else
            Row("DelDisplay") = Mid(Trim(ComboBoxEdit3.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + Trim(TextEdit2.Text) + "'"
        End If

        ds.Tables("SelectTbDel").Rows.Add(Row)
        TextEdit2.Text = ""
    End Sub
    '刪除當前Grid2當前選中行的查詢條件
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim i As Integer = ds.Tables("SelectTbDel").Rows.Count - 1
        ds.Tables("SelectTbDel").Rows.RemoveAt(i)

    End Sub
    '添加日期查詢
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim Row As DataRow

        Row = ds.Tables("SelectTbDel").NewRow
        Row("DelConditon") = " " & Mid(ComboBoxEdit3.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + "  " + Mid(Trim(ComboBoxEdit2.Text), 1, 3) + " " + "'" + DateEdit1.Text + "'" + " "
        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(ComboBoxEdit2.Text), 3) + " " + "'" + DateEdit1.Text + "'"
        Else
            Row("DelDisplay") = Mid(Trim(ComboBoxEdit3.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(ComboBoxEdit2.Text), 3) + " " + "'" + DateEdit1.Text + "'"
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        On Error Resume Next

        If GridView1.GetFocusedRowCellValue("Type") = "日期" Then
            XtraTabControl2.SelectedTabPageIndex = 1
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = True
            LabelControl3.Text = ""
        Else
            Dim tempC As String = "退貨單號,補退貨單號,收入倉庫,配件名稱"
            Dim Strarray As Array = Split(tempC, ",")
            For i As Integer = 0 To UBound(Strarray)
                If GridView1.GetFocusedRowCellValue("Category").ToString = Strarray(i) Then
                    SimpleButton7.Enabled = False
                    SimpleButton5.Enabled = True
                    TextEdit2.Enabled = True
                    TextEdit2.Focus()
                    ComboBoxEdit4.Visible = False
                    ComboBoxEdit5.Visible = False
                    PM_M_Code.Visible = False

                    Exit For
                Else

                    If GridView1.GetFocusedRowCellValue("Category").ToString = "生產工藝" Then
                        ComboBoxEdit4.Visible = True
                        ComboBoxEdit5.Visible = False
                        PM_M_Code.Visible = False
                    ElseIf GridView1.GetFocusedRowCellValue("Category").ToString = "產品編號" Then
                        ComboBoxEdit4.Visible = False
                        ComboBoxEdit5.Visible = False
                        PM_M_Code.Visible = True
                    ElseIf GridView1.GetFocusedRowCellValue("Category").ToString = "審核" Then
                        ComboBoxEdit4.Visible = False
                        ComboBoxEdit5.Visible = True
                        PM_M_Code.Visible = False
                    End If

                    TextEdit2.Enabled = False
                    SimpleButton5.Enabled = False
                    SimpleButton7.Enabled = True
                End If
            Next

            XtraTabControl2.SelectedTabPageIndex = 0
            XtraTabControl2.TabPages(0).PageEnabled = True
            XtraTabControl2.TabPages(1).PageEnabled = False
            LabelControl3.Text = "(" + GridView1.GetFocusedRowCellValue("Category") + ")"
        End If

    End Sub
End Class