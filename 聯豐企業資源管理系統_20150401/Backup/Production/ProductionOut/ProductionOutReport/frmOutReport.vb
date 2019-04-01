Imports LFERP.Library.ProductionOWPAcceptance
Imports LFERP.Library.ProductionOutProcess
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Public Class frmOutReport

    Dim ds As New DataSet

    Private Sub frmOutReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '載入供應商資料,加工類型資料
        LblCaptionType.Text = tempValue3
        tempValue3 = ""

        If LblCaptionType.Text = "88150401" Then
            '加工資料詳細查詢（外發加工記錄）
            LblCaption.Text = "外發加工記錄"

        ElseIf LblCaptionType.Text = "88150402" Then

            '供應商送貨資料查詢（外發加工返回記錄）
            LblCaption.Text = "外發加工返回記錄"
            LblDate.Text = "返回日期"

        ElseIf LblCaptionType.Text = "88150403" Then
            '未交回資料查詢（未完成外發加工資料）
            LblCaption.Text = "外發加工未完成記錄"
        End If

        CreateTable()

        'DateEditS.EditValue = Format(DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), "yyyy/MM/dd")
        'DateEditE.EditValue = Format(Now, "yyyy/MM/dd")
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged

        If PM_M_Code.EditValue <> "" Then
            Dim ppc As New ProcessMainControl
            GluType.Properties.ValueMember = "Type3ID"
            GluType.Properties.DisplayMember = "Type3ID"
            GluType.Properties.DataSource = ppc.ProcessMain_GetList2("生產加工", PM_M_Code.EditValue)
        End If

    End Sub


    Sub CreateTable()

        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        ''--------------------------------------------------------------------------------
        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim ds As New DataSet

        Dim strSupplier, strPM_M_Code, strType, strProcess, strDate1, strDate2 As String

        If gluSupplier.EditValue = "" Then
            strSupplier = Nothing
        Else
            strSupplier = gluSupplier.EditValue
        End If

        If PM_M_Code.EditValue = "" Then
            strPM_M_Code = Nothing
        Else
            strPM_M_Code = PM_M_Code.EditValue
        End If

        If GluType.EditValue = "" Then
            strType = Nothing
        Else
            strType = GluType.EditValue
        End If

        If GlookP_Name.EditValue = "" Then
            strProcess = Nothing
        Else
            strProcess = GlookP_Name.EditValue
        End If

        'If DateEditS.EditValue Is Nothing Or DateEditS.EditValue = "" Then
        '    strDate1 = Nothing
        'Else
        '    strDate1 = DateEditS.EditValue
        'End If

        'If DateEditE.EditValue Is Nothing Or DateEditE.EditValue = "" Then
        '    strDate2 = Nothing
        'Else
        '    strDate2 = DateEditE.EditValue
        'End If
        If DateEditS.EditValue <> Nothing Then
            strDate1 = DateEditS.EditValue
        Else
            strDate1 = Nothing
        End If

        If DateEditE.EditValue <> Nothing Then
            strDate2 = DateEditE.EditValue
        Else
            strDate2 = Nothing
        End If


        ds.Tables.Clear()

        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet

        Dim mcOutwardAcc As New ProductionOWPAcceptanceControl
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcOutProcess As New ProductionOutProcessControl
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim suc As New LFERP.SystemManager.SystemUser.SystemUserController
        Dim sui As List(Of LFERP.SystemManager.SystemUser.SystemUserInfo)
        Dim strCompany As String

        sui = suc.SystemUser_GetList(InUserID, Nothing, Nothing)
        strCompany = Mid(sui(0).DPT_ID, 1, 4)
        ds.Tables.Clear()


        If LblCaptionType.Text = "88150401" Then
            If mcOutProcess.ProductionOutProcess_GetList(Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, strDate1, strDate2, Nothing).Count <= 0 Then
                MsgBox("無外發加工信息存在!")
                Exit Sub
            End If '2012-7-25
            ltc3.CollToDataSet(ds, "ProductionOutProcess", mcOutProcess.ProductionOutProcess_GetList(Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, strDate1, strDate2, Nothing))
            ltc2.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
            PreviewRPT(ds, "rptProductionOutProcess", "外發加工信息", True, True)
            ltc3 = Nothing
            ltc2 = Nothing
        End If


        If LblCaptionType.Text = "88150402" Then
            If mcOutwardAcc.ProductionOWPAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, Nothing, Nothing, strDate1, strDate2, Nothing, Nothing).Count <= 0 Then
                MsgBox("無加工返回資料信息記錄存在!")
                Exit Sub
            End If

            ltc1.CollToDataSet(ds, "ProductionOWPAcceptance", mcOutwardAcc.ProductionOWPAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, Nothing, Nothing, strDate1, strDate2, Nothing, Nothing))
            ltc2.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "ProductionOutProcess", mcOutProcess.ProductionOutProcess_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc4.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))

            PreviewRPT(ds, "rptOutReturn", "加工返回資料信息", True, True)
            ltc1 = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
        End If

        If LblCaptionType.Text = "88150403" Then
            If mcOutProcess.ProductionOutProcess_GetList(Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, strDate1, strDate2, 1).Count <= 0 Then
                MsgBox("無外發加工未完成信息存在!")
                Exit Sub
            End If
            ltc3.CollToDataSet(ds, "ProductionOutProcess", mcOutProcess.ProductionOutProcess_GetList(Nothing, Nothing, Nothing, strPM_M_Code, strType, strProcess, strSupplier, strDate1, strDate2, 1))
            ltc2.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
            PreviewRPT(ds, "rptProductionOutNoComplete", "外發加工未完成信息", True, True)
            ltc3 = Nothing
            ltc2 = Nothing
        End If
        'Me.Close()
    End Sub


    Private Sub GluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluType.EditValueChanged
        ''
        If PM_M_Code.EditValue <> "" And GluType.EditValue <> "" Then
            GlookP_Name.Properties.DisplayMember = "PS_Name"
            GlookP_Name.Properties.ValueMember = "PS_NO"
            Dim pc As New ProcessMainControl
            GlookP_Name.Properties.DataSource = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, "生產加工", GluType.EditValue, Nothing, True)
        End If

    End Sub
End Class