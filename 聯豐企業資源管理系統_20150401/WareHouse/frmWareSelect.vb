
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class frmWareSelect

    Dim ds As New DataSet
    Dim mtc As New Material.MaterialTypeController
    Dim TempA As String, TempB As String
    Dim StrA As String, StrB As String, StrC As String
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Len(bteWH_ID.Text) = 3 Then
            MsgBox("請選擇正確的倉庫!")
            Exit Sub

        End If
        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            If RadioButton1.Checked = True Then
                If ComboBoxEdit1.Text = "入庫單號" Or ComboBoxEdit1.Text = "出庫單號" Or ComboBoxEdit1.Text = "調拔單號" Or ComboBoxEdit1.Text = "借刀單號" Or ComboBoxEdit1.Text = "還刀單號" Then
                    tempValue = 1
                ElseIf ComboBoxEdit1.Text = "物料編號" Then
                    tempValue = 2

                ElseIf ComboBoxEdit1.Text = "物料名稱" Or ComboBoxEdit1.Text = "借刀流水號" Or ComboBoxEdit1.Text = "還刀流水號" Then
                    tempValue = 4
                End If
                tempValue2 = TextEdit1.Text.Trim
            End If

            If RadioButton2.Checked = True Then '物料類別
                tempValue = 3
                tempValue2 = PopupContainerEdit1.Text.Trim
            End If
            tempValue4 = bteWH_ID.Text.Trim
        Else
            If ds.Tables("SelectTbDel").Rows.Count = 0 Then
                MsgBox("查詢條件為空,請添加后再確定!", , "提示")
                Exit Sub
            End If
            tempValue = 6
            tempValue2 = ""
            For i As Integer = 0 To ds.Tables("SelectTbDel").Rows.Count - 1
                tempValue2 = tempValue2 & ds.Tables("SelectTbDel").Rows(i)("DelConditon").ToString
            Next

            '@2012/12/21 修改 當自定義樣式查詢中沒有查詢倉庫名稱時，默認為查詢固定樣式中選中的倉庫名稱
            If TempA = "入庫作業" Or TempA = "出庫作業" Then
                If InStr(tempValue2, "WH_ID") <= 0 Then
                    tempValue2 = tempValue2 & " And WH_ID='" & bteWH_ID.Text.Trim & "'"
                End If
            ElseIf TempA = "調拔作業" Then
                If InStr(tempValue2, "DepotNO") <= 0 Then
                    tempValue2 = tempValue2 & " And DepotNO='" & bteWH_ID.Text.Trim & "'"
                End If
            End If
        End If


        'MsgBox(tempValue2)

        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub FrmpurSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bteWH_ID.Text = tempValue4
        tempValue4 = ""
        TempA = tempValue
        tempValue = ""

        ComboBoxEdit3.SelectedIndex = 0
        XtraTabControl1.SelectedTabPageIndex = 0
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")

        mtc.LoadNodes(Tv1, ErpUser.MaterialType)
        PopupContainerEdit1.Enabled = False


        CreateTable()
        LoadTable()
        TextEdit1.Focus()

        ''2013-4-15
        If TempA = "借刀作業" Then
            ComboBoxEdit1.Properties.Items.Clear()
            ComboBoxEdit1.Properties.Items.Add("借刀單號")
            ComboBoxEdit1.Properties.Items.Add("借刀流水號")
            ComboBoxEdit1.Properties.Items.Add("物料編號")
            ComboBoxEdit1.Text = "物料編號"
            PopupContainerEdit1.Visible = False
            RadioButton2.Visible = False
        End If

        If TempA = "還刀作業" Then
            ComboBoxEdit1.Properties.Items.Clear()
            ComboBoxEdit1.Properties.Items.Add("還刀單號")
            ComboBoxEdit1.Properties.Items.Add("還刀流水號")
            ComboBoxEdit1.Properties.Items.Add("物料編號")
            ComboBoxEdit1.Text = "物料編號"
            PopupContainerEdit1.Visible = False
            RadioButton2.Visible = False
        End If


    End Sub
    Private Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("SelectTb")
            .Columns.Add("AutoID", GetType(Integer))
            .Columns.Add("Category", GetType(String))
            .Columns.Add("Type", GetType(String))
            .Columns.Add("FieldName", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("SelectTb")

        With ds.Tables.Add("SelectTbDel")
            .Columns.Add("DelConditon", GetType(String))
            .Columns.Add("DelDisplay", GetType(String))
        End With
        GridControl2.DataSource = ds.Tables("SelectTbDel")
    End Sub
    Private Sub LoadTable()
        Dim Row As DataRow
        On Error Resume Next

        If TempA = "入庫作業" Then
            StrA = "入庫單號,物料編碼,物料名稱,物料規格,物料類別,入庫日期,部門審核,會計審核,單位,倉庫名稱,數量,備注"
            StrB = "文字,文字,文字,文字,文字,日期,文字,文字,文字,文字,數字,文字"
            StrC = "WIP_ID,MaterialCode.M_Code,M_Name,MaterialCode.M_Gauge,MaterialCode.Type3ID,WIP_AddDate,WIP_Check,WIP_ReCheck,MaterialCode.M_Unit,WH_ID,WIP_Qty,WIP_Remark"
        End If
        If TempA = "出庫作業" Then
            StrA = "出庫單號,物料編碼,物料名稱,物料規格,物料類別,申領單號,出庫日期,申領部門,領料工號,領料人姓名,部門審核,會計審核,單位,倉庫名稱,數量,備注"
            StrB = "文字,文字,文字,文字,文字,文字,日期,文字,文字,文字,文字,文字,文字,文字,數字,文字"
            StrC = "WO_ID,MaterialCode.M_Code,M_Name,MaterialCode.M_Gauge,MaterialCode.Type3ID,AP_NO,WO_AddDate,DPT_ID,WO_PerID,WO_PerName,WO_Check,WO_ReCheck,MaterialCode.M_Unit,WH_ID,WO_Qty,WO_Remark"
        End If
        If TempA = "調拔作業" Then
            StrA = "調拔單號,物料編碼,物料名稱,物料規格,物料類別,調撥日期,部門審核,單位,倉庫名稱,數量,備注"
            StrB = "文字,文字,文字,文字,文字,日期,文字,文字,文字,數字,文字"
            StrC = "MV_NO,M_Code,M_Name,M_Gauge,M_Code,MV_Date,MV_Check,M_Unit,DepotNO,MV_Qty,MV_Remark"
        End If

        '2013-4-12
        If TempA = "借刀作業" Then
            StrA = "借刀單號,借刀流水號,刀具編碼,借刀人,部門,借出日期,操作人"
            StrB = "文字,文字,文字,文字,文字,日期,文字"
            StrC = "WB_NO,WB_NUM,M_Code,WB_PerID,DPT_ID,WB_Date,WB_Action"
        End If

        If TempA = "還刀作業" Then
            StrA = "還刀單號,還刀流水號,刀具編碼,還刀人,代還刀人,部門,還刀日期,操作人"
            StrB = "文字,文字,文字,文字,文字,文字,日期,文字"
            StrC = "WB_NO,WB_NUM,M_Code,WB_PerID,RR_PerID,DPT_ID,WB_Date,WB_Action"
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

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim fr As New frmWareSelectCondition
        Dim Row As DataRow
        tempValue = GridView1.GetFocusedRowCellValue("Category")
        fr.ShowDialog()
        TempB = tempValue2
        tempValue2 = ""
        If TempB = "" Then Exit Sub
        Row = ds.Tables("SelectTbDel").NewRow
        If GridView1.GetFocusedRowCellValue("Category") = "物料類別" Then
            Row("DelConditon") = "  " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + "  " + GridView1.GetFocusedRowCellValue("FieldName") + " Like " + "'%" + TempB + "%'" + " "
        ElseIf GridView1.GetFocusedRowCellValue("Category") = "未交數" Then
            Row("DelConditon") = "  " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + "  " + GridView1.GetFocusedRowCellValue("FieldName") + " " + TempB + " "
        Else
            Row("DelConditon") = "  " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + "  " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + TempB + "'" + " "
        End If

        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + TempB + "'"
        Else
            Row("DelDisplay") = Mid(Trim(ComboBoxEdit3.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + TempB + "'"
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
        TempB = ""
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        On Error Resume Next

        If GridView1.GetFocusedRowCellValue("Type") = "日期" Then
            XtraTabControl2.SelectedTabPageIndex = 1
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = True
            XtraTabControl2.TabPages(2).PageEnabled = False
            LabelControl3.Text = ""
            TextEdit2.Enabled = False
            bteWHID.Enabled = False
        ElseIf GridView1.GetFocusedRowCellValue("Category") = "倉庫名稱" Then    '@2012/12/21 自定義樣式查詢中添加倉庫名稱查詢
            TextEdit2.Visible = False
            bteWHID.Enabled = True
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = False
            XtraTabControl2.TabPages(2).PageEnabled = False
            SimpleButton5.Enabled = True
            LabelControl3.Text = "(" + GridView1.GetFocusedRowCellValue("Category") + ")"
        ElseIf GridView1.GetFocusedRowCellValue("Type") = "數字" Then
            XtraTabControl2.SelectedTabPageIndex = 2
            XtraTabControl2.TabPages(0).PageEnabled = False
            XtraTabControl2.TabPages(1).PageEnabled = False
            XtraTabControl2.TabPages(2).PageEnabled = True
            LabelControl3.Text = ""
            TextEdit2.Enabled = False
            bteWHID.Enabled = False
        Else
            Dim tempC As String = "入庫單號,出庫單號,調拔單號,庫存管理,物料名稱,物料規格,物料編碼,領料工號,申領單號,領料人姓名,單位,備注"
            Dim Strarray As Array = Split(tempC, ",")
            For i As Integer = 0 To UBound(Strarray)
                If GridView1.GetFocusedRowCellValue("Category").ToString = Strarray(i) Then
                    SimpleButton7.Enabled = False
                    SimpleButton5.Enabled = True
                    TextEdit2.Enabled = True
                    TextEdit2.Focus()
                    Exit For
                Else
                    TextEdit2.Enabled = False
                    SimpleButton5.Enabled = False
                    SimpleButton7.Enabled = True
                End If
            Next
            TextEdit2.Visible = True
            XtraTabControl2.SelectedTabPageIndex = 0
            XtraTabControl2.TabPages(0).PageEnabled = True
            XtraTabControl2.TabPages(1).PageEnabled = False
            XtraTabControl2.TabPages(2).PageEnabled = False
            LabelControl3.Text = "(" + GridView1.GetFocusedRowCellValue("Category") + ")"
        End If

    End Sub

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

    Private Sub Tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Tv1.AfterSelect
        PopupContainerEdit1.EditValue = Tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub


    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click

        ComboBoxEdit1.Enabled = True
        TextEdit1.Enabled = True

        PopupContainerEdit1.Enabled = False
        PopupContainerEdit1.Text = ""

      
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click

        ComboBoxEdit1.Enabled = False
        TextEdit1.Enabled = False
        TextEdit1.Text = ""

        PopupContainerEdit1.Enabled = True


    End Sub

    Private Sub RadioButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ComboBoxEdit1.Enabled = False
        TextEdit1.Enabled = False
        TextEdit1.Text = ""

        PopupContainerEdit1.Enabled = False
        PopupContainerEdit1.Text = ""

    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim i As Integer = ds.Tables("SelectTbDel").Rows.Count - 1
        ds.Tables("SelectTbDel").Rows.RemoveAt(i)

    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Dim strTemp As String
        Dim strTemp1 As String

        If TextEdit2.Text = "" And bteWHID.Text = "" Then
            MsgBox("數據為空,不能添加!")
            Exit Sub
        End If

        If GridView1.GetFocusedRowCellValue("Category") = "倉庫名稱" Then
            strTemp = Trim(bteWHID.Tag)
            strTemp1 = Trim(bteWHID.Text)
        Else
            strTemp = Trim(TextEdit2.Text)
            strTemp1 = Trim(TextEdit2.Text)
        End If

        Dim Row As DataRow
        Row = ds.Tables("SelectTbDel").NewRow
        If GridView1.GetFocusedRowCellValue("Category") = "物料名稱" Or GridView1.GetFocusedRowCellValue("Category") = "物料規格" Or GridView1.GetFocusedRowCellValue("Category") = "物料類別" Or GridView1.GetFocusedRowCellValue("Category") = "備注" Then
            Row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " like " + "'%" + strTemp + "%'" + " "
        Else
            Row("DelConditon") = " " & Mid(Trim(ComboBoxEdit3.Text), 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + " = " + "'" + strTemp + "'" + " "
        End If

        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + strTemp1 + "'"
        Else
            Row("DelDisplay") = Mid(Trim(ComboBoxEdit3.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " = " + "'" + strTemp1 + "'"
        End If

        ds.Tables("SelectTbDel").Rows.Add(Row)
        TextEdit2.Text = ""
        bteWHID.Tag = ""
        bteWHID.Text = ""
    End Sub


    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage.Text = "固定樣式" Then
            TextEdit1.Focus()
        Else
            TextEdit2.Focus()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBoxEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            PopupContainerEdit1.Focus()
        End If
    End Sub

    '@2012/12/21 添加
    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteWH_ID.ButtonClick
        Dim fr As New frmWareHouseSelect

        ErpUser.WareHouseList = Nothing
        tempValue3 = ""

        fr.ShowDialog()

        If fr.SelectWareID <> "" Then
            bteWH_ID.Text = fr.SelectWareID
        End If
        ErpUser.WareHouseList = "'W01','W02'"

    End Sub

    '@2012/12/21 添加
    Private Sub bteWHID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteWHID.ButtonClick
        Dim fr As New frmWareHouseSelect

        ErpUser.WareHouseList = Nothing
        tempValue3 = ""

        fr.ShowDialog()

        If fr.SelectWareID <> "" Then
            bteWHID.Tag = fr.SelectWareID
            bteWHID.Text = fr.SelectWareUpName & "-" & fr.SelectWareName
        End If
        ErpUser.WareHouseList = "'W01','W02'"
    End Sub

    '@ 2013/3/18 添加
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim Row As DataRow

        Row = ds.Tables("SelectTbDel").NewRow
        Row("DelConditon") = " " & Mid(ComboBoxEdit3.Text, 1, 3) + " " + GridView1.GetFocusedRowCellValue("FieldName") + "  " + Mid(Trim(cboLogic.Text), 1, 3) + " " + "'" + txtQty.Text.Trim + "'" + " "
        If ds.Tables("SelectTbDel").Rows.Count = 0 Then
            Row("DelDisplay") = GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(cboLogic.Text), 3) + " " + "'" + txtQty.Text.Trim + "'"
        Else
            Row("DelDisplay") = Mid(Trim(ComboBoxEdit3.Text), 1, 4) + GridView1.GetFocusedRowCellValue("Category") + " " + Mid(Trim(cboLogic.Text), 3) + " " + "'" + txtQty.Text.Trim + "'"
        End If
        ds.Tables("SelectTbDel").Rows.Add(Row)
    End Sub
End Class