Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.DataSetting

Public Class frmProductionSalesReport

    Dim ds As New DataSet

    Sub LoadProductNo()  '產品編號

        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub

    Private Sub frmProductionSalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxEdit1.EditValue = "生產加工"
        ' DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        Me.DateEdit1.EditValue = Format(DateAdd(DateInterval.Day, -1, CDate(Now)), "yyyy/MM/dd")

        CreateTable()
        LoadProductNo()

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        GluType.Properties.ValueMember = "PM_Type"
        GluType.Properties.DisplayMember = "PM_Type"
        GluType.Properties.DataSource = ds.Tables("ProductType")


        ''-----------------------------------------

        With ds.Tables.Add("TFac")
            .Columns.Add("FacName", GetType(String))
            .Columns.Add("FacID", GetType(String))
            .Columns.Add("FacIDName", GetType(String))
        End With

        lueFacID.Properties.DisplayMember = "FacIDName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = ds.Tables("TFac")

        With ds.Tables.Add("TDep")
            .Columns.Add("DepName", GetType(String))
            .Columns.Add("DepID", GetType(String))
            .Columns.Add("FacName", GetType(String))
            .Columns.Add("DepIDName", GetType(String))
        End With

        lueDepID.Properties.DisplayMember = "DepIDName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = ds.Tables("TDep")

        Load_Fac()

    End Sub

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged

        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ds.Tables("ProductType").Clear()
        'If ComboBoxEdit1.EditValue = "" Then
        '    MsgBox("工藝類型不能為空!")
        '    Exit Sub
        'End If
        ppi = ppc.ProcessMain_GetList2(ComboBoxEdit1.EditValue, PM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow

                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)

            Next
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckBox1.Checked = True Then
            PrintOld()
        Else
            PrintNew()
        End If

        'Me.Close()
    End Sub


    Sub PrintOld()
        Dim dsP As New DataSet

        If ComboBoxEdit1.EditValue = "" Then
            MsgBox("工藝類型不能為空!")
            Exit Sub
        End If
        If PM_M_Code.EditValue = "" Then
            MsgBox("產品編號信息不能為空!")
            Exit Sub
        End If
        If GluType.EditValue = "" Then
            MsgBox("類型不能為空!")
            Exit Sub
        End If
        If DateEdit1.Text = "" Then
            MsgBox("日期信息部能為空!")
            Exit Sub
        End If

      

        Dim pdc As New ProductionFieldDaySummaryControl
        Dim pwc As New ProductionDPTWareInventoryControl

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        If pdc.ProductionFieldDaySummary_GetList1(ComboBoxEdit1.EditValue, PM_M_Code.EditValue, GluType.EditValue, Nothing, Nothing, Nothing, DateEdit1.Text, DateEdit1.Text).Count = 0 Then
            MsgBox("當前日期不存在在類型的生產數據記錄!")
            Exit Sub
        End If
        ltc.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList2(ComboBoxEdit1.EditValue, PM_M_Code.EditValue, GluType.EditValue, Nothing, Nothing, Nothing, DateEdit1.Text, DateEdit1.Text))

        'ltc1.CollToDataSet(ds, "ProductionDayDPTWareInventory", pwc.ProductionDayDPTWareInventory_GetList(Nothing, Nothing, DateEdit1.Text))

        Dim i As Long

        For i = 0 To ds.Tables("ProductionFieldDaySummary").Rows.Count - 1
            ds.Tables("ProductionFieldDaySummary").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPTDialog(ds, "rptProductDayDetail", "每日生產數據", True, True)

        ltc = Nothing
        ltc1 = Nothing


        
    End Sub


    Sub PrintNew()
        Dim dsP As New DataSet

        If ComboBoxEdit1.EditValue = "" Then
            MsgBox("工藝類型不能為空!")
            Exit Sub
        End If
        'If PM_M_Code.EditValue = "" Then
        '    MsgBox("產品編號信息不能為空!")
        '    Exit Sub
        'End If
        'If GluType.EditValue = "" Then
        '    MsgBox("類型不能為空!")
        '    Exit Sub
        'End If
        If DateEdit1.Text = "" Then
            MsgBox("日期信息部能為空!")
            Exit Sub
        End If

        If Format(CDate(DateEdit1.EditValue), "yyyy-MM-dd") = Format(Now, "yyyy-MM-dd") Then
            MsgBox("不能選擇當天日期!")
            Exit Sub
        End If

        'Dim pdc As New ProductionFieldDaySummaryControl
        'Dim pwc As New ProductionDPTWareInventoryControl

        'Dim ltc As New CollectionToDataSet
        'Dim ltc1 As New CollectionToDataSet

        'If pdc.ProductionFieldDaySummary_GetList1(ComboBoxEdit1.EditValue, PM_M_Code.EditValue, GluType.EditValue, Nothing, Nothing, Nothing, DateEdit1.Text, DateEdit1.Text).Count = 0 Then
        '    MsgBox("當前日期不存在在類型的生產數據記錄!")
        '    Exit Sub
        'End If
        'ltc.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList2(ComboBoxEdit1.EditValue, PM_M_Code.EditValue, GluType.EditValue, Nothing, Nothing, Nothing, DateEdit1.Text, DateEdit1.Text))

        ''ltc1.CollToDataSet(ds, "ProductionDayDPTWareInventory", pwc.ProductionDayDPTWareInventory_GetList(Nothing, Nothing, DateEdit1.Text))

        'Dim i As Long

        'For i = 0 To ds.Tables("ProductionFieldDaySummary").Rows.Count - 1
        '    ds.Tables("ProductionFieldDaySummary").Rows(i)("P_ID") = i + 1
        'Next

        'PreviewRPT(ds, "rptProductDayDetail", "每日生產數據", True, True)

        'ltc = Nothing
        'ltc1 = Nothing


        Dim strPM_Type As String = Nothing 'GluType
        Dim strFacID As String = Nothing 'lueFacID
        Dim strPM_M_Code As String = Nothing

        Dim strDateOld As String '選中日期前一天節余 (即每日表中的當天節余)
        Dim strDateNow As String '時實節余  (即每日表中的當天節余)
        Dim strDate As String '選中日期節余

        strDate = Format(CDate(DateEdit1.EditValue), "yyyy-MM-dd")
        strDateNow = Format(DateAdd(DateInterval.Day, 1, CDate(strDate)), "yyyy-MM-dd")
        strDateOld = Format(CDate(DateEdit1.EditValue), "yyyy-MM-dd")

        ' MsgBox(strDate & "---" & strDateNow & "-------" & strDateOld)

        If Me.PM_M_Code.EditValue = "" Then
            strPM_M_Code = Nothing
        Else
            strPM_M_Code = PM_M_Code.EditValue
        End If


        If GluType.EditValue = "" Then
            strPM_Type = Nothing
        Else
            strPM_Type = GluType.EditValue
        End If

        '------------------------------------------------------
        If lueFacID.EditValue = "" Or lueFacID.EditValue = "*" Then
            If lueDepID.EditValue = "" Or lueDepID.EditValue = "*" Then
                strFacID = Nothing
            Else
                strFacID = lueFacID.EditValue
            End If
        Else
            If lueDepID.EditValue = "" Or lueDepID.EditValue = "*" Then
                strFacID = Mid(lueFacID.EditValue, 1, 1)
            Else
                strFacID = Me.lueDepID.EditValue
            End If
        End If
        '----------------------------------------------------

        dsP.Tables.Clear()

        Dim pdc As New ProductionFieldDaySummaryControl
        Dim pwc As New ProductionDPTWareInventoryControl
        Dim pwc2 As New ProductionDPTWareInventoryControl

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet

        ' MsgBox(strFacID)

        If pdc.ProductionFieldDaySummary_GetList3(ComboBoxEdit1.EditValue, strPM_M_Code, Nothing, Nothing, strFacID, Nothing, strDate, strDate).Count = 0 Then
            MsgBox("當前日期不存在在類型的生產數據記錄!")
            Exit Sub
        End If



        ltc.CollToDataSet(dsP, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList3(ComboBoxEdit1.EditValue, strPM_M_Code, strPM_Type, Nothing, strFacID, Nothing, strDate, strDate))
        ltc1.CollToDataSet(dsP, "ProductionDayDPTWareInventory", pwc.ProductionDayDPTWareInventory_GetList(Nothing, Nothing, strDateOld))
        ltc2.CollToDataSet(dsP, "ProductionDPTWareInventory", pwc2.ProductionDayDPTWareInventory_GetList(Nothing, Nothing, strDateNow))

        Dim i As Long

        For i = 0 To dsP.Tables("ProductionFieldDaySummary").Rows.Count - 1
            dsP.Tables("ProductionFieldDaySummary").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPTDialog1(dsP, "rptProductionFieldDaySummary", "每日生產數據", Format(CDate(DateEdit1.EditValue), "yyyy年MM月dd日"), Format(CDate(DateEdit1.EditValue), "yyyy年MM月dd日"), True, True)

        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
    End Sub




    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Sub Load_Fac()
        ' 加載廠別名稱() 
        Dim fc As New FacControler
        Dim fcl As New List(Of FacInfo)
        Dim i As Integer

        fcl = fc.GetFacList(strInFacID, Nothing)

        If fcl.Count <= 0 Then Exit Sub

        ds.Tables("TFac").Clear()

        If strInFacID = Nothing Then
            Dim row As DataRow
            row = ds.Tables("TFac").NewRow
            row("FacName") = "全部"
            row("FacID") = "*"
            row("FacIDName") = "* 全部"
            ds.Tables("TFac").Rows.Add(row)
        End If

        For i = 0 To fcl.Count - 1
            Dim row1 As DataRow
            row1 = ds.Tables("TFac").NewRow
            row1("FacName") = fcl(i).FacName
            row1("FacID") = fcl(i).FacID
            row1("FacIDName") = fcl(i).FacID & " " & fcl(i).FacName
            ds.Tables("TFac").Rows.Add(row1)
        Next
    End Sub
    ''' <summary>
    ''' 固定查詢載入部門
    ''' </summary>
    ''' <remarks></remarks>
    Sub Load_Dep()
        ' 加載廠別名稱()
        Dim dc As New DepartmentControler
        Dim dil As New List(Of DepartmentInfo)
        Dim i As Integer

        If lueFacID.EditValue = "*" Then
            dil = dc.BriName_GetList(strInDepID, Nothing, Nothing)
        Else
            dil = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
        End If
        If dil.Count <= 0 Then Exit Sub

        ds.Tables("TDep").Clear()

        If strInDepID = Nothing Then
            Dim row As DataRow
            row = ds.Tables("TDep").NewRow
            row("DepName") = "全部"
            row("DepID") = "*"
            row("DepIDName") = "* 全部"
            ds.Tables("TDep").Rows.Add(row)
        End If

        For i = 0 To dil.Count - 1
            Dim row1 As DataRow
            row1 = ds.Tables("TDep").NewRow
            row1("DepName") = dil(i).DepName
            row1("DepID") = dil(i).DepID
            row1("FacName") = dil(i).FacName
            row1("DepIDName") = dil(i).DepID & " " & dil(i).DepName
            ds.Tables("TDep").Rows.Add(row1)
        Next

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Load_Dep()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            lueFacID.Enabled = False
            lueDepID.Enabled = False
        End If
    End Sub
End Class