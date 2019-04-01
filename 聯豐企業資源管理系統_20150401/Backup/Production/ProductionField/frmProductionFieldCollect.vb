Imports LFERP.Library.Product
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionField
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionFieldDaySummary

Public Class frmProductionFieldCollect
    Dim pdc As New ProductionFieldDaySummaryControl
    Dim mcCompany As New LFERP.DataSetting.CompanyControler
    Dim ds As New DataSet

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ds As New DataSet

        If lueFacID.EditValue Is Nothing Then
            MsgBox("請選擇廠別!")
            Exit Sub
        End If

        If lueDepID.EditValue Is Nothing Or lueDepID.Text = "" Then
            MsgBox("請選擇部門!")
            Exit Sub
        End If
  
        tempValue2 = lueDepID.EditValue

        If ComboBoxEditT.EditValue Is Nothing Or ComboBoxEditT.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = ComboBoxEditT.EditValue
        End If

        If PM_M_Code.EditValue Is Nothing Or PM_M_Code.EditValue = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = PM_M_Code.EditValue
        End If

        If GluType.EditValue Is Nothing Or GluType.EditValue = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = GluType.EditValue
        End If

        If GluEdit1.EditValue Is Nothing Or GluEdit1.EditValue = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = GluEdit1.EditValue
        End If

        tempValue7 = DateEdit1.EditValue
        tempValue8 = DateEdit2.EditValue

        Dim ltc As New CollectionToDataSet
        'Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim pfc As New ProductionFieldControl


        If Label1.Tag = "SFJL" Then
            If pfc.ProductionField_GetList2(Nothing, tempValue3, tempValue4, tempValue5, tempValue6, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, tempValue7, tempValue8, Nothing, Nothing, "True").Count <= 0 Then
                MsgBox("記錄不存在!", 64, "提示")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList2(Nothing, tempValue3, tempValue4, tempValue5, tempValue6, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, tempValue7, tempValue8, Nothing, Nothing, "True"))
            'ltc1.CollToDataSet(ds, "ProductionFieldDaySummary", pdc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, tempValue7, tempValue8))
            ltc2.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Mid(strInDPT_ID, 1, 4), Nothing, Nothing, Nothing))
            PreviewRPT(ds, "rptProductionFieldSR1", "部門物料收發記錄", True, True)
        ElseIf Label1.Tag = "LBJC" Then
            '查詢出pt06記錄
            Dim pfl As New List(Of ProductionFieldInfo)
            pfl = pfc.ProductionField_GetList2(Nothing, tempValue3, tempValue4, tempValue5, tempValue6, Nothing, Nothing, tempValue2, "PT06", True, True, tempValue7, tempValue8, Nothing, Nothing, "True")
            If pfl.Count <= 0 Then
                MsgBox("記錄不存在!", 64, "提示")
                Exit Sub
            End If

            Dim strDate As String
            strDate = Format(CDate(DateEdit1.EditValue), "yyyy-MM-dd") & "至" & Format(CDate(DateEdit2.EditValue), "yyyy-MM-dd")

            ltc.CollToDataSet(ds, "ProductionField", pfl)
            PreviewRPT1(ds, "rptProductionFieldLBJC", "留辦加存清單", strDate, UserName, True, True)

        Else
            If pfc.ProductionField_GetList2(Nothing, tempValue3, tempValue4, tempValue5, tempValue6, Nothing, Nothing, tempValue2, Nothing, True, True, tempValue7, tempValue8, Nothing, Nothing, "True").Count <= 0 Then
                MsgBox("記錄不存在!", 64, "提示")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList2(Nothing, tempValue3, tempValue4, tempValue5, tempValue6, Nothing, Nothing, tempValue2, Nothing, True, True, tempValue7, tempValue8, Nothing, Nothing, "True"))

            PreviewRPT1(ds, "rptProductionFieldDetail", "生產收發明細", tempValue7, tempValue8, True, True)
        End If

        ltc = Nothing

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        'Me.Close()

    End Sub



    Private Sub frmProductionFieldCollect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        'Dim mc As New ProcessMainControl
        'PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        'PM_M_Code.Properties.ValueMember = "PM_M_Code"
        'PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

        ''2013-10-18產品動態增加
        With ds.Tables.Add("PM_M_Code")
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))
        End With
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = ds.Tables("PM_M_Code")


        DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
        DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")

        lueFacID.Select()
        lueFacID.EditValue = strInFacIDFull
        lueDepID.EditValue = strInDepIDFull

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        Dim ppc As New ProcessMainControl
        GluType.Properties.DataSource = ppc.ProcessMain_GetList2(ComboBoxEditT.EditValue, PM_M_Code.EditValue)
        GluType.Properties.DisplayMember = "Type3ID"
        GluType.Properties.ValueMember = "Type3ID"

        GluType.Text = ""
        GluEdit1.Properties.DataSource = Nothing
        GluEdit1.Text = ""
    End Sub

    Private Sub GluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluType.EditValueChanged

        Dim pc As New ProcessMainControl

        GluEdit1.Properties.DataSource = (pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, ComboBoxEditT.EditValue, GluType.EditValue, Nothing, True))
        GluEdit1.Properties.ValueMember = "PS_NO"
        GluEdit1.Properties.DisplayMember = "PS_Name"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub lueFacID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueFacID.KeyDown, lueDepID.KeyDown, PM_M_Code.KeyDown, GluType.KeyDown, GluEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub ComboBoxEditT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEditT.SelectedIndexChanged
        PM_M_Code_EditValueChanged(Nothing, Nothing)
    End Sub

    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged
        'If lueDepID.EditValue Is Nothing Then Exit Sub
        LoadPM_M_Code(Me.lueDepID.EditValue)
    End Sub

    Sub LoadPM_M_Code(ByVal strGluDep As String)
        Dim mi As New List(Of LFERP.Library.Production.Datasetting.ProductionDataSettingInfo)
        Dim mc As New LFERP.Library.Production.Datasetting.ProductionDataSettingControl
        mi = mc.ProductionUser_GetList(strGluDep, Nothing)

        ds.Tables("PM_M_Code").Clear()

        If mi.Count > 0 Then    '判斷是否有權限限制
            Dim row As DataRow
            Dim j As Integer
            For j = 0 To mi.Count - 1
                row = ds.Tables("PM_M_Code").NewRow
                row("PM_M_Code") = mi(j).PM_M_Code
                row("PM_JiYu") = mi(j).PM_JiYu '
                ds.Tables("PM_M_Code").Rows.Add(row)
            Next
        Else
            Dim row As DataRow
            Dim j As Integer

            Dim mpi As New List(Of ProcessMainInfo)
            Dim mpc As New ProcessMainControl
            mpi = mpc.ProcessMain_GetList3(Nothing, Nothing)

            If mpi.Count > 0 Then
                For j = 0 To mpi.Count - 1
                    row = ds.Tables("PM_M_Code").NewRow
                    row("PM_M_Code") = mpi(j).PM_M_Code
                    row("PM_JiYu") = mpi(j).PM_JiYu '
                    ds.Tables("PM_M_Code").Rows.Add(row)
                Next
            End If

        End If
    End Sub
End Class