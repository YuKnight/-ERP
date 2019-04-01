Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPieceWorkGroup


Public Class rptProductionSumPiece

    Dim Str_Choice As String ''組別計件查詢 還是 個人計件查詢
    Dim ds As New DataSet
    Private Sub ProductionSumPiecePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Str_Choice = tempValue
        tempValue = Nothing

        Start_Date.Text = Format(Now, "yyyy/MM/dd")
        End_Date.Text = Format(Now, "yyyy/MM/dd")

        CreateTable()

        Dim mc As New ProductController
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If Str_Choice = "P" Then
            Dim ptc As New ProductionPiecePersonnelControl  ''載入 員工編號---姓名---部門
            txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnel_GetList1(Nothing, strInDepID, Nothing, Nothing, "False", Nothing, Nothing, Nothing, Nothing)
            txtPer_NO.Properties.DisplayMember = "Per_Name"
            txtPer_NO.Properties.ValueMember = "Per_NO"
            Me.LabCaption.Text = "個人記件記錄"

        ElseIf Str_Choice = "G" Then ''組別計件打印

            'Per_DepName.Visible = False

            LabPer_NO.Text = "組別編號(&I):"

            Per_NO.Caption = "組別編號"
            Per_NO.FieldName = "G_NO"
            Per_Name.Caption = "組別名稱"
            Per_Name.FieldName = "G_Name"

            Per_DepName.FieldName = "G_DepName" 'G_DepName

            'Dim pc As New ProductionPieceWorkGroupControl
            'txtPer_NO.Properties.DisplayMember = "G_Name"
            'txtPer_NO.Properties.ValueMember = "G_NO"
            'txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)

            Me.LabCaption.Text = "組別記件記錄"
        End If

        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        lueFacID.Focus()
        lueFacID.Select()

        ''--------------------查詢時用戶權限------------------------
        If strInUserRank = "生產部" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "管理" Then
        ElseIf strInUserRank = "統計" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        '配件名稱表
        With ds.Tables.Add("ProductType")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
        End With

        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")

    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        If gluPM_M_Code.EditValue <> "" Then
            Dim pcc As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)

            pci = pcc.ProcessMain_GetList1(Nothing, gluPM_M_Code.EditValue, cboPro_Type.Text, Nothing)
            If pci.Count = 0 Then
                ds.Tables("ProductType").Clear()
            Else
                ds.Tables("ProductType").Clear()
                Dim i As Integer
                For i = 0 To pci.Count - 1
                    Dim row As DataRow
                    row = ds.Tables("ProductType").NewRow
                    row("M_Code") = pci(i).M_Code
                    row("PM_Type") = pci(i).Type3ID

                    ds.Tables("ProductType").Rows.Add(row)
                Next
            End If
        End If
    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ds As New DataSet

        Dim strPer_NO, strPro_Type, strPM_Type, strPM_M_Code, strFacID, strDepID, strStart_Date, strEnd_Date As String

        If txtPer_NO.EditValue Is Nothing Then
            strPer_NO = Nothing
        Else
            strPer_NO = txtPer_NO.EditValue
        End If

        If cboPro_Type.EditValue Is Nothing Then
            strPro_Type = Nothing
        Else
            strPro_Type = cboPro_Type.EditValue
        End If

        If gluPM_M_Code.EditValue Is Nothing Then
            strPM_M_Code = Nothing
        Else
            strPM_M_Code = gluPM_M_Code.EditValue
        End If

        If gluPM_Type.EditValue Is Nothing Then
            strPM_Type = Nothing
        Else
            strPM_Type = gluPM_Type.EditValue
        End If

        If lueFacID.EditValue Is Nothing Then
            strFacID = Nothing
        Else
            strFacID = lueFacID.EditValue
        End If

        If lueDepID.EditValue Is Nothing Then
            strDepID = Nothing
        Else
            strDepID = lueDepID.EditValue
        End If

        strStart_Date = Start_Date.EditValue
        strEnd_Date = End_Date.EditValue

        Dim strCompany As String

        strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO


        If Str_Choice = "P" Then

            ds.Tables.Clear()
            Dim ltc1 As New CollectionToDataSet
            Dim ltc2 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet

            Dim mcCompany As New LFERP.DataSetting.CompanyControler
            Dim PSPP As New LFERP.Library.ProductionSumPiecePersonnel.ProductionSumPiecePersonnelControl
            Dim PPP As New LFERP.Library.ProductionPieceProcess.ProductionPieceProcessControl

            ds.Tables.Clear()

            ltc1.CollToDataSet(ds, "ProductionSumPiecePersonnel", PSPP.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, strPer_NO, Nothing, strDepID, strFacID, strPro_Type, strPro_Type, strPM_Type, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, Nothing))
            ltc2.CollToDataSet(ds, "ProductionPieceProcess", PPP.ProductionPieceProcess_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))

            PreviewRPT(ds, "rptProductionSumPiecePersonnel", "個人計件匯總", True, True)

            ltc3 = Nothing
            ltc2 = Nothing
            ltc1 = Nothing

            Me.Close()

        End If


        ''''------組別計件打印--------------------------------------------------------


        If Str_Choice = "G" Then

            ds.Tables.Clear()
            Dim ltc1 As New CollectionToDataSet
            Dim ltc2 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet

            Dim mcCompany As New LFERP.DataSetting.CompanyControler
            Dim PSPWG As New LFERP.Library.ProductionSumPieceWorkGroup.ProductionSumPieceWorkGroupControl
            Dim PPP As New LFERP.Library.ProductionPieceProcess.ProductionPieceProcessControl

            ds.Tables.Clear()

            ltc1.CollToDataSet(ds, "ProductionSumPieceWorkGroup", PSPWG.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strPer_NO, strDepID, strFacID, strPro_Type, strPro_Type, strPM_Type, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, Nothing))
            ltc2.CollToDataSet(ds, "ProductionPieceProcess", PPP.ProductionPieceProcess_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, "MG", Nothing, Nothing))

            PreviewRPT(ds, "rptProductionSumPieceWorkGroup", "組別計件匯總", True, True)

            ltc3 = Nothing
            ltc2 = Nothing
            ltc1 = Nothing

            Me.Close()

        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged
        If lueDepID.EditValue Is Nothing Then Exit Sub

        If Str_Choice = "G" Then
            Dim pc As New ProductionPieceWorkGroupControl
            txtPer_NO.Properties.DisplayMember = "G_Name"
            txtPer_NO.Properties.ValueMember = "G_NO"
            txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, Nothing, Nothing, Nothing, Nothing)

        End If

    End Sub
End Class