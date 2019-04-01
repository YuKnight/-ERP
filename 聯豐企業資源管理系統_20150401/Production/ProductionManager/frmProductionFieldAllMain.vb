Imports LFERP.Library.Production.ProductionFieldDaySummary

Public Class frmProductionFieldAllMain

    Dim pfc As New ProductionFieldDaySummaryControl


    Dim strType As String   '區分指定日期或是指定天數
    Dim strDate As String   '臨時日期
    Dim strDate1 As String  '臨時日期
    Dim strDate2 As String  '臨時日期
    Dim IntDay As Integer   '天數
    Dim strProcess As String  '加工類型

    '默認情況下為生產加工/且日期範圍為7天
    Private Sub frmProductionFieldAllMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If strType = "指定天數" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, strDate1, strDate2)
        Else
            DateEdit1.Text = DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd")))
            DateEdit2.Text = CDate(Format(Now, "yyyy/MM/dd"))
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If
        strProcess = "生產加工"
        Grid2.DataSource = ""
    End Sub
    '胚部加工工藝生產完成狀況
    Private Sub cmdPeiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeiBu.Click
        If strType = "指定天數" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("胚部加工", Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("胚部加工", Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("胚部加工", Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If
        strProcess = "胚部加工"
        Grid2.DataSource = ""
    End Sub
    '生產加工工藝生產完成狀況
    Private Sub cmdShengChan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShengChan.Click
        If strType = "指定天數" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("生產加工", Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If
        strProcess = "生產加工"
        Grid2.DataSource = ""
    End Sub
    '裝配加工工藝生產完成狀況
    Private Sub cmdZhuangPei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZhuangPei.Click
        If strType = "指定天數" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("裝配出貨", Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("裝配出貨", Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList("裝配出貨", Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If
        strProcess = "裝配出貨"
        Grid2.DataSource = ""
    End Sub

    '查詢---針對查詢日期範圍定義
    '@ 2012/1/6 添加判斷，不為空時執行
    Private Sub FieldMainStripSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldMainStripSelect.Click
        Dim frm As New frmProductionMainSelect
        frm.ShowDialog()
        If tempValue <> "" And tempValue2 <> "" And tempValue3 <> "" Then '不為空時執行
            If frm.RadioButton1.Checked = True Then
                '指定天數查詢(距今天天數)
                strType = tempValue3
                strDate = tempValue2
                IntDay = CInt(tempValue)

            ElseIf frm.RadioButton2.Checked = True Then
                strType = tempValue3
                strDate1 = tempValue
                strDate2 = tempValue2
            End If

            cmdShengChan_Click(Nothing, Nothing)  '默認顯示生產加工工藝

            tempValue = ""
            tempValue2 = ""
            tempValue3 = ""
        End If
    End Sub

    '生產部詳細生產情況
    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp


        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB, strC As String

        strA = GridView1.GetFocusedRowCellValue("Pro_Type").ToString
        strB = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
        strC = GridView1.GetFocusedRowCellValue("PM_Type").ToString

        If strType = "指定天數" Then

            Grid2.DataSource = pfc.ProductionFieldDaySummary_FacGetList(strA, strB, strC, Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid2.DataSource = pfc.ProductionFieldDaySummary_FacGetList(strA, strB, strC, Nothing, Nothing, strDate1, strDate2)
        Else
            Grid2.DataSource = pfc.ProductionFieldDaySummary_FacGetList(strA, strB, strC, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If


    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        strType = "日期範圍"
        strDate1 = DateEdit1.Text
        strDate2 = DateEdit2.Text
        Grid1.DataSource = pfc.ProductionFieldDaySummary_ComGetList(strProcess, Nothing, Nothing, strDate1, strDate2)
    End Sub

End Class