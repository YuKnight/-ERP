Imports LFERP.DataSetting
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPieceWorkGroup

Imports LFERP.Library.ProductionPiecePayWGMain
Imports LFERP.Library.ProductionPiecePayWGSub
Imports LFERP.Library.ProductionPiecePayPersonnel


Public Class frmProductionPiecePayFind
    Dim Load_OK As String ''確定Load事件是否已載入完畢
    Dim Str_Choice As String

    Dim ds As New DataSet
    Dim dsF As New DataSet

    Private Sub frmProductionPiecePayPersonnelFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '加載廠別名稱
        Str_Choice = tempValue2
        GluG_NO.Text = tempValue8

        tempValue2 = Nothing
        tempValue8 = Nothing

        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        DatePL_YYMM.EditValue = Format(Now, "yyyy年MM月")

        If InStr(Str_Choice, "打印", CompareMethod.Text) > 0 Then
            btnFind.Text = "打印(&P)"
            GroupBox1.Text = "打印條件"
        Else
            btnFind.Text = "查詢(&F)"
            GroupBox1.Text = "查詢條件"
        End If

        If InStr(Str_Choice, "個人", CompareMethod.Text) > 0 Then '具體到個人  
            G_NO.FieldName = "Per_NO"
            G_Name.FieldName = "Per_Name"

            G_NO.Caption = "廠証編號"
            G_Name.Caption = "姓名"

            LabG_NO.Text = "廠証編號(&I)"
            GluG_NO.Properties.ValueMember = "Per_NO"
            GluG_NO.Properties.DisplayMember = "Per_NOName"

            If Str_Choice = "個人薪金查詢" Or Str_Choice = "個人薪金打印" Then
                ComboCheck.Text = "已審核"
            End If

        Else
            GluG_NO.Properties.ValueMember = "G_NO"
            GluG_NO.Properties.DisplayMember = "G_NOName"
        End If

        LabCaption.Text = Str_Choice
        Me.Text = Str_Choice

        lueFacID.Focus()
        lueFacID.Select()

        Load_OK = "OK"

        ''--------------------查詢時用戶權限------------------------
        If strInUserRank = "生產部" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "管理" Then
        ElseIf strInUserRank = "統計" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        If lueFacID.EditValue Is Nothing Then Exit Sub

        Dim dc As New DepartmentControler
        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub



    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        If lueFacID.EditValue Is Nothing Then
            tempValue3 = Nothing
        Else
            tempValue3 = lueFacID.EditValue
        End If

        If lueDepID.EditValue Is Nothing Then
            tempValue4 = Nothing
        Else
            tempValue4 = lueDepID.EditValue
        End If

        If GluG_NO.Text = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = GluG_NO.EditValue
        End If

        If DatePL_YYMM.EditValue Is Nothing Then
            tempValue6 = Nothing
        Else
            tempValue6 = Format(CDate(DatePL_YYMM.EditValue), "yyyy/MM")
        End If

        If ComboCheck.Text = "全部" Then
            tempValue7 = Nothing
        ElseIf ComboCheck.Text = "已審核" Then
            tempValue7 = "True"
        ElseIf ComboCheck.Text = "未審核" Then
            tempValue7 = "False"
        End If

        ''-----------------------------------------------------------------

        If InStr(Str_Choice, "查詢", CompareMethod.Text) > 0 Then
            tempValue = "F"
            Me.Close()
        ElseIf InStr(Str_Choice, "打印", CompareMethod.Text) > 0 Then

        Else
            Exit Sub
        End If

        Select Case Str_Choice
            Case "組別計件薪金打印"
                ''打印 組別計件工資
                ds.Tables.Clear()
                Dim ltc1 As New CollectionToDataSet
                Dim ltc2 As New CollectionToDataSet
                Dim ltc3 As New CollectionToDataSet


                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim WGppM As New LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainControl
                Dim WGppS As New LFERP.Library.ProductionPiecePayWGSub.ProductionPiecePayWGSubControl

                Dim strCompany As String
                strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

                ds.Tables.Clear()

                ltc1.CollToDataSet(ds, "ProductionPiecePayWGMain", WGppM.ProductionPiecePayWGMain_GetList(Nothing, Nothing, tempValue5, tempValue6, Nothing, Nothing, tempValue4, tempValue3, Nothing, Nothing, tempValue7))
                ltc2.CollToDataSet(ds, "ProductionPiecePayWGSub", WGppS.ProductionPiecePayWGSub_GetList(Nothing, Nothing, Nothing, Nothing))
                ltc3.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
                PreviewRPT(ds, "rptProductionPiecePayWG", "組別計件工資", True, True)

                ltc1 = Nothing
                ltc2 = Nothing
                ltc3 = Nothing

            Case "個人計件薪金打印"
                ds.Tables.Clear()
                Dim ltc1 As New CollectionToDataSet
                Dim ltc2 As New CollectionToDataSet

                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim Ppp As New LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelContol

                Dim strCompany As String
                strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

                ds.Tables.Clear()

                ltc1.CollToDataSet(ds, "ProductionPiecePayPersonnel", Ppp.ProductionPiecePayPersonnel_GetList(Nothing, tempValue5, Nothing, tempValue6, tempValue4, tempValue7, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue3, Nothing))
                ltc2.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
                PreviewRPT(ds, "RPTProductionPiecePayPersonnel", "個人計件工資", True, True)

                ltc1 = Nothing
                ltc2 = Nothing

            Case "個人薪金打印"

                Dim ltc1 As New CollectionToDataSet
                Dim ltc2 As New CollectionToDataSet
                Dim ltc3 As New CollectionToDataSet
                Dim ltc4 As New CollectionToDataSet
                Dim ltc5 As New CollectionToDataSet


                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim payp As New LFERP.Library.ProductionPayPersonnel.ProductionPayPersonnelContol
                Dim pppayp As New LFERP.Library.ProductionPiecePayPersonnel.ProductionPiecePayPersonnelContol
                Dim ppwgMain As New LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainControl
                Dim ppwgSub As New LFERP.Library.ProductionPiecePayWGSub.ProductionPiecePayWGSubControl

                Dim strCompany As String
                strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

                ds.Tables.Clear()

                If payp.ProductionPieceMeritedPaySum_View(tempValue6, tempValue4, tempValue3, tempValue5, tempValue7).Count <= 0 Then
                    MsgBox("指定條件內無記錄存在!")
                    Exit Sub
                End If

                ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
                ltc2.CollToDataSet(ds, "ProductionPayPersonnel", payp.ProductionPieceMeritedPaySum_View(tempValue6, tempValue4, tempValue3, tempValue5, tempValue7))
                ltc3.CollToDataSet(ds, "ProductionPiecePayPersonnel", pppayp.ProductionPiecePayPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue7, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

                ltc4.CollToDataSet(ds, "ProductionPiecePayWGMain", ppwgMain.ProductionPiecePayWGMain_GetList(Nothing, Nothing, Nothing, tempValue6, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue7))
                ltc5.CollToDataSet(ds, "ProductionPiecePayWGSub", ppwgSub.ProductionPiecePayWGSub_GetList(Nothing, Nothing, tempValue5, Nothing))

                ltc1 = Nothing
                ltc2 = Nothing
                ltc3 = Nothing
                ltc4 = Nothing
                ltc5 = Nothing

                PreviewRPT(ds, "rptProductionPayPersonnel", "個人計件工資", True, True)

        End Select

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged
        If lueDepID.EditValue Is Nothing Then Exit Sub

        If InStr(Str_Choice, "個人", CompareMethod.Text) > 0 Then
            Dim Pppp As New ProductionPiecePersonnelControl
            GluG_NO.Properties.DataSource = Pppp.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
        Else
            Dim Pppp As New ProductionPieceWorkGroupControl
            GluG_NO.Properties.DataSource = Pppp.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, Nothing, Nothing, Nothing, Nothing)

        End If
    End Sub

End Class