Imports LFERP.Library.ProductionField
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.ProductionKaiLiao


Public Class frmProductionFieldMain

    Dim pfc As New ProductionFieldDaySummaryControl
    Dim psc As New ProductionScheduleControl

    Dim strType As String
    Dim strDate As String
    Dim strDate1 As String
    Dim strDate2 As String
    Dim IntDay As Integer


    '生產計劃數量

    '默認為生產工藝模式
    Private Sub frmProductionFieldMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If strType = "指定天數" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If

        Grid2.DataSource = Nothing

    End Sub
    '胚部工藝信息
    Private Sub cmdPeiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeiBu.Click
        If strType = "指定天數" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "胚部加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "胚部加工", Nothing, Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "胚部加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If

        Grid2.DataSource = Nothing
    End Sub
    '生產工藝信息
    Private Sub cmdShengChan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShengChan.Click
        If strType = "指定天數" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "生產加工", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If

        Grid2.DataSource = Nothing
    End Sub
    '裝配工藝信息
    Private Sub cmdZhuangPei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZhuangPei.Click
        If strType = "指定天數" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "裝配出貨", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "裝配出貨", Nothing, Nothing, Nothing, strDate1, strDate2)
        Else
            Grid1.DataSource = psc.ProductionSchedule_GetList2(Nothing, "裝配出貨", Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If

        Grid2.DataSource = Nothing
    End Sub
    '判定當前選中項目的生產明細
    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB, strC, strD As String

        strA = GridView1.GetFocusedRowCellValue("Pro_Type").ToString
        strB = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
        strC = GridView1.GetFocusedRowCellValue("PM_Type").ToString
        strD = GridView1.GetFocusedRowCellValue("FacName").ToString

        If strType = "指定天數" Then

            Grid2.DataSource = pfc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate)
        ElseIf strType = "日期範圍" Then
            Grid2.DataSource = pfc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, strDate1, strDate2)
        Else
            Grid2.DataSource = pfc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
        End If


    End Sub
    '查詢操作---自定義查詢各自工藝類型下部門生產狀況
    '@ 2012/1/6 添加判斷，不為空時執行
    Private Sub FieldMainSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldMainSelect.Click

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
    '列印部門的生產流程表---日期段內(默認一個星期)
    Private Sub FieldMainStatusPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldMainStatusPrint.Click

        If GridView1.RowCount = 0 Then Exit Sub



        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet


        Dim psc As New ProductionScheduleControl  '生產計劃
        Dim pkc As New ProductionKaiLiaoControl   '開料信息
        Dim pfc As New ProductionFieldControl  '物料收發信息
        Dim pdc As New ProductionFieldDaySummaryControl  '每天記錄信息

        ds.Tables.Clear()
        Dim strA, strB, strC, strD, strF As String
        strA = GridView1.GetFocusedRowCellValue("Pro_Type").ToString
        strB = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
        strC = GridView1.GetFocusedRowCellValue("PM_Type").ToString
        strD = GridView1.GetFocusedRowCellValue("FacName").ToString
        strF = GridView1.GetFocusedRowCellValue("PS_Dep").ToString


        If strType = "指定天數" Then
            '---------------------------------------------------------------------------------------導入臨時日期表
            Dim pdi As New ProductionFieldDaySummaryInfo


            pdi.Str1 = DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd")))
            pdi.Str2 = strDate

            pdc.Temp3_Add(pdi)

            MsgBox(DateAdd(DateInterval.Day, -IntDay, CDate(strDate)))

            If psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, DateAdd(DateInterval.Day, -IntDay, CDate(strDate)), strDate).Count = 0 Then
                MsgBox("當前日期範圍內無此生產計劃信息!")
                Exit Sub
            End If
            If pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃無開料信息!")
                Exit Sub
            End If
            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃中無物料收發記錄!")
                Exit Sub
            End If

            '---------------------------------------------------------------------------------------


            ltc.CollToDataSet(ds, "ProductionSchedule", psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate))
            ltc1.CollToDataSet(ds, "ProductionKaiLiao", pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing))
            ltc2.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), strDate))

        ElseIf strType = "日期範圍" Then
            '---------------------------------------------------------------------------------------導入臨時日期表
            Dim pdi As New ProductionFieldDaySummaryInfo


            pdi.Str1 = strDate1
            pdi.Str2 = strDate2

            pdc.Temp3_Add(pdi)
            '---------------------------------------------------------------------------------------

            If psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, strDate1, strDate2).Count = 0 Then
                MsgBox("當前日期範圍內無此生產計劃信息!")
                Exit Sub
            End If
            If pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃無開料信息!")
                Exit Sub
            End If
            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, strDate1, strDate2, Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃中無物料收發記錄!")
                Exit Sub
            End If


            ltc.CollToDataSet(ds, "ProductionSchedule", psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, strDate1, strDate2))
            ltc1.CollToDataSet(ds, "ProductionKaiLiao", pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing))
            ltc2.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, strDate1, strDate2, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, strDate1, strDate2))
        Else
            '---------------------------------------------------------------------------------------導入臨時日期表
            Dim pdi As New ProductionFieldDaySummaryInfo


            pdi.Str1 = DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd")))
            pdi.Str2 = Format(Now, "yyyy/MM/dd")

            pdc.Temp3_Add(pdi)
            '---------------------------------------------------------------------------------------
            If psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd"))).Count = 0 Then
                MsgBox("當前日期範圍內無此生產計劃信息!")
                Exit Sub
            End If
            If pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃無開料信息!")
                Exit Sub
            End If
            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內此生產計劃中無物料收發記錄!")
                Exit Sub
            End If


            ltc.CollToDataSet(ds, "ProductionSchedule", psc.ProductionSchedule_GetList2(Nothing, strA, strB, strC, strF, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd"))))
            ltc1.CollToDataSet(ds, "ProductionKaiLiao", pkc.ProductionKaiLiao_GetList(Nothing, strA, Nothing, Nothing, Nothing, strB, strC, Nothing, Nothing, True, Nothing))
            ltc2.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing))
            ltc3.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, Nothing, Nothing, strD, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd"))))

        End If
       

        ltc4.CollToDataSet(ds, "Temp3", pdc.Temp3_GetList(Nothing, Nothing))

        PreviewRPT(ds, "rptProductionProcess", "工藝生產流程表", True, True)


        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing

    End Sub

    '部門物料收發記錄---日期段內(默認一個星期)
    Private Sub cmsTransferInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsTransferInOut.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        Dim pfc As New ProductionFieldControl  '物料收發信息
        Dim pdc As New ProductionFieldDaySummaryControl  '每天記錄信息

        ds.Tables.Clear()
        Dim strA, strB, strC, strD, strE As String

        strA = GridView1.GetFocusedRowCellValue("Pro_Type").ToString
        strB = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
        strC = GridView1.GetFocusedRowCellValue("PM_Type").ToString
        strD = GridView2.GetFocusedRowCellValue("FP_OutDep").ToString
        strE = GridView2.GetFocusedRowCellValue("Pro_NO").ToString


        If strType = "指定天數" Then

            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內無此工序的物料收發記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, Format(Now.AddDays(-IntDay), "yyyy/MM/dd"), Format(Now, "yyyy/MM/dd"), Nothing, Nothing))
            ltc1.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, strE, strD, Nothing, DateAdd(DateInterval.Day, -IntDay, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd"))))

        ElseIf strType = "日期範圍" Then
            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, strDate1, strDate2, Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內無此工序的物料收發記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, strDate1, strDate2, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, strE, strD, Nothing, strDate1, strDate2))
        Else
            If pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, Format(Now.AddDays(-7), "yyyy/MM/dd"), Format(Now, "yyyy/MM/dd"), Nothing, Nothing).Count = 0 Then
                MsgBox("當前日期範圍內無此工序的物料收發記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, strA, strB, strC, strE, Nothing, Nothing, strD, Nothing, True, True, Format(Now.AddDays(-7), "yyyy/MM/dd"), Format(Now, "yyyy/MM/dd"), Nothing, Nothing))
            ltc1.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(strA, strB, strC, strE, strD, Nothing, DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd"))))
        End If

        PreviewRPT(ds, "rptProductionFieldSR", "部門詳細收發記錄", True, True)

        ltc = Nothing
        ltc1 = Nothing

    End Sub


End Class